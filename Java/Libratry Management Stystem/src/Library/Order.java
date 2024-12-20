package Library;

public class Order {
    private Book book;
    private User user;
    private double price;
    private int qty;

    public Order(){}
    public Order(Book book, User user, double price, int qty){
        this.book =  book;
        this.user = user;
        this.price = price;
        this.qty= qty;
    }

    public double getPrice() {
        return price;
    }

    public Book getBook() {
        return book;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public void setBook(Book book) {
        this.book = book;
    }

    public int getQty() {
        return qty;
    }

    public void setQty(int qty) {
        this.qty = qty;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    @Override
    public String toString() {
        return "Order{" +
                "book=" + book.getName() +
                ", user=" + user.getName() +
                ", price=" + String.valueOf(price) +
                ", qty=" + String.valueOf(qty) +
                '}';
    }
    public String toString2() {
        String text = book.getName()+ "<N/>"+ user.getName() +"<N/>"+ price+"<N/>"+ qty + "<N/>";
        return text;
    }
}
