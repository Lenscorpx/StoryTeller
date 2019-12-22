namespace Storyteller
{
    partial class frm_garcons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nom_enfant = new System.Windows.Forms.TextBox();
            this.rtxt_histoire = new System.Windows.Forms.RichTextBox();
            this.btn_lire = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_effacer = new System.Windows.Forms.Button();
            this.cbx_voices = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Storyteller Boys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom de l\'enfant";
            // 
            // txt_nom_enfant
            // 
            this.txt_nom_enfant.BackColor = System.Drawing.Color.Black;
            this.txt_nom_enfant.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom_enfant.ForeColor = System.Drawing.Color.Red;
            this.txt_nom_enfant.Location = new System.Drawing.Point(178, 69);
            this.txt_nom_enfant.Name = "txt_nom_enfant";
            this.txt_nom_enfant.Size = new System.Drawing.Size(316, 32);
            this.txt_nom_enfant.TabIndex = 6;
            // 
            // rtxt_histoire
            // 
            this.rtxt_histoire.Location = new System.Drawing.Point(12, 116);
            this.rtxt_histoire.Name = "rtxt_histoire";
            this.rtxt_histoire.Size = new System.Drawing.Size(804, 373);
            this.rtxt_histoire.TabIndex = 7;
            this.rtxt_histoire.Text = "";
            // 
            // btn_lire
            // 
            this.btn_lire.Location = new System.Drawing.Point(509, 69);
            this.btn_lire.Name = "btn_lire";
            this.btn_lire.Size = new System.Drawing.Size(75, 32);
            this.btn_lire.TabIndex = 8;
            this.btn_lire.Text = "Lecture";
            this.btn_lire.UseVisualStyleBackColor = true;
            this.btn_lire.Click += new System.EventHandler(this.btn_lire_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(587, 69);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 32);
            this.btn_pause.TabIndex = 9;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(664, 69);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 32);
            this.btn_stop.TabIndex = 10;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_effacer
            // 
            this.btn_effacer.Location = new System.Drawing.Point(741, 69);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(75, 32);
            this.btn_effacer.TabIndex = 11;
            this.btn_effacer.Text = "Effacer";
            this.btn_effacer.UseVisualStyleBackColor = true;
            this.btn_effacer.Click += new System.EventHandler(this.btn_effacer_Click);
            // 
            // cbx_voices
            // 
            this.cbx_voices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_voices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_voices.FormattingEnabled = true;
            this.cbx_voices.Location = new System.Drawing.Point(587, 19);
            this.cbx_voices.Name = "cbx_voices";
            this.cbx_voices.Size = new System.Drawing.Size(229, 28);
            this.cbx_voices.TabIndex = 21;
            // 
            // frm_garcons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(828, 501);
            this.Controls.Add(this.cbx_voices);
            this.Controls.Add(this.btn_effacer);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_lire);
            this.Controls.Add(this.rtxt_histoire);
            this.Controls.Add(this.txt_nom_enfant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_garcons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storyteller Boys";
            this.Load += new System.EventHandler(this.frm_garcons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nom_enfant;
        private System.Windows.Forms.RichTextBox rtxt_histoire;
        private System.Windows.Forms.Button btn_lire;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_effacer;
        private System.Windows.Forms.ComboBox cbx_voices;
    }
}