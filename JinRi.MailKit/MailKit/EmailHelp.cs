


using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace JinRi.MailKits
{
    /// <summary>
    /// 邮件帮助类
    /// </summary>
    public class EmailHelp
    {
        #region //获取配置文件
        private const string pop3Host = "mail.jinri.cn";
        private const int pop3Port = 993;
        private const string smtpHost = "smtp.jinri.cn";
        private const int smtpPort = 25;
        private const string mailFromName = "hulei";
        private const string mailFrom = "hulei@jinri.cn";
        private const string mailTo = "hulei@jinri.cn";
        private const string mailToName = "清明正直雨上";
        private const string mailFromAccount = "hulei@jinri.cn";
        private const string mailPassword = "hl@123";
        private const string path = @"..\..\MailKitExample.png";


        /// <summary>
        /// Smtp服务器地址 发件服务器
        /// </summary>
        private static readonly string SmtpServer = ConfigurationManager.AppSettings["SmtpServer"];

        /// <summary>
        /// SMTP端口 发件
        /// </summary>
        private static readonly int SmtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);

        /// <summary>
        /// Pop服务器地址 
        /// </summary>
        private static readonly string PopServer = ConfigurationManager.AppSettings["PopServer"];

        /// <summary>
        /// POP端口
        /// </summary>
        private static readonly int PopPort = int.Parse(ConfigurationManager.AppSettings["PopPort"]);

        /// <summary>
        /// Imap服务器地址
        /// </summary>
        private static readonly string ImapServer = ConfigurationManager.AppSettings["ImapServer"];


        /// <summary>
        /// IMAP端口
        /// </summary>
        private static readonly int ImapPort = int.Parse(ConfigurationManager.AppSettings["ImapPort"]);


        #endregion

        #region  send MimeMessage 

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="mailFromAccount">发送邮箱账号</param>
        /// <param name="mailPassword">发送邮箱密码</param>
        /// <param name="message">邮件</param>
        public static void SendEmali(string mailFromAccount, string mailPassword, MimeMessage message)
        {
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                ////为了演示目的，接受所有的SSL证书（如果服务器支持STARTTLS）
                //client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                //建立一个指定的邮件服务器的连接。如果客户端应该将SSL包连接到服务器，则为true，
                client.Connect(SmtpServer, SmtpPort, false);
                // 注：因为我们没有一个oauth2令牌，禁用
                // xoauth2认证机制。
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                // 注：仅在SMTP服务器需要身份验证时才需要
                client.Authenticate(mailFromAccount, mailPassword);
                client.Send(message);
                //断开服务器
                client.Disconnect(true);
            }
        }



        /// <summary>
        /// 创建文本消息
        /// </summary>
        /// <param name="fromAddress">发件地址</param>
        /// <param name="toAddressList">收件地址</param>
        /// <param name="title">标题</param>
        /// <param name="content">内容</param>
        /// <param name="IsPostFiles">是否将POST上传文件加为附件</param>
        /// <returns></returns>
        public static MimeMessage CreateTextMessage(MailboxAddress fromAddress, IList<MailboxAddress> toAddressList
            , string title, string content, bool IsPostFiles = false)
        {
            var message = new MimeMessage();
            message.From.Add(fromAddress);
            message.To.AddRange(toAddressList);
            message.Subject = title; //设置消息的主题
            TextPart plain = new TextPart("plain")
            {
                Text = content,
            };
            //var html = new TextPart("html")
            //{
            //    Text = content,
            //};

            var alternative = new Multipart("alternative")
            {
                plain
            };
            var multipart = new Multipart("mixed")
            {
                alternative
            };

            if (IsPostFiles)
            {
                IList<MimePart> multiPartList = GetMimePartList();
                foreach (var item in multiPartList)
                {
                    multipart.Add(item);
                }
            }
            message.Body = multipart;
            return message;
        }



        /// <summary>
        /// .NET的SmtpClient 机制创建邮件
        /// </summary>   
        private static void CreateNewSmtpClient()
        {
            MailMessage mymail = new MailMessage()
            {
                From = new MailAddress(mailFrom)
            };
            mymail.To.Add(mailTo);
            mymail.Subject = string.Format("C#自动发送邮件测试 From geffzhang TO {0}", mailTo);
            mymail.Body = @"<p>Hey geffzhang<br><p>不好意思，我在测试程序，刚才把QQ号写错了，Sorry！<br><p>-- Geffzhang<br>";
            //mymail.IsBodyHtml = true;
            mymail.Attachments.Add(new Attachment(path));
            SmtpClient smtpclient = new System.Net.Mail.SmtpClient()
            {
                Port = smtpPort,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Host = smtpHost,
                EnableSsl = false,
                Credentials = new System.Net.NetworkCredential(mailFromAccount, mailPassword)
            };
            try
            {
                smtpclient.Send(mymail);
                Console.WriteLine("发送成功");
            }
            catch (Exception ex)
            {
                Console.WriteLine("发送邮件失败.请检查是否为qq邮箱，并且没有被防护软件拦截" + ex);
            }
        }




        #endregion

        #region //其它类


        /// <summary>
        /// 收邮件
        /// </summary>
        /// <param name="mailFromAccount">发送邮箱账号</param>
        /// <param name="mailPassword">发送邮箱密码</param>
        /// <param name="searchQuery">查询条件</param>
        /// <param name="folderName">文件夹名称</param>
        /// <returns></returns>
        public static IList<IMessageSummary> ReceiveEmail(string mailFromAccount, string mailPassword, string folderName, SearchQuery searchQuery = null)
        {
            //打开收件箱
            var folder = OpenFolder(mailFromAccount, mailPassword, folderName);

            //IList<OrderBy> orderByList = new List<OrderBy> { OrderBy.Date };
            //查询所有的邮件
            var uidss = folder.Search(searchQuery);

            IList<IMessageSummary> msgList = new List<IMessageSummary>();
            if (uidss.Count > 0)//判断是否查询到邮件
            {
                //获取邮件头
                msgList = folder.Fetch(uidss, MessageSummaryItems.UniqueId | MessageSummaryItems.Full);
            }
            folder.Close();
            return msgList;
        }


        /// <summary>
        /// 根据唯一号查询信件
        /// </summary>
        /// <param name="mailFromAccount">邮箱账号</param>
        /// <param name="mailPassword">邮箱密码</param>
        /// <param name="id">唯一号</param>
        /// <param name="folderName">文件夹名称</param>
        /// <returns></returns>
        public static MimeMessage GetEmailByUniqueId(string mailFromAccount, string mailPassword, uint id, string folderName)
        {
            //打开收件箱
            var folder = OpenFolder(mailFromAccount, mailPassword, folderName);
            UniqueId emailUniqueId = new UniqueId(id);
            MimeMessage message = folder.GetMessage(emailUniqueId);
            /*将邮件设为已读*/
            MessageFlags flags = MessageFlags.Seen;
            folder.SetFlags(emailUniqueId, flags, true);
            return message;
        }


        /// <summary>
        /// 打开邮箱文件夹
        /// </summary>
        /// <param name="mailFromAccount">邮箱账号</param>
        /// <param name="mailPassword">邮箱密码</param>
        /// <param name="folderName">文件夹名称(INBOX:收件箱名称)</param>
        /// <returns></returns>
        public static IMailFolder OpenFolder(string mailFromAccount, string mailPassword, string folderName)
        {
            ImapClient client = new ImapClient();
            client.Connect(ImapServer, ImapPort);
            client.Authenticate(mailFromAccount, mailPassword);
            //获取所有文件夹
            //List<IMailFolder> mailFolderList = client.GetFolders(client.PersonalNamespaces[0]).ToList();
            var folder = client.GetFolder(folderName);

            //打开文件夹并设置为读的方式
            folder.Open(MailKit.FolderAccess.ReadWrite);
            return folder;
        }



        /// <summary>
        /// 读取上传的文件
        /// </summary>
        /// <returns></returns>
        public static IList<MimePart> GetMimePartList()
        {
            IList<MimePart> mimePartList = new List<MimePart>();
            var current = HttpContext.Current;
            if (current != null)
            {
                HttpRequest request = current.Request;
                HttpFileCollection files = request.Files;
                int filesCount = files.Count;
                for (int i = 0; i < filesCount; i++)
                {
                    HttpPostedFile item = files[i];
                    MimePart attachment = new MimePart(item.ContentType)
                    {
                        ContentObject = new ContentObject(item.InputStream, ContentEncoding.Default),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = item.FileName
                    };

                    mimePartList.Add(attachment);
                }
            }
            return mimePartList;
        }

        /// <summary>
        /// 下载邮件附件
        /// </summary>
        /// <param name="mimePart"></param>
        public static void DownFile(MimePart mimePart)
        {
            HttpContext context = HttpContext.Current;

            // 设置编码和附件格式
            context.Response.ContentType = mimePart.ContentType.ToString();
            //context.Response.ContentEncoding = Encoding.UTF8;

            context.Response.Charset = "";
            string fileName = HttpUtility.UrlEncode(mimePart.FileName, Encoding.UTF8);
            context.Response.AppendHeader("Content-Disposition",
                "attachment;filename=" + fileName);
            using (MemoryStream ms = new MemoryStream())
            {
                mimePart.ContentObject.DecodeTo(ms);
                ms.Flush();
                ms.Position = 0;
                context.Response.BinaryWrite(ms.GetBuffer());
                context.Response.End();
            }
        }
        #endregion
    }
}
