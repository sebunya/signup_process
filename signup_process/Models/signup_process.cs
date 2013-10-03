using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace signup_process.Models
{
    public class signup_process
    {

        //depositor details on  signup  with customer

                     public int ID { get; set;}
                     public string name_of_depositor { get; set; }
                     public string nationality { get; set; }
                     public string nationality { get; set; }
                     public string district { get; set; }
                     public string place_of_birth { get; set; }
                     public string sub_county { get; set; }
                     public string marital_status { get; set; }
                     public string no_of_dependants { get; set; }
                     public string id_or_passportno { get; set; }
                     public string date_of_issue { get; set; }
                     public string permannent_address { get; set; }
                     public string postal_address { get; set; }
                     public string employer { get; set; }
                     public string nature_of_business { get; set; }
                     public string location { get; set; }
                     public string office_or_business { get; set; }
                     public string other_bankers { get; set; }
                     public string next_of_kin { get; set; }
                     public string relationship { get; set; }
                     public string nationality { get; set; }
                     public int phone_no{ get; set; }
                     public string gender { get; set; }
                     public DateTime date_of_account_creation { get; set; }
                     public string referer { get; set; }
                     public string branch { get; set; }
                     public virtual ICollection<signup_process_backoffice> signup_process_backoffice { set; get; }
    }

    public class signup_process_backoffice
    {

        //depositor details in  the back office

        public int customer_ID { get; set; }
        public string account_chosen { get; set; }
        public string account_number { get; set; }
        public string account_brought_by { get; set; }
        public string name_of_staff { get; set; }

        public virtual signup_process signup_process { get; set; }

    }


    public class signup_processDBcontext : DbContext
    {

        public DbSet<signup_process> signup_process { get; set; }
        public DbSet<signup_process_backoffice> signup_process_backoffice { get; set; }
    }


}
