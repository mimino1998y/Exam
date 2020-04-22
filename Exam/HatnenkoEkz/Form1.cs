using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace HatnenkoEkz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void redB_Click(object sender, EventArgs e)
        {
            if (redNameTB.Text == "" || redQuantityTB.Text == "" || redQuotaTB.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка.");
                return;
            }

            try
            {
                int t = Convert.ToInt32(redQuantityTB.Text);
                t = Convert.ToInt32(redQuotaTB.Text);
            }

            catch (Exception exc)
            {
                MessageBox.Show("В поля \"Количество товара\" и \"Квота товара\" можно вводить только целочисленные значения!\n" + exc.ToString(), "Ошибка.");
                return;
            }

            if (Convert.ToInt32(redQuantityTB.Text) < 0 || Convert.ToInt32(redQuotaTB.Text) <= 0)
            {
                MessageBox.Show("Количество и квота товара не могут быть отрицательными!", "Ошибка.");
                return;
            }

            bool flag = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == redIdTB.Text)
                {
                    for (int j = 1; j < dataGridView1.ColumnCount; j++)
                    {
                        if (j == 1) dataGridView1.Rows[i].Cells[j].Value = redNameTB.Text;
                        else if (j == 2) dataGridView1.Rows[i].Cells[j].Value = redQuantityTB.Text;
                        else if (j == 3) dataGridView1.Rows[i].Cells[j].Value = redQuotaTB.Text;
                    }
                    flag = true;
                    updateXMLfile();
                    break;
                }
            }

            if (!flag) MessageBox.Show("Такого ID не существует!", "Ошибка.");
           
        }

        private void addB_Click(object sender, EventArgs e)
        {
            if (redNameTB.Text == "" || redQuantityTB.Text == "" || redQuotaTB.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка.");
                return;
            }

            try
            {
                int t = Convert.ToInt32(redQuantityTB.Text);
                t = Convert.ToInt32(redQuotaTB.Text);
            }

            catch (Exception exc)
            {
                MessageBox.Show("В поля \"Количество товара\" и \"Квота товара\" можно вводить только целочисленные значения!\n" + exc.ToString(), "Ошибка.");
                return;
            }

            if (Convert.ToInt32(redQuantityTB.Text) < 0 || Convert.ToInt32(redQuotaTB.Text) <= 0)
            {
                MessageBox.Show("Количество и квота товара не могут быть отрицательными!", "Ошибка.");
                return;
            }

            int n = dataGridView1.Rows.Add(); 
            dataGridView1.Rows[n].Cells[0].Value = redIdTB.Text; 
            dataGridView1.Rows[n].Cells[1].Value = redNameTB.Text; 
            dataGridView1.Rows[n].Cells[2].Value = redQuantityTB.Text; 
            dataGridView1.Rows[n].Cells[3].Value = redQuotaTB.Text;
            updateXMLfile();
        }


        public void updateXMLfile()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            dt.TableName = "Product";
            dt.Columns.Add("Id"); 
            dt.Columns.Add("Name");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Quota");
            ds.Tables.Add(dt); 

            foreach (DataGridViewRow r in dataGridView1.Rows) 
            {
                DataRow row = ds.Tables["Product"].NewRow();
                row["Id"] = r.Cells[0].Value; 
                row["Name"] = r.Cells[1].Value;
                row["Quantity"] = r.Cells[2].Value;
                row["Quota"] = r.Cells[3].Value;
                ds.Tables["Product"].Rows.Add(row);
            }
            ds.WriteXml("../../Data.xml");          
        }
        
        public void refresh()
        {
            dataGridView1.Rows.Clear();      
            if (File.Exists("../../Data.xml"))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("../../Data.xml");

                foreach (DataRow item in ds.Tables["Product"].Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item["Id"];
                    dataGridView1.Rows[n].Cells[1].Value = item["Name"]; 
                    dataGridView1.Rows[n].Cells[2].Value = item["Quantity"]; 
                    dataGridView1.Rows[n].Cells[3].Value = item["Quota"];
                }
            }
            else
            {
                MessageBox.Show("XML файл не найден.", "Ошибка.");
            }
            
        }

        private void overviewB_Click(object sender, EventArgs e)
        {
            XmlTextWriter textWritter = new XmlTextWriter("../../Overview.xml", Encoding.UTF8);
            textWritter.WriteStartDocument();
            textWritter.WriteStartElement("NewDataSet");
            textWritter.WriteEndElement();
            textWritter.Close();

            XmlDocument document = new XmlDocument();
            document.Load("../../Overview.xml");

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (Convert.ToInt32(r.Cells[2].Value) < Convert.ToInt32(r.Cells[3].Value))
                {
                    XmlNode productXML = document.CreateElement("Product");
                    document.DocumentElement.AppendChild(productXML);

                    XmlNode idXML = document.CreateElement("Id");
                    idXML.InnerText = r.Cells[0].Value.ToString();
                    productXML.AppendChild(idXML);

                    XmlNode nameXML = document.CreateElement("Name");
                    nameXML.InnerText = r.Cells[1].Value.ToString();
                    productXML.AppendChild(nameXML);

                    XmlNode restockValueXML = document.CreateElement("RestockValue");
                    restockValueXML.InnerText = (Convert.ToInt32(r.Cells[3].Value) - Convert.ToInt32(r.Cells[2].Value)).ToString();
                    productXML.AppendChild(restockValueXML);

                    document.Save("../../Overview.xml");
                    MessageBox.Show("Выписка оформлена", "Выполнено.");
                }
            }
        }
    }

}
