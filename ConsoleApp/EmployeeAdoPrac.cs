
namespace ConsoleApp
{
    public class EmployeeAdoPrac
    {
       private static string connectionString = @"Server=MercylessBeast\SQLEXPRESS;Database=JuneInternship;Trusted_Connection=True;";

        public static void CheckConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);

                conn.Open();

                Console.WriteLine("Connection to SQL Server is successful lets go.");

                conn.Close();
            }
            catch (Exception msg)
            {
                Console.WriteLine($"Error Message: {msg}");
            }
        }
        public static void AddEmployee()
        {
            EmployeeInputDto employee = new();

            Console.Write("Enter FirstName:");
            employee.FirstName = Console.ReadLine();
            Console.Write("Enter LastName:");
            employee.LastName = Console.ReadLine();
            Console.Write("Enter Age:");
            employee.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary:");
            employee.Salary = Convert.ToInt32(Console.ReadLine());

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "Insert Into Employee (FirstName,LastName,Age,Salary)  Values (@firstname,@lastname,@age,@salary)";
                        command.Parameters.AddWithValue("@firstname", employee.FirstName);
                        command.Parameters.AddWithValue("@lastname", employee.LastName);
                        command.Parameters.AddWithValue("@age", employee.Age);
                        command.Parameters.AddWithValue("@salary", employee.Salary);
                        connection.Open();
                        command.ExecuteNonQuery();
                      
                    }
                }
                Console.WriteLine("Employee added Succesfully in your database");
               
            }
            catch (Exception msg)
            {
                Console.WriteLine($"Error:{msg}");
            }

        }

        public static void UpdateEmployee()
        {
            EmployeeDto employee = new();
            A: Console.Write("Enter the id of Employee You Want to update:");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            var storeId = GetEmployeeById(employee.Id);

            if (storeId is null)
            {
                return;
            }
           
                Console.Write("Enter FirstName:");
                employee.FirstName = Console.ReadLine();

                Console.Write("Enter LastName:");
                employee.LastName = Console.ReadLine();

                Console.Write("Enter Age:");
                employee.Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Salary:");
       


            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    using(SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = $"Update Employee SET FirstName = @firstName, LastName = @lastName, Age = @age,Salary =@salary WHERE Id = @EmployeeId" ;
                        command.Parameters.AddWithValue("@EmployeeId", employee.Id);
                        command.Parameters.AddWithValue("@firstName",employee.FirstName);
                        command.Parameters.AddWithValue("@lastName", employee.LastName);
                        command.Parameters.AddWithValue("@age", employee.Age);
                        command.Parameters.AddWithValue("@salary", employee.Salary);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("Updated");
             
                }
            }
            catch(Exception msg)
            {
                Console.WriteLine(msg.ToString());
            }
        }

        public static Employee GetEmployeeById(int id)
        {
            Employee employee = new();
            if(id<=0)
            {
                Console.WriteLine("Doesn't exist");
                return null;
            }
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    using(SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "Select Id,FirstName,LastName,Age,Salary From Employee Where Id=@EmployeeId";
                            command.Parameters.AddWithValue("@EmployeeId", id);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    employee.Id = reader.GetInt32(0);
                                    employee.FirstName = reader.GetString(1);
                                    employee.LastName = reader.GetString(2);
                                    employee.Age = reader.GetInt32(3);
                                    employee.Salary = reader.GetInt32(4);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No Person with Id = {id} exists.");
                                employee = null;
                                
                            }
                        }

                    }
                   
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error:{ex}");
            }
            return employee;
        }

        public static void GetEmployee()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM Employee";

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine($"{reader.GetInt32(0)}."
                                                      + $"{reader.GetString(1)} "
                                                      + $"{reader.GetString(2)}-"
                                                      + $"{reader.GetInt32(3)}-"
                                                      + $"{reader.GetInt32(4)}");
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
            catch (Exception msg)
            {
                Console.WriteLine($"Error: {msg}");
            }
        }

        public static void DeleteEmployee()
        {
            GetEmployee();
            EmployeeDto employee = new();
            Console.Write("Enter the id of Employee You Want to Delete:");
            employee.Id = Convert.ToInt32(Console.ReadLine());
            var storeId = GetEmployeeById(employee.Id);
            if (storeId is null)
                return;
            //storeId.FirstName = employee.FirstName;
            //storeId.LastName = employee.LastName;
            //storeId.Age = employee.Age;
            //storeId.Salary = employee.Salary;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = $"Delete From Employee  WHERE Id = @EmployeeId";
                        command.Parameters.AddWithValue("@EmployeeId",employee.Id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Deleted successfully");
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
            }
        }
    }
}
