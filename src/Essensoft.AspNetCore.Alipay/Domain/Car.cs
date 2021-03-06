using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// Car Data Structure.
    /// </summary>
    public class Car : AlipayObject
    {
        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonProperty("car_engine_no")]
        public string CarEngineNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonProperty("car_frame_no")]
        public string CarFrameNo { get; set; }

        /// <summary>
        /// 品牌型号
        /// </summary>
        [JsonProperty("car_model_code")]
        public string CarModelCode { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 该车辆数据来源，1 来自 ISV，2来自保险师内部数据
        /// </summary>
        [JsonProperty("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 初次登记日期
        /// </summary>
        [JsonProperty("first_register_date")]
        public string FirstRegisterDate { get; set; }

        /// <summary>
        /// 天津地区行驶证地址
        /// </summary>
        [JsonProperty("license_address")]
        public string LicenseAddress { get; set; }

        /// <summary>
        /// 是否过户车
        /// </summary>
        [JsonProperty("transfer_car")]
        public string TransferCar { get; set; }

        /// <summary>
        /// 过户日期
        /// </summary>
        [JsonProperty("transfer_date")]
        public string TransferDate { get; set; }

        /// <summary>
        /// 所有需要报价机构对应的精友码
        /// </summary>
        [JsonProperty("vehicle_info_list")]
        public List<VehicleInfo> VehicleInfoList { get; set; }

        /// <summary>
        /// 天津地区行驶证车辆类型
        /// </summary>
        [JsonProperty("vehicle_type")]
        public string VehicleType { get; set; }
    }
}
