namespace NaukaCsharp2
{
    partial class NaukaC2
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
            this.Koniec = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.TextBox();
            this.WczytajLista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DictionaryLista = new System.Windows.Forms.TextBox();
            this.WczytajDictionary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QueueLista = new System.Windows.Forms.TextBox();
            this.QueueList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Koniec
            // 
            this.Koniec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Koniec.Location = new System.Drawing.Point(986, 859);
            this.Koniec.Name = "Koniec";
            this.Koniec.Size = new System.Drawing.Size(100, 43);
            this.Koniec.TabIndex = 0;
            this.Koniec.Text = "Zamknij";
            this.Koniec.UseVisualStyleBackColor = true;
            this.Koniec.Click += new System.EventHandler(this.Koniec_Click);
            // 
            // Lista
            // 
            this.Lista.Location = new System.Drawing.Point(12, 104);
            this.Lista.Multiline = true;
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(269, 170);
            this.Lista.TabIndex = 1;
            // 
            // WczytajLista
            // 
            this.WczytajLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WczytajLista.Location = new System.Drawing.Point(181, 280);
            this.WczytajLista.Name = "WczytajLista";
            this.WczytajLista.Size = new System.Drawing.Size(100, 43);
            this.WczytajLista.TabIndex = 0;
            this.WczytajLista.Text = "Wczytaj";
            this.WczytajLista.UseVisualStyleBackColor = true;
            this.WczytajLista.Click += new System.EventHandler(this.List_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "List<nazwa> :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DictionaryLista
            // 
            this.DictionaryLista.Location = new System.Drawing.Point(12, 375);
            this.DictionaryLista.Multiline = true;
            this.DictionaryLista.Name = "DictionaryLista";
            this.DictionaryLista.Size = new System.Drawing.Size(269, 170);
            this.DictionaryLista.TabIndex = 1;
            // 
            // WczytajDictionary
            // 
            this.WczytajDictionary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WczytajDictionary.Location = new System.Drawing.Point(181, 551);
            this.WczytajDictionary.Name = "WczytajDictionary";
            this.WczytajDictionary.Size = new System.Drawing.Size(100, 43);
            this.WczytajDictionary.TabIndex = 0;
            this.WczytajDictionary.Text = "Wczytaj";
            this.WczytajDictionary.UseVisualStyleBackColor = true;
            this.WczytajDictionary.Click += new System.EventHandler(this.WczytajDictionary_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dictionary<typy>";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1074, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kolejki listy obiekty";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 46);
            this.label4.TabIndex = 2;
            this.label4.Text = "Queue <typ>";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QueueLista
            // 
            this.QueueLista.Location = new System.Drawing.Point(12, 646);
            this.QueueLista.Multiline = true;
            this.QueueLista.Name = "QueueLista";
            this.QueueLista.Size = new System.Drawing.Size(269, 170);
            this.QueueLista.TabIndex = 1;
            // 
            // QueueList
            // 
            this.QueueList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QueueList.Location = new System.Drawing.Point(181, 822);
            this.QueueList.Name = "QueueList";
            this.QueueList.Size = new System.Drawing.Size(100, 43);
            this.QueueList.TabIndex = 0;
            this.QueueList.Text = "Wczytaj";
            this.QueueList.UseVisualStyleBackColor = true;
            this.QueueList.Click += new System.EventHandler(this.WczytajQueue_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 822);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kasuj(odczytaj)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OdczytajQueue_Click);
            // 
            // NaukaC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1098, 914);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QueueList);
            this.Controls.Add(this.QueueLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WczytajDictionary);
            this.Controls.Add(this.DictionaryLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WczytajLista);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.Koniec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NaukaC2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nauka C# 2";
            this.Load += new System.EventHandler(this.NaukaC2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NaukaC2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NaukaC2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NaukaC2_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Koniec;
        private System.Windows.Forms.TextBox Lista;
        private System.Windows.Forms.Button WczytajLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DictionaryLista;
        private System.Windows.Forms.Button WczytajDictionary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QueueLista;
        private System.Windows.Forms.Button QueueList;
        private System.Windows.Forms.Button button1;
    }
}

