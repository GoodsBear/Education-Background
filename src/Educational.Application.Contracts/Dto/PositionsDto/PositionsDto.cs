using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Educational.Dto.PositionsDto
{
    public class PositionsDto: AuditedEntityDto<Guid>
    {
        /// <summary>
        /// 职位名称
        /// </summary>
        public string PositionName { get; set; }
    }
}
