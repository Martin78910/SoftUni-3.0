import java.util.Scanner;

public class Problem19 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String email = scan.nextLine();
        String text = scan.nextLine();
        String[]splitedEmail = email.split("@");
        StringBuilder list = new StringBuilder();
        for (int i =0;i<splitedEmail[0].length();i++){
            list.append("*");
        }
        String replacement =list.toString()+"@" + splitedEmail[1];
        if (text.contains(email)){
            text = text.replace(email,replacement);
        }
        System.out.println(text);
    }
}
