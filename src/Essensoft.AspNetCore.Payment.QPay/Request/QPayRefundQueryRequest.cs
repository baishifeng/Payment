using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.QPay.Response;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    /// <summary>
    /// 退款查询
    /// </summary>
    public class QPayRefundQueryRequest : IQPayRequest<QPayRefundQueryResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 子商户应用ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// QQ钱包退款单号
        /// </summary>
        public string RefundId { get; set; }

        /// <summary>
        /// 商户退款单号
        /// </summary>
        public string OutRefundNo { get; set; }

        /// <summary>
        /// QQ钱包订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://qpay.qq.com/cgi-bin/pay/qpay_refund_query.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "appid", AppId },
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
                { "refund_id", RefundId },
                { "out_refund_no", OutRefundNo },
                { "transaction_id", TransactionId },
                { "out_trade_no", OutTradeNo }
            };
            return parameters;
        }

        public bool IsCheckResponseSign()
        {
            return true;
        }

        #endregion
    }
}
