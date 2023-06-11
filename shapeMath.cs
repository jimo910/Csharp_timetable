using System;
using  System.Collections;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;

 namespace ConsoleApp{

    public class ShapeMath{

    
        public static double GetArea ( string shape = "",  double length1=0, double length2=0 ){
                if (String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase)){
                        return length1 * length2;
                }else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase)){
                        return length1 * length2*0.5;

        }else{
            return -1;
        }

    }


    }

 }