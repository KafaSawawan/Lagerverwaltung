# Lagerverwaltungsprogramm

## Projektbeschreibung
Das Lagerverwaltungsprogramm ermöglicht es, den Bestand von Artikeln in einem Lager zu verwalten. Es bietet grundlegende Funktionen zur Verwaltung von Artikeln, zur Bestandsaufnahme und zur Ausgabe von Berichten. Zusätzlich können Lagerplätze und Benutzer verwaltet werden.

## Funktionen

### 1. **Artikel hinzufügen**
- **Funktion**: Der Benutzer kann neue Artikel zum Lagerbestand hinzufügen.
- **Daten**:
  - Artikelnummer (eindeutig)
  - Artikelname
  - Beschreibung
  - Menge
  - Preis pro Einheit

### 2. **Artikel bearbeiten**
- **Funktion**: Der Benutzer kann bestehende Artikel bearbeiten.
- **Änderungen**:
  - Artikelname
  - Beschreibung
  - Menge
  - Preis pro Einheit

### 3. **Artikel löschen**
- **Funktion**: Der Benutzer kann einen Artikel aus dem System entfernen.

### 4. **Bestand anzeigen**
- **Funktion**: Der Benutzer kann eine Übersicht aller Artikel im Lager anzeigen.
  - **Filter**:
    - Nach Artikelname oder Beschreibung suchen
    - Nach Menge filtern (Artikel mit Menge ≤ 3 oder > 3)
    - Nach Lagerplatz filtern
  - **Sortierung**:
    - Artikelnummer, Artikelname, Menge, Preis pro Einheit sortieren
  - **Farbliche Markierung**:
    - Artikel mit wenig Bestand (z. B. ≤ 3) werden rot markiert.

### 5. **Bestand aktualisieren**
- **Funktion**: Der Benutzer kann die Menge eines Artikels erhöhen oder verringern (z. B. bei Wareneingang oder -ausgang).

### 6. **Statistik generieren**
- **Funktion**: Der Benutzer kann eine Statistik erstellen (z. B. die fünf häufigsten Artikel im Lager) mit grafischer Darstellung.

### 7. **Lagerplätze verwalten** (Zusatzfunktion)
- **Funktion**: Der Benutzer kann mehrere Lagerplätze anlegen und verwalten.
  - **Daten**: Name und Standort des Lagerplatzes.

### 8. **Benutzer verwalten** (Zusatzfunktion)
- **Funktion**: Das System unterstützt mehrere Benutzer mit unterschiedlichen Rechten.
  - **Benutzerdaten**:
    - Name
    - Rolle (z. B. Admin, Mitarbeiter)
    - Passwort

## Technische Anforderungen
- **Programmiersprache**: C# mit Blazor (für Frontend) und Entity Framework Core (für Datenbankzugriff).
- **Datenbank**: Microsoft SQL Server.
- **Benutzeroberfläche**: Eine ansprechende und benutzerfreundliche grafische Oberfläche.
- **Fehlerbehandlung**: Das Programm implementiert grundlegende Fehlerbehandlungen wie Eingabefehler.

## Datenbankmodell

Die Datenbank besteht aus folgenden Tabellen:

1. **Artikel**:
   - `ArtikelId` (Primärschlüssel)
   - `Artikelname`
   - `Beschreibung`
   - `Menge`
   - `PreisProEinheit`
   - `LagerplatzId` (Fremdschlüssel zu Lagerplatz)

2. **Lagerplatz**:
   - `LagerplatzId` (Primärschlüssel)
   - `Name`
   - `Standort`

3. **Benutzer**:
   - `BenutzerId` (Primärschlüssel)
   - `Name`
   - `Rolle`
   - `Passwort`

<img src="img/dbdiagram.png" width="500px" />
Table Lagerplatz {
  id integer [primary key]
  name varchar
  standort varchar 
}

Table Artikel {
  id integer [primary key]
  artikelname varchar
  beschreibung varchar
  menge integer
  preis float
  lager_id integer
}



Ref: Artikel.lager_id > Lagerplatz.id // many-to-one

