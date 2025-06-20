using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
	/// <summary>
	/// 订单状态枚举
	/// </summary>
	public enum OrderStateEnum
	{
		未支付,
		已付款,
		已评价,
		已取消,
	}
}
