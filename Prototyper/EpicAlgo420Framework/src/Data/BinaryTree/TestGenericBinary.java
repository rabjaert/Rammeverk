package Data.BinaryTree;

import java.util.Collections;
import java.util.Comparator;
import java.util.List;



import Interfaces.BinaryTree.IBinaryTree;

public class TestGenericBinary<T>{

    public Node root;
    private Comparator<T> comparator;

    public TestGenericBinary(Comparator<T> comparator) {
        this.root = null;
        this.comparator = comparator;

    }

    public class Node {
        public T data;
        public Node left, right;
        //public int counter;
    
        public Node(T data) {
            this.data = data; 
            this.left = null;
            this.right = null;
        }
        

        /**
         * @return the left
         */
        public Node getLeft() {
            return left;
        }
        /**
         * @param left the left to set
         */
        public void setLeft(Node left) {
            this.left = left;
        }
        /**
         * @return the right
         */
        public Node getRight() {
            return right;
        }
        /**
         * @param right the right to set
         */
        public void setRight(Node right) {
            this.right = right;
        }

        /**
         * @param data the data to set
         */
        public void setData(T data) {
            this.data = data;
        }
    }


        public Node deleteNode(Node root, T data) {
 
            if(root == null) return root;
     
            if(comparator.compare(data, root.data) < 0){
                root.setLeft(deleteNode(root.getLeft(), data));
            } 
            else if(comparator.compare(data, root.data) > 0) {
                root.setRight(deleteNode(root.getRight(), data));
            } else {
                // node with no leaf nodes
                if(root.getLeft() == null && root.getRight() == null) {
                    System.out.println("deleting "+data);
                    return null;
                } else if(root.getLeft() == null) {
                    // node with one node (no left node)
                    System.out.println("deleting "+data);
                    return root.getRight();
                } else if(root.getRight() == null) {
                    // node with one node (no right node)
                    System.out.println("deleting "+data);
                    return root.getLeft();
                } else {
                    // nodes with two nodes
                    // search for min number in right sub tree
                    T minValue = minValue(root.getRight());
                    root.setData(minValue);
                    root.setRight(deleteNode(root.getRight(), minValue));
                    System.out.println("deleting "+data);
                }
            }
     
            return root;
    }


    private T minValue(Node node) {
 
        if(node.getLeft() != null) {
            return minValue(node.getLeft());
        }
        return node.data;
    }

    public Node insertNode(Node node, T data){

        if(node == null){
            node = new Node(data);
        }

        
         else if (comparator != null && comparator.compare(data, node.data) < 0) {
                node.left = insertNode(node.left, data);
        } else {
            node.right = insertNode(node.right, data);
        }
    
        return node;
    }
    public void insertItem(T word){
        root = insertNode(root, word);
    }

    public void insertItemArray(T word[]){
        for(var i = 0; i < word.length; i++){
        insertItem(word[i]);
     }
    }

    public void insertItemList(List<T> data){
        for(var i = 0; i < data.size(); i++){
        insertItem(data.get(i));
     }
    }


    public void inOrder(Node root) {
        if (root != null) {
            inOrder(root.left);
            System.out.print(root.data.toString() +" \n");
            inOrder(root.right);
        }
    }
    
    public void preOrder(Node root) {
        if (root != null) {
            System.out.print(root.data.toString() +" \n");
            preOrder(root.left);
            preOrder(root.right);
        }
    }
    
    public void postOrder(Node root) {
        if (root != null) {
            postOrder(root.left);
            postOrder(root.right);
            System.out.print(root.data.toString() +" \n");
        }
    }

   
    public boolean contains(Node root, T data)  {
        // Searches for value x in binary tree rooted at root
        
        if (root == null)
            return false;
        if (root.data == data)
            return true;
        return (contains(root.left, data) || contains(root.right, data));
        }

}
