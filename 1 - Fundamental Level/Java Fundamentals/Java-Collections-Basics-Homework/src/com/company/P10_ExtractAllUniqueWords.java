package com.company;

import java.util.Scanner;
import java.util.TreeSet;

/**
 * Created by Killer18ys on 31-10-2015.
 */
public class P10_ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine().toLowerCase();
        String[] words = line.split("\\W+");

        TreeSet<String> uniqueWords = new TreeSet<>();

        for (int i = 0; i < words.length; i++) {
            String word = words[i];
            uniqueWords.add(word);
        }

        System.out.println(uniqueWords);

    }
}
