( Chapter TWO: HOW TO GET RESULTS)

( Arithmetic operators)
    \ +     adds top two elements of the stack                        ( n1 n2 -- n1 + n2)
    \ -     subtracts the second element from the first               ( n1 n2 --  n1 - n2)
    \ *     multiplies last two elements on the stack                 ( n1 n2 -- n1 * n2)
    \ /     divides the last element on the stack by the second last  ( n1 n2 -- n1 / n2
    \ /mod  divides then returns the remainder then quotient        ( n1 n2 -- remainder quotient)
    \ mod   returns remainder from division                          ( n1 n2 -- remainder of n1 / n2)

 \ 32 bit systems range of single-length signed numbers  -32768 to 32767
 \ 64 bit systems range of single-length signed numbers  -9223372036854775808 to 9223372036854775807

( Stack Maneuvers)
    \ swap  ( n1 n2 -- n2 n1)
    \ dup   ( n -- n n)
    \ over  ( n1 n2 -- n1 n2 n1)
    \ rot   ( n1 n2 n3 -- n2 n3 n1)
    \ drop  ( n -- )


 : yards-to-inches  ( n -- n')
    36 * ;

: feet-to-inches  ( n -- n')
    12 * ;

: cm-to-m  ( n -- n')
    100 / ;

: 2b2 ( c b a -- n)
    ;

: 2b3 ( a b -- n)
    8 * / ;

: 2b4 ( a b -- n)
    * 0.5 * 100 / ;

: 2b5  ( a -- n)
    dup 2 * 3 + * ;

