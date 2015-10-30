package com.company;

import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by Hacker on 10/29/2015.
 */
public class P04_LongestIncreasingSequence {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String[] line = scanner.nextLine().split("\\s+");
        int[] numbers = new int[line.length];
        int tempCounter = 0;
        int counter = 0;
        int tempBeginSequenceIndex = 0;
        int beginSequenceIndex = 0;

        for (int i = 0; i < line.length; i++) {
            numbers[i] = Integer.parseInt(line[i]);
        }

        System.out.print(numbers[0]);
        for (int i = 1; i < numbers.length; i++) {
            if (numbers[i - 1] < numbers[i]){
                System.out.print(" " + numbers[i]);
                tempCounter++;
            }else {
                System.out.println();
                System.out.print(numbers[i]);
                tempCounter = 0;
                tempBeginSequenceIndex = i;
            }

            if (tempCounter > counter){
                counter = tempCounter;
                beginSequenceIndex = tempBeginSequenceIndex;
            }
        }


        System.out.println();
        System.out.print("Longest: ");
        for (int i = beginSequenceIndex; i <= beginSequenceIndex + counter; i++) {
            System.out.print(" " + numbers[i]);
        }

    }
}
