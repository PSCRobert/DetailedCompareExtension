
using System;

namespace ConsoleApplication
{
    public class Employee 
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Title Title { get; set; }
    }

    public enum Title
    {
        Mr, Mrs, Miss, Ms, Dr, Rev, Cllr
    }
}