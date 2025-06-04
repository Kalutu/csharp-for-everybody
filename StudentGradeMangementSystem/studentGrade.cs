 using System;
using System.Collections.Generic;

class Student 
{
   
    public string Name { get; set; }
    public int StudentId { get; set; }
    public List<double> Grades { get; set; } 
    
    public Student(string name, int studentId)
    {
        Name = name;
        StudentId = studentId;
        Grades = new List<double>();  
    }
    
   
    public void AddGrade(double grade)  
    {
    
        if (grade >= 0 && grade <= 100)
        {
            Grades.Add(grade);  
        }
        else
        {
            Console.WriteLine("Grade must be between 0 and 100");
        }
    }

    public double CalculateAverage() 
    {
        if (Grades.Count == 0) 
            return 0;
            
        double sum = 0;
        for (int i = 0; i < Grades.Count; i++) 
        {
            sum += Grades[i];
        }
        return sum / Grades.Count;
    }
    

    public char GetLetterGrade() 
    {
        double avg = CalculateAverage();
        
        if (avg >= 90 && avg <= 100)
            return 'A';
        else if (avg >= 80 && avg < 90)  
            return 'B';
        else if (avg >= 70 && avg < 80)
            return 'C';
        else if (avg >= 60 && avg < 70)
            return 'D';
        else
            return 'F';
    }
    

    public void DisplayInfo() 
    {
        Console.WriteLine($"Name: {Name}");  
        Console.WriteLine($"Student ID: {StudentId}");
        Console.Write("Grades: ");
        
        for (int i = 0; i < Grades.Count; i++) 
        {
            Console.Write(Grades[i]);
            if (i < Grades.Count - 1)  
                Console.Write(", ");
        }
        Console.WriteLine();  
        Console.WriteLine($"Average: {CalculateAverage()}");  
        Console.WriteLine($"Letter Grade: {GetLetterGrade()}");
    }
}

class StudentGradeSystem 
{
    static void Main() 
    {
      
        Student aman = new Student("Aman", 201000004);
        
       
        aman.AddGrade(85);
        aman.AddGrade(92);
        aman.AddGrade(78);
        
       
        aman.DisplayInfo();
        
       
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}