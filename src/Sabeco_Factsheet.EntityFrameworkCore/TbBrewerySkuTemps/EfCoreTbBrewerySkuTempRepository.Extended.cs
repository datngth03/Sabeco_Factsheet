using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Sabeco_Factsheet.EntityFrameworkCore;

namespace Sabeco_Factsheet.TbBrewerySkuTemps
{
    public class EfCoreTbBrewerySkuTempRepository : EfCoreTbBrewerySkuTempRepositoryBase, ITbBrewerySkuTempRepository
    {
        public EfCoreTbBrewerySkuTempRepository(IDbContextProvider<Sabeco_FactsheetDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
        //HQSOFT's generated code:
        public virtual async Task<List<TbBrewerySkuTemp>> GetListNoPagedAsync(
            string? filterText = null,
            int? idBrewerySKUMin = null,
            int? idBrewerySKUMax = null,
            int? yearMin = null,
            int? yearMax = null,
            string? breweryCode = null,
            string? sKUCode = null,
            decimal? productionVolumeMin = null,
            decimal? productionVolumeMax = null,
            byte? docStatusMin = null,
            byte? docStatusMax = null,
            bool? isActive = null,
            DateTime? crt_dateMin = null,
            DateTime? crt_dateMax = null,
            int? crt_userMin = null,
            int? crt_userMax = null,
            DateTime? mod_dateMin = null,
            DateTime? mod_dateMax = null,
            int? mod_userMin = null,
            int? mod_userMax = null,
            int? breweryIdMin = null,
            int? breweryIdMax = null,
            int? sKUIdMin = null,
            int? sKUIdMax = null,
            string? sorting = null, 
            CancellationToken cancellationToken = default)
        {
            var query = ApplyFilter((await GetQueryableAsync()), filterText, idBrewerySKUMin, idBrewerySKUMax, yearMin, yearMax, breweryCode, sKUCode, productionVolumeMin, productionVolumeMax, docStatusMin, docStatusMax, isActive, crt_dateMin, crt_dateMax, crt_userMin, crt_userMax, mod_dateMin, mod_dateMax, mod_userMin, mod_userMax, breweryIdMin, breweryIdMax, sKUIdMin, sKUIdMax);
            query = query.OrderBy(string.IsNullOrWhiteSpace(sorting) ? TbBrewerySkuTempConsts.GetDefaultSorting(false) : sorting);
            return await query.ToListAsync(cancellationToken);
        }
        //Write your custom code here...
    }
}