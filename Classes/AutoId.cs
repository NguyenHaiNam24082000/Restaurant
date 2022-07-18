using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Restaurant.Classes
{
    static class AutoId
    {
        static ConnectDataBase connectDataBase = new ConnectDataBase();
        public static string getID(string headerID,int len,string sql)
        {
            int id=0;
            string idString = "";
            bool isHave = false;
            DataTable dataTable = connectDataBase.readData(sql);
            //DataTable dt = null;
            if (dataTable.Rows.Count >= 1)
            {
                do
                {
                    idString = "";
                    id++;
                    idString = headerID;
                    for (int i = 0; i < len - (idString.Length + id.ToString().Length); ++i)
                    {
                        idString += "0";
                    }
                    idString += id.ToString();
                    if (id <= dataTable.Rows.Count)
                    {
                        if (idString.ToUpper().Trim().Equals(dataTable.Rows[id - 1].ItemArray[0].ToString().ToUpper().Trim()))
                        {
                            isHave = true;
                        }
                        else isHave = false;
                    }
                    else
                    {
                        isHave = false;
                    }    
                }
                while (isHave);
            }
            else
            {
                idString = headerID;
                for (int i=0;i<len-(idString.Length+1);++i)
                {
                    idString += "0";
                }
                idString += "1";
            }                
            return idString;
        }
    }
}
