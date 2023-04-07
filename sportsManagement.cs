using Microsoft.Data.SqlClient;

namespace sportsManagement
{
    internal class Program
    {
        static void addSport(int sport_id,string sport_name, SqlConnection conn)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO sports VALUES ({sport_id},'{sport_name}')";
            cmd.ExecuteReader().Close();
            Console.WriteLine($"{sport_name}is added to the sports table");
        }

        static void addScoreboard(int tournament_id,int  sport_id, int winner_player_id,int score, SqlConnection conn)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO scoreboard VALUES ({tournament_id},{sport_id},{winner_player_id},{score})";
            cmd.ExecuteReader().Close();
            Console.WriteLine("new row is added to the scoreboard table");
        }

        static void addTournament(int tournament_id, int sport_id, int college_id, SqlConnection conn)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"INSERT INTO tournament VALUES ({tournament_id},{sport_id},{college_id})";
            cmd.ExecuteReader().Close();
            Console.WriteLine($"new tournament is added to the tournaments table");
        }

        static void removeSport(int sport_id, SqlConnection conn)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM sports WHERE sport_id = {sport_id}";
            cmd.ExecuteReader().Close();
            Console.WriteLine($"sport {sport_id} is removed");
        }

        static void updateScoreBoard(int tournament_id, int sport_id, int upadated_score, SqlConnection conn)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE scoreboard SET score = {upadated_score} WHERE tournament_id = {tournament_id} AND sport_id = {sport_id}";
            cmd.ExecuteReader().Close();
            Console.WriteLine($"new scores are updated in the scoreboard");
        }

        static void removePlayer(int player_id, SqlConnection conn)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM players WHERE player_id= {player_id}";
            cmd.ExecuteReader().Close();
            Console.WriteLine($"player {player_id} has been removed");
        }

        static void removeTournament(int tournament_id, int sport_id, SqlConnection conn)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM tournament WHERE tournament_id= {tournament_id}";
            cmd.ExecuteReader().Close();
            Console.WriteLine($"tournament {tournament_id} has been removed");
        }


        static void Main(string[] args)
        {
            string CONN_STRING = "Data Source=DESKTOP-ESRRQ99;Initial Catalog = college sports management;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(CONN_STRING);
            conn.Open();

            Console.WriteLine("press 1 to add a new sport ");
            Console.WriteLine("press 2 to add the scoreboard ");
            Console.WriteLine("press 3 to add a new tournament ");
            Console.WriteLine("press 4 to remove a sport ");
            Console.WriteLine("press 5 to update the scoreboard ");
            Console.WriteLine("press 6 to a remove player");
            Console.WriteLine("press 7 to a remove a tournament");



            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                Console.WriteLine("Enter the sport id ");
                int sport_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the sport name ");
                string sport_name = Console.ReadLine();
                
                addSport(sport_id, sport_name,conn);
            }
            else if(choice == 2)
            {
                Console.WriteLine("Enter the tournament id ");
                int tournament_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the sport id ");
                int sport_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the winner player's id ");
                int winner_player_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the score");
                int score  = Convert.ToInt32(Console.ReadLine());

                addScoreboard(tournament_id, sport_id, winner_player_id,score,conn);
            }
            else if(choice == 3)
            {
                Console.WriteLine("Enter the tournament id ");
                int tournament_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the sport id ");
                int sport_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the college id ");
                int college_id = Convert.ToInt32(Console.ReadLine());

                addTournament(tournament_id, sport_id, college_id, conn);
            }
            else if(choice == 4)
            {
                Console.WriteLine("Enter the sport id ");
                int sport_id = Convert.ToInt32(Console.ReadLine());

                removeSport(sport_id, conn);
            }
            else if(choice == 5)
            {
                Console.WriteLine("Enter the tournament id ");
                int tournament_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the sport id ");
                int sport_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the updated score ");
                int upadated_score = Convert.ToInt32(Console.ReadLine());
               
                updateScoreBoard(tournament_id, sport_id, upadated_score, conn);
            }
            else if(choice == 6)
            {
                Console.WriteLine("Enter the player id");
                int player_id = Convert.ToInt32(Console.ReadLine());

                removePlayer(player_id, conn);
            }
            else if(choice == 7)
            {
                Console.WriteLine("Enter the tournament id ");
                int tournament_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the sport id ");
                int sport_id = Convert.ToInt32(Console.ReadLine());
                

                removeTournament(tournament_id, sport_id, conn);
            }


        }
    }
}