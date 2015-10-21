package com.company;

import java.util.Scanner;

/**
 * Created by Killer18ys on 14-10-2015.
 */
public class P06_SumNumbersFrom1ToN {

  public static void main(String[] args){
      Scanner console = new Scanner(System.in);

      int number = Integer.parseInt(console.nextLine());
      int result = 0;

      for(int i = 1; i <= number ; i++) {
          result += i;
      }

      System.out.println(result);
  }


}
