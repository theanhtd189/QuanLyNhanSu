﻿namespace BTL_QLNS
{
    partial class QuanLyNhanVien
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbxDuan = new System.Windows.Forms.ComboBox();
            this.dUANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlynhasu_3FDataSet1 = new BTL_QLNS.Quanlynhasu_3FDataSet1();
            this.cbxPhongban = new System.Windows.Forms.ComboBox();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlynhasu_3FDataSet = new BTL_QLNS.Quanlynhasu_3FDataSet();
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblMaDa = new System.Windows.Forms.Label();
            this.lblMaPb = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblTenNv = new System.Windows.Forms.Label();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTieude = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.id_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Pb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Da = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLicense = new System.Windows.Forms.Label();
            this.pHONGBANTableAdapter = new BTL_QLNS.Quanlynhasu_3FDataSetTableAdapters.PHONGBANTableAdapter();
            this.dUANTableAdapter = new BTL_QLNS.Quanlynhasu_3FDataSet1TableAdapters.DUANTableAdapter();
            this.btnChon = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynhasu_3FDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynhasu_3FDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 567);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 300);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Image = global::BTL_QLNS.Properties.Resources.iconfinder_Undo_278852;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 39);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Trở lại";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExportExcel);
            this.panel2.Controls.Add(this.btnreset);
            this.panel2.Controls.Add(this.dtpNgaysinh);
            this.panel2.Controls.Add(this.cbxDuan);
            this.panel2.Controls.Add(this.cbxPhongban);
            this.panel2.Controls.Add(this.txtTenNv);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.txtLuong);
            this.panel2.Controls.Add(this.txtDiachi);
            this.panel2.Controls.Add(this.txtMaNv);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnTim);
            this.panel2.Controls.Add(this.lblMaDa);
            this.panel2.Controls.Add(this.lblMaPb);
            this.panel2.Controls.Add(this.lblLuong);
            this.panel2.Controls.Add(this.lblNgaysinh);
            this.panel2.Controls.Add(this.lblTenNv);
            this.panel2.Controls.Add(this.lblMaNv);
            this.panel2.Controls.Add(this.lblDiachi);
            this.panel2.Controls.Add(this.lblTieude);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(137, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 300);
            this.panel2.TabIndex = 1;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExportExcel.Image = global::BTL_QLNS.Properties.Resources.Logoexe;
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.Location = new System.Drawing.Point(638, 249);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(100, 38);
            this.btnExportExcel.TabIndex = 21;
            this.btnExportExcel.Text = "Xuất ";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnreset.Image = global::BTL_QLNS.Properties.Resources.iconfinder_Synchronize_278832;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.Location = new System.Drawing.Point(49, 249);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(109, 38);
            this.btnreset.TabIndex = 20;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaysinh.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaysinh.Location = new System.Drawing.Point(152, 156);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(200, 24);
            this.dtpNgaysinh.TabIndex = 6;
            // 
            // cbxDuan
            // 
            this.cbxDuan.DataSource = this.dUANBindingSource;
            this.cbxDuan.DisplayMember = "name_Da";
            this.cbxDuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxDuan.FormattingEnabled = true;
            this.cbxDuan.Location = new System.Drawing.Point(541, 192);
            this.cbxDuan.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDuan.Name = "cbxDuan";
            this.cbxDuan.Size = new System.Drawing.Size(197, 32);
            this.cbxDuan.TabIndex = 16;
            this.cbxDuan.ValueMember = "id_Da";
            // 
            // dUANBindingSource
            // 
            this.dUANBindingSource.DataMember = "DUAN";
            this.dUANBindingSource.DataSource = this.quanlynhasu_3FDataSet1;
            // 
            // quanlynhasu_3FDataSet1
            // 
            this.quanlynhasu_3FDataSet1.DataSetName = "Quanlynhasu_3FDataSet1";
            this.quanlynhasu_3FDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxPhongban
            // 
            this.cbxPhongban.DataSource = this.pHONGBANBindingSource;
            this.cbxPhongban.DisplayMember = "name_Pb";
            this.cbxPhongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxPhongban.FormattingEnabled = true;
            this.cbxPhongban.Location = new System.Drawing.Point(541, 151);
            this.cbxPhongban.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPhongban.Name = "cbxPhongban";
            this.cbxPhongban.Size = new System.Drawing.Size(197, 32);
            this.cbxPhongban.TabIndex = 14;
            this.cbxPhongban.ValueMember = "id_Pb";
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.quanlynhasu_3FDataSet;
            // 
            // quanlynhasu_3FDataSet
            // 
            this.quanlynhasu_3FDataSet.DataSetName = "Quanlynhasu_3FDataSet";
            this.quanlynhasu_3FDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTenNv
            // 
            this.txtTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNv.Location = new System.Drawing.Point(152, 112);
            this.txtTenNv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(200, 29);
            this.txtTenNv.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(183, 193);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 29);
            this.txtSearch.TabIndex = 8;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuong.Location = new System.Drawing.Point(541, 110);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(197, 29);
            this.txtLuong.TabIndex = 12;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiachi.Location = new System.Drawing.Point(541, 59);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(197, 29);
            this.txtDiachi.TabIndex = 10;
            // 
            // txtMaNv
            // 
            this.txtMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNv.Location = new System.Drawing.Point(152, 64);
            this.txtMaNv.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(200, 29);
            this.txtMaNv.TabIndex = 2;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = global::BTL_QLNS.Properties.Resources.iconfinder_Remove_278742;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(493, 249);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = global::BTL_QLNS.Properties.Resources.iconfinder_Save_278762;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(344, 249);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 38);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = global::BTL_QLNS.Properties.Resources.iconfinder_Stock_Index_Up_278812;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(195, 249);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 38);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Image = global::BTL_QLNS.Properties.Resources.iconfinder_Zoom_In_278882;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(49, 188);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(128, 34);
            this.btnTim.TabIndex = 7;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblMaDa
            // 
            this.lblMaDa.AutoSize = true;
            this.lblMaDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDa.Location = new System.Drawing.Point(404, 196);
            this.lblMaDa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDa.Name = "lblMaDa";
            this.lblMaDa.Size = new System.Drawing.Size(89, 24);
            this.lblMaDa.TabIndex = 15;
            this.lblMaDa.Text = "Mã dự án";
            // 
            // lblMaPb
            // 
            this.lblMaPb.AutoSize = true;
            this.lblMaPb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPb.Location = new System.Drawing.Point(403, 155);
            this.lblMaPb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaPb.Name = "lblMaPb";
            this.lblMaPb.Size = new System.Drawing.Size(133, 24);
            this.lblMaPb.TabIndex = 13;
            this.lblMaPb.Text = "Mã phòng ban";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLuong.Location = new System.Drawing.Point(404, 114);
            this.lblLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(64, 24);
            this.lblLuong.TabIndex = 11;
            this.lblLuong.Text = "Lương";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaysinh.Location = new System.Drawing.Point(45, 154);
            this.lblNgaysinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(94, 24);
            this.lblNgaysinh.TabIndex = 5;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblTenNv
            // 
            this.lblTenNv.AutoSize = true;
            this.lblTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNv.Location = new System.Drawing.Point(48, 112);
            this.lblTenNv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNv.Name = "lblTenNv";
            this.lblTenNv.Size = new System.Drawing.Size(66, 24);
            this.lblTenNv.TabIndex = 3;
            this.lblTenNv.Text = "Họ tên";
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNv.Location = new System.Drawing.Point(48, 64);
            this.lblMaNv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(68, 24);
            this.lblMaNv.TabIndex = 1;
            this.lblMaNv.Text = "Mã NV";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiachi.Location = new System.Drawing.Point(404, 64);
            this.lblDiachi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(67, 24);
            this.lblDiachi.TabIndex = 9;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTieude
            // 
            this.lblTieude.AutoSize = true;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieude.Location = new System.Drawing.Point(267, 10);
            this.lblTieude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(219, 29);
            this.lblTieude.TabIndex = 0;
            this.lblTieude.Text = "Quản lý nhân viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvNhanVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(137, 312);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 189);
            this.panel3.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Nv,
            this.nam_Nv,
            this.ngaysinh_Nv,
            this.diachi_Nv,
            this.luong_Nv,
            this.id_Pb,
            this.id_Da});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(771, 189);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_Nv
            // 
            this.id_Nv.DataPropertyName = "id_Nv";
            this.id_Nv.HeaderText = "Mã NV";
            this.id_Nv.MinimumWidth = 6;
            this.id_Nv.Name = "id_Nv";
            this.id_Nv.ReadOnly = true;
            // 
            // nam_Nv
            // 
            this.nam_Nv.DataPropertyName = "name_Nv";
            this.nam_Nv.HeaderText = "Họ Tên";
            this.nam_Nv.MinimumWidth = 6;
            this.nam_Nv.Name = "nam_Nv";
            this.nam_Nv.ReadOnly = true;
            // 
            // ngaysinh_Nv
            // 
            this.ngaysinh_Nv.DataPropertyName = "ngaysinh_Nv";
            this.ngaysinh_Nv.HeaderText = "Ngày sinh";
            this.ngaysinh_Nv.MinimumWidth = 6;
            this.ngaysinh_Nv.Name = "ngaysinh_Nv";
            this.ngaysinh_Nv.ReadOnly = true;
            // 
            // diachi_Nv
            // 
            this.diachi_Nv.DataPropertyName = "diachi_Nv";
            this.diachi_Nv.HeaderText = "Địa chỉ";
            this.diachi_Nv.MinimumWidth = 6;
            this.diachi_Nv.Name = "diachi_Nv";
            this.diachi_Nv.ReadOnly = true;
            // 
            // luong_Nv
            // 
            this.luong_Nv.DataPropertyName = "luong_Nv";
            this.luong_Nv.HeaderText = "Lương";
            this.luong_Nv.MinimumWidth = 6;
            this.luong_Nv.Name = "luong_Nv";
            this.luong_Nv.ReadOnly = true;
            // 
            // id_Pb
            // 
            this.id_Pb.DataPropertyName = "id_Pb";
            this.id_Pb.HeaderText = "Mã PB";
            this.id_Pb.MinimumWidth = 6;
            this.id_Pb.Name = "id_Pb";
            this.id_Pb.ReadOnly = true;
            // 
            // id_Da
            // 
            this.id_Da.DataPropertyName = "id_Da";
            this.id_Da.HeaderText = "Mã DA";
            this.id_Da.MinimumWidth = 6;
            this.id_Da.Name = "id_Da";
            this.id_Da.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnChon);
            this.panel4.Controls.Add(this.lblLicense);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(137, 509);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(771, 54);
            this.panel4.TabIndex = 3;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLicense.Location = new System.Drawing.Point(501, 31);
            this.lblLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(0, 17);
            this.lblLicense.TabIndex = 4;
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // dUANTableAdapter
            // 
            this.dUANTableAdapter.ClearBeforeFill = true;
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChon.Location = new System.Drawing.Point(299, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(157, 47);
            this.btnChon.TabIndex = 5;
            this.btnChon.Text = "CHỌN NHÂN VIÊN";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Quanlynhanvien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dUANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynhasu_3FDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlynhasu_3FDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Da;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.ComboBox cbxDuan;
        private System.Windows.Forms.ComboBox cbxPhongban;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblMaDa;
        private System.Windows.Forms.Label lblMaPb;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTieude;
        private Quanlynhasu_3FDataSet quanlynhasu_3FDataSet;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private Quanlynhasu_3FDataSetTableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private Quanlynhasu_3FDataSet1 quanlynhasu_3FDataSet1;
        private System.Windows.Forms.BindingSource dUANBindingSource;
        private Quanlynhasu_3FDataSet1TableAdapters.DUANTableAdapter dUANTableAdapter;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnChon;
    }
}