using B_Commerce.Login.Common;
using System;
using System.Collections.Generic;
using System.Text;
using static B_Commerce.Login.Common.Constants;

namespace B_Commerce.Login.Response
{
    public class BaseResponse
    {
        public int Code { get; set; }

        public string Messeage { get; set; }
        public void SetError(ResponseCode code)
        {
            this.Code = (int)code;
            this.Messeage = Constants.ErrorCodes[(int)code];

        }
    }
}
