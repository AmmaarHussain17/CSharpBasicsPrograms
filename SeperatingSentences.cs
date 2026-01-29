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

        public static string addAnUnderscoreInKeys(string eachKeySentence)
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

        public static int DuplicatesRemovalKeys(string[] keysData)
        {
            int i;
            for(i = 0; i < keysData.Length - 1; i++)
            {
                if (keysData[i] == keysData[i + 1]) break;
            }
            return i + 1;
        }

        

    }
}
