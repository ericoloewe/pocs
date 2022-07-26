package org.example.console;

//import org.example.business.WordsBusiness;

import java.math.BigDecimal;
import java.math.BigInteger;
import java.text.NumberFormat;
import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.Month;
import java.util.*;
import java.util.regex.Pattern;

public class Run {
//    private static final WordsBusiness business = new WordsBusiness();

    public static void main(String[] args) {
        System.out.println("HEREEE");
//        asd();

        // calculation(new String[] {"Sweater $36 12%","Shirt 12 50%",});
    }

    private static void asd() {
        var scanner = new Scanner(System.in);

        var a = new BigInteger(scanner.nextLine());
        var b = Integer.parseInt(scanner.nextLine());


        System.out.printf("%d", 1);
        System.out.printf("%f", 1.5);
        System.out.printf("%15s%s", "str, number", "");

        LocalDate localDate = LocalDate.of(1947, Month.AUGUST, 15);

        // Find the day from the local date
        DayOfWeek dayOfWeek = DayOfWeek.from(localDate);

        Locale locale = new Locale("en", "UK");
        NumberFormat fmt = NumberFormat.getCurrencyInstance(locale);

        var arr = new ArrayList<BigDecimal>();

        var aa = new BigDecimal("123");

//        aa.compareTo(1);

        arr.sort(Collections.reverseOrder());

        var map = new HashMap<BigDecimal, String>();


        var av = "";

        var c = av.toCharArray();

        c[0] = Character.toUpperCase(c[0]);

        var s = new String(c);

        var big = new BigInteger(""+ 1);

        big.isProbablePrime(1);

//        Character.isAlphabetic()
    }

    public static Integer find_total(Integer[] my_numbers) {
        //Insert your code here
        var point = 0;

        for (var i = 0; i < my_numbers.length; i++) {
            var num = my_numbers[i];

            if (num == 5)
                point += 5;
            else if (num % 2 == 0)
                point += 1;
            else
                point += 3;
        }

        return point;
    }

    public static String output(String[] input) {
        //Insert your code here
        var finals = new StringBuilder();

        for (String s : input) {
            var arr = s.replaceAll("[0-9]", "").toCharArray();
            var isNotAlp = true;

            for (var j = 0; j < arr.length; j++) {
                if (isNotAlp)
                    arr[j] = Character.toUpperCase(arr[j]);

                isNotAlp = !Character.isAlphabetic(arr[j]);
            }

            finals.append(new String(arr));
        }

        return finals.toString();
    }

    public static String calculation( String[] items ) {
        var totalPrice = 0d;
        var salePrice = 0d;

        for(var item: items) {
            java.util.Optional<String> priceStr = findPrice(item);
            if (priceStr.isEmpty())
                continue;

            var price = Double.parseDouble(priceStr.get());

            java.util.Optional<String> percentOffStr = findPercentOff(item);
            var percentOff = Integer.parseInt(percentOffStr.get());

            totalPrice += price;
            var discount = price*(percentOff/100.0);
            salePrice += price - discount;
        }

        var amountSaved = totalPrice-salePrice;

        StringBuffer sb = new StringBuffer();
        sb.append("Total Original Price:$")
                .append(String.format("%,.2f", totalPrice))
                .append(";Total sale price:$")
                .append(String.format("%,.2f", salePrice))
                .append(";Amount saved:$")
                .append(String.format("%,.2f", amountSaved))
                .append(";");
        return sb.toString();
    }

    private static java.util.Optional<String> findPrice(String line) {
        String regex = "[$]([0-9.]+)";
        java.util.regex.Matcher m = java.util.regex.Pattern.compile(regex).matcher(line);
        if(m.find()) {
            try{
                String priceStr = m.group(1);
                return java.util.Optional.of(priceStr);
            }catch(java.time.format.DateTimeParseException ex) {
                return java.util.Optional.empty();
            }
        }
        return java.util.Optional.empty();
    }
    private static java.util.Optional<String> findPercentOff(String line) {
        String regex = "(\\d*)%";
        java.util.regex.Matcher m = java.util.regex.Pattern.compile(regex).matcher(line);
        if(m.find()) {
            try {
                String percentOffStr = m.group(1);
                return java.util.Optional.of(percentOffStr);
            }catch(java.time.format.DateTimeParseException ex) {
                return java.util.Optional.empty();
            }
        }
        return java.util.Optional.empty();
    }
}
