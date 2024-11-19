Console.WriteLine(Calculate(12, "/", 2));

double Calculate(double nr1, string operation, double nr2) =>
    operation switch
    {
        "+" => nr1 + nr2,
        "-" => nr1 - nr2,
        "*" => nr1 * nr2,
        "/" => nr1 / nr2,
        "" => throw new ArgumentException(),
        null => throw new ArgumentNullException(),
        _ => throw new ArgumentOutOfRangeException()
    };