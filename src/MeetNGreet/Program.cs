using System;

namespace MeetNGreet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.Person _preson = new Person.Person() { Name = "amir", Surname = "yavin", Address = "null" };
            Console.WriteLine("Hello '{0} {1}' of '{2}'! may the force be with you!!!", _preson.Name, _preson.Surname, _preson.Address);
        }
    }
}
