//Derived class

public class WritingAssignment : Assignment
{
    //Attributes
    private string _title = "";

    //Getters


    //Setters 


    //Constructors
    public WritingAssignment(string studentName,string topic, string title) : base(studentName,topic)
    {
        _title = title;
    }

    //Methods
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

}