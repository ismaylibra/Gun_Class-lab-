using System;

namespace Gun_Class
{
    class Program
    {
        static void Main(string[] args)
        { NewPlace2:
            Gun gun = new Gun();
            Console.WriteLine("Enter the type of the gun");
            Gun.Type = Console.ReadLine();
            Console.WriteLine("Enter the your total bullet size");
            Gun.TotalBulletSize = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter the magazine size of the gun");
            Gun.MagazineSize = Convert.ToByte(Console.ReadLine());
            gun.BulletLeft = Gun.MagazineSize;
           
        NewPlace:
            Console.WriteLine("Please, choose one of them");
            Console.WriteLine($"\n1. Shoot \n2. Full Shoot \n3. Reload\n4. Bullet Left \n5. Gun Information \n6. Clear the page \n7. Return to program \n8. EXIT");
            Console.WriteLine("\n*****************");
            byte selection = Convert.ToByte(Console.ReadLine());

            switch (selection)
            {
                case (byte)GunMenu.Shoot:
                    gun.Shoot();
                    goto NewPlace;
                case (byte)GunMenu.FullShoot:
                    gun.FullShoot();
                    goto NewPlace;
                case (byte)GunMenu.Reload:
                    gun.Reload();
                    goto NewPlace; ;
                case (byte)GunMenu.BulletLeft:
                    gun.BulletLeftMethod();
                    goto NewPlace; ;
                case (byte)GunMenu.GunInformation:
                    gun.GunInformation();
                    goto NewPlace;
                case (byte)GunMenu.Clear:
                    Console.Clear();
                    goto NewPlace;
                case (byte)GunMenu.Return:
                     goto NewPlace2;
                case (byte)GunMenu.Exit:
                    break;
            }
        }
    }
}
