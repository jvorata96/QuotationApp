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
            this.TxtListofMaterials = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TxtDeleteMaterial = new System.Windows.Forms.TextBox();
            this.TxtShowDeletedMaterial = new System.Windows.Forms.TextBox();
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
            this.BtnPushToTest.Location = new System.Drawing.Point(120, 168);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cost";
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
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.TxtTotal.Location = new System.Drawing.Point(411, 366);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(228, 20);
            this.TxtTotal.TabIndex = 21;
            this.TxtTotal.TextChanged += new System.EventHandler(this.TxtBoxTotal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(507, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(120, 215);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(157, 29);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add More Materials";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtListofMaterials
            // 
            this.TxtListofMaterials.Location = new System.Drawing.Point(354, 23);
            this.TxtListofMaterials.Multiline = true;
            this.TxtListofMaterials.Name = "TxtListofMaterials";
            this.TxtListofMaterials.ReadOnly = true;
            this.TxtListofMaterials.Size = new System.Drawing.Size(424, 158);
            this.TxtListofMaterials.TabIndex = 24;
            this.TxtListofMaterials.TextChanged += new System.EventHandler(this.TxtListofMaterials_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 29);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Material";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TxtDeleteMaterial
            // 
            this.TxtDeleteMaterial.Location = new System.Drawing.Point(155, 295);
            this.TxtDeleteMaterial.Name = "TxtDeleteMaterial";
            this.TxtDeleteMaterial.Size = new System.Drawing.Size(89, 20);
            this.TxtDeleteMaterial.TabIndex = 26;
            // 
            // TxtShowDeletedMaterial
            // 
            this.TxtShowDeletedMaterial.Location = new System.Drawing.Point(122, 321);
            this.TxtShowDeletedMaterial.Multiline = true;
            this.TxtShowDeletedMaterial.Name = "TxtShowDeletedMaterial";
            this.TxtShowDeletedMaterial.ReadOnly = true;
            this.TxtShowDeletedMaterial.Size = new System.Drawing.Size(155, 49);
            this.TxtShowDeletedMaterial.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 619);
            this.Controls.Add(this.TxtShowDeletedMaterial);
            this.Controls.Add(this.TxtDeleteMaterial);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.TxtListofMaterials);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox TxtListofMaterials;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox TxtDeleteMaterial;
        private System.Windows.Forms.TextBox TxtShowDeletedMaterial;
    }
}

