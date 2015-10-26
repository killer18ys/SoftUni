package com.company;

import java.io.*;
import java.util.ArrayList;

/**
 * Created by Killer18ys on 26-10-2015.
 */
public class P05_SaveAnArrayListOfDoubles {
    public static final String outputFile = "resources\\doubles.list";
    public static final String inputFile = "resources\\doubles.list";

    public static void main(String[] args) {

        ArrayList<Double> arrayListOfDoubles = new ArrayList<>();

        arrayListOfDoubles.add(3.14);
        arrayListOfDoubles.add(7.33);
        arrayListOfDoubles.add(33.77);
        arrayListOfDoubles.add(77.33);
        arrayListOfDoubles.add(37.73);

        try {
            ObjectOutputStream outputStream = new ObjectOutputStream(new FileOutputStream(outputFile));
            outputStream.writeObject(arrayListOfDoubles);


            ObjectInputStream inputStream = new ObjectInputStream(new FileInputStream(inputFile));

            System.out.println(inputStream.readObject());

        }catch (Exception e){
            System.out.println(e);
        }
    }
}
