using System.ComponentModel.DataAnnotations;

namespace DNTPersianNewsAgency.Core
{
    public enum NewsType
    {
        [Display(Name = "اقتصادی")]
        Economic,

        [Display(Name = "سیاسی")]
        Political,

        [Display(Name = "علمی")]
        Scientific,

        [Display(Name = "فرهنگی")]
        Culture,

        [Display(Name = "اجتماعی")]
        Social,

        [Display(Name = "بین المللی")]
        International,

        [Display(Name = "ورزشی")]
        Sport,

        [Display(Name = "سایر")]
        All
    }
}
