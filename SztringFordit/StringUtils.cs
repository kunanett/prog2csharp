using System;

namespace SztringFordit {
    public class StringUtils {
        public static string ReverseString(string str) {
            var array = str.ToCharArray();
            Array.Reverse(array);
            //return new string(array);
            return string.Join("", array);
        }
    }
}