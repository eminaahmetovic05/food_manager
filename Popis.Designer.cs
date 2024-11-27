namespace WindowsFormsApplication1
{
    partial class Popis
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
            this.btn_klik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOCATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gALLERYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOPISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaDataSet = new WindowsFormsApplication1.novaDataSet();
            this.novaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikDataSet2 = new WindowsFormsApplication1.korisnikDataSet2();
            this.korisnikDataSet = new WindowsFormsApplication1.korisnikDataSet();
            this.korisnikDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikDataSet3 = new WindowsFormsApplication1.korisnikDataSet3();
            this.korisnikDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proizvodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikDataSet4 = new WindowsFormsApplication1.korisnikDataSet4();
            this.popisTableAdapter = new WindowsFormsApplication1.korisnikDataSet4TableAdapters.popisTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_klik
            // 
            this.btn_klik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_klik.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_klik.Location = new System.Drawing.Point(513, 453);
            this.btn_klik.Name = "btn_klik";
            this.btn_klik.Size = new System.Drawing.Size(112, 36);
            this.btn_klik.TabIndex = 1;
            this.btn_klik.Text = "Popis";
            this.btn_klik.UseVisualStyleBackColor = false;
            this.btn_klik.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(302, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis prodanih proizvoda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.lOCATIONToolStripMenuItem,
            this.gALLERYToolStripMenuItem,
            this.pOPISToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // lOCATIONToolStripMenuItem
            // 
            this.lOCATIONToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOCATIONToolStripMenuItem.Name = "lOCATIONToolStripMenuItem";
            this.lOCATIONToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.lOCATIONToolStripMenuItem.Text = "LOCATION";
            this.lOCATIONToolStripMenuItem.Click += new System.EventHandler(this.lOCATIONToolStripMenuItem_Click);
            // 
            // gALLERYToolStripMenuItem
            // 
            this.gALLERYToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gALLERYToolStripMenuItem.Name = "gALLERYToolStripMenuItem";
            this.gALLERYToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.gALLERYToolStripMenuItem.Text = "GALLERY";
            this.gALLERYToolStripMenuItem.Click += new System.EventHandler(this.gALLERYToolStripMenuItem_Click);
            // 
            // pOPISToolStripMenuItem
            // 
            this.pOPISToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOPISToolStripMenuItem.Name = "pOPISToolStripMenuItem";
            this.pOPISToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.pOPISToolStripMenuItem.Text = "POPIS";
            // 
            // novaDataSet
            // 
            this.novaDataSet.DataSetName = "novaDataSet";
            this.novaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // novaDataSetBindingSource
            // 
            this.novaDataSetBindingSource.DataSource = this.novaDataSet;
            this.novaDataSetBindingSource.Position = 0;
            // 
            // korisnikDataSet2BindingSource
            // 
            this.korisnikDataSet2BindingSource.DataSource = this.korisnikDataSet2;
            this.korisnikDataSet2BindingSource.Position = 0;
            // 
            // korisnikDataSet2
            // 
            this.korisnikDataSet2.DataSetName = "korisnikDataSet2";
            this.korisnikDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikDataSet
            // 
            this.korisnikDataSet.DataSetName = "korisnikDataSet";
            this.korisnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikDataSetBindingSource
            // 
            this.korisnikDataSetBindingSource.DataSource = this.korisnikDataSet;
            this.korisnikDataSetBindingSource.Position = 0;
            // 
            // korisnikDataSet3
            // 
            this.korisnikDataSet3.DataSetName = "korisnikDataSet3";
            this.korisnikDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikDataSet3BindingSource
            // 
            this.korisnikDataSet3BindingSource.DataSource = this.korisnikDataSet3;
            this.korisnikDataSet3BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proizvodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.popisBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(365, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // proizvodiDataGridViewTextBoxColumn
            // 
            this.proizvodiDataGridViewTextBoxColumn.DataPropertyName = "proizvodi";
            this.proizvodiDataGridViewTextBoxColumn.HeaderText = "proizvodi";
            this.proizvodiDataGridViewTextBoxColumn.Name = "proizvodiDataGridViewTextBoxColumn";
            // 
            // popisBindingSource
            // 
            this.popisBindingSource.DataMember = "popis";
            this.popisBindingSource.DataSource = this.korisnikDataSet4;
            // 
            // korisnikDataSet4
            // 
            this.korisnikDataSet4.DataSetName = "korisnikDataSet4";
            this.korisnikDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // popisTableAdapter
            // 
            this.popisTableAdapter.ClearBeforeFill = true;
            // 
            // Popis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 709);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_klik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Popis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Popis";
            this.Load += new System.EventHandler(this.Popis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_klik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOCATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gALLERYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOPISToolStripMenuItem;
        private System.Windows.Forms.BindingSource korisnikDataSetBindingSource;
        private korisnikDataSet korisnikDataSet;
        private System.Windows.Forms.BindingSource korisnikDataSet2BindingSource;
        private korisnikDataSet2 korisnikDataSet2;
        private System.Windows.Forms.BindingSource korisnikDataSet3BindingSource;
        private korisnikDataSet3 korisnikDataSet3;
        private System.Windows.Forms.BindingSource novaDataSetBindingSource;
        private novaDataSet novaDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private korisnikDataSet4 korisnikDataSet4;
        private System.Windows.Forms.BindingSource popisBindingSource;
        private WindowsFormsApplication1.korisnikDataSet4TableAdapters.popisTableAdapter popisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodiDataGridViewTextBoxColumn;

    }
}