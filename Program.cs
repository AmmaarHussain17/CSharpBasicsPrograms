using ManualStringProcessing;

class Program
{
    public static void Main(string[] args)
    {
        var data = "    employee name :    JOHN   doe   \n" +
        "    EMPLOYEE id:    0045  \n" +
        "    Department  :      finance  \n" +
        "joining date  :12   -   03   -2021  \n" +
        "email :     John.Doe@Company.COM\n " +
        "phone number:     91 - 98765   43210 \n" +
        "remarks :      excellent   performer \n" +
        "remarks :needs    improvement\n" +
        "END  of      report\n";



        // 1. lines
        // 2. leading trailing spaces => |employee name :    JOHN   doe|
        // 3. separating lines by colon(key:value) => |employee name |                            
        //                                            | JOHN   doe|
        // 4. trailing spaces => |
        // 4. Converting all sentences into lower cases
        // 5. Adding an Underscore_ in keys.



        string[] lines = SeperatingSentences.Lines(data);

        string[] eachKeyData = new string[lines.Length];
        string[] eachValuesData = new string[lines.Length];

        int indexesKeyForBreakingKeyAndValuesInEachSentence = 0;
        int indexesValuesForBreakingKeyAndValuesInEachSentence = 0;
        foreach (string trimmed in lines)
        {
            MyKeyValue eachKeyAndValueData = SeperatingSentences.BreakingKeyAndValuesInEachSentence(trimmed);
            eachKeyData[indexesKeyForBreakingKeyAndValuesInEachSentence++] = eachKeyAndValueData.key;
            eachValuesData[indexesValuesForBreakingKeyAndValuesInEachSentence++] = eachKeyAndValueData.value;
        }


        string[] afterTrimmedStringKeys = new string[lines.Length];
        int indexesForSeperatingSentencesKeys = 0;

        foreach (string keyLines in eachKeyData)
        {
            string trimmedLineKey = SeperatingSentences.LeadingSpacesTrimmed(keyLines);
            afterTrimmedStringKeys[indexesForSeperatingSentencesKeys++] = trimmedLineKey;
        }


        string[] afterTrimmedStringValues = new string[lines.Length];
        int indexesForSeperatingSentencesValues = 0;
        foreach (string ValueLines in eachValuesData)
        {
            string trimmedLineKey = SeperatingSentences.LeadingSpacesTrimmed(ValueLines);
            afterTrimmedStringValues[indexesForSeperatingSentencesValues++] = trimmedLineKey;
        }

        string[] afterTrimmedStringKeysEnd = new string[lines.Length];
        int indexesForSeperatingSentencesKeysEnd = 0;

        foreach (string keyLinesEnd in afterTrimmedStringKeys)
        {
            string trimmedLineKeyEnds = SeperatingSentences.trailingSpacesTrimmed(keyLinesEnd);
            afterTrimmedStringKeysEnd[indexesForSeperatingSentencesKeysEnd++] = trimmedLineKeyEnds;
        }

        string[] afterTrimmedStringValuesEnd = new string[lines.Length];
        int indexesForSeperatingSentencesValuesEnd = 0;

        foreach (string valuesLinesEnd in afterTrimmedStringValues)
        {
            string trimmedLineValuesEnds = SeperatingSentences.trailingSpacesTrimmed(valuesLinesEnd);
            afterTrimmedStringValuesEnd[indexesForSeperatingSentencesValuesEnd++] = trimmedLineValuesEnds;
        }

        foreach (string data3 in afterTrimmedStringValuesEnd)
        {
            Console.Write(data3);
            Console.WriteLine();
        }

        string[] keysAfterConvertedIntoLowercase = new string[lines.Length];
        int indexesValuesAfterConvertedIntoLowercaseForKeys = 0;
        foreach (string lowercaseForKeyData in eachKeyData)
        {
            string afterConvertedIntoLowercase = SeperatingSentences.ConvertingSentencesIntoLowercase(lowercaseForKeyData);
            keysAfterConvertedIntoLowercase[indexesValuesAfterConvertedIntoLowercaseForKeys++] = afterConvertedIntoLowercase;
        }

        string[] valuesAfterConvertedIntoLowercase = new string[lines.Length];
        int indexesValuesAfterConvertedIntoLowercaseForValues = 0;
        foreach (string lowercaseForKeyData in eachKeyData)
        {
            string afterConvertedIntoLowercase = SeperatingSentences.ConvertingSentencesIntoLowercase(lowercaseForKeyData);
            valuesAfterConvertedIntoLowercase[indexesValuesAfterConvertedIntoLowercaseForValues++] = afterConvertedIntoLowercase;
        }




        //string[] keysAfterAddedUnderscore = new string[lines.Length];
        //int indexesValuesAfterAddedUnderscoreForKeys = 0;
        //foreach (string keyBeforeAddedUnderScore in keysAfterConvertedIntoLowercase)
        //{
        //    string keyAfterAddedUnderScore = SeperatingSentences.addAnUnderscoreInKeys(keyBeforeAddedUnderScore);
        //    keysAfterAddedUnderscore[indexesValuesAfterAddedUnderscoreForKeys++] = keyAfterAddedUnderScore;
        //}
        //foreach (string dataTemp in keysAfterAddedUnderscore)
        //{
        //    Console.WriteLine(dataTemp);
        //}




        //foreach (string dataTemp in valuesAfterConvertedIntoLowercase)
        //{
        //    Console.WriteLine(dataTemp);
        //}
        //Console.Write($"{eachKeyData[0]} ");
        //Console.Write($"{eachValuesData[0]} ");
        //SeperatingSentences.sentencesStrings(data);


        //string data = "abc\n" +
        //              "ghf\n";



        //foreach(string eachData in eachDetail)
        //{
        //    Console.WriteLine(eachData);
        //}

    }
}