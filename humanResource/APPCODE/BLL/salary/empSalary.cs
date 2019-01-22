using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using humanResource.APPCODE.DAL;

namespace humanResource.APPCODE.BLL.salary
{
    public class empSalary
    {
        CoreX con = new CoreX();  
            //salary_details
            public int salary_scheme_info(string b_ac_no, string dop, string h_name, string IFSC,/*set_status_func_needed*/bool status, string ac_type, float pay_rate, string pay_type, bool paid, int emp_id)
            {
                
                string sal = "INSERT INTO salary(bank_ac_no,date_o_pay,holder_name,IFSC,status,ac_type,pay_rate,pay_type,paid,emp_id) VALUES (@bank_ac_no,@date_o_pay,@holder_name,@IFSC,@status,@ac_type,@pay_rate,@pay_type,@paid,@emp_id)";
                NameValuePairList NameValuePairObject = new NameValuePairList();

                NameValuePairObject.Add(new NameValuePair("@bank_ac_no", b_ac_no));
                NameValuePairObject.Add(new NameValuePair("@date_o_pay", dop));
                NameValuePairObject.Add(new NameValuePair("@holder_name", h_name));
                NameValuePairObject.Add(new NameValuePair("@IFSC", IFSC));
                NameValuePairObject.Add(new NameValuePair("@status", status));
                NameValuePairObject.Add(new NameValuePair("@ac_type", ac_type));
                NameValuePairObject.Add(new NameValuePair("@pay_rate", pay_rate));//amount_per_month{fluctuates}
                NameValuePairObject.Add(new NameValuePair("@pay_type", pay_type));//M/0>>default
                NameValuePairObject.Add(new NameValuePair("@emp_id", emp_id));


                int Status = con.InsertUpdateOrDelete(sal, NameValuePairObject);
                return Status;
            }
            //pay_rate fluctuation
            public int pay_rateupdate(float value)
            {
                string query = "INSERT INTO salary(pay_rate) VALUES (@pay_rate)";
                NameValuePairList NameValuePairObject = new NameValuePairList();

                NameValuePairObject.Add(new NameValuePair("@pay_rate", value));
                int Status = con.InsertUpdateOrDelete(query, NameValuePairObject);
                return Status;
            }

        }
}