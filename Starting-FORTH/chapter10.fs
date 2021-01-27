( Chapter Ten: I/0 AND YOU )

( random number generator -- high level )

variable rnd   here rnd ! 
: random   rnd @ 31421 * 6927 + dup rnd ! ;
: choose ( u1 -- u2 ) 
    random u* swap drop ; 
( u* not found) 

: -text   2dup + swap do drop 2+
    dup 2- @ I @ - dup if dup abs / leave then 
        2 +loop swap drop ; 

        

