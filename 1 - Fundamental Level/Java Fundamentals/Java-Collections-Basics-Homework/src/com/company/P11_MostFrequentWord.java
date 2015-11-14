package com.company;

import java.util.Collections;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

/**
 * Created by Killer18ys on 31-10-2015.
 */
public class P11_MostFrequentWord {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine().toLowerCase();
        String[] words = line.split("\\W+");

        TreeMap<String, Integer> wordCountMap = new TreeMap<>();

        for (int i = 0; i < words.length; i++) {
            String word = words[i];
            int count;

            if (wordCountMap.containsKey(word)){
                count = wordCountMap.get(word);
                wordCountMap.put(word, count + 1);
            }else{
                wordCountMap.put(word, 1);
            }
        }

        for(Map.Entry<String, Integer> entry : wordCountMap.entrySet()){
            String key = entry.getKey();
            int value = entry.getValue();
            int maxValue = Collections.max(wordCountMap.values());

            if (value == maxValue){
                System.out.println(key + " -> " + value + " times");
            }
        }
    }
}
