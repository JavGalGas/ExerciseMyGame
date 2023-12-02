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
    class Race
    {
         private List<Runner?> _runners;

        public TEAM GetTeamAhead()
        {

        }
        
        public void AddRunner(Runner? runner)
        {
            _runners.Add(runner);
        }
        public void CreateRunner(int count)
        {
            for (int i = 0; i < count; i++) 
            {
                Runner runner=new Runner();
                _runners.Add(runner);
            }
        }
        public int GetListCount()
        {
            return _runners.Count;
        }
        public Runner? GetRunnerAt(int index) 
        {
            if(_runners[index] == null)
                return null;
            return _runners[index];
        }
        public void Simulate()
        {

        }
        public List<Runner> SortByDistance(List<Runner> runners) 
        {
            for (int i = 0; i < runners.Count()-1; i++)
            {
                for (int j = i + 1; j < runners.Count; j++)
                {
                    if (runners[j] == runners[i])
                    {

                    }
                }
            }
        }
        
    }

    
}
