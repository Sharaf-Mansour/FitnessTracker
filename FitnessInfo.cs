namespace FitnessTracker;
public class FitnessInfo(Gender gender = default, double age = default, double height = default, double weight = default, double activityLevel = default)
{
    public Gender Gender { get; set; } = gender;
    public double Age { get; set; } = age;
    public double Height { get; set; } = height;
    public double Weight { get; set; } = weight;
    public double ActivityLevel { get; set; } = activityLevel;

    public double CalculateDailyCalorieIntake() => Gender switch
    {
        Gender.Male => (88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age)) * (1 + activityLevel / 10),
        Gender.Female => (447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age)) * (1 + activityLevel / 10),
        _ => throw new ArgumentException("Invalid gender. Please specify 'Male' or 'Female'.")
    };
}