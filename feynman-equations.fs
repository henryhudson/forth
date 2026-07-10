\ feynman-equations.fs — equations from Feynman's red books as Henceforth words
\
\ Source: "Equations from Feynmans red books" (Henry Hudson, LaTeX,
\ ~/Programming/LaTeX/Feynman Equations). One word per equation, the
\ chapter given with each. Integer Forth throughout:
\
\   - most words are unit-free — supply consistent units, get them back
\   - where fractions of c or hbar matter, quantities are PER-MILLE:
\     1000 = 1.0 = c = hbar (the classic Forth scaled-integer idiom)
\
\ Tested by FeynmanEquations_Tests in the Henceforth suite.

\ ---------- tools -------------------------------------------------------

: sq   ( n -- n*n )  dup * ;

: cubed   ( n -- n*n*n )  dup sq * ;

: isqrt   ( n -- root )  \ floor square root, Newton's method
   dup 2 < if exit then
   dup
   begin  2dup / over + 2/  2dup >  while  nip  repeat
   drop nip ;

\ ---------- work and potential energy (ch 13-14) ------------------------

: kinetic-energy   ( m v -- T )  \ kinetic energy is half the mass times the speed squared: T = 1/2 m v^2
   sq * 2/ ;

: weight-energy   ( m g z -- U )  \ potential energy is mass times gravity times height: U = m g z
   * * ;

: spring-energy   ( k x -- U )  \ spring energy is half the stiffness times the stretch squared: U = 1/2 k x^2
   sq * 2/ ;

: gravity-force   ( mu m r -- F )  \ gravity pulls with the sun's strength times the mass, divided by
\ the distance squared: F = mu m / r^2   (mu = GM)
   sq >r * r> / ;

: gravity-energy   ( mu m r -- U )  \ gravitational energy is minus the sun's strength times the mass,
\ over the distance: U = -mu m / r
   >r * r> / negate ;

: gradient-force   ( dU dx -- Fx )  \ force is minus the change in energy over the change in
\ position: Fx = -dU/dx
   / negate ;

\ ---------- momentum and rotation (ch 18-19) ----------------------------

: momentum   ( m v -- p )  \ momentum is mass times velocity: p = m v
   * ;

\ Both torque and angular momentum are the z-component of a cross
\ product — position across force, or position across momentum — one
\ shape, factored once: tau = xFy - yFx, L = xpy - ypx.
: cross-z   ( x ay y ax -- z )
   * >r * r> - ;

: torque   ( x fy y fx -- tau )  cross-z ;

: angular-momentum   ( x py y px -- L )  cross-z ;

: spin-momentum   ( m w r -- L )  \ angular momentum is mass times spin rate times radius
\ squared: L = m w r^2
   sq * * ;

: spin-energy   ( i w -- T )  \ rotational energy is half the moment of inertia times the spin
\ rate squared: T = 1/2 I w^2
   sq * 2/ ;

: rim-speed   ( w r -- v )  \ rim speed is spin rate times radius: v = w r
   * ;

: rod-inertia-end   ( m l -- I )  \ a rod swung from one end resists with a third of its mass times
\ its length squared: I = M L^2 / 3
   sq * 3 / ;

: rod-inertia-middle   ( m l -- I )  \ swung from its centre, a twelfth of the mass times the length
\ squared: I = M L^2 / 12
   sq * 12 / ;

: parallel-axis   ( ic m r -- I )  \ inertia about a shifted axis is the centre inertia plus the mass
\ times the shift squared: I = Ic + M Rcm^2
   sq * + ;

: centre-of-mass   ( m1 r1 m2 r2 -- Rcm )  \ the balance point: each mass times its position, summed, over the
\ total mass: R = (m1 r1 + m2 r2) / (m1 + m2)
   over * 2swap over * rot +  rot rot +  / ;

\ ---------- special relativity (ch 15-17), per-mille of c ---------------

: lorentz-gamma   ( v -- gamma )  \ gamma is one over the square root of one minus the speed squared
\ over light speed squared: gamma = 1 / sqrt(1 - v^2/c^2)
   sq 1000000 swap - isqrt  1000000 swap / ;

: moving-mass   ( m0 v -- m )  \ a moving mass is the rest mass times gamma: m = m0 gamma
   lorentz-gamma 1000 */ ;

: rest-energy   ( m0 -- E )  \ energy equals rest mass — with light speed set to one they are
\ the same number: E = m0
   ;

: energy-momentum   ( p m0 -- E )  \ energy squared is momentum squared plus rest mass squared, light
\ speed one: E^2 = p^2 + m0^2
   sq swap sq + isqrt ;

\ ---------- the harmonic oscillator (ch 21-25), per-mille ---------------

: period-of   ( w0 -- t0 )  \ the period is two pi over the angular frequency: t0 = 2 pi / w0
\ (milli-radians per second in, milliseconds out)
   6283000 swap / ;

: resonance   ( k m -- w0 )  \ the resonant frequency is the square root of stiffness over
\ mass: w0 = sqrt(k/m) — answer per-mille
   1000000 swap */ isqrt ;

: q-factor   ( w0 gamma -- Q )  \ the quality factor is the resonant frequency over the
\ damping: Q = w0 / gamma
   / ;

: forced-amplitude   ( f0 m w0 w -- x )  \ the response is the drive strength over the mass times the gap
\ between the frequencies squared: x = F0 / m (w0^2 - w^2)
   sq swap sq swap -  * / ;

\ ---------- electricity (ch 23-25) --------------------------------------

: ohms-law   ( i r -- v )  \ volts equal current times resistance: V = I R
   * ;

: capacitor-volts   ( q c -- v )  \ volts equal charge over capacitance: V = q / C
   / ;

\ ---------- gases and heat (ch 39) --------------------------------------

: pressure   ( f a -- p )  \ pressure is force over area: P = F / A
   / ;

: gas-pressure   ( n kt v -- p )  \ pressure times volume equals the molecule count times Boltzmann's
\ constant times temperature: P V = N k T
   >r * r> / ;

: pressure-energy   ( u -- pv )  \ pressure times volume is two thirds of the internal
\ energy: P V = 2/3 U
   2 3 */ ;

\ ---------- quantum behaviour (ch 37-38), hbar = 1 ----------------------

: photon-energy   ( w -- E )  \ a photon's energy is Planck's constant times its frequency — with
\ the constant set to one, energy IS frequency: E = hbar w
   ;

: photon-momentum   ( k -- p )  \ and its momentum is the constant times the wave number,
\ likewise: p = hbar k
   ;

: uncertainty   ( dp -- dx )  \ the spread in position is at least Planck's constant over the
\ spread in momentum: dx >= hbar / dp — per-mille both sides
   1000000 swap / ;

53 constant bohr-radius  \ the size of an atom: the Bohr radius is 0.528 angstrom,
\ fifty-three picometres: a0 = hbar^2 / (m e^2)
-13600 constant bohr-energy  \ hydrogen's ground state energy is minus 13.6 electronvolts,
\ stored in thousandths: E0 = -13.6 eV

\ ---------- statistical mechanics (ch 41) -------------------------------

: random-walk   ( n l -- rms )  \ the mean squared wander is the step count times the step length
\ squared, so the typical distance is the step length times the
\ square root of the count: Rrms = L sqrt(N)
   swap isqrt * ;

\ ---------- and Kepler, for the film ------------------------------------

: kepler?   ( t1 a1 t2 a2 -- flag )  \ the square of the period is proportional to the cube of the
\ orbit — true when T1^2 a2^3 = T2^2 a1^3
   cubed rot cubed rot sq *  rot rot  swap sq *  = ;

\ ---------- a worked example with variables -----------------------------

variable apple-mass    \ grams
variable drop-height   \ metres
102 apple-mass !
10 drop-height !

: apple-energy   ( -- millijoules )  \ energy is mass times gravity times height, gravity taken as nine
\ point eight one: U = m g z
   apple-mass @  981  drop-height @  * *  100 / ;
