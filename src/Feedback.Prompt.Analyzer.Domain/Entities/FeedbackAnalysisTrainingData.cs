using Feedback.Prompt.Analyzer.Domain.Common.Analysis;

namespace Feedback.Prompt.Analyzer.Domain.Entities;

/// <summary>
/// Represents feedback analysis prompt training data
/// </summary>
public class FeedbackAnalysisTrainingData : TrainingData<Product, CustomerFeedback, FeedbackAnalysisResult>;