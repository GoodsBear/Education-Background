using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Educational.Roles
{
    /// <summary>
    /// 角色信息
    /// </summary>
    public class RoleInfo : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 角色名（必填）
        /// </summary>
        [Required]
        [MaxLength(50)]
        [Comment("角色名")]
        public string RoleName { get; set; }

        /// <summary>
        /// 编码（必填，唯一约束可后续添加索引）
        /// </summary>
        [Required]
        [MaxLength(50)]
        [Comment("编码")]
        public string Code { get; set; }
    }
}
