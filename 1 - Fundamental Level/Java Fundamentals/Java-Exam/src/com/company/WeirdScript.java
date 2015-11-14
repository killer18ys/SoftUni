package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Killer18ys on 14-11-2015.
 */
public class WeirdScript {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        int keyNumber = n - 1;
        boolean isLower  = (keyNumber / 26) % 2 == 0;

        char key;

        if (isLower){
            key =  (char)((keyNumber % 26) + 97);
        }else{
            key =  (char)((keyNumber % 26) + 65);
        }

        String pattern = "(" + key + "{2})(.*?)\\1";
        Pattern rgx = Pattern.compile(pattern);

        String line = scanner.nextLine();
        StringBuilder stringBuilder = new StringBuilder();

        while (!line.equals("End")){
            stringBuilder.append(line);
            line = scanner.nextLine();
        }

        Matcher matcher = rgx.matcher(stringBuilder.toString());
        while (matcher.find()){
            System.out.println(matcher.group(2));
        }

    }
}
