package com.company;

import java.util.Scanner;

/**
 * Created by Hacker on 10/22/2015.
 */
public class P12_CharacterMultiplier {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String stringOne = scanner.next();
        String stringTwo = scanner.next();
        int totalSum = 0;

        int stringOneLength = stringOne.length();
        int stringTwoLength = stringTwo.length();
        int stringOneCharValue, stringTwoCharValue;

        for (int i = 0; i < stringOne.length(); i++) {

            stringOneCharValue = stringOne.charAt(i);

            stringTwoCharValue = stringTwo.charAt(i);

            totalSum += stringOneCharValue * stringTwoCharValue;
        }


        System.out.println(totalSum);

    }
}
