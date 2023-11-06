namespace EmGame
{
    public class WarZone
    {
        private int width, height;

        public void CreateWarrior(int count, TeamType type)
        {
            for(int i = 0; i < count; i++)
            {
                Warrior warrior = new Warrior();
                warrior._team=type
            }
        }
        public void RemoveAt(int index)
        {

        }
        public void MoveWarrior(List<Warrior> list, int x, int y)
        {

        }

        //Ver como conseguir que MoveWarrior llame a un solo guerrero
    }
}
