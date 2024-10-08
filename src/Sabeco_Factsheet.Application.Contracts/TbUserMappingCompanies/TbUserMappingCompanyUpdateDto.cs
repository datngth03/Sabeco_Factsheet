using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Sabeco_Factsheet.TbUserMappingCompanies
{
    public abstract class TbUserMappingCompanyUpdateDtoBase : AuditedEntityDto<int>
    {
        public int? userid { get; set; }
        public int? companyid { get; set; }
        public bool? IsActive { get; set; }

    }
}