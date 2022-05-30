namespace Praktikum_30_Mei_2022
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.TeamName = new System.Windows.Forms.Label();
            this.Manager = new System.Windows.Forms.Label();
            this.Stadium = new System.Windows.Forms.Label();
            this.TopScore = new System.Windows.Forms.Label();
            this.Worst = new System.Windows.Forms.Label();
            this.LblTeam = new System.Windows.Forms.Label();
            this.LblManager = new System.Windows.Forms.Label();
            this.LblStadium = new System.Windows.Forms.Label();
            this.LblTopScorer = new System.Windows.Forms.Label();
            this.LblWorst = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(31, 47);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(75, 23);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.Text = "<<";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(141, 47);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 1;
            this.BtnPrevious.Text = "<";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(252, 47);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(362, 47);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(75, 23);
            this.BtnLast.TabIndex = 3;
            this.BtnLast.Text = ">>";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Location = new System.Drawing.Point(38, 115);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(89, 16);
            this.TeamName.TabIndex = 4;
            this.TeamName.Text = "Team Name :";
            // 
            // Manager
            // 
            this.Manager.AutoSize = true;
            this.Manager.Location = new System.Drawing.Point(60, 155);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(67, 16);
            this.Manager.TabIndex = 5;
            this.Manager.Text = "Manager :";
            // 
            // Stadium
            // 
            this.Stadium.AutoSize = true;
            this.Stadium.Location = new System.Drawing.Point(65, 192);
            this.Stadium.Name = "Stadium";
            this.Stadium.Size = new System.Drawing.Size(62, 16);
            this.Stadium.TabIndex = 6;
            this.Stadium.Text = "Stadium :";
            // 
            // TopScore
            // 
            this.TopScore.AutoSize = true;
            this.TopScore.Location = new System.Drawing.Point(46, 233);
            this.TopScore.Name = "TopScore";
            this.TopScore.Size = new System.Drawing.Size(81, 16);
            this.TopScore.TabIndex = 7;
            this.TopScore.Text = "Top Scorer :";
            // 
            // Worst
            // 
            this.Worst.AutoSize = true;
            this.Worst.Location = new System.Drawing.Point(17, 270);
            this.Worst.Name = "Worst";
            this.Worst.Size = new System.Drawing.Size(110, 16);
            this.Worst.TabIndex = 8;
            this.Worst.Text = "Worst Discipline :";
            // 
            // LblTeam
            // 
            this.LblTeam.AutoSize = true;
            this.LblTeam.Location = new System.Drawing.Point(172, 115);
            this.LblTeam.Name = "LblTeam";
            this.LblTeam.Size = new System.Drawing.Size(44, 16);
            this.LblTeam.TabIndex = 9;
            this.LblTeam.Text = "label1";
            // 
            // LblManager
            // 
            this.LblManager.AutoSize = true;
            this.LblManager.Location = new System.Drawing.Point(172, 155);
            this.LblManager.Name = "LblManager";
            this.LblManager.Size = new System.Drawing.Size(44, 16);
            this.LblManager.TabIndex = 10;
            this.LblManager.Text = "label2";
            // 
            // LblStadium
            // 
            this.LblStadium.AutoSize = true;
            this.LblStadium.Location = new System.Drawing.Point(172, 192);
            this.LblStadium.Name = "LblStadium";
            this.LblStadium.Size = new System.Drawing.Size(44, 16);
            this.LblStadium.TabIndex = 11;
            this.LblStadium.Text = "label3";
            // 
            // LblTopScorer
            // 
            this.LblTopScorer.AutoSize = true;
            this.LblTopScorer.Location = new System.Drawing.Point(172, 233);
            this.LblTopScorer.Name = "LblTopScorer";
            this.LblTopScorer.Size = new System.Drawing.Size(44, 16);
            this.LblTopScorer.TabIndex = 12;
            this.LblTopScorer.Text = "label4";
            // 
            // LblWorst
            // 
            this.LblWorst.AutoSize = true;
            this.LblWorst.Location = new System.Drawing.Point(172, 270);
            this.LblWorst.Name = "LblWorst";
            this.LblWorst.Size = new System.Drawing.Size(44, 16);
            this.LblWorst.TabIndex = 13;
            this.LblWorst.Text = "label5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(887, 203);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 583);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LblWorst);
            this.Controls.Add(this.LblTopScorer);
            this.Controls.Add(this.LblStadium);
            this.Controls.Add(this.LblManager);
            this.Controls.Add(this.LblTeam);
            this.Controls.Add(this.Worst);
            this.Controls.Add(this.TopScore);
            this.Controls.Add(this.Stadium);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label Manager;
        private System.Windows.Forms.Label Stadium;
        private System.Windows.Forms.Label TopScore;
        private System.Windows.Forms.Label Worst;
        private System.Windows.Forms.Label LblTeam;
        private System.Windows.Forms.Label LblManager;
        private System.Windows.Forms.Label LblStadium;
        private System.Windows.Forms.Label LblTopScorer;
        private System.Windows.Forms.Label LblWorst;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

