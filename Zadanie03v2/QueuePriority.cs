using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie03v2
{
    class QueuePriority
    {
        public static void Enqueue(Customer customer, List<Customer> lista)
        {
                lista.Add(customer);
        }


        public static Customer Dequeue(List<Customer> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("W kolejce nie ma już  klientów");
                
                return null;
                
            }
            else
            {
                int index = 0, tmpPriority = 0;
                Customer vip = null;
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].priority > tmpPriority)
                    {
                        tmpPriority = lista[i].priority;
                        vip = lista[i];
                        index = i;
                    }
                }
                lista.RemoveAt(index);
                Console.WriteLine($"Pobrany klient to {vip.fname} {vip.lname} o priorytecie {vip.priority}");
                return vip;
            }
        }

        public static int QueueCount(List<Customer> lista)
        {
            int liczbaElementow;
            liczbaElementow = lista.Count;
            return liczbaElementow;
        }

        public static Hashtable hashtable(List<Customer> lista)
        {
            Hashtable hashtable = new Hashtable();
            int priority1 = 1;
            int priority2 = 2;
            int priority3 = 3;
            int liczbaElementow1 = 0;
            int liczbaElementow2 = 0;
            int liczbaElementow3 = 0;


            foreach (Customer item in lista)
            {
                if (item.priority == priority1)
                {
                    liczbaElementow1++;

                }
            }
            hashtable.Add(priority1.ToString(), liczbaElementow1.ToString());
            foreach (Customer item in lista)
            {
                if (item.priority == priority2)
                {
                    liczbaElementow2++;

                }
            }
            hashtable.Add(priority2.ToString(), liczbaElementow2.ToString());
            foreach (Customer item in lista)
            {
                if (item.priority == priority3)
                {
                    liczbaElementow3++;

                }
            }
            hashtable.Add(priority3.ToString(), liczbaElementow3.ToString());

            return hashtable;
        }
        public static void Wydrukhashtable(Hashtable hashtable)
        {
            Console.WriteLine("W kolejce jest {0} osób o priorytecie \"1\"", hashtable["1"]);
            Console.WriteLine("W kolejce jest {0} osób o priorytecie \"2\"", hashtable["2"]);
            Console.WriteLine("W kolejce jest {0} osób o priorytecie \"3\"", hashtable["3"]);
        }  
    }

}
