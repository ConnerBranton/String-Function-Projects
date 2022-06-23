using System;

namespace StringFunctionProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //string testStr0 = "a b c d e";
            //string testStr1 = "hardey";
            //char character0 = ' ';
            //char character1 = 'b';
            //int num = 3;

            while (true)
            {
                Console.Clear();

                //DRAW MENU
                string[] mainMenu = { "String Contains", "Pad Left", "String Remove", "String Intersection", "String Union", "String Replace", "String Is Numeric", "String OverLoad", "String Split", "Quit Program" };
                int userSelection = RunMenu(mainMenu);

                Console.Clear();

                //PROCESS USER SELECTION
                if (userSelection == 1)
                {
                    Console.WriteLine("This Function checks to see if a char is located in the string.");
                    Console.WriteLine();
                    string word = Prompt("Please enter a word : ");
                    Console.Write("Please enter a character : ");
                    char character = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.WriteLine(StringContains(word, character));
                }
                else if (userSelection == 2)
                {
                    Console.WriteLine("This Function adds a char to the beginning of a string as many times as your number.");
                    Console.WriteLine();
                    string word = Prompt("Please enter a word : ");
                    int num0 = PromptInt("Please enter a number : ");
                    Console.Write("Please enter a character : ");
                    char character = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.WriteLine(PadLeft(word, character, num0));
                }
                else if (userSelection == 3)
                {
                    Console.WriteLine("This Function removes a char from a string if located.");
                    Console.WriteLine();
                    Console.Write("Please enter a single character : ");
                    char character = Console.ReadKey().KeyChar;
                    Console.WriteLine("");
                    string word = Prompt("Please enter a word : ");
                    Console.WriteLine(StringRemove(word, character));
                }
                else if (userSelection == 4)
                {
                    Console.WriteLine("This Function compares two words and combines the alike letters to create a new string.");
                    Console.WriteLine();
                    string word1 = Prompt("Please enter a word : ");
                    string word2 = Prompt("Please enter a second word : ");
                    Console.WriteLine(StringIntersection(word1, word2));
                }
                else if (userSelection == 5)
                {
                    Console.WriteLine("The function accepts two words and returns a string of the unique characters present in both strings.");
                    Console.WriteLine();
                    string word2 = Prompt("Please enter a word : ");
                    string word1 = Prompt("Please enter a second word : ");
                    Console.WriteLine(StringUnion(word2, word1));
                }
                else if (userSelection == 6)
                {
                    Console.WriteLine("This function will return a string with all occurrences of the first char replaced by the second char.");
                    Console.WriteLine();
                    string word = Prompt("Please enter a word : ");
                    Console.Write("Please enter a character : ");
                    char character = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.Write("Please enter another character : ");
                    char character2 = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.WriteLine(StringReplace(word, character, character2));
                }
                else if (userSelection == 7)
                {
                    Console.WriteLine("This function will check a string and return if it is numeric.");
                    Console.WriteLine();
                    string word = Prompt("Please enter a string : ");
                    Console.WriteLine(StringIsNumeric(word));
                }
                else if(userSelection == 8)
                {
                    Console.WriteLine("This function checks to find a string contained inside of another string.");
                    Console.WriteLine();
                    string word0 = Prompt("Please enter a word longer than your next choice : ");
                    string word1 = Prompt("Please enter a shorter word : ");
                    Console.WriteLine(StringContainsOL(word0, word1));
                }
                else if(userSelection == 9)
                {
                    Console.WriteLine("This function splits a string off of the char provided and returns an array");
                    string word = Prompt("Please enter a string : ");
                    Console.Write("Please enter a character : ");
                    char character = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    Console.WriteLine(StringSplit(word, character));
                }
                else
                {
                    return;//quit
                }//end if

                //HOLD WINDOW UNTIL USER PRESSES ENTER
                Prompt("Press enter to continue");
            }//end while


            //Console.WriteLine(StringContains(testStr0, character));
            //Console.WriteLine(PadLeft(testStr0, character0, num));
            //Console.WriteLine(StringRemove(testStr0, character0));
            //Console.WriteLine(StringIntersection(testStr0, testStr1));
            //Console.WriteLine(StringUnion(testStr0, testStr1));
            //Console.WriteLine(StringReplace(testStr0, character0, character1));
            //Console.WriteLine(StringIsNumeric(testStr0));
            //Console.WriteLine(StringContainsOL(testStr0, testStr1));
            //Console.WriteLine(StringSplit(testStr0, character0));

        }

        static int RunMenu(string[] menu)
        {
            int minSelection = 1;
            int maxSelection = menu.Length;

            int userSelection = 0;

            //DRAW MENU
            for (int index = 0; index < menu.Length; index++)
            {
                string menuText = menu[index];
                Console.WriteLine((index + 1) + ". " + menuText);
            }//end for

            //VALIDATE INPUT FOR SELECTION
            do
            {
                Console.WriteLine();
                userSelection = PromptInt("Please make a number selection : ");
            } while (userSelection > maxSelection || userSelection < minSelection);

            //RETURN SELECTION
            return userSelection;
        }//end function

        static string Prompt(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }//end function

        //static char PromptChar(string character)
        //{
        //    char[] input = character.ToCharArray();
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        input[i] = Console.ReadLine()[0];
        //    }
        //    return input[0];
        //}        
        static int PromptInt(string text)
        {
            bool parsedSucessfully = false;
            int parsedValue = 0;

            while (parsedSucessfully == false)
            {
                string userInput = Prompt(text);
                parsedSucessfully = int.TryParse(userInput, out parsedValue);
            }//end while

            return parsedValue;
        }//end function               
        static bool StringContains(string strPapi, char letter)
        {
           bool check = true;
            //set an array for the string to be seperated into
            char[] name = strPapi.ToCharArray();

            for (int index = 0; index < name.Length; index ++)
            {
                //if statement to check for char inside array
                if (letter == name[index])
                {
                    //if true break from loop
                    check = true;
                    break;
                }
                if(letter != name[index])
                {
                    //if false continue to next location of array
                    check = false;
                    continue;
                }
            }
            //retun result of check
            return check;

            Console.ReadKey();

            
        }
        static string PadLeft(string teststr, char character, int num)
        {
            //create new string to store return value
            string name = "";

            //for loop to add the character to the beginning of the string
            for(int index = 0; index < num; index++)
            {
                name = name + character;
            }//end for
            //combine new string to beginning of old string
            name = name + teststr;

            //return new string
            return name;
        }


        static string StringRemove(string name, char searchcharacter)
        {
            string newWord = "";
            
            //for loop to traverse through name to check for searchcharacter
            for(int i = 0; i < name.Length; i++)
            {
                
                if(searchcharacter != name[i])
                {
                    //set letters to new word that arent equal to searchcharacter
                    newWord = newWord + name[i];
                    
                }//end if
                
            }//end for
            
            //return word without searcharacter letters
            return newWord;
        }

        static string StringIntersection(string primary, string searchword)
        {
            string newWord = "";
            //for loop traverse through primary string            
            for (int i = 0; i < primary.Length; i++)
            {
                //loop through searchword location with each letter in primary to search for match                
                for(int j = 0; j < searchword.Length; j++)
                {
                    //if there is a match add that letter to newWord
                    if(primary[i] == searchword[j])
                    {
                        newWord = newWord + searchword[j];
                    }//end if
                     
                }//end for
                               
            }//end for
            //return newWord string
            return newWord;
        }

        static string StringUnion(string s1, string s2)
        {
            //assign return to string 1
            string returnStr = s1;
            //for loop to traverse s2 length
            for(int i = 0; i < s2.Length; i += 1)
            {
                //create char to check for alike-ness of each location of s2
                char letter = s2[i];
                //send information to string contains
                bool inReturnStr = StringContains(returnStr, letter);
                //if letter is not already in string 1 add letter to end of return string
                if (!inReturnStr)
                {
                    returnStr += letter;
                }
                
            }//return result
            return returnStr;
        }

        static string StringReplace(string word, char primaryLetter, char secondaryLetter)
        {
            string newWord = "";
            //for loop traverse throug word to find match of letters
            for (int i = 0; i < word.Length; i++)
            {
                
                if (primaryLetter == word[i])
                {
                    //set secondaryLetter in place of letters that match primaryLetter
                    newWord = newWord + secondaryLetter;

                }//end if
                if(primaryLetter != word[i])
                {
                    newWord = newWord + word[i];
                }//end if
            }
            //return result
            return newWord;
        }

        static bool StringIsNumeric(string word)
        {
            bool check = true;

            //create array and send var to it
            char[] array = word.ToCharArray();

            //for loop to traverse through the array to check for digit only...else return false
            for (int index = 0; index < array.Length; index++)
            {

                //perameters to check for digits 0-9 
                if (array[index] >= '0' && array[index] <= '9' || array[index] == '.')
                {
                    //continue loop if number is located
                    continue;

                }//end if
                else
                {
                    //if a character other than a digit is located return false
                    check = false;
                }//end else
            }//end for loop
            return check;
        }
        static bool StringContainsOL(string s1, string s2)
        {
            

            bool check = false;
            //set an array for the string to be seperated into
            for (int i = 0; i <= s1.Length; i++)
            {
                check = true;
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i + j] != s2[j])
                    {
                        check = false;
                    }
                }
                if(check == true)
                {
                    return check;
                }
            }
            //retun result of check
            return check;
        }
        static char[] StringSplit(string s1, char character)
        {

            string newWord = "";

            for (int i = 0; i < s1.Length; i++)
            {

                if (character != s1[i])
                {
                    newWord = newWord + s1[i];
                }
            }

            // Creating array of string length 
            char[] ch = new char[newWord.Length];

            // Copy character by character into array 
            for (int i = 0; i < newWord.Length; i++)
            {
                ch[i] = newWord[i];
            }
                        
            return ch;
        }
    }
}
