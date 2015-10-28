package com.company;

import java.util.Scanner;

/**
 * Created by Hacker on 10/27/2015.
 */
public class P02_SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] words = scanner.nextLine().split("\\s+");


        for (int i = 1; i < words.length; i++) {
            String prevWord = words[i - 1];
            String currWord = words[i];

            if (prevWord.equals(currWord)){

                System.out.println(prevWord);

            }else{
                System.out.println(currWord);
            }

        }
    }
}
