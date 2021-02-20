( user input)

\ key starts listening for user input exits after character is detected

: print-keycode
    begin key dup . 32 = until ; \ listens until spacebar is detected




