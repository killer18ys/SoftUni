package com.company;

import java.util.DoubleSummaryStatistics;
import java.util.Scanner;

/**
 * Created by Killer18ys on 18-10-2015.
 */
public class P04_CalculateExpression {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double a = Double.parseDouble(scanner.next());
        double b = Double.parseDouble(scanner.next());
        double c = Double.parseDouble(scanner.next());




        double formulaeOne = ((a*a + b*b)/(a*a - b*b));
                formulaeOne = Math.pow(formulaeOne, (a+b+c)/(Math.sqrt(c)));

        double formulaeTwo = (a*a + b*b - c*c*c);
                formulaeTwo = Math.pow(formulaeTwo, a-b);

        double diff = Math.abs(((a + b + c) / 3) - (formulaeOne + formulaeTwo) / 2);

        System.out.printf("F1 result: %.2f; F2 result: %.2f; Diff: %.2f", formulaeOne, formulaeTwo, diff);
    }
}
