import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Problem21 {
    public static void main(String[] args) {
        Scanner scan =new Scanner(System.in);

        String input = scan.nextLine();
        Pattern pattern = Pattern.compile("<upcase>(.*?)</upcase>");
        Matcher regexMatcher = pattern.matcher(input);
        while (regexMatcher.find()) {
            input = regexMatcher.replaceAll(
                    String.valueOf(regexMatcher.group(1).toUpperCase()));
        }

        System.out.println(input);
    }
}

