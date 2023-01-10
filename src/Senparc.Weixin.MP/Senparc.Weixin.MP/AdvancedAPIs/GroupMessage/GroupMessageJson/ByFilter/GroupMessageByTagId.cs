﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2023 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2023 Senparc
    
    文件名：GroupMessageByTagId.cs
    文件功能描述：根据 TagId 群发所需的数据
    
    
    创建标识：Senparc - 20171217

----------------------------------------------------------------*/

using System;

namespace Senparc.Weixin.MP.AdvancedAPIs.GroupMessage
{
    /// <summary>
    /// 根据 TagId 群发筛选
    /// </summary>
    public class GroupMessageByTagId : BaseGroupMessageByFilter
    {
        public string tag_id { get; set; }
    }
}
