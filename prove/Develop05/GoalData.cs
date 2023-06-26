public class GoalData
{
    private string _fileName;
    private List<Goal> goals = new List<Goal>();
    private int _totalPoints = 0;
    public int TotalPoints {get{return _totalPoints;}}

    private void GetFilename()
    {
        Console.WriteLine("What is the filename: ");
        _fileName = Console.ReadLine();
    }

    public void Save()
    {
        if (_fileName == null)
            GetFilename();
        Console.WriteLine("Saving Goals....");
        using (StreamWriter outputFile = new StreamWriter(_fileName, true))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine($"{goal.ToSaveString()}");
            }
        }
        Console.WriteLine("....Saved Goals");
    }

    public void Load()
    {
        if (_fileName == null)
            GetFilename();
        Console.WriteLine("Loading Goals....");
        goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        _totalPoints = int.Parse(lines[0]);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            switch(parts[0])
            {
                case "Eternal":
                    EternalGoal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    goals.Add(goal);
                    break;
                case "Simple":
                    SimpleGoal sgoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    goals.Add(sgoal);
                    break;
                case "Checklist":
                    CheckListGoal cgoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                    goals.Add(cgoal);
                    break;

            }
        }

        Console.WriteLine(".... Goals Loaded");
    }

    public void AddGoal()
    {
        Console.WriteLine(
            "Submenu\n" +
            "1.Simple Goal\n" +
            "2.Check List Goal\n" +
            "3.Eternal Goal");
        string choice2 = Console.ReadLine();
        switch (choice2)
        {
            case "1":
                Console.WriteLine("What is the name of your goal? ");
                string _goalName = Console.ReadLine();
                Console.WriteLine("What is your goal description? ");
                string _goalDescription = Console.ReadLine();
                Console.WriteLine("How many points if the goal worth? ");
                int _points = int.Parse(Console.ReadLine());
                SimpleGoal sgoal = new SimpleGoal(_goalName, _goalDescription, _points);
                goals.Add(sgoal);
                break;
            case "2":
                Console.WriteLine("What is the name of your goal? ");
                _goalName = Console.ReadLine();
                Console.WriteLine("What is your goal description? ");
                _goalDescription = Console.ReadLine();
                Console.WriteLine("How many points if the goal worth? ");
                _points = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times would you like to do this goal? ");
                int _target = int.Parse(Console.ReadLine());
                Console.WriteLine("How many bonus points is this goal worth when completed? ");
                int _bonusPoints = int.Parse(Console.ReadLine());
                CheckListGoal cgoal = new CheckListGoal(_goalName, _goalDescription, _points, _target, _bonusPoints);
                goals.Add(cgoal);
                break;
            case "3":
                Console.WriteLine("What is the name of your goal? ");
                _goalName = Console.ReadLine();
                Console.WriteLine("What is your goal description? ");
                _goalDescription = Console.ReadLine();
                Console.WriteLine("How many points if the goal worth? ");
                _points = int.Parse(Console.ReadLine());
                EternalGoal egoal = new EternalGoal(_goalName, _goalDescription, _points);
                goals.Add(egoal);
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    // public void basicinfo()
    // {

    // }


    public void displayAllGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal.Display());
        }
    }
    public void displayIncompleteGoals()
    {
        int counter = 1;
        List<int> indexes = new List<int>();
        //  0   1   2   3   4   ...
        //  3   6   7   9   10 ...
        for (int i = 0; i < goals.Count; i++)
        {
            if (goals[i] is CompletableGoal completableGoal)
            {
                if (!completableGoal.IsComplete)
                {
                    Console.Write($"{counter}. ");
                    Console.WriteLine(completableGoal.Display());
                    counter++;
                    indexes.Add(i);
                }
            }
            else
            {
                Console.Write($"{counter}. ");
                Console.WriteLine(goals[i].Display());
                counter++;
                indexes.Add(i);
            }

        }

        Console.WriteLine("Enter the goal: ");
        int option = int.Parse(Console.ReadLine());
        _totalPoints += goals[indexes[option - 1]].recordEvent();
    }

}