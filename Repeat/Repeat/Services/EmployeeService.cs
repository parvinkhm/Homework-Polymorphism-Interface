using Repeat.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat.Services
{
    internal class EmployeeService : IEmployeeService
    {
        public void Search(string serachText)
        {
            string[] employees = { "Pervin", "Sheref", "Cahangir", "fidan", "Kubra" };
            foreach (var item in employees)
            {
                if (item.Contains(serachText))
                {
                    Console.WriteLine(item);
                } 
            }
        }
    }
}
