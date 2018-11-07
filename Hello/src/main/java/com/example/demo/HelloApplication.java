package com.example.demo;

// Xamarin.Forms 안드로이드에서 자바기반 스프링 프레임워크(스프링 부트)로
// 작성한 웹서비스 호출 실습.

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class HelloApplication {

	public static void main(String[] args) {
		SpringApplication.run(HelloApplication.class, args);
		
	}
}
