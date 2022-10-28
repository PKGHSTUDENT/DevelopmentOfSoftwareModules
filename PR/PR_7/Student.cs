namespace PR_7
{
    public class Student
    {
        private string _lastName;
        private string _firstName;
        private int _age;
        private int _course;

        public string FirstName
        {
            get { return (_firstName != "") ? _firstName : "John"; }
            set => _firstName = (value != "") ? value.ToUpper() : "John";
        }

        // Mod No.2
        public string LastName
        {
            get { return (_lastName != "") ? _lastName : "Doe"; }
            set => _lastName = (value != "") ? value.ToUpper() : "Doe";
        }

        // Mod No.2
        public int Age
        {
            get => _age;
            set { _age = (value < 15 || value > 35) ? 15 : value; }
        }

        public int Course
        {
            get => _course;
            set { _course = (value < 1 || value > 4) ? 0 : value; }
        }

        // Mod No.3
        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="firstName">Student name.</param>
        /// <param name="lastName">Student's last name.</param>
        /// <param name="age">Student age.</param>
        /// <param name="course">Student course.</param>
        public Student(string firstName, string lastName, int age, int course)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Course = course;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Student {FirstName} {LastName} {Age} years, course {Course}");
        }


    }
}
