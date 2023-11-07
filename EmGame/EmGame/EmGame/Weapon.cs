using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmGame
{
    public enum WeaponType
    {
        PUNCH,
        SWORD,
        BOW,
        MAZE,
        ARROW,
    }
    public class Weapon
    {
        private WeaponType _weaponType;

        public WeaponType? GetWeaponType()
        {
            return _weaponType;
        }
        public int GetWeaponDamage()
        {
            if (_weaponType == WeaponType.PUNCH)
                return 25;
            if (_weaponType == WeaponType.SWORD)
                return 10;
            if( _weaponType == WeaponType.BOW)
                return 3;
            if(_weaponType == WeaponType.MAZE)
                return 15;
            if(_weaponType == WeaponType.ARROW)
                return 6;
            return int.MinValue;
        }


        public double GetWeaponDistance()
        {
            if (_weaponType == WeaponType.PUNCH)
                return 1.5;
            if( _weaponType == WeaponType.SWORD)
                return 3;
            if (_weaponType == WeaponType.BOW)
                return 1.5;
            if (_weaponType == WeaponType.MAZE)
                return 2;
            if (_weaponType == WeaponType.ARROW)
                return 6;
            return -1;
        }


        public static double GetDistance(Warrior w1, Warrior w2)
        {
            return GetDistance(w1.GetX(), w1.GetY(), w2.GetX(), w2.GetY());
        }
        public static double GetDistance(int x1, int y1, int x2, int y2)
        {
            int dx= x2-x1;
            int dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
