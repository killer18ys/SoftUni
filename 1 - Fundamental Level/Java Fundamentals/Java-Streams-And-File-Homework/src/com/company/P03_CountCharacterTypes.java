package com.company;

import java.io.*;

/**
 * Created by Hacker on 10/25/2015.
 */
public class P03_CountCharacterTypes {
    public static final String INPUT_FILE_PATH = "resources\\words.txt";
    public static final String OUTPUT_FILE_PATH = "resources\\P03-count-chars.txt";

    public static void main(String[] args) {
        try{
            File inputFile = new File(INPUT_FILE_PATH);
            BufferedReader reader = new BufferedReader(new FileReader(inputFile));

            File outputFile = new File(OUTPUT_FILE_PATH);
            PrintWriter writer = new PrintWriter(new FileWriter(outputFile));

           int vowelsCount = 0;
           int consonantsCount = 0;
           int punctuationCount = 0;

            int currSymbol = reader.read();

            while (currSymbol != -1){

                if ((currSymbol >=65 && currSymbol <= 90) ||(currSymbol >= 97 && currSymbol <= 122)){
                    if (currSymbol != 'a' && currSymbol != 'e' && currSymbol != 'i' && currSymbol != 'o' && currSymbol != 'u'){
                        consonantsCount++;
                    }else{
                        vowelsCount++;
                    }
                }else{
                    if (currSymbol == '!' || currSymbol == '.' || currSymbol == ',' || currSymbol == '?'){
                        punctuationCount++;
                    }
                }

                currSymbol = reader.read();
            }

            writer.printf("Vowels: %d\n", vowelsCount);
            writer.printf("Consonants: %d\n", consonantsCount);
            writer.printf("Punctuation: %d\n", punctuationCount);

            reader.close();
            writer.close();

        }catch (Exception e){
            System.out.println(e);
        }

    }
}
