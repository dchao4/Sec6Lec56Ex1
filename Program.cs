using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec6Lec56Ex1
{   //1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

    //If no one likes your post, it doesn't display anything.
    //If only one person likes your post, it displays: [Friend's Name] likes your post.
    //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
    //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
    //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
    //Depending on the number of names provided, display a message based on the above pattern.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please post a message");
            var friendList = new List<string>();
            int friendCount;
            string inputNames;
            string inputMessage = Console.ReadLine();

            Console.WriteLine("Friends");
            do
            {
                inputNames = Console.ReadLine();
                friendList.Add(inputNames);
                friendCount = friendList.Count;
                               
            }
            while (!(String.IsNullOrEmpty(inputNames)));

            friendCount = friendCount - 1;

            if (friendCount ==0 )
                Console.WriteLine("You have no friends");
            if (friendCount == 1)
            {
                Console.WriteLine(friendList[0]+"likes your post");
                            }
            else if (friendCount == 2)
                Console.WriteLine(friendList[0]+ " and " + friendList[1] +"like your post");
            else if (friendCount > 2)
                Console.WriteLine("{0},{1}, and {2} others like your post.", friendList[0], friendList[1], friendCount-2);

            ///callingExercises = new Exercise1();
        }
    }
}
