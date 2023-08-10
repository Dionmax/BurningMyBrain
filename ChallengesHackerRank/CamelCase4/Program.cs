using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

/**
 * 
 * Tests
 * 
S;V;iPad
C;M;mouse pad
C;C;code swarm
S;C;OrangeHighlighter
 **/

class Solution
{
    public static string transformStringCMV(string action, string type, string text)
    {
        string[] words = text.Split(' ');

        switch (type)
        {
            case "M":
                if (action == "S")
                {
                    text = text.ToLower();
                    text = Regex.Replace(text, @"[()]", "");
                }
                else if (action == "C")
                {

                    text = Regex.Replace(text, @"\b\p{Ll}", match => match.Value.ToUpper());

                    text = text + "()";

                    text = char.ToLowerInvariant(text[0]) + text.Substring(1);

                    text = Regex.Replace(text, " ", "");
                }
                break;

            case "C":


                if (action == "C")
                {
                    text = Regex.Replace(text, @"\b\p{Ll}", match => match.Value.ToUpper());
                    text = Regex.Replace(text, " ", "");
                }
                else
                {
                    text = text.ToLower();
                }

                break;

            case "V":
                if (action == "S")
                {
                    text = text.ToLower();
                }
                else
                {
                    text = Regex.Replace(text, @"\b\p{Ll}", match => match.Value.ToUpper());
                    text = char.ToLowerInvariant(text[0]) + text.Substring(1);
                    text = Regex.Replace(text, " ", "");
                }
                break;

            default:
                return text;

        }

        return text;
    }

    public static string SplitCamelCase(string source)
    {
        return String.Join(" ", Regex.Split(source, @"(?<!^)(?=[A-Z])"));
    }

    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string input = "";
        string[]? input2;

        do
        {
            input = Console.ReadLine();

            if (input != "" && input != null)
            {
                input2 = input.Split(";");

                if (input2[0] == "S")
                {
                    input2[2] = SplitCamelCase(input2[2]);
                    Console.WriteLine(transformStringCMV(input2[0], input2[1], input2[2]));
                }
                else if (input2[0] == "C")
                {
                    Console.WriteLine(transformStringCMV(input2[0],input2[1], input2[2]).Trim());
                }
            }
            else
                break;
        } while (input != "");
    }
}
