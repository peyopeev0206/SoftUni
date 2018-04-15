package BombNumbers;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;


public class main {
    private static int[] numbers;
    private static int bombRange;

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        numbers = Arrays
                .stream(reader.readLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int[] specialNumbers = Arrays
                .stream(reader.readLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();
        int bombNumber = specialNumbers[0];
        bombRange = specialNumbers[1];

        for (int i = 0; i < numbers.length; i++) {
            if (numbers[i] == bombNumber) {
                Explode(i);
            }
        }

        System.out.println(Arrays.stream(numbers).sum());
    }

    private static void Explode(int index) {
        for (int i = 0; i < bombRange; i++) {
            if ((index - 1) - i >= 0) {
                numbers[(index - 1) - i] = 0;
            }
            if ((index + 1) + i < numbers.length) {
                numbers[(index + 1) + i] = 0;
            }
        }

        numbers[index] = 0;
    }
}
