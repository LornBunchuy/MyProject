package Library;

import java.util.ArrayList;
import java.util.Scanner;

public class ViewOrders implements IOOperation{
    @Override
    public void oper(Database db, User user) {
        System.out.println("\nEnter book name: ");
        Scanner s = new Scanner(System.in);
        String bookname = s.next();
        int i =- db.getBook(bookname);
        if(i>=-1){
            System.out.println("Book\t\tUser\t\tPrice\t\tQty");
            for(Order order : db.getAllOrders()){
                if(order.getBook().getName().matches(bookname)){
                    System.out.println(order.getBook().getName()+"\t\t"+order.getUser().getName()+"\t\t"+order.getPrice()+"\t"+order.getQty());
                }

            }
            System.out.println();

        }else{
            System.out.println("Book doesn't exist!!");
        }
        user.menu(db, user);
    }
}
