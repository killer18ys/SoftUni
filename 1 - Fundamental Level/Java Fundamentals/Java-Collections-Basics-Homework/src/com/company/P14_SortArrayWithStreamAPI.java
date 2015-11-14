package com.company;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 * Created by Killer18ys on 01-11-2015.
 */
public class P14_SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] line = scanner.nextLine().split("\\s+");
        String sortOrder = scanner.nextLine();
        ArrayList<Integer> numbers = new ArrayList<>();

        for (int i = 0; i < line.length; i++) {
            String s = line[i];
            numbers.add(Integer.parseInt(s));
        }

        if (sortOrder.equals("Ascending")){
            numbers = numbers.stream().sorted().collect(Collectors.toCollection(ArrayList::new));
        }else if(sortOrder.equals("Descending")){
            numbers = numbers.stream().sorted(Collections.reverseOrder()).collect(Collectors.toCollection(ArrayList::new));
        }

        System.out.println(numbers);

    }
}
