using System;
using StudentManager.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace StudentManager.Model
{

    // PARA A CONSOLA 
    //var student = new Student("sofia", "Aula", DateTime.Now);
    //student.Study(2);

    //        Console.WriteLine(student.ToString());

    public class Student : ICanStudy
    {

            private int energy; //valores
            public int Energy //propriedades
            {
                get
                {
                    return energy;
                }
                set
                {
                    if (value < 0) energy = 0;
                    if (value > 100) energy = 100;
                }
            }

            public void Study(int studyHours) //métodos study e rest
            {
                var tot = Energy - studyHours * 10;
                if (tot < 0) Console.WriteLine("Não me apetece estudar mais");
                else
                {
                    Energy = tot;
                    Console.WriteLine($"Estou a estudar {studyHours} horas");
                }
            }

            public void Rest(int restingHours)
            {
                var tot = Energy + restingHours * 10;
                if (tot > 100) Console.WriteLine("Está sol lá fora, não vou dormir mais");
                else
                {
                    Energy = tot;
                    Console.WriteLine("zzzzz");
                }
            }

            private string name;
            //propriedades
            public string Name
            {
                get //assessores
                {
                    return name;
                }
                set
                {
                    if (!string.IsNullOrEmpty(value)) name = value;
                }
            }
            private string @class;
            public string Class 
        { 
            get
            {
                return @class;
            }
            set 
            {
                if (!string.IsNullOrEmpty(value)) @class = value;

            } 
        }

            public DateTime BirthDate { get; set; }


            public int Idade
            {
                get
                {
                    return DateTime.Now.Year - BirthDate.Year;
                }
            }

            public Student(string name, string @class, DateTime birthDate)
            {
                this.name = name;
                this.@class = @class;
                BirthDate = birthDate;
                Energy = 50;
            }

        public override string ToString()
        {
            return $"Nome - {Name} \nTurma - {Class}\nData de Nascimento -{BirthDate.ToString("dd/MM/yyyy")}";
        }




    }
}
