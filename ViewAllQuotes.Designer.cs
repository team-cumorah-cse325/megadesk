﻿namespace megaDesk
{
    partial class ViewAllQuotes
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
            button1 = new Button();
            quotesView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)quotesView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 307);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // quotesView
            // 
            quotesView.BackgroundColor = SystemColors.Window;
            quotesView.BorderStyle = BorderStyle.Fixed3D;
            quotesView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            quotesView.Location = new Point(10, 12);
            quotesView.Name = "quotesView";
            quotesView.Size = new Size(678, 286);
            quotesView.TabIndex = 1;
            // 
            // ViewAllQuotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(quotesView);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewAllQuotes";
            Text = "View All Quotes";
            ((System.ComponentModel.ISupportInitialize)quotesView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView quotesView;
    }
}