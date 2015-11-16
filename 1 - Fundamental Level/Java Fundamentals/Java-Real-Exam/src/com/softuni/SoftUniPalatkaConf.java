package com.softuni;

import java.util.Scanner;

public class SoftUniPalatkaConf {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int people = Integer.parseInt(scanner.nextLine());
        int n = Integer.parseInt(scanner.nextLine());

        int beds = 0;
        int meals = 0;

        for (int i = 0; i < n; i++) {
            String[] lineArgs = scanner.nextLine().split("\\s+");

            String item = lineArgs[0];
            int quantity = Integer.parseInt(lineArgs[1]);
            String type = lineArgs[2];

            if (!item.equals("food")){
                beds += quantity * typeToNumber(type);
            }else{
                meals += quantity * typeToNumber(type);
            }
        }


        if (beds >= people){
            System.out.printf("Everyone is happy and sleeping well. Beds left: %d\n", beds - people);
        }else{
            System.out.printf("Some people are freezing cold. Beds needed: %d\n", Math.abs(beds - people));
        }

        if (meals >= people){
            System.out.printf("Nobody left hungry. Meals left: %d\n", meals - people);
        }else {
            System.out.printf("People are starving. Meals needed: %d\n", Math.abs(meals - people));
        }
    }

    public static int typeToNumber(String type){

        if (type.equals("firstClass") || type.equals("triple")){
            return 3;
        }

        if (type.equals("double") || type.equals("normal") || type.equals("musaka")){
            return 2;
        }

        if (type.equals("single")){
            return 1;
        }

        if (type.equals("zakuska")){
            return 0;
        }

        return -1;
    }

}
