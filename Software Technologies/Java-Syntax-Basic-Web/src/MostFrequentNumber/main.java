package MostFrequentNumber;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.HashMap;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        HashMap<Integer, Integer> numbers = new HashMap<>();

        int[] arr = Arrays.stream(reader.readLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();
        int maxValue = 0, element = 0;

        for (int currentNumber : arr) {
            if (!numbers.containsKey(currentNumber)) {
                numbers.put(currentNumber, 1);
            } else {
                numbers.put(currentNumber, numbers.get(currentNumber) + 1);
            }

            int currentLength = numbers.get(currentNumber);
            if (currentLength > maxValue) {
                element = currentNumber;
                maxValue = currentLength;
            }
        }

        System.out.println(element);
    }
}