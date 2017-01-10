using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AboutCallback
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string sex = tb_sex.Text;
            string age = tb_age.Text;
            string phone = tb_phone.Text;

            /* excute callback method */
            AddUserEventManager.SINGLETON.onAddUserEvent(new AddUserEventArgs(name, sex, age, phone));

            MessageBox.Show("유저를 등록하였습니다.");
        }
    }
}
