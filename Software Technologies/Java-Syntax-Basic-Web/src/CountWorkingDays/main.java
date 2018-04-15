package CountWorkingDays;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Date;

public class main {
    public static void main(String[] args) throws IOException {
        int[] holidays = {32 + 1, 3 * 32 + 3, 5 * 32 + 1, 5 * 32 + 6, 5 * 32 + 24, 9 * 32 + 6, 9 * 32 + 22, 11 * 32 + 1, 12 * 32 + 24, 12 * 32 + 25, 12 * 32 + 26};
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int[] startDate = Arrays
                .stream(reader.readLine().split("-"))
                .mapToInt(Integer::parseInt).toArray();
        int[] endDate = Arrays
                .stream(reader.readLine().split("-"))
                .mapToInt(Integer::parseInt).toArray();
        Date start = new Date(startDate[2], startDate[1] - 1, startDate[0]);
        Date end = new Date(endDate[2], endDate[1] - 1, endDate[0]);

        int workDays = 0;

        while (start.getTime() <= end.getTime()) {
            if (start.getDay() != 1
                    && start.getDay() != 0
                    && Arrays.stream(holidays).allMatch(x -> x != (start.getMonth() + 1) * 32 + start.getDate())) {
                workDays++;
            }
            start.setTime(start.getTime() + 24 * 60 * 60 * 1000);
        }

        System.out.println(workDays);
    }
}