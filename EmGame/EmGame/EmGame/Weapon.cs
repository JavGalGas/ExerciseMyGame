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
                return 5;
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
    }
}
