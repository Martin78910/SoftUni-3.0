import java.util.Scanner;

public class Problem5{
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int number = input.nextInt();

        String baseHexadecimal = Integer.toString(number, 16);
        String basebinary = Integer.toString(number, 2);
        System.out.println(baseHexadecimal.toUpperCase());
        System.out.println(basebinary.toUpperCase());
    }
}
