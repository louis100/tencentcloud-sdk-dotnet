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

namespace TencentCloud.Ams.V20200608
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ams.V20200608.Models;

   public class AmsClient : AbstractClient{

       private const string endpoint = "ams.tencentcloudapi.com";
       private const string version = "2020-06-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 取消任务
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public async Task<CancelTaskResponse> CancelTask(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 取消任务
        /// </summary>
        /// <param name="req"><see cref="CancelTaskRequest"/></param>
        /// <returns><see cref="CancelTaskResponse"/></returns>
        public CancelTaskResponse CancelTaskSync(CancelTaskRequest req)
        {
             JsonResponseModel<CancelTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（Audio Moderation）用于提交音频内容（包括音频文件或流地址）进行智能审核任务，使用前请您登陆控制台开通音频内容安全服务。
        /// 
        /// ### 功能使用说明：
        /// - 前往“内容安全控制台-音频内容安全”开启使用音频内容安全服务，首次开通可获得20小时免费调用时长
        /// 
        /// ### 接口功能说明：
        /// - 支持对音频流或音频文件进行检测，判断其中是否包含违规内容；
        /// - 支持设置回调地址 Callback 获取检测结果，或通过接口(查询音频检测结果)主动轮询获取检测结果；
        /// - 支持识别违规内容，包括：低俗、谩骂、色情、涉政、广告等场景；
        /// - 支持批量提交检测任务。检测任务列表最多支持10个；
        /// 
        /// ### 音频文件调用说明：
        /// - 音频文件大小支持：文件 < 500M；
        /// - 音频文件时长支持：< 1小时；
        /// - 音频码率类型支持：128 Kbps - 256 Kbps ；
        /// - 音频文件支持格式：wav、mp3、aac、flac、amr、3gp、 m4a、wma、ogg、ape；
        /// - 支持音视频文件分离并对音频文件进行独立识别；
        /// 
        /// ### 音频流调用说明：
        /// - 音频流时长支持：< 3小时；
        /// - 音频码率类型支持：128 Kbps - 256 Kbps ；
        /// - 音频流支持的传输协议：RTMP、HTTP、HTTPS；
        /// - 音频流格式支持的类型：rtp、srtp、rtmp、rtmps、mmsh、 mmst、hls、http、tcp、https、m3u8；
        /// - 支持音视频流分离并对音频流进行独立识别；
        /// </summary>
        /// <param name="req"><see cref="CreateAudioModerationTaskRequest"/></param>
        /// <returns><see cref="CreateAudioModerationTaskResponse"/></returns>
        public async Task<CreateAudioModerationTaskResponse> CreateAudioModerationTask(CreateAudioModerationTaskRequest req)
        {
             JsonResponseModel<CreateAudioModerationTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAudioModerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAudioModerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（Audio Moderation）用于提交音频内容（包括音频文件或流地址）进行智能审核任务，使用前请您登陆控制台开通音频内容安全服务。
        /// 
        /// ### 功能使用说明：
        /// - 前往“内容安全控制台-音频内容安全”开启使用音频内容安全服务，首次开通可获得20小时免费调用时长
        /// 
        /// ### 接口功能说明：
        /// - 支持对音频流或音频文件进行检测，判断其中是否包含违规内容；
        /// - 支持设置回调地址 Callback 获取检测结果，或通过接口(查询音频检测结果)主动轮询获取检测结果；
        /// - 支持识别违规内容，包括：低俗、谩骂、色情、涉政、广告等场景；
        /// - 支持批量提交检测任务。检测任务列表最多支持10个；
        /// 
        /// ### 音频文件调用说明：
        /// - 音频文件大小支持：文件 < 500M；
        /// - 音频文件时长支持：< 1小时；
        /// - 音频码率类型支持：128 Kbps - 256 Kbps ；
        /// - 音频文件支持格式：wav、mp3、aac、flac、amr、3gp、 m4a、wma、ogg、ape；
        /// - 支持音视频文件分离并对音频文件进行独立识别；
        /// 
        /// ### 音频流调用说明：
        /// - 音频流时长支持：< 3小时；
        /// - 音频码率类型支持：128 Kbps - 256 Kbps ；
        /// - 音频流支持的传输协议：RTMP、HTTP、HTTPS；
        /// - 音频流格式支持的类型：rtp、srtp、rtmp、rtmps、mmsh、 mmst、hls、http、tcp、https、m3u8；
        /// - 支持音视频流分离并对音频流进行独立识别；
        /// </summary>
        /// <param name="req"><see cref="CreateAudioModerationTaskRequest"/></param>
        /// <returns><see cref="CreateAudioModerationTaskResponse"/></returns>
        public CreateAudioModerationTaskResponse CreateAudioModerationTaskSync(CreateAudioModerationTaskRequest req)
        {
             JsonResponseModel<CreateAudioModerationTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAudioModerationTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAudioModerationTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建业务配置，1个账号最多可以创建20个配置，可定义音频审核的场景，如色情、谩骂等，
        /// 
        /// 在创建业务配置之前，你需要以下步骤：
        /// 1. 开通COS存储桶功能，新建存储桶，例如 cms_segments，用来存储 视频转换过程中生成对音频和图片。
        /// 2. 然后在COS控制台，授权天御内容安全主账号 对 cms_segments 存储桶对读写权限。具体授权操作，参考https://cloud.tencent.com/document/product/436/38648
        /// </summary>
        /// <param name="req"><see cref="CreateBizConfigRequest"/></param>
        /// <returns><see cref="CreateBizConfigResponse"/></returns>
        public async Task<CreateBizConfigResponse> CreateBizConfig(CreateBizConfigRequest req)
        {
             JsonResponseModel<CreateBizConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBizConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBizConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建业务配置，1个账号最多可以创建20个配置，可定义音频审核的场景，如色情、谩骂等，
        /// 
        /// 在创建业务配置之前，你需要以下步骤：
        /// 1. 开通COS存储桶功能，新建存储桶，例如 cms_segments，用来存储 视频转换过程中生成对音频和图片。
        /// 2. 然后在COS控制台，授权天御内容安全主账号 对 cms_segments 存储桶对读写权限。具体授权操作，参考https://cloud.tencent.com/document/product/436/38648
        /// </summary>
        /// <param name="req"><see cref="CreateBizConfigRequest"/></param>
        /// <returns><see cref="CreateBizConfigResponse"/></returns>
        public CreateBizConfigResponse CreateBizConfigSync(CreateBizConfigRequest req)
        {
             JsonResponseModel<CreateBizConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBizConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBizConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 音频审核明细列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAmsListRequest"/></param>
        /// <returns><see cref="DescribeAmsListResponse"/></returns>
        public async Task<DescribeAmsListResponse> DescribeAmsList(DescribeAmsListRequest req)
        {
             JsonResponseModel<DescribeAmsListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAmsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAmsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 音频审核明细列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAmsListRequest"/></param>
        /// <returns><see cref="DescribeAmsListResponse"/></returns>
        public DescribeAmsListResponse DescribeAmsListSync(DescribeAmsListRequest req)
        {
             JsonResponseModel<DescribeAmsListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAmsList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAmsListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 控制台识别统计
        /// </summary>
        /// <param name="req"><see cref="DescribeAudioStatRequest"/></param>
        /// <returns><see cref="DescribeAudioStatResponse"/></returns>
        public async Task<DescribeAudioStatResponse> DescribeAudioStat(DescribeAudioStatRequest req)
        {
             JsonResponseModel<DescribeAudioStatResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAudioStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAudioStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 控制台识别统计
        /// </summary>
        /// <param name="req"><see cref="DescribeAudioStatRequest"/></param>
        /// <returns><see cref="DescribeAudioStatResponse"/></returns>
        public DescribeAudioStatResponse DescribeAudioStatSync(DescribeAudioStatRequest req)
        {
             JsonResponseModel<DescribeAudioStatResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAudioStat");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAudioStatResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看单个配置
        /// </summary>
        /// <param name="req"><see cref="DescribeBizConfigRequest"/></param>
        /// <returns><see cref="DescribeBizConfigResponse"/></returns>
        public async Task<DescribeBizConfigResponse> DescribeBizConfig(DescribeBizConfigRequest req)
        {
             JsonResponseModel<DescribeBizConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBizConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBizConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看单个配置
        /// </summary>
        /// <param name="req"><see cref="DescribeBizConfigRequest"/></param>
        /// <returns><see cref="DescribeBizConfigResponse"/></returns>
        public DescribeBizConfigResponse DescribeBizConfigSync(DescribeBizConfigRequest req)
        {
             JsonResponseModel<DescribeBizConfigResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBizConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBizConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查看任务详情
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
