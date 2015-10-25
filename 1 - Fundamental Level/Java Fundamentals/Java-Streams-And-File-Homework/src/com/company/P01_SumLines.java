package com.company;

import java.io.*;
import java.util.concurrent.ExecutionException;

/**
 * Created by Killer18ys on 23-10-2015.
 */
public class P01_SumLines {
    public static final String FILE_PATH = "C:\\Users\\Killer18ys\\Desktop\\lines.txt";
    public static final String SAVE_FILE_PATH = "C:\\Users\\Killer18ys\\Desktop\\result.txt";

    public static void main(String[] args) {

        try{
            File inputFile = new File(FILE_PATH);
            BufferedReader reader = new BufferedReader(new FileReader(inputFile));

            File outputFile = new File(SAVE_FILE_PATH);
            PrintWriter writer = new PrintWriter(new FileWriter(outputFile));

            String s;
            int lineCharValueSum;
            while ((s = reader.readLine()) != null){
                char[] line = s.toCharArray();
                lineCharValueSum = 0;

                for (int i = 0; i < line.length; i++) {
                    lineCharValueSum += (int)line[i];
                }
                writer.println(lineCharValueSum);

            }

            reader.close();
            writer.flush();
            writer.close();

        }
        catch (Exception e){
            System.out.println(e);
        }
    }
}
