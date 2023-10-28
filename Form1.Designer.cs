namespace New_World_Armor_Weight_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CBHelm = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            CBChest = new ComboBox();
            label3 = new Label();
            CBGloves = new ComboBox();
            label4 = new Label();
            CBPants = new ComboBox();
            label5 = new Label();
            CBBoots = new ComboBox();
            label6 = new Label();
            CBShield = new ComboBox();
            lblClass = new Label();
            lblWeight = new Label();
            LblHelmWeight = new Label();
            LblChestWeight = new Label();
            LblGloveWeight = new Label();
            LblPantsWeight = new Label();
            LblBootsWeight = new Label();
            LblShieldWeight = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // CBHelm
            // 
            CBHelm.FormattingEnabled = true;
            CBHelm.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "N/A" });
            CBHelm.Location = new Point(40, 29);
            CBHelm.Name = "CBHelm";
            CBHelm.Size = new Size(121, 23);
            CBHelm.TabIndex = 0;
            CBHelm.Text = "Light";
            CBHelm.SelectedIndexChanged += CB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 11);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Helmet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 56);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "Chest";
            // 
            // CBChest
            // 
            CBChest.FormattingEnabled = true;
            CBChest.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "N/A" });
            CBChest.Location = new Point(40, 74);
            CBChest.Name = "CBChest";
            CBChest.Size = new Size(121, 23);
            CBChest.TabIndex = 2;
            CBChest.Text = "Light";
            CBChest.SelectedIndexChanged += CB_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 100);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Gloves";
            // 
            // CBGloves
            // 
            CBGloves.FormattingEnabled = true;
            CBGloves.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "N/A" });
            CBGloves.Location = new Point(40, 118);
            CBGloves.Name = "CBGloves";
            CBGloves.Size = new Size(121, 23);
            CBGloves.TabIndex = 4;
            CBGloves.Text = "Light";
            CBGloves.SelectedIndexChanged += CB_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 145);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Pants";
            // 
            // CBPants
            // 
            CBPants.FormattingEnabled = true;
            CBPants.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "N/A" });
            CBPants.Location = new Point(40, 163);
            CBPants.Name = "CBPants";
            CBPants.Size = new Size(121, 23);
            CBPants.TabIndex = 6;
            CBPants.Text = "Light";
            CBPants.SelectedIndexChanged += CB_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 191);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 9;
            label5.Text = "Boots";
            // 
            // CBBoots
            // 
            CBBoots.FormattingEnabled = true;
            CBBoots.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "N/A" });
            CBBoots.Location = new Point(40, 209);
            CBBoots.Name = "CBBoots";
            CBBoots.Size = new Size(121, 23);
            CBBoots.TabIndex = 8;
            CBBoots.Text = "Light";
            CBBoots.SelectedIndexChanged += CB_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 233);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 11;
            label6.Text = "Shield";
            // 
            // CBShield
            // 
            CBShield.FormattingEnabled = true;
            CBShield.Items.AddRange(new object[] { "Light", "Medium", "Heavy", "N/A" });
            CBShield.Location = new Point(40, 251);
            CBShield.Name = "CBShield";
            CBShield.Size = new Size(121, 23);
            CBShield.TabIndex = 10;
            CBShield.Text = "Light";
            CBShield.SelectedIndexChanged += CB_SelectedIndexChanged;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(40, 310);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(108, 15);
            lblClass.TabIndex = 12;
            lblClass.Text = "Weight Class: Light";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(40, 325);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(100, 15);
            lblWeight.TabIndex = 13;
            lblWeight.Text = "Total Weight: 12.7";
            // 
            // LblHelmWeight
            // 
            LblHelmWeight.AutoSize = true;
            LblHelmWeight.Location = new Point(167, 32);
            LblHelmWeight.Name = "LblHelmWeight";
            LblHelmWeight.Size = new Size(22, 15);
            LblHelmWeight.TabIndex = 14;
            LblHelmWeight.Text = "1.5";
            // 
            // LblChestWeight
            // 
            LblChestWeight.AutoSize = true;
            LblChestWeight.Location = new Point(167, 77);
            LblChestWeight.Name = "LblChestWeight";
            LblChestWeight.Size = new Size(22, 15);
            LblChestWeight.TabIndex = 15;
            LblChestWeight.Text = "3.5";
            // 
            // LblGloveWeight
            // 
            LblGloveWeight.AutoSize = true;
            LblGloveWeight.Location = new Point(167, 121);
            LblGloveWeight.Name = "LblGloveWeight";
            LblGloveWeight.Size = new Size(22, 15);
            LblGloveWeight.TabIndex = 16;
            LblGloveWeight.Text = "1.5";
            // 
            // LblPantsWeight
            // 
            LblPantsWeight.AutoSize = true;
            LblPantsWeight.Location = new Point(167, 166);
            LblPantsWeight.Name = "LblPantsWeight";
            LblPantsWeight.Size = new Size(13, 15);
            LblPantsWeight.TabIndex = 17;
            LblPantsWeight.Text = "2";
            // 
            // LblBootsWeight
            // 
            LblBootsWeight.AutoSize = true;
            LblBootsWeight.Location = new Point(167, 212);
            LblBootsWeight.Name = "LblBootsWeight";
            LblBootsWeight.Size = new Size(22, 15);
            LblBootsWeight.TabIndex = 18;
            LblBootsWeight.Text = "1.5";
            // 
            // LblShieldWeight
            // 
            LblShieldWeight.AutoSize = true;
            LblShieldWeight.Location = new Point(167, 254);
            LblShieldWeight.Name = "LblShieldWeight";
            LblShieldWeight.Size = new Size(22, 15);
            LblShieldWeight.TabIndex = 19;
            LblShieldWeight.Text = "2.7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 295);
            label7.Name = "label7";
            label7.Size = new Size(153, 15);
            label7.TabIndex = 20;
            label7.Text = "Light = <13, Medium = <23";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 355);
            Controls.Add(label7);
            Controls.Add(LblShieldWeight);
            Controls.Add(LblBootsWeight);
            Controls.Add(LblPantsWeight);
            Controls.Add(LblGloveWeight);
            Controls.Add(LblChestWeight);
            Controls.Add(LblHelmWeight);
            Controls.Add(lblWeight);
            Controls.Add(lblClass);
            Controls.Add(label6);
            Controls.Add(CBShield);
            Controls.Add(label5);
            Controls.Add(CBBoots);
            Controls.Add(label4);
            Controls.Add(CBPants);
            Controls.Add(label3);
            Controls.Add(CBGloves);
            Controls.Add(label2);
            Controls.Add(CBChest);
            Controls.Add(label1);
            Controls.Add(CBHelm);
            Name = "Form1";
            Text = "NW Weight Calc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBHelm;
        private Label label1;
        private Label label2;
        private ComboBox CBChest;
        private Label label3;
        private ComboBox CBGloves;
        private Label label4;
        private ComboBox CBPants;
        private Label label5;
        private ComboBox CBBoots;
        private Label label6;
        private ComboBox CBShield;
        private Label lblClass;
        private Label lblWeight;
        private Label LblHelmWeight;
        private Label LblChestWeight;
        private Label LblGloveWeight;
        private Label LblPantsWeight;
        private Label LblBootsWeight;
        private Label LblShieldWeight;
        private Label label7;
    }
}