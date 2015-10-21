package com.company;

import java.util.Scanner;

/**
 * Created by Killer18ys on 20-10-2015.
 */
public class P05_ConvertDecimalToBase_7 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();

        String base7 = Integer.toString(n, 7);

        System.out.println(base7);
    }
}
