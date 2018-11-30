using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisTask1
{
    class FileIO
    {
        public string FilePath = "D:\\ProgrammingC#\\DataAnalysisTask1\\DataAnalysisTask1\\bin\\Debug\\db.txt";

        public ItemSetCollection Read_File(string FilePath)
        {
            ItemSet itemset;
            ItemSetCollection itemsets = new ItemSetCollection();
            const Int32 BUFFER_SIZE = 128;
            using (var fileStream = File.OpenRead(FilePath))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BUFFER_SIZE))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    itemset = new ItemSet();
                    string[] lines = line.Split('/');
                    for (int i = 0; i < lines.Length; i++)
                    {
                        //Console.WriteLine(lines[i]);
                        itemset.Add(lines[i]);
                    }
                    //Console.WriteLine("ItemSet count = " + itemset.Count);
                    itemsets.Add(itemset);
                }
            }

            return itemsets;
        }

        public void Write_File(ItemSet itemset)
        {
            ItemSetCollection itemsets = Read_File(FilePath);
            itemsets.Add(itemset);

            StringBuilder stringbuilder = new StringBuilder();

            foreach (var i in itemsets)
            {
                string output = string.Empty;
                foreach (var s in i)
                {
                    if (i.IndexOf(s) == i.Count - 1)
                        output += s;
                    else
                        output += s + "/";

                }
                Console.WriteLine(output);
                stringbuilder.AppendLine(output);
            }

            using (var fileStream = File.OpenWrite(FilePath))
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                //Console.WriteLine(stringbuilder.ToString());
                writer.Write(stringbuilder.ToString());
            }
        }

        //Default location
        public ItemSetCollection Read_File()
        {
            ItemSet itemset;
            ItemSetCollection itemsets = new ItemSetCollection();
            const Int32 BUFFER_SIZE = 128;
            using (var fileStream = File.OpenRead(FilePath))
                //Making sure that it would read lithuanian alphabet
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BUFFER_SIZE))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    itemset = new ItemSet();
                    string[] lines = line.Split('/');
                    for (int i = 0; i < lines.Length; i++)
                    {
                        itemset.Add(lines[i]);
                    }
                    itemsets.Add(itemset);
                }
            }
            return itemsets;
        }
    }
}
