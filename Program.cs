using System;

class Employee
{
    private string fullName;
    private DateTime birthDate;
    private string phoneNumber;
    private string email;
    private string position;
    private string jobDescription;

    public Employee(string fullName, DateTime birthDate, string phoneNumber, string email, string position, string jobDescription)
    {
        this.fullName = fullName;
        this.birthDate = birthDate;
        this.phoneNumber = phoneNumber;
        this.email = email;
        this.position = position;
        this.jobDescription = jobDescription;
    }

    public void SetFullName(string fullName)
    {
        this.fullName = fullName;
    }

    public string GetFullName()
    {
        return fullName;
    }

    public void SetBirthDate(DateTime birthDate)
    {
        this.birthDate = birthDate;
    }

    public DateTime GetBirthDate()
    {
        return birthDate;
    }

    public void SetPhoneNumber(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public string GetPhoneNumber()
    {
        return phoneNumber;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void SetPosition(string position)
    {
        this.position = position;
    }

    public string GetPosition()
    {
        return position;
    }

    public void SetJobDescription(string jobDescription)
    {
        this.jobDescription = jobDescription;
    }

    public string GetJobDescription()
    {
        return jobDescription;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Phone Number: {phoneNumber}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Job Description: {jobDescription}");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("John Doe", new DateTime(1990, 5, 15), "123-456-7890", "john.doe@example.com", "Software Engineer", "Developing software applications");
        employee.DisplayEmployeeInfo();
    }
}
