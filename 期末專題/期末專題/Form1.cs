using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ComicRentalSystem
{
    public partial class Form1 : Form
    {
        private List<ComicBook> 漫畫列表 = new List<ComicBook>();
        private List<RentalRecord> 租借記錄 = new List<RentalRecord>();
        private List<Member> 會員列表 = new List<Member>();
        private Color 主色調 = Color.FromArgb(70, 130, 180);
        private Color 強調色 = Color.FromArgb(255, 165, 0);
        private const string 會員檔案 = "members.dat";
        private string 當前搜尋姓名 = "";
        private bool 在租借記錄頁面搜尋 = true;

        public Form1()
        {
            InitializeComponent();
            設定介面風格();
            初始化範例資料();
            載入會員資料();
            刷新漫畫列表();
            刷新租借記錄();
            刷新會員列表();
        }

        private void 設定介面風格()
        {
            this.BackColor = Color.White;

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(100, 30);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            btn租借.BackColor = 主色調;
            btn租借.ForeColor = Color.White;
            btn租借.FlatStyle = FlatStyle.Flat;
            btn租借.FlatAppearance.BorderSize = 0;

            btn歸還.BackColor = 主色調;
            btn歸還.ForeColor = Color.White;
            btn歸還.FlatStyle = FlatStyle.Flat;
            btn歸還.FlatAppearance.BorderSize = 0;

            btn添加漫畫.BackColor = 強調色;
            btn添加漫畫.ForeColor = Color.White;
            btn添加漫畫.FlatStyle = FlatStyle.Flat;
            btn添加漫畫.FlatAppearance.BorderSize = 0;

            btn搜尋.BackColor = 主色調;
            btn搜尋.ForeColor = Color.White;
            btn搜尋.FlatStyle = FlatStyle.Flat;
            btn搜尋.FlatAppearance.BorderSize = 0;

            btn刪除會員.BackColor = Color.FromArgb(220, 20, 60);
            btn刪除會員.ForeColor = Color.White;
            btn刪除會員.FlatStyle = FlatStyle.Flat;
            btn刪除會員.FlatAppearance.BorderSize = 0;

            btn搜尋會員.BackColor = 主色調;
            btn搜尋會員.ForeColor = Color.White;
            btn搜尋會員.FlatStyle = FlatStyle.Flat;
            btn搜尋會員.FlatAppearance.BorderSize = 0;

            foreach (Control c in this.Controls)
            {
                if (c is GroupBox)
                {
                    GroupBox gb = (GroupBox)c;
                    gb.ForeColor = 主色調;
                    gb.Font = new Font(gb.Font, FontStyle.Bold);
                }
            }

            dataGridView漫畫.BackgroundColor = Color.White;
            dataGridView漫畫.BorderStyle = BorderStyle.None;
            dataGridView漫畫.EnableHeadersVisualStyles = false;
            dataGridView漫畫.ColumnHeadersDefaultCellStyle.BackColor = 主色調;
            dataGridView漫畫.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView漫畫.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold);

            DataGridViewCheckBoxColumn 勾選欄位 = new DataGridViewCheckBoxColumn();
            勾選欄位.HeaderText = "選擇";
            勾選欄位.Name = "勾選欄位";
            dataGridView漫畫.Columns.Add(勾選欄位);
            dataGridView漫畫.Columns["勾選欄位"].DisplayIndex = 0;

            dataGridView租借記錄.BackgroundColor = Color.White;
            dataGridView租借記錄.BorderStyle = BorderStyle.None;
            dataGridView租借記錄.EnableHeadersVisualStyles = false;
            dataGridView租借記錄.ColumnHeadersDefaultCellStyle.BackColor = 主色調;
            dataGridView租借記錄.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView租借記錄.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold);

            DataGridViewCheckBoxColumn 租借勾選欄位 = new DataGridViewCheckBoxColumn();
            租借勾選欄位.HeaderText = "選擇";
            租借勾選欄位.Name = "租借勾選欄位";
            dataGridView租借記錄.Columns.Add(租借勾選欄位);
            dataGridView租借記錄.Columns["租借勾選欄位"].DisplayIndex = 0;

            dataGridView會員.BackgroundColor = Color.White;
            dataGridView會員.BorderStyle = BorderStyle.None;
            dataGridView會員.EnableHeadersVisualStyles = false;
            dataGridView會員.ColumnHeadersDefaultCellStyle.BackColor = 主色調;
            dataGridView會員.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView會員.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold);
        }

        private void 初始化範例資料()
        {
            漫畫列表.Add(new ComicBook("漫畫1", "作者1", "科技", 3));
            漫畫列表.Add(new ComicBook("漫畫2", "作者2", "懸疑", 2));
            租借記錄.Add(new RentalRecord("無", "無", "無", "無", DateTime.MinValue, DateTime.MinValue));
        }

        private void 載入會員資料()
        {
            if (File.Exists(會員檔案))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(會員檔案, FileMode.Open))
                    {
                        會員列表 = (List<Member>)formatter.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"載入會員資料失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void 儲存會員資料()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(會員檔案, FileMode.Create))
                {
                    formatter.Serialize(fs, 會員列表);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存會員資料失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 刷新漫畫列表()
        {
            Dictionary<string, bool> 勾選狀態 = new Dictionary<string, bool>();
            foreach (DataGridViewRow row in dataGridView漫畫.Rows)
            {
                if (row.Cells["勾選欄位"].Value != null)
                {
                    勾選狀態[row.Cells["標題"].Value.ToString()] = Convert.ToBoolean(row.Cells["勾選欄位"].Value);
                }
            }

            dataGridView漫畫.DataSource = null;
            dataGridView漫畫.DataSource = 漫畫列表;

            if (!dataGridView漫畫.Columns.Contains("勾選欄位"))
            {
                DataGridViewCheckBoxColumn 勾選欄位 = new DataGridViewCheckBoxColumn();
                勾選欄位.HeaderText = "選擇";
                勾選欄位.Name = "勾選欄位";
                dataGridView漫畫.Columns.Add(勾選欄位);
            }
            dataGridView漫畫.Columns["勾選欄位"].DisplayIndex = 0;

            foreach (DataGridViewRow row in dataGridView漫畫.Rows)
            {
                string 標題 = row.Cells["標題"].Value.ToString();
                if (勾選狀態.ContainsKey(標題))
                {
                    row.Cells["勾選欄位"].Value = 勾選狀態[標題];
                }
            }

            dataGridView漫畫.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void 刷新租借記錄()
        {
            Dictionary<string, bool> 勾選狀態 = new Dictionary<string, bool>();
            foreach (DataGridViewRow row in dataGridView租借記錄.Rows)
            {
                if (row.Cells["租借勾選欄位"].Value != null && row.Cells["漫畫標題"].Value != null)
                {
                    勾選狀態[row.Cells["漫畫標題"].Value.ToString()] = Convert.ToBoolean(row.Cells["租借勾選欄位"].Value);
                }
            }

            List<RentalRecord> 顯示的記錄;
            if (string.IsNullOrEmpty(當前搜尋姓名) || !在租借記錄頁面搜尋)
            {
                顯示的記錄 = 租借記錄;
            }
            else
            {
                顯示的記錄 = 租借記錄.FindAll(r =>
                    r.客戶姓名.ToLower().Contains(當前搜尋姓名.ToLower()) &&
                    r.漫畫標題 != "無");
            }

            dataGridView租借記錄.DataSource = null;
            dataGridView租借記錄.DataSource = 顯示的記錄;

            if (!dataGridView租借記錄.Columns.Contains("租借勾選欄位"))
            {
                DataGridViewCheckBoxColumn 租借勾選欄位 = new DataGridViewCheckBoxColumn();
                租借勾選欄位.HeaderText = "選擇";
                租借勾選欄位.Name = "租借勾選欄位";
                dataGridView租借記錄.Columns.Add(租借勾選欄位);
            }
            dataGridView租借記錄.Columns["租借勾選欄位"].DisplayIndex = 0;

            foreach (DataGridViewRow row in dataGridView租借記錄.Rows)
            {
                if (row.Cells["漫畫標題"].Value != null)
                {
                    string 標題 = row.Cells["漫畫標題"].Value.ToString();
                    if (勾選狀態.ContainsKey(標題))
                    {
                        row.Cells["租借勾選欄位"].Value = 勾選狀態[標題];
                    }

                    if (標題 == "無")
                    {
                        if (dataGridView租借記錄.Columns.Contains("租借日期"))
                            row.Cells["租借日期"].Value = "";
                        if (dataGridView租借記錄.Columns.Contains("應還日期"))
                            row.Cells["應還日期"].Value = "";
                    }
                }
            }

            dataGridView租借記錄.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (dataGridView租借記錄.Columns.Contains("租借日期"))
                dataGridView租借記錄.Columns["租借日期"].Width = 150;
            if (dataGridView租借記錄.Columns.Contains("應還日期"))
                dataGridView租借記錄.Columns["應還日期"].Width = 150;
        }

        private void 刷新會員列表()
        {
            List<Member> 顯示的會員;
            if (string.IsNullOrEmpty(當前搜尋姓名) || 在租借記錄頁面搜尋)
            {
                顯示的會員 = 會員列表;
            }
            else
            {
                顯示的會員 = 會員列表.FindAll(m =>
                    m.姓名.ToLower().Contains(當前搜尋姓名.ToLower()));
            }

            dataGridView會員.DataSource = null;
            dataGridView會員.DataSource = 顯示的會員;
            dataGridView會員.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn租借_Click(object sender, EventArgs e)
        {
            string 客戶姓名 = txt客戶姓名.Text.Trim();

            if (string.IsNullOrEmpty(客戶姓名))
            {
                MessageBox.Show("請輸入客戶姓名！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var 現有會員 = 會員列表.FirstOrDefault(m => m.姓名.Equals(客戶姓名, StringComparison.OrdinalIgnoreCase));

            if (現有會員 == null)
            {
                var 註冊視窗 = new 會員註冊視窗(客戶姓名);
                if (註冊視窗.ShowDialog() == DialogResult.OK)
                {
                    會員列表.Add(new Member(註冊視窗.會員姓名, 註冊視窗.會員信箱, 註冊視窗.會員電話));
                    現有會員 = 會員列表.Last();
                    儲存會員資料();
                    刷新會員列表();
                }
                else
                {
                    return;
                }
            }

            List<ComicBook> 選擇的漫畫列表 = new List<ComicBook>();
            foreach (DataGridViewRow row in dataGridView漫畫.Rows)
            {
                if (row.Cells["勾選欄位"].Value != null && Convert.ToBoolean(row.Cells["勾選欄位"].Value))
                {
                    var 漫畫 = (ComicBook)row.DataBoundItem;
                    if (漫畫.庫存 <= 0)
                    {
                        MessageBox.Show($"漫畫 {漫畫.標題} 庫存不足，無法租借！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    選擇的漫畫列表.Add(漫畫);
                }
            }

            if (選擇的漫畫列表.Count == 0)
            {
                MessageBox.Show("請至少勾選一本要租借的漫畫！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (租借記錄.Count == 1 && 租借記錄[0].漫畫標題 == "無")
            {
                租借記錄.RemoveAt(0);
            }

            string 租借的漫畫列表 = "";
            foreach (var 漫畫 in 選擇的漫畫列表)
            {
                漫畫.庫存--;
                租借記錄.Add(new RentalRecord(
                    漫畫.標題,
                    現有會員.姓名,
                    現有會員.電子郵件,
                    現有會員.電話,
                    DateTime.Now,
                    DateTime.Now.AddDays(7)
                ));
                租借的漫畫列表 += $"{漫畫.標題}, ";

                foreach (DataGridViewRow row in dataGridView漫畫.Rows)
                {
                    if (((ComicBook)row.DataBoundItem).標題 == 漫畫.標題)
                    {
                        row.Cells["勾選欄位"].Value = false;
                    }
                }
            }
            租借的漫畫列表 = 租借的漫畫列表.TrimEnd(',', ' ');

            刷新漫畫列表();
            刷新租借記錄();
            MessageBox.Show($"{現有會員.姓名} 已成功租借以下漫畫:\n{租借的漫畫列表}", "租借成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt客戶姓名.Clear();
        }

        private void btn歸還_Click(object sender, EventArgs e)
        {
            List<RentalRecord> 選擇的記錄列表 = new List<RentalRecord>();

            foreach (DataGridViewRow row in dataGridView租借記錄.Rows)
            {
                if (row.Cells["租借勾選欄位"].Value != null &&
                    Convert.ToBoolean(row.Cells["租借勾選欄位"].Value) &&
                    row.DataBoundItem != null)
                {
                    var 記錄 = (RentalRecord)row.DataBoundItem;
                    if (記錄.漫畫標題 != "無")
                    {
                        選擇的記錄列表.Add(記錄);
                    }
                }
            }

            if (選擇的記錄列表.Count == 0)
            {
                MessageBox.Show("請至少勾選一筆要歸還的記錄！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string 歸還的漫畫列表 = "";
            foreach (var 記錄 in 選擇的記錄列表)
            {
                var 漫畫 = 漫畫列表.Find(c => c.標題 == 記錄.漫畫標題);
                if (漫畫 != null)
                {
                    漫畫.庫存++;
                    租借記錄.Remove(記錄);
                    歸還的漫畫列表 += $"{記錄.漫畫標題}, ";
                }
            }

            if (租借記錄.Count == 0)
            {
                租借記錄.Add(new RentalRecord("無", "無", "無", "無", DateTime.MinValue, DateTime.MinValue));
            }

            刷新漫畫列表();
            刷新租借記錄();
            MessageBox.Show($"已成功歸還以下漫畫:\n{歸還的漫畫列表.TrimEnd(',', ' ')}", "歸還成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn搜尋會員_Click(object sender, EventArgs e)
        {
            當前搜尋姓名 = txt搜尋姓名.Text.Trim();
            在租借記錄頁面搜尋 = (tabControl1.SelectedTab == tabPage租借記錄);
            刷新租借記錄();
            刷新會員列表();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            在租借記錄頁面搜尋 = (tabControl1.SelectedTab == tabPage租借記錄);
            刷新租借記錄();
            刷新會員列表();
        }

        private void btn刪除會員_Click(object sender, EventArgs e)
        {
            if (dataGridView會員.SelectedRows.Count > 0)
            {
                var 選擇的會員 = (Member)dataGridView會員.SelectedRows[0].DataBoundItem;

                bool 有未歸還 = 租借記錄.Any(r =>
                    r.客戶姓名 == 選擇的會員.姓名 &&
                    r.漫畫標題 != "無");

                if (有未歸還)
                {
                    MessageBox.Show("此會員尚有未歸還的漫畫，無法刪除！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var 確認結果 = MessageBox.Show($"確定要刪除會員 {選擇的會員.姓名} 嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (確認結果 == DialogResult.Yes)
                {
                    會員列表.Remove(選擇的會員);
                    儲存會員資料();
                    刷新會員列表();
                    MessageBox.Show("會員已刪除！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除的會員！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn添加漫畫_Click(object sender, EventArgs e)
        {
            string 標題 = txt標題.Text;
            string 作者 = txt作者.Text;
            string 分類 = txt分類.Text;

            if (!string.IsNullOrEmpty(標題) && !string.IsNullOrEmpty(作者) && !string.IsNullOrEmpty(分類))
            {
                if (int.TryParse(txt庫存.Text, out int 庫存) && 庫存 > 0)
                {
                    漫畫列表.Add(new ComicBook(標題, 作者, 分類, 庫存));
                    刷新漫畫列表();
                    清除添加漫畫欄位();
                    MessageBox.Show("漫畫已成功添加！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("請輸入有效的庫存數量（必須大於0）！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請填寫所有必填欄位！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 清除添加漫畫欄位()
        {
            txt標題.Clear();
            txt作者.Clear();
            txt分類.Clear();
            txt庫存.Clear();
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {
            string 搜尋關鍵字 = txt搜尋.Text.ToLower();

            if (!string.IsNullOrEmpty(搜尋關鍵字))
            {
                var 篩選後的漫畫 = 漫畫列表.FindAll(c =>
                    c.標題.ToLower().Contains(搜尋關鍵字) ||
                    c.作者.ToLower().Contains(搜尋關鍵字) ||
                    c.分類.ToLower().Contains(搜尋關鍵字));

                dataGridView漫畫.DataSource = null;
                dataGridView漫畫.DataSource = 篩選後的漫畫;
            }
            else
            {
                刷新漫畫列表();
            }
        }

        [Serializable]
        public class ComicBook
        {
            public string 標題 { get; set; }
            public string 作者 { get; set; }
            public string 分類 { get; set; }
            public int 庫存 { get; set; }

            public ComicBook(string 標題, string 作者, string 分類, int 庫存)
            {
                this.標題 = 標題;
                this.作者 = 作者;
                this.分類 = 分類;
                this.庫存 = 庫存;
            }
        }

        [Serializable]
        public class RentalRecord
        {
            public string 漫畫標題 { get; set; }
            public string 客戶姓名 { get; set; }
            public string 客戶信箱 { get; set; }
            public string 客戶電話 { get; set; }
            public DateTime 租借日期 { get; set; }
            public DateTime 應還日期 { get; set; }

            public RentalRecord(string 漫畫標題, string 客戶姓名, string 客戶信箱, string 客戶電話, DateTime 租借日期, DateTime 應還日期)
            {
                this.漫畫標題 = 漫畫標題;
                this.客戶姓名 = 客戶姓名;
                this.客戶信箱 = 客戶信箱;
                this.客戶電話 = 客戶電話;
                this.租借日期 = 租借日期;
                this.應還日期 = 應還日期;
            }
        }

        [Serializable]
        public class Member
        {
            public string 姓名 { get; set; }
            public string 電子郵件 { get; set; }
            public string 電話 { get; set; }

            public Member(string 姓名, string 電子郵件, string 電話)
            {
                this.姓名 = 姓名;
                this.電子郵件 = 電子郵件;
                this.電話 = 電話;
            }
        }
    }

    public class 會員註冊視窗 : Form
    {
        public string 會員姓名 { get; private set; }
        public string 會員信箱 { get; private set; }
        public string 會員電話 { get; private set; }

        private TextBox txt姓名;
        private TextBox txt信箱;
        private TextBox txt電話;
        private Button btn確認;
        private Button btn取消;

        public 會員註冊視窗(string 預設姓名)
        {
            this.Text = "會員註冊";
            this.Size = new Size(350, 250);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lbl姓名 = new Label();
            lbl姓名.Text = "姓名:";
            lbl姓名.Location = new Point(20, 20);
            lbl姓名.Width = 80;
            this.Controls.Add(lbl姓名);

            txt姓名 = new TextBox();
            txt姓名.Location = new Point(100, 20);
            txt姓名.Width = 200;
            txt姓名.Text = 預設姓名;
            this.Controls.Add(txt姓名);

            Label lbl信箱 = new Label();
            lbl信箱.Text = "電子郵件:";
            lbl信箱.Location = new Point(20, 60);
            lbl信箱.Width = 80;
            this.Controls.Add(lbl信箱);

            txt信箱 = new TextBox();
            txt信箱.Location = new Point(100, 60);
            txt信箱.Width = 200;
            this.Controls.Add(txt信箱);

            Label lbl電話 = new Label();
            lbl電話.Text = "電話:";
            lbl電話.Location = new Point(20, 100);
            lbl電話.Width = 80;
            this.Controls.Add(lbl電話);

            txt電話 = new TextBox();
            txt電話.Location = new Point(100, 100);
            txt電話.Width = 200;
            this.Controls.Add(txt電話);

            btn確認 = new Button();
            btn確認.Text = "確認";
            btn確認.Location = new Point(100, 150);
            btn確認.Width = 80;
            btn確認.DialogResult = DialogResult.OK;
            btn確認.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt姓名.Text))
                {
                    MessageBox.Show("請輸入姓名！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                會員姓名 = txt姓名.Text.Trim();
                會員信箱 = txt信箱.Text.Trim();
                會員電話 = txt電話.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
            this.Controls.Add(btn確認);

            btn取消 = new Button();
            btn取消.Text = "取消";
            btn取消.Location = new Point(200, 150);
            btn取消.Width = 80;
            btn取消.DialogResult = DialogResult.Cancel;
            this.Controls.Add(btn取消);

            this.AcceptButton = btn確認;
            this.CancelButton = btn取消;
        }
    }
}