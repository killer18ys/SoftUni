package com.company;

import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by Killer18ys on 31-10-2015.
 */
public class P09_CombineListsOfLetters {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        ArrayList<Character> firstList = new ArrayList<>();
        ArrayList<Character> secondList = new ArrayList<>();
        ArrayList<Character> result = new ArrayList<>();

        for (char c : scanner.nextLine().replaceAll("\\s+", "").toCharArray()){
            firstList.add(c);
        }

        for (char c : scanner.nextLine().replaceAll("\\s+", "").toCharArray()){
            secondList.add(c);
        }

        secondList.removeAll(firstList);

        result.addAll(firstList);
        result.addAll(secondList);

        System.out.println(result);
    }
}
