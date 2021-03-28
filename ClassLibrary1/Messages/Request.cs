using System;

namespace ClassLibrary1.Messages
{
   
   
        /// <summary>
        /// Тип сообщения, который клиент посылает на сервер
        /// </summary>
        [Serializable]
        public class Request
        {
            public Enums.Commands command { get; set; }
            public Enums.Entities entity { get; set; }
            public int id { get; set; }
            public object data { get; set; }
        }
    
}