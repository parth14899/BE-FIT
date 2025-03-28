using System;

public class DietPlan
{
    public string PlanId { get; set; }
    public string UserId { get; set; }
    public string MealName { get; set; }
    public int Calories { get; set; }
    public int Protein { get; set; }
    public int Fat { get; set; }

    public DietPlan(string planId, string userId, string mealName, int calories, int protein, int fat)
    {
        PlanId = planId;
        UserId = userId;
        MealName = mealName;
        Calories = calories;
        Protein = protein;
        Fat = fat;
    }
}
