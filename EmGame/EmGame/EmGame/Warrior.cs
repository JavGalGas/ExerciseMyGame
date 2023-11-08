﻿using System.Security.Cryptography.X509Certificates;

namespace EmGame
{
    public enum TeamType
    {
        HUMAN,
        DWARF,
        ORC,
        ELF,
        GNOME,
        DEMON,

    }
    public class Warrior
    {
        private int _x, _y;
        private int _life;
        private double _accuracity;
        private int _armor;
        private double _lucky;
        private TeamType _team;
        private int cooldown;
        public Warrior(int x, int y, int life, double accuracity, int armor, double lucky, TeamType teamType)
        {
            _x=x;
            _y=y;
            _life=life;
            _accuracity=accuracity;
            _armor=armor;
            _lucky=lucky;
            _team=teamType;
        }
        

        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }
        public int GetLife()
        {
            return _life;
        }
        public double GetAccuracity()
        {
            return _accuracity;
        }
        public int GetArmor()
        {
            return _armor;
        }
        public  double GetLucky()
        {
            return _lucky;
        }
        public TeamType GetTeam()
        {
            return _team;
        }


        public void ExecuteTurn(WarZone zone)
        {

        }


        public void Move()
        {

        }

        
    }
   
        
    
}
