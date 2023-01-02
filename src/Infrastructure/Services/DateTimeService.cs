using Store.Application.Common.Interfaces;

namespace Store.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
