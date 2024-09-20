
Console.Clear();
//Describe game to user
Console.WriteLine("Hello! This is a game called madlibs which will ask you for some words like" +
"nouns, adjectives, plurals nouns etc. To make a fun story for you to read.");
//create a string variable with the story that will be manipulated by user
string originalStory = "A vacation is when you take a trip to some (adjective) place with your"
+ " (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun)."
+ " A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for "
+ "(plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). When "
+ "parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers "
+ "play golf, and mothers sit around (verb ending in “ing”) Last summer, my little brother fell in"
+ " a/an (noun) and got poison (plant) all over his (part of the body) My family is going to go to"
+ " (place) and I will practice (verb ending in “ing”) Parents need vacations more than kids because"
+ " parents are always very (adjective) and because they have to work (number) hours every day all "
+ "year making enough (plural noun) to pay for the vacation.";
//Console.Write(originalStory);
Console.WriteLine("");
//create an array that will hold each word as seperate items in an array
string[] newStory = originalStory.Split();
for(int i = 0; i < newStory.Length - 1; i++)
{
    //initializing a string variable that will have the value of a specific item in the array
    //to be tested against
    string storyWord = newStory[i];
    if(storyWord[0].Equals('('))
    {
        for(int j = i+1; j < newStory.Length - 2; j++)
        {
            string endOfStoryWrd = newStory[j];
            int endWrdLength = endOfStoryWrd.Length;
            if(!endOfStoryWrd[endWrdLength - 1].Equals(')') && storyWord[0].Equals('('))
            {
                storyWord += endOfStoryWrd;
                Console.Clear();
                Console.WriteLine(storyWord);
            }
            else if(newStory[j][0].Equals(')'))
            {

            }
        }
    }
}
/*foreach(string word in newStory)
{
    Console.Write($" {word}");
}*/