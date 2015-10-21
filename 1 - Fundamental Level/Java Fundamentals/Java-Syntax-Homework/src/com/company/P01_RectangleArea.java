package com.company;

import java.util.Scanner;

/**
 * Created by Killer18ys on 16-10-2015.
 */
public class P01_RectangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double a = scanner.nextDouble();
        double b = scanner.nextDouble();

        double area = a * b;

        System.out.println(area);
    }
}
