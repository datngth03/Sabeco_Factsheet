namespace Sabeco_Factsheet.TbContacts
{
    public static class TbContactConsts
    {
        private const string DefaultSorting = "{0}companyid asc";

        public static string GetDefaultSorting(bool withEntityName)
        {
            return string.Format(DefaultSorting, withEntityName ? "TbContact." : string.Empty);
        }

        public const int ContactNameMaxLength = 150;
        public const int ContactDeptMaxLength = 150;
        public const int ContactPositionMaxLength = 150;
        public const int ContactEmailMaxLength = 150;
        public const int ContactPhoneMaxLength = 50;
        public const int NoteMaxLength = 250;
    }
}