namespace BaseballGameWindows
{
    partial class BaseGame
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
            this.tNumber1 = new System.Windows.Forms.TextBox();
            this.tNumber2 = new System.Windows.Forms.TextBox();
            this.tNumber3 = new System.Windows.Forms.TextBox();
            this.bInput = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tNumber1
            // 
            this.tNumber1.Location = new System.Drawing.Point(12, 12);
            this.tNumber1.Name = "tNumber1";
            this.tNumber1.Size = new System.Drawing.Size(100, 21);
            this.tNumber1.TabIndex = 0;
            // 
            // tNumber2
            // 
            this.tNumber2.Location = new System.Drawing.Point(12, 39);
            this.tNumber2.Name = "tNumber2";
            this.tNumber2.Size = new System.Drawing.Size(100, 21);
            this.tNumber2.TabIndex = 1;
            // 
            // tNumber3
            // 
            this.tNumber3.Location = new System.Drawing.Point(12, 66);
            this.tNumber3.Name = "tNumber3";
            this.tNumber3.Size = new System.Drawing.Size(100, 21);
            this.tNumber3.TabIndex = 2;
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(13, 103);
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(99, 64);
            this.bInput.TabIndex = 3;
            this.bInput.Text = "Play";
            this.bInput.UseVisualStyleBackColor = true;
            this.bInput.Click += new System.EventHandler(this.bInput_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(131, 12);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(67, 12);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Play Ball!!!";
            //this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(133, 103);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(97, 64);
            this.bClear.TabIndex = 5;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(133, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(103, 60);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BaseGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 194);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.tNumber3);
            this.Controls.Add(this.tNumber2);
            this.Controls.Add(this.tNumber1);
            this.Name = "BaseGame";
            this.Text = "BaseGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNumber1;
        private System.Windows.Forms.TextBox tNumber2;
        private System.Windows.Forms.TextBox tNumber3;
        private System.Windows.Forms.Button bInput;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.ListView listView1;
    }
}