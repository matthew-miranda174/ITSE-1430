namespace Nile.Windows
{
    partial class ProductDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this._TextName = new System.Windows.Forms.TextBox();
            this._TextDescription = new System.Windows.Forms.TextBox();
            this._TextPrice = new System.Windows.Forms.TextBox();
            this._checkIsDiscontinued = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _TextName
            // 
            this._TextName.Location = new System.Drawing.Point(139, 40);
            this._TextName.Name = "_TextName";
            this._TextName.Size = new System.Drawing.Size(100, 20);
            this._TextName.TabIndex = 0;
            // 
            // _TextDescription
            // 
            this._TextDescription.Location = new System.Drawing.Point(139, 81);
            this._TextDescription.Multiline = true;
            this._TextDescription.Name = "_TextDescription";
            this._TextDescription.Size = new System.Drawing.Size(166, 42);
            this._TextDescription.TabIndex = 1;
            // 
            // _TextPrice
            // 
            this._TextPrice.Location = new System.Drawing.Point(139, 129);
            this._TextPrice.Name = "_TextPrice";
            this._TextPrice.Size = new System.Drawing.Size(100, 20);
            this._TextPrice.TabIndex = 2;
            // 
            // _checkIsDiscontinued
            // 
            this._checkIsDiscontinued.AutoSize = true;
            this._checkIsDiscontinued.Location = new System.Drawing.Point(139, 161);
            this._checkIsDiscontinued.Name = "_checkIsDiscontinued";
            this._checkIsDiscontinued.Size = new System.Drawing.Size(126, 17);
            this._checkIsDiscontinued.TabIndex = 3;
            this._checkIsDiscontinued.Text = "checkIsDiscontinued";
            this._checkIsDiscontinued.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(135, 197);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.OnSave);
            // 
            // buttonCancle
            // 
            this.buttonCancle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancle.Location = new System.Drawing.Point(216, 197);
            this.buttonCancle.Name = "buttonCancle";
            this.buttonCancle.Size = new System.Drawing.Size(75, 23);
            this.buttonCancle.TabIndex = 5;
            this.buttonCancle.Text = "Cancle";
            this.buttonCancle.UseVisualStyleBackColor = true;
            this.buttonCancle.Click += new System.EventHandler(this.OnCancle);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // ProductDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancle);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this._checkIsDiscontinued);
            this.Controls.Add(this._TextPrice);
            this.Controls.Add(this._TextDescription);
            this.Controls.Add(this._TextName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductDetailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _TextName;
        private System.Windows.Forms.TextBox _TextDescription;
        private System.Windows.Forms.TextBox _TextPrice;
        private System.Windows.Forms.CheckBox _checkIsDiscontinued;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}