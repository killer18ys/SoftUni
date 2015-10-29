package Lab_28_10_2015;

import Lab_28_10_2015.Exeptions.OutOfEnrgyExeption;

/**
 * Created by Killer18ys on 28-10-2015.
 */
public class Mage extends GameCharacter {
    private static final int BASE_HEALTH = 5000;
    private static final int BASE_POWER = 150;
    private static final int BASE_ENERGY = 2500;
    private static final int BASE_ATTACK_COST = 250;


    public Mage(int health, int power, int energy, int attackCost, String name){
        super(health, power, energy, attackCost, name);
    }

    public Mage(String name){
        this(BASE_HEALTH, BASE_POWER, BASE_ENERGY, BASE_ATTACK_COST , name);
    }

    @Override
    public void attack(GameCharacter other) throws OutOfEnrgyExeption {

    }
}
