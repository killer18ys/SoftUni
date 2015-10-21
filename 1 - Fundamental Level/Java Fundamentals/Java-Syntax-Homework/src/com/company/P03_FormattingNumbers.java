package com.company;

import java.util.Scanner;

/**
 * Created by Killer18ys on 17-10-2015.
 */
public class P03_FormattingNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int a = scanner.nextInt();
        double b = scanner.nextDouble();
        double c = scanner.nextDouble();

        String binaryNum = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');

        System.out.printf("|%-10X|%10s|%10.2f|%-10.3f|", a, binaryNum, b, c);


    }
}
