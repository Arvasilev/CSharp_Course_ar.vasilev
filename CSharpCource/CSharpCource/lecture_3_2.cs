using System;
using System.Collections.Generic;

namespace CSharpCource
{
    class lecture_3_2
    {
        public lecture_3_2()
        {
            string text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            
            text = text.Trim(new char[] { ',', '.' });
            string[] textArray = text.Split(new char[] { ' ' }); 
            
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            
            foreach (string word in textArray)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word] += 1; 
                }
                else
                {
                    dictionary.Add(word,1);
                }
            }

            foreach (KeyValuePair<string, int> keyValue in dictionary)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            
            Console.ReadKey();
        }
    }
}

