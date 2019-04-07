namespace PasoParametrosPLC_PC_CSharp
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LedConexion = new System.Windows.Forms.PictureBox();
            this.GbxConectarPLC = new System.Windows.Forms.GroupBox();
            this.TbIP = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelConetenido = new System.Windows.Forms.Panel();
            this.tbConsola = new System.Windows.Forms.TextBox();
            this.lbConsola = new System.Windows.Forms.Label();
            this.LblAux = new System.Windows.Forms.Label();
            this.btnLeerDB0 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GbxLeer = new System.Windows.Forms.GroupBox();
            this.TBx4 = new System.Windows.Forms.TextBox();
            this.TBx3 = new System.Windows.Forms.TextBox();
            this.TBx2 = new System.Windows.Forms.TextBox();
            this.TBx1 = new System.Windows.Forms.TextBox();
            this.btnEscribirDB0 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEscribirDB2 = new System.Windows.Forms.Button();
            this.btnLeerDB2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LedConexion)).BeginInit();
            this.GbxConectarPLC.SuspendLayout();
            this.panelConetenido.SuspendLayout();
            this.GbxLeer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMUNICACION PC <---> PLC ";
            // 
            // BtnConectar
            // 
            this.BtnConectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConectar.Location = new System.Drawing.Point(76, 141);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(127, 45);
            this.BtnConectar.TabIndex = 1;
            this.BtnConectar.Text = "CONECTAR";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONECTAR CON PLC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(31, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado conexión";
            // 
            // LedConexion
            // 
            this.LedConexion.Image = global::PasoParametrosPLC_PC_CSharp.Properties.Resources.rojo;
            this.LedConexion.Location = new System.Drawing.Point(25, 141);
            this.LedConexion.Name = "LedConexion";
            this.LedConexion.Size = new System.Drawing.Size(45, 45);
            this.LedConexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LedConexion.TabIndex = 4;
            this.LedConexion.TabStop = false;
            // 
            // GbxConectarPLC
            // 
            this.GbxConectarPLC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GbxConectarPLC.Controls.Add(this.TbIP);
            this.GbxConectarPLC.Controls.Add(this.BtnConectar);
            this.GbxConectarPLC.Controls.Add(this.LedConexion);
            this.GbxConectarPLC.Controls.Add(this.label2);
            this.GbxConectarPLC.Controls.Add(this.label3);
            this.GbxConectarPLC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GbxConectarPLC.Location = new System.Drawing.Point(12, 12);
            this.GbxConectarPLC.Name = "GbxConectarPLC";
            this.GbxConectarPLC.Size = new System.Drawing.Size(230, 228);
            this.GbxConectarPLC.TabIndex = 5;
            this.GbxConectarPLC.TabStop = false;
            // 
            // TbIP
            // 
            this.TbIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbIP.Location = new System.Drawing.Point(25, 70);
            this.TbIP.Name = "TbIP";
            this.TbIP.Size = new System.Drawing.Size(178, 27);
            this.TbIP.TabIndex = 5;
            this.TbIP.Text = "192.168.1.150";
            this.TbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelConetenido
            // 
            this.panelConetenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panelConetenido.Controls.Add(this.tbConsola);
            this.panelConetenido.Controls.Add(this.lbConsola);
            this.panelConetenido.Controls.Add(this.LblAux);
            this.panelConetenido.Location = new System.Drawing.Point(248, 68);
            this.panelConetenido.Name = "panelConetenido";
            this.panelConetenido.Size = new System.Drawing.Size(722, 544);
            this.panelConetenido.TabIndex = 7;
            // 
            // tbConsola
            // 
            this.tbConsola.Location = new System.Drawing.Point(447, 113);
            this.tbConsola.Multiline = true;
            this.tbConsola.Name = "tbConsola";
            this.tbConsola.Size = new System.Drawing.Size(217, 388);
            this.tbConsola.TabIndex = 11;
            // 
            // lbConsola
            // 
            this.lbConsola.AutoSize = true;
            this.lbConsola.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConsola.Location = new System.Drawing.Point(496, 32);
            this.lbConsola.Name = "lbConsola";
            this.lbConsola.Size = new System.Drawing.Size(63, 17);
            this.lbConsola.TabIndex = 10;
            this.lbConsola.Text = "Consola:";
            // 
            // LblAux
            // 
            this.LblAux.AutoSize = true;
            this.LblAux.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAux.Location = new System.Drawing.Point(23, 32);
            this.LblAux.Name = "LblAux";
            this.LblAux.Size = new System.Drawing.Size(39, 17);
            this.LblAux.TabIndex = 0;
            this.LblAux.Text = "Aux: ";
            // 
            // btnLeerDB0
            // 
            this.btnLeerDB0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeerDB0.Location = new System.Drawing.Point(6, 165);
            this.btnLeerDB0.Name = "btnLeerDB0";
            this.btnLeerDB0.Size = new System.Drawing.Size(107, 30);
            this.btnLeerDB0.TabIndex = 6;
            this.btnLeerDB0.Text = "Leer";
            this.btnLeerDB0.UseVisualStyleBackColor = true;
            this.btnLeerDB0.Click += new System.EventHandler(this.btnLeerDB0_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(30, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "byte 20:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(16, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Real 14.0:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(30, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "int 12.0:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "12 Char 0.0:";
            // 
            // GbxLeer
            // 
            this.GbxLeer.Controls.Add(this.TBx4);
            this.GbxLeer.Controls.Add(this.TBx3);
            this.GbxLeer.Controls.Add(this.TBx2);
            this.GbxLeer.Controls.Add(this.TBx1);
            this.GbxLeer.Controls.Add(this.btnEscribirDB0);
            this.GbxLeer.Controls.Add(this.label12);
            this.GbxLeer.Controls.Add(this.btnLeerDB0);
            this.GbxLeer.Controls.Add(this.label7);
            this.GbxLeer.Controls.Add(this.label6);
            this.GbxLeer.Controls.Add(this.label5);
            this.GbxLeer.Controls.Add(this.label4);
            this.GbxLeer.Location = new System.Drawing.Point(12, 246);
            this.GbxLeer.Name = "GbxLeer";
            this.GbxLeer.Size = new System.Drawing.Size(230, 217);
            this.GbxLeer.TabIndex = 9;
            this.GbxLeer.TabStop = false;
            // 
            // TBx4
            // 
            this.TBx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx4.Location = new System.Drawing.Point(95, 134);
            this.TBx4.Name = "TBx4";
            this.TBx4.Size = new System.Drawing.Size(121, 19);
            this.TBx4.TabIndex = 15;
            // 
            // TBx3
            // 
            this.TBx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx3.Location = new System.Drawing.Point(95, 109);
            this.TBx3.Name = "TBx3";
            this.TBx3.Size = new System.Drawing.Size(121, 19);
            this.TBx3.TabIndex = 14;
            // 
            // TBx2
            // 
            this.TBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx2.Location = new System.Drawing.Point(95, 84);
            this.TBx2.Name = "TBx2";
            this.TBx2.Size = new System.Drawing.Size(121, 19);
            this.TBx2.TabIndex = 13;
            // 
            // TBx1
            // 
            this.TBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBx1.Location = new System.Drawing.Point(95, 59);
            this.TBx1.Name = "TBx1";
            this.TBx1.Size = new System.Drawing.Size(121, 19);
            this.TBx1.TabIndex = 12;
            // 
            // btnEscribirDB0
            // 
            this.btnEscribirDB0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscribirDB0.Location = new System.Drawing.Point(119, 165);
            this.btnEscribirDB0.Name = "btnEscribirDB0";
            this.btnEscribirDB0.Size = new System.Drawing.Size(107, 30);
            this.btnEscribirDB0.TabIndex = 11;
            this.btnEscribirDB0.Text = "Escribir";
            this.btnEscribirDB0.UseVisualStyleBackColor = true;
            this.btnEscribirDB0.Click += new System.EventHandler(this.btnEscribirDB0_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(96, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "DB1";
            // 
            // btnEscribirDB2
            // 
            this.btnEscribirDB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscribirDB2.Location = new System.Drawing.Point(117, 107);
            this.btnEscribirDB2.Name = "btnEscribirDB2";
            this.btnEscribirDB2.Size = new System.Drawing.Size(107, 30);
            this.btnEscribirDB2.TabIndex = 11;
            this.btnEscribirDB2.Text = "Escribir";
            this.btnEscribirDB2.UseVisualStyleBackColor = true;
            this.btnEscribirDB2.Click += new System.EventHandler(this.btnEscribirDB2_Click);
            // 
            // btnLeerDB2
            // 
            this.btnLeerDB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeerDB2.Location = new System.Drawing.Point(4, 107);
            this.btnLeerDB2.Name = "btnLeerDB2";
            this.btnLeerDB2.Size = new System.Drawing.Size(107, 30);
            this.btnLeerDB2.TabIndex = 6;
            this.btnLeerDB2.Text = "Leer";
            this.btnLeerDB2.UseVisualStyleBackColor = true;
            this.btnLeerDB2.Click += new System.EventHandler(this.btnLeerDB2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb6);
            this.groupBox1.Controls.Add(this.tb5);
            this.groupBox1.Controls.Add(this.btnEscribirDB2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnLeerDB2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(12, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 146);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // tb6
            // 
            this.tb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb6.Location = new System.Drawing.Point(95, 84);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(121, 19);
            this.tb6.TabIndex = 13;
            // 
            // tb5
            // 
            this.tb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb5.Location = new System.Drawing.Point(95, 59);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(121, 19);
            this.tb5.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(96, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "DB2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(20, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "world 2.0:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(38, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "int 0.0:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelConetenido);
            this.Controls.Add(this.GbxConectarPLC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbxLeer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "EDS PC - PLC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LedConexion)).EndInit();
            this.GbxConectarPLC.ResumeLayout(false);
            this.GbxConectarPLC.PerformLayout();
            this.panelConetenido.ResumeLayout(false);
            this.panelConetenido.PerformLayout();
            this.GbxLeer.ResumeLayout(false);
            this.GbxLeer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox LedConexion;
        private System.Windows.Forms.GroupBox GbxConectarPLC;
        private System.Windows.Forms.TextBox TbIP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelConetenido;
        private System.Windows.Forms.Label LblAux;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLeerDB0;
        private System.Windows.Forms.GroupBox GbxLeer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbConsola;
        private System.Windows.Forms.TextBox tbConsola;
        private System.Windows.Forms.Button btnEscribirDB0;
        private System.Windows.Forms.TextBox TBx4;
        private System.Windows.Forms.TextBox TBx3;
        private System.Windows.Forms.TextBox TBx2;
        private System.Windows.Forms.TextBox TBx1;
        private System.Windows.Forms.Button btnEscribirDB2;
        private System.Windows.Forms.Button btnLeerDB2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}

