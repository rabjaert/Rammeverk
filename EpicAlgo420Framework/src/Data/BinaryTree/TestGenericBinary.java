package Data.BinaryTree;

import java.util.Collections;
import java.util.Comparator;
import java.util.List;

import Interfaces.BinaryTree.IBinaryTree;

public class TestGenericBinary<T> implements IBinaryTree<T>{

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

    @Override
    public void add(T element) {
        // TODO Auto-generated method stub

    }

    @Override
    public boolean contains(T element) {
        // TODO Auto-generated method stub
        return false;
    }

    @Override
	public void remove(T element) {
		// TODO Auto-generated method stub
		
	}}