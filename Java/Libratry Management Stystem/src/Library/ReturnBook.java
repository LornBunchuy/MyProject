package Library;

import java.util.Scanner;

public class ReturnBook implements IOOperation{
    @Override
    public void oper(Database db, User user) {
        Scanner s = new Scanner(System.in);
        System.out.println("Enter book name: ");
        String bookname= s.next();
        if(!db.getBrws().isEmpty()){
            for(Borrowing b : db.getBrws()){
                if(b.getBook().getName().matches(bookname) && b.getUser().getName().matches(user.getName())){
                    Book book = b.getBook();
                     int i = db.getAllBooks().indexOf(book);
                    if(b.getDaysleft() < 0){
                        System.out.println("You are late!" + "You have to pay " + Math.abs(b.getDaysleft()* 50)+ "as fine\n");
                    }
                    book.setBrwcopies(book.getBrwcopies()+1);
                    db.returnBook(b, book, i);
                    System.out.println("Book returned\nThank you!");
                    break;
                }else{
                    System.out.println("You didn't borrow this book !");
                }
            }
        }else{
            System.out.println("You didn't borrow this book !");
        }
        user.menu(db, user);
    }
}
