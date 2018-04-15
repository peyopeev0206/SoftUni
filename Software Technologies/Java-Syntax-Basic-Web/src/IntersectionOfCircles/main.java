package IntersectionOfCircles;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Circle firstCircle = Circle.parseCircle(reader.readLine());
        Circle secondCircle = Circle.parseCircle(reader.readLine());

        System.out.println(firstCircle.intersect(secondCircle) ? "Yes" : "No");
    }
}

class Circle {
    private int X;
    private int Y;
    private int R;

    private Circle(int x, int y, int radius) {
        this.X = x;
        this.Y = y;
        this.R = radius;
    }

    static Circle parseCircle(String input) {
        int[] data = Arrays.stream(input.split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();
        return new Circle(data[0], data[1], data[2]);
    }

    boolean intersect(Circle circle) {
        double distance = Math.sqrt(Math.pow(this.X - circle.X, 2) + Math.pow(this.Y - circle.Y, 2));

        return distance <= this.R + circle.R;
    }
}