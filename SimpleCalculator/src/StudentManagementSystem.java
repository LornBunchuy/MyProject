//import java.util.HashMap;
//import java.util.Scanner;
//
//public class StudentManagementSystem {
//    private HashMap<String, Student> studentMap;
//
//    public StudentManagementSystem(){
//        studentMap = new HashMap<String, Student>();
//    }
//    public void addStudent(String name, String id, double grade){
//        if(studentMap.containsKey(id)){
//            System.out.println("Student ID already exists!");
//        }
//        else{
//            Student student = new Student(name, id, grade);
//            studentMap.put(id, student);
//            System.out.println("Stundent Added successfully!");
//        }
//    }
//    public void displayStudent(){
//        if(studentMap.isEmpty()){
//            System.out.println("No Studnet to display.");
//        }else{
//            for(Student student : studentMap.values()){
//                System.out.println(student);
//            }
//        }
//    }
//    public void searchStudent(String id){
//        if(studentMap.containsKey(id)){
//            System.out.println(studentMap.get(id));
//        }else{
//            System.out.println("Student ID not found!");
//        }
//    }
//    public void  deleteStudent(String id){
//        if(studentMap.containsKey(id)){
//            studentMap.remove(id);
//            System.out.println("Student removed successfully!");
//        }else{
//            System.out.println("Student ID not found!");
//        }
//    }
//}


import java.util.HashMap;
import java.util.Scanner;

public class StudentManagementSystem{
    private HashMap<String, Student> studentMap;

    public StudentManagementSystem(){
        studentMap = new HashMap<String, Student>();
    }
    public void addStudent(String name, String id, double grade){
        if(studentMap.containsKey(id)){
            System.out.println("Student exist already!");
        }else{
            Student student = new Student(name, id, grade);
            studentMap.put(id, student);
            System.out.println("student added successfully!");
        }
    }
    public void searchStudent(String id) {
        if (studentMap.containsKey(id)) {
            System.out.println(studentMap.get(id));
        } else {
            System.out.println("Student ID is not found!");
        }
    }
    public void displayStudent(){
        if(studentMap.isEmpty()){
            System.out.println("No Student ID");
        }else{
            for (Student student : studentMap.values()){
                System.out.println(student);
            }
        }
    }
    public void deleteStudent(String id){
        if(studentMap.containsKey(id)){
            studentMap.remove(id);
            System.out.println("Student ID removed successfully!");
        }else{
            System.out.println("Student Id not found!");
        }
    }
}
