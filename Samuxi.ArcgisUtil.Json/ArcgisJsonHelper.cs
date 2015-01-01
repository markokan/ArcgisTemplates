using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuxi.ArcgisUtil.Json
{
    public class ArcgisJsonHelper
    {
        public static IList<ArcgisObject> ReadDirectory(string directory)
        {
            var retVal = new List<ArcgisObject>();
            var files = Directory.GetFiles(directory,"*.json");
            if (files != null && files.Any())
            {
                foreach (var file in files)
                {
                    retVal.Add(new ArcgisObject(file));
                }
            }

            return retVal;
        }
    }
}
