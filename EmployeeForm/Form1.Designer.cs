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
               this.nameTextBox = new System.Windows.Forms.TextBox();
               this.IdNumberTextBox = new System.Windows.Forms.TextBox();
               this.ShiftTextBox = new System.Windows.Forms.TextBox();
               this.PayRateTextBox = new System.Windows.Forms.TextBox();
               this.EnterDataButton = new System.Windows.Forms.Button();
               this.ExitButton = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // nameLabel
               // 
               this.nameLabel.AutoSize = true;
               this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.nameLabel.Location = new System.Drawing.Point(83, 39);
               this.nameLabel.Name = "nameLabel";
               this.nameLabel.Size = new System.Drawing.Size(59, 20);
               this.nameLabel.TabIndex = 0;
               this.nameLabel.Text = "Name :";
               // 
               // idLabel
               // 
               this.idLabel.AutoSize = true;
               this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.idLabel.Location = new System.Drawing.Point(48, 79);
               this.idLabel.Name = "idLabel";
               this.idLabel.Size = new System.Drawing.Size(94, 20);
               this.idLabel.TabIndex = 1;
               this.idLabel.Text = "ID Number :";
               // 
               // shiftLabel
               // 
               this.shiftLabel.AutoSize = true;
               this.shiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.shiftLabel.Location = new System.Drawing.Point(92, 120);
               this.shiftLabel.Name = "shiftLabel";
               this.shiftLabel.Size = new System.Drawing.Size(50, 20);
               this.shiftLabel.TabIndex = 2;
               this.shiftLabel.Text = "Shift :";
               // 
               // payRateLabel
               // 
               this.payRateLabel.AutoSize = true;
               this.payRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.payRateLabel.Location = new System.Drawing.Point(60, 165);
               this.payRateLabel.Name = "payRateLabel";
               this.payRateLabel.Size = new System.Drawing.Size(82, 20);
               this.payRateLabel.TabIndex = 3;
               this.payRateLabel.Text = "Pay Rate :";
               // 
               // nameTextBox
               // 
               this.nameTextBox.Location = new System.Drawing.Point(148, 39);
               this.nameTextBox.Name = "nameTextBox";
               this.nameTextBox.Size = new System.Drawing.Size(156, 20);
               this.nameTextBox.TabIndex = 4;
               this.nameTextBox.Text = "Last, First";
               // 
               // IdNumberTextBox
               // 
               this.IdNumberTextBox.Location = new System.Drawing.Point(148, 79);
               this.IdNumberTextBox.Name = "IdNumberTextBox";
               this.IdNumberTextBox.Size = new System.Drawing.Size(54, 20);
               this.IdNumberTextBox.TabIndex = 5;
               this.IdNumberTextBox.Text = "####";
               // 
               // ShiftTextBox
               // 
               this.ShiftTextBox.Location = new System.Drawing.Point(148, 120);
               this.ShiftTextBox.Name = "ShiftTextBox";
               this.ShiftTextBox.Size = new System.Drawing.Size(54, 20);
               this.ShiftTextBox.TabIndex = 6;
               this.ShiftTextBox.Text = "1 or 2";
               // 
               // PayRateTextBox
               // 
               this.PayRateTextBox.Location = new System.Drawing.Point(148, 165);
               this.PayRateTextBox.Name = "PayRateTextBox";
               this.PayRateTextBox.Size = new System.Drawing.Size(54, 20);
               this.PayRateTextBox.TabIndex = 7;
               this.PayRateTextBox.Text = "0.00";
               // 
               // EnterDataButton
               // 
               this.EnterDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.EnterDataButton.Location = new System.Drawing.Point(236, 223);
               this.EnterDataButton.Name = "EnterDataButton";
               this.EnterDataButton.Size = new System.Drawing.Size(75, 30);
               this.EnterDataButton.TabIndex = 8;
               this.EnterDataButton.Text = "Submit";
               this.EnterDataButton.UseVisualStyleBackColor = true;
               this.EnterDataButton.Click += new System.EventHandler(this.EnterDataButton_Click);
               // 
               // ExitButton
               // 
               this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ExitButton.Location = new System.Drawing.Point(12, 223);
               this.ExitButton.Name = "ExitButton";
               this.ExitButton.Size = new System.Drawing.Size(75, 30);
               this.ExitButton.TabIndex = 9;
               this.ExitButton.Text = "Exit";
               this.ExitButton.UseVisualStyleBackColor = true;
               this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
               // 
               // EmployeeFormDataEntry
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(323, 265);
               this.Controls.Add(this.ExitButton);
               this.Controls.Add(this.EnterDataButton);
               this.Controls.Add(this.PayRateTextBox);
               this.Controls.Add(this.ShiftTextBox);
               this.Controls.Add(this.IdNumberTextBox);
               this.Controls.Add(this.nameTextBox);
               this.Controls.Add(this.payRateLabel);
               this.Controls.Add(this.shiftLabel);
               this.Controls.Add(this.idLabel);
               this.Controls.Add(this.nameLabel);
               this.Name = "EmployeeFormDataEntry";
               this.Text = "Employee Shift and Pay Form";
               this.Load += new System.EventHandler(this.EmployeeFormDataEntry_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label nameLabel;
          private System.Windows.Forms.Label idLabel;
          private System.Windows.Forms.Label shiftLabel;
          private System.Windows.Forms.Label payRateLabel;
          private System.Windows.Forms.TextBox nameTextBox;
          private System.Windows.Forms.TextBox IdNumberTextBox;
          private System.Windows.Forms.TextBox ShiftTextBox;
          private System.Windows.Forms.TextBox PayRateTextBox;
          private System.Windows.Forms.Button EnterDataButton;
          private System.Windows.Forms.Button ExitButton;
     }
}

