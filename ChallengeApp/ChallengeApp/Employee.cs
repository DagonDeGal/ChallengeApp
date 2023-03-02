﻿using ChallengeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Employee
{
    private List<int> score = new List<int>();
    
    public Employee(string name, string surname, string age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public string Age { get; private set;}
     
    public int Result
    {
        get
        {
            return score.Sum();
        }
    }
    public void AddScore(int score)
    {
        this.score.Add(score);
    }
}