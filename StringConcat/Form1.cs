using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringConcat
{
  public partial class Form1 : Form
  {
    List<string> firstWord = new List<string>();
    List<string> secondWord = new List<string>();
    public Form1()
    {
      InitializeComponent();
    }



    private void btn_AddWord_Click(object sender, EventArgs e)
    {
      if (firstWord.Contains(textBox1.Text))
      {
        if (secondWord.Contains(textBox1.Text))
        {
          MessageBox.Show("Word exists in both drop down boxes, please enter another word!");
        }
        else
        {
          secondWord.Add(textBox1.Text);
          cbox_WordTwo.Items.Add(secondWord);
        }
      }
      else
      {
        firstWord.Add(textBox1.Text);
        cbox_WordOne.Items.Add(firstWord);
      }
    }
  }
}
