namespace SistemaVendas.Formularios
{
    partial class MenuCancelamento
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
            this.textBoxCodCancel = new System.Windows.Forms.TextBox();
            this.buttonCancelVend = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código de cancelamento";
            // 
            // textBoxCodCancel
            // 
            this.textBoxCodCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodCancel.Location = new System.Drawing.Point(32, 78);
            this.textBoxCodCancel.Name = "textBoxCodCancel";
            this.textBoxCodCancel.Size = new System.Drawing.Size(463, 40);
            this.textBoxCodCancel.TabIndex = 1;
            // 
            // buttonCancelVend
            // 
            this.buttonCancelVend.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancelVend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancelVend.Location = new System.Drawing.Point(53, 157);
            this.buttonCancelVend.Name = "buttonCancelVend";
            this.buttonCancelVend.Size = new System.Drawing.Size(175, 43);
            this.buttonCancelVend.TabIndex = 2;
            this.buttonCancelVend.Text = "Cancelar venda";
            this.buttonCancelVend.UseVisualStyleBackColor = false;
            this.buttonCancelVend.Click += new System.EventHandler(this.buttonCancelVend_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonContinue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonContinue.Location = new System.Drawing.Point(291, 157);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(175, 43);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "Continuar venda";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // MenuCancelamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(531, 244);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonCancelVend);
            this.Controls.Add(this.textBoxCodCancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuCancelamento";
            this.Text = "MenuCancelamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodCancel;
        private System.Windows.Forms.Button buttonCancelVend;
        private System.Windows.Forms.Button buttonContinue;
    }
}