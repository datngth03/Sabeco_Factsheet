using System;

namespace Sabeco_Factsheet.TbAdditionInfoTemps
{
    public abstract class TbAdditionInfoTempExcelDtoBase
    {
        public int CompanyId { get; set; }
        public DateTime? DocDate { get; set; }
        public string? TypeOfGroup { get; set; }
        public string? TypeOfEvent { get; set; }
        public string? Description { get; set; }
        public string? NoOfDocument { get; set; }
        public string? Remark { get; set; }
        public bool? IsActive { get; set; }
        public int? create_user { get; set; }
        public DateTime? create_date { get; set; }
        public int? mod_user { get; set; }
        public DateTime? mod_date { get; set; }
    }
}