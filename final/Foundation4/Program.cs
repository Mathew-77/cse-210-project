using System;

class video
{
    static void Main(string[] args)
    {
        private string _title;
        private string _author;
        private double _length;
        private list <comment> _comment = new list<comment>();

        public video (string _title,string _author, double _length)
        {
            _title = title;
            _author = author;
            _length = length;
        }
        public void list(comment, comment)
        {
            _comment . add(comment);
        }
        public int countcomment()
        {
            int count = 0;
            _count = comment.count;
            return count
        }
        public void displayinfo()
        {
            console.writeline($"title: {_title} Author: {_author} length {_length} seconds");
            console.writeline();
            int comment count =countcomments();
            console.writeline($"number of comments: {commentcount}");
            foreach (commentcount in _comment);
            {
                comment.displayinfo();
            }
            
                
            

        }
        
    }
}