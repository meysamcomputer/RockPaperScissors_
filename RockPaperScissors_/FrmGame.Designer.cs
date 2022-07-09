namespace RockPaperScissors_
{
    partial class FrmGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pb_PlayerA = new System.Windows.Forms.PictureBox();
            this.Pb_PlayerB = new System.Windows.Forms.PictureBox();
            this.Lb_PlayerA = new System.Windows.Forms.Label();
            this.Lb_PlayerB = new System.Windows.Forms.Label();
            this.LB_ResA = new System.Windows.Forms.Label();
            this.Lb_ResB = new System.Windows.Forms.Label();
            this.Btn_PlayB = new System.Windows.Forms.Button();
            this.Btn_PlayBoth = new System.Windows.Forms.Button();
            this.Btn_PlayHunred = new System.Windows.Forms.Button();
            this.Dgv_Result = new System.Windows.Forms.DataGridView();
            this.A_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUM_ResA = new System.Windows.Forms.Label();
            this.SUM_ResB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PlayerA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PlayerB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_PlayerA
            // 
            this.Pb_PlayerA.Location = new System.Drawing.Point(12, 58);
            this.Pb_PlayerA.Name = "Pb_PlayerA";
            this.Pb_PlayerA.Size = new System.Drawing.Size(225, 225);
            this.Pb_PlayerA.TabIndex = 0;
            this.Pb_PlayerA.TabStop = false;
            // 
            // Pb_PlayerB
            // 
            this.Pb_PlayerB.Location = new System.Drawing.Point(243, 58);
            this.Pb_PlayerB.Name = "Pb_PlayerB";
            this.Pb_PlayerB.Size = new System.Drawing.Size(225, 225);
            this.Pb_PlayerB.TabIndex = 1;
            this.Pb_PlayerB.TabStop = false;
            // 
            // Lb_PlayerA
            // 
            this.Lb_PlayerA.AutoSize = true;
            this.Lb_PlayerA.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_PlayerA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lb_PlayerA.Location = new System.Drawing.Point(42, 9);
            this.Lb_PlayerA.Name = "Lb_PlayerA";
            this.Lb_PlayerA.Size = new System.Drawing.Size(124, 37);
            this.Lb_PlayerA.TabIndex = 2;
            this.Lb_PlayerA.Text = "Player A";
            // 
            // Lb_PlayerB
            // 
            this.Lb_PlayerB.AutoSize = true;
            this.Lb_PlayerB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_PlayerB.ForeColor = System.Drawing.Color.Blue;
            this.Lb_PlayerB.Location = new System.Drawing.Point(263, 9);
            this.Lb_PlayerB.Name = "Lb_PlayerB";
            this.Lb_PlayerB.Size = new System.Drawing.Size(122, 37);
            this.Lb_PlayerB.TabIndex = 3;
            this.Lb_PlayerB.Text = "Player B";
            // 
            // LB_ResA
            // 
            this.LB_ResA.AutoSize = true;
            this.LB_ResA.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB_ResA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LB_ResA.Location = new System.Drawing.Point(12, 286);
            this.LB_ResA.Name = "LB_ResA";
            this.LB_ResA.Size = new System.Drawing.Size(122, 37);
            this.LB_ResA.TabIndex = 4;
            this.LB_ResA.Text = "Result A";
            // 
            // Lb_ResB
            // 
            this.Lb_ResB.AutoSize = true;
            this.Lb_ResB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lb_ResB.ForeColor = System.Drawing.Color.Blue;
            this.Lb_ResB.Location = new System.Drawing.Point(275, 286);
            this.Lb_ResB.Name = "Lb_ResB";
            this.Lb_ResB.Size = new System.Drawing.Size(120, 37);
            this.Lb_ResB.TabIndex = 5;
            this.Lb_ResB.Text = "Result B";
            // 
            // Btn_PlayB
            // 
            this.Btn_PlayB.Location = new System.Drawing.Point(474, 58);
            this.Btn_PlayB.Name = "Btn_PlayB";
            this.Btn_PlayB.Size = new System.Drawing.Size(99, 38);
            this.Btn_PlayB.TabIndex = 6;
            this.Btn_PlayB.Text = "Play B";
            this.Btn_PlayB.UseVisualStyleBackColor = true;
            this.Btn_PlayB.Click += new System.EventHandler(this.Btn_PlayB_Click);
            // 
            // Btn_PlayBoth
            // 
            this.Btn_PlayBoth.Location = new System.Drawing.Point(474, 102);
            this.Btn_PlayBoth.Name = "Btn_PlayBoth";
            this.Btn_PlayBoth.Size = new System.Drawing.Size(99, 38);
            this.Btn_PlayBoth.TabIndex = 7;
            this.Btn_PlayBoth.Text = "Play Both";
            this.Btn_PlayBoth.UseVisualStyleBackColor = true;
            this.Btn_PlayBoth.Click += new System.EventHandler(this.Btn_PlayBoth_Click);
            // 
            // Btn_PlayHunred
            // 
            this.Btn_PlayHunred.Location = new System.Drawing.Point(474, 146);
            this.Btn_PlayHunred.Name = "Btn_PlayHunred";
            this.Btn_PlayHunred.Size = new System.Drawing.Size(99, 45);
            this.Btn_PlayHunred.TabIndex = 8;
            this.Btn_PlayHunred.Text = "Play 100 Times";
            this.Btn_PlayHunred.UseVisualStyleBackColor = true;
            this.Btn_PlayHunred.Click += new System.EventHandler(this.Btn_PlayHunred_Click);
            // 
            // Dgv_Result
            // 
            this.Dgv_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A_Status,
            this.B_Status,
            this.A_Result,
            this.B_Result});
            this.Dgv_Result.Location = new System.Drawing.Point(576, 57);
            this.Dgv_Result.Name = "Dgv_Result";
            this.Dgv_Result.RowTemplate.Height = 25;
            this.Dgv_Result.Size = new System.Drawing.Size(426, 368);
            this.Dgv_Result.TabIndex = 9;
            // 
            // A_Status
            // 
            this.A_Status.DataPropertyName = "A_Status";
            this.A_Status.HeaderText = "Player A Status";
            this.A_Status.Name = "A_Status";
            // 
            // B_Status
            // 
            this.B_Status.DataPropertyName = "B_Status";
            this.B_Status.HeaderText = "Player B Status";
            this.B_Status.Name = "B_Status";
            // 
            // A_Result
            // 
            this.A_Result.DataPropertyName = "A_Result";
            this.A_Result.HeaderText = "Player A Result";
            this.A_Result.Name = "A_Result";
            // 
            // B_Result
            // 
            this.B_Result.DataPropertyName = "B_Result";
            this.B_Result.HeaderText = "Player B Result";
            this.B_Result.Name = "B_Result";
            // 
            // SUM_ResA
            // 
            this.SUM_ResA.AutoSize = true;
            this.SUM_ResA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SUM_ResA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SUM_ResA.Location = new System.Drawing.Point(21, 323);
            this.SUM_ResA.Name = "SUM_ResA";
            this.SUM_ResA.Size = new System.Drawing.Size(81, 15);
            this.SUM_ResA.TabIndex = 10;
            this.SUM_ResA.Text = "Sum Result A";
            // 
            // SUM_ResB
            // 
            this.SUM_ResB.AutoSize = true;
            this.SUM_ResB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SUM_ResB.ForeColor = System.Drawing.Color.Blue;
            this.SUM_ResB.Location = new System.Drawing.Point(314, 323);
            this.SUM_ResB.Name = "SUM_ResB";
            this.SUM_ResB.Size = new System.Drawing.Size(81, 15);
            this.SUM_ResB.TabIndex = 11;
            this.SUM_ResB.Text = "Sum Result B";
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 427);
            this.Controls.Add(this.SUM_ResB);
            this.Controls.Add(this.SUM_ResA);
            this.Controls.Add(this.Dgv_Result);
            this.Controls.Add(this.Btn_PlayHunred);
            this.Controls.Add(this.Btn_PlayBoth);
            this.Controls.Add(this.Btn_PlayB);
            this.Controls.Add(this.Lb_ResB);
            this.Controls.Add(this.LB_ResA);
            this.Controls.Add(this.Lb_PlayerB);
            this.Controls.Add(this.Lb_PlayerA);
            this.Controls.Add(this.Pb_PlayerB);
            this.Controls.Add(this.Pb_PlayerA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGame";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PlayerA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_PlayerB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Pb_PlayerA;
        private PictureBox Pb_PlayerB;
        private Label Lb_PlayerA;
        private Label Lb_PlayerB;
        private Label LB_ResA;
        private Label Lb_ResB;
        private Button Btn_PlayB;
        private Button Btn_PlayBoth;
        private Button Btn_PlayHunred;
        private DataGridView Dgv_Result;
        private DataGridViewTextBoxColumn A_Status;
        private DataGridViewTextBoxColumn B_Status;
        private DataGridViewTextBoxColumn A_Result;
        private DataGridViewTextBoxColumn B_Result;
        private Label SUM_ResA;
        private Label SUM_ResB;
    }
}