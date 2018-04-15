package ToUpperCase;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String text = reader.readLine();
        int index, endIndex;
        while ((index = text.indexOf("<upcase>")) >= 0) {
            endIndex = text.indexOf("</upcase>");
            String substr = text.substring(index, endIndex + 9);

            text = text.replace(substr, substr.substring(8, substr.length() - 9).toUpperCase());
        }

        System.out.println(text);
    }
}