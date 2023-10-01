namespace Calculadora_de_Lautaro_Marguery
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
            cmbOperacion = new ComboBox();
            txtSegundoOperador = new TextBox();
            txtPrimerOperador = new TextBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblResultado = new Label();
            grbSistema = new GroupBox();
            lblFResultado = new Label();
            grbSistema.SuspendLayout();
            SuspendLayout();
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Location = new Point(326, 240);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(121, 23);
            cmbOperacion.TabIndex = 0;
            cmbOperacion.SelectedIndexChanged += cmbOperacion_SelectedIndexChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(501, 240);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(140, 23);
            txtSegundoOperador.TabIndex = 1;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(142, 240);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(140, 23);
            txtPrimerOperador.TabIndex = 2;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(142, 290);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(140, 38);
            btnOperar.TabIndex = 3;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(326, 290);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 38);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(501, 290);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 38);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Location = new Point(142, 201);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(115, 15);
            lblPrimerOperador.TabIndex = 6;
            lblPrimerOperador.Text = "PRIMER OPERADOR:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Location = new Point(332, 201);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(76, 15);
            lblOperacion.TabIndex = 7;
            lblOperacion.Text = "OPERACION:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Location = new Point(501, 201);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(128, 15);
            lblSegundoOperador.TabIndex = 8;
            lblSegundoOperador.Text = "SEGUNDO OPERADOR:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(6, 48);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 9;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Location = new Point(108, 48);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 10;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(12, 9);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(243, 62);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "Resultado:";
            // 
            // grbSistema
            // 
            grbSistema.Controls.Add(rdbBinario);
            grbSistema.Controls.Add(rdbDecimal);
            grbSistema.Location = new Point(304, 55);
            grbSistema.Name = "grbSistema";
            grbSistema.Size = new Size(200, 100);
            grbSistema.TabIndex = 12;
            grbSistema.TabStop = false;
            grbSistema.Text = "Representar resultado en:";
            // 
            // lblFResultado
            // 
            lblFResultado.AutoSize = true;
            lblFResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblFResultado.Location = new Point(26, 103);
            lblFResultado.Name = "lblFResultado";
            lblFResultado.Size = new Size(0, 37);
            lblFResultado.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFResultado);
            Controls.Add(grbSistema);
            Controls.Add(lblResultado);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(txtPrimerOperador);
            Controls.Add(txtSegundoOperador);
            Controls.Add(cmbOperacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Lauty";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            grbSistema.ResumeLayout(false);
            grbSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOperacion;
        private TextBox txtSegundoOperador;
        private TextBox txtPrimerOperador;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblResultado;
        private GroupBox grbSistema;
        private Label lblFResultado;
    }
}