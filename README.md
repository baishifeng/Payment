![Payment](https://raw.githubusercontent.com/Essensoft/Payment/master/images/Payment-Title.png)

## 简介

Payment 是基于 .NET Core / ASP.NET Core 开发，支持多商户的跨平台支付SDK集。
简化了API调用及相关通知的处理流程。

## Package

Package  | NuGet 
-------- | :------------ 
Essensoft.AspNetCore.Payment.Alipay         | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.Alipay.svg)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Alipay)
Essensoft.AspNetCore.Payment.WeChatPay      | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.WeChatPay.svg)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.WeChatPay)
Essensoft.AspNetCore.Payment.QPay           | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.QPay.svg)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.QPay)
Essensoft.AspNetCore.Payment.JDPay		    | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.JDPay.svg)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.JDPay)
Essensoft.AspNetCore.Payment.LianLianPay    | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.LianLianPay.svg)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.LianLianPay)
Essensoft.AspNetCore.Payment.UnionPay       | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.UnionPay.svg)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.UnionPay)
Essensoft.AspNetCore.Payment.Security       | [![NuGet](https://img.shields.io/nuget/v/Essensoft.AspNetCore.Payment.Security.svg)](https://www.nuget.org/packages/Essensoft.AspNetCore.Payment.Security)

## 交流方式
* [Payment QQ交流群: 522457525](https://shang.qq.com/wpa/qunwpa?idkey=aac56c8f02f54893267d3ac90787c1794a7687f3c31a923812a36b67c4ee6271)

## 支持渠道

### 支付宝

* 当面付、APP支付、手机网站支付、电脑网站支付、单笔转账到支付宝账户...

### 微信支付

* 付款码支付(刷卡)、JSAPI支付(公众号)、Native支付(扫码)、APP支付、H5支付、小程序支付、企业付款(零钱/银行卡)、现金红包、酒店押金

### QQ钱包

* 付款码支付、扫码支付、公众号支付、APP支付、企业付款

### 京东支付
* 网页支付、APP支付、扫一扫、付款码、代付

### 连连支付
* 网银支付、银行卡支付、掌上银行支付、实时付款

### 银联支付
* 在线网关支付、无跳转支付、手机支付控件、手机网页支付（WAP支付）、二维码支付(商户)

## 官方文档

* [支付宝-蚂蚁金服-文档中心](https://docs.open.alipay.com/catalog)

* [微信支付-开发文档](https://pay.weixin.qq.com/wiki/doc/api/index.html)

* [QQ钱包商户平台-开发文档](https://qpay.qq.com/buss/qpaywiki.shtml)

* [京东支付文档](http://payapi.jd.com)

* [连连支付开放平台](http://open.lianlianpay.com)

* [银联支付-中国银联技术开放平台-产品API](https://open.unionpay.com/tjweb/api/list?tagId=20)

## 开发环境
* Windows 10
* VS2017 15.9.3
* .NET Core 2.2、.NET Core 2.1

## 运行环境
* .NET Core 2.1+

## 使用方式

* [配置参数(支持多商户)](docs/Configuration.md)

* [配置HttpClient(支持API证书)](docs/Using-HttpClient.md)

* [查看示例项目](samples/WebApplicationSample)

----

---

## 致谢

[Varorbc](https://github.com/Varorbc)
