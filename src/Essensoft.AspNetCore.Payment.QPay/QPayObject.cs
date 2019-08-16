﻿using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay
{
    /// <summary>
    /// QPay 基础对象。
    /// </summary>
    public abstract class QPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [XmlIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 原始参数
        /// </summary>
        [XmlIgnore]
        public QPayDictionary Parameters { get; internal set; }

        /// <summary>
        /// 处理 _$n
        /// </summary>
        internal virtual void Execute() { }
    }
}
