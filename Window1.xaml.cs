using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string Event_1 = Application.Current.Properties["event_type"].ToString();
        string img_path;
        string path;
        string copy_item;
        string cake_selection = "";
        string food_1 = "";
        string food_2 = "";
        string food_3 = "";
        string food_4 = "";
        string food_5 = "";
        string food_6 = "";
        string food_7 = "";
        string food_8 = "";
        string food_9 = "";
        string food_10 = "";
        string drinks_1 = "";
        string drinks_2 = "";
        string drinks_3 = "";
        string drinks_4 = "";
        string drinks_5 = "";
        int index;

        List<string> l1;
        List<string> l2;
        List<string> l5;
        List<string> display;

        List<string> b_nv;
        List<string> w_nv;
        List<string> b_d;
        List<string> w_d;
        List<string> a;
        List<string> na;
        List<string> veg_kids;
        List<string> nveg_kids;
        List<string> cake;
        string _xmlFile = "C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml";
        string _xmlFile_food = "C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml";
        string _xmlFile_drinks = "C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml";


        public Window1()
        {

            InitializeComponent();

            char[] array_dr = new char[5];
            display = new List<string>();
            l1 = new List<string>();
            l1.Add("Penne Vodka");
            l1.Add("Pad Thai Noodles");
            l1.Add("Truffle Risotto");
            l1.Add("Eggplant Parmesan");
            f_1.ItemsSource = l1;

            l5 = new List<string>();
            l5.Add("Mac n Cheese");
            l5.Add("Jackfruit Taco");
            l5.Add("Blackbean Burger");
            l5.Add("Pizza quattro formaggi");
            lb_b.ItemsSource = l5;

            b_nv = new List<string>();
            b_nv.Add("Chicken Nuggets");
            b_nv.Add("Salami n Cheese Sandwiches");
            b_nv.Add("Grilled Lasagna");
            b_nv.Add("Peperoni Pizza");
            b_nveg.ItemsSource = b_nv;

            w_nv = new List<string>();
            w_nv.Add("Butter Chicken with Basmati");
            w_nv.Add("Lamb rack with Red wine");
            w_nv.Add("Chicken Parm Casserole");
            w_nv.Add("Pecan Crusted Fish");
            W_nveg.ItemsSource = w_nv;

            w_d = new List<string>();
            w_d.Add("Tiramisu");
            w_d.Add("Panna cotta with Berries");
            w_d.Add("Fruit n Cake tarts");
            w_d.Add("Creme Brulee");
            w_des.ItemsSource = w_d;

            b_d = new List<string>();
            b_d.Add("Assorted Doughnut");
            b_d.Add("Assorted Cupcakes");
            b_d.Add("Assorted Icecream");
            b_d.Add("Assorted Brownies");
            b_des.ItemsSource = b_d;

            a = new List<string>();
            a.Add("Martini");
            a.Add("Margarita");
            a.Add("Red and White Wine");
            a.Add("Beer - Snow and Budweiser");
            a.Add("Scotch");
            a.Add("Vodka");
            al_drinks.ItemsSource = a;

            na = new List<string>();
            na.Add("SoftDrinks");
            na.Add("Virgin Mojito");
            na.Add("Virgin Mary");
            na.Add("Raspberry Iced Tea");
            na.Add("Watermelon Lemonade");
            na.Add("Fruit Sangria");
            nal_drinks1.ItemsSource = na;

            veg_kids = new List<string>();
            veg_kids.Add("Mushroom n Spinach Pizza");
            veg_kids.Add("Grilled Tofu Burger");
            veg_kids.Add("Pickled Avocado Taco");
            veg_kids.Add("Pasta Arrabbiata");

            veg_add_kids.ItemsSource = veg_kids;

            nveg_kids = new List<string>();
            nveg_kids.Add("Chicken n Cheese Poppers");
            nveg_kids.Add("Ham Mac n Cheese");
            nveg_kids.Add("Charred Peperoni Pizza");
            nveg_kids.Add("BBQ Chicken Wings");

            nveg_add_kids.ItemsSource = nveg_kids;

            label.Content = Event_1;
            {
                if (Event_1 == "Wedding")
                {
                    lb2.Visibility = Visibility.Visible;
                    f_1.Visibility = Visibility.Visible;
                    lb_b.Visibility = Visibility.Hidden;
                    b_des.Visibility = Visibility.Hidden;
                    b_nveg.Visibility = Visibility.Hidden;
                    w_des.Visibility = Visibility.Visible;
                    W_nveg.Visibility = Visibility.Visible;
                    al_drinks.Visibility = Visibility.Visible;
                    k_v_header.Visibility = Visibility.Visible;
                    k_nv_header.Visibility = Visibility.Visible;
                    nveg_add_kids.Visibility = Visibility.Visible;
                    veg_add_kids.Visibility = Visibility.Visible;
                    cake = new List<string>();
                    cake.Add("Banana Coconut Mocha");
                    cake.Add("Ginger and Passionfruit");
                    cake.Add("Hazelnut with Chocolate Buttercream");
                    cake.Add("Chocolate Matcha with Berries");
                    Cake.ItemsSource = cake;
                }

                else
                {
                    lb3.Visibility = Visibility.Visible;
                    f_1.Visibility = Visibility.Hidden;
                    lb_b.Visibility = Visibility.Visible;
                    b_des.Visibility = Visibility.Visible;
                    b_nveg.Visibility = Visibility.Visible;
                    w_des.Visibility = Visibility.Hidden;
                    W_nveg.Visibility = Visibility.Hidden;
                    al_drinks.Visibility = Visibility.Hidden;
                    nal_header.Margin = new Thickness(24, 252, 0, 0);

                    al_header.Visibility = Visibility.Hidden;

                    k_v_header.Visibility = Visibility.Hidden;
                    k_nv_header.Visibility = Visibility.Hidden;
                    nveg_add_kids.Visibility = Visibility.Hidden;
                    veg_add_kids.Visibility = Visibility.Hidden;
                    alcount.Margin = new Thickness(142.2, 201, 0, 0);
                    alcount.Visibility = Visibility.Hidden;
                    cake = new List<string>();
                    cake.Add("Chocolate");
                    cake.Add("Strawberry");
                    cake.Add("Vanilla");
                    cake.Add("RedVelvet");
                    Cake.ItemsSource = cake;

                    kidsv_count.Visibility = Visibility.Hidden;
                    kidsnv_count.Visibility = Visibility.Hidden;
                    he1.Margin = new Thickness(24, 53, 0, 0);
                    he2.Margin = new Thickness(24, 101, 0, 0);
                    he3.Margin = new Thickness(24, 152, 0, 0);
                    he4.Margin = new Thickness(24, 201, 0, 0);
                    lb_b.Margin = new Thickness(119.2, 53, 0, 0);
                    b_des.Margin = new Thickness(119.2, 152, 0, 0);
                    b_nveg.Margin = new Thickness(119.2, 101, 0, 0);
                    Cake.Margin = new Thickness(120.2, 201, 0, 0);
                    nal_drinks1.Margin = new Thickness(119.2, 252, 0, 0);
                    v_count.Margin = new Thickness(144.2, 53, 0, 0);
                    nv_count.Margin = new Thickness(144.2, 101, 0, 0);
                    d_count.Margin = new Thickness(144.2, 151, 0, 0);
                    c_count.Margin = new Thickness(24, 224, 0, 0);
                    nalcount.Margin = new Thickness(144.2, 251, 0, 0);
                }
            }

            Application.Current.Properties["venue_cost"] = "";
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument xdoc = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            XDocument xdoc1 = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");

            try
            {
                final_food.ItemsSource = null;
                var product = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("food_1").Single();
                string selectedItem11 = product.Value;

                var product1 = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("food_2").Single();
                string selectedItem1 = product1.Value;

                var product2 = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("food_3").Single();
                string selectedItem2 = product2.Value;

                var product3 = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("food_4").Single();
                string selectedItem3 = product3.Value;

                var product4 = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("food_5").Single();
                string selectedItem4 = product4.Value;

                var product5 = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("food_6").Single();
                string selectedItem5 = product5.Value;

                var product6 = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("food_7").Single();
                string selectedItem6 = product6.Value;

                var product7 = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("food_8").Single();
                string selectedItem7 = product7.Value;

                var product8 = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("food_9").Single();
                string selectedItem8 = product8.Value;

                var product9 = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("food_10").Single();
                string selectedItem9 = product9.Value;



                if ((final_food.Items.Contains(selectedItem11)) || (final_food.Items.Contains(selectedItem1)) || (final_food.Items.Contains(selectedItem2)) || (final_food.Items.Contains(selectedItem3)) || (final_food.Items.Contains(selectedItem4)) || (final_food.Items.Contains(selectedItem5)) || (final_food.Items.Contains(selectedItem6)) || (final_food.Items.Contains(selectedItem7)) || (final_food.Items.Contains(selectedItem8)) || (final_food.Items.Contains(selectedItem9)))
                {

                }

                else
                {
                    final_food.Items.Add(selectedItem1);
                    final_food.Items.Add(selectedItem11);
                    final_food.Items.Add(selectedItem2);
                    final_food.Items.Add(selectedItem3);
                    final_food.Items.Add(selectedItem4);
                    final_food.Items.Add(selectedItem5);
                    final_food.Items.Add(selectedItem6);
                    final_food.Items.Add(selectedItem7);
                    final_food.Items.Add(selectedItem8);
                    final_food.Items.Add(selectedItem9);
                }
            }
            catch (Exception)
            {
            }


            int i1 = 0;
            while (final_food.Items.Count - 1 >= i1)
            {
                if (Convert.ToString(final_food.Items[i1]).Trim() == string.Empty)
                {
                    final_food.Items.RemoveAt(i1);
                    i1 -= 1;
                }
                i1 += 1;
            }
            string name1 = App.Current.Properties["Order_Id"].ToString();
            XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
            var aldrinkc = xdoc_dr.Descendants("Drinks")
                .Where(g => g.Attribute("id").Value == name1)
                .Elements("A_drinks_count")
                .Single();

            var naldrinkc = xdoc_dr.Descendants("Drinks")
                .Where(g => g.Attribute("id").Value == name1)
                .Elements("NA_drinks_count")
                .Single();
            alcount.Text = aldrinkc.Value.ToString();
            nalcount.Text = naldrinkc.Value.ToString();
            try
            {
                var product11 = xdoc_dr.Descendants("Drinks")
                .Where(g => g.Attribute("id").Value == name1)
                .Elements("drinks_1")
                .Single();
                string drink1 = product11.Value;

                var product22 = xdoc_dr.Descendants("Drinks")
                    .Where(g => g.Attribute("id").Value == name1)
                    .Elements("drinks_2")
                    .Single();
                string drink2 = product22.Value;

                var product33 = xdoc_dr.Descendants("Drinks")
                    .Where(g => g.Attribute("id").Value == name1)
                    .Elements("drinks_3")
                    .Single();
                string drink3 = product33.Value;

                var product44 = xdoc_dr.Descendants("Drinks")
                    .Where(g => g.Attribute("id").Value == name1)
                    .Elements("drinks_4")
                    .Single();
                string drink4 = product44.Value;

                var product55 = xdoc_dr.Descendants("Drinks")
                    .Where(g => g.Attribute("id").Value == name1)
                    .Elements("drinks_5")
                    .Single();
                string drink5 = product55.Value;
                if (final_drinks.Items.Contains(drink1))
                {

                }
                else
                {
                    display.Add(drink1);
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                }

                if (final_drinks.Items.Contains(drink2))
                {

                }
                else
                {
                    display.Add(drink2);
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                }

                if (final_drinks.Items.Contains(drink3))
                {

                }
                else
                {
                    display.Add(drink3);
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                }

                if (final_drinks.Items.Contains(drink4))
                {

                }
                else
                {
                    display.Add(drink4);
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                }

                if (final_drinks.Items.Contains(drink5))
                {

                }
                else
                {
                    display.Add(drink5);
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                }

                int i2 = 0;
                while (display.Count - 1 >= i2)
                {
                    if (Convert.ToString(final_drinks.Items[i2]).Trim() == string.Empty)
                    {
                        display.RemoveAt(i2);
                        i2 -= 1;
                    }
                    i2 += 1;
                }
                databinding_drinks();

            }
            catch (Exception)
            {



            }
            string eid = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");
            var venue_id = doc_i.Descendants("Events").Where(g => g.Attribute("id").Value == eid).Elements("Venue").Single();


            if (venue_id.Value.ToString() != string.Empty)
            {
                next_v.Visibility = Visibility.Visible;
                back_v.Visibility = Visibility.Visible;
                venue_info.Visibility = Visibility.Visible;
                helptext_v.Margin = new Thickness(10.8, 343.4, 0, 0);
                string venue_value = venue_id.Value.ToString();
                if (venue_value == "Pool 1")
                {
                    lb3.SelectedIndex = 0;
                    lb3.Focus();
                    string image1 = "pp";
                    path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                    img_dis.Source = new BitmapImage(new Uri(path));
                    App.Current.Properties["image"] = image1;
                    App.Current.Properties["venue_selection"] = "Pool 1";
                    App.Current.Properties["venue_cost"] = "7";
                    venue_info.Text = "  Cost for the Venue: 7€ " + "\n" + "\n  Area of the Venue: 200 m²";
                }
                else if (venue_value == "Pool 2")
                {
                    lb3.SelectedIndex = 1;
                    lb3.Focus();
                    string image1 = "OIP";
                    path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                    img_dis.Source = new BitmapImage(new Uri(path));
                    App.Current.Properties["image"] = image1;
                    App.Current.Properties["venue_selection"] = "Pool 2";
                    App.Current.Properties["venue_cost"] = "11";
                    venue_info.Text = "  Cost for the Venue: 11€ " + "\n" + "\n  Area of the Venue: 320 m²";

                }
                else if (venue_value == "Hall 1")
                {
                    lb3.SelectedIndex = 2;

                    lb3.Focus();
                    string image1 = "h";
                    path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                    img_dis.Source = new BitmapImage(new Uri(path));
                    App.Current.Properties["image"] = image1;
                    App.Current.Properties["venue_selection"] = "Hall 1";
                    App.Current.Properties["venue_cost"] = "12";
                    venue_info.Text = "  Cost for the Venue: 12€ " + "\n" + "\n  Area of the Venue: 400 m²";
                }
                else if (venue_value == "Hall 2")
                {
                    lb3.SelectedIndex = 3;
                    lb3.Focus();
                    string image1 = "bh";
                    path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                    img_dis.Source = new BitmapImage(new Uri(path));
                    App.Current.Properties["image"] = image1;
                    App.Current.Properties["venue_selection"] = "Hall 2";
                    App.Current.Properties["venue_cost"] = "13";
                    venue_info.Text = "  Cost for the Venue: 13€ " + "\n" + "\n  Area of the Venue: 400 m²";
                }
                else if (venue_value == "Garden 2")
                {
                    lb2.SelectedIndex = 3;
                    lb2.Focus();
                    string image1 = "gg";
                    path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                    img_dis.Source = new BitmapImage(new Uri(path));
                    App.Current.Properties["image"] = image1;
                    App.Current.Properties["venue_selection"] = "Garden 2";
                    App.Current.Properties["venue_cost"] = "11";
                    venue_info.Text = "  Cost for the Venue: 11€ " + "\n" + "\n  Area of the Venue: 360 m²";

                }
                else if (venue_value == "Garden 1")
                {
                    lb2.SelectedIndex = 2;

                    lb2.Focus();
                    string image1 = "garden";
                    path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                    img_dis.Source = new BitmapImage(new Uri(path));
                    App.Current.Properties["image"] = image1;
                    App.Current.Properties["venue_selection"] = "Garden 1";
                    App.Current.Properties["venue_cost"] = "12";
                    venue_info.Text = "  Cost for the Venue: 12€ " + "\n" + "\n  Area of the Venue: 380 m²";
                }
                else if (venue_value == "banquet 2")
                {
                    lb2.SelectedIndex = 1;
                    lb2.Focus();
                    string image1 = "ban";
                    path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                    img_dis.Source = new BitmapImage(new Uri(path));
                    App.Current.Properties["image"] = image1;
                    App.Current.Properties["venue_selection"] = "banquet 2";
                    App.Current.Properties["venue_cost"] = "11";
                    venue_info.Text = "  Cost for the Venue: 11€ " + "\n" + "\n  Area of the Venue: 250 m²";

                }
                else if (venue_value == "banquet 1")
                {
                    lb2.SelectedIndex = 0;

                    lb2.Focus();
                    string image1 = "bb";
                    path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                    img_dis.Source = new BitmapImage(new Uri(path));
                    App.Current.Properties["image"] = image1;
                    App.Current.Properties["venue_selection"] = "banquet 1";
                    App.Current.Properties["venue_cost"] = "12";
                    venue_info.Text = "  Cost for the Venue: 12€ " + "\n" + "\n  Area of the Venue: 310 m²";
                }
            }
            var veg_count = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("V_food_count").Single();
            v_count.Text = veg_count.Value;
            var nveg_count = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("NV_food_count").Single();
            nv_count.Text = nveg_count.Value;
            var dessert_count = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("des_count").Single();
            d_count.Text = dessert_count.Value;
            var knvcount = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("kid_nv_food_count").Single();
            kidsnv_count.Text = knvcount.Value;
            var kvcount = xdoc.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("kid_v_food_count").Single();
            kidsv_count.Text = kvcount.Value;
            var Cake1 = doc_i.Descendants("Events").Where(g => g.Attribute("id").Value == name).Elements("Cake").Single();
            c_count.Text = Cake1.Value.ToString();

            payment_Details();
        }

        private void payment_Details()
        {
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");
            var venue = doc_i.Descendants("Events").Where(g => g.Attribute("id").Value == name).Elements("Venue").Single();
            p_venue.Text = venue.Value;

            var venue_p = doc_i.Descendants("Events").Where(g => g.Attribute("id").Value == name).Elements("Venue_Cost").Single();

            var venue_D = doc_i.Descendants("Events").Where(g => g.Attribute("id").Value == name).Elements("Duration").Single();
            ven_price.Text = (Convert.ToInt32(venue_p.Value) * Convert.ToInt32(venue_D.Value)).ToString() + " €";

            XDocument doc_f = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            var food_nv = doc_f.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("NV_food_count").Single();
            p_food_nv.Text = food_nv.Value;

            var food_v = doc_f.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("V_food_count").Single();
            p_food_v.Text = food_v.Value;

            var food_d = doc_f.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("des_count").Single();
            p_food_d.Text = food_d.Value;

            var food_k_v = doc_f.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("kid_v_food_count").Single();

            var food_k_nv = doc_f.Descendants("Food").Where(g => g.Attribute("id").Value == name).Elements("kid_nv_food_count").Single();

            k_v.Text = food_k_v.Value;
            k_nv_Copy.Text = food_k_nv.Value;

            XDocument doc_d = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
            var drinks_a = doc_d.Descendants("Drinks").Where(g => g.Attribute("id").Value == name).Elements("A_drinks_count").Single();
            p_drinks_a.Text = drinks_a.Value;

            var drinks_na = doc_d.Descendants("Drinks").Where(g => g.Attribute("id").Value == name).Elements("NA_drinks_count").Single();
            p_drinks_na.Text = drinks_na.Value;

            var dr_cost = (Convert.ToInt32(drinks_na.Value) * 2) + (Convert.ToInt32(drinks_a.Value) * 4);

            drink_price.Text = ((Convert.ToInt32(drinks_na.Value) * 2) + (Convert.ToInt32(drinks_a.Value) * 4)).ToString() + " €";

            food_price.Text = ((Convert.ToInt32(food_v.Value) * 8) + (Convert.ToInt32(food_nv.Value) * 11) +
                (Convert.ToInt32(food_d.Value) * 5)).ToString() + " €";

            kids_menu.Text = ((Convert.ToInt32(food_k_v.Value) * 5) + (Convert.ToInt32(food_k_nv.Value) * 5)).ToString() + " €";

            var g_kids = doc_i.Descendants("Events").Where(g => g.Attribute("id").Value == name).Elements("Guest_No_K").Single();
            var g_adults = doc_i.Descendants("Events").Where(g => g.Attribute("id").Value == name).Elements("Guest_No_A").Single();
            var cake_t = doc_i.Descendants("Events").Where(g => g.Attribute("id").Value == name).Elements("tier").Single();
            var cake_selected = doc_i.Descendants("Events").Where(g => g.Attribute("id").Value == name).Elements("Cake").Single();
            cake_op_selected.Text = cake_selected.Value;
            cake_price.Text = (15 * Convert.ToInt32(cake_t.Value)).ToString() + " €";
            a_c.Text = g_adults.Value;
            k_c.Text = g_kids.Value;
            event_duration.Text = venue_D.Value;
            event_duration_Copy.Text = cake_t.Value;
            total_1.Text = ((Convert.ToInt32(g_adults.Value)) * (Convert.ToInt32(((Convert.ToInt32(food_v.Value) * 8) + (Convert.ToInt32(food_nv.Value) * 11) +
                (Convert.ToInt32(food_d.Value) * 5))))).ToString() +  " €";
            total_2.Text = ((Convert.ToInt32(g_kids.Value)) * (Convert.ToInt32(((Convert.ToInt32(food_v.Value) * 8) + (Convert.ToInt32(food_nv.Value) * 11) +
                (Convert.ToInt32(food_d.Value) * 5))) * 0.6)).ToString() + " €";
       
        }


        private void ListBox3_DoubleClick(object sender, MouseEventArgs e)
        {

            index = this.lb3.SelectedIndex;
            next_v.Visibility = Visibility.Visible;
            back_v.Visibility = Visibility.Visible;
            venue_info.Visibility = Visibility.Visible;
            helptext_v.Margin = new Thickness(10.8, 343.4, 0, 0);
            if (index == 0)
            {
                string image1 = "pp";
                path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                img_dis.Source = new BitmapImage(new Uri(path));

                App.Current.Properties["image"] = image1;
                App.Current.Properties["venue_selection"] = "Pool 1";
                App.Current.Properties["venue_cost"] = "7";
                venue_info.Text = "  Cost for the Venue: 7€ " + "\n" + "\n  Area of the Venue: 200 m²";
                save_venue();

            }
            else if (index == 1)
            {
                string image1 = "OIP";
                path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                img_dis.Source = new BitmapImage(new Uri(path));
                App.Current.Properties["image"] = image1;
                App.Current.Properties["venue_selection"] = "Pool 2";
                App.Current.Properties["venue_cost"] = "11";
                venue_info.Text = "  Cost for the Venue: 11€ " + "\n" + "\n  Area of the Venue: 320 m²";
                save_venue();
            }
            else if (index == 2)
            {
                string image1 = "h";
                path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                img_dis.Source = new BitmapImage(new Uri(path));
                App.Current.Properties["image"] = image1;
                App.Current.Properties["venue_selection"] = "Hall 1";
                App.Current.Properties["venue_cost"] = "12";
                venue_info.Text = "  Cost for the Venue: 12€ " + "\n" + "\n  Area of the Venue: 400 m²";
                save_venue();
            }
            else if (index == 3)
            {
                string image1 = "bh";
                path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                img_dis.Source = new BitmapImage(new Uri(path));
                App.Current.Properties["image"] = image1;
                App.Current.Properties["venue_selection"] = "Hall 2";
                App.Current.Properties["venue_cost"] = "13";
                venue_info.Text = "  Cost for the Venue: 13€ " + "\n" + "\n  Area of the Venue: 400 m²";
                save_venue();
            }

        }


        private void ListBox2_DoubleClick(object sender, MouseEventArgs e)
        {
            string eid = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");
            var venue_id = doc_i.Descendants("Events").Where(g => g.Attribute("id").Value == eid).Elements("Venue").Single();
            index = this.lb2.SelectedIndex;
            helptext_v.Margin = new Thickness(10.8, 343.4, 0, 0);
            next_v.Visibility = Visibility.Visible;
            back_v.Visibility = Visibility.Visible;
            venue_info.Visibility = Visibility.Visible;

            if (index == 0)
            {
                string image1 = "bb";
                path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                img_dis.Source = new BitmapImage(new Uri(path));
                App.Current.Properties["image"] = image1;
                App.Current.Properties["venue_selection"] = "banquet 1";
                App.Current.Properties["venue_cost"] = "15";
                venue_info.Text = "  Cost for the Venue: 15€" + "\n" + "\n  Area of the Venue: 310 m²";
                save_venue();

            }
            else if (index == 1)
            {
                string image1 = "ban";
                path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                img_dis.Source = new BitmapImage(new Uri(path));
                App.Current.Properties["image"] = image1;
                App.Current.Properties["venue_selection"] = "banquet 2";
                App.Current.Properties["venue_cost"] = "17";
                venue_info.Text = "  Cost for the Venue: 17€" + "\n" + "\n  Area of the Venue: 250 m²";
                save_venue();
            }
            else if (index == 2)
            {
                string image1 = "garden";
                path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                img_dis.Source = new BitmapImage(new Uri(path));
                App.Current.Properties["image"] = image1;
                App.Current.Properties["venue_selection"] = "Garden 1";
                App.Current.Properties["venue_cost"] = "19";
                venue_info.Text = "  Cost for the Venue: 19€" + "\n" + "\n  Area of the Venue: 380 m²";
                save_venue();
            }
            else if (index == 3)
            {
                string image1 = "gg";
                path = "C:/Users/mayan/Desktop/" + image1 + "1" + ".jpg";
                img_dis.Source = new BitmapImage(new Uri(path));
                App.Current.Properties["image"] = image1;
                App.Current.Properties["venue_selection"] = "Garden 2";
                App.Current.Properties["venue_cost"] = "22";
                venue_info.Text = "  Cost for the Venue: 22€" + "\n" + "\n  Area of the Venue: 360 m²";
                save_venue();
            }

        }

        private void save_venue()
        {
            string venue = App.Current.Properties["venue_selection"].ToString();
            string venue_cost = App.Current.Properties["venue_cost"].ToString();
            string order_id = App.Current.Properties["Order_Id"].ToString();
            XDocument xdoc = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");
            var product = xdoc.Descendants("Events").Single(p => p.Attribute("id").Value.Equals(order_id));
            product.SetElementValue("Venue", venue);
            product.SetElementValue("Venue_Cost", venue_cost);

            xdoc.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");
            MessageBox.Show("Selection Saved!");
            payment_Details();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (final_food.SelectedIndex == -1 && final_drinks.SelectedIndex != -1)
            {

            }

            else if (final_food.SelectedIndex == -1 && final_drinks.SelectedIndex == -1)
            {

            }
            else
            {
                string selectedItem1 = final_food.SelectedItem.ToString();
                int selectedIndex1 = final_food.SelectedIndex;
                final_food.Items.Remove(selectedItem1);


                if ((selectedItem1 == "Pecan Crusted Fish") || (selectedItem1 == "Chicken Parm Casserole") || (selectedItem1 == "Lamb rack with Red wine") || (selectedItem1 == "Butter Chicken with Basmati") || (selectedItem1 == "Peperoni Pizza") || (selectedItem1 == "Grilled Lasagna") || (selectedItem1 == "Salami n Cheese Sandwiches") || (selectedItem1 == "Chicken Nuggets"))
                {
                    string eid = App.Current.Properties["Order_Id"].ToString();
                    XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var w_nv_c = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == eid).Elements("NV_food_count").Single();
                    int i = Convert.ToInt32(w_nv_c.Value);
                    i = i - 1;
                    App.Current.Properties["w_nv_c"] = i;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var product_dr = xdoc_dr.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("NV_food_count", App.Current.Properties["w_nv_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    nv_count.Text = i.ToString();
                    save_all();
                    payment_Details();
                }
                else if ((selectedItem1 == "Pizza quattro formaggi") || (selectedItem1 == "Blackbean Burger") || (selectedItem1 == "Jackfruit Taco") || (selectedItem1 == "Mac n Cheese") || (selectedItem1 == "Eggplant Parmesan") || (selectedItem1 == "Truffle Risotto") || (selectedItem1 == "Pad Thai Noodles") || (selectedItem1 == "Penne Vodka"))

                {
                    string eid = App.Current.Properties["Order_Id"].ToString();
                    XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var w_v_c = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == eid).Elements("V_food_count").Single();
                    int i = Convert.ToInt32(w_v_c.Value);
                    i = i - 1;
                    App.Current.Properties["w_v_c"] = i;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var product_dr = xdoc_dr.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("V_food_count", App.Current.Properties["w_v_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    v_count.Text = i.ToString();
                    save_all();
                    payment_Details();
                }
                else if ((selectedItem1 == "Tiramisu") || (selectedItem1 == "Panna cotta with Berries") || (selectedItem1 == "Fruit n Cake tarts") || (selectedItem1 == "Creme Brulee") || (selectedItem1 == "Assorted Doughnut") || (selectedItem1 == "Assorted Cupcakes") || (selectedItem1 == "Assorted Icecream") || (selectedItem1 == "Assorted Brownies"))
                {
                    string eid = App.Current.Properties["Order_Id"].ToString();
                    XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var w_d_c = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == eid).Elements("des_count").Single();
                    int i = Convert.ToInt32(w_d_c.Value);
                    i = i - 1;
                    App.Current.Properties["w_des_c"] = i;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var product_dr = xdoc_dr.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("des_count", App.Current.Properties["w_des_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    d_count.Text = i.ToString();
                    save_all();
                    payment_Details();
                }
                else if ((selectedItem1 == "Mushroom n Spinach Pizza") || (selectedItem1 == "Grilled Tofu Burger") || (selectedItem1 == "Pickled Avocado Taco") || (selectedItem1 == "Pasta Arrabbiata"))
                {
                    string eid = App.Current.Properties["Order_Id"].ToString();
                    XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var k_v = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == eid).Elements("kid_v_food_count").Single();
                    int i = Convert.ToInt32(k_v.Value);
                    i = i - 1;
                    App.Current.Properties["k_v"] = i;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var product_dr = xdoc_dr.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("kid_v_food_count", App.Current.Properties["k_v"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    kidsv_count.Text = i.ToString();
                    save_all();
                    payment_Details();
                }
                else if ((selectedItem1 == "Chicken n Cheese Poppers") || (selectedItem1 == "Ham Mac n Cheese") || (selectedItem1 == "Charred Peperoni Pizza") || (selectedItem1 == "BBQ Chicken Wings"))
                {
                    string eid = App.Current.Properties["Order_Id"].ToString();
                    XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var k_nv = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == eid).Elements("kid_nv_food_count").Single();
                    int i = Convert.ToInt32(k_nv.Value);
                    i = i - 1;
                    App.Current.Properties["k_nv"] = i;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var product_dr = xdoc_dr.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("kid_nv_food_count", App.Current.Properties["k_nv"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    kidsnv_count.Text = i.ToString();
                    save_all();
                    payment_Details();
                }



            }

            if (final_drinks.SelectedIndex == -1 && final_food.SelectedIndex != -1)
            {

            }
            else if (final_food.SelectedIndex == -1 && final_drinks.SelectedIndex == -1)
            {

            }
            else
            {
                string selectedItem2 = final_drinks.SelectedItem.ToString();
                int selectedIndex2 = final_drinks.SelectedIndex;

                if ((selectedItem2 == "Martini") || (selectedItem2 == "Scotch") || (selectedItem2 == "Vodka") || (selectedItem2 == "Margarita") || (selectedItem2 == "Red and White Wine") || (selectedItem2 == "Beer - Snow and Budweiser"))
                {
                    string eid = App.Current.Properties["Order_Id"].ToString();
                    XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var al_c = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == eid).Elements("A_drinks_count").Single();
                    int i = Convert.ToInt32(al_c.Value);
                    i = i - 1;
                    alcount.Text = i.ToString();
                    App.Current.Properties["al_dr_c"] = i;
                    display.RemoveAt(selectedIndex2);
                    final_drinks.ItemsSource = display;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var product_dr = xdoc_dr.Descendants("Drinks").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("A_drinks_count", App.Current.Properties["al_dr_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    databinding_drinks();
                    save_all_drinks();
                    payment_Details();
                }
                else if ((selectedItem2 == "SoftDrinks") || (selectedItem2 == "Virgin Mojito") || (selectedItem2 == "Virgin Mary") || (selectedItem2 == "Raspberry Iced Tea") || (selectedItem2 == "Watermelon Lemonade") || (selectedItem2 == "Fruit Sangria"))
                {
                    string eid = App.Current.Properties["Order_Id"].ToString();
                    XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var nal_c = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == eid).Elements("NA_drinks_count").Single();
                    int i = Convert.ToInt32(nal_c.Value);
                    i = i - 1;
                    nalcount.Text = i.ToString();
                    App.Current.Properties["nal_dr_c"] = i;
                    display.RemoveAt(selectedIndex2);
                    final_drinks.ItemsSource = display;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var product_dr = xdoc_dr.Descendants("Drinks").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("NA_drinks_count", App.Current.Properties["nal_dr_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    databinding_drinks();
                    save_all_drinks();
                    payment_Details();

                }
            }

        }

        private void save_all_drinks()
        {
            XDocument xdoc_drinks = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
            var movieNames1 = xdoc_drinks.Descendants("Drinks").Attributes("id").Select(g => g.Value);
            foreach (var name in movieNames1)
            {
                lb_drinks_check.Items.Add(name);
            }
            try
            {
                final_drinks.Items.GetItemAt(0);

            }
            catch (Exception)
            {
                display.Insert(0, "");
            }
            try
            {
                final_drinks.Items.GetItemAt(1);

            }
            catch (Exception)
            {
                display.Insert(1, "");
            }
            try
            {
                final_drinks.Items.GetItemAt(2);

            }
            catch (Exception)
            {
                display.Insert(2, "");
            }
            try
            {
                final_drinks.Items.GetItemAt(3);

            }
            catch (Exception)
            {
                display.Insert(3, "");
            }
            try
            {
                final_drinks.Items.GetItemAt(4);

            }
            catch (Exception)
            {
                display.Insert(4, "");
            }

            final_drinks.ItemsSource = display;
            databinding_drinks();

            string i = App.Current.Properties["Order_Id"].ToString();
            string j = i;

            XDocument doc = XDocument.Load(_xmlFile_drinks);

            if (final_drinks.Items.Count > 5)
            {
                MessageBox.Show("Please select only 5 items");
            }
            else
            {
                if (lb_drinks_check.Items.Contains(i))
                {
                    drinks_1 = final_drinks.Items.GetItemAt(0).ToString();
                    drinks_2 = final_drinks.Items.GetItemAt(1).ToString();
                    drinks_3 = final_drinks.Items.GetItemAt(2).ToString();
                    drinks_4 = final_drinks.Items.GetItemAt(3).ToString();
                    drinks_5 = final_drinks.Items.GetItemAt(4).ToString();
                    string e_id = App.Current.Properties["Order_Id"].ToString();
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var product_dr = xdoc_dr.Descendants("Drinks").Single(p => p.Attribute("id").Value.Equals(e_id));
                    product_dr.SetElementValue("drinks_1", drinks_1);
                    product_dr.SetElementValue("drinks_2", drinks_2);
                    product_dr.SetElementValue("drinks_3", drinks_3);
                    product_dr.SetElementValue("drinks_4", drinks_4);
                    product_dr.SetElementValue("drinks_5", drinks_5);

                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                }
                else
                {

                    doc.Root.Add(new XElement("Drinks",
                    new XAttribute("id", j),
                    new XElement("ID", i),
                    new XElement("drinks_1", final_drinks.Items.GetItemAt(0).ToString()),
                    new XElement("drinks_2", final_drinks.Items.GetItemAt(1).ToString()),
                    new XElement("drinks_3", final_drinks.Items.GetItemAt(2).ToString()),
                    new XElement("drinks_4", final_drinks.Items.GetItemAt(3).ToString()),
                    new XElement("drinks_5", final_drinks.Items.GetItemAt(4).ToString())
                    ));
                    doc.Save(_xmlFile_drinks);
                    MessageBox.Show("Orders Added");

                }

            }
            int i1 = 0;
            while (display.Count - 1 >= i1)
            {
                if (Convert.ToString(final_drinks.Items[i1]).Trim() == string.Empty)
                {
                    display.RemoveAt(i1);
                    i1 -= 1;
                }
                i1 += 1;
            }

            payment_Details();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }



        private void Del_Drinks_Click(object sender, RoutedEventArgs e)
        {
            if (final_drinks.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item to delete!");
            }
            else
            {
                string selectedItem1 = final_drinks.SelectedItem.ToString();
                int selectedIndex1 = final_drinks.SelectedIndex;
                if ((selectedItem1 == "Martini") || (selectedItem1 == "Scotch") || (selectedItem1 == "Vodka") || (selectedItem1 == "Margarita") || (selectedItem1 == "Red and White Wine") || (selectedItem1 == "Beer - Snow and Budweiser"))
                {
                    string eid = App.Current.Properties["Order_Id"].ToString();
                    XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var al_c = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == eid).Elements("A_drinks_count").Single();
                    int i = Convert.ToInt32(al_c.Value);
                    i = i - 1;
                    alcount.Text = "Number of Drinks selected: " + i.ToString();
                    App.Current.Properties["al_dr_c"] = i;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var product_dr = xdoc_dr.Descendants("Drinks").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("A_drinks_count", App.Current.Properties["al_dr_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    display.RemoveAt(selectedIndex1);
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                }
                else if ((selectedItem1 == "SoftDrinks") || (selectedItem1 == "Virgin Mojito") || (selectedItem1 == "Virgin Mary") || (selectedItem1 == "Raspberry Iced Tea") || (selectedItem1 == "Watermelon Lemonade") || (selectedItem1 == "Fruit Sangria"))
                {
                    string eid = App.Current.Properties["Order_Id"].ToString();
                    XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var nal_c = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == eid).Elements("NA_drinks_count").Single();
                    int i = Convert.ToInt32(nal_c.Value);
                    i = i - 1;
                    nalcount.Text = "Number of Drinks selected: " + i.ToString();
                    App.Current.Properties["nal_dr_c"] = i;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var product_dr = xdoc_dr.Descendants("Drinks").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("NA_drinks_count", App.Current.Properties["nal_dr_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    display.RemoveAt(selectedIndex1);
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                }
            }
        }

        private void Save_drinks_Click(object sender, RoutedEventArgs e)
        {

            XDocument xdoc_drinks = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
            var movieNames1 = xdoc_drinks.Descendants("Drinks").Attributes("id").Select(g => g.Value);
            foreach (var name in movieNames1)
            {
                lb_drinks_check.Items.Add(name);
            }
            try
            {
                final_drinks.Items.GetItemAt(0);

            }
            catch (Exception)
            {
                display.Insert(0, "");
            }
            try
            {
                final_drinks.Items.GetItemAt(1);

            }
            catch (Exception)
            {
                display.Insert(1, "");
            }
            try
            {
                final_drinks.Items.GetItemAt(2);

            }
            catch (Exception)
            {
                display.Insert(2, "");
            }
            try
            {
                final_drinks.Items.GetItemAt(3);

            }
            catch (Exception)
            {
                display.Insert(3, "");
            }
            try
            {
                final_drinks.Items.GetItemAt(4);

            }
            catch (Exception)
            {
                display.Insert(4, "");
            }

            final_drinks.ItemsSource = display;
            databinding_drinks();

            string i = App.Current.Properties["Order_Id"].ToString();
            string j = i;

            XDocument doc = XDocument.Load(_xmlFile_drinks);

            if (final_drinks.Items.Count > 5)
            {
                MessageBox.Show("Please select only 5 items");
            }
            else
            {
                if (lb_drinks_check.Items.Contains(i))
                {
                    drinks_1 = final_drinks.Items.GetItemAt(0).ToString();
                    drinks_2 = final_drinks.Items.GetItemAt(1).ToString();
                    drinks_3 = final_drinks.Items.GetItemAt(2).ToString();
                    drinks_4 = final_drinks.Items.GetItemAt(3).ToString();
                    drinks_5 = final_drinks.Items.GetItemAt(4).ToString();
                    string e_id = App.Current.Properties["Order_Id"].ToString();
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var product_dr = xdoc_dr.Descendants("Drinks").Single(p => p.Attribute("id").Value.Equals(e_id));
                    product_dr.SetElementValue("drinks_1", drinks_1);
                    product_dr.SetElementValue("drinks_2", drinks_2);
                    product_dr.SetElementValue("drinks_3", drinks_3);
                    product_dr.SetElementValue("drinks_4", drinks_4);
                    product_dr.SetElementValue("drinks_5", drinks_5);

                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                }
                else
                {

                    doc.Root.Add(new XElement("Drinks",
                    new XAttribute("id", j),
                    new XElement("ID", i),
                    new XElement("drinks_1", final_drinks.Items.GetItemAt(0).ToString()),
                    new XElement("drinks_2", final_drinks.Items.GetItemAt(1).ToString()),
                    new XElement("drinks_3", final_drinks.Items.GetItemAt(2).ToString()),
                    new XElement("drinks_4", final_drinks.Items.GetItemAt(3).ToString()),
                    new XElement("drinks_5", final_drinks.Items.GetItemAt(4).ToString())
                    ));
                    doc.Save(_xmlFile_drinks);
                    MessageBox.Show("Orders Added");

                }

            }
            int i1 = 0;
            while (display.Count - 1 >= i1)
            {
                if (Convert.ToString(final_drinks.Items[i1]).Trim() == string.Empty)
                {
                    display.RemoveAt(i1);
                    i1 -= 1;
                }
                i1 += 1;
            }
            MessageBox.Show("Saved!");
            payment_Details();
        }


        private void databinding_drinks()
        {
            final_drinks.ItemsSource = null;
            final_drinks.ItemsSource = display;
        }

        private void info8(object sender, SelectionChangedEventArgs e)
        {
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            if (veg_add_kids.SelectedIndex == -1)
            {
                Food_Info2.Text = "Double click on the food/drink to view Allergen Information";
                Food_Info1.Text = "Double click on the food/drink to view item description";
            }

            else if (veg_add_kids.SelectedItem.ToString() == "Mushroom n Spinach Pizza")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == veg_add_kids.SelectedItem.ToString()).Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == veg_add_kids.SelectedItem.ToString()).Elements("item2").Single();
                Food_Info2.Text = item2.Value;

            }
            else if (veg_add_kids.SelectedItem.ToString() == "Grilled Tofu Burger")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == veg_add_kids.SelectedItem.ToString()).Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == veg_add_kids.SelectedItem.ToString()).Elements("item2").Single();
                Food_Info2.Text = item2.Value;

            }
            else if (veg_add_kids.SelectedItem.ToString() == "Pickled Avocado Taco")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == veg_add_kids.SelectedItem.ToString()).Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == veg_add_kids.SelectedItem.ToString()).Elements("item2").Single();
                Food_Info2.Text = item2.Value;

            }
            else if (veg_add_kids.SelectedItem.ToString() == "Pasta Arrabbiata")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == veg_add_kids.SelectedItem.ToString()).Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == veg_add_kids.SelectedItem.ToString()).Elements("item2").Single();
                Food_Info2.Text = item2.Value;

            }
        }

        private void info3(object sender, SelectionChangedEventArgs e)
        {
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            if (W_nveg.SelectedIndex == -1)
            {
                Food_Info2.Text = "Double click on the food/drink to view Allergen Information";
                Food_Info1.Text = "Double click on the food/drink to view item description";
            }

            else if (W_nveg.SelectedItem.ToString() == "Butter Chicken with Basmati")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Butter Chicken").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Butter Chicken").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Butter Chicken").Elements("item3").Single();
            }
            else if (W_nveg.SelectedItem.ToString() == "Lamb rack with Red wine")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Lamb rack").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Lamb rack").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Lamb rack").Elements("item3").Single();
            }
            else if (W_nveg.SelectedItem.ToString() == "Chicken Parm Casserole")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Chicken Casserole").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Chicken Casserole").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Chicken Casserole").Elements("item3").Single();
            }
            else if (W_nveg.SelectedItem.ToString() == "Pecan Crusted Fish")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Fish").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Fish").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Fish").Elements("item3").Single();
            }

        }

        private void info2(object sender, SelectionChangedEventArgs e)
        {
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            if (f_1.SelectedIndex == -1)
            {
                Food_Info2.Text = "Double click on the food/drink to view Allergen Information";
                Food_Info1.Text = "Double click on the food/drink to view item description";
            }

            else if (f_1.SelectedItem.ToString() == "Penne Vodka")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "PenneVodka").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "PenneVodka").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "PenneVodka").Elements("item3").Single();
            }
            else if (f_1.SelectedItem.ToString() == "Pad Thai Noodles")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Pad Thai Noodles").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Pad Thai Noodles").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Pad Thai Noodles").Elements("item3").Single();
            }
            else if (f_1.SelectedItem.ToString() == "Truffle Risotto")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Truffle Risotto").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Truffle Risotto").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Truffle Risotto").Elements("item3").Single();
            }
            else if (f_1.SelectedItem.ToString() == "Eggplant Parmesan")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Eggplant Parmesan").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Eggplant Parmesan").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Eggplant Parmesan").Elements("item3").Single();
            }

        }

        private void info4(object sender, SelectionChangedEventArgs e)
        {
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            if (b_nveg.SelectedIndex == -1)
            {
                Food_Info2.Text = "Double click on the food/drink to view Allergen Information";
                Food_Info1.Text = "Double click on the food/drink to view item description";
            }
            else if (b_nveg.SelectedItem.ToString() == "Chicken Nuggets")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Chicken Nuggets").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Chicken Nuggets").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Chicken Nuggets").Elements("item3").Single();
            }
            else if (b_nveg.SelectedItem.ToString() == "Grilled Lasagna")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Lasagna").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Lasagna").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Lasagna").Elements("item3").Single();
            }
            else if (b_nveg.SelectedItem.ToString() == "Peperoni Pizza")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Peperoni Pizza").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Peperoni Pizza").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Peperoni Pizza").Elements("item3").Single();
            }
            else if (b_nveg.SelectedItem.ToString() == "Salami n Cheese Sandwiches")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Salami-Cheese-Sandwich").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Salami-Cheese-Sandwich").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Salami-Cheese-Sandwich").Elements("item3").Single();
            }

        }
        private void info5(object sender, SelectionChangedEventArgs e)
        {
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            if (w_des.SelectedIndex == -1)
            {
                Food_Info2.Text = "Double click on the food/drink to view Allergen Information";
                Food_Info1.Text = "Double click on the food/drink to view item description";
            }
            else if (w_des.SelectedItem.ToString() == "Tiramisu")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "tiramisu").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "tiramisu").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "tiramisu").Elements("item3").Single();
            }
            else if (w_des.SelectedItem.ToString() == "Panna cotta with Berries")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "pannacotta").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "pannacotta").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "pannacotta").Elements("item3").Single();
            }
            else if (w_des.SelectedItem.ToString() == "Fruit n Cake tarts")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "tarts").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "tarts").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "tarts").Elements("item3").Single();
            }
            else if (w_des.SelectedItem.ToString() == "Creme Brulee")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "CremeBrulee").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "CremeBrulee").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "CremeBrulee").Elements("item3").Single();
            }
            else if (w_des.SelectedIndex == -1)
            {

            }
        }

        private void info7(object sender, SelectionChangedEventArgs e)
        {
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            if (nveg_add_kids.SelectedIndex == -1)
            {
                Food_Info2.Text = "Double click on the food/drink to view Allergen Information";
                Food_Info1.Text = "Double click on the food/drink to view item description";
            }
            else if (nveg_add_kids.SelectedItem.ToString() == "Chicken n Cheese Poppers")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == nveg_add_kids.SelectedItem.ToString()).Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == nveg_add_kids.SelectedItem.ToString()).Elements("item2").Single();
                Food_Info2.Text = item2.Value;

            }
            else if (nveg_add_kids.SelectedItem.ToString() == "Ham Mac n Cheese")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == nveg_add_kids.SelectedItem.ToString()).Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == nveg_add_kids.SelectedItem.ToString()).Elements("item2").Single();
                Food_Info2.Text = item2.Value;

            }
            else if (nveg_add_kids.SelectedItem.ToString() == "Charred Peperoni Pizza")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == nveg_add_kids.SelectedItem.ToString()).Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == nveg_add_kids.SelectedItem.ToString()).Elements("item2").Single();
                Food_Info2.Text = item2.Value;

            }
            else if (nveg_add_kids.SelectedItem.ToString() == "BBQ Chicken Wings")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == nveg_add_kids.SelectedItem.ToString()).Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == nveg_add_kids.SelectedItem.ToString()).Elements("item2").Single();
                Food_Info2.Text = item2.Value;

            }
            else if (nveg_add_kids.SelectedIndex == -1)
            {

            }
        }

        private void info1(object sender, SelectionChangedEventArgs e)
        {
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            if (lb_b.SelectedIndex == -1)
            {
                Food_Info2.Text = "Double click on the food/drink to view Allergen Information";
                Food_Info1.Text = "Double click on the food/drink to view item description";
            }
            else if (lb_b.SelectedItem.ToString() == "Mac n Cheese")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "macncheese").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "macncheese").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "macncheese").Elements("item3").Single();
            }
            else if (lb_b.SelectedItem.ToString() == "Jackfruit Taco")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Jackfruit Taco").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Jackfruit Taco").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Jackfruit Taco").Elements("item3").Single();
            }
            else if (lb_b.SelectedItem.ToString() == "Blackbean Burger")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Blackbean Burger").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Blackbean Burger").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Blackbean Burger").Elements("item3").Single();
            }
            else if (lb_b.SelectedItem.ToString() == "Pizza quattro formaggi")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Pizzaquattroformaggi").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Pizzaquattroformaggi").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Pizzaquattroformaggi").Elements("item3").Single();
            }
            else if (lb_b.SelectedIndex == -1)
            {

            }
        }

        private void info6(object sender, SelectionChangedEventArgs e)
        {

            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            if (b_des.SelectedIndex == -1)
            {
                Food_Info2.Text = "Double click on the food/drink to view Allergen Information";
                Food_Info1.Text = "Double click on the food/drink to view item description";
            }
            else if (b_des.SelectedItem.ToString() == "Assorted Doughnut")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Doughnut").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Doughnut").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Doughnut").Elements("item3").Single();
            }
            else if (b_des.SelectedItem.ToString() == "Assorted Cupcakes")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Cupcakes").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Cupcakes").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Cupcakes").Elements("item3").Single();
            }
            else if (b_des.SelectedItem.ToString() == "Assorted Icecream")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Icecream").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Icecream").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Icecream").Elements("item3").Single();
            }
            else if (b_des.SelectedItem.ToString() == "Assorted Brownies")
            {
                var item1 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Brownies").Elements("item1").Single();
                Food_Info1.Text = item1.Value;

                var item2 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Brownies").Elements("item2").Single();
                Food_Info2.Text = item2.Value;

                var item3 = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == "Brownies").Elements("item3").Single();
            }
            else if (b_des.SelectedIndex == -1)
            {

            }
        }




        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(App.Current.Properties["i"]) != 1)
                {
                    App.Current.Properties["i"] = Convert.ToInt32(App.Current.Properties["i"]) - 1;
                    img_path = App.Current.Properties["image"].ToString() + App.Current.Properties["i"].ToString() + ".jpg";
                    path = "C:/Users/mayan/Desktop/" + img_path;
                    img_dis.Source = new BitmapImage(new Uri(path));
                }
                else
                {
                    App.Current.Properties["i"] = 4;
                }
            }
            catch (Exception)
            {
                App.Current.Properties["i"] = 4;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            try
            {
                App.Current.Properties["i"] = Convert.ToInt32(App.Current.Properties["i"]) + 1;
                img_path = App.Current.Properties["image"].ToString() + App.Current.Properties["i"].ToString() + ".jpg";
                path = "C:/Users/mayan/Desktop/" + img_path;
                img_dis.Source = new BitmapImage(new Uri(path));
            }
            catch (Exception)
            {
                App.Current.Properties["i"] = 0;
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

            string eid = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            var w_nv_c = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == eid).Elements("NV_food_count").Single();
            int i = Convert.ToInt32(w_nv_c.Value);

            var w_v_c = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == eid).Elements("V_food_count").Single();
            int i1 = Convert.ToInt32(w_v_c.Value);

            var w_des_c = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == eid).Elements("des_count").Single();
            int i2 = Convert.ToInt32(w_des_c.Value);

            var k_v = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == eid).Elements("kid_v_food_count").Single();
            int i3 = Convert.ToInt32(k_v.Value);

            var k_nv = doc_i.Descendants("Food").Where(g => g.Attribute("id").Value == eid).Elements("kid_nv_food_count").Single();
            int i4 = Convert.ToInt32(k_nv.Value);

            XDocument doc_d = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
            var al_c = doc_d.Descendants("Drinks").Where(g => g.Attribute("id").Value == eid).Elements("A_drinks_count").Single();
            int a_i = Convert.ToInt32(al_c.Value);

            var nal_c = doc_d.Descendants("Drinks").Where(g => g.Attribute("id").Value == eid).Elements("NA_drinks_count").Single();
            int na_i = Convert.ToInt32(nal_c.Value);

            if (W_nveg.SelectedIndex >= 0)
            {

                if (final_food.Items.Contains(W_nveg.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    MessageBox.Show("Item Added: " + W_nveg.SelectedItem.ToString());
                    final_food.Items.Add(W_nveg.SelectedItem.ToString());
                    i = i + 1;
                    App.Current.Properties["w_nv_c"] = i;
                    var product_dr = doc_i.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("NV_food_count", App.Current.Properties["w_nv_c"].ToString());
                    doc_i.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    nv_count.Text = i.ToString();
                    save_all();
                }

                W_nveg.SelectedItem = null;

            }
            else if (f_1.SelectedIndex >= 0)
            {


                if (final_food.Items.Contains(f_1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    MessageBox.Show("Item Added: " + f_1.SelectedItem.ToString());
                    final_food.Items.Add(f_1.SelectedItem.ToString());
                    i1 = i1 + 1;
                    App.Current.Properties["w_v_c"] = i1;
                    var product_dr = doc_i.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("V_food_count", App.Current.Properties["w_v_c"].ToString());
                    doc_i.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    v_count.Text = i1.ToString();
                    save_all();
                }
                f_1.SelectedItem = null;
            }
            else if (Cake.SelectedIndex >= 0)
            {

                MessageBox.Show("Item Added: " + Cake.SelectedItem.ToString());
                string e_id = App.Current.Properties["Order_Id"].ToString();

                cake_selection = Cake.SelectedItem.ToString();
                XDocument xdoc2 = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");
                var product2 = xdoc2.Descendants("Events").Single(p => p.Attribute("id").Value.Equals(e_id));
                product2.SetElementValue("Cake", Cake.SelectedItem.ToString());
                xdoc2.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");
                c_count.Text = Cake.SelectedItem.ToString();
                Cake.SelectedItem = null;
                payment_Details();
            }
            else if (w_des.SelectedIndex >= 0)
            {

                if (final_food.Items.Contains(w_des.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    final_food.Items.Add(w_des.SelectedItem.ToString());
                    i2 = i2 + 1;
                    App.Current.Properties["w_des_c"] = i2;

                    var product_dr = doc_i.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("des_count", App.Current.Properties["w_des_c"].ToString());
                    doc_i.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    d_count.Text = i2.ToString();
                    MessageBox.Show("Item Added: " + w_des.SelectedItem.ToString());
                    save_all();
                }
                w_des.SelectedItem = null;
            }
            else if (b_des.SelectedIndex >= 0)
            {

                if (final_food.Items.Contains(b_des.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    final_food.Items.Add(b_des.SelectedItem.ToString());
                    i2 = i2 + 1;
                    App.Current.Properties["w_des_c"] = i2;

                    var product_dr = doc_i.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("des_count", App.Current.Properties["w_des_c"].ToString());
                    doc_i.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    d_count.Text = i2.ToString();
                    MessageBox.Show("Item Added: " + b_des.SelectedItem.ToString());
                    save_all();
                }
                b_des.SelectedItem = null;
            }
            else if (b_nveg.SelectedIndex >= 0)
            {

                if (final_food.Items.Contains(b_nveg.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    final_food.Items.Add(b_nveg.SelectedItem.ToString());
                    i = i + 1;
                    App.Current.Properties["w_nv_c"] = i;
                    var product_dr = doc_i.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("NV_food_count", App.Current.Properties["w_nv_c"].ToString());
                    doc_i.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    nv_count.Text = i.ToString();
                    MessageBox.Show("Item Added: " + b_nveg.SelectedItem.ToString());
                    save_all();
                }
                b_nveg.SelectedItem = null;
            }
            else if (lb_b.SelectedIndex >= 0)
            {

                if (final_food.Items.Contains(lb_b.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    final_food.Items.Add(lb_b.SelectedItem.ToString());
                    i1 = i1 + 1;
                    App.Current.Properties["w_v_c"] = i1;

                    var product_dr = doc_i.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("V_food_count", App.Current.Properties["w_v_c"].ToString());
                    doc_i.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    v_count.Text = i1.ToString();
                    MessageBox.Show("Item Added: " + lb_b.SelectedItem.ToString());
                    save_all();
                }
                lb_b.SelectedItem = null;
            }
            else if (veg_add_kids.SelectedIndex >= 0)
            {

                if (final_food.Items.Contains(veg_add_kids.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    final_food.Items.Add(veg_add_kids.SelectedItem.ToString());
                    i3 = i3 + 1;
                    App.Current.Properties["k_v"] = i3;

                    var product_dr = doc_i.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("kid_v_food_count", App.Current.Properties["k_v"].ToString());
                    doc_i.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    kidsv_count.Text = i3.ToString();
                    MessageBox.Show("Item Added: " + veg_add_kids.SelectedItem.ToString());
                    save_all();
                }
                veg_add_kids.SelectedItem = null;
            }
            else if (nveg_add_kids.SelectedIndex >= 0)
            {

                if (final_food.Items.Contains(nveg_add_kids.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    final_food.Items.Add(nveg_add_kids.SelectedItem.ToString());
                    i4 = i4 + 1;
                    App.Current.Properties["k_nv"] = i4;

                    var product_dr = doc_i.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("kid_nv_food_count", App.Current.Properties["k_nv"].ToString());
                    doc_i.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    kidsnv_count.Text = i4.ToString();
                    MessageBox.Show("Item Added: " + nveg_add_kids.SelectedItem.ToString());
                    save_all();
                }
                nveg_add_kids.SelectedItem = null;
            }
            else if (al_drinks.SelectedIndex >= 0)
            {

                if (final_drinks.Items.Contains(al_drinks.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    display.Add(al_drinks.SelectedItem.ToString());
                    a_i = a_i + 1;
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                    App.Current.Properties["al_dr_c"] = a_i;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var product_dr = xdoc_dr.Descendants("Drinks").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("A_drinks_count", App.Current.Properties["al_dr_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    alcount.Text = a_i.ToString();
                    MessageBox.Show("Drink Added: " + al_drinks.SelectedItem.ToString());
                    save_all_drinks();
                }

                al_drinks.SelectedIndex = -1;

            }
            else if (nal_drinks1.SelectedIndex >= 0)
            {
                if (final_drinks.Items.Contains(nal_drinks1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    na_i = na_i + 1;
                    display.Add(nal_drinks1.SelectedItem.ToString());
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                    App.Current.Properties["nal_dr_c"] = na_i;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var product_dr = xdoc_dr.Descendants("Drinks").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("NA_drinks_count", App.Current.Properties["nal_dr_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    nalcount.Text = na_i.ToString();
                    MessageBox.Show("Drink Added: " + nal_drinks1.SelectedItem.ToString());
                    save_all_drinks();
                }
                nal_drinks1.SelectedIndex = -1;

            }

        }

        private void save_all()
        {
            XDocument xdoc_food = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
            var movieNames = xdoc_food.Descendants("Food").Attributes("id").Select(g => g.Value);
            foreach (var name in movieNames)
            {
                lb_check.Items.Add(name);
            }

            int count = Convert.ToInt32(Application.Current.Properties["Count"]);
            try
            {
                final_food.Items.GetItemAt(0);

            }
            catch (Exception)
            {
                final_food.Items.Insert(0, "");
            }
            try
            {
                final_food.Items.GetItemAt(1);

            }
            catch (Exception)
            {
                final_food.Items.Insert(1, "");
            }
            try
            {
                final_food.Items.GetItemAt(2);

            }
            catch (Exception)
            {
                final_food.Items.Insert(2, "");
            }
            try
            {
                final_food.Items.GetItemAt(3);

            }
            catch (Exception)
            {
                final_food.Items.Insert(3, "");
            }
            try
            {
                final_food.Items.GetItemAt(4);

            }
            catch (Exception)
            {
                final_food.Items.Insert(4, "");
            }
            try
            {
                final_food.Items.GetItemAt(5);

            }
            catch (Exception)
            {
                final_food.Items.Insert(5, "");
            }
            try
            {
                final_food.Items.GetItemAt(6);

            }
            catch (Exception)
            {
                final_food.Items.Insert(6, "");
            }
            try
            {
                final_food.Items.GetItemAt(7);

            }
            catch (Exception)
            {
                final_food.Items.Insert(7, "");
            }
            try
            {
                final_food.Items.GetItemAt(8);

            }
            catch (Exception)
            {
                final_food.Items.Insert(8, "");
            }
            try
            {
                final_food.Items.GetItemAt(9);

            }
            catch (Exception)
            {
                final_food.Items.Insert(9, "");
            }
            if (final_food.Items.Count <= 10)
            {
                string i = App.Current.Properties["Order_Id"].ToString();
                string j = i;

                if (lb_check.Items.Contains(i))
                {
                    food_1 = final_food.Items.GetItemAt(0).ToString();
                    food_2 = final_food.Items.GetItemAt(1).ToString();
                    food_3 = final_food.Items.GetItemAt(2).ToString();
                    food_4 = final_food.Items.GetItemAt(3).ToString();
                    food_5 = final_food.Items.GetItemAt(4).ToString();
                    food_6 = final_food.Items.GetItemAt(5).ToString();
                    food_7 = final_food.Items.GetItemAt(6).ToString();
                    food_8 = final_food.Items.GetItemAt(7).ToString();
                    food_9 = final_food.Items.GetItemAt(8).ToString();
                    food_10 = final_food.Items.GetItemAt(9).ToString();
                    string e_id = App.Current.Properties["Order_Id"].ToString();
                    XDocument xdoc1 = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");
                    var product = xdoc1.Descendants("Food").Single(p => p.Attribute("id").Value.Equals(e_id));
                    product.SetElementValue("food_1", food_1);
                    product.SetElementValue("food_2", food_2);
                    product.SetElementValue("food_3", food_3);
                    product.SetElementValue("food_4", food_4);
                    product.SetElementValue("food_5", food_5);
                    product.SetElementValue("food_6", food_6);
                    product.SetElementValue("food_7", food_7);
                    product.SetElementValue("food_8", food_8);
                    product.SetElementValue("food_9", food_9);
                    product.SetElementValue("food_10", food_10);
                    xdoc1.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile2.xml");

                    final_food.ItemsSource = null;
                }
                else
                {
                    XDocument doc = XDocument.Load(_xmlFile_food);

                    doc.Root.Add(new XElement("Food",
                    new XAttribute("id", j),
                    new XElement("ID", i),
                    new XElement("food_1", final_food.Items.GetItemAt(0).ToString()),
                    new XElement("food_2", final_food.Items.GetItemAt(1).ToString()),
                    new XElement("food_3", final_food.Items.GetItemAt(2).ToString()),
                    new XElement("food_4", final_food.Items.GetItemAt(3).ToString()),
                    new XElement("food_5", final_food.Items.GetItemAt(4).ToString()),
                    new XElement("food_6", final_food.Items.GetItemAt(5).ToString()),
                    new XElement("food_7", final_food.Items.GetItemAt(6).ToString()),
                    new XElement("food_8", final_food.Items.GetItemAt(7).ToString()),
                    new XElement("food_9", final_food.Items.GetItemAt(8).ToString()),
                    new XElement("food_10", final_food.Items.GetItemAt(9).ToString())));
                    doc.Save(_xmlFile_food);

                }
                int i1 = 0;
                while (final_food.Items.Count - 1 >= i1)
                {
                    if (Convert.ToString(final_food.Items[i1]).Trim() == string.Empty)
                    {
                        final_food.Items.RemoveAt(i1);
                        i1 -= 1;
                    }
                    i1 += 1;
                }

                payment_Details();
            }
            else
            {
                MessageBox.Show("Please select only 10 items");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string eid = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
            var al_c = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == eid).Elements("A_drinks_count").Single();
            int i = Convert.ToInt32(al_c.Value);

            var nal_c = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == eid).Elements("NA_drinks_count").Single();
            int i1 = Convert.ToInt32(nal_c.Value);

            if (al_drinks.SelectedIndex > 0)
            {

                if (final_drinks.Items.Contains(al_drinks.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    display.Add(al_drinks.SelectedItem.ToString());
                    i = i + 1;
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                    App.Current.Properties["al_dr_c"] = i;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var product_dr = xdoc_dr.Descendants("Drinks").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("A_drinks_count", App.Current.Properties["al_dr_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    alcount.Text = "Number of Drinks selected: " + i.ToString();
                    MessageBox.Show("Drink Added: " + al_drinks.SelectedItem.ToString());
                }

                al_drinks.SelectedIndex = -1;

            }
            else if (nal_drinks1.SelectedIndex > 0)
            {


                if (final_drinks.Items.Contains(nal_drinks1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Item added already");
                }
                else
                {
                    i1 = i1 + 1;
                    display.Add(nal_drinks1.SelectedItem.ToString());
                    final_drinks.ItemsSource = display;
                    databinding_drinks();
                    App.Current.Properties["nal_dr_c"] = i1;
                    XDocument xdoc_dr = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    var product_dr = xdoc_dr.Descendants("Drinks").Single(p => p.Attribute("id").Value.Equals(eid));
                    product_dr.SetElementValue("NA_drinks_count", App.Current.Properties["nal_dr_c"].ToString());
                    xdoc_dr.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");
                    nalcount.Text = "Number of Drinks selected: " + i1.ToString();
                    MessageBox.Show("Drink Added: " + nal_drinks1.SelectedItem.ToString());
                }
                nal_drinks1.SelectedIndex = -1;
            }

        }


        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow w = new MainWindow();
            w.Show();
        }

        private void duration_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (duration.SelectedIndex == 0)
            {
                App.Current.Properties["event_duration"] = 3.ToString();
                save_venue_price();
            }
            if (duration.SelectedIndex == 1)
            {
                App.Current.Properties["event_duration"] = 4.ToString();
                save_venue_price();
            }
            if (duration.SelectedIndex == 2)
            {
                App.Current.Properties["event_duration"] = 5.ToString();
                save_venue_price();
            }
            if (duration.SelectedIndex == 3)
            {
                App.Current.Properties["event_duration"] = 6.ToString();
                save_venue_price();
            }
            if (duration.SelectedIndex == 4)
            {
                App.Current.Properties["event_duration"] = 7.ToString();
                save_venue_price();
            }
            if (duration.SelectedIndex == 5)
            {
                App.Current.Properties["event_duration"] = 8.ToString();
                save_venue_price();
            }

        }

        private void save_venue_price()
        {
            string selected_id = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");

            var product_dr = doc_i.Descendants("Events").Single(p => p.Attribute("id").Value.Equals(selected_id));

            product_dr.SetElementValue("Duration", App.Current.Properties["event_duration"].ToString());

            doc_i.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");

            payment_Details();
        }

        private void al_drinks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");

            if (al_drinks.SelectedIndex == 0)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Martini").Elements("item1").Single();
                var item2 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Martini").Elements("item2").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = item2.Value;

            }
            else if (al_drinks.SelectedIndex == 1)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Margarita").Elements("item1").Single();
                var item2 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Margarita").Elements("item2").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = item2.Value;
            }
            else if (al_drinks.SelectedIndex == 2)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Red Wine").Elements("item1").Single();
                var item2 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Red Wine").Elements("item2").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = item2.Value;
            }
            else if (al_drinks.SelectedIndex == 3)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Scotch").Elements("item1").Single();
                var item2 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Scotch").Elements("item2").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = item2.Value;
            }
            else if (al_drinks.SelectedIndex == 4)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Vodka").Elements("item1").Single();
                var item2 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Vodka").Elements("item2").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = item2.Value;
            }
            else if (al_drinks.SelectedIndex == 5)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Beer - Snow and Budweiser").Elements("item1").Single();
                var item2 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Beer - Snow and Budweiser").Elements("item2").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = item2.Value;
            }
        }

        private void nal_drinks1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile3.xml");

            if (nal_drinks1.SelectedIndex == 0)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "SoftDrinks").Elements("item1").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = "No allergens!";

            }
            else if (nal_drinks1.SelectedIndex == 1)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Virgin Mojito").Elements("item1").Single();

                Food_Info1.Text = item1.Value;
                Food_Info2.Text = "No allergens!";
            }
            else if (nal_drinks1.SelectedIndex == 2)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Virgin Mary").Elements("item1").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = "No allergens!";
            }
            else if (nal_drinks1.SelectedIndex == 3)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Raspberry Iced Tea").Elements("item1").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = "No allergens!";
            }
            else if (nal_drinks1.SelectedIndex == 4)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Watermelon Lemonade").Elements("item1").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = "No allergens!";
            }
            else if (nal_drinks1.SelectedIndex == 5)
            {
                var item1 = doc_i.Descendants("Drinks").Where(g => g.Attribute("id").Value == "Fruit Sangria").Elements("item1").Single();
                Food_Info1.Text = item1.Value;
                Food_Info2.Text = "No allergens!";
            }
        }

        private void t_cake_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (t_cake.SelectedIndex == 0)
            {
                App.Current.Properties["cake_tier"] = 1.ToString();
                save_cake();
            }
            if (t_cake.SelectedIndex == 1)
            {
                App.Current.Properties["cake_tier"] = 2.ToString();
                save_cake();
            }
            if (t_cake.SelectedIndex == 2)
            {
                App.Current.Properties["cake_tier"] = 3.ToString();
                save_cake();
            }

        }

        private void save_cake()
        {
            string selected_id = App.Current.Properties["Order_Id"].ToString();
            XDocument doc_i = XDocument.Load("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");

            var product_dr = doc_i.Descendants("Events").Single(p => p.Attribute("id").Value.Equals(selected_id));

            product_dr.SetElementValue("tier", App.Current.Properties["cake_tier"].ToString());

            doc_i.Save("C:/Users/mayan/source/repos/WpfApp5/WpfApp5/XMLFile1.xml");

            payment_Details();
        }
    }

}