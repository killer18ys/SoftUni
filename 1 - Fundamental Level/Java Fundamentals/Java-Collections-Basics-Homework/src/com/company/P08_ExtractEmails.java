package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Killer18ys on 31-10-2015.
 */
public class P08_ExtractEmails {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();

        Pattern pattern = Pattern.compile("[_a-z0-9-]+(\\.[_a-z0-9-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,3})");
        Matcher matcher = pattern.matcher(line);

        while (matcher.find()){
            System.out.println(matcher.group());
        }
    }
}
