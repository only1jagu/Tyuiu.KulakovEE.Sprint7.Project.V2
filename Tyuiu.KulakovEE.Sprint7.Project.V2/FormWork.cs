using Tyuiu.KulakovEE.Sprint7.Project.V2.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Tyuiu.KulakovEE.Sprint7.Project.V2
{
  
    public partial class FormWork : Form
    {
   
        public FormWork()
        {
            InitializeComponent();
          
        }

        public FormWork(FormMain formMain)
        {
            
            InitializeComponent();
          


        }



        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void aboutProgramToolStripMenuItem_KEE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа содержит в себе данные:\r* ·        номер, название, адрес и телефон магазина;", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_KEE_Click(object sender, EventArgs e)
        {
            openFileDialogTable_KEE.ShowDialog();
            openFilePath = openFileDialogTable_KEE.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewTableOrders_KEE.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTableOrders_KEE.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTableOrders_KEE.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            if (dataGridViewTableOrders_KEE.Rows.Count != 0) { buttonRemoveRows_KEE.Enabled = true; }
        }

        private void buttonDownload_KEE_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_KEE.FileName = "DataBase.csv";
            saveFileDialogTable_KEE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_KEE.ShowDialog();


            string path = saveFileDialogTable_KEE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewTableOrders_KEE.RowCount;
            int columns = dataGridViewTableOrders_KEE.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTableOrders_KEE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTableOrders_KEE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }
        

        private void buttonAdd_KEE_Click(object sender, EventArgs e)
        {
            dataGridViewTableOrders_KEE.Rows.Add();
            buttonRemoveRows_KEE.Enabled = true;
        }

        private void buttonInfo_KEE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripMenuItemExit_KEE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemoveRows_KEE_Click(object sender, EventArgs e)
        {
            int ind = dataGridViewTableOrders_KEE.SelectedCells[0].RowIndex;
            dataGridViewTableOrders_KEE.Rows.RemoveAt(ind);
            if (dataGridViewTableOrders_KEE.Rows.Count == 0) { buttonRemoveRows_KEE.Enabled = false; }
        }

        private void buttonFilter_KEE_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewTableOrders_KEE.Rows)
            {
                if ((r.Cells[comboBoxColsNames_KEE.SelectedIndex - 1].Value).ToString().ToUpper().Contains(textBoxFilter_KEE.Text.ToUpper()))
                {
                    dataGridViewTableOrders_KEE.Rows[r.Index].Visible = true;
                    dataGridViewTableOrders_KEE.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridViewTableOrders_KEE.CurrentCell = null;
                    dataGridViewTableOrders_KEE.Rows[r.Index].Visible = false;
                }
            }
        }

        private void comboBoxColsNames_KEE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColsNames_KEE.SelectedIndex != 0)
            {
                textBoxFilter_KEE.Enabled = true;
                buttonFilter_KEE.Enabled = true;
            }
            else
            {
                textBoxFilter_KEE.Enabled = false;
                buttonFilter_KEE.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Ежемесячная выручка");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewTableOrders_KEE.Rows)
            {
                if (!row.IsNewRow && row.Cells[3] != null && row.Cells[3].Value != null)
                {
                    string label = row.Cells[0].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[3].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.chart1.Series.Add(series);
        }

        private void toolStripMenuItemInstruction_KEE_Click(object sender, EventArgs e)
        {
            FormInstruction formInstruction = new FormInstruction();
            formInstruction.ShowDialog();
        }

        private void textBoxSearch_KEE_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxSearch_KEE != null)
            {
                string currentText = textBoxSearch_KEE.Text;
                foreach (DataGridViewRow row in dataGridViewTableOrders_KEE.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && textBoxSearch_KEE.Text != string.Empty && cell.Value.ToString().Contains(textBoxSearch_KEE.Text))
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void toolStripTextBoxSearch_KEE_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch_KEE != null)
            {
                string currentText = toolStripTextBoxSearch_KEE.Text;
                foreach (DataGridViewRow row in dataGridViewTableOrders_KEE.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && toolStripTextBoxSearch_KEE.Text != string.Empty && cell.Value.ToString().Contains(toolStripTextBoxSearch_KEE.Text))
                        {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelSearch_KEE_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFilter_KEE_TextChanged(object sender, EventArgs e)
        {

        }

        private void поддержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelpDevWin formHelpDevWin = new FormHelpDevWin();
            formHelpDevWin.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)

        {
            
         
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

       
        
        

        private void dataGridViewTable_KEE_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index).ToString();
            object header = this.dataGridViewTableOrders_KEE.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewTableOrders_KEE.Rows[index].HeaderCell.Value = indexStr;
        }
  
    }
}

