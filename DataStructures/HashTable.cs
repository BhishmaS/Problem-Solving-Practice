using System;
using System.Collections;

namespace Learning.DataStructures
{
    class HashTableDemo
	{
		static public void Test()
		{
			// Create a hashtable
			// Using Hashtable class
			Hashtable my_hashtable = new Hashtable();

			// Adding key/value pair in the hashtable
			// Using Add() method
			my_hashtable.Add("A1", "Welcome");
			my_hashtable.Add("A3", "GeeksforGeeks");
			my_hashtable.Add("A2", "to");

			my_hashtable.Remove("A2");
			my_hashtable.Clear();
			my_hashtable.ContainsKey("A2");
			my_hashtable.ContainsValue("to");

			var keys = my_hashtable.Keys;
			var values = my_hashtable.Values;

			foreach (DictionaryEntry element in my_hashtable)
			{
				Console.WriteLine("Key:- {0} and Value:- {1} ",
								element.Key, element.Value);
			}
		}
	}
}