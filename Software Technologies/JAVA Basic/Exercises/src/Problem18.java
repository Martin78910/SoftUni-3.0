import java.util.Scanner;

public class Problem18 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String str = scan.nextLine();
        if(str.length()>20){
            System.out.print(str.substring(0, 20));
        }
        if(str.length()<20){
            String padded = str + "********************".substring(str.length());
            System.out.print(padded);
        }
    }
}
