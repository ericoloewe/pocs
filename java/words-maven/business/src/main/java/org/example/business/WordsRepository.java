package org.example.business;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface WordsRepository extends JpaRepository<Word, Integer> {
    boolean existsByName(String name);

    List<Word> findByName(String name);

    @Query("select max(s.id) from Word s")
    Integer findMaxId();
}
