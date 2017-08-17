/*
 * Name:Kirandeeep Kaur
 * Date:17/August/2017
 * StudentID:300915966
 * Description:Created Splash Form. This is a splash form design.
 * Version:0.1 
 */
namespace COMP123_S2017_FinalExam_StudentID
{
    partial class SplashForm
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
            this.SplashFormtimer = new System.Windows.Forms.Timer(this.components);
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SplashFormtimer
            // 
            this.SplashFormtimer.Enabled = true;
            this.SplashFormtimer.Interval = 3000;
            this.SplashFormtimer.Tick += new System.EventHandler(this.SplashFormtimer_Tick);
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcomelabel.Location = new System.Drawing.Point(171, 132);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(248, 39);
            this.Welcomelabel.TabIndex = 0;
            this.Welcomelabel.Text = "WELCOME!!!:)";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.ControlBox = false;
            this.Controls.Add(this.Welcomelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashFormtimer;
        private System.Windows.Forms.Label Welcomelabel;
    }
}