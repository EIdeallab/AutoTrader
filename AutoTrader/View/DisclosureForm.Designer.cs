namespace AutoTrader.View
{
    partial class DisclosureForm
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
            this.disclosureListview = new System.Windows.Forms.ListView();
            this.disclosureTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disclosureDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // disclosureListview
            // 
            this.disclosureListview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disclosureListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.disclosureTitle,
            this.disclosureDate});
            this.disclosureListview.HideSelection = false;
            this.disclosureListview.Location = new System.Drawing.Point(-2, 0);
            this.disclosureListview.Margin = new System.Windows.Forms.Padding(0);
            this.disclosureListview.Name = "disclosureListview";
            this.disclosureListview.Size = new System.Drawing.Size(800, 450);
            this.disclosureListview.TabIndex = 0;
            this.disclosureListview.UseCompatibleStateImageBehavior = false;
            this.disclosureListview.View = System.Windows.Forms.View.Details;
            this.disclosureListview.Click += new System.EventHandler(this.DisclosureList_Click);
            // 
            // disclosureTitle
            // 
            this.disclosureTitle.Text = "공시";
            this.disclosureTitle.Width = 550;
            // 
            // disclosureDate
            // 
            this.disclosureDate.Text = "일자";
            this.disclosureDate.Width = 100;
            // 
            // DisclosureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.disclosureListview);
            this.Name = "DisclosureForm";
            this.Text = "DartForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView disclosureListview;
        private System.Windows.Forms.ColumnHeader disclosureDate;
        private System.Windows.Forms.ColumnHeader disclosureTitle;
    }
}