using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storj_CSharp_GUI_Client
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int r = new Random().Next();
			//var rest = new REST.RESTProcessor;
			//REST.RESTProcessor.("https://api.storj.io/contacts/8bcd2636cc4c3799ba4e2e86f45e89bc7ffe05ca","");
			
		}

		private void btnNodeInfo_Click(object sender, EventArgs e)
		{
		var res = REST.RESTProcessor.GET("https://api.storj.io/contacts/" + txtNodeID.Text);
		var res2 = JsonConvert.DeserializeObject(res);

		}
	}
}
