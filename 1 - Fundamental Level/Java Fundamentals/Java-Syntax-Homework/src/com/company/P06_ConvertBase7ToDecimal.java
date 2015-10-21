package com.company;

import java.util.Scanner;

/**
 * Created by Killer18ys on 20-10-2015.
 */
public class P06_ConvertBase7ToDecimal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();

        System.out.println(base7ToDecimal(n));
    }

    public static int base7ToDecimal(int number){
        int result = 0;
        int pow = 0;
        int base = 7;

        while (number != 0){
            int currDigit = number % 10;
            number /= 10;

            result += currDigit*Math.pow(base, pow);
            pow++;
        }

        return result;
    }
}
