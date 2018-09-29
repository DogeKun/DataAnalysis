using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAnalysisTask1.data;


namespace DataAnalysisTask1
{
    public partial class Form1 : Form
    {
        private Database dbPhone;
        public Form1()
        {
            InitializeComponent();
            //PhoneCPU lt;
            dbPhone = new Database();
            dbPhone.ReadDatabase();

            this.WindowState = FormWindowState.Maximized;

            DataTable_Fill();
            ComboBox_Fill();
        }

        public void DataTable_Fill()
        {
            
            DataTable dTable = new DataTable();
            PhoneDataGrid.DataSource = dTable;
            dTable.Columns.AddRange(new DataColumn[14]
            {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Pavadinimas"),
                new DataColumn("Kaina", typeof(float)),
                new DataColumn("Cpu pavadinimas"),
                new DataColumn("Cores", typeof(int)),
                new DataColumn("Gpu"),
                new DataColumn("Battery capacity"),
                new DataColumn("Camera MPX", typeof(int)),
                new DataColumn("Memory Capacity", typeof(int)),
                new DataColumn("ScreenName"),
                new DataColumn("ScreenIstrizaine", typeof(float)),
                new DataColumn("Resoliution"),
                new DataColumn("StorageAmount", typeof(int)),
                new DataColumn("Analitic Length", typeof(float))
            });

            foreach(Phone phone in dbPhone.phones)
            {
                dTable.Rows.Add(
                    phone.phoneID, phone.phoneName, phone.phonePrice,
                    phone.cpu.cpuName, phone.cpu.cpuCore, phone.cpu.gpuName,
                    phone.battery.batteryCapacity, phone.camera.cameraMPX, phone.memory.memoryAmount,
                    phone.screen.screenName, phone.screen.Istrizaine(),
                    phone.resoliution.ResoliutionToString(), phone.storage.storageCapacity, phone.AnalysisLength
                    );
            }
            PhoneDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            PhoneDataGrid.AllowUserToResizeRows = true;
            PhoneDataGrid.AllowUserToResizeColumns = true;
            PhoneDataGrid.AllowUserToAddRows = false;

            PhoneDataGrid.Font = new Font("Microsoft sans serif", 10);
            PhoneDataGrid.DataSource = dTable;
        }

        private void ComboBox_Fill()
        {
            //Clearing Comboboxes if for some reason we will need to update information
            BatteryComboBox.Items.Clear();
            CPUCoreComboBox.Items.Clear();
            CameraComboBox.Items.Clear();
            MemoryComboBox.Items.Clear();
            ResoliutionComboBox.Items.Clear();
            StorageComboBox.Items.Clear();
            ScreenSizeComboBox.Items.Clear();

            BatteryComboBox.Items.Add("Select Item");
            BatteryComboBox.SelectedIndex = 0;
            foreach (PhoneBattery battery in dbPhone.batteries)
            {
                ComboBoxItem item = new ComboBoxItem(battery.batteryID, battery.batteryCapacity.ToString() + "mAh");
                BatteryComboBox.Items.Add(item);
            }
            
            //BatteryComboBox.SelectionChangeCommitted += BatteryComboBox_SelectionChange;

            CPUCoreComboBox.Items.Add("Select Item");
            CPUCoreComboBox.SelectedIndex = 0;
            var temp = new List<int>();
            foreach (PhoneCPU cpu in dbPhone.cpus)
            {
                ComboBoxItem item = new ComboBoxItem(cpu.cpuID, cpu.cpuCore.ToString());
                if( !temp.Contains(cpu.cpuCore) )
                {
                    temp.Add(cpu.cpuCore);
                    //Console.WriteLine(CPUCoreComboBox.Items.Contains(item));
                    CPUCoreComboBox.Items.Add(item);
                }
            }
            temp.Clear(); temp = null;
            CPUCoreComboBox.SelectionChangeCommitted += ComboBox_SelectionChange;

            CameraComboBox.Items.Add("Select Item");
            CameraComboBox.SelectedIndex = 0;
            //CameraComboBox.DataSource = dbPhone.cameras;
            temp = new List<int>();
            foreach (PhoneCamera cam in dbPhone.cameras)
            {
                ComboBoxItem item = new ComboBoxItem(cam.cameraID, cam.ToString());

                if (!temp.Contains(cam.cameraMPX))
                {
                    temp.Add(cam.cameraMPX);
                    Console.WriteLine(cam.cameraMPX);
                    CameraComboBox.Items.Add(item);
                }
            }
            temp.Clear(); temp = null;

            CameraComboBox.SelectionChangeCommitted += ComboBox_SelectionChange;


            MemoryComboBox.Items.Add("Select Item");
            MemoryComboBox.SelectedIndex = 0;
            foreach (PhoneMemory memory in dbPhone.memory)
            {
                ComboBoxItem item = new ComboBoxItem(memory.memoryID, memory.memoryAmount.ToString() + " GB");
                MemoryComboBox.Items.Add(item);
            }

            ResoliutionComboBox.Items.Add("Select Item");
            ResoliutionComboBox.SelectedIndex = 0;
            foreach (PhoneResoliution resoliution in dbPhone.resoliutions)
            {
                ComboBoxItem item = new ComboBoxItem(resoliution.resoliutionID, resoliution.ResoliutionToString());
                ResoliutionComboBox.Items.Add(item);
            }

            StorageComboBox.Items.Add("Select Item");
            StorageComboBox.SelectedIndex = 0;
            foreach (PhoneStorage storage in dbPhone.storages)
            {
                ComboBoxItem item = new ComboBoxItem(storage.storageID, storage.storageCapacity.ToString() + " GB");
                StorageComboBox.Items.Add(item);
            }

            ScreenSizeComboBox.Items.Add("Select Item");
            ScreenSizeComboBox.SelectedIndex = 0;

            var tempfloat = new List<float>();
            foreach (PhoneScreen screen in dbPhone.screens)
            {
                ComboBoxItem item = new ComboBoxItem(screen.screenID, screen.ToString());
                if (!tempfloat.Contains(screen.Istrizaine()))
                {
                    tempfloat.Add(screen.Istrizaine()); 
                    ScreenSizeComboBox.Items.Add(item);
                }
            }
            tempfloat.Clear(); tempfloat = null;
        }

        public void ComboBox_SelectionChange(object sender, EventArgs e)
        {
            if(CPUCoreComboBox.SelectedIndex != 0)
                Console.WriteLine((CPUCoreComboBox.SelectedItem as ComboBoxItem).ItemID + " " + (CPUCoreComboBox.SelectedItem as ComboBoxItem).ItemValue);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnalysisLength_Click(object sender, EventArgs e)
        {
            List<int> analysisdata_ID = new List<int>();

            if (BatteryComboBox.SelectedIndex != 0)
                analysisdata_ID.Add((BatteryComboBox.SelectedItem as ComboBoxItem).ItemID);
            else analysisdata_ID.Add(-1);

            if (CPUCoreComboBox.SelectedIndex != 0)
                analysisdata_ID.Add((CPUCoreComboBox.SelectedItem as ComboBoxItem).ItemID);
            else analysisdata_ID.Add(-1);

            if (CameraComboBox.SelectedIndex != 0)
                analysisdata_ID.Add((CameraComboBox.SelectedItem as ComboBoxItem).ItemID);
            else analysisdata_ID.Add(-1);

            if (MemoryComboBox.SelectedIndex != 0)
                analysisdata_ID.Add((MemoryComboBox.SelectedItem as ComboBoxItem).ItemID);
            else analysisdata_ID.Add(-1);

            if (ResoliutionComboBox.SelectedIndex != 0)
                analysisdata_ID.Add((ResoliutionComboBox.SelectedItem as ComboBoxItem).ItemID);
            else analysisdata_ID.Add(-1);

            if (StorageComboBox.SelectedIndex != 0)
                analysisdata_ID.Add((StorageComboBox.SelectedItem as ComboBoxItem).ItemID);
            else analysisdata_ID.Add(-1);

            if (ScreenSizeComboBox.SelectedIndex != 0)
                analysisdata_ID.Add((ScreenSizeComboBox.SelectedItem as ComboBoxItem).ItemID);
            else analysisdata_ID.Add(-1);
            
            foreach (int sk in analysisdata_ID)
                if(sk > -1)
                {
                    new DataAnalysis().Analyse(analysisdata_ID, ref dbPhone);
                    DataTable_Fill();
                    return;
                }
            //if for some reason the statment doesnt work it will give user a message box 
            MessageBox.Show("Select atleast 1 attribute");
            return;

        }
    }
}
