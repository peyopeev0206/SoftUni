package ReverseString;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String word = reader.readLine();

        for (int i = word.length() - 1; i >= 0; i--) {
            System.out.printf("%c", word.charAt(i));
        }
        System.out.println();
    }
}