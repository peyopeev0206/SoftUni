package URLParser;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Pattern pattern = Pattern.compile("^(?:(?<protocol>.*?)?://)?(?<server>.+?)(?:/(?<resource>.*))?$");

        String url = reader.readLine();
        Matcher matcher = pattern.matcher(url);

        if (matcher.find()) {
            String protocol = matcher.group("protocol");
            System.out.printf("[protocol] = \"%s\"%n", protocol == null ? "" : protocol);

            System.out.printf("[server] = \"%s\"%n", matcher.group("server"));

            String resource = matcher.group("resource");
            System.out.printf("[resource] = \"%s\"%n", resource == null ? "" : resource);
        }
    }
}