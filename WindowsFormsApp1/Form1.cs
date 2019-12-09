using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Quotation;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Quote testQuotation = new Quote();
        

        private bool lockAdd = false;

        private void btnPushToTest_Click(object sender, EventArgs e)
        {

            Material material = new Material();

            try
            {
                material.Name = TxtName.Text;
                material.Qty = UInt32.Parse(TxtQty.Text);
                material.Material_Cost = UInt32.Parse(TxtCost.Text);
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
                
                if (!lockAdd)
                {
                    testQuotation.AddMaterial(material);
                    lockAdd = true;
                }
                

                testQuotation.setTotal();
                

                TxtTotal.Text = testQuotation.Total.ToString();

                //TxtListofMaterials.Text = testQuotation.listMaterials();
                var sb = new StringBuilder();
                var listOfMaterials = testQuotation.GetMaterials();
                foreach(Material material1 in listOfMaterials)
                {
                    sb.AppendLine(material1.Name);
                }

                TxtListofMaterials.Text = sb.ToString();

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

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void TxtBoxTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void TxtListofMaterials_TextChanged(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Material material = testQuotation.DeleteMaterial(TxtDeleteMaterial.Text);
           
            //TxtShowDeletedMaterial.Text = material.Name;

            var sb = new StringBuilder();
            var listOfMaterials = testQuotation.GetMaterials();
            foreach (Material material1 in listOfMaterials)
            {
                sb.AppendLine(material1.Name);
            }

            TxtShowDeletedMaterial.Text = sb.ToString();

        }
    }
}
