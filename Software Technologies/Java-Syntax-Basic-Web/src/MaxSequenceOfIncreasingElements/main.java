package MaxSequenceOfIncreasingElements;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int[] arr = Arrays.stream(reader.readLine().split(" "))
                .filter(p -> !p.equals(""))
                .mapToInt(Integer::parseInt)
                .toArray();

        int maxLength = -1, maxLengthStart = 0;
        int currentLength = 1, currentElement, lastElement = arr[0], currentStart = 0;

        for (int i = 1; i < arr.length; i++) {
            currentElement = arr[i];

            if (currentElement > lastElement) {
                currentLength++;
            } else {
                if (currentLength > maxLength) {
                    maxLengthStart = currentStart;
                    maxLength = currentLength;
                }
                currentLength = 1;
                currentStart = i;
            }

            lastElement = currentElement;
        }
        if (currentLength > maxLength) {
            maxLengthStart = currentStart;
            maxLength = currentLength;
        }

        for (int i = maxLengthStart; i < maxLength + maxLengthStart; i++) {
            System.out.printf("%d ", arr[i]);
        }
    }
}