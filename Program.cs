/**************************************************************************************************
* Madlibs is a game in which you take a story and mix up the word types.
* You collect a bunch of words and then insert them into the story.
*
* For example:
*
* A vacation is when you take a trip to some (adjective) place with your
* (adjective) family. Usually you go to some place that is near a/an (noun) or up on a/an (noun).
*
* You would then ask someone else for two nouns and two adjectives, they would say
* 'mountain' , 'billy goat', 'ugly', and 'gentle'.   You'd insert these into the story becomes:

* A vacation is when you take a trip to some ugly place with your gentle family. Usually you go to
* some place that is near a/an mountain or up on a/an billy goat

* Your job is to build a code that detects a word in parenthesis and asks the user for a word of that
* type. You will print the original story and the new 'mad libbed' story.
***************************************************************************************************/
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
//create an array that will hold each word as seperate items in an array
string[] newStory = originalStory.Split();
for(int i = 0; i < newStory.Length - 1; i++)
{
    //initializing a string variable that will have the value of a specific item in the array
    //to be tested against
    string newStoryWord = newStory[i];
    if(newStoryWord[0].Equals('('))
    {
        Console.WriteLine("found a (");
    }
}