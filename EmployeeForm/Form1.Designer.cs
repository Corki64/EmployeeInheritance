namespace EmployeeForm
{
     partial class EmployeeFormDataEntry
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
               this.nameLabel = new System.Windows.Forms.Label();
               this.idLabel = new System.Windows.Forms.Label();
               this.shiftLabel = new System.Windows.Forms.Label();
               this.payRateLabel = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // nameLabel
               // 
               this.nameLabel.AutoSize = true;
               this.nameLabel.Location = new System.Drawing.Point(89, 46);
               this.nameLabel.Name = "nameLabel";
               this.nameLabel.Size = new System.Drawing.Size(41, 13);
               this.nameLabel.TabIndex = 0;
               this.nameLabel.Text = "Name :";
               // 
               // idLabel
               // 
               this.idLabel.AutoSize = true;
               this.idLabel.Location = new System.Drawing.Point(89, 90);
               this.idLabel.Name = "idLabel";
               this.idLabel.Size = new System.Drawing.Size(64, 13);
               this.idLabel.TabIndex = 1;
               this.idLabel.Text = "ID Number :";
               // 
               // shiftLabel
               // 
               this.shiftLabel.AutoSize = true;
               this.shiftLabel.Location = new System.Drawing.Point(89, 136);
               this.shiftLabel.Name = "shiftLabel";
               this.shiftLabel.Size = new System.Drawing.Size(70, 13);
               this.shiftLabel.TabIndex = 2;
               this.shiftLabel.Text = "Shift (1 or 2) :";
               // 
               // payRateLabel
               // 
               this.payRateLabel.AutoSize = true;
               this.payRateLabel.Location = new System.Drawing.Point(89, 198);
               this.payRateLabel.Name = "payRateLabel";
               this.payRateLabel.Size = new System.Drawing.Size(87, 13);
               this.payRateLabel.TabIndex = 3;
               this.payRateLabel.Text = "Pay Rate (0.00) :";
               // 
               // EmployeeFormDataEntry
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.payRateLabel);
               this.Controls.Add(this.shiftLabel);
               this.Controls.Add(this.idLabel);
               this.Controls.Add(this.nameLabel);
               this.Name = "EmployeeFormDataEntry";
               this.Text = "Form1";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label nameLabel;
          private System.Windows.Forms.Label idLabel;
          private System.Windows.Forms.Label shiftLabel;
          private System.Windows.Forms.Label payRateLabel;
     }
}

