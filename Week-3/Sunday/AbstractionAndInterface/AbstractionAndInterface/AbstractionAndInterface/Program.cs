using System;

namespace AbstractionAndInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDataSource xmlDataSource = new XmlDataSource();
            SqlDataSource sqlDataSource = new SqlDataSource();

            VendorBusiness vendorBusiness = new VendorBusiness();
            vendorBusiness.DataSource = sqlDataSource;
            vendorBusiness.DataSource.SaveData("örnek");

            vendorBusiness.DataSource = xmlDataSource;
            vendorBusiness.DataSource.SaveData("xml örnek");

            Recorder recorder = new Recorder();
           // recorder.RecordData(new XmlDataSource);
        }
    }
}
