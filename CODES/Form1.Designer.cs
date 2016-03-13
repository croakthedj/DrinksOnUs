namespace DrinkOMatic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblingredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fInalDataSet2 = new DrinkOMatic.FInalDataSet2();
            this.vwDRINKSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fInalDataSet10 = new DrinkOMatic.FInalDataSet10();
            this.tblingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fInalDataSet1 = new DrinkOMatic.FInalDataSet1();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tblingredientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fInalDataSet3 = new DrinkOMatic.FInalDataSet3();
            this.tblingredientsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fInalDataSet4 = new DrinkOMatic.FInalDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblDrinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fInalDataSet = new DrinkOMatic.FInalDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.tblDrinksTableAdapter = new DrinkOMatic.FInalDataSetTableAdapters.tblDrinksTableAdapter();
            this.tblingredientsTableAdapter = new DrinkOMatic.FInalDataSet1TableAdapters.tblingredientsTableAdapter();
            this.tblingredientsTableAdapter1 = new DrinkOMatic.FInalDataSet2TableAdapters.tblingredientsTableAdapter();
            this.tblingredientsTableAdapter2 = new DrinkOMatic.FInalDataSet3TableAdapters.tblingredientsTableAdapter();
            this.tblingredientsTableAdapter3 = new DrinkOMatic.FInalDataSet4TableAdapters.tblingredientsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwDRINKSearchTableAdapter = new DrinkOMatic.FInalDataSet10TableAdapters.vwDRINKSearchTableAdapter();
            this.fInalDataSet18 = new DrinkOMatic.FInalDataSet18();
            this.cmbIntSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbIntSearchTableAdapter = new DrinkOMatic.FInalDataSet18TableAdapters.cmbIntSearchTableAdapter();
            this.fInalDataSet19 = new DrinkOMatic.FInalDataSet19();
            this.vwDRINKSearch1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDRINKSearch1TableAdapter = new DrinkOMatic.FInalDataSet19TableAdapters.vwDRINKSearch1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblingredientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDRINKSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblingredientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblingredientsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIntSearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDRINKSearch1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblingredientsBindingSource1, "Ingredients", true));
            this.comboBox1.DataSource = this.vwDRINKSearchBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Ingredients";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // tblingredientsBindingSource1
            // 
            this.tblingredientsBindingSource1.DataMember = "tblingredients";
            this.tblingredientsBindingSource1.DataSource = this.fInalDataSet2;
            // 
            // fInalDataSet2
            // 
            this.fInalDataSet2.DataSetName = "FInalDataSet2";
            this.fInalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwDRINKSearchBindingSource
            // 
            this.vwDRINKSearchBindingSource.DataMember = "vwDRINKSearch";
            this.vwDRINKSearchBindingSource.DataSource = this.fInalDataSet10;
            // 
            // fInalDataSet10
            // 
            this.fInalDataSet10.DataSetName = "FInalDataSet10";
            this.fInalDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblingredientsBindingSource
            // 
            this.tblingredientsBindingSource.DataMember = "tblingredients";
            this.tblingredientsBindingSource.DataSource = this.fInalDataSet1;
            // 
            // fInalDataSet1
            // 
            this.fInalDataSet1.DataSetName = "FInalDataSet1";
            this.fInalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblingredientsBindingSource1, "Ingredients", true));
            this.comboBox2.DataSource = this.tblingredientsBindingSource1;
            this.comboBox2.DisplayMember = "Ingredients";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(152, 253);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(283, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "Ingredients";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwDRINKSearchBindingSource, "Category", true));
            this.comboBox3.DataSource = this.vwDRINKSearchBindingSource;
            this.comboBox3.DisplayMember = "Category";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(152, 327);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(283, 24);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.ValueMember = "Category";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tblingredientsBindingSource2
            // 
            this.tblingredientsBindingSource2.DataMember = "tblingredients";
            this.tblingredientsBindingSource2.DataSource = this.fInalDataSet3;
            // 
            // fInalDataSet3
            // 
            this.fInalDataSet3.DataSetName = "FInalDataSet3";
            this.fInalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblingredientsBindingSource3
            // 
            this.tblingredientsBindingSource3.DataMember = "tblingredients";
            this.tblingredientsBindingSource3.DataSource = this.fInalDataSet4;
            // 
            // fInalDataSet4
            // 
            this.fInalDataSet4.DataSetName = "FInalDataSet4";
            this.fInalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(21, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingredients";
            // 
            // Search_txt
            // 
            this.Search_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_txt.Location = new System.Drawing.Point(634, 189);
            this.Search_txt.Multiline = true;
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(283, 22);
            this.Search_txt.TabIndex = 5;
            this.Search_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(551, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::DrinkOMatic.Properties.Resources.Hopstarter_Scrap_Magnifying_Glass;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(634, 273);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 62);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Show Drink(s)";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::DrinkOMatic.Properties.Resources.edit_add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(788, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 62);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add New";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Addform_load);
            // 
            // tblDrinksBindingSource
            // 
            this.tblDrinksBindingSource.DataMember = "tblDrinks";
            this.tblDrinksBindingSource.DataSource = this.fInalDataSet;
            // 
            // fInalDataSet
            // 
            this.fInalDataSet.DataSetName = "FInalDataSet";
            this.fInalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(3, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 12;
            // 
            // tblDrinksTableAdapter
            // 
            this.tblDrinksTableAdapter.ClearBeforeFill = true;
            // 
            // tblingredientsTableAdapter
            // 
            this.tblingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // tblingredientsTableAdapter1
            // 
            this.tblingredientsTableAdapter1.ClearBeforeFill = true;
            // 
            // tblingredientsTableAdapter2
            // 
            this.tblingredientsTableAdapter2.ClearBeforeFill = true;
            // 
            // tblingredientsTableAdapter3
            // 
            this.tblingredientsTableAdapter3.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Image = global::DrinkOMatic.Properties.Resources.TOPOMATICSM;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(970, 83);
            this.label3.TabIndex = 11;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Category,
            this.Amount,
            this.Ingredients,
            this.directionsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vwDRINKSearchBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 403);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(961, 266);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 94;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 85;
            // 
            // Ingredients
            // 
            this.Ingredients.DataPropertyName = "Ingredients";
            this.Ingredients.HeaderText = "Ingredients";
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.ReadOnly = true;
            this.Ingredients.Width = 107;
            // 
            // directionsDataGridViewTextBoxColumn
            // 
            this.directionsDataGridViewTextBoxColumn.DataPropertyName = "Directions";
            this.directionsDataGridViewTextBoxColumn.HeaderText = "Directions";
            this.directionsDataGridViewTextBoxColumn.Name = "directionsDataGridViewTextBoxColumn";
            this.directionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwDRINKSearchTableAdapter
            // 
            this.vwDRINKSearchTableAdapter.ClearBeforeFill = true;
            // 
            // fInalDataSet18
            // 
            this.fInalDataSet18.DataSetName = "FInalDataSet18";
            this.fInalDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbIntSearchBindingSource
            // 
            this.cmbIntSearchBindingSource.DataMember = "cmbIntSearch";
            this.cmbIntSearchBindingSource.DataSource = this.fInalDataSet18;
            // 
            // cmbIntSearchTableAdapter
            // 
            this.cmbIntSearchTableAdapter.ClearBeforeFill = true;
            // 
            // fInalDataSet19
            // 
            this.fInalDataSet19.DataSetName = "FInalDataSet19";
            this.fInalDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwDRINKSearch1BindingSource
            // 
            this.vwDRINKSearch1BindingSource.DataMember = "vwDRINKSearch1";
            this.vwDRINKSearch1BindingSource.DataSource = this.fInalDataSet19;
            // 
            // vwDRINKSearch1TableAdapter
            // 
            this.vwDRINKSearch1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::DrinkOMatic.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 689);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Drink-O-Matic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblingredientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDRINKSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblingredientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblingredientsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIntSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fInalDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDRINKSearch1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private FInalDataSet fInalDataSet;
        private System.Windows.Forms.BindingSource tblDrinksBindingSource;
        private FInalDataSetTableAdapters.tblDrinksTableAdapter tblDrinksTableAdapter;
        private System.Windows.Forms.Label label4;
        private FInalDataSet1 fInalDataSet1;
        private System.Windows.Forms.BindingSource tblingredientsBindingSource;
        private FInalDataSet1TableAdapters.tblingredientsTableAdapter tblingredientsTableAdapter;
        private FInalDataSet2 fInalDataSet2;
        private System.Windows.Forms.BindingSource tblingredientsBindingSource1;
        private FInalDataSet2TableAdapters.tblingredientsTableAdapter tblingredientsTableAdapter1;
        private FInalDataSet3 fInalDataSet3;
        private System.Windows.Forms.BindingSource tblingredientsBindingSource2;
        private FInalDataSet3TableAdapters.tblingredientsTableAdapter tblingredientsTableAdapter2;
        private FInalDataSet4 fInalDataSet4;
        private System.Windows.Forms.BindingSource tblingredientsBindingSource3;
        private FInalDataSet4TableAdapters.tblingredientsTableAdapter tblingredientsTableAdapter3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FInalDataSet10 fInalDataSet10;
        private System.Windows.Forms.BindingSource vwDRINKSearchBindingSource;
        private FInalDataSet10TableAdapters.vwDRINKSearchTableAdapter vwDRINKSearchTableAdapter;
        private FInalDataSet18 fInalDataSet18;
        private System.Windows.Forms.BindingSource cmbIntSearchBindingSource;
        private FInalDataSet18TableAdapters.cmbIntSearchTableAdapter cmbIntSearchTableAdapter;
        private FInalDataSet19 fInalDataSet19;
        private System.Windows.Forms.BindingSource vwDRINKSearch1BindingSource;
        private FInalDataSet19TableAdapters.vwDRINKSearch1TableAdapter vwDRINKSearch1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredients;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionsDataGridViewTextBoxColumn;

    }
}

