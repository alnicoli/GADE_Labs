# GDD Custom PacMan

## Idee
PacMan ist ein Klassiker und macht auch nach Jahrzehnten noch sehr viel Spass. Aufbauend auf PacMan kam uns die Idee, die Spielregeln ein wenig zu verändern. In unserer Version des PacMan-Spiels sind die Mauern / Hindernisse nicht statisch, sondern sollen sich nach definierter Zeit umstrukturieren, sodass sich eine komplett neue und unbekannte Spielsituation ergibt. Ob die neue Situation dem Spieler schadet oder nützt ist ganz dem Zufall überlassen.
## Mechanik
Die Figur PacMan wandert durch ein Labyrinth und muss Punkte fressen, während die Figur von Geistern gejagt wird. Frisst der Spieler eine "Kraftpille", kann dieser für eine Gewisse Zeit die Geister (nun blau gefärbt) fressen und erleidet dabei keinen Schaden. Hin und wieder erscheinen Fruchtsymbole im Labyrinth, welche auch gefressen werden können und Extrapunkte geben. Während dem ganzen Spielverlauf werden die Wände regelmässig automatisch umstrukturiert, sodass sich das Labyrinth verändert. Werden alle Punkt gefressen ist das Level geschafft.
## Steuerung
Wir verwenden eine simple WASD für die Richtungssteuerung, Alternitativ stehen auch die Pfeiltasten zur verfügung.
Mit der Leertaste lässt sich das Spiel pausieren.
Die Escape taste pausiert das Spiel und öffnet das Menü. Im Menü kann mit W & S resp. mit Pfeil Hoch und Pfeil Hinunter Menüpunkte ausgewählt werden. Die Enter Taste öffnet den Menü Punkt, die Leertste schaltet bestimmte Punkte um und Escape Taste schliesst den Menü punkt, ist kein Menüpunkt mehr offen, schliesst Escape das Menu und das Spiel läuft weiter.
## Grafik
Die Kamera erzeugt einen Top-Down view, die Wande und Figuren sind in 3d. Anders als beim Original zeigt dei Kamera nicht das ganze Spielfeld sondern nur den Teil, in dem Spieler gerade befindet, die Kamera ist dabei auf den Spieler zentriert.
Die Charaktere im Spiel folgen vom Design her dem Original, der Spieler (Pac Man) ist eine Gelbe Sphäre mit sich öffnenden und schliessendem Mund. Die 4 Geister sind Rot, Pink, Hellblau und Orange und haben die Form der Klassischen Geister.
Die zu sammelten Punkte sind schlichte kleine gelb leuchtende Sphären. Die Früchte haben die formen von Kirschen, Äpfeln, Bananen und Ananas.
Damit das Spiel für das Auge nicht langweilig wird, gibt es meherere Stile des Spielfeldes, der Stil wird zufällig ausgewählt
### Verlies
Hierbei Orientierten wir uns an schmalen korridoren wie Sie in Mittelalterlichen Festungen vorzufinden sind. Das Spielfeld wird mit Fackeln an den Wänden Beleuchtet. Flecken, Risse und fehlende Steine am Boden und an den Wänden sollen den Eindruck der Verwitterung erwecken. Einzelne Räume werden mit Käfigen und mittelarterlichen Folterinstrumenten Dekoriert.
### Raumstation
In der Raumstation sind lange weisse mit kalten Licht beleuchtete Gänge. Gelegentliche Fenster am Boden zeigen eine Ansicht der Erde und den Weltraum. Es gibt einzelne Räume die mit Konsolen und Servern dekoriert sind. An den Wanden finden sich Panele mit blinkenden Leuschten.
### Mine
Die Mine zeichnet sich durch dunkle, erdige Gänge aus, als Beleuchtung dienen alte Öllampen die an den Stützverstrebungen hängen die in den Gängen in regelmässigen abstand stehen. In einigen Gängen verlaufen Schienen und es gibt Räume mit Kisten und Material.
## Coding
Das Spiel verwendet eine Collision Detection, je nach dem, mit welchen Object der Spieler kollidiert, wird eine andere aktion ausgeführt.
### Weltengenerierung
Die Verschiedenen Stufen des Spielfelds (Max 10, danach Repetition) werden im Voraus berechnet. um zu garantieren das kein Abschnitt erstellt wird, der nicht erreichbar ist, verwenden wir einen Pfadfinder Algorithmus (Dijkstra) und prüfen somit das jeder begehbare Punkt von Startpunkt aus erreichbar ist.
### KI der Geister
Die KI der Geister folgt ebenfalls dem Originalspiel
#### "Scatter Mode"
Frisst der Spieler eine Kraftpille, fallen die Geister in den Scatter Mode und versuchen einen in fest vorgegebenen Punkt am Rand des Spielfeldes zu erreichen.
#### Roter Geist "Blinky"
Blinky sucht immer den direktesten Weg zur Position des Spielers
#### Pinker Geist "Pinky"
Pinky versucht dem Spieler den Weg abzuschneiden in dem er die Position und Ausrichtung des Spielers verwendet
#### Hellblauer Geist "Inky"
Inky verhält sich ähnlich wie Pinky mit dem Unterschied das er zusätzlich die Position und Bewegungsrichtung von Blinky verwendet um den Spieler einzukreisen. Inky kooperiert also mit Blinky.
#### Oranger Geist "Clyde"
Clyde verhält sich eher feige und versucht vor Pac Man zu seiner Ecke im Scatter Mode zu kommen, sollte er sich Pac Man zu sehr nähern. Ist Pac Man genug weit entfernt, verhält er sich wie Blinky
