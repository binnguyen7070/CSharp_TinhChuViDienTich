namespace CSharp_TinhChuViDienTich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dai = Convert.ToDouble(txtdai.Text);
            double rong = Convert.ToDouble(txtrong.Text);

            lbKQ.Text = "Dien tich = " + TinhDienTich(dai, rong) + Environment.NewLine + "Chu Vi = " + TinhChuVi(dai, rong);
        }
        private double TinhDienTich(double d, double r)
        {
            return d * r;
        }


        private double TinhChuVi(double d, double r)
        {
            return 2 * (d + r);
        }


    }
}
