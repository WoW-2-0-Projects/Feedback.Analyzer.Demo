using Test.Data.Models;

namespace Test.Data.TrainingData;

public class TrainingDataModel
{
    public Product Product { get; set; } = default!;
    
    public List<CustomerFeedback> Reviews { get; set; } = default!;
}