/**
  *
  * Beschreibung
  *
  * @version 1.0 vom 24.03.2016
  * @author Sebastian Mischke
  */

import java.util.*;
 
public class Person {
  
  // Anfang Attribute
  private int id;
  private String nachname;
  private String vorname;
  private char geschlecht;
  private Date gebdat;
  private Person vater;
  private int vaterid;
  private Person mutter;
  private int mutterid;
  private Person ehepartner;
  private int ehepartnerid;
  // Ende Attribute
  
  public Person() {
    this.id = 0;
    this.nachname = "";
    this.vorname = "";
    this.gebdat = null;
    this.vater = null;
    this.vaterid = 0;
    this.mutter = null;
    this.mutterid = 0;
    this.ehepartner = null;
    this.ehepartnerid = 0;
  }
  
  public Person(int id, String nachname, String vorname, char geschlecht, Date gebdat, Person vater, int vaterid, Person mutter, int mutterid, Person ehepartner, int ehepartnerid) {
    this.id = id;
    this.nachname = nachname;
    this.vorname = vorname;
    this.geschlecht = geschlecht;
    this.gebdat = gebdat;
    this.vater = vater;
    this.vaterid = vaterid;
    this.mutter = mutter;
    this.mutterid = mutterid;
    this.ehepartner = ehepartner;
    this.ehepartnerid = ehepartnerid;
  }
  
  
  public Person(int id, String nachname, String vorname, char geschlecht, Date gebdat, Person vater, Person mutter, Person ehepartner) {
    this.id = id;
    this.nachname = nachname;
    this.vorname = vorname;
    this.geschlecht = geschlecht;
    this.gebdat = gebdat;
    this.vater = vater;
    this.mutter = mutter;
    this.ehepartner = ehepartner;
    this.vaterid = 0;
    this.mutterid = 0;
    this.ehepartnerid = 0;
  }
  
  
  public Person(int id, String nachname, String vorname, char geschlecht, Date gebdat, int vaterid, int mutterid, int ehepartnerid) {
    this.id = id;
    this.nachname = nachname;
    this.vorname = vorname;
    this.geschlecht = geschlecht;
    this.gebdat = gebdat;
    this.vaterid = vaterid;
    this.mutterid = mutterid;
    this.ehepartnerid = ehepartnerid;
    this.vater = null;
    this.mutter = null;
    this.ehepartner = null;
  }
  
  
  public Person(int id, String nachname, String vorname, char geschlecht, Person vater, int vaterid, Person mutter, int mutterid, Person ehepartner, int ehepartnerid) {
    this.id = id;
    this.nachname = nachname;
    this.vorname = vorname;
    this.geschlecht = geschlecht;
    this.vater = vater;
    this.vaterid = vaterid;
    this.mutter = mutter;
    this.mutterid = mutterid;
    this.ehepartner = ehepartner;
    this.ehepartnerid = ehepartnerid;
    this.gebdat = null;
  }
  
  
  public Person(int id, String nachname, String vorname, char geschlecht, Person vater, Person mutter, Person ehepartner) {
    this.id = id;
    this.nachname = nachname;
    this.vorname = vorname;
    this.geschlecht = geschlecht;
    this.vater = vater;
    this.mutter = mutter;
    this.ehepartner = ehepartner;
    this.gebdat = null;
    this.vaterid = 0;
    this.mutterid = 0;
    this.ehepartnerid = 0;
  }
  
  
  public Person(int id, String nachname, String vorname, char geschlecht, int vaterid, int mutterid, int ehepartnerid) {
    this.id = id;
    this.nachname = nachname;
    this.vorname = vorname;
    this.geschlecht = geschlecht;
    this.vaterid = vaterid;
    this.mutterid = mutterid;
    this.ehepartnerid = ehepartnerid;
    this.gebdat = null;
    this.vater = null;
    this.mutter = null;
    this.ehepartner = null;
  }
  
  
  // Anfang Methoden
  public String getNachname() {
    return nachname;
  }
  
  public void setNachname(String nachname) {
    this.nachname = nachname;
  }
  
  public String getVorname() {
    return vorname;
  }
  
  public void setVorname(String vorname) {
    this.vorname = vorname;
  }
  
  public Date getGebdat() {
    return gebdat;
  }
  
  public void setGebdat(Date gebdat) {
    this.gebdat = gebdat;
  }
  
  public int getId() {
    return id;
  }
  
  public void setId(int id) {
    this.id = id;
  }
  
  public Person getVater() {
    return vater;
  }
  
  public void setVater(Person vater) {
    this.vater = vater;
  }
  
  public Person getMutter() {
    return mutter;
  }
  
  public void setMutter(Person mutter) {
    this.mutter = mutter;
  }
  
  public Person getEhepartner() {
    return ehepartner;
  }
  
  public void setEhepartner(Person ehepartner) {
    this.ehepartner = ehepartner;
  }
  
  public int getAlter() {
    // TODO: Calculate age
    return 18;
  }
  
  public int getVaterid() {
    return vaterid;
  }
  
  public void setVaterid(int vaterid) {
    this.vaterid = vaterid;
  }
  
  public int getMutterid() {
    return mutterid;
  }
  
  public void setMutterid(int mutterid) {
    this.mutterid = mutterid;
  }
  
  public int getEhepartnerid() {
    return ehepartnerid;
  }
  
  public void setEhepartnerid(int ehepartnerid) {
    this.ehepartnerid = ehepartnerid;
  }
  
  public char getGeschlecht() {
    return geschlecht;
  }
  
  public void setGeschlecht(char geschlecht) {
    this.geschlecht = geschlecht;
  }
  
  public String getAhnenziffer() {
    // TODO: return tree section
    return 0; 
  }
  
  
  // Ende Methoden
} // end of Person
