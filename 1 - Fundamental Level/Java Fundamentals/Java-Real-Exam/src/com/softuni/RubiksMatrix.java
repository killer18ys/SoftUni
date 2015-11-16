package com.softuni;

import java.util.Scanner;
import java.util.TreeMap;

/**
 * Created by Killer18ys on 15-11-2015.
 */
public class RubiksMatrix {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] dimensions = scanner.nextLine().split("\\s+");
        int rows = Integer.parseInt(dimensions[0]);
        int cols = Integer.parseInt(dimensions[1]);

        int[][] matrix = new int[rows][cols];
        int counter = 1;

        TreeMap<Integer, int[]> positionTracker = new TreeMap<>();

        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                matrix[row][col] = counter;
                counter++;
            }
        }

        int commandCount = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < commandCount; i++) {
            String line = scanner.nextLine();
            String[] lineArgs = line.split("\\s+");
            int rowOrColPosition = Integer.parseInt(lineArgs[0]);
            String direction = lineArgs[1];
            int moves = Integer.parseInt(lineArgs[2]);

                if (direction.equals("up")){
                    matrix = rotateMatrixColUp(matrix, rowOrColPosition, moves);
                }

                if (direction.equals("down")){
                    matrix = rotateMatrixColDown(matrix, rowOrColPosition, moves);
                }

                if (direction.equals("left")){
                    matrix = rotateMatrixRowToLeft(matrix, rowOrColPosition, moves);
                }

                if (direction.equals("right")){
                    matrix = rotateMatrixRowToRight(matrix, rowOrColPosition, moves);
                }
        }



        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                positionTracker.put(matrix[row][col], new int[] {row, col});
            }
        }

        int currElement = 1;
        int tempValue;
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {

                if (matrix[row][col] != currElement){
                   int tempRow =  positionTracker.get(currElement)[0];
                   int tempCol =  positionTracker.get(currElement)[1];

                    tempValue = matrix[row][col];
                    matrix[row][col] = matrix[tempRow][tempCol];
                    matrix[tempRow][tempCol] = tempValue;

                    positionTracker.put(matrix[row][col], new int[] {row, col});
                    positionTracker.put(matrix[tempRow][tempCol], new int[] {tempRow, tempCol});

                    System.out.printf("Swap (%d, %d) with (%d, %d)\n" , row, col, tempRow, tempCol );
                }else{
                    System.out.println("No swap required");
                }

                currElement++;
            }
        }
    }


    public static void printMatrix(int[][] matrix){
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                System.out.print(matrix[row][col] + " ");
            }
            System.out.println();
        }
    }

    public static int[][] rotateMatrixRowToRight(int[][] matrix, int rowToRotate, int moves){
        int[] unOrderedArr = matrix[rowToRotate];
        int orderToRotate = moves % matrix[rowToRotate].length;

        for (int i = 0; i < orderToRotate; i++) {
            for (int j = unOrderedArr.length - 1; j > 0; j--) {
                int temp = unOrderedArr[j];
                unOrderedArr[j] = unOrderedArr[j - 1];
                unOrderedArr[j - 1] = temp;
            }
        }

        matrix[rowToRotate] = unOrderedArr;

        return matrix;
    }

    public static int[][] rotateMatrixRowToLeft(int[][] matrix, int rowToRotate, int moves){
        int[] unOrderedArr = matrix[rowToRotate];
        int orderToRotate = moves % matrix[rowToRotate].length;

        for (int i = 0; i < orderToRotate; i++) {
            for (int j = 0; j < unOrderedArr.length - 1; j++) {
                int temp = unOrderedArr[j];
                unOrderedArr[j] = unOrderedArr[j + 1];
                unOrderedArr[j + 1] = temp;
            }
        }

        matrix[rowToRotate] = unOrderedArr;

        return matrix;
    }

    public static int[][] rotateMatrixColUp(int[][] matrix, int colToRotate, int moves){
        int[] unOrderedArr = new int[matrix.length];
        int orderToRotate = moves % matrix.length;

        int counter = 0;

        for (int row = 0; row < matrix.length; row++) {
            unOrderedArr[counter] =  matrix[row][colToRotate];
            counter++;
        }

        for (int i = 0; i < orderToRotate; i++) {
            for (int j = 0; j < unOrderedArr.length - 1; j++) {
                int temp = unOrderedArr[j];
                unOrderedArr[j] = unOrderedArr[j + 1];
                unOrderedArr[j + 1] = temp;
            }
        }

        counter = 0;
        for (int row = 0; row < matrix.length; row++) {
            matrix[row][colToRotate] = unOrderedArr[counter];
            counter++;
        }


        return matrix;
    }

    public static int[][] rotateMatrixColDown(int[][] matrix, int colToRotate, int moves){
        int[] unOrderedArr = new int[matrix.length];
        int orderToRotate = moves % matrix.length;

        int counter = 0;

        for (int row = 0; row < matrix.length; row++) {
            unOrderedArr[counter] =  matrix[row][colToRotate];
            counter++;
        }

        for (int i = 0; i < orderToRotate; i++) {
            for (int j = unOrderedArr.length - 1; j > 0 ; j--) {
                int temp = unOrderedArr[j];
                unOrderedArr[j] = unOrderedArr[j - 1];
                unOrderedArr[j - 1] = temp;
            }
        }

        counter = 0;
        for (int row = 0; row < matrix.length; row++) {
            matrix[row][colToRotate] = unOrderedArr[counter];
            counter++;
        }


        return matrix;
    }
}

