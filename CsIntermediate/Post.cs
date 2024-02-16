using System;

namespace ConsoleApp1.CsIntermediate
{
    internal class Post
    {
        private int _numberOfVotes=0;
        private string _title;
        private string _description;
        private DateTime _postDate;

        public Post(string title, string description, DateTime postDate)
        {
            this._title = title;
            this._description = description;
            this._postDate = postDate;
        }

        public void SetVotes(bool val)
        {
            if (val) this._numberOfVotes++;
            else this._numberOfVotes--;
        }

        public int Vote
        {
            get {
                return this._numberOfVotes;
            }
        }

    }

    public class Accessible
    {
        public void MainAccessible()
        {
            bool stopLoop = false;
            Post post = new Post("newPost", "Description", DateTime.Now);
            while (true)
            {
                Console.WriteLine("Press \n 1-> Upvote \n 2-> Downvote \n 3-> Get the number of votes");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        post.SetVotes(true);
                        break;
                    case "2":
                        post.SetVotes(false);
                        break;
                    case "3":
                        Console.WriteLine("Number of Current Vote on this post is {0}", post.Vote);
                        break;
                    default:
                        stopLoop = true;
                        break;
                }
                if (stopLoop) break;
            }
        }
    }

}
