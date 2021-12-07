using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_DictionarySortedListKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic olmayan koleksiyon davranışı...
            Hashtable HTList = new Hashtable();
            HTList.Add(1, "Bir");
            HTList.Add(2, "İki");
            HTList.Add(3, "Üç");
            //HTList.Add(1, "Test");


            //Dictionary<TKey, TValue>

            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "Bir");
            DictionaryList.Add(2, "İki");
            DictionaryList.Add(3, "Üç");
            //DictionaryList.Add(1, "Test");



        }
    }
}
