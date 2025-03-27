using System;
// Exercise.cs
public class Exercise
{
    public string ExerciseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }
    public string Intensity { get; set; }
    public string MuscleGroup { get; set; }

    // Constructor
    public Exercise(string exerciseId, string name, string description, int duration, string intensity, string muscleGroup)
    {
        ExerciseId = exerciseId;
        Name = name;
        Description = description;
        Duration = duration;
        Intensity = intensity;
        MuscleGroup = muscleGroup;
    }
}
