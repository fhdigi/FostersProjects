using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using FosterCollector.Classes;
using FosterCollector.Droid;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(SqLiteAndroid))]

namespace FosterCollector.Droid
{
    class SqLiteAndroid : ISQLite
    {
        public SqLiteAndroid() {}

        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "CollectionRecords.db3";

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            
            // Create the connection
            var conn = new SQLiteConnection(path);
            
            // Return the database connection
            return conn;
        }

        public bool ExportRouteData(List<CollectionRecord>filteredList, string baseFileName)
        {
            // Basic credential information 
            string ftpUser = "0083045|lccsnycom00";
            string ftpPassword = "captmo28";
            string ftpfullpath = "ftp://www.lccsny.com/foster/" + baseFileName;

            // Create the serialization object 
            XmlSerializer exportRecs = new XmlSerializer(typeof (List<CollectionRecord>));

            // Get the path where we want to store the exported file 
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Export.dat");

            // Open the stream writer for writing 
            StreamWriter sWrite = new StreamWriter(path, false);

            // Serialize the contents of the collection to the file 
            exportRecs.Serialize(sWrite, filteredList);

            // Close the file 
            sWrite.Close();

            // Create a client object for the FTP 
            Client ftpClient = new Client("ftp://www.lccsny.com/foster/", ftpUser, ftpPassword);

            // Upload the file 
            ftpClient.UploadFile(path, baseFileName);

            return true;
        }

        public bool GetCustomerRouteData()
        {
            // Set the variables 
            string ftpUser = "0083045|lccsnycom00";
            string ftpPassword = "captmo28";

            // Get the path where we want to store the exported file 
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "CustomerList.dat");

            // Delete the existing file
            try
            {
                File.Delete(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // Create a client object for the FTP 
            Client ftpClient = new Client("ftp://www.lccsny.com/foster/", ftpUser, ftpPassword);

            // Download the file from the FTP site 
            ftpClient.DownloadFile("CustomerList.dat", path);

            return true;
        }

        public List<CCustomerList> ReturnCustomerList()
        {
            List<CCustomerList> customerList = null;

            // Get the path where we want to store the exported file 
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "CustomerList.dat");

            // Create a new serialization object 
            XmlSerializer serializer = new XmlSerializer(typeof(List<CCustomerList>));

            // Open the file reader 
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
            
                // Get the customer list from the file 
                try
                {
                    customerList = (List<CCustomerList>)serializer.Deserialize(reader);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                } 
           
                // Close the file 
                reader.Close();
            }

            return customerList;
        }
    }
}