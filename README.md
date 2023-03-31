# Project: DeadBy2d
Biel.C & David.C
Repo: https://github.com/BielComas/DeadBy2D

## Gameplay
4 supervivents, 1 killer, donar voltes pel mapa per fer gens, tirant pales a tort i a dret per tocar li la polla al killer mentres ens face campeja :D

## Coses que s’han de crear
- Mapa de prova
- Entitats de prova
- Mapa
- Entitats
- Animacions
- Scripts
- Testing
- Solucionar Bugs

## Entities
### Game

┌───────────────────┬───────────────────────────┬─────────────────────────────────────────────────────────────────────┐
│ var int           │ GensDone || GensRemaining │ Variable que  indica la quantitat de generadors reparats            │
│ var int           │ SurviorsAlive             │ Variable que  indica la quantitat de supervivents vius a la partida │
│ var list || array │ Offerings                 │ Llista que conté les Ofrenes fetes                                  │
│ func void         │ EndGame                   │ Funció que canvia l’estat del joc                                   │
└───────────────────┴───────────────────────────┴─────────────────────────────────────────────────────────────────────┘

### Survivor
var float
SurvivorSpeed
Velocitat de movoment

var survivor_estate
SurvivorEstate
Estat del survivor (Normal,Ferit,Tirat,Penjat)

var int
SurvivorLifes
Cops que li queden per ser penjat (2,1,0).

var bool
SurvivorCanMove
Indica si es pot moure(no es podra moure quan es transportat pel killer, en una taquilla, al ganxo o reparant)

var list || array
SurvivorPerks
Conté les habilitats dels survivors

var object
SurvivorObject
Conté l’objecte que porta

func void 
SurvivorTakeDamage
Canvia l’estat
Animació de rebre l'hòstia
++ velocitat 
Passa X temps
– – velocitat

func void
SurvivorRepair
No es pot moure
Fa animació de reparar

func void
SurvivorDie
C muere

func void
SurvivorSkillCheck
Salta skill-check

func void
SurvivorCrouch
Redueix velocitat
Animació acotat

func void
SurvivorTrowPalet

func void
SurvivorJumpWindows

func void
SurvivorJumpPalet

func void
SurvivorHideLocker

func void
SurvivorSearch
### Killer
var float
KillerSpeed

var bool
KillerCanMove

var killer_estate
KillerEstate

var list || array
KillerPerks

var Power
KillerPower

func void
KillerAttack

func void
KillerKickGen

func void
KillerGrabSurvivor

func void
KillerCheckLoker

func void
KillerHook

func void
KillerJump

func void
KillerCloseHatch
aquesta no la vull ficar, ta feo XD

### Gens
var float
GenRepairValue

var gen_estate
GenEstat

func void
GenDone

func void
GenBreakingDown

func void
GenTakeDamage

### Objectes
var float
ObjectUsableValue

func void
ObjectUse

func void
ObjectDestroy

### Pales
var palet_estate
Estat

func void
PaletDown

func void
PaletDestroy

### Cofres
var bool
Opened

var object
Object

func void
Searching

func void
Open

### Portes
### Interruptor
### Trampilla