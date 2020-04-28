namespace SimpleTournament
{
    partial class main
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
            this.btn_item1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_item2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_item1
            // 
            this.btn_item1.Location = new System.Drawing.Point(13, 13);
            this.btn_item1.Name = "btn_item1";
            this.btn_item1.Size = new System.Drawing.Size(775, 99);
            this.btn_item1.TabIndex = 0;
            this.btn_item1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F);
            this.label1.Location = new System.Drawing.Point(379, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "vs";
            // 
            // btn_item2
            // 
            this.btn_item2.Location = new System.Drawing.Point(13, 142);
            this.btn_item2.Name = "btn_item2";
            this.btn_item2.Size = new System.Drawing.Size(775, 99);
            this.btn_item2.TabIndex = 2;
            this.btn_item2.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 253);
            this.Controls.Add(this.btn_item2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_item1);
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_item1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_item2;
    }
}