using System.ComponentModel.DataAnnotations;

namespace DNTPersianNewsAgency.Core
{
    /// <summary>
    /// خبر گزاری های رسمی
    /// </summary>
    public enum NewsAgencyType
    {
        [Display(Name = "تسنیم")]
        Tasnim,



        [Display(Name = "دنیای اقتصاد")]
        DonyaEqtesad,

        [Display(Name = "اقتصاد آنلاین")]
        Eghtesadonline,

        [Display(Name = "مهر")]
        Mehr,

        [Display(Name = "ایسنا")]
        Isna,

        [Display(Name = "فرارو")]
        Fararu,


        [Display(Name = "تیتر 20")]
        Titr20,


        [Display(Name = "سنا")]
        Sena,

        [Display(Name = "بورس نیوز")]
        Boursenews,


        [Display(Name = "رادیو سهام")]
        Radiosaham,
    }
}
