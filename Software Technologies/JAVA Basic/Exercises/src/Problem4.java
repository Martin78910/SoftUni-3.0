import java.util.Scanner;

public class Problem4 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        char ch = scan.next().charAt(0);
        if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u'|| ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U' ){
            System.out.println("vowel");
        }


        else if (ch=='0' || ch=='1' || ch=='2' || ch=='3' || ch=='4' || ch=='5' || ch=='6'|| ch=='7'|| ch=='8'|| ch=='9'){
            System.out.println("digit");
        }
        else{
            System.out.println("other");
        }

    }
}
