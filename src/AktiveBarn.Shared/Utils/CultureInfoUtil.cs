using System.Globalization;

namespace AktiveBarn.Shared.Utils;

public static class CultureInfoUtil
{
    public static CultureInfo GetCapitalizedCultureInfo(string cultureName)
    {
        var cultureInfo = CultureInfo.GetCultureInfo(cultureName);
        cultureInfo = (CultureInfo)cultureInfo.Clone();
        cultureInfo.DateTimeFormat.DayNames =
            [.. cultureInfo.DateTimeFormat.DayNames.Select(cultureInfo.TextInfo.ToTitleCase)];

        cultureInfo.DateTimeFormat.MonthGenitiveNames =
            [.. cultureInfo.DateTimeFormat.MonthGenitiveNames.Select(cultureInfo.TextInfo.ToTitleCase)];

        return cultureInfo;
    }
}