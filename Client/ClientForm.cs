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
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace Client
{
    // làm về công việc file json, về phần đọc thông tin địa điểm: tên địa điểm, mã số vùng, kinh độ vĩ độ và miêu tả 


    //Bởi vì thiết bị Client không tạo ra kết nối đến
    //một địa chỉ Server cụ thể do đó phương thức Connect()
    //không cần dùng trong chương trình UDP Client
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }
        public class State
        {
            public byte[] buffer = new byte[bufSize];
        }

        // Thay vào đó, Socket phi kết nối cung cấp hai phương thức
        // để thực hiện việc này là SendTo() và ReceiveFrom()
        private string receiveImg()
        {
            int bytes = socketClient.ReceiveFrom(state.buffer, 0, bufSize, SocketFlags.None, ref epFrom);

            byte[] req = new byte[bytes];
            Array.Copy(state.buffer, req, bytes);

            data = Encoding.UTF8.GetString(req);
            Dictionary<string, string> res = new Dictionary<string, string>();
            res = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);

            int totalByte = Int32.Parse(res["totalByte"]);

            int byteCurrent = 0;

            string image = "";
            while (byteCurrent< totalByte)
            {
                sendRequest("{\"key\":\"img\", \"byteCur\":\"" + byteCurrent.ToString() + "\"}");
                Thread.Sleep(2);
                bytes = socketClient.ReceiveFrom(state.buffer, 0, bufSize, SocketFlags.None, ref epFrom);

                req = new byte[bytes];
                Array.Copy(state.buffer, req, bytes);

                data = Encoding.UTF8.GetString(req);
                image += data;
                byteCurrent += data.Length;
            }
            return image;
        }

        private void receiveData()
        {
            int bytes = socketClient.ReceiveFrom(state.buffer, 0, bufSize, SocketFlags.None, ref epFrom);
            try
            {
                State so = state;
                byte[] req = new byte[bytes];
                Array.Copy(state.buffer, req, bytes);
                data = Encoding.UTF8.GetString(req);

                if (data == "Agree to connect")
                {
                    MessageBox.Show("Connection complete!", "Notify", MessageBoxButtons.OK);
                }
                else if (data == "Disconnection") //{"key":"Disconnection"} 
                {
                    disconnectFromServer();
                }

                else
                {
                    Dictionary<string, string> res = new Dictionary<string, string>();
                    res = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);

                    //disconnectFromServer();
                    if (res["ten"] == "NONE")
                    {
                        data = "No data!!!";
                    }

                    if (res["key"] == "detail")
                    {
                        ten = res["ten"];
                        ma_so = res["ma"];
                        kinh_do = res["kinh_do"];
                        vi_do = res["vi_do"];
                        mo_ta = res["mo_ta"];
                        pathPic = res["pic"];
                    }
                    else if (res["key"] == "All detail")
                    {
                        tenn.Add(res["ten"]);
                        ma_soo.Add(res["ma"]);
                        kinh_doo.Add(res["kinh_do"]);
                        vi_doo.Add(res["vi_do"]);
                        mo_taa.Add(res["mo_ta"]);
                    }

                }
                Array.Clear(state.buffer, 0, bufSize);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ReceiveData Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void sendRequest(string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            socketClient.SendTo(data, epFrom);
        }
        private void disconnectFromServer()
        {
            try
            {
                DialogResult res = MessageBox.Show(
                    "  Server has been disconnected!!!" +
                    "\nDo you want to close client?", "Server"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes) this.Close();
                socketClient.Shutdown(SocketShutdown.Both);
                socketClient.Disconnect(true);

            }
            catch { }
        }
        private void IPenter_Click(object sender, EventArgs e)
        {
            if (IPenter.Text != "Enter IP") return;
            IPenter.Text = "";
            IPenter.ForeColor = Color.Black;
        }

        private void IPenter_Leave(object sender, EventArgs e)
        {
            if (IPenter.Text != "") return;
            IPenter.Text = "Enter IP";
            IPenter.ForeColor = Color.Gray;
        }
        private void Portenter_Click(object sender, EventArgs e)
        {
            if (Portenter.Text != "Enter port") return;
            Portenter.Text = "";
            Portenter.ForeColor = Color.Black;
        }

        private void Portenter_Leave(object sender, EventArgs e)
        {
            if (Portenter.Text != "") return;
            Portenter.Text = "Enter port";
            Portenter.ForeColor = Color.Gray;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                IPenter.Text = "127.3.1.1";
                Portenter.Text = "24";
                IPenter.ForeColor = Portenter.ForeColor = Color.Black;
            }
            else
            {
                IPenter.Text = "Enter IP";
                Portenter.Text = "Enter port";
                IPenter.ForeColor = Portenter.ForeColor = Color.Gray;
            }
        }

        private void connectServer_Click(object sender, EventArgs e)
        {
            try
            {
                socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                socketClient.Connect(new IPEndPoint(IPAddress.Parse(IPenter.Text), Int32.Parse(Portenter.Text)));
                epFrom = new IPEndPoint(IPAddress.Parse(IPenter.Text), Int32.Parse(Portenter.Text));

                sendRequest("Connecting....");
                receiveData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnectServer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show(
                    "  Do you want to disconnect from server?",
                    "Disconnect"
                  , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes) this.Close();

                sendRequest("{ \"key\" : \"Disconnect\"}");

                socketClient.Shutdown(SocketShutdown.Both);
                socketClient.Disconnect(true);
            }
            catch { }
        }

        private void displayAll_Click(object sender, EventArgs e)
        {
            tenn = new List<string>();
            mo_taa = new List<string>();
            ma_soo = new List<string>();
            kinh_doo = new List<string>();
            vi_doo = new List<string>();
          
            try
            {
                AllPlaces Objs = new AllPlaces();
                string req = "{ \"key\" : \"All detail\"}";
                sendRequest(req);
                for (int i = 0; i < 11; i++)
                    receiveData();

                Objs.ten = tenn;
                Objs.mo_ta = mo_taa;
                Objs.ma_so = ma_soo;
                Objs.kinh_do = kinh_doo;
                Objs.vi_do = vi_doo;
                Objs.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                OnePlace Obj = new OnePlace();
                if (NamePlaceSearch.Text != "Enter name of place")
                {
                    // gửi vị trí muốn tìm kiếm
                    string req = "{ \"key\" : \"detail\", \"search\":\"" + NamePlaceSearch.Text + "\"}"; 
                    sendRequest(req);
                    receiveData();

                    if (data == "No data!!!")
                    {
                        MessageBox.Show("This data isn't exist !", "No data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    { 
                    // DB/Picture.jpg,DB/Picture2.jpg
                    string[] pathArr = pathPic.Split(',');
                    pics = new string[pathArr.Length];
                    for (int i=0; i<pathArr.Length; i++)
                    {
                            sendRequest(
                                "{ \"key\" : \"img\"," +
                                " \"byteCur\":\"-1\", \"path\":\"" +
                                pathArr[i] +
                                "\"}");
                        pics[i] = receiveImg();
                    }

                    Obj.ten = ten;
                    Obj.mo_ta = mo_ta;
                    Obj.ma_so = ma_so;
                    Obj.kinh_do=kinh_do; 
                    Obj.vi_do = vi_do;
                    Obj.pic = pics;
                    Obj.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NamePlaceSearch_Click(object sender, EventArgs e)
        {
            if (NamePlaceSearch.Text != "Enter name of place") return;
            NamePlaceSearch.Text = "";
            NamePlaceSearch.ForeColor = Color.Black;
        }
        private void NamePlaceSearch_Leave(object sender, EventArgs e)
        {
            if (NamePlaceSearch.Text != "") return;
            NamePlaceSearch.Text = "Enter name of place";
            NamePlaceSearch.ForeColor = Color.Gray;
        }
            
        public Socket socketClient;
        private const int bufSize = 70000;
        private State state = new State();
        private EndPoint epFrom = new IPEndPoint(IPAddress.Any, 0);
        private AsyncCallback recv = null;
        public static string data;
        public string ten, ma_so, kinh_do, vi_do, mo_ta;
        private string pathPic;
        private string[] pics;
        public List<string> tenn;
        public List<string> ma_soo;
        public List<string> kinh_doo;
        public List<string> vi_doo;
        public List<string> mo_taa;
    }
}