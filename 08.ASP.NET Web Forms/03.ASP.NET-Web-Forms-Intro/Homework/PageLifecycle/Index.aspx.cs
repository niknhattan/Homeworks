﻿namespace PageLifecycle
{
    using System;
    public partial class Index : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            Response.Write("ON INIT invoked" + "<br/>");
            base.OnInit(e);
        }
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Page_PreInit invoked" + "<br/>");
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Page_Init invoked" + "<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page_Load invoked" + "<br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Page_PreRender invoked" + "<br/>");
        }


        protected void ButtonOK_Init(object sender, EventArgs e)
        {
            Response.Write("ButtonOK_Init invoked" + "<br/>");
        }

        protected void ButtonOK_Load(object sender, EventArgs e)
        {
            Response.Write("ButtonOK_Load invoked" + "<br/>");
        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            Response.Write("ButtonOK_Click invoked" + "<br/>");
        }

        protected void ButtonOK_PreRender(object sender, EventArgs e)
        {
            Response.Write("ButtonOK_PreRender invoked" + "<br/>");
        }

    }
}