using System.Windows.Forms;

namespace WPFUserControlWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            elementHost1.Child = new UserControl1();
        }
    }
}
