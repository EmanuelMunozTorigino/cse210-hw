using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("~~~~~~ Youtube Videos comments and likes ~~~~~~");
        Console.WriteLine();

        //    Console.WriteLine("Hello Foundation1 World!");
        UserGenerator userGenerator = new UserGenerator();

        Video video = new Video("Json in 10 minutes", "Free Code Camp", 600);
        Video video1 = new Video("Learning Hooks with React", "JonMircha", 300);
        Video video2 = new Video("His Grace is Sufficient", "Brad Wilcox", 1860);
        Video video3 = new Video("Diamond Heart - song", "Alan Walker", 180);

        List<Video> videos = [video, video1, video2, video3];

        /*
        videos.add(video);
        videos.add(video1);
        videos.add(video2);
        videos.add(video3);

        */

        foreach (Video v in videos)
        {
            Random random = new Random();

            int max = random.Next(3, 5);

            int quantity = 0;
            while (quantity < max)
            {

                string user = userGenerator.SetRandomUser();
                string comment = userGenerator.SetRandomComment();

                v.AddComments(user, comment);

                quantity++;
            }
        }

        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
            Console.WriteLine();
            v.DisplayCommentQuantity();
            v.DisplayAll();
        }



        /*
        string [] comment = ["This video is helpful", "I like the video,"];



        string title1 = "Learning Javascript";
        string author1 = "Midu dev";
        int length1 = 180;


        Video video1= new Video(title1, author1, length1);

        video1._videos.Add(video1);
        */



        /*
                string comment = "This video is helpful";

                //, "I like the video,";

                Comment comment1 = new Comment("@emaDouglas", comment);

                comment1.displayComment();
        */
    }


}