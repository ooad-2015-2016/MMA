# MMA
## Rent a car
#### Članovi tima:
1. Mensur Kurtagić
2. Adnana Šantić
3. Mahira Mahmutović

## Opis teme
Rent-a-car aplikacija omogućava efikasniji rad rent a car agencije i također korisnicima odnosno klijentima nudi pojednostavljenje i znatno ubrzanje procesa izdavanja vozila. Na ovaj način se omogućava jednostavno kreiranje ugovora između korisnika i agencije i adekvatna sinhronizacija aktivnosti agencije. Arhitektura aplikacije omogućava rad u više geografski udaljenih 
poslovnica koje međusobno jedinstvo podataka održavaju sinhronizacijom kroz Internet server. Aplikacija je dostupna korisniku sa uređajem koji ima pristup internetu. 

## Procesi
#### Proces registracije klijenta
Korisnik popunjava formular sa ličnim podacima.
#### Proces rezervacije
Korisnik iz postojeće baze vrši odabir dostupnih vozila. Prije pristupa bazi neophodno je da korisnik odabere grad/poslovnicu i da unese datum preuzimanja i vraćanja vozila, nakon čega dobija ponudu dostupnih automobila u tom gradu i u to vrijeme. Korisnik ima mogućnost naknadnog produžavanja trajanja rezervacije.
#### Proces ažuriranja baze dostupnih vozila
Nakon rezervacije određenog vozila od strane klijenta neophodno je u sistemu to isto vozilo označiti kao nedostupno u periodu trajanja te iste rezervacije, isti slučaj je i prilikom odvođenja vozila u servis. Prilikom povratka vozila u poslovnicu isto se označava kao dostupno u bazi. 
#### Proces naplate usluga
Vrši se na licu mjesta (u poslovnici) prilikom povratka vozila. O cijeni je klijent bio obavješten prilikom procesa rezervacije. Dodatni popust za članove VIP kluba kao i za plaćanje karticom.
#### Proces nabavke novih vozila
Zadatak menadžera. Analizira stanje u agenciji (potražnja) i donosi zaključak o dovoljnoj/nedovoljnoj opremljenosti o čemu obavještava direktora (izvještaj). Direktor zatim donosi odluku o novoj nabavci.

## Funkcionalnosti
- Mogućnost pregledavanja stanja vozila
- Uvid u status svakog vozila na osnovu njegovog tehničkog pregleda (servisa)
- Mogućnost uvida u zauzeća auta od strane pojedinih korisnika s ciljem kreiranja bolje ponude za iste
- Mogućnost uvida u najviše i najmanje iznajmljivani automobil (radi ocjenjivanja potražnje)
- Mogućnost uvida u ocjene korisnika (zarad poboljšanja kvalitete usluge)

## Akteri

- Korisnik usluga (klijent, online klijent)

ima mogućnost iznajmljivanja i rezervacije automobila u poslovnici (klijent) ili putem online sistema (online klijent)

- Uposlenik

radi na poslovima iznajmljivanja, rezervacije, naplaćivanja, ažuriranja VIP kluba (dodavanje novih/brisanje postojećih članova u bazi softvera)

- Vozač

po želji klijenta dovodi vozilo na ugovoreno mjesto i dodatno vrsi usluge vožnje uz novčanu naknadu (za članove VIP kluba ova usluga je besplatna)

- Menadžer

bavi se nabavkom novih vozila uz adekvatno obnavljanje baze podataka u softveru, zatim održavanjem voznog parka (registracija, popravka...), također provjerava ispravnost softvera i usljed eventualnog kvara preduzima adekvatne radnje

- Direktor

ima kontrolu nad sveukupnim procesom