package BookLibraryUpgraded;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.Date;

public class main {
    public static void main(String[] args) throws IOException, ParseException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        ArrayList<Book> books = new ArrayList<>();
        SimpleDateFormat dateFormat = new SimpleDateFormat("dd.MM.yyyy");

        int n = Integer.parseInt(reader.readLine());

        for (int i = 0; i < n; i++) {
            String[] data = reader.readLine().split("\\s");
            books.add(new Book(data[0], dateFormat.parse(data[3])));
        }
        Date dateToCompare = dateFormat.parse(reader.readLine());

        books.stream()
                .filter(book -> book.getReleaseDate().compareTo(dateToCompare) > 0)
                .sorted(Comparator.comparing(Book::getReleaseDate).thenComparing(Book::getTitle))
                .forEach(System.out::println);
    }
}

class Book {
    private String title;
    private Date releaseDate;

    Book(String title, Date releaseDate) {
        this.title = title;
        this.releaseDate = releaseDate;
    }

    Date getReleaseDate() {
        return this.releaseDate;
    }

    String getTitle() {
        return this.title;
    }

    @Override
    public String toString() {
        return String.format("%s -> %s", this.title, new SimpleDateFormat("dd.MM.yyyy").format(this.releaseDate));
    }
}