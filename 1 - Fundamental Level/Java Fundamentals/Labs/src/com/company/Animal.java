package com.company;

/**
 * Created by Killer18ys on 28-10-2015.
 */
public abstract class Animal {
    private int numberOfLegs;

    public Animal(int numberOfLegs) {
        this.setNumberOfLegs(numberOfLegs);
    }

    public int getNumberOfLegs() {
        return numberOfLegs;
    }

    public void walk(){
        System.out.println("Moving " + this.numberOfLegs + " legs");
    }

    public void setNumberOfLegs(int numberOfLegs) {
        this.numberOfLegs = numberOfLegs;
    }
}
