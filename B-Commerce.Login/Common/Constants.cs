using System;
using System.Collections.Generic;
using System.Text;

namespace B_Commerce.Login.Common
{
    public class Constants
    {
        public enum ResponseCode
        {
            SUCCESS,
            INVALID_USERNAME_OR_PASSWORD,
            SYSTEM,
            FAILED

        }

        public static Dictionary<int, string> ErrorCodes = new Dictionary<int, string>
      {
          {0,"Başarılı" },
          {1,"Kullanıcı adı veya şifre hatalı" },
          {2,"Sistemsel bir hata oluştu" }

      };
    }
}
