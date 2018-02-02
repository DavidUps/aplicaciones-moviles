namespace herenciasVisual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.order_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.brand_TextBox = new System.Windows.Forms.TextBox();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ram_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.port_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.speed_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.batery_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resolution_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.memori_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addOrder_Button = new System.Windows.Forms.Button();
            this.deleteOrder_Button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ramOperation_TextBox = new System.Windows.Forms.TextBox();
            this.operation_ComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.moreRam_Button = new System.Windows.Forms.Button();
            this.lessRam_Button = new System.Windows.Forms.Button();
            this.lessPrice_Button = new System.Windows.Forms.Button();
            this.morePrice_Button = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.priceOperation_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.operativeSistem_TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.operativeSistem_TextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.deleteOrder_Button);
            this.groupBox1.Controls.Add(this.addOrder_Button);
            this.groupBox1.Controls.Add(this.memori_TextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.batery_TextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.resolution_TextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.port_TextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.speed_TextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.price_TextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ram_TextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.name_TextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.brand_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.order_ComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // order_ComboBox
            // 
            this.order_ComboBox.FormattingEnabled = true;
            this.order_ComboBox.Items.AddRange(new object[] {
            "Ordenador",
            "Tablet",
            "Movil"});
            this.order_ComboBox.Location = new System.Drawing.Point(7, 20);
            this.order_ComboBox.Name = "order_ComboBox";
            this.order_ComboBox.Size = new System.Drawing.Size(187, 21);
            this.order_ComboBox.TabIndex = 0;
            this.order_ComboBox.SelectedIndexChanged += new System.EventHandler(this.order_ComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // brand_TextBox
            // 
            this.brand_TextBox.Location = new System.Drawing.Point(94, 52);
            this.brand_TextBox.Name = "brand_TextBox";
            this.brand_TextBox.Size = new System.Drawing.Size(100, 20);
            this.brand_TextBox.TabIndex = 2;
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(94, 78);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(100, 20);
            this.name_TextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // price_TextBox
            // 
            this.price_TextBox.Location = new System.Drawing.Point(94, 130);
            this.price_TextBox.Name = "price_TextBox";
            this.price_TextBox.Size = new System.Drawing.Size(100, 20);
            this.price_TextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // ram_TextBox
            // 
            this.ram_TextBox.Location = new System.Drawing.Point(94, 104);
            this.ram_TextBox.Name = "ram_TextBox";
            this.ram_TextBox.Size = new System.Drawing.Size(100, 20);
            this.ram_TextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ram";
            // 
            // port_TextBox
            // 
            this.port_TextBox.Location = new System.Drawing.Point(94, 182);
            this.port_TextBox.Name = "port_TextBox";
            this.port_TextBox.Size = new System.Drawing.Size(100, 20);
            this.port_TextBox.TabIndex = 12;
            this.port_TextBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Puertos";
            // 
            // speed_TextBox
            // 
            this.speed_TextBox.Location = new System.Drawing.Point(94, 156);
            this.speed_TextBox.Name = "speed_TextBox";
            this.speed_TextBox.Size = new System.Drawing.Size(100, 20);
            this.speed_TextBox.TabIndex = 10;
            this.speed_TextBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Velocidad";
            // 
            // batery_TextBox
            // 
            this.batery_TextBox.Location = new System.Drawing.Point(94, 234);
            this.batery_TextBox.Name = "batery_TextBox";
            this.batery_TextBox.Size = new System.Drawing.Size(100, 20);
            this.batery_TextBox.TabIndex = 16;
            this.batery_TextBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bateria";
            // 
            // resolution_TextBox
            // 
            this.resolution_TextBox.Location = new System.Drawing.Point(94, 208);
            this.resolution_TextBox.Name = "resolution_TextBox";
            this.resolution_TextBox.Size = new System.Drawing.Size(100, 20);
            this.resolution_TextBox.TabIndex = 14;
            this.resolution_TextBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Resolucion";
            // 
            // memori_TextBox
            // 
            this.memori_TextBox.Location = new System.Drawing.Point(94, 260);
            this.memori_TextBox.Name = "memori_TextBox";
            this.memori_TextBox.Size = new System.Drawing.Size(100, 20);
            this.memori_TextBox.TabIndex = 18;
            this.memori_TextBox.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Almacenamiento";
            // 
            // addOrder_Button
            // 
            this.addOrder_Button.Location = new System.Drawing.Point(7, 324);
            this.addOrder_Button.Name = "addOrder_Button";
            this.addOrder_Button.Size = new System.Drawing.Size(96, 23);
            this.addOrder_Button.TabIndex = 19;
            this.addOrder_Button.Text = "Añadir";
            this.addOrder_Button.UseVisualStyleBackColor = true;
            this.addOrder_Button.Click += new System.EventHandler(this.addOrder_Button_Click);
            // 
            // deleteOrder_Button
            // 
            this.deleteOrder_Button.Location = new System.Drawing.Point(109, 324);
            this.deleteOrder_Button.Name = "deleteOrder_Button";
            this.deleteOrder_Button.Size = new System.Drawing.Size(83, 23);
            this.deleteOrder_Button.TabIndex = 20;
            this.deleteOrder_Button.Text = "Eliminar";
            this.deleteOrder_Button.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lessPrice_Button);
            this.groupBox3.Controls.Add(this.morePrice_Button);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.priceOperation_TextBox);
            this.groupBox3.Controls.Add(this.lessRam_Button);
            this.groupBox3.Controls.Add(this.moreRam_Button);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.ramOperation_TextBox);
            this.groupBox3.Controls.Add(this.operation_ComboBox);
            this.groupBox3.Location = new System.Drawing.Point(229, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 120);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox2";
            // 
            // ramOperation_TextBox
            // 
            this.ramOperation_TextBox.Location = new System.Drawing.Point(53, 52);
            this.ramOperation_TextBox.Name = "ramOperation_TextBox";
            this.ramOperation_TextBox.Size = new System.Drawing.Size(69, 20);
            this.ramOperation_TextBox.TabIndex = 18;
            // 
            // operation_ComboBox
            // 
            this.operation_ComboBox.FormattingEnabled = true;
            this.operation_ComboBox.Location = new System.Drawing.Point(7, 20);
            this.operation_ComboBox.Name = "operation_ComboBox";
            this.operation_ComboBox.Size = new System.Drawing.Size(187, 21);
            this.operation_ComboBox.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Ram";
            // 
            // moreRam_Button
            // 
            this.moreRam_Button.Location = new System.Drawing.Point(128, 52);
            this.moreRam_Button.Name = "moreRam_Button";
            this.moreRam_Button.Size = new System.Drawing.Size(27, 23);
            this.moreRam_Button.TabIndex = 22;
            this.moreRam_Button.Text = "+";
            this.moreRam_Button.UseVisualStyleBackColor = true;
            // 
            // lessRam_Button
            // 
            this.lessRam_Button.Location = new System.Drawing.Point(161, 52);
            this.lessRam_Button.Name = "lessRam_Button";
            this.lessRam_Button.Size = new System.Drawing.Size(27, 23);
            this.lessRam_Button.TabIndex = 23;
            this.lessRam_Button.Text = "-";
            this.lessRam_Button.UseVisualStyleBackColor = true;
            // 
            // lessPrice_Button
            // 
            this.lessPrice_Button.Location = new System.Drawing.Point(161, 78);
            this.lessPrice_Button.Name = "lessPrice_Button";
            this.lessPrice_Button.Size = new System.Drawing.Size(27, 23);
            this.lessPrice_Button.TabIndex = 27;
            this.lessPrice_Button.Text = "-";
            this.lessPrice_Button.UseVisualStyleBackColor = true;
            // 
            // morePrice_Button
            // 
            this.morePrice_Button.Location = new System.Drawing.Point(128, 78);
            this.morePrice_Button.Name = "morePrice_Button";
            this.morePrice_Button.Size = new System.Drawing.Size(27, 23);
            this.morePrice_Button.TabIndex = 26;
            this.morePrice_Button.Text = "+";
            this.morePrice_Button.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Precio";
            // 
            // priceOperation_TextBox
            // 
            this.priceOperation_TextBox.Location = new System.Drawing.Point(53, 78);
            this.priceOperation_TextBox.Name = "priceOperation_TextBox";
            this.priceOperation_TextBox.Size = new System.Drawing.Size(69, 20);
            this.priceOperation_TextBox.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(229, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 202);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 173);
            this.listBox1.TabIndex = 0;
            // 
            // operativeSistem_TextBox
            // 
            this.operativeSistem_TextBox.Location = new System.Drawing.Point(94, 286);
            this.operativeSistem_TextBox.Name = "operativeSistem_TextBox";
            this.operativeSistem_TextBox.Size = new System.Drawing.Size(100, 20);
            this.operativeSistem_TextBox.TabIndex = 22;
            this.operativeSistem_TextBox.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "S.O.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteOrder_Button;
        private System.Windows.Forms.Button addOrder_Button;
        private System.Windows.Forms.TextBox memori_TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox batery_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resolution_TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox port_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox speed_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ram_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brand_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox order_ComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button lessPrice_Button;
        private System.Windows.Forms.Button morePrice_Button;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox priceOperation_TextBox;
        private System.Windows.Forms.Button lessRam_Button;
        private System.Windows.Forms.Button moreRam_Button;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ramOperation_TextBox;
        private System.Windows.Forms.ComboBox operation_ComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox operativeSistem_TextBox;
        private System.Windows.Forms.Label label10;
    }
}

