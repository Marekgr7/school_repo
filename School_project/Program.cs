using System;
using System.Collections.Generic;

namespace School_project
{
    class Program
    {

        static List<Pracownik> DUMMY_EMPLOYEES = new List<Pracownik>{
            new Pracownik("Mark", "Hunt", "tester"),
            new Pracownik("Goerge", "StPierre", "tester")
            };


        static void Main(string[] args)
        {
            
            DUMMY_EMPLOYEES[0].UstawDepartment("HR");
            DUMMY_EMPLOYEES[1].UstawDepartment("IT");


            // |Ten Uzytkownik rzuci wyjatek, gdyz juz istnieje
            try
            {
                dodajPracownika("Mark", "Hunt", "tester", "HR");
            } catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }

            // Ten uzytkownik zostanie dodany
            try
            {
                dodajPracownika("Nate", "Diaz", "testero", "IT");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }

            Console.Out.WriteLine("Lista pracownikow : ");

            Pracownik nate = DUMMY_EMPLOYEES.Find((p) => { return p.Login == "Nate"; });

            Console.WriteLine("Pracownik nate to " + nate.Login);
            
            foreach (Pracownik p in DUMMY_EMPLOYEES)
            {
                Console.Out.WriteLine($"login: {p.Login}, nazwisko: {p.Nazwisko}");
            }

            Console.Out.WriteLine();

        }

        static void dodajPracownika(String login, String nazwisko, String haslo, String department)
        {

            if (haslo.Length < 6 || DUMMY_EMPLOYEES.Find((p) => { return p.Login == login; }) != null)
            {
                if (DUMMY_EMPLOYEES.Find((p) => { return p.Login == login; }) != null)
                {
                    throw new Exception("Dany uzytkownik o tym loginie juz istnieje");
                }

                throw new Exception("Haslo powinno miec minimum 6 znakow"); 
            }
            else
            {
                Console.Out.WriteLine("Pracownik zostaje utworzony");

                DUMMY_EMPLOYEES.Add(new Pracownik(login, nazwisko, haslo));
                DUMMY_EMPLOYEES[DUMMY_EMPLOYEES.Count - 1].UstawDepartment(department);
            }

        }

        void ustawDepartment(String login, String department)
        {
            Pracownik pracownik = DUMMY_EMPLOYEES.Find((p) => { return p.Login == login; });
            pracownik.UstawDepartment(department);
        }
    }
}

