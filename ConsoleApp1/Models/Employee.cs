﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Employee
    {
        string _name;
        string _surname;
        string _username ;
       
        int _age;

        public Employee(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            Age = age;
            _username = _name + " " + _surname;
        }

        public int Age 
        { 
            get => _age; 
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("yasi duzgun daxil edin");
                }
            }     
        }

        public string Username 
        { get => _username;
            set
            {
                _username = value;
            } 
        }

        //public int Name
        //{
        //    get => _name;
        //    set
        //    {
        //        _name = _name[0].ToUpper();

        //    }
        //}


    }
}
