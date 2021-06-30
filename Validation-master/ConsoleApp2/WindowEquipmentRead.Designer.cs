
namespace EquipmentQualification
{
    partial class WindowEquipmentRead
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNameEquipment = new System.Windows.Forms.TextBox();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxNumberQuall = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заводской номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Помещение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Статус валидации\r\n";
            // 
            // textBoxNameEquipment
            // 
            this.textBoxNameEquipment.Location = new System.Drawing.Point(240, 52);
            this.textBoxNameEquipment.Name = "textBoxNameEquipment";
            this.textBoxNameEquipment.Size = new System.Drawing.Size(230, 23);
            this.textBoxNameEquipment.TabIndex = 4;
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(240, 96);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(230, 23);
            this.textBoxSerialNumber.TabIndex = 5;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(240, 134);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(230, 23);
            this.textBoxLocation.TabIndex = 6;
            // 
            // textBoxNumberQuall
            // 
            this.textBoxNumberQuall.Location = new System.Drawing.Point(240, 226);
            this.textBoxNumberQuall.Name = "textBoxNumberQuall";
            this.textBoxNumberQuall.Size = new System.Drawing.Size(230, 23);
            this.textBoxNumberQuall.TabIndex = 7;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(72, 324);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(108, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(186, 324);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(108, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(300, 324);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(108, 23);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Номер протокола валидации";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(240, 188);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(230, 23);
            this.textBoxStatus.TabIndex = 12;
            // 
            // WindowEquipmentRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 372);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxNumberQuall);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxSerialNumber);
            this.Controls.Add(this.textBoxNameEquipment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WindowEquipmentRead";
            this.Text = "Добавление оборудование";
            this.Load += new System.EventHandler(this.WindowEquipmentRead_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNameEquipment;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxNumberQuall;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStatus;
    }
}