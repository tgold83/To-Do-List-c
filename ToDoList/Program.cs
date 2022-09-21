using System;
using ToDoList.Models;
using System.Collections.Generic;

namespace UserList
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Welcome to the To Do List.");
			Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
			string userInput = Console.ReadLine();
			if (userInput == "add" || userInput == "Add")
			{
				Console.WriteLine("Please enter the description for the new item.");
				string itemDescription = Console.ReadLine();
				Item newItem = new Item(itemDescription);
				Console.WriteLine(itemDescription + " has been added to your list. Would you like to add an item to your list or view your list? (Add/View)");
				Main();
			}
			else if (userInput == "view" || userInput == "View")
			{
				List<string> stringifiedList = new List<string> {};
				foreach (Item item in Item.GetAll()) {
					stringifiedList.Add(item.Description);
				}
				string listString = string.Join(", ", stringifiedList.ToArray());
				Console.WriteLine(listString);
				Main();
			}
		}
	}
}

// Program: Welcome to the To Do List.
// Program: Would you like to add an item to your list or view your list? (Add/View)
// User: Add
// Program: Please enter the description for the new item.
// User: Walk the dog.
// Program: 'Walk the dog' has been added to your list. Would you like to add an item to your list or view your list? (Add/View)
// User: View
// Program: 1. Walk the dog.
// Program: Would you like to add an item to your list or view your list? (Add/View)