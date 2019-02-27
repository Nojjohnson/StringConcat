namespace StringConcat
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btn_AddWord = new System.Windows.Forms.Button();
      this.cbox_WordOne = new System.Windows.Forms.ComboBox();
      this.cbox_WordTwo = new System.Windows.Forms.ComboBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.rbtn_RemoveWordOne = new System.Windows.Forms.RadioButton();
      this.rbtn_RemoveWordTwo = new System.Windows.Forms.RadioButton();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(353, 87);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 0;
      // 
      // btn_AddWord
      // 
      this.btn_AddWord.Location = new System.Drawing.Point(364, 38);
      this.btn_AddWord.Name = "btn_AddWord";
      this.btn_AddWord.Size = new System.Drawing.Size(75, 23);
      this.btn_AddWord.TabIndex = 1;
      this.btn_AddWord.Text = "Add Word";
      this.btn_AddWord.UseVisualStyleBackColor = true;
      this.btn_AddWord.Click += new System.EventHandler(this.btn_AddWord_Click);
      // 
      // cbox_WordOne
      // 
      this.cbox_WordOne.FormattingEnabled = true;
      this.cbox_WordOne.Location = new System.Drawing.Point(92, 217);
      this.cbox_WordOne.Name = "cbox_WordOne";
      this.cbox_WordOne.Size = new System.Drawing.Size(121, 21);
      this.cbox_WordOne.TabIndex = 2;
      // 
      // cbox_WordTwo
      // 
      this.cbox_WordTwo.FormattingEnabled = true;
      this.cbox_WordTwo.Location = new System.Drawing.Point(563, 217);
      this.cbox_WordTwo.Name = "cbox_WordTwo";
      this.cbox_WordTwo.Size = new System.Drawing.Size(121, 21);
      this.cbox_WordTwo.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(342, 264);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(131, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Concat or Remove";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label1.Location = new System.Drawing.Point(0, 437);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "label1";
      // 
      // rbtn_RemoveWordOne
      // 
      this.rbtn_RemoveWordOne.AutoSize = true;
      this.rbtn_RemoveWordOne.Location = new System.Drawing.Point(113, 244);
      this.rbtn_RemoveWordOne.Name = "rbtn_RemoveWordOne";
      this.rbtn_RemoveWordOne.Size = new System.Drawing.Size(65, 17);
      this.rbtn_RemoveWordOne.TabIndex = 6;
      this.rbtn_RemoveWordOne.TabStop = true;
      this.rbtn_RemoveWordOne.Text = "Remove";
      this.rbtn_RemoveWordOne.UseVisualStyleBackColor = true;
      // 
      // rbtn_RemoveWordTwo
      // 
      this.rbtn_RemoveWordTwo.AutoSize = true;
      this.rbtn_RemoveWordTwo.Location = new System.Drawing.Point(584, 244);
      this.rbtn_RemoveWordTwo.Name = "rbtn_RemoveWordTwo";
      this.rbtn_RemoveWordTwo.Size = new System.Drawing.Size(65, 17);
      this.rbtn_RemoveWordTwo.TabIndex = 7;
      this.rbtn_RemoveWordTwo.TabStop = true;
      this.rbtn_RemoveWordTwo.Text = "Remove";
      this.rbtn_RemoveWordTwo.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.rbtn_RemoveWordTwo);
      this.Controls.Add(this.rbtn_RemoveWordOne);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.cbox_WordTwo);
      this.Controls.Add(this.cbox_WordOne);
      this.Controls.Add(this.btn_AddWord);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btn_AddWord;
    private System.Windows.Forms.ComboBox cbox_WordOne;
    private System.Windows.Forms.ComboBox cbox_WordTwo;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton rbtn_RemoveWordOne;
    private System.Windows.Forms.RadioButton rbtn_RemoveWordTwo;
  }
}

