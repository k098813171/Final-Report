namespace ComicRentalSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage漫畫列表 = new System.Windows.Forms.TabPage();
            this.dataGridView漫畫 = new System.Windows.Forms.DataGridView();
            this.tabPage租借記錄 = new System.Windows.Forms.TabPage();
            this.dataGridView租借記錄 = new System.Windows.Forms.DataGridView();
            this.tabPage會員管理 = new System.Windows.Forms.TabPage();
            this.dataGridView會員 = new System.Windows.Forms.DataGridView();
            this.groupBox會員管理 = new System.Windows.Forms.GroupBox();
            this.btn刪除會員 = new System.Windows.Forms.Button();
            this.groupBox租借 = new System.Windows.Forms.GroupBox();
            this.txt客戶姓名 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn租借 = new System.Windows.Forms.Button();
            this.groupBox歸還 = new System.Windows.Forms.GroupBox();
            this.btn歸還 = new System.Windows.Forms.Button();
            this.groupBox添加漫畫 = new System.Windows.Forms.GroupBox();
            this.btn添加漫畫 = new System.Windows.Forms.Button();
            this.txt庫存 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt分類 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt作者 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt標題 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox搜尋 = new System.Windows.Forms.GroupBox();
            this.btn搜尋會員 = new System.Windows.Forms.Button();
            this.txt搜尋姓名 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.txt搜尋 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage漫畫列表.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView漫畫)).BeginInit();
            this.tabPage租借記錄.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView租借記錄)).BeginInit();
            this.tabPage會員管理.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView會員)).BeginInit();
            this.groupBox會員管理.SuspendLayout();
            this.groupBox租借.SuspendLayout();
            this.groupBox歸還.SuspendLayout();
            this.groupBox添加漫畫.SuspendLayout();
            this.groupBox搜尋.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage漫畫列表);
            this.tabControl1.Controls.Add(this.tabPage租借記錄);
            this.tabControl1.Controls.Add(this.tabPage會員管理);
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 400);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage漫畫列表
            // 
            this.tabPage漫畫列表.Controls.Add(this.dataGridView漫畫);
            this.tabPage漫畫列表.Location = new System.Drawing.Point(4, 25);
            this.tabPage漫畫列表.Name = "tabPage漫畫列表";
            this.tabPage漫畫列表.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage漫畫列表.Size = new System.Drawing.Size(692, 371);
            this.tabPage漫畫列表.TabIndex = 0;
            this.tabPage漫畫列表.Text = "漫畫列表";
            this.tabPage漫畫列表.UseVisualStyleBackColor = true;
            // 
            // dataGridView漫畫
            // 
            this.dataGridView漫畫.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView漫畫.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView漫畫.Location = new System.Drawing.Point(3, 3);
            this.dataGridView漫畫.Name = "dataGridView漫畫";
            this.dataGridView漫畫.Size = new System.Drawing.Size(686, 365);
            this.dataGridView漫畫.TabIndex = 0;
            // 
            // tabPage租借記錄
            // 
            this.tabPage租借記錄.Controls.Add(this.dataGridView租借記錄);
            this.tabPage租借記錄.Location = new System.Drawing.Point(4, 25);
            this.tabPage租借記錄.Name = "tabPage租借記錄";
            this.tabPage租借記錄.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage租借記錄.Size = new System.Drawing.Size(692, 371);
            this.tabPage租借記錄.TabIndex = 1;
            this.tabPage租借記錄.Text = "租借記錄";
            this.tabPage租借記錄.UseVisualStyleBackColor = true;
            // 
            // dataGridView租借記錄
            // 
            this.dataGridView租借記錄.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView租借記錄.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView租借記錄.Location = new System.Drawing.Point(3, 3);
            this.dataGridView租借記錄.Name = "dataGridView租借記錄";
            this.dataGridView租借記錄.Size = new System.Drawing.Size(686, 365);
            this.dataGridView租借記錄.TabIndex = 0;
            // 
            // tabPage會員管理
            // 
            this.tabPage會員管理.Controls.Add(this.dataGridView會員);
            this.tabPage會員管理.Controls.Add(this.groupBox會員管理);
            this.tabPage會員管理.Location = new System.Drawing.Point(4, 25);
            this.tabPage會員管理.Name = "tabPage會員管理";
            this.tabPage會員管理.Size = new System.Drawing.Size(692, 371);
            this.tabPage會員管理.TabIndex = 2;
            this.tabPage會員管理.Text = "會員管理";
            this.tabPage會員管理.UseVisualStyleBackColor = true;
            // 
            // dataGridView會員
            // 
            this.dataGridView會員.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView會員.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView會員.Location = new System.Drawing.Point(0, 0);
            this.dataGridView會員.Name = "dataGridView會員";
            this.dataGridView會員.Size = new System.Drawing.Size(692, 321);
            this.dataGridView會員.TabIndex = 0;
            // 
            // groupBox會員管理
            // 
            this.groupBox會員管理.Controls.Add(this.btn刪除會員);
            this.groupBox會員管理.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox會員管理.Location = new System.Drawing.Point(0, 321);
            this.groupBox會員管理.Name = "groupBox會員管理";
            this.groupBox會員管理.Size = new System.Drawing.Size(692, 50);
            this.groupBox會員管理.TabIndex = 1;
            this.groupBox會員管理.TabStop = false;
            this.groupBox會員管理.Text = "會員管理";
            // 
            // btn刪除會員
            // 
            this.btn刪除會員.Location = new System.Drawing.Point(600, 15);
            this.btn刪除會員.Name = "btn刪除會員";
            this.btn刪除會員.Size = new System.Drawing.Size(80, 30);
            this.btn刪除會員.TabIndex = 0;
            this.btn刪除會員.Text = "刪除會員";
            this.btn刪除會員.UseVisualStyleBackColor = true;
            this.btn刪除會員.Click += new System.EventHandler(this.btn刪除會員_Click);
            // 
            // groupBox租借
            // 
            this.groupBox租借.Controls.Add(this.txt客戶姓名);
            this.groupBox租借.Controls.Add(this.label1);
            this.groupBox租借.Controls.Add(this.btn租借);
            this.groupBox租借.Location = new System.Drawing.Point(730, 20);
            this.groupBox租借.Name = "groupBox租借";
            this.groupBox租借.Size = new System.Drawing.Size(250, 120);
            this.groupBox租借.TabIndex = 1;
            this.groupBox租借.TabStop = false;
            this.groupBox租借.Text = "租借漫畫";
            // 
            // txt客戶姓名
            // 
            this.txt客戶姓名.Location = new System.Drawing.Point(20, 40);
            this.txt客戶姓名.Name = "txt客戶姓名";
            this.txt客戶姓名.Size = new System.Drawing.Size(220, 23);
            this.txt客戶姓名.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "客戶姓名：";
            // 
            // btn租借
            // 
            this.btn租借.Location = new System.Drawing.Point(160, 80);
            this.btn租借.Name = "btn租借";
            this.btn租借.Size = new System.Drawing.Size(80, 30);
            this.btn租借.TabIndex = 0;
            this.btn租借.Text = "租借";
            this.btn租借.UseVisualStyleBackColor = true;
            this.btn租借.Click += new System.EventHandler(this.btn租借_Click);
            // 
            // groupBox歸還
            // 
            this.groupBox歸還.Controls.Add(this.btn歸還);
            this.groupBox歸還.Location = new System.Drawing.Point(730, 150);
            this.groupBox歸還.Name = "groupBox歸還";
            this.groupBox歸還.Size = new System.Drawing.Size(250, 80);
            this.groupBox歸還.TabIndex = 2;
            this.groupBox歸還.TabStop = false;
            this.groupBox歸還.Text = "歸還漫畫";
            // 
            // btn歸還
            // 
            this.btn歸還.Location = new System.Drawing.Point(160, 30);
            this.btn歸還.Name = "btn歸還";
            this.btn歸還.Size = new System.Drawing.Size(80, 30);
            this.btn歸還.TabIndex = 0;
            this.btn歸還.Text = "歸還";
            this.btn歸還.UseVisualStyleBackColor = true;
            this.btn歸還.Click += new System.EventHandler(this.btn歸還_Click);
            // 
            // groupBox添加漫畫
            // 
            this.groupBox添加漫畫.Controls.Add(this.btn添加漫畫);
            this.groupBox添加漫畫.Controls.Add(this.txt庫存);
            this.groupBox添加漫畫.Controls.Add(this.label5);
            this.groupBox添加漫畫.Controls.Add(this.txt分類);
            this.groupBox添加漫畫.Controls.Add(this.label4);
            this.groupBox添加漫畫.Controls.Add(this.txt作者);
            this.groupBox添加漫畫.Controls.Add(this.label3);
            this.groupBox添加漫畫.Controls.Add(this.txt標題);
            this.groupBox添加漫畫.Controls.Add(this.label2);
            this.groupBox添加漫畫.Location = new System.Drawing.Point(20, 430);
            this.groupBox添加漫畫.Name = "groupBox添加漫畫";
            this.groupBox添加漫畫.Size = new System.Drawing.Size(700, 100);
            this.groupBox添加漫畫.TabIndex = 3;
            this.groupBox添加漫畫.TabStop = false;
            this.groupBox添加漫畫.Text = "添加新漫畫";
            // 
            // btn添加漫畫
            // 
            this.btn添加漫畫.Location = new System.Drawing.Point(600, 64);
            this.btn添加漫畫.Name = "btn添加漫畫";
            this.btn添加漫畫.Size = new System.Drawing.Size(80, 30);
            this.btn添加漫畫.TabIndex = 8;
            this.btn添加漫畫.Text = "添加";
            this.btn添加漫畫.UseVisualStyleBackColor = true;
            this.btn添加漫畫.Click += new System.EventHandler(this.btn添加漫畫_Click);
            // 
            // txt庫存
            // 
            this.txt庫存.Location = new System.Drawing.Point(500, 40);
            this.txt庫存.Name = "txt庫存";
            this.txt庫存.Size = new System.Drawing.Size(80, 23);
            this.txt庫存.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "庫存:";
            // 
            // txt分類
            // 
            this.txt分類.Location = new System.Drawing.Point(350, 40);
            this.txt分類.Name = "txt分類";
            this.txt分類.Size = new System.Drawing.Size(140, 23);
            this.txt分類.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "分類:";
            // 
            // txt作者
            // 
            this.txt作者.Location = new System.Drawing.Point(180, 40);
            this.txt作者.Name = "txt作者";
            this.txt作者.Size = new System.Drawing.Size(160, 23);
            this.txt作者.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "作者:";
            // 
            // txt標題
            // 
            this.txt標題.Location = new System.Drawing.Point(20, 40);
            this.txt標題.Name = "txt標題";
            this.txt標題.Size = new System.Drawing.Size(150, 23);
            this.txt標題.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "標題:";
            // 
            // groupBox搜尋
            // 
            this.groupBox搜尋.Controls.Add(this.btn搜尋會員);
            this.groupBox搜尋.Controls.Add(this.txt搜尋姓名);
            this.groupBox搜尋.Controls.Add(this.label7);
            this.groupBox搜尋.Controls.Add(this.btn搜尋);
            this.groupBox搜尋.Controls.Add(this.txt搜尋);
            this.groupBox搜尋.Controls.Add(this.label6);
            this.groupBox搜尋.Location = new System.Drawing.Point(730, 240);
            this.groupBox搜尋.Name = "groupBox搜尋";
            this.groupBox搜尋.Size = new System.Drawing.Size(250, 180);
            this.groupBox搜尋.TabIndex = 4;
            this.groupBox搜尋.TabStop = false;
            this.groupBox搜尋.Text = "搜尋";
            // 
            // btn搜尋會員
            // 
            this.btn搜尋會員.Location = new System.Drawing.Point(160, 143);
            this.btn搜尋會員.Name = "btn搜尋會員";
            this.btn搜尋會員.Size = new System.Drawing.Size(80, 30);
            this.btn搜尋會員.TabIndex = 5;
            this.btn搜尋會員.Text = "搜尋會員";
            this.btn搜尋會員.UseVisualStyleBackColor = true;
            this.btn搜尋會員.Click += new System.EventHandler(this.btn搜尋會員_Click);
            // 
            // txt搜尋姓名
            // 
            this.txt搜尋姓名.Location = new System.Drawing.Point(20, 114);
            this.txt搜尋姓名.Name = "txt搜尋姓名";
            this.txt搜尋姓名.Size = new System.Drawing.Size(220, 23);
            this.txt搜尋姓名.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "搜尋姓名:";
            // 
            // btn搜尋
            // 
            this.btn搜尋.Location = new System.Drawing.Point(160, 73);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(80, 30);
            this.btn搜尋.TabIndex = 2;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = true;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // txt搜尋
            // 
            this.txt搜尋.Location = new System.Drawing.Point(20, 40);
            this.txt搜尋.Name = "txt搜尋";
            this.txt搜尋.Size = new System.Drawing.Size(220, 23);
            this.txt搜尋.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "搜尋關鍵字:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.groupBox搜尋);
            this.Controls.Add(this.groupBox添加漫畫);
            this.Controls.Add(this.groupBox歸還);
            this.Controls.Add(this.groupBox租借);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "漫畫租書及預約系統";
            this.tabControl1.ResumeLayout(false);
            this.tabPage漫畫列表.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView漫畫)).EndInit();
            this.tabPage租借記錄.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView租借記錄)).EndInit();
            this.tabPage會員管理.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView會員)).EndInit();
            this.groupBox會員管理.ResumeLayout(false);
            this.groupBox租借.ResumeLayout(false);
            this.groupBox租借.PerformLayout();
            this.groupBox歸還.ResumeLayout(false);
            this.groupBox添加漫畫.ResumeLayout(false);
            this.groupBox添加漫畫.PerformLayout();
            this.groupBox搜尋.ResumeLayout(false);
            this.groupBox搜尋.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage漫畫列表;
        private System.Windows.Forms.DataGridView dataGridView漫畫;
        private System.Windows.Forms.TabPage tabPage租借記錄;
        private System.Windows.Forms.DataGridView dataGridView租借記錄;
        private System.Windows.Forms.TabPage tabPage會員管理;
        private System.Windows.Forms.DataGridView dataGridView會員;
        private System.Windows.Forms.GroupBox groupBox會員管理;
        private System.Windows.Forms.Button btn刪除會員;
        private System.Windows.Forms.GroupBox groupBox租借;
        private System.Windows.Forms.TextBox txt客戶姓名;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn租借;
        private System.Windows.Forms.GroupBox groupBox歸還;
        private System.Windows.Forms.Button btn歸還;
        private System.Windows.Forms.GroupBox groupBox添加漫畫;
        private System.Windows.Forms.Button btn添加漫畫;
        private System.Windows.Forms.TextBox txt庫存;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt分類;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt作者;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt標題;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox搜尋;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.TextBox txt搜尋;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn搜尋會員;
        private System.Windows.Forms.TextBox txt搜尋姓名;
        private System.Windows.Forms.Label label7;
    }
}