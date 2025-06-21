using Educational.Dto.PositionsDto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Educational.Positions
{
    public interface IPositionAppService: IApplicationService
    {
        Task<ApiResult<PositionsDto>> CreatePosition(CreateUpdatePositionDto createPositionDto);
        Task<ApiResult<PositionsDto>> UpdatePosition(Guid id, CreateUpdatePositionDto createPositionDto);
        Task<ApiResult<ApiPagiing<List<PositionsDto>>>> GetPositionList([FromQuery] PositionSearchDto searchDto);
    }
}
