﻿namespace ArtCatalog
{
    partial class AddProduct
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
            this.pName = new System.Windows.Forms.TextBox();
            this.pDiscript = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pPrice = new System.Windows.Forms.NumericUpDown();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(115, 21);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(188, 20);
            this.pName.TabIndex = 1;
            // 
            // pDiscript
            // 
            this.pDiscript.Location = new System.Drawing.Point(115, 47);
            this.pDiscript.Name = "pDiscript";
            this.pDiscript.Size = new System.Drawing.Size(188, 20);
            this.pDiscript.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество";
            // 
            // pCount
            // 
            this.pCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pCount.Location = new System.Drawing.Point(115, 76);
            this.pCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pCount.Name = "pCount";
            this.pCount.Size = new System.Drawing.Size(188, 20);
            this.pCount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена";
            // 
            // pPrice
            // 
            this.pPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pPrice.Location = new System.Drawing.Point(115, 103);
            this.pPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.pPrice.Name = "pPrice";
            this.pPrice.Size = new System.Drawing.Size(188, 20);
            this.pPrice.TabIndex = 7;
            // 
            // filePath
            // 
            this.filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filePath.Location = new System.Drawing.Point(29, 150);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(223, 22);
            this.filePath.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Путь к картинке";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(258, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFile
            // 
            this.openFile.Filter = "Изображения JPEG (*.jpg)|*.jpg| Изображение PNG  (*.png)|*.png";
            this.openFile.Title = "Выберите файл с изображением товара";
            // 
            // picture
            // 
            this.picture.Image = global::ArtCatalog.Properties.Resources.product_default;
            this.picture.Location = new System.Drawing.Point(331, 24);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(236, 185);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 12;
            this.picture.TabStop = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 225);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.pPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pDiscript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добаление продукта";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox pName;
        protected System.Windows.Forms.TextBox pDiscript;
        protected System.Windows.Forms.NumericUpDown pCount;
        protected System.Windows.Forms.NumericUpDown pPrice;
        protected System.Windows.Forms.TextBox filePath;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.PictureBox picture;
        protected System.Windows.Forms.OpenFileDialog openFile;
    }
}