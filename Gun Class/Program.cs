using System;

namespace Gun_Class
{
    class Program
    {
        static void Main(string[] args)
        { NewPlace2:
            Gun gun = new Gun();
            Console.WriteLine("Enter the type of the gun");
            gun.Type = Console.ReadLine();
            Console.WriteLine("Enter the your total bullet size");
            gun.TotalBulletSize = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter the magazine size of the gun");
            //gun.MagazineSize = Convert.ToByte(Console.ReadLine());
            Gun.MagazineSize = Convert.ToByte(Console.ReadLine());
        NewPlace:
            Console.WriteLine("Please, choose one of them");
            Console.WriteLine($"1.Shoot \n2.Full Shoot \n3.Reload\n4.Bullet Left \n5.Gun Information \n6.Clear the page \n7.Return to program");
            Console.WriteLine("************************************************************************************************************************");
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
                    goto NewPlace;
                case (byte)GunMenu.Exit:
                    goto NewPlace2;   
            }
        }
    }
}
