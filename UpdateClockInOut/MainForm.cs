using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateClockInOut
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cbFirstName.Text = "All";
        }

        private int _timeSheetID;

        private void MainForm_Load(object sender, EventArgs e)
        {
            DatabaseHandle dbHandle = new DatabaseHandle();
            DataTable dt = dbHandle.ListOfStaff();

            List<String> lstFirstName = dt.AsEnumerable().Select(r => r.Field<String>("first_name")).ToList();
            lstFirstName = lstFirstName.Distinct().ToList();

            cbFirstName.Items.Add("All");
            foreach (String firstName in lstFirstName)
            {
                cbFirstName.Items.Add(firstName);
            }

            dgvStaff.DataSource = dt;
            InitializeDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DatabaseHandle dbHandle = new DatabaseHandle();
            DataTable dt;
            if (cbFirstName.Text == "All")
                dt = dbHandle.ListOfStaff();
            else
                dt = dbHandle.ListOfStaffByFirstName(cbFirstName.Text, dtpSearchST.Value.Date.ToLongTimeString(), dtpSearchET.Value.Date.ToLongTimeString());
            //dt = dbHandle.ListOfStaffByFirstName(cbFirstName.Text, dtpSearchST.Value.ToLongTimeStringring("yyyy-MM-dd HH:mm:ss"), dtpSearchET.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")) ;

            if (dt == null)
                dt = dbHandle.ListOfStaff();

            dgvStaff.DataSource = dt;
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            DataGridViewColumn column = dgvStaff.Columns[0];
            column.Width = 50;
            column = dgvStaff.Columns[1];
            column.Width = 100;
            column = dgvStaff.Columns[2];
            column.Width = 150;
            column = dgvStaff.Columns[3];
            column.Width = 150;
            dgvStaff.Columns[2].DefaultCellStyle.Format = "d/M/yyyy HH:mm:ss";
            dgvStaff.Columns[3].DefaultCellStyle.Format = "d/M/yyyy HH:mm:ss";
            this.dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.MultiSelect = false;
        }

        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvStaff.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvStaff.Rows[selectedrowindex];

                _timeSheetID = int.Parse(Convert.ToString(selectedRow.Cells["employee_time_sheet_id"].Value));

                txtUpdateStaff.Text = Convert.ToString(selectedRow.Cells["first_name"].Value);
                String sTime = Convert.ToString(selectedRow.Cells["clockin_time"].Value);
                String eTime = Convert.ToString(selectedRow.Cells["clockout_time"].Value);

                dtpUpdateST.Value =  DateTime.ParseExact(sTime, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                if(eTime != "")
                    dtpUpdateET.Value = DateTime.ParseExact(eTime, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHandle dbHandle = new DatabaseHandle();
                DataTable dt;
                if (dbHandle.UpdateStaffTimeSheet(_timeSheetID, dtpUpdateST.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtpUpdateET.Value.ToString("yyyy-MM-dd HH:mm:ss")) > 0)
                {
                    MessageBox.Show("Update Complete!");
                    dt = dbHandle.ListOfStaff();

                    if (dt == null)
                        dt = dbHandle.ListOfStaff();

                    dgvStaff.DataSource = dt;
                    InitializeDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Update " + ex.Message);
            }

        }
    }
}
