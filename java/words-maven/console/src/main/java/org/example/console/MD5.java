package org.example.console;

import java.io.*;
import java.nio.charset.StandardCharsets;
import java.security.NoSuchAlgorithmException;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.security.MessageDigest;

public class MD5 {

    public static void main(String[] args) throws NoSuchAlgorithmException, UnsupportedEncodingException {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner scanner = new Scanner(System.in);

        String message = scanner.nextLine();

        byte[] bytesOfMessage = message.getBytes(StandardCharsets.UTF_8);

        MessageDigest md = MessageDigest.getInstance("MD5");
        byte[] theMD5digest = md.digest(bytesOfMessage);

        StringBuffer sb = new StringBuffer();

        for (byte b : theMD5digest) {
            sb.append(Integer.toHexString((b & 0xFF) | 0x100), 1, 3);
        }

        // System.out.println(new String(theMD5digest, StandardCharsets.UTF_8));
        System.out.println(sb);
    }
}

