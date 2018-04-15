package BooleanVariable;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        boolean bool = Boolean.valueOf(reader.readLine());

        System.out.println(bool ? "Yes" : "No");
    }
}