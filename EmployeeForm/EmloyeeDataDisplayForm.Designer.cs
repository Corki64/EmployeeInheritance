namespace EmployeeForm
{
     partial class EmployeeDataDisplayForm
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
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.productionWorkerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
               this.productionWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.productionWorkerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
               this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.employeeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.shiftNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.hourlyPayRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.productionWorkerBindingSource1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.productionWorkerBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.productionWorkerBindingSource2)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.AutoGenerateColumns = false;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeNumberDataGridViewTextBoxColumn,
            this.shiftNumberDataGridViewTextBoxColumn,
            this.hourlyPayRateDataGridViewTextBoxColumn});
               this.dataGridView1.DataSource = this.productionWorkerBindingSource1;
               this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dataGridView1.Location = new System.Drawing.Point(0, 0);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(482, 292);
               this.dataGridView1.TabIndex = 0;
               this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
               // 
               // productionWorkerBindingSource1
               // 
               this.productionWorkerBindingSource1.DataSource = typeof(EmployeeForm.ProductionWorker);
               // 
               // productionWorkerBindingSource
               // 
               this.productionWorkerBindingSource.DataSource = typeof(EmployeeForm.ProductionWorker);
               // 
               // productionWorkerBindingSource2
               // 
               this.productionWorkerBindingSource2.DataSource = typeof(EmployeeForm.ProductionWorker);
               // 
               // employeeNameDataGridViewTextBoxColumn
               // 
               this.employeeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
               this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
               this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
               // 
               // employeeNumberDataGridViewTextBoxColumn
               // 
               this.employeeNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeeNumber";
               this.employeeNumberDataGridViewTextBoxColumn.HeaderText = "Employee Number";
               this.employeeNumberDataGridViewTextBoxColumn.Name = "employeeNumberDataGridViewTextBoxColumn";
               // 
               // shiftNumberDataGridViewTextBoxColumn
               // 
               this.shiftNumberDataGridViewTextBoxColumn.DataPropertyName = "ShiftNumber";
               this.shiftNumberDataGridViewTextBoxColumn.HeaderText = "ShiftNumber";
               this.shiftNumberDataGridViewTextBoxColumn.Name = "shiftNumberDataGridViewTextBoxColumn";
               // 
               // hourlyPayRateDataGridViewTextBoxColumn
               // 
               this.hourlyPayRateDataGridViewTextBoxColumn.DataPropertyName = "HourlyPayRate";
               this.hourlyPayRateDataGridViewTextBoxColumn.HeaderText = "HourlyPayRate";
               this.hourlyPayRateDataGridViewTextBoxColumn.Name = "hourlyPayRateDataGridViewTextBoxColumn";
               // 
               // EmployeeDataDisplayForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoSize = true;
               this.ClientSize = new System.Drawing.Size(482, 292);
               this.Controls.Add(this.dataGridView1);
               this.Name = "EmployeeDataDisplayForm";
               this.Text = "Employee Data Information Form";
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.productionWorkerBindingSource1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.productionWorkerBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.productionWorkerBindingSource2)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.BindingSource productionWorkerBindingSource;
          private System.Windows.Forms.BindingSource productionWorkerBindingSource1;
          private System.Windows.Forms.BindingSource productionWorkerBindingSource2;
          private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumberDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn shiftNumberDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn hourlyPayRateDataGridViewTextBoxColumn;
     }
}