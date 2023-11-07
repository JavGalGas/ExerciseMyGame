using System.Security.Cryptography.X509Certificates;

namespace EmGame
{
    public class WarZone
    {
        private int _width=10, _height=10;

        public WarZone(int width, int height)
        {
            _width=width;
            _height=height;
        }

        private List<Warrior> _warriors=new List<Warrior>();
        public List<Warrior> GetWarriorList()
        {
            return _warriors;
        }
        public void CreateWarrior(int count, TeamType type)
        {
            for(int i = 0; i < count; i++)
            {
                Warrior warrior = new Warrior(1,1,100,0.6,1,0.8, type);
                _warriors.Add(warrior);
            }
        }
        public List<Warrior> RemoveAt(int index)
        {
            List<Warrior> List1= GetWarriorList();
            List1.RemoveAt(index);
            return List1;

        }
        public void MoveWarrior(List<Warrior> list, int x, int y)
        {
           return;
        }

        public void ExecuteRound(WarZone zone)
        {
            return;
        }
        public Warrior? GetWarriorAt(int x, int y) //en el WarZone
        {
            return null;
        }

        public int GetWarriorCount()
        {
            return _warriors.Count;
        }
        public Warrior? GetWarriorAt(int index) // en la lista
        {
            return null;
        }

        public int GetEnemiesArroundCount(int x, int y, TeamType team)
        {
            return 0;
        }

        public int GetPlayersArround(int x, int y)
        {
            return 0;
        }

        public List<Warrior> GetWarriorsSortedByDistance(int x, int y)
        {
            return new List<Warrior>();
        }
        public List<Warrior> GetWarriorsInside(int x, int y, int x2, int y2)
        //public List<Warrior> GetWarriorsInside(int x, int y, int w, int h)
        {
            
            return new List<Warrior>();
        }
        //Ver como conseguir que MoveWarrior llame a un solo guerrero
        public void IsBattleFinished()
        {

        }
    }
}
