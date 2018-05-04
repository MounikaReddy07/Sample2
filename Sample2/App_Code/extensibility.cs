using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample2.App_Code
{
    public class extensibility
    {
        public static List<string> GetList()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add("item" + i.ToString());
            }
            return list;
        }

    }
}