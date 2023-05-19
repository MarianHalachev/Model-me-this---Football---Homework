namespace Model_me_this___Football___Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Примерен вход
            var player1 = new Striker { Name = "John", Age = 25, Number = 10, Height = 180 };
            var player2 = new Defender { Name = "Michael", Age = 27, Number = 5, Height = 185 };
            var player3 = new Midfielder { Name = "David", Age = 24, Number = 8, Height = 175 };
            var player4 = new Goalkeeper { Name = "Robert", Age = 30, Number = 1, Height = 190 };

            // Създаване на треньор
            var coach = new Coach { Name = "Peter", Age = 45 };

            // Създаване на отбор
            var team = new Team { Coach = coach, FootballPlayers = new List<FootballPlayer> { player1, player2, player3, player4 } };

            // Създаване на съдии
            var referee = new Refree { Name = "David", Age = 40 };
            var assistantReferee1 = new AssistantRefree { Name = "Sarah", Age = 35 };
            var assistantReferee2 = new AssistantRefree { Name = "Mark", Age = 38 };

            // Създаване на мач
            var game = new Game
            {
                Team1 = team,
                Team2 = team,
                Refree = referee,
                AssistantRefrees = new List<AssistantRefree> { assistantReferee1, assistantReferee2 },
                Goals = new List<Goal>
    {
        new Goal { Minute = 15, FootballPlayer = player1 },
        new Goal { Minute = 30, FootballPlayer = player2 }
    },
                Result = "2-1",
                Winner = "Team1"
            };

            // Извеждане на информация за мача
            Console.WriteLine("Game Result:");
            Console.WriteLine($"Team1 vs Team2: {game.Result}");
            Console.WriteLine($"Winner: {game.Winner}");
            Console.WriteLine("Goals:");
            foreach (var goal in game.Goals)
            {
                Console.WriteLine($"Minute: {goal.Minute}, Player: {goal.FootballPlayer.Name}");
            }

            // Извеждане на информация за отбора
            Console.WriteLine("Team Information:");
            Console.WriteLine($"Coach: {team.Coach.Name}");
            Console.WriteLine($"Number of Players: {team.FootballPlayers.Count}");
            Console.WriteLine($"Average Player Age: {team.AveragePlayerAge()}");
        }
    }
}