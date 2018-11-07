package com.example.demo;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Repository;

@Repository
public class EmpDAO {
	private static List<Emp> emps;
	{
		emps = new ArrayList<Emp>();
		emps.add(new Emp(1001L, "TopCredu", 6000L, "CLERK"));
		emps.add(new Emp(1002L, "Jhon Denver", 7000L, "SALESMAN"));
		emps.add(new Emp(1003L, "Karl Luice", 8000L, "MANAGER"));
		emps.add(new Emp(1004L, "Chanho Park", 7000L, "SALESMAN"));
		emps.add(new Emp(1005L, "Phile Migalon", 8000L, "MANAGER"));
		emps.add(new Emp(1006L, "Jhon Smith", 7500L, "SALESMAN"));
		emps.add(new Emp(1007L, "OracleJavaCommunity", 6800L, "CLERK"));
		emps.add(new Emp(1008L, "Ojc.Asia", 7200L, "CLERK"));
	}

	public List<Emp> getEmps() {
		return emps;
	}

	public Emp getEmp(Long empno) {
		for (Emp e : emps) {
			if (e.getEmpno().equals(empno))
				return e;
		}
		return null;
	}

	public Emp createEmp(Emp e) {
		emps.add(e);
		return e;
	}

	public Long deleteEmp(Long empno) {
		for (Emp e : emps) {
			if (e.getEmpno().equals(empno)) {
				emps.remove(e);
				return empno;
			}
		}
		return null;
	}

	public Emp updateEmp(Long empno, Emp e) {
		for (Emp emp : emps) {
			if (emp.getEmpno().equals(empno)) {
				e.setEmpno(emp.getEmpno());
				emps.remove(emp);
				emps.add(e);
				return e;
			}
		}
		return null;
	}
}


