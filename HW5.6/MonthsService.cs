namespace HW5._6
{
    public class MonthsService : IMonthsService
    {
        public string[] GetMonths()
        {
            return new string[]
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };
        }
    }
}
