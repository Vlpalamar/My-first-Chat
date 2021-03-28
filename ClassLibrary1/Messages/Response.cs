using System;

namespace ClassLibrary1.Messages
{
    /// <summary>
    /// Тип сообщения, которым сервер отвечает
    /// </summary>
    [Serializable]
    public class Response
    {
        public bool success { get; set; }
        public Enums.ResponseCodes code { get; set; }
        public string msg { get; set; }
        public object data { get; set; }
    }
}