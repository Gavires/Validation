
namespace EquipmentQualification
{
    partial class WindowMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
            this.ButtonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            resources.ApplyResources(this.ButtonExit, "ButtonExit");
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PUserName
            // 
            resources.ApplyResources(this.PUserName, "PUserName");
            this.PUserName.Name = "PUserName";
            this.PUserName.Click += new System.EventHandler(this.PUserName_Click);
            // 
            // WindowMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonExit);
            this.Name = "WindowMain";
            this.Load += new System.EventHandler(this.WindowMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PUserName;
    }
}