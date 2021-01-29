( chapter Four )

\ with modulo division we can represent decimal points

30 10 /mod

create romans ( table of roman numerals)
        ( ones) 73 C, 86 C,
        ( tens) 88 C, 76 C,
    ( hundreds) 67 C, 68 C,
   ( thousands) 77 C,

VARIABLE COLUMN# ( current offset)
: ONES        0 column# ! ;
: TENS        2 column# ! ;
: HUNDREDS    4 column# ! ;
: THOUSANDS   6 column# ! ;

: column  ( -- address-of-column)
    romans column# @ + ;

: oner
    column C@ EMIT ;
: fiver
    column 1+ C@ EMIT ;
: tenner
    column 1+ 1+ C@ EMIT ;

: .symbol  ( offset)
    column + C@ EMIT ;

: oner
    0 .symbol ;
: fiver
    1 .symbol ;
: tenner
    2 .symbol ;

: oners ( number of oners)
    ?dup if 0 do oner loop then ;
: almost ( quotient of 5 /)
    oner if tenner else fiver then ;
: digit ( digit --)
    5 /mod over 4 = if almost drop else if fiver then
    oners then ;

: ROMAN ( number --)
    1000 /mod thousands digit
    100  /mod hundreds  digit
    10   /mod tens      digit
              ones      digit ;

: ROMAN ( n)
    DUP 3999 > ABORT" too large" ROMAN ;


