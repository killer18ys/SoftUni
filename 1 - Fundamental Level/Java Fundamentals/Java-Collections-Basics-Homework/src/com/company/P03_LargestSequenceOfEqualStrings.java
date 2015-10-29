package com.company;

import java.util.Scanner;

/**
 * Created by Killer18ys on 28-10-2015.
 */
public class P03_LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] words = scanner.nextLine().split("\\s+");
        int tempCounter = 0;
        int counter = 0;
        int wordPosition = 0;

        for (int i = 1; i < words.length; i++) {
            if (words[i - 1].equals(words[i])) {
                tempCounter++;
            }else {
                tempCounter = 1;
            }

            if(tempCounter > counter) {
                counter = tempCounter;
                wordPosition = i;
            }
        }

        String result = new String(new char[counter]).replace("\0", words[wordPosition]+ " ");

        System.out.println(result);

    }
}
