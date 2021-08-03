using System;
using System.Collections.Generic;

namespace GenericMethodSample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //список клиентов
            List<Client> listOfClients = new List<Client>();
            listOfClients.Add(new Client(){Name = "Abrikosov", PassportNumber = "a-11111111"});
            listOfClients.Add(new Client(){Name = "Bulochkin", PassportNumber = "b-22222222"});
            listOfClients.Add(new Client(){Name = "Vinogradov", PassportNumber = "v-33333333"});
            listOfClients.Add(new Client(){Name = "Gorohov", PassportNumber = "g-44444444"});
            listOfClients.Add(new Client(){Name = "Durmanov", PassportNumber = "d-55555555"});

            //список сотрудников
            List<Employee> listOfEmployee = new List<Employee>();
            listOfEmployee.Add(new Employee(){Name = "Acaciev", PassportNumber = "AC-66666666"});
            listOfEmployee.Add(new Employee(){Name = "Bukov", PassportNumber = "BU-77777777"});
            listOfEmployee.Add(new Employee(){Name = "Vyazov", PassportNumber = "VY-88888888"});
            listOfEmployee.Add(new Employee(){Name = "Gingkov", PassportNumber = "GI-99999999"});
            listOfEmployee.Add(new Employee(){Name = "Dubov", PassportNumber = "DU-00000000"});
            
            //поиск клиента из списка клиентов
            Person foundClient = FindPersonByPassportnmber("g-44444444", listOfClients);
            Console.WriteLine(foundClient.ToString());
            
            //поиск сотрудника из списка сотрудников тем же методом
            Person foundEmployee = FindPersonByPassportnmber("BU-77777777", listOfEmployee);
            Console.WriteLine(foundEmployee.ToString());
        }

        //Обобщенынй метод, который ищет Person и его наследников (Client, Employee)
        //в списке List<Person> (List<Client>, List<Employee>)
        public static Person FindPersonByPassportnmber<T>(string PassportNumber, List<T> listOfPersons) where T: Person    //обобщенный метод. работает только с экземплярами и наследниками Person
        {
            Person person = new Person();
            Person newPerson = new Person() {PassportNumber = PassportNumber};
            Person foundPerson = listOfPersons.Find(x => x.Equals(newPerson) );
            return foundPerson;
        }
    }
}