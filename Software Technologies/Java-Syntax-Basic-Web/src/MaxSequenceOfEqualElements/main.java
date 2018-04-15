package MaxSequenceOfEqualElements;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int[] arr = Arrays.stream(reader.readLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int maxLength = -1, maxLengthElement = 0;
        int currentLength = 1, currentElement, lastElement = arr[0];

        for (int i = 1; i < arr.length; i++) {
            currentElement = arr[i];

            if (currentElement == lastElement) {
                currentLength++;
            } else {
                if (currentLength > maxLength) {
                    maxLengthElement = lastElement;
                    maxLength = currentLength;
                }
                currentLength = 1;
            }

            lastElement = currentElement;
        }
        if (currentLength > maxLength) {
            maxLengthElement = lastElement;
            maxLength = currentLength;
        }

        for (int i = 0; i < maxLength; i++) {
            System.out.printf("%d ", maxLengthElement);
        }
    }
}