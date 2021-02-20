( chapter eight: VARIABLES, CONSTANTS AND ARRAYS)


variable date
12 date !

variable month

variable year

: !date
    year ! month ! date ! ;

: .date
    date ? month ? year ? ;

variable eggs
: reset   0 eggs ! ;

42 constant life

220 constant limit

: ?too-hot ( n -- )
    limit > if ." DANGER -- Reduce heat now" then ;

variable limits 9 allot
create limits 20 , 200 ,  2 , 3 , 290 ,

create 'samples 20 allot
: stars
    ?dup if 0 do 42 emit loop then ;
: samples ( index# -- address)
    2* 'samples + ;
: init-samples ( -- )
    11 0 do  i 7 mod  i samples ! loop ;
: plot ( -- )
    11 0 do cr i 2 u.r space i samples @ stars loop cr ;

init-samples

variable board 7 allot
: clear
    board  10 0 fill ;
: sqr
    board + ;
: bar
    ." | " ;
: dashes
    cr  9 0 do ." -" loop cr ;
: .box
    sqr c@ dup 0= if 2 spaces else
        dup 1 = if ." X " else
                   ." O " then then drop ;
: display
    cr 9 0 do
        i if  i 3 mod 0= if dashes else bar then then
            i .box loop cr quit ;
: play
    1- 0 max 8 min sqr c! ;
: x!
    1 swap play display ;
: O!
    -1 swap play display ;

