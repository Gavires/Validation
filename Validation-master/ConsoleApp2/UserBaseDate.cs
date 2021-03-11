using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentQualification
{
    class UserBaseDate
    {
        public List<User> UsersTXT { get; set; } = new List<User>();
        private string text = "";
        public async Task File()
        {
            string writePath = @"\\file\Отдел обеспечения качества\Сариев И.Н\Кодинг\Validation-master\Validation-master\Validation-master\Данные\UsersBase1.txt";
            try
            {
                using (StreamReader sr = new StreamReader(writePath, Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        text = line;
                    }
                }
                // асинхронное чтение
                using (StreamReader sr = new StreamReader(writePath, Encoding.Default))
                {
                    string line;
                    while ((line = await sr.ReadLineAsync()) != null)
                    {
                        text = line;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //MessageBox.Show(text, "Прочитано из файла");
        }
        private string WordText (int index, string str)
        {
            string text="";
            while (str[index]!=' ')
            {
                text += str[index];
            }
            return text;
        }
        private int SearchWord(int index, string str)
        {
            while (str[index] == ' ') index++;
            return index;
        }
        public void SaveUserToList()
        {
            var user = new User();
            int index = 0;
            while ((text!=null))
            {
                user.UserName = WordText(index, text);
                index = SearchWord(index, text);
                user.Name = WordText(index, text);
                index = SearchWord(index, text);
                user.Password = WordText(index, text);
                index = SearchWord(index, text);
                if (WordText(index,text) == "T") 
                {
                    user.AvtorStatus = true;
                };
                user.Password = WordText(index, text);
                index = SearchWord(index, text);
                if (WordText(index, text) == "T")
                {
                    user.AdminStatus = true;
                };
            }
            UsersTXT.Add(user);
        }
    }
    
}
