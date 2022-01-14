using AuthVec.Application.Common.Interfaces;

namespace AuthVec.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
