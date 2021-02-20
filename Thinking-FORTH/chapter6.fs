( Chapter six: Factoring)

: two-thirds ( n1 -- n2)
    2 3 * / ;

\ centers lines of 80
: center ( length --)
    80 swap -  2 / spaces ;

: letter  ( --)
    blk @ BLOCK   >in @ +   c! ;

: frame  ( -- a)
    scr @ block ;
: cursor  ( -- a)
     ; \ r# not defined
: at  ( -- a)
    frame   cursor @ + ;

\ ibm pc text modes
: COL-MODE!  ( #columns mode)
    \ mode #columns ! ; mode not defined in gforth
;


\ Moore    " doubly nested do loop, thats a sign somethings wrong "
