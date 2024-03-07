using System;
namespace AWFitnessTracker;
public record FittnessInfo(string Gender, int Age, int Height, int Weight, double ActivityLevel)
{
    public double CalculateDailyCalorieIntake() => Gender.ToLower() switch
    {
        "male" => (88.362 + (13.397 * Weight) + (4.799 * Height) - (5.677 * Age)) * (1 + ActivityLevel / 10),
        "female" => (447.593 + (9.247 * Weight) + (3.098 * Height) - (4.330 * Age)) * (1 + ActivityLevel / 10),
        _ => throw new ArgumentException("Invalid gender. Please specify 'male' or 'female'.")
    };
}
