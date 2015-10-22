package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Hacker on 10/22/2015.
 */
public class P11_StartsAndEndsWithCapitalLetter {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();

        Pattern pattern = Pattern.compile("\\b[A-Z][A-Za-z]*[A-Z]\\b");
        Matcher matcher = pattern.matcher(line);

        StringBuilder result = new StringBuilder();

        while (matcher.find()){
            result.append(matcher.group());
            result.append(" ");
        }

        System.out.println(result.toString());

    }
}
