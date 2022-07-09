using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors_.Classes
{
    public class GameStatus
    {
        public GameStatus(int a_Status, int b_Status, int a_Result, int b_Result)
        {
            A_Status = a_Status;
            B_Status = b_Status;
            A_Result = a_Result;
            B_Result = b_Result;
        }
    
        public int A_Status { get; set; }
        public int B_Status { get; set; }
        public int A_Result { get; set; }
        public int B_Result { get; set; }
    }
}
