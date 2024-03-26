using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public class ExtendedDictionaryElement<Key, Value1, Value2>
    {
        public Key key { set; get; }
        public Value1 value1 { set; get; }
        public Value2 value2 { set; get; }
    }
}