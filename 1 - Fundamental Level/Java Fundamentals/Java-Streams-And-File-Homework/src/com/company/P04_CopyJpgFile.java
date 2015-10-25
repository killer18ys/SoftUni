package com.company;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;

/**
 * Created by Hacker on 10/25/2015.
 */
public class P04_CopyJpgFile {
    public static final String INPUT_FILE_PATH = "resources\\image.jpg";
    public static final String OUTPUT_FILE_PATH = "resources\\image-copy.jpg";

    public static void main(String[] args) {

        try {

            File inputFile = new File(INPUT_FILE_PATH);
            FileInputStream inputStream = new FileInputStream(inputFile);

            File outputFile = new File(OUTPUT_FILE_PATH);
            FileOutputStream outputStream = new FileOutputStream(outputFile);

            byte[] buffer = new byte[(int)inputFile.length()];

            inputStream.read(buffer);
            outputStream.write(buffer);

        }catch (Exception e){
            System.out.println(e);
        }
    }
}
