using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Educational.AnncoucementManager
{
    /// <summary>
    /// 公告表
    /// </summary>
    public class Announcement:FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 公告标题
        /// </summary>
        [Required(ErrorMessage = "公告标题不能为空")] // 必填
        [StringLength(100, MinimumLength = 5, ErrorMessage = "公告标题长度应在5到100个字符之间")] // 标题通常有长度限制
        public string AnnouncementTitle { get; set; } = string.Empty; // 默认值为空字符串

        /// <summary>
        /// 公告内容
        /// </summary>
        [Required(ErrorMessage = "公告内容不能为空")] // 必填
        [StringLength(4000, MinimumLength = 10, ErrorMessage = "公告内容长度应在10到4000个字符之间")] // 内容通常允许更长的文本
        public string AccouncementContent { get; set; } = string.Empty; // 默认值为空字符串
    }
}
