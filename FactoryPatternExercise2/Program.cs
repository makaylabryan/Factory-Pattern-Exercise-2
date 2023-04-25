namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database would you like to use: List, SQL, or Mongo?");
            string databaseAccess = Console.ReadLine();

            IDataAccess database = DataAccessFactory.GetDataAccessType (databaseAccess);
            database.LoadData();
            database.SaveData();
            Console.ReadLine();
        }
    }
}
