using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational.Dto.PositionsDto
{
    public class PositionSearchDto:Seach
    {
        /// <summary>
        /// 职位名称
        /// </summary>
        public string? PositionName { get; set; }
    }
}
