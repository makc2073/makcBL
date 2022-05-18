
namespace Деловые_дамы1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddFrom = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.Del = new System.Windows.Forms.Button();
            this.UpdBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddFrom
            // 
            this.AddFrom.Location = new System.Drawing.Point(12, 402);
            this.AddFrom.Name = "AddFrom";
            this.AddFrom.Size = new System.Drawing.Size(75, 23);
            this.AddFrom.TabIndex = 1;
            this.AddFrom.Text = "AddFrom";
            this.AddFrom.UseVisualStyleBackColor = true;
            this.AddFrom.Click += new System.EventHandler(this.AddFrom_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(12, 347);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(42, 20);
            this.ID.TabIndex = 2;
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(12, 373);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 3;
            this.Del.Text = "Delete";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // UpdBtn
            // 
            this.UpdBtn.Location = new System.Drawing.Point(93, 373);
            this.UpdBtn.Name = "UpdBtn";
            this.UpdBtn.Size = new System.Drawing.Size(75, 22);
            this.UpdBtn.TabIndex = 4;
            this.UpdBtn.Text = "Update";
            this.UpdBtn.UseVisualStyleBackColor = true;
            this.UpdBtn.Click += new System.EventHandler(this.UpdBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "- выбранный ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdBtn);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.AddFrom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddFrom;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button UpdBtn;
        private System.Windows.Forms.Label label1;
    }
}

