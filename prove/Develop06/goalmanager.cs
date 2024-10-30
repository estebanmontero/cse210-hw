using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>(); // Encapsulated list of goals
    private int _score = 0; // Encapsulated user score

    public void Start()
    {
        string choice;
        do
        {
            DisplayScore();
            Console.WriteLine("1. Create Goal\n2. List Goals\n3. Record Event\n4. Save Goals\n5. Load Goals\n6. Quit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        } while (choice != "6");
    }

    private void DisplayScore() => Console.WriteLine($"Score: {_score}");

    private void CreateGoal()
    {
        Console.WriteLine("Enter Goal Type (Simple, Eternal, Checklist): ");
        string type = Console.ReadLine();
        Console.Write("Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = type switch
        {
            "Simple" => new SimpleGoal(name, description, points),
            "Eternal" => new EternalGoal(name, description, points),
            "Checklist" => CreateChecklistGoal(name, description, points),
            _ => null
        };

        if (goal != null) _goals.Add(goal);
        else Console.WriteLine("Invalid goal type.");
    }

    private ChecklistGoal CreateChecklistGoal(string name, string description, int points)
    {
        Console.Write("Target Count: ");
        int targetCount = int.Parse(Console.ReadLine());
        Console.Write("Bonus Points: ");
        int bonusPoints = int.Parse(Console.ReadLine());
        return new ChecklistGoal(name, description, points, targetCount, bonusPoints);
    }

    private void ListGoals()
    {
        foreach (var goal in _goals)
            Console.WriteLine(goal.GetDetails());
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Enter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"Earned {points} points!");
        }
        else Console.WriteLine("Invalid goal number.");
    }

    private void SaveGoals()
    {
        using StreamWriter writer = new("goals.txt");
        writer.WriteLine(_score);
        foreach (var goal in _goals)
            writer.WriteLine(goal.GetStringRepresentation());
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt")) { Console.WriteLine("No saved goals found."); return; }

        using StreamReader reader = new("goals.txt");
        _score = int.Parse(reader.ReadLine());
        _goals.Clear();
        
        string line;
        while ((line = reader.ReadLine()) != null)
            _goals.Add(Goal.FromStringRepresentation(line));

        Console.WriteLine("Goals loaded.");
    }
}

