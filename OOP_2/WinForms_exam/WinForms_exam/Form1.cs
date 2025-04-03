using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_exam
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private TextBox inputField;
        private string currentText = "";
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private int currentIndex = 0;

        public Form1()
        {
           
            this.Text = "Буквенное приложение";
            this.Size = new System.Drawing.Size(400, 200);
            this.StartPosition = FormStartPosition.CenterScreen;

           
            inputField = new TextBox();
            this.Controls.Add(inputField);

            Button addButton = new Button();
            addButton.Text = "Добавить букву";
            addButton.Location = new System.Drawing.Point(50, 80);
            addButton.Size = new System.Drawing.Size(100, 30);
            addButton.Click += button3_Click;
            this.Controls.Add(addButton);

            Button deleteButton = new Button();
            deleteButton.Text = "Удалить букву";
            deleteButton.Location = new System.Drawing.Point(150, 80);
            deleteButton.Size = new System.Drawing.Size(100, 30);
            deleteButton.Click += button2_Click;
            this.Controls.Add(deleteButton);

            Button duplicateButton = new Button();
            duplicateButton.Text = "Дублировать букву";
            duplicateButton.Location = new System.Drawing.Point(250, 80);
            duplicateButton.Size = new System.Drawing.Size(100, 30);
            duplicateButton.Click += button1_Click;
            this.Controls.Add(duplicateButton);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentText += alphabet[currentIndex];
            currentIndex = (currentIndex + 1) % alphabet.Length;
            inputField.Text = currentText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentText.Length > 0)
            {
                currentText = currentText.Substring(0, currentText.Length - 1);
                inputField.Text = currentText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentText.Length > 0)
            {
                currentText += currentText[currentText.Length - 1];
                inputField.Text = currentText;
            }
        }

        
    }
    
}
