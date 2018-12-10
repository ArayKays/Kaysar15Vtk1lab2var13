using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Fundamentals
{
    public class Assignment5
    {
        public string _fullname { get; set; }
        /// <summary>
        /// Функция принимает имя и фамилию.
        /// Если данные будут пусты, в одной из них,
        /// Программа выведет нам исключение, пустой строки.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="surname">Фамилия</param>
        public void Define(string name, string surname)
        {
            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
                throw new ArgumentNullException();

            _fullname = name + " " + surname;
        }

    }
}

