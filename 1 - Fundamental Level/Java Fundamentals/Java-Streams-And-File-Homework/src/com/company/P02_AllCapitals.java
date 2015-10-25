package com.company;

import java.io.*;

/**
 * Created by Hacker on 10/25/2015.
 */
public class P02_AllCapitals {
    public static final String INPUT_FILE_PATH = "resources\\lines.txt";
    public static final String OUTPUT_FILE_PATH = "resources\\P02-AllCapitalLines.txt";

    public static void main(String[] args) {

        try{
            File inputFile = new File(INPUT_FILE_PATH);
            BufferedReader reader = new BufferedReader(new FileReader(inputFile));

            File outputFile = new File(OUTPUT_FILE_PATH);
            PrintWriter writer = new PrintWriter(new FileWriter(outputFile));



            String line = reader.readLine();
            while (line != null){
                writer.println(line.toUpperCase());

                line = reader.readLine();
            }
            reader.close();
            writer.close();
        }
        catch (Exception e){
            System.out.println(e);
        }
    }
}
