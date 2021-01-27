using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    public class MyDictionary<TK,TV>
    {
        TK[] key;
        TV[] value;

        public MyDictionary()
        {
            key = new TK[0];
            value = new TV[0];
        }

        public void Add(TK keyAdd,TV valueAdd)
        {
            TK[] tempDictionaryTK =key ;
            key = new TK[key.Length + 1];

            TV[] tempDictionaryTV = value;
            value = new TV[value.Length + 1];


            for (int i = 0; i < tempDictionaryTK.Length; i++)
            {
                key[i] = tempDictionaryTK[i];
                for (int j = 0; j < tempDictionaryTV.Length; j++)
                {
                    value[j] = tempDictionaryTV[j];
                }
            }
            key[key.Length - 1] = keyAdd;
            value[value.Length - 1] = valueAdd;
        }
        

    }
}
