using System;

namespace Sabeco_Factsheet.TbHisLogPrintings
{
    public abstract class TbHisLogPrintingExcelDtoBase
    {
        public bool? IsSendMail { get; set; }
        public DateTime? DateSendMail { get; set; }
        public int? Type { get; set; }
        public DateTime InsertDate { get; set; }
        public string? UserName { get; set; }
        public string? CompanyCode { get; set; }
        public string? FileLanguage { get; set; }
        public bool? IsPrinting { get; set; }
    }
}