package com.company;

import java.util.Scanner;

/**
 * Created by Killer18ys on 13-10-2015.
 */


public class P05_PrintACharacterTriangle {
    public static void main(String[] args){

        Scanner console = new Scanner(System.in);

        int n = Integer.parseInt(console.nextLine());

        for (int i = 0; i < n; i++) {
            for (char j = 'a'; j < (char)(97 + i); j++) {
                System.out.print(j + " ");
            }
            System.out.println();
        }

        for (int i = n; i > 0; i--) {
            for (char j = 'a'; j <  (char)(97 + i); j++) {
                System.out.print(j + " ");
            }
            System.out.println();
        }


    }
}
