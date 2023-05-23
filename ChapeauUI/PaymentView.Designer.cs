namespace ChapeauUI
{
   public partial class PaymentView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtDrinkCost = new System.Windows.Forms.TextBox();
            this.txtMainCourseCost = new System.Windows.Forms.TextBox();
            this.txtDessertsCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWithoutVat = new System.Windows.Forms.TextBox();
            this.txtPriceWithVAT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttips = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.lblPerPerson = new System.Windows.Forms.Label();
            this.txtAmountPerPerson = new System.Windows.Forms.TextBox();
            this.pnlPaymentHistory = new System.Windows.Forms.Panel();
            this.listPaymentHistory = new System.Windows.Forms.ListView();
            this.btnPaymentHistory = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.rbtnVisa = new System.Windows.Forms.RadioButton();
            this.rbtnPin = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlPaymentHistory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chicken Pasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Molten Cake";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Split Bill ?";
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(64, 73);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(79, 36);
            this.rbtnYes.TabIndex = 7;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            this.rbtnYes.CheckedChanged += new System.EventHandler(this.rbtnYes_CheckedChanged);
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(239, 73);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(77, 36);
            this.rbtnNo.TabIndex = 8;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.rbtnNo_CheckedChanged);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(77, 441);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(129, 32);
            this.lblQuestion.TabIndex = 9;
            this.lblQuestion.Text = "How Many";
            // 
            // txtDrinkCost
            // 
            this.txtDrinkCost.Location = new System.Drawing.Point(689, 113);
            this.txtDrinkCost.Name = "txtDrinkCost";
            this.txtDrinkCost.Size = new System.Drawing.Size(200, 39);
            this.txtDrinkCost.TabIndex = 11;
            // 
            // txtMainCourseCost
            // 
            this.txtMainCourseCost.Location = new System.Drawing.Point(689, 179);
            this.txtMainCourseCost.Name = "txtMainCourseCost";
            this.txtMainCourseCost.Size = new System.Drawing.Size(200, 39);
            this.txtMainCourseCost.TabIndex = 12;
            // 
            // txtDessertsCost
            // 
            this.txtDessertsCost.Location = new System.Drawing.Point(685, 266);
            this.txtDessertsCost.Name = "txtDessertsCost";
            this.txtDessertsCost.Size = new System.Drawing.Size(200, 39);
            this.txtDessertsCost.TabIndex = 13;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(342, 817);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(432, 46);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 973);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Price without VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 1056);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Price Including VAT";
            // 
            // txtWithoutVat
            // 
            this.txtWithoutVat.Location = new System.Drawing.Point(885, 971);
            this.txtWithoutVat.Name = "txtWithoutVat";
            this.txtWithoutVat.Size = new System.Drawing.Size(200, 39);
            this.txtWithoutVat.TabIndex = 17;
            // 
            // txtPriceWithVAT
            // 
            this.txtPriceWithVAT.Location = new System.Drawing.Point(888, 1049);
            this.txtPriceWithVAT.Name = "txtPriceWithVAT";
            this.txtPriceWithVAT.Size = new System.Drawing.Size(200, 39);
            this.txtPriceWithVAT.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 1232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tips";
            // 
            // txttips
            // 
            this.txttips.Location = new System.Drawing.Point(888, 1225);
            this.txttips.Name = "txttips";
            this.txttips.Size = new System.Drawing.Size(200, 39);
            this.txttips.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 719);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Payment Method";
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Location = new System.Drawing.Point(885, 441);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(200, 39);
            this.txtNumberOfPeople.TabIndex = 22;
            // 
            // lblPerPerson
            // 
            this.lblPerPerson.AutoSize = true;
            this.lblPerPerson.Location = new System.Drawing.Point(80, 887);
            this.lblPerPerson.Name = "lblPerPerson";
            this.lblPerPerson.Size = new System.Drawing.Size(218, 32);
            this.lblPerPerson.TabIndex = 26;
            this.lblPerPerson.Text = "Amount Per Person";
            // 
            // txtAmountPerPerson
            // 
            this.txtAmountPerPerson.Location = new System.Drawing.Point(888, 887);
            this.txtAmountPerPerson.Name = "txtAmountPerPerson";
            this.txtAmountPerPerson.Size = new System.Drawing.Size(200, 39);
            this.txtAmountPerPerson.TabIndex = 27;
            // 
            // pnlPaymentHistory
            // 
            this.pnlPaymentHistory.Controls.Add(this.listPaymentHistory);
            this.pnlPaymentHistory.Location = new System.Drawing.Point(1372, 87);
            this.pnlPaymentHistory.Name = "pnlPaymentHistory";
            this.pnlPaymentHistory.Size = new System.Drawing.Size(562, 299);
            this.pnlPaymentHistory.TabIndex = 28;
            // 
            // listPaymentHistory
            // 
            this.listPaymentHistory.Location = new System.Drawing.Point(22, 26);
            this.listPaymentHistory.Name = "listPaymentHistory";
            this.listPaymentHistory.Size = new System.Drawing.Size(528, 233);
            this.listPaymentHistory.TabIndex = 0;
            this.listPaymentHistory.UseCompatibleStateImageBehavior = false;
            // 
            // btnPaymentHistory
            // 
            this.btnPaymentHistory.Location = new System.Drawing.Point(1521, 441);
            this.btnPaymentHistory.Name = "btnPaymentHistory";
            this.btnPaymentHistory.Size = new System.Drawing.Size(272, 46);
            this.btnPaymentHistory.TabIndex = 29;
            this.btnPaymentHistory.Text = "Payment History";
            this.btnPaymentHistory.UseVisualStyleBackColor = true;
            this.btnPaymentHistory.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1273, 887);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 32);
            this.label9.TabIndex = 30;
            this.label9.Text = "FeedBack";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(1617, 880);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(200, 39);
            this.txtFeedback.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 32);
            this.label10.TabIndex = 32;
            this.label10.Text = "Table";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Location = new System.Drawing.Point(557, 33);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(27, 32);
            this.lblTableNumber.TabIndex = 33;
            this.lblTableNumber.Text = "2";
            // 
            // rbtnVisa
            // 
            this.rbtnVisa.AutoSize = true;
            this.rbtnVisa.Location = new System.Drawing.Point(32, 71);
            this.rbtnVisa.Name = "rbtnVisa";
            this.rbtnVisa.Size = new System.Drawing.Size(88, 36);
            this.rbtnVisa.TabIndex = 34;
            this.rbtnVisa.TabStop = true;
            this.rbtnVisa.Text = "Visa";
            this.rbtnVisa.UseVisualStyleBackColor = true;
            // 
            // rbtnPin
            // 
            this.rbtnPin.AutoSize = true;
            this.rbtnPin.Location = new System.Drawing.Point(177, 125);
            this.rbtnPin.Name = "rbtnPin";
            this.rbtnPin.Size = new System.Drawing.Size(78, 36);
            this.rbtnPin.TabIndex = 35;
            this.rbtnPin.TabStop = true;
            this.rbtnPin.Text = "Pin";
            this.rbtnPin.UseVisualStyleBackColor = true;
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Location = new System.Drawing.Point(298, 71);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(96, 36);
            this.rbtnCash.TabIndex = 36;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "Cash";
            this.rbtnCash.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNo);
            this.groupBox1.Controls.Add(this.rbtnYes);
            this.groupBox1.Location = new System.Drawing.Point(934, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 200);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnCash);
            this.groupBox2.Controls.Add(this.rbtnPin);
            this.groupBox2.Controls.Add(this.rbtnVisa);
            this.groupBox2.Location = new System.Drawing.Point(850, 609);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 200);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(888, 1150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 39);
            this.textBox1.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 1157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 32);
            this.label11.TabIndex = 40;
            this.label11.Text = "Paied Amount";
            // 
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1971, 1308);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPaymentHistory);
            this.Controls.Add(this.pnlPaymentHistory);
            this.Controls.Add(this.txtAmountPerPerson);
            this.Controls.Add(this.lblPerPerson);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttips);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPriceWithVAT);
            this.Controls.Add(this.txtWithoutVat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDessertsCost);
            this.Controls.Add(this.txtMainCourseCost);
            this.Controls.Add(this.txtDrinkCost);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PaymentView";
            this.Text = "PaymentView";
            this.pnlPaymentHistory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private RadioButton rbtnYes;
        private RadioButton rbtnNo;
        private Label lblQuestion;
        private TextBox txtDrinkCost;
        private TextBox txtMainCourseCost;
        private TextBox txtDessertsCost;
        private Button btnCalculate;
        private Label label5;
        private Label label6;
        private TextBox txtWithoutVat;
        private TextBox txtPriceWithVAT;
        private Label label7;
        private TextBox txttips;
        private Label label8;
        private TextBox txtNumberOfPeople;
        private Label lblPerPerson;
        private TextBox txtAmountPerPerson;
        private Panel pnlPaymentHistory;
        private Button btnPaymentHistory;
        private ListView listPaymentHistory;
        private Label label9;
        private TextBox txtFeedback;
        private Label label10;
        private Label lblTableNumber;
        private RadioButton rbtnVisa;
        private RadioButton rbtnPin;
        private RadioButton rbtnCash;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label11;
    }
}