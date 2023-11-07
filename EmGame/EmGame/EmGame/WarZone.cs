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

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
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
        //public List<Warrior> RemoveAt(int index)
        //{
        //    List<Warrior> List1= _warriors;
        //    List1.RemoveAt(index);
        //    return List1;
        //}
        public void MoveWarrior(List<Warrior> list, int x, int y)
        {
           return;
        }

        public void ExecuteRound(WarZone zone)
        {
            for(int i=0; i< _warriors.Count; i++)
            {
                Warrior warrior= _warriors[i];
                warrior.ExecuteTurn(zone);
            }
            return;
        }

        public Warrior? GetWarriorAt(int x, int y) //en el WarZone
        {
            for (int i = 0; i < _warriors.Count; i++)
            {
                if (_warriors[i].GetX()==x && _warriors[i].GetY()==y)
                    return _warriors[i];
            }
            return null;
        }

        public int GetWarriorCount()
        {
            return _warriors.Count;
        }

        public Warrior? GetWarriorAt2(int index) // en la lista
        {
            return (index < 0 || index >= _warriors.Count) ? _warriors[index] : null;
        }

        public int GetEnemiesAroundCount(int x, int y, TeamType team) // todos los enemigos en el rango
        {
            int enemyCount = 0;




            return enemyCount;
        }

        public int GetPlayersAroundCount(int x, int y) //todos los jugadores en el rango
        {
            int playerCount = 0;




            return playerCount;
        }

        public List<Warrior> GetWarriorsSortedByDistance(int x, int y)
        {
            return new List<Warrior>();
        }

        public List<Warrior> GetWarriorsInside(int x, int y, int x2, int y2)
        //public List<Warrior> GetWarriorsInside(int x, int y, int width, int height)
        {
            int i=x;
            int j=y;
            List<Warrior?> list = new List<Warrior?>();

            //while(i<=x2)
            //{
            //  ++i;
            //    while(j<=y2)
            //    {
            //        ++j;
            //        if (GetWarriorAt(i, j)==null)
            //            break;
            //        list.Add(GetWarriorAt(i, j));
            //    }   
            //}

            while (i<=x2 && j<=y2)
            {
                ++i;
                ++j;
                if (j == y2)
                    j = y;
                if (GetWarriorAt(i, j) == null)
                    continue;
                list.Add(GetWarriorAt(i, j));
            }
            return list;
        }

        //Ver como conseguir que MoveWarrior llame a un solo guerrero
        public void IsBattleFinished()
        {
            

        }
    }
}
