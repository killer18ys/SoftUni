package com.company;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class TinySporebat {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String pattern = "(.+)([0-9]+)";
        Pattern rgx = Pattern.compile(pattern);
        Matcher matcher;

        int health = 5800;
        int collectedGlowcaps = 0;
        boolean isDead = false;
        int glowcaps = 0;
        int tinySporebatCost = 30;
        int lifebloom = 200;

        String line = scanner.nextLine();

        while (!line.equals("Sporeggar")){
            matcher = rgx.matcher(line);

            if (matcher.find()){
                char[] enemies = matcher.group(1).toCharArray();
                glowcaps = Integer.parseInt(matcher.group(2));

                for(char enemy : enemies){
                    if (enemy != 'L'){
                        health -= (int)enemy;
                    }else {
                        health += lifebloom;
                    }
                }
            }

            if (health > 0){
                collectedGlowcaps += glowcaps;
            }else{
                isDead = true;
            }

            if (isDead){
                System.out.printf("Died. Glowcaps: %d\n", collectedGlowcaps);
                break;
            }

            line = scanner.nextLine();
        }

        if (!isDead){
            System.out.printf("Health left: %d\n", health);

            if (collectedGlowcaps >= tinySporebatCost){
                System.out.printf("Bought the sporebat. Glowcaps left: %d\n", collectedGlowcaps - tinySporebatCost);
            }else{
                System.out.printf("Safe in Sporeggar, but another %d Glowcaps needed.\n", tinySporebatCost - collectedGlowcaps);
            }

        }

    }
}
