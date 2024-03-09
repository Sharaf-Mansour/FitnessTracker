namespace FitnessTracker;
    /// <summary>
    /// A class Responsable for Calculating Daily Calories Intake <br/>
    /// Parameters are Optional
    /// </summary>  
    /// <param name="gender">Can be <c> Male </c> or <c> Female </c> : default Male</param>
    /// <param name="age">a double represents the factor of Calculating Calories based on Age: default 0</param>
    /// <param name="height">a double represents the factor of Calculating Calories based on Height: default 0</param>
    /// <param name="weight">a double represents the factor of Calculating Calories based on Weight: default 0</param>
    /// <param name="activityLevel">An Enum Value represents the factor of Calculating Calories based on Activity Level: default Sedentary</param>
public class FitnessInfo(
                            Gender gender = default,
                            double age = default,
                            double height = default, 
                            double weight = default,
                            ActivityLevel activityLevel = default
                        )
{
    /// <summary>
    /// Can be Male or Female: default Male
    /// </summary>  
    public Gender Gender { get; set; } = gender;
    /// <summary>
    ///a double represents the factor of Calculating Calories based on Age: default 0
    /// </summary>  
    public double Age { get; set; } = age;
     /// <summary>
    ///a double represents the factor of Calculating Calories based on Height: default 0
    /// </summary>  
    public double Height { get; set; } = height;
     /// <summary>
    ///a double represents the factor of Calculating Calories based on Weight: default 0
    /// </summary>  
    public double Weight { get; set; } = weight;
     /// <summary>
    ///  An Enum Value represents the factor of Calculating Calories based on Activity Level: default Sedentary
    /// </summary>  
    public ActivityLevel ActivityLevel { get; set; } = activityLevel;
     /// <summary>
    /// A Method Calculates the Daily Calories Intake
    /// </summary>
    /// <returns>
    ///<para>The Calculated Calories Based on (Gender, Age, Height, Weight and Activity Level)</para>
    /// </returns>
    /// <exception cref="ArgumentException">
    /// thrown when gender is Invalid
    /// </exception>
    public double CalculateDailyCalorieIntake() => Gender switch
    {
        Gender.Male => (88.362 + (13.397 * Weight) + (4.799 * Height) - (5.677 * Age)) * (1+ (double)ActivityLevel/10),
        Gender.Female => (447.593 + (9.247 * Weight) + (3.098 * Height) - (4.330 * Age)) * (1+(double)ActivityLevel/10),
        _ => throw new ArgumentException("Invalid gender. Please specify 'Male' or 'Female'.")
    };
}


