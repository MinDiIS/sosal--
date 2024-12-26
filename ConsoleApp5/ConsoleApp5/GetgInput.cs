public static class GetgInput
{
    public static bool GetResponce()
    {
        string text = Console.ReadLine();
        bool result = text switch
        {
            "да" => true,
            "Да" => true,
            "нет" => false,
            "Нет" => false,
            _ => true,
        };
        return result;
    }
}