using System;

namespace Sabeco_Factsheet.TbCompanyPersonTemps
{
    public abstract class TbCompanyPersonTempExcelDtoBase
    {
        public int? idCompanyPerson { get; set; }
        public string? BranchCode { get; set; }
        public int CompanyId { get; set; }
        public int PersonId { get; set; }
        public int? PositionId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public byte? PositionType { get; set; }
        public string? PositionCode { get; set; }
        public decimal? PersonalValue { get; set; }
        public decimal? PersonalSharePercentage { get; set; }
        public decimal? OwnerValue { get; set; }
        public decimal? RepresentativePercentage { get; set; }
        public string? Note { get; set; }
        public bool IsActive { get; set; }
        public DateTime? crt_date { get; set; }
        public int? crt_user { get; set; }
        public DateTime? mod_date { get; set; }
        public int? mod_user { get; set; }
        public bool IsDeleted { get; set; }
    }
}