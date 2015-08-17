namespace mindnalytics
{
    partial class CargarNarrativas
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Archivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnRmvAsset = new System.Windows.Forms.Button();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.tablaAssets = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimeLine = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Archivo});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 56);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(207, 393);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Archivo
            // 
            this.Archivo.Text = "Archivo";
            this.Archivo.Width = 700;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(13, 20);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(207, 28);
            this.btnAddFile.TabIndex = 4;
            this.btnAddFile.Text = "Añadir Archivo";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnRmvAsset
            // 
            this.btnRmvAsset.Location = new System.Drawing.Point(231, 240);
            this.btnRmvAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnRmvAsset.Name = "btnRmvAsset";
            this.btnRmvAsset.Size = new System.Drawing.Size(53, 47);
            this.btnRmvAsset.TabIndex = 38;
            this.btnRmvAsset.Text = "-";
            this.btnRmvAsset.UseVisualStyleBackColor = true;
            this.btnRmvAsset.Click += new System.EventHandler(this.btnRmvAsset_Click);
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(231, 174);
            this.btnAddAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(53, 47);
            this.btnAddAsset.TabIndex = 37;
            this.btnAddAsset.Text = "+";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // tablaAssets
            // 
            this.tablaAssets.AllowUserToAddRows = false;
            this.tablaAssets.AllowUserToDeleteRows = false;
            this.tablaAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Imagen,
            this.boton,
            this.Path});
            this.tablaAssets.Location = new System.Drawing.Point(293, 72);
            this.tablaAssets.Margin = new System.Windows.Forms.Padding(5);
            this.tablaAssets.MultiSelect = false;
            this.tablaAssets.Name = "tablaAssets";
            this.tablaAssets.RowHeadersVisible = false;
            this.tablaAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaAssets.Size = new System.Drawing.Size(715, 364);
            this.tablaAssets.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 35);
            this.button1.TabIndex = 44;
            this.button1.Text = "< Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimeLine
            // 
            this.btnTimeLine.Location = new System.Drawing.Point(766, 12);
            this.btnTimeLine.Name = "btnTimeLine";
            this.btnTimeLine.Size = new System.Drawing.Size(242, 35);
            this.btnTimeLine.TabIndex = 45;
            this.btnTimeLine.Text = "Configurar Timeline >";
            this.btnTimeLine.UseVisualStyleBackColor = true;
            this.btnTimeLine.Click += new System.EventHandler(this.btnTimeLine_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 140;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            // 
            // boton
            // 
            this.boton.HeaderText = "...";
            this.boton.Name = "boton";
            this.boton.Text = "...";
            this.boton.Width = 30;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 800;
            // 
            // CargarNarrativas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 466);
            this.Controls.Add(this.btnTimeLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRmvAsset);
            this.Controls.Add(this.btnAddAsset);
            this.Controls.Add(this.tablaAssets);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAddFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CargarNarrativas";
            this.Text = "CargarNarrativas";
            ((System.ComponentModel.ISupportInitialize)(this.tablaAssets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Archivo;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnRmvAsset;
        private System.Windows.Forms.Button btnAddAsset;
        public System.Windows.Forms.DataGridView tablaAssets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTimeLine;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imagen;
        private System.Windows.Forms.DataGridViewButtonColumn boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;

    }
}