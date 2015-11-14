package com.company;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by Killer18ys on 31-10-2015.
 */
public class P13_FilterArray {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] inputWords = scanner.nextLine().split("\\s+");
        ArrayList<String> words = new ArrayList<>();

        for (int i = 0; i < inputWords.length; i++) {
            String inputWord = inputWords[i];
            words.add(inputWord);
        }

       List<String> result = words.stream().filter(x -> x.length() > 3).collect(Collectors.toList());

       if (result.isEmpty()){
           System.out.println("(empty)");
       }else{
           result.stream().forEach(s -> System.out.print(s + " "));
       }
    }
}
