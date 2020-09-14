using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Zadanie03v2
{
    class Program
    {

        static void Main(string[] args)
        {
            Customer c1 = new Customer ("Jan","Kowalski",1);
            Customer c2 = new Customer ("Andrzej","Maj",2);
            Customer c3 = new Customer("Marek", "Markowski", 3);
            Customer c4 = new Customer("Zbigniew", "Janowski", 1);
            Customer c5 = new Customer("Karol", "Przybylski", 2);
            
            List<Customer> QueuePriority = new List<Customer>();
            //dodawanie do kolejki
            Customer.Enqueue(c1, QueuePriority);
            Customer.Enqueue(c2, QueuePriority);
            Customer.Enqueue(c3, QueuePriority);
            Customer.Enqueue(c4, QueuePriority);
            Customer.Enqueue(c5, QueuePriority);
            //Wydruk statystyk
            Hashtable hashtable = Customer.Hashtable(QueuePriority);
            Customer.Wydrukhashtable(hashtable);
            foreach (Customer item in QueuePriority)
            {
                Console.WriteLine($"{item.Fname} \t {item.Lname} \t {item.priority}");
            }
            //Usuwanie z kolejki
            Customer vip = Customer.Dequeue(QueuePriority);
            Console.WriteLine($"Pobrany klient to {vip.fname} {vip.lname} o priorytecie {vip.priority}");

            //Wydruk statystyk
            hashtable = Customer.Hashtable(QueuePriority);
            Customer.Wydrukhashtable(hashtable);
            foreach (Customer item in QueuePriority)
            {
                Console.WriteLine($"{item.Fname} \t {item.Lname} \t {item.priority}");
            }

            Console.ReadLine();
            
            //Usuwanie z kolejki
            vip = Customer.Dequeue(QueuePriority);
            Console.WriteLine($"Pobrany klient to {vip.fname} {vip.lname} o priorytecie {vip.priority}");
            //Wydruk statystyk
            hashtable = Customer.Hashtable(QueuePriority);
            Customer.Wydrukhashtable(hashtable);
            foreach (Customer item in QueuePriority)
            {
                Console.WriteLine($"{item.Fname} \t {item.Lname} \t {item.priority}");
            }

            Console.ReadLine();


            ///////Brudnopis do debugowania
            /*
            hashtable = Customer.Hashtable(QueuePriority);
            Customer.Wydrukhashtable(hashtable);

            foreach (Customer item in QueuePriority)
            {
                Console.WriteLine($"{item.Fname} \t {item.Lname} \t {item.priority}");
            }
            Console.WriteLine(Customer.QueueCount(QueuePriority).ToString() ); 
            Console.ReadLine();
            hashtable = Customer.Hashtable(QueuePriority);
            Customer.Wydrukhashtable(hashtable);
            vip = Customer.Dequeue(QueuePriority);
            Console.WriteLine($"Pobrany klient to {vip.fname} {vip.lname} o priorytecie {vip.priority}");
            foreach (Customer item in QueuePriority)
            {
                Console.WriteLine($"{item.Fname} \t {item.Lname} \t {item.priority}");
            }
            Console.WriteLine(Customer.QueueCount(QueuePriority).ToString());
            
            Console.WriteLine(hashtable.Count);
            Console.WriteLine();
            Console.WriteLine("W kolejce jest {0} osób o priorytecie \"1\"", hashtable["1"]);
            Console.WriteLine();
            Console.ReadLine();


            vip = Customer.Dequeue(QueuePriority);
            Console.WriteLine($"Pobrany klient to {vip.fname} {vip.lname} o priorytecie {vip.priority}");
            foreach (Customer item in QueuePriority)
            {
                Console.WriteLine($"{item.Fname} \t {item.Lname} \t {item.priority}");
            }
            Console.WriteLine(Customer.QueueCount(QueuePriority).ToString());
            Console.ReadLine();
            
            vip =Customer.Dequeue(QueuePriority);
            Console.WriteLine($"Pobrany klient to {vip.fname} {vip.lname} o priorytecie {vip.priority}");
            foreach (Customer item in QueuePriority)
            {
                Console.WriteLine($"{item.Fname} \t {item.Lname} \t {item.priority}");
            }
            Console.WriteLine(Customer.QueueCount(QueuePriority).ToString());
            Console.ReadLine();*/
        }


    }
}
