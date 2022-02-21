
namespace NoteTakingApp
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.msgDataGridView = new System.Windows.Forms.DataGridView();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.msgDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(409, 392);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(490, 392);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(247, 392);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // msgDataGridView
            // 
            this.msgDataGridView.AllowUserToAddRows = false;
            this.msgDataGridView.AllowUserToDeleteRows = false;
            this.msgDataGridView.AllowUserToResizeColumns = false;
            this.msgDataGridView.AllowUserToResizeRows = false;
            this.msgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msgDataGridView.Location = new System.Drawing.Point(499, 60);
            this.msgDataGridView.Name = "msgDataGridView";
            this.msgDataGridView.ReadOnly = true;
            this.msgDataGridView.RowHeadersVisible = false;
            this.msgDataGridView.Size = new System.Drawing.Size(240, 290);
            this.msgDataGridView.TabIndex = 4;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(97, 121);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(343, 229);
            this.txtMessage.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(343, 20);
            this.txtName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.msgDataGridView);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Note Taking App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msgDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView msgDataGridView;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

