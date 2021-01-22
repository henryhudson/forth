: ?full   12 = if ." its full " then ; 

: ?too-hot   200 > if ." danger danger reduce heat " then ;

: ?day 32 < if ." looks good " else ." no way " then ;

: eggsize
 dup 18 < if ." REJECT " else
 dup 21 < if ." SMALL " else 
 dup 24 < if ." MEDIUM " else 
 dup 27 < if ." LARGE " else 
 dup 30 < if ." EXTRA LARGE " else
 ." ERROR " 
then then then then then drop ;

: BOXTEST ( length width height --)
  6 > rot 22 > rot 19 > and and 
  if ." big enough " then ;
	 
