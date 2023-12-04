using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM1
{
    public enum TEAM
    {
        BLUE,
        RED,
        GREEN,
    }
    public class Race
    {
        private static List<Runner?>? _runners;

        public TEAM GetTeamAhead()
        {
            
        }
        public static List<Runner?>? GetRunners()
        {
            return _runners;
        }
        public void AddRunner(Runner? runner)
        {
            _runners?.Add(runner);
        }
        public void CreateRunner(int count)
        {
            for (int i = 0; i < count; i++) 
            {
                Runner runner=new Runner();
                _runners?.Add(runner);
            }
        }
        public int? GetListCount()
        {
            return _runners?.Count;
        }
        public Runner? GetRunnerAt(int index) 
        {
            if(_runners?[index] == null)
                return null;
            return _runners[index];
        }

        public Runner? SearchRunner(string name)
        {
            for(int i = 0; i < _runners?.Count; i++)
            {
                Runner? runner= _runners[i];

                if(runner?.GetName() == name)
                    return runner;
            }
            return null;
        }

        public void RemoveRunnerAt(int index)
        {
            _runners?.RemoveAt(index);
        }
        public void Simulate()
        {

        }
        public List<Runner> SortByDistance(List<Runner> runners)
        {
            for (int i = 0; i < runners.Count() - 1; i++)
            {
                for (int j = i + 1; j < runners.Count; j++)
                {
                    if (runners[j].getPosition() > runners[i].getPosition())
                    {
                        Utils.Swap(runners[i], runners[j]);
                    }
                }
            }
            return runners;
        }

    }

    
}
