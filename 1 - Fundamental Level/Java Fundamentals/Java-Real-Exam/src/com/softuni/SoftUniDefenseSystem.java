package com.softuni;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Killer18ys on 15-11-2015.
 */
public class SoftUniDefenseSystem {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String pattern = "([A-Z][a-z]+).*?([A-Z][a-z]*[A-Z]).*?([0-9]+)L";
        Pattern rgx = Pattern.compile(pattern);

        double softuniLiters = 0.0;

        String line = scanner.nextLine();

        while (!line.equals("OK KoftiShans")){
            Matcher matcher = rgx.matcher(line);

            while (matcher.find()){
                String name = matcher.group(1);
                String alcoholType = matcher.group(2);
                int quantity = Integer.parseInt(matcher.group(3));

                System.out.printf("%s brought %d liters of %s!\n",name, quantity, alcoholType.toLowerCase());
                softuniLiters += quantity * 0.001;
            }

            line = scanner.nextLine();
        }

        System.out.printf("%.3f softuni liters\n", softuniLiters);

    }
}
