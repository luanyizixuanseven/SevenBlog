using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Seven.BaseEntity
{
    public class BaseEntity<T>
    {
        [Key]
        public T ID { get; set; }

        public DateTime CrateTime { get; set; }

        public string CreateUserID { get; set; }

        public DateTime UpdateTime { get; set; }

        public string UpdateUserID { get; set; }

        public EnumEntityState EnumEntityState { get; set; }
    }

    public class BaseParentEntity<T> : BaseEntity<T>
    {
        /// <summary>
        /// 父级ID
        /// </summary>
        public T ParentID { get; set; }
    }

    public class BaseGuidEntity : BaseEntity<Guid>
    {
    }

    public class BaseGuidParentEntity : BaseParentEntity<Guid>
    {
    }
}
