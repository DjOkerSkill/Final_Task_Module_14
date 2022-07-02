using System;
using System.Collections.Generic;
using System.Linq;

namespace Final_Task_Module_14
{
    internal class Program
    {
        public class Contact 
        { 
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public long PhoneNumber { get; set; }
            
            public Contact (string name, string lastName, long phoneNumber, string email) 
            {
                Name = name;
                LastName = lastName;
                PhoneNumber = phoneNumber;
                Email = email;
            }
        }
        
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();
            
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
        

            var query = from item in phoneBook
                        orderby item.Name, item.LastName
                        select item;

            foreach (var item in query)
                Console.WriteLine(item.Name+" "+ item.LastName+" "+ item.Email+" "+item.PhoneNumber);
           

        }
    }
}
