class StringCompress {
    public static String compress(String word){
        String result = "";
        char last = '\0';
        int count = 0;
        int length = word.length();
        for (int i=0;i<length ;i++ ) {
            char current = word.charAt(i);
            if(current != last){
                count = 0;
                last = current;
            }
            count++;
            //    dont go beyond limit    next is different?       last char?
            if ( i < length-1 && current != word.charAt(i + 1) || i == length-1 ) {
                result += "" + current + count;
            }
        }
        System.out.println("inside:   " + result);
        return result.length() < word.length()? result : word;
    }

    public static void main(String[] args) {
        System.out.println(compress("aba"));
        System.out.println(compress("abbbba"));
        System.out.println(compress("bbbaaaabcccc"));
        System.out.println(compress("abc"));
    }
}
