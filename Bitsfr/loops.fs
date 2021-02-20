\ do loops akin to for loops
: hello-x-10 10 0 do i ." hello " cr drop loop ;

\ begin until loop akin to while loop
: begin-loop ( n-- n looped down by whole ints until zero )
    begin 1 - dup dup . 0 = until ;


