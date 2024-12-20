package Library;

import java.util.Scanner;

public class DeleteBook implements IOOperation{
    @Override
    public void oper(Database db, User user) {
        Scanner s = new Scanner(System.in);
        System.out.println("Enter book name: ");
        String bookname= s.next();

        int i = db.getBook(bookname);
        if(i>-1){
           db.deleteBook(i);
            System.out.println("Book deleted successfully!");
        }else{
            System.out.println("Book does't exist!");
        }
        user.menu(db,user);
    }
}
