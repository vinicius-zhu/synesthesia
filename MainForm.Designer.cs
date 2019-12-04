namespace Synesthesia
{
    partial class MainForm
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxLight = new System.Windows.Forms.TextBox();
            this.textBoxSound = new System.Windows.Forms.TextBox();
            this.labelLight = new System.Windows.Forms.Label();
            this.labelSound = new System.Windows.Forms.Label();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(84, 106);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "buttonRun";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // textBoxLight
            // 
            this.textBoxLight.Location = new System.Drawing.Point(72, 54);
            this.textBoxLight.Name = "textBoxLight";
            this.textBoxLight.Size = new System.Drawing.Size(100, 20);
            this.textBoxLight.TabIndex = 1;
            // 
            // textBoxSound
            // 
            this.textBoxSound.Location = new System.Drawing.Point(72, 80);
            this.textBoxSound.Name = "textBoxSound";
            this.textBoxSound.Size = new System.Drawing.Size(100, 20);
            this.textBoxSound.TabIndex = 2;
            // 
            // labelLight
            // 
            this.labelLight.AutoSize = true;
            this.labelLight.Location = new System.Drawing.Point(31, 57);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(30, 13);
            this.labelLight.TabIndex = 3;
            this.labelLight.Text = "Light";
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.Location = new System.Drawing.Point(31, 83);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(38, 13);
            this.labelSound.TabIndex = 4;
            this.labelSound.Text = "Sound";
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.Location = new System.Drawing.Point(178, 55);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(17, 19);
            this.pictureBoxColor.TabIndex = 5;
            this.pictureBoxColor.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 149);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.labelSound);
            this.Controls.Add(this.labelLight);
            this.Controls.Add(this.textBoxSound);
            this.Controls.Add(this.textBoxLight);
            this.Controls.Add(this.buttonRun);
            this.Name = "MainForm";
            this.Text = "Synesthesia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxLight;
        private System.Windows.Forms.TextBox textBoxSound;
        private System.Windows.Forms.Label labelLight;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.PictureBox pictureBoxColor;
    }
}

