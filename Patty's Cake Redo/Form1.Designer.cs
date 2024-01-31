namespace Patty_s_Cake_Redo
{
    partial class homePage
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
            this.topBanner = new System.Windows.Forms.Label();
            this.placeAnOrder = new System.Windows.Forms.RadioButton();
            this.finish = new System.Windows.Forms.RadioButton();
            this.oneTier = new System.Windows.Forms.RadioButton();
            this.twoTier = new System.Windows.Forms.RadioButton();
            this.threeTier = new System.Windows.Forms.RadioButton();
            this.candles = new System.Windows.Forms.CheckBox();
            this.text = new System.Windows.Forms.CheckBox();
            this.designs = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.Customers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tiers = new System.Windows.Forms.GroupBox();
            this.addons = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.Label();
            this.basePrice = new System.Windows.Forms.Label();
            this.custNameInput = new System.Windows.Forms.TextBox();
            this.basePriceInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tiers.SuspendLayout();
            this.addons.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBanner
            // 
            this.topBanner.AutoSize = true;
            this.topBanner.BackColor = System.Drawing.Color.White;
            this.topBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topBanner.Font = new System.Drawing.Font("Curlz MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topBanner.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.topBanner.Location = new System.Drawing.Point(292, 25);
            this.topBanner.Name = "topBanner";
            this.topBanner.Size = new System.Drawing.Size(681, 87);
            this.topBanner.TabIndex = 0;
            this.topBanner.Text = "Welcome To Patty\'s Cakes!";
            // 
            // placeAnOrder
            // 
            this.placeAnOrder.AutoSize = true;
            this.placeAnOrder.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeAnOrder.Location = new System.Drawing.Point(79, 61);
            this.placeAnOrder.Name = "placeAnOrder";
            this.placeAnOrder.Size = new System.Drawing.Size(166, 25);
            this.placeAnOrder.TabIndex = 1;
            this.placeAnOrder.TabStop = true;
            this.placeAnOrder.Text = "Place an Order";
            this.placeAnOrder.UseVisualStyleBackColor = true;
            this.placeAnOrder.CheckedChanged += new System.EventHandler(this.placeAnOrder_CheckedChanged);
            // 
            // finish
            // 
            this.finish.AutoSize = true;
            this.finish.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish.Location = new System.Drawing.Point(79, 132);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(197, 25);
            this.finish.TabIndex = 2;
            this.finish.TabStop = true;
            this.finish.Text = "Finish for the Day";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.CheckedChanged += new System.EventHandler(this.finish_CheckedChanged);
            // 
            // oneTier
            // 
            this.oneTier.AutoSize = true;
            this.oneTier.Enabled = false;
            this.oneTier.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneTier.Location = new System.Drawing.Point(64, 61);
            this.oneTier.Name = "oneTier";
            this.oneTier.Size = new System.Drawing.Size(105, 25);
            this.oneTier.TabIndex = 5;
            this.oneTier.TabStop = true;
            this.oneTier.Text = "One-tier";
            this.oneTier.UseVisualStyleBackColor = true;
            // 
            // twoTier
            // 
            this.twoTier.AutoSize = true;
            this.twoTier.Enabled = false;
            this.twoTier.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoTier.Location = new System.Drawing.Point(64, 113);
            this.twoTier.Name = "twoTier";
            this.twoTier.Size = new System.Drawing.Size(105, 25);
            this.twoTier.TabIndex = 6;
            this.twoTier.TabStop = true;
            this.twoTier.Text = "Two-tier";
            this.twoTier.UseVisualStyleBackColor = true;
            this.twoTier.CheckedChanged += new System.EventHandler(this.twoTier_CheckedChanged);
            // 
            // threeTier
            // 
            this.threeTier.AutoSize = true;
            this.threeTier.Enabled = false;
            this.threeTier.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeTier.Location = new System.Drawing.Point(64, 163);
            this.threeTier.Name = "threeTier";
            this.threeTier.Size = new System.Drawing.Size(120, 25);
            this.threeTier.TabIndex = 8;
            this.threeTier.TabStop = true;
            this.threeTier.Text = "Three-tier";
            this.threeTier.UseVisualStyleBackColor = true;
            this.threeTier.CheckedChanged += new System.EventHandler(this.threeTier_CheckedChanged);
            // 
            // candles
            // 
            this.candles.AutoSize = true;
            this.candles.Enabled = false;
            this.candles.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candles.Location = new System.Drawing.Point(69, 61);
            this.candles.Name = "candles";
            this.candles.Size = new System.Drawing.Size(105, 25);
            this.candles.TabIndex = 9;
            this.candles.Text = "Candles";
            this.candles.UseVisualStyleBackColor = true;
            this.candles.CheckedChanged += new System.EventHandler(this.candles_CheckedChanged);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Enabled = false;
            this.text.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(69, 113);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(69, 25);
            this.text.TabIndex = 10;
            this.text.Text = "Text";
            this.text.UseVisualStyleBackColor = true;
            this.text.CheckedChanged += new System.EventHandler(this.text_CheckedChanged);
            // 
            // designs
            // 
            this.designs.AutoSize = true;
            this.designs.Enabled = false;
            this.designs.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designs.Location = new System.Drawing.Point(69, 164);
            this.designs.Name = "designs";
            this.designs.Size = new System.Drawing.Size(103, 25);
            this.designs.TabIndex = 11;
            this.designs.Text = "Designs";
            this.designs.UseVisualStyleBackColor = true;
            this.designs.CheckedChanged += new System.EventHandler(this.designs_CheckedChanged);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(560, 402);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(131, 36);
            this.submit.TabIndex = 12;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Customers
            // 
            this.Customers.FormattingEnabled = true;
            this.Customers.Location = new System.Drawing.Point(1033, 25);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(201, 82);
            this.Customers.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.placeAnOrder);
            this.groupBox1.Controls.Add(this.finish);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 225);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a menu item:";
            // 
            // tiers
            // 
            this.tiers.Controls.Add(this.oneTier);
            this.tiers.Controls.Add(this.twoTier);
            this.tiers.Controls.Add(this.threeTier);
            this.tiers.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiers.Location = new System.Drawing.Point(652, 178);
            this.tiers.Name = "tiers";
            this.tiers.Size = new System.Drawing.Size(247, 225);
            this.tiers.TabIndex = 12;
            this.tiers.TabStop = false;
            this.tiers.Text = "How many tiers:";
            // 
            // addons
            // 
            this.addons.Controls.Add(this.text);
            this.addons.Controls.Add(this.designs);
            this.addons.Controls.Add(this.candles);
            this.addons.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addons.Location = new System.Drawing.Point(942, 178);
            this.addons.Name = "addons";
            this.addons.Size = new System.Drawing.Size(240, 225);
            this.addons.TabIndex = 13;
            this.addons.TabStop = false;
            this.addons.Text = "Which addons:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(91, 74);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(93, 21);
            this.total.TabIndex = 14;
            this.total.Text = "Total: $0";
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custName.Location = new System.Drawing.Point(354, 178);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(209, 27);
            this.custName.TabIndex = 15;
            this.custName.Text = "Customer name:";
            // 
            // basePrice
            // 
            this.basePrice.AutoSize = true;
            this.basePrice.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basePrice.Location = new System.Drawing.Point(354, 291);
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(143, 27);
            this.basePrice.TabIndex = 16;
            this.basePrice.Text = "Base price:";
            // 
            // custNameInput
            // 
            this.custNameInput.Location = new System.Drawing.Point(359, 226);
            this.custNameInput.Name = "custNameInput";
            this.custNameInput.ReadOnly = true;
            this.custNameInput.Size = new System.Drawing.Size(239, 20);
            this.custNameInput.TabIndex = 3;
            // 
            // basePriceInput
            // 
            this.basePriceInput.Location = new System.Drawing.Point(359, 340);
            this.basePriceInput.Name = "basePriceInput";
            this.basePriceInput.ReadOnly = true;
            this.basePriceInput.Size = new System.Drawing.Size(235, 20);
            this.basePriceInput.TabIndex = 4;
            this.basePriceInput.Text = "0";
            this.basePriceInput.TextChanged += new System.EventHandler(this.basePriceInput_TextChanged);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1246, 463);
            this.Controls.Add(this.basePriceInput);
            this.Controls.Add(this.custNameInput);
            this.Controls.Add(this.basePrice);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.total);
            this.Controls.Add(this.addons);
            this.Controls.Add(this.tiers);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.topBanner);
            this.Controls.Add(this.groupBox1);
            this.Name = "homePage";
            this.Text = "Patty\'s Cakes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tiers.ResumeLayout(false);
            this.tiers.PerformLayout();
            this.addons.ResumeLayout(false);
            this.addons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topBanner;
        private System.Windows.Forms.RadioButton placeAnOrder;
        private System.Windows.Forms.RadioButton finish;
        private System.Windows.Forms.RadioButton oneTier;
        private System.Windows.Forms.RadioButton twoTier;
        private System.Windows.Forms.RadioButton threeTier;
        private System.Windows.Forms.CheckBox candles;
        private System.Windows.Forms.CheckBox text;
        private System.Windows.Forms.CheckBox designs;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ListBox Customers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox tiers;
        private System.Windows.Forms.GroupBox addons;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.Label basePrice;
        private System.Windows.Forms.TextBox custNameInput;
        private System.Windows.Forms.TextBox basePriceInput;
    }
}

