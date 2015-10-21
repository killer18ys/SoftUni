package com.company;

import java.util.Scanner;

/**
 * Created by Killer18ys on 14-10-2015.
 */
public class P08_GetAverage {

    public static void main(String[] args) {

        Scanner console = new Scanner(System.in);

        double a = console.nextDouble();
        double b = console.nextDouble();
        double c = console.nextDouble();


        System.out.printf("Avg: %.2f", (a + b + c)/3.0);

    }
}
