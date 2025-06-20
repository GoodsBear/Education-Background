using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
	/// <summary>
	/// 验证状态枚举
	/// </summary>
	public enum VerifyStateEnum
	{
		待审核,
        审核通过,
		已驳回,
		已取消,
	}
}
