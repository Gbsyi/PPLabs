using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLogger
{
    //Для примера добавим класс Person
    public class Person
    {
        private Logger _logger = Logger.GetLogger();
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Age = age;
            Name = name;
            _logger.Log("Создан объект \'Person\':",Name, Age );
        }
        public void GetAge()
        {
            _logger.Log("Получен возраст человека с именем: ", Name);
        }
    }
}
