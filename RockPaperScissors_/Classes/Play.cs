
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors_.Classes
{
    public class Play
    {

        public List<GameStatus> States { get; set; }
        public Play()
        {
            //Column 0=A status
            //Column 1=B status
            //Column 3=Result for A
            //Column 4=Result for B
            //In Columns 0 and 1 : 1=Rock,2=paper,3=Scissors
            //In Column 2 : 1=Equal ,2= A Win ,3= A Lose 
            States = new List<GameStatus> {
               new GameStatus(1,1,1,1),
               new GameStatus(1,2,3,2),
               new GameStatus(1,3,2,3),
               new GameStatus(2,1,2,3),
               new GameStatus(2,2,1,1),
               new GameStatus(2,3,3,2),
               new GameStatus(3,1,3,2),
               new GameStatus(3,2,2,3),
               new GameStatus(3,3,1,1)
            };
        }
    }


}
