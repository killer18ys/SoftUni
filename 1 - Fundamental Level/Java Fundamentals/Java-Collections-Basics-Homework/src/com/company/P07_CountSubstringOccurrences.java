package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Hacker on 10/30/2015.
 */
public class P07_CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine().toLowerCase();
        String wordToSearch = scanner.nextLine().toLowerCase();



        int count = 0;
        int indexOccurrence = line.indexOf(wordToSearch);

        while (indexOccurrence != -1){
            count++;
            indexOccurrence++;
            indexOccurrence = line.indexOf(wordToSearch, indexOccurrence);
        }

        System.out.println(count);
    }
}
