using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_RPG_Simulator_assignment
{
    public class Dnd_Classes //The default is always internal make sure to change it to public
    {
    
        //Fields
        string _className;



        List<string> _personalList;

        Stats _stats;

        public Dnd_Classes(string className, List<string> personalList, Stats stats)
        {

            //Constructor
            _className = className;
            



            _personalList = personalList;

            _stats = stats;
            //click constructor,then click properties,either option will work
        }

        public void RerollStats()
        {
            _stats.RerollStats();
        }

        public string ClassName { get => _className; set => _className = value; }
        public List<string> PersonalList { get => _personalList; set => _personalList = value; }

        public Stats Stats { get => _stats; set => _stats = value; }

        public override string ToString()
        {
            return $"{this.ClassName}";
        }
    }
}
