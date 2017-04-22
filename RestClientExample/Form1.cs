using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Making Rest Queries in .NET
 * This example was made using just .net framework.
 * Was made following this good tutorial: https://docs.microsoft.com/en-us/dotnet/articles/csharp/tutorials/console-webapiclient
 */
namespace RestClientExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestClient rc = new RestClient();
            this.textBox1.Text = RestClient.query("https://api.github.com/orgs/dotnet/repos");
        }
    }
}
