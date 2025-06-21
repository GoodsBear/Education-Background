using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Educational.Permissions
{
    /// <summary>
    /// 权限信息
    /// </summary>
    public class PermissionInfo : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 权限名称（必填）
        /// </summary>
        [Required]
        [MaxLength(100)]
        [Comment("权限名称")]
        public string PermissionName { get; set; }
    }
}
