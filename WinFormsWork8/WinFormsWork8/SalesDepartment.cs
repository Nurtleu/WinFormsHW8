using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWork8
{
    public partial class SalesDepartment : Form
    {
        List<ProductOfOnlineMarket> productOfOnlineMarket;
        AddEdit addEdit = new AddEdit();       
        public SalesDepartment()
        {
            productOfOnlineMarket = new List<ProductOfOnlineMarket>();
            object[] productCount;

            productOfOnlineMarket.Add
                (new ProductOfOnlineMarket()
            {
                Name = "MSI GP72 Leopard (219KZ-BB7770H8G1T0DS10SH)",Price = 499500,Characteristic = "17,3` 1920x1080 | Intel Core i7 7700HQ | HDD 1000 | nVidia GeForce GTX 1050, 2GB GDDR5 | Windows 10 | Вес 2,6 кг",
            });

            productOfOnlineMarket.Add
                (new ProductOfOnlineMarket()
            {
                Name = "Lenovo IdeaPad Yoga 900 13.3 Touch,Silver(80UE008ARK)", Price = 342000,Characteristic = "15.6` 1920x1080 | Intel Core i7 7700HQ | RAM 8 | HDD 1000+SSD 128 | nVidia GeForce GTX1060 6144 DDR5 | Windows 10 | Вес 1,3 кг",
            });

            productOfOnlineMarket.Add
                (new ProductOfOnlineMarket()
            {
                Name = "Asus G502V (GL502VM-FY243T)",Price = 396000,Characteristic = "15.6` 1920x1080 | Intel Core i7 7700HQ | RAM 8 | HDD 1000+SSD 128 | nVidia GeForce GTX1060 6144 DDR5 | Windows 10 | Вес 1,85",
            });

            productOfOnlineMarket.Add
                (new ProductOfOnlineMarket()
            {
                Name = "Apple MacBook Pro Touch Bar 13,Retina, 256 GB, Space Gray(MLH12RU/ A)", Price = 679000, Characteristic = "13` 2560x1600 | Intel Core i5 | RAM 8 | SSD 256 | Intel HD Graphics 550 | Mac OS X",
            });

            productOfOnlineMarket.Add
                (new ProductOfOnlineMarket()
            {
                Name= "Apple MacBook Pro Touch Bar 15 Retina,512 GB,Space Gray(MLH42RU / A)", Price=967500,Characteristic= "15,4` 2880x1800 | Intel Core i7 | RAM 16 | SSD 512 | Intel HD Graphics 530 | Mac OS X | Вес 1,83 кг",
            });

            productCount = new object[productOfOnlineMarket.Count];
            
            for(int i = 0; i < productOfOnlineMarket.Count; i++)
            {
                productCount[i] = productOfOnlineMarket[i].Name;
            }

            comboBoxProductInfo.Items.AddRange(productCount);
            comboBoxProductInfo.SelectedIndex = 0;

            InitializeComponent();          
        }

        private void ButtonStock_Click(object sender, EventArgs e)
        {
            addEdit.Show();
            this.Hide();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            listBoxProductInfo.Items.Add(comboBoxProductInfo.Text);
            int priceOfComputer = int.Parse(textBoxPrice.Text);
            int totalPriceOfComputer = int.Parse(textBoxTotalPrice.Text);
            int info = int.Parse(textBoxInformation.Text);
            totalPriceOfComputer += priceOfComputer;
            textBoxTotalPrice.Text = totalPriceOfComputer.ToString();
        }

        private void ComboBoxProductInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = productOfOnlineMarket.ElementAt((sender as ComboBox).SelectedIndex).Price.ToString();
        }
    }
}