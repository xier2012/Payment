﻿using Essensoft.AspNetCore.Payment.WeChatPay.V3.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Request
{
    /// <summary>
    /// 合单查询订单API（电商平台、服务商、直连商户）
    /// 最新更新时间：2020.03.27
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter5_1_11.shtml
    /// </summary>
    public class WeChatPayCombineTransactionsOutTradeNoRequest : IWeChatPayGetRequest<WeChatPayCombineTransactionsOutTradeNoResponse>
    {
        /// <summary>
        /// 合单商户订单号
        /// 合单支付总订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一 。
        /// 示例值：P20150806125346
        /// </summary>
        public string CombineOutTradeNo { get; set; }

        public string GetRequestUrl()
        {
            return $"https://api.mch.weixin.qq.com/v3/combine-transactions/out-trade-no/{CombineOutTradeNo}";
        }
    }
}
