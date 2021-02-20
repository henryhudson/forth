( chapter Seven: Handling data: stacks and states)

\ variable top     ( y coordinate top of box)
\ variable left    ( x coordinate left of box)
\ variable bottom  ( y coordinate bottom of box)
\ variable right   ( x coordinate right of box)

\ : [BOX]  ( x1 y1 x2 y2)
  \  bottom !  right !  top !  left !
 \   left @ top @  right @ top @ line


\ DOER / MAKE
: NOTHING ;
: DOER CREATE ’ NOTHING , DOES> @ >R ;
VARIABLE MARKER
:(MAKE) R> DUP2+ DUP2+ SWAP@ 2+(pfa)!
@ ?DUP IF >R THEN ;
: MAKE STATE @ IF ( compiling)
COMPILE (MAKE) HERE MARKER ! 0 ,
ELSE HERE [COMPILE] ’ !
[COMPILE] ] THEN ; IMMEDIATE
: ;AND COMPILE EXIT HERE MARKER @ ! ; IMMEDIATE
: UNDO [’] NOTHING [COMPILE] ’ ! ;


