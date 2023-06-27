namespace HW5._6
{
    public class DaysOfWeekService : IDaysOfWeekService
    {
        public string[] GetDaysOfWeek()
        {
            return new string[] 
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
        }
    }
}
