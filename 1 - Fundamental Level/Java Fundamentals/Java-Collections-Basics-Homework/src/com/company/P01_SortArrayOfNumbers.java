package com.company;

import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by Hacker on 10/27/2015.
 */
public class P01_SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        int[] numbers = new int[n];

        String[] inputNumbers = scanner.nextLine().split("\\s+");

        for (int i = 0; i < inputNumbers.length; i++) {
            String inputNumber = inputNumbers[i];
            numbers[i] = Integer.parseInt(inputNumber);
        }

        Arrays.sort(numbers);

        for (int i = 0; i < numbers.length; i++) {
            System.out.print(numbers[i] + " ");
            
        }
    }
}
