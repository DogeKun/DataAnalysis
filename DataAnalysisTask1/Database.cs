using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DataAnalysisTask1.data;


namespace DataAnalysisTask1
{
     public enum Tables { Phone,
        PhoneBattery,
        PhoneBiometrics,
        PhoneCamera,
        PhoneCPU,
        PhoneManifactiorer,
        PhoneMemory,
        PhoneResoliution,
        PhoneScreen,
        PhoneStorage
    }
    class Database
    {
        private string query;
        private string connection;
        private MySqlCommand cmd;
        private MySqlDataReader dataReader;
        private MySqlConnection dbConn;

        public List<Phone> phones = new List<Phone>();
        public List<PhoneBattery> batteries = new List<PhoneBattery>();
        public List<PhoneBiometrics> biometrics = new List<PhoneBiometrics>();
        public List<PhoneCamera> cameras = new List<PhoneCamera>();
        public List<PhoneCPU> cpus = new List<PhoneCPU>();
        public List<PhoneManifactiorer> manifactiorers = new List<PhoneManifactiorer>();
        public List<PhoneMemory> memory = new List<PhoneMemory>();
        public List<PhoneResoliution> resoliutions = new List<PhoneResoliution>();
        public List<PhoneScreen> screens = new List<PhoneScreen>();
        public List<PhoneStorage> storages = new List<PhoneStorage>();

        public Database()
        {
            connection = "server=localhost;database=telparink;uid=root;SslMode=none";
        }

        public void ReadDatabase()
        {
            _Database_Read_Switch(Tables.PhoneCPU);
            _Database_Read_Switch(Tables.PhoneBattery);
            _Database_Read_Switch(Tables.PhoneBiometrics);
            _Database_Read_Switch(Tables.PhoneCamera);
            _Database_Read_Switch(Tables.PhoneCPU);
            _Database_Read_Switch(Tables.PhoneManifactiorer);
            _Database_Read_Switch(Tables.PhoneMemory);
            _Database_Read_Switch(Tables.PhoneResoliution);
            _Database_Read_Switch(Tables.PhoneScreen);
            _Database_Read_Switch(Tables.PhoneStorage);

            _Database_Read_Switch(Tables.Phone);

            foreach (Phone phone in phones)
            {
                Console.WriteLine(phone.phoneID + " " + phone.phoneName + " " + phone.storage.storageCapacity);
            }

            Console.WriteLine("List Phone lenth is" + phones.Count);
        }

        private void _Database_Read_Switch(Tables selection)
        {
            dbConn = new MySqlConnection(connection);
            try
            {
                switch(selection)
                {
                    case Tables.Phone:
                        dbConn.Open();
                        query = "SELECT * FROM `phones` WHERE 1";

                        cmd = new MySqlCommand(query, dbConn);
                        dataReader = cmd.ExecuteReader();
                        while(dataReader.Read())
                        {
                            try
                            {
                                var phone = new Phone(
                                    dataReader.GetInt16("phonesID"), dataReader.GetString("name"), dataReader.GetFloat("priceEur"),
                                    cpus.Find(r => r.cpuID == dataReader.GetInt16("cpuID")),
                                    batteries.Find(r => r.batteryID == dataReader.GetInt16("batteryID")),
                                    biometrics.Find(r => r.biometricsID == dataReader.GetInt16("biometricID")),
                                    cameras.Find(r => r.cameraID == dataReader.GetInt16("cameraID")),
                                    manifactiorers.Find(r => r.manifactiorerID == dataReader.GetInt16("gamintojasID")),
                                    memory.Find(r => r.memoryID == dataReader.GetInt16("memoryID")), dataReader.GetInt16("osID"), dataReader.GetInt16("portsID"),
                                    screens.Find(r => r.screenID == dataReader.GetInt16("screenID")),
                                    resoliutions.Find(r => r.resoliutionID == dataReader.GetInt16("skirgebaID")),
                                    storages.Find(r => r.storageID == dataReader.GetInt16("storageID"))
                                    );
                                phones.Add(phone);
                            }
                            catch
                            {
                                Console.WriteLine("Failed to read row - " + dataReader.GetInt16("phonesID") + " Phones table");
                            }
                        }
                        dbConn.Close();
                        break;
                    case Tables.PhoneBattery:
                        dbConn.Open();
                        query = "SELECT * FROM `battery` WHERE 1";

                        cmd = new MySqlCommand(query, dbConn);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            var phoneBattery = new PhoneBattery(dataReader.GetInt16("batteryID"), dataReader.GetInt16("amount"));
                            batteries.Add(phoneBattery);
                        }
                        dbConn.Close();
                        break;
                    case Tables.PhoneBiometrics:
                        dbConn.Open();
                        query = "SELECT * FROM `biometrics` WHERE 1";

                        cmd = new MySqlCommand(query, dbConn);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            
                            var phoneBiometrics = new PhoneBiometrics(dataReader.GetInt16("biometricID"), dataReader.GetBoolean("bool"));
                            biometrics.Add(phoneBiometrics);
                        }
                        dbConn.Close();
                        break;
                    case Tables.PhoneCamera:
                        dbConn.Open();
                        query = "SELECT * FROM `camera` WHERE 1";

                        cmd = new MySqlCommand(query, dbConn);
                        dataReader = cmd.ExecuteReader();
                        while(dataReader.Read())
                        {
                            var phonecamera = new PhoneCamera(dataReader.GetInt16("cameraID"), dataReader.GetString("optics"),
                                dataReader.GetInt16("mpx"), dataReader.GetInt16("recordQuality"));
                            cameras.Add(phonecamera);
                        }
                        dbConn.Close();
                        break;
                    case Tables.PhoneCPU:
                        dbConn.Open();
                        query = "SELECT * FROM `cpu` WHERE 1";

                        cmd = new MySqlCommand(query, dbConn);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            var phonecpu = new PhoneCPU(dataReader.GetInt16("cpuid"), 
                                dataReader.GetString("name"), dataReader.GetInt16("cores"), 
                                dataReader.GetFloat("frequency"), dataReader.GetString("GPU"));
                            cpus.Add(phonecpu);
                        }
                        dbConn.Close();
                        break;
                    case Tables.PhoneManifactiorer:
                        dbConn.Open();
                        query = "SELECT * FROM `gamintojas` WHERE 1";

                        cmd = new MySqlCommand(query, dbConn);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            var phoneManifactiorer = new PhoneManifactiorer(dataReader.GetInt16("gamintojasID"), dataReader.GetString("name"));
                            manifactiorers.Add(phoneManifactiorer);
                        }
                        dbConn.Close();
                        break;
                    case Tables.PhoneMemory:
                        dbConn.Open();
                        query = "SELECT * FROM `memory` WHERE 1";

                        cmd = new MySqlCommand(query, dbConn);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            var phoneMemory = new PhoneMemory(dataReader.GetInt16("memoryID"), dataReader.GetInt16("amount"));
                            memory.Add(phoneMemory);
                        }
                        dbConn.Close();
                        break;
                    case Tables.PhoneResoliution:
                        dbConn.Open();
                        query = "SELECT * FROM `skirgeba` WHERE 1";

                        cmd = new MySqlCommand(query, dbConn);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            var phoneResoliution = new PhoneResoliution(dataReader.GetInt16("skirGebaID"), dataReader.GetInt16("xaxis"), dataReader.GetInt16("yaxis"));
                            resoliutions.Add(phoneResoliution);
                        }
                        dbConn.Close();
                        break;
                    case Tables.PhoneStorage:
                        dbConn.Open();
                        query = "SELECT * FROM `storage` WHERE 1";

                        cmd = new MySqlCommand(query, dbConn);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            var phoneStorage = new PhoneStorage(dataReader.GetInt16("storageID"), dataReader.GetInt16("amount"));
                            storages.Add(phoneStorage);
                        }
                        dbConn.Close();
                        break;
                    case Tables.PhoneScreen:
                        dbConn.Open();
                        query = "SELECT * FROM `screen` WHERE 1";

                        cmd = new MySqlCommand(query, dbConn);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            var phoneScreen = new PhoneScreen(dataReader.GetInt16("screenID"),
                                dataReader.GetString("name"), dataReader.GetInt16("screenLength"), 
                                dataReader.GetInt16("screenWidth"), dataReader.GetBoolean("notch"));
                            screens.Add(phoneScreen);
                        }
                        dbConn.Close();
                        break;
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine("fail to read - " + selection);
                //Console.WriteLine(exc);
            }
        }

       
    }
}
/*
 * 09/14
 * Read data from database
 * Specialized class 
 * For reason 
 * using data classes as variables
 * read class should use 
 * Data return/ Get
 * Data read/ .ReadDatabase()
 *  1)all classes should have specific functions to make the code more module
 *  2)use Lambda expretions to fill Phones based on ID
 * Get filled/partially filed database
 * 
 * Should take about 4-12h
 * 
 * 
 * 09/15
 * Add algorithms for data analysis
 * Add ability to change priorities with droplists
 *  1)DropList/ figure out how to specify the ID
 * Multithreading?
*/
