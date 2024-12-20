package Library;

import java.util.ArrayList;

public class ViewBooks implements IOOperation {
    @Override
    public void oper(Database db, User user){
        ArrayList<Book> books = db.getAllBooks();
        System.out.println("Name\tAuthor\tPublisher\tCollection location Address\t" +
                "Status\tQty\tPrice\tBorrowing copies" );
        for(Book b : books){
            System.out.println(b.getName()+"\t"+b.getAuthor()+"\t"+b.getPublisher()+"\t"+ b.getAddress()+"\t"+
                    b.getStatus()+"\t"+b.getQty()+"\t"+b.getPrice()+"\t"+ b.getBrwcopies());
        }

        System.out.println();
        user.menu(db,user);
    }
}