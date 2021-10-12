using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Insert(InsertEmployee Employee);

      
        // TODO: Add your service operations here  

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class InsertEmployee
    { 
        string EmpName = string.Empty;
        int salary;
        string City = string.Empty;

        [DataMember]
        public string Name
        {
            get { return EmpName; }
            set { EmpName = value; }
        }

        [DataMember]
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        [DataMember]
        public string CityName
        {
            get { return City; }
            set { City = value; }
        }

    }
}
