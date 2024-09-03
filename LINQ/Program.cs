using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("College Football Mascots:\n");

            var collegeTeams = new List<string>() { "Huskers", "Hawkeyes", "Sooners", "Longhorns", "Crimson Tide", "Buckeyes", "Ducks", "Bruins" };

            var orderCollegeTeams = collegeTeams.OrderByDescending(x => x.Length).ToList();
            orderCollegeTeams.ForEach(x => Console.WriteLine(x));
        }
    }

}
