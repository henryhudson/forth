( chapter six: THROW IT FOR A LOOP) 

: test   10 0 do cr ." hello " loop ;

: decade   10 0 do I . loop ;

: times-table   cr 11 1 do dup i * . loop drop ;

: R%   50 / 1+ 2/ ;
( broken ) 
: compound ( amount int -- )
    swap 21 1 do i . 2dup r% + dup . cr loop 2drop ; 

: rectangle  256 0 do i 16 mod 0= if cr then ." *" loop ;

: whole-ten-times-table   cr 11 1 do i times-table loop ;

: whole-ten-times-table-aligned cr 11 1 do
     11 1 do i j * 5 u.r loop cr loop ; 

