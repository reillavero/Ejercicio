namespace Ejercicio_24
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tBx_Cenas = new System.Windows.Forms.TextBox();
            this.lbl_costeCena = new System.Windows.Forms.Label();
            this.check_Salud = new System.Windows.Forms.CheckBox();
            this.check_CenaLujo = new System.Windows.Forms.CheckBox();
            this.numeric_Cenas = new System.Windows.Forms.NumericUpDown();
            this.lbl_numPersonas = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tBx_Cumple = new System.Windows.Forms.TextBox();
            this.lbl_cumle = new System.Windows.Forms.Label();
            this.lbl_Tarta = new System.Windows.Forms.Label();
            this.tBx_Tarta = new System.Windows.Forms.TextBox();
            this.check_CumpleLujo = new System.Windows.Forms.CheckBox();
            this.numeric_Cumple = new System.Windows.Forms.NumericUpDown();
            this.lbl_Cumple = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Cenas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Cumple)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tBx_Cenas);
            this.tabPage1.Controls.Add(this.lbl_costeCena);
            this.tabPage1.Controls.Add(this.check_Salud);
            this.tabPage1.Controls.Add(this.check_CenaLujo);
            this.tabPage1.Controls.Add(this.numeric_Cenas);
            this.tabPage1.Controls.Add(this.lbl_numPersonas);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(487, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cenas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tBx_Cenas
            // 
            this.tBx_Cenas.Location = new System.Drawing.Point(140, 247);
            this.tBx_Cenas.Name = "tBx_Cenas";
            this.tBx_Cenas.Size = new System.Drawing.Size(100, 26);
            this.tBx_Cenas.TabIndex = 5;
            // 
            // lbl_costeCena
            // 
            this.lbl_costeCena.AutoSize = true;
            this.lbl_costeCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costeCena.Location = new System.Drawing.Point(70, 247);
            this.lbl_costeCena.Name = "lbl_costeCena";
            this.lbl_costeCena.Size = new System.Drawing.Size(61, 20);
            this.lbl_costeCena.TabIndex = 4;
            this.lbl_costeCena.Text = "Coste:";
            // 
            // check_Salud
            // 
            this.check_Salud.AutoSize = true;
            this.check_Salud.Location = new System.Drawing.Point(40, 187);
            this.check_Salud.Name = "check_Salud";
            this.check_Salud.Size = new System.Drawing.Size(153, 24);
            this.check_Salud.TabIndex = 3;
            this.check_Salud.Text = "Opción Saludable";
            this.check_Salud.UseVisualStyleBackColor = true;
            this.check_Salud.CheckedChanged += new System.EventHandler(this.check_Salud_CheckedChanged);
            // 
            // check_CenaLujo
            // 
            this.check_CenaLujo.AutoSize = true;
            this.check_CenaLujo.Location = new System.Drawing.Point(40, 130);
            this.check_CenaLujo.Name = "check_CenaLujo";
            this.check_CenaLujo.Size = new System.Drawing.Size(165, 24);
            this.check_CenaLujo.TabIndex = 2;
            this.check_CenaLujo.Text = "Decoración de Lujo";
            this.check_CenaLujo.UseVisualStyleBackColor = true;
            this.check_CenaLujo.CheckedChanged += new System.EventHandler(this.check_CenaLujo_CheckedChanged);
            // 
            // numeric_Cenas
            // 
            this.numeric_Cenas.Location = new System.Drawing.Point(210, 70);
            this.numeric_Cenas.Name = "numeric_Cenas";
            this.numeric_Cenas.Size = new System.Drawing.Size(80, 26);
            this.numeric_Cenas.TabIndex = 1;
            this.numeric_Cenas.ValueChanged += new System.EventHandler(this.numeric_Cenas_ValueChanged);
            // 
            // lbl_numPersonas
            // 
            this.lbl_numPersonas.AutoSize = true;
            this.lbl_numPersonas.Location = new System.Drawing.Point(40, 71);
            this.lbl_numPersonas.Name = "lbl_numPersonas";
            this.lbl_numPersonas.Size = new System.Drawing.Size(158, 20);
            this.lbl_numPersonas.TabIndex = 0;
            this.lbl_numPersonas.Text = "Número de Personas";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tBx_Cumple);
            this.tabPage2.Controls.Add(this.lbl_cumle);
            this.tabPage2.Controls.Add(this.lbl_Tarta);
            this.tabPage2.Controls.Add(this.tBx_Tarta);
            this.tabPage2.Controls.Add(this.check_CumpleLujo);
            this.tabPage2.Controls.Add(this.numeric_Cumple);
            this.tabPage2.Controls.Add(this.lbl_Cumple);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(487, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cumpleaños";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tBx_Cumple
            // 
            this.tBx_Cumple.Location = new System.Drawing.Point(140, 271);
            this.tBx_Cumple.Name = "tBx_Cumple";
            this.tBx_Cumple.Size = new System.Drawing.Size(100, 26);
            this.tBx_Cumple.TabIndex = 6;
            // 
            // lbl_cumle
            // 
            this.lbl_cumle.AutoSize = true;
            this.lbl_cumle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cumle.Location = new System.Drawing.Point(70, 272);
            this.lbl_cumle.Name = "lbl_cumle";
            this.lbl_cumle.Size = new System.Drawing.Size(61, 20);
            this.lbl_cumle.TabIndex = 5;
            this.lbl_cumle.Text = "Coste:";
            // 
            // lbl_Tarta
            // 
            this.lbl_Tarta.AutoSize = true;
            this.lbl_Tarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tarta.Location = new System.Drawing.Point(40, 191);
            this.lbl_Tarta.Name = "lbl_Tarta";
            this.lbl_Tarta.Size = new System.Drawing.Size(149, 20);
            this.lbl_Tarta.TabIndex = 4;
            this.lbl_Tarta.Text = "Texto de la Tarta:";
            // 
            // tBx_Tarta
            // 
            this.tBx_Tarta.Location = new System.Drawing.Point(40, 214);
            this.tBx_Tarta.Name = "tBx_Tarta";
            this.tBx_Tarta.Size = new System.Drawing.Size(360, 26);
            this.tBx_Tarta.TabIndex = 3;
            this.tBx_Tarta.TextChanged += new System.EventHandler(this.tBx_Tarta_TextChanged);
            // 
            // check_CumpleLujo
            // 
            this.check_CumpleLujo.AutoSize = true;
            this.check_CumpleLujo.Location = new System.Drawing.Point(40, 130);
            this.check_CumpleLujo.Name = "check_CumpleLujo";
            this.check_CumpleLujo.Size = new System.Drawing.Size(165, 24);
            this.check_CumpleLujo.TabIndex = 2;
            this.check_CumpleLujo.Text = "Decoración de Lujo";
            this.check_CumpleLujo.UseVisualStyleBackColor = true;
            this.check_CumpleLujo.CheckedChanged += new System.EventHandler(this.check_CumpleLujo_CheckedChanged);
            // 
            // numeric_Cumple
            // 
            this.numeric_Cumple.Location = new System.Drawing.Point(210, 70);
            this.numeric_Cumple.Name = "numeric_Cumple";
            this.numeric_Cumple.Size = new System.Drawing.Size(86, 26);
            this.numeric_Cumple.TabIndex = 1;
            this.numeric_Cumple.ValueChanged += new System.EventHandler(this.numeric_Cumple_ValueChanged);
            // 
            // lbl_Cumple
            // 
            this.lbl_Cumple.AutoSize = true;
            this.lbl_Cumple.Location = new System.Drawing.Point(40, 70);
            this.lbl_Cumple.Name = "lbl_Cumple";
            this.lbl_Cumple.Size = new System.Drawing.Size(158, 20);
            this.lbl_Cumple.TabIndex = 0;
            this.lbl_Cumple.Text = "Número de Personas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 461);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Planificador de Presupuestos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Cenas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Cumple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tBx_Cenas;
        private System.Windows.Forms.Label lbl_costeCena;
        private System.Windows.Forms.CheckBox check_Salud;
        private System.Windows.Forms.CheckBox check_CenaLujo;
        private System.Windows.Forms.NumericUpDown numeric_Cenas;
        private System.Windows.Forms.Label lbl_numPersonas;
        private System.Windows.Forms.TextBox tBx_Cumple;
        private System.Windows.Forms.Label lbl_cumle;
        private System.Windows.Forms.Label lbl_Tarta;
        private System.Windows.Forms.TextBox tBx_Tarta;
        private System.Windows.Forms.CheckBox check_CumpleLujo;
        private System.Windows.Forms.NumericUpDown numeric_Cumple;
        private System.Windows.Forms.Label lbl_Cumple;
    }
}

