﻿namespace mindnalytics
{
    partial class CargarAssets
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnCargarAssets = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtNeutral = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddNewGroup = new System.Windows.Forms.Button();
            this.btnNeutral = new System.Windows.Forms.Button();
            this.btnTimeLine = new System.Windows.Forms.Button();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Archivo});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 49);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(207, 370);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Archivo
            // 
            this.Archivo.Text = "Archivo";
            this.Archivo.Width = 700;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(13, 13);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(207, 28);
            this.btnAddFile.TabIndex = 2;
            this.btnAddFile.Text = "Añadir Archivo";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel1.Controls.Add(this.imagen);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1154, 638);
            this.splitContainer1.SplitterDistance = 239;
            this.splitContainer1.TabIndex = 18;
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(13, 426);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(207, 200);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 3;
            this.imagen.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.btnCargarAssets);
            this.splitContainer2.Panel1.Controls.Add(this.btnPreview);
            this.splitContainer2.Panel1.Controls.Add(this.txtNeutral);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.btnAddNewGroup);
            this.splitContainer2.Panel1.Controls.Add(this.btnNeutral);
            this.splitContainer2.Panel1.Controls.Add(this.btnTimeLine);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Size = new System.Drawing.Size(911, 638);
            this.splitContainer2.SplitterDistance = 86;
            this.splitContainer2.TabIndex = 18;
            // 
            // btnCargarAssets
            // 
            this.btnCargarAssets.Location = new System.Drawing.Point(262, 49);
            this.btnCargarAssets.Name = "btnCargarAssets";
            this.btnCargarAssets.Size = new System.Drawing.Size(222, 35);
            this.btnCargarAssets.TabIndex = 30;
            this.btnCargarAssets.Text = "Cargar Grupo de Assets";
            this.btnCargarAssets.UseVisualStyleBackColor = true;
            this.btnCargarAssets.Visible = false;
            this.btnCargarAssets.Click += new System.EventHandler(this.btnCargarAssets_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(500, 49);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(164, 35);
            this.btnPreview.TabIndex = 29;
            this.btnPreview.Text = "Ver Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Visible = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtNeutral
            // 
            this.txtNeutral.Location = new System.Drawing.Point(138, 16);
            this.txtNeutral.Margin = new System.Windows.Forms.Padding(4);
            this.txtNeutral.Name = "txtNeutral";
            this.txtNeutral.Size = new System.Drawing.Size(691, 22);
            this.txtNeutral.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Imagen Calma :";
            // 
            // btnAddNewGroup
            // 
            this.btnAddNewGroup.Location = new System.Drawing.Point(23, 49);
            this.btnAddNewGroup.Name = "btnAddNewGroup";
            this.btnAddNewGroup.Size = new System.Drawing.Size(229, 35);
            this.btnAddNewGroup.TabIndex = 21;
            this.btnAddNewGroup.Text = "Añadir Nuevo Grupo de OA";
            this.btnAddNewGroup.UseVisualStyleBackColor = true;
            this.btnAddNewGroup.Click += new System.EventHandler(this.btnAddNewGroup_Click);
            // 
            // btnNeutral
            // 
            this.btnNeutral.Location = new System.Drawing.Point(837, 16);
            this.btnNeutral.Margin = new System.Windows.Forms.Padding(4);
            this.btnNeutral.Name = "btnNeutral";
            this.btnNeutral.Size = new System.Drawing.Size(25, 22);
            this.btnNeutral.TabIndex = 26;
            this.btnNeutral.Text = "...";
            this.btnNeutral.UseVisualStyleBackColor = true;
            this.btnNeutral.Click += new System.EventHandler(this.btnNeutral_Click_1);
            // 
            // btnTimeLine
            // 
            this.btnTimeLine.Location = new System.Drawing.Point(698, 49);
            this.btnTimeLine.Name = "btnTimeLine";
            this.btnTimeLine.Size = new System.Drawing.Size(201, 35);
            this.btnTimeLine.TabIndex = 25;
            this.btnTimeLine.Text = "Configurar Narrativas >";
            this.btnTimeLine.UseVisualStyleBackColor = true;
            this.btnTimeLine.Click += new System.EventHandler(this.btnTimeLine_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Selecciona la ubicacion del proyecto";
            // 
            // CargarAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1154, 638);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CargarAssets";
            this.Text = "Cargar Objetos de Aprendizaje";
            this.Load += new System.EventHandler(this.CargarAssets_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader Archivo;
        private GrupoAssets userControl11;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddNewGroup;
        private System.Windows.Forms.Button btnNeutral;
        private System.Windows.Forms.Button btnTimeLine;
        private System.Windows.Forms.Button btnCargarAssets;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TextBox txtNeutral;

        //GrupoAssets grupo = new GrupoAssets();
        #endregion

        

    }
}