import java.util.Scanner;

public class Problem20 {
    public static void main(String[] args) {

                Scanner scan = new Scanner(System.in);
                String text = scan.nextLine();
                int indexOfProtocol = text.indexOf("://");
                String protocol = "";
                if (indexOfProtocol != -1) {
                    protocol = text.substring(0, indexOfProtocol);
                    text = text.substring(indexOfProtocol + "://".length());
                }

                int indexOfSlash = text.indexOf('/');
                String server = "";
                String resource = "";
                if (indexOfSlash != -1) {
                    server = text.substring(0, indexOfSlash);
                    resource = text.substring(indexOfSlash + 1);
                } else {
                    server = text;
                }

                System.out.printf("[protocol] = \"%s\"%n", protocol);
                System.out.printf("[server] = \"%s\"%n", server);
                System.out.printf("[resource] = \"%s\"%n", resource);
            }
        }