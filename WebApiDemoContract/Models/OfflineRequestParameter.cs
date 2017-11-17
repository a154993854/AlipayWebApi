﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDemoContract.Models
{
    public class OfflineRequestParameter
    {
        /// <summary>
        /// 必选
        /// 商户订单号,64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        public string out_trade_no { get; set; }
        /// <summary>
        /// 必选
        /// 支付场景 
        /// 条码支付，取值：bar_code
        /// 声波支付，取值：wave_code
        /// </summary>
        public string scene { get; set; }
        /// <summary>
        /// 必选
        /// 支付授权码，25~30开头的长度为16~24位的数字，实际字符串长度以开发者获取的付款码长度为准
        /// </summary>
        public string auth_code { get; set; }
        /// <summary>
        /// 可选
        /// 销售产品码
        /// </summary>
        public string product_code { get; set; }
        /// <summary>
        /// 必选
        /// 订单标题
        /// </summary>
        public string subject { get; set; }
        /// <summary>
        /// 可选
        /// 买家的支付宝用户id，如果为空，会从传入了码值信息中获取买家ID
        /// </summary>
        public string buyer_id { get; set; }
        /// <summary>
        /// 可选
        /// 如果该值为空，则默认为商户签约账号对应的支付宝用户ID
        /// </summary>
        public string seller_id { get; set; }
        /// <summary>
        /// 可选
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000] 
        ///如果同时传入【可打折金额】和【不可打折金额】，该参数可以不用传入； 
        ///如果同时传入了【可打折金额】，【不可打折金额】，【订单总金额】三者，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】
        /// </summary>
        public Double total_amount { get; set; }
        /// <summary>
        /// 可选
        /// 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。 
        /// 如果该值未传入，但传入了【订单总金额】和【不可打折金额】，则该值默认为【订单总金额】-【不可打折金额】
        /// </summary>
        public double discountable_amount { get; set; }
        /// <summary>
        /// 可选
        /// 订单描述
        /// </summary>
        public string body { get; set; }
        /// <summary>
        /// 可选
        /// 订单包含的商品列表信息，Json格式，其它说明详见商品明细说明
        /// </summary>
        public List<Goods_detail> Goods_detail;
        /// <summary>
        /// 可选
        /// 商户操作员编号
        /// </summary>
        public string operator_id { get; set; }
        /// <summary>
        /// 可选
        /// 商店门店编号
        /// </summary>
        public string store_id { get; set; }
        /// <summary>
        /// 商户机终端号
        /// </summary>
        public string terminal_id { get; set; }
        /// <summary>
        /// 可选
        /// 业务扩展参数
        /// </summary>
        public List<ExtendParams> extend_params;
        /// <summary>
        /// 可选
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m
        /// </summary>
        public string timeout_express { get; set; }
    }
}