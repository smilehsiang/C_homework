namespace homework1_console
{
    partial class Frm_note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_note));
            this.工具列 = new System.Windows.Forms.MenuStrip();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.儲存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.列印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.預覽列印VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.結束XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.復原UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消復原RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全選AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選項OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.轉成大寫 = new System.Windows.Forms.ToolStripMenuItem();
            this.轉成小寫 = new System.Windows.Forms.ToolStripMenuItem();
            this.自動換行 = new System.Windows.Forms.ToolStripMenuItem();
            this.快選顏色 = new System.Windows.Forms.ToolStripMenuItem();
            this.紅色 = new System.Windows.Forms.ToolStripMenuItem();
            this.綠色 = new System.Windows.Forms.ToolStripMenuItem();
            this.藍色 = new System.Windows.Forms.ToolStripMenuItem();
            this.黑色 = new System.Windows.Forms.ToolStripMenuItem();
            this.說明HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.內容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜尋SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.關於 = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟檔案 = new System.Windows.Forms.OpenFileDialog();
            this.儲存檔案 = new System.Windows.Forms.SaveFileDialog();
            this.字型 = new System.Windows.Forms.FontDialog();
            this.顏色 = new System.Windows.Forms.ColorDialog();
            this.工具欄 = new System.Windows.Forms.ToolStrip();
            this.新增tool = new System.Windows.Forms.ToolStripButton();
            this.開啟tool = new System.Windows.Forms.ToolStripButton();
            this.儲存tool = new System.Windows.Forms.ToolStripButton();
            this.列印PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下tool = new System.Windows.Forms.ToolStripButton();
            this.複製tool = new System.Windows.Forms.ToolStripButton();
            this.貼上tool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.說明tool = new System.Windows.Forms.ToolStripButton();
            this.時間 = new System.Windows.Forms.Timer(this.components);
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.狀態欄 = new System.Windows.Forms.StatusStrip();
            this.time = new System.Windows.Forms.ToolStripStatusLabel();
            this.預覽列印 = new System.Windows.Forms.PrintPreviewDialog();
            this.工具列.SuspendLayout();
            this.工具欄.SuspendLayout();
            this.狀態欄.SuspendLayout();
            this.SuspendLayout();
            // 
            // 工具列
            // 
            this.工具列.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.工具列.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.工具列.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.選項ToolStripMenuItem,
            this.說明HToolStripMenuItem});
            this.工具列.Location = new System.Drawing.Point(0, 0);
            this.工具列.Name = "工具列";
            this.工具列.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.工具列.Size = new System.Drawing.Size(1454, 48);
            this.工具列.TabIndex = 0;
            this.工具列.Text = "menu";
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripMenuItem,
            this.開啟OToolStripMenuItem,
            this.toolStripSeparator,
            this.儲存SToolStripMenuItem,
            this.另存新檔AToolStripMenuItem,
            this.toolStripSeparator1,
            this.列印PToolStripMenuItem,
            this.預覽列印VToolStripMenuItem,
            this.toolStripSeparator2,
            this.結束XToolStripMenuItem});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(110, 34);
            this.檔案FToolStripMenuItem.Text = "檔案(&F)";
            // 
            // 新增NToolStripMenuItem
            // 
            this.新增NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新增NToolStripMenuItem.Image")));
            this.新增NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增NToolStripMenuItem.Name = "新增NToolStripMenuItem";
            this.新增NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新增NToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.新增NToolStripMenuItem.Text = "新增(&N)";
            this.新增NToolStripMenuItem.Click += new System.EventHandler(this.新增NToolStripMenuItem_Click);
            // 
            // 開啟OToolStripMenuItem
            // 
            this.開啟OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("開啟OToolStripMenuItem.Image")));
            this.開啟OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟OToolStripMenuItem.Name = "開啟OToolStripMenuItem";
            this.開啟OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開啟OToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.開啟OToolStripMenuItem.Text = "開啟(&O)";
            this.開啟OToolStripMenuItem.Click += new System.EventHandler(this.開啟OToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(356, 6);
            // 
            // 儲存SToolStripMenuItem
            // 
            this.儲存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripMenuItem.Image")));
            this.儲存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripMenuItem.Name = "儲存SToolStripMenuItem";
            this.儲存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.儲存SToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.儲存SToolStripMenuItem.Text = "儲存(&S)";
            this.儲存SToolStripMenuItem.Click += new System.EventHandler(this.儲存SToolStripMenuItem_Click);
            // 
            // 另存新檔AToolStripMenuItem
            // 
            this.另存新檔AToolStripMenuItem.Name = "另存新檔AToolStripMenuItem";
            this.另存新檔AToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.另存新檔AToolStripMenuItem.Text = "另存新檔(&A)";
            this.另存新檔AToolStripMenuItem.Click += new System.EventHandler(this.另存新檔AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // 列印PToolStripMenuItem
            // 
            this.列印PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("列印PToolStripMenuItem.Image")));
            this.列印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.列印PToolStripMenuItem.Name = "列印PToolStripMenuItem";
            this.列印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.列印PToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.列印PToolStripMenuItem.Text = "列印(&P)";
            // 
            // 預覽列印VToolStripMenuItem
            // 
            this.預覽列印VToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("預覽列印VToolStripMenuItem.Image")));
            this.預覽列印VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.預覽列印VToolStripMenuItem.Name = "預覽列印VToolStripMenuItem";
            this.預覽列印VToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.預覽列印VToolStripMenuItem.Text = "預覽列印(&V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(356, 6);
            // 
            // 結束XToolStripMenuItem
            // 
            this.結束XToolStripMenuItem.Name = "結束XToolStripMenuItem";
            this.結束XToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.結束XToolStripMenuItem.Text = "結束(&X)";
            this.結束XToolStripMenuItem.Click += new System.EventHandler(this.結束XToolStripMenuItem_Click);
            // 
            // 編輯EToolStripMenuItem
            // 
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.復原UToolStripMenuItem,
            this.取消復原RToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪下TToolStripMenuItem,
            this.複製CToolStripMenuItem,
            this.貼上PToolStripMenuItem,
            this.toolStripSeparator4,
            this.全選AToolStripMenuItem});
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(110, 34);
            this.編輯EToolStripMenuItem.Text = "編輯(&E)";
            // 
            // 復原UToolStripMenuItem
            // 
            this.復原UToolStripMenuItem.Name = "復原UToolStripMenuItem";
            this.復原UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.復原UToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.復原UToolStripMenuItem.Text = "復原(&U)";
            // 
            // 取消復原RToolStripMenuItem
            // 
            this.取消復原RToolStripMenuItem.Name = "取消復原RToolStripMenuItem";
            this.取消復原RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.取消復原RToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.取消復原RToolStripMenuItem.Text = "取消復原(&R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(356, 6);
            // 
            // 剪下TToolStripMenuItem
            // 
            this.剪下TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪下TToolStripMenuItem.Image")));
            this.剪下TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪下TToolStripMenuItem.Name = "剪下TToolStripMenuItem";
            this.剪下TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪下TToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.剪下TToolStripMenuItem.Text = "剪下(&T)";
            this.剪下TToolStripMenuItem.Click += new System.EventHandler(this.剪下TToolStripMenuItem_Click);
            // 
            // 複製CToolStripMenuItem
            // 
            this.複製CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("複製CToolStripMenuItem.Image")));
            this.複製CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.複製CToolStripMenuItem.Name = "複製CToolStripMenuItem";
            this.複製CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.複製CToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.複製CToolStripMenuItem.Text = "複製(&C)";
            this.複製CToolStripMenuItem.Click += new System.EventHandler(this.複製CToolStripMenuItem_Click);
            // 
            // 貼上PToolStripMenuItem
            // 
            this.貼上PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("貼上PToolStripMenuItem.Image")));
            this.貼上PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼上PToolStripMenuItem.Name = "貼上PToolStripMenuItem";
            this.貼上PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼上PToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.貼上PToolStripMenuItem.Text = "貼上(&P)";
            this.貼上PToolStripMenuItem.Click += new System.EventHandler(this.貼上PToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(356, 6);
            // 
            // 全選AToolStripMenuItem
            // 
            this.全選AToolStripMenuItem.Name = "全選AToolStripMenuItem";
            this.全選AToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.全選AToolStripMenuItem.Text = "全選(&A)";
            this.全選AToolStripMenuItem.Click += new System.EventHandler(this.全選AToolStripMenuItem_Click);
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂CToolStripMenuItem,
            this.選項OToolStripMenuItem});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(110, 34);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 自訂CToolStripMenuItem
            // 
            this.自訂CToolStripMenuItem.Name = "自訂CToolStripMenuItem";
            this.自訂CToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.自訂CToolStripMenuItem.Text = "自訂(&C)";
            // 
            // 選項OToolStripMenuItem
            // 
            this.選項OToolStripMenuItem.Name = "選項OToolStripMenuItem";
            this.選項OToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.選項OToolStripMenuItem.Text = "選項(&O)";
            // 
            // 選項ToolStripMenuItem
            // 
            this.選項ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顏色CToolStripMenuItem,
            this.字型VToolStripMenuItem,
            this.轉成大寫,
            this.轉成小寫,
            this.自動換行,
            this.快選顏色});
            this.選項ToolStripMenuItem.Name = "選項ToolStripMenuItem";
            this.選項ToolStripMenuItem.Size = new System.Drawing.Size(120, 34);
            this.選項ToolStripMenuItem.Text = "格式(&M)";
            // 
            // 顏色CToolStripMenuItem
            // 
            this.顏色CToolStripMenuItem.Name = "顏色CToolStripMenuItem";
            this.顏色CToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.顏色CToolStripMenuItem.Text = "顏色(&C)";
            this.顏色CToolStripMenuItem.Click += new System.EventHandler(this.顏色CToolStripMenuItem_Click);
            // 
            // 字型VToolStripMenuItem
            // 
            this.字型VToolStripMenuItem.Name = "字型VToolStripMenuItem";
            this.字型VToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.字型VToolStripMenuItem.Text = "字型(&V)";
            this.字型VToolStripMenuItem.Click += new System.EventHandler(this.字型VToolStripMenuItem_Click);
            // 
            // 轉成大寫
            // 
            this.轉成大寫.Name = "轉成大寫";
            this.轉成大寫.Size = new System.Drawing.Size(359, 44);
            this.轉成大寫.Text = "To Upper(&U)";
            this.轉成大寫.Click += new System.EventHandler(this.轉成大寫_Click);
            // 
            // 轉成小寫
            // 
            this.轉成小寫.Name = "轉成小寫";
            this.轉成小寫.Size = new System.Drawing.Size(359, 44);
            this.轉成小寫.Text = "To Lower(&L)";
            this.轉成小寫.Click += new System.EventHandler(this.轉成小寫_Click);
            // 
            // 自動換行
            // 
            this.自動換行.Name = "自動換行";
            this.自動換行.Size = new System.Drawing.Size(359, 44);
            this.自動換行.Text = "自動換行";
            this.自動換行.Click += new System.EventHandler(this.自動換行_Click);
            // 
            // 快選顏色
            // 
            this.快選顏色.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.紅色,
            this.綠色,
            this.藍色,
            this.黑色});
            this.快選顏色.Name = "快選顏色";
            this.快選顏色.Size = new System.Drawing.Size(359, 44);
            this.快選顏色.Text = "快選顏色";
            // 
            // 紅色
            // 
            this.紅色.Name = "紅色";
            this.紅色.Size = new System.Drawing.Size(193, 44);
            this.紅色.Text = "紅色";
            this.紅色.Click += new System.EventHandler(this.紅色_Click);
            // 
            // 綠色
            // 
            this.綠色.Name = "綠色";
            this.綠色.Size = new System.Drawing.Size(193, 44);
            this.綠色.Text = "綠色";
            this.綠色.Click += new System.EventHandler(this.綠色_Click);
            // 
            // 藍色
            // 
            this.藍色.Name = "藍色";
            this.藍色.Size = new System.Drawing.Size(193, 44);
            this.藍色.Text = "藍色";
            this.藍色.Click += new System.EventHandler(this.藍色_Click);
            // 
            // 黑色
            // 
            this.黑色.Name = "黑色";
            this.黑色.Size = new System.Drawing.Size(193, 44);
            this.黑色.Text = "黑色";
            this.黑色.Click += new System.EventHandler(this.黑色_Click);
            // 
            // 說明HToolStripMenuItem
            // 
            this.說明HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.內容CToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜尋SToolStripMenuItem,
            this.toolStripSeparator5,
            this.關於});
            this.說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
            this.說明HToolStripMenuItem.Size = new System.Drawing.Size(115, 34);
            this.說明HToolStripMenuItem.Text = "說明(&H)";
            // 
            // 內容CToolStripMenuItem
            // 
            this.內容CToolStripMenuItem.Name = "內容CToolStripMenuItem";
            this.內容CToolStripMenuItem.Size = new System.Drawing.Size(244, 44);
            this.內容CToolStripMenuItem.Text = "內容(&C)";
            // 
            // 索引IToolStripMenuItem
            // 
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            this.索引IToolStripMenuItem.Size = new System.Drawing.Size(244, 44);
            this.索引IToolStripMenuItem.Text = "索引(&I)";
            // 
            // 搜尋SToolStripMenuItem
            // 
            this.搜尋SToolStripMenuItem.Name = "搜尋SToolStripMenuItem";
            this.搜尋SToolStripMenuItem.Size = new System.Drawing.Size(244, 44);
            this.搜尋SToolStripMenuItem.Text = "搜尋(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(241, 6);
            // 
            // 關於
            // 
            this.關於.Name = "關於";
            this.關於.Size = new System.Drawing.Size(244, 44);
            this.關於.Text = "關於(&A)...";
            this.關於.Click += new System.EventHandler(this.關於_Click);
            // 
            // 儲存檔案
            // 
            this.儲存檔案.Filter = "純文字檔案|*.txt";
            // 
            // 工具欄
            // 
            this.工具欄.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.工具欄.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增tool,
            this.開啟tool,
            this.儲存tool,
            this.列印PToolStripButton,
            this.toolStripSeparator6,
            this.剪下tool,
            this.複製tool,
            this.貼上tool,
            this.toolStripSeparator7,
            this.說明tool});
            this.工具欄.Location = new System.Drawing.Point(0, 48);
            this.工具欄.Name = "工具欄";
            this.工具欄.Size = new System.Drawing.Size(1454, 50);
            this.工具欄.TabIndex = 2;
            this.工具欄.Text = "toolStrip1";
            // 
            // 新增tool
            // 
            this.新增tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新增tool.Image = ((System.Drawing.Image)(resources.GetObject("新增tool.Image")));
            this.新增tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增tool.Name = "新增tool";
            this.新增tool.Size = new System.Drawing.Size(46, 36);
            this.新增tool.Text = "新增(&N)";
            this.新增tool.Click += new System.EventHandler(this.新增tool_Click);
            // 
            // 開啟tool
            // 
            this.開啟tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.開啟tool.Image = ((System.Drawing.Image)(resources.GetObject("開啟tool.Image")));
            this.開啟tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟tool.Name = "開啟tool";
            this.開啟tool.Size = new System.Drawing.Size(46, 36);
            this.開啟tool.Text = "開啟(&O)";
            this.開啟tool.Click += new System.EventHandler(this.開啟tool_Click);
            // 
            // 儲存tool
            // 
            this.儲存tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.儲存tool.Image = ((System.Drawing.Image)(resources.GetObject("儲存tool.Image")));
            this.儲存tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存tool.Name = "儲存tool";
            this.儲存tool.Size = new System.Drawing.Size(46, 36);
            this.儲存tool.Text = "儲存(&S)";
            this.儲存tool.Click += new System.EventHandler(this.儲存tool_Click);
            // 
            // 列印PToolStripButton
            // 
            this.列印PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.列印PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("列印PToolStripButton.Image")));
            this.列印PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.列印PToolStripButton.Name = "列印PToolStripButton";
            this.列印PToolStripButton.Size = new System.Drawing.Size(46, 36);
            this.列印PToolStripButton.Text = "列印(&P)";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 42);
            // 
            // 剪下tool
            // 
            this.剪下tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪下tool.Image = ((System.Drawing.Image)(resources.GetObject("剪下tool.Image")));
            this.剪下tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪下tool.Name = "剪下tool";
            this.剪下tool.Size = new System.Drawing.Size(46, 36);
            this.剪下tool.Text = "剪下(&U)";
            this.剪下tool.Click += new System.EventHandler(this.剪下tool_Click);
            // 
            // 複製tool
            // 
            this.複製tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.複製tool.Image = ((System.Drawing.Image)(resources.GetObject("複製tool.Image")));
            this.複製tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.複製tool.Name = "複製tool";
            this.複製tool.Size = new System.Drawing.Size(46, 36);
            this.複製tool.Text = "複製(&C)";
            this.複製tool.Click += new System.EventHandler(this.複製tool_Click);
            // 
            // 貼上tool
            // 
            this.貼上tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.貼上tool.Image = ((System.Drawing.Image)(resources.GetObject("貼上tool.Image")));
            this.貼上tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼上tool.Name = "貼上tool";
            this.貼上tool.Size = new System.Drawing.Size(46, 36);
            this.貼上tool.Text = "貼上(&P)";
            this.貼上tool.Click += new System.EventHandler(this.貼上tool_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 42);
            // 
            // 說明tool
            // 
            this.說明tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.說明tool.Image = ((System.Drawing.Image)(resources.GetObject("說明tool.Image")));
            this.說明tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.說明tool.Name = "說明tool";
            this.說明tool.Size = new System.Drawing.Size(46, 36);
            this.說明tool.Text = "說明(&L)";
            this.說明tool.Click += new System.EventHandler(this.說明tool_Click);
            // 
            // 時間
            // 
            this.時間.Enabled = true;
            this.時間.Interval = 1000;
            this.時間.Tick += new System.EventHandler(this.時間_Tick);
            // 
            // txtBox
            // 
            this.txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox.Location = new System.Drawing.Point(0, 98);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(1454, 783);
            this.txtBox.TabIndex = 3;
            this.txtBox.Text = "";
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // 狀態欄
            // 
            this.狀態欄.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.狀態欄.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.time});
            this.狀態欄.Location = new System.Drawing.Point(0, 859);
            this.狀態欄.Name = "狀態欄";
            this.狀態欄.Size = new System.Drawing.Size(1454, 22);
            this.狀態欄.TabIndex = 4;
            this.狀態欄.Text = "statusStrip1";
            // 
            // time
            // 
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 12);
            // 
            // 預覽列印
            // 
            this.預覽列印.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.預覽列印.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.預覽列印.ClientSize = new System.Drawing.Size(400, 300);
            this.預覽列印.Enabled = true;
            this.預覽列印.Icon = ((System.Drawing.Icon)(resources.GetObject("預覽列印.Icon")));
            this.預覽列印.Name = "預覽列印";
            this.預覽列印.Visible = false;
            // 
            // Frm_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 881);
            this.Controls.Add(this.狀態欄);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.工具欄);
            this.Controls.Add(this.工具列);
            this.MainMenuStrip = this.工具列;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_note";
            this.Text = "記事本";
            this.工具列.ResumeLayout(false);
            this.工具列.PerformLayout();
            this.工具欄.ResumeLayout(false);
            this.工具欄.PerformLayout();
            this.狀態欄.ResumeLayout(false);
            this.狀態欄.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip 工具列;
        private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 儲存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 列印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 預覽列印VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 結束XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 復原UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消復原RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 剪下TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 複製CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全選AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選項OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 內容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜尋SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 關於;
        private System.Windows.Forms.OpenFileDialog 開啟檔案;
        private System.Windows.Forms.SaveFileDialog 儲存檔案;
        private System.Windows.Forms.ToolStripMenuItem 選項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顏色CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 轉成大寫;
        private System.Windows.Forms.ToolStripMenuItem 轉成小寫;
        private System.Windows.Forms.ToolStripMenuItem 自動換行;
        private System.Windows.Forms.ToolStripMenuItem 快選顏色;
        private System.Windows.Forms.ToolStripMenuItem 紅色;
        private System.Windows.Forms.ToolStripMenuItem 綠色;
        private System.Windows.Forms.ToolStripMenuItem 藍色;
        private System.Windows.Forms.ToolStripMenuItem 黑色;
        private System.Windows.Forms.FontDialog 字型;
        private System.Windows.Forms.ColorDialog 顏色;
        private System.Windows.Forms.ToolStrip 工具欄;
        private System.Windows.Forms.ToolStripButton 新增tool;
        private System.Windows.Forms.ToolStripButton 開啟tool;
        private System.Windows.Forms.ToolStripButton 儲存tool;
        private System.Windows.Forms.ToolStripButton 列印PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton 剪下tool;
        private System.Windows.Forms.ToolStripButton 複製tool;
        private System.Windows.Forms.ToolStripButton 貼上tool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton 說明tool;
        private System.Windows.Forms.Timer 時間;
        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.StatusStrip 狀態欄;
        private System.Windows.Forms.ToolStripStatusLabel time;
        private System.Windows.Forms.PrintPreviewDialog 預覽列印;
    }
}