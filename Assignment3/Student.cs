using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Student
    {
        public Student() // Default constructor
        {
            _id = defaultID;
        }

        public Student(string id) // Parameterized sontructor
        {
            _id = id;
        }

        // Fields
        private string _id;
        public const string defaultID = "0000000";
        private string _name;
        private string _major;
        private string _startDate;
        private string _gradDate;
        private string _stateProvTerr;
        private string _country;
        private string _email;
        private string _phone;
        private string _mailAddress;
        readonly List<Student> stuLog = new List<Student>();

        // Methods
        public string ID
        {
            get {
                return _id; }
        }

        public string Name
        {
            get {
                return _name; 
            }
            set { 
                _name = value;
                stuLog.Add(new Student(value));
                Console.WriteLine("Name: " + value);
            }
        }

        public string Major 
        {
            get { return _major; }
            set { 
                _major = value;
                stuLog.Add(new Student(value));
                Console.WriteLine("Major: " + value);
            }
        }

        public string StartDate
        {
            get { return _startDate; }
            set {
                if (value == null)
                    {
                    this._startDate = "2/27/2022";
                    stuLog.Add(new Student(value));
                    Console.WriteLine("Start Date: 2/27/2022");
                } else {
                    _startDate = value;
                    stuLog.Add(new Student(value));
                    Console.WriteLine("Start Date: " + value);
                }
            }
        }

        public string GradDate
        {
            get { return _gradDate; }
            set { 
                _gradDate = value;
                stuLog.Add(new Student(value));
                Console.WriteLine("Anticipated Graduation Date: " + value);
            }
        }

        public string StateProvTerr
        {
            get { return _stateProvTerr; }
            set {
                _stateProvTerr = value;
                stuLog.Add(new Student(value));
                Console.WriteLine("State/Province/Territory: " + value);
            }
        }

        public string Country
        {
            get { return _country; }
            set { 
                _country = value;
                stuLog.Add(new Student(value));
                Console.WriteLine("Country: " + value);
            }
        }

        public string Email
        {
            protected get { return _email; }
            set { 
                _email = value;
                stuLog.Add(new Student(value));
                Console.WriteLine("Email Address: " + value);
            }
        }

        public string Phone
        {
            protected get { return _phone; }
            set { 
                _phone = value;
                stuLog.Add(new Student(value));
                Console.WriteLine("Phone #: " + value);
            }
        }

        public string MailAddress
        {
            protected get { return _mailAddress; }
            set { 
                _mailAddress = value;
                stuLog.Add(new Student(value));
                Console.WriteLine("Mailing Address: " + value);
            }
        }
    }
}
