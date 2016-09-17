import java.util.Arrays;
import java.util.HashMap;
import java.util.Scanner;

public class Problem9 {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        Integer[] sequence = Arrays.stream(scan.nextLine().split("\\s+")).map(Integer::parseInt).toArray(Integer[]::new);

        HashMap<Integer, Integer> map = new HashMap<>();
        Arrays.stream(sequence).forEach((n) -> {
                    if (map.containsKey(n)) {
                        map.put(n, map.get(n) + 1);
                    } else {
                        map.put(n, 1);
                    }
                }
        );


        int elementVal = 0;
        int maxSeqLength = 0;
        for (Integer n :
                sequence) {
            if (map.get(n) > maxSeqLength){
                elementVal = n;
                maxSeqLength = map.get(n);
            }
        }

        System.out.println(elementVal);
    }
}

