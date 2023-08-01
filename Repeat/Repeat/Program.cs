
using Repeat;
using Repeat.Models;
using System.Collections;
using System.Globalization;

//ArrayList arrayList = new ArrayList();

//arrayList.Add(5);  
//arrayList.Add("salam");
//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}

//Hashtable hashtable = new Hashtable();

//hashtable.Add(1, "Samir");
//hashtable.Add(2, "Fidan");
//hashtable.Add(3, "Kubra");

//foreach (DictionaryEntry item in hashtable)
//{
//    Console.WriteLine(item.Value);
//}

//SortedList sortedList = new SortedList();

//sortedList.Add(5, "salam5");
//sortedList.Add(3, "salam3");
//sortedList.Add(1, "salam1");

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key);
//}


//SortedList sortedList2 = new SortedList();

//sortedList2.Add("Az", "salam5");
//sortedList2.Add("Ca", "salam3");
//sortedList2.Add("Ba", "salam1");

//foreach (DictionaryEntry item in sortedList2)
//{
//    Console.WriteLine(item.Key);
//}

//SortedList<int, string> genericSortList = new SortedList<int, string>();

//genericSortList.Add(2, "sd");
//genericSortList.Add(1, "sdfsdfd");

//foreach (KeyValuePair<int, string> item in genericSortList)
//{
//    Console.WriteLine(item.Value);
//}

//Dictionary<int, int> dictionary = new Dictionary<int, int>();

//dictionary.Add(2, 2);
//dictionary.Add(1, 5);

//foreach (KeyValuePair<int, int> item in dictionary)
//{
//    Console.WriteLine(item.Value);
//}

//Dictionary<string, string> user = new Dictionary<string, string>();

//user.Add("admin", "Cahangir");
//user.Add("superadmin", "Sheref");
//user.Add("member", "Pervin");

//foreach (KeyValuePair<string, string> item in user)
//{
//    if (item.Key == "admin")
//    {
//        Console.WriteLine(item.Value);
//    }
//}

//Stack<int> stack = new Stack<int>();

//stack.Push(1);
//stack.Push(10);
//stack.Push(4);

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}


//Queue<int> queue = new Queue<int>();

//queue.Enqueue(1);
//queue.Enqueue(10);
//queue.Enqueue(4);

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}

List<int> nums = new List<int>();

nums.Add(1);
nums.Add(2);
nums.Add(3);
nums.Add(6);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//int[] arr = { 1, 2, 3 };

//var data = arr.ToList();

//List<int> nums2 = new List<int>();

//nums.Add(1);
//nums.Add(2);
//nums.Add(3);
//nums.Add(88);

//nums.AddRange(nums2);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//var result = nums.ToArray ();

//Console.WriteLine(nums.Count);

//for (int i = 0; i < nums.Count; i++)
//{
//    Console.WriteLine(nums[i]);
//}

//nums.Remove(6);


//var result = nums.FirstOrDefault(m => m > 5);
//var result = nums.FindAll(m => m > 5);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//var result = nums.Exists(x => x == 3);

//Console.WriteLine(result);

//var result = nums.Where(m => m > 20 || m < 30).FirstOrDefault();

//var result = nums.Any(m => m == 5);



EmployeeController controller = new EmployeeController();

//controller.GetAll();

controller.FilterByPrice();

