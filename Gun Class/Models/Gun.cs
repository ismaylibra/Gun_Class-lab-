using System;

namespace Gun_Class
{
    class Gun
    {
        public string Type;
        public byte TotalBulletSize;
        public static byte MagazineSize;
        public byte BulletLeft;
        byte count = 0;
        public Gun()
        {

        }
        public Gun(string type, byte totalsize)
        {
            Type = type;
            TotalBulletSize = totalsize;
        }
        public void Shoot()
        {
            BulletLeft = MagazineSize;
            BulletLeft -= count;
            if (BulletLeft == 0)
            {
                Console.WriteLine("your magazine is empty, you must reload");
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
                BulletLeft += count;
                
                count = 0;

                Console.WriteLine($"You  must reload. You have {TotalBulletSize} bullet");
            }
        }
        public void BulletLeftMethod()
        {
            MagazineSize = BulletLeft;
            Console.WriteLine($"You have {BulletLeft} bullet");
        }
        public void GunInformation()
        {
            Console.WriteLine($"Gun Name: {Type} \nTotal Size: {TotalBulletSize} \nGun's Magazine Size: {MagazineSize} \nBullet Left {BulletLeft}");
        }
        public void FullShoot()
        {
            if (BulletLeft != 0)
            {
                TotalBulletSize -= BulletLeft;
                BulletLeft = MagazineSize;
                BulletLeft = 0;

                Console.WriteLine($"You have {BulletLeft} bullet");

            }
        }
    }
}
