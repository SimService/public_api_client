﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Api
{
    public static class StatusCodeExtension
    {
        public static StatusCodeObject AsObject(this StatusCode code)
        {
            switch (code)
            {
                case StatusCode.success:
                    return new StatusCodeObject() { code = (int)code, description = "success" };
                case StatusCode.partial_success:
                    return new StatusCodeObject() { code = (int)code, description = "input error" };
                case StatusCode.failed:
                    return new StatusCodeObject() { code = (int)code, description = "server error" };
                default:
                    return new StatusCodeObject() { code = (int)code, description = "server error" };
            }
        }
    }
    public class StatusCodeObject
    {
        public int code { get; set; }
        public string description { get; set; }
    }
}