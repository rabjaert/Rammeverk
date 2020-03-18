import Data.BinaryTree.BinaryTree;

public class Main {

    public static void main(String[] args) {
       BinaryTree<String> etTre = new BinaryTree<>();

        String [] data = {"Hei", "Hva", "Faen", "Driver", "Du", "Med"};

        for(String i : data){
            System.out.println(i);
        }

        /*
        for (String i : data) {
            etTre.insertNode(etTre.root, i);
            System.out.print(i);
            
        }
        System.out.println("traverseandprint");
        etTre.traverseAndPrint();
        System.out.println("inorder");
        etTre.inOrder(etTre.root);
       */
/*
        for(int i = 0; i < data.length; i++){
            etTre.insertNode(etTre.root, i);
        } 

        etTre.traverseAndPrint();
        

    }
*/
}
}