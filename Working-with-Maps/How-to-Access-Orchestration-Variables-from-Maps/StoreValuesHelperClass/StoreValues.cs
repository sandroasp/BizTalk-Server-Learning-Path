using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreValuesHelperClass
{
    public class StoreValues
    {
        [ThreadStatic]
        public static Dictionary<string, string> Data = new Dictionary<string, string>();

        /// <summary>
        /// This method will read the value of a property (key) defined earlier for this thread.
        /// The property (key) must exist in the dictionary
        /// </summary>
        /// <param name="key">Name of the variable</param>
        /// <returns></returns>
        public static string GetDataValue(string key)
        {
            if (Data.ContainsKey(key))
            {
                return Data[key];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// This method will set a value of a property (Key) for a specific thread
        /// </summary>
        /// <param name="key">Name of the variable</param>
        /// <param name="value">Value of the variable</param>
        public static void SetDataValue(string key, string value)
        {
            if (Data == null)
                Data = new Dictionary<string, string>();
            Data[key] = value;
        }
    }
}
