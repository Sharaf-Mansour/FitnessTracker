namespace FitnessTracker;
public class FitnessInfo(Gender gender = default, double age = default, double height = default, double weight = default, ActivityLevel activityLevel = default)
{
    public Gender Gender { get; set; } = gender;
    public double Age { get; set; } = age;
    public double Height { get; set; } = height;
    public double Weight { get; set; } = weight;
    public ActivityLevel ActivityLevel { get; set; } = activityLevel;
    public double CalculateDailyCalorieIntake() => Gender switch
    {
        Gender.Male => (88.362 + (13.397 * Weight) + (4.799 * Height) - (5.677 * Age)) * (1+ (double)ActivityLevel/10),
        Gender.Female => (447.593 + (9.247 * Weight) + (3.098 * Height) - (4.330 * Age)) * (1+(double)ActivityLevel/10),
        _ => throw new ArgumentException("Invalid gender. Please specify 'Male' or 'Female'.")
    };
}