namespace SimpleTournament
{
    partial class Init
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_selall = new System.Windows.Forms.Button();
            this.btn_deselall = new System.Windows.Forms.Button();
            this.btn_delsel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.tbx_newitem = new System.Windows.Forms.TextBox();
            this.btn_revorder = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.Lstbx_Items = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_selall
            // 
            this.btn_selall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_selall.Enabled = false;
            this.btn_selall.Location = new System.Drawing.Point(12, 383);
            this.btn_selall.Name = "btn_selall";
            this.btn_selall.Size = new System.Drawing.Size(95, 33);
            this.btn_selall.TabIndex = 2;
            this.btn_selall.Text = "모두 선택";
            this.btn_selall.UseVisualStyleBackColor = true;
            this.btn_selall.Click += new System.EventHandler(this.btn_selall_Click);
            // 
            // btn_deselall
            // 
            this.btn_deselall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deselall.Enabled = false;
            this.btn_deselall.Location = new System.Drawing.Point(113, 383);
            this.btn_deselall.Name = "btn_deselall";
            this.btn_deselall.Size = new System.Drawing.Size(130, 33);
            this.btn_deselall.TabIndex = 3;
            this.btn_deselall.Text = "모두 선택해제";
            this.btn_deselall.UseVisualStyleBackColor = true;
            this.btn_deselall.Click += new System.EventHandler(this.btn_deselall_Click);
            // 
            // btn_delsel
            // 
            this.btn_delsel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delsel.Enabled = false;
            this.btn_delsel.Location = new System.Drawing.Point(249, 383);
            this.btn_delsel.Name = "btn_delsel";
            this.btn_delsel.Size = new System.Drawing.Size(155, 33);
            this.btn_delsel.TabIndex = 4;
            this.btn_delsel.Text = "선택한 항목 삭제";
            this.btn_delsel.UseVisualStyleBackColor = true;
            this.btn_delsel.Click += new System.EventHandler(this.btn_delsel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(612, 383);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(157, 33);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "입력한 항목 추가";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tbx_newitem
            // 
            this.tbx_newitem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_newitem.Location = new System.Drawing.Point(13, 349);
            this.tbx_newitem.Name = "tbx_newitem";
            this.tbx_newitem.Size = new System.Drawing.Size(756, 28);
            this.tbx_newitem.TabIndex = 6;
            this.tbx_newitem.TextChanged += new System.EventHandler(this.tbx_newitem_TextChanged);
            // 
            // btn_revorder
            // 
            this.btn_revorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_revorder.Enabled = false;
            this.btn_revorder.Location = new System.Drawing.Point(410, 383);
            this.btn_revorder.Name = "btn_revorder";
            this.btn_revorder.Size = new System.Drawing.Size(196, 33);
            this.btn_revorder.TabIndex = 7;
            this.btn_revorder.Text = "선택한 항목 순서 반전";
            this.btn_revorder.UseVisualStyleBackColor = true;
            this.btn_revorder.Click += new System.EventHandler(this.btn_revorder_Click);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(13, 423);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(756, 48);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "시작!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Lstbx_Items
            // 
            this.Lstbx_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lstbx_Items.FormattingEnabled = true;
            this.Lstbx_Items.ItemHeight = 18;
            this.Lstbx_Items.Location = new System.Drawing.Point(12, 12);
            this.Lstbx_Items.Name = "Lstbx_Items";
            this.Lstbx_Items.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Lstbx_Items.Size = new System.Drawing.Size(757, 328);
            this.Lstbx_Items.TabIndex = 9;
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 483);
            this.Controls.Add(this.Lstbx_Items);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_revorder);
            this.Controls.Add(this.tbx_newitem);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delsel);
            this.Controls.Add(this.btn_deselall);
            this.Controls.Add(this.btn_selall);
            this.MinimumSize = new System.Drawing.Size(803, 539);
            this.Name = "Init";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_selall;
        private System.Windows.Forms.Button btn_deselall;
        private System.Windows.Forms.Button btn_delsel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tbx_newitem;
        private System.Windows.Forms.Button btn_revorder;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ListBox Lstbx_Items;
    }
}

