package FitString;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        StringBuilder expression = new StringBuilder(reader.readLine());
        int expressionLength = expression.length();

        for (int i = expressionLength; i < 20; i++) {
            expression.append("*");
        }
        System.out.println(expression.substring(0, 20));
    }
}