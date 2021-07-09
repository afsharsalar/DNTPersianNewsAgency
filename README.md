#DNTPersianNewsAgency.Core
=======
<div dir="rtl">

<p>
  <a href="https://github.com/afsharsalar/DNTPersianNewsAgency">
     <img alt="GitHub Actions status" src="https://github.com/VahidN/DNTPersianUtils.Core/workflows/.NET%20Core%20Build/badge.svg">
  </a>
</p>

DNTPersianNewsAgency.Core

کتابخانه‌ای است متشکل از متدهای الحاقی کمکی جهت کار با RSS های خبرگزای های ایرانی، در برنامه‌های مبتنی بر NET Core. 
برای نصب آن دستور ذیل را در کنسول پاورشل نیوگت اجرا کنید:
</div>

[![Nuget](https://img.shields.io/nuget/v/DNTPersianNewsAgency.Core)](https://github.com/afsharsalar/DNTPersianNewsAgency)
```
PM> Install-Package DNTPersianNewsAgency.Core 
```
<div dir="rtl">
  <h2>نحوه کار 
</h2>
  
</div>

```csharp
var data = RssReader.Read();
```
