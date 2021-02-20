( Chapter ONE: FUNDAMENTAL FORTH)

: star ( --  )
    42 emit ;

: stars ( n -- )
    0 do star loop ;

: greet ( -- )
    ." hello, forth i speak " ;

: greet2 ." hello " cr greet ;

