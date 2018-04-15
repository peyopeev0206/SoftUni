package AverageGrades;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;
public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        ArrayList<Student> students = new ArrayList<>();

        int n = Integer.parseInt(reader.readLine());

        for (int i = 0; i < n; i++) {
            String[] data = reader.readLine().split(" ");

            double gradesSum = 0.0;
            for (int j = 1; j < data.length; j++) {
                gradesSum += Double.parseDouble(data[j]);
            }
            double averageGrade = gradesSum / (data.length - 1);
            if (averageGrade >= 5) {
                students.add(new Student(data[0], averageGrade));
            }
        }

        Collections.sort(students);
        for (Student student : students) {
            System.out.println(student);
        }
    }
    static class Student implements Comparable<Student> {
        private String Name;
        private Double AverageGrade;

        Student(String name, double averageGrade) {
            this.Name = name;
            this.AverageGrade = averageGrade;
        }

        @Override
        public String toString() {
            return String.format("%s -> %.2f", this.Name, this.AverageGrade);
        }

        @Override
        public int compareTo(Student student) {
            int nameComparison = this.Name.compareTo(student.Name);
            if (nameComparison == 0) {
                return student.AverageGrade.compareTo(this.AverageGrade);
            }

            return nameComparison;
        }
    }
}
