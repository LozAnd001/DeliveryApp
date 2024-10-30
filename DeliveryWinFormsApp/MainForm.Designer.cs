namespace DeliveryWinFormsApp
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            сортировкаЗаказовToolStripMenuItem = new ToolStripMenuItem();
            добавитьЗаказToolStripMenuItem = new ToolStripMenuItem();
            districtBindingSource = new BindingSource(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)districtBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(23, 109);
            label1.Name = "label1";
            label1.Size = new Size(836, 46);
            label1.TabIndex = 0;
            label1.Text = "Вас приветствует приложение для службы доставки";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { сортировкаЗаказовToolStripMenuItem, добавитьЗаказToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(871, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаЗаказовToolStripMenuItem
            // 
            сортировкаЗаказовToolStripMenuItem.Name = "сортировкаЗаказовToolStripMenuItem";
            сортировкаЗаказовToolStripMenuItem.Size = new Size(164, 24);
            сортировкаЗаказовToolStripMenuItem.Text = "Сортировка заказов";
            сортировкаЗаказовToolStripMenuItem.Click += сортировкаЗаказовToolStripMenuItem_Click;
            // 
            // добавитьЗаказToolStripMenuItem
            // 
            добавитьЗаказToolStripMenuItem.Name = "добавитьЗаказToolStripMenuItem";
            добавитьЗаказToolStripMenuItem.Size = new Size(131, 24);
            добавитьЗаказToolStripMenuItem.Text = "Добавить заказ";
            добавитьЗаказToolStripMenuItem.Click += добавитьЗаказToolStripMenuItem_Click;
            // 
            // districtBindingSource
            // 
            districtBindingSource.DataSource = typeof(DeliveryApp.Db.Models.District);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 304);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)districtBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem сортировкаЗаказовToolStripMenuItem;
        private ToolStripMenuItem добавитьЗаказToolStripMenuItem;
        private BindingSource districtBindingSource;
    }
}
