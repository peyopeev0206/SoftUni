package VowelOrDigit;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.regex.Pattern;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        Pattern digit = Pattern.compile("\\d");
        Pattern vowel = Pattern.compile("[aieuo]");

        String symbol = reader.readLine();
        if (digit.matcher(symbol).find()){
            System.out.println("digit");
        }
        else if (vowel.matcher(symbol).find()){
            System.out.println("vowel");
        }
        else{
            System.out.println("other");
        }
    }
}