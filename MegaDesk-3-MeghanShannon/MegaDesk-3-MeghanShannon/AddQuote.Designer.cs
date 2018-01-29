namespace MegaDesk_3_MeghanShannon
{
    partial class AddQuote
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
            this.MainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.deskWidth = new System.Windows.Forms.TextBox();
            this.deskDepth = new System.Windows.Forms.TextBox();
            this.drawerNum = new System.Windows.Forms.ComboBox();
            this.surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.rushOrder = new System.Windows.Forms.ComboBox();
            this.errorMessage = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(481, 12);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(107, 32);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(47, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(47, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desk Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(46, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desk Depth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(47, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount of Drawers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(47, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Surface Material:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(47, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rush Order: (optional)";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(351, 60);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(237, 22);
            this.customerName.TabIndex = 7;
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(351, 106);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(237, 22);
            this.deskWidth.TabIndex = 8;
            this.deskWidth.TextChanged += new System.EventHandler(this.deskWidth_TextChanged);
            // 
            // deskDepth
            // 
            this.deskDepth.Location = new System.Drawing.Point(351, 154);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(237, 22);
            this.deskDepth.TabIndex = 9;
            this.deskDepth.TextChanged += new System.EventHandler(this.deskDepth_TextChanged);
            this.deskDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deskDepth_KeyPress);
            // 
            // drawerNum
            // 
            this.drawerNum.FormattingEnabled = true;
            this.drawerNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawerNum.Location = new System.Drawing.Point(351, 198);
            this.drawerNum.Name = "drawerNum";
            this.drawerNum.Size = new System.Drawing.Size(121, 24);
            this.drawerNum.TabIndex = 10;
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.FormattingEnabled = true;
            this.surfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.surfaceMaterial.Location = new System.Drawing.Point(351, 247);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(121, 24);
            this.surfaceMaterial.TabIndex = 11;
            // 
            // rushOrder
            // 
            this.rushOrder.FormattingEnabled = true;
            this.rushOrder.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.rushOrder.Location = new System.Drawing.Point(351, 298);
            this.rushOrder.Name = "rushOrder";
            this.rushOrder.Size = new System.Drawing.Size(121, 24);
            this.rushOrder.TabIndex = 12;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.Location = new System.Drawing.Point(51, 12);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 25);
            this.errorMessage.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Submit.Location = new System.Drawing.Point(481, 326);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(120, 32);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.rushOrder);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.drawerNum);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox deskWidth;
        private System.Windows.Forms.TextBox deskDepth;
        private System.Windows.Forms.ComboBox drawerNum;
        private System.Windows.Forms.ComboBox surfaceMaterial;
        private System.Windows.Forms.ComboBox rushOrder;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Submit;
    }
}