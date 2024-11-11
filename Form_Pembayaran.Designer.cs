namespace JenisBayar
{
    partial class Form_JenisPembayaran
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKodePembayaran = new System.Windows.Forms.TextBox();
            this.txtNamaPembayaran = new System.Windows.Forms.TextBox();
            this.txtJumlahPembayaran = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dgJenisBayar = new System.Windows.Forms.DataGridView();
            this.kodejenispembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namapembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmlpembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblJenisBayarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbAdmSekolahDataSet = new JenisBayar.dbAdmSekolahDataSet();
            this.tbl_JenisBayarTableAdapter = new JenisBayar.dbAdmSekolahDataSetTableAdapters.tbl_JenisBayarTableAdapter();
            this.dbAdmSekolahDataSet1 = new JenisBayar.dbAdmSekolahDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dgJenisBayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJenisBayarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAdmSekolahDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAdmSekolahDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(752, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA JENIS PEMBAYARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pembayaran ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kode Pembayaran ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Pembayaran ";
            // 
            // txtKodePembayaran
            // 
            this.txtKodePembayaran.Location = new System.Drawing.Point(436, 163);
            this.txtKodePembayaran.Name = "txtKodePembayaran";
            this.txtKodePembayaran.Size = new System.Drawing.Size(355, 38);
            this.txtKodePembayaran.TabIndex = 4;
            // 
            // txtNamaPembayaran
            // 
            this.txtNamaPembayaran.Location = new System.Drawing.Point(436, 295);
            this.txtNamaPembayaran.Name = "txtNamaPembayaran";
            this.txtNamaPembayaran.Size = new System.Drawing.Size(355, 38);
            this.txtNamaPembayaran.TabIndex = 5;
            // 
            // txtJumlahPembayaran
            // 
            this.txtJumlahPembayaran.Location = new System.Drawing.Point(436, 412);
            this.txtJumlahPembayaran.Name = "txtJumlahPembayaran";
            this.txtJumlahPembayaran.Size = new System.Drawing.Size(355, 38);
            this.txtJumlahPembayaran.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(746, 512);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 57);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(94, 512);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(150, 57);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "Tambah ";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(304, 512);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(150, 57);
            this.btnUbah.TabIndex = 11;
            this.btnUbah.Text = "Ubah ";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(530, 512);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(150, 57);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dgJenisBayar
            // 
            this.dgJenisBayar.AutoGenerateColumns = false;
            this.dgJenisBayar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgJenisBayar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodejenispembayaranDataGridViewTextBoxColumn,
            this.namapembayaranDataGridViewTextBoxColumn,
            this.jmlpembayaranDataGridViewTextBoxColumn});
            this.dgJenisBayar.DataSource = this.tblJenisBayarBindingSource;
            this.dgJenisBayar.Location = new System.Drawing.Point(94, 613);
            this.dgJenisBayar.Name = "dgJenisBayar";
            this.dgJenisBayar.RowHeadersWidth = 102;
            this.dgJenisBayar.RowTemplate.Height = 40;
            this.dgJenisBayar.Size = new System.Drawing.Size(857, 270);
            this.dgJenisBayar.TabIndex = 14;
            // 
            // kodejenispembayaranDataGridViewTextBoxColumn
            // 
            this.kodejenispembayaranDataGridViewTextBoxColumn.DataPropertyName = "kode_jenispembayaran";
            this.kodejenispembayaranDataGridViewTextBoxColumn.HeaderText = "kode_jenispembayaran";
            this.kodejenispembayaranDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.kodejenispembayaranDataGridViewTextBoxColumn.Name = "kodejenispembayaranDataGridViewTextBoxColumn";
            this.kodejenispembayaranDataGridViewTextBoxColumn.Width = 250;
            // 
            // namapembayaranDataGridViewTextBoxColumn
            // 
            this.namapembayaranDataGridViewTextBoxColumn.DataPropertyName = "nama_pembayaran";
            this.namapembayaranDataGridViewTextBoxColumn.HeaderText = "nama_pembayaran";
            this.namapembayaranDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.namapembayaranDataGridViewTextBoxColumn.Name = "namapembayaranDataGridViewTextBoxColumn";
            this.namapembayaranDataGridViewTextBoxColumn.Width = 250;
            // 
            // jmlpembayaranDataGridViewTextBoxColumn
            // 
            this.jmlpembayaranDataGridViewTextBoxColumn.DataPropertyName = "jml_pembayaran";
            this.jmlpembayaranDataGridViewTextBoxColumn.HeaderText = "jml_pembayaran";
            this.jmlpembayaranDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.jmlpembayaranDataGridViewTextBoxColumn.Name = "jmlpembayaranDataGridViewTextBoxColumn";
            this.jmlpembayaranDataGridViewTextBoxColumn.Width = 250;
            // 
            // tblJenisBayarBindingSource
            // 
            this.tblJenisBayarBindingSource.DataMember = "tbl_JenisBayar";
            this.tblJenisBayarBindingSource.DataSource = this.dbAdmSekolahDataSet;
            // 
            // dbAdmSekolahDataSet
            // 
            this.dbAdmSekolahDataSet.DataSetName = "dbAdmSekolahDataSet";
            this.dbAdmSekolahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_JenisBayarTableAdapter
            // 
            this.tbl_JenisBayarTableAdapter.ClearBeforeFill = true;
            // 
            // dbAdmSekolahDataSet1
            // 
            this.dbAdmSekolahDataSet1.DataSetName = "dbAdmSekolahDataSet";
            this.dbAdmSekolahDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form_JenisPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1043, 945);
            this.Controls.Add(this.dgJenisBayar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtJumlahPembayaran);
            this.Controls.Add(this.txtNamaPembayaran);
            this.Controls.Add(this.txtKodePembayaran);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_JenisPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Agama";
            this.Load += new System.EventHandler(this.Form_Agama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgJenisBayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJenisBayarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAdmSekolahDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAdmSekolahDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKodePembayaran;
        private System.Windows.Forms.TextBox txtNamaPembayaran;
        private System.Windows.Forms.TextBox txtJumlahPembayaran;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgJenisBayar;
        private dbAdmSekolahDataSet dbAdmSekolahDataSet;
        private System.Windows.Forms.BindingSource tblJenisBayarBindingSource;
        private dbAdmSekolahDataSetTableAdapters.tbl_JenisBayarTableAdapter tbl_JenisBayarTableAdapter;
        private dbAdmSekolahDataSet dbAdmSekolahDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodejenispembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namapembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmlpembayaranDataGridViewTextBoxColumn;
    }
}

