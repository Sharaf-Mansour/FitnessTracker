namespace FitnessTracker;

public class Workout(
    Workoutdays WorkoutDays = default
)
{
        
     public Workoutdays WorkoutDays { get; set; }= WorkoutDays;
    public string CalculateWorkoutSchedule(Workoutdays WorkoutDays) => WorkoutDays switch
    {
        Workoutdays.zeroday => "You need to workout",
        Workoutdays.oneday => "Full body program",
        Workoutdays.twodays or Workoutdays.fourdays => "Upper and lower program or bro split program",
        Workoutdays.threedays or Workoutdays.sixdays or Workoutdays.sevendays  => "Push and pull and legs program or Arnold split program",
        Workoutdays.fivedays => "Bro split program or Push, pull, legs program with upper and lower program",
        _ => "Unknown workout schedule"
        
    };
}