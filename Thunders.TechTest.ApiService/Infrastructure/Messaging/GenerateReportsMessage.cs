namespace Thunders.TechTest.ApiService.Infrastructure.Messaging;

public class GenerateReportsMessage
{
    public GenerateReportsMessage(int year, int month)
    {
        Year = year;
        Month = month;
    }

    public int Year { get; private set; }
    public int Month { get; private set; }
}
