package Library;

import java.util.Scanner;

public class BorrowBook implements IOOperation{
    @Override
    public void oper(Database db, User user) {
        Scanner s = new Scanner(System.in);
        System.out.println("Enter book name: ");
        String bookname= s.next();

        int i = db.getBook(bookname);
        if(i>-1){
           Book book  =  db.getBook(i);
           boolean n = true;

           for(Borrowing b : db.getBrws()){
               if(b.getBook().getName().matches(bookname) && b.getUser().getName().matches(user.getName())){
                   n =false;
                   System.out.println("You have borrowed this book before!");
               }

           }
           if(n){
               if(book.getBrwcopies()>1 ){
                   Borrowing brw = new Borrowing(book,  user);
                   book.setBrwcopies(book.getBrwcopies() - 1);
                   db.borrowBook(brw, book ,i);
                   System.out.println("You must return the book before 24 day from now\n"+

                           "Expiry date: "+ brw.getFinih() + "\nEnjoy!\n");
               }else{
                   System.out.println("This book isn't available for borrowing !\n");
               }
           }
        }else{
            System.out.println("Book  doesn't exist!!");
        }
        user.menu(db, user);
    }
}
