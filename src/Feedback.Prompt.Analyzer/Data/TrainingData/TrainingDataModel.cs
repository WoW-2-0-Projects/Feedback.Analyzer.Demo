using Feedback.Prompt.Analyzer.Domain.Entities;

namespace Feedback.Prompt.Analyzer.Data.TrainingData;

public class TrainingDataModel
{
    public Product Product { get; set; } = default!;
    
    public List<CustomerFeedback> Reviews { get; set; } = default!;
}