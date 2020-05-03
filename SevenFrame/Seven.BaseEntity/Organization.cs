using System;
using System.Collections.Generic;
using System.Text;

namespace Seven.BaseEntity
{
    public class Organization : BaseGuidParentEntity
    {
        /// <summary>
        /// 组织名称
        /// </summary>
        public string OrgName { get; set; }

        /// <summary>
        /// 管理员账号
        /// </summary>
        public string Admin { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 层级路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 组织Code
        /// </summary>
        public string OrgCode { get; set; }

        public string ExtentFild { get; set; }
    }
}
