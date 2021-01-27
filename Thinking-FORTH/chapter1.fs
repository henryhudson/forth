( THE PHILOSOPHY OF FORTH)

\ FORTH is a language and an operating system

variable color ( pointer to current tally)
variable reds ( tally of red apples)
variable greens ( tally of green apples)

: RED ( set apple type to red)
    reds color ! ;
: GREEN ( set apple type to green)
    greens color ! ;
: APPLES ( -- address of current apple tally)
    color @ ;

