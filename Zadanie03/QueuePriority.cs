using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie03
{
    class QueuePriority
    {
        QueuePriority queue = new QueuePriority();

        private List<Customer> lista = new List<Customer>();

        public void Enqueue (Customer customer)
        {
            lista.Add(customer);
        }
        public void Dequeue ()
        {
            foreach (customer item in lista)
            {

            }
        }

    }
}
