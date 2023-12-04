namespace TrabalhoAvaliativo2
{
    partial class FormFIPE
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trabalhoSegurosDataSet1 = new TrabalhoAvaliativo2.trabalhoSegurosDataSet();
            this.apolicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apolicesTableAdapter = new TrabalhoAvaliativo2.trabalhoSegurosDataSetTableAdapters.ApolicesTableAdapter();
            this.tableAdapterManager = new TrabalhoAvaliativo2.trabalhoSegurosDataSetTableAdapters.TableAdapterManager();
            this.tabelaFIPEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabelaFIPETableAdapter = new TrabalhoAvaliativo2.trabalhoSegurosDataSetTableAdapters.TabelaFIPETableAdapter();
            this.tabelaFIPEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoSegurosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // trabalhoSegurosDataSet1
            // 
            this.trabalhoSegurosDataSet1.DataSetName = "trabalhoSegurosDataSet";
            this.trabalhoSegurosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apolicesBindingSource
            // 
            this.apolicesBindingSource.DataMember = "Apolices";
            this.apolicesBindingSource.DataSource = this.trabalhoSegurosDataSet1;
            // 
            // apolicesTableAdapter
            // 
            this.apolicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApolicesTableAdapter = this.apolicesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.MarcasTableAdapter = null;
            this.tableAdapterManager.ModelosTableAdapter = null;
            this.tableAdapterManager.TabelaFIPETableAdapter = this.tabelaFIPETableAdapter;
            this.tableAdapterManager.UpdateOrder = TrabalhoAvaliativo2.trabalhoSegurosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabelaFIPEBindingSource
            // 
            this.tabelaFIPEBindingSource.DataMember = "TabelaFIPE";
            this.tabelaFIPEBindingSource.DataSource = this.trabalhoSegurosDataSet1;
            // 
            // tabelaFIPETableAdapter
            // 
            this.tabelaFIPETableAdapter.ClearBeforeFill = true;
            // 
            // tabelaFIPEDataGridView
            // 
            this.tabelaFIPEDataGridView.AutoGenerateColumns = false;
            this.tabelaFIPEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaFIPEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tabelaFIPEDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tabelaFIPEDataGridView.DataSource = this.tabelaFIPEBindingSource;
            this.tabelaFIPEDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaFIPEDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tabelaFIPEDataGridView.Name = "tabelaFIPEDataGridView";
            this.tabelaFIPEDataGridView.Size = new System.Drawing.Size(800, 450);
            this.tabelaFIPEDataGridView.TabIndex = 0;
            this.tabelaFIPEDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaFIPEDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MarcaID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MarcaID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ModeloID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ModeloID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ano";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ano";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormFIPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabelaFIPEDataGridView);
            this.Name = "FormFIPE";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormFIPE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoSegurosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apolicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaFIPEDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private trabalhoSegurosDataSet trabalhoSegurosDataSet1;
        private System.Windows.Forms.BindingSource apolicesBindingSource;
        private trabalhoSegurosDataSetTableAdapters.ApolicesTableAdapter apolicesTableAdapter;
        private trabalhoSegurosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private trabalhoSegurosDataSetTableAdapters.TabelaFIPETableAdapter tabelaFIPETableAdapter;
        private System.Windows.Forms.BindingSource tabelaFIPEBindingSource;
        private System.Windows.Forms.DataGridView tabelaFIPEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}