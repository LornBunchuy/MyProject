//public class Student {
//    private String name;
//    private String id;
//    private double grade;
//
//    public Student(String name, String id, double grade){
//        this.name = name;
//        this.id = id;
//        this.grade = grade;
//    }
//    public String getName(){
//        return name;
//    }
//    public String getId(){
//        return id;
//    }
//    public double getGrade(){
//        return grade;
//    }
//    public void setName(String name){
//        this.name = name;
//    }
//    public void  setId(String id){
//        this.id = id;
//    }
//    public void setGrade(double grade){
//        this.grade = grade;
//    }
//
//    public String toString(){
//        return "ID: "+ id +", Name: "+ name + ", Grade: " + grade;
//    }
//}

























public class Student {
    private String name;
    private String id;
    private double grade;

    public Student(String name, String id, double grade) {
        this.name = name;
        this.id = id;
        this.grade = grade;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public Double getGrade() {
        return grade;
    }

    public void setGrade(double grade) {
        this.grade = grade;
    }

    public String toString() {
        return "ID: " + id + ", Name: " + name + ", Grade: " + grade;
    }
}