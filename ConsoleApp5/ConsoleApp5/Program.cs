string[] allQuest = new string[]
{
    "Ты любишь маму?",
    "Ты гей",
    "Ты натурал?",
    "Ты любишь Диму",
    "ты сделал лабу?",
};

while (true)
{
    Huy();
    Console.ReadLine();
}

void Huy()
{

    Random r = new Random();
    int index = r.Next(0, allQuest.Length - 1);

    Console.WriteLine(allQuest[index]);

    bool result = GetgInput.GetResponce();

    Console.Clear();
    if (result)
    {
        Console.WriteLine("Сосал?");
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
        Console.WriteLine("Пидора ответ");
    }
}