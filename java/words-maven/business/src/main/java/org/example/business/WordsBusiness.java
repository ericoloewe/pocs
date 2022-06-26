package org.example.business;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.util.stream.Collectors;

@Service
public class WordsBusiness {
    @Autowired
    private WordsRepository wordsRepository;

    public String one() {
        return wordsRepository.findAll().stream().map(Word::toString).collect(Collectors.joining(";"));
    }

    @Transactional
    public void create(String word) {
        wordsRepository.save(new Word(word));
    }
}
