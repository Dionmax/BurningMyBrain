namespace System
{
    static class DateTimeExtensions
    {
        static public string ElipsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (DateTime.Now.Subtract(thisObj).TotalHours < 24.0)
                return duration.TotalHours.ToString("F1") + " Hours";

            return duration.TotalDays.ToString("F1") + " Days";
        }
    }
}
