public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    
        public string GetStudentName() //  provide Getters for our private member variables so they can be accessed
    {                                   // later both outside the class as well is in derived classes.

        return _studentName; //This GetStudentName() function will be called to main class to get the private student name 
    }

    public string GetTopic() //this will returns the topic
    {
        return _topic;
    }

    public string GetSummary() //this function will returns the both if it is called publicly to any other class.
    {
        return _studentName + " - " + _topic;
    }
}