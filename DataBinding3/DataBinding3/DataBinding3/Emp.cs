using System;
using System.Collections.Generic;
using System.Text;

namespace DataBinding3
{
    public class Emp
    {
        public int Empno { get; set; }

        public string Ename { get; set; }

        public static IEnumerable<Emp> Emps { get; set; }

        static Emp()
        {
            Emps = new List<Emp>
            {
            new Emp() { Empno = 1, Ename = "송수진" },
            new Emp() { Empno = 2, Ename = "후이" },
            new Emp() { Empno = 3, Ename = "도라에몽" },
            new Emp() { Empno = 4, Ename = "도라미" },
            new Emp() { Empno = 5, Ename = "딸기우유" }
            };
        }
        public override string ToString()
        {
            return string.Format("Empno : {0}, Ename : {1}", Empno,
           Ename);
        }
    }
}
