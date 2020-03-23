import java.util.ArrayList;
import java.util.Comparator;

import Data.BinaryTree.BinaryTree;
import Data.BinaryTree.BinaryTreeOld;
import Data.BinaryTree.TestGenericBinary;
import Data.Model.Actor;

public class Main {

    public static void main(String[] args) {

       BinaryTreeOld<Integer> etTre = new BinaryTreeOld<>();


        Integer [] data = {1,5,6,10,6,5,2};

        for(Integer i : data){
           etTre.insertWord(i);
        }

        etTre.inOrder(etTre.root);
       

        Actor person1 = new Actor("Roger", "Knutsen", 20);
        Actor person2 = new Actor("Robert", "Lundeby", 31);
        Actor person3 = new Actor("Ragnar","Mørk", 69);
        Actor person4 = new Actor("Snoop","Dog",40);
        Actor person5 = new Actor("Zelda", "Hambeg", 20);
        Actor person6 = new Actor("Niklas", "Berby", 31);
        Actor person7 = new Actor("Satan","Satansen", 69);
        Actor person8 = new Actor("Juda","Judasen",40);

        Comparator<Actor> actorNameComparator = new Comparator<Actor>() {
            @Override
            public int compare(Actor e1, Actor e2) {
                return e1.getFornavn().compareTo(e2.getFornavn());
            }
        };


        Comparator<Actor> byAge = (Actor o1, Actor o2) ->o1.getAlder() - o2.getAlder();

        TestGenericBinary<Actor> actorTre = new TestGenericBinary<>(byAge);

        Comparator<Actor> byFirstName = 
        (Actor o1, Actor o2)->o1.getFornavn().compareTo(o2.getFornavn());
        

        
        TestGenericBinary<Actor> ttt = new TestGenericBinary<>(byFirstName);

        //TestGenericBinary<Actor> acaaatorTre = new TestGenericBinary<>(byFirstName);

        ArrayList<Actor> bæsj = new ArrayList<Actor>();
        bæsj.add(person1);
        bæsj.add(person2);
        bæsj.add(person3);
        bæsj.add(person4);
        bæsj.add(person5);
        bæsj.add(person6);
        bæsj.add(person7);
        bæsj.add(person8);

       actorTre.insertItemList(bæsj);

       actorTre.inOrder(actorTre.root);
       
        /* 
        ArrayList<Actors> actors = new ArrayList<>();

        etTre.add(actors);
        etTre.traverseAndPrint();
        etTre.getMaxData();
        etTre.GetElement(2);
        etTre.search(actor.id = 1);*/

        
        


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