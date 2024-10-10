using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Video
{
    private string _title;
    private string _author;
    private int _length;  // In sec..

    private List<Comment> _comments;

    public List<Video> _videos;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();


    }
    public void AddComments(string user, string comment)
    {
        _comments.Add(new Comment(user, comment));
    }

    public void DisplayCommentQuantity()
    {
        Console.WriteLine($"{_comments.Count} Comments");
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
    }

    public void DisplayAll()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("______________________________________________________________________________________________");
    }





    /*

             foreach (Comment comment in _comments) {}
            }

            public void GetComment() {

            while (Video != _comments[0].Comment) {}

            }



        public void DisplayVideoInfo() {


            video1)
            Aprendiendo Java Script - MiduDev - 180seg

                - @emaDouglas - It was helpful
                - 
                -
                -
            ~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|
            video2)
                -
                -
                -
                -
                -
            ~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|~~|

    */

}
