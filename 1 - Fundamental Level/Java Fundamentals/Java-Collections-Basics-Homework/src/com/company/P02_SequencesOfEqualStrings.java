package com.company;

import java.util.Scanner;

/**
 * Created by Hacker on 10/27/2015.
 */
public class P02_SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] words = scanner.nextLine().split("\\s+");


        System.out.print(words[0]);
        for (int i = 1; i < words.length; i++) {
            if (words[i].equals(words[i - 1])){
                System.out.print(" " + words[i]);
            }else{
                System.out.println();
                System.out.print(words[i]);
            }
        }
    }
}
