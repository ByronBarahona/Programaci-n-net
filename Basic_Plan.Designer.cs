namespace Prueba1.GUI
{
    partial class Basic_Plan
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
            this.Lbl_Saludo = new System.Windows.Forms.Label();
            this.Lbl_admni = new System.Windows.Forms.Label();
            this.Lbl_Informacion = new System.Windows.Forms.Label();
            this.Lbl_Cliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Deportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Deportista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Msg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gbox_Detalle = new System.Windows.Forms.GroupBox();
            this.Btn_Calculo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_peso = new System.Windows.Forms.Label();
            this.Lbl_Altura = new System.Windows.Forms.Label();
            this.Txt_Peso = new System.Windows.Forms.TextBox();
            this.Txt_Altura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Gbox_Detalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Saludo
            // 
            this.Lbl_Saludo.AutoSize = true;
            this.Lbl_Saludo.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Saludo.Name = "Lbl_Saludo";
            this.Lbl_Saludo.Size = new System.Drawing.Size(63, 13);
            this.Lbl_Saludo.TabIndex = 0;
            this.Lbl_Saludo.Text = "Bienvenido:";
            // 
            // Lbl_admni
            // 
            this.Lbl_admni.AutoSize = true;
            this.Lbl_admni.Location = new System.Drawing.Point(83, 13);
            this.Lbl_admni.Name = "Lbl_admni";
            this.Lbl_admni.Size = new System.Drawing.Size(44, 13);
            this.Lbl_admni.TabIndex = 1;
            this.Lbl_admni.Text = "Nombre";
            // 
            // Lbl_Informacion
            // 
            this.Lbl_Informacion.AutoSize = true;
            this.Lbl_Informacion.Location = new System.Drawing.Point(16, 30);
            this.Lbl_Informacion.Name = "Lbl_Informacion";
            this.Lbl_Informacion.Size = new System.Drawing.Size(177, 13);
            this.Lbl_Informacion.TabIndex = 2;
            this.Lbl_Informacion.Text = "Aquí puedes gestionar los datos de:";
            // 
            // Lbl_Cliente
            // 
            this.Lbl_Cliente.AutoSize = true;
            this.Lbl_Cliente.Location = new System.Drawing.Point(200, 29);
            this.Lbl_Cliente.Name = "Lbl_Cliente";
            this.Lbl_Cliente.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Cliente.TabIndex = 3;
            this.Lbl_Cliente.Text = "Deportista";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Deportista,
            this.Nombre_Deportista,
            this.IMC,
            this.Msg});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // ID_Deportista
            // 
            this.ID_Deportista.HeaderText = "N°";
            this.ID_Deportista.Name = "ID_Deportista";
            // 
            // Nombre_Deportista
            // 
            this.Nombre_Deportista.HeaderText = "Deportista";
            this.Nombre_Deportista.Name = "Nombre_Deportista";
            // 
            // IMC
            // 
            this.IMC.HeaderText = "IMC";
            this.IMC.Name = "IMC";
            // 
            // Msg
            // 
            this.Msg.HeaderText = "Mensaje";
            this.Msg.Name = "Msg";
            // 
            // Gbox_Detalle
            // 
            this.Gbox_Detalle.Controls.Add(this.Txt_Altura);
            this.Gbox_Detalle.Controls.Add(this.Txt_Peso);
            this.Gbox_Detalle.Controls.Add(this.Lbl_Altura);
            this.Gbox_Detalle.Controls.Add(this.Lbl_peso);
            this.Gbox_Detalle.Controls.Add(this.button1);
            this.Gbox_Detalle.Controls.Add(this.Btn_Calculo);
            this.Gbox_Detalle.Location = new System.Drawing.Point(12, 226);
            this.Gbox_Detalle.Name = "Gbox_Detalle";
            this.Gbox_Detalle.Size = new System.Drawing.Size(441, 100);
            this.Gbox_Detalle.TabIndex = 5;
            this.Gbox_Detalle.TabStop = false;
            this.Gbox_Detalle.Text = "Detalle";
            // 
            // Btn_Calculo
            // 
            this.Btn_Calculo.Location = new System.Drawing.Point(21, 20);
            this.Btn_Calculo.Name = "Btn_Calculo";
            this.Btn_Calculo.Size = new System.Drawing.Size(94, 23);
            this.Btn_Calculo.TabIndex = 0;
            this.Btn_Calculo.Text = "Calcular IMC";
            this.Btn_Calculo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver al menú";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Lbl_peso
            // 
            this.Lbl_peso.AutoEllipsis = true;
            this.Lbl_peso.AutoSize = true;
            this.Lbl_peso.Location = new System.Drawing.Point(178, 30);
            this.Lbl_peso.Name = "Lbl_peso";
            this.Lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.Lbl_peso.TabIndex = 2;
            this.Lbl_peso.Text = "Peso";
            // 
            // Lbl_Altura
            // 
            this.Lbl_Altura.AutoSize = true;
            this.Lbl_Altura.Location = new System.Drawing.Point(178, 60);
            this.Lbl_Altura.Name = "Lbl_Altura";
            this.Lbl_Altura.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Altura.TabIndex = 3;
            this.Lbl_Altura.Text = "Altura";
            // 
            // Txt_Peso
            // 
            this.Txt_Peso.Location = new System.Drawing.Point(218, 27);
            this.Txt_Peso.Name = "Txt_Peso";
            this.Txt_Peso.Size = new System.Drawing.Size(49, 20);
            this.Txt_Peso.TabIndex = 4;
            // 
            // Txt_Altura
            // 
            this.Txt_Altura.Location = new System.Drawing.Point(218, 53);
            this.Txt_Altura.Name = "Txt_Altura";
            this.Txt_Altura.Size = new System.Drawing.Size(49, 20);
            this.Txt_Altura.TabIndex = 5;
            // 
            // Basic_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 332);
            this.Controls.Add(this.Gbox_Detalle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lbl_Cliente);
            this.Controls.Add(this.Lbl_Informacion);
            this.Controls.Add(this.Lbl_admni);
            this.Controls.Add(this.Lbl_Saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Basic_Plan";
            this.Text = "Basic_Plan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Gbox_Detalle.ResumeLayout(false);
            this.Gbox_Detalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Saludo;
        private System.Windows.Forms.Label Lbl_admni;
        private System.Windows.Forms.Label Lbl_Informacion;
        private System.Windows.Forms.Label Lbl_Cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Deportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Deportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Msg;
        private System.Windows.Forms.GroupBox Gbox_Detalle;
        private System.Windows.Forms.TextBox Txt_Altura;
        private System.Windows.Forms.TextBox Txt_Peso;
        private System.Windows.Forms.Label Lbl_Altura;
        private System.Windows.Forms.Label Lbl_peso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Calculo;
    }
}