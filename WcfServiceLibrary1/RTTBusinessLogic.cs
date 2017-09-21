using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    public interface IBusinessLogic
    {

        [OperationContract]
        string InsertUserDetails(ClientDetails value);

        [OperationContract]
        int DeleteDetails(int id);

        [OperationContract]
        ClientData GetClientData();
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class ClientDetails
    {
        int id = int.MaxValue;
        string name = string.Empty;
        string surname = string.Empty;
        string gender = string.Empty;
        string residentialAddress = string.Empty;
        string workAddress = string.Empty;
        string cellNumber = string.Empty;
        string workNumber = string.Empty;

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        [DataMember]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        [DataMember]
        public string ResidentialAddress
        {
            get { return residentialAddress; }
            set { residentialAddress = value; }
        }
        [DataMember]
        public string WorkAddress
        {
            get { return workAddress; }
            set { workAddress = value; }
        }
        [DataMember]
        public string CellNumber
        {
            get { return cellNumber; }
            set { cellNumber = value; }
        }
        [DataMember]
        public string WorkNumber
        {
            get { return workNumber; }
            set { workNumber = value; }
        }



    }
    [DataContract]
    public class ClientData
    {
        public ClientData()
        {
            this.ClientTable = new DataTable("ClientsData");
        }
        [DataMember]
        public DataTable ClientTable { get; set; }
    }
}
