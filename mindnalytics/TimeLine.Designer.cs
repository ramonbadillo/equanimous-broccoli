namespace mindnalytics
{
    partial class TimeLine
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaTimeline = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDwnAsset = new System.Windows.Forms.Button();
            this.btnUpAsset = new System.Windows.Forms.Button();
            this.btnRmvAsset = new System.Windows.Forms.Button();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.btnTimeLine = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Archivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTimeline)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupos de Assets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Narrativas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sequencia";
            // 
            // tablaTimeline
            // 
            this.tablaTimeline.AllowUserToAddRows = false;
            this.tablaTimeline.AllowUserToDeleteRows = false;
            this.tablaTimeline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTimeline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.Tipo});
            this.tablaTimeline.Location = new System.Drawing.Point(325, 84);
            this.tablaTimeline.Margin = new System.Windows.Forms.Padding(5);
            this.tablaTimeline.MultiSelect = false;
            this.tablaTimeline.Name = "tablaTimeline";
            this.tablaTimeline.RowHeadersVisible = false;
            this.tablaTimeline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTimeline.Size = new System.Drawing.Size(424, 530);
            this.tablaTimeline.TabIndex = 28;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "#";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 40;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 280;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // btnDwnAsset
            // 
            this.btnDwnAsset.Location = new System.Drawing.Point(758, 377);
            this.btnDwnAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnDwnAsset.Name = "btnDwnAsset";
            this.btnDwnAsset.Size = new System.Drawing.Size(53, 47);
            this.btnDwnAsset.TabIndex = 41;
            this.btnDwnAsset.Text = "Dwn";
            this.btnDwnAsset.UseVisualStyleBackColor = true;
            // 
            // btnUpAsset
            // 
            this.btnUpAsset.Location = new System.Drawing.Point(758, 322);
            this.btnUpAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpAsset.Name = "btnUpAsset";
            this.btnUpAsset.Size = new System.Drawing.Size(53, 47);
            this.btnUpAsset.TabIndex = 40;
            this.btnUpAsset.Text = "Up";
            this.btnUpAsset.UseVisualStyleBackColor = true;
            // 
            // btnRmvAsset
            // 
            this.btnRmvAsset.Location = new System.Drawing.Point(263, 377);
            this.btnRmvAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnRmvAsset.Name = "btnRmvAsset";
            this.btnRmvAsset.Size = new System.Drawing.Size(53, 47);
            this.btnRmvAsset.TabIndex = 39;
            this.btnRmvAsset.Text = "-";
            this.btnRmvAsset.UseVisualStyleBackColor = true;
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(263, 322);
            this.btnAddAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(53, 47);
            this.btnAddAsset.TabIndex = 38;
            this.btnAddAsset.Text = "+";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // btnTimeLine
            // 
            this.btnTimeLine.Location = new System.Drawing.Point(570, 12);
            this.btnTimeLine.Name = "btnTimeLine";
            this.btnTimeLine.Size = new System.Drawing.Size(242, 35);
            this.btnTimeLine.TabIndex = 42;
            this.btnTimeLine.Text = "Finalizar Configuracion >";
            this.btnTimeLine.UseVisualStyleBackColor = true;
            this.btnTimeLine.Click += new System.EventHandler(this.btnTimeLine_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 35);
            this.button1.TabIndex = 43;
            this.button1.Text = "< Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Archivo});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 87);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(242, 261);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Archivo
            // 
            this.Archivo.Text = "Archivo";
            this.Archivo.Width = 220;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(13, 386);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(242, 228);
            this.listView2.TabIndex = 45;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Archivo";
            this.columnHeader1.Width = 700;
            // 
            // TimeLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 630);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTimeLine);
            this.Controls.Add(this.btnDwnAsset);
            this.Controls.Add(this.btnUpAsset);
            this.Controls.Add(this.btnRmvAsset);
            this.Controls.Add(this.btnAddAsset);
            this.Controls.Add(this.tablaTimeline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeLine";
            this.Text = "TimeLine";
            this.Load += new System.EventHandler(this.TimeLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTimeline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView tablaTimeline;
        private System.Windows.Forms.Button btnDwnAsset;
        private System.Windows.Forms.Button btnUpAsset;
        private System.Windows.Forms.Button btnRmvAsset;
        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Button btnTimeLine;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Archivo;
        public System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}