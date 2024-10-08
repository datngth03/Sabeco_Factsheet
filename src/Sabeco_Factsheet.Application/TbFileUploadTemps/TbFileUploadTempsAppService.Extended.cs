using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Sabeco_Factsheet.Permissions;
using Sabeco_Factsheet.TbFileUploadTemps;
using MiniExcelLibs;
using Volo.Abp.Content;
using Volo.Abp.Authorization;
using Volo.Abp.Caching;
using Microsoft.Extensions.Caching.Distributed;
using Sabeco_Factsheet.Shared;

namespace Sabeco_Factsheet.TbFileUploadTemps
{
    public class TbFileUploadTempsAppService : TbFileUploadTempsAppServiceBase, ITbFileUploadTempsAppService
    {
        //<suite-custom-code-autogenerated>
        public TbFileUploadTempsAppService(ITbFileUploadTempRepository tbFileUploadTempRepository, TbFileUploadTempManager tbFileUploadTempManager, IDistributedCache<TbFileUploadTempDownloadTokenCacheItem, string> downloadTokenCache)
            : base(tbFileUploadTempRepository, tbFileUploadTempManager, downloadTokenCache)
        {
        }
        //HQSOFT's generated code:
        public virtual async Task<List<TbFileUploadTempDto>> GetListNoPagedAsync(GetTbFileUploadTempsInput input)
        {
            var items = await _tbFileUploadTempRepository.GetListNoPagedAsync(input.FilterText, input.companyIdMin, input.companyIdMax, input.personIdMin, input.personIdMax, input.fileName, input.fullFileName, input.fileLink, input.uploadDateMin, input.uploadDateMax, input.UserUploadMin, input.UserUploadMax, input.note, input.IsActive, input.DownloadCountMin, input.DownloadCountMax, input.crt_dateMin, input.crt_dateMax, input.crt_userMin, input.crt_userMax, input.mod_dateMin, input.mod_dateMax, input.mod_userMin, input.mod_userMax, input.Sorting);

            return ObjectMapper.Map<List<TbFileUploadTemp>, List<TbFileUploadTempDto>>(items);
        }
        //</suite-custom-code-autogenerated>

        //Write your custom code...
    }
}