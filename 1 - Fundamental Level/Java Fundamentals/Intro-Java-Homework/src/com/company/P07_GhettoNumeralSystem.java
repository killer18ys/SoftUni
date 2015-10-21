package com.company;

import com.sun.xml.internal.fastinfoset.util.CharArray;

import java.util.Scanner;

/**
 * Created by Killer18ys on 14-10-2015.
 */
public class P07_GhettoNumeralSystem {

    public static void  main(String[] args){

        Scanner console = new Scanner(System.in);

        char[] inputNumber = console.nextLine().toCharArray();

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < inputNumber.length; i++) {

            String str = Character.toString(inputNumber[i]);
            int num = Integer.parseInt(str);

            result.append(digitToKeyWord(num));
        }

        System.out.println(result.toString());
    }



    public static String digitToKeyWord(int digit) {

        String keyWord = null;

        switch (digit) {
            case 0:
                keyWord = "Gee";
                break;
            case 1:
                keyWord = "Bro";
                break;
            case 2:
                keyWord = "Zuz";
                break;
            case 3:
                keyWord = "Ma";
                break;
            case 4:
                keyWord = "Duh";
                break;
            case 5:
                keyWord = "Yo";
                break;
            case 6:
                keyWord = "Dis";
                break;
            case 7:
                keyWord = "Hood";
                break;
            case 8:
                keyWord = "Jam";
                break;
            case 9:
                keyWord = "Mack";
                break;
        }

        return keyWord;
    }

}
