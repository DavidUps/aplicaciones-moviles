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

namespace herenciasVisual
{
    public partial class Form1 : Form
    {

        ArrayList order = new ArrayList();
        int computerCount = 0;
        public void orderNotVisible()
        {
            operativeSistem_TextBox.Visible = false;
            batery_TextBox.Visible = false;
            memori_TextBox.Visible = false;
            resolution_TextBox.Visible = false;
            speed_TextBox.Visible = false;
            port_TextBox.Visible = false;
        }  
        
        //Añadir elemento de la clase
        
        public Form1()
        {
            InitializeComponent();
        }

        private void order_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (order_ComboBox.SelectedIndex == 0)
            {
                orderNotVisible();
                speed_TextBox.Visible = true;
                port_TextBox.Visible = true;
            }
            if(order_ComboBox.SelectedIndex == 1)
            {
                orderNotVisible();
                resolution_TextBox.Visible = true;
                batery_TextBox.Visible = true;
            }
            if(order_ComboBox.SelectedIndex == 2)
            {
                orderNotVisible();
                operativeSistem_TextBox.Visible = true;
                batery_TextBox.Visible = true;
                memori_TextBox.Visible = true;
            }
        }

        private void addOrder_Button_Click(object sender, EventArgs e)
        {
            if(order_ComboBox.SelectedIndex == 0)
            {
                
                order.Add(new Computer());
            }
        }
    }
}
