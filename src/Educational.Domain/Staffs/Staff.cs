using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Educational.Staffs
{
	/// <summary>
	/// 员工信息
	/// </summary>
	public class Staff: FullAuditedAggregateRoot<Guid>
	{
		/// <summary>
		/// 员工姓名
		/// </summary>
		public string StaffName { get; set; }
		/// <summary>
		/// 登录账户
		/// </summary>
        public string LoginAccount { get; set; }
		/// <summary>
		/// 电话
		/// </summary>
        public string Phone { get; set; }
		//所属机构
        public Guid? OrgId { get; set; }
		//性别
        public GenderEnum? Sex { get; set; }
		//职位
        public Guid Position { get; set; }
	}
}
