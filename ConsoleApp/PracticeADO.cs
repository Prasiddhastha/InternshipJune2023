namespace ConsoleApp;

public class PracticeADO
{
    private static string _connectionString = "Server=ANAYA-PC;Database=ANAYA;User Id=sa;Password=A@nya903";

    public static void CheckConnection()
    {
        try
        {
            SqlConnection conn = new SqlConnection(_connectionString);

            conn.Open();

            Console.WriteLine("Connection to SQL Server successful.");

            conn.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex}");
        }
    }

    public void AddPerson()
    {
        PersonInputDto person = new();

        Console.Write("FirstName: ");
        person.FirstName = Console.ReadLine();

        Console.Write("LastName: ");
        person.LastName = Console.ReadLine();

        Console.Write("Age: ");
        person.Age = Convert.ToInt32(Console.ReadLine());

        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO JuneInternship (FirstName, LastName, Age) VALUES (@firstName, @lastName, @age)";
                    cmd.Parameters.AddWithValue("@firstName", person.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", person.LastName);
                    cmd.Parameters.AddWithValue("@age", person.Age);

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }

            Console.WriteLine("Person added successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error while adding a new person - {ex}");
        }
    }

    public void UpdatePerson()
    {
        PersonDto person = new();

        Console.Write("Enter the Id for the person you want to update: ");
        person.Id = Convert.ToInt32(Console.ReadLine());

        var me = GetPersonById(person.Id);
        if (me is null)
            return;

        Console.Write("FirstName: ");
        person.FirstName = Console.ReadLine();

        Console.Write("LastName: ");
        person.LastName = Console.ReadLine();

        Console.Write("Age: ");
        person.Age = Convert.ToInt32(Console.ReadLine());

        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE JuneInternship SET FirstName = @firstName, LastName = @lastName, Age = @age WHERE Id = @PersonId";
                    cmd.Parameters.AddWithValue("@PersonId", person.Id);
                    cmd.Parameters.AddWithValue("@firstName", person.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", person.LastName);
                    cmd.Parameters.AddWithValue("@age", person.Age);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine($"Person {person.Id} upated successfully");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex}");
        }
    }

    public void GetPeople()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JuneInternship";

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader.GetInt32(reader.GetOrdinal("Id"))}."
                                                  + $"{reader.GetString(reader.GetOrdinal("FirstName"))} "
                                                  + $"{reader.GetString(reader.GetOrdinal("LastName"))} - "
                                                  + $"{reader.GetInt32(reader.GetOrdinal("Age"))}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No Person Available...");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex}");
        }
    }

    private Person GetPersonById(int id)
    {
        if(id <= 0)
        {
            Console.WriteLine($"No person with id 0");
            return null;
        }

        Person person = new();

        try
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JuneInternship WHERE Id = @PersonId";
                    cmd.Parameters.AddWithValue("@PersonId", id);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                person.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                                person.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                person.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                                person.Age = reader.GetInt32(reader.GetOrdinal("Age"));
                               
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No Person with {id} exists.");
                            person = null;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex}");
        }

        return person;
    }
}
