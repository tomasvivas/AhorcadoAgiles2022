Feature: UI Tests

A short summary of the feature

@UITests
Scenario: Usuario ingresa una letra correcta
	Given Usuario ingresa una <Palabra>
	When Usuario ingresa una letra <Correcta>
	Then La letra se muestra en la palabra a adivinar

	Examples:
	| Palabra           | Correcta |
	| 'pato'            | 'a'      |
	| 'serpiente'       | 'e'      |
	| 'reactor nuclear' | ' '      |

@UITests
Scenario: Usuario ingresa una letra incorrecta
	Given Usuario ingresa una <Palabra>
	When Usuario ingresa una letra <Incorrecta>
	Then Se descuenta un punto de vida
	 And La letra se muestra en letras incorrectas

	Examples:
	| Palabra           | Incorrecta |
	| 'pato'            | 'i'        |
	| 'serpiente'       | 'h'        |
	| 'reactor nuclear' | '?'        |

@UITests
Scenario: Usuario gana el juego
	Given Usuario ingresa una <Palabra>
	When Usuario ingresa todas las letras <Correctas>
	Then Usuario gana la partida

	Examples:
	| Palabra           | Correctas                 |
	| 'pato'            | ['p','a','t','o']         |
	| 'serpiente'       | ['serpiente']             |
	| 'reactor nuclear' | ['reactor',' ','nuclear'] |

@UITests
Scenario: Usuario pierde el juego
	Given Usuario ingresa una <Palabra>
	When Usuario pierde todas las vidas ingresando letras <Incorrectas>
	Then Usuario pierde la partida

	Examples:
	| Palabra           | Incorrectas                              |
	| 'pato'            | ['e','i','s','o','r']                    |
	| 'serpiente'       | ['auto','auto','auto','auto','auto']     |
	| 'reactor nuclear' | ['caliente','otra palabra','h','i','?' ] |
