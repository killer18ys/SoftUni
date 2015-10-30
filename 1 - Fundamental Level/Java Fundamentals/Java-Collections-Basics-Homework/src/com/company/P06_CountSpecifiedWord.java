package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Hacker on 10/30/2015.
 */
public class P06_CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        String wordToSearch = scanner.nextLine();

        Pattern pattern = Pattern.compile(" " + wordToSearch + " ");
        Matcher matcher = pattern.matcher(line);

        int counter = 0;
        while (matcher.find()){
            counter++;
        }

        System.out.println(counter);

    }
}
