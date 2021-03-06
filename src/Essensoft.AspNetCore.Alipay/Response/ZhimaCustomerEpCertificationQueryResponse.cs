using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// ZhimaCustomerEpCertificationQueryResponse.
    /// </summary>
    public class ZhimaCustomerEpCertificationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 认证不通过的原因
        /// </summary>
        [JsonProperty("failed_reason")]
        public string FailedReason { get; set; }

        /// <summary>
        /// 认证是否通过，通过为true，不通过为false
        /// </summary>
        [JsonProperty("passed")]
        public string Passed { get; set; }
    }
}
