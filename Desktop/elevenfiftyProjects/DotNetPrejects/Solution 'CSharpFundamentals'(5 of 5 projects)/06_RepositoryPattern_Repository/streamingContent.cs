using System;

namespace _06_RepositoryPattern_Repository
{
    public enum GenereType
    {
        Horror =1,
        RomCom,
        SciFi,
        Documentary,
        Bromance,
        Drama,
        Action,
    }
   //.Plain.old.C#.Objects.--.POCO
    public class streamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string MaturityRating { get; set; }
        public double StarRating { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public GenereType TypeOfGenre { get; set; }

        public  streamingContent() { }
        public streamingContent(string title, string description, string maturityrating, double starrating, bool isfamilyfriend, GenereType genre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityrating;
            StarRating = starrating;
            IsFamilyFriendly = isfamilyfriend;
            TypeOfGenre = genre;

        }
    }
}
