package Library;

public class Book
{
    private String name;
    private String author;
    private String publisher;
    private String adress;
    private String status;
    private int qty;
    private double price;
    private int brwcopies;

    public Book(){}
    public Book(String name, String author, String publisher, String adress,String status,int qty,double price,int brwcopies){
        this.name = name;
        this.author = author;
        this.publisher  = publisher;
        this.adress = adress;
        this.status = status;
        this.qty = qty;
        this.price = price;
        this.brwcopies = brwcopies;
    }

    public String toString(){
        String text = "Book name: "+ name+ "\nBook Author: "+ author +"\nBook Publisher: "+ publisher+"\nBook Collections Address: "+ adress + "\nQty: "+ String.valueOf(qty)+ "\nBook Price: "+ String.valueOf(price)+"\nBorrowing Copies: "+ String.valueOf(brwcopies);
        return text;
    }

    public String getName() {
        return name;
    }

    public String getAuthor() {
        return author;
    }

    public String getPublisher() {
        return publisher;
    }

    public String getAddress() {
        return adress;
    }

    public String getStatus() {
        return status;
    }

    public int getQty() {
        return qty;
    }

    public void setQty(int qty) {
        this.qty = qty;
    }

    public double getPrice() {
        return price;
    }

    public int getBrwcopies() {
        return brwcopies;
    }

    public void setBrwcopies(int brwcopies) {
        this.brwcopies = brwcopies;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public void setAddress(String adress) {
        this.adress = adress;
    }

    public void setPublisher(String publisher) {
        this.publisher = publisher;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String toString2(){
        String text = name+ "<N/>"+ author +"<N/>"+ publisher+"<N/>"+ adress + "<N/>"+ String.valueOf(qty)+ "<N/>"+ String.valueOf(price)+"<N/>"+ String.valueOf(brwcopies);
        return text;
    }
}
