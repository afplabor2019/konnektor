namespace BlackJack
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
            this.btn_Hit = new System.Windows.Forms.Button();
            this.btn_Stand = new System.Windows.Forms.Button();
            this.lbl_Player = new System.Windows.Forms.Label();
            this.lbl_Dealer = new System.Windows.Forms.Label();
            this.lbl_DealerCardValue = new System.Windows.Forms.Label();
            this.lbl_PlayerCardValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Hit
            // 
            this.btn_Hit.BackColor = System.Drawing.Color.Orange;
            this.btn_Hit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Hit.Location = new System.Drawing.Point(150, 530);
            this.btn_Hit.Name = "btn_Hit";
            this.btn_Hit.Size = new System.Drawing.Size(120, 35);
            this.btn_Hit.TabIndex = 1;
            this.btn_Hit.Text = "Lapot Kér";
            this.btn_Hit.UseVisualStyleBackColor = false;
            // 
            // btn_Stand
            // 
            this.btn_Stand.BackColor = System.Drawing.Color.Orange;
            this.btn_Stand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Stand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stand.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Stand.Location = new System.Drawing.Point(353, 530);
            this.btn_Stand.Name = "btn_Stand";
            this.btn_Stand.Size = new System.Drawing.Size(120, 35);
            this.btn_Stand.TabIndex = 2;
            this.btn_Stand.Text = "Megáll";
            this.btn_Stand.UseVisualStyleBackColor = false;
            // 
            // lbl_Player
            // 
            this.lbl_Player.AutoSize = true;
            this.lbl_Player.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Player.Location = new System.Drawing.Point(255, 496);
            this.lbl_Player.Name = "lbl_Player";
            this.lbl_Player.Size = new System.Drawing.Size(116, 31);
            this.lbl_Player.TabIndex = 3;
            this.lbl_Player.Text = "Játékos";
            this.lbl_Player.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Dealer
            // 
            this.lbl_Dealer.AutoSize = true;
            this.lbl_Dealer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dealer.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Dealer.Location = new System.Drawing.Point(266, 21);
            this.lbl_Dealer.Name = "lbl_Dealer";
            this.lbl_Dealer.Size = new System.Drawing.Size(91, 31);
            this.lbl_Dealer.TabIndex = 4;
            this.lbl_Dealer.Text = "Osztó";
            this.lbl_Dealer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DealerCardValue
            // 
            this.lbl_DealerCardValue.AutoSize = true;
            this.lbl_DealerCardValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DealerCardValue.Location = new System.Drawing.Point(150, 111);
            this.lbl_DealerCardValue.Name = "lbl_DealerCardValue";
            this.lbl_DealerCardValue.Size = new System.Drawing.Size(21, 24);
            this.lbl_DealerCardValue.TabIndex = 5;
            this.lbl_DealerCardValue.Text = "0";
            this.lbl_DealerCardValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PlayerCardValue
            // 
            this.lbl_PlayerCardValue.AutoSize = true;
            this.lbl_PlayerCardValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerCardValue.Location = new System.Drawing.Point(150, 439);
            this.lbl_PlayerCardValue.Name = "lbl_PlayerCardValue";
            this.lbl_PlayerCardValue.Size = new System.Drawing.Size(21, 24);
            this.lbl_PlayerCardValue.TabIndex = 6;
            this.lbl_PlayerCardValue.Text = "0";
            this.lbl_PlayerCardValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack.Properties.Resources.Asztal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.lbl_PlayerCardValue);
            this.Controls.Add(this.lbl_DealerCardValue);
            this.Controls.Add(this.lbl_Dealer);
            this.Controls.Add(this.lbl_Player);
            this.Controls.Add(this.btn_Stand);
            this.Controls.Add(this.btn_Hit);
            this.Name = "Form1";
            this.Text = "BlackJack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Hit;
        private System.Windows.Forms.Button btn_Stand;
        private System.Windows.Forms.Label lbl_Player;
        private System.Windows.Forms.Label lbl_Dealer;
        private System.Windows.Forms.Label lbl_DealerCardValue;
        private System.Windows.Forms.Label lbl_PlayerCardValue;
    }
}

