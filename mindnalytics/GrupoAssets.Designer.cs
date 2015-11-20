﻿namespace mindnalytics
{
    partial class GrupoAssets
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnDwnAsset = new System.Windows.Forms.Button();
            this.btnUpAsset = new System.Windows.Forms.Button();
            this.btnRmvAsset = new System.Windows.Forms.Button();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.numZOrder = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tablaAssets = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAssets)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteGroup);
            this.groupBox1.Controls.Add(this.btnDwnAsset);
            this.groupBox1.Controls.Add(this.btnUpAsset);
            this.groupBox1.Controls.Add(this.btnRmvAsset);
            this.groupBox1.Controls.Add(this.btnAddAsset);
            this.groupBox1.Controls.Add(this.numZOrder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.tablaAssets);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 440);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grupo de Objetos de Aprendizaje # ";
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(588, 397);
            this.btnDeleteGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(228, 28);
            this.btnDeleteGroup.TabIndex = 38;
            this.btnDeleteGroup.Text = "Eliminar Grupo de Assets";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Visible = false;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // btnDwnAsset
            // 
            this.btnDwnAsset.Location = new System.Drawing.Point(762, 226);
            this.btnDwnAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnDwnAsset.Name = "btnDwnAsset";
            this.btnDwnAsset.Size = new System.Drawing.Size(53, 47);
            this.btnDwnAsset.TabIndex = 37;
            this.btnDwnAsset.Text = "Dwn";
            this.btnDwnAsset.UseVisualStyleBackColor = true;
            this.btnDwnAsset.Visible = false;
            this.btnDwnAsset.Click += new System.EventHandler(this.btnDwnAsset_Click);
            // 
            // btnUpAsset
            // 
            this.btnUpAsset.Location = new System.Drawing.Point(762, 154);
            this.btnUpAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpAsset.Name = "btnUpAsset";
            this.btnUpAsset.Size = new System.Drawing.Size(53, 47);
            this.btnUpAsset.TabIndex = 36;
            this.btnUpAsset.Text = "Up";
            this.btnUpAsset.UseVisualStyleBackColor = true;
            this.btnUpAsset.Visible = false;
            this.btnUpAsset.Click += new System.EventHandler(this.btnUpAsset_Click);
            // 
            // btnRmvAsset
            // 
            this.btnRmvAsset.Location = new System.Drawing.Point(14, 226);
            this.btnRmvAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnRmvAsset.Name = "btnRmvAsset";
            this.btnRmvAsset.Size = new System.Drawing.Size(53, 47);
            this.btnRmvAsset.TabIndex = 35;
            this.btnRmvAsset.Text = "-";
            this.btnRmvAsset.UseVisualStyleBackColor = true;
            this.btnRmvAsset.Click += new System.EventHandler(this.btnRmvAsset_Click);
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(14, 154);
            this.btnAddAsset.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(53, 47);
            this.btnAddAsset.TabIndex = 34;
            this.btnAddAsset.Text = "+";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // numZOrder
            // 
            this.numZOrder.Location = new System.Drawing.Point(676, 29);
            this.numZOrder.Margin = new System.Windows.Forms.Padding(4);
            this.numZOrder.Name = "numZOrder";
            this.numZOrder.Size = new System.Drawing.Size(77, 22);
            this.numZOrder.TabIndex = 33;
            this.numZOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numZOrder.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Orden Z :";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 27);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(440, 22);
            this.txtName.TabIndex = 28;
            // 
            // tablaAssets
            // 
            this.tablaAssets.AllowUserToAddRows = false;
            this.tablaAssets.AllowUserToDeleteRows = false;
            this.tablaAssets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAssets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.X,
            this.Y,
            this.Time,
            this.Path});
            this.tablaAssets.Location = new System.Drawing.Point(77, 71);
            this.tablaAssets.Margin = new System.Windows.Forms.Padding(5);
            this.tablaAssets.MultiSelect = false;
            this.tablaAssets.Name = "tablaAssets";
            this.tablaAssets.RowHeadersVisible = false;
            this.tablaAssets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaAssets.Size = new System.Drawing.Size(676, 318);
            this.tablaAssets.TabIndex = 27;
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
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Visible = false;
            this.X.Width = 40;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.Visible = false;
            this.Y.Width = 40;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time (S)";
            this.Time.Name = "Time";
            this.Time.Visible = false;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 800;
            // 
            // GrupoAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GrupoAssets";
            this.Size = new System.Drawing.Size(845, 451);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAssets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnDwnAsset;
        private System.Windows.Forms.Button btnUpAsset;
        private System.Windows.Forms.Button btnRmvAsset;
        private System.Windows.Forms.Button btnAddAsset;
        public System.Windows.Forms.NumericUpDown numZOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.DataGridView tablaAssets;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;


    }
}
