namespace rencalu
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            label4 = new Label();
            textBox1 = new TextBox();
            switch_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.renclau_low_resolution_logo_black_on_transparent_background___Copy;
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(294, 58);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 10;
            label4.Text = "Modifica adresa";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 97);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Adresa noua";
            textBox1.Size = new Size(302, 23);
            textBox1.TabIndex = 11;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // switch_btn
            // 
            switch_btn.Location = new Point(314, 137);
            switch_btn.Name = "switch_btn";
            switch_btn.Size = new Size(75, 23);
            switch_btn.TabIndex = 12;
            switch_btn.Text = "Modifica";
            switch_btn.UseVisualStyleBackColor = true;
            switch_btn.Click += switch_btn_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 218);
            Controls.Add(switch_btn);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label4;
        private TextBox textBox1;
        private Button switch_btn;
    }
}