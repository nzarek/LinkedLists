using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Nicholas Zarek
 * Module 6 Programming Project
 * Part A
 * 
 * This program demonstrates push/pop of a stack.
 *
 */

namespace Zarek_Mod6Projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack myStack = new Stack();


        private void btnPush_Click(object sender, EventArgs e)
        {

            
            myStack.Push(txtInput.Text);

            lstBox.Items.Add(txtInput.Text);
            txtInput.Clear();
            txtInput.Focus();
            
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myStack.Pop().ToString());
            lstBox.Items.RemoveAt(lstBox.Items.Count - 1);
        }
    }
}