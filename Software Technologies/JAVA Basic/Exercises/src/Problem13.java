import java.util.Arrays;
import java.util.Scanner;

public class Problem13 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = Integer.parseInt(scan.nextLine());
        Integer[][] matrix = new Integer[n][];
        for (int row = 0; row < n; row++)
        {
            String[] rowAsString = scan.nextLine().split("\\s+");
            matrix[row] = Arrays.stream(rowAsString).map(Integer::parseInt).toArray(Integer[]::new);
        }

        int currentSum = 0;
        for (int i = 0; i < matrix.length; i++)
        {
            currentSum += matrix[i][i];
        }

        int sum = 0;
        for (int i = 0; i < matrix.length; i++)
        {
            sum += matrix[i][matrix.length - 1 - i];
        }

        int result = Math.abs(currentSum - sum);

        System.out.println(result);
    }
}
