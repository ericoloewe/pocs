package org.example.console;

import org.example.business.WordsBusiness;

public class Run {
    private static final WordsBusiness business = new WordsBusiness();

    public static void main(String[] args) {
        System.out.println(business.one());
    }
}
