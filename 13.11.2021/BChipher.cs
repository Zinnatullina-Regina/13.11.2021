using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chipher
{
    class BCripher : ICriper
    {
        const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public string encode(string text)
        {

            string fullAlfabet = alfabet + alfabet.ToLower();
            int letterQty = fullAlfabet.Length;
            string encod = "";
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                int index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    encod += c.ToString();
                }
                else
                {
                    int codeIndex = (letterQty + 32 - index) % letterQty;
                    if (alfabet.Contains(c))
                    {
                        encod += (fullAlfabet[codeIndex]).ToString().ToUpper();
                    }
                    else
                    {

                        encod += (fullAlfabet[codeIndex]).ToString().ToLower();
                    }

                }
            }

            return encod;

        }


        public string decode(string textcode)
        {

            string fullAlfabet = alfabet + alfabet.ToLower();
            int letterQty = fullAlfabet.Length;
            string cod = "";
            for (int i = 0; i < textcode.Length; i++)
            {
                char c = textcode[i];
                int index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    cod += c.ToString();
                }
                else
                {
                    int codeIndex = (letterQty - 32 + index) % letterQty;
                    if (alfabet.Contains(c))
                    {
                        cod += fullAlfabet[codeIndex].ToString().ToUpper();
                    }
                    else
                    {

                        cod += (fullAlfabet[codeIndex]).ToString().ToLower();
                    }

                }
            }

            return cod;


        }
    }
}