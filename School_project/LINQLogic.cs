using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School_project
{
    class LINQLogic
    {
        public IOrderedEnumerable<Pracownik> SortujAlfabetycznie(List<Pracownik> pracownicy)
        {
            var myLinqQuery = from pracownik in pracownicy
                              orderby pracownik.Nazwisko
                              select pracownik;

            return myLinqQuery;
        }

        private Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
