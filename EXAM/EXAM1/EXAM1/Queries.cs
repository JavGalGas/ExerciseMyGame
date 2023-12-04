using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM1
{
    public class Queries
    {
        
        List<Runner?>? _raceRunners = Race.GetRunners();
        private int meta = 1000;

        public int GetMeta()
        { 
            return meta; 
        }
        public List<Runner?> GetWinner()
        {
            List<Runner?> result = new List<Runner?>();
            int b = 0, r = 0, g = 0;
            for(int i = 0; i < _raceRunners?.Count ; i++) 
            { 
                
            }
            return result;
        }
        public int GetRunnerCountWithTeam(TEAM team)
        {
            int count = 0;
            for (int i = 0; i < _raceRunners?.Count; i++)
            {

            }
            return count;
        }

        public Runner? GetMostAdvancedRunner()
        {
            return _raceRunners?[0];
        }
        public TEAM GetTeamWinner(string name) //recorre la lista y hace retorno 
        {

        }
    }
}
