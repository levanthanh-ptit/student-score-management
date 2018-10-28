using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DX_Student_Score_Management
{
    public class ConnectionData
    {
        private string server;
        private string dataBase;
        private string userId;
        private string password;

        public string GetConnectionString()
        {
            return $"server={server};database={dataBase};user id={userId};password={password}";
        }

        public string GetServer()
        {
            return server;
        }

        public void SetServer(string value)
        {
            server = value;
        }

        public string GetDataBase()
        {
            return dataBase;
        }

        public void SetDataBase(string value)
        {
            dataBase = value;
        }
        public string GetUserId()
        {
            return userId;
        }

        public void SetUserId(string value)
        {
            userId = value;
        }
        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string value)
        {
            password = value;
        }
    }
}
