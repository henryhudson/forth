( Chapter FIVE: THE PHILOSOPHY OF THE FIXED POINT)

: difference - abs ;

: quadratic ( a b c x --n)
    >r swap rot I * + r> * + ;

: percent ( n1 n2 -- n2 percent of n1)
    100 */ ;

: rounded-percent ( rounds to nearest integer )
    10 */ 5 + 10 / ;

: circle-area ( n -- area )
    dup * 355 113 */ ;

: celcius-to-kelvin 273 + ;

: fahrenheit-to-celcius 32 - 10 * 18 / ;

: celcius-to-fahrenheit 18 * 10 / 32 + ;


\ */  creates a double length intermediate result

: p1  ( a b c -- )
    negate */ ;

: p2 ( n n1 n2 n3 -- )
    max max max . ;

\ temp converters
: FtoC ( degF -- degC)
    32 - 10 * 18 / ;

: FtoK ( degF -- degK)
    FtoC 273 + ;

: CtoF ( degC -- degF)
    18 * 10 / 32 + ;

: CtoK ( degC -- degK)
    273 + ;

: KtoC ( degK -- degC)
    273 - ;

: KtoF ( degK -- degF)
    KtoC CtoF ;
