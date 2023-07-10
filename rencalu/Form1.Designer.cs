namespace rencalu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            bt_cauta = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            copy = new Button();
            modifica = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(183, 70);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nr. telefon";
            textBox1.Size = new Size(336, 23);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // bt_cauta
            // 
            bt_cauta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bt_cauta.Location = new Point(266, 110);
            bt_cauta.Name = "bt_cauta";
            bt_cauta.Size = new Size(172, 37);
            bt_cauta.TabIndex = 1;
            bt_cauta.Text = "Cauta";
            bt_cauta.UseVisualStyleBackColor = true;
            bt_cauta.Click += bt_cauta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = renclau.Properties.Resources.renclau_low_resolution_logo_black_on_transparent_background___Copy;
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(248, 33);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 3;
            label1.Text = "Introdu numărul de telefon:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // copy
            // 
            copy.Location = new Point(183, 171);
            copy.Name = "copy";
            copy.Size = new Size(126, 23);
            copy.TabIndex = 4;
            copy.Text = "Copiaza baza de date";
            copy.UseVisualStyleBackColor = true;
            copy.Click += copy_Click;
            // 
            // modifica
            // 
            modifica.Location = new Point(391, 171);
            modifica.Name = "modifica";
            modifica.Size = new Size(128, 23);
            modifica.TabIndex = 5;
            modifica.Text = "Modifica adresa";
            modifica.UseVisualStyleBackColor = true;
            modifica.Click += modifica_Click;
            // 
            // Form1
            // 
            AcceptButton = bt_cauta;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 218);
            Controls.Add(modifica);
            Controls.Add(copy);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(bt_cauta);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Renclau";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button bt_cauta;
        private PictureBox pictureBox1;
        private Label label1;
        private Button copy;
        private Button modifica;
    }
}