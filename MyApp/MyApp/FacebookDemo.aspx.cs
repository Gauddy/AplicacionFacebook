using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facebook;

namespace MyApp
{
    public partial class FacebookDemo : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var fb = new FacebookClient();
             if (Request.QueryString["code"] != null)
            {
                string accessCode = Request.QueryString["code"].ToString();
 
                
 
                // throws OAuthException 
                dynamic result = fb.Post("oauth/access_token", new
                {
 
                    client_id = "your_app_id",
 
                    client_secret = "your_app_secret",
 
                    redirect_uri = "http://localhost:8779/FacebookDemo.aspx",
 
                    code = accessCode
 
                });
 
                var accessToken = result.access_token;
              }
        }

            protected void Button1_Click(object sender, EventArgs e)
       {
           var fb = new FacebookClient();
            var loginUrl = fb.GetLoginUrl(new
               {
 
                   client_id = "your_app_id",
 
                   redirect_uri = "http://localhost:8779/FacebookDemo.aspx",
 
                   response_type = "code",
 
                   scope = "email" // Add other permissions as needed
 
               });
               Response.Redirect(loginUrl.AbsoluteUri);
        }
        
    }
}