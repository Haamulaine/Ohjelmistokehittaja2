namespace Harjoitus_4
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
            dateTimePicker1 = new DateTimePicker();
            TulosTB = new Button();
            VuodetTB = new Label();
            KuutTB = new Label();
            PaivatTB = new Label();
            TunnitTB = new Label();
            MinuutitTB = new Label();
            SekunnitTB = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(18, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(347, 35);
            dateTimePicker1.TabIndex = 0;
            // 
            // TulosTB
            // 
            TulosTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TulosTB.Location = new Point(403, 37);
            TulosTB.Name = "TulosTB";
            TulosTB.Size = new Size(75, 35);
            TulosTB.TabIndex = 1;
            TulosTB.Text = "Laske";
            TulosTB.UseVisualStyleBackColor = true;
            TulosTB.Click += button1_Click;
            // 
            // VuodetTB
            // 
            VuodetTB.AutoSize = true;
            VuodetTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VuodetTB.Location = new Point(18, 98);
            VuodetTB.Name = "VuodetTB";
            VuodetTB.Size = new Size(79, 30);
            VuodetTB.TabIndex = 2;
            VuodetTB.Text = "Vuodet";
            // 
            // KuutTB
            // 
            KuutTB.AutoSize = true;
            KuutTB.Font = new Font("Segoe UI", 16F);
            KuutTB.Location = new Point(18, 150);
            KuutTB.Name = "KuutTB";
            KuutTB.Size = new Size(116, 30);
            KuutTB.TabIndex = 3;
            KuutTB.Text = "Kuukaudet";
            // 
            // PaivatTB
            // 
            PaivatTB.AutoSize = true;
            PaivatTB.Font = new Font("Segoe UI", 16F);
            PaivatTB.Location = new Point(18, 206);
            PaivatTB.Name = "PaivatTB";
            PaivatTB.Size = new Size(69, 30);
            PaivatTB.TabIndex = 4;
            PaivatTB.Text = "Päivät";
            // 
            // TunnitTB
            // 
            TunnitTB.AutoSize = true;
            TunnitTB.Font = new Font("Segoe UI", 16F);
            TunnitTB.Location = new Point(245, 98);
            TunnitTB.Name = "TunnitTB";
            TunnitTB.Size = new Size(73, 30);
            TunnitTB.TabIndex = 5;
            TunnitTB.Text = "Tunnit";
            // 
            // MinuutitTB
            // 
            MinuutitTB.AutoSize = true;
            MinuutitTB.Font = new Font("Segoe UI", 16F);
            MinuutitTB.Location = new Point(245, 150);
            MinuutitTB.Name = "MinuutitTB";
            MinuutitTB.Size = new Size(93, 30);
            MinuutitTB.TabIndex = 6;
            MinuutitTB.Text = "Minuutit";
            // 
            // SekunnitTB
            // 
            SekunnitTB.AutoSize = true;
            SekunnitTB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SekunnitTB.Location = new Point(245, 206);
            SekunnitTB.Name = "SekunnitTB";
            SekunnitTB.Size = new Size(93, 30);
            SekunnitTB.TabIndex = 7;
            SekunnitTB.Text = "Sekunnit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SekunnitTB);
            Controls.Add(MinuutitTB);
            Controls.Add(TunnitTB);
            Controls.Add(PaivatTB);
            Controls.Add(KuutTB);
            Controls.Add(VuodetTB);
            Controls.Add(TulosTB);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button TulosTB;
        private Label VuodetTB;
        private Label KuutTB;
        private Label PaivatTB;
        private Label TunnitTB;
        private Label MinuutitTB;
        private Label SekunnitTB;
    }
}
