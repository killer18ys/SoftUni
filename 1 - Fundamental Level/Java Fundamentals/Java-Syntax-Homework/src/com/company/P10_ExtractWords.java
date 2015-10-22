package com.company;

import jdk.nashorn.internal.runtime.regexp.joni.Regex;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Hacker on 10/22/2015.
 */
public class P10_ExtractWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();

        Pattern pattern = Pattern.compile("[A-Za-z]{2,}");
        Matcher matcher = pattern.matcher(line);

        StringBuilder result = new StringBuilder();

        while (matcher.find()){
            result.append(matcher.group());
            result.append(" ");
        }

        System.out.printf(result.toString());

    }
}
