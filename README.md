# InteractionOverrideSample
Beispiel zum Reproduzieren

## Schritte zum Reproduzieren

1. VS Projekt erstellen 
2. EPLAN starten 
3. EPLAN Projekt öffenen (2024)
4. EDZ importieren (stammt aus EPLAN_parts.alk)
5. Gerät einfügen `SIE.6EP1322-5BA10`
6. ![](Images\PropertyArrangements_ok.png)
7. Eigenschaftsanordnung wird angezeigt
8. API Addin laden `Sample.EplAddIn.InteractionOverride.dll`
9. Gerät einfügen `SIE.6EP1322-5BA10`
10. ![](Images\PropertyArrangements_not_ok.png)

## Erwartetes Verhalten

Wird eine Interaction überschrieben und in den überschriebenen Methoden die base Methode aufgerufen, so sollte das Verhalten identisch sein. 

## Aktuelles Verhalten

Eigenschaftsanordnung wird mit geladenen AddIn nicht angezeigt. Wird das Addin entladen und das Projekt geschlossen und erneut geöffnet, wird die Eigenschaftsanordnung wieder angezeigt. 
