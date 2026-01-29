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



        // 1. lines diving string into lines.
        // 2. separating lines by colon(key:value) => |employee name |                            
        //                                            | JOHN   doe|
        // 3. Leading  spaces => | For Keys and Values
        // 4. trailing spaces => | For Keys and Values
        // 4. Converting all sentences of Keys and Values into lower cases
        // 5. Adding an Underscore_ in keys.
        // 6. Removing Duplicates => | remarks == remarks
        // 7. Small Correction in Values


        // lines diving string into lines.
        string[] lines = SeperatingSentences.Lines(data);
        // separating lines by colon(key:value) => |employee name |                            
        //                                         | JOHN   doe|
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

        // Leading spaces removed => for Keys 
        string[] afterTrimmedStringKeys = new string[lines.Length];
        int indexesForSeperatingSentencesKeys = 0;

        foreach (string keyLines in eachKeyData)
        {
            string trimmedLineKey = SeperatingSentences.LeadingSpacesTrimmed(keyLines);
            afterTrimmedStringKeys[indexesForSeperatingSentencesKeys++] = trimmedLineKey;
        }

        // Leading spaces removed => for Values
        string[] afterTrimmedStringValues = new string[lines.Length];
        int indexesForSeperatingSentencesValues = 0;
        foreach (string ValueLines in eachValuesData)
        {
            string trimmedLineKey = SeperatingSentences.LeadingSpacesTrimmed(ValueLines);
            afterTrimmedStringValues[indexesForSeperatingSentencesValues++] = trimmedLineKey;
        }

        // trailing spaces removed => for Keys
        string[] afterTrimmedStringKeysEnd = new string[lines.Length];
        int indexesForSeperatingSentencesKeysEnd = 0;

        foreach (string keyLinesEnd in afterTrimmedStringKeys)
        {
            string trimmedLineKeyEnds = SeperatingSentences.trailingSpacesTrimmed(keyLinesEnd);
            afterTrimmedStringKeysEnd[indexesForSeperatingSentencesKeysEnd++] = trimmedLineKeyEnds;
        }

        // trailing spaces removed => for Values
        string[] afterTrimmedStringValuesEnd = new string[lines.Length];
        int indexesForSeperatingSentencesValuesEnd = 0;

        foreach (string valuesLinesEnd in afterTrimmedStringValues)
        {
            string trimmedLineValuesEnds = SeperatingSentences.trailingSpacesTrimmed(valuesLinesEnd);
            afterTrimmedStringValuesEnd[indexesForSeperatingSentencesValuesEnd++] = trimmedLineValuesEnds;
        }

        // Converting all sentences of Keys into lower cases
        string[] keysAfterConvertedIntoLowercase = new string[lines.Length];
        int indexesValuesAfterConvertedIntoLowercaseForKeys = 0;
        foreach (string lowercaseForKeyData in afterTrimmedStringKeysEnd)
        {
            string afterConvertedIntoLowercase = SeperatingSentences.ConvertingSentencesIntoLowercase(lowercaseForKeyData);
            keysAfterConvertedIntoLowercase[indexesValuesAfterConvertedIntoLowercaseForKeys++] = afterConvertedIntoLowercase;
        }

        // Converting all sentences of Values into lower cases
        string[] valuesAfterConvertedIntoLowercase = new string[lines.Length];
        int indexesValuesAfterConvertedIntoLowercaseForValues = 0;
        foreach (string lowercaseForKeyData in afterTrimmedStringValuesEnd)
        {
            string afterConvertedIntoLowercase = SeperatingSentences.ConvertingSentencesIntoLowercase(lowercaseForKeyData);
            valuesAfterConvertedIntoLowercase[indexesValuesAfterConvertedIntoLowercaseForValues++] = afterConvertedIntoLowercase;
        }

        // Adding an Underscore_ in keys where needed.
        string[] keysAfterAddedUnderscore = new string[lines.Length];
        int indexesValuesAfterAddedUnderscoreForKeys = 0;
        foreach (string keyBeforeAddedUnderScore in keysAfterConvertedIntoLowercase)
        {
            string keyAfterAddedUnderScore = SeperatingSentences.AddAnUnderscoreInKeys(keyBeforeAddedUnderScore);
            keysAfterAddedUnderscore[indexesValuesAfterAddedUnderscoreForKeys++] = keyAfterAddedUnderScore;
        }

        // Removing Duplicates => | remarks == remarks
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

        // Corrections in Values
        string[] valuesAfterCorrections = new string[stringSizeAfterDuplicateRemoval];

        // Removing Extra Middle Spaces in employee name
        valuesAfterCorrections[0] = SeperatingSentences.ExtraMiddleSpacesRemoval(afterDuplicateRemovalValues[0]);

        // Removing Extra Middle Spaces in remarks
        valuesAfterCorrections[6] = SeperatingSentences.ExtraMiddleSpacesRemoval(afterDuplicateRemovalValues[6]);

        // Removing Zeroes in the beginning of employee Id
        valuesAfterCorrections[1] = SeperatingSentences.RemoveZeroInBeginningOfString(afterDuplicateRemovalValues[1]);

        // Removing Spaces of joining date
        valuesAfterCorrections[3] = SeperatingSentences.RemoveSpaces(afterDuplicateRemovalValues[3]);

        // Removing Spaces and Hypens in Phone Number 
        valuesAfterCorrections[5] = SeperatingSentences.RemoveExtraSpacesAndHyphen(afterDuplicateRemovalValues[5]);

        // Assigning rest of the Values to new string where no Correction are needed
        for (int i = 0; i < valuesAfterCorrections.Length; i++)
        {
            if (valuesAfterCorrections[i] == null)
                valuesAfterCorrections[i] = afterDuplicateRemovalValues[i];
        }

        // Oupting all Keys and Values into a Single String
        string FinalOutputString = SeperatingSentences.AllStringsConcatenated(afterDuplicateRemovalKeys, valuesAfterCorrections, stringSizeAfterDuplicateRemoval);
        Console.WriteLine(FinalOutputString);

    }
}
