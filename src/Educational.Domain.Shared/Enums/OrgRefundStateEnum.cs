using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
	/// <summary>
	/// 组织退费状态
	/// </summary>
	public enum OrgRefundStateEnum
	{
		已申请,
		已审核待退款,
		退款驳回,
		退款完成,
		退款失败,
	}
}
