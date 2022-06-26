package org.example.webapi.controllers;

import org.example.business.WordsBusiness;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HomeController {
    @Autowired
    private WordsBusiness business;

    @GetMapping("/")
    public String index() {
        return business.one();
    }

    @GetMapping("/{word}")
    public String index(@PathVariable String word) {
        business.create(word);

        return "OK!";
    }
}
