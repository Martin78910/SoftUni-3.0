import java.util.Scanner;

public class Problem2 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String number = scan.nextLine();
        Boolean istrue = Boolean.parseBoolean(number);
        if (istrue == true){
            System.out.print("Yes");
        }
        else{
            System.out.print("No");
        }

    }
}
