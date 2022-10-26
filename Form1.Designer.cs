
namespace Formser {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.azonosito = new System.Windows.Forms.NumericUpDown();
            this.nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nyelvek = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.szuletes = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.varosok = new System.Windows.Forms.ComboBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.hibas = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.azonosito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hibas)).BeginInit();
            this.SuspendLayout();
            // 
            // azonosito
            // 
            this.azonosito.Location = new System.Drawing.Point(87, 54);
            this.azonosito.Margin = new System.Windows.Forms.Padding(4);
            this.azonosito.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.azonosito.Name = "azonosito";
            this.azonosito.Size = new System.Drawing.Size(160, 22);
            this.azonosito.TabIndex = 1;
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(84, 104);
            this.nev.Margin = new System.Windows.Forms.Padding(4);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(132, 22);
            this.nev.TabIndex = 2;
            this.nev.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Azonosító";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Név";
            // 
            // nyelvek
            // 
            this.nyelvek.FormattingEnabled = true;
            this.nyelvek.Location = new System.Drawing.Point(84, 153);
            this.nyelvek.Name = "nyelvek";
            this.nyelvek.Size = new System.Drawing.Size(121, 24);
            this.nyelvek.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Milyen nyelven akar beszélni";
            // 
            // szuletes
            // 
            this.szuletes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.szuletes.Location = new System.Drawing.Point(83, 208);
            this.szuletes.Name = "szuletes";
            this.szuletes.ShowUpDown = true;
            this.szuletes.Size = new System.Drawing.Size(164, 22);
            this.szuletes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mikor született";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hol született";
            // 
            // varosok
            // 
            this.varosok.FormattingEnabled = true;
            this.varosok.Location = new System.Drawing.Point(83, 257);
            this.varosok.Name = "varosok";
            this.varosok.Size = new System.Drawing.Size(164, 24);
            this.varosok.Sorted = true;
            this.varosok.TabIndex = 10;
            this.varosok.Text = "Debrecen";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(83, 287);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(164, 41);
            this.checkButton.TabIndex = 11;
            this.checkButton.Text = "Ellenőrzés";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // hibas
            // 
            this.hibas.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 394);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.varosok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.szuletes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nyelvek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.azonosito);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tester";
            ((System.ComponentModel.ISupportInitialize)(this.azonosito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hibas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown azonosito;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nyelvek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker szuletes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox varosok;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.ErrorProvider hibas;
    }
}

