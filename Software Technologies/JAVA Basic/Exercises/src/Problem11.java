import java.util.Arrays;
import java.util.Scanner;

public class Problem11 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        Integer[] sequence = Arrays.stream(scan.nextLine().split("\\s+")).map(Integer::parseInt).toArray(Integer[]::new);
        int index = -1;

        if (sequence.length == 1)
        {
            System.out.println(0);
        }
        else
        {
            for (int numberIndex = 0; numberIndex < sequence.length; numberIndex++)
            {
                long leftSum = 0;
                for (int leftIndex = numberIndex - 1; leftIndex >= 0; leftIndex--)
                {
                    leftSum += sequence[leftIndex];
                }

                long rightSum = 0;
                for (int rightIndex = numberIndex + 1; rightIndex < sequence.length; rightIndex++)
                {
                    rightSum += sequence[rightIndex];
                }

                if (rightSum == leftSum)
                {
                    index = numberIndex;
                    break;
                }
            }

            if (index != -1)
            {
                System.out.println(index);
            }
            else
            {
                System.out.println("no");
            }
        }
    }
}

