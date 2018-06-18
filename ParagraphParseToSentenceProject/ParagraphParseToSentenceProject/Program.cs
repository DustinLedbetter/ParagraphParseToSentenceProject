/***********************************************************************************************************
 *                                          God First                                                      *
 * Created by: Dustin Ledbetter                                                                            *
 * Date: 6-15-2018                                                                                         *
 * Type: C#.NET console application                                                                        *
 * Purpose: Takes a paragraph of text and returns an array seperated into sentences printed out in console *
 **********************************************************************************************************/
using System;
using System.Text.RegularExpressions;

namespace ParagraphParseToSentenceProject
{
    class Program
    {

        // Creates a string that holds the paragraph to be sorted
        public static string paragraph = "Nyrn and Tyene may have reached King’s Landing by now, she mused, as she settled down crosslegged by the mouth of the cave to watch the falling rain.If not they ought to be there soon.Three hundred seasoned spears had gone with them, over the Boneway, past the ruins of Summerhall, and up the kingsroad. If the Lannisters had tried to spring their little trap in the kingswood, Lady Nym would have seen that it ended in disaster.Nor would the murderers have found their prey. Prince Trystane had remained safely back at Sunspear, after a tearful parting from Princess Myrcella.That accounts for one brother, thought Arianne, but where is Quentyn, if not with the griffin? Had he wed his dragon queen? King Quentyn. It still sounded silly. This new Daenerys Targaryen was younger than Arianne by half a dozen years.What would a maid that age want with her dull, bookish brother? Young girls dreamed of dashing knights with wicked smiles, not solemn boys who always did their duty.She will want Dorne, though. If she hopes to sit the Iron Throne, she must have Sunspear.If Quentyn was the price for that, this dragon queen would pay it.What if she was at Griffin’s End with Connington, and all this about another Targaryen was just some sort of subtle ruse? Her brother could well be with her.King Quentyn. Will I need to kneel to him?";

        /// <summary>
        /// Calls method to break the paragraph up into sentences.
        /// Pauses at end til user presses a key signifying program is complete.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Calls method to break the paragraph up into sentences
            SplitParagraphIntoSentences(paragraph);

            // Pauses at end til user presses a key signifying program is complete
            Console.WriteLine("\n" + "Press any key to continue...");
            Console.ReadKey();

        }

        /// <summary>
        /// Splits the paragraph into sentences when it finds a ., ?, or ! and stores it into an array of sentences.
        /// Prints out each line in the sentence array to the console. 
        /// </summary>
        /// <param name="input"></param>
        public static void SplitParagraphIntoSentences(string input)
        {

            // Splits the paragraph into sentences when it finds a ., ?, or ! and stores it into an array of sentences
            string[] sentences = Regex.Split(input, @"(?<=[.?!])");

            // Prints out each line in the sentence array to the console 
            foreach (string line in sentences)
            {

                // Prints each line
                Console.WriteLine(line.Trim());

            }

        }



    }
} // ParagraphParseToSentenceProject
