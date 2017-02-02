using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    class hospital
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int untreatedPatients = 0;
            int treatedPatients = 0;
            int doctors = 7;

            for (int i = 1; i <= period; i++)
            {
                int patientsPerDay = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        //treatedPatients++;
                        //untreatedPatients--;
                        doctors++;
                    }
                }
                if (doctors >= patientsPerDay)
                {
                    treatedPatients += patientsPerDay;
                }
                else
                {
                    untreatedPatients += patientsPerDay - doctors;
                    treatedPatients += doctors;
                }                
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
