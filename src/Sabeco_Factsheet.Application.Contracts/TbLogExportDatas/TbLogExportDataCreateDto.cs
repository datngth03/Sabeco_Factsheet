using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Sabeco_Factsheet.TbLogExportDatas
{
    public abstract class TbLogExportDataCreateDtoBase
    {
        [Required(ErrorMessage = "The field is required.")]
        public DateTime TimeExport { get; set; }
        [Required(ErrorMessage = "The field is required.")]
        public bool IsSuccess { get; set; }
        [Required(ErrorMessage = "The field is required.")]
        public int UserExport { get; set; }
        public string? TableName { get; set; }
        public string? ReasonExportFailed { get; set; }
    }
}