using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Weapon
    {
        public int Weight { get; set; }
        public int HitPoint { get; set; }
       //public int BulletsCount { get; set; } Bıçağın mermisi olmaz buraya bu yüzden mermi yazılmaz
       //public int MaxCharger { get; set; }
       public virtual void Attack() 
        {
            Console.WriteLine($"Oyuncu {this.GetType().Name} ile saldırdı.");
        }
    }
    public class Knife : Weapon
    {
        
    }
    public class Gun : Weapon 
    {
        public int BulletsCount { get; set; }
        public int MaxCharger { get; set; }
        public void ChangeCharger() 
        {
            Console.WriteLine($"Oyuncu {this.GetType().Name} şarjörünü değiştirdi...");

        }
    }
    public class Sniper : Gun 
    {
        public int Distance { get; set; }
        public override void Attack()
        {
            base.Attack();
        }
    }
    public class MachineGun : Gun 
    {
        public bool Zoom { get; set; }
    }
    public class Shotgun : Gun 
    {
        public int SpesificProperty { get; set; }
    }
    public class Ak47 : MachineGun 
    {
      //  Console.WriteLine("Oyuncu Ak47 ile saldırdı.");
    }
}
