: key# ( returns value of last key pressed ) ;
: position ( returns address of character pointed-to ) ;
: forward ( advance pointer, stopping at the last position) ;
: backward ( retreat pointer, stopping at the first position) ;
: overwrite ( )
    key# position C! forward ;
: insert ( )
    slide> overwrite ;
: delete
    slide< blank-end ;
\ broke missing slide<
