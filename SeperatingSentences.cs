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



        //public static void sentencesStrings(string data)
        //{
        //    int countSizeOfEachString = 0;
        //    for (int i = 0; i < data.Length; i++)
        //    {
        //        if (data[i] == '\n') countSizeOfEachString++;
        //    }

        //    string[] eachLine = new string[countSizeOfEachString];
        //    int nextLineStartingStringLength = 0;

        //    for (int i = 0; i < eachLine.Length; i++)
        //    {
        //        int j = nextLineStartingStringLength;
        //        while (j < data.Length)
        //        {
        //            if (data[j] == '\n') break;

        //            eachLine[i] += data[j];

        //            j++;
        //        }
        //        nextLineStartingStringLength = j + 1;
        //    }

        //    string[] eachFieldHeader = new string[countSizeOfEachString];
        //    string[] eachFieldNames = new string[countSizeOfEachString];


        //    

        //    string[] namesAfterConvertingIntoLowercase = convertIntoLowercase(eachFieldNames);
        //    string[] headersAfterConvertingIntoLowercase = convertIntoLowercase(eachFieldHeader);

        //    underscoreAdderAtHeader(headersAfterConvertingIntoLowercase);

        //    //underscoreAdder(eachFieldHeader);

        //}
        //public static string[] convertIntoLowercase(string[] headerConvertIntoLowerCase)
        //{
        //    for (int i = 0; i < headerConvertIntoLowerCase.Length; i++)
        //    {
        //        char[] chars = headerConvertIntoLowerCase[i].ToCharArray();

        //        for (int j = 0; j < chars.Length; j++)
        //        {
        //            if (chars[j] >= 'A' && chars[j] <= 'Z')
        //            {
        //                chars[j] = (char)(chars[j] + 32);
        //            }
        //        }
        //        headerConvertIntoLowerCase[i] = new string(chars);

        //    }
        //    //foreach (string temp in headerConvertIntoLowerCase)
        //    //{
        //    //    Console.WriteLine(temp);
        //    //}
        //    return headerConvertIntoLowerCase;
        //}
        //public static void underscoreAdderAtHeader(string[] adderUnderscoreInHeaders)
        //{
        //    for (int str = 0; str < adderUnderscoreInHeaders.Length; str++)
        //    {

        //    }
        //foreach (string temp in adderUnderscoreInHeaders)
        //{
        //    Console.WriteLine(temp);
        //}

    }
}
