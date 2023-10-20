using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorOffice
{
    public partial class Medics
    {
        public string Fullname {
            get { return $"{Name}, {Surname} ({NumberTuition})"; }
        }
        
        public override string ToString()
        {
            return $"Nombre: {Name}\nApellido: {Surname}\nNro. Matricula: {NumberTuition}";
        }
    }
}
