using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab8
{
    public partial class Form1 : Form
    {
        private const string FileName = "data\\photos.xml";
        private XmlTextReader _reader;
        private DataSet _dataSet;
        private DataTable _table;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dataSet = new DataSet();
            
            var fs = new FileStream(FileName, FileMode.Open);
            _reader = new XmlTextReader(fs);
            _dataSet.ReadXml(_reader, XmlReadMode.InferSchema);
            _table = _dataSet.Tables[0];
            _table.PrimaryKey = new[] { _table.Columns[0] };
            
            bindingSource1.DataMember = _table.TableName;
            bindingSource1.DataSource = _table;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Дата";
            dataGridView1.Columns[3].HeaderText = "Название файла";

            fs.Close();
        }

        // private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        // {
        //     DisplayDetails(e.RowIndex);
        // }
        //
        // private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        // {
        //     DisplayDetails(e.RowIndex);
        // }
        
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DisplayDetails(e.RowIndex);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(textBoxSearchName.Text))
                sb.Append($"Name LIKE '%{textBoxSearchName.Text}%'");

            if (checkBoxDate.Checked)
            {
                if (sb.Length > 0)
                    sb.Append(" AND ");
                
                sb.Append($"Date = '{dateTimePickerSearchDate.Value.ToString("yyyy-MM-dd")}'");
            }
            
            _table.DefaultView.RowFilter = sb.Length > 0 ? sb.ToString() : string.Empty;

            dataGridView1.Refresh();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearchName.Text = string.Empty;
            checkBoxDate.Checked = false;
            Filter();
        }
        
        private void DisplayDetails(int rowIndex)
        {
            if (rowIndex < 0)
                return;
            
            var photoId = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            
            var row = _table.Rows.Find(photoId);
            
            var name = row[1].ToString();
            var date = row[2].ToString();
            var fileName = $@"Data\\{row[3]}";

            pictureBox1.Image = Image.FromFile(fileName);
            textBoxName.Text = name;
            textBoxDate.Text = date;
        }
    }
}