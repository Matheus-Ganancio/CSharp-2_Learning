class Movie
{
    public Movie(string title, int ageRating)
    {
        Title = title;
        AgeRating = ageRating;
    }

    public string Title { get; set; }
    public int AgeRating { get; set; }

    public bool CanWatch(int userAge)
    {
        return userAge >= AgeRating;
    }

    public void ShowResult(int userAge)
    {
        if (CanWatch(userAge))
        {
            Console.WriteLine($"User age: {userAge} years. Can watch the movie {Title}.");
        }
        else
        {
            Console.WriteLine($"User age: {userAge} years. Can't watch the movie {Title}.");
        }
    }
}