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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeCallback();
        }

        private void InitializeCallback()
        {
            /* regist callback method */
            AddUserEventManager.SINGLETON.addUserEventHandler += SINGLETON_addUserEventHandler;
        }

        /* callback method */
        private void SINGLETON_addUserEventHandler(AddUserEventArgs args)
        {
            string name = args.name;
            string sex = args.sex;
            string phone = args.phone;
            string age = args.age;

            ListViewItem lvItem = new ListViewItem(new string[] { name, sex, age, phone });
            lv_userList.Items.Add(lvItem);
        }

        AddUserForm addUserForm = null;
        private void 유저추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(addUserForm == null)
            {
                addUserForm = new AddUserForm();
                addUserForm.FormClosed += AddUserForm_FormClosed;
                addUserForm.Show();
            }
        }

        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.addUserForm = null;
        }
    }
}
