
class UniqueChars {
    public static boolean hasUnique(String phrase){
        phrase = phrase.toLowerCase();
        boolean[] letters = new boolean[27];
        int phrase_lenght = phrase.length();
        for (int i = 0; i< phrase_lenght ; i++ ) {
            int position = phrase.charAt(i) - 'a';
            if(letters[position]){
                return false;
            }
            letters[position] = true;
        }
        return true;
    }
    public static void main(String[] args) {
        System.out.println("Main Function");
        System.out.println(hasUnique("murcielago"));
        System.out.println(hasUnique("ana"));
        System.out.println(hasUnique(""));
        System.out.println(hasUnique("mexico"));
        System.out.println(hasUnique("internet"));
    }
}
