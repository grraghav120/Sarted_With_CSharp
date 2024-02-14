namespace ConsoleApp1
{
    public class Person
    {
        string fName, lName;
        public Person(string firstName, string lastName)
        {
            this.fName = firstName;
            this.lName = lastName;
        }
        public string fullName()
        {
            return fName + " " + lName;
        }
    }
}
