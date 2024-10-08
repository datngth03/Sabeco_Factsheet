using Volo.Abp.Application.Dtos;
using System;

namespace Sabeco_Factsheet.TbCompanyPersonTemps
{
    public abstract class TbCompanyPersonTempExcelDownloadDtoBase
    {
        public string DownloadToken { get; set; } = null!;

        public string? FilterText { get; set; }

        public int? idCompanyPersonMin { get; set; }
        public int? idCompanyPersonMax { get; set; }
        public string? BranchCode { get; set; }
        public int? CompanyIdMin { get; set; }
        public int? CompanyIdMax { get; set; }
        public int? PersonIdMin { get; set; }
        public int? PersonIdMax { get; set; }
        public int? PositionIdMin { get; set; }
        public int? PositionIdMax { get; set; }
        public DateTime? FromDateMin { get; set; }
        public DateTime? FromDateMax { get; set; }
        public DateTime? ToDateMin { get; set; }
        public DateTime? ToDateMax { get; set; }
        public byte? PositionTypeMin { get; set; }
        public byte? PositionTypeMax { get; set; }
        public string? PositionCode { get; set; }
        public decimal? PersonalValueMin { get; set; }
        public decimal? PersonalValueMax { get; set; }
        public decimal? PersonalSharePercentageMin { get; set; }
        public decimal? PersonalSharePercentageMax { get; set; }
        public decimal? OwnerValueMin { get; set; }
        public decimal? OwnerValueMax { get; set; }
        public decimal? RepresentativePercentageMin { get; set; }
        public decimal? RepresentativePercentageMax { get; set; }
        public string? Note { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? crt_dateMin { get; set; }
        public DateTime? crt_dateMax { get; set; }
        public int? crt_userMin { get; set; }
        public int? crt_userMax { get; set; }
        public DateTime? mod_dateMin { get; set; }
        public DateTime? mod_dateMax { get; set; }
        public int? mod_userMin { get; set; }
        public int? mod_userMax { get; set; }
        public bool? IsDeleted { get; set; }

        public TbCompanyPersonTempExcelDownloadDtoBase()
        {

        }
    }
}