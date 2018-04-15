package com.softuni.entity;

public class Calculator {
    private String operator;
    private double leftOperand;
    private double rightOperand;

    public Calculator(String leftOperand, String operator, String rightOperand) {
        double num1, num2;
        try {
            num1 = Double.parseDouble(leftOperand);
        } catch (NumberFormatException e) {
            num1 = 0;
        }

        try {
            num2 = Double.parseDouble(rightOperand);
        } catch (NumberFormatException e) {
            num2 = 0;
        }
        this.leftOperand = num1;
        this.operator = operator;
        this.rightOperand = num2;
    }

    public String calculate() {
        String result = "";

        switch (this.operator) {
            case "+":
                result = String.valueOf(sum());
                break;
            case "-":
                result = String.valueOf(subtract());
                break;
            case "*":
                result = String.valueOf(multiply());
                break;
            case "/":
                result = String.valueOf(divide());
                break;
            case "%":
                result = String.valueOf(modulus());
                break;
            case "^":
                result = String.valueOf(pow());
                break;
            case "SQRT":
                result = String.valueOf(sqrt());
                break;
            case "AND":
                result = String.valueOf(and());
                break;
            case "OR":
                result = String.valueOf(or());
                break;
            case "XOR":
                result = String.valueOf(xor());
                break;
            case "NOR":
                result = String.valueOf(nor());
                break;
            case "SL":
                result = String.valueOf(sl());
                break;
            case "SR":
                result = String.valueOf(sr());
                break;
            case "BINARY":
                result = bin();
                break;
            case "HEX":
                result = hex();
                break;
            case "OCT":
                result = oct();
                break;
        }

        return result;
    }

    public double getRightOperand() {
        return rightOperand;
    }

    public double getLeftOperand() {
        return leftOperand;
    }

    public String getOperator() {
        return operator;
    }

    private double sum() {
        return this.leftOperand + this.rightOperand;
    }

    private double subtract() {
        return this.leftOperand - this.rightOperand;
    }

    private double multiply() {
        return this.leftOperand * this.rightOperand;
    }

    private double divide() {
        return this.leftOperand / this.rightOperand;
    }

    private double modulus() {
        return this.leftOperand % this.rightOperand;
    }

    private double pow() {
        return Math.pow(this.leftOperand, this.rightOperand);
    }

    private double sqrt() {
        return Math.sqrt(this.leftOperand);
    }

    private double or() {
        return (int) this.leftOperand | (int) this.rightOperand;
    }

    private double xor() {
        return (int) this.leftOperand ^ (int) this.rightOperand;
    }

    private double and() {
        return (int) this.leftOperand & (int) this.rightOperand;
    }

    private double nor() {
        return ~(int) this.leftOperand;
    }

    private double sl() {
        return (int) this.leftOperand << (int) this.rightOperand;
    }

    private double sr() {
        return (int) this.leftOperand >> (int) this.rightOperand;
    }

    private String bin() {
        return Integer.toBinaryString((int) this.leftOperand);
    }

    private String hex() {
        return Integer.toHexString((int) this.leftOperand).toUpperCase();
    }

    private String oct() {
        return Integer.toOctalString((int) this.leftOperand);
    }
}
