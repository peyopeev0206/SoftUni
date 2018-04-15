package EqualSums;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class main {
    private static int[] numbers;

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        numbers = Arrays.stream(reader.readLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        for (int i = 0; i < numbers.length; i++) {
            if (hasEqualSum(i)) {
                System.out.println(i);
                return;
            }
        }

        System.out.println("no");
    }

    private static boolean hasEqualSum(int index) {
        int leftSum = 0, rightSum = 0;
        for (int i = 0; i < index; i++) {
            leftSum += numbers[i];
        }
        for (int i = index + 1; i < numbers.length; i++) {
            rightSum += numbers[i];
        }

        return leftSum == rightSum;
    }
}