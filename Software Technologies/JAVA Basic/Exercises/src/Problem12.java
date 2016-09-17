import java.util.Arrays;
import java.util.Scanner;

public class Problem12 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        Integer[] sequence = Arrays.stream(scan.nextLine().split("\\s+")).map(Integer::parseInt).toArray(Integer[]::new);

        for (int row = 'a'; row < 'a' + sequence[0]; row++) {
            for (int col = row; col < row + sequence[1]; col++) {
                System.out.printf("%s%s%s ", (char) row, (char) col, (char) row);
            }

            System.out.println();
        }
    }
}

