package CensorEmailAddress;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String email = reader.readLine();
        StringBuilder text = new StringBuilder(reader.readLine());
        int index;

        while ((index = text.indexOf(email)) >= 0) {
            while (text.charAt(index) != '@') {
                text.replace(index++, index, "*");
            }
        }

        System.out.println(text);
    }
}