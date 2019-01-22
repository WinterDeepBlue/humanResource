using System.Data;
using humanResource.APPCODE.DAL;

namespace humanResource.APPCODE.BLL.department
{
    public partial class DepartmentQuery
    {
        CoreX obj = new CoreX();
        //department_insert/update
        public int DepartmentInsert(string depName, string description, string empLead,string parentdept)
        {
            string InsertQuery = "Insert into department(deptId,depName,description,dLeadEmp,parentDept) Values(@deptId,@depName,@description,@dLeadEmp,@parentDept)";
            GUID buffer = new GUID();
            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@deptId", buffer.hashFunc(depName)));
            nameValuePairObject.Add(new NameValuePair("@depName", depName));
            nameValuePairObject.Add(new NameValuePair("@description", description));
            nameValuePairObject.Add(new NameValuePair("@dLeadEmp", empLead));
            nameValuePairObject.Add(new NameValuePair("@parentDept", parentdept));
            int status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return status;
        }
        //fetchQuery>>specific-dept
        public DataSet DepartmentFsequence(string deptId)
        {
            string selectQuery = "SELECT * FROM department WHERE deptId='"+deptId+"'";
            DataSet data = obj.FillAndReturnDataSet(selectQuery);
            return data;
        }

        #region deleteQuery

        //early-stage
        #region deleteQuery
        public int DeleteRecord(string deptid)
        {
            string delQuery = "DELETE FROM department WHERE depId='" + deptid + "'";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@depId", deptid));

            int status = obj.InsertUpdateOrDelete(delQuery, nameValuePairObject);
            return status;
        }
        //bulk-delete
        #endregion

        public int DeleteByName(string deptName)
        {
            string delquery = "DELETE FROM department WHERE depName LIKE '%" + deptName + "%'";
            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@depName", deptName));
            int status = obj.InsertUpdateOrDelete(delquery, nameValuePairObject);
            return status;
        }
        #endregion
        #region updatequery
        public int DepartmentUpdate(string depName,string description,string empLead,string parentDept,string deptId)
        {
            string updateQuery = "UPDATE department SET depName='"+depName+"',description='"+description+"',dLeadEmp='"+empLead+"',parentDept='"+parentDept+"' WHERE deptId='"+deptId+"'";
            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@depName", depName));
            nameValuePairObject.Add(new NameValuePair("@description", description));
            nameValuePairObject.Add(new NameValuePair("@dLeadEmp", empLead));
            nameValuePairObject.Add(new NameValuePair("@parentDept", parentDept));
            int status = obj.InsertUpdateOrDelete(updateQuery, nameValuePairObject);
            return status;
        }
        #endregion
    }

    public class DesignationQuery
    {
         CoreX obj =new CoreX();
         //designation_insert/update
         #region InsertQuery
        
         public int DesignationUpdate(string designation, string description)
                {
                    string InsertQuery = "Insert into designationT(desgId,designation,description) Values(@desgId,@designation,@description)";
                    GUID buffer = new GUID();
                    NameValuePairList nameValuePairObject = new NameValuePairList();
                    nameValuePairObject.Add(new NameValuePair("@desgId", buffer.hashFunc(designation)));
                    nameValuePairObject.Add(new NameValuePair("@designation", designation));
                    nameValuePairObject.Add(new NameValuePair("@description", description));

                    int status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
                    return status;
                }
         #endregion

         //fetch>>specific-designation
         #region fetchQuery
         public DataSet DepartmentFsequence(string desgId)
                {
                    string selectQuery = "SELECT * FROM designationT WHERE desgId='" + desgId + "'";
                    DataSet data = obj.FillAndReturnDataSet(selectQuery);
                    return data;
                }
         #endregion
        
        #region deleteQuery

         //early-stage
         #region deleteQuery
          public int DeleteRecord(string desgId)
                {
                    string delQuery = "DELETE FROM designationT WHERE depId='" + desgId + "'";

                    NameValuePairList nameValuePairObject = new NameValuePairList();
                    nameValuePairObject.Add(new NameValuePair("@desgId", desgId));

                    int status = obj.InsertUpdateOrDelete(delQuery, nameValuePairObject);
                    return status;
                }
        //bulk-delete
         #endregion
        
        public int DeleteByName(string designation)
        {
            string delquery = "DELETE FROM designationT WHERE depName LIKE '%" + designation + "%'";
            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@designation", designation));
            int status = obj.InsertUpdateOrDelete(delquery, nameValuePairObject);
            return status;
        }
        #endregion
        //update->query
        #region updateQuery
        
        public int UpdateQuery(string desgId, string designation,string description)
        {
            string updateQuery = "UPDATE designationT SET deignation ='"+designation+"',description ='"+description+"' WHERE desgId='"+desgId+"'";
            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@designation", designation));
            nameValuePairObject.Add(new NameValuePair("@description", description));
            int status = obj.updateQ(updateQuery, nameValuePairObject);
            return status;
        }
        #endregion
    }
}