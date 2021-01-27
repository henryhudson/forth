( Chapter Twelve: THREE EXAMPLES)


\ weight of conical piles -- single length)
variable density
variable theta
variable string

34 constant quote

: " QUOTE word dup c@ 1+ allot ;
: .substance string @ count type space ;

: material ( string density theta)
    create , , ,
    does> dup @ theta ! 2 + dup @ density ! 2 + @ string ! ;

: FOOT ( )
    10 * ;
: INCH ( )
    100 12 */ 5 + 10 / + ;

: /tan 1000 theta @ * / ;
: PILE
    dup dup 10 */ 1000 */ 355 339 */ /tan /tan
    density @ 200 */ ." = " . ." tons of " .substance ;


\ table of materials
( string-address            density         theta)
" cement"                   131             700   material cement
" loose gravel"             93              649   material loose-gravel
" dry sand"                 90              754   material dry-sand











