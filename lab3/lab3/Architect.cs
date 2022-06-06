using System;
using System.ComponentModel.DataAnnotations;

namespace lab3
{
    abstract class Algorithms //Hero Factory
    {
        public abstract Encode CreateEncode(); //Movement
        public abstract Decode CreateDecode(); //Weapon
    }
    
    class Cesar: Algorithms // Elf
    {
        public override Encode CreateEncode()
        {
            return new EncodeCesar();
        }
        public override Decode CreateDecode()   
        {
            return new DecodeCesar(); 
        }
    }
    
    class XOR: Algorithms // Elf
    {
        public override Encode CreateEncode()
        {
            return new EncodeXOR();
        }
        public override Decode CreateDecode()   
        {
            return new DecodeXOR(); 
        }
    }
    
    class Scytale: Algorithms // Elf
    {
        public override Encode CreateEncode()
        {
            return new EncodeScytale();
        }
        public override Decode CreateDecode()   
        {
            return new DecodeScytale(); 
        }
    }

    abstract class Encode
    {
        public abstract string Encoding(string str, int key);
    }

    abstract class Decode
    {
        public abstract string Decoding(string str, int key);
    }

    class EncodeCesar : Encode
    {
        const string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public override string Encoding(string str, int key)
        {
            string fullAlfabet = alfabet + alfabet.ToLower();
            int letterQty = fullAlfabet.Length;
            string retVal = "";
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                int index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    retVal += c.ToString();
                }
                else
                {
                    int codeIndex = (letterQty + index + key) % letterQty;
                    retVal += fullAlfabet[codeIndex];
                }
            }

            return retVal;
        }
    }

    class DecodeCesar : Decode
    {
        const string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public override string Decoding(string str, int key)
        {
            key = -key;
            string fullAlfabet = alfabet + alfabet.ToLower();
            int letterQty = fullAlfabet.Length;
            string retVal = "";
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                int index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    retVal += c.ToString();
                }
                else
                {
                    int codeIndex = (letterQty + index + key) % letterQty;
                    retVal += fullAlfabet[codeIndex];
                }
            }

            return retVal;
        }
    }
    
    class EncodeXOR : Encode
    {
        public override string Encoding(string str, int key)
        {
            var res = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                res += ((char)(str[i] ^ key)).ToString();
            }

            return res;
        }
    }

    class DecodeXOR : Decode
    {
        public override string Decoding(string str, int key)
        {
            var res = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                res += ((char)(str[i] ^ key)).ToString();
            }

            return res;
        }
    }
    
    class EncodeScytale : Encode
    {
        public override string Encoding(string str, int key)
        {
            var k = str.Length % key;
            if (k > 0)
            {
                //дополняем строку пробелами
                str += new string(' ', key - k);
            }

            var column = str.Length / key;
            var result = "";

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < key; j++)
                {
                    result += str[i + column * j].ToString();
                }
            }

            return result;
        }
    }

    class DecodeScytale : Decode
    {
        public override string Decoding(string str, int key)
        {
            var column = str.Length / key;
            var symbols = new char[str.Length];
            int index = 0;
            for (int i = 0; i < column; i++)
            {   
                for (int j = 0; j < key; j++)
                {
                    symbols[i + column * j] = str[index];
                    index++;
                }
            }

            return string.Join("", symbols);
        }
    }
             
    class Code //Hero
    {
        private Encode _encode;
        private Decode _decode;
 
        public Code(Algorithms algorithm)
        {
            _encode = algorithm.CreateEncode();
            _decode = algorithm.CreateDecode();
        }

        public string Encode(string text, int key)
        {
            return _encode.Encoding(text, key);
        }
        
        public string Decode(string text, int key)
        {
            return _decode.Decoding(text, key);
        }
    }
}