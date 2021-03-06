import java.util.Arrays;
import java.util.Scanner;

public class Problem8 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        Integer[] sequence = Arrays.stream(scan.nextLine().split("\\s+")).map(Integer::parseInt).toArray(Integer[]::new);

        int maxLength = -1;
        int startingIndex = -1;
        for (int currentIndex = 0; currentIndex < sequence.length; currentIndex++)
        {
            int previousIndex = currentIndex;
            int currentLength = 1;
            for (int nextIndex = currentIndex + 1; nextIndex < sequence.length; nextIndex++)
            {
                if (sequence[previousIndex] < sequence[nextIndex])
                {
                    currentLength++;
                }
                else
                {
                    break;
                }

                previousIndex++;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                startingIndex = currentIndex;
            }
        }

        for (int i = 0; i < maxLength; i++)
        {
            System.out.print(sequence[ startingIndex + i] + " ");
        }

        System.out.println();
    }
}