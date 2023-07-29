using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    //create a name and a score
    public class ScoresModel : IComparable
    {
        public string Name { get; set; }    
        public int Score { get; set; }
        public ScoresModel(string name, int score) 
        { 
            this.Name = name;
            this.Score = score; 
        }

        //backwards sort
        public int CompareTo(object? obj)
        {
            ScoresModel incomingScore = obj as ScoresModel;
            //return this.Score.CompareTo(incomingScore.Score);
            return incomingScore.Score.CompareTo(this.Score);

        }
    }
}
