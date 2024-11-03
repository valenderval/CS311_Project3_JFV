namespace CS311_Project3_JFV
{
    partial class FrmMain
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
            cboSize = new ComboBox();
            grbPizza = new GroupBox();
            label1 = new Label();
            grbCrust = new GroupBox();
            rdoRegular = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            ckbMushroom = new CheckBox();
            ckbExtraCheese = new CheckBox();
            ckbJalepeno = new CheckBox();
            ckbBananaPeppers = new CheckBox();
            ckbGreenOlives = new CheckBox();
            ckbBlackOlives = new CheckBox();
            ckbGreenPepper = new CheckBox();
            ckbOnion = new CheckBox();
            ckbSpicyItalianSausage = new CheckBox();
            ckbCanadianBacon = new CheckBox();
            ckbSausage = new CheckBox();
            ckbPepperoni = new CheckBox();
            pictPizza = new PictureBox();
            lblValsPizzaria = new Label();
            rtfOrderSummary = new RichTextBox();
            lblSummary = new Label();
            txtSubTotal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            label2 = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            grbPizza.SuspendLayout();
            grbCrust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictPizza).BeginInit();
            SuspendLayout();
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboSize.Location = new Point(6, 26);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(151, 28);
            cboSize.TabIndex = 0;
            cboSize.Text = "Select Size";
            cboSize.SelectedIndexChanged += cboSize_SelectedIndexChanged;
            // 
            // grbPizza
            // 
            grbPizza.Controls.Add(label1);
            grbPizza.Controls.Add(grbCrust);
            grbPizza.Controls.Add(ckbMushroom);
            grbPizza.Controls.Add(ckbExtraCheese);
            grbPizza.Controls.Add(ckbJalepeno);
            grbPizza.Controls.Add(ckbBananaPeppers);
            grbPizza.Controls.Add(ckbGreenOlives);
            grbPizza.Controls.Add(ckbBlackOlives);
            grbPizza.Controls.Add(ckbGreenPepper);
            grbPizza.Controls.Add(ckbOnion);
            grbPizza.Controls.Add(ckbSpicyItalianSausage);
            grbPizza.Controls.Add(ckbCanadianBacon);
            grbPizza.Controls.Add(ckbSausage);
            grbPizza.Controls.Add(ckbPepperoni);
            grbPizza.Controls.Add(cboSize);
            grbPizza.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbPizza.Location = new Point(61, 134);
            grbPizza.Name = "grbPizza";
            grbPizza.Size = new Size(553, 230);
            grbPizza.TabIndex = 2;
            grbPizza.TabStop = false;
            grbPizza.Text = "Build Your Pizza!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(16, 80);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 15;
            label1.Text = "Toppings: ";
            // 
            // grbCrust
            // 
            grbCrust.Controls.Add(rdoRegular);
            grbCrust.Controls.Add(rdoThick);
            grbCrust.Controls.Add(rdoThin);
            grbCrust.Location = new Point(189, 26);
            grbCrust.Name = "grbCrust";
            grbCrust.Size = new Size(317, 42);
            grbCrust.TabIndex = 14;
            grbCrust.TabStop = false;
            grbCrust.Text = "Select Crust: ";
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Location = new Point(225, 12);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(81, 24);
            rdoRegular.TabIndex = 2;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Location = new Point(155, 12);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(64, 24);
            rdoThick.TabIndex = 1;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Location = new Point(91, 12);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(58, 24);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Location = new Point(346, 194);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(102, 24);
            ckbMushroom.TabIndex = 13;
            ckbMushroom.Text = "Mushroom";
            ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            ckbExtraCheese.AutoSize = true;
            ckbExtraCheese.Location = new Point(346, 164);
            ckbExtraCheese.Name = "ckbExtraCheese";
            ckbExtraCheese.Size = new Size(115, 24);
            ckbExtraCheese.TabIndex = 12;
            ckbExtraCheese.Text = "Extra Cheese";
            ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            ckbJalepeno.AutoSize = true;
            ckbJalepeno.Location = new Point(346, 134);
            ckbJalepeno.Name = "ckbJalepeno";
            ckbJalepeno.Size = new Size(90, 24);
            ckbJalepeno.TabIndex = 11;
            ckbJalepeno.Text = "Jalapeño";
            ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            ckbBananaPeppers.AutoSize = true;
            ckbBananaPeppers.Location = new Point(346, 99);
            ckbBananaPeppers.Name = "ckbBananaPeppers";
            ckbBananaPeppers.Size = new Size(137, 24);
            ckbBananaPeppers.TabIndex = 10;
            ckbBananaPeppers.Text = "Banana Peppers";
            ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            ckbGreenOlives.AutoSize = true;
            ckbGreenOlives.Location = new Point(217, 194);
            ckbGreenOlives.Name = "ckbGreenOlives";
            ckbGreenOlives.Size = new Size(118, 24);
            ckbGreenOlives.TabIndex = 9;
            ckbGreenOlives.Text = "Green Olives ";
            ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            ckbBlackOlives.AutoSize = true;
            ckbBlackOlives.Location = new Point(217, 164);
            ckbBlackOlives.Name = "ckbBlackOlives";
            ckbBlackOlives.Size = new Size(110, 24);
            ckbBlackOlives.TabIndex = 8;
            ckbBlackOlives.Text = "Black Olives";
            ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            ckbGreenPepper.AutoSize = true;
            ckbGreenPepper.Location = new Point(217, 134);
            ckbGreenPepper.Name = "ckbGreenPepper";
            ckbGreenPepper.Size = new Size(121, 24);
            ckbGreenPepper.TabIndex = 7;
            ckbGreenPepper.Text = "Green Pepper";
            ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Location = new Point(217, 104);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(71, 24);
            ckbOnion.TabIndex = 6;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbSpicyItalianSausage
            // 
            ckbSpicyItalianSausage.AutoSize = true;
            ckbSpicyItalianSausage.Location = new Point(33, 194);
            ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            ckbSpicyItalianSausage.Size = new Size(178, 24);
            ckbSpicyItalianSausage.TabIndex = 4;
            ckbSpicyItalianSausage.Text = "Spicy Italian Sausagae";
            ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            ckbCanadianBacon.AutoSize = true;
            ckbCanadianBacon.Location = new Point(33, 164);
            ckbCanadianBacon.Name = "ckbCanadianBacon";
            ckbCanadianBacon.Size = new Size(138, 24);
            ckbCanadianBacon.TabIndex = 3;
            ckbCanadianBacon.Text = "Canadian Bacon";
            ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Location = new Point(32, 134);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(86, 24);
            ckbSausage.TabIndex = 2;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            ckbPepperoni.AutoSize = true;
            ckbPepperoni.Location = new Point(32, 104);
            ckbPepperoni.Name = "ckbPepperoni";
            ckbPepperoni.Size = new Size(99, 24);
            ckbPepperoni.TabIndex = 1;
            ckbPepperoni.Text = "Pepperoni";
            ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // pictPizza
            // 
            pictPizza.BackColor = SystemColors.Control;
            pictPizza.Image = Properties.Resources.pizzaPic;
            pictPizza.Location = new Point(620, 45);
            pictPizza.Name = "pictPizza";
            pictPizza.Size = new Size(211, 212);
            pictPizza.TabIndex = 3;
            pictPizza.TabStop = false;
            // 
            // lblValsPizzaria
            // 
            lblValsPizzaria.AutoSize = true;
            lblValsPizzaria.Font = new Font("Stencil", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblValsPizzaria.ForeColor = Color.DarkOrange;
            lblValsPizzaria.Location = new Point(154, 45);
            lblValsPizzaria.Name = "lblValsPizzaria";
            lblValsPizzaria.Size = new Size(364, 56);
            lblValsPizzaria.TabIndex = 4;
            lblValsPizzaria.Text = "Val's Pizzaria";
            // 
            // rtfOrderSummary
            // 
            rtfOrderSummary.Location = new Point(226, 385);
            rtfOrderSummary.Name = "rtfOrderSummary";
            rtfOrderSummary.Size = new Size(388, 120);
            rtfOrderSummary.TabIndex = 5;
            rtfOrderSummary.Text = "";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Stencil", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummary.ForeColor = Color.DarkOrange;
            lblSummary.Location = new Point(34, 385);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(186, 21);
            lblSummary.TabIndex = 6;
            lblSummary.Text = "Order Summary: ";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(746, 313);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(99, 27);
            txtSubTotal.TabIndex = 7;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(746, 346);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(99, 27);
            txtTax.TabIndex = 8;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(746, 379);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(99, 27);
            txtTotal.TabIndex = 9;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(655, 421);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(190, 49);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(655, 313);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 11;
            label2.Text = "SubTotal";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTax.Location = new Point(655, 344);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(39, 23);
            lblTax.TabIndex = 12;
            lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(655, 379);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 23);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lavenderTileFLoor;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(921, 534);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(label2);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubTotal);
            Controls.Add(lblSummary);
            Controls.Add(rtfOrderSummary);
            Controls.Add(lblValsPizzaria);
            Controls.Add(pictPizza);
            Controls.Add(grbPizza);
            Name = "FrmMain";
            Text = "Val's Pizza";
            grbPizza.ResumeLayout(false);
            grbPizza.PerformLayout();
            grbCrust.ResumeLayout(false);
            grbCrust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictPizza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSize;
        private GroupBox grbPizza;
        private CheckBox ckbSpicyItalianSausage;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbSausage;
        private CheckBox ckbPepperoni;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbOnion;
        private CheckBox ckbMushroom;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbJalepeno;
        private CheckBox ckbBananaPeppers;
        private GroupBox grbCrust;
        private RadioButton rdoRegular;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private PictureBox pictPizza;
        private Label lblValsPizzaria;
        private Label label1;
        private RichTextBox rtfOrderSummary;
        private Label lblSummary;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Label label2;
        private Label lblTax;
        private Label lblTotal;
    }
}
