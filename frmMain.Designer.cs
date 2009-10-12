
partial class frmMain
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
        this.richTextBox2 = new System.Windows.Forms.RichTextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.rbtSourceCode = new System.Windows.Forms.RichTextBox();
        this.button3 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // richTextBox2
        // 
        this.richTextBox2.Location = new System.Drawing.Point(279, 46);
        this.richTextBox2.Name = "richTextBox2";
        this.richTextBox2.Size = new System.Drawing.Size(249, 221);
        this.richTextBox2.TabIndex = 1;
        this.richTextBox2.Text = "";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(14, 24);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(101, 13);
        this.label1.TabIndex = 2;
        this.label1.Text = "SPINA source code";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(282, 24);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(78, 13);
        this.label2.TabIndex = 3;
        this.label2.Text = "OutputWindow";
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(27, 289);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(75, 23);
        this.button1.TabIndex = 4;
        this.button1.Text = "&Load";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(168, 289);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(75, 23);
        this.button2.TabIndex = 5;
        this.button2.Text = "&Save";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // rbtSourceCode
        // 
        this.rbtSourceCode.Location = new System.Drawing.Point(17, 45);
        this.rbtSourceCode.Name = "rbtSourceCode";
        this.rbtSourceCode.Size = new System.Drawing.Size(235, 223);
        this.rbtSourceCode.TabIndex = 0;
        this.rbtSourceCode.Text = "a=[1,2,3;4,5,6];\nb=[2;4;6];\nc=a*b;\nprint c;\nprint a;\nprint b;";
        // 
        // button3
        // 
        this.button3.Location = new System.Drawing.Point(370, 289);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(75, 23);
        this.button3.TabIndex = 6;
        this.button3.Text = "&Run";
        this.button3.UseVisualStyleBackColor = true;
        this.button3.Click += new System.EventHandler(this.button3_Click);
        // 
        // frmMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(540, 359);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.richTextBox2);
        this.Controls.Add(this.rbtSourceCode);
        this.MaximizeBox = false;
        this.Name = "frmMain";
        this.Text = "SPINA";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox richTextBox2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.RichTextBox rbtSourceCode;
    private System.Windows.Forms.Button button3;
}