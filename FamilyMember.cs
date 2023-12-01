using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar.LessonThree.TaskOne
{
    //TaskOne
    //Спроектируйте программу для построения генеалогического дерева.Учтите что у нас есть
    //члены семьи у кого нет детей(дет). Есть члены семьи у кого дети есть (взрослые).
    //Есть мужчины и женщины.

    //TaskTwo
    //Доработать предыдущий класс реализовав методы вывода родителей, детей,
    //братьев/сестер(включая двоюродных), бабушеки дедушек.
    //Подумайте как лучше реализовать данные методы.

    //Homework
    //Доработайте приложение генеалогического дерева таким образом чтобы программа выводила
    //на экран близких родственников (жену/мужа). Продумайте способ более красивого вывода
    //с использованием горизонтальных и вертикальных черточек.
    public enum Gender
    {
        male,
        female
    }
    public class FamilyMember
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public Gender Gender { get; private set; }
        public  FamilyMember Mother { get; private set; }
        public FamilyMember Father { get; private set; }

        public FamilyMember Spouse { get; private set; }

        public FamilyMember[] Children { get; private set; }
        public FamilyMember(string firstName, string lastName, int age, Gender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        public FamilyMember[] GetGrandMother()
        {
            return new FamilyMember[] { Mother?.Mother, Father?.Mother };
        }
        public FamilyMember[] GetGrandFather()
        {
            return new FamilyMember[] { Mother?.Father, Father?.Father };
        }
     
        public void SetFamily(FamilyMember father, FamilyMember mother, FamilyMember? spuse = null, params FamilyMember[] children )
        {
            Father = father;
            Mother = mother;
            Spouse = spuse;
            Children = children;
        }
        public FamilyMember[] GetImmediateFamily()
        {
            FamilyMember[] immediateFamily = new FamilyMember[(Spouse!= null? 1:0) + (Children!=null? Children.Length:0)];
            if(Spouse!= null)
            {
                immediateFamily[0] = Spouse;
            }
            if(Children!=null && Spouse != null)
            {
                for (int i = 0; i < Children.Length; i++)
                {
                    immediateFamily[i+1] = Children[i];
                }
            }
            if(Children == null)
            {
                Console.WriteLine("Семьи нет...");
            }
            else if (Spouse == null && Children != null)
            {
                for (int i = 0; i < Children.Length; i++)
                {
                    immediateFamily[i] = Children[i];
                }
            }

            return immediateFamily;
        }

    }
}
