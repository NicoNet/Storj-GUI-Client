using Newtonsoft.Json;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Org.BouncyCastle.OpenSsl;

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
		var res = REST.GET("https://api.storj.io/contacts/" + txtNodeID.Text);
		var res2 = JsonConvert.DeserializeObject(res);

		}



		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnCreateUser_Click(object sender, EventArgs e)
		{
			AsymmetricCipherKeyPair keys = GenerateKeys(256);
			//var pub = (ECPublicKeyParameters)keys.Public;
			//var prv = (ECPrivateKeyParameters)keys.Private;
			
			String pub = getKey(keys.Public).Replace("-","");
			String prv = getKey(keys.Private).Replace("-",""); //BitConverter.ToString(data);

		}
		private static string getKey(dynamic key)
		{
			TextWriter textWriter = new StringWriter();
			PemWriter pemWriter = new PemWriter(textWriter);
			pemWriter.WriteObject(key);
			pemWriter.Writer.Flush();
			string pem = textWriter.ToString();
			var pem2 = pem.Split('\r').Skip(1).TakeWhile(i => !i.Contains("-----")).ToArray();
			pem = string.Join("",pem2);
			byte[] bytes = Convert.FromBase64String(pem);
			string hex = BitConverter.ToString(bytes);
			return hex;
		}
		private static AsymmetricCipherKeyPair GenerateKeys(int keySize)
		{
			ECKeyPairGenerator gen = new ECKeyPairGenerator("ECDSA");
			SecureRandom secureRandom = new SecureRandom();
			KeyGenerationParameters keyGenParam = new KeyGenerationParameters(secureRandom, keySize);
			gen.Init(keyGenParam);
			return gen.GenerateKeyPair();
		}
	}
}
