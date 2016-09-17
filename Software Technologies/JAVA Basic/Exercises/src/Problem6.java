import java.util.Scanner;
import java.util.SortedSet;
import java.util.TreeSet;

public class Problem6 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String firstLine = scan.nextLine();
        String secondLine = scan.nextLine();

        SortedSet<String> set = new TreeSet<>();
        set.add(firstLine);
        set.add(secondLine);

        set.forEach((line) ->{
            String removedSpace = line.replaceAll("\\s+", "");
            System.out.println(removedSpace);
        });

        if (firstLine.equals(secondLine)){
            String removedSpace = firstLine.replaceAll("\\s+", "");
            System.out.println(removedSpace);
        }
    }
}

