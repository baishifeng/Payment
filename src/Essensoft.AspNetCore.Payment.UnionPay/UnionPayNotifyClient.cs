﻿using System;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.UnionPay.Parser;
using Essensoft.AspNetCore.Payment.UnionPay.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    public class UnionPayNotifyClient : IUnionPayNotifyClient
    {
        private readonly ILogger _logger;
        private readonly IOptionsSnapshot<UnionPayOptions> _optionsSnapshotAccessor;

        #region UnionPayNotifyClient Constructors

        public UnionPayNotifyClient(
            ILogger<UnionPayNotifyClient> logger,
            IOptionsSnapshot<UnionPayOptions> optionsAccessor)
        {
            _logger = logger;
            _optionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        #region IUnionPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : UnionPayNotify
        {
            return await ExecuteAsync<T>(request, null);
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request, string optionsName) where T : UnionPayNotify
        {
            var options = _optionsSnapshotAccessor.Get(optionsName);
            var parameters = await GetParametersAsync(request);

            var query = UnionPayUtility.BuildQuery(parameters);
            _logger.Log(options.LogLevel, "Request:{query}", query);

            var parser = new UnionPayDictionaryParser<T>();
            var rsp = parser.Parse(parameters);
            CheckNotifySign(parameters, options);
            return rsp;
        }

        #endregion

        #region Common Method

        private async Task<UnionPayDictionary> GetParametersAsync(HttpRequest request)
        {
            var parameters = new UnionPayDictionary();
            var form = await request.ReadFormAsync();
            foreach (var iter in form)
            {
                parameters.Add(iter.Key, iter.Value);
            }
            return parameters;
        }

        private void CheckNotifySign(UnionPayDictionary dictionary, UnionPayOptions options)
        {
            if (dictionary == null || dictionary.Count == 0)
            {
                throw new UnionPayException("sign check fail: sign is Empty!");
            }

            var ifValidateCNName = !options.TestMode;
            if (!UnionPaySignature.Validate(dictionary, options.RootCertificate.cert, options.MiddleCertificate.cert, options.SecureKey, ifValidateCNName))
            {
                throw new UnionPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}
