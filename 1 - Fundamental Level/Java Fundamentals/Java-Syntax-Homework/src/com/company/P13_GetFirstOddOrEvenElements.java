package com.company;

import java.util.ArrayList;
import java.util.Scanner;

/**
 * Created by Hacker on 10/22/2015.
 */
public class P13_GetFirstOddOrEvenElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] line = scanner.nextLine().split(" ");

        String[] commands = scanner.nextLine().split(" ");
        int n = Integer.parseInt(commands[1]);
        String oddOrEven = commands[2];

        ArrayList<Integer> numbers = new ArrayList<>();

        for (int i = 0; i < line.length; i++) {
            numbers.add(Integer.parseInt(line[i]));
        }

      if (oddOrEven == "Even") {
          numbers.stream().filter(x -> x % 2 == 0).limit(n).forEach(System.out::print);
      } else{
          numbers.stream().filter(x -> x % 2 != 0).limit(n).forEach(System.out::print);
      }


    }
}
