using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

using Quotation;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeRawMaterials();

        }

        private void InitializeRawMaterials()
        {
            var cylinder0 = new Cylinder("New...", 0, 0, 0, 0, 1);
            var cylinder1 = new Cylinder("MS ROUND", 0.27, 0.135, 7850, 5, 1);
            var cylinder2 = new Cylinder("ALUMINUM ROUNDS", 0.05, 2, 2700, 12, 1);
            var cylinder3 = new Cylinder("4140 ROUND", 0.21, 0.04, 7850, 6, 1);
            var cylinder4 = new Cylinder("s600-vanadis23", 0.068, 0.045, 7850, 40, 1);
            var cylinder5 = new Cylinder("SS316 ROUND", 0.025, 0.225, 8000, 12, 1);
            var cylinder6 = new Cylinder("calmax ROUND", 0.04, 0.465, 7850, 16, 1);
            var cylinder7 = new Cylinder("EN36A", 0.025, 0.27, 7850, 10, 1);
            var cylinder8 = new Cylinder("SS431 ROUND", 0.25, 0.045, 8000, 9.5, 1);
            var cylinder9 = new Cylinder("K1045 ROUND", 0.18, 3, 7850, 2, 1);
            var cylinder10 = new Cylinder("K110", 0.0508, 0.11, 7850, 12, 1);
            var cylinder12 = new Cylinder("BRONZE SOLID", 0.1778, 0.076, 8000, 16, 1);
            var cylinder13 = new Cylinder("NYLON-B PLASTICS", 0.2, 0.05, 1100, 15, 1);
            ////////////////
            //BindingList <Cylinder> bindinglist = new BindingList<Cylinder>
            //{
            //    cylinder0,
            //    cylinder1,
            //    cylinder2,
            //    cylinder3,
            //    cylinder4,
            //    cylinder5,
            //    cylinder6,
            //    cylinder7,
            //    cylinder8,
            //    cylinder9,
            //    cylinder10,
            //    cylinder11,
            //    cylinder12,
            //    cylinder13
            //};

            //BindingSource bSource = new BindingSource
            //{
            //    DataSource = bindinglist
            //};

            //foreach (Cylinder cylinder in bindinglist)
            //{
            //    cylinder.ComputePricePerPiece();
            //    cylinder.ComputeTotalPrice();
            //}

            //cylinderList.AddRange(cylinders);

            //comboBox1.DisplayMember = "Name";
            //comboBox1.ValueMember = null;

            //comboBox1.DataSource = bSource;

            ////////////////////////

            List<Cylinder> cylinders = new List<Cylinder>
            {
                cylinder0,
                cylinder1,
                cylinder2,
                cylinder3,
                cylinder4,
                cylinder5,
                cylinder6,
                cylinder7,
                cylinder8,
                cylinder9,
                cylinder10,
                
                cylinder12,
                cylinder13
            };

            foreach (Cylinder cylinder in cylinders)
            {
                cylinder.ComputePricePerPiece();
                cylinder.ComputeTotalPrice();
            }

            cylinderList.AddRange(cylinders);

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = null;
            comboBox1.DataSource = cylinderList;

            textBox1.Text = cylinderList.Count.ToString();

        }

        Quote testQuotation = new Quote();
        

        private bool lockAdd = false;
        private bool lockModify = true;

        private void btnPushToTest_Click(object sender, EventArgs e)
        {

            Material material = new Material();

            try
            {
                material.Name = TxtName.Text;
                material.Qty = UInt32.Parse(TxtQty.Text);
                material.Material_Cost = float.Parse(TxtCost.Text);
                material.Markup = float.Parse(TxtMarkup.Text);
                material.Setup_Cost = UInt32.Parse(TxtSetupCost.Text);
                material.Setup_Hr = float.Parse(TxtSetupHr.Text);
                material.Operation_Cost = UInt32.Parse(TxtOptCost.Text);
                material.Operation_Hr = float.Parse(TxtOptHr.Text);

                //testQuotation.Name = TxtName.Text;
                //testQuotation.Qty = UInt32.Parse(TxtQty.Text);
                //testQuotation.Material_Cost = UInt32.Parse(TxtCost.Text);
                //testQuotation.Markup = float.Parse(TxtMarkup.Text);
                //testQuotation.Setup_Cost = UInt32.Parse(TxtSetupCost.Text);
                //testQuotation.Setup_Hr = float.Parse(TxtSetupHr.Text);
                //testQuotation.Operation_Cost = UInt32.Parse(TxtOptCost.Text);
                //testQuotation.Operation_Hr = float.Parse(TxtOptHr.Text);
                
                if(!lockModify)
                {
                    testQuotation.ModifyMaterial(oldName, material);
                    lockModify = true;
                }

                if (!lockAdd)
                {
                    testQuotation.AddMaterial(material);
                    lockAdd = true;
                }

                material.SetSubTotal();
                material.SetPricePerPiece();
                testQuotation.setTotal();
                

                TxtTotal.Text = testQuotation.Total.ToString();

                //TxtListofMaterials.Text = testQuotation.listMaterials();
                //var sb = new StringBuilder();
                //var listOfMaterials = testQuotation.GetMaterials();
                //foreach(Material material1 in listOfMaterials)
                //{
                //    sb.AppendLine(material1.Name);
                //    sb.Append("; Subtotal: " + material.SubTotal.ToString());
                //}

                //TxtListofMaterials.Text = sb.ToString();
                DisplayTable();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //MessageBox.Show(testQuotation.ToString());

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtQty.Clear();
            TxtCost.Clear();
            TxtMarkup.Clear();
            TxtSetupCost.Clear();
            TxtSetupHr.Clear();
            TxtOptCost.Clear();
            TxtOptHr.Clear();

            lockAdd = false;
            lockModify = true;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtQty_TextChanged(object sender, EventArgs e)
        {
            if (AutomaticTotal())
                TxtTotal.Text = testQuotation.Total.ToString();
        }

        private void TxtMarkup_TextChanged(object sender, EventArgs e)
        {
            if (AutomaticTotal())
                TxtTotal.Text = testQuotation.Total.ToString();
        }

        private void TxtCost_TextChanged(object sender, EventArgs e)
        {
            if (AutomaticTotal())
                TxtTotal.Text = testQuotation.Total.ToString();
        }

        private void TxtSetupCost_TextChanged(object sender, EventArgs e)
        {
            if (AutomaticTotal())
                TxtTotal.Text = testQuotation.Total.ToString();
        }

        private void TxtSetupHr_TextChanged(object sender, EventArgs e)
        {
            if (AutomaticTotal())
                TxtTotal.Text = testQuotation.Total.ToString();
        }

        private void TxtOptCost_TextChanged(object sender, EventArgs e)
        {
            if (AutomaticTotal())
            {
                TxtTotal.Text = testQuotation.Total.ToString();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (AutomaticTotal())
                TxtTotal.Text = testQuotation.Total.ToString();
        }

        static int x = 0;

        private bool AutomaticTotal()
        {
            if ( TxtQty.Text.Length > 0 && TxtCost.Text.Length > 0
                && TxtMarkup.Text.Length > 0 && TxtSetupCost.Text.Length > 0
                && TxtSetupHr.Text.Length > 0 && TxtOptCost.Text.Length > 0
                && TxtOptHr.Text.Length > 0)
            {
                //TxtListofMaterials.Text = "Hu" + x + 3.ToString();
                x++;

                //try
                //{


                //    testQuotation.Name = TxtName.Text;
                //    testQuotation.Qty = UInt32.Parse(TxtQty.Text);
                //    testQuotation.Material_Cost = UInt32.Parse(TxtCost.Text);
                //    testQuotation.Markup = float.Parse(TxtMarkup.Text);
                //    testQuotation.Setup_Cost = UInt32.Parse(TxtSetupCost.Text);
                //    testQuotation.Setup_Hr = float.Parse(TxtSetupHr.Text);
                //    testQuotation.Operation_Cost = UInt32.Parse(TxtOptCost.Text);
                //    testQuotation.Operation_Hr = float.Parse(TxtOptHr.Text);
                //    testQuotation.setTotal();

                //    //TxtTotal.Text = testQuotation.Total.ToString();
                //    //TxtListofMaterials.Text = testQuotation.listMaterials();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}

                return true;
            }

            //TxtListofMaterials.Text = "Hu" + x.ToString() + 5.ToString();
            x++;
            return false;

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Material material = testQuotation.DeleteMaterial(TxtDeleteMaterial.Text);
            Material material = testQuotation.DeleteMaterial(oldName);

            //TxtShowDeletedMaterial.Text = material.Name;
            DisplayTable();

            var sb = new StringBuilder();
            var listOfMaterials = testQuotation.GetMaterials();
            foreach (Material material1 in listOfMaterials)
            {
                sb.AppendLine(material1.Name);
            }

            lockModify = true;

            //TxtShowDeletedMaterial.Text = sb.ToString();

        }

        private void DisplayTable()
        {
            List<Material> materials = new List<Material>(testQuotation.GetMaterials());
            dataGridView1.DataSource = materials;

            dataGridView1.AutoResizeColumns();

            dataGridView1.Columns["SubTotal"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Price_Per_Piece"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Subtotal"].HeaderText = "Sub Total";
            dataGridView1.Columns["Price_Per_Piece"].HeaderText = "Price per Piece";


            dataGridView1.Columns["Material_Cost"].Visible = false;
            dataGridView1.Columns["Setup_Hr"].Visible = false;
            dataGridView1.Columns["Setup_Cost"].Visible = false;
            dataGridView1.Columns["Operation_Cost"].Visible = false;
            dataGridView1.Columns["Operation_Hr"].Visible = false;
            dataGridView1.Columns["Markup"].Visible = false;

            dataGridView1.ClearSelection();
        }

        public string oldName { get; set; }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    //dataGridView1.SelectionMode
                    var selectedMaterial = dataGridView1.SelectedRows[0].DataBoundItem as Material;
                    oldName = selectedMaterial.Name;
                    TxtName.Text = selectedMaterial.Name;
                    TxtCost.Text = selectedMaterial.Material_Cost.ToString();
                    TxtSetupCost.Text = selectedMaterial.Setup_Cost.ToString();
                    TxtSetupHr.Text = selectedMaterial.Setup_Hr.ToString();
                    TxtQty.Text = selectedMaterial.Qty.ToString();
                    TxtOptCost.Text = selectedMaterial.Operation_Cost.ToString();
                    TxtOptHr.Text = selectedMaterial.Operation_Hr.ToString();
                    TxtMarkup.Text = selectedMaterial.Markup.ToString();
                    lockModify = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some error occurred:" + ex.Message + " - " + ex.Source);
                }
            }
                
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joelEngineeringDBDataSet2.JoelProducts' table. You can move, or remove it, as needed.
            this.joelProductsTableAdapter.Fill(this.joelEngineeringDBDataSet2.JoelProducts);
            // TODO: This line of code loads data into the 'joelEngineeringDBDataSet1.JoelProducts' table. You can move, or remove it, as needed.
            //this.joelProductsTableAdapter1.Fill(this.joelEngineeringDBDataSet1.JoelProducts);
            // TODO: This line of code loads data into the 'joelEngineeringDBDataSet.JoelProducts' table. You can move, or remove it, as needed.
            //this.joelProductsTableAdapter.Fill(this.joelEngineeringDBDataSet.JoelProducts);

        }


        /// <summary>
        /// Calculator
        /// </summary>

        private Cylinder currentCylinder = new Cylinder("Untitled", 0, 0, 0, 0, 0);
        private List<Cylinder> cylinderList = new List<Cylinder>();
        private Cylinder cylinderBlank = new Cylinder("New...", 0, 0, 0, 0, 1);


        //private BindingList<Cylinder> cylinderList = new BindingList<Cylinder>();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                TxtDensity.ReadOnly = true;

                if (comboBox1.SelectedIndex == 0)
                {
                    TxtDensity.ReadOnly = false;

                    LblName.Visible = true;
                    TxtRawName.Visible = true;
                    BtnSave.Visible = true;
                }
                else
                {
                    TxtDensity.ReadOnly = true;

                    LblName.Visible = false;
                    TxtRawName.Visible = false;
                    BtnSave.Visible = false;
                }
                

                TxtLength.Text = ((Cylinder)comboBox1.SelectedItem).Length.ToString();
                TxtDiameter.Text = ((Cylinder)comboBox1.SelectedItem).Diameter.ToString();
                TxtDensity.Text = ((Cylinder)comboBox1.SelectedItem).Density.ToString();
                TxtPricePerKilo.Text = string.Format("{0:C2}", ((Cylinder)comboBox1.SelectedItem).Price_Per_Kilo);
                TxtPricePerPiece.Text = string.Format("{0:C2}", ((Cylinder)comboBox1.SelectedItem).Price_Per_Piece);
                TxtQuantityRaw.Text = ((Cylinder)comboBox1.SelectedItem).Qty.ToString();
                TxtTotalRaw.Text = string.Format("{0:C2}", ((Cylinder)comboBox1.SelectedItem).Total);
            }
        }
        
        

        private void TxtLength_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtLength.Text, out double length);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                currentCylinder = ((Cylinder)comboBox1.SelectedItem);
                currentCylinder.Length = length;
                ShowTotalPriceRaw();
            }
            
        }

        private void TxtLength_LostFocus(object sender, EventArgs e)
        {
            TxtLength.Text = string.Format("{0:N6}", ((Cylinder)comboBox1.SelectedItem).Length);
        }

        private void TxtDiameter_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtDiameter.Text, out double diameter);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                currentCylinder = ((Cylinder)comboBox1.SelectedItem);
                currentCylinder.Diameter = diameter;
                ShowTotalPriceRaw();
            }
        }

        private void TxtDiameter_LostFocus(object sender, EventArgs e)
        {
            TxtDiameter.Text = string.Format("{0:N6}", ((Cylinder)comboBox1.SelectedItem).Diameter);
        }

        private void TxtPricePerKilo_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = decimal.TryParse(TxtPricePerKilo.Text, System.Globalization.NumberStyles.Any, CultureInfo.CreateSpecificCulture("en-AU"), out decimal pricePerKilo);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                currentCylinder = ((Cylinder)comboBox1.SelectedItem);
                currentCylinder.Price_Per_Kilo = (double)pricePerKilo;
                ShowTotalPriceRaw();
            }
        }

        private void TxtPricePerKilo_LostFocus(object sender, EventArgs e)
        {
            TxtPricePerKilo.Text = string.Format("{0:C2}", ((Cylinder)comboBox1.SelectedItem).Price_Per_Kilo);
        }
        

        private void TxtQuantityRaw_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = double.TryParse(TxtQuantityRaw.Text, out double qty);

            if (TxtLength.TextLength > 0 && isNumeric)
            {
                currentCylinder = ((Cylinder)comboBox1.SelectedItem);
                currentCylinder.Qty = qty;
                ShowTotalPriceRaw();
            }
        }

        private void TxtDensity_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric = float.TryParse(TxtDensity.Text, out float density);

            if (TxtDensity.TextLength > 0 && isNumeric)
            {
                currentCylinder = ((Cylinder)comboBox1.SelectedItem);
                currentCylinder.Density = density;
                ShowTotalPriceRaw();
            }
        }

        private void TxtDensity_LostFocus(object sender, EventArgs e)
        {
            TxtDensity.Text = string.Format("{0:N}", ((Cylinder)comboBox1.SelectedItem).Density);
        }

        private void ShowTotalPriceRaw()
        {
            currentCylinder.ComputePricePerPiece();
            currentCylinder.ComputeTotalPrice();
            TxtPricePerPiece.Text = string.Format("{0:C2}", ((Cylinder)comboBox1.SelectedItem).Price_Per_Piece);
            TxtTotalRaw.Text = string.Format("{0:C2}", ((Cylinder)comboBox1.SelectedItem).Total);
        }

        private void TxtTotalRaw_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRawName_TextChanged(object sender, EventArgs e)
        {

        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                currentCylinder.Name = TxtRawName.Text;
                cylinderList.Add(currentCylinder);

                //BindingSource bSource = new BindingSource
                //{
                //    DataSource = bindinglist
                //};

                //foreach (Cylinder cylinder in bindinglist)
                //{
                //    cylinder.ComputePricePerPiece();
                //    cylinder.ComputeTotalPrice();
                //}

                //cylinderList.AddRange(cylinders);

                //comboBox1.DisplayMember = "Name";
                //comboBox1.ValueMember = null;

                //comboBox1.DataSource = bSource;

                //comboBox1.Update();
                //comboBox1.Refresh();

                comboBox1.DataSource = null;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = null;

                
                cylinderList.Insert(0, cylinderBlank); //ayusin mo to
                cylinderList.RemoveAt(1);
                comboBox1.DataSource = cylinderList;
                textBox1.Text = cylinderList.Count.ToString();

               
                //ObservableCollection<Cylinder> 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + ": " + ex.Source);
            }
        }

        public SQLQuery sQLQuery;
        List<Material> materialsx;

        private void button1_Click(object sender, EventArgs e)
        {
            //SQLQuery sQLQuery = new SQLQuery();
            sQLQuery = new SQLQuery();
            sQLQuery.Connect();


            //List<Material> materials = new List<Material>(sQLQuery.Products);
            materialsx = new List<Material>(sQLQuery.Products);
            DataGridProducts.DataSource = materialsx;

            DataGridProducts.AutoResizeColumns();

            DataGridProducts.Columns["SubTotal"].DefaultCellStyle.Format = "C2";
            DataGridProducts.Columns["Price_Per_Piece"].DefaultCellStyle.Format = "C2";
            DataGridProducts.Columns["Subtotal"].HeaderText = "Sub Total";
            DataGridProducts.Columns["Price_Per_Piece"].HeaderText = "Price per Piece";


            DataGridProducts.Columns["Material_Cost"].Visible = false;
            DataGridProducts.Columns["Setup_Hr"].Visible = false;
            DataGridProducts.Columns["Setup_Cost"].Visible = false;
            DataGridProducts.Columns["Operation_Cost"].Visible = false;
            DataGridProducts.Columns["Operation_Hr"].Visible = false;
            DataGridProducts.Columns["Markup"].Visible = false;

            DataGridProducts.ClearSelection();

            ComboBoxProducts.DisplayMember = "Name";
            ComboBoxProducts.ValueMember = null;
            ComboBoxProducts.DataSource = materialsx;


            //try
            //{
            //    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            //    {
            //        DataSource = "joelengineering.database.windows.net",
            //        UserID = "tony",
            //        Password = "Jadenonoy_12",
            //        InitialCatalog = "JoelEngineeringDB"
            //    };

            //    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            //    {
            //        Console.WriteLine("\nQuery data example:");
            //        //Console.WriteLine("=========================================\n");

            //        connection.Open();
            //        StringBuilder sb = new StringBuilder();
            //        sb.Append("SELECT * FROM JoelProducts");
            //        //sb.Append("INSERT INTO JoelProducts VALUES ('trylang227', 223, 1, 50, 3, 75, 0.5);");

            //        String sql = sb.ToString();

            //        SqlCommand command = new SqlCommand(sql, connection);
            //        command.ExecuteNonQuery();

            //        textBox2.Text = "yoyoyo";


            //        ComboProducts.DataSource = null;
            //        ComboProducts.DisplayMember = "PRODUCT NAME/WORKS";
            //        ComboProducts.DataSource = joelProductsBindingSource;


            //        Console.WriteLine("hello");


            //        ComboProducts.Refresh();
            //        //ComboProducts.Update();
            //        //using (SqlCommand command = new SqlCommand(sql, connection))
            //        //{
            //        //    using (SqlDataReader reader = command.ExecuteReader())
            //        //    {
            //        //        while (reader.Read())
            //        //        {
            //        //            //Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
            //        //            textBox2.Text = reader.GetInt32(0).ToString() + reader.GetString(1).ToString();
            //        //            break;
            //        //        }
            //        //    }
            //        //}
            //    }
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message + ex.Source);
            //}

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void DisplayProducts()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Material material = new Material
            {
                Name = "sample",
                Material_Cost = 2,
                Setup_Hr = 3,
                Setup_Cost = 4,
                Operation_Hr = 5,
                Operation_Cost = 6,
                Markup = 7,
                Qty = 1
            };

            sQLQuery.AddProduct(material);

            materialsx = new List<Material>(sQLQuery.Products);
            DataGridProducts.DataSource = materialsx;

            DataGridProducts.AutoResizeColumns();

            DataGridProducts.Columns["SubTotal"].DefaultCellStyle.Format = "C2";
            DataGridProducts.Columns["Price_Per_Piece"].DefaultCellStyle.Format = "C2";
            DataGridProducts.Columns["Subtotal"].HeaderText = "Sub Total";
            DataGridProducts.Columns["Price_Per_Piece"].HeaderText = "Price per Piece";


            DataGridProducts.Columns["Material_Cost"].Visible = false;
            DataGridProducts.Columns["Setup_Hr"].Visible = false;
            DataGridProducts.Columns["Setup_Cost"].Visible = false;
            DataGridProducts.Columns["Operation_Cost"].Visible = false;
            DataGridProducts.Columns["Operation_Hr"].Visible = false;
            DataGridProducts.Columns["Markup"].Visible = false;

            DataGridProducts.ClearSelection();

            ComboBoxProducts.DisplayMember = "Name";
            ComboBoxProducts.ValueMember = null;
            ComboBoxProducts.DataSource = materialsx;
        }
    }
}
