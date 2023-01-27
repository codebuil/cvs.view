using System.Collections.ObjectModel;

namespace csvView3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string arg = openFileDialog1.FileName;
            int n = 0;
            int nn = 0;
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.GridLines = true;
            listView1.View = View.Details;
            if (arg.Count() > 0)
            {
  
                try
                {
                    string[] lines = System.IO.File.ReadAllLines("" + arg);




                    for (n = 0; n < lines.Count(); n++)
                    {

                        
                            string[] colss = lines[n].Split(",");
                        if (n == 0)
                        {
                            for (nn = 0; nn < colss.Count(); nn++)
                            {
                                
                                listView1.Columns.Add(colss[nn]);
                            }
                        }
                        ListViewItem item1 = new ListViewItem(colss[0], -2);

                        if (colss.Count() > 1)
                        {
                            for (nn = 1; nn < colss.Count(); nn++)
                            {
                                item1.SubItems.Add(colss[nn]);
                                
                            }
                        }
                            listView1.Items.AddRange (new ListViewItem[] { item1 });
                        
                            

                         
                    }
                        
                        
                    
                }
                catch (Exception ee)
                {
  
                }
  
            }
            else
            {
           
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}