using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxLightPainting2
{
    public partial class Form1 : Form
    {
        int intPictureHeight = 0;   //圖片原始高度
        int intPictureWidth = 0;   //圖片原始寬度
        double dblPbxPictureHeight = 0;   //圖片放在pbx的高度
        int intPbxPictureWidth = 0;   //圖片放在pbx的寬度
        double dblQuantity = 0;   //切片數量
        double dblMove = 0.0;   //pbx每層位移高度
        string strPictureLocationName;  //pbx檔案路徑含檔案名稱
        string strPictureLocation;  //pbx檔案路徑不含檔案名稱
        Graphics graPicture;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)   //匯入圖片
        {

            btnCalculationMenu.Visible = true;  //沒有匯入檔案前無法選計算功能
            BtnPictureMenu.Visible = true;  //沒有匯入檔案前無法選圖片功能

            OpenFileDialog ofDialog = new OpenFileDialog(); //匯入圖檔
            ofDialog.InitialDirectory = ".\\";
            ofDialog.Filter = "jpg files (*.*)|*.jpg";
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bm = new Bitmap(ofDialog.FileName);
                strPictureLocationName = ofDialog.FileName; //圖片路徑含檔名存入全域變數
                strPictureLocation = strPictureLocationName.Substring(0, strPictureLocationName.LastIndexOf("\\")); //圖片路徑名存入全域變數
                //Console.WriteLine(strPictureLocation);
                //Console.WriteLine("圖片路徑:" + strPictureLocationName);
                intPictureHeight = bm.Height;   //圖片原始高度存入全域變數
                intPictureWidth = bm.Width;   //圖片原始寬度存入全域變數
                
                if (intPictureHeight > 1200)
                {
                    MessageBox.Show("超過光塗鴉範圍，圖片高度請小於1200pixel", "圖片匯入失敗");
                    return;
                }
                
                pbxPicture.Image = new Bitmap(ofDialog.FileName);   //圖片放入PictureBox
                dblPbxPictureHeight = pbxPicture.Height;    //pbx的高放入全域變數
                intPbxPictureWidth = pbxPicture.Width;  //pbx的寬放入全域變數
                //Console.WriteLine("圖片放在pbx的高度:" + dblPbxPictureHeight);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)  //離開程式  
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);      
        }

        private void btnCut_Click(object sender, EventArgs e)   //預覽切割
        {
           
            double dblPbxMove = 0.0;    //pbx位移高度
            double dblPbxStartToEnd = 0.0;  //拿來跟上面加總用的
            CallQuantity(); //呼吸切片數量

            try
            {
                dblPbxMove = dblPbxPictureHeight / dblQuantity; //計算pbx位移高度
                //Console.WriteLine("pbx位移量:" + dblPbxMove);
            }
            catch (Exception)
            {
                return;
            }
         
            //Console.WriteLine("pbx位移高度:" + dblPbxMove);

            graPicture = pbxPicture.CreateGraphics();   //建立畫布
            Pen pLine = new Pen(Brushes.Red, 1);    //建立筆

            for (int i = 0; i < dblQuantity; i++)   //迴圈畫pbx的切割線
            {
                dblPbxStartToEnd += dblPbxMove;
                //Console.WriteLine(dblPbxStartToEnd);
                graPicture.DrawLine(pLine, 0, (float)dblPbxStartToEnd, intPbxPictureWidth, (float)dblPbxStartToEnd);
            }
            btnPbxClear.Visible = true; //切割線清除鈕顯示
        }

        private void btnCutSave_Click(object sender, EventArgs e)   //切割並儲存
        {
            double dblTenMove = 0.0;    //位移高度
            dblTenMove = dblMove * 10;  //，不知道為什麼之前把他乘0.1，所以再乘回來，懶的查原因了

            Bitmap bmPicture = new Bitmap(strPictureLocationName);    //來源圖片

            for (int i = 0; i < dblQuantity; i++)    //切片迴圈
            {
                Bitmap bmCutPicture = new Bitmap(intPictureWidth, (int)dblTenMove);   //建立切割底圖
                //Console.WriteLine("位移高度:" + (int)dblTenMove);
                Graphics graPicture = Graphics.FromImage(bmCutPicture);     //從切割底圖上建立畫板
                graPicture.DrawImage(bmPicture,                  //來源圖片
                         new Rectangle(0, 0, intPictureWidth, (int)dblTenMove),  //切割大小，前兩個數字是起始位置，後兩個數字是切割的寬高
                         new Rectangle(0, (int)dblTenMove * i, intPictureWidth, (int)dblTenMove), //切割來源圖片，前兩個數字是起始位置，後兩個數字是切割的寬高
                         GraphicsUnit.Pixel);   //測量單位Pixel
                int intPictureName = 1;
                intPictureName = (int)dblQuantity - i;
                bmCutPicture.Save(strPictureLocation + "\\" + "第" + intPictureName + "層" + ".jpg");    //儲存位置命名，從尾端開始命名回去
                graPicture.Dispose();
                bmCutPicture.Dispose();
            }          

        }

        private void btnCalculation_Click(object sender, EventArgs e)   //計算層高
        {
            lbxCalculation.Items.Clear();   //清空listbox
            CallQuantity(); //讀取切片數量
            double dblStartToEnd = 20.0;    //因為光塗壓底下多15mm，所以從20mm開始
            for (int i = 1; i <= dblQuantity; i++)  //計算原始圖片的層高並寫入lbx
            {
                dblStartToEnd += dblMove;
                string strPrintList = string.Format("第 {0:00} 層    物體高度 {1} mm", i, dblStartToEnd.ToString("#0.00"));
                lbxCalculation.Items.Add(strPrintList);
            }
        }

        private void CallQuantity()
        {
            try
            {
                if (tbxQuantity.Text == "" || tbxQuantity.Text == "0")  //切片數量防呆
                {
                    MessageBox.Show("請輸入切片數量", "切片數量輸入錯誤");
                    return;
                }
                else
                {
                    string strQuantity = "";
                    strQuantity = tbxQuantity.Text;
                    dblQuantity = Int32.Parse(strQuantity);
                    if (dblQuantity < 0)
                    {
                        MessageBox.Show("請輸入正整數，不要玩她", "切片數量輸入錯誤"); //切片數量防呆
                        return;
                    }
                    //Console.WriteLine("int切片數量:" + intQuantity);
                    dblMove = intPictureHeight / dblQuantity * 0.1;
                    //Console.WriteLine("dbl層高:" + dblMove);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("請輸入整數，不要玩她", "切片數量輸入錯誤");  //切片數量防呆
                return;
            }  
        }

        private void btnPbxClear_Click(object sender, EventArgs e)  //清除切割
        {
            graPicture.Clear(this.BackColor);
            graPicture.Dispose();
            pbxPicture.Image = new Bitmap(strPictureLocationName);
            btnPbxClear.Visible = false;
            lbxCalculation.Items.Clear();
        }

        private void btnInfo_Click(object sender, EventArgs e)  //關於程式
        {
            Form2 fm2 = new Form2();    //開form2
            fm2.ShowDialog();
        }
    }
}
