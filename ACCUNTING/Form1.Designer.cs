namespace ACCUNTING
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInsertCustuomer = new System.Windows.Forms.ToolStripButton();
            this.btnInsertReport = new System.Windows.Forms.ToolStripButton();
            this.btnRecevid = new System.Windows.Forms.ToolStripButton();
            this.btnPayments = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnSeting = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecive = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblAccountBalanse = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsertCustuomer,
            this.btnInsertReport,
            this.btnRecevid,
            this.btnPayments,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInsertCustuomer
            // 
            this.btnInsertCustuomer.Image = global::ACCUNTING.Properties.Resources._1371476468_preferences_contact_list;
            this.btnInsertCustuomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInsertCustuomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsertCustuomer.Name = "btnInsertCustuomer";
            this.btnInsertCustuomer.Size = new System.Drawing.Size(71, 59);
            this.btnInsertCustuomer.Text = "طرف حساب";
            this.btnInsertCustuomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInsertCustuomer.ToolTipText = "طرف حساب";
            this.btnInsertCustuomer.Click += new System.EventHandler(this.BtnInsertCustuomer_Click);
            // 
            // btnInsertReport
            // 
            this.btnInsertReport.Image = global::ACCUNTING.Properties.Resources.list2;
            this.btnInsertReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInsertReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInsertReport.Name = "btnInsertReport";
            this.btnInsertReport.Size = new System.Drawing.Size(68, 59);
            this.btnInsertReport.Text = "گزارش جدید";
            this.btnInsertReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInsertReport.ToolTipText = "گزارش جدید";
            this.btnInsertReport.Click += new System.EventHandler(this.BtnInsertReport_Click);
            // 
            // btnRecevid
            // 
            this.btnRecevid.Image = global::ACCUNTING.Properties.Resources._1370791030_credit_card;
            this.btnRecevid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRecevid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecevid.Name = "btnRecevid";
            this.btnRecevid.Size = new System.Drawing.Size(98, 59);
            this.btnRecevid.Text = "گزارش دریافتی ها";
            this.btnRecevid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecevid.Click += new System.EventHandler(this.BtnRecevid_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Image = global::ACCUNTING.Properties.Resources.servicesCosts;
            this.btnPayments.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPayments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(97, 59);
            this.btnPayments.Text = "گزارش پرداختی ها";
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPayments.Click += new System.EventHandler(this.BtnPayments_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSeting});
            this.toolStripDropDownButton3.Image = global::ACCUNTING.Properties.Resources.FILE0271;
            this.toolStripDropDownButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(66, 59);
            this.toolStripDropDownButton3.Text = "تنظیمات ";
            this.toolStripDropDownButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSeting
            // 
            this.btnSeting.Image = global::ACCUNTING.Properties.Resources.User_login;
            this.btnSeting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSeting.Name = "btnSeting";
            this.btnSeting.Size = new System.Drawing.Size(166, 46);
            this.btnSeting.Text = "تنظیمات ورود";
            this.btnSeting.Click += new System.EventHandler(this.BtnSeting_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(118, 17);
            this.lblDate.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 17);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ACCUNTING.Properties.Resources.Untitled_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.lblAccountBalanse);
            this.groupBox1.Controls.Add(this.lblPay);
            this.groupBox1.Controls.Add(this.lblRecive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(333, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش ماه جاری";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(259, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی ها :";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(259, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "پرداختی ها :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(259, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "مانده حساب :";
            // 
            // lblRecive
            // 
            this.lblRecive.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblRecive.Location = new System.Drawing.Point(6, 26);
            this.lblRecive.Name = "lblRecive";
            this.lblRecive.Size = new System.Drawing.Size(237, 17);
            this.lblRecive.TabIndex = 3;
            this.lblRecive.Text = "0";
            // 
            // lblPay
            // 
            this.lblPay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPay.Location = new System.Drawing.Point(6, 52);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(237, 17);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "0";
            // 
            // lblAccountBalanse
            // 
            this.lblAccountBalanse.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblAccountBalanse.Location = new System.Drawing.Point(6, 78);
            this.lblAccountBalanse.Name = "lblAccountBalanse";
            this.lblAccountBalanse.Size = new System.Drawing.Size(237, 17);
            this.lblAccountBalanse.TabIndex = 5;
            this.lblAccountBalanse.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(259, 107);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 21);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnInsertCustuomer;
        private System.Windows.Forms.ToolStripButton btnInsertReport;
        private System.Windows.Forms.ToolStripButton btnRecevid;
        private System.Windows.Forms.ToolStripButton btnPayments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem btnSeting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountBalanse;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblRecive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
    }
}

