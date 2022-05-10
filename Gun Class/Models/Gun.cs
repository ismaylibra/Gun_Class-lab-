using System;

namespace Gun_Class
{
    class Gun
    {
      static string _type;
      public static byte TotalBulletSize;
      public static byte MagazineSize;
       public byte BulletLeft;
       public byte count = 0;
        public static string Type
        {
            get => _type;
            set
            {
                while (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Please, enter the type of the gun");
                    value = Console.ReadLine();
                    _type = value;
                }
            }
        }
       

        public Gun()
        {

        }
       
        public void Shoot()
        {
            BulletLeft = MagazineSize;
            BulletLeft -= count;
           
            if (BulletLeft==0)
            {
                Console.WriteLine($"You don't have bullet, that's why you can't shoot");
                return;
            }
            else
            {
                Console.WriteLine($"You have {--BulletLeft} bullet");
                count++;
            }
            
        }
        public void Reload()
        {
            if (TotalBulletSize == 0)
            {
                Console.WriteLine("You can't reload a gun, because you don't have any bullet");
                return;

            }
            else
            {
                TotalBulletSize -= count;
                BulletLeft = MagazineSize;
                count = 0;
                Console.WriteLine($"You  must reload. You have {TotalBulletSize} bullet");
            }
        }
        public void BulletLeftMethod()
        {
           
            Console.WriteLine($"You have {BulletLeft} bullet");
        }
        
        public void FullShoot()
        {
            if (BulletLeft != 0)
            {
                count = MagazineSize;
                BulletLeft = 0;

                Console.WriteLine($"You have {BulletLeft} bullet");

            }
        }
        public void GunInformation()
        {
            
            Console.WriteLine($"Gun Name: {Type} \nTotal Size: {TotalBulletSize} \nGun's Magazine Size: {MagazineSize} \nBullet Left {BulletLeft}");
        }
    }
}
