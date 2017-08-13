using System;
namespace NepaliDateConverter
{
    public interface INepaliDateConverter
    {
        /// <summary>
        /// Will convert given English Date to Nepali Date
        /// </summary>
        /// <returns>The to nepali.</returns>
        /// <param name="yy">2017</param>
        /// <param name="mm">12</param>
        /// <param name="dd">3</param>
        Calendar ConvertToNepali(int yy, int mm, int dd);

        /// <summary>
        /// Will convert given Nepali Date to English Date
        /// </summary>
        /// <returns>The to english.</returns>
        /// <param name="yy">2074</param>
        /// <param name="mm">12</param>
        /// <param name="dd">1</param>
        Calendar ConvertToEnglish(int yy, int mm, int dd);
    }
}
