public class UserGenerator()
{
    private List<string> _randomComments = new List<string>();

    private List<string> _randomUsers = new List<string>();


    public string SetRandomUser()
    {

        _randomUsers = [
        "@Jonmircha",
        "@emaDouglas",
        "@Maurodev",
        "@pepe",
        "@soyDalto",
        "@Sergicode",
        "@user",
        "@user1",
        "@user2",
        "@user3",
        "@user4"];


        Random random = new Random();

        int index = random.Next(_randomUsers.Count);

        //      _personName = _randomUsers[index];
        string user = _randomUsers[index];

        //      return _personName;
        return user;


    }

    public string SetRandomComment()
    {

        _randomComments = [
        "I liked your video!",
        "It was so helpful man.",
        "You have an incredible energy.",
        "Your work is trully impressive.",
        "Your attention to detail is remarkable.",
        "You are a great teamplayer.",
        "You need to work on your communication skills.",
        "Don't be afraid to share your ideas.",
        "Your overall performance has been excelent.",
        "I really like your work on this project.",
        "I think you could have spend more time on the final review of the document."];


        Random random = new Random();

        int index = random.Next(_randomComments.Count);

        string comment = _randomComments[index];
        //        _comment = _randomComments[index];

        return comment;
        //      return _comment;
    }

    /*
        public string GetRandomDate() {
                    Random rnd = new Random();
            DateTime today = DateTime.Now;

            int rndYear = rnd.Next(1995, today.Year);
            int rndMonth = rnd.Next(1, 12);
            int rndDay = rnd.Next(1, 31);

            DateTime generateDate = new DateTime(rndYear, rndMonth, rndDay);
            Console.WriteLine(generateDate);



        public string TimeDifference(DateTime pastDate, DateTime currentDate)
        {
            TimeSpan difference = currentDate - pastDate;

            // If more than a year has passed
            if (difference.Days >= 365)
            {
                int years = (int)(difference.Days / 365);
                return years == 1 ? "Hace 1 año" : $"Hace {years} años";
            }

            // If more than a month has passed
            if (difference.Days >= 30)
            {
                int months = (int)(difference.Days / 30);
                return months == 1 ? "Hace 1 mes" : $"Hace {months} meses";
            }

            // If more than a day has passed
            if (difference.Days >= 1)
            {
                return difference.Days == 1 ? "Hace 1 día" : $"Hace {difference.Days} días";
            }

            // If is the same day:
            return "Today";
        }


        }

    */

}

