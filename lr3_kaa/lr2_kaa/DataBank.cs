using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2_kaa
{
    static class DataBank
    {
        public static string[] NewArticle;
        public static string[] NewAuthor;
        public static bool Flag = false;
        public static List<string> AllPublisher = new List<string>(); //
        public static List<string> AllSources = new List<string>(); //
        public static List<string> AllUdc = new List<string>(); //

        public static List<string> AllEducation = new List<string>();
        public static List<string> AllWork = new List<string>();

        public static List<string> AllAuthors = new List<string>();
        public static List<string> AllAuthorsNames = new List<string>();


        public static string CurrentTable;

    }
}
