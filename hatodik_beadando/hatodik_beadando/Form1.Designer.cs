namespace hatodik_beadando
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.button_car = new System.Windows.Forms.Button();
            this.button_ball = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_colorBall = new System.Windows.Forms.Button();
            this.button_present = new System.Windows.Forms.Button();
            this.btn_colorPresent1 = new System.Windows.Forms.Button();
            this.btn_colorPresent2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(1, 330);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(801, 122);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // button_car
            // 
            this.button_car.Location = new System.Drawing.Point(13, 13);
            this.button_car.Name = "button_car";
            this.button_car.Size = new System.Drawing.Size(97, 84);
            this.button_car.TabIndex = 1;
            this.button_car.Text = "CAR";
            this.button_car.UseVisualStyleBackColor = true;
            this.button_car.Click += new System.EventHandler(this.button_car_Click);
            // 
            // button_ball
            // 
            this.button_ball.Location = new System.Drawing.Point(117, 13);
            this.button_ball.Name = "button_ball";
            this.button_ball.Size = new System.Drawing.Size(101, 84);
            this.button_ball.TabIndex = 2;
            this.button_ball.Text = "BALL";
            this.button_ball.UseVisualStyleBackColor = true;
            this.button_ball.Click += new System.EventHandler(this.button_ball_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming next:";
            // 
            // btn_colorBall
            // 
            this.btn_colorBall.BackColor = System.Drawing.Color.Gold;
            this.btn_colorBall.Location = new System.Drawing.Point(117, 113);
            this.btn_colorBall.Name = "btn_colorBall";
            this.btn_colorBall.Size = new System.Drawing.Size(101, 30);
            this.btn_colorBall.TabIndex = 4;
            this.btn_colorBall.UseVisualStyleBackColor = false;
            this.btn_colorBall.Click += new System.EventHandler(this.button_color_Click);
            // 
            // button_present
            // 
            this.button_present.Location = new System.Drawing.Point(225, 13);
            this.button_present.Name = "button_present";
            this.button_present.Size = new System.Drawing.Size(101, 84);
            this.button_present.TabIndex = 5;
            this.button_present.Text = "Present";
            this.button_present.UseVisualStyleBackColor = true;
            this.button_present.Click += new System.EventHandler(this.button_present_Click);
            // 
            // btn_colorPresent1
            // 
            this.btn_colorPresent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_colorPresent1.Location = new System.Drawing.Point(225, 113);
            this.btn_colorPresent1.Name = "btn_colorPresent1";
            this.btn_colorPresent1.Size = new System.Drawing.Size(101, 30);
            this.btn_colorPresent1.TabIndex = 6;
            this.btn_colorPresent1.UseVisualStyleBackColor = false;
            this.btn_colorPresent1.Click += new System.EventHandler(this.button_color_Click);
            // 
            // btn_colorPresent2
            // 
            this.btn_colorPresent2.BackColor = System.Drawing.Color.Red;
            this.btn_colorPresent2.Location = new System.Drawing.Point(225, 149);
            this.btn_colorPresent2.Name = "btn_colorPresent2";
            this.btn_colorPresent2.Size = new System.Drawing.Size(101, 30);
            this.btn_colorPresent2.TabIndex = 7;
            this.btn_colorPresent2.UseVisualStyleBackColor = false;
            this.btn_colorPresent2.Click += new System.EventHandler(this.button_color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_colorPresent2);
            this.Controls.Add(this.btn_colorPresent1);
            this.Controls.Add(this.button_present);
            this.Controls.Add(this.btn_colorBall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ball);
            this.Controls.Add(this.button_car);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button button_car;
        private System.Windows.Forms.Button button_ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_colorBall;
        private System.Windows.Forms.Button button_present;
        private System.Windows.Forms.Button btn_colorPresent1;
        private System.Windows.Forms.Button btn_colorPresent2;
    }
}

