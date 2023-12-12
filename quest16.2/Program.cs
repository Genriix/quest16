struct Train
{
    public string destination;
    public int trainNumber;
    public DateTime departureTime;
}

class Program
{
    static void Main(string[] args)
    {
        Train[] trains = new Train[8];

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Введите информацию о {0}-м поезде:", i + 1);

            Console.Write("Название пункта назначения: ");
            trains[i].destination = Console.ReadLine();

            Console.Write("Номер поезда: ");
            trains[i].trainNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Время отправления (в формате ДД.ММ.ГГ): ");
            trains[i].departureTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yy", null);

            Console.WriteLine();
        }

        Array.Sort(trains, (t1, t2) => t1.trainNumber.CompareTo(t2.trainNumber));

        Console.Write("Введите номер поезда: ");
        int trainNum = Convert.ToInt32(Console.ReadLine());

        bool trainFound = false;

        foreach (Train train in trains)
        {
            if (train.trainNumber == trainNum)
            {
                Console.WriteLine("Название пункта назначения: {0}", train.destination);
                Console.WriteLine("Время отправления: {0}", train.departureTime.ToString("dd.MM.yyyy HH:mm"));
                trainFound = true;
                break;
            }
        }

        if (!trainFound)
        {
            Console.WriteLine("Поезд с таким номером не найден.");
        }

        Console.ReadLine();
    }
}