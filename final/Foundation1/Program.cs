using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("The little guy knows what he wants", "3 Southern Cats and Momma", 5);
        Comment comment1 = new Comment("paulabonanno2750", "Tigger is so soft spoken and sweet. It takes a lot to rile him up. He is so handsome.");
        vid1.comments.Add(comment1);
        Comment comment2 = new Comment("sunnyd1951", "Tigger is so sweet and well spoken and then we have MOUTH OF THE SOUTH Willow");
        vid1.comments.Add(comment2);
        Comment comment3 = new Comment("pamhouse6804", "I was waiting for Willow to say something.  She never disappoints. Love them all.");
        vid1.comments.Add(comment3);
        vid1.videoInfo();
    }
}