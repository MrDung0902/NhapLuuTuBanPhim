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
using Newtonsoft.Json;
namespace NhapLuuTuBanPhim
{
    public partial class Nhapdulieu : Form
    {
        List<string> history = new List<string>();
        string LogFilePath = "log_history.txt";
        public Nhapdulieu()
        {
            InitializeComponent();
            if (File.Exists(LogFilePath))
            {
                string json = File.ReadAllText(LogFilePath);
                try
                {
                    history = JsonConvert.DeserializeObject<List<string>>(json) ?? new List<string>();
                    TxbLog.Text = string.Join(Environment.NewLine, history);
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Loi khi doc file Json: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TxbNhapdulieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
           
            string input = DateTime.Now +" || "+TxbNhapdulieu.Text;           
            if (!string.IsNullOrEmpty(TxbNhapdulieu.Text))
            {
                history.Add(input);
                TxbLog.Text = string.Join(Environment.NewLine, history);
          
                ///Luu File Json.
                ///
                try
                {
                    string json = JsonConvert.SerializeObject(history, Formatting.Indented);
                    File.WriteAllText(LogFilePath, json);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(" Loi khi luu JSON:" + ex.Message);
                }
                TxbNhapdulieu.Clear();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            TxbLog.Clear();
            history.Clear();
            File.WriteAllText(LogFilePath, TxbLog.Text);
        }
    }
}
