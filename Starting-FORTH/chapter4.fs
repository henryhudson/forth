( Chapter FOUR: Decisions decisions decisions... )


: ?full  ( n -- )
    12 = if ." its full " then ;

: ?too-hot  ( n -- )
    200 > if ." danger danger reduce heat " then ;

\ if else
: ?day ( n -- )
    32 < if ." looks good " else ." no way " then ;

: eggsize
 dup 18 < if ." REJECT " else
 dup 21 < if ." SMALL " else
 dup 24 < if ." MEDIUM " else
 dup 27 < if ." LARGE " else
 dup 30 < if ." EXTRA LARGE " else
 ." ERROR "
then then then then then drop ;

: random
    dup 0<   swap  10 mod 0= + ;


: BOXTEST ( length width height --)
  6 > rot 22 > rot 19 > and and
  if ." big enough " then ;


: card ( n -- )
    21  < if ." UNDERAGE "  else ." alcohol allowed" then ;

: sign.test  ( n -- )
    dup 0= if ." ZERO " else
    dup 0> if ." POSITIVE " else
    dup 0< if ." NEGATIVE " else
    ." fail "
    then then then drop ;


\ words with built in ifs
( ?dup) \

