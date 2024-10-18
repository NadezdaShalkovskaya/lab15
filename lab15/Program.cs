using System;

class Program
{
    class HockeyTeam
    {
        public string Name { get; }
        public int PenaltyTime { get; private set; }

        public HockeyTeam(string name)
        {
            Name = name;
            PenaltyTime = 0;
        }

        public void AddPenalty(int minutes)
        {
            PenaltyTime += minutes;
            Console.WriteLine($"{Name}: Текущая сумма штрафного времени: {PenaltyTime} минут.");
        }
    }

    static void Main(string[] args)
    {
        // Создание команд
        HockeyTeam teamA = new HockeyTeam("Команда A");
        HockeyTeam teamB = new HockeyTeam("Команда B");

        // Пример добавления штрафного времени
        teamA.AddPenalty(2);
        teamB.AddPenalty(5);
        teamA.AddPenalty(4);
        teamB.AddPenalty(2);

        // Вывод итогового штрафного времени
        int totalPenaltyTime = teamA.PenaltyTime + teamB.PenaltyTime;
        Console.WriteLine($"\nИтоговое штрафное время: Команда A - {teamA.PenaltyTime} минут, " +
                          $"Команда B - {teamB.PenaltyTime} минут. " +
                          $"Общее штрафное время: {totalPenaltyTime} минут.");

        Console.WriteLine("Игра окончена.");
    }
}