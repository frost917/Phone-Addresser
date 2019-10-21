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

            Console.WriteLine("저장 목록 로딩 완료.");
        }

        void InfoSave(Info info)
        {
            
            Stream st = new FileStream(saveFile, FileMode.Open);
            BinaryFormatter serializer = new BinaryFormatter();

            serializer.Serialize(st, info);
            st.Close();
            Console.WriteLine("저장 완료.");
        }

        Info InfoLoad(Info info)
        {
            Info SavedData;
            Stream st = new FileStream(saveFile, FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            SavedData = (Info)deserializer.Deserialize(st);
            st.Close();
            Console.WriteLine("불러오기 완료.");
            return SavedData;
        }
    }
}