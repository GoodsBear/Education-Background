using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Educational.RBAC
{
    public class User:FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 账号昵称
        /// </summary>
        [Required(ErrorMessage = "账号名称不能为空")] // 必填
        [StringLength(50, MinimumLength = 2, ErrorMessage = "账号名称长度应在2到50个字符之间")] // 长度限制
        public string UserName { get; set; } = string.Empty; // 默认值为空字符串

        /// <summary>
        /// 真实姓名
        /// </summary>
        [Required(ErrorMessage = "真实姓名不能为空")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "真实姓名长度应在2到50个字符之间")]
        public string NickName { get; set; } = string.Empty; // 默认值为空字符串

        /// <summary>
        /// 登录名
        /// </summary>
        [Required(ErrorMessage = "登录名不能为空")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "登录名长度应在4到50个字符之间")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "登录名只能包含字母、数字和下划线")] // 正则表达式验证
        public string LoginName { get; set; } = string.Empty; // 默认值为空字符串

        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "密码不能为空")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "密码长度应至少为6个字符")] 
        // 密码长度建议长一些以增加安全性
        // [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,100}
        // $", ErrorMessage = "密码必须包含大小写字母、数字和特殊字符")] // 更复杂的密码要求
        public string LoginPwd { get; set; } = string.Empty; // 默认值为空字符串

        /// <summary>
        /// 用户状态
        /// </summary>
        [Range(0, 1, ErrorMessage = "用户状态只能是0（禁用）或1（启用）")] // 范围验证
        public int Status { get; set; } // 1:启用, 0:禁用

        /// <summary>
        /// 用户手机号
        /// </summary>
        [Phone(ErrorMessage = "手机号格式不正确")] // 内置手机号格式验证
        [StringLength(11, MinimumLength = 11, ErrorMessage = "手机号长度必须为11位")]
        [RegularExpression(@"^1[3-9]\d{9}$", ErrorMessage = "手机号格式不正确")]
        // 手机号固定长度
        // 或者更严格的正则验证：
        public string UserTel { get; set; } = string.Empty; // 默认值为空字符串

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [EmailAddress(ErrorMessage = "邮箱地址格式不正确")] // 内置邮箱格式验证
        [StringLength(100, ErrorMessage = "邮箱长度不能超过100个字符")]
        public string UserEmail { get; set; } = string.Empty; // 默认值为空字符串
    }
}
