using Seminar.LessonThree.TaskOne;

namespace TaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FamilyMember Natalia = new FamilyMember("Наталья", "Д", 51, Gender.female);
            FamilyMember Aleksandr = new FamilyMember("Александр", "Б", 73, Gender.male);
            FamilyMember Nadia = new FamilyMember("Надежда", "Б", 75, Gender.female);
            Natalia.SetFamily(Aleksandr, Nadia);

            FamilyMember Igor = new FamilyMember("Игорь", "Д", 53, Gender.male);
            FamilyMember Evgeny = new FamilyMember("Евгений", "Д", 79, Gender.male);
            FamilyMember Valya = new FamilyMember("Валентина", "Д", 70, Gender.female);
            Igor.SetFamily(Evgeny, Valya);

            FamilyMember Vlad = new FamilyMember("Владислав", "Д", 28, Gender.male);
            FamilyMember Karina = new FamilyMember("Карина", "Д", 23, Gender.female);
            FamilyMember Sofia = new FamilyMember("София", "Д", 0, Gender.female);
            FamilyMember Mark = new FamilyMember("Марк", "Д", 0, Gender.female);
            Vlad.SetFamily(Igor, Natalia, Karina, Sofia, Mark);

            FamilyMember[] grandFather = Vlad.GetGrandFather();
            FamilyMember[] grandMother = Vlad.GetGrandMother();

            foreach (var item in grandFather)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            foreach (var item in grandMother)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

           FamilyMember[] familie =  Vlad.GetImmediateFamily(); 

            foreach (var item in familie)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}");
            }
        }
    }
}
