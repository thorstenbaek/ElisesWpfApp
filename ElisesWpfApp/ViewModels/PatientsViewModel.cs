using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElisesWpfApp.ViewModels
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
    }
    public class PatientsViewModel
    {
       public ObservableCollection<Patient> Patients { get; set; }

        public PatientsViewModel()
        {
            Patients = new ObservableCollection<Patient>();
            Patients.Add(new Patient { FirstName = "Elise", LastName = "Christiansen" });
            Patients.Add(new Patient { FirstName = "Thor", LastName = "Stenbæk" });
        }
    }
}
