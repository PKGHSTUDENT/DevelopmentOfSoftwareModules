namespace PR_5
{
    class Student
    {
        private string _name;
        private string _lastname;
        private int _age;
        private int _course;

        public Student(string lastname, string name, int age, int course)
        {
            _lastname = lastname;
            _name = name;
            _age = age;
            _course = course;
        }

        public void SetLastname(string lastname) { _lastname = lastname; }
        public void SetName(string name) { _name = name; }
        public void SetAge(int age) { _age = age; }
        public void SetCourse(int course) { _course = course; }
        public string GetName() { return _name; }
        public string GetLastname() { return _lastname; }
        public int GetAge() { return _age; }
        public int GetCourse() { return _course; }

        /// <summary>
        /// Displays student information
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("+----------------------------+\n" +
                              "|          Student           |\n" +
                              "+----------------------------+\n\n" +
                              $"First/last name: {_name}/{_lastname}\n" +
                              $"Age: {_age}\n" +
                              $"Course: {_course}\n";
        }
    }
}
