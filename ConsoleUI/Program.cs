using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


//CarManager carManager = new CarManager(new InMemoryCarDal());

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.Description);
//}


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }

}
