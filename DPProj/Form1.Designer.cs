namespace DPProj
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnSName = new System.Windows.Forms.Button();
            this.cbTea = new System.Windows.Forms.CheckBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblDrinking = new System.Windows.Forms.Label();
            this.cbCoffee = new System.Windows.Forms.CheckBox();
            this.cbColdWater = new System.Windows.Forms.CheckBox();
            this.cbColdCola = new System.Windows.Forms.CheckBox();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.cbSauces = new System.Windows.Forms.CheckBox();
            this.tbOrders = new System.Windows.Forms.TextBox();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.rbRoundBelgianWaffle = new System.Windows.Forms.RadioButton();
            this.rbSquareBelgianWaffle = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgvLaslOrder = new System.Windows.Forms.DataGridView();
            this.lblLastOrder = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.shef = new System.Windows.Forms.Button();
            this.lblPay = new System.Windows.Forms.Label();
            this.tbPhon = new System.Windows.Forms.TextBox();
            this.lblPhon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPn = new System.Windows.Forms.TextBox();
            this.lblWaffle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaslOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOrder.Location = new System.Drawing.Point(792, 457);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(118, 37);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "הזמנה";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // btnSName
            // 
            this.btnSName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSName.Location = new System.Drawing.Point(673, 233);
            this.btnSName.Margin = new System.Windows.Forms.Padding(4);
            this.btnSName.Name = "btnSName";
            this.btnSName.Size = new System.Drawing.Size(77, 28);
            this.btnSName.TabIndex = 1;
            this.btnSName.Text = "חפש";
            this.btnSName.UseVisualStyleBackColor = false;
            this.btnSName.Click += new System.EventHandler(this.BtnSName_Click);
            // 
            // cbTea
            // 
            this.cbTea.AutoSize = true;
            this.cbTea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbTea.Location = new System.Drawing.Point(111, 358);
            this.cbTea.Margin = new System.Windows.Forms.Padding(4);
            this.cbTea.Name = "cbTea";
            this.cbTea.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbTea.Size = new System.Drawing.Size(90, 20);
            this.cbTea.TabIndex = 2;
            this.cbTea.Text = "תה - 8 ש\"ח";
            this.cbTea.UseVisualStyleBackColor = false;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMenu.Location = new System.Drawing.Point(71, 55);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMenu.Size = new System.Drawing.Size(168, 55);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "תפריט:";
            // 
            // lblDrinking
            // 
            this.lblDrinking.AutoSize = true;
            this.lblDrinking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDrinking.Location = new System.Drawing.Point(93, 338);
            this.lblDrinking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrinking.Name = "lblDrinking";
            this.lblDrinking.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDrinking.Size = new System.Drawing.Size(39, 16);
            this.lblDrinking.TabIndex = 7;
            this.lblDrinking.Text = "שתיה:";
            // 
            // cbCoffee
            // 
            this.cbCoffee.AutoSize = true;
            this.cbCoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbCoffee.Location = new System.Drawing.Point(111, 386);
            this.cbCoffee.Margin = new System.Windows.Forms.Padding(4);
            this.cbCoffee.Name = "cbCoffee";
            this.cbCoffee.Size = new System.Drawing.Size(103, 20);
            this.cbCoffee.TabIndex = 8;
            this.cbCoffee.Text = "קפה - 10 ש\"ח";
            this.cbCoffee.UseVisualStyleBackColor = false;
            // 
            // cbColdWater
            // 
            this.cbColdWater.AutoSize = true;
            this.cbColdWater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbColdWater.Location = new System.Drawing.Point(111, 415);
            this.cbColdWater.Margin = new System.Windows.Forms.Padding(4);
            this.cbColdWater.Name = "cbColdWater";
            this.cbColdWater.Size = new System.Drawing.Size(128, 20);
            this.cbColdWater.TabIndex = 9;
            this.cbColdWater.Text = "מים קרים - 11 ש\"ח";
            this.cbColdWater.UseVisualStyleBackColor = false;
            // 
            // cbColdCola
            // 
            this.cbColdCola.AutoSize = true;
            this.cbColdCola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbColdCola.Location = new System.Drawing.Point(111, 443);
            this.cbColdCola.Margin = new System.Windows.Forms.Padding(4);
            this.cbColdCola.Name = "cbColdCola";
            this.cbColdCola.Size = new System.Drawing.Size(131, 20);
            this.cbColdCola.TabIndex = 10;
            this.cbColdCola.Text = "קולה קרה - 12 ש\"ח";
            this.cbColdCola.UseVisualStyleBackColor = false;
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbChocolate.Enabled = false;
            this.cbChocolate.Location = new System.Drawing.Point(111, 275);
            this.cbChocolate.Margin = new System.Windows.Forms.Padding(4);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(116, 20);
            this.cbChocolate.TabIndex = 11;
            this.cbChocolate.Text = "שוקולד - 12 ש\"ח";
            this.cbChocolate.UseVisualStyleBackColor = false;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblToppings.Location = new System.Drawing.Point(89, 256);
            this.lblToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(43, 16);
            this.lblToppings.TabIndex = 12;
            this.lblToppings.Text = "תוספות";
            // 
            // cbSauces
            // 
            this.cbSauces.AutoSize = true;
            this.cbSauces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbSauces.Enabled = false;
            this.cbSauces.Location = new System.Drawing.Point(111, 304);
            this.cbSauces.Margin = new System.Windows.Forms.Padding(4);
            this.cbSauces.Name = "cbSauces";
            this.cbSauces.Size = new System.Drawing.Size(111, 20);
            this.cbSauces.TabIndex = 13;
            this.cbSauces.Text = "רטבים - 8  ש\"ח";
            this.cbSauces.UseVisualStyleBackColor = false;
            // 
            // tbOrders
            // 
            this.tbOrders.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbOrders.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbOrders.ForeColor = System.Drawing.Color.Black;
            this.tbOrders.Location = new System.Drawing.Point(67, 563);
            this.tbOrders.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrders.Multiline = true;
            this.tbOrders.Name = "tbOrders";
            this.tbOrders.Size = new System.Drawing.Size(508, 152);
            this.tbOrders.TabIndex = 14;
            this.tbOrders.Text = "אין הזמנות";
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbOrderNumber.Enabled = false;
            this.tbOrderNumber.Location = new System.Drawing.Point(805, 105);
            this.tbOrderNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.ReadOnly = true;
            this.tbOrderNumber.Size = new System.Drawing.Size(68, 22);
            this.tbOrderNumber.TabIndex = 15;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblOrderNumber.Location = new System.Drawing.Point(727, 112);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(78, 16);
            this.lblOrderNumber.TabIndex = 16;
            this.lblOrderNumber.Text = "מספר הזמנה:";
            // 
            // rbRoundBelgianWaffle
            // 
            this.rbRoundBelgianWaffle.AutoSize = true;
            this.rbRoundBelgianWaffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rbRoundBelgianWaffle.Location = new System.Drawing.Point(96, 198);
            this.rbRoundBelgianWaffle.Margin = new System.Windows.Forms.Padding(4);
            this.rbRoundBelgianWaffle.Name = "rbRoundBelgianWaffle";
            this.rbRoundBelgianWaffle.Size = new System.Drawing.Size(149, 20);
            this.rbRoundBelgianWaffle.TabIndex = 17;
            this.rbRoundBelgianWaffle.TabStop = true;
            this.rbRoundBelgianWaffle.Text = "וופל בלגי עגול - 20 ש\"ח";
            this.rbRoundBelgianWaffle.UseVisualStyleBackColor = false;
            this.rbRoundBelgianWaffle.CheckedChanged += new System.EventHandler(this.RbRoundBelgianWaffle_CheckedChanged);
            // 
            // rbSquareBelgianWaffle
            // 
            this.rbSquareBelgianWaffle.AutoSize = true;
            this.rbSquareBelgianWaffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rbSquareBelgianWaffle.Location = new System.Drawing.Point(96, 226);
            this.rbSquareBelgianWaffle.Margin = new System.Windows.Forms.Padding(4);
            this.rbSquareBelgianWaffle.Name = "rbSquareBelgianWaffle";
            this.rbSquareBelgianWaffle.Size = new System.Drawing.Size(160, 20);
            this.rbSquareBelgianWaffle.TabIndex = 18;
            this.rbSquareBelgianWaffle.TabStop = true;
            this.rbSquareBelgianWaffle.Text = "וופל בלגי מרובע - 23 ש\"ח";
            this.rbSquareBelgianWaffle.UseVisualStyleBackColor = false;
            this.rbSquareBelgianWaffle.CheckedChanged += new System.EventHandler(this.RbSquareBelgianWaffle_CheckedChanged);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbName.Location = new System.Drawing.Point(136, 121);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(116, 22);
            this.tbName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(92, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "שם:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblDate.Location = new System.Drawing.Point(727, 85);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 16);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "תאריך: ";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 728);
            this.splitter1.TabIndex = 22;
            this.splitter1.TabStop = false;
            // 
            // dgvLaslOrder
            // 
            this.dgvLaslOrder.AllowUserToDeleteRows = false;
            this.dgvLaslOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvLaslOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLaslOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaslOrder.Location = new System.Drawing.Point(363, 274);
            this.dgvLaslOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLaslOrder.Name = "dgvLaslOrder";
            this.dgvLaslOrder.ReadOnly = true;
            this.dgvLaslOrder.RowHeadersWidth = 10;
            this.dgvLaslOrder.RowTemplate.Height = 21;
            this.dgvLaslOrder.Size = new System.Drawing.Size(852, 167);
            this.dgvLaslOrder.TabIndex = 23;
            // 
            // lblLastOrder
            // 
            this.lblLastOrder.AutoSize = true;
            this.lblLastOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblLastOrder.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblLastOrder.Location = new System.Drawing.Point(359, 198);
            this.lblLastOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastOrder.Name = "lblLastOrder";
            this.lblLastOrder.Size = new System.Drawing.Size(288, 22);
            this.lblLastOrder.TabIndex = 24;
            this.lblLastOrder.Text = "חיפוש הזמנות קודמות לפי מספר טלפון:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl.Location = new System.Drawing.Point(73, 514);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(259, 46);
            this.lbl.TabIndex = 26;
            this.lbl.Text = "מצב ההזמנות:";
            // 
            // shef
            // 
            this.shef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.shef.Location = new System.Drawing.Point(1055, 53);
            this.shef.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.shef.Name = "shef";
            this.shef.Size = new System.Drawing.Size(160, 48);
            this.shef.TabIndex = 27;
            this.shef.Text = "לחץ כדי שהשף ייצר מוצר במטבח";
            this.shef.UseVisualStyleBackColor = false;
            this.shef.Click += new System.EventHandler(this.Shef_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.BackColor = System.Drawing.Color.Transparent;
            this.lblPay.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPay.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPay.Location = new System.Drawing.Point(583, 514);
            this.lblPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(167, 46);
            this.lblPay.TabIndex = 28;
            this.lblPay.Text = "לתשלום:";
            // 
            // tbPhon
            // 
            this.tbPhon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbPhon.Location = new System.Drawing.Point(156, 154);
            this.tbPhon.Name = "tbPhon";
            this.tbPhon.Size = new System.Drawing.Size(96, 22);
            this.tbPhon.TabIndex = 30;
            this.tbPhon.Leave += new System.EventHandler(this.WriteNum);
            // 
            // lblPhon
            // 
            this.lblPhon.AutoSize = true;
            this.lblPhon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPhon.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lblPhon.Location = new System.Drawing.Point(92, 154);
            this.lblPhon.Name = "lblPhon";
            this.lblPhon.Size = new System.Drawing.Size(53, 22);
            this.lblPhon.TabIndex = 31;
            this.lblPhon.Text = "טלפון:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label2.Location = new System.Drawing.Point(475, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "טלפון:";
            // 
            // tbPn
            // 
            this.tbPn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbPn.Location = new System.Drawing.Point(534, 233);
            this.tbPn.Name = "tbPn";
            this.tbPn.Size = new System.Drawing.Size(113, 22);
            this.tbPn.TabIndex = 32;
            // 
            // lblWaffle
            // 
            this.lblWaffle.AutoSize = true;
            this.lblWaffle.Font = new System.Drawing.Font("Gabriola", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblWaffle.Location = new System.Drawing.Point(415, -20);
            this.lblWaffle.Name = "lblWaffle";
            this.lblWaffle.Size = new System.Drawing.Size(305, 147);
            this.lblWaffle.TabIndex = 34;
            this.lblWaffle.Text = "waffle bar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1245, 728);
            this.Controls.Add(this.lblWaffle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPn);
            this.Controls.Add(this.lblPhon);
            this.Controls.Add(this.tbPhon);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.shef);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblLastOrder);
            this.Controls.Add(this.dgvLaslOrder);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rbSquareBelgianWaffle);
            this.Controls.Add(this.rbRoundBelgianWaffle);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.tbOrderNumber);
            this.Controls.Add(this.tbOrders);
            this.Controls.Add(this.cbSauces);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.cbChocolate);
            this.Controls.Add(this.cbColdCola);
            this.Controls.Add(this.cbColdWater);
            this.Controls.Add(this.cbCoffee);
            this.Controls.Add(this.lblDrinking);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.cbTea);
            this.Controls.Add(this.btnSName);
            this.Controls.Add(this.btnOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaslOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnSName;
        private System.Windows.Forms.CheckBox cbTea;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblDrinking;
        private System.Windows.Forms.CheckBox cbCoffee;
        private System.Windows.Forms.CheckBox cbColdWater;
        private System.Windows.Forms.CheckBox cbColdCola;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.CheckBox cbSauces;
        private System.Windows.Forms.TextBox tbOrders;
        private System.Windows.Forms.TextBox tbOrderNumber;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.RadioButton rbRoundBelgianWaffle;
        private System.Windows.Forms.RadioButton rbSquareBelgianWaffle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dgvLaslOrder;
        private System.Windows.Forms.Label lblLastOrder;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button shef;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox tbPhon;
        private System.Windows.Forms.Label lblPhon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPn;
        private System.Windows.Forms.Label lblWaffle;
    }
}

