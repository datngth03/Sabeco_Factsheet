using Volo.Abp.Application.Dtos;
using System;

namespace Sabeco_Factsheet.TbCompanyMemberCouncilTerms
{
    public abstract class GetTbCompanyMemberCouncilTermsInputBase : PagedAndSortedResultRequestDto
    {

        public string? FilterText { get; set; }

        public int? CompanyIdMin { get; set; }
        public int? CompanyIdMax { get; set; }
        public int? TermFromMin { get; set; }
        public int? TermFromMax { get; set; }
        public int? TermEndMin { get; set; }
        public int? TermEndMax { get; set; }

        public GetTbCompanyMemberCouncilTermsInputBase()
        {

        }
    }
}