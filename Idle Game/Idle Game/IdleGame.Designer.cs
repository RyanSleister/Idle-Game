namespace Idle_Game
{
    partial class GameForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGold = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.btnClick = new System.Windows.Forms.Button();
            this.btnItem1 = new System.Windows.Forms.Button();
            this.lblItem1 = new System.Windows.Forms.Label();
            this.lblItem2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnItem2 = new System.Windows.Forms.Button();
            this.lblItem4 = new System.Windows.Forms.Label();
            this.lblItem3 = new System.Windows.Forms.Label();
            this.btnItem4 = new System.Windows.Forms.Button();
            this.btnItem3 = new System.Windows.Forms.Button();
            this.btnClickProfit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(658, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 56);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblGold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblGold.Location = new System.Drawing.Point(473, 115);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(72, 26);
            this.lblGold.TabIndex = 1;
            this.lblGold.Text = "Gold: 0";
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(427, 182);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(160, 81);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "&Click!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnItem1
            // 
            this.btnItem1.Location = new System.Drawing.Point(160, 46);
            this.btnItem1.Name = "btnItem1";
            this.btnItem1.Size = new System.Drawing.Size(43, 34);
            this.btnItem1.TabIndex = 3;
            this.btnItem1.Text = "Buy";
            this.btnItem1.UseVisualStyleBackColor = true;
            this.btnItem1.Click += new System.EventHandler(this.btnShoes_Click);
            // 
            // lblItem1
            // 
            this.lblItem1.AutoSize = true;
            this.lblItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblItem1.Location = new System.Drawing.Point(25, 50);
            this.lblItem1.Name = "lblItem1";
            this.lblItem1.Size = new System.Drawing.Size(122, 17);
            this.lblItem1.TabIndex = 4;
            this.lblItem1.Text = "Longswords (10g)";
            // 
            // lblItem2
            // 
            this.lblItem2.AutoSize = true;
            this.lblItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblItem2.Location = new System.Drawing.Point(25, 100);
            this.lblItem2.Name = "lblItem2";
            this.lblItem2.Size = new System.Drawing.Size(127, 17);
            this.lblItem2.TabIndex = 5;
            this.lblItem2.Text = "Greatsword (100g)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 6;
            // 
            // btnItem2
            // 
            this.btnItem2.Location = new System.Drawing.Point(160, 92);
            this.btnItem2.Name = "btnItem2";
            this.btnItem2.Size = new System.Drawing.Size(43, 34);
            this.btnItem2.TabIndex = 7;
            this.btnItem2.Text = "Buy";
            this.btnItem2.UseVisualStyleBackColor = true;
            this.btnItem2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblItem4
            // 
            this.lblItem4.AutoSize = true;
            this.lblItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblItem4.Location = new System.Drawing.Point(25, 200);
            this.lblItem4.Name = "lblItem4";
            this.lblItem4.Size = new System.Drawing.Size(102, 17);
            this.lblItem4.TabIndex = 8;
            this.lblItem4.Text = "Longbow (25k)";
            // 
            // lblItem3
            // 
            this.lblItem3.AutoSize = true;
            this.lblItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblItem3.Location = new System.Drawing.Point(25, 150);
            this.lblItem3.Name = "lblItem3";
            this.lblItem3.Size = new System.Drawing.Size(95, 17);
            this.lblItem3.TabIndex = 9;
            this.lblItem3.Text = "Battleaxe (1k)";
            // 
            // btnItem4
            // 
            this.btnItem4.Location = new System.Drawing.Point(160, 191);
            this.btnItem4.Name = "btnItem4";
            this.btnItem4.Size = new System.Drawing.Size(43, 34);
            this.btnItem4.TabIndex = 10;
            this.btnItem4.Text = "Buy";
            this.btnItem4.UseVisualStyleBackColor = true;
            this.btnItem4.Click += new System.EventHandler(this.btnItem4_Click);
            // 
            // btnItem3
            // 
            this.btnItem3.Location = new System.Drawing.Point(160, 141);
            this.btnItem3.Name = "btnItem3";
            this.btnItem3.Size = new System.Drawing.Size(43, 34);
            this.btnItem3.TabIndex = 11;
            this.btnItem3.Text = "Buy";
            this.btnItem3.UseVisualStyleBackColor = true;
            this.btnItem3.Click += new System.EventHandler(this.btnItem3_Click);
            // 
            // btnClickProfit
            // 
            this.btnClickProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClickProfit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClickProfit.Location = new System.Drawing.Point(136, 298);
            this.btnClickProfit.Name = "btnClickProfit";
            this.btnClickProfit.Size = new System.Drawing.Size(99, 77);
            this.btnClickProfit.TabIndex = 12;
            this.btnClickProfit.Text = "Buy Armory (10,000g)";
            this.btnClickProfit.UseVisualStyleBackColor = true;
            this.btnClickProfit.Click += new System.EventHandler(this.btnClickProfit_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClickProfit);
            this.Controls.Add(this.btnItem3);
            this.Controls.Add(this.btnItem4);
            this.Controls.Add(this.lblItem3);
            this.Controls.Add(this.lblItem4);
            this.Controls.Add(this.btnItem2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblItem2);
            this.Controls.Add(this.lblItem1);
            this.Controls.Add(this.btnItem1);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.btnExit);
            this.Name = "GameForm";
            this.Text = "Idle Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnItem1;
        private System.Windows.Forms.Label lblItem1;
        private System.Windows.Forms.Label lblItem2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnItem2;
        private System.Windows.Forms.Label lblItem4;
        private System.Windows.Forms.Label lblItem3;
        private System.Windows.Forms.Button btnItem4;
        private System.Windows.Forms.Button btnItem3;
        private System.Windows.Forms.Button btnClickProfit;
    }
}

