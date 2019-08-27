using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;

namespace WebApplication1
{
    public class Class1
    {
        [HttpPost]
        public HttpResponseMessage PostAP()
        {
            //expected AP
            return new HttpResponseMessage();
        }

        [HttpPost]
        public HttpResponseMessage PostWithSaveAtLevel1()
        {
            //expected no AP
            Class2.save();
            return new HttpResponseMessage();
        }


        [HttpPost]
        public HttpResponseMessage PostWithSaveAtLevel2()
        {
            //expected no AP
            Class2.method2();
            return new HttpResponseMessage();
        }

    }
}
