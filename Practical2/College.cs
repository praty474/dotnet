namespace programs.Practical2;

using System;

class Vsic
{

    private string[] faulty;
    private int student;

    public Vsic()
    {
        faulty = new string[0];
        student = 0;
    }

    public string[] Faulty
    {
        get { return faulty; }
        set { faulty = value; }
    }

    public int Student
    {
        get { return student; }
        set { student = value; }
    }


}

