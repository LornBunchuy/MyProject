package Library;

import java.io.*;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.concurrent.ArrayBlockingQueue;

public class Database
{
    private ArrayList<User> users = new ArrayList<User>();
    private ArrayList<String> usernames = new ArrayList<String>();
    private ArrayList<Book> books = new ArrayList<Book>();
    private ArrayList<String> bookNames = new ArrayList<String>();
    private ArrayList<Order> orders = new ArrayList<Order>();
    private ArrayList<Borrowing> borrowings = new ArrayList<Borrowing>();

    private File userFile = new File("D:\\Year 3\\Semester 1\\IT 312 (Java)\\Libratry Management Stystem\\data\\Users");
    private File bookFile = new File("D:\\Year 3\\Semester 1\\IT 312 (Java)\\Libratry Management Stystem\\data\\Books");
    private File borrowfile = new File("D:\\Year 3\\Semester 1\\IT 312 (Java)\\Libratry Management Stystem\\data\\Borrowings");
    private File folder = new File("D:\\Year 3\\Semester 1\\IT 312 (Java)\\Libratry Management Stystem\\data");
    private File orderfile = new File("D:\\Year 3\\Semester 1\\IT 312 (Java)\\Libratry Management Stystem\\data\\Orders");
    public Database(){
        if(!folder.exists()){
            folder.mkdir();
        }
        if(!userFile.exists()){
            try {
                userFile.createNewFile();
            } catch (IOException e) {}
        }
        if(!bookFile.exists()){
            try {
                bookFile.createNewFile();
            } catch (IOException e) {}
        }
        if(!orderfile.exists()){
            try {
                orderfile.createNewFile();
            } catch (IOException e) {}
        }
        if(!borrowfile.exists()){
            try {
                borrowfile.createNewFile();
            } catch (IOException e) {}
        }
        getUsers();
        getBooks();
        getOrders();
        getBorrowing();
    }
    public void AddUser(User s){
        users.add(s);
        usernames.add(s.getName());
        saveUser();
    }

    public int login(String phonenumber, String email){
        int  n  = -1;
        for(User s: users){
            if(s.getPhoneNumber().matches(phonenumber) && s.getEmail().matches(email)){
                n = users.indexOf(s);
                break;
            }
        }
        return n;
    }
    public User getUser(int n){
       return users.get(n);
    }

    public void AddBook(Book book){
        books.add(book);
        bookNames.add(book.getName());
        saveBook();
    }

    public void getUsers(){
        String text1 = "";
        try {
            BufferedReader br1 = new BufferedReader(new FileReader(userFile));
            String s1;
            while((s1 = br1.readLine()) !=null){
                text1 =text1 + s1;
            }
            br1.close();
        }catch (Exception e){
            System.err.println(e.toString());
        }
        if(!text1.matches("") || !text1.isEmpty()){
            String[] a1 = text1.split("<NewUser/>");
            for(String a: a1){
               String[] a2 = a.split("<N/>");
               if(a2[3].matches("Admin")){
                   User user = new Admin(a2[0], a2[1], a2[2]);
                   users.add(user);
                   usernames.add(user.getName());
               }else{
                   User user = new NormalUser(a2[0], a2[1], a2[2]);
                   users.add(user);
                   usernames.add(user.getName());
               }
            }
        }
    }
    private void saveUser(){
        String text1 ="";
        for(User user : users){
            text1 = text1 + user.toString()+"<NewUser/>\n";
        }
        try{
            PrintWriter pw = new PrintWriter(userFile);
            pw.println(text1);
            pw.close();
        }catch (Exception e){
            System.err.println(e.toString());
        }
    }
    private void saveBook(){
        String text1 ="";
        for(Book book : books){
            text1 = text1 + book.toString2()+"<NewBook/>\n";
        }
        try{
            PrintWriter pw = new PrintWriter(bookFile);
            pw.println(text1);
            pw.close();
        }catch (Exception e){
            System.err.println(e.toString());
        }
    }
    public void getBooks(){
        String text1 = "";
        try {
            BufferedReader br1 = new BufferedReader(new FileReader(bookFile));
            String s1;
            while((s1 = br1.readLine()) !=null){
                text1 =text1 + s1;
            }
            br1.close();
        }catch (Exception e){
            System.err.println(e.toString());
        }
        if(!text1.matches("") || !text1.isEmpty()){
            String[] a1 = text1.split("<NewBook/>");
            for(String a: a1){
                Book book = parseBook(a);
                books.add(book);
                bookNames.add(book.getName());
            }
        }
    }
    public Book parseBook(String s){
        String[] a = s.split("<N/>");
        Book book = new Book();
        book.setName(a[0]);
        book.setAuthor(a[1]);
        book.setPublisher(a[2]);
        book.setAddress(a[3]);
        book.setQty(Integer.parseInt(a[4]));
        book.setPrice(Integer.parseInt(a[5]));
        book.setBrwcopies(Integer.parseInt(a[6]));
        return book;
    }
    public ArrayList<Book> getAllBooks(){
        return books;
    }

    public int getBook(String bookname){
        int  n  = -1;
        for(Book s: books){
            if(s.getName().matches(bookname)){
                n = books.indexOf(s);
                break;
            }
        }
        return n;
    }
    public Book getBook(int i){
        return books.get(i);
    }
    public void deleteBook(int d){
        books.remove(d);
        bookNames.remove(d);
        saveBook();
    }

    public void deleteAllData(){
        if(userFile.exists()){
            try {
                userFile.delete();

            } catch (Exception e) {}
        }
        if(bookFile.exists()){
            try {
                bookFile.delete();
            } catch (Exception e) {}
        }
        if(orderfile.exists()){
            try {
                orderfile.delete();
            } catch (Exception e) {}
        }
        if(borrowfile.exists()){
            try {
                borrowfile.delete();
            } catch (Exception e) {}
        }
    }
    public void addOrder(Order order,Book book , int bookindex ){
        orders.add(order);
        books.set(bookindex, book);
        saveOrder();
        saveBook();
    }
    private void saveOrder(){
        String text1 ="";
        for(Order order : orders){
            text1 = text1 + order.toString2()+"<NewOrder/>\n";
        }
        try{
            PrintWriter pw = new PrintWriter(orderfile);
            pw.println(text1);
            pw.close();
        }catch (Exception e){
            System.err.println(e.toString());
        }
    }
    private void getOrders(){
        String text1 = "";
        try {
            BufferedReader br1 = new BufferedReader(new FileReader(orderfile));
            String s1;
            while((s1 = br1.readLine()) !=null){
                text1 =text1 + s1;
            }
            br1.close();
        }catch (Exception e){
            System.err.println(e.toString());
        }
        if(!text1.matches("") || !text1.isEmpty()){
            String[] a1 = text1.split("<NewOrder/>");
            for(String s : a1){
                Order order = parseOrder(s);
                orders.add(order);
            }
        }
    }
    public boolean getUserExit(String name){
        boolean f = false;
        for(User user: users){
            if(user.getName().toLowerCase().matches(name.toLowerCase())){
              f = true;
                break;
            }
        }
        return f;
    }
    private User getUserByName(String name){
        User u = new NormalUser("");
        for(User user: users){
            if(user.getName().matches(name)){
                u = user;
                break;
            }
        }
        return u;
    }
    private Order parseOrder(String s){
        String[] a = s.split("<N/>");
        Order order = new Order(books.get(getBook(a[0])), getUserByName(a[1]),Double.parseDouble(a[2]), Integer.parseInt(a[3]));
       return order;
    }
    public ArrayList<Order> getAllOrders(){
        return orders;
    }
    private  void saveBorrowing(){
        String text1 ="";
        for(Borrowing borrowing : borrowings){
            text1 = text1 + borrowing.toString2()+"<NewBorrowing/>\n";
        }
        try{
            PrintWriter pw = new PrintWriter(borrowfile);
            pw.println(text1);
            pw.close();
        }catch (Exception e){
            System.err.println(e.toString());
        }
    }
    private void getBorrowing(){
        String text1 = "";
        try {
            BufferedReader br1 = new BufferedReader(new FileReader(borrowfile));
            String s1;
            while((s1 = br1.readLine()) !=null){
                text1 =text1 + s1;
            }
            br1.close();
        }catch (Exception e){
            System.err.println(e.toString());
        }
        if(!text1.matches("") || !text1.isEmpty()){
            String[] a1 = text1.split("<NewBorrowing/>");
            for(String s : a1){
            Borrowing borrowing = parseBorrowing(s);
            borrowings.add(borrowing);
            }
        }
    }
    private Borrowing parseBorrowing(String s){
        String[] a =  s.split("<N/>");
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd");
        LocalDate start = LocalDate.parse(a[0], formatter);
        LocalDate finiish = LocalDate.parse(a[1], formatter);
        Book  book = getBook(getBook(a[3]));
        User user = getUserByName(a[4]);
        Borrowing br = new Borrowing(start,finiish,book,user);
        return br;
    }
    public void borrowBook(Borrowing brw, Book book , int bookindex){
        borrowings.add(brw);
        books.add(bookindex, book);
        saveBorrowing();
        saveBook();
    }


    public ArrayList<Borrowing> getBrws(){
        return borrowings;
    }

    public void returnBook(Borrowing b, Book book , int bookindex){
        borrowings.remove(b);
        books.set(bookindex, book);
        saveBook();
        saveBorrowing();
    }
}



