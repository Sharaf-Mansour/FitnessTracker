namespace FitnessTracker;
   /// <summary>
   /// A Class to assign the best workout program based on the number of <c>Workout Days</c>
   /// </summary>
   /// <param name="WorkoutDays">Workout Days an Enum could be from <c>ZeroDays</c> to <c>SevenDays</c></param>
public class Workout( Workoutdays WorkoutDays = default)
{
    /// <summary>
    /// Workout Days an Enum could be from <c>ZeroDays</c> to <c>SevenDays</c>
    /// </summary>
    public Workoutdays WorkoutDays { get; set; } = WorkoutDays;
    /// <summary>
    /// A Method that assign the best workout program.
    /// </summary>
    /// <returns>
    /// <para>Assign the best workout program based on the number of (<c>Workout Days</c>)</para>
    /// </returns>
    public string AssignWorkoutProgram() => WorkoutDays switch
    {
        Workoutdays.ZeroDay => "You need to workout",
        Workoutdays.OneDay => "Full body program",
        Workoutdays.TwoDays or Workoutdays.FourDays => "Upper and lower program or bro split program",
        Workoutdays.ThreeDays or Workoutdays.SixDays or Workoutdays.SevenDays  => "Push and pull and legs program or Arnold split program",
        Workoutdays.FiveDays => "Bro split program or Push, pull, legs program with upper and lower program",
        _ => "Unknown workout schedule"       
    };
}