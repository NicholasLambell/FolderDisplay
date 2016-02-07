namespace FolderDisplay {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnClearTV = new System.Windows.Forms.Button();
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.ilstTVImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnClearTV
            // 
            this.btnClearTV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTV.Location = new System.Drawing.Point(12, 12);
            this.btnClearTV.Name = "btnClearTV";
            this.btnClearTV.Size = new System.Drawing.Size(260, 23);
            this.btnClearTV.TabIndex = 2;
            this.btnClearTV.Text = "Clear List";
            this.btnClearTV.UseVisualStyleBackColor = true;
            this.btnClearTV.Click += new System.EventHandler(this.btnClearTV_Click);
            // 
            // tvFiles
            // 
            this.tvFiles.AllowDrop = true;
            this.tvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvFiles.Location = new System.Drawing.Point(12, 41);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.Size = new System.Drawing.Size(259, 290);
            this.tvFiles.TabIndex = 3;
            this.tvFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvFiles_DragDrop);
            this.tvFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvFiles_DragEnter);
            // 
            // ilstTVImages
            // 
            this.ilstTVImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilstTVImages.ImageSize = new System.Drawing.Size(16, 16);
            this.ilstTVImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 343);
            this.Controls.Add(this.tvFiles);
            this.Controls.Add(this.btnClearTV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 382);
            this.Name = "FormMain";
            this.Text = "Folder Display";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClearTV;
        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.ImageList ilstTVImages;
    }
}