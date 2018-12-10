using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment4
    {
        public string _fullname { get; set; }
        /// <summary>
        /// Функция получает имя и фамилию и объединяет их.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        public void Define(string name, string surname)
        {
            _fullname = name + " " + surname;
        }

    }
}
