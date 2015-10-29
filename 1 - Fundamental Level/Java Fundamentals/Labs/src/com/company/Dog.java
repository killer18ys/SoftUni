package com.company;

/**
 * Created by Killer18ys on 28-10-2015.
 */
public class Dog extends Animal implements  Greatable{

    public Dog() {
        super(4);
    }

    @Override
    public void sayHello() {
        System.out.println("Bau-Bau");
    }
}
