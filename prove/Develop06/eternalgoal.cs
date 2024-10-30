public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override int RecordEvent() => _points;
    public override string GetDetails() => $"[Eternal] {_name}: {_description} - {_points} points each time";
    public override string GetStringRepresentation() => $"EternalGoal|{_name}|{_description}|{_points}";
}

