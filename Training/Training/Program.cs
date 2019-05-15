using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment No:- 1
            NumberSum a1 = new NumberSum();
            a1.Calculate();

            // Assignment No:- 2
            DayCountIf a20 = new DayCountIf();
            a20.Daycount();
            DayCountSwitch a21 = new DayCountSwitch();
            a21.Daycount();

            // Assignment No:- 3
            RightPattren a3 = new RightPattren();
            a3.RightDesignPattren();

            // Assignment No:- 4
            Fibonacci a4 = new Fibonacci();
            a4.FibonacciDisplay();

            // Assignment No:- 5
            _2DArray a5 = new _2DArray();
            a5.arrayd();

            // Assignment No:- 6
            ArrayStr6 a6 = new ArrayStr6();
            a6.arraydstr();

            // Assignment No:- 7 and 8
            narray7 a78 = new narray7();
            a78.readnarray();

            // Assignment No:- 9
            Trimoperation a9 = new Trimoperation();
            a9.trimo();

            // Assignment No:- 10
            specialString a10 = new specialString();
            a10.specialstring();

            // Assignment No:- 11
            strfwdrev a11 = new strfwdrev();
            a11.revfwdstr();

            // Assignment No:- 12
            strmerge a12 = new strmerge();
            a12.merges();

            // Assignment No:- 13,14 and 15
            strcase a1345 = new strcase();
            a1345.cnvclasses();
            a1345.countwords();
            a1345.distinctword();

            // Assignment No:- 16
            secondmaxele a16 = new secondmaxele();
            a16.secondmax();
                       
        }
    }

}