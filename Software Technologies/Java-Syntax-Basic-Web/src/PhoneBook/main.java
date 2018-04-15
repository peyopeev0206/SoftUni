package PhoneBook;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        HashMap<String, String> phoneBook = new HashMap<>();
        String command;

        while (!(command = reader.readLine()).equals("END")) {
            String[] data = command.split("\\s+");
            if (data[0].equals("A")) {
                phoneBook.put(data[1], data[2]);
            } else {
                String phoneNumber = phoneBook.get(data[1]);
                if (phoneNumber == null) {
                    System.out.println(String.format("Contact %s does not exist.", data[1]));
                } else {
                    System.out.println(String.format("%s -> %s", data[1], phoneNumber));
                }
            }
        }
    }
}