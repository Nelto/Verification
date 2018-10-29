using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verification
{
    class Verific
    {
        int[] count = new int[256];
        string chars;

      public  Verific(String input)
        {
            try
            {
                using (StreamReader sr = new StreamReader("Res.txt", System.Text.Encoding.Default))
                {
                    chars = sr.ReadToEnd();
                }
                Count();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void Count()
        {
            for (int i = 0; i < chars.Length; i++)
            {
                count[chars[i]]++;
            }
        }

        public void PrintCountingRes()
        {
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0) Console.Write((char)i + "  " + count[i] + "\n");
            }
        }

        public void PrintChances()
        {
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0) Console.Write("{0}  {1:0.#####}\n", (char) i, (double)count[i] / chars.Length);
            }
        }
    }
}
