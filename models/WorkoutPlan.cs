using System;

public class WorkoutPlan
{
    public string PlanId { get; set; }
    public string UserId { get; set; }
    public List<string> ExerciseList { get; set; }
    public int Duration { get; set; }
    public string Intensity { get; set; }
    public int Frequency { get; set; }

    public WorkoutPlan(string planId, string userId, List<string> exerciseList, int duration, string intensity, int frequency)
    {
        PlanId = planId;
        UserId = userId;
        ExerciseList = exerciseList;
        Duration = duration;
        Intensity = intensity;
        Frequency = frequency;
    }
}
