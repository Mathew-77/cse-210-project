using System;

class Program
{
    static void Main(string[] args)
    {
    private string _title;
    private string _author;
    private string _length;
    private list <comment> _comments = new list<comment>();

    public video(string title, string author, double length)
    {
        _title =title;
        _author = author;
        _length =length;
    }

    public void list comment(comment comment)
    {
        _comments.Add(comment);
    }
    public int countcomments()
    {
        int count = 0;
        count = comments .count;
        return count;{
    public void displayinfo()
    {
        console.writeline($"title: {_title} |Author: {_author} | length: {_length} seconds") 
    }
    console.writeline();
    int commentcount = countcomments();
    console.writeline($"Number of comments: (commentcount)");
    foreach (comment comment in _comments)
    {
      comment.displayinfo();  
    }   
    }

    
    }
}