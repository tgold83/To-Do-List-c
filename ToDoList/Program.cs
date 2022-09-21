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
			ListMaker();
			
			static void ListMaker() 
			{
				Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
				string userInput = Console.ReadLine();
				if (userInput == "add" || userInput == "Add")
				{
					Console.WriteLine("Please enter the description for the new item.");
					string itemDescription = Console.ReadLine();
					Item newItem = new Item(itemDescription);
					Console.WriteLine(itemDescription + " has been added to your list. Would you like to add an item to your list or view your list? (Add/View)");
					ListMaker();
				}
				else if (userInput == "view" || userInput == "View")
				{
					List<Item> list = Item.GetAll();
					if (list.Count == 0)
					{
						Console.WriteLine("You haven't added any items to the list.");
						ListMaker();
					}
					List<string> stringifiedList = new List<string> {};
					foreach (Item item in Item.GetAll()) {
						stringifiedList.Add(item.Description);
					}
					string listString = string.Join("\n", stringifiedList.ToArray());
					Console.WriteLine(listString);
					ListMaker();
				}
			}
		}
	}
}