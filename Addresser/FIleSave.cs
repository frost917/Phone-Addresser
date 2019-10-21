using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Addresser
{
    class DataSave
    {
        private DirectoryInfo saveDIR = 
        new DirectoryInfo(Directory.GetCurrentDirectory() 
        + "\\AddressInfoSave");
        private string saveFile = Directory.GetCurrentDirectory() 
        + "\\AddressInfoSave\\DATA.sav"; 
        
        void isFileExist()
        {
            if(!saveDIR.Exists)
                saveDIR.Create();
            
            FileInfo save = new FileInfo(saveFile);
            if(!save.Exists)
                save.Create();

            Console.WriteLine("���� ��� �ε� �Ϸ�.");
        }

        void InfoSave(Info info)
        {
            
            Stream st = new FileStream(saveFile, FileMode.Open);
            BinaryFormatter serializer = new BinaryFormatter();

            serializer.Serialize(st, info);
            st.Close();
            Console.WriteLine("���� �Ϸ�.");
        }

        Info InfoLoad(Info info)
        {
            Info SavedData;
            Stream st = new FileStream(saveFile, FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            SavedData = (Info)deserializer.Deserialize(st);
            st.Close();
            Console.WriteLine("�ҷ����� �Ϸ�.");
            return SavedData;
        }
    }
}