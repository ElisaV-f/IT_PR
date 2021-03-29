
namespace PR_6
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.richTextBox2 = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(464, 53);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(180, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "Преобразованный массив";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(117, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(123, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Исходный массив";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(139, 397);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(89, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Заполнить";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(491, 397);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(102, 23);
      this.button2.TabIndex = 5;
      this.button2.Text = "Рассчитать";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(98, 90);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(185, 281);
      this.richTextBox1.TabIndex = 8;
      this.richTextBox1.Text = "";
      // 
      // richTextBox2
      // 
      this.richTextBox2.Location = new System.Drawing.Point(467, 90);
      this.richTextBox2.Name = "richTextBox2";
      this.richTextBox2.Size = new System.Drawing.Size(185, 281);
      this.richTextBox2.TabIndex = 9;
      this.richTextBox2.Text = "";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.richTextBox2);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.RichTextBox richTextBox2;
  }
}

