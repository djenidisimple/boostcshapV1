namespace Boost
{
    partial class FormAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.address = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "<--";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(22, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(636, 211);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(125, 376);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownAge.TabIndex = 25;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(52, 412);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 24;
            this.address.Text = "Adresse";
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Location = new System.Drawing.Point(52, 376);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(26, 13);
            this.years.TabIndex = 23;
            this.years.Text = "Age";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(52, 340);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(43, 13);
            this.firstName.TabIndex = 22;
            this.firstName.Text = "Prenom";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(52, 304);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 21;
            this.name.Text = "Nom";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(52, 276);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(58, 13);
            this.id.TabIndex = 20;
            this.id.Text = "identuifiant";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(304, 317);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "MODIFIER";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(125, 412);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(133, 20);
            this.textBoxAdress.TabIndex = 18;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(125, 340);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(133, 20);
            this.textBoxFirstName.TabIndex = 17;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(125, 304);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 20);
            this.textBoxName.TabIndex = 16;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(125, 270);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(133, 20);
            this.textId.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(304, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "SUPPRIMER";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 480);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.address);
            this.Controls.Add(this.years);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        protected System.Windows.Forms.NumericUpDown numericUpDownAge;
        protected System.Windows.Forms.Label address;
        protected System.Windows.Forms.Label years;
        protected System.Windows.Forms.Label firstName;
        protected System.Windows.Forms.Label name;
        protected System.Windows.Forms.Label id;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button btnDelete;
    }
}