﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HelloService.HelloServiceClient client = new HelloService.HelloServiceClient("BasicHttpBinding_IHelloService");
            LabelMsg.Text = client.GetMessage(TextBox1.Text);

        }
    }
}