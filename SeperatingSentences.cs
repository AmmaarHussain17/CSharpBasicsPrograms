using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ManualStringProcessing
{
    public class MyKeyValue
    {
        public string key;
        public string value;
    }
    internal class SeperatingSentences
    {
        // Separating Single string into proper lines.
        public static string[] Lines(string data)
        {
            int countSizeOfEachString = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '\n') countSizeOfEachString++;
            }

            string[] eachLine = new string[countSizeOfEachString];
            int nextLineStartingStringLength = 0;

            for (int i = 0; i < eachLine.Length; i++)
            {
                int j = nextLineStartingStringLength;
                while (j < data.Length)
                {
                    if (data[j] == '\n') break;

                    eachLine[i] += data[j];

                    j++;
                }
                nextLineStartingStringLength = j + 1;
            }
            return eachLine;
        }
        
        // Breaking keys and values relations of Each String.
        public static MyKeyValue BreakingKeyAndValuesInEachSentence(string keyAndValueString)
        {
            string eachKey = null;
            string eachValue = null;

            MyKeyValue keyValue = new MyKeyValue();

            int namesValesStartingIndex = 0;

            for (int i = 0; i < keyAndValueString.Length; i++)
            {
                if (keyAndValueString[i] == ':')
                {
                    namesValesStartingIndex = i + 1;
                    break;
                }
                eachKey += keyAndValueString[i];
            }
            for (int k = namesValesStartingIndex; k < keyAndValueString.Length; k++)
            {
                eachValue += keyAndValueString[k];
            }

            keyValue.key = eachKey;
            keyValue.value = eachValue;

            return keyValue;
        }

        // Trimming Leading Zeroes of Keys and Values.
        public static string LeadingSpacesTrimmed(string line)
        {
            string eachLine = null;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != ' ')
                {
                    for (int j = i; j < line.Length; j++)
                    {
                        eachLine += line[i++];
                    }
                    break;
                }
            }
            return eachLine;
        }

        // Trimming Trailing Zeroes of Keys and Values.
        public static string trailingSpacesTrimmed(string line)
        {
            string eachLine = null;
            int k = 0;

            for (int i = line.Length - 1; i >= 0 ; i--)
            {
                if (line[i] != ' ')
                {
                    for (int j = 0; j <= i; j++)
                    {
                        eachLine += line[k++];
                    }
                    break;
                }
            }
            return eachLine;
        }

        // Converting keys and values into Lowercase.
        public static string ConvertingSentencesIntoLowercase(string eachSentenceData)
        {
            string lowercaseConvertedEachLine = null;
            for(int i = 0; i < eachSentenceData.Length; i++)
            {
                if (eachSentenceData[i] >= 'A' && eachSentenceData[i] <= 'Z')
                    lowercaseConvertedEachLine += (char) (eachSentenceData[i] + 32);
                else
                    lowercaseConvertedEachLine += eachSentenceData[i];
            }
            return lowercaseConvertedEachLine;
        }

        // Adding Underscore in keys between two words. 
        public static string AddAnUnderscoreInKeys(string eachKeySentence)
        {
            string keyAfterAddedUnderScore = null;
            for (int i = 0; i < eachKeySentence.Length; i++)
            {
                if (eachKeySentence[i] == ' ')
                    keyAfterAddedUnderScore += '_';
                else
                    keyAfterAddedUnderScore += eachKeySentence[i];
            }
            return keyAfterAddedUnderScore;
        }

        // Remving Duplicates in Keys.
        public static int DuplicatesRemovalKeys(string[] keysData)
        {
            int i;
            for(i = 0; i < keysData.Length - 1; i++)
            {
                if (keysData[i] == keysData[i + 1]) break;
            }
            return i + 1;
        }

        // Removing Extra Spaces present in Middle of Values.
        public static string ExtraMiddleSpacesRemoval(string line)
        {
            string afterExtraMiddleSpacesRemoved = null;
            for(int i = 0; i < line.Length; i++)
            {
                if(i == 0 || line[i] != ' ' || line[i - 1] != ' ')
                    afterExtraMiddleSpacesRemoved += line[i];
            }
            return afterExtraMiddleSpacesRemoved;
        }

        // Removing Extra Zeroes in the Beginning.
        public static string RemoveZeroInBeginningOfString(string line)
        {
            string afterZeroesRemoval = null;
            for(int i = 0; i < line.Length; i++)
            {
                if (line[i] != '0')
                {
                    for(int j = i; j < line.Length; j++)
                    {
                        afterZeroesRemoval += line[i++];
                    }
                    break;
                }
            }
            return afterZeroesRemoval;
        }

        // Removing Spaces where not needed.
        public static string RemoveSpaces(string line)
        {
            string lineAfterSpacesRemoval = null;
            for(int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ') continue;
                lineAfterSpacesRemoval += line[i];
            }
            return lineAfterSpacesRemoval;
        }

        //Removing Spaces and Hypen where not needed.
        public static string RemoveExtraSpacesAndHyphen(string line)
        {
            string lineAfterSpacesAndHyphenRemoval = null;
            for(int i = 0; i < line.Length; i++)
            {
                if (line[i] == ' ' || line[i] == '-') continue;
                lineAfterSpacesAndHyphenRemoval += line[i];
            }
            return lineAfterSpacesAndHyphenRemoval;
        }

        // Concatenating all the Keys and Values into a single String.
        public static string AllStringsConcatenated(string[] keys, string[] values,int size)
        {
            string finalConcatedString = null;
            string colonWithProperSpaces = " : ";
            for(int i = 0; i < size; i++)
            {
                finalConcatedString += keys[i] + colonWithProperSpaces + values[i] + "\n";
            }
            return finalConcatedString;
        }
    }
}
