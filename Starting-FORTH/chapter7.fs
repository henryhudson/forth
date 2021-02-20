( chapter seven: A NUMBER OF KINDS OF NUMBERS)

( more efficient to do 2* rather than 2 * due to arimetic bitwise shift )


: .$ SWAP OVER DABS
    <# # # 46 HOLD #S SIGN 36 HOLD #> TYPE SPACE ;

: printables ( -- )
    127 32 do i emit cr loop ;

: .ph#
    <# # # # # 45 hold #S #> type space ;

: .date
    <# # # 47 hold  # # 47 hold  #s #>  type space ;

: .$  ( n -- )
    swap over dabs
    <#  # # 46 hold  #s sign  36 hold  #> type space ;

\ problems

: p1
    0 begin 1+ dup  0< until  1- . ;

: binary
    2 base ! ;

: p6
    1000 0 do cr ." decimal" decimal i  4  u.r 8 spaces
               ." hex"       hex     i  4  u.r 8 spaces
               ." binary"    binary  i  11 u.r 8 spaces
    loop decimal ;


