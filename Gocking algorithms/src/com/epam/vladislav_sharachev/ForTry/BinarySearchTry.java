package com.epam.vladislav_sharachev.ForTry;

public class BinarySearchTry {

    private static Integer binarySearch(int[] list, int item) {
        int low = 0;
        int high = list.length - 1;
        while (low <= high) {
            int mid = (low + high) / 2;
            int guess = list[mid];
            if (guess == item) {
                return mid;
            }
            if (guess > item) {
                high = mid - 1;
            } else {
                low = mid + 1;
            }
        }
        return null;
    }

    public static void main(String[] args) {
        int[] list = {1, 2, 3, 4, 5, 6, 7, 8, 9};

        System.out.println(binarySearch(list, 4));
        System.out.println(list[4]);
    }
}
