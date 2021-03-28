using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp27
{
    public class ServerConnect
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        public string host { get; set; } = "localhost";
        public int port { get; set; } = 3333;

        private BinaryFormatter bf;

        public static Action<string> onError = new Action<string>((string msg) => { MessageBox.Show("Server Error: " + msg); });



        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        private ServerConnect(string login, string password, string host = "localhost", int port = 3333)
        {
            start(login, password, host, port);
        }


        /// <summary>
        /// Установка соединения
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        public void start(string login, string password, string host = "localhost", int port = 3333)
        {
            if (tcpClient != null)
            {
                onError(" Уже есть экземпляр");
                return;
            }
            try
            {
                tcpClient = new TcpClient(host, port);
                stream = tcpClient.GetStream();
                bf = new BinaryFormatter();
            }
            catch (Exception e)
            {
                onError(e.Message);
            }

            // Запрос на авторизацию
            Request request = new Request();
            request.command = Commands.UserLogin;
            request.id = 0;
            request.entity = Entities.None;
            // Последняя точка - шифрование пароля
            request.data = new User() { email = login, pswd = password };

            // Отправка запроса
            sendRequest(ref request);
            // Получение ответа
            Response response = receiveResponce();

            if (!response.success)
            {
                Close();
                onError(" Ответ не норма");
                return;
            }

            if (response.code != ResponseCodes.OK)
            {
                Close();
                onError(" Код ответа " + response.code);
                return;
            }

            MessageBox.Show("Соединение с сервером установленно");
        }

        private void Close()
        {

        }

        private static ServerConnect instance;


        /// <summary>
        /// Реализация одиночки
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        public static ServerConnect getInstance(string login, string password, string host = "localhost", int port = 3333)
        {
            if (instance == null)
            {
                instance = new ServerConnect(login, password, host, port);
            }
            return instance;
        }

        public static ServerConnect getInstance()
        {
            return instance;
        }
        /// <summary>
        /// Отослать запрос серверу
        /// </summary>
        /// <param name="res"></param>
        public ServerConnect sendRequest(ref Request req)
        {
            try
            {
                bf.Serialize(stream, req);
            }
            catch (Exception ex)
            {
                onError(" sendRequest: " + ex.Message);
            }

            return this;
        }

        /// <summary>
        /// Получить получить ответ от сервера
        /// </summary>
        /// <returns></returns>
        public Response receiveResponce()
        {
            try
            {
                while (!stream.DataAvailable)
                {

                }
                return (Response)bf.Deserialize(stream);
            }
            catch (Exception ex)
            {
                onError(" receiveRequest: " + ex.Message);
            }

            return null;
        }




    }
}
