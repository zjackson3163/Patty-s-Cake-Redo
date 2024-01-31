using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patty_s_Cake_Redo
{
    public partial class homePage : Form
    {
        //initializes variables
        public double totalPrice;
        public List<string> custname = new List<string>();
        public List<double>custPrice = new List<double>();
        StreamWriter daysOrders = new StreamWriter("daysOrders.txt");
        

        public homePage()
        {
            InitializeComponent();
        }
        
        //opens all inputs to receive input
        private void placeAnOrder_CheckedChanged(object sender, EventArgs e)
        {
            
                basePriceInput.ReadOnly = true;
                custNameInput.ReadOnly = false;
                oneTier.Enabled = true;
                twoTier.Enabled = true;
                threeTier.Enabled = true;
                candles.Enabled = true;
                text.Enabled = true;
                designs.Enabled = true;
        }

        //closes all inputs from receiving input
        private void finish_CheckedChanged(object sender, EventArgs e)
        {
            custNameInput.ReadOnly = true;
            basePriceInput.ReadOnly = true;
            oneTier.Enabled = false;
            twoTier.Enabled = false;
            threeTier.Enabled = false;
            candles.Enabled = false;
            text.Enabled = false;
            designs.Enabled = false;
        }

        //changes total label each time base input is changed
        private void basePriceInput_TextChanged(object sender, EventArgs e)
        {
            totalPrice += Convert.ToDouble(basePriceInput.Text);
            total.Text = "Total: $" + basePriceInput.Text;
        }

        //adds subtracts 7.99 from price if checked or unchecked
        private void twoTier_CheckedChanged(object sender, EventArgs e)
        {
            if (twoTier.Checked == true)
            {
                totalPrice += 7.99;
                total.Text = "Total: $" + Convert.ToString(totalPrice);
            }
            else
            {
                totalPrice -= 7.99;
                total.Text = "Total: $" + Convert.ToString(totalPrice);
            }
        }


        //adds/subtracts 14.99 from price if checked or unchecked
        private void threeTier_CheckedChanged(object sender, EventArgs e)
        {
            if (threeTier.Checked == true)
            {
                totalPrice += 14.99;
                total.Text = "Total: $" + Convert.ToString(totalPrice);
            }
            else
            {
                totalPrice -= 14.99;
                total.Text = "Total: $" + Convert.ToString(totalPrice);
            }
        }

        //adds subtracts 4.99 from price if checked or unchecked
        private void candles_CheckedChanged(object sender, EventArgs e)
        {
            if (candles.Checked == true)
            {
                totalPrice += 4.99;
                total.Text = "Total: $" + Convert.ToString(totalPrice);
            }
            else
            {
                totalPrice -= 4.99;
                total.Text = "Total: $" + Convert.ToString(totalPrice);
            }
        }

        //adds/subtracts 7.99 from price if checked or unchecked
        private void text_CheckedChanged(object sender, EventArgs e)
        {
            if (text.Checked == true)
            {
                totalPrice += 7.99;
                total.Text = "Total: $" + Convert.ToString(totalPrice);
            }
            else
            {
                totalPrice -= 7.99;
                total.Text = "Total: $" + Convert.ToString(totalPrice);
            }
        }

        //adds/subtracts 9.99 from price if checked or unchecked
        private void designs_CheckedChanged(object sender, EventArgs e)
        {
            if (designs.Checked == true)
            {
                totalPrice += 9.99;
                total.Text = "Total: $" + Convert.ToString(totalPrice);
            }
            else
            {
                totalPrice -= 9.99;
                total.Text = "Total: $" + Convert.ToString(totalPrice);
            }
        }

        //adds customer name and their total to an array. resets price and customer name
        private void submit_Click(object sender, EventArgs e)
        {
            if (placeAnOrder.Checked == true)
            {
                Customers.Items.AddRange(new object[] { custNameInput.Text });
                custname.Add(custNameInput.Text);
                custPrice.Add(totalPrice);
                MessageBox.Show($"Order placed for {custNameInput.Text} ${totalPrice}");

                custNameInput.ReadOnly = true;
                basePriceInput.ReadOnly = true;
                oneTier.Checked = false;
                twoTier.Checked = false;
                threeTier.Checked = false;
                candles.Checked = false;
                text.Checked = false;
                designs.Checked = false;
                totalPrice = Convert.ToDouble(basePriceInput.Text);
                total.Text = "Total: $" + Convert.ToString(totalPrice);
                custNameInput.Text = "";
                placeAnOrder.Checked = false;
            }
            else
            {
                var homePage = new Form();
                
                for(int i = 0; i < custname.Count; i++)
                {
                    daysOrders.WriteLine($"{custname[i]}, ${custPrice[i]}");
                }
                MessageBox.Show($"Daily orders have been printed to the file orders.txt. \nHave a great rest of your day! <3");
                homePage.Close();
            }
            
        }

        /*Following code cited from:
         Dark Knight. Dec 15th, 2010, StackOverflow, "https://stackoverflow.com/questions/4454423/c-sharp-listbox-item-double-click-event"
         */

        private void Customers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = Customers.IndexFromPoint(e.Location);
            if (Customers.SelectedItem != null)
            {
                total.Text = "Total: $" + Convert.ToString(100);
                
            }
        }
    }
}
