( Chapter Eleven: EXTENDING THE COMPILER: )


: STRING   CREATE ALLOT DOES> + ;
: ERASED   HERE OVER ERASE ALLOT ;
: 0STRING   CREATE ERASED DOES> + ;

\ multi dimensional array
: ARRAY ( #rows #columns -- )
    CREATE OVER , * ALLOT
    DOES> ( member: row column -- )
    DUP @ ROT * + + 1+ 1+ ;

\ faster array
: ARRAY ( #rows #columns -- )
    OVER CONSTANT HERE 1+ 1+ , * ALLOT
    DOES> 2@ ROT * + + ;

( SHAPES, USING A DEFINING WORD)
: STAR 42 EMIT ;

: .ROW ( )
    CR 8 0 DO DUP 128 AND
    IF STAR ELSE SPACE THEN
    2 * LOOP DROP ;

: SHAPE  ( )
    create 8 0 do c, loop
    does> dup 7 + do i C@ .row -1 +loop cr ;

HEX
    18 18 3c 5a 99 24 24 24 shape man
    81 42 24 18 18 24 42 81 shape equis
    aa aa fe fe 38 38 38 fe shape castle
DECIMAL

: INTERPRET  ( )
    begin -' if number else execute
    ?Stack ABORT" stack empty" then 0 until ;


