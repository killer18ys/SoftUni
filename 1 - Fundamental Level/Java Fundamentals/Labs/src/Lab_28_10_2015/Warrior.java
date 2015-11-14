package Lab_28_10_2015;

import Lab_28_10_2015.Exceptions.OutOfEnergyException;

/**
 * Created by Hacker on 11/1/2015.
 */
public class Warrior extends GameCharacter {
    public static final int BASE_HEALTH = 5000;
    public static final int BASE_POWER = 200;
    public static final int BASE_ENERGY = 1000;
    public static final int BASE_ATTACK_COST = 150;
    public static final double POWER_SURGE_CHANCE = 0.3;
    public static final double BLOCK_CHANCE = 0.6;

    public Warrior(int health, int power, int energy, int attackCost, String name){
        super(health, power, energy, attackCost, name);
    }

    public Warrior(String name){
        this(BASE_HEALTH, BASE_POWER, BASE_ENERGY, BASE_ATTACK_COST, name);
    }



    @Override
    public void attack(GameCharacter other) throws OutOfEnergyException {
        if (other == this){
            throw new IllegalStateException("Cannot attack itself");
        }

        if (this.getEnergy() < this.getAttackCost()){
            throw new OutOfEnergyException(this.getName() + " is out of energy. Battle over.");
        }

        boolean isPowerSurge = Math.random() < POWER_SURGE_CHANCE;

        if (isPowerSurge){
            System.out.println(this.getName() + " was lucky. Free attack.");
        }else{
            this.setEnergy(this.getEnergy() - this.getAttackCost());
        }

        other.respond(this.getPower());
    }

    @Override
    public void respond(int damage) {
        boolean hasBlocked = Math.random() < BLOCK_CHANCE;

        if (hasBlocked){
            System.out.println("Attack was blocked!");
            damage = damage / 2;
        }

        this.setHealth(this.getHealth() - damage);
        System.out.println(damage + " damage dealt!");
    }
}

