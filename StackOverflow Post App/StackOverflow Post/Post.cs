using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    internal class Post
    {
        private int _vote = 0;
        private string _title;
        private string _description;
        private DateTime _createdOn = DateTime.Now;

        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set=> _description = value; }
        public DateTime CreatedOn { get => _createdOn; }
        public int Vote { get => _vote; }

        internal void CreatePost()
        {
            Console.WriteLine("Please enter the title for your post:");
            _title = Console.ReadLine();
            Console.WriteLine("Please enter the description for your post:");
            _description = Console.ReadLine();
            DisplayPost();
        }

        internal void DisplayPost()
        {
            Console.WriteLine($"Your post... Title: {Title}, Description: {Description}, Created on: {CreatedOn}, Current Vote: {Vote}");
        }

        internal void UpVote()
        {
            _vote++;
        }

        internal void DownVote()
        {
            _vote--;
        }

        internal void Voting()
        {
            Console.WriteLine("Would you like to up vote this post? please enter \"U\" \nWould you like to down vote this post? please enter \"D\"");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "U":
                    UpVote();
                    Repeat();
                    break;
                case "D":
                    DownVote();
                    Repeat();
                    break;
                default:
                    Console.WriteLine("please enter either \"U\" or \"D\" in uppercase only.");
                    Voting();
                    break;
            }
        }

        internal void Repeat()
        {
            Console.WriteLine("Would you like to vote again");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Y":
                    Voting();
                    break;
                case "N":
                    DisplayPost();
                    Console.WriteLine("Thank you for your post and votes");
                    break;
                default:
                    Console.WriteLine("please enter either \"Y\" or \"N\" in uppercase only.");
                    Repeat();
                    break;
            }
        }
    }
}
