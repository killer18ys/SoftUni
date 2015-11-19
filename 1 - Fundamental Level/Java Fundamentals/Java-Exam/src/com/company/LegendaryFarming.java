package com.company;

import java.util.HashMap;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

/**
 * Created by Hacker on 11/14/2015.
 */
public class LegendaryFarming {
    public static final int ITEM_COST = 250;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        HashMap<String, Integer> valuableMaterials = new HashMap<>();
        valuableMaterials.put("shards", 0);
        valuableMaterials.put("fragments", 0);
        valuableMaterials.put("motes", 0);
        TreeMap<String, Integer> junkMaterials = new TreeMap<>();
        String obtainedMaterial = "";

        Pattern rgx = Pattern.compile("([0-9]+)\\s(\\w*)");

        while (true){
            String line = scanner.nextLine();
            Matcher matcher = rgx.matcher(line);

            if(matcher.find()){
                int quantity = Integer.parseInt(matcher.group(1));
                String material = matcher.group(2).toLowerCase();

                if (material.equals("shards") || material.equals("fragments") || material.equals("motes")){
                    valuableMaterials.put(material, valuableMaterials.get(material) + quantity);

                    if (valuableMaterials.get(material) >= ITEM_COST){
                        obtainedMaterial = material;
                        valuableMaterials.put(material, valuableMaterials.get(material) - ITEM_COST);
                        break;
                    }

                }else{
                    if (junkMaterials.get(material) != null){
                        junkMaterials.put(material, junkMaterials.get(material) + quantity);
                    }else{
                        junkMaterials.put(material, quantity);
                    }
                }
            }
        }

        System.out.println();

    }
}
