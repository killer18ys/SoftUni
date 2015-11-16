package com.softuni;

import java.util.*;

/**
 * Created by Killer18ys on 15-11-2015.
 */
public class LogParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);


        // {"Project": ["ProjectName"], "Type": ["ErrorType"], "Message": ["ErrorMessage"]}

        HashMap<String, HashMap<String, ArrayList<String>>> projectTypeMap = new HashMap<>();

        String line = scanner.nextLine();

        while (!line.equals("END")){
            line = line.replaceAll("[{}\"\\]\\[]", "");
            String[] lineArgs = line.split(",\\s");

            String projectName = lineArgs[0].split(":\\s+")[1];
            String type = lineArgs[1].split(":\\s+")[1];
            String message = lineArgs[2].split(":\\s+")[1];


            if (!projectTypeMap.containsKey(projectName)){
                projectTypeMap.put(projectName, new HashMap<>());
            }

            if (!projectTypeMap.get(projectName).containsKey("Critical")){
                projectTypeMap.get(projectName).put("Critical", new ArrayList<>());
            }
            if (!projectTypeMap.get(projectName).containsKey("Warning")) {
                projectTypeMap.get(projectName).put("Warning", new ArrayList<>());
            }

            projectTypeMap.get(projectName).get(type).add(message);


            line = scanner.nextLine();
        }

//        HashMap<String, Integer> sortedHashMap = new HashMap<>();
//
//        for (Map.Entry<String, HashMap<String, ArrayList<String>>> entry : projectTypeMap.entrySet()){
//            sortedHashMap.put(entry.getKey(), entry.getValue());
//

    }


    public static HashMap<String, Integer> sortingHashMap(HashMap<String, HashMap<String, ArrayList<String>>> map){
        LinkedHashMap<String, Integer> sortedHashMap = new LinkedHashMap<>();

        for (Map.Entry<String, HashMap<String, ArrayList<String>>> entry : map.entrySet()){
            String nameOfProject = entry.getKey();
            int numberOfCriticalError = entry.getValue().get("Critical").size();
            int numberOfWarning = entry.getValue().get("Warning").size();
            int totalErrors = numberOfCriticalError + numberOfWarning;

            sortedHashMap.put(nameOfProject, totalErrors);
        }

        sortedHashMap.entrySet().stream().sorted();


        return sortedHashMap;
    }

}
