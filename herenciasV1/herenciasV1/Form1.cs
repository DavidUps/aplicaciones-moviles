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

namespace herenciasV1
{
    public partial class Form1 : Form
    {

        ArrayList order = new ArrayList();
        

        public Form1()
        {
            InitializeComponent();
        }

        //Text view don´t visible
        public void orderNotVisible()
        {
            operativeSistem_Order.Visible = false;
            batery_Order.Visible = false;
            memory_Order.Visible = false;
            resolution_Order.Visible = false;
            speed_Order.Visible = false;
            ports_Order.Visible = false;
        }

        //Combo Order
        private void combo_Order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Order.SelectedIndex == 0)
            {
                orderNotVisible();
                speed_Order.Visible = true;
                ports_Order.Visible = true;
            }
            if (combo_Order.SelectedIndex == 1)
            {
                orderNotVisible();
                resolution_Order.Visible = true;
                batery_Order.Visible = true;
            }
            if (combo_Order.SelectedIndex == 2)
            {
                orderNotVisible();
                operativeSistem_Order.Visible = true;
                batery_Order.Visible = true;
                memory_Order.Visible = true;
            }
        }

        //Add Button
        private void add_BtnOrder_Click(object sender, EventArgs e)
        {
            order.Add(" ");

            if (combo_Order.SelectedIndex == 0)
            {
                string brand = brand_Order.Text.ToString();
                string name = name_Order.Text.ToString();
                int ram = Int32.Parse(ram_Order.Text.ToString());
                int price = Int32.Parse(price_Order.Text.ToString());
                int speed = Int32.Parse(speed_Order.Text.ToString());
                int port = Int32.Parse(ports_Order.Text.ToString());
                Computer computer = new Computer("computer", brand, name, ram, price, speed, port);
                order.Add(computer);
                list_Ticket.Items.Add("Ordenador");
                list_Ticket.Items.Add(computer.getAllComputer());
            }
            if (combo_Order.SelectedIndex == 1)
            {
                string brand = brand_Order.Text.ToString();
                string name = name_Order.Text.ToString();
                int ram = Int32.Parse(ram_Order.Text.ToString());
                int price = Int32.Parse(price_Order.Text.ToString());
                int resource = Int32.Parse(resolution_Order.Text.ToString());
                int batery = Int32.Parse(batery_Order.Text.ToString());
                Tablet tablet = new Tablet("tablet",brand, name, ram, price, resource, batery);
                order.Add(tablet);
                list_Ticket.Items.Add("Tablet");
                list_Ticket.Items.Add(tablet.getAllTablet());
            }
            if (combo_Order.SelectedIndex == 2)
            {
                string brand = brand_Order.Text.ToString();
                string name = name_Order.Text.ToString();
                int ram = Int32.Parse(ram_Order.Text.ToString());
                int price = Int32.Parse(price_Order.Text.ToString());
                string os = operativeSistem_Order.Text.ToString();
                int batery = Int32.Parse(batery_Order.Text.ToString());
                int memory = Int32.Parse(memory_Order.Text.ToString());
                Movile movile = new Movile("movile",brand, name, ram, price, os, batery, memory);
                order.Add(movile);
                list_Ticket.Items.Add("Movil");
                list_Ticket.Items.Add(movile.getAllMovile());
            }
        }

        //Delte Button
        private void delete_BtnOrder_Click(object sender, EventArgs e)
        {
            brand_Order.Text = "";
            name_Order.Text = "";
            ram_Order.Text = "";
            price_Order.Text = "";
            speed_Order.Text = "";
            ports_Order.Text = "";
            resolution_Order.Text = "";
            batery_Order.Text = "";
            memory_Order.Text = "";
            operativeSistem_Order.Text = "";
        }

        private void addRam_Edit_Click(object sender, EventArgs e)
        {
            if (list_Ticket.SelectedItem.ToString().Equals("Tablet"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Tablet aux = (Tablet)order[select];
                aux.setMoreRam(2);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllTablet());
                list_Ticket.Items.RemoveAt(select); ;
            }
            if (list_Ticket.SelectedItem.ToString().Equals("Ordenador"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Computer aux = (Computer)order[select];
                aux.setMoreRam(2);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllComputer());
                list_Ticket.Items.RemoveAt(select);
            }
           
            if (list_Ticket.SelectedItem.ToString().Equals("Movil"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Movile aux = (Movile)order[select];
                aux.setMoreRam(2);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllMovile());
                list_Ticket.Items.RemoveAt(select);
            }

        }

        private void deleteRam_Edit_Click(object sender, EventArgs e)
        {
            if (list_Ticket.SelectedItem.ToString().Equals("Tablet"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Tablet aux = (Tablet)order[select];
                aux.setLessRam(2);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllTablet());
                list_Ticket.Items.RemoveAt(select); ;
            }
            if (list_Ticket.SelectedItem.ToString().Equals("Ordenador"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Computer aux = (Computer)order[select];
                aux.setLessRam(2);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllComputer());
                list_Ticket.Items.RemoveAt(select);
            }

            if (list_Ticket.SelectedItem.ToString().Equals("Movil"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Movile aux = (Movile)order[select];
                aux.setLessRam(2);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllMovile());
                list_Ticket.Items.RemoveAt(select);
            }

        }

        private void addPrice_Edit_Click(object sender, EventArgs e)
        {
            if (list_Ticket.SelectedItem.ToString().Equals("Tablet"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Tablet aux = (Tablet)order[select];
                aux.setMorePrice(20);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllTablet());
                list_Ticket.Items.RemoveAt(select); ;
            }
            if (list_Ticket.SelectedItem.ToString().Equals("Ordenador"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Computer aux = (Computer)order[select];
                aux.setMorePrice(20);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllComputer());
                list_Ticket.Items.RemoveAt(select);
            }

            if (list_Ticket.SelectedItem.ToString().Equals("Movil"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Movile aux = (Movile)order[select];
                aux.setMorePrice(20);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllMovile());
                list_Ticket.Items.RemoveAt(select);
            }
        }

        private void deletePrice_Edit_Click(object sender, EventArgs e)
        {
            if (list_Ticket.SelectedItem.ToString().Equals("Tablet"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Tablet aux = (Tablet)order[select];
                aux.setLessPrice(20);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllTablet());
                list_Ticket.Items.RemoveAt(select); ;
            }
            if (list_Ticket.SelectedItem.ToString().Equals("Ordenador"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Computer aux = (Computer)order[select];
                aux.setLessPrice(20);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllComputer());
                list_Ticket.Items.RemoveAt(select);
            }

            if (list_Ticket.SelectedItem.ToString().Equals("Movil"))
            {
                int select = 0;
                select = list_Ticket.SelectedIndex + 1;
                Movile aux = (Movile)order[select];
                aux.setLessPrice(20);
                order[list_Ticket.SelectedIndex] = aux;
                list_Ticket.Items.Insert(select + 1, aux.getAllMovile());
                list_Ticket.Items.RemoveAt(select);
            }
        }

        private void combo_Edit_SelectedIndexChanged(object sender, EventArgs e)
        {

            int total = list_Ticket.Items.Count;

            object[] computerList   = new object[list_Ticket.Items.Count];
            object[] tablet         = new object[list_Ticket.Items.Count];
            object[] movile         = new object[list_Ticket.Items.Count];

            list_Ticket.Items.Clear();

            if (combo_Edit.SelectedIndex == 0)
            {
                for(int i = 0; i< total ; i++)
                {
                    list_Ticket.Items.Add(computerList[i]);
                }
            }

        }

        private void list_Ticket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
