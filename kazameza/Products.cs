using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Numerics;
using DevComponents.DotNetBar;

namespace kazameza
{
    public partial class Products : Office2007Form
    {
        public Products()
        {
            this.EnableGlass = false;//The essential,
            InitializeComponent();
        }

       

        private void Products_Load(object sender, EventArgs e)
        {
            Model2 db = new Model2();
            var product = from data in db.Products select data;
            foreach (var i in product)
            {
                dataGridProducts.Rows.Add(i.Title, i.Img, i.Quantity, i.Price, i.MinPrice, i.WholesalePrice, i.SouqPS, i.SellerPS, i.SouqPrice, i.SellerPrice, i.EAN, i.Sku, i.CategoryType);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Model2 db = new Model2();
            Product product = new Product();
            product.Title = textBoxX1.Text;
            // product.Img = textBoxX2.Text
            product.Quantity = int.Parse(textBoxX3.Text);
            product.Price =Convert.ToDecimal( textBoxX4.Text);
            //  updata.MinPrice = Convert.ToDecimal(textBoxX5.Text);
            product.WholesalePrice= Convert.ToDecimal(textBoxX6.Text);
            product.SouqPS = Convert.ToDouble(textBoxX7.Text);
            product.SellerPS= Convert.ToDouble(textBoxX8.Text);
            decimal price = Convert.ToDecimal(textBoxX4.Text);
            double souqps= Convert.ToDouble(textBoxX7.Text);
            decimal souqprice = price *Convert.ToDecimal( souqps);
            decimal sellerprice=  price* Convert.ToDecimal(textBoxX8.Text);
            decimal wholesale = Convert.ToDecimal(textBoxX6.Text);
            product.MinPrice = souqprice + sellerprice + wholesale;
            product.SouqPrice = souqprice;
            product.SellerPrice = sellerprice;
            product.EAN = textBoxX9.Text;
            product.Sku = textBoxX10.Text;
           // product.CategoryType = int.Parse(textBoxX11.Text);
            string cate = textBoxX10.Text;
            string catetype= cate.Substring(0, cate.IndexOf("."));
            product.CategoryType = int.Parse(catetype);
            db.Products.Add(product);
            db.SaveChanges();
            textBoxX1.Text = textBoxX2.Text = textBoxX3.Text = textBoxX4.Text = textBoxX5.Text = textBoxX6.Text = textBoxX7.Text = textBoxX8.Text = textBoxX9.Text = textBoxX10.Text = textBoxX11.Text = "";
        }

        //private void update_btn_Click(object sender, EventArgs e)
        //{
        //    Model2 db = new Model2();
        //    var updata = (from data in db.Products
        //                  where data.EAN.ToString() == textBoxX9.Text
        //                  select data).First();

        //    updata.Title = textBoxX1.Text;
        //    updata.Quantity = int.Parse(textBoxX3.Text);
        //    updata.Price = Convert.ToDecimal(textBoxX4.Text);
        //  //  updata.MinPrice = Convert.ToDecimal(textBoxX5.Text);
        //    updata.WholesalePrice = Convert.ToDecimal(textBoxX6.Text);
        //    updata.SouqPS = Convert.ToDouble(textBoxX7.Text);
        //    updata.SellerPS = Convert.ToDouble(textBoxX8.Text);
        //    decimal price = Convert.ToDecimal(textBoxX4.Text);
        //    double souqps = Convert.ToDouble(textBoxX7.Text);
        //    decimal souqprice = price * Convert.ToDecimal(souqps);
        //    decimal sellerprice = price * Convert.ToDecimal(textBoxX8.Text);
        //    decimal wholesale = Convert.ToDecimal(textBoxX6.Text);
        //    updata.MinPrice = souqprice + sellerprice + wholesale;
        //    updata.SouqPrice = souqprice;
        //    updata.SellerPrice = sellerprice;
        //    updata.EAN = textBoxX9.Text;
        //    updata.Sku = textBoxX10.Text;
        //    // updata.CategoryType = int.Parse(textBoxX11.Text);
        //    string cate = textBoxX10.Text;
        //    string catetype = cate.Substring(0, cate.IndexOf("."));
        //    updata.CategoryType = int.Parse(catetype);
        //    db.SaveChanges();
        //    textBoxX1.Text = textBoxX2.Text = textBoxX3.Text = textBoxX4.Text = textBoxX5.Text = textBoxX6.Text = textBoxX7.Text = textBoxX8.Text = textBoxX9.Text = textBoxX10.Text = textBoxX11.Text = "";

        //}

        private void dataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridProducts.CurrentRow.Index != -1)
            {
                Product product = new Product();
                product.EAN = dataGridProducts.CurrentRow.Cells["EAN"].Value.ToString();
                using (Model2 db = new Model2())
                {
                    product = db.Products.Where(x => x.EAN == product.EAN).FirstOrDefault();
                    textBoxX1.Text = product.Title;
                    textBoxX3.Text =product.Quantity.ToString();
                    textBoxX4.Text = product.Price.ToString();
                    textBoxX5.Text = product.MinPrice.ToString();
                    textBoxX6.Text = product.WholesalePrice.ToString();
                    textBoxX7.Text = product.SouqPS.ToString();
                    textBoxX8.Text = product.SellerPS.ToString();
                    textBoxX9.Text = product.EAN;
                    textBoxX10.Text = product.Sku;
                    textBoxX11.Text = product.CategoryType.ToString();






                }
            }
        }
        //excel sheet btn
        private void buttonX1_Click(object sender, EventArgs e)
        {
            string fname = "";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Excel File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fname = fdlg.FileName;
            }

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(fname);
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
           


            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
           // int colCount = xlRange.Columns.Count;

          
           // dataGridProducts.ColumnCount = colCount;
            dataGridProducts.RowCount = rowCount;
            Model2 m = new Model2();
            Product pro = new Product();

            for (int i = 1; i <= rowCount-1; i++)
            {
                for (int j = 1; j <= dataGridProducts.ColumnCount; j++)
                {



                     

                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                      // dataGridProducts.Rows[i - 1].Cells[j - 1].Value = xlRange.Cells[i, j].Value2.ToString();
                        
                        
                        dataGridProducts.Rows[i-1].Cells[0].Value = xlRange.Cells[i+1, 4].Value2.ToString();
                        dataGridProducts.Rows[i-1].Cells[2].Value = xlRange.Cells[i+1, 9].Value2.ToString();
                        dataGridProducts.Rows[i-1].Cells[3].Value = xlRange.Cells[i+1, 8].Value2.ToString();
                        dataGridProducts.Rows[i-1].Cells[10].Value = xlRange.Cells[i+1, 1].Value2.ToString();
                        dataGridProducts.Rows[i-1].Cells[11].Value = xlRange.Cells[i+1, 2].Value2.ToString();








                    }

             

                }

                pro.Title = dataGridProducts.Rows[i - 1].Cells[0].Value.ToString();
                pro.Quantity = int.Parse(dataGridProducts.Rows[i - 1].Cells[2].Value.ToString());
                pro.Price = Convert.ToDecimal(dataGridProducts.Rows[i - 1].Cells[3].Value.ToString());
                pro.EAN = dataGridProducts.Rows[i - 1].Cells[10].Value.ToString();
                pro.Sku = dataGridProducts.Rows[i - 1].Cells[11].Value.ToString();

                m.Products.Add(pro);
                m.SaveChanges();
            }

            //cleanup  
            GC.Collect();
            GC.WaitForPendingFinalizers();

            
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);

            //close and release  
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);

            //quit and release  
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);

        }

        private void labelItem1_Click(object sender, EventArgs e)
        {

        }

        private void labelItem2_Click(object sender, EventArgs e)
        {

        }

        private void labelItem3_Click(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.Show();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Setting s = new Setting();

            s.Show();
            

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            reports r = new reports();
            r.Show();
        }

       

        private void update_btn_Click_1(object sender, EventArgs e)
        {
            Model2 db = new Model2();
            var updata = (from data in db.Products
                          where data.EAN.ToString() == textBoxX9.Text
                          select data).First();

            updata.Title = textBoxX1.Text;
            updata.Quantity = int.Parse(textBoxX3.Text);
            updata.Price = Convert.ToDecimal(textBoxX4.Text);
            //  updata.MinPrice = Convert.ToDecimal(textBoxX5.Text);
            updata.WholesalePrice = Convert.ToDecimal(textBoxX6.Text);
            updata.SouqPS = Convert.ToDouble(textBoxX7.Text);
            updata.SellerPS = Convert.ToDouble(textBoxX8.Text);
            decimal price = Convert.ToDecimal(textBoxX4.Text);
            double souqps = Convert.ToDouble(textBoxX7.Text);
            decimal souqprice = price * Convert.ToDecimal(souqps);
            decimal sellerprice = price * Convert.ToDecimal(textBoxX8.Text);
            decimal wholesale = Convert.ToDecimal(textBoxX6.Text);
            updata.MinPrice = souqprice + sellerprice + wholesale;
            updata.SouqPrice = souqprice;
            updata.SellerPrice = sellerprice;
            updata.EAN = textBoxX9.Text;
            updata.Sku = textBoxX10.Text;
            // updata.CategoryType = int.Parse(textBoxX11.Text);
            string cate = textBoxX10.Text;
            string catetype = cate.Substring(0, cate.IndexOf("."));
            updata.CategoryType = int.Parse(catetype);
            db.SaveChanges();
            textBoxX1.Text = textBoxX2.Text = textBoxX3.Text = textBoxX4.Text = textBoxX5.Text = textBoxX6.Text = textBoxX7.Text = textBoxX8.Text = textBoxX9.Text = textBoxX10.Text = textBoxX11.Text = "";


        }

        private void exdown_btn_Click(object sender, EventArgs e)
        {
            excelDownload d = new excelDownload();
            d.Show();
                 
        }
    }
}
