using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueAtRisk.Entities;

namespace ValueAtRisk
{
    public partial class Form1 : Form
    {
        PortfolioEntities1 context = new PortfolioEntities1();
        List<Tick> Ticks;
        List<PortfolioItem> Portfolio = new List<PortfolioItem>;

        public Form1()
        {
            InitializeComponent();
            Ticks = context.Tick.ToList();
            dataGridView1.DataSource = Ticks;
            CreatePortfolio();
        }

        private void CreatePortfolio()
        {
            
        }
    }
}
