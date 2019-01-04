


/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author jrago
 */
public class Students {
    private static String name, course;
    private int mobile, studentID;
    private char gender;

    public Students(int studentID, String name, char gender, String course, int mobile){
        this.studentID=studentID;
        this.name=name;
        this.gender=gender;
        this.course=course;
        this.mobile=mobile;

    }//setter
    public int getID(){
        return this.studentID;
    }//setter
    public String getName(){
        return this.name;
    }//setter
    public char getGender(){
        return this.gender;
    }//settter
    public String getCourse(){
        return this.course;
    }//setter
    public int getMobile(){
        return this.mobile;
    }//setter
    public String toString(){
        return(studentID+"    "+name+"   "+gender+"     "+course+"     "+mobile);
    }
    

   
    

}


