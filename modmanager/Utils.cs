using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modmanager
{
    class Utils
    {
        public static string GetRelativePath(string full_path, string root)
        {
            int start_index = full_path.IndexOf(root);

            if(start_index >= 0)
            {
                int common_length = start_index + root.Length;
                string relative_path = full_path.Substring(common_length, full_path.Length - common_length);
                return relative_path;
            }
            else
            {
                return full_path;
            }
         
        }
    }
}
