Console.WriteLine("-- Fluxograma de Engenharia --");

Console.WriteLine("O objeto se move? Responda com S/N");
bool resposta1 = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.WriteLine("Deveria se mover?");
bool resposta2 = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

string mensagem;

if (resposta1)
{
    if (resposta2)
    {
       Console.ForegroundColor = ConsoleColor.Green;
       mensagem = "Ótimo, está funcionando perfeitamente!";
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        mensagem = "Use a Silver Tape.";
    }
}

else
{
    if (resposta2)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        mensagem = "Use o WD-40 de preferência!";
    }

    else
    {
      Console.ForegroundColor = ConsoleColor.Green;
      mensagem = "Ótimo, está funcionando perfeitamente!";
    }
}

Console.WriteLine("");
Console.WriteLine(mensagem);
Console.WriteLine("");
Console.ResetColor();