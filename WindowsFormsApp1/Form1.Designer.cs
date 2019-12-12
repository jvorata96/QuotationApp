namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnPushToTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCost = new System.Windows.Forms.TextBox();
            this.TxtSetupCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSetupHr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtOptCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtOptHr = new System.Windows.Forms.TextBox();
            this.TxtMarkup = new System.Windows.Forms.TextBox();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtLength = new System.Windows.Forms.TextBox();
            this.TxtDiameter = new System.Windows.Forms.TextBox();
            this.TxtDensity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtPricePerPiece = new System.Windows.Forms.TextBox();
            this.TxtPricePerKilo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtQuantityRaw = new System.Windows.Forms.TextBox();
            this.TxtTotalRaw = new System.Windows.Forms.TextBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtRawName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(95, 23);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(228, 20);
            this.TxtName.TabIndex = 0;
            this.TxtName.Text = "Enter Material Name";
            this.TxtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // BtnPushToTest
            // 
            this.BtnPushToTest.Location = new System.Drawing.Point(338, 93);
            this.BtnPushToTest.Name = "BtnPushToTest";
            this.BtnPushToTest.Size = new System.Drawing.Size(157, 29);
            this.BtnPushToTest.TabIndex = 8;
            this.BtnPushToTest.Text = "Calculate";
            this.BtnPushToTest.UseVisualStyleBackColor = true;
            this.BtnPushToTest.Click += new System.EventHandler(this.btnPushToTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // TxtCost
            // 
            this.TxtCost.Location = new System.Drawing.Point(95, 75);
            this.TxtCost.Name = "TxtCost";
            this.TxtCost.Size = new System.Drawing.Size(89, 20);
            this.TxtCost.TabIndex = 2;
            this.TxtCost.TextChanged += new System.EventHandler(this.TxtCost_TextChanged);
            // 
            // TxtSetupCost
            // 
            this.TxtSetupCost.Location = new System.Drawing.Point(95, 101);
            this.TxtSetupCost.Name = "TxtSetupCost";
            this.TxtSetupCost.Size = new System.Drawing.Size(89, 20);
            this.TxtSetupCost.TabIndex = 3;
            this.TxtSetupCost.TextChanged += new System.EventHandler(this.TxtSetupCost_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Markup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Operation $/Hr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Setup $/Hr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Material Price";
            // 
            // TxtSetupHr
            // 
            this.TxtSetupHr.Location = new System.Drawing.Point(272, 101);
            this.TxtSetupHr.Name = "TxtSetupHr";
            this.TxtSetupHr.Size = new System.Drawing.Size(51, 20);
            this.TxtSetupHr.TabIndex = 4;
            this.TxtSetupHr.TextChanged += new System.EventHandler(this.TxtSetupHr_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Setup Hr";
            // 
            // TxtOptCost
            // 
            this.TxtOptCost.Location = new System.Drawing.Point(95, 127);
            this.TxtOptCost.Name = "TxtOptCost";
            this.TxtOptCost.Size = new System.Drawing.Size(89, 20);
            this.TxtOptCost.TabIndex = 5;
            this.TxtOptCost.TextChanged += new System.EventHandler(this.TxtOptCost_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Operation Hr";
            // 
            // TxtOptHr
            // 
            this.TxtOptHr.Location = new System.Drawing.Point(272, 127);
            this.TxtOptHr.Name = "TxtOptHr";
            this.TxtOptHr.Size = new System.Drawing.Size(51, 20);
            this.TxtOptHr.TabIndex = 6;
            this.TxtOptHr.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // TxtMarkup
            // 
            this.TxtMarkup.Location = new System.Drawing.Point(272, 75);
            this.TxtMarkup.Name = "TxtMarkup";
            this.TxtMarkup.Size = new System.Drawing.Size(51, 20);
            this.TxtMarkup.TabIndex = 7;
            this.TxtMarkup.TextChanged += new System.EventHandler(this.TxtMarkup_TextChanged);
            // 
            // TxtQty
            // 
            this.TxtQty.Location = new System.Drawing.Point(95, 49);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(89, 20);
            this.TxtQty.TabIndex = 1;
            this.TxtQty.Text = "1";
            this.TxtQty.TextChanged += new System.EventHandler(this.TxtQty_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quantity";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(338, 128);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(157, 20);
            this.TxtTotal.TabIndex = 21;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(338, 23);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(157, 29);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add More Materials";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(483, 347);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(338, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 29);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Material";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Raw Material Calculator";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(530, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtLength
            // 
            this.TxtLength.Location = new System.Drawing.Point(639, 101);
            this.TxtLength.Name = "TxtLength";
            this.TxtLength.Size = new System.Drawing.Size(89, 20);
            this.TxtLength.TabIndex = 32;
            this.TxtLength.TextChanged += new System.EventHandler(this.TxtLength_TextChanged);
            this.TxtLength.LostFocus += new System.EventHandler(this.TxtLength_LostFocus);
            // 
            // TxtDiameter
            // 
            this.TxtDiameter.Location = new System.Drawing.Point(530, 102);
            this.TxtDiameter.Name = "TxtDiameter";
            this.TxtDiameter.Size = new System.Drawing.Size(89, 20);
            this.TxtDiameter.TabIndex = 31;
            this.TxtDiameter.TextChanged += new System.EventHandler(this.TxtDiameter_TextChanged);
            this.TxtDiameter.LostFocus += new System.EventHandler(this.TxtDiameter_LostFocus);
            // 
            // TxtDensity
            // 
            this.TxtDensity.Location = new System.Drawing.Point(530, 151);
            this.TxtDensity.Name = "TxtDensity";
            this.TxtDensity.ReadOnly = true;
            this.TxtDensity.Size = new System.Drawing.Size(89, 20);
            this.TxtDensity.TabIndex = 33;
            this.TxtDensity.TextChanged += new System.EventHandler(this.TxtDensity_TextChanged);
            this.TxtDensity.LostFocus += new System.EventHandler(this.TxtDensity_LostFocus);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(642, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Length";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(533, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Diameter";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(533, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Density";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(642, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Price / Piece";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(642, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Price / Kilo";
            // 
            // TxtPricePerPiece
            // 
            this.TxtPricePerPiece.Location = new System.Drawing.Point(639, 203);
            this.TxtPricePerPiece.Name = "TxtPricePerPiece";
            this.TxtPricePerPiece.ReadOnly = true;
            this.TxtPricePerPiece.Size = new System.Drawing.Size(89, 20);
            this.TxtPricePerPiece.TabIndex = 38;
            // 
            // TxtPricePerKilo
            // 
            this.TxtPricePerKilo.Location = new System.Drawing.Point(639, 151);
            this.TxtPricePerKilo.Name = "TxtPricePerKilo";
            this.TxtPricePerKilo.Size = new System.Drawing.Size(89, 20);
            this.TxtPricePerKilo.TabIndex = 37;
            this.TxtPricePerKilo.TextChanged += new System.EventHandler(this.TxtPricePerKilo_TextChanged);
            this.TxtPricePerKilo.LostFocus += new System.EventHandler(this.TxtPricePerKilo_LostFocus);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(542, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(533, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Quantity";
            // 
            // TxtQuantityRaw
            // 
            this.TxtQuantityRaw.Location = new System.Drawing.Point(530, 202);
            this.TxtQuantityRaw.Name = "TxtQuantityRaw";
            this.TxtQuantityRaw.Size = new System.Drawing.Size(89, 20);
            this.TxtQuantityRaw.TabIndex = 41;
            this.TxtQuantityRaw.TextChanged += new System.EventHandler(this.TxtQuantityRaw_TextChanged);
            // 
            // TxtTotalRaw
            // 
            this.TxtTotalRaw.Location = new System.Drawing.Point(530, 240);
            this.TxtTotalRaw.Name = "TxtTotalRaw";
            this.TxtTotalRaw.ReadOnly = true;
            this.TxtTotalRaw.Size = new System.Drawing.Size(198, 20);
            this.TxtTotalRaw.TabIndex = 45;
            this.TxtTotalRaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTotalRaw.TextChanged += new System.EventHandler(this.TxtTotalRaw_TextChanged);
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(Quotation.Material);
            // 
            // TxtRawName
            // 
            this.TxtRawName.Location = new System.Drawing.Point(571, 282);
            this.TxtRawName.Name = "TxtRawName";
            this.TxtRawName.Size = new System.Drawing.Size(157, 20);
            this.TxtRawName.TabIndex = 46;
            this.TxtRawName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtRawName.Visible = false;
            this.TxtRawName.TextChanged += new System.EventHandler(this.TxtRawName_TextChanged);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(527, 285);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 47;
            this.LblName.Text = "Name";
            this.LblName.Visible = false;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(571, 318);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(157, 29);
            this.BtnSave.TabIndex = 49;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Visible = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(594, 369);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1267, 536);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtRawName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtQuantityRaw);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TxtPricePerPiece);
            this.Controls.Add(this.TxtPricePerKilo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtDensity);
            this.Controls.Add(this.TxtDiameter);
            this.Controls.Add(this.TxtLength);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.TxtMarkup);
            this.Controls.Add(this.TxtOptHr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtOptCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSetupHr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSetupCost);
            this.Controls.Add(this.TxtCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPushToTest);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtTotalRaw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnPushToTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCost;
        private System.Windows.Forms.TextBox TxtSetupCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSetupHr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtOptCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtOptHr;
        private System.Windows.Forms.TextBox TxtMarkup;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.TextBox TxtLength;
        private System.Windows.Forms.TextBox TxtDiameter;
        private System.Windows.Forms.TextBox TxtDensity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtPricePerPiece;
        private System.Windows.Forms.TextBox TxtPricePerKilo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtQuantityRaw;
        private System.Windows.Forms.TextBox TxtTotalRaw;
        private System.Windows.Forms.TextBox TxtRawName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox textBox1;
    }
}

