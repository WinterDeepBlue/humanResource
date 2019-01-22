using humanResource.APPCODE.DAL;

namespace humanResource.APPCODE.BLL.employee
{
    public class e_insert
    {
        CoreX obj = new CoreX();

        #region insert_columns
        //for_fetch_corporate_bsc_info
        public int basic_info(string Name, string Phone, string Email)
        {
            string InsertQuery = "Insert into employee(Name,Phone,Email) Values(@Name,@Phone,@Email)";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@Name", Name));
            nameValuePairObject.Add(new NameValuePair("@Phone", Phone));
            nameValuePairObject.Add(new NameValuePair("@Email", Email));

            int Status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return Status;
        }

        

        //for_fetch_work_info_work exp
        public int basic_info(string current_emplyr,string current_post,string from_d,string to_d,string desc)
        {
            string InsertQuery = "Insert into interviewee(current_employeer,current_posit,employd_fd,employee_td,job_description) Values(@current_employeer,@current_posit,@employd_fd,@employee_td,@job_description)";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@current_employeer", current_emplyr));
            nameValuePairObject.Add(new NameValuePair("@current_posit", current_post));
            nameValuePairObject.Add(new NameValuePair("@employd_fd", from_d));
            nameValuePairObject.Add(new NameValuePair("@employee_td", to_d));
            nameValuePairObject.Add(new NameValuePair("@job_description",desc));

            int Status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return Status;
        }

        //to_address_line
        public int address_line(string block, string street, string city,int zipcode,string state,string district,string country,int emp_id)
        {
            string InsertQuery = "Insert into employee(block,street,city,zipcode,state,district,country) Values(@block,@street,@city,@zipcode,@state,@district,@country)";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@block", block));
            nameValuePairObject.Add(new NameValuePair("@street", street));
            nameValuePairObject.Add(new NameValuePair("@city", city));
            nameValuePairObject.Add(new NameValuePair("@zipcode", zipcode));
            nameValuePairObject.Add(new NameValuePair("@state", state));
            nameValuePairObject.Add(new NameValuePair("@district",district));
            nameValuePairObject.Add(new NameValuePair("@country", country));

            int Status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return Status;
        }

        #endregion
    }
}