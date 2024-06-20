namespace SistemaVendas.Formularios
{
    partial class Vender
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            this.vendasGrid = new System.Windows.Forms.DataGridView();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQtd = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.textBoxValorPago = new System.Windows.Forms.TextBox();
            this.textBoxTroco = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.comboBoxFrmPag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.texBoxValorUni = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vendasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasGrid
            // 
            this.vendasGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendasGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendasGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.vendasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendasGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vendasGrid.Location = new System.Drawing.Point(559, 195);
            this.vendasGrid.MultiSelect = false;
            this.vendasGrid.Name = "vendasGrid";
            this.vendasGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vendasGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.vendasGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendasGrid.Size = new System.Drawing.Size(795, 495);
            this.vendasGrid.TabIndex = 43;
            this.vendasGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.vendasGrid_RowsAdded);
            // 
            // textBoxCod
            // 
            this.textBoxCod.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCod.Location = new System.Drawing.Point(7, 182);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(539, 44);
            this.textBoxCod.TabIndex = 0;
            this.textBoxCod.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxCod_MouseClick);
            this.textBoxCod.TextChanged += new System.EventHandler(this.textBoxCod_TextChanged);
            this.textBoxCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCod_KeyPress);
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.White;
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(12, 257);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(459, 44);
            this.textBoxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(20, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código de barras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(7, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produto";
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQtd.Location = new System.Drawing.Point(477, 257);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(69, 44);
            this.textBoxQtd.TabIndex = 5;
            this.textBoxQtd.Text = "1";
            this.textBoxQtd.TextChanged += new System.EventHandler(this.textBoxQtd_TextChanged);
            this.textBoxQtd.Enter += new System.EventHandler(this.textBoxQtd_Enter);
            this.textBoxQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQtd_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(555, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 45;
            this.label6.Text = "Sub total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(8, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 48;
            this.label9.Text = "Valor pago";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(8, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 49;
            this.label10.Text = "Troco";
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Enabled = false;
            this.textBoxSubTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubTotal.Location = new System.Drawing.Point(559, 103);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(795, 48);
            this.textBoxSubTotal.TabIndex = 50;
            // 
            // textBoxValorPago
            // 
            this.textBoxValorPago.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorPago.Location = new System.Drawing.Point(12, 451);
            this.textBoxValorPago.Name = "textBoxValorPago";
            this.textBoxValorPago.Size = new System.Drawing.Size(292, 54);
            this.textBoxValorPago.TabIndex = 53;
            this.textBoxValorPago.TextChanged += new System.EventHandler(this.textBoxValorPago_TextChanged);
            // 
            // textBoxTroco
            // 
            this.textBoxTroco.Enabled = false;
            this.textBoxTroco.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTroco.Location = new System.Drawing.Point(12, 538);
            this.textBoxTroco.Name = "textBoxTroco";
            this.textBoxTroco.Size = new System.Drawing.Size(292, 54);
            this.textBoxTroco.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(327, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 26);
            this.label11.TabIndex = 56;
            this.label11.Text = "Forma de pagamento";
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConcluirVenda.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConcluirVenda.Location = new System.Drawing.Point(285, 603);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(261, 90);
            this.btnConcluirVenda.TabIndex = 57;
            this.btnConcluirVenda.Text = "Concluir venda";
            this.btnConcluirVenda.UseVisualStyleBackColor = false;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // comboBoxFrmPag
            // 
            this.comboBoxFrmPag.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxFrmPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrmPag.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFrmPag.FormattingEnabled = true;
            this.comboBoxFrmPag.Items.AddRange(new object[] {
            "Espécie",
            "Débito",
            "Crédito",
            "Pix",
            "Ticket"});
            this.comboBoxFrmPag.Location = new System.Drawing.Point(332, 359);
            this.comboBoxFrmPag.Name = "comboBoxFrmPag";
            this.comboBoxFrmPag.Size = new System.Drawing.Size(214, 46);
            this.comboBoxFrmPag.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(493, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 26);
            this.label4.TabIndex = 60;
            this.label4.Text = "Qtd";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Purple;
            this.label12.Location = new System.Drawing.Point(474, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "(Q)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(554, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 63;
            this.label3.Text = "Detalhes da Venda";
            // 
            // texBoxValorUni
            // 
            this.texBoxValorUni.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texBoxValorUni.Location = new System.Drawing.Point(12, 359);
            this.texBoxValorUni.Name = "texBoxValorUni";
            this.texBoxValorUni.ReadOnly = true;
            this.texBoxValorUni.Size = new System.Drawing.Size(289, 44);
            this.texBoxValorUni.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(7, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 26);
            this.label8.TabIndex = 67;
            this.label8.Text = "Valor unitário";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(7, 603);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(263, 87);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar venda";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(4, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "(c)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaVendas.Properties.Resources.PDV_Azul;
            this.pictureBox1.Location = new System.Drawing.Point(328, 427);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 64);
            this.panel1.TabIndex = 71;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1328, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(1016, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(229, 44);
            this.label13.TabIndex = 21;
            this.label13.Text = "Caixa Ocupado";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.Image = global::SistemaVendas.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(411, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(506, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(154)))), ((int)(((byte)(187)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 732);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1366, 36);
            this.panel5.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(617, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Bem - vindo(a)";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SistemaVendas.Properties.Resources.loja_de_roupa__2_;
            this.pictureBox8.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(73, 60);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 70;
            this.pictureBox8.TabStop = false;
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.texBoxValorUni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxFrmPag);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxTroco);
            this.Controls.Add(this.textBoxQtd);
            this.Controls.Add(this.textBoxValorPago);
            this.Controls.Add(this.vendasGrid);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(300, 200);
            this.Name = "Vender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vender";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Vender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vendasGrid;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.MaskedTextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textBoxQtd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.TextBox textBoxValorPago;
        private System.Windows.Forms.TextBox textBoxTroco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.ComboBox comboBoxFrmPag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox texBoxValorUni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}