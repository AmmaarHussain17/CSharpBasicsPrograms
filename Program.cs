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
        // 2. separating lines by colon(key:value) => |employee name |                            
        //                                            | JOHN   doe|
        // 3. Leading  spaces => | For Keys and Values
        // 4. trailing spaces => | For Keys and Values
        // 4. Converting all sentences into lower cases
        // 5. Adding an Underscore_ in keys.
        // 6. Removing Duplicates => | remarks == remarks



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

        string[] keysAfterConvertedIntoLowercase = new string[lines.Length];
        int indexesValuesAfterConvertedIntoLowercaseForKeys = 0;
        foreach (string lowercaseForKeyData in afterTrimmedStringKeysEnd)
        {
            string afterConvertedIntoLowercase = SeperatingSentences.ConvertingSentencesIntoLowercase(lowercaseForKeyData);
            keysAfterConvertedIntoLowercase[indexesValuesAfterConvertedIntoLowercaseForKeys++] = afterConvertedIntoLowercase;
        }

        string[] valuesAfterConvertedIntoLowercase = new string[lines.Length];
        int indexesValuesAfterConvertedIntoLowercaseForValues = 0;
        foreach (string lowercaseForKeyData in afterTrimmedStringValues)
        {
            string afterConvertedIntoLowercase = SeperatingSentences.ConvertingSentencesIntoLowercase(lowercaseForKeyData);
            valuesAfterConvertedIntoLowercase[indexesValuesAfterConvertedIntoLowercaseForValues++] = afterConvertedIntoLowercase;
        }

        string[] keysAfterAddedUnderscore = new string[lines.Length];
        int indexesValuesAfterAddedUnderscoreForKeys = 0;
        foreach (string keyBeforeAddedUnderScore in keysAfterConvertedIntoLowercase)
        {
            string keyAfterAddedUnderScore = SeperatingSentences.addAnUnderscoreInKeys(keyBeforeAddedUnderScore);
            keysAfterAddedUnderscore[indexesValuesAfterAddedUnderscoreForKeys++] = keyAfterAddedUnderScore;
        }

        int stringSizeAfterDuplicateRemoval = 0;

        stringSizeAfterDuplicateRemoval = SeperatingSentences.DuplicatesRemovalKeys(keysAfterAddedUnderscore);

        string[] afterDuplicateRemovalKeys = new string[stringSizeAfterDuplicateRemoval];
        string[] afterDuplicateRemovalValues = new string[stringSizeAfterDuplicateRemoval];
        
        for (int i = 0; i < stringSizeAfterDuplicateRemoval; i++)
        {
            afterDuplicateRemovalKeys[i] = keysAfterAddedUnderscore[i];
        }
        for (int i = 0; i < stringSizeAfterDuplicateRemoval; i++)
        {
            afterDuplicateRemovalValues[i] = valuesAfterConvertedIntoLowercase[i];
        }
        foreach (string data3 in afterDuplicateRemovalKeys)
        {
            Console.WriteLine(data3);
        }
        foreach (string data3 in afterDuplicateRemovalValues)
        {
            Console.WriteLine(data3);
        }




        //string data = "abc\n" +
        //              "ghf\n";



        //foreach(string eachData in eachDetail)
        //{
        //    Console.WriteLine(eachData);
        //}

    }
}
