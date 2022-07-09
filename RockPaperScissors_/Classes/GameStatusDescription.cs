namespace RockPaperScissors_.Classes
{
    public class GameStatusDescription
    {
        public GameStatusDescription(string a_Status, string b_Status, string a_Result, string b_Result)
        {
            A_Status = a_Status;
            B_Status = b_Status;
            A_Result = a_Result;
            B_Result = b_Result;
        }

        public string A_Status { get; set; }
        public string B_Status { get; set; }
        public string A_Result { get; set; }
        public string B_Result { get; set; }
    }
}
