namespace taschenrechner_stefan2
{
    partial class Taschenrechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button zahl1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taschenrechner));
            this.zahl2 = new System.Windows.Forms.Button();
            this.zahl3 = new System.Windows.Forms.Button();
            this.zahl4 = new System.Windows.Forms.Button();
            this.zahl5 = new System.Windows.Forms.Button();
            this.zahl6 = new System.Windows.Forms.Button();
            this.zahl7 = new System.Windows.Forms.Button();
            this.zahl8 = new System.Windows.Forms.Button();
            this.zahl9 = new System.Windows.Forms.Button();
            this.zahl0 = new System.Windows.Forms.Button();
            this.multiplizieren = new System.Windows.Forms.Button();
            this.dividieren = new System.Windows.Forms.Button();
            this.addieren = new System.Windows.Forms.Button();
            this.subtrahieren = new System.Windows.Forms.Button();
            this.radieren = new System.Windows.Forms.Button();
            this.ausfuehren = new System.Windows.Forms.Button();
            this.ergebnisbox = new System.Windows.Forms.TextBox();
            this.eingabe = new System.Windows.Forms.Label();
            this.leeren = new System.Windows.Forms.Button();
            this.vorherigeeingabe = new System.Windows.Forms.Label();
            this.alt_eingabe = new System.Windows.Forms.Label();
            zahl1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zahl1
            // 
            resources.ApplyResources(zahl1, "zahl1");
            zahl1.Name = "zahl1";
            zahl1.UseVisualStyleBackColor = true;
            zahl1.Click += new System.EventHandler(this.button_Click);
            // 
            // zahl2
            // 
            resources.ApplyResources(this.zahl2, "zahl2");
            this.zahl2.Name = "zahl2";
            this.zahl2.UseVisualStyleBackColor = true;
            this.zahl2.Click += new System.EventHandler(this.button_Click);
            // 
            // zahl3
            // 
            resources.ApplyResources(this.zahl3, "zahl3");
            this.zahl3.Name = "zahl3";
            this.zahl3.UseVisualStyleBackColor = true;
            this.zahl3.Click += new System.EventHandler(this.button_Click);
            // 
            // zahl4
            // 
            resources.ApplyResources(this.zahl4, "zahl4");
            this.zahl4.Name = "zahl4";
            this.zahl4.UseVisualStyleBackColor = true;
            this.zahl4.Click += new System.EventHandler(this.button_Click);
            // 
            // zahl5
            // 
            resources.ApplyResources(this.zahl5, "zahl5");
            this.zahl5.Name = "zahl5";
            this.zahl5.UseVisualStyleBackColor = true;
            this.zahl5.Click += new System.EventHandler(this.button_Click);
            // 
            // zahl6
            // 
            resources.ApplyResources(this.zahl6, "zahl6");
            this.zahl6.Name = "zahl6";
            this.zahl6.UseVisualStyleBackColor = true;
            this.zahl6.Click += new System.EventHandler(this.button_Click);
            // 
            // zahl7
            // 
            resources.ApplyResources(this.zahl7, "zahl7");
            this.zahl7.Name = "zahl7";
            this.zahl7.UseVisualStyleBackColor = true;
            this.zahl7.Click += new System.EventHandler(this.button_Click);
            // 
            // zahl8
            // 
            resources.ApplyResources(this.zahl8, "zahl8");
            this.zahl8.Name = "zahl8";
            this.zahl8.UseVisualStyleBackColor = true;
            this.zahl8.Click += new System.EventHandler(this.button_Click);
            // 
            // zahl9
            // 
            resources.ApplyResources(this.zahl9, "zahl9");
            this.zahl9.Name = "zahl9";
            this.zahl9.UseVisualStyleBackColor = true;
            this.zahl9.Click += new System.EventHandler(this.button_Click);
            // 
            // zahl0
            // 
            resources.ApplyResources(this.zahl0, "zahl0");
            this.zahl0.Name = "zahl0";
            this.zahl0.UseVisualStyleBackColor = true;
            this.zahl0.Click += new System.EventHandler(this.button_Click);
            // 
            // multiplizieren
            // 
            resources.ApplyResources(this.multiplizieren, "multiplizieren");
            this.multiplizieren.Name = "multiplizieren";
            this.multiplizieren.UseVisualStyleBackColor = true;
            this.multiplizieren.Click += new System.EventHandler(this.rechnen_click);
            // 
            // dividieren
            // 
            resources.ApplyResources(this.dividieren, "dividieren");
            this.dividieren.Name = "dividieren";
            this.dividieren.UseVisualStyleBackColor = true;
            this.dividieren.Click += new System.EventHandler(this.rechnen_click);
            // 
            // addieren
            // 
            resources.ApplyResources(this.addieren, "addieren");
            this.addieren.Name = "addieren";
            this.addieren.UseVisualStyleBackColor = true;
            this.addieren.Click += new System.EventHandler(this.rechnen_click);
            // 
            // subtrahieren
            // 
            resources.ApplyResources(this.subtrahieren, "subtrahieren");
            this.subtrahieren.Name = "subtrahieren";
            this.subtrahieren.UseVisualStyleBackColor = true;
            this.subtrahieren.Click += new System.EventHandler(this.rechnen_click);
            // 
            // radieren
            // 
            resources.ApplyResources(this.radieren, "radieren");
            this.radieren.Name = "radieren";
            this.radieren.UseVisualStyleBackColor = true;
            this.radieren.Click += new System.EventHandler(this.radieren_Click);
            // 
            // ausfuehren
            // 
            resources.ApplyResources(this.ausfuehren, "ausfuehren");
            this.ausfuehren.Name = "ausfuehren";
            this.ausfuehren.UseVisualStyleBackColor = true;
            this.ausfuehren.Click += new System.EventHandler(this.ausfuehren_Click);
            // 
            // ergebnisbox
            // 
            resources.ApplyResources(this.ergebnisbox, "ergebnisbox");
            this.ergebnisbox.Name = "ergebnisbox";
            // 
            // eingabe
            // 
            resources.ApplyResources(this.eingabe, "eingabe");
            this.eingabe.Name = "eingabe";
            // 
            // leeren
            // 
            resources.ApplyResources(this.leeren, "leeren");
            this.leeren.Name = "leeren";
            this.leeren.UseVisualStyleBackColor = true;
            this.leeren.Click += new System.EventHandler(this.leeren_Click);
            // 
            // vorherigeeingabe
            // 
            resources.ApplyResources(this.vorherigeeingabe, "vorherigeeingabe");
            this.vorherigeeingabe.Name = "vorherigeeingabe";
            // 
            // alt_eingabe
            // 
            resources.ApplyResources(this.alt_eingabe, "alt_eingabe");
            this.alt_eingabe.Name = "alt_eingabe";
            // 
            // Taschenrechner
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alt_eingabe);
            this.Controls.Add(this.vorherigeeingabe);
            this.Controls.Add(this.leeren);
            this.Controls.Add(this.eingabe);
            this.Controls.Add(this.ergebnisbox);
            this.Controls.Add(this.ausfuehren);
            this.Controls.Add(this.radieren);
            this.Controls.Add(this.subtrahieren);
            this.Controls.Add(this.addieren);
            this.Controls.Add(this.dividieren);
            this.Controls.Add(this.multiplizieren);
            this.Controls.Add(this.zahl0);
            this.Controls.Add(this.zahl9);
            this.Controls.Add(this.zahl8);
            this.Controls.Add(this.zahl7);
            this.Controls.Add(this.zahl6);
            this.Controls.Add(this.zahl5);
            this.Controls.Add(this.zahl4);
            this.Controls.Add(this.zahl3);
            this.Controls.Add(this.zahl2);
            this.Controls.Add(zahl1);
            this.MaximizeBox = false;
            this.Name = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zahl2;
        private System.Windows.Forms.Button zahl3;
        private System.Windows.Forms.Button zahl4;
        private System.Windows.Forms.Button zahl5;
        private System.Windows.Forms.Button zahl6;
        private System.Windows.Forms.Button zahl7;
        private System.Windows.Forms.Button zahl8;
        private System.Windows.Forms.Button zahl9;
        private System.Windows.Forms.Button zahl0;
        private System.Windows.Forms.Button multiplizieren;
        private System.Windows.Forms.Button dividieren;
        private System.Windows.Forms.Button addieren;
        private System.Windows.Forms.Button subtrahieren;
        private System.Windows.Forms.Button radieren;
        private System.Windows.Forms.Button ausfuehren;
        private System.Windows.Forms.TextBox ergebnisbox;
        private System.Windows.Forms.Label eingabe;
        private System.Windows.Forms.Button leeren;
        private System.Windows.Forms.Label vorherigeeingabe;
        private System.Windows.Forms.Label alt_eingabe;
    }
}