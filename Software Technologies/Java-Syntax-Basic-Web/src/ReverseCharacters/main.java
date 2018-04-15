package ReverseCharacters;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < 3; i++) {
            result.insert(0, reader.readLine());
        }

        System.out.println(result);
    }
}