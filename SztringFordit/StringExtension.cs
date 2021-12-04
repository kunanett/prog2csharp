using System;

namespace SztringFordit {
    //static class = nem példányosítható
    public static class StringExtension {
        public static string ReverseStr(this String str) {
            var array = str.ToCharArray();
            Array.Reverse(array);
            return string.Join("", array);
        }
    }
}