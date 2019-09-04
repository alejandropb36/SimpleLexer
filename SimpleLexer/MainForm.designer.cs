﻿namespace SimpleLexer
{
    partial class MainForm
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
            this.textBoxContent1 = new System.Windows.Forms.TextBox();
            this.buttonSplitWords = new System.Windows.Forms.Button();
            this.textBoxContent2 = new System.Windows.Forms.TextBox();
            this.dataGridViewWords = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxContent1
            // 
            this.textBoxContent1.Location = new System.Drawing.Point(11, 11);
            this.textBoxContent1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContent1.Multiline = true;
            this.textBoxContent1.Name = "textBoxContent1";
            this.textBoxContent1.Size = new System.Drawing.Size(265, 336);
            this.textBoxContent1.TabIndex = 0;
            // 
            // buttonSplitWords
            // 
            this.buttonSplitWords.Location = new System.Drawing.Point(280, 79);
            this.buttonSplitWords.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSplitWords.Name = "buttonSplitWords";
            this.buttonSplitWords.Size = new System.Drawing.Size(73, 23);
            this.buttonSplitWords.TabIndex = 1;
            this.buttonSplitWords.Text = "Analyzer";
            this.buttonSplitWords.UseVisualStyleBackColor = true;
            this.buttonSplitWords.Click += new System.EventHandler(this.buttonSplitWords_Click);
            // 
            // textBoxContent2
            // 
            this.textBoxContent2.Location = new System.Drawing.Point(416, 11);
            this.textBoxContent2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContent2.Multiline = true;
            this.textBoxContent2.Name = "textBoxContent2";
            this.textBoxContent2.Size = new System.Drawing.Size(210, 115);
            this.textBoxContent2.TabIndex = 2;
            // 
            // dataGridViewWords
            // 
            this.dataGridViewWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lexema,
            this.Tipo,
            this.Id});
            this.dataGridViewWords.Location = new System.Drawing.Point(333, 131);
            this.dataGridViewWords.Name = "dataGridViewWords";
            this.dataGridViewWords.Size = new System.Drawing.Size(293, 236);
            this.dataGridViewWords.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(280, 32);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(73, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear all";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 379);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.dataGridViewWords);
            this.Controls.Add(this.textBoxContent2);
            this.Controls.Add(this.buttonSplitWords);
            this.Controls.Add(this.textBoxContent1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Simple Lexer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContent1;
        private System.Windows.Forms.Button buttonSplitWords;
        private System.Windows.Forms.TextBox textBoxContent2;
        private System.Windows.Forms.DataGridView dataGridViewWords;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

