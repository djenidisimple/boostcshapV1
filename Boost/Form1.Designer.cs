namespace Boost
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
            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boostDataSet = new Boost.BoostDataSet();
            this.btnWin = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridAffichage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boostDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAffichage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(105, 96);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(105, 145);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(133, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(105, 234);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(133, 20);
            this.textBoxAdress.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(162, 282);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "AJOUTER";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataMember = "Personne";
            this.personneBindingSource.DataSource = this.boostDataSet;
            // 
            // boostDataSet
            // 
            this.boostDataSet.DataSetName = "BoostDataSet";
            this.boostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnWin
            // 
            this.btnWin.Location = new System.Drawing.Point(539, 366);
            this.btnWin.Name = "btnWin";
            this.btnWin.Size = new System.Drawing.Size(75, 23);
            this.btnWin.TabIndex = 7;
            this.btnWin.Text = "fenetre 2";
            this.btnWin.UseVisualStyleBackColor = true;
            this.btnWin.Click += new System.EventHandler(this.btnWin_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(32, 96);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 9;
            this.name.Text = "Nom";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(32, 145);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(43, 13);
            this.firstName.TabIndex = 10;
            this.firstName.Text = "Prenom";
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Location = new System.Drawing.Point(32, 189);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(26, 13);
            this.years.TabIndex = 11;
            this.years.Text = "Age";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(32, 234);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 12;
            this.address.Text = "Adresse";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(105, 189);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(132, 20);
            this.numericUpDownAge.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Personne";
            // 
            // dataGridAffichage
            // 
            this.dataGridAffichage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAffichage.Location = new System.Drawing.Point(277, 40);
            this.dataGridAffichage.Name = "dataGridAffichage";
            this.dataGridAffichage.Size = new System.Drawing.Size(545, 297);
            this.dataGridAffichage.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(849, 419);
            this.Controls.Add(this.dataGridAffichage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.address);
            this.Controls.Add(this.years);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnWin);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boostDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAffichage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnWin;
        protected System.Windows.Forms.Label name;
        protected System.Windows.Forms.Label firstName;
        protected System.Windows.Forms.Label years;
        protected System.Windows.Forms.Label address;
        protected System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private BoostDataSet boostDataSet;
        private System.Windows.Forms.DataGridView dataGridAffichage;
    }
}

