Feature: UI Tests

A short summary of the feature

@UITests
Scenario: Usuario ingresa una letra correcta
	Given Usuario ingresa un nombre
	When Usuario ingresa una letra <Correcta>
	Then La letra se muestra en la palabra a adivinar

	Examples:
	| Correcta |
	| 'a'      |
	| 't'      |
	| 'o'      |

@UITests
Scenario: Usuario ingresa una letra incorrecta
	Given Usuario ingresa un nombre
	When Usuario ingresa una letra <Incorrecta>
	Then Se descuenta un punto de vida
	 And La letra se muestra en letras incorrectas

	Examples:
	| Incorrecta |
	| 'i'        |
	| 'h'        |
	| '?'        |

@UITests
Scenario: Usuario gana el juego
	Given Usuario ingresa un nombre
	When Usuario ingresa todas las letras <Correctas>
	Then Usuario gana la partida

	Examples:
	 | Correctas         |
	 | ['p','a','t','o'] |
	 | ['pato']          |
	 | ['t','a','o','p'  |

@UITests
Scenario: Usuario pierde el juego
	Given Given Usuario ingresa un nombre
	When Usuario pierde todas las vidas ingresando letras <Incorrectas>
	Then Usuario pierde la partida

	Examples:
	 | Incorrectas           |
	 | ['e','i','s','m','r'] |
	 | ['toro']              |
	 | ['error']             |
