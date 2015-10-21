package com.company;

import java.util.Scanner;

/**
 * Created by Killer18ys on 17-10-2015.
 */
public class P02_TriangleArea {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int x1 = scanner.nextInt();
        int y1 = scanner.nextInt();
        int x2 = scanner.nextInt();
        int y2 = scanner.nextInt();
        int x3 = scanner.nextInt();
        int y3 = scanner.nextInt();

        double area = Math.abs((x1*(y2 - y3) + x2*(y3 - y1) + x3*(y1 - y2))/2.0);

        area = Math.round(area);

        if (area > 0){
            System.out.println(area);
        }
        else{
            System.out.println(0);
        }

    }
}
