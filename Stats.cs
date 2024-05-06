using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_RPG_Simulator_assignment
{
    public class Stats
    {
        //Fields
        string _className;
        List<int> _statList;
        int _health;

        int _str;

        int _dex;

        int _con;

        int _int;

        int _wis;

        int _cha;

        public Stats(string className, List<int> statList)
        {
            //Constructor
            _className = className;
            _statList = statList;

            int[] stats = statList.ToArray();
            Random r = new Random();

            _health = r.Next(stats[0], stats[1]);
            _str = r.Next(stats[2], stats[3]);
            _dex = r.Next(stats[4], stats[5]);
            _con = r.Next(stats[6], stats[7]);
            _int = r.Next(stats[8], stats[9]);
            _wis = r.Next(stats[10], stats[11]);
            _cha = r.Next(stats[12], stats[13]);
        }

        public void RerollStats()
        {
            //using arrays lets me associate the random stat values to specific positions,so when the stats are rolled the program knows where to put the numbers
            int[] stats = _statList.ToArray();
            Random r = new Random();

            _health = r.Next(stats[0], stats[1]);
            _str = r.Next(stats[2], stats[3]);
            _dex = r.Next(stats[4], stats[5]);
            _con = r.Next(stats[6], stats[7]);
            _int = r.Next(stats[8], stats[9]);
            _wis = r.Next(stats[10], stats[11]);
            _cha = r.Next(stats[12], stats[13]);
        }

        public string ClassName { get => _className; set => _className = value; }
        public List<int> StatList { get => _statList; set => _statList = value; }
        public int Health { get => _health; set => _health = value; }
        public int Str { get => _str; set => _str = value; }
        public int Dex { get => _dex; set => _dex = value; }
        public int Con { get => _con; set => _con = value; }
        public int Int { get => _int; set => _int = value; }
        public int Wis { get => _wis; set => _wis = value; }
        public int Cha { get => _cha; set => _cha = value; }
    }
}
