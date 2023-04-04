using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok_03
{
    internal class GlossaryItem1302210028
    {
        public class GlossDef
        {
            public string para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
            public GlossDef() { }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }

            public GlossEntry() { }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
            public GlossList() { }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }

            public GlossDiv() { }
        }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }

            public Glossary() { }
        }

        public class GlossaryF
        {
            public Glossary glossary { get; set; }

            public GlossaryF() { }
        }
    }
}
