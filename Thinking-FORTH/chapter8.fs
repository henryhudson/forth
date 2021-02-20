( Chapter EIGHT: MINIMIZING CONTROL STRUCTURES)
: .SUIT  ( suit --)
  CASE
  0 of   ." Hearts " ENDOF
  1 of   ." Spades " ENDOF
  2 of   ." Diamonds " ENDOF
  3 of   ." Clubs " ENDOF
  endcase ;

create twos
  1 c,  2 c,  4 c,  8 c,  16 c,  32 c,

: 2**  ( n -- 2-to-the-n)
  twos +  c@ ;

create pixels
  6 allot

: pixel  ( i -- a )
  pixels + ;

: character  ( -- graphics character)
  160   6 0 do  i pixel c@ i 2** and + loop ;

