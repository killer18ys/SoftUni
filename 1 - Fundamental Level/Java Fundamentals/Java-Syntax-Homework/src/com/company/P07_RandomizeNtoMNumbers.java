package com.company;

import java.util.*;

/**
 * Created by Killer18ys on 20-10-2015.
 */
public class P07_RandomizeNtoMNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        int m = scanner.nextInt();

        int start = Math.min(n, m);
        int end = Math.max(n, m);

        ArrayList<Integer> numbers = new ArrayList<>();

        for (int i = start; i <= end; i++) {
            numbers.add(i);

        }

        long seed = System.nanoTime();
        Collections.shuffle(numbers, new Random(seed));

        System.out.println(numbers);


    }
}
