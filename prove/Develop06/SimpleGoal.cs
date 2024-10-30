public class SimpleGoal : Goal
{
    private bool _isComplete; // Completion status

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string GetDetails() => $"[Simple] {_name}: {_description} - {_points} points - {(IsComplete() ? "[X]" : "[ ]")}";
    public override string GetStringRepresentation() => $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";

    private bool IsComplete() => _isComplete;
}

