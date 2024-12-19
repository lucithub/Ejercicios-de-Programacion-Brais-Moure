public class Main {
    public static void main(String[] args) {
        int counter = 2; // al imprimir los 2 primeros el counter debe empezar en el 2
        long numberOne = 0;
        long numberTwo = 1;
        long accumulator = 0;
        System.out.println(numberOne);
        System.out.println(numberTwo);
        while (counter < 50){
            accumulator = numberOne + numberTwo;
            numberOne = numberTwo;
            numberTwo = accumulator;
            counter++;
            System.out.println(accumulator);
        }
    }
}