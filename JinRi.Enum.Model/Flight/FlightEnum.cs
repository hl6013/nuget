using System.ComponentModel;

namespace JinRi.Enum.Flight
{
    /// <summary>
    /// 飞机相关的枚举
    /// </summary>
    public class FlightEnum
    {
        #region 飞机
        /// <summary>
        /// 舱位等级
        /// </summary>
        public enum CabinClass
        {
            /// <summary>
            /// 所有舱位
            /// </summary>
            [Description("所有舱位")]
            A = 0,
            /// <summary>
            /// 经济舱
            /// </summary>
            [Description("经济舱")]
            Y = 1,
            /// <summary>
            /// 公务舱
            /// </summary>
            [Description("公务舱")]
            C = 2,
            /// <summary>
            /// 头等舱    
            /// </summary>
            [Description("头等舱")]
            F = 3,
            /// <summary>
            /// 超级经济舱    
            /// </summary>
            [Description("超级经济舱")]
            S = 4
        }

        /// <summary>
        /// 舱位
        /// </summary>
        public enum CabinLevel
        {
            /// <summary>
            /// A
            /// </summary>
            [Description("A")]
            A,
            /// <summary>
            /// B
            /// </summary>
            [Description("B")]
            B,
            /// <summary>
            /// C
            /// </summary>
            [Description("C")]
            C,
            /// <summary>
            /// D
            /// </summary>
            [Description("D")]
            D,
            /// <summary>
            /// E
            /// </summary>
            [Description("E")]
            E,
            /// <summary>
            /// F
            /// </summary>
            [Description("F")]
            F,
            /// <summary>
            /// G
            /// </summary>
            [Description("G")]
            G,
            /// <summary>
            /// H
            /// </summary>
            [Description("H")]
            H,
            /// <summary>
            /// I
            /// </summary>
            [Description("I")]
            I,
            /// <summary>
            /// J
            /// </summary>
            [Description("J")]
            J,
            /// <summary>
            /// K
            /// </summary>
            [Description("K")]
            K,
            /// <summary>
            /// L
            /// </summary>
            [Description("L")]
            L,
            /// <summary>
            /// M
            /// </summary>
            [Description("M")]
            M,
            /// <summary>
            /// N
            /// </summary>
            [Description("N")]
            N,
            /// <summary>
            /// O
            /// </summary>
            [Description("O")]
            O,
            /// <summary>
            /// P
            /// </summary>
            [Description("P")]
            P,
            /// <summary>
            /// Q
            /// </summary>
            [Description("Q")]
            Q,
            /// <summary>
            /// R
            /// </summary>
            [Description("R")]
            R,
            /// <summary>
            /// S
            /// </summary>
            [Description("S")]
            S,
            /// <summary>
            /// T
            /// </summary>
            [Description("T")]
            T,
            /// <summary>
            /// U
            /// </summary>
            [Description("U")]
            U,
            /// <summary>
            /// V
            /// </summary>
            [Description("V")]
            V,
            /// <summary>
            /// W
            /// </summary>
            [Description("W")]
            W,
            /// <summary>
            /// X
            /// </summary>
            [Description("X")]
            X,
            /// <summary>
            /// Y
            /// </summary>
            [Description("Y")]
            Y,
            /// <summary>
            /// Z
            /// </summary>
            [Description("Z")]
            Z
        }

        /// <summary>
        /// 机型大小
        /// </summary>
        public enum CraftWidthType
        {
            /// <summary>
            /// 无机型大小
            /// </summary>
            [Description("无")]
            None = 0,
            /// <summary>
            /// 配送
            /// </summary>
            [Description("大")]
            Big = 1,
            /// <summary>
            /// 上门
            /// </summary>
            [Description("中")]
            Mid = 2,
            /// <summary>
            /// 上门
            /// </summary>
            [Description("小")]
            Small = 3
        }
        #endregion

        #region 行程
        /// <summary>
        /// 航程/政策类型
        /// </summary>
        public enum FlightType
        {
            /// <summary>
            /// 单程
            /// </summary>
            [Description("单程")]
            OW = 1,
            /// <summary>
            /// 往返
            /// </summary>
            [Description("往返")]
            RT = 2,
            /// <summary>
            /// 多程
            /// </summary>
            [Description("多程")]
            MT = 3
        }

        /// <summary>
        /// 航班类型
        /// </summary>
        public enum FlightTripType
        {
            /// <summary>
            /// 国内始发
            /// </summary>
            [Description("国内始发")]
            InlandArr = 1,
            /// <summary>
            /// 直飞soto
            /// </summary>
            [Description("直飞soto")]
            FlightSoto = 2,
            /// <summary>
            /// 国内始发add-on
            /// </summary>
            [Description("国内始发add-on")]
            InlandArrAddon = 3,
            /// <summary>
            /// 国外始发add-on
            /// </summary>
            [Description("国外始发add-on")]
            ForeignArrAddon = 4,
            /// <summary>
            /// 境外到境外
            /// </summary>
            [Description("境外到境外")]
            OutOfCountry = 5,
            /// <summary>
            /// 国内始发中转
            /// </summary>
            [Description("国内始发中转")]
            InternalTransfer = 6,
            /// <summary>
            /// 国外始发中转
            /// </summary>
            [Description("国外始发中转")]
            ForeignArrTransfer = 7,
            /// <summary>
            /// 境外境外境外
            /// </summary>
            [Description("境外境外境外")]
            OutOfCountryTransfer = 8,
            /// <summary>
            /// 境外境内境外
            /// </summary>
            [Description("境外境内境外")]
            OutsideTerritory = 9,
            /// <summary>
            /// 全球到全球
            /// </summary>
            [Description("全球到全球")]
            GlobalToGlobal = 10,
            /// <summary>
            /// 全球中转全球
            /// </summary>
            [Description("全球中转全球")]
            GlobalTransit = 11
        }


        /// <summary>
        /// 航班来源
        /// </summary>
        public enum FlightSource
        {
            /// <summary>
            /// 单程
            /// </summary>
            [Description("携程")]
            Ctrip = 1,
            /// <summary>
            /// 途牛
            /// </summary>
            [Description("途牛")]
            Tuniu = 2,
            /// <summary>
            /// 今通
            /// </summary>
            [Description("今通")]
            JinRi = 3,
            /// <summary>
            /// 517
            /// </summary>
            [Description("517")]
            _517na = 4,
            /// <summary>
            /// 不夜城
            /// </summary>
            [Description("不夜城")]
            NoNight = 5,
            /// <summary>
            /// 淘宝
            /// </summary>
            [Description("淘宝")]
            Taobao = 6,
            /// <summary>
            /// 去哪儿
            /// </summary>
            [Description("去哪儿")]
            quNar = 7,
            /// <summary>
            /// 同城
            /// </summary>
            [Description("同城")]
            ly = 8,
            /// <summary>
            /// eTerm
            /// </summary>
            [Description("eTerm")]
            eTerm = 9,
        }
        #endregion

    }
}
