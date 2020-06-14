using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public static byte[,] a = new byte[9, 9];
        public static byte count;
        public static int kq = 0;
        OpenFileDialog op;
        public Form1()
        {
            InitializeComponent();
        }
        private void PaintArea(DataGridView dgv)
        {
            for (byte i = 3; i < 6; i++) dgv.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
            for (byte i = 3; i < 6; i++) dgv.Columns[i].DefaultCellStyle.BackColor = Color.LightGray;
            DataGridViewCellStyle st = new DataGridViewCellStyle { BackColor = Color.White };
            for (byte i = 3; i < 6; i++)
                for (byte j = 3; j < 6; j++) dgv.Rows[i].Cells[j].Style = st;
        }
        private void MakeRed()
        {
            for (byte i = 0; i < 9; i++)
                    for (byte j = 0; j < 9; j++)
                    {
                        DataGridViewCellStyle rs = new DataGridViewCellStyle {ForeColor = Color.Red};
                        if (i > 2 && i < 6 && j > 2 && j < 6) rs.BackColor = Color.White;
                        if (Convert.ToInt32(InputData.Rows[i].Cells[j].Value)==0)
                            OutputData.Rows[i].Cells[j].Style = rs;
                    }
        }
        public DataTable Conv()
        {
            DataTable dt = new DataTable();
            for (byte i = 0; i < 9; i++) { dt.Columns.Add(i.ToString()); }
            for (byte i = 0; i < 9; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < 9; j++) { dr[j] = a[i, j]; }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        private bool CheckErr()
        {
            for (byte i = 0; i < 9; i++)
            {
                bool[] hang = new bool[10];
                bool[] cot = new bool[10];
                for (byte zz = 0; zz < 10; zz++)
                {
                    hang[zz] = false;
                    cot[zz]=false;
                 }
                for (byte j=0;j<9;j++)
                {
                    if (hang[a[i, j]] && a[i,j]!=0)
                    {
                        MessageBox.Show("Trùng giá trị :" + a[i, j] + " trên hàng " + (i + 1), "Check Message");
                        return false;
                    }
                    else hang[a[i, j]] = true;
                    if (cot[a[j, i]] && a[j,i]!=0)
                    {
                        MessageBox.Show("Trùng giá trị :" + a[j, i] + " trên cột " + (i + 1), "Check Message");
                        return false;
                    }
                    else cot[a[j, i]] = true;
                }
            }
            for (byte i = 0; i <= 6; i += 3)
                for (byte j = 0; j <= 6; j += 3)
                {
                    bool[] num = new bool[10];
                    for (byte zz = 0; zz < 10; zz++) num[zz] = false;
                    for (byte k = i; k < i + 3; k++)
                        for (byte l = j; l < j + 3; l++)
                            if (num[a[k,l]] && a[k,l]!=0)
                            {
                                MessageBox.Show("Trùng giá trị :" + a[k, l].ToString() + " tại khối " + (i + 1) + "," + (j + 1),"Check Message");
                                return false;
                            }
                            else num[a[k, l]]=true;
                }
            return true;
        }        
        private void Preprocess()
        {            
            bool fl;
            do
            {
                fl = false;
                for (byte i = 0; i < 9; i++)
                    for (byte j = 0; j < 9; j++)
                    {
                        if (a[i, j] == 0)
                        {
                            bool[] num = new bool[10];
                            for (byte z = 1; z < 10; z++) num[z] = true;
                            for (byte k = 0; k < 9; k++)
                            {
                                num[a[i, k]] = false;
                                num[a[k, j]] = false;
                            }
                            int vt1 = (i / 3); vt1 *= 3;
                            int vt2 = (j / 3); vt2 *= 3;
                            for (int k1 = vt1; k1 < vt1 + 3; k1++)
                                for (int k2 = vt2; k2 < vt2 + 3; k2++)
                                    num[a[k1, k2]] = false;
                            byte dem = 0, gt = 0;
                            for (byte k = 1; k <= 9; k++)
                            {
                                if (num[k])
                                {
                                    dem++;
                                    gt = k;
                                }
                            }
                            if (dem == 1)
                            {
                                MessageBox.Show("Chọn " + gt + " tại vị trí [" + (i + 1) +","+ (j + 1)+"]!","Preprocess");
                                a[i, j] = gt;
                                InputData.Rows[i].Cells[j].Value = gt;
                                InputData.Rows[i].Cells[j].Style.ForeColor = Color.Gray;
                                fl = true;
                            }
                        }
                    }
            }
            while (fl == true);
            if (!fl) MessageBox.Show("Không thể chọn thêm giá trị!","Preprocess");
        }        
        private byte Space()
        {
            byte t = 0;
            for (byte i = 0; i < 9; i++)
                for (byte j = 0; j < 9; j++) if (a[i, j] == 0) t++;
            return t;
        }
        private bool Check(int x, int y, int v)
        {
            for (int i = 0; i < 9; i++)
                if ((a[x,i] == v) || (a[i,y] == v)) return false;
            int k1 = (x / 3) * 3;
            int k2 = (y / 3) * 3;
            for (int i = k1; i < k1 + 3; i++)
                for (int j = k2; j < k2 + 3; j++)
                    if (a[i,j] == v) return false;
            return true;
        }
        private void Findcor(ref int x, ref int y)
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (a[i, j] == 0)
                    {
                        x = i; y = j;
                        return;
                    }
        }
        private void Backtracking(int tick)
        {
            if (tick==0)
            {                
                kq++;
                if (kq > 1) return;
                OutputData.DataSource = Conv();
                PaintArea(OutputData);
                MakeRed();
                OutputData.ClearSelection();
                SaveResult();
                return;
            }
            int x=0, y=0;
            Findcor(ref x,ref y);

            for (byte i = 1; i <= 9; i++)
                if (Check(x, y, i))
                {
                    a[x,y] = i;
                    if (kq<=1) Backtracking(tick - 1);
                    a[x,y] = 0;
                }
        }
        private void Executebtn_Click(object sender, EventArgs e)
        {
            kq = 0;
            if (CheckErr())
            {
                count = Space();
                Backtracking(count);
            }
            else MessageBox.Show("Test đầu vào lỗi!!","Kết quả");
            if (kq == 0) MessageBox.Show("Bài toán không có lời giải!!","Kết quả");
            else if (kq > 1) MessageBox.Show("Bài toán có nhiều lời giải, 1 lời giải đã được lưu lại.","Kết quả");            
            return;
        }
        private void Changebtn_Click(object sender, EventArgs e){InputData.ReadOnly = false;}        
        private void Prebtn_Click(object sender, EventArgs e)
        {
            if (CheckErr()) Preprocess();
        }
        private void Checkbtn_Click(object sender, EventArgs e)
        {
            if (CheckErr()) MessageBox.Show("Test đầu vào không có lỗi, sẵn sàng thực hiện.","Check Message");
            else MessageBox.Show("Test đầu vào lỗi!!","Check Message");
        }
        private void InputData_EndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int ri = e.RowIndex, ci = e.ColumnIndex;
            MessageBox.Show("Thay đổi giá trị tại [" + (ri + 1) + "," + (ci + 1) + "]","Value Changed");            
            if (InputData.Rows[ri].Cells[ci].Value.ToString() == "") InputData.Rows[ri].Cells[ci].Value = 0;            
            int gt = Convert.ToInt32(InputData.Rows[ri].Cells[ci].Value);
            if (gt < 0 || gt > 9)
            {
                MessageBox.Show("Lỗi nhập giá trị!","Lỗi");
                InputData.Rows[ri].Cells[ci].Value = 0;
            } 
            a[ri, ci] = Convert.ToByte(InputData.Rows[ri].Cells[ci].Value);
            Prebtn.Enabled = true;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            op.ShowDialog();            
            MessageBox.Show("Open " + op.FileName);
            string[] lines = File.ReadAllLines(op.FileName);
            bool ok = true;
            for (byte i = 0; i < lines.Length; i++)
            {
                lines[i].Trim();
                string[] gtt = lines[i].Split(' ');                
                if (gtt.Length != 9) ok=false;
                int k;
                for (byte j = 0; j < gtt.Length; j++)
                {
                    if (Int32.TryParse(gtt[j], out k))
                    {
                        if (k > 9 || k < 0) ok = false;                        
                        if (ok) a[i, j] = (byte)k;
                    }
                    else ok = false;
                }
            }
            if (ok)
            {
                InputData.DataSource = Conv();
                PaintArea(InputData);
                Prebtn.Enabled = true;
                Checkbtn.Enabled = true;
            }
            else MessageBox.Show("Không thể nhập file Input", "Lỗi định dạng");
        }
        private void SaveResult()
        {
            string[] write = new string[9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    write[i] = write[i] + " " + a[i, j].ToString();            
            string path = op.FileName;
            path=path.Replace("input", "output");
            //path = path + @"\output.txt";
            File.WriteAllLines(path, write);
            MessageBox.Show("Đã lưu kết quả vào file " + path,"Save file successful");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < 9; i++)
                for (byte j = 0; j < 9; j++) a[i, j] = 0;
            InputData.DataSource = Conv();
            InputData.ReadOnly = false;
            PaintArea(InputData);
            Checkbtn.Enabled=true;
            Prebtn.Enabled = true;
            op = new OpenFileDialog();
            op.FileName = Directory.GetCurrentDirectory();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form aa = new HuongDan();
            aa.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ab = new About();
            ab.Show();
        }
    }
}