namespace flybird
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
            this.pipetop = new System.Windows.Forms.PictureBox();
            this.pipebottom = new System.Windows.Forms.PictureBox();
            this.flybird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gameover = new System.Windows.Forms.Label();
            this.high = new System.Windows.Forms.Label();
            this.pipetop1 = new System.Windows.Forms.PictureBox();
            this.pipebottom1 = new System.Windows.Forms.PictureBox();
            this.h_label = new System.Windows.Forms.Label();
            this.high_value = new System.Windows.Forms.Label();
            this.rstart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom1)).BeginInit();
            this.SuspendLayout();
            // 
            // pipetop
            // 
            this.pipetop.Image = global::flybird.Properties.Resources.pipedown;
            this.pipetop.Location = new System.Drawing.Point(698, -1);
            this.pipetop.Name = "pipetop";
            this.pipetop.Size = new System.Drawing.Size(116, 209);
            this.pipetop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop.TabIndex = 0;
            this.pipetop.TabStop = false;
            // 
            // pipebottom
            // 
            this.pipebottom.Image = global::flybird.Properties.Resources.pipe;
            this.pipebottom.Location = new System.Drawing.Point(597, 431);
            this.pipebottom.Name = "pipebottom";
            this.pipebottom.Size = new System.Drawing.Size(116, 214);
            this.pipebottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom.TabIndex = 1;
            this.pipebottom.TabStop = false;
            // 
            // flybird
            // 
            this.flybird.Image = global::flybird.Properties.Resources.bird;
            this.flybird.Location = new System.Drawing.Point(59, 140);
            this.flybird.Name = "flybird";
            this.flybird.Size = new System.Drawing.Size(50, 46);
            this.flybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flybird.TabIndex = 2;
            this.flybird.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::flybird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-6, 639);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1788, 110);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.scoreText.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.Red;
            this.scoreText.Location = new System.Drawing.Point(681, 677);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(133, 38);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "score:0";
            this.scoreText.Click += new System.EventHandler(this.scoreText_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.gametimerevent);
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.BackColor = System.Drawing.Color.Cyan;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover.ForeColor = System.Drawing.Color.Red;
            this.gameover.Location = new System.Drawing.Point(151, 284);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(22, 51);
            this.gameover.TabIndex = 5;
            this.gameover.Text = "\r\n";
            // 
            // high
            // 
            this.high.AutoSize = true;
            this.high.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high.Location = new System.Drawing.Point(29, 20);
            this.high.Name = "high";
            this.high.Size = new System.Drawing.Size(0, 38);
            this.high.TabIndex = 6;
            // 
            // pipetop1
            // 
            this.pipetop1.Image = global::flybird.Properties.Resources.pipedown;
            this.pipetop1.Location = new System.Drawing.Point(1278, -1);
            this.pipetop1.Name = "pipetop1";
            this.pipetop1.Size = new System.Drawing.Size(116, 157);
            this.pipetop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipetop1.TabIndex = 7;
            this.pipetop1.TabStop = false;
            // 
            // pipebottom1
            // 
            this.pipebottom1.Image = global::flybird.Properties.Resources.pipe;
            this.pipebottom1.Location = new System.Drawing.Point(1278, 382);
            this.pipebottom1.Name = "pipebottom1";
            this.pipebottom1.Size = new System.Drawing.Size(116, 263);
            this.pipebottom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipebottom1.TabIndex = 8;
            this.pipebottom1.TabStop = false;
            // 
            // h_label
            // 
            this.h_label.AutoSize = true;
            this.h_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.h_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.h_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h_label.ForeColor = System.Drawing.Color.Red;
            this.h_label.Location = new System.Drawing.Point(52, 29);
            this.h_label.Name = "h_label";
            this.h_label.Size = new System.Drawing.Size(202, 38);
            this.h_label.TabIndex = 9;
            this.h_label.Text = "High-Score:";
            // 
            // high_value
            // 
            this.high_value.AutoSize = true;
            this.high_value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.high_value.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high_value.ForeColor = System.Drawing.Color.Red;
            this.high_value.Location = new System.Drawing.Point(269, 29);
            this.high_value.Name = "high_value";
            this.high_value.Size = new System.Drawing.Size(35, 38);
            this.high_value.TabIndex = 10;
            this.high_value.Text = "0";
            this.high_value.Click += new System.EventHandler(this.high_value_Click);
            // 
            // rstart
            // 
            this.rstart.AutoSize = true;
            this.rstart.BackColor = System.Drawing.Color.Lime;
            this.rstart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rstart.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rstart.ForeColor = System.Drawing.Color.Red;
            this.rstart.Location = new System.Drawing.Point(577, 116);
            this.rstart.Name = "rstart";
            this.rstart.Size = new System.Drawing.Size(136, 40);
            this.rstart.TabIndex = 11;
            this.rstart.Text = "ReStart";
            this.rstart.Click += new System.EventHandler(this.rstart_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1780, 761);
            this.Controls.Add(this.pipetop);
            this.Controls.Add(this.pipetop1);
            this.Controls.Add(this.rstart);
            this.Controls.Add(this.high_value);
            this.Controls.Add(this.h_label);
            this.Controls.Add(this.high);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.flybird);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipebottom);
            this.Controls.Add(this.pipebottom1);
            this.Name = "Form1";
            this.Text = "flybird game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipetop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipetop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipebottom;
        private System.Windows.Forms.PictureBox flybird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Label high;
        private System.Windows.Forms.PictureBox pipetop1;
        private System.Windows.Forms.PictureBox pipebottom1;
        private System.Windows.Forms.Label h_label;
        private System.Windows.Forms.Label high_value;
        private System.Windows.Forms.Label rstart;
    }
}

