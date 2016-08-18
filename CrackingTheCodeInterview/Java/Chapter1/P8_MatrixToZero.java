class P8_MatrixToZero {

    public static int [][] toZero(int[][] matrix){
        boolean [] rows = new boolean[matrix.length];
        boolean [] cols = new boolean[matrix[0].length];
        for (int i=0;i<matrix.length ;i++) {
            for (int j=0;j<matrix[0].length ;j++) {
                if (matrix[i][j] == 0) {
                    rows[i] = true;
                    cols[j] = true;
                }
            }
        }
        for (int i=0;i<matrix.length ;i++) {
            for (int j=0;j<matrix[0].length ;j++) {
                if (rows[i] || cols[j]) {
                    matrix[i][j] = 0;
                }
            }
        }
        return matrix;
    }

    public static void main(String[] args) {
        int[][] matrix = {
            {1, 2, 3, 4, 5},
            {6, 0, 8, 0, 1},
            {2, 3, 4, 5, 6},
            {7, 0, 9, 0, 2},
            {3, 4, 5, 6, 7},
        };
        int [][] withZeroes = toZero(matrix);
        for (int i=0;i<withZeroes.length ;i++) {
            System.out.print("[");
            for (int j=0;j<withZeroes[0].length ;j++) {
                System.out.print(" " + withZeroes[i][j] + " ");
            }
            System.out.println("]");
        }
    }
}
