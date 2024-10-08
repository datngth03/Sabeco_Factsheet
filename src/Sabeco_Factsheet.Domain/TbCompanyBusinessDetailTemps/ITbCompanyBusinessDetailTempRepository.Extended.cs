using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
namespace Sabeco_Factsheet.TbCompanyBusinessDetailTemps
{
    public partial interface ITbCompanyBusinessDetailTempRepository
    {
        //HQSOFT's generated code:
        Task<List<TbCompanyBusinessDetailTemp>> GetListNoPagedAsync(
                    string? filterText = null,
                    int? parentIdMin = null,
                    int? parentIdMax = null,
                    string? registrationCode = null,
                    string? registrationName = null,
                    string? registrationName_EN = null,
                    bool? isActive = null,
                    DateTime? crt_dateMin = null,
                    DateTime? crt_dateMax = null,
                    int? crt_userMin = null,
                    int? crt_userMax = null,
                    DateTime? mod_dateMin = null,
                    DateTime? mod_dateMax = null,
                    int? mod_userMin = null,
                    int? mod_userMax = null,
                    string? sorting = null,
            CancellationToken cancellationToken = default
        );
        //Write your custom code here...
    }
}