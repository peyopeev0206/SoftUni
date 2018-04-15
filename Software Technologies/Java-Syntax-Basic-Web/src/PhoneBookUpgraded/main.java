package PhoneBookUpgraded;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.TreeMap;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        TreeMap<String, String> phoneBook = new TreeMap<>();
        String command;

        while (!(command = reader.readLine()).equals("END")) {
            String[] data = command.split("\\s+");
            switch (data[0]) {
                case "A":
                    phoneBook.put(data[1], data[2]);
                    break;
                case "S":
                    String phoneNumber = phoneBook.get(data[1]);
                    if (phoneNumber == null) {
                        System.out.println(String.format("Contact %s does not exist.", data[1]));
                    } else {
                        System.out.println(String.format("%s -> %s", data[1], phoneNumber));
                    }
                    break;
                default:
                    for (String person : phoneBook.keySet()) {
                        System.out.println(String.format("%s -> %s", person, phoneBook.get(person)));
                    }
                    break;
            }
        }
    }
}