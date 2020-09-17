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
            Customer c4 = new Customer("Zbigniew", "Janowski", 2);
            Customer c5 = new Customer("Karol", "Przybylski", 3);
            
            List<Customer> queue = new List<Customer>();
            //dodawanie do kolejki
            QueuePriority.Enqueue(c1, queue);
            QueuePriority.Enqueue(c2, queue);
            QueuePriority.Enqueue(c3, queue);
            QueuePriority.Enqueue(c4, queue);
            QueuePriority.Enqueue(c5, queue);

            Console.ReadLine();
            //Wydruk statystyk
            Hashtable hashtable = QueuePriority.hashtable(queue);
            QueuePriority.Wydrukhashtable(hashtable);

            //Usuwanie z kolejki
            Customer vip = QueuePriority.Dequeue(queue);
            

            ////Wydruk statystyk
            hashtable = QueuePriority.hashtable(queue);
            QueuePriority.Wydrukhashtable(hashtable);
            


            Console.ReadLine();

            ////Usuwanie z kolejki
            vip = QueuePriority.Dequeue(queue);
            
            ////Wydruk statystyk
            hashtable = QueuePriority.hashtable(queue);
            QueuePriority.Wydrukhashtable(hashtable);
            


            Console.ReadLine();
            ////Usuwanie z kolejki
            vip = QueuePriority.Dequeue(queue);
            
            ////Wydruk statystyk
            hashtable = QueuePriority.hashtable(queue);
            QueuePriority.Wydrukhashtable(hashtable);
            


            Console.ReadLine();
            ////Usuwanie z kolejki
            vip = QueuePriority.Dequeue(queue);
            
            ////Wydruk statystyk
            hashtable = QueuePriority.hashtable(queue);
            QueuePriority.Wydrukhashtable(hashtable);
            


            Console.ReadLine();
            ////Usuwanie z kolejki
            vip = QueuePriority.Dequeue(queue);
            
            ////Wydruk statystyk
            hashtable = QueuePriority.hashtable(queue);
            QueuePriority.Wydrukhashtable(hashtable);
            


            Console.ReadLine();
            ////Usuwanie z kolejki
            vip = QueuePriority.Dequeue(queue);
            
            ////Wydruk statystyk
            hashtable = QueuePriority.hashtable(queue);
            QueuePriority.Wydrukhashtable(hashtable);


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
