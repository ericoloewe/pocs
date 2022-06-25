package org.example.webapi.controllers;

import org.example.business.WordsBusiness;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HomeController {
    private final WordsBusiness business = new WordsBusiness();

    @GetMapping("/")
    public String index() {
        return business.one();
    }
}
