using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Project
{
    public partial class Join_Room_1 : Form
    {
        private Form childForm;
        public Join_Room_1()
        {
            InitializeComponent();
        }
        private void openForm(Form form)
        {
            if (childForm != null)
            {
                childForm.Close();
            }
            childForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            openForm(new Menu_Form());
        }

        private void Join_Room_1_Load(object sender, EventArgs e)
        {
            player_name_label.Text = DataContainer.player.PlayerName;
        }

        private void join_room_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string playerinfo = JsonConvert.SerializeObject(DataContainer.player);
                string req = "join_room, " + input_code_box.Text + ", " + playerinfo;
                byte[] send_data = Encoding.UTF8.GetBytes(req);
                DataContainer.ns.Write(send_data, 0, send_data.Length);

                while (DataContainer.response_msg == "") { }
                if (DataContainer.response_msg == "full")
                {
                    MessageBox.Show("The room is full!", "Error");
                    DataContainer.flush();
                    return;
                }
                else
                {
                    DataContainer.room = JsonConvert.DeserializeObject<Room>(DataContainer.response_msg);
                    DataContainer.player.RoomId = DataContainer.room.RoomId;
                    DataContainer.flush();
                }

                openForm(new Waiting_Room());
            }
            catch
            {
                MessageBox.Show("Wrong room's code!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void input_code_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
