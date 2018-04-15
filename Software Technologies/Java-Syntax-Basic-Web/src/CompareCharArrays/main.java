package CompareCharArrays;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String firstCharArray = String.join("", reader.readLine().split(" "));
        String secondCharArray = String.join("", reader.readLine().split(" "));
        if (firstCharArray.compareTo(secondCharArray) < 0) {
            System.out.println(firstCharArray);
            System.out.println(secondCharArray);
        } else {
            System.out.println(secondCharArray);
            System.out.println(firstCharArray);
        }
    }
}