using System;
using System.Collections.Generic;

namespace ListExample {
    /**
     * C#-ban lehet primitív típust listában tárolni, pl int
     * deklarációnál javaban el lehet hagyni a jobb oldalon a típust, c#-ban nem:
     * nem helyes:  List<string> myList = new List<>()
     * helyes:      List<string> myList = new List<string>();
     *
     * a C# a primitíveket is objektumként kezeli, így például egy int-nek is van toString() metódusa
     *
     * foreach ciklussal olyan adatszerkezeteket lehet bejárni, amelyek implementálják az IEnumerable interfészt
     *
     */
    public class ListExample {
        public static void Main(string[] args) {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            
            
            /*List<string> myList = new List<string>();
            myList.Add("Hello");
            myList.Add("World");*/

            var number = 5;
            //primitív típusoknak is vannak metódusai
            number.ToString();
            
            //c#-ban a List egy dinamikus tömb
            var myList = new List<string> {
                "Hello",
                "World"
            };

            Console.WriteLine();
            Console.WriteLine("Kiíratás string Join segítségével");
            Console.WriteLine(string.Join(", ", myList));

            Console.WriteLine();
            Console.WriteLine("Kiíratás for ciklus segítségével");
            //a ciklus fejében string típus helyett lehet használni a var kulcsszót, mivel a word ciklusváltozó típusa kikövetkeztethető
            for (var i = 0; i < myList.Count; i++) {
                Console.WriteLine(myList[i]);
                //java-ban: myList.get(i);
            }

            Console.WriteLine();
            Console.WriteLine("Kiíratás foreach ciklus segítségével");
            //a ciklus fejében string típus helyett lehet használni a var kulcsszót, mivel a word ciklusváltozó típusa kikövetkeztethető
            foreach (var word in myList) {
                Console.WriteLine(word);
            }
        }
    }
}