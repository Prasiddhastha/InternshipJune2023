global using EntityPrac.Data;
using EntityPrac.Models;

Customer customer = new Customer();
DataContext context = new DataContext();
Practice practice = new Practice(context);
A: Console.WriteLine("----What you want to do----");
Console.WriteLine("\n1.AddCustomer\t 2.GetCustomer\n3.Update\t4.Delete\n5.GetCustomerbyID\n");
Console.Write("Enter your option:");
var choose = Console.ReadLine();

switch (choose)
{
    case "1":
        Console.Clear();
        practice.AddCustomers(customer);
        
        break;
    case "2":
        Console.Clear();
        practice.GetCustomers();
        break;
    case "3":
        Console.Clear();
       
        practice.Update(customer);
        break;
    case "4":
        Console.Clear();
        practice.Delete(customer);
        break;
    case "5":
        Console.Clear();
        practice.GetCustomerById(customer);
        break;
    default:
        Console.Clear();
        Console.WriteLine("Wrong input");
        break;
}
Console.ReadLine();
Console.Clear();
goto A;
