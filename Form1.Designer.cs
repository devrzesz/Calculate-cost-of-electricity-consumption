namespace Cost_of_electricity_consumption
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateEnergyConsumption_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.areaOfHome = new System.Windows.Forms.TextBox();
            this.demandForHeatingPower = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tarrifListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // calculateEnergyConsumption_Button
            // 
            this.calculateEnergyConsumption_Button.Location = new System.Drawing.Point(321, 168);
            this.calculateEnergyConsumption_Button.Name = "calculateEnergyConsumption_Button";
            this.calculateEnergyConsumption_Button.Size = new System.Drawing.Size(99, 23);
            this.calculateEnergyConsumption_Button.TabIndex = 0;
            this.calculateEnergyConsumption_Button.Text = "Oblicz Zuzycie";
            this.calculateEnergyConsumption_Button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metraz potrzebny do ogrzania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Zapotrzebowanie na moc grzewczą";
            // 
            // areaOfHome
            // 
            this.areaOfHome.Location = new System.Drawing.Point(199, 26);
            this.areaOfHome.Name = "areaOfHome";
            this.areaOfHome.Size = new System.Drawing.Size(100, 20);
            this.areaOfHome.TabIndex = 3;
            this.areaOfHome.Text = "m2";
            // 
            // demandForHeatingPower
            // 
            this.demandForHeatingPower.Location = new System.Drawing.Point(196, 78);
            this.demandForHeatingPower.Name = "demandForHeatingPower";
            this.demandForHeatingPower.Size = new System.Drawing.Size(100, 20);
            this.demandForHeatingPower.TabIndex = 4;
            this.demandForHeatingPower.Text = "m2/W";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wybierz Taryfe";
            // 
            // tarrifListBox
            // 
            this.tarrifListBox.FormattingEnabled = true;
            this.tarrifListBox.Items.AddRange(new object[] {
            "G11",
            "G12",
            "G12w",
            "G13"});
            this.tarrifListBox.Location = new System.Drawing.Point(506, 26);
            this.tarrifListBox.Name = "tarrifListBox";
            this.tarrifListBox.Size = new System.Drawing.Size(119, 56);
            this.tarrifListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 316);
            this.Controls.Add(this.tarrifListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.demandForHeatingPower);
            this.Controls.Add(this.areaOfHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateEnergyConsumption_Button);
            this.Name = "Form1";
            this.Text = "Koszty zuzycia energii na potrzeby ogrzewania elektrycznego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateEnergyConsumption_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox areaOfHome;
        private System.Windows.Forms.TextBox demandForHeatingPower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox tarrifListBox;
    }
}

