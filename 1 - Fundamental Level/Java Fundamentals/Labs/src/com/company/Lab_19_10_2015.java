package com.company;

import java.io.*;
import java.text.SimpleDateFormat;
import java.time.format.DateTimeFormatter;
import java.util.Date;


/**
 * Created by Killer18ys on 19-10-2015.
 */
public class Lab_19_10_2015 {
    private static final String FILE_PATH = "C:\\\\Users\\Killer18ys\\Desktop\\users.txt";
    private static final String SAVE_FILE_PATH = "C:\\\\Users\\Killer18ys\\Desktop\\users-total-time.txt";

    public static void main(String[] args) {

        try{
            File file = new File(FILE_PATH);
            BufferedReader bfr = new BufferedReader(new FileReader(file));

            File outputFile = new File(SAVE_FILE_PATH);
            FileWriter wr = new FileWriter(outputFile, true);
            PrintWriter writer = new PrintWriter(wr, true);

            String line = bfr.readLine();

            while(line != null){
               String[] lineParam  = line.split(" ");
                String name = lineParam[0];
                int totalTimeInMin = 0;
                for (int i = 1; i < lineParam.length; i++) {
                    String[] time = lineParam[i].split(":");
                    int  hours = Integer.parseInt(time[0]);
                    int minutes = Integer.parseInt(time[1]);

                    totalTimeInMin += (hours * 60) + minutes;
                }

                String[] convertedTime = timeConvert(totalTimeInMin).split(":");
                int days = Integer.parseInt(convertedTime[0]);
                int hours = Integer.parseInt(convertedTime[1]);
                int minutes = Integer.parseInt(convertedTime[2]);


                writer.printf("%s %d (%d days %d hours %d minutes)", name , totalTimeInMin, days, hours, minutes);
                writer.println();

                line = bfr.readLine();
            }

            bfr.close();
            writer.close();
        }
        catch (Exception e){
            System.out.println(e);
        }



    }

    public static String timeConvert(int time) {
        return time/24/60 + ":" + time/60%24 + ':' + time%60;
    }
}
