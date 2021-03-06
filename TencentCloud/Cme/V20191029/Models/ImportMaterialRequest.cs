/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportMaterialRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台名称，指定访问的平台。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 媒体归属者，团队或个人。
        /// </summary>
        [JsonProperty("Owner")]
        public Entity Owner{ get; set; }

        /// <summary>
        /// 媒体名称，不能超过30个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 导入媒资类型，取值：
        /// <li>VOD：云点播文件；</li>
        /// <li>EXTERNAL：媒资绑定。</li>
        /// 注意：如果不填默认为云点播文件。
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 云点播媒资 FileId，仅当 SourceType 为 VOD 时有效。
        /// </summary>
        [JsonProperty("VodFileId")]
        public string VodFileId{ get; set; }

        /// <summary>
        /// 原始媒资文件信息，当 SourceType 取值 EXTERNAL 的时候必填。
        /// </summary>
        [JsonProperty("ExternalMediaInfo")]
        public ExternalMediaInfo ExternalMediaInfo{ get; set; }

        /// <summary>
        /// 媒体分类路径，形如："/a/b"，层级数不能超过10，每个层级长度不能超过15字符。若不填则默认为根路径。
        /// </summary>
        [JsonProperty("ClassPath")]
        public string ClassPath{ get; set; }

        /// <summary>
        /// 媒体预处理任务模板 ID。取值：
        /// <li>10：进行编辑预处理。</li>
        /// </summary>
        [JsonProperty("PreProcessDefinition")]
        public long? PreProcessDefinition{ get; set; }

        /// <summary>
        /// 操作者。填写用户的 Id，用于标识调用者及校验操作权限。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "VodFileId", this.VodFileId);
            this.SetParamObj(map, prefix + "ExternalMediaInfo.", this.ExternalMediaInfo);
            this.SetParamSimple(map, prefix + "ClassPath", this.ClassPath);
            this.SetParamSimple(map, prefix + "PreProcessDefinition", this.PreProcessDefinition);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

