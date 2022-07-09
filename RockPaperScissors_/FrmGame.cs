using RockPaperScissors_.Classes;

namespace RockPaperScissors_
{
    public partial class FrmGame : Form
    {
        List<GameStatus> States;
        List<GameStatus> Results;
        /// <summary>
        /// Form Constructor
        /// </summary>
        public FrmGame()
        {
            InitializeComponent();
            Results = new List<GameStatus>();
            Play pl = new Play();
            States = pl.States;
            Random rnd = new Random();
            int B_Status = rnd.Next(1, 4);
            Play(1, B_Status);



        }
        /// <summary>
        /// Play game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Play_Click(object sender, System.EventArgs e)
        {
            Results.Clear();
            Random rnd1 = new Random();
            int A_Status = rnd1.Next(1, 4);
            Random rnd = new Random();
            int B_Status = rnd.Next(1, 4);
            Play(A_Status, B_Status);
            SetGridViewResult();
        }
        /// <summary>
        /// Play Player B
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_PlayB_Click(object sender, EventArgs e)
        {
            Results.Clear();
            Random rnd = new Random();
            int B_Status = rnd.Next(1, 4);
            Play(1, B_Status);
            SetGridViewResult();
        }
        /// <summary>
        /// Play Both Players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_PlayBoth_Click(object sender, EventArgs e)
        {
            Results.Clear();
            Random rnd1 = new Random();
            int A_Status = rnd1.Next(1, 4);
            Random rnd = new Random();
            int B_Status = rnd.Next(1, 4);
            Play(A_Status, B_Status);
            SetGridViewResult();
        }
        /// <summary>
        /// play Game base Function
        /// </summary>
        /// <param name="A_status"></param>
        /// <param name="B_Status"></param>
        private void Play(int A_status, int B_Status)
        {

            Pb_PlayerA.Image = Image.FromFile(@"Resources\images\" + A_status.ToString() + ".jpg");
            Pb_PlayerB.Image = Image.FromFile(@"Resources\images\" + B_Status.ToString() + ".jpg");

            var res = States.Where(x => x.A_Status == A_status && x.B_Status == B_Status).FirstOrDefault();

            switch (res.A_Result)
            {
                case 1:
                    LB_ResA.Text = "Equal";
                    Lb_ResB.Text = "Equal";
                    SUM_ResA.Text = "Equal=1,Win=0,Lost=0";
                    SUM_ResB.Text = "Equal=1,Win=0,Lost=0";
                    break;
                case 2:
                    LB_ResA.Text = "Winner";
                    Lb_ResB.Text = "Loser";
                    SUM_ResA.Text = "Equal=0,Win=1,Lost=0";
                    SUM_ResB.Text = "Equal=0,Win=0,Lost=1";
                    break;
                case 3:
                    LB_ResA.Text = "Loser";
                    Lb_ResB.Text = "Winner";
                    SUM_ResA.Text = "Equal=0,Win=0,Lost=1";
                    SUM_ResB.Text = "Equal=0,Win=1,Lost=0";
                    break;

            }
            Results.Add(new GameStatus(A_status, B_Status, res.A_Result, res.B_Result));

        }
        /// <summary>
        /// Play Hunred random Game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_PlayHunred_Click(object sender, EventArgs e)
        {
            Results.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {

                int B_Status = rnd.Next(1, 4);
                Play(1, B_Status);
            }

            SetGridViewResult();
            int  EqualA = Results.Where(x => x.A_Result == 1).Count();
            int winA = Results.Where(x => x.A_Result == 2).Count();
            int lostA = Results.Where(x => x.A_Result == 3).Count();

            int EqualB = Results.Where(x => x.B_Result == 1).Count();
            int winB= Results.Where(x => x.B_Result == 2).Count();
            int lostB = Results.Where(x => x.B_Result == 3).Count();
            SUM_ResA.Text = "Equal="+ EqualA.ToString() + ",Win="+  winA.ToString() + ",Lost="+ lostA.ToString() + "";
            SUM_ResB.Text = "Equal="+ EqualB.ToString() + ",Win="+ winB.ToString() + ",Lost="+lostB.ToString() + "";
        }
        /// <summary>
        /// show Result in Gridview
        /// </summary>
        private void SetGridViewResult()
        {

            Dgv_Result.DataSource = null;

            List<GameStatusDescription> lst = new List<GameStatusDescription>();
            foreach (var item in Results)
            {

                lst.Add(new GameStatusDescription(GetStatus(item.A_Status), GetStatus(item.B_Status), GetResult(item.A_Result), GetResult(item.B_Result)));


            }
            Dgv_Result.DataSource = lst;
        }
        /// <summary>
        /// Get Status Name
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private string GetStatus(int i)
        {
            string res = "";
            switch (i)
            {
                case 1:
                    res = "Rock";
                    break;
                case 2:
                    res = "Paper";
                    break;
                case 3:
                    res = "Scissors";
                    break;
            }
            return res;
        }
        /// <summary>
        /// Get Result Name
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private string GetResult(int i)
        {
            string res = "";
            switch (i)
            {
                case 1:
                    res = "Equal";
                    break;
                case 2:
                    res = "Winner";
                    break;
                case 3:
                    res = "loser";
                    break;
            }
            return res;
        }
    }
}