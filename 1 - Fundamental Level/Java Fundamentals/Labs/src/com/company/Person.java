package com.company;

/**
 * Created by Killer18ys on 28-10-2015.
 */
public class Person extends Animal implements Greatable {
    private String name;
    private int age;

    public Person(String name, int age) {
        super(2);
        this.name = name;
        this.age = age;
    }

    public Person(String name){
        this(name, 0);
    }

    public String getName(){
        return name;
    }

    public void setName(String name){
        this.name = name;
    }

    @Override
    public void sayHello() {
        System.out.println("Hello, my name is " + this.name +
                " and my age is " + this.age);
    }

    @Override
    public void walk() {
        System.out.println("Vurvq s " + this.getNumberOfLegs() + " kraka");
    }
}
