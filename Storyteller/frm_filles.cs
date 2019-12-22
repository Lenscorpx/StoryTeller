using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace Storyteller
{
    
    public partial class frm_filles : Form
    {
        SpeechSynthesizer parole = new SpeechSynthesizer();
        public frm_filles()
        {
            InitializeComponent();
        }

        private void btn_lire_Click(object sender, EventArgs e)
        {
            parole.SelectVoice(cbx_voices.Text);
            parole.SpeakAsync("Salut" + txt_nom_enfant.Text + " moi c'est Hortense et je vais te raconter une histoire");
            parole.SpeakAsync("Sois attentif et ecoute");
            parole.SpeakAsync(rtxt_histoire.Text);
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            parole.SelectVoice(cbx_voices.Text);
            if(btn_pause.Text=="Pause")
            {
                parole.Pause();
                btn_pause.Text = "Reprendre";
            }
            else 
            {
                parole.Resume();
                btn_pause.Text = "Pause";
            }
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            parole.SelectVoice(cbx_voices.Text);
            parole.SpeakAsyncCancelAll();
        }

        private void btn_effacer_Click(object sender, EventArgs e)
        {
            rtxt_histoire.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_filles_Load(object sender, EventArgs e)
        {
            foreach (InstalledVoice une_voix in parole.GetInstalledVoices())
            {
                cbx_voices.Items.Add(une_voix.VoiceInfo.Name);
            }
        }
    }
}
