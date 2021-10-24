using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Type_Collection_demo
{
    class CollectonDemo
    {
        static void Main(string[] args)
        {
            #region System.Collections classes
            /*int[] numberArray = new int[3];
            numberArray[0] = 454;
            numberArray[1] = 44754;
            numberArray[2] = 23;
            for(int i=0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
            */
            #endregion
            /*ArrayList countryList = new ArrayList();
            countryList.Add("India");//0
            countryList.Add("USA");//2
            countryList.Insert(1, "France");//1
            countryList.Add(100);//int-3
            countryList.Add(true);//bool-4


            //object initializer
            Person person = new Person() { FirstName = "Vaka", LastName = "Lakshmi" };
            Console.WriteLine(person.FirstName + " " + person.LastName);
            Console.WriteLine("-----------------------------------\n");

            countryList.Add(person);//5

            //from countryList collection for item no 5 (person object) print only FirstName
            //type conversion
            Console.WriteLine(((Person)countryList[5]).FirstName);


            Console.WriteLine("-----------------------------------\n");


            for (int i=0; i < countryList.Count; i++)
            {
                Console.WriteLine(countryList[i]);
            }
            */


            /*List<string> countryList = new List<string>();
            countryList.Add("India");

            List<int> numbers = new List<int>();
            numbers.Add(100);

            List<Person> personList = new List<Person>();
            personList.Add(new Person() { FirstName = "Vaka", LastName = "Lakshmi" });
            Console.WriteLine(personList[0].FirstName);
            */


            #region nullable type
            //int i=null;
            Nullable<int> x = null;
            x = 100;
            x = null;

            //datatype        ---- nullable type
            int? y = null;
            #endregion



        }
    }
}
