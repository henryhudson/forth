: ?fizz ( test for fizz)  3 mod 0 = dup if ." Fizz " then ;
: ?buzz ( test for buzz)  5 mod 0 = dup if ." Buzz " then ;
: ?fizz-buzz ( test for fizz-buzz)  dup ?fizz swap ?buzz or invert ;
: do-fizz-buzz ( play fizz-buzz) 1000 1 do cr i ?fizz-buzz if i . then loop ;
