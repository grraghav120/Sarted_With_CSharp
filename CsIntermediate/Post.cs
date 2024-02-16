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
}
