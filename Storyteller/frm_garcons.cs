using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;//cette ligne nous permet de faire reference a la parole incluse par defaut dans notre version de Windows
using System.Speech.Synthesis;// cette ligne ici, nous permet de preciser quel type de parole nous allons utiliser, dans ce cas c'est la synthese du texte en parole

namespace Storyteller
{
    public partial class frm_garcons : Form
    {
        SpeechSynthesizer parole = new SpeechSynthesizer();// cette lligne nous permet de declarer un terme qui fera appel a la parole tout au long de notre code
        public frm_garcons()
        {
            InitializeComponent();
        }

        private void frm_garcons_Load(object sender, EventArgs e)
        {
            foreach (InstalledVoice une_voix in parole.GetInstalledVoices())
            {
                cbx_voices.Items.Add(une_voix.VoiceInfo.Name);
            }
        }

        private void btn_lire_Click(object sender, EventArgs e)
        {
            parole.SelectVoice(cbx_voices.Text);
            parole.SpeakAsync("Salut" + txt_nom_enfant.Text + " moi c'est Hortense et je vais te raconter une histoire");//ici on utilise le mot "parole" que nous avons declare ci haut pour permettre a la machine de transformer le texte en parole 
            parole.SpeakAsync("Sois attentif et ecoute");
            parole.SpeakAsync(rtxt_histoire.Text);//ici la machine transforme tout ce qui est ecri dans le richtextbox en parole.
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            parole.SelectVoice(cbx_voices.Text);
            if (btn_pause.Text == "Pause")//ici nous mettons une condition, pour reconnaitre soit la pause, soit la reprise de la parole
            {
                parole.Pause();//cette ligne nous permet de mettre une pause dans notre speech
                btn_pause.Text = "Reprendre";
            }
            else
            {
                parole.Resume();//cette ligne nous permet de reprendre le speech qui a ete mis en pause
                btn_pause.Text = "Pause";
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            parole.SpeakAsyncCancelAll();//cette ligne stoppe la lecture, en cas de reprise la lecture recommence du debut
        }

        private void btn_effacer_Click(object sender, EventArgs e)
        {
            rtxt_histoire.Clear();//cette ligne efface le contenu du richtextbox contenant l'histoire
        }
    }
}
