( Chapter Six: THROW IT FOR A LOOP)

: test ( -- )
    10 0 do cr ." hello " loop ;

: decade
    10 0 do i . loop ;

: times-table  ( n -- )
    cr 11 1 do dup i * . loop drop ;

: R% ( broke)
    10 */ 5 + 10 / ;

: compound ( amount int -- )
   swap 21 1 do ." year " i .  3 spaces
   2dup r% + dup ." balance " . cr loop 2drop ;


: rectangle
    256 0 do i 16 mod 0= if cr then ." *" loop ;

: whole-ten-times-table
    cr 11 1 do i times-table loop ;

: whole-ten-times-table-aligned
    cr 11 1 do
    11 1 do i j * 5 u.r loop cr loop ;

: pentajumps
    50 0 do i . 5 +loop ;

: inc-count ( increment stop start  -- )
    do i . dup +loop drop ;

: doubling ( )
    4611686018427387904 2 * 1 do i cr . i +loop ;


( INDEFINITE LOOPS)

\ problems

: stars  ( n - )
    0 do ." *" loop ;

: box  ( width height -- )
    0 do cr dup stars loop drop ;

: \box ( width height -- )
    0 do cr i spaces dup stars loop drop ;

: half-box ( width height -- )
       1 swap do cr i stars -1 +loop drop ;

: /box ( width height -- )
    begin cr dup spaces 10 stars 1- dup 0= until  drop ;

: triangle
    do cr 9 i - spaces
        i 2* 1+ stars dup +loop drop ;

: **  ( n x -- n to the power of x )
    1- ?dup if
    over rot rot  0 do over * loop swap drop then ;

: till-doubled ( amount initial)
    over 2* rot rot swap 21 1 do
        cr ." after year " i 2 u.r 3 spaces
            2dup r% + dup ." balance " .
        dup 2over drop > if
    cr cr ." more than doubled in " i . ." years " leave
        then loop 2drop drop ;

