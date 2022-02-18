using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ReadWriteFile
    {

        public List<Character> ReadListCharacter(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);

            var listDeserialize = (List<Character>)formatter.Deserialize(stream);
            stream.Close();

            return listDeserialize;
        }

        public void WriteCharacter(string path, Character ch)
        {
            var tmpList = new List<Character>();

            if (File.Exists(path))
            {
                tmpList = this.ReadListCharacter(path);
            }

            tmpList.Add(ch);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, tmpList);
            stream.Close();
        }
    }
}
