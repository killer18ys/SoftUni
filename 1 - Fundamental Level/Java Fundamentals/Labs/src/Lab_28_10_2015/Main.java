package Lab_28_10_2015;

import Lab_28_10_2015.Exceptions.OutOfEnergyException;

/**
 * Created by Killer18ys on 28-10-2015.
 */
public class Main {
    public static void main(String[] args) {
        GameCharacter luboTheMage = new Mage("Lubo");
        GameCharacter danchoTheWarrior = new Warrior("Dancho");

        int roundCounter = 0;
        while (true){
            System.out.println("Round: " + ++roundCounter);
            try{

                if (roundCounter % 2 == 0){
                    luboTheMage.attack(danchoTheWarrior);
                    danchoTheWarrior.attack(luboTheMage);
                }else {
                    danchoTheWarrior.attack(luboTheMage);
                    luboTheMage.attack(danchoTheWarrior);
                }

            }catch (OutOfEnergyException e){
                System.out.println(e.getMessage());
                break;
            }
            System.out.println();
        }

        if (luboTheMage.getHealth() < danchoTheWarrior.getHealth()){
            System.out.println(danchoTheWarrior.getName() + " the warrior is the winner!");

            System.out.println("Stats: ");
            System.out.println(danchoTheWarrior.getName() + "'s health is " + danchoTheWarrior.getHealth());
            System.out.println(luboTheMage.getName() + "'s health is " + luboTheMage.getHealth());

        }else if (luboTheMage.getHealth() > danchoTheWarrior.getHealth()){
            System.out.println(luboTheMage.getName() + " the mage is the winner!");

            System.out.println("Stats: ");
            System.out.println(luboTheMage.getName() + "'s health is " + luboTheMage.getHealth());
            System.out.println(danchoTheWarrior.getName() + "'s health is " + danchoTheWarrior.getHealth());

        }else{
            System.out.println("There is no winner");
        }

    }
}
