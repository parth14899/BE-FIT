using System;


public class User
{
    public string UserId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public int Age { get; set; }

    // fitness level  (beginner, intermediate, advanced)
    public string FitnessLevel { get; set; }

    // Constructor to initialize the User object
    public User(string userId, string firstName, string lastName, string email, int age, string fitnessLevel)
    {
        UserId = userId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Age = age;
        FitnessLevel = fitnessLevel;
    }
}

