package Data.BinaryTree;

public class Node<T> {
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