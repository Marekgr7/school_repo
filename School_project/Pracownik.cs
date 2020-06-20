using System;
using System.Collections.Generic;
using System.Text;

namespace School_project
{
    class Pracownik
    {

        public String Nazwisko { get; set; }
        public String Login { get; set; }
        public String Department { get; set; }
        public String Haslo  { get; set; }

        public Pracownik(string Login, string Nazwisko, string Haslo)
        {
            this.Nazwisko = Nazwisko;
            this.Login = Login;
            this.Haslo = Haslo;
        }

        public void UstawDepartment(String Department)
        {
            this.Department = Department;
        }
    }

}
