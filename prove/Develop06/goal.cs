public abstract class Goal
{
    protected string _name; // Encapsulated name
    protected string _description; // Encapsulated description
    protected int _points; // Encapsulated points

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent(); // Polymorphic method for recording events
    public abstract string GetDetails();
    public abstract string GetStringRepresentation();

    public static Goal FromStringRepresentation(string data)
    {
        string[] parts = data.Split("|");
        return parts[0] switch
        {
            "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])),
            "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
            "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])),
            _ => throw new InvalidOperationException("Unknown goal type")
        };
    }
}

