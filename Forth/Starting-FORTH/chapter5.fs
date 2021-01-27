( chapter five: the philosphy of fixed point)

: difference - abs ;

: quadratic ( a b c x --n) 
    >r swap rot I * + r> * + ;

: percent ( n1 n2 -- n2 percent of n1)
    100 */ ;

: rounded-percent ( rounds to nearest integer ) 
    10 */ 5 + 10 / ;

: circle-area ( n -- n * n * PI) 
    dup * 355 113 */ ;

: celcius-to-kelvin 273 + ;

: fahrenheit-to-celcius 32 - 10 * 18 / ;

: celcius-to-fahrenheit 18 * 10 / 32 + ;

