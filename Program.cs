// See https://aka.ms/new-console-template for more information
namespace InheritanceExamples
{
    class program
    {
        static void Main(string[] args)
        {
            var animalInstance = new Animals();

            animalInstance.NeedSleep = true;

            animalInstance.NumberOfLegs = 4;

            Console.WriteLine("MY Dog");
            var myDog = new Dog();
            myDog.HasOwner = true;
            myDog.NumberOfLegs = 4;
            Console.WriteLine(myDog.NumberOfLegs);
            myDog.Bark();

            Console.WriteLine("=================================================== \n");
            Console.WriteLine("My Cat");
            var myCat = new Cat();  
            myCat.HasOwner = true;
            myCat.NumberOfLegs = 4;
            Console.WriteLine(myCat.NumberOfLegs);
            myCat.HasFur();
        }
    }
}
