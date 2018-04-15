package BookLibrary;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;


public class main {
    public static void main(String[] args) throws IOException {
    BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
    int n = Integer.parseInt(reader.readLine());

    HashMap<String, Double> authors = new HashMap<>(n + 1);

    for (int i = 0; i < n; i++) {
        String[] data = reader.readLine().split("\\s+");
        String name = data[1];
        Double price = Double.parseDouble(data[5]);
        Double beforePrice = authors.get(name);

        authors.put(name, beforePrice == null ? price : beforePrice + price);
    }

    authors.entrySet().stream().sorted((o1, o2) -> {
        int priceComparison = Double.compare(o2.getValue(), o1.getValue());
        return priceComparison == 0 ? o1.getKey().compareTo(o2.getKey()) : priceComparison;
    }).forEach(author -> System.out.println(String.format("%s -> %.2f", author.getKey(), author.getValue())));
}
}
