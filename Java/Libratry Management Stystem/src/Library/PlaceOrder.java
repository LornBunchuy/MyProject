package Library;

import java.util.Scanner;

public class PlaceOrder implements IOOperation{
    @Override
    public void oper(Database db, User user) {
        Order order = new Order();
        System.out.println("\nEnter book name: ");
        Scanner s = new Scanner(System.in);
        String bookname = s.next();
        int i = db.getBook(bookname);
        if(i <=-1){
            System.out.println("Book doesn't exist!!");
        }else {
            Book book = db.getBook(i);
            order.setBook(book);
            order.setUser(user);
            System.out.println("Enter qty: ");
            int qty = s.nextInt();
            order.setQty(qty);
            order.setPrice(book.getPrice()*qty);
            int bookindex = db.getBook(book.getName());
            book.setQty(book.getQty() - 1);
            db.addOrder(order, book, bookindex);
            System.out.println("Order placed successfully!");
        }
        user.menu(db, user);
    }
}
