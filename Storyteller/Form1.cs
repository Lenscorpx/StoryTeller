using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Media;
namespace Storyteller
{
    public partial class frm_menu_principal : Form
    {
        public frm_menu_principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_garcons boy = new frm_garcons();
            boy.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frm_filles girls = new frm_filles();
            girls.Show();
        }

        private void frm_menu_principal_Load(object sender, EventArgs e)
        {

            SoundPlayer mediaplayer = new SoundPlayer() 
            { 
                SoundLocation = @"C:\Users\LensX\Desktop\Storyteller\Storyteller\Resources\106-sam_smith-writings_on_the_wall-1ndd.wav" 
            };
            mediaplayer.PlayLooping();
        }
    }
}
