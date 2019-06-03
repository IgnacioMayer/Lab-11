using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    public class Gestionador
    {
        private List<Local> locales;
        private string filename = "saveddata.bin"; 

        public Gestionador(List<Local> locales)
        {
            this.Locales = locales;
        }

        public Gestionador()
        {
            this.Locales = new List<Local>();

            if (File.Exists(this.filename))
            {
                Stream openFileStream = File.OpenRead(this.filename);
                BinaryFormatter deserializer = new BinaryFormatter();
                this.Locales = (List<Local>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();
            }
        }

        public List<Local> Locales { get => locales; set => locales = value; }

        public void Guardar()
        {
            Stream SaveFileStream = File.Create(this.filename);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(SaveFileStream, this.locales);
            SaveFileStream.Close();
        }
    }
}
