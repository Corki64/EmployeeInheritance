using System;
using System.Collections.Generic;
using System.Windows.Forms;

/**
 * This program will open a window and ask the employer to type in data pertinent to
 * an individual employee. The data will be displayed on a grid-view window on the bottom
 * of the main form.
 *
 * This program was created for class CPSC_2713 Module 6 Activity
 *
 * @author Luis Cortez (lac0084@auburn.edu)
 * @version 042120191534
 */
namespace EmployeeForm
{
     public partial class EmployeeFormDataEntry : Form
     {
          public EmployeeFormDataEntry()
          {
               InitializeComponent();
          }

          private readonly List<ProductionWorker> _workerList = new List<ProductionWorker>();

          private void EmployeeFormDataEntry_Load(object sender, EventArgs e)
          {

          }

          private void ExitButton_Click(object sender, EventArgs e)
          {
               Close();
          }

          private void EnterDataButton_Click(object sender, EventArgs e)
          {


               var worker = new ProductionWorker
               {
                    EmployeeName = nameTextBox.Text,
                    EmployeeNumber = Convert.ToInt32(IdNumberTextBox.Text),
                    ShiftNumber = Convert.ToInt32(ShiftTextBox.Text),
                    HourlyPayRate = Convert.ToDouble(PayRateTextBox.Text)

               };
               _workerList.Add(worker);

               dataGridView1.DataSource = _workerList;
               EmployeeFormDataEntry_Load(_workerList, e);
          }



          private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }
     }
}
