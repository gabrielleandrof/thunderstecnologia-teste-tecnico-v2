namespace Thunders.TechTest.ApiService.Responses.TollUsage;

public class HourlyTollUsageReportResponse
{
    public string City { get; set; } = default!;
    public int Hour { get; set; }
    public decimal Total { get; set; }
}
