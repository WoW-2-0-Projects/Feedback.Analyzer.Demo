using Feedback.Prompt.Analyzer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Feedback.Prompt.Analyzer.Persistence.DataContexts;

public class AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : DbContext(dbContextOptions)
{
    #region ClientsInfrastructure
   
    public DbSet<Product> Products => Set<Product>();
    
    #endregion

    #region FeedbackInfrastructure
    
    public DbSet<CustomerFeedback> Feedbacks => Set<CustomerFeedback>();

    #endregion
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}