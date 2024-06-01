namespace Autobus_Complete
{
    partial class FrmGame
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
            this.components = new System.ComponentModel.Container();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.tbPerson = new System.Windows.Forms.TextBox();
            this.tbAnimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLetter = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnRoundComplete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.lblRound.Location = new System.Drawing.Point(62, 57);
            this.lblRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(139, 37);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round #1";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.lblTimer.Location = new System.Drawing.Point(450, 60);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(66, 30);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "00:00";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.lblPerson.Location = new System.Drawing.Point(86, 160);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(103, 21);
            this.lblPerson.TabIndex = 3;
            this.lblPerson.Text = "Person Name";
            // 
            // tbPerson
            // 
            this.tbPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.tbPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.tbPerson.Location = new System.Drawing.Point(90, 195);
            this.tbPerson.Name = "tbPerson";
            this.tbPerson.Size = new System.Drawing.Size(221, 22);
            this.tbPerson.TabIndex = 4;
            // 
            // tbAnimal
            // 
            this.tbAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.tbAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.tbAnimal.Location = new System.Drawing.Point(90, 285);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Size = new System.Drawing.Size(221, 22);
            this.tbAnimal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.label1.Location = new System.Drawing.Point(86, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Animal";
            // 
            // tbPlant
            // 
            this.tbPlant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.tbPlant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPlant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.tbPlant.Location = new System.Drawing.Point(393, 285);
            this.tbPlant.Name = "tbPlant";
            this.tbPlant.Size = new System.Drawing.Size(221, 22);
            this.tbPlant.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.label3.Location = new System.Drawing.Point(389, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plant";
            // 
            // tbCountry
            // 
            this.tbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.tbCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.tbCountry.Location = new System.Drawing.Point(393, 195);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(221, 22);
            this.tbCountry.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.label4.Location = new System.Drawing.Point(389, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Country";
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(220)))), ((int)(((byte)(172)))));
            this.lblLetter.Location = new System.Drawing.Point(281, 60);
            this.lblLetter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(89, 30);
            this.lblLetter.TabIndex = 11;
            this.lblLetter.Text = "Letter A";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(111)))));
            this.lblPoints.Location = new System.Drawing.Point(596, 60);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(97, 30);
            this.lblPoints.TabIndex = 12;
            this.lblPoints.Text = "0  points";
            // 
            // btnRoundComplete
            // 
            this.btnRoundComplete.Location = new System.Drawing.Point(290, 392);
            this.btnRoundComplete.Name = "btnRoundComplete";
            this.btnRoundComplete.Size = new System.Drawing.Size(144, 39);
            this.btnRoundComplete.TabIndex = 13;
            this.btnRoundComplete.Values.Text = "Bus Complete";
            this.btnRoundComplete.Click += new System.EventHandler(this.btnCompleteRound_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(32)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(727, 510);
            this.Controls.Add(this.btnRoundComplete);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPlant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAnimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPerson);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblRound);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Complete Game";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.TextBox tbPerson;
        private System.Windows.Forms.TextBox tbAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLetter;
        private System.Windows.Forms.Label lblPoints;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRoundComplete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
    }
}