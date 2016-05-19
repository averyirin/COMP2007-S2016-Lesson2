using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2007_S2016_Lesson2_Part2 {
    public partial class Site : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            ChangeActivePage();
        }
        /**
         * Change the active page depending on the page title
         * 
         * @method ChangeActivePage
         */
        private string ChangeActivePage() {
            switch (Page.Title) {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Products":
                    products.Attributes.Add("class", "active");
                    break;
                case "Services":
                    services.Attributes.Add("class", "active");
                    break;
                case "About":
                    about.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
            }
            return Page.Title;
        }
            
    }
}