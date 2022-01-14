using System;
using System.Collections;

namespace Learning.DataStructures
{
    class HashTable
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

			foreach (DictionaryEntry element in my_hashtable)
			{
				Console.WriteLine("Key:- {0} and Value:- {1} ",
								element.Key, element.Value);
			}
		}
	}
}