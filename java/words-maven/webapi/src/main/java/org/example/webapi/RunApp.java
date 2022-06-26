package org.example.webapi;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.autoconfigure.domain.EntityScan;
import org.springframework.data.jpa.repository.config.EnableJpaRepositories;

@SpringBootApplication(scanBasePackages = {"org.example.webapi", "org.example.business"})
@EnableJpaRepositories("org.example.business")
@EntityScan("org.example.business")
public class RunApp {
    public static void main(String[] args) {
        SpringApplication.run(RunApp.class, args);
    }
}
