namespace Parte1;

public class Simplify
{
    public string Combo(string Message)
    {
        Console.WriteLine(Message);
        string Imput = Console.ReadLine()!;
        return Imput;
    }

    public string Text(string Message)
    {
        Console.WriteLine(Message);
        return Message;
    }

    public string Imput()
    {
        string Replay = Console.ReadLine()!;
        return Replay!;
    }

    // public string CallCombo(string ConsoleCombo)
    // {
    //     var CallSimplify = new Simplify();
    //     string Replay = CallSimplify.Combo(ConsoleCombo);
    //     return Replay;
    // }

    // public string CallText(string ConsoleText)
    // {
    //     var CallSimplify = new Simplify();
    //     string Replay = CallSimplify.Text(ConsoleText);
    //     return Replay;
    // }

    // public string CallImput()
    // {
    //     var CallSimplify = new Simplify();
    //     string Replay = CallSimplify.Imput();
    //     return Replay;
    // }
}
