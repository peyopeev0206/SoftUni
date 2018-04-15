package IndexOfLetters.main;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        byte[] word = reader.readLine().getBytes("US-ASCII");

        for (byte symbol : word) {
            System.out.printf("%s -> %d%n", (char) symbol, symbol - 97);
        }
    }
}