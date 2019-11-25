using Microsoft.EntityFrameworkCore;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.Common.Interfaces
{
    public interface IPortfolioDbContext
    {
        DbSet<Value> Values { get; set; }
    }
}