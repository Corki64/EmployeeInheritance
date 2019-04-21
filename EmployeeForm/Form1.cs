using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeForm
{
     public partial class EmployeeFormDataEntry : Form
     {
          public EmployeeFormDataEntry()
          {
               InitializeComponent();
          }

          List<ProductionWorker> _workerList = new List<ProductionWorker>();

          private void EmployeeFormDataEntry_Load(object sender, EventArgs e)
          {

          }

          private void ExitButton_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void EnterDataButton_Click(object sender, EventArgs e)
          {
               ProductionWorker worker = new ProductionWorker
               {
                    EmployeeName = nameTextBox.Text,
                    EmployeeNumber = Convert.ToInt32(IdNumberTextBox.Text),
                    ShiftNumber = Convert.ToInt32(ShiftTextBox.Text),
                    HourlyPayRate = Convert.ToDouble(PayRateTextBox.Text)
               };

               _workerList.Add(worker);

               
          }
     }
}
