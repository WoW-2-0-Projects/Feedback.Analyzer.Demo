using Feedback.Prompt.Analyzer.Domain.Models.Common;

namespace Feedback.Prompt.Analyzer.Domain.Models.Entities;

/// <summary>
/// Represents feedback analysis prompt training data
/// </summary>
public class FeedbackAnalysisTrainingData : TrainingData<Product, CustomerFeedback, FeedbackAnalysisResult>;