import java.util.Scanner;

public class Problem3 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        char firstLetter = scan.next().charAt(0);
        char secondLetter = scan.next().charAt(0);
        char thirdLetter = scan.next().charAt(0);
        System.out.printf("%c%c%c",thirdLetter,secondLetter,firstLetter);
    }
}
