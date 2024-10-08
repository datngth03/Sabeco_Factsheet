using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;
using Sabeco_Factsheet.Validation;

namespace Sabeco_Factsheet.TbCompanyPersons
{
    public abstract class TbCompanyPersonUpdateDtoBase : AuditedEntityDto<int>
    {
        [StringLength(TbCompanyPersonConsts.BranchCodeMaxLength, ErrorMessage = "The field must be a string with a maximum length of {1}.")] 
        public string? BranchCode { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        public int CompanyId { get; set; } 

        [Required(ErrorMessage = "The field is required.")]
        public int PersonId { get; set; }

        [Required(ErrorMessage = "The field is required.")]
        public int PositionId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        [StringLength(TbCompanyPersonConsts.PositionCodeMaxLength, ErrorMessage = "The field must be a string with a maximum length of {1}.")] 
        public string? PositionCode { get; set; }
        public byte? PostionType { get; set; }

        
        [DecimalValidation(ErrorMessage = "Value must be up to 18 digits in total, including up to 2 decimal places.")]
        public decimal? PersonalValue { get; set; }

        
        [DecimalValidation(ErrorMessage = "Value must be up to 18 digits in total, including up to 2 decimal places.")]
        public decimal? PersonalSharePercentage { get; set; }

        
        [DecimalValidation(ErrorMessage = "Value must be up to 18 digits in total, including up to 2 decimal places.")]
        public decimal? OwnerValue { get; set; }

        
        [DecimalValidation(ErrorMessage = "Value must be up to 18 digits in total, including up to 2 decimal places.")]
        public decimal? RepresentativePercentage { get; set; }
        [StringLength(TbCompanyPersonConsts.NoteMaxLength, ErrorMessage = "The field must be a string with a maximum length of {1}.")] 
        public string? Note { get; set; }
        [Required(ErrorMessage = "The field is required.")]
        public bool IsActive { get; set; }
        public DateTime? crt_date { get; set; }
        public int? crt_user { get; set; }
        public DateTime? mod_date { get; set; }
        public int? mod_user { get; set; }
        public bool IsDeleted { get; set; }

    }
}