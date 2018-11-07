package com.example.demo;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class EmpController {
	@Autowired
	private EmpDAO empDAO;

// http://locahost:8080/emp/all
	@GetMapping("/emp/all")
	public List<Emp> getEmps() {
		System.out.println();
		return empDAO.getEmps();
	}

// http://locahost:8080/emp/1
	@GetMapping("/emp/{empno}")
	public ResponseEntity<Emp> getEmp(@PathVariable("empno") Long empno) {
		Emp e = empDAO.getEmp(empno);
		if (e == null) {
			return new ResponseEntity<Emp>(HttpStatus.NOT_FOUND);
		}
		return new ResponseEntity<Emp>(e, HttpStatus.OK);
	}

// http://locahost:8080/emp/create
	@PostMapping(value = "/emp/create")
	public ResponseEntity<Emp> createEmp(@RequestBody Emp e) {
		empDAO.createEmp(e);
		return new ResponseEntity<Emp>(e, HttpStatus.OK);
	}

// http://locahost:8080/emp/delete/1
	@DeleteMapping("/emp/delete/{empno}")
	public ResponseEntity<Long> deleteEmp(@PathVariable Long empno) {
		if (null == empDAO.deleteEmp(empno)) {
			return new ResponseEntity<Long>(HttpStatus.NOT_FOUND);
		}
		return new ResponseEntity<Long>(empno, HttpStatus.OK);
	}

// http://locahost:8080/emp/update/1
	@PutMapping("/emp/update/{empno}")
	public ResponseEntity<Emp> updateCustomer(@PathVariable Long empno, @RequestBody Emp e) {
		e = empDAO.updateEmp(empno, e);
		if (null == e)
			return new ResponseEntity<Emp>(HttpStatus.NOT_FOUND);
		return new ResponseEntity<Emp>(e, HttpStatus.OK);
	}
}
