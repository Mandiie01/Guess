using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Guess
{
    public partial class Form1 : Form
    {
        string[] movies = { "Moana", "Descendant", "Cruella" };

        public Form1()
        {
            InitializeComponent();
        }

        Random rand;
        string[] words = { "" };
        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] movies = { "Moana", "Descendant", "Cruella" };
            Random rand = new Random();
            int index = rand.Next(0, movies.Length);
            string guess = textBox1.Text;
            if (guess == movies[index])
            {
                MessageBox.Show(movies + "Correct answer.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show(movies + "Incorrect answer.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            string[] hints = { "A strong-willed daughter of a chief of a coastal village, who is chosen by the ocean itself to reunite a mystical relic with the goddess Te Fiti.", " It’s a musical fantasy adventure-comedy that features the teenage children of famous Disney villains, such as Maleficent, the Evil Queen, Jafar, and Cruella de Vil. The film explores themes of self-empowerment, friendship, and questioning one’s identity.", " It’s a dark comedy about ambition, greed, corporate sabotage, revenge, class conflict, high fashion, and murder. The movie stars Emma Stone and Emma Thompson in lead roles and is set in 1970s England." };
            Random random = new Random();
            int randomIndex = random.Next(0, movies.Length);
            /*randomIndex = int.Parse(lblHints.Text);*/
            string randomHint = hints[randomIndex];


            for (int i = 1; i == hints.Length; i += 3)
            {
                lblHints.Text = {"A strong-willed daughter of a chief of a coastal village,\n who is chosen by the ocean itself to reunite a mystical \n with the goddess Te Fiti.", " It’s a musical fantasy adventure-comedy that features\n the teenage children of famous Disney villains, such as Maleficent,\n the Evil Queen, Jafar, and Cruella de Vil. The film explores\n themes of self-empowerment, friendship, and questioning one’s identity.", " It’s a dark comedy about ambition, greed, corporate \nsabotage, revenge, class conflict, high fashion,\n and murder. The movie stars Emma Stone and Emma \nThompson in lead roles and is set in 1970s England."};
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            lblHints.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
