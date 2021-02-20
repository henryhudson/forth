( CONDITIONALS)
 \ false is 0
 \ true is -1

 4 3 > \ returns -1 as true

(
    >: greater than
    <: less than
    = invert: not equals
)

: is-it-0? ( n -- )
    0 =
    if ." yes it is"
    else ." nope" then ;

: is-it-5? ( n -- )
    5 =
    if ." yes it is "
    else ." no " then ;
