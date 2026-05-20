# Katalog kontrol MH (public) — vertikální export do Markdown
- Zdroj: `Katalog kontrol MH(public)_1.4.1.2.xlsx`
- Vygenerováno: 2026-01-22T14:42:24Z
- Verze zdroje (odhad z názvu): 1.4.1.2

---

## List: Titulní strana
- Rozsah listu dle `dimensions`: `A6:A10`

| Řádek | Sloupec | Buňka | Hodnota | Komentář |
|---:|:---:|:---:|---|---|
| 6 | A | A6 | Název projektu: Zajištění redesignu agendy zaměstnanosti s ohledem na digitalizaci procesů a snížení administrativní zátěže |  |
| 7 | A | A7 | Registrační číslo projektu: CZ.31.2.0/0.0/0.0/23_090/0010634 |  |
| 8 | A | A8 | Verze dokumentu k API: 1.4.1.2 |  |
| 9 | A | A9 | MPSV poskytuje dodavatelům za účelem analýzy dopadů zákona o JMHZ popis datových položek, které budou zaměstnavatelé uvádět v povinných hlášeních podle připravovaného zákona o JMHZ. Popis je poskytován s výhradou případných změn, protože u zákona o JMHZ ani u nařízení vlády, které bude zákonné povinnosti předávat povinná hlášení konkretizovat, ještě nebyl ukončen legislativní proces a v jeho průběhu nejsou vyloučeny změny vyvolané průběhem zbývající části legislativního procesu. Změny mohou být nutné, pokud dojde k uplatnění pozměňovacích návrhů v Senátu a jejich schválení Poslaneckou sněmovnou. Rovněž nelze vyloučit změny v případě zásadních připomínek uplatněných při projednávání nařízení vlády k JMHZ Legislativní radou vlády ČR.  |  |

- Počet uvedených buněk (nenulová hodnota a/nebo komentář): **4**

---

## List: MH
- Rozsah listu dle `dimensions`: `A1:N201`

| Řádek | Sloupec | Buňka | Hodnota | Komentář |
|---:|:---:|:---:|---|---|
| 1 | A | A1 | ID Kontroly<br><br>kód chyby DIS = ID Kontroly + 20000<br>kód chyby cJMHZ = ID kontroly + 40000<br> | Josef Dvořák: ID kontroly = unikátní klíč kontroly |
| 1 | B | B1 | Název kontroly | Josef Dvořák: Jedinečný název kontroly. Navrhuje procesní tým JMHZ |
| 1 | C | C1 | Seznam ID atributů, kterých se kontrola týká | Josef Dvořák: Id atributů podle datového slovníku, na které se kontrola vztahuje. Například kontrola fomátu RČ se uplatní u všech RČ. |
| 1 | D | D1 | Oblast atributu z DS (dat. slovník) |  |
| 1 | E | E1 | Typ formuláře<br>(v závorce identifikátor oblasti chyby na systému DIS) |  |
| 1 | F | F1 | Systém realizující prevalidační kontrolu pro ePortál |  |
| 1 | G | G1 | Propustnost / Nepropustnost kontroly pro prevalidační kontrolu na ePortálu |  |
| 1 | H | H1 | Systém realizující kontrolu [DIS / cJMHZ] |  |
| 1 | I | I1 | Propustnost / Nepropustnost kontrol na DIS nebo cJMHZ |  |
| 1 | J | J1 | Kategorie kontroly  |  |
| 1 | K | K1 | Detailní popis prováděné kontroly | Josef Dvořák: Popis kontroly. Může být vzorec, slovní popis nebo jiná forma. Regex výrazy bude psát Eviden.<br><br>podle dokumentu (viz odkaz) - doplnit odkaz a kategorie a la F4, F3 apod. Dle Sjednocení názvu kontrol JMHZ a jejich rozdělení.xlsx (sharepoint.com) |
| 1 | L | L1 | Chybová hláška | Josef Dvořák: Jedinečná chybová hláška. Navrhuje tým JMHZ. |
| 1 | M | M1 | Zdroj kontroly z as-is stavu anebo "nová" |  |
| 1 | N | N1 | Poznámka |  |
| 2 | A | A2 | 1 |  |
| 2 | B | B2 | Počet zaměstnanců se slevou |  |
| 2 | C | C2 | 10030<br>10372 |  |
| 2 | D | D2 | Přehled o výši pojistného |  |
| 2 | E | E2 | Formulář PVPOJ a zaměstnance |  |
| 2 | F | F2 | ePortál |  |
| 2 | G | G2 | propustná |  |
| 2 | H | H2 | cJMHZ |  |
| 2 | I | I2 | propustná |  |
| 2 | J | J2 | F5 |  |
| 2 | K | K2 | Počet zaměstnanců, za které zaměstnavatel uplatňuje slevu na pojistném s vyplněnými údaji jednotlivých zaměstnanců (10372) = "ANO" musí být = Počet zaměstnanců (10030).<br>---<br>10030 Počet zaměstnanců<br>10372 Sleva na pojistném |  |
| 2 | L | L2 | Nesouhlasí počet zaměstnanců, za které zaměstnavatel uplatňuje slevu na pojistném. |  |
| 2 | M | M2 | nová |  |
| 3 | A | A3 | 3 |  |
| 3 | B | B3 | Sleva na pojistném |  |
| 3 | C | C3 | 10032<br>10031 |  |
| 3 | D | D3 | Přehled o výši pojistného |  |
| 3 | E | E3 | Formulář PVPOJ (pvpoj) |  |
| 3 | F | F3 | ePortál |  |
| 3 | G | G3 | nepropustná |  |
| 3 | H | H3 | DIS |  |
| 3 | I | I3 | nepropustná |  |
| 3 | J | J3 | F4 |  |
| 3 | K | K3 | ="Sleva na pojistném (10032) (zaokrouhlená na celé koruny nahoru) = "& 'Parametrické konstanty'!C6 &" % úhrnu vyměřovacích základů zaměstnanců (10031).<br>---<br>10031 Úhrn vyměřovacích základů zaměstnanců<br>10032 Sleva na pojistném zaměstnavatele<br>" |  |
| 3 | L | L3 | Sleva na pojistném neodpovídá úhrnu vyměřovacích základů zaměstnanců, za které je uplatňována. |  |
| 3 | M | M3 | PVPOJ 2023 1.1 |  |
| 3 | N | N3 | OŘ3: ČSSZ-215 |  |
| 4 | A | A4 | 4 |  |
| 4 | B | B4 | Vypočítané pojistné k úhradě |  |
| 4 | C | C4 | 10033<br>10029<br>10032<br>10487<br>10545 |  |
| 4 | D | D4 | Přehled o výši pojistného |  |
| 4 | E | E4 | Formulář PVPOJ (pvpoj) |  |
| 4 | F | F4 | ePortál |  |
| 4 | G | G4 | nepropustná |  |
| 4 | H | H4 | DIS |  |
| 4 | I | I4 | nepropustná |  |
| 4 | J | J4 | F4 |  |
| 4 | K | K4 | (10033) = (10029 - 10032 - 10487 - 10545)<br>---<br>10033 Vypočítané pojistné<br>10029 Pojistné celkem<br>10032 Sleva na pojistném zaměstnavatele<br>10487 Úhrn slev na pojistném zaměstnanců (pracující důchodci)<br>10545 Úhrn slev na pojistném zaměstnanců (ovocnáři) |  |
| 4 | L | L4 | Pojistné k úhradě neodpovídá vykázánému pojistnému celkem a případně odečítané slevě na pojistném zaměstnavatele či odečítaným úhrnům slev na pojistném zaměstnanců (pracujících důchodců a ovocnářů včetně). |  |
| 4 | M | M4 | PVPOJ 2023 1.1 |  |
| 4 | N | N4 | OŘ3: ČSSZ-215 |  |
| 5 | A | A5 | 7 |  |
| 5 | B | B5 | Úhrn vyměřovacích základů zaměstnanců zaměstnavatele, kteří nevykonávají činnost v rizikovém zaměstnání nebo činnost zdravotnického záchranáře nebo člena jednotky HZS podniku je roven vyměřovacím základům všech příslušných zaměstnanců |  |
| 5 | C | C5 | 10023<br>10477<br>10478<br>10239<br>10502 |  |
| 5 | D | D5 | Přehled o výši pojistného |  |
| 5 | E | E5 | Formulář PVPOJ a zaměstnance |  |
| 5 | F | F5 | ePortál |  |
| 5 | G | G5 | propustná |  |
| 5 | H | H5 | cJMHZ |  |
| 5 | I | I5 | propustná |  |
| 5 | J | J5 | F5 |  |
| 5 | K | K5 | Úhrn vyměřovacích základů zaměstnanců zaměstnavatele, kteří nevykonávají činnost v rizikovém zaměstnání nebo činnost zdravotnického záchranáře nebo člena jednotky HZS podniku (10023) se pro datové scénáře je vypočten:<br>1) činnosti K až S: <br> (10239) = "K" až "S" nebo, <br> (10239) = "1" až "9" s příznakem (10502) = "Pracovní vztah specifické skupiny"<br>2) pěstoun: (10239) = "M",<br> (10023) = ∑ (n) vyměřovacích základů dotčených zaměstnanců (10477)<br><br>pro ostatní dat. scénáře:  <br> (10023) = ∑ (n) vyměřovacích základů dotčených zaměstnanců (10478).<br>---<br>10023 Úhrn vyměřovacích základů zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku<br>10477 Částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné<br>10478 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ<br>10239 Druh činnosti<br>10502 Bližší určení pracovněprávního vztahu |  |
| 5 | L | L5 | Úhrn nesouhlasí se součtem vyměřovacích základů dotčených zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo činnost zdravotnického záchranáře nebo člena jednotky HZS podniku. |  |
| 5 | M | M5 | nová |  |
| 5 | N | N5 | OŘ3: ČSSZ-216 |  |
| 6 | A | A6 | 8 |  |
| 6 | B | B6 | Pojistné za zaměstnavatele u zaměstnanců,  kteří nevykonávají činnost v rizikovém zaměstnání nebo činnost zdravotnického záchranáře nebo člena jednotky HZS podniku |  |
| 6 | C | C6 | 10024<br>10023 |  |
| 6 | D | D6 | Přehled o výši pojistného |  |
| 6 | E | E6 | Formulář PVPOJ (pvpoj) |  |
| 6 | F | F6 | ePortál |  |
| 6 | G | G6 | nepropustná |  |
| 6 | H | H6 | DIS |  |
| 6 | I | I6 | nepropustná |  |
| 6 | J | J6 | F4 |  |
| 6 | K | K6 | ="Pojistné za zaměstnavatele (10024) = " & 'Parametrické konstanty'!C3 & " * Úhrn vyměřovacích základů zaměstnanců (10023), kteří nevykonávají činnost v rizikovém zaměstnání nebo činnost zdravotnického záchranáře nebo člena jednotky HZS podniku a nevykonávají rizikové zaměstnání. Zaokrohluje se na celé koruny nahoru." & CHAR(10) &<br>"---" & CHAR(10) &<br>"10023 Úhrn vyměřovacích základů zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku" & CHAR(10) &<br>"10024 Pojistné za zaměstnavatele u zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku" |  |
| 6 | L | L6 | Vykázané pojistné neodpovídá vykázánému úhrnu vyměřovacích základů zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo činnost zdravotnického záchranáře nebo člena jednotky HZS podniku. |  |
| 6 | M | M6 | nová |  |
| 6 | N | N6 | OŘ3: ČSSZ-215 |  |
| 7 | A | A7 | 9 |  |
| 7 | B | B7 | Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku |  |
| 7 | C | C7 | 10025<br>10479 |  |
| 7 | D | D7 | Přehled o výši pojistného |  |
| 7 | E | E7 | Formulář PVPOJ a zaměstnance |  |
| 7 | F | F7 | ePortál |  |
| 7 | G | G7 | propustná |  |
| 7 | H | H7 | cJMHZ |  |
| 7 | I | I7 | propustná |  |
| 7 | J | J7 | F5 |  |
| 7 | K | K7 | Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku (10025) se = ∑ (n) vyměřovacích základů dotčených zaměstnanců (10479).<br>---<br>10025 Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku<br>10479 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ  |  |
| 7 | L | L7 | Úhrn nesouhlasí se součtem vyměřovacích základů dotčených zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku. |  |
| 7 | M | M7 | nová |  |
| 7 | N | N7 | OŘ3: ČSSZ-216 |  |
| 8 | A | A8 | 10 |  |
| 8 | B | B8 | Pojistné za zaměstnavatele u zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku |  |
| 8 | C | C8 | 10026<br>10025 |  |
| 8 | D | D8 | Přehled o výši pojistného |  |
| 8 | E | E8 | Formulář PVPOJ (pvpoj) |  |
| 8 | F | F8 | ePortál |  |
| 8 | G | G8 | nepropustná |  |
| 8 | H | H8 | DIS |  |
| 8 | I | I8 | nepropustná |  |
| 8 | J | J8 | F4 |  |
| 8 | K | K8 | ="Pojistné za zaměstnavatele (10026) = " & 'Parametrické konstanty'!C4  & " * Úhrn vyměřovacích základů zaměstnanců (10025), kteří jsou zdr. Záchranáři nebo členy HZS. Zaokrohluje se na celé koruny nahoru."& CHAR(10) &<br>"---" & CHAR(10) &<br>"10025 Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku" & CHAR(10) &<br>"10026 Pojistné za zaměstnavatele u zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku" |  |
| 8 | L | L8 | Vykázané pojistné neodpovídá vykázanému úhrnu vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku. |  |
| 8 | M | M8 | nová |  |
| 8 | N | N8 | OŘ3: ČSSZ-215 |  |
| 9 | A | A9 | 11 |  |
| 9 | B | B9 | Pojistné za zaměstnavatele celkem |  |
| 9 | C | C9 | 10027<br>10024<br>10026<br>10484 |  |
| 9 | D | D9 | Přehled o výši pojistného |  |
| 9 | E | E9 | Formulář PVPOJ (pvpoj) |  |
| 9 | F | F9 | ePortál |  |
| 9 | G | G9 | nepropustná |  |
| 9 | H | H9 | DIS |  |
| 9 | I | I9 | nepropustná |  |
| 9 | J | J9 | F4 |  |
| 9 | K | K9 | Pojistné za zaměstnavatele celkem (10027) = (10024 + 10026 + 10484)<br>---<br>10024 Pojistné za zaměstnavatele u zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku<br>10026 Pojistné za zaměstnavatele u zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku<br>10484 Pojistné za zaměstnavatele u zaměstnanců, kteří vykonávají rizikové zaměstnání<br>10027 Pojistné za zaměstnavatele celkem (součet úhrnů)<br> |  |
| 9 | L | L9 | Vykázané pojistné za zaměstnavatele neodpovídá vykázaným dílčím hodnotám. |  |
| 9 | M | M9 | nová |  |
| 9 | N | N9 | OŘ3: ČSSZ-215 |  |
| 10 | A | A10 | 12 |  |
| 10 | B | B10 | Pojistné za zaměstnance |  |
| 10 | C | C10 | 10028<br>10370 |  |
| 10 | D | D10 | Přehled o výši pojistného |  |
| 10 | E | E10 | Formulář PVPOJ a zaměstnance |  |
| 10 | F | F10 | ePortál |  |
| 10 | G | G10 | propustná |  |
| 10 | H | H10 | cJMHZ |  |
| 10 | I | I10 | propustná |  |
| 10 | J | J10 | F5 |  |
| 10 | K | K10 | Pojistné za zaměstnance (10028) = ∑ (n) pojistného všech zaměstnanců (10370).<br>---   <br>10028 Pojistné za zaměstnance<br>10370 Sociální pojištění |  |
| 10 | L | L10 | Pojistné za zaměstnance nesouhlasí se součtem pojistného za všechny jednotlivé zaměstnance. |  |
| 10 | M | M10 | nová |  |
| 11 | A | A11 | 13 |  |
| 11 | B | B11 | Pojistné celkem |  |
| 11 | C | C11 | 10029<br>10028<br>10027 |  |
| 11 | D | D11 | Přehled o výši pojistného |  |
| 11 | E | E11 | Formulář PVPOJ (pvpoj) |  |
| 11 | F | F11 | ePortál |  |
| 11 | G | G11 | nepropustná |  |
| 11 | H | H11 | DIS |  |
| 11 | I | I11 | nepropustná |  |
| 11 | J | J11 | F4 |  |
| 11 | K | K11 | Pojistné celkem (10029) = Pojistné za zaměstnavatele celkem (10027) + Pojistné za zaměstnance (10028).<br>---   <br>10027 Pojistné za zaměstnavatele celkem (součet úhrnů)<br>10028 Pojistné za zaměstnance<br>10029 Pojistné celkem |  |
| 11 | L | L11 | Vykázané pojistné celkem neodpovídá vykázanému pojistnému za zaměstnance a pojistnému za zaměstnavatele. |  |
| 11 | M | M11 | nová |  |
| 11 | N | N11 | OŘ3: ČSSZ-215 |  |
| 12 | A | A12 | 15 |  |
| 12 | B | B12 | Maximální možný odpracovaný počet hodin v měsíci pro pracovní/služební poměry (kromě zdravotníků, tam bude muset být nastaven limit v závislosti na platné legislativě v době spuštění pilotu/ostrého provozu)<br>S ohledem na max. možný počet týdnů v měsíci (5) je limit nastaven na: 5*48 (tj. 40 + 8 hodin přesčasů) =240 |  |
| 12 | C | C12 | 10268<br>10239<br>10249 |  |
| 12 | D | D12 | Průběh zaměstnání v daném měsíci |  |
| 12 | E | E12 | Formulář zaměstnance (form) |  |
| 12 | F | F12 | ePortál |  |
| 12 | G | G12 | nepropustná |  |
| 12 | H | H12 | cJMHZ |  |
| 12 | I | I12 | propustná |  |
| 12 | J | J12 | F5 |  |
| 12 | K | K12 | ="Platí jen pro pracovní nebo služební poměr tedy:<br>pro pracovní poměr (10239) je 1 až 9 nebo <br>pro služební poměr (10249) kód začíná 13, pak platí že,<br>počet odpracovaných hodin (10268) musí být <= " & 'Parametrické konstanty'!C11 & ".<br>---<br>10239 Druh činnosti<br>10268 Počet odpracovaných hodin<br>10249 Postavení v zaměstnání<br>" |  |
| 12 | L | L12 | Překročen maximální možný počet odpracovaných hodin, zkontrolujte položku. Uvedená chyba nebrání podání. |  |
| 12 | M | M12 | nová |  |
| 12 | N | N12 | PŘ3: ČSSZ-180 |  |
| 13 | A | A13 | 20 |  |
| 13 | B | B13 | Odpracované hodiny |  |
| 13 | C | C13 | 10268<br>10269 |  |
| 13 | D | D13 | Průběh zaměstnání v daném měsíci |  |
| 13 | E | E13 | Formulář zaměstnance (form) |  |
| 13 | F | F13 | ePortál |  |
| 13 | G | G13 | nepropustná |  |
| 13 | H | H13 | DIS |  |
| 13 | I | I13 | nepropustná |  |
| 13 | J | J13 | F4 |  |
| 13 | K | K13 | Počet odpracovaných hodin (10268) >= počet přesčasových hodin (10269).<br>---<br>10268 Počet odpracovaných hodin<br>10269 Přesčasové hodiny (z odpracovaných) |  |
| 13 | L | L13 | Přesčasové hodiny převyšují odpracované hodiny. |  |
| 13 | M | M13 | nová |  |
| 14 | A | A14 | 23 |  |
| 14 | B | B14 | Složení počtu neodpracovaných hodin s náhradou či nekrácením mzdy |  |
| 14 | C | C14 | 10276<br>10279 |  |
| 14 | D | D14 | Průběh zaměstnání v daném měsíci |  |
| 14 | E | E14 | Formulář zaměstnance (form) |  |
| 14 | F | F14 | ePortál |  |
| 14 | G | G14 | nepropustná |  |
| 14 | H | H14 | DIS |  |
| 14 | I | I14 | nepropustná |  |
| 14 | J | J14 | F4 |  |
| 14 | K | K14 | Počet neodpracovaných hodin s náhradou či nekrácením mzdy (10276) >= Počet neodpracovaných hodin v důsledku čerpání dovolené na zotavenou (10279).<br>---<br>10276 Počet neodpracovaných hodin s náhradou či nekrácením mzdy<br>10279 Počet neodpracovaných hodin v důsledku čerpání dovolené na zotavenou<br><br> |  |
| 14 | L | L14 | Chybný počet neodpracovaných hodin s náhradou či nekrácením mzdy. |  |
| 14 | M | M14 | nová |  |
| 15 | A | A15 | 28 |  |
| 15 | B | B15 | Mzda zúčtovaná |  |
| 15 | C | C15 | 10328<br>10329<br>10330<br>10331<br>10332 |  |
| 15 | D | D15 | Mzda |  |
| 15 | E | E15 | Formulář zaměstnance (form) |  |
| 15 | F | F15 | ePortál |  |
| 15 | G | G15 | nepropustná |  |
| 15 | H | H15 | DIS |  |
| 15 | I | I15 | nepropustná |  |
| 15 | J | J15 | F4 |  |
| 15 | K | K15 | Mzda zúčtovaná (10328) >=<br>Tarifní mzdy (10329)<br>+ Prémie a odměny pravidelné (10330)<br>+ Prémie a odměny nepravidelné (10331)<br>+ Příplatky celkem (10332)<br>---   <br>10328 Mzda za práci zúčtovaná<br>10329 Tarifní mzdy<br>10330 Prémie a odměny pravidelné<br>10331 Prémie a odměny nepravidelné<br>10332 Příplatky celkem |  |
| 15 | L | L15 | Mzda zúčtovaná je menší než součet jejích složek. |  |
| 15 | M | M15 | nová |  |
| 15 | N | N15 | OŘ3: ČSÚ-11 |  |
| 16 | A | A16 | 29 |  |
| 16 | B | B16 | Příplatky |  |
| 16 | C | C16 | 10332<br>10334<br>10335<br>10336 |  |
| 16 | D | D16 | Mzda |  |
| 16 | E | E16 | Formulář zaměstnance (form) |  |
| 16 | F | F16 | ePortál |  |
| 16 | G | G16 | nepropustná |  |
| 16 | H | H16 | DIS |  |
| 16 | I | I16 | nepropustná |  |
| 16 | J | J16 | F4 |  |
| 16 | K | K16 | Příplatky celkem (10332) >=<br>Příplatky za práci v noci (10334)<br>+ Příplatky za práci o sobotách a nedělích (10335)<br>+ Příplatky za práci ve svátek (10336)<br>---   <br>10332 Příplatky celkem<br>10334 Příplatky za práci v noci<br>10335 Příplatky za práci o sobotách a nedělích<br>10336 Příplatky za práci ve svátek |  |
| 16 | L | L16 | Příplatky jsou nižší než součet jednotlivých příplatků. |  |
| 16 | M | M16 | nová |  |
| 16 | N | N16 | OŘ3: ČSÚ-11 |  |
| 17 | A | A17 | 30 |  |
| 17 | B | B17 | Náhrady mzdy zúčtované |  |
| 17 | C | C17 | 10337<br>10338<br>10339<br>10340<br>10341 |  |
| 17 | D | D17 | Mzda |  |
| 17 | E | E17 | Formulář zaměstnance (form) |  |
| 17 | F | F17 | ePortál |  |
| 17 | G | G17 | nepropustná |  |
| 17 | H | H17 | DIS |  |
| 17 | I | I17 | nepropustná |  |
| 17 | J | J17 | F4 |  |
| 17 | K | K17 | Náhrady mzdy zúčtované (10337) >=<br>Náhrady za dovolenou (10338)<br>+ Náhrady za svátky (10339)<br>+ Náhrady - překážky na straně zaměstnavatele (10340)<br>+ Náhrady - překážky na straně zaměstnance (10341)<br>---<br>10337 Náhrady mzdy zúčtované<br>10338 Náhrady za dovolenou<br>10339 Náhrady za svátky<br>10340 Náhrady - překážky na straně zaměstnavatele<br>10341 Náhrady - překážky na straně zaměstnance |  |
| 17 | L | L17 | Náhrady jsou nižší než součet jednotlivých náhrad. |  |
| 17 | M | M17 | nová |  |
| 17 | N | N17 | OŘ3: ČSÚ-11 |  |
| 18 | A | A18 | 34 |  |
| 18 | B | B18 | Počet neodpracovaných hodin z důvodu dočasné pracovní neschopnosti x náhrady mzdy za dočasnou pracovní neschopnost |  |
| 18 | C | C18 | 10342<br>10278<br> |  |
| 18 | D | D18 | Mzda |  |
| 18 | E | E18 | Formulář zaměstnance (form) |  |
| 18 | F | F18 | ePortál |  |
| 18 | G | G18 | nepropustná |  |
| 18 | H | H18 | DIS |  |
| 18 | I | I18 | nepropustná |  |
| 18 | J | J18 | F4 |  |
| 18 | K | K18 | Pakliže je počet neodpracovaných hodin z důvodu dočasné pracovní neschopnosti, za které je ze strany zaměstnavatele poskytována náhrada mzdy (10278) > 0,<br>pak Náhrady při dočasné pracovní neschopnosti (10342) > 0.<br>---   <br>10278 Počet neodpracovaných hodin z důvodu dočasné pracovní neschopnosti, za které je ze strany zaměstnavatele poskytována náhrada mzdy <br>10342 Náhrady při dočasné pracovní neschopnosti (bez srážek nad rámec §192/3 zákoníku práce) |  |
| 18 | L | L18 | Neodpovídá počtu neodpracovaných hodin z důvodu dočasné pracovní neschopnosti. |  |
| 18 | M | M18 | nová |  |
| 19 | A | A19 | 35 |  |
| 19 | B | B19 | Počet neodpracovaných hodin z důvodu čerpání dovolené na zotavenou x náhrady mzdy za dovolenou |  |
| 19 | C | C19 | 10338<br>10279 |  |
| 19 | D | D19 | Mzda |  |
| 19 | E | E19 | Formulář zaměstnance (form) |  |
| 19 | F | F19 | ePortál |  |
| 19 | G | G19 | nepropustná |  |
| 19 | H | H19 | DIS |  |
| 19 | I | I19 | nepropustná |  |
| 19 | J | J19 | F4 |  |
| 19 | K | K19 | Pokud Počet neodpracovaných hodin v důsledku čerpání dovolené na zotavenou (10279) > 0 pak,<br>Náhrady za dovolenou (10338) > 0.<br>---<br>10279 Počet neodpracovaných hodin v důsledku čerpání dovolené na zotavenou<br>10338 Náhrady za dovolenou |  |
| 19 | L | L19 | Chybí údaj k náhradě za dovolenou. |  |
| 19 | M | M19 | nová |  |
| 19 | N | N19 | OŘ3: ČSÚ-11 |  |
| 20 | A | A20 | 36 |  |
| 20 | B | B20 | Počet přesčasových hodin x příplatky za práci přesčas |  |
| 20 | C | C20 | 10333<br>10269<br> |  |
| 20 | D | D20 | Mzda |  |
| 20 | E | E20 | Formulář zaměstnance (form) |  |
| 20 | F | F20 | ePortál |  |
| 20 | G | G20 | nepropustná |  |
| 20 | H | H20 | DIS |  |
| 20 | I | I20 | nepropustná |  |
| 20 | J | J20 | F4 |  |
| 20 | K | K20 | Pokud Počet přesčasových hodin (10269) > 0 pak,<br>Příplatky za práci přesčas (10333) >= 0.<br>---   <br>10269 Přesčasové hodiny (z odpracovaných)<br>10333 Příplatky za práci přesčas<br> |  |
| 20 | L | L20 | Chybí údaj k příplatkům za přesčas. |  |
| 20 | M | M20 | nová |  |
| 21 | A | A21 | 37 |  |
| 21 | B | B21 | Formát IK MPSV |  |
| 21 | C | C21 | 10051 |  |
| 21 | D | D21 | Zaměstnanec / Žák / Student  |  |
| 21 | E | E21 | Formulář zaměstnance (form) |  |
| 21 | F | F21 | ePortál |  |
| 21 | G | G21 | nepropustná |  |
| 21 | H | H21 | DIS |  |
| 21 | I | I21 | nepropustná |  |
| 21 | J | J21 | F4 |  |
| 21 | K | K21 | Regulární výraz pro IKMPSV (10051): délka 10 číslic, z toho na prvních 9 se aplikuje modulo 11, 10. číslice je kontrolní a odpovídá zbytku z dělení prvních 9 číslic číslem 11<br>---   <br>10051 IK MPSV (Osobní identifikační číslo - OIČ) |  |
| 21 | L | L21 | IK MPSV neodpovídá formátu. |  |
| 21 | M | M21 | nová |  |
| 22 | A | A22 | 42 |  |
| 22 | B | B22 | Kontrola atributů v rámci slev na pojistném jsou vázany k druhu činnosti v rozsahu 1 až 9 |  |
| 22 | C | C22 | 10372<br>10239<br>10502 |  |
| 22 | D | D22 | Vykonávaná pozice zaměstnance |  |
| 22 | E | E22 | Formulář zaměstnance (form) |  |
| 22 | F | F22 | ePortál |  |
| 22 | G | G22 | nepropustná |  |
| 22 | H | H22 | cJMHZ |  |
| 22 | I | I22 | nepropustná |  |
| 22 | J | J22 | F5 |  |
| 22 | K | K22 | Když je (10239) v rozmezí "1" až "9" a (10502) není "výkon trestu odnětí svobody" nebo není "pracovní vztah specifické skupiny",<br>pak (10372) může nabývat  "ANO" nebo "NE"<br>---<br>10372 Sleva na pojistném zaměstnavatele<br>10239 Druh činnosti<br>10502 Bližší určení pracovněprávního vztahu |  |
| 22 | L | L22 | Slevu na pojistném zaměstnavatele lze uplatnit (uvést "ANO" v atributu 10372) pouze za zaměstnance s druhem činnosti 1 až 9. |  |
| 22 | M | M22 | nová |  |
| 22 | N | N22 | V ostatních případech nesplňujících vstupní podmínku se 10372 neposílá.<br> |  |
| 23 | A | A23 | 43 |  |
| 23 | B | B23 | Pojištění od |  |
| 23 | C | C23 | 10354<br>10355<br>10005 |  |
| 23 | D | D23 | Průběh pojištění v daném měsíci |  |
| 23 | E | E23 | Formulář zaměstnance (form) |  |
| 23 | F | F23 | ePortál |  |
| 23 | G | G23 | nepropustná |  |
| 23 | H | H23 | DIS |  |
| 23 | I | I23 | nepropustná |  |
| 23 | J | J23 | F4 |  |
| 23 | K | K23 | 1) datum od (10354) <= datum do (10355)<br>2) datum od (10354) <= datum vyplnění formuláře (10005)<br>---   <br>10005 Datum a čas vyplnění podání<br>10354 Pojištění od<br>10355 Pojištění do |  |
| 23 | L | L23 | Chybné datum od. |  |
| 23 | M | M23 | nová |  |
| 24 | A | A24 | 44 |  |
| 24 | B | B24 | Pojištění do |  |
| 24 | C | C24 | 10355<br>10354<br>10005 |  |
| 24 | D | D24 | Průběh pojištění v daném měsíci |  |
| 24 | E | E24 | Formulář zaměstnance (form) |  |
| 24 | F | F24 | ePortál |  |
| 24 | G | G24 | nepropustná |  |
| 24 | H | H24 | DIS |  |
| 24 | I | I24 | nepropustná |  |
| 24 | J | J24 | F4 |  |
| 24 | K | K24 | 1) datum do (10355) > = datum od (10354)<br>2) datum do (10355) <= datum vyplnění formuláře (10005)<br>---   <br>10005 Datum a čas vyplnění podání<br>10354 Pojištění od<br>10355 Pojištění do |  |
| 24 | L | L24 | Chybné datum do. |  |
| 24 | M | M24 | nová |  |
| 25 | A | A25 | 45 |  |
| 25 | B | B25 | Rozsah kratší pracovní/služební doby |  |
| 25 | C | C25 | 10373 |  |
| 25 | D | D25 | Průběh pojištění v daném měsíci |  |
| 25 | E | E25 | Formulář zaměstnance (form) |  |
| 25 | F | F25 | ePortál |  |
| 25 | G | G25 | nepropustná |  |
| 25 | H | H25 | DIS |  |
| 25 | I | I25 | nepropustná |  |
| 25 | J | J25 | F4 |  |
| 25 | K | K25 | ="(10373) musí být nejvýše "& ('Parametrické konstanty'!C12) &" hodin<br>---<br>10373 Rozsah kratší pracovní/služební doby<br>" |  |
| 25 | L | L25 | Uvedený počet hodin překračuje limit stanovený právní úpravou (30 hodin). |  |
| 25 | M | M25 | PVPOJ 2023 1.1 |  |
| 26 | A | A26 | 50 |  |
| 26 | B | B26 | Vyměřovací základ není vyplněn |  |
| 26 | C | C26 | 10245 |  |
| 26 | D | D26 | Průběh pojištění v daném měsíci |  |
| 26 | E | E26 | Formulář zaměstnance (form) |  |
| 26 | F | F26 | ePortál |  |
| 26 | G | G26 | nepropustná |  |
| 26 | H | H26 | DIS |  |
| 26 | I | I26 | nepropustná |  |
| 26 | J | J26 | F4 |  |
| 26 | K | K26 | Je-li Vyměřovací základ uveden, musí být (10245) >= 0<br>---<br>10245 Vyměřovací základ |  |
| 26 | L | L26 | Vyměřovací základ nesmí být záporný. |  |
| 26 | M | M26 | nová |  |
| 26 | N | N26 | PŘ3: ČSSZ-202 |  |
| 27 | A | A27 | 56 |  |
| 27 | B | B27 | Datum dosažení expozice NPE |  |
| 27 | C | C27 | 10272<br>10005 |  |
| 27 | D | D27 | Průběh zaměstnání v daném měsíci |  |
| 27 | E | E27 | Formulář zaměstnance (form) |  |
| 27 | F | F27 | ePortál |  |
| 27 | G | G27 | nepropustná |  |
| 27 | H | H27 | DIS |  |
| 27 | I | I27 | nepropustná |  |
| 27 | J | J27 | F4 |  |
| 27 | K | K27 | Datum dosažení expozice NPE (10272) není větší než datum vyplnění podání (10005).<br>---   <br>10005 Datum a čas vyplnění podání<br>10272 Datum dosažení expozice NPE |  |
| 27 | L | L27 | Datum musí být nižší než datum vyplnění podání. |  |
| 27 | M | M27 | nová |  |
| 28 | A | A28 | 57 |  |
| 28 | B | B28 | Počet odpracovaných hodin v rámci rizikové práce (§ 37d odst. 2 ZDP), práce zdravotnického záchranáře (§ 37d odst. 3) a práce člena jednotky HZS podniku (§ 37d odst. 3) není větší než počet odpracovaných hodin |  |
| 28 | C | C28 | 10273<br>10268 |  |
| 28 | D | D28 | Průběh zaměstnání v daném měsíci |  |
| 28 | E | E28 | Formulář zaměstnance (form) |  |
| 28 | F | F28 | ePortál |  |
| 28 | G | G28 | nepropustná |  |
| 28 | H | H28 | DIS |  |
| 28 | I | I28 | nepropustná |  |
| 28 | J | J28 | F4 |  |
| 28 | K | K28 | Počet odpracovaných hodin v rámci rizikové práce je (10273) < = Počtu odpracovaných hodin (10268).<br>---   <br>10268 Počet odpracovaných hodin<br>10273 Počet odpracovaných hodin v rámci rizikové práce (§ 37d odst. 2 ZDP), práce zdravotnického záchranáře (§ 37d odst. 3) a práce člena jednotky HZS podniku (§ 37d odst. 3)   |  |
| 28 | L | L28 | Počet odpracovaných hodin rizikové práce je větší než počet odpracovaných hodin. |  |
| 28 | M | M28 | nová |  |
| 29 | A | A29 | 58 |  |
| 29 | B | B29 | Počet kalendářních dnů trvání pojištění v daném kalendářním měsíci |  |
| 29 | C | C29 | 10356<br>10010<br>10011 |  |
| 29 | D | D29 | Průběh pojištění v daném měsíci |  |
| 29 | E | E29 | Formulář zaměstnance (form) |  |
| 29 | F | F29 | ePortál |  |
| 29 | G | G29 | nepropustná |  |
| 29 | H | H29 | DIS |  |
| 29 | I | I29 | nepropustná |  |
| 29 | J | J29 | F4 |  |
| 29 | K | K29 | Uvedený počet dnů (10356) <= počet dnů v daném měsíci (10010),  v roce (10011 - pro přestupné roky).<br>---<br>10356 Počet kalendářních dnů trvání doby důchodového pojištění v daném kalendářním měsíci<br>10010 Měsíc<br>10011 Rok |  |
| 29 | L | L29 | Neodpovídá možnému počtu dnů v kalendářním měsíci. |  |
| 29 | M | M29 | nová |  |
| 30 | A | A30 | 59 |  |
| 30 | B | B30 | Vyměřovací základ s podmínkami |  |
| 30 | C | C30 | 10245<br>10356<br>10357<br>10375<br>10240 |  |
| 30 | D | D30 | Průběh pojištění v daném měsíci |  |
| 30 | E | E30 | Formulář zaměstnance (form) |  |
| 30 | F | F30 | ePortál |  |
| 30 | G | G30 | nepropustná |  |
| 30 | H | H30 | DIS |  |
| 30 | I | I30 | nepropustná |  |
| 30 | J | J30 | F4 |  |
| 30 | K | K30 | Kontrola kódu ELDP (10240):<br>1.: je-li druhá pozice údaje Kód ELDP = P pak údaj Vyměřovací základ (10245) musí být uveden<br>2.: je-li údaj Započtené dny (10356) = údaji Vyloučené doby (10357) a současně je-li druhá pozice údaje Kód ELDP ≠ D, pak údaj Vyměřovací základ (10245) = 0.<br>3.: je-li v následujícím řádku (tj. výskytu) průběhu činnosti druhá pozice údaje Kód ELDP = D a údaj Započtené dny je neprázdný a zároveň platí, že první pozice z údaje kódu z tohoto řádku je shodný s prvním znakem z údaje kód v následujícím řádku a že se v obou řádcích jedná o zaměstnání stejného rozsahu a že doby pojištění v těchto řádcích na sebe bezprostředně navazují, pak se údaj Vyměřovací základ v předcházejícím řádku doby pojištění před dovršením důchodového věku se uvádí jako (10245) = 0.<br>4.: je-li druhá pozice údaje Kód ELDP = D a údaj Započtené dny (10356) = 0 a údaj Odečtené doby (10375) = údaji Vyloučené doby (10357), pak se údaj Vyměřovacího základu uvádí jako (10245) = 0.<br>5.: je-li druhá pozice údaje Kód ELDP (10240) ≠ D nebo (10240) ≠ P a údaj Započtené dny (10356) = 0, pak se údaj Vyměřovací základ uvádí jako (10245) = 0.<br>---<br>10245 Vyměřovací základ<br>10356 Počet kalendářních dnů trvání doby důchodového pojištění v daném kalendářním měsíci (Započtené dny)<br>10357 Vyloučené doby<br>10375 Odečtené doby<br>10240 Kód ELDP |  |
| 30 | L | L30 | Chybně uvedený vyměřovací základ. |  |
| 30 | M | M30 | nová |  |
| 30 | N | N30 | OŘ3: ČSSZ-206<br>OŘ3: ČSSZ-205 |  |
| 31 | A | A31 | 60 |  |
| 31 | B | B31 | Datum nastání specifické právní skutečnosti |  |
| 31 | C | C31 | 10409<br>10005 |  |
| 31 | D | D31 | Souhrnná vrstva |  |
| 31 | E | E31 | Souhrnná vrstva (souhrn) |  |
| 31 | F | F31 | ePortál |  |
| 31 | G | G31 | nepropustná |  |
| 31 | H | H31 | DIS |  |
| 31 | I | I31 | nepropustná |  |
| 31 | J | J31 | F4 |  |
| 31 | K | K31 | Datum nastání specifické právní skutečnosti (10409) musí být menší než datum podání (10005).<br>---   <br>10005 Datum a čas vyplnění podání<br>10409 Datum nastání specifické právní skutečnosti |  |
| 31 | L | L31 | Datum nastání specifické právní skutečnosti musí být menší než datum podání. |  |
| 31 | M | M31 | nová |  |
| 32 | A | A32 | 61 |  |
| 32 | B | B32 | Globální kontrola XSD schématu |  |
| 32 | D | D32 | JMHZ obecně |  |
| 32 | E | E32 | Měsíční podání JMHZ (global) |  |
| 32 | F | F32 | ePortál |  |
| 32 | G | G32 | nepropustná |  |
| 32 | H | H32 | DIS |  |
| 32 | I | I32 | nepropustná |  |
| 32 | J | J32 | T4 |  |
| 32 | K | K32 | Kontrola XML proti XSD (kontrola čitelnosti) - zjednodušené XSD |  |
| 32 | L | L32 | Vaše e-Podání neprošlo validací proti XML schématu. Detail chyby: |  |
| 32 | M | M32 | nová |  |
| 33 | A | A33 | 72 |  |
| 33 | B | B33 | Vyplnění položky Zúčtovaný příjem - celkem |  |
| 33 | C | C33 | 10286 |  |
| 33 | D | D33 | Souhrnná data zaměstnance |  |
| 33 | E | E33 | Formulář zaměstnance (form) |  |
| 33 | F | F33 | ePortál |  |
| 33 | G | G33 | nepropustná |  |
| 33 | H | H33 | DIS |  |
| 33 | I | I33 | nepropustná |  |
| 33 | J | J33 | F4 |  |
| 33 | K | K33 | (10286) nesmí být záporné číslo<br>---<br>10286 Zúčtovaný příjem - celkem |  |
| 33 | L | L33 | Musí být uvedena hodnota větší nebo rovna nule. |  |
| 33 | M | M33 | nová |  |
| 33 | N | N33 | OŘ3: ČSSZ-174, DIS řešeno na úrovni XSD |  |
| 34 | A | A34 | 74 |  |
| 34 | B | B34 | Výše vyplaceného měsíčního daňového bonusu |  |
| 34 | C | C34 | 10306 |  |
| 34 | D | D34 | Souhrnná data zaměstnance |  |
| 34 | E | E34 | Formulář zaměstnance (form) |  |
| 34 | F | F34 | ePortál |  |
| 34 | G | G34 | nepropustná |  |
| 34 | H | H34 | cJMHZ |  |
| 34 | I | I34 | propustná |  |
| 34 | J | J34 | F5 |  |
| 34 | K | K34 | ="(10306) může nabývat jen hodnoty větší nebo rovné nule (nemůže mít zápornou hodnotu), v případě kladné hodnoty nemůže být nižší než "& ('Parametrické konstanty'!C15) &" Kč.<br>---<br>10306 Výše vyplaceného měsíčního daňového bonusu" |  |
| 34 | L | L34 | Hodnota musí být rovna nule nebo větší rovno než 50 Kč. |  |
| 34 | M | M34 | nová |  |
| 35 | A | A35 | 78 |  |
| 35 | B | B35 | Přeplatek nebo nedoplatek z ročního zúčtování je roven součtu příslušných položek |  |
| 35 | C | C35 | 10321<br>10322<br>10323<br>10239 |  |
| 35 | D | D35 | Souhrnná data zaměstnance |  |
| 35 | E | E35 | Formulář zaměstnance (form) |  |
| 35 | F | F35 | ePortál |  |
| 35 | G | G35 | nepropustná |  |
| 35 | H | H35 | DIS |  |
| 35 | I | I35 | nepropustná |  |
| 35 | J | J35 | F4 |  |
| 35 | K | K35 | Přeplatek nebo nedoplatek z ročního zúčtování (10321),<br>musí být roven (10322) + (10323). <br>Kontrola nepostihuje dat. scénář pronájem mezinárodní síly, (10239) = "12".<br>---<br>10321 Přeplatek nebo nedoplatek z ročního zúčtování<br>10322 Přeplatek nebo nedoplatek z ročního zúčtování - z toho přeplatek na dani nebo nedoplatek daně<br>10323 Přeplatek nebo nedoplatek z ročního zúčtování - z toho doplatek na daňovém bonusu nebo přeplacená částka daňového bonusu zaměstnanci<br> |  |
| 35 | L | L35 | Hodnota neodpovídá součtu dílčích položek. |  |
| 35 | M | M35 | nová |  |
| 36 | A | A36 | 79 |  |
| 36 | B | B36 | Roční zúčtování záloh - Přeplatek nebo nedoplatek z ročního zúčtování |  |
| 36 | C | C36 | 10321<br>10322<br>10323<br>10420<br>10454<br>10320<br>10239 |  |
| 36 | D | D36 | Souhrnná data zaměstnance |  |
| 36 | E | E36 | Formulář zaměstnance (form) |  |
| 36 | F | F36 | ePortál |  |
| 36 | G | G36 | nepropustná |  |
| 36 | H | H36 | DIS |  |
| 36 | I | I36 | nepropustná |  |
| 36 | J | J36 | F4 |  |
| 36 | K | K36 | Pokud je uvedeno, že proběhlo roční zúčtování záloh (10320) = "ANO", <br>pak musí být vyplněny položky: 10321, 10322, 10323, 10420, 10454.<br>Kontrola nepostihuje dat. scénář pronájem mezinárodní síly, (10239) = "12".<br>---<br>10321 Přeplatek nebo nedoplatek z ročního zúčtování<br>10322 Přeplatek nebo nedoplatek z ročního zúčtování - z toho přeplatek na dani nebo nedoplatek daně<br>10323 Přeplatek nebo nedoplatek z ročního zúčtování - z toho doplatek na daňovém bonusu nebo přeplacená částka daňového bonusu zaměstnanci<br>10420 Uplatněna sleva na manželku / manžela<br>10454 Uplatněno daňové zvýhodnění na děti<br>10320 Roční zúčtování záloh bylo provedeno<br>10239 Druh činnosti |  |
| 36 | L | L36 | Není uvedena hodnota  pro roční zúčtování záloh. |  |
| 36 | M | M36 | nová |  |
| 37 | A | A37 | 81 |  |
| 37 | B | B37 | Rodné číslo splňuje modulo |  |
| 37 | C | C37 | 10457<br> |  |
| 37 | D | D37 | Souhrnná data zaměstnance |  |
| 37 | E | E37 | Formulář zaměstnance (form) |  |
| 37 | F | F37 | ePortál |  |
| 37 | G | G37 | nepropustná |  |
| 37 | H | H37 | DIS |  |
| 37 | I | I37 | nepropustná |  |
| 37 | J | J37 | F4 |  |
| 37 | K | K37 | Rodné číslo (10457) nesplňuje modulo pro RČ.<br>---   <br>10457 Rodné číslo uživatele |  |
| 37 | L | L37 | Chybně uvedené rodné číslo. |  |
| 37 | M | M37 | nová |  |
| 38 | A | A38 | 82 |  |
| 38 | B | B38 | Vyplnění položky Výplatní termín při nastání specifické právní skutečnosti |  |
| 38 | C | C38 | 10410<br>10408 |  |
| 38 | D | D38 | Příjem v daném měsíci |  |
| 38 | E | E38 | Formulář zaměstnance (form) |  |
| 38 | F | F38 | ePortál |  |
| 38 | G | G38 | nepropustná |  |
| 38 | H | H38 | cJMHZ |  |
| 38 | I | I38 | nepropustná |  |
| 38 | J | J38 | F5 |  |
| 38 | K | K38 | Pokud je uvedena specifická právní skutečnost (10408), <br>pak musí být uveden výplatní termín (10410) u všech součástí podání.<br>---   <br>10408 Specifická právní skutečnost<br>10410 Výplatní termín při nastání specifické právní skutečnosti |  |
| 38 | L | L38 | Výplatní termín musí být uveden. |  |
| 38 | M | M38 | nová |  |
| 39 | A | A39 | 84 |  |
| 39 | B | B39 | Pořadí balíku dat |  |
| 39 | C | C39 | 10002<br>10003 |  |
| 39 | D | D39 | Meta atributy |  |
| 39 | E | E39 | Měsíční podání JMHZ |  |
| 39 | F | F39 | ePortál |  |
| 39 | G | G39 | nepropustná |  |
| 39 | H | H39 | DIS |  |
| 39 | I | I39 | nepropustná |  |
| 39 | J | J39 | T5 |  |
| 39 | K | K39 | Pořadí balíku (10002) nesmí být vyšší, než počet balíků (10003).<br>---   <br>10002 Pořadí balíku dat<br>10003 Počet balíků dat<br> |  |
| 39 | L | L39 | Pořadí balíku nesmí být vyšší než počet balíků. |  |
| 39 | M | M39 | nová |  |
| 40 | A | A40 | 87 |  |
| 40 | B | B40 | Správnost kódu ELDP |  |
| 40 | C | C40 | 10240<br>10239 |  |
| 40 | D | D40 | Průběh pojištění v daném měsíci |  |
| 40 | E | E40 | Formulář zaměstnance (form) |  |
| 40 | F | F40 | ePortál |  |
| 40 | G | G40 | nepropustná |  |
| 40 | H | H40 | cJMHZ |  |
| 40 | I | I40 | nepropustná |  |
| 40 | J | J40 | F5 |  |
| 40 | K | K40 | První pozice kódu ELDP (10240) musí odpovídat  kódu položky v číselníku Druh činnosti (10239).<br>---   <br>10239 Druh činnosti<br>10240 Kód ELDP |  |
| 40 | L | L40 | Kód ELDP neodpovídá číselníku Druh činnosti. |  |
| 40 | M | M40 | nová |  |
| 40 | N | N40 | atribut (10239) Druh činnosti výchází z dat v registrace zaměstnance |  |
| 41 | A | A41 | 88 |  |
| 41 | B | B41 | Datum a čas vyplnění podání |  |
| 41 | C | C41 | 10005 |  |
| 41 | D | D41 | Meta atributy |  |
| 41 | E | E41 | Měsíční podání JMHZ |  |
| 41 | F | F41 | ePortál |  |
| 41 | G | G41 | nepropustná |  |
| 41 | H | H41 | DIS |  |
| 41 | I | I41 | nepropustná |  |
| 41 | J | J41 | T6 |  |
| 41 | K | K41 | (10005) <= aktuálnímu datu.<br>---<br>10005 Datum a čas vyplnění podání |  |
| 41 | L | L41 | Datum vyplnění podání musí být nižší nebo rovno aktuálnímu datu. |  |
| 41 | M | M41 | nová |  |
| 42 | A | A42 | 90 |  |
| 42 | B | B42 | Měsíc |  |
| 42 | C | C42 | 10010 |  |
| 42 | D | D42 | Meta atributy |  |
| 42 | E | E42 | Měsíční podání JMHZ |  |
| 42 | F | F42 | ePortál |  |
| 42 | G | G42 | nepropustná |  |
| 42 | H | H42 | DIS |  |
| 42 | I | I42 | nepropustná |  |
| 42 | J | J42 | T6 |  |
| 42 | K | K42 | (10010, 10011) < aktuální kalendářní datum (měsíc a rok).<br>---<br>10010 Měsíc<br>10011 Rok |  |
| 42 | L | L42 | Měsíc musí být nižší aktuálnímu měsíci a roku. |  |
| 42 | M | M42 | nová |  |
| 42 | N | N42 | opraveno v rámci 3.kola OŘ - ČSSZ 182 |  |
| 43 | A | A43 | 91 |  |
| 43 | B | B43 | Rok |  |
| 43 | C | C43 | 10011 |  |
| 43 | D | D43 | Meta atributy |  |
| 43 | E | E43 | Měsíční podání JMHZ |  |
| 43 | F | F43 | ePortál |  |
| 43 | G | G43 | nepropustná |  |
| 43 | H | H43 | DIS |  |
| 43 | I | I43 | nepropustná |  |
| 43 | J | J43 | T6 |  |
| 43 | K | K43 | Rok (10011) <= aktuálnímu roku.<br>---   <br>10011 Rok |  |
| 43 | L | L43 | Rok musí být nižší nebo roven aktuálnímu roku. |  |
| 43 | M | M43 | nová |  |
| 43 | N | N43 | opraveno v rámci 3.kola OŘ - ČSSZ 182 |  |
| 44 | A | A44 | 93 |  |
| 44 | B | B44 | Počet formulářů v balíků musí být maximálně jako Počet formulářů celkem |  |
| 44 | C | C44 | 10015<br>10488 |  |
| 44 | D | D44 | Meta atributy |  |
| 44 | E | E44 | Měsíční podání JMHZ |  |
| 44 | F | F44 | ePortál |  |
| 44 | G | G44 | nepropustná |  |
| 44 | H | H44 | DIS |  |
| 44 | I | I44 | nepropustná |  |
| 44 | J | J44 | T5 |  |
| 44 | K | K44 | (10015) <= (10488)<br>---<br>10015 Počet formulářů v balíku dat<br>10488 Počet formulářů celkem |  |
| 44 | L | L44 | Počet formulářů v balíku musí být maximálně jako Počet formulářů celkem. |  |
| 44 | M | M44 | nová |  |
| 45 | A | A45 | 94 |  |
| 45 | B | B45 | Stanovený fond pro danou profesi (v hodinách měsíčně) |  |
| 45 | C | C45 | 10259 |  |
| 45 | D | D45 | Vykonávaná pozice zaměstnance |  |
| 45 | E | E45 | Formulář zaměstnance (form) |  |
| 45 | F | F45 | ePortál |  |
| 45 | G | G45 | nepropustná |  |
| 45 | H | H45 | DIS |  |
| 45 | I | I45 | nepropustná |  |
| 45 | J | J45 | F4 |  |
| 45 | K | K45 | (10259) >= 0<br>---<br>10259 Pracovní doba stanovená pro danou profesi (v hodinách měsíčně) |  |
| 45 | L | L45 | Stanovený fond pro danou profesi musí být kladná nebo nulová hodnota. |  |
| 45 | M | M45 | nová |  |
| 46 | A | A46 | 95 |  |
| 46 | B | B46 | Sjednaný fond pracovní doby (v hodinách měsíčně) |  |
| 46 | C | C46 | 10260 |  |
| 46 | D | D46 | Vykonávaná pozice zaměstnance |  |
| 46 | E | E46 | Formulář zaměstnance (form) |  |
| 46 | F | F46 | ePortál |  |
| 46 | G | G46 | nepropustná |  |
| 46 | H | H46 | DIS |  |
| 46 | I | I46 | nepropustná |  |
| 46 | J | J46 | F4 |  |
| 46 | K | K46 | (10260) >=  0<br>---<br>10260 Pracovní doba sjednaná (v hodinách měsíčně) |  |
| 46 | L | L46 | Sjednaný fond pracovní doby musí být kladná nebo nulová hodnota. |  |
| 46 | M | M46 | nová |  |
| 47 | A | A47 | 96 |  |
| 47 | B | B47 | Stanovená týdenní pracovní doba zaměstnance (§ 79 zákoníku práce) |  |
| 47 | C | C47 | 10261 |  |
| 47 | D | D47 | Vykonávaná pozice zaměstnance |  |
| 47 | E | E47 | Formulář zaměstnance (form) |  |
| 47 | F | F47 | ePortál |  |
| 47 | G | G47 | nepropustná |  |
| 47 | H | H47 | DIS |  |
| 47 | I | I47 | nepropustná |  |
| 47 | J | J47 | F4 |  |
| 47 | K | K47 | (10261) > 0<br>---<br>10261 Stanovená týdenní pracovní doba zaměstnance (§79 zákoníku práce) |  |
| 47 | L | L47 | Stanovená týdenní pracovní doba musí být kladná hodnota. |  |
| 47 | M | M47 | nová |  |
| 48 | A | A48 | 97 |  |
| 48 | B | B48 | Osvobozené příjmy ze zúčtovaných příjmů - celkem |  |
| 48 | C | C48 | 10289<br>10286 |  |
| 48 | D | D48 | Souhrnná data zaměstnance |  |
| 48 | E | E48 | Formulář zaměstnance (form) |  |
| 48 | F | F48 | ePortál |  |
| 48 | G | G48 | nepropustná |  |
| 48 | H | H48 | DIS |  |
| 48 | I | I48 | nepropustná |  |
| 48 | J | J48 | F4 |  |
| 48 | K | K48 | (10289) =< (10286)<br>---<br>10289 Osvobozené příjmy ze zúčtovaných příjmů - celkem<br>10286 Zúčtovaný příjem - celkem |  |
| 48 | L | L48 | Hodnota osvobozených příjmů nesmí být vyšší než zúčtovaný příjem - celkem. |  |
| 48 | M | M48 | nová |  |
| 49 | A | A49 | 98 |  |
| 49 | B | B49 | Počet dní nesmí být vyšší než počet kalendářních dní v daném měsíci |  |
| 49 | C | C49 | 10358<br>10359<br>10375<br>10357<br>10360<br>10362<br>10463<br>10536<br>10010<br>10011 |  |
| 49 | D | D49 | Průběh pojištění v daném měsíci |  |
| 49 | E | E49 | Formulář zaměstnance (form) |  |
| 49 | F | F49 | ePortál |  |
| 49 | G | G49 | nepropustná |  |
| 49 | H | H49 | DIS |  |
| 49 | I | I49 | nepropustná |  |
| 49 | J | J49 | F4 |  |
| 49 | K | K49 | Hodnota pro jednotlivé atributy ve výčtu nesmí být vyšší než počet dní v daném měsíci (10010) v roce (10011 - pro přestupné roky),<br>platí pro atributy níže:<br>---<br>(10358) Počet dnů trvání dočasné pracovní neschopnosti<br>(10359) Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)<br>(10375) Doby odečítané po důchodovém věku - počet dnů<br>(10357 Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) zákona č. 155/1995 Sb.<br>(10360) Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné<br>(10362) Počet dnů čerpání otcovské<br>(10463) Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)<br>(10536) Poceř dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb.<br>(10010) Měsíc<br>(10011) Rok<br> |  |
| 49 | L | L49 | Hodnota nesmí být vyšší než počet dní v daném měsíci. |  |
| 49 | M | M49 | nová |  |
| 50 | A | A50 | 99 |  |
| 50 | B | B50 | "Platnost kódu od/do" se týká aktuálního měsíce |  |
| 50 | C | C50 | 10241<br>10242<br>10010 |  |
| 50 | D | D50 | Průběh pojištění v daném měsíci |  |
| 50 | E | E50 | Formulář zaměstnance (form) |  |
| 50 | F | F50 | ePortál |  |
| 50 | G | G50 | nepropustná |  |
| 50 | H | H50 | DIS |  |
| 50 | I | I50 | nepropustná |  |
| 50 | J | J50 | F4 |  |
| 50 | K | K50 | Měsíc z intervalu (10241, 10242) musí být v měsíci, za který se podání podává (10010),<br>tato kontrola se neprovádí v datovém scénáři odložený příjem: formOdlozenyPrijem.xsd<br>---<br>10241 Platnost kódu od<br>10242 Platnost kódu do<br>10010 Měsíc |  |
| 50 | L | L50 | Datum je mimo měsíc, za který je podáváno. |  |
| 50 | M | M50 | nová |  |
| 51 | A | A51 | 100 |  |
| 51 | B | B51 | Platnost kódu od je menší než Platnost kódu do |  |
| 51 | C | C51 | 10241<br>10242 |  |
| 51 | D | D51 | Průběh pojištění v daném měsíci |  |
| 51 | E | E51 | Formulář zaměstnance (form) |  |
| 51 | F | F51 | ePortál |  |
| 51 | G | G51 | nepropustná |  |
| 51 | H | H51 | DIS |  |
| 51 | I | I51 | nepropustná |  |
| 51 | J | J51 | F4 |  |
| 51 | K | K51 | Platnost kódu od (10241) musí být rovna nebo menší, než Platnost kódu do (10242).<br>---<br>10241 Platnost kódu od<br>10242 Platnost kódu do<br><br><br> |  |
| 51 | L | L51 | Datum kódu "od" musí být rovno nebo nižší než datum kódu "do". |  |
| 51 | M | M51 | nová |  |
| 51 | N | N51 | OŘ3: ČSSZ-186 |  |
| 52 | A | A52 | 103 |  |
| 52 | B | B52 | Uvedení identifikace dočasného přidělení |  |
| 52 | C | C52 | 10251<br>10252<br>10457<br>10492<br>10493<br>10494 |  |
| 52 | D | D52 | Vykonávaná pozice zaměstnance |  |
| 52 | E | E52 | Formulář zaměstnance (form) |  |
| 52 | F | F52 | ePortál |  |
| 52 | G | G52 | nepropustná |  |
| 52 | H | H52 | DIS |  |
| 52 | I | I52 | nepropustná |  |
| 52 | J | J52 | F4 |  |
| 52 | K | K52 | Pokud (10251) = "ANO",<br>pak musí být vyplněna buď jedna nebo druhá hodnota nebo třetí množina hodnot: <br>1) (10252) XOR <br>2) (10457) XOR <br>3) ((10492) AND (10493) AND (10494)).<br>---<br>10251 Zaměstnání za účelem dočasného přidělení u uživatele<br>10252 IČO uživatele<br>10457 Rodné číslo uživatele<br>10492 Kód státu zahraniční právnické osoby nebo zahraniční fyzické osoby<br>10493 Registrační číslo zahraniční právnické osoby nebo identifikace zahraniční fyzické osoby<br>10494 Název zahraniční právnické osoby nebo zahraniční fyzické osoby<br> |  |
| 52 | L | L52 | Není uvedena identifikace dočasného přidělení. |  |
| 52 | M | M52 | nová |  |
| 53 | A | A53 | 109 |  |
| 53 | B | B53 | Kontrola na Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR |  |
| 53 | C | C53 | 10416<br>10286 |  |
| 53 | D | D53 | Souhrnná data zaměstnance |  |
| 53 | E | E53 | Formulář zaměstnance (form) |  |
| 53 | F | F53 | ePortál |  |
| 53 | G | G53 | nepropustná |  |
| 53 | H | H53 | DIS |  |
| 53 | I | I53 | nepropustná |  |
| 53 | J | J53 | F4 |  |
| 53 | K | K53 | (10416) <= (10286)<br>---<br>10286 Zúčtovaný příjem - celkem<br>10416 Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR |  |
| 53 | L | L53 | Odměna člena orgánu právnických osob je vyšší než zúčtovaný příjem. |  |
| 53 | M | M53 | nová |  |
| 54 | A | A54 | 110 |  |
| 54 | B | B54 | Pořadí pro určení výše daňového zvýhodnění tvoří řadu |  |
| 54 | C | C54 | 10440 |  |
| 54 | D | D54 | Souhrnná data zaměstnance |  |
| 54 | E | E54 | Formulář zaměstnance (form) |  |
| 54 | F | F54 | ePortál |  |
| 54 | G | G54 | nepropustná |  |
| 54 | H | H54 | DIS |  |
| 54 | I | I54 | nepropustná |  |
| 54 | J | J54 | F4 |  |
| 54 | K | K54 | Při vyplňování (10440) nelze uplatnit dítě s vyšším pořadím pokud v daném měsící nejsou uvedeny děti, které jsou uvedeny s nižším pořadím nebo s "N".<br>---<br>10440 Pořadí pro určení výše daňového zvýhodnění |  |
| 54 | L | L54 | Nelze uplatnit dítě s vyšším pořadím, pokud v daném měsíci nejsou uvedeny děti s nižším pořadím nebo s "N". |  |
| 54 | M | M54 | nová |  |
| 54 | N | N54 | Pro 3 děti a více je přiřazováno pořadí 1, 2, 3 a pro další dítě (4té atd.) platí, že  pořadí pro určení výše daňového zvýhodnění (10440) je 3.<br>Za dítě, na které není uplatňováno daňové zvýhodnění, je vyplněna hodnota N. |  |
| 55 | A | A55 | 111 |  |
| 55 | B | B55 | Počet měsíců uplatnění slevy souhlasí s možným počtem uplatnění |  |
| 55 | C | C55 | 10430<br>10425 |  |
| 55 | D | D55 | Souhrnná data zaměstnance |  |
| 55 | E | E55 | Formulář zaměstnance (form) |  |
| 55 | F | F55 | ePortál |  |
| 55 | G | G55 | nepropustná |  |
| 55 | H | H55 | DIS |  |
| 55 | I | I55 | nepropustná |  |
| 55 | J | J55 | F4 |  |
| 55 | K | K55 | Pokud je sleva uplatněna (10425) = "ANO"<br>pak, počet měsíců uplatnění slevy nabývá hodnoty 1 až 12, <br>(10430) = <1;12>.<br>---<br>10425 Držitelka / držitel karty ZTP/P<br>10430 Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P |  |
| 55 | L | L55 | Chybná hodnota v počtu měsíců uplatnění slevy ve dvojnásobné výši (ZTP/P). |  |
| 55 | M | M55 | nová |  |
| 56 | A | A56 | 112 |  |
| 56 | B | B56 | Při uplatnění daňového zvýhodnění na děti je vyplněno alespoň 1 dítě (roční zúčtování) |  |
| 56 | C | C56 | 10446<br>10447<br>10448<br>10451<br>10454 |  |
| 56 | D | D56 | Souhrnná data zaměstnance |  |
| 56 | E | E56 | Formulář zaměstnance (form) |  |
| 56 | F | F56 | ePortál |  |
| 56 | G | G56 | nepropustná |  |
| 56 | H | H56 | DIS |  |
| 56 | I | I56 | nepropustná |  |
| 56 | J | J56 | F4 |  |
| 56 | K | K56 | Pokud je (10454) = "ANO", pak jsou vyplněny všechny povinné atr. z podtřídy "Vyživované děti".<br> ---<br>10446 Jméno<br>10447 Příjmení<br>10448 Datum narození nebo 10449 Rodné číslo<br>10451 Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících<br>10454 Uplatněno daňové zvýhodnění na děti<br> |  |
| 56 | L | L56 | Nejsou vyplněny údaje za dítě. |  |
| 56 | M | M56 | nová |  |
| 57 | A | A57 | 113 |  |
| 57 | B | B57 | Povinné RČ nebo datum narození jiné vyživující osoby ve společně hospodařící domácnosti |  |
| 57 | C | C57 | 10433<br>10434 |  |
| 57 | D | D57 | Souhrnná data zaměstnance |  |
| 57 | E | E57 | Formulář zaměstnance (form) |  |
| 57 | F | F57 | ePortál |  |
| 57 | G | G57 | nepropustná |  |
| 57 | H | H57 | DIS |  |
| 57 | I | I57 | nepropustná |  |
| 57 | J | J57 | F4 |  |
| 57 | K | K57 | Musí být vyplněno buď RČ (10434) nebo datum narození (10433) vyživující osoby.<br>---   <br>10433 Datum narození<br>10434 Rodné číslo |  |
| 57 | L | L57 | Chybí rodné číslo nebo datum narození jiné vyživující osoby ve společně hospodařící domácnosti. |  |
| 57 | M | M57 | nová |  |
| 58 | A | A58 | 114 |  |
| 58 | B | B58 | Povinné RČ nebo datum narození vyživovaného dítěte |  |
| 58 | C | C58 | 10437<br>10438 |  |
| 58 | D | D58 | Souhrnná data zaměstnance |  |
| 58 | E | E58 | Formulář zaměstnance (form) |  |
| 58 | F | F58 | ePortál |  |
| 58 | G | G58 | nepropustná |  |
| 58 | H | H58 | DIS |  |
| 58 | I | I58 | nepropustná |  |
| 58 | J | J58 | F4 |  |
| 58 | K | K58 | Musí být vyplněno buď RČ (10438) nebo datum narození  (10437) vyživovaného dítěte.<br>---   <br>10437 Datum narození<br>10438 Rodné číslo |  |
| 58 | L | L58 | Chybí rodné číslo nebo datum narození vyživovaného dítěte. |  |
| 58 | M | M58 | nová |  |
| 59 | A | A59 | 115 |  |
| 59 | B | B59 | Povinné RČ nebo datum narození manžela/manželky |  |
| 59 | C | C59 | 10424<br>10423 |  |
| 59 | D | D59 | Souhrnná data zaměstnance |  |
| 59 | E | E59 | Formulář zaměstnance (form) |  |
| 59 | F | F59 | ePortál |  |
| 59 | G | G59 | nepropustná |  |
| 59 | H | H59 | DIS |  |
| 59 | I | I59 | nepropustná |  |
| 59 | J | J59 | F4 |  |
| 59 | K | K59 | Musí být vyplněno buď RČ (10423) nebo datum narození (10424) manžela/manželky<br>---   <br>10423 Rodné číslo manželky / manžela<br>10424 Datum narození manželky / manžela |  |
| 59 | L | L59 | Chybí rodné číslo nebo datum narození manžela/manželky. |  |
| 59 | M | M59 | nová |  |
| 60 | A | A60 | 118 |  |
| 60 | B | B60 | Pojistné za zaměstnance |  |
| 60 | C | C60 | 10370<br>10477 |  |
| 60 | D | D60 | Průběh pojištění v daném měsíci |  |
| 60 | E | E60 | Formulář zaměstnance (form) |  |
| 60 | F | F60 | ePortál |  |
| 60 | G | G60 | nepropustná |  |
| 60 | H | H60 | DIS |  |
| 60 | I | I60 | nepropustná |  |
| 60 | J | J60 | F4 |  |
| 60 | K | K60 | ="Pojistné na sociální zabezpečení za zaměstnance (10370) = " & 'Parametrické konstanty'!C7 &<br>" z vyměřovacvího základu zaměstnance (10477), výsledná hodnota se zaokrouhluje na celé koruny směrem nahoru."& CHAR(10) &<br>"---" & CHAR(10) &<br>"10477 Částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné" & CHAR(10) &<br>"10370 Sociální pojištění" |  |
| 60 | L | L60 | Pojistné za zaměstnance neodpovídá vyměřovacímu základu zaměstnance. |  |
| 60 | M | M60 | nová |  |
| 60 | N | N60 | OŘ: ČSSZ-220 |  |
| 61 | A | A61 | 121 |  |
| 61 | B | B61 | Kontrola vyplnění vyloučených dob dle § 16 odst. 4 písm |  |
| 61 | C | C61 | 10357<br>10358<br>10359<br>10360<br>10362<br>10536 |  |
| 61 | D | D61 | Průběh pojištění v daném měsíci |  |
| 61 | E | E61 | Formulář zaměstnance (form) |  |
| 61 | F | F61 | ePortál |  |
| 61 | G | G61 | nepropustná |  |
| 61 | H | H61 | DIS |  |
| 61 | I | I61 | nepropustná |  |
| 61 | J | J61 | F4 |  |
| 61 | K | K61 | Pokud (10357) > 0,<br>pak platí že, 10357 = (10358 + 10359 + 10360 + 10362 + 10536)<br>---<br>10357 Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) zákona č. 155/1995 Sb.<br>10358 Počet dnů trvání dočasné pracovní neschopnosti<br>10359 Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)<br>10360 Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné<br>10362 Počet dnů čerpání otcovské<br>10536 Počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb. |  |
| 61 | L | L61 | Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) zákona č. 155/1995 Sb. musí být rovna sumě atributů: Počet dnů trvání dočasné pracovní neschopnosti, Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu), Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné, Počet dnů čerpání otcovské, Počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb. |  |
| 61 | M | M61 | nová |  |
| 62 | A | A62 | 123 |  |
| 62 | B | B62 | Kontrola vyplnění data nastání specifické právní skutečnosti |  |
| 62 | C | C62 | 10408<br>10409 |  |
| 62 | D | D62 | Souhrnná vrstva |  |
| 62 | E | E62 | Souhrnná vrstva (souhrn) |  |
| 62 | F | F62 | ePortál |  |
| 62 | G | G62 | nepropustná |  |
| 62 | H | H62 | DIS |  |
| 62 | I | I62 | nepropustná |  |
| 62 | J | J62 | F4 |  |
| 62 | K | K62 | Pokud je uvedena Typ specifické právní skutečnsti (10408), <br>pak musí být vyplněna položka Datum nastání specifické právní skutečnosti (10409).<br>---<br>10408 Specifická právní skutečnost<br>10409 Datum nastání specifické právní skutečnosti |  |
| 62 | L | L62 | Není vyplněno datum nastání specifické právní skutečnosti. |  |
| 62 | M | M62 | nová |  |
| 63 | A | A63 | 124 |  |
| 63 | B | B63 | Kontrola vyplnění údaje za manžela / manželku (roční zúčtování) |  |
| 63 | C | C63 | 10420<br>10421<br>10422<br>10423<br>10424<br>10425<br>10426 |  |
| 63 | D | D63 | Souhrnná data zaměstnance |  |
| 63 | E | E63 | Formulář zaměstnance (form) |  |
| 63 | F | F63 | ePortál |  |
| 63 | G | G63 | nepropustná |  |
| 63 | H | H63 | DIS |  |
| 63 | I | I63 | nepropustná |  |
| 63 | J | J63 | F4 |  |
| 63 | K | K63 | Pokud je (10420) = "ANO",<br>pak musí být vyplněny položky (10421), (10422), (10423) nebo (10424), (10425), (10426).<br>---<br>10421 Jméno manželky / manžela<br>10422 Příjmení manželky / manžela<br>10423 Rodné číslo manželky / manžela nebo 10424 Datum narození manželky / manžela<br>10425 Držitelka / držitel karty ZTP/P<br>10426 Počet měsíců uplatnění slevy<br>10420 Uplatněna sleva na manželku / manžela |  |
| 63 | L | L63 | Nejsou uvedena všechna povinná pole pro uplatnění slevy za manžela / -ku. |  |
| 63 | M | M63 | nová |  |
| 64 | A | A64 | 125 |  |
| 64 | B | B64 | Kontrola vyplnění počet měsíců uplatnění slevy ZTP/P (roční zúčtování) |  |
| 64 | C | C64 | 10430<br>10420<br>10425 |  |
| 64 | D | D64 | Souhrnná data zaměstnance |  |
| 64 | E | E64 | Formulář zaměstnance (form) |  |
| 64 | F | F64 | ePortál |  |
| 64 | G | G64 | nepropustná |  |
| 64 | H | H64 | DIS |  |
| 64 | I | I64 | nepropustná |  |
| 64 | J | J64 | F4 |  |
| 64 | K | K64 | Pokud je (10420) = "ANO" a zároveň (10425) = "ANO",<br>pak musí být (10430) z intervalu <1;12>.<br>---<br>10430 Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P<br>10420 Uplatněna sleva na manželku / manžela<br>10425 Držitelka / držitel karty ZTP/P |  |
| 64 | L | L64 | Počet měsíců musí být roven nebo nižší než počet měsíců uplatnění slevy na ZTP/P. |  |
| 64 | M | M64 | nová |  |
| 65 | A | A65 | 126 |  |
| 65 | B | B65 | Kontrola na vyplnění údajů další vyživující osoby (roční zúčtování) |  |
| 65 | C | C65 | 10441<br>10442<br>10443<br>10444<br>10445<br>10455 |  |
| 65 | D | D65 | Souhrnná data zaměstnance |  |
| 65 | E | E65 | Formulář zaměstnance (form) |  |
| 65 | F | F65 | ePortál |  |
| 65 | G | G65 | nepropustná |  |
| 65 | H | H65 | DIS |  |
| 65 | I | I65 | nepropustná |  |
| 65 | J | J65 | F4 |  |
| 65 | K | K65 | Pokud je (10455) = "ANO",<br>musí být vyplněny položky (10441), (10442), (10443) nebo (10444), (10445).<br>---<br>10441 Jméno<br>10442 Příjmení<br>10443 Datum narození nebo 10444 Rodné číslo<br>10445 Měsíce vyživování<br>10455 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba<br> |  |
| 65 | L | L65 | Nejsou vyplněny údaje za další vyživující osobu. |  |
| 65 | M | M65 | nová |  |
| 66 | A | A66 | 127 |  |
| 66 | B | B66 | Kontrola na vyplnění údajů další vyživující osoby |  |
| 66 | C | C66 | 10453<br>10431<br>10432<br>10433<br>10434 |  |
| 66 | D | D66 | Souhrnná data zaměstnance |  |
| 66 | E | E66 | Formulář zaměstnance (form) |  |
| 66 | F | F66 | ePortál |  |
| 66 | G | G66 | nepropustná |  |
| 66 | H | H66 | DIS |  |
| 66 | I | I66 | nepropustná |  |
| 66 | J | J66 | F4 |  |
| 66 | K | K66 | Pokud je (10453) = "ANO",<br>musí být vyplněny položky (10431), (10432), (10433) nebo (10434).<br>---<br>10431 Jméno<br>10432 Příjmení<br>10433 Datum narození nebo 10434 Rodné číslo<br>10453 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba |  |
| 66 | L | L66 | Nejsou vyplněny údaje za další vyživující osobu. |  |
| 66 | M | M66 | nová |  |
| 67 | A | A67 | 128 |  |
| 67 | B | B67 | Při uplatnění daňového zvýhodnění na děti je vyplněno alespoň 1 dítě |  |
| 67 | C | C67 | 10303<br>10435<br>10436<br>10437<br>10438<br>10440<br>10439<br>10453 |  |
| 67 | D | D67 | Souhrnná data zaměstnance |  |
| 67 | E | E67 | Formulář zaměstnance (form) |  |
| 67 | F | F67 | ePortál |  |
| 67 | G | G67 | nepropustná |  |
| 67 | H | H67 | DIS |  |
| 67 | I | I67 | nepropustná |  |
| 67 | J | J67 | F4 |  |
| 67 | K | K67 | Pokud (10303) > 0,<br>pak musí být vyplněny všechny povinné atr. z třídy "Výpočet zálohy na daň" a podtřídy "Vyživované děti"<br>---<br>10435 Jméno<br>10436 Příjmení<br>10437 Datum narození nebo 10438 Rodné číslo<br>10440 Pořadí pro určení výše daňového zvýhodnění<br>10303 Měsíční daňové zvýhodnění na děti<br>10439 Průkaz ZTP/P<br>10453 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba |  |
| 67 | L | L67 | Nejsou vyplněny údaje za děti. |  |
| 67 | M | M67 | nová |  |
| 68 | A | A68 | 129 |  |
| 68 | B | B68 | Číslo měsíce |  |
| 68 | C | C68 | 10010 |  |
| 68 | D | D68 | Meta atributy |  |
| 68 | E | E68 | Měsíční podání JMHZ |  |
| 68 | F | F68 | ePortál |  |
| 68 | G | G68 | nepropustná |  |
| 68 | H | H68 | DIS |  |
| 68 | I | I68 | nepropustná |  |
| 68 | J | J68 | T6 |  |
| 68 | K | K68 | Uvedené číslo měsíce (10010) = <1,12>.<br>---<br>10010 Měsíc<br> |  |
| 68 | L | L68 | Číslo měsíce musí být v rozsahu 1-12 včetně. |  |
| 68 | M | M68 | nová |  |
| 69 | A | A69 | 130 |  |
| 69 | B | B69 | Kontrola, že datum od je nižší nebo roven než datum do (průběh studia) |  |
| 69 | C | C69 | 10263<br>10264 |  |
| 69 | D | D69 | Průběh teoretické a praktické přípravy |  |
| 69 | E | E69 | Formulář zaměstnance (form) |  |
| 69 | F | F69 | ePortál |  |
| 69 | G | G69 | nepropustná |  |
| 69 | H | H69 | DIS |  |
| 69 | I | I69 | nepropustná |  |
| 69 | J | J69 | F4 |  |
| 69 | K | K69 | Datum od (10263) musí být nižší nebo roven než Datum do (10264).<br>---<br>10263 Datum od<br>10264 Datum do |  |
| 69 | L | L69 | Datum od musí být nižší než Datum do. |  |
| 69 | M | M69 | nová |  |
| 69 | N | N69 | OŘ3: ČSSZ-203 |  |
| 70 | A | A70 | 131 |  |
| 70 | B | B70 | Rok |  |
| 70 | C | C70 | 10011<br>10010 |  |
| 70 | D | D70 | Meta atributy |  |
| 70 | E | E70 | Měsíční podání JMHZ |  |
| 70 | F | F70 | ePortál |  |
| 70 | G | G70 | nepropustná |  |
| 70 | H | H70 | DIS |  |
| 70 | I | I70 | nepropustná |  |
| 70 | J | J70 | T6 |  |
| 70 | K | K70 | Měsíc (10010) a rok (10011), za které je podávno, musí být vyšší nebo rovno "leden 2026".<br>---<br>10010 Měsíc<br>10011 Rok |  |
| 70 | L | L70 | JMHZ neslouží pro hlášení za zvolené období. |  |
| 70 | M | M70 | nová |  |
| 70 | N | N70 | OŘ3: ČSSZ-210 |  |
| 71 | A | A71 | 132 |  |
| 71 | B | B71 | Kontrola roku pro podání opravného hlášení. |  |
| 71 | C | C71 | 10011 |  |
| 71 | D | D71 | Meta atributy |  |
| 71 | E | E71 | Měsíční podání JMHZ |  |
| 71 | F | F71 | ePortál |  |
| 71 | G | G71 | nepropustná |  |
| 71 | H | H71 | DIS |  |
| 71 | I | I71 | nepropustná |  |
| 71 | J | J71 | T6 |  |
| 71 | K | K71 | Opravné hlášení lze podat nejpozději do 10 let (10006) od konce kalendářního roku (10011), ve kterém byl zaměstnavatel povinen podat jednotné měsíční hlášení, které je opravováno (10007).<br>---<br>10011 Rok<br>10006 Datum a čas přijetí podání<br>10007 Typ podání<br> |  |
| 71 | L | L71 | Zvolený rok přesahuje období pro hlášení do JMHZ. |  |
| 71 | M | M71 | nová |  |
| 71 | N | N71 | OŘ3: ČSSZ-210 |  |
| 72 | A | A72 | 133 |  |
| 72 | B | B72 | Kontrola správnosti Kódu ELDP při zaměstnání malého rozsahu |  |
| 72 | C | C72 | 10240<br>10243 |  |
| 72 | D | D72 | Průběh pojištění v daném měsíci |  |
| 72 | E | E72 | Měsíční podání JMHZ |  |
| 72 | F | F72 | ePortál |  |
| 72 | G | G72 | nepropustná |  |
| 72 | H | H72 | cJMHZ |  |
| 72 | I | I72 | nepropustná |  |
| 72 | J | J72 | F5 |  |
| 72 | K | K72 | 1.: je-li první pozice údaje Kód ELDP (10240) = "T", "U", "V", "W", "X", "Y", "Z", "ZA", "ZB", "ZC" pak hodnota Malý rozsah (10243) nesmí být = "A"<br>2.: je-li třetí pozice údaje Kód (10240)= "B", "F", "J", "V", "T", pak hodnota Malý rozsah (10243) nesmí být = "A"<br>3.: je-li druhý pozice údaje Kód (10240) = "P", pak hodnota údaje Malý rozsah (10243) nesmí být = "A"<br>---<br>10240 Kód ELDP<br>10243 Zaměstnání malého rozsahu |  |
| 72 | L | L72 | U daného kódu ELDP není možné zaměstnání malého rozsahu. |  |
| 72 | M | M72 | AS-IS |  |
| 72 | N | N72 | OŘ3: ČSSZ-213 |  |
| 73 | A | A73 | 134 |  |
| 73 | B | B73 | Počet kalendářních dnů trvání pojištění v daném kalendářním měsíci - interval |  |
| 73 | C | C73 | 10356<br>10355<br>10354 |  |
| 73 | D | D73 | Průběh pojištění v daném měsíci |  |
| 73 | E | E73 | Formulář zaměstnance (form) |  |
| 73 | F | F73 | ePortál |  |
| 73 | G | G73 | nepropustná |  |
| 73 | H | H73 | DIS |  |
| 73 | I | I73 | nepropustná |  |
| 73 | J | J73 | F4 |  |
| 73 | K | K73 | Uvedený počet dnů (10356) <= (10355) - (10354)<br>---<br>10356 Počet kalendářních dnů doby důchodového pojištění v daném kalendářním měsíci<br>10354 Pojištění od<br>10355 Pojištění do |  |
| 73 | L | L73 | Počet kalendářních dnů neodpovídá uvedeným datům trvání pojištění v daném měsíci. |  |
| 73 | M | M73 | nová |  |
| 73 | N | N73 | OŘ: 204-ČSSZ |  |
| 74 | A | A74 | 135 |  |
| 74 | B | B74 | Uvedení trvání pojištění v daném měsíci |  |
| 74 | C | C74 | 10356<br>10375<br>10240<br>10354<br>10355 |  |
| 74 | D | D74 | Průběh pojištění v daném měsíci |  |
| 74 | E | E74 | Formulář zaměstnance (form) |  |
| 74 | F | F74 | ePortál |  |
| 74 | G | G74 | nepropustná |  |
| 74 | H | H74 | DIS |  |
| 74 | I | I74 | nepropustná |  |
| 74 | J | J74 | F4 |  |
| 74 | K | K74 | 1.: Je-li v údaji Kód ELDP na druhé pozici "V", pak údaj Započtené dny (10356) < nebo = Σ dnů z intervalu od (10354) – do (10355).<br>2.: Je-li druhá pozice údaje Kód ELDP = "P", pak údaj Započtené dny  (10356) = 0.<br>3.: Je-li druhá pozice údaje Kód ELDP různý od "P" a "V" a zároveň třetí pozice údaje Kód ELDP roven "T" a zároveň jsou uvedeny Odečtené doby (10375), pak hodnota údaje Započtené dny (10356) se musí rovnat součtu dnů z intervalu (od (10354) – do (10355)) - Odečtené doby (10375).<br>---<br>10356 Počet kalendářních dnů trvání doby důchodového pojištění v daném kalendářním měsíci (Započtené dny)<br>10375 Odečtené doby<br>10240 Kód ELDP<br>10354 Pojištění od<br>10355 Pojištění do |  |
| 74 | L | L74 | Uvedená doba trvání pojištění neodpovídá kódu ELDP. |  |
| 74 | M | M74 | nová |  |
| 74 | N | N74 | OŘ: ČSSZ-214 |  |
| 75 | A | A75 | 137 |  |
| 75 | B | B75 | Vyplnění důvodu uplatnění slevy |  |
| 75 | C | C75 | 10374<br>10372 |  |
| 75 | D | D75 | Průběh pojištění v daném měsíci |  |
| 75 | E | E75 | Formulář zaměstnance (form) |  |
| 75 | F | F75 | ePortál |  |
| 75 | G | G75 | nepropustná |  |
| 75 | H | H75 | DIS |  |
| 75 | I | I75 | nepropustná |  |
| 75 | J | J75 | F4 |  |
| 75 | K | K75 | Pokud je (10372) = "ANO" pak,<br>Důvod uplatnění slevy (10374) musí být vyplněn<br>---<br>10372 Sleva na pojistném<br>10374 Důvod uplatnění slevy |  |
| 75 | L | L75 | Důvod uplatnění slevy musí být vyplněn, pokud je za zaměstnance uplatněna sleva na pojistném zaměstnavatele. |  |
| 75 | M | M75 | nová |  |
| 75 | N | N75 | OŘ3: ČSSZ-51 |  |
| 76 | A | A76 | 138 |  |
| 76 | B | B76 | Kratší rozsah pracovní/služební doby musí být vyplněn |  |
| 76 | C | C76 | 10373<br>10372<br>10374 |  |
| 76 | D | D76 | Průběh pojištění v daném měsíci |  |
| 76 | E | E76 | Formulář zaměstnance (form) |  |
| 76 | F | F76 | ePortál |  |
| 76 | G | G76 | nepropustná |  |
| 76 | H | H76 | DIS |  |
| 76 | I | I76 | nepropustná |  |
| 76 | J | J76 | F4 |  |
| 76 | K | K76 | Pakliže je (10372) = "ANO" a zároveň Důvod uplatnění slevy (10374) = "A" až "F" pak,<br>kratší rozsah pracovní/služební doby (10373) musí být vyplněn.<br>---<br>10372 Sleva na pojistném zaměstnavatele<br>10373 Rozsah kratší pracovní/služební doby<br>10374 Důvod uplatnění slevy" |  |
| 76 | L | L76 | Kratší rozsah služební doby musí být vyplněn. |  |
| 76 | M | M76 | nová |  |
| 76 | N | N76 | OŘ3: ČSSZ-51 |  |
| 77 | A | A77 | 140 |  |
| 77 | B | B77 | Neuvedení požadavku na příspěvek APZ v aktuálním měsíci, když v předchozím měsíci byl uveden |  |
| 77 | C | C77 | 10232<br>10010 |  |
| 77 | D | D77 | Vykonávaná pozice zaměstnance |  |
| 77 | E | E77 | Formulář zaměstnance (form) |  |
| 77 | F | F77 | ePortál |  |
| 77 | G | G77 | nepropustná |  |
| 77 | H | H77 | cJMHZ |  |
| 77 | I | I77 | propustná |  |
| 77 | J | J77 | F5 |  |
| 77 | K | K77 | Pokud zaměstnavatel v měsíčním hlášení nevyplní atribut APZ (10232 = "ANO"), ačkoliv ho v předchozím měsíci(10010) uvedl, bude na tuto skutečnost upozorněn.<br>---<br>10010 Měsíc<br>10232 Mzdový příspěvek v rámci nástrojů APZ |  |
| 77 | L | L77 | V minulém měsíci byl uveden požadavek na příspěvek APZ. |  |
| 77 | M | M77 | nová |  |
| 78 | A | A78 | 142 |  |
| 78 | B | B78 | Úhrn vyměřovacích základů zaměstnanců zaměstnavatele, kteří vykonávají činnost v rizikovém zaměstnání |  |
| 78 | C | C78 | 10483<br>10480 |  |
| 78 | D | D78 | Přehled o výši pojistného |  |
| 78 | E | E78 | Formulář PVPOJ a zaměstnance |  |
| 78 | F | F78 | ePortál |  |
| 78 | G | G78 | propustná |  |
| 78 | H | H78 | cJMHZ |  |
| 78 | I | I78 | propustná |  |
| 78 | J | J78 | F5 |  |
| 78 | K | K78 | Úhrn vyměřovacích základů zaměstnanců zaměstnavatele, kteří vykonávají činnost v rizikovém zaměstnání (10483) se = ∑ (n) vyměřovacích základů dotčených zaměstnanců (10480).<br>---<br>10480 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ <br>10483 Úhrn vyměřovacích základů zaměstnanců, kteří vykonávají rizikové zaměstnání |  |
| 78 | L | L78 | Úhrn nesouhlasí se součtem vyměřovacích základů dotčených zaměstnanců, kteří vykonávají činnost v rizikovém zaměstnání. |  |
| 78 | M | M78 | nová |  |
| 79 | A | A79 | 143 |  |
| 79 | B | B79 | Variabilní symbol zaměstnavatele |  |
| 79 | C | C79 | 10221 |  |
| 79 | D | D79 | Zaměstnavatel  / Škola / Vzdělávací zařízení |  |
| 79 | E | E79 | Souhrnná vrstva (souhrn) |  |
| 79 | F | F79 | ePortál |  |
| 79 | G | G79 | nepropustná |  |
| 79 | H | H79 | DIS |  |
| 79 | I | I79 | nepropustná |  |
| 79 | J | J79 | T5 |  |
| 79 | K | K79 | Standardní kontrola tvaru VS a Kontrola vůči registru zaměstnavatelů.<br>---<br>10221 Variabilní symbol |  |
| 79 | L | L79 | Variabilní symbol není platný. |  |
| 79 | M | M79 | nová |  |
| 80 | A | A80 | 144 |  |
| 80 | B | B80 | Překážky na straně zaměstnance s náhradou mzdy/platu - počet neodpracovaných hodin |  |
| 80 | C | C80 | 10471<br>10260 |  |
| 80 | D | D80 | Průběh zaměstnání v daném měsíci |  |
| 80 | E | E80 | Formulář zaměstnance (form) |  |
| 80 | F | F80 | ePortál |  |
| 80 | G | G80 | nepropustná |  |
| 80 | H | H80 | DIS |  |
| 80 | I | I80 | nepropustná |  |
| 80 | J | J80 | F4 |  |
| 80 | K | K80 | Hodnota Překážky na straně zaměstnance s náhradou mzdy/platu - počet neodpracovaných hodin (10471) nesmí být vyšší než Pracovní doba sjednaná (v hodinách měsíčně) (10260).<br>---<br>10260 Pracovní doba sjednaná (v hodinách měsíčně)<br>10471 Překážky na straně zaměstnance s náhradou mzdy/platu - počet neodpracovaných hodin |  |
| 80 | L | L80 | Hodnota Překážky na straně zaměstnance s náhradou mzdy/platu - počet neodpracovaných hodin nesmí být vyšší než Pracovní doba sjednaná (v hodinách měsíčně). |  |
| 80 | M | M80 | nová |  |
| 81 | A | A81 | 145 |  |
| 81 | B | B81 | Překážky na straně zaměstnavatele - počet neodpracovaných hodin |  |
| 81 | C | C81 | 10472<br>10260 |  |
| 81 | D | D81 | Průběh zaměstnání v daném měsíci |  |
| 81 | E | E81 | Formulář zaměstnance (form) |  |
| 81 | F | F81 | ePortál |  |
| 81 | G | G81 | nepropustná |  |
| 81 | H | H81 | DIS |  |
| 81 | I | I81 | nepropustná |  |
| 81 | J | J81 | F4 |  |
| 81 | K | K81 | Hodnota Překážky na straně zaměstnavatele - počet neodpracovaných hodin (10472) nesmí být vyšší než Sjednaný fond pracovní doby (v hodinách měsíčně) (10260).<br>---<br>10260 Sjednaný fond pracovní doby (v hodinách měsíčně)<br>10472 Překážky na straně zaměstnavatele - počet neodpracovaných hodin |  |
| 81 | L | L81 | Hodnota Překážky na straně zaměstnavatele - počet neodpracovaných hodin nesmí být vyšší než Sjednaný fond pracovní doby (v hodinách měsíčně). |  |
| 81 | M | M81 | nová |  |
| 82 | A | A82 | 148 |  |
| 82 | B | B82 | Specifická právní skutečnost |  |
| 82 | C | C82 | 10408 |  |
| 82 | D | D82 | Souhrnná vrstva |  |
| 82 | E | E82 | Souhrnná vrstva (souhrn) |  |
| 82 | F | F82 | ePortál |  |
| 82 | G | G82 | nepropustná |  |
| 82 | H | H82 | DIS |  |
| 82 | I | I82 | nepropustná |  |
| 82 | J | J82 | F4 |  |
| 82 | K | K82 | Hodnota musí být z číselníku.<br>---<br>10408 Specifická právní skutečnost |  |
| 82 | L | L82 | ="Hodnota " & B82 & " neodpovídá číselníku." |  |
| 82 | M | M82 | nová |  |
| 83 | A | A83 | 150 |  |
| 83 | B | B83 | Typ kolektivní smlouvy/dohody |  |
| 83 | C | C83 | 10214 |  |
| 83 | D | D83 | Souhrnná vrstva |  |
| 83 | E | E83 | Souhrnná vrstva (souhrn) |  |
| 83 | F | F83 | n/a |  |
| 83 | G | G83 | n/a |  |
| 83 | H | H83 | DIS |  |
| 83 | I | I83 | nepropustná |  |
| 83 | J | J83 | F4 |  |
| 83 | K | K83 | Hodnota musí být z číselníku<br>---<br>10214 Kolektivní smlouva/dohoda |  |
| 83 | L | L83 | ="Hodnota " & B83 & " neodpovídá číselníku." |  |
| 83 | M | M83 | nová |  |
| 84 | A | A84 | 151 |  |
| 84 | B | B84 | Forma vlastnictví |  |
| 84 | C | C84 | 10220 |  |
| 84 | D | D84 | Souhrnná vrstva |  |
| 84 | E | E84 | Souhrnná vrstva (souhrn) |  |
| 84 | F | F84 | n/a |  |
| 84 | G | G84 | n/a |  |
| 84 | H | H84 | DIS |  |
| 84 | I | I84 | nepropustná |  |
| 84 | J | J84 | F4 |  |
| 84 | K | K84 | Hodnota musí být z číselníku<br>---<br>10220 Forma |  |
| 84 | L | L84 | ="Hodnota " & B84 & " neodpovídá číselníku." |  |
| 84 | M | M84 | nová |  |
| 85 | A | A85 | 152 |  |
| 85 | B | B85 | Kód obce |  |
| 85 | C | C85 | 10230 |  |
| 85 | D | D85 | Vykonávaná pozice zaměstnance |  |
| 85 | E | E85 | Formulář zaměstnance (form) |  |
| 85 | F | F85 | n/a |  |
| 85 | G | G85 | n/a |  |
| 85 | H | H85 | DIS |  |
| 85 | I | I85 | nepropustná |  |
| 85 | J | J85 | F4 |  |
| 85 | K | K85 | Hodnota musí být z číselníku<br>---<br>10230 Kód obce |  |
| 85 | L | L85 | ="Hodnota " & B85 & " neodpovídá číselníku." |  |
| 85 | M | M85 | nová |  |
| 86 | A | A86 | 153 |  |
| 86 | B | B86 | Kód státu |  |
| 86 | C | C86 | 10231 |  |
| 86 | D | D86 | Vykonávaná pozice zaměstnance |  |
| 86 | E | E86 | Formulář zaměstnance (form) |  |
| 86 | F | F86 | n/a |  |
| 86 | G | G86 | n/a |  |
| 86 | H | H86 | DIS |  |
| 86 | I | I86 | nepropustná |  |
| 86 | J | J86 | F4 |  |
| 86 | K | K86 | Hodnota musí být z číselníku<br>---<br>10231 Stát |  |
| 86 | L | L86 | ="Hodnota " & B86 & " neodpovídá číselníku." |  |
| 86 | M | M86 | nová |  |
| 87 | A | A87 | 154 |  |
| 87 | B | B87 | Nástroj opatření - APZ |  |
| 87 | C | C87 | 10233 |  |
| 87 | D | D87 | Vykonávaná pozice zaměstnance |  |
| 87 | E | E87 | Formulář zaměstnance (form) |  |
| 87 | F | F87 | n/a |  |
| 87 | G | G87 | n/a |  |
| 87 | H | H87 | DIS |  |
| 87 | I | I87 | nepropustná |  |
| 87 | J | J87 | F4 |  |
| 87 | K | K87 | Hodnota musí být z číselníku<br>---<br>10233 Nástroj (opatření) |  |
| 87 | L | L87 | ="Hodnota " & B87 & " neodpovídá číselníku." |  |
| 87 | M | M87 | nová |  |
| 88 | A | A88 | 155 |  |
| 88 | B | B88 | Druh činnosti |  |
| 88 | C | C88 | 10239 |  |
| 88 | D | D88 | Vykonávaná pozice zaměstnance |  |
| 88 | E | E88 | Formulář zaměstnance (form) |  |
| 88 | F | F88 | n/a |  |
| 88 | G | G88 | n/a |  |
| 88 | H | H88 | DIS |  |
| 88 | I | I88 | nepropustná |  |
| 88 | J | J88 | F4 |  |
| 88 | K | K88 | Hodnota musí být z číselníku<br>---<br>10239 Druh činnosti |  |
| 88 | L | L88 | ="Hodnota " & B88 & " neodpovídá číselníku." |  |
| 88 | M | M88 | nová |  |
| 89 | A | A89 | 156 |  |
| 89 | B | B89 | Kategorizace rizika |  |
| 89 | C | C89 | 10274 |  |
| 89 | D | D89 | Průběh zaměstnání v daném měsíci |  |
| 89 | E | E89 | Formulář zaměstnance (form) |  |
| 89 | F | F89 | n/a |  |
| 89 | G | G89 | n/a |  |
| 89 | H | H89 | DIS |  |
| 89 | I | I89 | nepropustná |  |
| 89 | J | J89 | F4 |  |
| 89 | K | K89 | Hodnota musí být z číselníku<br>---<br>10274 Kategorizace rizika |  |
| 89 | L | L89 | ="Hodnota " & B89 & " neodpovídá číselníku." |  |
| 89 | M | M89 | nová |  |
| 90 | A | A90 | 157 |  |
| 90 | B | B90 | Kód ELDP |  |
| 90 | C | C90 | 10240 |  |
| 90 | D | D90 | Průběh pojištění v daném měsíci |  |
| 90 | E | E90 | Formulář zaměstnance (form) |  |
| 90 | F | F90 | n/a |  |
| 90 | G | G90 | n/a |  |
| 90 | H | H90 | DIS |  |
| 90 | I | I90 | nepropustná |  |
| 90 | J | J90 | F4 |  |
| 90 | K | K90 | Hodnota musí být z číselníku<br>---<br>10240 Kód ELDP |  |
| 90 | L | L90 | ="Hodnota " & B90 & " neodpovídá číselníku." |  |
| 90 | M | M90 | nová |  |
| 91 | A | A91 | 158 |  |
| 91 | B | B91 | Důvod uplatnění slevy |  |
| 91 | C | C91 | 10374 |  |
| 91 | D | D91 | Průběh pojištění v daném měsíci |  |
| 91 | E | E91 | Formulář zaměstnance (form) |  |
| 91 | F | F91 | n/a |  |
| 91 | G | G91 | n/a |  |
| 91 | H | H91 | DIS |  |
| 91 | I | I91 | nepropustná |  |
| 91 | J | J91 | F4 |  |
| 91 | K | K91 | Hodnota musí být z číselníku<br>---<br>10374 Důvod uplatnění slevy |  |
| 91 | L | L91 | ="Hodnota " & B91 & " neodpovídá číselníku." |  |
| 91 | M | M91 | nová |  |
| 92 | A | A92 | 159 |  |
| 92 | B | B92 | Mzdový příspěvek v rámci nástrojů APZ |  |
| 92 | C | C92 | 10232<br>10233 |  |
| 92 | D | D92 | Vykonávaná pozice zaměstnance |  |
| 92 | E | E92 | Formulář zaměstnance (form) |  |
| 92 | F | F92 | n/a |  |
| 92 | G | G92 | n/a |  |
| 92 | H | H92 | DIS |  |
| 92 | I | I92 | nepropustná |  |
| 92 | J | J92 | F4 |  |
| 92 | K | K92 | Pokud je (10232) = "ANO",<br>potom musí být vyplněn (10233).<br>---<br>10232 Mzdový příspěvek v rámci nástrojů APZ<br>10233 Nástroj (opatření) |  |
| 92 | L | L92 | Chybí nástroj v rámci APZ. |  |
| 92 | M | M92 | nová |  |
| 93 | A | A93 | 162 |  |
| 93 | B | B93 | Pokud vznikla účast na pojistném, je třeba vyplnit alespoň jeden typ vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a, b nebo c |  |
| 93 | C | C93 | 10023<br>10025<br>10483<br><br><br> |  |
| 93 | D | D93 | Přehled o výši pojistného |  |
| 93 | E | E93 | Formulář PVPOJ (pvpoj) |  |
| 93 | F | F93 | ePortál |  |
| 93 | G | G93 | nepropustná |  |
| 93 | H | H93 | DIS |  |
| 93 | I | I93 | nepropustná |  |
| 93 | J | J93 | F4 |  |
| 93 | K | K93 | Atributy musí být vyplněny:<br>1) (10023, 10025, 10483) = 0<br>2) nebo v jedné z položek (10023, 10025, 10483) musí být nenulová kladná hodnota.<br>---<br>10023 Úhrn vyměřovacích základů zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku<br>10025 Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku<br>10483 Úhrn vyměřovacích základů zaměstnanců, kteří vykonávají rizikové zaměstnání<br> |  |
| 93 | L | L93 | Je potřeba vyplnit alespoň jednu částku vyměřovacího základu zaměstnavatele nebo nuly. |  |
| 93 | M | M93 | nová |  |
| 94 | A | A94 | 164 |  |
| 94 | B | B94 | Kontrola na uplatnění slevy na pojistném zaměstnavatele v rámci splatnosti pojistného |  |
| 94 | C | C94 | 10032<br>10006<br>10010<br>10011<br>10016 |  |
| 94 | D | D94 | Přehled o výši pojistného |  |
| 94 | E | E94 | Formulář PVPOJ (pvpoj) |  |
| 94 | F | F94 | ePortál |  |
| 94 | G | G94 | nepropustná |  |
| 94 | H | H94 | DIS |  |
| 94 | I | I94 | nepropustná |  |
| 94 | J | J94 | F4 |  |
| 94 | K | K94 | Pokud je (10016) = "R" a současně (10032) > 0 a (10006) je po lhůtě splatnosti pojistného (lhůta se určuje podle atributů (10010), (10011) na DIS pomocí kalendáře splatnosti),<br>pak slevu na pojistném zaměstnavatele (10032) nelze uplatnit.<br>----<br>10032 Sleva na pojistném zaměstnavatele<br>10006 Datum a čas přijetí podání<br>10010 Měsíc<br>10011 Rok<br>10016 Typ formuláře |  |
| 94 | L | L94 | Slevu na pojistném zaměstnavatele nelze uplatnit po lhůtě splatnosti pojistného. |  |
| 94 | M | M94 | nová |  |
| 94 | N | N94 | DŮLEŽITÉ:<br>tato kontrola 164 bude pro podání za měsíce 1,2,3/2026 vypnuta, tento bypass platí do 30. 06. 2026<br><br>vysvětlení lhůta splatnosti: pojistné je splatné od 1. do 20. dne následujícího kalendářního měsíce. Připadne-li 20. den na sobotu, neděli nebo státní svátek, považuje se za den splatnosti nejbližší následující pracovní den. |  |
| 95 | A | A95 | 165 |  |
| 95 | B | B95 | Kontrola vyplnění vyloučených dob dle  § 18 odst. 7 |  |
| 95 | C | C95 | 10366<br>10473<br>10474<br>10475 |  |
| 95 | D | D95 | Průběh pojištění v daném měsíci |  |
| 95 | E | E95 | Formulář zaměstnance (form) |  |
| 95 | F | F95 | ePortál |  |
| 95 | G | G95 | nepropustná |  |
| 95 | H | H95 | DIS |  |
| 95 | I | I95 | nepropustná |  |
| 95 | J | J95 | F4 |  |
| 95 | K | K95 | Pro datové scénáře:<br>1) druh činnosti: 1 až 9 s příznakem (10502) = "žádné"; A až J; T až ZC, formBezPriznaku.xsd<br>2) druh činnosti: M, formPestoun.xsd<br>3) druh činnosti: K, N, O, P, Q, R, S nebo 1 až 9 s příznakem (10502) = "Pracovní vztah specifické skupiny", formCinnostKS.xsd<br>4) druh činnosti: odložený příjem, formOdlozenyPrijem.xsd<br>platí následující kontrola:<br>pokud je (10366) > 0, <br>pak musí být (10366) = (10473 + 10474 + 10475)<br>---<br>10473 Počet dnů omluvené nepřítomnosti, za které nenáleží náhrada příjmu (neplacené volno, stávka)<br>10474 Počet dnů dočasné pracovní neschopnosti nebo karantény, za které náleží náhrada příjmu<br>10475 Počet dnů, za které bylo zaměstnanci vypláceno nemocenské, peněžitá pomoc v mateřství, otcovská, ošetřovné nebo dlouhodobé ošetřovné<br>10366 Vyloučené dny podle § 18 odst. 7 zákona č. 187/2006 Sb. |  |
| 95 | L | L95 | Vyloučené dny celkem musí být součtem jednotlivých typů vyloučených dnů. |  |
| 95 | M | M95 | nová |  |
| 96 | A | A96 | 166 |  |
| 96 | B | B96 | Kontrola vyplnění odečítaných dnů |  |
| 96 | C | C96 | 10462<br>10463<br>10464<br>10465<br>10466<br>10468<br>10469<br>10375<br> |  |
| 96 | D | D96 | Průběh pojištění v daném měsíci |  |
| 96 | E | E96 | Formulář zaměstnance (form) |  |
| 96 | F | F96 | ePortál |  |
| 96 | G | G96 | nepropustná |  |
| 96 | H | H96 | DIS |  |
| 96 | I | I96 | nepropustná |  |
| 96 | J | J96 | F4 |  |
| 96 | K | K96 | Pokud (10375) > 0,<br>pak platí že, 10375 = (10462 + 10463 + 10464 + 10465 + 10466 + 10468 + 10469).<br>---<br>10462 Počet dnů trvání dočasné pracovní neschopnosti (karanténa)<br>10463 Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)<br>10464 Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné<br>10465 Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné <br>10466 Počet dnů čerpání otcovské<br>10468 Počet dnů čerpání neplaceného volna<br>10469 Počet dnů neomluvené absence<br>10375 Doby odečítané po důchodovém věku - počet dnů |  |
| 96 | L | L96 | Doby odečítané po důchodovém věku - počet dnů musí být roven sumě atributů: Doby odečítané po důchodovém věku - počet dnů, Počet dnů trvání dočasné pracovní neschopnosti (karanténa), Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu), Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné, Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné, Počet dnů čerpání otcovské, Počet dnů čerpání neplaceného volna, Počet dnů neomluvené absence. |  |
| 96 | M | M96 | nová |  |
| 97 | A | A97 | 167 |  |
| 97 | B | B97 | Pojistné za zaměstnavatele u zaměstnanců, kteří vykonávají rizikové zaměstnání |  |
| 97 | C | C97 | 10484<br>10483 |  |
| 97 | D | D97 | Přehled o výši pojistného |  |
| 97 | E | E97 | Formulář PVPOJ (pvpoj) |  |
| 97 | F | F97 | ePortál |  |
| 97 | G | G97 | nepropustná |  |
| 97 | H | H97 | DIS |  |
| 97 | I | I97 | nepropustná |  |
| 97 | J | J97 | F4 |  |
| 97 | K | K97 | ="Pojistné za zaměstnavatele u zaměstnanců, kteří vykonávají rizikové zaměstnání (10484) = " & 'Parametrické konstanty'!C5  &<br>" * Úhrn vyměřovacích základů zaměstnanců, kteří vykonávají rizikové zaměstnání (10483). Zaokrohluje se na celé koruny nahoru."<br>& CHAR(10) &<br>"---" & CHAR(10) &<br>"10483 Úhrn vyměřovacích základů zaměstnanců, kteří vykonávají rizikové zaměstnání" & CHAR(10) &<br>"10484 Pojistné za zaměstnavatele u zaměstnanců, kteří vykonávají rizikové zaměstnání" |  |
| 97 | L | L97 | Vykázané pojistné neodpovídá vykázanému úhrnu vyměřovacích základů zaměstnanců, kteří vykonávají rizikové zaměstnání. |  |
| 97 | M | M97 | nová |  |
| 98 | A | A98 | 168 |  |
| 98 | B | B98 | Pojistné za zaměstnance |  |
| 98 | C | C98 | 10028<br>10023<br>10025<br>10483 |  |
| 98 | D | D98 | Přehled o výši pojistného |  |
| 98 | E | E98 | Formulář PVPOJ (pvpoj) |  |
| 98 | F | F98 | ePortál |  |
| 98 | G | G98 | nepropustná |  |
| 98 | H | H98 | DIS |  |
| 98 | I | I98 | nepropustná |  |
| 98 | J | J98 | F4 |  |
| 98 | K | K98 | ="Pro (10028) platí:" & CHAR(10) & "hodnota údaje je dána výrazem v absolutní hodnotě: \|1 – ("& ('Parametrické konstanty'!C7*100)<br>&" % úhrnu vyměřovacích základů pojistného (10023 + 10025 + 10483) / Úhrn pojistného za zaměstnance (10028))\| <= 0.01 nebo \|"<br>& ('Parametrické konstanty'!C7*100) & " % úhrnu vyměřovacích základů pojistného (10023 + 10025 + 10483) – Úhrn pojistného za zaměstnance (10028)\| <= 100; <br><br>tzn. akceptovány budou hodnoty, kdy Úhrn pojistného za zaměstnance (10028) je větší než "<br>& ('Parametrické konstanty'!C7*100) & " % úhrnu vyměřovacích základů pojistného (10023 + 10025 + 10483), ale rozdíl částek je <= 100 (obě podmínky musejí být porušeny současně, aby nebyl údaj akceptován), " & CHAR(10)<br>& "a zároveň musí platit (10028) >= " & ('Parametrické konstanty'!C8*100) & " % z (10023 + 10025 + 10483)" & CHAR(10) & "---" & CHAR(10)<br>& "10023 Úhrn vyměřovacích základů zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku" & CHAR(10)<br>& "10025 Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku" & CHAR(10)<br>& "10028 Pojistné za zaměstnance" & CHAR(10)<br>& "10483 Úhrn vyměřovacích základů zaměstnanců, kteří vykonávají rizikové zaměstnání" |  |
| 98 | L | L98 | Vykázané pojistné za zaměstnance neodpovídá celkové částce vykázaných úhrnů vyměřovacích základů zaměstnanců. |  |
| 98 | M | M98 | nová |  |
| 99 | A | A99 | 170 |  |
| 99 | B | B99 | Úhrn slev na pojistném zaměstnanců |  |
| 99 | C | C99 | 10487<br>10486<br> |  |
| 99 | D | D99 | Přehled o výši pojistného |  |
| 99 | E | E99 | Formulář PVPOJ (pvpoj) |  |
| 99 | F | F99 | ePortál |  |
| 99 | G | G99 | nepropustná |  |
| 99 | H | H99 | DIS |  |
| 99 | I | I99 | nepropustná |  |
| 99 | J | J99 | F4 |  |
| 99 | K | K99 | ="Pro (10487) platí:" & CHAR(10)<br>& "hodnota údaje je dána výrazem v absolutní hodnotě: \|1 – ("& ('Parametrické konstanty'!C9*100) &" % údaje (10486) / údaj 10487)\| <= 0.01 nebo \|"& ('Parametrické konstanty'!C9*100) &" % údaje (10486) – údaj 10487\| <= 100;" & CHAR(10) & CHAR(10)<br>& "tzn. akceptovány budou hodnoty, kdy úhrn slev na pojistném zaměstnanců (10487) je větší než "& ('Parametrické konstanty'!C9*100) &" % úhrnu vyměřovacích základů pojistného (10486)," & CHAR(10)<br>& "ale rozdíl částek je <= 100 (obě podmínky musejí být porušeny současně, aby nebyl údaj akceptován)," & CHAR(10)<br>& "a zároveň musí platit (10487) ≥ "& ('Parametrické konstanty'!C10*100) &" % z (10486)" & CHAR(10)<br>& "---" & CHAR(10)<br>& "10486 Úhrn vyměřovacích základů zaměstnanců" & CHAR(10)<br>& "10487 Úhrn slev na pojistném zaměstnanců" |  |
| 99 | L | L99 | Úhrn slev na pojistném zaměstnanců neodpovídá vykázanému úhrnu vyměřovacích základů těchto zaměstnanců. |  |
| 99 | M | M99 | nová |  |
| 100 | A | A100 | 188 |  |
| 100 | B | B100 | Sleva na pojistném zaměstnavatele jen z jednoho zaměstnání zaměstnance |  |
| 100 | C | C100 | 10372 |  |
| 100 | D | D100 | Průběh pojištění v daném měsíci |  |
| 100 | E | E100 | Formulář zaměstnance (form) |  |
| 100 | F | F100 | ePortál |  |
| 100 | G | G100 | nepropustná |  |
| 100 | H | H100 | cJMHZ |  |
| 100 | I | I100 | propustná |  |
| 100 | J | J100 | F5 |  |
| 100 | K | K100 | Vykonává-li zaměstnanec u téhož zaměstnavatele více zaměstnání v pracovním nebo služebním poměru, náleží sleva jen z jednoho zaměstnání (tj. nelze uvést v údaji (10372) = "ANO" za příslušný kalendářní měsíc u více než jednoho zaměstnání zaměstnance).<br>---<br>10372 Sleva na pojistném |  |
| 100 | L | L100 | Slevu na pojistném zaměstnavatele může zaměstnavatel uplatnit za zaměstnance pouze z jednoho zaměstnání tohoto zaměstnance. |  |
| 100 | M | M100 | nová |  |
| 100 | N | N100 | propustná kontrola - cJHMZ nedokáže rozlišit, na kterém PPV má být sleva správně umístěna |  |
| 101 | A | A101 | 190 |  |
| 101 | B | B101 | Stornování celého řádného podání |  |
| 101 | C | C101 | 10007<br>10010<br>10011 |  |
| 101 | D | D101 | Meta atributy |  |
| 101 | E | E101 | Měsíční podání JMHZ (global) |  |
| 101 | F | F101 | ePortál |  |
| 101 | G | G101 | nepropustná |  |
| 101 | H | H101 | DIS |  |
| 101 | I | I101 | nepropustná |  |
| 101 | J | J101 | F4 |  |
| 101 | K | K101 | Zaměstnavatel nesmí stornovat (10007) řádné podání jindy, než v intervalu od 1. až 20. dne v měsíci, který bezprostředně následuje po měsici (10010, 10011), za které bylo učiněno podání.<br>Pokud konec lhůty (tj. 20 den v kalendářním měsíci) připadá na víkend nebo státní svátek, pak je posledním dnem lhůty nejbližší příští pracovní den.<br>---<br>10006 Datum a čas přijetí podání<br>10007 Typ podání ("S") - storno<br>10010 Měsíc<br>10011 Rok |  |
| 101 | L | L101 | Zaměstnavatel nesmí stornovat řádné podání jindy, než v intervalu od 1. až 20. dne v měsíci, který bezprostředně následuje po měsíci, za které bylo učiněno podání. |  |
| 101 | M | M101 | nová |  |
| 102 | A | A102 | 191 |  |
| 102 | B | B102 | Kontrola na atributy uváděné jen v lednovém, únorovém nebo březnovém podání |  |
| 102 | C | C102 | 10036<br>10037<br>10320<br>10321<br>10322<br>10323<br>10420<br>10421<br>10422<br>10423<br>10424<br>10425<br>10426<br>10430<br>10454<br>10455<br>10441<br>10442<br>10443<br>10444<br>10445<br>10446<br>10447<br>10448<br>10449<br>10450<br>10451 |  |
| 102 | D | D102 | JMHZ obecně |  |
| 102 | E | E102 | Formulář zaměstnance (form) |  |
| 102 | F | F102 | ePortál |  |
| 102 | G | G102 | nepropustná |  |
| 102 | H | H102 | DIS |  |
| 102 | I | I102 | nepropustná |  |
| 102 | J | J102 | F4 |  |
| 102 | K | K102 | Atributy ve výčtu mohou být uvedeny jen v lednovém, únorové nebo březnovém podání. |  |
| 102 | L | L102 | Atribut [XY] může být uveden jen v lednovém, únorovém nebo březnovém podání. |  |
| 102 | M | M102 | nová |  |
| 102 | N | N102 | M01-02-03 |  |
| 103 | A | A103 | 192 |  |
| 103 | B | B103 | Kontrola na atributy uváděné jen v lednovém nebo únorovém podání |  |
| 103 | C | C103 | 10319 |  |
| 103 | D | D103 | Souhrnná data zaměstnance |  |
| 103 | E | E103 | Formulář zaměstnance (form) |  |
| 103 | F | F103 | ePortál |  |
| 103 | G | G103 | nepropustná |  |
| 103 | H | H103 | DIS |  |
| 103 | I | I103 | nepropustná |  |
| 103 | J | J103 | F4 |  |
| 103 | K | K103 | Atribut (10319) může být uveden jen v lednovém nebo únorovém podání.<br>---<br>10319 Zaměstnanec požádal o provedení ročního zúčtování |  |
| 103 | L | L103 | Atribut Zaměstnanec požádal o provedení ročního zúčtování může být uveden jen v lednovém nebo únorovém podání. |  |
| 103 | M | M103 | nová |  |
| 103 | N | N103 | M01-02 |  |
| 104 | A | A104 | 193 |  |
| 104 | B | B104 | Kontrola na atributy uváděné jen v lednovém podání |  |
| 104 | C | C104 | 10313<br>10317<br>10316<br>10318<br>10311<br>10312 |  |
| 104 | D | D104 | Souhrnná data zaměstnance |  |
| 104 | E | E104 | Formulář zaměstnance (form) |  |
| 104 | F | F104 | ePortál |  |
| 104 | G | G104 | nepropustná |  |
| 104 | H | H104 | DIS |  |
| 104 | I | I104 | nepropustná |  |
| 104 | J | J104 | F4 |  |
| 104 | K | K104 | Atributy ve výčtu mohou být uvedeny jen v lednovém podání. |  |
| 104 | L | L104 | Atribut [XY] může být uveden jen v lednovém podání. |  |
| 104 | M | M104 | nová |  |
| 104 | N | N104 | M01 |  |
| 105 | A | A105 | 194 |  |
| 105 | B | B105 | Kontrola na atributy uváděné jen prosincovém podání |  |
| 105 | C | C105 | 10452<br>10038<br>10039<br>10220<br>10214 |  |
| 105 | D | D105 | Souhrnná vrstva, Zaměstnavatel  / Škola / Vzdělávací zařízení |  |
| 105 | E | E105 | Formulář zaměstnance (form) |  |
| 105 | F | F105 | ePortál |  |
| 105 | G | G105 | nepropustná |  |
| 105 | H | H105 | DIS |  |
| 105 | I | I105 | nepropustná |  |
| 105 | J | J105 | F4 |  |
| 105 | K | K105 | Atributy ve výčtu mohou být uvedeny jen v prosincovém podání. |  |
| 105 | L | L105 | Atribut [XY] může být uveden jen v prosincovém podání. |  |
| 105 | M | M105 | nová |  |
| 105 | N | N105 | M12 |  |
| 106 | A | A106 | 201 |  |
| 106 | B | B106 | Datum úhrady má být větší rovno datu vyplnění  |  |
| 106 | C | C106 | 10347<br>10005 |  |
| 106 | D | D106 | Souhrnná data zaměstnance |  |
| 106 | E | E106 | Formulář zaměstnance (form) |  |
| 106 | F | F106 | ePortál |  |
| 106 | G | G106 | nepropustná |  |
| 106 | H | H106 | DIS |  |
| 106 | I | I106 | nepropustná |  |
| 106 | J | J106 | F4 |  |
| 106 | K | K106 | (10347) <= (10005)<br>---<br>10347 Datum úhrady mzdy včetně odvodů na soc. a zdravotní pojištění<br>10005 Datum a čas vyplnění podání |  |
| 106 | L | L106 | Datum úhrady musí být menší rovno datu vyplnění. |  |
| 106 | M | M106 | nová |  |
| 107 | A | A107 | 204 |  |
| 107 | B | B107 | Stornování součástí individualizované části |  |
| 107 | C | C107 | 10007<br>10010<br>10011 |  |
| 107 | D | D107 | Meta atributy |  |
| 107 | E | E107 | Formulář zaměstnance (form) |  |
| 107 | F | F107 | ePortál |  |
| 107 | G | G107 | nepropustná |  |
| 107 | H | H107 | DIS |  |
| 107 | I | I107 | nepropustná |  |
| 107 | J | J107 | F4 |  |
| 107 | K | K107 | Zaměstnavatel nesmí stornovat (10007) součásti individualizované části jindy, než v intervalu od 1. až 20. dne v měsíci, který bezprostředně následuje po měsici (10010, 10011), za které bylo učiněno podání.<br>Pokud konec lhůty (tj. 20 den v kalendářním měsíci) připadá na víkend nebo státní svátek, pak je posledním dnem lhůty nejbližší příští pracovní den. <br>---<br>10007 Typ podání ("O") - opravné<br>10016 Typ formuláře (storno součásti individualizované části)<br>10010 Měsíc<br>10011 Rok |  |
| 107 | L | L107 | Zaměstnavatel nesmí stornovat součásti individualizované části jindy než v intervalu od 1. až 20. dne v měsíci, který bezprostředně následuje po měsíci, za který bylo učiněno podání. |  |
| 107 | M | M107 | nová |  |
| 108 | A | A108 | 207 |  |
| 108 | B | B108 | Úhrn vyměřovacích základů zaměstnanců, za které zaměstnavatel uplatňuje slevu na pojistném zaměstnavatele |  |
| 108 | C | C108 | 10477<br>10372<br>10031 |  |
| 108 | D | D108 | Průběh pojištění v daném měsíci |  |
| 108 | E | E108 | Formulář PVPOJ a zaměstnance |  |
| 108 | F | F108 | ePortál |  |
| 108 | G | G108 | nepropustná |  |
| 108 | H | H108 | cJMHZ |  |
| 108 | I | I108 | propustná |  |
| 108 | J | J108 | F5 |  |
| 108 | K | K108 | Součet vyměřovacích základů zaměstnanců (10477), za které zaměstnavatel uplatňuje slevu na pojistném zaměstnavatele (10372) = "ANO",<br>se musí rovnat úhrnu vyměřovacích základů zaměstnanců (10031), za které zaměstnavatel tuto slevu uplatňuje.<br>---<br>10477 Částka vyměřovacího základu zaměstnance, ze kterého je odváděno pojistné<br>10372 Sleva na pojistném<br>10031 Úhrn vyměřovacích základů zaměstnanců |  |
| 108 | L | L108 | Vykázaný úhrn vyměřovacích základů zaměstnanců, za které zaměstnavatel uplatňuje slevu na pojistném zaměstnavatele, neodpovídá součtu vyměřovacích základů těchto zaměstnanců. |  |
| 108 | M | M108 | nová |  |
| 109 | A | A109 | 208 |  |
| 109 | B | B109 | Výše slevy na pojistném zaměstnance |  |
| 109 | C | C109 | 10490<br>10491 |  |
| 109 | D | D109 | Průběh pojištění v daném měsíci |  |
| 109 | E | E109 | Formulář zaměstnance (form) |  |
| 109 | F | F109 | ePortál |  |
| 109 | G | G109 | nepropustná |  |
| 109 | H | H109 | DIS |  |
| 109 | I | I109 | nepropustná |  |
| 109 | J | J109 | F4 |  |
| 109 | K | K109 | Výše slevy na pojistném zaměstnance (10491) musí být vyplněna jen v případě, že (10490) = "ANO".<br>---<br>10490 Sleva na pojistném zaměstnance<br>10491 Výše slevy na pojistném zaměstnance |  |
| 109 | L | L109 | Výše slevy na pojistném zaměstnance musí být vyplněna jen v případě, že je v poli Sleva na pojistném zaměstnance uvedeno ANO. |  |
| 109 | M | M109 | nová |  |
| 110 | A | A110 | 209 |  |
| 110 | B | B110 | Úhrn slev na pojistném zaměstnanců |  |
| 110 | C | C110 | 10487<br>10491 |  |
| 110 | D | D110 | Průběh pojištění v daném měsíci |  |
| 110 | E | E110 | Formulář PVPOJ a zaměstnance |  |
| 110 | F | F110 | ePortál |  |
| 110 | G | G110 | nepropustná |  |
| 110 | H | H110 | cJMHZ |  |
| 110 | I | I110 | propustná |  |
| 110 | J | J110 | F5 |  |
| 110 | K | K110 | Součet slev na pojistném zaměstnanců (10491) se musí rovnat úhrnu slev na pojistném zaměstnanců (10487).<br>---<br>10487 Úhrn slev na pojistném zaměstnanců<br>10491 Výše slevy na pojistném zaměstnance |  |
| 110 | L | L110 | Vykázaný úhrn slev na pojistném zaměstnanců neodpovídá součtu slev na pojistném těchto zaměstnanců. |  |
| 110 | M | M110 | nová |  |
| 111 | A | A111 | 211 |  |
| 111 | B | B111 | Stornování součástí individualizované části - kontrola kompletnosti řádného podání |  |
| 111 | C | C111 | 10016 |  |
| 111 | D | D111 | Meta atributy |  |
| 111 | E | E111 | Formulář zaměstnance (form) |  |
| 111 | F | F111 | ePortál |  |
| 111 | G | G111 | nepropustná |  |
| 111 | H | H111 | cJMHZ |  |
| 111 | I | I111 | nepropustná |  |
| 111 | J | J111 | F5 |  |
| 111 | K | K111 | Pokud zaměstnavatel stornuje součásti individualizované části (10016) = "S", pak v řádném podání musí zůstat min. jednu součást individualizované části (povinná část řádného podání).<br>---<br>10016 Typ formuláře |  |
| 111 | L | L111 | Stornování součástí individualizované části - řádné podání neobsahuje žádnou validní součást individualizované části. |  |
| 111 | M | M111 | nová |  |
| 112 | A | A112 | 213 |  |
| 112 | B | B112 | Kontrola Úhrn vyměřovacích základů zaměstnanců, kteří mají nárok na slevu na pojistném zaměstnance |  |
| 112 | C | C112 | 10486<br>10477<br>10490 |  |
| 112 | D | D112 | Přehled o výši pojistného |  |
| 112 | E | E112 | Formulář PVPOJ a zaměstnance |  |
| 112 | F | F112 | ePortál |  |
| 112 | G | G112 | propustná |  |
| 112 | H | H112 | cJMHZ |  |
| 112 | I | I112 | propustná |  |
| 112 | J | J112 | F5 |  |
| 112 | K | K112 | (10486) = ∑ (10477), za zaměstnance, u kterého je (10490) = "ANO"<br>---<br>10486 Úhrn vyměřovacích základů zaměstnanců<br>10477 Částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné<br>10490 Sleva na pojistném zaměstnance<br><br> |  |
| 112 | L | L112 | Vykázaný úhrn vyměřovacích základů zaměstnanců, kteří mají nárok na slevu na pojistném zaměstnance, neodpovídá součtu vyměřovacích základů těchto zaměstnanců. |  |
| 112 | M | M112 | nová |  |
| 113 | A | A113 | 214 |  |
| 113 | B | B113 | Kontrola věku dítěte pro uplatnění slevy (roční zúčtovaní) |  |
| 113 | C | C113 | 10451<br>10448<br>10449 |  |
| 113 | D | D113 | Souhrnná data zaměstnance |  |
| 113 | E | E113 | Formulář zaměstnance (form) |  |
| 113 | F | F113 | ePortál |  |
| 113 | G | G113 | nepropustná |  |
| 113 | H | H113 | DIS |  |
| 113 | I | I113 | nepropustná |  |
| 113 | J | J113 | F4 |  |
| 113 | K | K113 | Pro každý měsíc, ve kterém je uvedeno pořadí dítěte (10451), se zkontroluje, jestli 1. den daného měsíce dítě nedosáhlo věku (10448 nebo 10449) 26 let.<br>Slevu nelze uplatnit pokud datum 26. narozenin připadá na 1. den v měsíci.<br>---<br>10448 Datum narození<br>10449 Rodné číslo<br>10451 Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících<br> |  |
| 113 | L | L113 | Věk dítěte již neumožňuje uplatnění daňového zvýhodnění. |  |
| 113 | M | M113 | nová |  |
| 114 | A | A114 | 215 |  |
| 114 | B | B114 | Kontrola věku dítěte pro uplatnění slevy (měsíční zúčtovaní) |  |
| 114 | C | C114 | 10440<br>10437<br>10438  |  |
| 114 | D | D114 | Souhrnná data zaměstnance |  |
| 114 | E | E114 | Formulář zaměstnance (form) |  |
| 114 | F | F114 | ePortál |  |
| 114 | G | G114 | nepropustná |  |
| 114 | H | H114 | DIS |  |
| 114 | I | I114 | nepropustná |  |
| 114 | J | J114 | F4 |  |
| 114 | K | K114 | Pro každý měsíc, ve kterém je uvedeno pořadí dítěte (10440), se zkontroluje, jestli 1. den daného měsíce dítě nedosáhlo věku (10437 nebo 10438) 26 let.<br>Slevu nelze uplatnit pokud datum 26. narozenin připadá na 1. den v měsíci (10010, 10011).<br>---<br>10437 Datum narození<br>10438 Rodné číslo<br>10440 Pořadí pro určení výše daňového zvýhodnění<br>10010 Měsíc<br>10011 Rok<br> |  |
| 114 | L | L114 | Věk dítěte již neumožňuje uplatnění daňového zvýhodnění. |  |
| 114 | M | M114 | nová |  |
| 115 | A | A115 | 216 |  |
| 115 | B | B115 | Kontrola součtů vyměřovacího základu zaměstnance |  |
| 115 | C | C115 | 10477<br>10478<br>10479<br>10480 |  |
| 115 | D | D115 | Průběh pojištění v daném měsíci |  |
| 115 | E | E115 | Formulář zaměstnance (form) |  |
| 115 | F | F115 | ePortál |  |
| 115 | G | G115 | nepropustná |  |
| 115 | H | H115 | DIS |  |
| 115 | I | I115 | nepropustná |  |
| 115 | J | J115 | F4 |  |
| 115 | K | K115 | Pokud je (10356) > 0, <br>a pokud se nejedná o datové scénáře:<br> 1) činnosti K až S: <br>  (10239) = "K" až "S" nebo, <br>  (10239) = "1" až "9" s příznakem (10502) = "Pracovní vztah specifické skupiny"<br> 2) pěstoun: (10239) = "M",<br>pak platí kontrola na součet: (10477) = (10478) + (10479) + (10480), <br>---<br>10477 Částka vyměřovacího základu zaměstnance, ze kterého je odváděno pojistné<br>10478 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ <br>10479 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ <br>10480 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ |  |
| 115 | L | L115 | Částka vyměřovacího základu zaměstnance, ze které je placeno pojistné, neodpovídá součtu dílčích částek vyměřovacího základu zaměstnance, které vstupují na straně zaměstnavatele do jednotlivých dílčích částek vyměřovacího základu zaměstnavatele. |  |
| 115 | M | M115 | nová |  |
| 116 | A | A116 | 217 |  |
| 116 | B | B116 | Chybný GUID podání. |  |
| 116 | C | C116 | 10001 |  |
| 116 | D | D116 | Meta atributy |  |
| 116 | E | E116 | Měsíční podání JMHZ (nezarazeno) |  |
| 116 | F | F116 | n/a |  |
| 116 | G | G116 | n/a |  |
| 116 | H | H116 | cJMHZ |  |
| 116 | I | I116 | nepropustná |  |
| 116 | J | J116 | T9 |  |
| 116 | K | K116 | Podání s referencí na řádné podání (GUID) a část/součást (GUID) - špatně uvedený GUID podání (lidská chyba - překlep, výběr jiného GUID) |  |
| 116 | L | L116 | Chybný GUID podání. |  |
| 116 | M | M116 | nová |  |
| 117 | A | A117 | 218 |  |
| 117 | B | B117 | Chybný GUID storno podání. |  |
| 117 | C | C117 | 10001 |  |
| 117 | D | D117 | Meta atributy |  |
| 117 | E | E117 | Měsíční podání JMHZ (nezarazeno) |  |
| 117 | F | F117 | n/a |  |
| 117 | G | G117 | n/a |  |
| 117 | H | H117 | cJMHZ |  |
| 117 | I | I117 | nepropustná |  |
| 117 | J | J117 | T9 |  |
| 117 | K | K117 | Špatně uvedený GUID storno podání - GUID neexistuje nebo GUID je navázáná na podání jiného subjektu (VS)<br>---<br>10001 GUID podání |  |
| 117 | L | L117 | Chybný GUID storno podání. |  |
| 117 | M | M117 | nová |  |
| 118 | A | A118 | 219 |  |
| 118 | B | B118 | Chybný GUID opravné součásti |  |
| 118 | C | C118 | 10012 |  |
| 118 | D | D118 | Meta atributy |  |
| 118 | E | E118 | Formulář zaměstnance (form) |  |
| 118 | F | F118 | n/a |  |
| 118 | G | G118 | n/a |  |
| 118 | H | H118 | cJMHZ |  |
| 118 | I | I118 | nepropustná |  |
| 118 | J | J118 | F5 |  |
| 118 | K | K118 | GUID opravné součásti je použit v jiném podání nebo neexistuje řádná součást se stejným GUID.<br>---<br>10012 GUID formuláře |  |
| 118 | L | L118 | Chybný GUID opravné součásti. |  |
| 118 | M | M118 | nová |  |
| 119 | A | A119 | 220 |  |
| 119 | B | B119 | Chybný GUID storno součásti |  |
| 119 | C | C119 | 10012 |  |
| 119 | D | D119 | Meta atributy |  |
| 119 | E | E119 | Formulář zaměstnance (form) |  |
| 119 | F | F119 | n/a |  |
| 119 | G | G119 | n/a |  |
| 119 | H | H119 | cJMHZ |  |
| 119 | I | I119 | nepropustná |  |
| 119 | J | J119 | F5 |  |
| 119 | K | K119 | GUID storno součásti je použit v jiném podání nebo neexistuje řádná součást se stejným GUID.<br>---<br>10012 GUID formuláře |  |
| 119 | L | L119 | Chybný GUID storno součásti. |  |
| 119 | M | M119 | nová |  |
| 120 | A | A120 | 225 |  |
| 120 | B | B120 | Chybějící 1. dílčí podání |  |
| 120 | C | C120 | 10002<br>10003 |  |
| 120 | D | D120 | Meta atributy |  |
| 120 | E | E120 | Měsíční podání JMHZ (nezarazeno) |  |
| 120 | F | F120 | n/a |  |
| 120 | G | G120 | n/a |  |
| 120 | H | H120 | cJMHZ |  |
| 120 | I | I120 | nepropustná |  |
| 120 | J | J120 | T9 |  |
| 120 | K | K120 | Na základě celkového počtu dílčích podání, 1. dílčí podání nebylo přijato do zpracování.<br>---<br>10002 Pořadí balíku dat<br>10003 Počet balíků dat<br><br> |  |
| 120 | L | L120 | Chybějící 1. dílčí podání. |  |
| 120 | M | M120 | nová |  |
| 121 | A | A121 | 226 |  |
| 121 | B | B121 | Neodpovídá počet individualizovaných součástí měsíčního hlášení registru zaměstnanců |  |
| 121 | D | D121 | Meta atributy |  |
| 121 | E | E121 | Měsíční podání JMHZ (nezarazeno) |  |
| 121 | F | F121 | n/a |  |
| 121 | G | G121 | n/a |  |
| 121 | H | H121 | cJMHZ |  |
| 121 | I | I121 | propustná |  |
| 121 | J | J121 | F5 |  |
| 121 | K | K121 | Pro každý VS a jeho měsíční podání bude zkontrolováno, že počet individulazovaných řádných součástí odpovídá počtu pojistných vztahů evidovaných v registru zaměstnavatelů pro rozhodné období. |  |
| 121 | L | L121 | Neodpovídá počet individualizovaných součástí měsíčního hlášení registru zaměstnanců. |  |
| 121 | M | M121 | nová |  |
| 121 | N | N121 | částečně přijato -  stav neúplné podání (pro postupné doplnění např. indiv. dat) |  |
| 122 | A | A122 | 227 |  |
| 122 | B | B122 | Neodpovídá počet individualizovaných součástí měsíčního hlášení celkovému počtu |  |
| 122 | C | C122 | 10488 |  |
| 122 | D | D122 | Meta atributy |  |
| 122 | E | E122 | Měsíční podání JMHZ (nezarazeno) |  |
| 122 | F | F122 | n/a |  |
| 122 | G | G122 | n/a |  |
| 122 | H | H122 | cJMHZ |  |
| 122 | I | I122 | propustná |  |
| 122 | J | J122 | F5 |  |
| 122 | K | K122 | Počet individualizovaných součástí měsíčního hlášení za všechny dílčí podání neodpovídá celkovému celkovému počtu (10488) individualizovaných součástí uvedeného v meta atributech podání.<br>V řádném nebo opravném prvním dílčím podání se do (10488) započítavají i formuláře souhrnu a pvpoj, tedy pro kontrolu sumy individualizovaných součátí se musí odečíst 2.<br>---<br>10488 Počet formulářů celkem |  |
| 122 | L | L122 | Neodpovídá počet individualizovaných součástí měsíčního hlášení celkovému počtu. |  |
| 122 | M | M122 | nová |  |
| 122 | N | N122 | částečně přijato -  stav neúplné podání (např. při ztrátě jednoho z balíků podání) |  |
| 123 | A | A123 | 228 |  |
| 123 | B | B123 | Neodpovídá počet dílčích podání celkovému počtu balíků |  |
| 123 | C | C123 | 10003 |  |
| 123 | D | D123 | Meta atributy |  |
| 123 | E | E123 | Měsíční podání JMHZ (nezarazeno) |  |
| 123 | F | F123 | n/a |  |
| 123 | G | G123 | n/a |  |
| 123 | H | H123 | cJMHZ |  |
| 123 | I | I123 | nepropustná |  |
| 123 | J | J123 | F5 |  |
| 123 | K | K123 | Počet dílčích podání neoodpovídá celkovému počtu balíků uvedeném  v meta atributech podání.<br>---<br>10003 Počet balíků dat |  |
| 123 | L | L123 | Neodpovídá počet dílčích podání celkovému počtu balíků. |  |
| 123 | M | M123 | nová |  |
| 124 | A | A124 | 229 |  |
| 124 | B | B124 | Kontrola kolize pořadí dítěte v měsíci (měsíční zúčtovaní) |  |
| 124 | C | C124 | 10440 |  |
| 124 | D | D124 | Souhrnná data zaměstnance |  |
| 124 | E | E124 | Formulář zaměstnance (form) |  |
| 124 | F | F124 | ePortál |  |
| 124 | G | G124 | nepropustná |  |
| 124 | H | H124 | DIS |  |
| 124 | I | I124 | nepropustná |  |
| 124 | J | J124 | F4 |  |
| 124 | K | K124 | V (10440) jsou kolize pořadí 1 a 2 jednotlivých dětí.<br>---<br>10440 Pořadí pro určení výše daňového zvýhodnění<br> |  |
| 124 | L | L124 | Uvedému pořadí dítěte odpovídá stejné pořadí u jiného dítěte. |  |
| 124 | M | M124 | nová |  |
| 125 | A | A125 | 230 |  |
| 125 | B | B125 | Kontrola kolize pořadí dítěte v měsíci (roční zúčtovaní) |  |
| 125 | C | C125 | 10451 |  |
| 125 | D | D125 | Souhrnná data zaměstnance |  |
| 125 | E | E125 | Formulář zaměstnance (form) |  |
| 125 | F | F125 | ePortál |  |
| 125 | G | G125 | nepropustná |  |
| 125 | H | H125 | cJMHZ |  |
| 125 | I | I125 | propustná |  |
| 125 | J | J125 | F5 |  |
| 125 | K | K125 | V (10451) jsou kolize pořadí 1 a 2 jednotlivých dětí ve stejných měsících.<br>---<br>10451 Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících |  |
| 125 | L | L125 | Pořadí dítěte v měsíci koliduje s totožným nastavením pro jiné dítě. |  |
| 125 | M | M125 | nová |  |
| 126 | A | A126 | 232 |  |
| 126 | B | B126 | Struktura řádného měsíčního hlášení |  |
| 126 | E | E126 | Měsíční podání JMHZ (global) |  |
| 126 | F | F126 | n/a |  |
| 126 | G | G126 | n/a |  |
| 126 | H | H126 | DIS |  |
| 126 | I | I126 | nepropustná |  |
| 126 | J | J126 | T5 |  |
| 126 | K | K126 | První dílčí podání řádného hlášení musí obsahovat všechny povinné vrstvy - souhrn, PVPOJ a minimálně jeden individualizovaný formulář. Případná další dílčí podání musí obsahovat jen individualizované formuláře. |  |
| 126 | L | L126 | Struktura řádného měsíčního hlášení neodpovídá specifikaci. |  |
| 126 | M | M126 | nová |  |
| 127 | A | A127 | 233 |  |
| 127 | B | B127 | Struktura opravného hlášení |  |
| 127 | E | E127 | Měsíční podání JMHZ (global) |  |
| 127 | F | F127 | n/a |  |
| 127 | G | G127 | n/a |  |
| 127 | H | H127 | DIS |  |
| 127 | I | I127 | nepropustná |  |
| 127 | J | J127 | T5 |  |
| 127 | K | K127 | První dílčí podání opravného hlášení musí obsahovat alespoň jednu z vrstev - souhrn, PVPOJ nebo minimálně jeden individualizovaný formulář. Případná další dílčí podání musí obsahovat jen individualizované formuláře. |  |
| 127 | L | L127 | Struktura opravného měsíčního hlášení neodpovídá specifikaci. |  |
| 127 | M | M127 | nová |  |
| 128 | A | A128 | 235 |  |
| 128 | B | B128 | Neodpovídá skutečný počet formulářů |  |
| 128 | C | C128 | 10015 |  |
| 128 | D | D128 | Meta atributy |  |
| 128 | E | E128 | Měsíční podání JMHZ (global) |  |
| 128 | F | F128 | n/a |  |
| 128 | G | G128 | n/a |  |
| 128 | H | H128 | DIS |  |
| 128 | I | I128 | nepropustná |  |
| 128 | J | J128 | T5 |  |
| 128 | K | K128 | Neodpovídá uvedený počet formulářů v balíku (10015) skutečnému počtu formulářů:<br>1) pro první balík (10002) = 1, pro řádné podání (10007) = "R", (10015) - 1 formulář pojistná část - 1 formulář souhrnná část = počet součástí indiv. části<br>2) pro první balík (10002) = 1, opravné podání (10007) = "O", (10015) - (1 za formulář pojistná část pokud existuje) - (1 za formulář souhrnná část pokud existuje) = počet součástí indiv. části<br>3) pro následující balíky (10002) nerovná se 1, pro řádné i opravné podání (10007) = "R" nebo "O" je: (10015)= počet součástí indiv. části<br>---<br>10015 Počet formulářů v balíku dat<br>10002 Pořadí balíku dat<br>10007 Typ podání  |  |
| 128 | L | L128 | Počet individualizovaných formulářů neodpovídá počtu uvedeného v hlavičce. |  |
| 128 | M | M128 | nová |  |
| 129 | A | A129 | 236 |  |
| 129 | B | B129 | Kontrola formulářů v řádném měsíčním hlášení |  |
| 129 | C | C129 | 10012 |  |
| 129 | D | D129 | Meta atributy |  |
| 129 | E | E129 | Formulář zaměstnance (form) |  |
| 129 | F | F129 | n/a |  |
| 129 | G | G129 | n/a |  |
| 129 | H | H129 | DIS |  |
| 129 | I | I129 | nepropustná |  |
| 129 | J | J129 | F1 |  |
| 129 | K | K129 | Řádné měsíční hlášení nesmí obsahovat formuláře typu opravna nebo storno.<br>---<br>10012 GUID formuláře |  |
| 129 | L | L129 | Řádné měsíční hlášení může obsahovat jen formuláře typu řádný. |  |
| 129 | M | M129 | nová |  |
| 130 | A | A130 | 237 |  |
| 130 | B | B130 | Kontrola formulářů v opravném měsíčním hlášení pro indiv. části |  |
| 130 | C | C130 | 10016<br>10007 |  |
| 130 | D | D130 | Meta atributy |  |
| 130 | E | E130 | Formulář zaměstnance (form) |  |
| 130 | F | F130 | n/a |  |
| 130 | G | G130 | n/a |  |
| 130 | H | H130 | DIS |  |
| 130 | I | I130 | nepropustná |  |
| 130 | J | J130 | F1 |  |
| 130 | K | K130 | Individualizované formuláře <br>- typu storno (10016) = "S" v <br>- opravném měsíčním hlášení  (10007) = "O"<br>musí obsahovat pouze hlavičku, nikoli datovou část situací.<br>---<br>10016 Typ formuláře<br>10007 Typ podání |  |
| 130 | L | L130 | Individualizované formuláře typu storno musí obsahovat pouze hlavičku. |  |
| 130 | M | M130 | nová |  |
| 131 | A | A131 | 238 |  |
| 131 | B | B131 | Kontrola konzistence klíčů GUID, ikmpsv, idppv v části individualizované součásti při změně dat |  |
| 131 | C | C131 | 10012<br>10016<br>10051<br>10228 |  |
| 131 | D | D131 | Meta atributy |  |
| 131 | E | E131 | Formulář zaměstnance (form) |  |
| 131 | F | F131 | n/a |  |
| 131 | G | G131 | n/a |  |
| 131 | H | H131 | cJMHZ |  |
| 131 | I | I131 | nepropustná |  |
| 131 | J | J131 | T9 |  |
| 131 | K | K131 | Pro opravné podání (10016) = "O" součásti individualizované části musí odpovídat dvojice klíčů (10051) a (10228) předchozím hodnotám ze zpracovaného řádného podání (10016) = "R", tj. pro konkrétní GUID formuláře musí být použita vždy stejná kombinace IK MPSV a ID pracovněprávního vztahu.<br>---<br>10012 GUID formuláře<br>10016 Typ formuláře<br>10051 IK MPSV<br>10228 ID pracovněprávního vztahu<br><br> |  |
| 131 | L | L131 | V rámci opravného podání součásti individualizované části nebyla nalezena odpovídající dvojice klíčů IK MPSV a ID pracovněprávního vztahu. |  |
| 131 | M | M131 | nová |  |
| 132 | A | A132 | 240 |  |
| 132 | B | B132 | Kontrola metaatributů pro řádné a opravného podání |  |
| 132 | C | C132 | 10002<br>10003<br>10015<br>10488<br>10007 |  |
| 132 | D | D132 | Meta atributy |  |
| 132 | E | E132 | Měsíční podání JMHZ (global) |  |
| 132 | F | F132 | n/a |  |
| 132 | G | G132 | n/a |  |
| 132 | H | H132 | DIS |  |
| 132 | I | I132 | nepropustná |  |
| 132 | J | J132 | T5 |  |
| 132 | K | K132 | Pokud je (10007) = "R" nebo "O", pak (10002, 10003, 10015, 10488) musí nabývat hodnot. <br>---<br>10002 Pořadí balíku dat<br>10003 Počet balíků dat<br>10015 Počet formulářů v balíku dat<br>10488 Počet formulářů celkem<br>10007 Typ podání |  |
| 132 | L | L132 | Pro řádné/opravné podání je vyplnění metadat: Pořadí balíku dat, Počet balíků dat, Počet formulářů v balíku dat, Počet formulářů celkem povinné. |  |
| 132 | M | M132 | nová |  |
| 133 | A | A133 | 241 |  |
| 133 | B | B133 | Kontrola konzistence metatributů GUID pro celé podání |  |
| 133 | C | C133 | 10221<br>10010<br>10011<br>10001<br>10007 |  |
| 133 | D | D133 | Zaměstnavatel  / Škola / Vzdělávací zařízení |  |
| 133 | E | E133 | Měsíční podání JMHZ (nezarazeno) |  |
| 133 | F | F133 | n/a |  |
| 133 | G | G133 | n/a |  |
| 133 | H | H133 | cJMHZ |  |
| 133 | I | I133 | nepropustná |  |
| 133 | J | J133 | T9 |  |
| 133 | K | K133 | Když je (10007) =  "S",<br>pak (10221), (10010), (10011) musí odpovídat předchozímu podání, které je referencováno přes GUID (10001).<br>---<br>10001 GUID podání<br>10007 Typ podání<br>10221 Variabilní symbol<br>10010 Měsíc<br>10011 Rok<br><br><br><br> |  |
| 133 | L | L133 | V rámci storna celého podání nebyly nalezeny odpovídající atributy: Variabilní symbol, Měsíc, Rok. |  |
| 133 | M | M133 | nová |  |
| 134 | A | A134 | 242 |  |
| 134 | B | B134 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů s prohlášením poplatníka daně |  |
| 134 | C | C134 | 10307<br>10309<br>10416<br>10310<br>10419<br>10068 |  |
| 134 | D | D134 | Souhrnná data zaměstnance |  |
| 134 | E | E134 | Formulář zaměstnance (form) |  |
| 134 | F | F134 | ePortál |  |
| 134 | G | G134 | nepropustná |  |
| 134 | H | H134 | cJMHZ |  |
| 134 | I | I134 | nepropustná |  |
| 134 | J | J134 | F5 |  |
| 134 | K | K134 | Když je (10419) = "ANO" a (10068) = "CZ",<br>pak následující atributy nesmí nabývat hodnot: (10307), (10416), (10309) a (10310) .<br>---<br>10307 Základ pro výpočet daně podle zvláštní sazby daně<br>10416 Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR<br>10309 Skutečně sražená daň podle zvláštní sazby daně / měsíc<br>10310 Sražená záloha na daň z příjmu nerezidenta člena orgánu právnické osoby<br>10419 Prohlášení poplatníka daně z příjmů ze závislé činnosti<br>10068 Kód státu rezidenství<br><br> |  |
| 134 | L | L134 | Pokud je učiněno prohlášení poplatníka k dani, pak nelze uplatnit srážkovou daň podle zvláštní sazby daně. |  |
| 134 | M | M134 | nová |  |
| 135 | A | A135 | 243 |  |
| 135 | B | B135 | Kontrola adekvátních atributů pro výpočet zálohy na daň nerezidentů  s prohlášením poplatníka daně |  |
| 135 | C | C135 | 10300<br>10301<br>10302<br>10303<br>10453<br>10431<br>10432<br>10433<br>10434<br>10435<br>10436<br>10437<br>10438<br>10439<br>10440<br>10304<br>10306<br>10419<br>10307<br>10309<br>10310<br>10068 |  |
| 135 | D | D135 | Souhrnná data zaměstnance |  |
| 135 | E | E135 | Formulář zaměstnance (form) |  |
| 135 | F | F135 | ePortál |  |
| 135 | G | G135 | nepropustná |  |
| 135 | H | H135 | cJMHZ |  |
| 135 | I | I135 | nepropustná |  |
| 135 | J | J135 | F5 |  |
| 135 | K | K135 | Když je (10419) = "ANO" a (10068) není "CZ",<br>pak následující atributy nesmí nabývat hodnot: (10300), (10301), (10302), (10303), (10453), (10431), (10432), (10433), (10434), (10435), (10436), (10437), (10438), (10439), (10440), (10304), (10306), (10307), (10309), (10310).<br>---<br>10300 Základní sleva na invaliditu (I. nebo II. Stupeň)<br>10301 Rozšířená sleva na invaliditu (III. Stupeň)<br>10302 Sleva na držitele průkazu ZTP/P<br>10303 Měsíční daňové zvýhodnění na děti<br>10453 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba<br>10431 Jméno<br>10432 Příjmení<br>10433 Datum narození<br>10434 Rodné číslo<br>10435 Jméno<br>10436 Příjmení<br>10437 Datum narození<br>10438 Rodné číslo<br>10439 Průkaz ZTP/P<br>10440 Pořadí pro určení výše daňového zvýhodnění<br>10304 Měsíční sleva na děti<br>10305 Skutečně sražená záloha na daň po uplatnění slev<br>10306 Výše vyplaceného měsíčního daňového bonusu<br>10419 Prohlášení poplatníka daně z příjmů ze závislé činnosti<br>10307 Základ pro výpočet daně podle zvláštní sazby daně<br>10309 Skutečně sražená daň podle zvláštní sazby daně / měsíc<br>10310 Sražená záloha na daň z příjmu nerezidenta člena orgánu právnické osoby<br>10068 Kód státu rezidenství |  |
| 135 | L | L135 | U daňového nerezidenta, který podepsal prohlášení popatníka, lze uplatnit pouze základní slevu na poplatníka a nelze uplatnit zvláštní sazbu daně. |  |
| 135 | M | M135 | nová |  |
| 136 | A | A136 | 244 |  |
| 136 | B | B136 | Kontrola neuplatnění daňových slev a zvýhodnění rezidentů bez prohlášení poplatníka |  |
| 136 | C | C136 | 10299<br>10300<br>10301<br>10302<br>10303<br>10453<br>10431<br>10432<br>10433<br>10434<br>10435<br>10436<br>10437<br>10438<br>10439<br>10440<br>10304<br>10306<br>10419 |  |
| 136 | D | D136 | Souhrnná data zaměstnance |  |
| 136 | E | E136 | Formulář zaměstnance (form) |  |
| 136 | F | F136 | ePortál |  |
| 136 | G | G136 | nepropustná |  |
| 136 | H | H136 | cJMHZ |  |
| 136 | I | I136 | nepropustná |  |
| 136 | J | J136 | F5 |  |
| 136 | K | K136 | ="Pokud (10419) = ""NE"","&CHAR(10)&<br>"pak následující atributy nesmí nabývat hodnot:"&CHAR(10)&<br>"(10299), (10300), (10301), (10302), (10303), (10453), (10431), (10432), (10433), (10434), (10435), (10436), (10437), (10438), (10439), (10440), (10304), (10306)." & CHAR(10) &<br>"---" & CHAR(10)&<br>"10299 Základní sleva na poplatníka" & CHAR(10)&<br>"10300 Základní sleva na invaliditu (I. nebo II. Stupeň)" & CHAR(10)&<br>"10301 Rozšířená sleva na invaliditu (III. Stupeň)" & CHAR(10)&<br>"10302 Sleva na držitele průkazu ZTP/P" & CHAR(10)&<br>"10303 Měsíční daňové zvýhodnění na děti" & CHAR(10)&<br>"10453 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba" & CHAR(10)&<br>"10431 Jméno" & CHAR(10)&<br>"10432 Příjmení" & CHAR(10)&<br>"10433 Datum narození" & CHAR(10)&<br>"10434 Rodné číslo" & CHAR(10)&<br>"10435 Jméno" & CHAR(10)&<br>"10436 Příjmení" & CHAR(10)&<br>"10437 Datum narození" & CHAR(10)&<br>"10438 Rodné číslo" & CHAR(10)&<br>"10439 Průkaz ZTP/P" & CHAR(10)&<br>"10440 Pořadí pro určení výše daňového zvýhodnění" & CHAR(10)&<br>"10304 Měsíční sleva na děti" & CHAR(10)&<br>"10306 Výše vyplaceného měsíčního daňového bonusu"  & CHAR(10)&<br>"10419 Prohlášení poplatníka daně z příjmů ze závislé činnosti" |  |
| 136 | L | L136 | Nebylo-li učiněno prohlášení poplatníka, nelze vyplnit atribut(y) související s daňovými slevami a daňovým zvýhodněním. |  |
| 136 | M | M136 | nová |  |
| 137 | A | A137 | 245 |  |
| 137 | B | B137 | Kontrola adekvátních atributů pro výpočet srážkové daně bez prohlášení poplatníka - srážková daň |  |
| 137 | C | C137 | 10297<br>10298<br>10299<br>10300<br>10301<br>10302<br>10303<br>10306<br>10453<br>10431<br>10432<br>10433<br>10434<br>10435<br>10436<br>10437<br>10438<br>10439<br>10440<br>10304<br>10305<br>10419<br>10416<br>10286<br>10239 |  |
| 137 | D | D137 | Souhrnná data zaměstnance |  |
| 137 | E | E137 | Formulář zaměstnance (form) |  |
| 137 | F | F137 | ePortál |  |
| 137 | G | G137 | nepropustná |  |
| 137 | H | H137 | cJMHZ |  |
| 137 | I | I137 | nepropustná |  |
| 137 | J | J137 | F5 |  |
| 137 | K | K137 | ="Pokud má zaměstnavatel pouze jednu mzdovou účtarnu, tedy je počet variabilních symbolů (10221) = 1, pak platí následující kontrola:" & CHAR(10) &<br>"Když (10419) = ""NE"" a" &CHAR(10)&<br>"1a) ∑ všech (10535), kde součet všech DPP za zaměstnance u zaměstnavatele (které jsou definovány (10239) = ""T-ZC"") < "&('Parametrické konstanty'!C14)& " a"&CHAR(10)&<br>"1b) ∑ všech (10535), které nejsou DPP (tj. (10239) se nerovná ""T-ZC"") <  "&('Parametrické konstanty'!C13)&CHAR(10)&<br>"pak následující atributy nesmí nabývat hodnot:"&CHAR(10)&<br>"(10297), (10298), (10299), (10300), (10301), (10302), (10303), (10453), (10431), (10432), (10433), (10434), (10435), (10436), (10437), (10438), (10439), (10440), (10304), (10305), (10306)." & CHAR(10) &<br>"---" & CHAR(10)&<br>"10297 Základ pro výpočet zálohy na daň" & CHAR(10)&<br>"10298 Vypočtená záloha na daň" & CHAR(10)&<br>"10299 Základní sleva na poplatníka" & CHAR(10)&<br>"10300 Základní sleva na invaliditu (I. nebo II. Stupeň)" & CHAR(10)&<br>"10301 Rozšířená sleva na invaliditu (III. Stupeň)" & CHAR(10)&<br>"10302 Sleva na držitele průkazu ZTP/P" & CHAR(10)&<br>"10303 Měsíční daňové zvýhodnění na děti" & CHAR(10)&<br>"10306 Výše vyplaceného měsíčního daňového bonusu" & CHAR(10)&<br>"10453 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba" & CHAR(10)&<br>"10431 Jméno" & CHAR(10)&<br>"10432 Příjmení" & CHAR(10)&<br>"10433 Datum narození" & CHAR(10)&<br>"10434 Rodné číslo" & CHAR(10)&<br>"10435 Jméno" & CHAR(10)&<br>"10436 Příjmení" & CHAR(10)&<br>"10437 Datum narození" & CHAR(10)&<br>"10438 Rodné číslo" & CHAR(10)&<br>"10439 Průkaz ZTP/P" & CHAR(10)&<br>"10440 Pořadí pro určení výše daňového zvýhodnění" & CHAR(10)&<br>"10304 Měsíční sleva na děti" & CHAR(10)&<br>"10305 Skutečně sražená záloha na daň po uplatnění slev" & CHAR(10)&<br>"10419 Prohlášení poplatníka daně z příjmů ze závislé činnosti" & CHAR(10) &<br>"10416 Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR" & CHAR(10) &<br>"10535 Základ pro výpočet daně" & CHAR(10) &<br>"10221 Variabilní symbol" & CHAR(10) &<br>"10239 Druh činnosti" |  |
| 137 | L | L137 | Nebylo-li učiněno prohlášení poplatníka a příjem podléhá srážkové dani, nelze vyplnit atribut(y) související se zálohovou daní. |  |
| 137 | M | M137 | nová |  |
| 138 | A | A138 | 248 |  |
| 138 | B | B138 | Kontrola vyplnění dat souhrnné vrstvy za zaměstnance jen pro primární pracovněprávní vztah zaměstnance |  |
| 138 | C | C138 | 10286<br>10416<br>10289<br>10417<br>10292<br>10293<br>10294<br>10295<br>10296<br>10418<br>10419<br>10297<br>10298<br>10299<br>10300<br>10301<br>10302<br>10303<br>10453<br>10431<br>10432<br>10433<br>10434<br>10435<br>10436<br>10437<br>10438<br>10439<br>10440<br>10304<br>10305<br>10306<br>10307<br>10308<br>10309<br>10310<br>10313<br>10317<br>10316<br>10318<br>10311<br>10312<br>10319<br>10320<br>10321<br>10322<br>10323<br>10420<br>10421<br>10422<br>10423<br>10424<br>10425<br>10426<br>10430<br>10539<br>10540<br>10541<br>10542<br>10454<br>10455<br>10441<br>10442<br>10443<br>10444<br>10445<br>10446<br>10447<br>10448<br>10449<br>10450<br>10451<br>10344<br>10116<br>10348<br>10349<br>10347<br>10350<br>10351<br>10352<br>10353<br>10482<br>10371<br>10495 |  |
| 138 | D | D138 | Souhrnná data zaměstnance |  |
| 138 | E | E138 | Formulář zaměstnance (form) |  |
| 138 | F | F138 | ePortál |  |
| 138 | G | G138 | nepropustná |  |
| 138 | H | H138 | DIS |  |
| 138 | I | I138 | nepropustná |  |
| 138 | J | J138 | F4 |  |
| 138 | K | K138 | Pokud (10495) = "NE", <br>pak atributy z oblasti atributů: "Souhrnná data zaměstnance" nesmí být vyplněny<br>---<br>10286 Zúčtovaný příjem - celkem<br>10416 Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR<br>10289 Osvobozené příjmy ze zúčtovaných příjmů - celkem<br>10417 Příspěvek zaměstnavatele na produkty spoření na stáří a pojištění dlouhodobé péče z osvobozených příjmů - celkem<br>10292 Příspěvek na penzijní připojištění se státním příspěvkem<br>10293 Příspěvek na doplňkové penzijní spoření<br>10294 Příspěvek na penzijní pojištění<br>10295 Příspěvek na soukromé životní pojištění<br>10296 Příspěvek na dlouhodobý investiční produkt<br>10418 Příspěvek na pojištění dlouhodobé péče<br>10419 Prohlášení poplatníka daně z příjmů ze závislé činnosti<br>10297 Základ pro výpočet zálohy na daň<br>10298 Vypočtená záloha na daň<br>10299 Základní sleva na poplatníka<br>10300 Základní sleva na invaliditu (I. nebo II. Stupeň)<br>10301 Rozšířená sleva na invaliditu (III. Stupeň)<br>10302 Sleva na držitele průkazu ZTP/P<br>10303 Měsíční daňové zvýhodnění na děti<br>10453 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba<br>10431 Jméno<br>10432 Příjmení<br>10433 Datum narození<br>10434 Rodné číslo<br>10435 Jméno<br>10436 Příjmení<br>10437 Datum narození<br>10438 Rodné číslo<br>10439 Průkaz ZTP/P<br>10440 Pořadí pro určení výše daňového zvýhodnění<br>10304 Měsíční sleva na děti<br>10305 Skutečně sražená záloha na daň po uplatnění slev<br>10306 Výše vyplaceného měsíčního daňového bonusu<br>10307 Základ pro výpočet daně podle zvláštní sazby daně<br>10308 Odměna člena (nerezidenta) orgánu právnické osoby<br>10309 Skutečně sražená daň podle zvláštní sazby daně / měsíc<br>10310 Sražená záloha na daň z příjmu nerezidenta člena orgánu právnické osoby<br>10313 Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. následujícího roku - příjmy zdaněné zálohou na daň celkem<br>10317 Skutečně sražená záloha na daň z příjmů vyplacených nebo obdržených do 31.1. následujícího roku<br>10316 Doplatky příjmů zúčtovaných v minulých zdaňovacích obdobích zdanitelných v ČR zdaněné zálohou na daň vyplacené nebo obdržené do 31.1. následujícího roku<br>10318 Skutečně sražená záloha na daň z doplatků příjmů zdanitelných v ČR<br>10311 Příjmy podléhající srážkové dani podle zvláštní sazby daně vyplacené nebo obdržené do 31.1. následujícího roku<br>10312 Skutečně sražená daň vybíraná srážkou podle zvláštní sazby daně<br>10319 Zaměstnanec požádal o provedení ročního zúčtování<br>10320 Roční zúčtování záloh bylo provedeno<br>10321 Přeplatek nebo nedoplatek z ročního zúčtování<br>10322 Přeplatek nebo nedoplatek z ročního zúčtování - z toho přeplatek na dani nebo nedoplatek daně<br>10323 Přeplatek nebo nedoplatek z ročního zúčtování - z toho doplatek na daňovém bonusu nebo přeplacená částka daňového bonusu zaměstnanci<br>10420 Uplatněna sleva na manželku / manžela<br>10421 Jméno manželky / manžela<br>10422 Příjmení manželky / manžela<br>10423 Rodné číslo manželky / manžela<br>10424 Datum narození manželky / manžela<br>10425 Držitelka / držitel karty ZTP/P<br>10426 Počet měsíců uplatnění slevy<br>10430 Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P<br>10539 Jméno dítěte<br>10540 Příjmení dítěte<br>10541 Datum narození dítěte<br>10542 Rodné číslo dítěte<br>10454 Uplatněno daňové zvýhodnění na děti <br>10455 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba<br>10441 Jméno<br>10442 Příjmení<br>10443 Datum narození<br>10444 Rodné číslo<br>10445 Měsíce vyživování<br>10446 Jméno<br>10447 Příjmení<br>10448 Datum narození<br>10449 Rodné číslo<br>10450 Průkaz ZTP/P v jednotlivých měsících<br>10451 Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících<br>10344 Čistý příjem<br>10116 Srážky na základě nařízeného soudního nebo správního výkonu rozhodnutí, konkursu nebo dohody o srážkách z příjmu<br>10348 Mzda/plat nebo jeho část vyplacena v hotovosti <br>10349 Provedeny srážky ze mzdy nebo platu určené k uspokojení plnění zaměstnavatele<br>10347 Datum úhrady mzdy včetně odvodů na soc. a zdravotní pojištění<br>10347 Srážky k uspokojení plnění zaměstnavatele podle občanského zákoníku<br>10351 Srážky k uhrazení škody, za kterou odpovídá zaměstnanec<br>10352 Srážky na závodní stravování pode §236 zákoníku práce,<br>10353 Srážky k uspokojení závazků zaměstnance podle § 146 písm. b) zákoníku práce<br>10482 Zdravotní pojištění<br>10371 Zdravotní pojištění<br>10495 Primární pracovněprávní vztah zaměstnance |  |
| 138 | L | L138 | Atributy souhrnné vrstvy za zaměstnance mohou být vyplněny pouze u primárního pracovněprávního vztahu. |  |
| 138 | M | M138 | nová |  |
| 139 | A | A139 | 251 |  |
| 139 | B | B139 | Kontrola vícečetnosti stejných IDPPV v součástí individualizovaných částí. |  |
| 139 | C | C139 | 10228 |  |
| 139 | D | D139 | Vykonávaná pozice zaměstnance |  |
| 139 | E | E139 | Formulář zaměstnance (form) |  |
| 139 | F | F139 | ePortál |  |
| 139 | G | G139 | nepropustná |  |
| 139 | H | H139 | cJMHZ |  |
| 139 | I | I139 | nepropustná |  |
| 139 | J | J139 | F5 |  |
| 139 | K | K139 | IDPPV (10228) v součástech individualizované části (ve formulářích osob) musí být uvedeno právě jednou v rámci podání.<br>---<br>10228 ID pracovněprávního vztahu<br><br> |  |
| 139 | L | L139 | ID pracovněprávního vztahu musí být v podání unikátní. |  |
| 139 | M | M139 | nová |  |
| 139 | N | N139 | případné modifikace se musí realizovat v následujícím (opravném) podání |  |
| 140 | A | A140 | 253 |  |
| 140 | B | B140 | Kontrola unikátnosti ID PPV v rámci dílčího podání |  |
| 140 | C | C140 | 10228 |  |
| 140 | D | D140 | Vykonávaná pozice zaměstnance |  |
| 140 | E | E140 | Formulář zaměstnance (form) |  |
| 140 | F | F140 | ePortál |  |
| 140 | G | G140 | nepropustná |  |
| 140 | H | H140 | DIS |  |
| 140 | I | I140 | nepropustná |  |
| 140 | J | J140 | F4 |  |
| 140 | K | K140 | IDPPV (10228) v dílčím podání v součástech individualizované části (ve formulářích osob) musí být uvedeno právě jednou.<br>Pokud se v hlášení vyskytují formuláře typu Odložený příjem (formOdlozenyPrijem.xsd), pak budou pro účely této kontroly ignorovány.<br>---<br>10228 ID pracovněprávního vztahu |  |
| 140 | L | L140 | V rámci dílčího podání musí být ID pracovněprávního vztahu unikátní. |  |
| 140 | M | M140 | nová |  |
| 140 | N | N140 | případné modifikace se musí realizovat v následujícím (opravném) podání |  |
| 141 | A | A141 | 255 |  |
| 141 | B | B141 | Kontrola existence min. jednoho primárního PPV za OIČ v rámci podání.  |  |
| 141 | C | C141 | 10495 |  |
| 141 | D | D141 | Meta atributy |  |
| 141 | E | E141 | Formulář zaměstnance (form) |  |
| 141 | F | F141 | ePortál |  |
| 141 | G | G141 | propustná |  |
| 141 | H | H141 | n/a |  |
| 141 | I | I141 | n/a |  |
| 141 | K | K141 | Existuje právě jedno primární PPV za OIČ v rámci podání.<br>---<br>10495  Primární pracovněprávní vztah zaměstnance |  |
| 141 | L | L141 | Neexistuje žádné primární PPV za OIČ v rámci podání. |  |
| 141 | M | M141 | nová |  |
| 141 | N | N141 | Jedná se pouze o upozornění v rámci ePortálu pro jedno podání (modální dialog s potrvzením pokračování bez primárního PPV,  za celé podání = všechny balíky za jeden VS).<br><br>pozn.: kontrolu napříč více VS jednoho IČO nelze na ePortálu provést, primární vztah přitom může být označen u jiného VS |  |
| 142 | A | A142 | 258 |  |
| 142 | B | B142 | Kontrola srážek ze mzdy nebo platu |  |
| 142 | C | C142 | 10349<br>10350<br>10351<br>10352<br>10353 |  |
| 142 | D | D142 | Souhrnná data zaměstnance |  |
| 142 | E | E142 | Formulář zaměstnance (form) |  |
| 142 | F | F142 | ePortál |  |
| 142 | G | G142 | nepropustná |  |
| 142 | H | H142 | DIS |  |
| 142 | I | I142 | nepropustná |  |
| 142 | J | J142 | F4 |  |
| 142 | K | K142 | Pokud jsou Provedeny srážky ze mzdy nebo platu určené k uspokojení plnění zaměstnavatele (10349) = "ANO", <br>pak musí být uvedena alespoň jedna hodnota z: 10350, 10351, 10352, 10353<br>---<br>10349 Provedeny srážky ze mzdy nebo platu určené k uspokojení plnění zaměstnavatele<br>10350 Srážky k uspokojení plnění zaměstnavatele podle občanského zákoníku<br>10351 Srážky k uhrazení škody, za kterou odpovídá zaměstnanec<br>10352 Srážky na závodní stravování pode §236 zákoníku práce,<br>10353 Srážky k uspokojení závazků zaměstnance podle § 146 písm. b) zákoníku práce |  |
| 142 | L | L142 | Pokud jsou evidovány srážky ze mzdy nebo platu, pak musí být uvedena hodnota alespoň jednoho z atributů: Srážky k uspokojení plnění zaměstnavatele podle občanského zákoníku, Srážky k uhrazení škody, za kterou odpovídá zaměstnanec, Srážky na závodní stravování pode § 236 zákoníku práce, Srážky k uspokojení závazků zaměstnance podle § 146 písm. b) zákoníku práce. |  |
| 142 | M | M142 | nová |  |
| 143 | A | A143 | 259 |  |
| 143 | B | B143 | Kontrola směn v hlubinném hornictví. |  |
| 143 | C | C143 | 10270<br>10272<br>10271 |  |
| 143 | D | D143 | Průběh zaměstnání v daném měsíci |  |
| 143 | E | E143 | Formulář zaměstnance (form) |  |
| 143 | F | F143 | ePortál |  |
| 143 | G | G143 | nepropustná |  |
| 143 | H | H143 | DIS |  |
| 143 | I | I143 | nepropustná |  |
| 143 | J | J143 | F4 |  |
| 143 | K | K143 | Pokud je uveden Datum dosažení expozice NPE (10272), <br>pak musí být uvedena alespoň jedna z hodnot: 10270 nebo 10271<br>---<br>10270 Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - uran<br>10271 Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - ostatní<br>10272 Datum dosažení expozice NPE |  |
| 143 | L | L143 | Pokud je uveden Datum dosažení expozice NPE, pak musí být uvedena alespoň jeden atribut: Počet odpracovaných směn v zaměstnání v hlubinném hornictví definovaném v § 37b ZDP - uran nebo Počet odpracovaných směn v zaměstnání v hlubinném hornictví definovaném v § 37b ZDP - ostatní. |  |
| 143 | M | M143 | nová |  |
| 144 | A | A144 | 260 |  |
| 144 | B | B144 | Kontrola existence max. jednoho primárního PPV za OIČ v rámci podání.  |  |
| 144 | C | C144 | 10495 |  |
| 144 | D | D144 | Meta atributy |  |
| 144 | E | E144 | Formulář zaměstnance (form) |  |
| 144 | F | F144 | ePortál |  |
| 144 | G | G144 | nepropustná |  |
| 144 | K | K144 | Musí existovat právě jedno primární PPV za OIČ v rámci podání.<br>---<br>10495  Primární pracovněprávní vztah zaměstnance |  |
| 144 | L | L144 | Existuje více než jedno primární PPV za OIČ v rámci podání.  |  |
| 144 | M | M144 | nová |  |
| 144 | N | N144 | Výsledkem kontroly je informatinví hláška, že bylo vybráno více primárních pracovně právních vztahů u jednoho OIČ napříč VS a musí dojí k opravě učení primárního PPV. |  |
| 145 | A | A145 | 261 |  |
| 145 | B | B145 | Kontrola odpovídajícího  ID PPV a VS v systémech ČSSZ |  |
| 145 | C | C145 | 10228<br>10221 |  |
| 145 | D | D145 | Vykonávaná pozice zaměstnance |  |
| 145 | E | E145 | Formulář zaměstnance (form) |  |
| 145 | F | F145 | n/a |  |
| 145 | G | G145 | n/a |  |
| 145 | H | H145 | DIS |  |
| 145 | I | I145 | nepropustná |  |
| 145 | J | J145 | F2 |  |
| 145 | K | K145 | Musí odpovídat ID PPV (10228)  a VS (10221), který je u PV evidován v systémech ČSSZ.<br>---<br>10221 Variabilní symbol<br>10228 ID pracovněprávního vztahu (Identifikátor zaměstnání) |  |
| 145 | L | L145 | Pojistný vztah s uvedeným ID PPV XXX a VS nebyl nalezen v systémech ČSSZ. |  |
| 145 | M | M145 | nová |  |
| 145 | N | N145 | post DIS validace - kód: 103901612 (akce 99) |  |
| 146 | A | A146 | 262 |  |
| 146 | B | B146 | Kontrola existence ID PPV v systémech ČSSZ |  |
| 146 | C | C146 | 10228 |  |
| 146 | D | D146 | Vykonávaná pozice zaměstnance |  |
| 146 | E | E146 | Formulář zaměstnance (form) |  |
| 146 | F | F146 | n/a |  |
| 146 | G | G146 | n/a |  |
| 146 | H | H146 | DIS |  |
| 146 | I | I146 | nepropustná |  |
| 146 | J | J146 | F2 |  |
| 146 | K | K146 | V systémech ČSSZ musí být  nalezeno ID PPV (10228) <br>---<br>10228 ID pracovněprávního vztahu (Identifikátor zaměstnání) |  |
| 146 | L | L146 | Pojistný vztah s uvedeným ID PPV XXX nebyl nalezen v systémech ČSSZ. |  |
| 146 | M | M146 | nová |  |
| 146 | N | N146 | post DIS validace - kód: 103901608 (akce 99) |  |
| 147 | A | A147 | 263 |  |
| 147 | B | B147 | Kontrola existence IK MPSV v systémech ČSSZ |  |
| 147 | C | C147 | 10051 |  |
| 147 | D | D147 | Zaměstnanec / Žák / Student  |  |
| 147 | E | E147 | Formulář zaměstnance (form) |  |
| 147 | F | F147 | n/a |  |
| 147 | G | G147 | n/a |  |
| 147 | H | H147 | DIS |  |
| 147 | I | I147 | nepropustná |  |
| 147 | J | J147 | F2 |  |
| 147 | K | K147 | V systémech ČSSZ musí být nalezeno IK MPSV (10051)<br>---<br>10051 IK MPSV (Osobní identifikační číslo - OIČ) |  |
| 147 | L | L147 | Pojistný vztah s uvedeným IK MPSV XXX nebyl nalezen v systémech ČSSZ. |  |
| 147 | M | M147 | nová |  |
| 147 | N | N147 | post DIS validace - kód: 103901609 (akce 99) |  |
| 148 | A | A148 | 264 |  |
| 148 | B | B148 | Kontrola existence IK MPSV a ID PPV v systémech ČSSZ |  |
| 148 | C | C148 | 10051<br>10228 |  |
| 148 | D | D148 | Zaměstnanec / Žák / Student  |  |
| 148 | E | E148 | Formulář zaměstnance (form) |  |
| 148 | F | F148 | n/a |  |
| 148 | G | G148 | n/a |  |
| 148 | H | H148 | DIS |  |
| 148 | I | I148 | nepropustná |  |
| 148 | J | J148 | F2 |  |
| 148 | K | K148 | V systémech ČSSZ musí být nalezeno IK MPSV (10051) a ID PPV (10228)<br>---<br>10051 IK MPSV (Osobní identifikační číslo - OIČ)<br>10228 ID pracovněprávního vztahu (Identifikátor zaměstnání) |  |
| 148 | L | L148 | Pojistný vztah s uvedeným ID PPV XXX a IK MPSV XXX nebyl nalezen v systémech ČSSZ. |  |
| 148 | M | M148 | nová |  |
| 148 | N | N148 | post DIS validace - kód: 103901610 (akce 99) |  |
| 149 | A | A149 | 265 |  |
| 149 | B | B149 | Pořadí pro určení výše daňového zvýhodnění |  |
| 149 | C | C149 | 10440 |  |
| 149 | D | D149 | Souhrnná data zaměstnance |  |
| 149 | E | E149 | Formulář zaměstnance (form) |  |
| 149 | F | F149 | n/a |  |
| 149 | G | G149 | n/a |  |
| 149 | H | H149 | DIS |  |
| 149 | I | I149 | nepropustná |  |
| 149 | J | J149 | F4 |  |
| 149 | K | K149 | Hodnota musí být z číselníku.<br>---<br>10440 Pořadí pro určení výše daňového zvýhodnění |  |
| 149 | L | L149 | ="Hodnota " & B149 & " neodpovídá číselníku." |  |
| 149 | M | M149 | nová |  |
| 150 | A | A150 | 267 |  |
| 150 | B | B150 | Kontrola nevyplnění dat pro rozklad při nulovém atributu Mzda za práci zúčtovaná |  |
| 150 | C | C150 | 10329<br>10330<br>10331<br>10332<br>10333<br>10334<br>10335<br>10336<br>10328 |  |
| 150 | D | D150 | Mzda |  |
| 150 | E | E150 | Formulář zaměstnance (form) |  |
| 150 | F | F150 | n/a |  |
| 150 | G | G150 | n/a |  |
| 150 | H | H150 | DIS |  |
| 150 | I | I150 | nepropustná |  |
| 150 | J | J150 | F4 |  |
| 150 | K | K150 | Pokud je (10328) = 0,<br>pak atributy: (10329), (10330), (10331), (10332), (10333), (10334), (10335), (10336) nesmí nabývat hodnot<br>---<br>10329 Tarifní mzdy<br>10330 Prémie a odměny pravidelné<br>10331 Prémie a odměny nepravidelné<br>10332 Příplatky celkem<br>10333 Příplatky za práci přesčas<br>10334 Příplatky za práci v noci<br>10335 Příplatky za práci o sobotách a nedělích<br>10336 Příplatky za práci ve svátek<br>10328 Mzda za práci zúčtovaná |  |
| 150 | L | L150 | Při celkové nulové hodnotě Mzda za práci zúčtovaná se nevyplňují atributy: Tarifní mzdy, Prémie a odměny pravidelné, Prémie a odměny nepravidelné, Příplatky celkem, Příplatky za práci přesčas, Příplatky za práci v noci, Příplatky za práci o sobotách a nedělích, Příplatky za práci ve svátek, Mzda za práci zúčtovaná. |  |
| 150 | M | M150 | nová |  |
| 151 | A | A151 | 269 |  |
| 151 | B | B151 | Kontrola Úhrn vyměřovacích základů zaměstnanců, kteří mají nárok na slevu na pojistném zaměstnance |  |
| 151 | C | C151 | 10544<br>10477<br>10546 |  |
| 151 | D | D151 | Přehled o výši pojistného |  |
| 151 | E | E151 | Formulář PVPOJ a zaměstnance |  |
| 151 | F | F151 | ePortál |  |
| 151 | G | G151 | propustná |  |
| 151 | H | H151 | cJMHZ |  |
| 151 | I | I151 | propustná |  |
| 151 | J | J151 | F5 |  |
| 151 | K | K151 | (10544) = ∑ (10477), za zaměstnance, u kterého je (10546) = "ANO"<br>---<br>10544 Úhrn vyměřovacích základů zaměstnanců<br>10477 Částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné<br>10546 Sleva na pojistném zaměstnance (Ovocnářství a pěstování zeleniny)<br><br> |  |
| 151 | L | L151 | Vykázaný úhrn vyměřovacích základů zaměstnanců, kteří mají nárok na slevu na pojistném zaměstnance v ovocnářství a při pěstování zeleniny, neodpovídá součtu vyměřovacích základů těchto zaměstnanců. |  |
| 151 | M | M151 | nová |  |
| 152 | A | A152 | 270 |  |
| 152 | B | B152 | Úhrn slev na pojistném zaměstnanců |  |
| 152 | C | C152 | 10545<br>10544 |  |
| 152 | D | D152 | Přehled o výši pojistného |  |
| 152 | E | E152 | Formulář PVPOJ (pvpoj) |  |
| 152 | F | F152 | ePortál |  |
| 152 | G | G152 | nepropustná |  |
| 152 | H | H152 | DIS |  |
| 152 | I | I152 | nepropustná |  |
| 152 | J | J152 | F4 |  |
| 152 | K | K152 | ="Pro (10545) platí:" & CHAR(10)<br>& "hodnota údaje je dána výrazem v absolutní hodnotě: \|1 – ("& ('Parametrické konstanty'!C7*100) &" % údaje (10544) / údaj (10545))\| <= 0.01 nebo \|"& ('Parametrické konstanty'!C7*100) &" % údaje (10544) – údaj (10545)\| <= 100;" & CHAR(10) & CHAR(10)<br>& "tzn. akceptovány budou hodnoty, kdy úhrn slev na pojistném zaměstnanců (10545) je větší než "& ('Parametrické konstanty'!C8*100) &" % úhrnu vyměřovacích základů pojistného (10544)," & CHAR(10)<br>& "ale rozdíl částek je <= 100 (obě podmínky musejí být porušeny současně, aby nebyl údaj akceptován) a zároveň musí platit (10545) ≥ "& ('Parametrické konstanty'!C7*100) &" % z (10544)" & CHAR(10)<br>& "---" & CHAR(10)<br>& "10545 Úhrn slev na pojistném zaměstnanců" & CHAR(10)<br>& "10544 Úhrn vyměřovacích základů zaměstnanců" |  |
| 152 | L | L152 | Úhrn slev na pojistném zaměstnanců neodpovídá vykázanému úhrnu vyměřovacích základů těchto zaměstnanců. |  |
| 152 | M | M152 | nová |  |
| 153 | A | A153 | 271 |  |
| 153 | B | B153 | Kontrola uplatnění slevy pro ovocnáře |  |
| 153 | C | C153 | 10546<br>10477 |  |
| 153 | D | D153 | Průběh pojištění v daném měsíci |  |
| 153 | E | E153 | Formulář zaměstnance (form) |  |
| 153 | F | F153 | ePortál |  |
| 153 | G | G153 | nepropustná |  |
| 153 | H | H153 | DIS |  |
| 153 | I | I153 | nepropustná |  |
| 153 | J | J153 | F4 |  |
| 153 | K | K153 | ="Pokud je (10477) > " & 'Parametrické konstanty'!C16 & ",<br>pak (10546) nesmí být ""ANO""<br>---<br>10546 Sleva na pojistném zaměstnance<br>10477 Částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné" |  |
| 153 | L | L153 | Slevu nelze uplatnit, protože atribut Částka vyměřovacího základu zaměstnance, ze který je odváděno pojistné překračuje limit dle § 23b odst. 4 ZPSZ v roce za, které je měsíční hlášení podáváno. |  |
| 153 | M | M153 | nová |  |
| 154 | A | A154 | 272 |  |
| 154 | B | B154 | Vylpnění výše slevy na pojistném zaměstnance pro ovocnářství a pěstování zeleniny |  |
| 154 | C | C154 | 10547<br>10546 |  |
| 154 | D | D154 | Průběh pojištění v daném měsíci |  |
| 154 | E | E154 | Formulář zaměstnance (form) |  |
| 154 | F | F154 | ePortál |  |
| 154 | G | G154 | nepropustná |  |
| 154 | H | H154 | DIS |  |
| 154 | I | I154 | nepropustná |  |
| 154 | J | J154 | F4 |  |
| 154 | K | K154 | Výše slevy na pojistném zaměstnance (10547) musí být vyplněna jen v případě, že (10546) = "ANO"<br>---<br>10547 Výše slevy na pojistném zaměstnance<br>10546 Sleva na pojistném zaměstnance |  |
| 154 | L | L154 | Výše slevy na pojistném zaměstnance musí být vyplněna jen v případě, že je v poli Sleva na pojistném zaměstnance uvedeno ANO. |  |
| 154 | M | M154 | nová |  |
| 155 | A | A155 | 273 |  |
| 155 | B | B155 | Kontrola slevy a pojištění pro ovocnářství a pěstování zeleniny |  |
| 155 | C | C155 | 10547<br>10370 |  |
| 155 | D | D155 | Průběh pojištění v daném měsíci |  |
| 155 | E | E155 | Formulář zaměstnance (form) |  |
| 155 | F | F155 | ePortál |  |
| 155 | G | G155 | nepropustná |  |
| 155 | H | H155 | DIS |  |
| 155 | I | I155 | nepropustná |  |
| 155 | J | J155 | F4 |  |
| 155 | K | K155 | Pokud (10546) = "ANO",<br>platí že: (10547) = (10370)<br>---<br>10547 Výše slevy na pojistném zaměstnance<br>10370 Sociální pojištění<br>10546 Sleva na pojistném zaměstnance<br><br><br><br> |  |
| 155 | L | L155 | Atribut Výše slevy na pojistném zaměstnance	 (pro ovocnářství a pěstování zeleniny) neodpovídá atributu Sociální pojištění. |  |
| 155 | M | M155 | nová |  |
| 156 | A | A156 | 275 |  |
| 156 | B | B156 | Kontrola výlučnosti uplatnění slevy |  |
| 156 | C | C156 | 10490<br>10546<br>10228 |  |
| 156 | D | D156 | Průběh pojištění v daném měsíci |  |
| 156 | E | E156 | Formulář zaměstnance (form) |  |
| 156 | F | F156 | ePortál |  |
| 156 | G | G156 | nepropustná |  |
| 156 | H | H156 | DIS |  |
| 156 | I | I156 | nepropustná |  |
| 156 | J | J156 | F4 |  |
| 156 | K | K156 | V rámci jednoho formuláře (10228) nesmí být oba atributy (10490, 10546) = "ANO"<br>---<br>10490 Sleva na pojistném zaměstnance<br>10546 Sleva na pojistném zaměstnance<br>10228 ID pracovněprávního vztahu (Identifikátor zaměstnání)<br><br><br> |  |
| 156 | L | L156 | Témuž zaměstnanci nelze poskytnout slevu zaměstnance pro pracující důchodce i slevu pro zaměstnance v ovocnářství a při pěstování zeleniny. Sleva pro zaměstnance v ovocnářství má přednost. |  |
| 156 | M | M156 | nová |  |
| 157 | A | A157 | 276 |  |
| 157 | B | B157 | Počet měsíců uplatnění slevy souhlasí s možným počtem uplatnění |  |
| 157 | C | C157 | 10426 |  |
| 157 | D | D157 | Souhrnná data zaměstnance |  |
| 157 | E | E157 | Formulář zaměstnance (form) |  |
| 157 | F | F157 | ePortál |  |
| 157 | G | G157 | nepropustná |  |
| 157 | H | H157 | DIS |  |
| 157 | I | I157 | nepropustná |  |
| 157 | J | J157 | F4 |  |
| 157 | K | K157 | Počet měsíců uplatnění slevy nabývá hodnoty 1 až 12, <br>(10426) = <1; 12>.<br>---<br>10426 Počet měsíců uplatnění slevy |  |
| 157 | L | L157 | Chybná hodnota v počtu měsíců uplatnění slevy. |  |
| 157 | M | M157 | nová |  |
| 158 | A | A158 | 277 |  |
| 158 | B | B158 | Povinné RČ nebo datum narození při uplatnění slevy  podle § 35bb zákona o daních z příjmů (ZDP) |  |
| 158 | C | C158 | 10541<br>10542 |  |
| 158 | D | D158 | Souhrnná data zaměstnance |  |
| 158 | E | E158 | Formulář zaměstnance (form) |  |
| 158 | F | F158 | ePortál |  |
| 158 | G | G158 | nepropustná |  |
| 158 | H | H158 | DIS |  |
| 158 | I | I158 | nepropustná |  |
| 158 | J | J158 | F4 |  |
| 158 | K | K158 | Musí být vyplněno buď RČ (10542) nebo datum narození (10541)<br>---<br>10541 Datum narození dítěte<br>10542 Rodné číslo dítěte |  |
| 158 | L | L158 | Chybí rodné číslo nebo datum narození dítěte v rámci uplatnění slevy  podle § 35bb zákona o daních z příjmů (ZDP). |  |
| 158 | M | M158 | nová |  |
| 159 | A | A159 | 278 |  |
| 159 | B | B159 | Kontrola věku dítěte pro uplatnění - I (výsledek ročního zúčtování sleva na manžela/manželku)  |  |
| 159 | C | C159 | 10541<br>10542<br>10011 |  |
| 159 | D | D159 | Souhrnná data zaměstnance |  |
| 159 | E | E159 | Formulář zaměstnance (form) |  |
| 159 | F | F159 | ePortál |  |
| 159 | G | G159 | nepropustná |  |
| 159 | H | H159 | DIS |  |
| 159 | I | I159 | nepropustná |  |
| 159 | J | J159 | F4 |  |
| 159 | K | K159 | Nelze uvést dítě, které se narodilo roku ((10011) - 5) a nebo dříve, <br>věk dítěte je určen (10541) nebo (10542)<br>---<br>10541 Datum narození dítěte<br>10542 Rodné číslo dítěte<br>10011 Rok |  |
| 159 | L | L159 | Nelze uvést dítě po dovršení tří let věku. |  |
| 159 | M | M159 | nová |  |
| 160 | A | A160 | 292 |  |
| 160 | B | B160 | Kontrola věku dítěte pro uplatnění - II (výsledek ročního zúčtování sleva na manžela/manželku)  |  |
| 160 | C | C160 | 10426<br>10541<br>10542<br>10011 |  |
| 160 | D | D160 | Souhrnná data zaměstnance |  |
| 160 | E | E160 | Formulář zaměstnance (form) |  |
| 160 | F | F160 | ePortál |  |
| 160 | G | G160 | nepropustná |  |
| 160 | H | H160 | DIS |  |
| 160 | I | I160 | nepropustná |  |
| 160 | J | J160 | F4 |  |
| 160 | K | K160 | Části kontroly 1) až 3) se vyhodnocují pouze v případě, pokud v sadě dětí není alespoň jedno dítě narozené v roce ((10011) - 2) nebo ((10011) - 3) (tj. dítě, pro které je relevantní všech 12 měsíců v ročním zúčtováním), pak platí, že (10426) je z intervalu <1; 12>.<br><br>1) Pro výpočet maximální možné hodnoty atributu (10426) je třeba určit počet unikátních měsíců, ve kterých lze uplatnit slevu podle rozhodných dnů. Rozhodným dnem pro každý měsíc je 1. den měsíce:<br>1a) Pokud se dítě narodí právě 1. den v měsíci, započítává se tento měsíc včetně.<br>1b) Pokud se narodí později, započítává se až následující měsíc.<br>1c) Pokud dítě dosáhne 3 let věku 1. dne v měsíci, pak se aktuální měsíc nezapočítáva.<br><br>2) U dětí narozených v roce ((10011) - 1) se počet měsíců relevantních (v rámci sady dětí) pro slevu stanoví podle toho, kolik od data narození dítěte proběhlo rozhodných dnů včetně data narození<br><br>3) U dětí narozených v roce ((10011) - 4) se počet měsíců relevantních pro slevu stanoví podle toho, kolik do data dosažení věku 3 let dítěte proběhlo rozhodných dnů od počátku roku.<br><br>Pro děti narozené v letech ((10011) - 1) a ((10011) - 4) se sečtou všechny unikátní měsíce relevantní pro slevu, které představují maximální hodnotu (10426). <br><br>Věk dítěte je určen (10541) nebo (10542). Pozn.: výraz ((10011)–4) představuje výpočet kalendářního roku, který je o čtyři roky nazpět od roku uvedeného v atributu (10011) tj. roku podání<br>---<br>10426 Počet měsíců uplatnění slevy<br>10541 Datum narození dítěte<br>10542 Rodné číslo dítěte<br>10011 Rok |  |
| 160 | L | L160 | Hodnota pro Počet měsíců uplatnění slevy neodpovídá maximálnímu možnému počtu měsíců stanovenému podle data narození dítěte v roce podání. |  |
| 160 | M | M160 | nová |  |
| 161 | A | A161 | 280 |  |
| 161 | B | B161 | Úhrn slev na pojistném zaměstnanců |  |
| 161 | C | C161 | 10545<br>10547 |  |
| 161 | D | D161 | Průběh pojištění v daném měsíci |  |
| 161 | E | E161 | Formulář zaměstnance (form) |  |
| 161 | F | F161 | ePortál |  |
| 161 | G | G161 | nepropustná |  |
| 161 | H | H161 | cJMHZ |  |
| 161 | I | I161 | propustná |  |
| 161 | J | J161 | F5 |  |
| 161 | K | K161 | Součet slev na pojistném zaměstnanců (10547) se musí rovnat úhrnu slev na pojistném zaměstnanců (10545).<br>---<br>10545 Úhrn slev na pojistném zaměstnanců<br>10547 Výše slevy na pojistném zaměstnance |  |
| 161 | L | L161 | Vykázaný úhrn slev na pojistném zaměstnanců neodpovídá součtu slev na pojistném těchto zaměstnanců. |  |
| 161 | M | M161 | nová |  |
| 162 | A | A162 | 281 |  |
| 162 | B | B162 | Kontrola nevyplnění dat pro rozklad při nulových náhradách mzdy zúčtované |  |
| 162 | C | C162 | 10338<br>10339<br>10340<br>10341<br>10337 |  |
| 162 | D | D162 | Mzda |  |
| 162 | E | E162 | Formulář zaměstnance (form) |  |
| 162 | F | F162 | ePortál |  |
| 162 | G | G162 | nepropustná |  |
| 162 | H | H162 | DIS |  |
| 162 | I | I162 | nepropustná |  |
| 162 | J | J162 | F4 |  |
| 162 | K | K162 | Pokud (10337) = 0,<br>pak atributy: (10338, 10339, 10340, 10341) nenabývají hodnot<br>---<br>10338 Náhrady za dovolenou<br>10339 Náhrady za svátky<br>10340 Náhrady - překážky na straně zaměstnavatele<br>10341 Náhrady - překážky na straně zaměstnance<br>10337 Náhrady mzdy zúčtované |  |
| 162 | L | L162 | Při nulových náhradách mzdy zúčtované se nevyplňují atributy: Náhrady za dovolenou, Náhrady za svátky, Náhrady - překážky na straně zaměstnavatele, Náhrady - překážky na straně zaměstnance. |  |
| 162 | M | M162 | nová |  |
| 163 | A | A163 | 282 |  |
| 163 | B | B163 | Kontrola nevyplnění dat odpracovaných hodin pro zaměstnání v hlubinném hornictví a rizikové práci |  |
| 163 | C | C163 | 10269<br>10270<br>10271<br>10272<br>10273<br>10274<br>10268 |  |
| 163 | D | D163 | Průběh zaměstnání v daném měsíci |  |
| 163 | E | E163 | Formulář zaměstnance (form) |  |
| 163 | F | F163 | ePortál |  |
| 163 | G | G163 | nepropustná |  |
| 163 | H | H163 | DIS |  |
| 163 | I | I163 | nepropustná |  |
| 163 | J | J163 | F4 |  |
| 163 | K | K163 | Pokud (10268) = 0,<br>pak atributy: (10269, 10270, 10271, 10272, 10273, 10274) nenabývají hodnot<br>---<br>10269 Přesčasové hodiny (z odpracovaných)<br>10270 Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - uran<br>10271 Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - ostatní<br>10272 Datum dosažení expozice NPE<br>10273 Počet odpracovaných hodin v rámci rizikové práce (§ 37d odst. 2 ZDP), práce zdravotnického záchranáře (§ 37d odst. 3) a práce člena jednotky HZS podniku (§ 37d odst. 3)  <br>10274 Kategorizace rizika<br>10268 Počet odpracovaných hodin |  |
| 163 | L | L163 | Při nulovém počtu odpracovaných hodin se nevyplňují atributy: Přesčasové hodiny (z odpracovaných), Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - uran, Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - ostatní, Datum dosažení expozice NPE, Počet odpracovaných hodin v rámci rizikové práce (§ 37d odst. 2 ZDP), práce zdravotnického záchranáře (§ 37d odst. 3) a práce člena jednotky HZS podniku (§ 37d odst. 3), Kategorizace rizika. |  |
| 163 | M | M163 | nová |  |
| 164 | A | A164 | 283 |  |
| 164 | B | B164 | Kontrola nevyplnění dat pro zúčtovaný příjem - celkem |  |
| 164 | C | C164 | 10416<br>10289<br>10417<br>10292<br>10293<br>10294<br>10295<br>10296<br>10418<br>10308<br>10309<br>10310<br>10286 |  |
| 164 | D | D164 | Souhrnná data zaměstnance |  |
| 164 | E | E164 | Formulář zaměstnance (form) |  |
| 164 | F | F164 | ePortál |  |
| 164 | G | G164 | nepropustná |  |
| 164 | H | H164 | DIS |  |
| 164 | I | I164 | nepropustná |  |
| 164 | J | J164 | F4 |  |
| 164 | K | K164 | Pokud (10286) = 0,<br>pak atributy: (10289, 10417, 10292, 10293, 10294, 10295, 10296, 10418, 10308, 10309, 10310, 10416) nesmí nabývat hodnot<br>---<br>10416 Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR<br>10289 Osvobozené příjmy ze zúčtovaných příjmů - celkem<br>10417 Příspěvek zaměstnavatele na produkty spoření na stáří a pojištění dlouhodobé péče z osvobozených příjmů - celkem<br>10292 Příspěvek na penzijní připojištění se státním příspěvkem<br>10293 Příspěvek na doplňkové penzijní spoření<br>10294 Příspěvek na penzijní pojištění<br>10295 Příspěvek na soukromé životní pojištění<br>10296 Příspěvek na dlouhodobý investiční produkt<br>10418 Příspěvek na pojištění dlouhodobé péče<br>10308 Odměna člena (nerezidenta) orgánu právnické osoby<br>10309 Skutečně sražená daň podle zvláštní sazby daně / měsíc<br>10310 Sražená daň podle zvláštní sazby daně z příjmu nerezidenta člena orgánu právnické osoby<br>10286 Zúčtovaný příjem - celkem |  |
| 164 | L | L164 | Při nulovém zúčtovaném příjmu - celkem se nevyplňují atributy: Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty. |  |
| 164 | M | M164 | nová |  |
| 165 | A | A165 | 284 |  |
| 165 | B | B165 | Kontrola vyplnění min. jednoho atributu pro částku vyměřovacího základu zaměstnance, ze které je odváděno pojistné |  |
| 165 | C | C165 | 10478<br>10479<br>10480<br>10477 |  |
| 165 | D | D165 | Průběh pojištění v daném měsíci |  |
| 165 | E | E165 | Formulář zaměstnance (form) |  |
| 165 | F | F165 | ePortál |  |
| 165 | G | G165 | nepropustná |  |
| 165 | H | H165 | DIS |  |
| 165 | I | I165 | nepropustná |  |
| 165 | J | J165 | F4 |  |
| 165 | K | K165 | Pokud se nejedná o datové scénáře: <br> 1) činnosti K až S: <br>  (10239) = "K" až "S" nebo, <br>  (10239) = "1" až "9" s příznakem (10502) = "Pracovní vztah specifické skupiny"<br> 2) pěstoun: (10239) = "M",<br>pak platí kontrola:<br>když (10477) nabývá hodnoty (je nenulový),<br>pak musí být vyplněn jeden z následujících atributů: (10478, 10479, 10480)<br>---<br>10478 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ <br>10479 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ <br>10480 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ <br>10477 Částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné |  |
| 165 | L | L165 | Pokud atribut částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné, nabývá hodnoty, pak musí být vyplněn alespoň jeden z následujících atributů: Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ, Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ, Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ. |  |
| 165 | M | M165 | nová |  |
| 166 | A | A166 | 286 |  |
| 166 | B | B166 | Kontrola nevyplnění atributů neodpracovaných hodin. |  |
| 166 | C | C166 | 10276<br>10278<br>10277<br>10279<br>10280<br>10471<br>10472<br>10275 |  |
| 166 | D | D166 | Průběh zaměstnání v daném měsíci |  |
| 166 | E | E166 | Formulář zaměstnance (form) |  |
| 166 | F | F166 | ePortál |  |
| 166 | G | G166 | nepropustná |  |
| 166 | H | H166 | DIS |  |
| 166 | I | I166 | nepropustná |  |
| 166 | J | J166 | F4 |  |
| 166 | K | K166 | Pokud je atribut (10275) = 0,<br>pak atributy: (10276, 10278, 10277, 10279, 10280, 10471, 10472) nesmí nabývat hodnot<br>---<br>10276 Počet neodpracovaných hodin s náhradou či nekrácením mzdy<br>10278 Počet neodpracovaných hodin z důvodu dočasné pracovní neschopnosti, za které je ze strany zaměstnavatele poskytována náhrada mzdy <br>10277 Počet neodpracovaných hodin v důsledku dočasné pracovní neschopnosti bez náhrady mzdy hrazené zaměstnavatelem<br>10279 Počet neodpracovaných hodin v důsledku čerpání dovolené na zotavenou<br>10280 Počet neodpracovaných hodin v důsledku ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné <br>10471 Překážky na straně zaměstnance s náhradou mzdy/platu - počet neodpracovaných hodin<br>10472 Překážky na straně zaměstnavatele - počet neodpracovaných hodin<br>10275 Celkový počet neodpracovaných hodin |  |
| 166 | L | L166 | Při nulovém celkovém počtu neodpracovaných hodin se nevyplňují atributy: Počet neodpracovaných hodin s náhradou či nekrácením mzdy, Počet neodpracovaných hodin z důvodu dočasné pracovní neschopnosti, za které je ze strany zaměstnavatele poskytována náhrada mzdy, Počet neodpracovaných hodin v důsledku dočasné pracovní neschopnosti bez náhrady mzdy hrazené zaměstnavatelem, Počet neodpracovaných hodin v důsledku čerpání dovolené na zotavenou, Počet neodpracovaných hodin v důsledku ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné, Překážky na straně zaměstnance s náhradou mzdy/platu - počet neodpracovaných hodin, Překážky na straně zaměstnavatele - počet neodpracovaných hodin. |  |
| 166 | M | M166 | nová |  |
| 167 | A | A167 | 289 |  |
| 167 | B | B167 | Kontrola uplatnění slevy na pojistném zaměstnavatele za zaměstnance, za kterého byl oznámen záměr uplatňovat tuto slevu |  |
| 167 | C | C167 | 10372<br>10032 |  |
| 167 | D | D167 | Průběh pojištění v daném měsíci |  |
| 167 | E | E167 | Formulář PVPOJ a zaměstnance |  |
| 167 | F | F167 | n/a |  |
| 167 | G | G167 | n/a |  |
| 167 | H | H167 | cJMHZ |  |
| 167 | I | I167 | propustná |  |
| 167 | J | J167 | F5 |  |
| 167 | K | K167 | Sleva na pojistném zaměstnavatele za zaměstnance (10372) = "ANO" náleží zaměstnavateli, jen pokud oznámil ČSSZ záměr uplatňovat tuto slevu za tohoto zaměstnance.<br>---<br>10032 Sleva na pojistném zaměstnavatele (Přehled o výši pojistného)<br>10372 Sleva na pojistném zaměstnavatele (Průběh pojištění v daném měsíci) |  |
| 167 | L | L167 | Zaměstnavatel neoznámil záměr uplatňovat slevu na pojistném zaměstnavatele za zaměstnance. |  |
| 167 | M | M167 | nová |  |
| 168 | A | A168 | 290 |  |
| 168 | B | B168 | Kontrola na výši slevy na pojistném zaměstnavatele uplatněné v opravném hlášení podaném po zákonné lhůtě |  |
| 168 | C | C168 | 10032<br>10007<br>10006<br>10011<br>10010 |  |
| 168 | D | D168 | Přehled o výši pojistného |  |
| 168 | E | E168 | Formulář PVPOJ a zaměstnance |  |
| 168 | F | F168 | n/a |  |
| 168 | G | G168 | n/a |  |
| 168 | H | H168 | cJMHZ |  |
| 168 | I | I168 | propustná |  |
| 168 | J | J168 | F5 |  |
| 168 | K | K168 | Pokud se jedná o opravné podání (10007) = "O", podaného po zákonné lhůtě, kontroluje  se:<br>výše slevy na pojistném v atributu (10032) není vyšší než sleva uplatněná v posledním hlášení zaslaném v zákonné lhůtě<br>---<br>10032 Sleva na pojistném zaměstnavatele (Přehled o výši pojistného)<br>10007 Typ podání<br>10006 Datum a čas přijetí podání<br>10010 Měsíc<br>10011 Rok |  |
| 168 | L | L168 | Opravným hlášením podaným po datu splatnosti pojistného nelze dodatečně uplatnit slevu na pojistném zaměstnavatele, resp. nelze uplatnit vyšší slevu než, která byla uplatněna v posledním hlášení podaném v zákonné lhůtě. |  |
| 168 | M | M168 | nová |  |
| 169 | A | A169 | 293 |  |
| 169 | B | B169 | Kontrola na datum od a do (průběh studia) jsou v rámci vykazovaného měsíce |  |
| 169 | C | C169 | 10263<br>10264<br>10010<br>10011 |  |
| 169 | D | D169 | Průběh teoretické a praktické přípravy |  |
| 169 | E | E169 | Formulář zaměstnance (form) |  |
| 169 | F | F169 | ePortál |  |
| 169 | G | G169 | nepropustná |  |
| 169 | H | H169 | DIS |  |
| 169 | I | I169 | nepropustná |  |
| 169 | J | J169 | F4 |  |
| 169 | K | K169 | Platí, že datum od (10263) a datum do (10264) musí být v rámci vykazovaného měsíce definovaném v (10010, 10011).<br>---   <br>10263 Datum od<br>10264 Datum do<br>10010 Měsíc<br>10011 Rok |  |
| 169 | L | L169 | Datum od a datum do musí být v rámci vykazovaného měsíce. |  |
| 169 | M | M169 | nová |  |
| 170 | A | A170 | 296 |  |
| 170 | B | B170 | Sleva na pojistném zaměstnanců v ovocnářství jen z DPP |  |
| 170 | C | C170 | 10546<br>10239 |  |
| 170 | D | D170 | Průběh pojištění v daném měsíci |  |
| 170 | E | E170 | Formulář zaměstnance (form) |  |
| 170 | F | F170 | ePortál |  |
| 170 | G | G170 | nepropustná |  |
| 170 | H | H170 | cJMHZ |  |
| 170 | I | I170 | nepropustná |  |
| 170 | J | J170 | F5 |  |
| 170 | K | K170 | Pokud (10239) = "T" až "ZC" (zaměstnání na DPP),<br>pak může (10546) = "ANO"<br>---<br>10546 Sleva na pojistném zaměstnance<br>10239 Druh činnosti |  |
| 170 | L | L170 | Sleva na pojistném zaměstnanců v ovocnářství a při pěstování zeleniny náleží jen z DPP. |  |
| 170 | M | M170 | nová |  |
| 171 | A | A171 | 297 |  |
| 171 | B | B171 | Počet zaměstnanců se slevou – pracující důchodci |  |
| 171 | C | C171 | 10485<br>10490 |  |
| 171 | D | D171 | Přehled o výši pojistného |  |
| 171 | E | E171 | Formulář PVPOJ a zaměstnance |  |
| 171 | F | F171 | ePortál |  |
| 171 | G | G171 | propustná |  |
| 171 | H | H171 | cJMHZ |  |
| 171 | I | I171 | propustná |  |
| 171 | J | J171 | F5 |  |
| 171 | K | K171 | Počet zaměstnanců (10485) nesmí být vyšší než ∑ (n) pojistných vztahů, u nichž je v atributu (10490) uvedeno „ANO“.<br>---<br>10485 Počet zaměstnanců<br>10490 Sleva na pojistném |  |
| 171 | L | L171 | Počet zaměstnanců, kteří mají nárok na slevu na pojistném pro pracující důchodce, nemůže být vyšší než počet pojistných vztahů, z nichž je tato sleva uplatňována. |  |
| 171 | M | M171 | PVPOJ 2023 1.1 |  |
| 172 | A | A172 | 298 |  |
| 172 | B | B172 | Počet zaměstnanců se slevou – ovocnáři |  |
| 172 | C | C172 | 10543<br>10546 |  |
| 172 | D | D172 | Přehled o výši pojistného |  |
| 172 | E | E172 | Formulář PVPOJ a zaměstnance |  |
| 172 | F | F172 | ePortál |  |
| 172 | G | G172 | propustná |  |
| 172 | H | H172 | cJMHZ |  |
| 172 | I | I172 | propustná |  |
| 172 | J | J172 | F5 |  |
| 172 | K | K172 | Počet zaměstnanců (10543) nesmí být vyšší než ∑ (n) pojistných vztahů, u nichž je v atributu (10546) uvedeno „ANO“.<br>---<br>10543 Počet zaměstnanců<br>10546 Sleva na pojistném ovocnáři |  |
| 172 | L | L172 | Počet zaměstnanců, kteří mají nárok na slevu na pojistném zaměstnance v ovocnářství a při pěstování zeleniny, nemůže být vyšší než počet pojistných vztahů (DPP), z nichž je tato sleva uplatňována. |  |
| 172 | M | M172 | nová |  |
| 173 | A | A173 | 299 |  |
| 173 | B | B173 | Kontrola datumu pojištění od a do v průběhu pojištění v měsíci |  |
| 173 | C | C173 | 10354<br>10355<br>10011<br>10010 |  |
| 173 | D | D173 | Průběh pojištění v daném měsíci |  |
| 173 | E | E173 | Formulář zaměstnance (form) |  |
| 173 | F | F173 | ePortál |  |
| 173 | G | G173 | nepropustná |  |
| 173 | H | H173 | DIS |  |
| 173 | I | I173 | nepropustná |  |
| 173 | J | J173 | F4 |  |
| 173 | K | K173 | Atributy (10354) a (10355) musí být v rámci vykazovaného měsíce, za které bylo podáno měsíční hlášení (10010, 10011).<br>---<br>10354 Pojištění od<br>10355 Pojištění do<br>10010 Měsíc<br>10011 Rok<br> |  |
| 173 | L | L173 | Atributy pojištění od a pojištění do musí být v rámci vykazovaného rozhodného období určeného atributy Měsíc a Rok. |  |
| 173 | M | M173 | nová |  |
| 174 | A | A174 | 300 |  |
| 174 | B | B174 | Kontrola na celkový počet formulářů v prvním dílčím podání |  |
| 174 | C | C174 | 10015 |  |
| 174 | D | D174 | Meta atributy |  |
| 174 | E | E174 | Měsíční podání JMHZ (global) |  |
| 174 | F | F174 | n/a |  |
| 174 | G | G174 | n/a |  |
| 174 | H | H174 | DIS |  |
| 174 | I | I174 | nepropustná |  |
| 174 | J | J174 | F4 |  |
| 174 | K | K174 | V rámci prvního dílčího podání nabývá atribut (10015) max. 1502 (pojistná část, souhrnná část, 1500 součástí indiv. části).<br>---<br>10015 Počet formulářů v balíku dat |  |
| 174 | L | L174 | Zadaný počet formulářů neodpovídá maximálnímu počtu formulářů (1502 celkem).  |  |
| 174 | M | M174 | nová |  |
| 174 | N | N174 | první dílčí podání vždy obsahuje souhrnnou, pojistnou část  a min. jednu součást indiv. části (povinné části podání, T4 řešeno na úrovni xsd )<br><br> |  |
| 175 | A | A175 | 301 |  |
| 175 | B | B175 | Kontrola na celkový počet formulářů v druhém a dalších dílčích podáních |  |
| 175 | C | C175 | 10015 |  |
| 175 | D | D175 | Meta atributy |  |
| 175 | E | E175 | Měsíční podání JMHZ (global) |  |
| 175 | F | F175 | n/a |  |
| 175 | G | G175 | n/a |  |
| 175 | H | H175 | DIS |  |
| 175 | I | I175 | nepropustná |  |
| 175 | J | J175 | T5 |  |
| 175 | K | K175 | V rámci druhého dílčího a následujících dílčích podání nabývá atribut (10015) max. 1500 součástí indiv. části.<br>---<br>10015 Počet formulářů v balíku dat |  |
| 175 | L | L175 | Zadaný počet formulářů neodpovídá maximálnímu počtu formulářů (1500 celkem).  |  |
| 175 | M | M175 | nová |  |
| 175 | N | N175 | druhé dílčí podání a následující neobsahuje souhrnnou a pojistnou část, obsahuje pouze součástí indiv. části |  |
| 176 | A | A176 | 302 |  |
| 176 | B | B176 | Kód státu zahraniční právnické osoby nebo zahraniční fyzické osoby |  |
| 176 | C | C176 | 10492 |  |
| 176 | D | D176 | Vykonávaná pozice zaměstnance |  |
| 176 | E | E176 | Formulář zaměstnance (form) |  |
| 176 | F | F176 | n/a |  |
| 176 | G | G176 | n/a |  |
| 176 | H | H176 | DIS |  |
| 176 | I | I176 | nepropustná |  |
| 176 | J | J176 | F4 |  |
| 176 | K | K176 | Hodnota musí být z číselníku<br>---<br>10492 Kód státu zahraniční právnické osoby nebo zahraniční fyzické osoby |  |
| 176 | L | L176 | ="Hodnota " & B176 & " neodpovídá číselníku." |  |
| 176 | M | M176 | nová |  |
| 177 | A | A177 | 303 |  |
| 177 | B | B177 | Kontrola na typ formuláře v součásti indiv. části |  |
| 177 | C | C177 | 10016 |  |
| 177 | D | D177 | JMHZ obecně |  |
| 177 | E | E177 | Formulář zaměstnance (form) |  |
| 177 | F | F177 | n/a |  |
| 177 | G | G177 | n/a |  |
| 177 | H | H177 | DIS |  |
| 177 | I | I177 | nepropustná |  |
| 177 | J | J177 | F1 |  |
| 177 | K | K177 | Pokud (10016) = "R" nebo "O",<br>pak element "formularOsoby" musí v sobě obsahovat jeden z typů formulářů: [bezPriznaku, pestoun, cinnostKS, vezen, mezinarodniPronajemSily, jinyPrijem, ozpTpp, odlozenyPrijem].<br>---<br>10016 Typ formuláře |  |
| 177 | L | L177 | V součásti individualizované části pro řádné nebo opravné podání musí být v elementu formularOsoby uveden příslušný typ formuláře (bezPriznaku, pestoun, cinnostKS, vezen, mezinarodniPronajemSily, jinyPrijem, ozpTpp nebo odlozenyPrijem). |  |
| 177 | M | M177 | nová |  |
| 178 | A | A178 | 304 |  |
| 178 | B | B178 | Vyplnění položky Základ pro výpočet daně |  |
| 178 | C | C178 | 10535 |  |
| 178 | D | D178 | Příjem v daném měsíci |  |
| 178 | E | E178 | Formulář zaměstnance (form) |  |
| 178 | F | F178 | ePortál |  |
| 178 | G | G178 | nepropustná |  |
| 178 | H | H178 | DIS |  |
| 178 | I | I178 | nepropustná |  |
| 178 | J | J178 | F4 |  |
| 178 | K | K178 | V případě nulového základu pro výpočet daně musí být uvedena nula,<br>tedy (10535) >= 0.<br>---<br>10535 Základ pro výpočet daně |  |
| 178 | L | L178 | Hodnota musí být vyplněna i v případě nulového základu pro výpočet daně, zároveň nesmí být záporná.  |  |
| 178 | M | M178 | nová |  |
| 179 | A | A179 | 305 |  |
| 179 | B | B179 | Jedinečnost GUID podání |  |
| 179 | C | C179 | 10001<br>10010<br>10011<br>10221 |  |
| 179 | D | D179 | Meta atributy |  |
| 179 | E | E179 | Měsíční podání JMHZ (nezarazeno) |  |
| 179 | F | F179 | n/a |  |
| 179 | G | G179 | n/a |  |
| 179 | H | H179 | cJMHZ |  |
| 179 | I | I179 | nepropustná |  |
| 179 | J | J179 | T5 |  |
| 179 | K | K179 | GUID podání (10001) je jedinečný identifikátor, který je vztažen k rozhodnému období (10011, 10010) a varibilnímu symbolu (10221).<br>---<br>10001 GUID podání<br>10010 Měsíc<br>10011 Rok<br>10221 Variabilní symbol |  |
| 179 | L | L179 | V systému nesmí existovat více řádných podání se stejným GUID. |  |
| 179 | M | M179 | nová |  |
| 179 | N | N179 | Storno podání v rámci tohoto rozhodného období a variabilního symbolu zneplatní GUID. Nové řádné podání musí být identifikováno novým jedinečným GUID. |  |
| 180 | A | A180 | 306 |  |
| 180 | B | B180 | Jedinečnost GUID formuláře |  |
| 180 | C | C180 | 10012<br>10010<br>10011<br>10221<br>10228 |  |
| 180 | D | D180 | Meta atributy |  |
| 180 | E | E180 | Měsíční podání JMHZ (nezarazeno) |  |
| 180 | F | F180 | n/a |  |
| 180 | G | G180 | n/a |  |
| 180 | H | H180 | cJMHZ |  |
| 180 | I | I180 | nepropustná |  |
| 180 | J | J180 | T5 |  |
| 180 | K | K180 | GUID formuláře (10012) je jedinečný identifikátor, který je vztažen k rozhodnému období (10011, 10010), varibilnímu symbolu (10221), jedné individualizované součásti (10228) v rámci podání s vazbou na GIUD (10001).  <br>---<br>10001 GUID podání<br>10012 GUID formuláře<br>10010 Měsíc<br>10011 Rok<br>10221 Variabilní symbol<br>10228 ID pracovněprávního vztahu (Identifikátor zaměstnání) |  |
| 180 | L | L180 | V systému nesmí existovat více řádných individualizovaných součástí se stejným GUID v rámci jednoho podání. |  |
| 180 | M | M180 | nová |  |
| 180 | N | N180 | Storno individualizované součásti zneplatní GUID. Nová řádná individualizovaná součást musí být identifikována novým jedinečným GUID. |  |
| 181 | A | A181 | 307 |  |
| 181 | B | B181 | Kontrola vyplnění dat ELDP |  |
| 181 | C | C181 |   |  |
| 181 | D | D181 | Průběh pojištění v daném měsíci |  |
| 181 | E | E181 | Formulář zaměstnance (form) |  |
| 181 | F | F181 | ePortál |  |
| 181 | G | G181 | nepropustná |  |
| 181 | H | H181 | DIS |  |
| 181 | I | I181 | nepropustná |  |
| 181 | J | J181 | F4 |  |
| 181 | K | K181 | Pokud není vyplněn atribut (10240),<br>pak atributy: (10241, 10242, 10245, 10357, 10358, 10359, 10360, 10362, 10536, 10375, 10462, 10463, 10464, 10465, 10466, 10468, 10469) nesmí nabývat hodnot.<br>---<br>10241 Platnost kódu od<br>10242 Platnost kódu do<br>10245 Vyměřovací základ<br>10357 Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.<br>10358 Počet dnů trvání dočasné pracovní neschopnosti<br>10359 Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)<br>10360 Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné<br>10362 Počet dnů čerpání otcovské<br>10536 Počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb.<br>10375 Doby odečítané po důchodovém věku - počet dnů<br>10462 Počet dnů trvání dočasné pracovní neschopnosti (karanténa)<br>10463 Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)<br>10464 Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné<br>10465 Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné <br>10466 Počet dnů čerpání otcovské<br>10468 Počet dnů čerpání neplaceného volna<br>10469 Počet dnů neomluvené absence<br>10240 Kód ELDP |  |
| 181 | L | L181 | Pokud není uveden kód ELDP, nelze vyplňovat údaje o době důchodového pojištění. |  |
| 181 | M | M181 | nová |  |
| 181 | N | N181 | Pokrytí interakce č. 35 |  |
| 182 | A | A182 | 308 |  |
| 182 | B | B182 | Kontrola částí podání ve stronovaném měsíčním hlášení |  |
| 182 | C | C182 | 10007 |  |
| 182 | D | D182 | Meta atributy |  |
| 182 | E | E182 | Měsíční podání JMHZ (global) |  |
| 182 | F | F182 | n/a |  |
| 182 | G | G182 | n/a |  |
| 182 | H | H182 | DIS |  |
| 182 | I | I182 | nepropustná |  |
| 182 | J | J182 | T5 |  |
| 182 | K | K182 | V podání typu storno (10007) = "S" se nesmí nacházet součásti: pvpoj, souhrn, individualizovaná.<br>---<br>10007 Typ podání |  |
| 182 | L | L182 | V podání typu storno (celého podání) se nesmí nacházet tyto části: pojistná část, souhrnná část, individualizovaná část. |  |
| 182 | M | M182 | nová |  |
| 183 | A | A183 | 309 |  |
| 183 | B | B183 | Uvedení trvání pojištění v daném měsíci |  |
| 183 | C | C183 | 10356<br>10375<br>10240<br>10354<br>10355<br>10243 |  |
| 183 | D | D183 | Průběh pojištění v daném měsíci |  |
| 183 | E | E183 | Formulář zaměstnance (form) |  |
| 183 | F | F183 | ePortál |  |
| 183 | G | G183 | nepropustná |  |
| 183 | H | H183 | cJMHZ |  |
| 183 | I | I183 | nepropustná |  |
| 183 | J | J183 | F5 |  |
| 183 | K | K183 | Je-li druhá pozice údaje Kód ELDP (10240) různá od "P" a "V" <br> * a zároveň třetí pozice údaje Kód ELDP (10240) různý od "T" <br> * a zároveň Malý rozsah (10243) je roven = "A" nebo třetí pozice údaje kódu je roven "S" nebo první pozice údaje Kód ELDP (10240) je z ("T", "U", "V", "W", "X", "Y", "Z"))<br> * a zároveň jsou uvedeny Odečtené doby (10375), <br> pak musí být hodnota údaje Dny započtené (10356) rovna součtu dnů z intervalu od (10354) – do (10355) mínus hodnota údaje Odečtené doby (10375).<br>---<br>10356 Počet kalendářních dnů trvání doby důchodového pojištění v daném kalendářním měsíci (Dny započtené)<br>10375 Oděčtené doby<br>10240 Kód ELDP<br>10354 Pojištění od<br>10355 Pojištění do<br>10243 Zaměstnání malého rozsahu |  |
| 183 | L | L183 | Uvedená doba trvání pojištění neodpovídá kódu ELDP. |  |
| 183 | M | M183 | nová |  |
| 183 | N | N183 | OŘ: ČSSZ-214 |  |
| 184 | A | A184 | 310 |  |
| 184 | B | B184 | Roční zúčtování záloh bylo provedeno |  |
| 184 | C | C184 | 10321<br>10322<br>10323<br>10420<br>10421<br>10422<br>10423<br>10424<br>10425<br>10426<br>10430<br>10539<br>10540<br>10541<br>10542<br>10454<br>10455<br>10441<br>10442<br>10443<br>10444<br>10445<br>10446<br>10447<br>10448<br>10449<br>10450<br>10451<br>10320 |  |
| 184 | D | D184 | Souhrnná data zaměstnance |  |
| 184 | E | E184 | Formulář zaměstnance (form) |  |
| 184 | F | F184 | ePortál |  |
| 184 | G | G184 | nepropustná |  |
| 184 | H | H184 | DIS |  |
| 184 | I | I184 | nepropustná |  |
| 184 | J | J184 | F4 |  |
| 184 | K | K184 | Pokud je atribut (10320) = "NE",<br>pak atributy: (10321, 10322, 10323, 10420, 10421, 10422, 10423, 10424, 10425, 10426, 10430, 10441, 10442, 10443, 10444, 10445, 10446, 10447, 10448, 10449, 10450, 10451, 10454, 10455, 10539, 10540, 10541, 10542) nesmí nabývat hodnot<br>---<br>10321 Přeplatek nebo nedoplatek z ročního zúčtování<br>10322 Přeplatek nebo nedoplatek z ročního zúčtování - z toho přeplatek na dani nebo nedoplatek daně<br>10323 Přeplatek nebo nedoplatek z ročního zúčtování - z toho doplatek na daňovém bonusu nebo přeplacená částka daňového bonusu zaměstnanci<br>10420 Uplatněna sleva na manželku / manžela<br>10421 Jméno manželky / manžela<br>10422 Příjmení manželky / manžela<br>10423 Rodné číslo manželky / manžela<br>10424 Datum narození manželky / manžela<br>10425 Držitelka / držitel karty ZTP/P<br>10426 Počet měsíců uplatnění slevy<br>10430 Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P<br>10539 Jméno dítěte<br>10540 Příjmení dítěte<br>10541 Datum narození dítěte<br>10542 Rodné číslo dítěte<br>10454 Uplatněno daňové zvýhodnění na děti <br>10455 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba<br>10441 Jméno<br>10442 Příjmení<br>10443 Datum narození<br>10444 Rodné číslo<br>10445 Měsíce vyživování<br>10446 Jméno<br>10447 Příjmení<br>10448 Datum narození<br>10449 Rodné číslo<br>10450 Průkaz ZTP/P v jednotlivých měsících<br>10451 Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících<br>10320 Roční zúčtování záloh bylo provedeno |  |
| 184 | L | L184 | Nebylo-li provedeno roční zúčtování záloh, pak nesmí být vyplněny atribut(y) výsledku ročního zúčtování. |  |
| 184 | M | M184 | nová |  |
| 184 | N | N184 | Pokrytí interakce č. 9 |  |
| 185 | A | A185 | 311 |  |
| 185 | B | B185 | Roční zúčtování záloh bylo provedeno v jednom měsíci |  |
| 185 | C | C185 | 10320<br>10010<br>10011 |  |
| 185 | D | D185 | Souhrnná data zaměstnance |  |
| 185 | E | E185 | Formulář zaměstnance (form) |  |
| 185 | F | F185 | ePortál |  |
| 185 | G | G185 | nepropustná |  |
| 185 | H | H185 | cJMHZ |  |
| 185 | I | I185 | nepropustná |  |
| 185 | J | J185 | F5 |  |
| 185 | K | K185 | (10320) = "ANO" může být uveden pouze v jednom měsíčním hlášení (v měsíci(10011): 1, 2, 3) za kalendářní  rok (10011).<br>Např.: pokud je uveden v únoru, pak jej nelze znovu uvést v lednu nebo v březnu.<br>---<br>10320 Roční zúčtování záloh bylo provedeno<br>10010 Měsíc<br>10011 Rok |  |
| 185 | L | L185 | Roční zúčtování záloh je možné provádět právě jednou za kalendářní rok v měsíci: leden, únor nebo březen. |  |
| 185 | M | M185 | nová |  |
| 186 | A | A186 | 312 |  |
| 186 | B | B186 | Pořadí pro určení výše daňového zvýhodnění tvoří řadu ve výsledku ročního zúčtování |  |
| 186 | C | C186 | 10451 |  |
| 186 | D | D186 | Souhrnná data zaměstnance |  |
| 186 | E | E186 | Formulář zaměstnance (form) |  |
| 186 | F | F186 | ePortál |  |
| 186 | G | G186 | nepropustná |  |
| 186 | H | H186 | DIS |  |
| 186 | I | I186 | nepropustná |  |
| 186 | J | J186 | F4 |  |
| 186 | K | K186 | Při vyplňování (10451) nelze uplatnit dítě s vyšším pořadím pokud v daném měsící nejsou uvedeny děti, které jsou uvedeny s nižším pořadím nebo s "N".<br>---<br>10451 Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících |  |
| 186 | L | L186 | Nelze uplatnit dítě s vyšším pořadím, pokud v daném měsíci nejsou uvedeny děti s nižším pořadím nebo s "N". |  |
| 186 | M | M186 | nová |  |
| 186 | N | N186 | Pro 3 děti a více je přiřazováno pořadí 1, 2, 3 a pro další dítě (4té atd.) platí, že  pořadí pro určení výše daňového zvýhodnění (10440) je 3.<br>Za dítě, na které není uplatňováno daňové zvýhodnění, je vyplněna hodnota N. |  |
| 187 | A | A187 | 315 |  |
| 187 | B | B187 | Vypočitané pojistné na soc. zabezpečení neodpovídá úhrnu vyměřovacích základů zaměstnanců. |  |
| 187 | C | C187 | 10481<br>10478<br>10479<br>10480 |  |
| 187 | D | D187 | Průběh pojištění v daném měsíci |  |
| 187 | E | E187 | Formulář zaměstnance (form) |  |
| 187 | F | F187 | ePortál |  |
| 187 | G | G187 | nepropustná |  |
| 187 | H | H187 | DIS |  |
| 187 | I | I187 | nepropustná |  |
| 187 | J | J187 | F4 |  |
| 187 | K | K187 | ="(10481) = (10478 * " & 'Parametrické konstanty'!C3  & ") + (10479 * " & 'Parametrické konstanty'!C4  & ") + (10480 * " & 'Parametrické konstanty'!C5  & ")" & CHAR(10) &<br>"Všechny mezivýpočty v závorkách se zaokrouhlují na celé koruny směrem nahoru." & CHAR(10) &<br>"---" & CHAR(10) &<br>"10481 Pojistné na sociální zabezpečení " & CHAR(10) &<br>"10478 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ" & CHAR(10) &<br>"10479 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ" & CHAR(10) &<br>"10480 Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ" |  |
| 187 | L | L187 | Pojistné na sociální zabezpečení neodpovídá vyměřovacímu základu zaměstnance. |  |
| 187 | M | M187 | nová |  |
| 188 | A | A188 | 317 |  |
| 188 | B | B188 | Výše měsíčního daň. zvýhodnění na děti |  |
| 188 | C | C188 | 10303<br>10440<br>10439 |  |
| 188 | D | D188 | Souhrnná data zaměstnance |  |
| 188 | E | E188 | Formulář zaměstnance (form) |  |
| 188 | F | F188 | ePortál |  |
| 188 | G | G188 | nepropustná |  |
| 188 | H | H188 | DIS |  |
| 188 | I | I188 | nepropustná |  |
| 188 | J | J188 | F4 |  |
| 188 | K | K188 | ="Atribut (10303) je součtem všech zvýhodnění na jednotlivé děti dle jejich pořadí (10440) - viz dílčí výpočty níže:" & CHAR(10) &<br>" a) (10440) = ""1"", pak do (10303) se přičítá částka " & 'Parametrické konstanty'!C17  & "," & CHAR(10) &<br>" b) (10440) = ""2"", pak do (10303) se přičítá částka " & 'Parametrické konstanty'!C18  & "," & CHAR(10) &<br>" c) (10440) = ""3"", pak do (10303) se přičítá částka " & 'Parametrické konstanty'!C19  & "," & CHAR(10) &<br>" d) (10440) = ""N"", pak za toto dítě není započítán do (10303) žádné zvýhodnění." & CHAR(10) &<br>"Při (10439) = ""ANO"", pak do sumy v atributu (10303) je započítán násobek x " & 'Parametrické konstanty'!C22 & " za jednotlivé dítě dle jeho pořadí." & CHAR(10) &<br>"---" & CHAR(10) &<br>"10303 Měsíční daňové zvýhodnění na děti" & CHAR(10) &<br>"10440 Pořadí pro určení výše daňového zvýhodnění" & CHAR(10) &<br>"10439 Průkaz ZTP/P" |  |
| 188 | L | L188 | Výše měsíčního daň. zvýhodnění na děti neodpovídá uvedenému pořadí vyživovaných dětí. |  |
| 188 | M | M188 | nová |  |
| 189 | A | A189 | 318 |  |
| 189 | B | B189 | Výše uvedené základní slevy na poplatníka neodpovídá legislativnímu předpisu. |  |
| 189 | C | C189 | 10299<br>10419 |  |
| 189 | D | D189 | Souhrnná data zaměstnance |  |
| 189 | E | E189 | Formulář zaměstnance (form) |  |
| 189 | F | F189 | ePortál |  |
| 189 | G | G189 | nepropustná |  |
| 189 | H | H189 | DIS |  |
| 189 | I | I189 | nepropustná |  |
| 189 | J | J189 | F4 |  |
| 189 | K | K189 | ="Pokud (10419) = ""ANO""" & CHAR(10) &<br>"pak atribut (10299) musí nabývat hodnot:" & CHAR(10) &<br>" (10299) = " & 'Parametrické konstanty'!C21  & ", nebo" & CHAR(10) &<br>" (10299) = 0" & CHAR(10) &<br>"---" & CHAR(10) &<br>"10299 Základní sleva na poplatníka" & CHAR(10) &<br>"10419 Prohlášení poplatníka daně z příjmů ze závislé činnosti" |  |
| 189 | L | L189 | Výše uvedené základní slevy na poplatníka neodpovídá legislativnímu předpisu. |  |
| 189 | M | M189 | nová |  |
| 190 | A | A190 | 321 |  |
| 190 | B | B190 | Pozitivní kontrola na vyplnění adekvátních atributů v souhrnné vrstvě zaměstnance |  |
| 190 | C | C190 | 10286<br>10416<br>10289<br>10417<br>10292<br>10293<br>10294<br>10295<br>10296<br>10418<br>10419<br>10297<br>10298<br>10299<br>10300<br>10301<br>10302<br>10303<br>10453<br>10431<br>10432<br>10433<br>10434<br>10435<br>10436<br>10437<br>10438<br>10439<br>10440<br>10304<br>10305<br>10306<br>10307<br>10308<br>10309<br>10310<br>10313<br>10317<br>10316<br>10318<br>10311<br>10312<br>10319<br>10320<br>10321<br>10322<br>10323<br>10420<br>10421<br>10422<br>10423<br>10424<br>10425<br>10426<br>10430<br>10539<br>10540<br>10541<br>10542<br>10454<br>10455<br>10441<br>10442<br>10443<br>10444<br>10445<br>10446<br>10447<br>10448<br>10449<br>10450<br>10451<br>10344<br>10116<br>10348<br>10349<br>10347<br>10347<br>10351<br>10352<br>10353<br>10482<br>10371<br>10495 |  |
| 190 | D | D190 | Souhrnná data zaměstnance |  |
| 190 | E | E190 | Formulář zaměstnance (form) |  |
| 190 | F | F190 | ePortál |  |
| 190 | G | G190 | nepropustná |  |
| 190 | H | H190 | DIS |  |
| 190 | I | I190 | nepropustná |  |
| 190 | J | J190 | F4 |  |
| 190 | K | K190 | Pokud je atribut (10495) = "ANO",<br>pak atributy: (z oblasti "Souhrnná data zaměstnance") musí dle adekvátních povinností nabývat hodnot<br>---<br>10286 Zúčtovaný příjem - celkem<br>10416 Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR<br>10289 Osvobozené příjmy ze zúčtovaných příjmů - celkem<br>10417 Příspěvek zaměstnavatele na produkty spoření na stáří a pojištění dlouhodobé péče z osvobozených příjmů - celkem<br>10292 Příspěvek na penzijní připojištění se státním příspěvkem<br>10293 Příspěvek na doplňkové penzijní spoření<br>10294 Příspěvek na penzijní pojištění<br>10295 Příspěvek na soukromé životní pojištění<br>10296 Příspěvek na dlouhodobý investiční produkt<br>10418 Příspěvek na pojištění dlouhodobé péče<br>10419 Prohlášení poplatníka daně z příjmů ze závislé činnosti<br>10297 Základ pro výpočet zálohy na daň<br>10298 Vypočtená záloha na daň<br>10299 Základní sleva na poplatníka<br>10300 Základní sleva na invaliditu (I. nebo II. Stupeň)<br>10301 Rozšířená sleva na invaliditu (III. Stupeň)<br>10302 Sleva na držitele průkazu ZTP/P<br>10303 Měsíční daňové zvýhodnění na děti<br>10453 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba<br>10431 Jméno<br>10432 Příjmení<br>10433 Datum narození<br>10434 Rodné číslo<br>10435 Jméno<br>10436 Příjmení<br>10437 Datum narození<br>10438 Rodné číslo<br>10439 Průkaz ZTP/P<br>10440 Pořadí pro určení výše daňového zvýhodnění<br>10304 Měsíční sleva na děti<br>10305 Skutečně sražená záloha na daň po uplatnění slev<br>10306 Výše vyplaceného měsíčního daňového bonusu<br>10307 Základ pro výpočet daně podle zvláštní sazby daně<br>10308 Odměna člena (nerezidenta) orgánu právnické osoby<br>10309 Skutečně sražená daň podle zvláštní sazby daně / měsíc<br>10310 Sražená záloha na daň z příjmu nerezidenta člena orgánu právnické osoby<br>10313 Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. následujícího roku - příjmy zdaněné zálohou na daň celkem<br>10317 Skutečně sražená záloha na daň z příjmů vyplacených nebo obdržených do 31.1. následujícího roku<br>10316 Doplatky příjmů zúčtovaných v minulých zdaňovacích obdobích zdanitelných v ČR zdaněné zálohou na daň vyplacené nebo obdržené do 31.1. následujícího roku<br>10318 Skutečně sražená záloha na daň z doplatků příjmů zdanitelných v ČR<br>10311 Příjmy podléhající srážkové dani podle zvláštní sazby daně vyplacené nebo obdržené do 31.1. následujícího roku<br>10312 Skutečně sražená daň vybíraná srážkou podle zvláštní sazby daně<br>10319 Zaměstnanec požádal o provedení ročního zúčtování<br>10320 Roční zúčtování záloh bylo provedeno<br>10321 Přeplatek nebo nedoplatek z ročního zúčtování<br>10322 Přeplatek nebo nedoplatek z ročního zúčtování - z toho přeplatek na dani nebo nedoplatek daně<br>10323 Přeplatek nebo nedoplatek z ročního zúčtování - z toho doplatek na daňovém bonusu nebo přeplacená částka daňového bonusu zaměstnanci<br>10420 Uplatněna sleva na manželku / manžela<br>10421 Jméno manželky / manžela<br>10422 Příjmení manželky / manžela<br>10423 Rodné číslo manželky / manžela<br>10424 Datum narození manželky / manžela<br>10425 Držitelka / držitel karty ZTP/P<br>10426 Počet měsíců uplatnění slevy<br>10430 Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P<br>10539 Jméno dítěte<br>10540 Příjmení dítěte<br>10541 Datum narození dítěte<br>10542 Rodné číslo dítěte<br>10454 Uplatněno daňové zvýhodnění na děti <br>10455 Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba<br>10441 Jméno<br>10442 Příjmení<br>10443 Datum narození<br>10444 Rodné číslo<br>10445 Měsíce vyživování<br>10446 Jméno<br>10447 Příjmení<br>10448 Datum narození<br>10449 Rodné číslo<br>10450 Průkaz ZTP/P v jednotlivých měsících<br>10451 Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících<br>10344 Čistý příjem<br>10116 Srážky na základě nařízeného soudního nebo správního výkonu rozhodnutí, konkursu nebo dohody o srážkách z příjmu<br>10348 Mzda/plat nebo jeho část vyplacena v hotovosti <br>10349 Provedeny srážky ze mzdy nebo platu určené k uspokojení plnění zaměstnavatele<br>10347 Datum úhrady mzdy včetně odvodů na soc. a zdravotní pojištění<br>10347 Srážky k uspokojení plnění zaměstnavatele podle občanského zákoníku<br>10351 Srážky k uhrazení škody, za kterou odpovídá zaměstnanec<br>10352 Srážky na závodní stravování pode §236 zákoníku práce,<br>10353 Srážky k uspokojení závazků zaměstnance podle § 146 písm. b) zákoníku práce<br>10482 Zdravotní pojištění<br>10371 Zdravotní pojištění<br>10495 Primární pracovněprávní vztah zaměstnance |  |
| 190 | L | L190 | Pokud je vyplněn primární pracovněprávní vztah zaměstnance, je nutné dle příslušných povinností doplnit hodnoty z oblasti: Souhrnná data zaměstnance. |  |
| 190 | M | M190 | nová |  |
| 191 | A | A191 | 323 |  |
| 191 | B | B191 | Kontrola datové integrity podání |  |
| 191 | D | D191 | JMHZ obecně |  |
| 191 | E | E191 | Měsíční podání JMHZ (nezarazeno) |  |
| 191 | F | F191 | n/a |  |
| 191 | G | G191 | n/a |  |
| 191 | H | H191 | cJMHZ |  |
| 191 | I | I191 | nepropustná |  |
| 191 | J | J191 | T9 |  |
| 191 | K | K191 | Obecná strukturální chyba validity dat, kdy je na vstupu uvedena hodnota, která není v souladu s očekávanou strukturou nebo pravidly datového modelu (např. nepovolená, nelogická či nečíselníková hodnota) |  |
| 191 | L | L191 | Chyba datové integrity podání |  |
| 191 | M | M191 | nová |  |
| 192 | A | A192 | 325 |  |
| 192 | B | B192 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů - zálohová daň |  |
| 192 | C | C192 | 10307<br>10309<br>10416<br>10535<br>10239 |  |
| 192 | D | D192 | Souhrnná data zaměstnance |  |
| 192 | E | E192 | Formulář zaměstnance (form) |  |
| 192 | F | F192 | ePortál |  |
| 192 | G | G192 | nepropustná |  |
| 192 | H | H192 | cJMHZ |  |
| 192 | I | I192 | nepropustná |  |
| 192 | J | J192 | F5 |  |
| 192 | K | K192 | ="Pokud (10416) není vyplněn nebo (10416) = ""0"" a" &CHAR(10)&<br>"1a) ∑ všech (10535), kde součet všech DPP za zaměstnance u zaměstnavatele (které jsou definovány (10239) = ""T-ZC"") >= "&('Parametrické konstanty'!C14)&CHAR(10)&<br>"1b) a zároveň ∑ všech (10535), které nejsou DPP (tj. (10239) se nerovná ""T-ZC"") >=  "&('Parametrické konstanty'!C13)&CHAR(10)&<br>"pak následující atributy nesmí nabývat hodnot: (10307), (10309)." & CHAR(10) &<br>"---" & CHAR(10)&<br>"10307 Základ pro výpočet daně podle zvláštní sazby daně" & CHAR(10)&<br>"10309 Skutečně sražená daň podle zvláštní sazby daně / měsíc" & CHAR(10)&<br>"10416 Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR" & CHAR(10) &<br>"10535 Základ pro výpočet daně" & CHAR(10) &<br>"10239 Druh činnosti" |  |
| 192 | L | L192 | Pro scénář, kdy je vybírána daň zálohou, nelze vyplnit atribut(y) související se srážkovou daní. |  |
| 192 | M | M192 | nová |  |
| 192 | N | N192 | od 1. 1. 2026 činí limit pro (10535) >= 12500 (pro T-ZC) |  |
| 193 | A | A193 | 326 |  |
| 193 | B | B193 | Kontrola právě jednoho řádného podání |  |
| 193 | C | C193 | 10010<br>10011<br>10221 |  |
| 193 | D | D193 | Meta atributy |  |
| 193 | E | E193 | Měsíční podání JMHZ (nezarazeno) |  |
| 193 | F | F193 | n/a |  |
| 193 | G | G193 | n/a |  |
| 193 | H | H193 | cJMHZ |  |
| 193 | I | I193 | nepropustná |  |
| 193 | J | J193 | T9 |  |
| 193 | K | K193 | V systému nesmí existovat více řádných podání k danému rozhodnému období (10011, 10010) a varibilnímu symbolu (10221).<br>Pozn.: toto neplatí v případě, kdy podání bylo zamítnuto nebo nebylo podáno (po stornu podání).<br>---<br>10010 Měsíc<br>10011 Rok<br>10221 Variabilní symbol |  |
| 193 | L | L193 | V systému nesmí existovat více řádných podání za jedno rozhodné období. |  |
| 193 | M | M193 | nová |  |
| 194 | A | A194 | 328 |  |
| 194 | B | B194 | Kontrola nevyplnění údajů při nulovém počtu dnů doby odečítané po dosažení důchodového věku |  |
| 194 | C | C194 | 10462<br>10463<br>10464<br>10465<br>10466<br>10468<br>10469<br>10375 |  |
| 194 | D | D194 | Průběh pojištění v daném měsíci |  |
| 194 | E | E194 | Formulář zaměstnance (form) |  |
| 194 | F | F194 | ePortál |  |
| 194 | G | G194 | nepropustná |  |
| 194 | H | H194 | DIS |  |
| 194 | I | I194 | nepropustná |  |
| 194 | J | J194 | F4 |  |
| 194 | K | K194 | Pokud je atribut (10375) = 0,<br>pak atributy: (10462, 10463, 10464, 10465, 10466, 10468, 10469) nesmí nabývat hodnot<br>---<br>10462 Počet dnů trvání dočasné pracovní neschopnosti (karanténa)<br>10463 Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)<br>10464 Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné<br>10465 Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné <br>10466 Počet dnů čerpání otcovské<br>10468 Počet dnů čerpání neplaceného volna<br>10469 Počet dnů neomluvené absence<br>10375 Doby odečítané po důchodovém věku - počet dnů |  |
| 194 | L | L194 | Pokud je počet kalendářních dnů doby odečítané po dosažení důchodového věku v měsíci nulový, pak se atributy o této době nevyplňují. |  |
| 194 | M | M194 | nová |  |
| 195 | A | A195 | 329 |  |
| 195 | B | B195 | Kontrola nevyplnění údajů důvodů při nulové době vyloučených dob |  |
| 195 | C | C195 | 10358<br>10359<br>10360<br>10362<br>10536<br>10357 |  |
| 195 | D | D195 | Průběh pojištění v daném měsíci |  |
| 195 | E | E195 | Formulář zaměstnance (form) |  |
| 195 | F | F195 | ePortál |  |
| 195 | G | G195 | nepropustná |  |
| 195 | H | H195 | DIS |  |
| 195 | I | I195 | nepropustná |  |
| 195 | J | J195 | F4 |  |
| 195 | K | K195 | Pokud je atribut (10357) nevyplněn  nebo (10357) = 0,<br>pak atributy: (10358, 10359, 10360, 10362, 10536) nesmí nabývat hodnot<br>---<br>10358 Počet dnů trvání dočasné pracovní neschopnosti<br>10359 Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)<br>10360 Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné<br>10362 Počet dnů čerpání otcovské<br>10536 Počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb.<br>10357 Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb. |  |
| 195 | L | L195 | Pokud nejsou vykázány žádné vyloučené doby, pak se údaje o omluvných důvodech nevyplňují. |  |
| 195 | M | M195 | nová |  |
| 196 | A | A196 | 330 |  |
| 196 | B | B196 | Kontrola povinnosti uvedení kódu ELDP při započtených dnech důchodového pojištění |  |
| 196 | D | D196 | Průběh pojištění v daném měsíci |  |
| 196 | E | E196 | Formulář zaměstnance (form) |  |
| 196 | F | F196 | ePortál |  |
| 196 | G | G196 | nepropustná |  |
| 196 | H | H196 | DIS |  |
| 196 | I | I196 | nepropustná |  |
| 196 | J | J196 | F4 |  |
| 196 | K | K196 | Pokud (10356) > 0,<br>pak (10240) musí nabývat hodnot.<br>---<br>10240 Kód ELDP<br>10356 Počet kalendářních dnů trvání doby důchodového pojištění v daném kalendářním měsíci (Započtené dny) |  |
| 196 | L | L196 | Pokud jsou vyplněny započtené dny důchodového pojištění, musí být uveden i kód ELDP. |  |
| 196 | M | M196 | nová |  |
| 197 | A | A197 | 331 |  |
| 197 | B | B197 | Typ Odloženého příjmu |  |
| 197 | C | C197 | 10548 |  |
| 197 | D | D197 | Meta atributy |  |
| 197 | E | E197 | Formulář zaměstnance (form) |  |
| 197 | F | F197 | ePortál |  |
| 197 | G | G197 | nepropustná |  |
| 197 | H | H197 | DIS |  |
| 197 | I | I197 | nepropustná |  |
| 197 | J | J197 | F4 |  |
| 197 | K | K197 | Hodnota musí být z číselníku.<br>---<br>10548 Typ Odloženého příjmu |  |
| 197 | L | L197 | ="Hodnota " & B197 & " neodpovídá číselníku." |  |
| 197 | M | M197 | nová |  |
| 198 | A | A198 | 332 |  |
| 198 | B | B198 | Povinnost atributu primární pracovněprávní pravní vztah zaměstnance v jednotlivých dat. scénářích |  |
| 198 | C | C198 | 10495 |  |
| 198 | D | D198 | Meta atributy |  |
| 198 | E | E198 | Formulář zaměstnance (form) |  |
| 198 | F | F198 | ePortál |  |
| 198 | G | G198 | nepropustná |  |
| 198 | H | H198 | DIS |  |
| 198 | I | I198 | nepropustná |  |
| 198 | J | J198 | F4 |  |
| 198 | K | K198 | Pro datový scénář pro druh činnosti 10 tedy: formOzpTpp.xsd je (10495) nepovinný,<br>pro všechny ostatní je (10495) povinný.<br>---<br>10495 Primární pracovněprávní vztah zaměstnance |  |
| 198 | L | L198 | Ve formuláři chybí povinný atribut primární pracovněprávní vztah zaměstnance. |  |
| 198 | M | M198 | nová |  |
| 199 | A | A199 | 333 |  |
| 199 | B | B199 | Časové omezení uplatnění slevy na pojistném (01–03/2026) |  |
| 199 | C | C199 | 10006<br>10032<br>10016 |  |
| 199 | D | D199 | Přehled o výši pojistného |  |
| 199 | E | E199 | Formulář PVPOJ (pvpoj) |  |
| 199 | F | F199 | ePortál |  |
| 199 | G | G199 | nepropustná |  |
| 199 | H | H199 | DIS |  |
| 199 | I | I199 | nepropustná |  |
| 199 | J | J199 | F4 |  |
| 199 | K | K199 | Pokud je (10016) = "R" a současně (10032) > 0 a (10006) > 30. 6. 2026, pak slevu na pojistném nelze uplatnit. Platí jen pro podání za měsíce 01-03/2026.<br>---<br>10006 Datum a čas přijetí podání<br>10032 Sleva na pojistném zaměstnavatele<br>10016 Typ formuláře<br> |  |
| 199 | L | L199 | Slevu na pojistném zaměstnavatele za měsíce leden, únor a březen 2026 uplatňuje zaměstnavatel jejím odečtením od pojistného. Nedílnou součástí je však vykázání uplatněné slevy v měsíčním hlášení za tyto měsíce v souladu s platnou právním úpravou, tj. tato měsíční hlášení měla být podána nejpozději do 30. 6. 2026. Vykázání slevy na pojistném zaměstnavatele po uplynutí této lhůty nelze považovat za její řádné uplatnění. |  |
| 199 | M | M199 | nová |  |
| 200 | A | A200 | 334 |  |
| 200 | B | B200 | Kontrola ztotožnění |  |
| 200 | C | C200 | 10053<br>10054<br>10056<br>10223<br>10239<br>10221<br> |  |
| 200 | D | D200 | Zaměstnanec / Žák / Student  |  |
| 200 | E | E200 | Formulář zaměstnance (form) |  |
| 200 | F | F200 | n/a |  |
| 200 | G | G200 | n/a |  |
| 200 | H | H200 | DIS |  |
| 200 | I | I200 | nepropustná |  |
| 200 | J | J200 | F2 |  |
| 200 | K | K200 | Kontrola ztotožnění dle identifikace (10053, 10054, 10056, 10223, 10239, 10221)<br>---<br>10053 Příjmení<br>10054 Jméno<br>10056 Datum narození<br>10223 Datum nástupu do zaměstnání<br>10239 Druh činnosti<br>10221 Variabilní symbol |  |
| 200 | L | L200 | Dle identifikačních údajů nedošlo na systémech ČSSZ ke ztotožnění. |  |
| 200 | M | M200 | nová |  |
| 201 | A | A201 | 335 |  |
| 201 | B | B201 | Kontrola správnosti atributu Obec |  |
| 201 | C | C201 | 10229 |  |
| 201 | D | D201 | Vykonávaná pozice zaměstnance |  |
| 201 | E | E201 | Formulář zaměstnance (form) |  |
| 201 | F | F201 | ePortál |  |
| 201 | G | G201 | nepropustná |  |
| 201 | H | H201 | DIS |  |
| 201 | I | I201 | nepropustná |  |
| 201 | J | J201 | F4 |  |
| 201 | K | K201 | Hodnota atributu Obec musí být z číselníku CISOB<br>---<br>10229 Obec |  |
| 201 | L | L201 | Hodnota atributu Obec neodpovídá tvaru v číselníku. |  |
| 201 | M | M201 | nová |  |
| 201 | N | N201 | CISOB |  |

- Počet uvedených buněk (nenulová hodnota a/nebo komentář): **2659**

---

## List: Changelog
- Rozsah listu dle `dimensions`: `A1:H500`

| Řádek | Sloupec | Buňka | Hodnota | Komentář |
|---:|:---:|:---:|---|---|
| 1 | A | A1 | DATUM ZMĚNY |  |
| 1 | B | B1 | VERZE |  |
| 1 | C | C1 | ZMĚNOVÝ POŽADAVEK |  |
| 1 | D | D1 | ID KONTROLY |  |
| 1 | E | E1 | NÁZEV<br>KONROLY |  |
| 1 | F | F1 | DOTČENÝ<br>SYSTÉM |  |
| 1 | G | G1 | TYP ZMĚNY<br><br>[změna kontroly \| odstranění kontroly \| přidání kontroly \| změna] |  |
| 1 | H | H1 | POPIS ZMĚNY |  |
| 2 | A | A2 | 2025-03-12 00:00:00 |  |
| 2 | B | B2 | 1.3 |  |
| 2 | C | C2 | n/a |  |
| 2 | D | D2 | 1 |  |
| 2 | E | E2 | =_xlfn.IFNA(VLOOKUP(D2,MH!A$2:N$547,2,TRUE),"") |  |
| 2 | F | F2 | =_xlfn.IFNA(VLOOKUP(D2,MH!A$2:N$547,7,TRUE),"") |  |
| 2 | G | G2 | změna kontroly |  |
| 2 | H | H2 | 10030 Počet zaměstnanců<br>10371 Zdravotní pojištění<br>10372 Sleva na pojistném<br><br>změna těla funkce, kontrola počtu zam. s příznakem 10372 = ANO, že je menší rovno 10030 zam. Celkem |  |
| 3 | A | A3 | 2025-03-12 00:00:00 |  |
| 3 | B | B3 | 1.3 |  |
| 3 | C | C3 | n/a |  |
| 3 | D | D3 | 174 |  |
| 3 | E | E3 | Kontrola úhrnu vyměřovacích základů zaměstnanců, které vstupují do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ |  |
| 3 | F | F3 | cJMHZ |  |
| 3 | G | G3 | odstranění kontroly |  |
| 3 | H | H3 | duplicita s id 7 |  |
| 4 | A | A4 | 2025-03-12 00:00:00 |  |
| 4 | B | B4 | 1.3 |  |
| 4 | C | C4 | n/a |  |
| 4 | D | D4 | 175 |  |
| 4 | E | E4 | Kontrola úhrnu vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ |  |
| 4 | F | F4 | cJMHZ |  |
| 4 | G | G4 | odstranění kontroly |  |
| 4 | H | H4 | duplicita s id 9 |  |
| 5 | A | A5 | 2025-03-12 00:00:00 |  |
| 5 | B | B5 | 1.3 |  |
| 5 | C | C5 | n/a |  |
| 5 | D | D5 | 176 |  |
| 5 | E | E5 | Kontrola úhrnu vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ |  |
| 5 | F | F5 | cJMHZ |  |
| 5 | G | G5 | odstranění kontroly |  |
| 5 | H | H5 | duplicita s id 142 |  |
| 6 | A | A6 | 2025-03-12 00:00:00 |  |
| 6 | B | B6 | 1.3 |  |
| 6 | C | C6 | n/a |  |
| 6 | D | D6 | 177 |  |
| 6 | E | E6 | Kontrola úhrnu pojistného za zaměstnance |  |
| 6 | F | F6 | cJMHZ |  |
| 6 | G | G6 | odstranění kontroly |  |
| 6 | H | H6 | duplicita s id 12 |  |
| 7 | A | A7 | 2025-03-12 00:00:00 |  |
| 7 | B | B7 | 1.3 |  |
| 7 | C | C7 | n/a |  |
| 7 | D | D7 | 181 |  |
| 7 | E | E7 | Počet zaměstnanců, za které zaměstnavatel uplatňuje slevu na pojistném zaměstnavatele |  |
| 7 | F | F7 | cJMHZ |  |
| 7 | G | G7 | odstranění kontroly |  |
| 7 | H | H7 | duplicita s id 1 |  |
| 8 | A | A8 | 2025-03-12 00:00:00 |  |
| 8 | B | B8 | 1.3 |  |
| 8 | C | C8 | n/a |  |
| 8 | D | D8 | 193 |  |
| 8 | E | E8 | =_xlfn.IFNA(VLOOKUP(D8,MH!A$2:N$547,2,TRUE),"") |  |
| 8 | F | F8 | =_xlfn.IFNA(VLOOKUP(D8,MH!A$2:N$547,7,TRUE),"") |  |
| 8 | G | G8 | změna kontroly |  |
| 8 | H | H8 | změna chyb. hlášky "Atribut [XY] může být uveden jen v prosincovémlednovém podání." |  |
| 9 | A | A9 | 2025-03-17 00:00:00 |  |
| 9 | B | B9 | 1.3 |  |
| 9 | C | C9 | n/a |  |
| 9 | D | D9 | 95 |  |
| 9 | E | E9 | =_xlfn.IFNA(VLOOKUP(D9,MH!A$2:N$547,2,TRUE),"") |  |
| 9 | F | F9 | =_xlfn.IFNA(VLOOKUP(D9,MH!A$2:N$547,7,TRUE),"") |  |
| 9 | G | G9 | změna kontroly |  |
| 9 | H | H9 | změna chyb. hlášky - Sjednaný místo Stanovený |  |
| 10 | A | A10 | 2025-03-17 00:00:00 |  |
| 10 | B | B10 | 1.3 |  |
| 10 | C | C10 | n/a |  |
| 10 | D | D10 | 98 |  |
| 10 | E | E10 | =_xlfn.IFNA(VLOOKUP(D10,MH!A$2:N$547,2,TRUE),"") |  |
| 10 | F | F10 | =_xlfn.IFNA(VLOOKUP(D10,MH!A$2:N$547,7,TRUE),"") |  |
| 10 | G | G10 | změna kontroly |  |
| 10 | H | H10 | přidán rok (10011) kvůli vyhodnocení přestupných roků |  |
| 11 | A | A11 | 2025-03-17 00:00:00 |  |
| 11 | B | B11 | 1.3 |  |
| 11 | C | C11 | n/a |  |
| 11 | E | E11 | =_xlfn.IFNA(VLOOKUP(D11,MH!A$2:N$547,2,TRUE),"") |  |
| 11 | F | F11 | =_xlfn.IFNA(VLOOKUP(D11,MH!A$2:N$547,6,TRUE),"") |  |
| 11 | G | G11 | změna kontroly |  |
| 11 | H | H11 | přidání sloupce pro identifikaci prevalidace na straně e-portálu |  |
| 12 | A | A12 | 2025-03-19 00:00:00 |  |
| 12 | B | B12 | 1.3 |  |
| 12 | C | C12 | n/a |  |
| 12 | D | D12 | 84 |  |
| 12 | E | E12 | =_xlfn.IFNA(VLOOKUP(D12,MH!A$2:N$547,2,TRUE),"") |  |
| 12 | F | F12 | =_xlfn.IFNA(VLOOKUP(D12,MH!A$2:N$547,7,TRUE),"") |  |
| 12 | G | G12 | změna kontroly |  |
| 12 | H | H12 | Změna kategorie kontroly z F4 na T5 |  |
| 13 | A | A13 | 2025-03-19 00:00:00 |  |
| 13 | B | B13 | 1.3 |  |
| 13 | C | C13 | n/a |  |
| 13 | D | D13 | 88 |  |
| 13 | E | E13 | =_xlfn.IFNA(VLOOKUP(D13,MH!A$2:N$547,2,TRUE),"") |  |
| 13 | F | F13 | =_xlfn.IFNA(VLOOKUP(D13,MH!A$2:N$547,7,TRUE),"") |  |
| 13 | G | G13 | změna kontroly |  |
| 13 | H | H13 | Změna kategorie kontroly z F4 na T6 |  |
| 14 | A | A14 | 2025-03-19 00:00:00 |  |
| 14 | B | B14 | 1.3 |  |
| 14 | C | C14 | n/a |  |
| 14 | D | D14 | 90 |  |
| 14 | E | E14 | =_xlfn.IFNA(VLOOKUP(D14,MH!A$2:N$547,2,TRUE),"") |  |
| 14 | F | F14 | =_xlfn.IFNA(VLOOKUP(D14,MH!A$2:N$547,7,TRUE),"") |  |
| 14 | G | G14 | změna kontroly |  |
| 14 | H | H14 | Změna kategorie kontroly z F4 na T6 |  |
| 15 | A | A15 | 2025-03-19 00:00:00 |  |
| 15 | B | B15 | 1.3 |  |
| 15 | C | C15 | n/a |  |
| 15 | D | D15 | 91 |  |
| 15 | E | E15 | =_xlfn.IFNA(VLOOKUP(D15,MH!A$2:N$547,2,TRUE),"") |  |
| 15 | F | F15 | =_xlfn.IFNA(VLOOKUP(D15,MH!A$2:N$547,7,TRUE),"") |  |
| 15 | G | G15 | změna kontroly |  |
| 15 | H | H15 | Změna kategorie kontroly z F4 na T6 |  |
| 16 | A | A16 | 2025-03-19 00:00:00 |  |
| 16 | B | B16 | 1.3 |  |
| 16 | C | C16 | n/a |  |
| 16 | D | D16 | 93 |  |
| 16 | E | E16 | =_xlfn.IFNA(VLOOKUP(D16,MH!A$2:N$547,2,TRUE),"") |  |
| 16 | F | F16 | =_xlfn.IFNA(VLOOKUP(D16,MH!A$2:N$547,7,TRUE),"") |  |
| 16 | G | G16 | změna kontroly |  |
| 16 | H | H16 | Změna kategorie kontroly z F4 na T5 |  |
| 17 | A | A17 | 2025-03-19 00:00:00 |  |
| 17 | B | B17 | 1.3 |  |
| 17 | C | C17 | n/a |  |
| 17 | D | D17 | 129 |  |
| 17 | E | E17 | =_xlfn.IFNA(VLOOKUP(D17,MH!A$2:N$547,2,TRUE),"") |  |
| 17 | F | F17 | =_xlfn.IFNA(VLOOKUP(D17,MH!A$2:N$547,7,TRUE),"") |  |
| 17 | G | G17 | změna kontroly |  |
| 17 | H | H17 | Změna kategorie kontroly z F4 na T6 |  |
| 18 | A | A18 | 2025-03-19 00:00:00 |  |
| 18 | B | B18 | 1.3 |  |
| 18 | C | C18 | n/a |  |
| 18 | D | D18 | 131 |  |
| 18 | E | E18 | =_xlfn.IFNA(VLOOKUP(D18,MH!A$2:N$547,2,TRUE),"") |  |
| 18 | F | F18 | =_xlfn.IFNA(VLOOKUP(D18,MH!A$2:N$547,7,TRUE),"") |  |
| 18 | G | G18 | změna kontroly |  |
| 18 | H | H18 | Změna kategorie kontroly z F4 na T6 |  |
| 19 | A | A19 | 2025-03-19 00:00:00 |  |
| 19 | B | B19 | 1.3 |  |
| 19 | C | C19 | n/a |  |
| 19 | D | D19 | 132 |  |
| 19 | E | E19 | =_xlfn.IFNA(VLOOKUP(D19,MH!A$2:N$547,2,TRUE),"") |  |
| 19 | F | F19 | =_xlfn.IFNA(VLOOKUP(D19,MH!A$2:N$547,7,TRUE),"") |  |
| 19 | G | G19 | změna kontroly |  |
| 19 | H | H19 | Změna kategorie kontroly z F4 na T6 |  |
| 20 | A | A20 | 2025-03-19 00:00:00 |  |
| 20 | B | B20 | 1.3 |  |
| 20 | C | C20 | n/a |  |
| 20 | D | D20 | 143 |  |
| 20 | E | E20 | =_xlfn.IFNA(VLOOKUP(D20,MH!A$2:N$547,2,TRUE),"") |  |
| 20 | F | F20 | =_xlfn.IFNA(VLOOKUP(D20,MH!A$2:N$547,7,TRUE),"") |  |
| 20 | G | G20 | změna kontroly |  |
| 20 | H | H20 | Změna kategorie kontroly z F4 na T5, změna chybové hlášky z "Variabilní symbol není vyplněn." |  |
| 21 | A | A21 | 2025-03-19 00:00:00 |  |
| 21 | B | B21 | 1.3 |  |
| 21 | C | C21 | n/a |  |
| 21 | D | D21 | 146 |  |
| 21 | E | E21 | =_xlfn.IFNA(VLOOKUP(D21,MH!A$2:N$547,2,TRUE),"") |  |
| 21 | F | F21 | =_xlfn.IFNA(VLOOKUP(D21,MH!A$2:N$547,7,TRUE),"") |  |
| 21 | G | G21 | změna kontroly |  |
| 21 | H | H21 | Změna kategorie kontroly z F4 na T5 |  |
| 22 | A | A22 | 2025-03-19 00:00:00 |  |
| 22 | B | B22 | 1.3 |  |
| 22 | C | C22 | n/a |  |
| 22 | D | D22 | 147 |  |
| 22 | E | E22 | Finanční úřad |  |
| 22 | F | F22 | =_xlfn.IFNA(VLOOKUP(D22,MH!A$2:N$547,7,TRUE),"") |  |
| 22 | G | G22 | změna kontroly |  |
| 22 | H | H22 | Změna kategorie kontroly z F4 na T5 |  |
| 23 | A | A23 | 2025-03-19 00:00:00 |  |
| 23 | B | B23 | 1.3 |  |
| 23 | C | C23 | n/a |  |
| 23 | D | D23 | 232 |  |
| 23 | E | E23 | =_xlfn.IFNA(VLOOKUP(D23,MH!A$2:N$547,2,TRUE),"") |  |
| 23 | F | F23 | =_xlfn.IFNA(VLOOKUP(D23,MH!A$2:N$547,7,TRUE),"") |  |
| 23 | G | G23 | přidání kontroly |  |
| 23 | H | H23 | přidání kontrol struktury |  |
| 24 | A | A24 | 2025-03-19 00:00:00 |  |
| 24 | B | B24 | 1.3 |  |
| 24 | C | C24 | n/a |  |
| 24 | D | D24 | 233 |  |
| 24 | E | E24 | =_xlfn.IFNA(VLOOKUP(D24,MH!A$2:N$547,2,TRUE),"") |  |
| 24 | F | F24 | =_xlfn.IFNA(VLOOKUP(D24,MH!A$2:N$547,7,TRUE),"") |  |
| 24 | G | G24 | přidání kontroly |  |
| 24 | H | H24 | přidání kontrol struktury |  |
| 25 | A | A25 | 2025-03-19 00:00:00 |  |
| 25 | B | B25 | 1.3 |  |
| 25 | C | C25 | n/a |  |
| 25 | D | D25 | 234 |  |
| 25 | E | E25 | Struktura storno hlášení |  |
| 25 | F | F25 | DIS |  |
| 25 | G | G25 | přidání kontroly |  |
| 25 | H | H25 | přidání kontrol struktury |  |
| 26 | A | A26 | 2025-03-19 00:00:00 |  |
| 26 | B | B26 | 1.3 |  |
| 26 | C | C26 | n/a |  |
| 26 | D | D26 | 235 |  |
| 26 | E | E26 | =_xlfn.IFNA(VLOOKUP(D26,MH!A$2:N$547,2,TRUE),"") |  |
| 26 | F | F26 | DIS |  |
| 26 | G | G26 | přidání kontroly |  |
| 26 | H | H26 | přidání kontrol struktury |  |
| 27 | A | A27 | 2025-03-19 00:00:00 |  |
| 27 | B | B27 | 1.3 |  |
| 27 | C | C27 | n/a |  |
| 27 | D | D27 | 236 |  |
| 27 | E | E27 | =_xlfn.IFNA(VLOOKUP(D27,MH!A$2:N$547,2,TRUE),"") |  |
| 27 | F | F27 | =_xlfn.IFNA(VLOOKUP(D27,MH!A$2:N$547,7,TRUE),"") |  |
| 27 | G | G27 | přidání kontroly |  |
| 27 | H | H27 | přidání kontrol struktury |  |
| 28 | A | A28 | 2025-03-19 00:00:00 |  |
| 28 | B | B28 | 1.3 |  |
| 28 | C | C28 | n/a |  |
| 28 | D | D28 | 237 |  |
| 28 | E | E28 | =_xlfn.IFNA(VLOOKUP(D28,MH!A$2:N$547,2,TRUE),"") |  |
| 28 | F | F28 | =_xlfn.IFNA(VLOOKUP(D28,MH!A$2:N$547,7,TRUE),"") |  |
| 28 | G | G28 | přidání kontroly |  |
| 28 | H | H28 | přidání kontrol struktury |  |
| 29 | A | A29 | 2025-03-20 00:00:00 |  |
| 29 | B | B29 | 1.3 |  |
| 29 | C | C29 | n/a |  |
| 29 | D | D29 | 213 |  |
| 29 | E | E29 | Kontrola uplatnění slevy za zaměstnance u jednoho zaměstnavatele je pouze jednou |  |
| 29 | F | F29 | =_xlfn.IFNA(VLOOKUP(D29,MH!A$2:N$547,7,TRUE),"") |  |
| 29 | G | G29 | změna kontroly |  |
| 29 | H | H29 | vylepšen detail kontroly  (p. MS) |  |
| 30 | A | A30 | 2025-03-20 00:00:00 |  |
| 30 | B | B30 | 1.3 |  |
| 30 | C | C30 | n/a |  |
| 30 | D | D30 | 231 |  |
| 30 | E | E30 | Kontrola uplatnění slevy za zaměstnance u jednoho zaměstnavatele je pouze jednou |  |
| 30 | F | F30 | cJMHZ |  |
| 30 | G | G30 | přidání kontroly |  |
| 30 | H | H30 | Kontrola uplatnění slevy za zaměstnance u jednoho zaměstnavatele, je pouze jednou. |  |
| 31 | A | A31 | 2025-03-20 00:00:00 |  |
| 31 | B | B31 | 1.3 |  |
| 31 | C | C31 | n/a |  |
| 31 | D | D31 | 238 |  |
| 31 | E | E31 | =_xlfn.IFNA(VLOOKUP(D31,MH!A$2:N$547,2,TRUE),"") |  |
| 31 | F | F31 | =_xlfn.IFNA(VLOOKUP(D31,MH!A$2:N$547,7,TRUE),"") |  |
| 31 | G | G31 | přidání kontroly |  |
| 31 | H | H31 | Kontrola konzistence klíčů GUID, ikmpsv, idppv v části individualizované části při změně dat |  |
| 32 | A | A32 | 2025-03-20 00:00:00 |  |
| 32 | B | B32 | 1.3 |  |
| 32 | C | C32 | n/a |  |
| 32 | D | D32 | 239 |  |
| 32 | E | E32 | Kontrola vyplnění atributů ke kolektivním smlouvám, při neexistenci smlouvy |  |
| 32 | F | F32 | =_xlfn.IFNA(VLOOKUP(D32,MH!A$2:N$547,7,TRUE),"") |  |
| 32 | G | G32 | přidání kontroly |  |
| 32 | H | H32 | Kontrola vyplnění atributů ke kolektivním smlouvám, při neexistenci smlouvy (podnět M. Hal.) - logická kontrola |  |
| 33 | A | A33 | 2025-03-21 00:00:00 |  |
| 33 | B | B33 | 1.3 |  |
| 33 | C | C33 | n/a |  |
| 33 | D | D33 | 98 |  |
| 33 | E | E33 | =_xlfn.IFNA(VLOOKUP(D33,MH!A$2:N$547,2,TRUE),"") |  |
| 33 | F | F33 | =_xlfn.IFNA(VLOOKUP(D33,MH!A$2:N$547,7,TRUE),"") |  |
| 33 | G | G33 | změna kontroly |  |
| 33 | H | H33 | na základě telka s pí. Madarovou a pí Kotíkovou, potvrzeno a odsouhlaseno přídání art.: 10357, 10360, 10362 a nově 10463 |  |
| 34 | A | A34 | 2025-03-21 00:00:00 |  |
| 34 | B | B34 | 1.3 |  |
| 34 | C | C34 | n/a |  |
| 34 | D | D34 | 145 |  |
| 34 | E | E34 | =_xlfn.IFNA(VLOOKUP(D34,MH!A$2:N$547,2,TRUE),"") |  |
| 34 | F | F34 | =_xlfn.IFNA(VLOOKUP(D34,MH!A$2:N$547,7,TRUE),"") |  |
| 34 | G | G34 | změna kontroly |  |
| 34 | H | H34 | oprava detailu, oprava chyb. Hlášky (M. Hal.) |  |
| 35 | A | A35 | 2025-03-21 00:00:00 |  |
| 35 | B | B35 | 1.3 |  |
| 35 | C | C35 | n/a |  |
| 35 | D | D35 | 208 |  |
| 35 | E | E35 | =_xlfn.IFNA(VLOOKUP(D35,MH!A$2:N$547,2,TRUE),"") |  |
| 35 | F | F35 | =_xlfn.IFNA(VLOOKUP(D35,MH!A$2:N$547,7,TRUE),"") |  |
| 35 | G | G35 | přidání kontroly |  |
| 35 | H | H35 | logická kontrola |  |
| 36 | A | A36 | 2025-03-21 00:00:00 |  |
| 36 | B | B36 | 1.3 |  |
| 36 | C | C36 | n/a |  |
| 36 | D | D36 | 209 |  |
| 36 | E | E36 | =_xlfn.IFNA(VLOOKUP(D36,MH!A$2:N$547,2,TRUE),"") |  |
| 36 | F | F36 | =_xlfn.IFNA(VLOOKUP(D36,MH!A$2:N$547,7,TRUE),"") |  |
| 36 | G | G36 | změna kontroly |  |
| 36 | H | H36 | vylepšen detail kontroly  (M. Sm.) |  |
| 37 | A | A37 | 2025-03-21 00:00:00 |  |
| 37 | B | B37 | 1.3 |  |
| 37 | C | C37 | n/a |  |
| 37 | D | D37 | 238 |  |
| 37 | E | E37 | =_xlfn.IFNA(VLOOKUP(D37,MH!A$2:N$547,2,TRUE),"") |  |
| 37 | F | F37 | =_xlfn.IFNA(VLOOKUP(D37,MH!A$2:N$547,7,TRUE),"") |  |
| 37 | G | G37 | změna kontroly |  |
| 37 | H | H37 | po konzultaci s M. Kal. uveden větší detail kontroly |  |
| 38 | A | A38 | 2025-03-23 00:00:00 |  |
| 38 | B | B38 | 1.3 |  |
| 38 | C | C38 | n/a |  |
| 38 | D | D38 | 1 |  |
| 38 | E | E38 | =_xlfn.IFNA(VLOOKUP(D38,MH!A$2:N$547,2,TRUE),"") |  |
| 38 | F | F38 | =_xlfn.IFNA(VLOOKUP(D38,MH!A$2:N$547,7,TRUE),"") |  |
| 38 | G | G38 | změna kontroly |  |
| 38 | H | H38 | Počet zaměstnanců, za které zaměstnavatel uplatňuje slevu na pojistném s vyplněnými údaji jednotlivých zaměstnanců (1037110372) = "ANO" musí být <= Počet zaměstnanců (10030). |  |
| 39 | A | A39 | 2025-03-24 00:00:00 |  |
| 39 | B | B39 | 1.3 |  |
| 39 | C | C39 | n/a |  |
| 39 | D | D39 | 42 |  |
| 39 | E | E39 | =_xlfn.IFNA(VLOOKUP(D39,MH!A$2:N$547,2,TRUE),"") |  |
| 39 | F | F39 | =_xlfn.IFNA(VLOOKUP(D39,MH!A$2:N$547,7,TRUE),"") |  |
| 39 | G | G39 | přidání kontroly |  |
| 39 | H | H39 | přidáno, inicioval TH a JK<br><br>Atributy (10372), (10373), (10374) mohou nabývat hodnot jen, když (10239) je v rozmezí 1 až 9.<br>---<br>10372 Sleva na pojistném zaměstnavatele<br>10373 Rozsah kratší pracovní/služební doby<br>10374 Důvod uplatnění slevy<br>10239 Druh činnosti |  |
| 40 | A | A40 | 2025-03-24 00:00:00 |  |
| 40 | B | B40 | 1.3 |  |
| 40 | C | C40 | n/a |  |
| 40 | D | D40 | 45 |  |
| 40 | E | E40 | =_xlfn.IFNA(VLOOKUP(D40,MH!A$2:N$547,2,TRUE),"") |  |
| 40 | F | F40 | =_xlfn.IFNA(VLOOKUP(D40,MH!A$2:N$547,7,TRUE),"") |  |
| 40 | G | G40 | změna kontroly |  |
| 40 | H | H40 | přidána vstupní podmínka (10239) = 1 až 9<br>na základě konzultace p. DM a TH<br> |  |
| 41 | A | A41 | 2025-03-24 00:00:00 |  |
| 41 | B | B41 | 1.3 |  |
| 41 | C | C41 | n/a |  |
| 41 | D | D41 | 137 |  |
| 41 | E | E41 | =_xlfn.IFNA(VLOOKUP(D41,MH!A$2:N$547,2,TRUE),"") |  |
| 41 | F | F41 | =_xlfn.IFNA(VLOOKUP(D41,MH!A$2:N$547,7,TRUE),"") |  |
| 41 | G | G41 | změna kontroly |  |
| 41 | H | H41 | přidána vstupní podmínka (10239) = 1 až 9<br>na základě konzultace p. DM a TH |  |
| 42 | A | A42 | 2025-03-24 00:00:00 |  |
| 42 | B | B42 | 1.3 |  |
| 42 | C | C42 | n/a |  |
| 42 | D | D42 | 138 |  |
| 42 | E | E42 | =_xlfn.IFNA(VLOOKUP(D42,MH!A$2:N$547,2,TRUE),"") |  |
| 42 | F | F42 | =_xlfn.IFNA(VLOOKUP(D42,MH!A$2:N$547,7,TRUE),"") |  |
| 42 | G | G42 | změna kontroly |  |
| 42 | H | H42 | formalita, úprava seznamu atributů |  |
| 43 | A | A43 | 2025-03-24 00:00:00 |  |
| 43 | B | B43 | 1.3 |  |
| 43 | C | C43 | n/a |  |
| 43 | D | D43 | 138 |  |
| 43 | E | E43 | =_xlfn.IFNA(VLOOKUP(D43,MH!A$2:N$547,2,TRUE),"") |  |
| 43 | F | F43 | =_xlfn.IFNA(VLOOKUP(D43,MH!A$2:N$547,7,TRUE),"") |  |
| 43 | G | G43 | změna kontroly |  |
| 43 | H | H43 | přidána vstupní podmínka (10239) = 1 až 9<br>na základě konzultace p. DM a TH |  |
| 44 | A | A44 | 2025-03-24 00:00:00 |  |
| 44 | B | B44 | 1.3 |  |
| 44 | C | C44 | n/a |  |
| 44 | D | D44 | 202 |  |
| 44 | E | E44 | Průběh pojištění v daném měsíci |  |
| 44 | F | F44 | DIS |  |
| 44 | G | G44 | změna kontroly |  |
| 44 | H | H44 | přidán větší detail kontroly, přidána vstupní podmínka<br>na základě konzultace p. DM a TH |  |
| 45 | A | A45 | 2025-03-24 00:00:00 |  |
| 45 | B | B45 | 1.3 |  |
| 45 | C | C45 | n/a |  |
| 45 | D | D45 | 212 |  |
| 45 | E | E45 | Rozsah kratší pracovní/služební doby je max 30 |  |
| 45 | F | F45 | DIS |  |
| 45 | G | G45 | odstranění kontroly |  |
| 45 | H | H45 | odstraněna kontrola 212, byla redundantní s 45 |  |
| 46 | A | A46 | 2025-03-26 00:00:00 |  |
| 46 | B | B46 | 1.3 |  |
| 46 | C | C46 | n/a |  |
| 46 | D | D46 | 234 |  |
| 46 | E | E46 | Struktura storno hlášení |  |
| 46 | F | F46 | DIS |  |
| 46 | G | G46 | odstranění kontroly |  |
| 46 | H | H46 | kontrola nahrazena id 240 |  |
| 47 | A | A47 | 2025-03-26 00:00:00 |  |
| 47 | B | B47 | 1.3 |  |
| 47 | C | C47 | n/a |  |
| 47 | D | D47 | 240 |  |
| 47 | E | E47 | =_xlfn.IFNA(VLOOKUP(D47,MH!A$2:N$547,2,TRUE),"") |  |
| 47 | F | F47 | =_xlfn.IFNA(VLOOKUP(D47,MH!A$2:N$547,7,TRUE),"") |  |
| 47 | G | G47 | přidání kontroly |  |
| 47 | H | H47 | detail pro storno celého podání |  |
| 48 | A | A48 | 2025-03-26 00:00:00 |  |
| 48 | B | B48 | 1.3 |  |
| 48 | C | C48 | n/a |  |
| 48 | D | D48 | 241 |  |
| 48 | E | E48 | =_xlfn.IFNA(VLOOKUP(D48,MH!A$2:N$547,2,TRUE),"") |  |
| 48 | F | F48 | cJMHZ |  |
| 48 | G | G48 | přidání kontroly |  |
| 48 | H | H48 | detail pro storno celého podání - paritní kontrola |  |
| 49 | A | A49 | 2025-03-27 00:00:00 |  |
| 49 | B | B49 | 1.3 |  |
| 49 | C | C49 | n/a |  |
| 49 | D | D49 | 165 |  |
| 49 | E | E49 | =_xlfn.IFNA(VLOOKUP(D49,MH!A$2:N$547,2,TRUE),"") |  |
| 49 | F | F49 | =_xlfn.IFNA(VLOOKUP(D49,MH!A$2:N$547,7,TRUE),"") |  |
| 49 | G | G49 | změna kontroly |  |
| 49 | H | H49 | změna popisu, hlášky, změna podmínky<br><br> |  |
| 50 | A | A50 | 2025-03-31 00:00:00 |  |
| 50 | B | B50 | 1.3 |  |
| 50 | C | C50 | n/a |  |
| 50 | D | D50 | 242 |  |
| 50 | E | E50 | =_xlfn.IFNA(VLOOKUP(D50,MH!A$2:N$547,2,TRUE),"") |  |
| 50 | F | F50 | =_xlfn.IFNA(VLOOKUP(D50,MH!A$2:N$547,7,TRUE),"") |  |
| 50 | G | G50 | přidání kontroly |  |
| 50 | H | H50 | iniciováno FS ZP14 |  |
| 51 | A | A51 | 2025-03-31 00:00:00 |  |
| 51 | B | B51 | 1.3 |  |
| 51 | C | C51 | n/a |  |
| 51 | D | D51 | 243 |  |
| 51 | E | E51 | =_xlfn.IFNA(VLOOKUP(D51,MH!A$2:N$547,2,TRUE),"") |  |
| 51 | F | F51 | =_xlfn.IFNA(VLOOKUP(D51,MH!A$2:N$547,7,TRUE),"") |  |
| 51 | G | G51 | přidání kontroly |  |
| 51 | H | H51 | iniciováno FS ZP14 |  |
| 52 | A | A52 | 2025-03-31 00:00:00 |  |
| 52 | B | B52 | 1.3 |  |
| 52 | C | C52 | n/a |  |
| 52 | D | D52 | 244 |  |
| 52 | E | E52 | =_xlfn.IFNA(VLOOKUP(D52,MH!A$2:N$547,2,TRUE),"") |  |
| 52 | F | F52 | =_xlfn.IFNA(VLOOKUP(D52,MH!A$2:N$547,7,TRUE),"") |  |
| 52 | G | G52 | přidání kontroly |  |
| 52 | H | H52 | iniciováno FS ZP14 |  |
| 53 | A | A53 | 2025-03-31 00:00:00 |  |
| 53 | B | B53 | 1.3 |  |
| 53 | C | C53 | n/a |  |
| 53 | D | D53 | 245 |  |
| 53 | E | E53 | =_xlfn.IFNA(VLOOKUP(D53,MH!A$2:N$547,2,TRUE),"") |  |
| 53 | F | F53 | =_xlfn.IFNA(VLOOKUP(D53,MH!A$2:N$547,7,TRUE),"") |  |
| 53 | G | G53 | přidání kontroly |  |
| 53 | H | H53 | iniciováno FS ZP14 |  |
| 54 | A | A54 | 2025-03-31 00:00:00 |  |
| 54 | B | B54 | 1.3 |  |
| 54 | C | C54 | n/a |  |
| 54 | D | D54 | 246 |  |
| 54 | E | E54 | =_xlfn.IFNA(VLOOKUP(D54,MH!A$2:N$547,2,TRUE),"") |  |
| 54 | F | F54 | =_xlfn.IFNA(VLOOKUP(D54,MH!A$2:N$547,7,TRUE),"") |  |
| 54 | G | G54 | přidání kontroly |  |
| 54 | H | H54 | iniciováno FS ZP14 |  |
| 55 | A | A55 | 2025-03-31 00:00:00 |  |
| 55 | B | B55 | 1.3 |  |
| 55 | C | C55 | n/a |  |
| 55 | D | D55 | 247 |  |
| 55 | E | E55 | =_xlfn.IFNA(VLOOKUP(D55,MH!A$2:N$547,2,TRUE),"") |  |
| 55 | F | F55 | =_xlfn.IFNA(VLOOKUP(D55,MH!A$2:N$547,7,TRUE),"") |  |
| 55 | G | G55 | přidání kontroly |  |
| 55 | H | H55 | iniciováno FS ZP14 |  |
| 56 | A | A56 | 2025-04-01 00:00:00 |  |
| 56 | B | B56 | 1.3 |  |
| 56 | C | C56 | n/a |  |
| 56 | D | D56 | 58 |  |
| 56 | E | E56 | =_xlfn.IFNA(VLOOKUP(D56,MH!A$2:N$547,2,TRUE),"") |  |
| 56 | F | F56 | =_xlfn.IFNA(VLOOKUP(D56,MH!A$2:N$547,7,TRUE),"") |  |
| 56 | G | G56 | změna kontroly |  |
| 56 | H | H56 | přejmenování atr. 10356 |  |
| 57 | A | A57 | 2025-04-01 00:00:00 |  |
| 57 | B | B57 | 1.3 |  |
| 57 | C | C57 | n/a |  |
| 57 | D | D57 | 86 |  |
| 57 | E | E57 | Chybný podíl zahraničního kapitálu |  |
| 57 | F | F57 | DIS |  |
| 57 | G | G57 | odstranění kontroly |  |
| 57 | H | H57 | 10404 odstraněno |  |
| 58 | A | A58 | 2025-04-01 00:00:00 |  |
| 58 | B | B58 | 1.3 |  |
| 58 | C | C58 | n/a |  |
| 58 | D | D58 | 108 |  |
| 58 | E | E58 | Kontrola na Zúčtovaný příjem - z toho příjem za bezplatné používání motorového vozidla |  |
| 58 | F | F58 | DIS |  |
| 58 | G | G58 | odstranění kontroly |  |
| 58 | H | H58 | 10415 odstraněno z atributů (na základě redukce DS), tedy smazání kontroly |  |
| 59 | A | A59 | 2025-04-01 00:00:00 |  |
| 59 | B | B59 | 1.3 |  |
| 59 | C | C59 | n/a |  |
| 59 | D | D59 | 134 |  |
| 59 | E | E59 | =_xlfn.IFNA(VLOOKUP(D59,MH!A$2:N$547,2,TRUE),"") |  |
| 59 | F | F59 | =_xlfn.IFNA(VLOOKUP(D59,MH!A$2:N$547,7,TRUE),"") |  |
| 59 | G | G59 | změna kontroly |  |
| 59 | H | H59 | přejmenování atr. 10356 |  |
| 60 | A | A60 | 2025-04-01 00:00:00 |  |
| 60 | B | B60 | 1.3 |  |
| 60 | C | C60 | n/a |  |
| 60 | D | D60 | 149 |  |
| 60 | E | E60 | Země původu podle velikosti |  |
| 60 | F | F60 | DIS |  |
| 60 | G | G60 | odstranění kontroly |  |
| 60 | H | H60 | 10405,10406 odstraněno z atributů |  |
| 61 | A | A61 | 2025-04-01 00:00:00 |  |
| 61 | B | B61 | 1.3 |  |
| 61 | C | C61 | n/a |  |
| 61 | D | D61 | 194 |  |
| 61 | E | E61 | =_xlfn.IFNA(VLOOKUP(D61,MH!A$2:N$547,2,TRUE),"") |  |
| 61 | F | F61 | =_xlfn.IFNA(VLOOKUP(D61,MH!A$2:N$547,7,TRUE),"") |  |
| 61 | G | G61 | změna kontroly |  |
| 61 | H | H61 | 10405 odstraněno z atributů |  |
| 62 | A | A62 | 2025-04-01 00:00:00 |  |
| 62 | B | B62 | 1.3 |  |
| 62 | C | C62 | n/a |  |
| 62 | D | D62 | 194 |  |
| 62 | E | E62 | =_xlfn.IFNA(VLOOKUP(D62,MH!A$2:N$547,2,TRUE),"") |  |
| 62 | F | F62 | =_xlfn.IFNA(VLOOKUP(D62,MH!A$2:N$547,7,TRUE),"") |  |
| 62 | G | G62 | změna kontroly |  |
| 62 | H | H62 | 10406 odstraněno z atributů |  |
| 63 | A | A63 | 2025-04-01 00:00:00 |  |
| 63 | B | B63 | 1.3 |  |
| 63 | C | C63 | n/a |  |
| 63 | D | D63 | 194 |  |
| 63 | E | E63 | =_xlfn.IFNA(VLOOKUP(D63,MH!A$2:N$547,2,TRUE),"") |  |
| 63 | F | F63 | =_xlfn.IFNA(VLOOKUP(D63,MH!A$2:N$547,7,TRUE),"") |  |
| 63 | G | G63 | změna kontroly |  |
| 63 | H | H63 | 10215, 10216, 10217, 10218, 10219 odstraněno z atributů  (na základě redukce DS) |  |
| 64 | A | A64 | 2025-04-01 00:00:00 |  |
| 64 | B | B64 | 1.3 |  |
| 64 | C | C64 | n/a |  |
| 64 | D | D64 | 200 |  |
| 64 | E | E64 | Kontrola vyplnění atributů ke kolektivním smlouvám |  |
| 64 | F | F64 | DIS |  |
| 64 | G | G64 | odstranění kontroly |  |
| 64 | H | H64 | 10218, 10217 odstraněno z atributů  (na základě redukce DS) |  |
| 65 | A | A65 | 2025-04-01 00:00:00 |  |
| 65 | B | B65 | 1.3 |  |
| 65 | C | C65 | n/a |  |
| 65 | D | D65 | 239 |  |
| 65 | E | E65 | Kontrola vyplnění atributů ke kolektivním smlouvám, při neexistenci smlouvy |  |
| 65 | F | F65 | =_xlfn.IFNA(VLOOKUP(D65,MH!A$2:N$547,7,TRUE),"") |  |
| 65 | G | G65 | odstranění kontroly |  |
| 65 | H | H65 | 10215, 10216, 10217, 10218, 10219 odstraněno z atributů  (na základě redukce DS) |  |
| 66 | A | A66 | 2025-04-01 00:00:00 |  |
| 66 | B | B66 | 1.3 |  |
| 66 | C | C66 | n/a |  |
| 66 | D | D66 | 247 |  |
| 66 | E | E66 | =_xlfn.IFNA(VLOOKUP(D66,MH!A$2:N$547,2,TRUE),"") |  |
| 66 | F | F66 | =_xlfn.IFNA(VLOOKUP(D66,MH!A$2:N$547,7,TRUE),"") |  |
| 66 | G | G66 | přidání kontroly |  |
| 66 | H | H66 | iniciováno FS ZP14 |  |
| 67 | A | A67 | 2025-04-01 00:00:00 |  |
| 67 | B | B67 | 1.3 |  |
| 67 | C | C67 | n/a |  |
| 67 | D | D67 | 248 |  |
| 67 | E | E67 | =_xlfn.IFNA(VLOOKUP(D67,MH!A$2:N$547,2,TRUE),"") |  |
| 67 | F | F67 | DIS |  |
| 67 | G | G67 | přidání kontroly |  |
| 67 | H | H67 | iniciováno FS ZP14 |  |
| 68 | A | A68 | 2025-04-01 00:00:00 |  |
| 68 | B | B68 | 1.3 |  |
| 68 | C | C68 | n/a |  |
| 68 | D | D68 | 249 |  |
| 68 | E | E68 | =_xlfn.IFNA(VLOOKUP(D68,MH!A$2:N$547,2,TRUE),"") |  |
| 68 | F | F68 | =_xlfn.IFNA(VLOOKUP(D68,MH!A$2:N$547,7,TRUE),"") |  |
| 68 | G | G68 | přidání kontroly |  |
| 68 | H | H68 | iniciováno FS ZP14 |  |
| 69 | A | A69 | 2025-04-03 00:00:00 |  |
| 69 | B | B69 | 1.3 |  |
| 69 | C | C69 | n/a |  |
| 69 | D | D69 | 147 |  |
| 69 | E | E69 | Finanční úřad |  |
| 69 | F | F69 | =_xlfn.IFNA(VLOOKUP(D69,MH!A$2:N$547,7,TRUE),"") |  |
| 69 | G | G69 | změna kontroly |  |
| 69 | H | H69 | formalita, úprava seznamu atributů |  |
| 70 | A | A70 | 2025-04-07 00:00:00 |  |
| 70 | B | B70 | 1.3 |  |
| 70 | C | C70 | n/a |  |
| 70 | D | D70 | 128 |  |
| 70 | E | E70 | =_xlfn.IFNA(VLOOKUP(D70,MH!A$2:N$547,2,TRUE),"") |  |
| 70 | F | F70 | =_xlfn.IFNA(VLOOKUP(D70,MH!A$2:N$547,7,TRUE),"") |  |
| 70 | G | G70 | změna kontroly |  |
| 70 | H | H70 | oprava datového atributu, oprava podmínky |  |
| 71 | A | A71 | 2025-04-13 00:00:00 |  |
| 71 | B | B71 | 1.3 |  |
| 71 | C | C71 | n/a |  |
| 71 | D | D71 | 65 |  |
| 71 | E | E71 | =_xlfn.IFNA(VLOOKUP(D71,MH!A$2:N$547,2,TRUE),"") |  |
| 71 | F | F71 | =_xlfn.IFNA(VLOOKUP(D71,MH!A$2:N$547,7,TRUE),"") |  |
| 71 | G | G71 | změna kontroly |  |
| 71 | H | H71 | formalita, úprava typ formuláře, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 72 | A | A72 | 2025-04-13 00:00:00 |  |
| 72 | B | B72 | 1.3 |  |
| 72 | C | C72 | n/a |  |
| 72 | D | D72 | 82 |  |
| 72 | E | E72 | =_xlfn.IFNA(VLOOKUP(D72,MH!A$2:N$547,2,TRUE),"") |  |
| 72 | F | F72 | =_xlfn.IFNA(VLOOKUP(D72,MH!A$2:N$547,7,TRUE),"") |  |
| 72 | G | G72 | změna kontroly |  |
| 72 | H | H72 | změna názvu kontroly a atributu v těle kontroly, nyní nepropustná kontrola, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 73 | A | A73 | 2025-04-13 00:00:00 |  |
| 73 | B | B73 | 1.3 |  |
| 73 | C | C73 | n/a |  |
| 73 | D | D73 | 106 |  |
| 73 | E | E73 | Kontrola na Zúčtovaný příjem - z toho peněžní příjmy |  |
| 73 | F | F73 | DIS |  |
| 73 | G | G73 | odstranění kontroly |  |
| 73 | H | H73 | komunikace pí. Sýk. - na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 74 | A | A74 | 2025-04-13 00:00:00 |  |
| 74 | B | B74 | 1.3 |  |
| 74 | C | C74 | n/a |  |
| 74 | D | D74 | 107 |  |
| 74 | E | E74 | Kontrola na Zúčtovaný příjem - z toho nepeněžní příjmy / naturální mzda |  |
| 74 | F | F74 | DIS |  |
| 74 | G | G74 | odstranění kontroly |  |
| 74 | H | H74 | komunikace pí. Sýk. - na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 75 | A | A75 | 2025-04-13 00:00:00 |  |
| 75 | B | B75 | 1.3 |  |
| 75 | C | C75 | n/a |  |
| 75 | D | D75 | 109 |  |
| 75 | E | E75 | =_xlfn.IFNA(VLOOKUP(D75,MH!A$2:N$547,2,TRUE),"") |  |
| 75 | F | F75 | =_xlfn.IFNA(VLOOKUP(D75,MH!A$2:N$547,7,TRUE),"") |  |
| 75 | G | G75 | změna kontroly |  |
| 75 | H | H75 | změna chyb. hlášky, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 76 | A | A76 | 2025-04-13 00:00:00 |  |
| 76 | B | B76 | 1.3 |  |
| 76 | C | C76 | n/a |  |
| 76 | D | D76 | 110 |  |
| 76 | E | E76 | =_xlfn.IFNA(VLOOKUP(D76,MH!A$2:N$547,2,TRUE),"") |  |
| 76 | F | F76 | =_xlfn.IFNA(VLOOKUP(D76,MH!A$2:N$547,7,TRUE),"") |  |
| 76 | G | G76 | přidání kontroly |  |
| 76 | H | H76 | přidání kontroly 110, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 77 | A | A77 | 2025-04-13 00:00:00 |  |
| 77 | B | B77 | 1.3 |  |
| 77 | C | C77 | n/a |  |
| 77 | D | D77 | 112 |  |
| 77 | E | E77 | =_xlfn.IFNA(VLOOKUP(D77,MH!A$2:N$547,2,TRUE),"") |  |
| 77 | F | F77 | =_xlfn.IFNA(VLOOKUP(D77,MH!A$2:N$547,7,TRUE),"") |  |
| 77 | G | G77 | změna kontroly |  |
| 77 | H | H77 | nekontrolujeme 10450 Průkaz ZTP/P v jednotlivých měsících, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 78 | A | A78 | 2025-04-13 00:00:00 |  |
| 78 | B | B78 | 1.3 |  |
| 78 | C | C78 | n/a |  |
| 78 | D | D78 | 123 |  |
| 78 | E | E78 | =_xlfn.IFNA(VLOOKUP(D78,MH!A$2:N$547,2,TRUE),"") |  |
| 78 | F | F78 | =_xlfn.IFNA(VLOOKUP(D78,MH!A$2:N$547,7,TRUE),"") |  |
| 78 | G | G78 | změna kontroly |  |
| 78 | H | H78 | změna názvu, chyb. hl., detailního  popisu, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 79 | A | A79 | 2025-04-13 00:00:00 |  |
| 79 | B | B79 | 1.3 |  |
| 79 | C | C79 | n/a |  |
| 79 | D | D79 | 128 |  |
| 79 | E | E79 | =_xlfn.IFNA(VLOOKUP(D79,MH!A$2:N$547,2,TRUE),"") |  |
| 79 | F | F79 | =_xlfn.IFNA(VLOOKUP(D79,MH!A$2:N$547,7,TRUE),"") |  |
| 79 | G | G79 | změna kontroly |  |
| 79 | H | H79 | vyřazení 10439 z kontroly |  |
| 80 | A | A80 | 2025-04-13 00:00:00 |  |
| 80 | B | B80 | 1.3 |  |
| 80 | C | C80 | n/a |  |
| 80 | D | D80 | 147 |  |
| 80 | E | E80 | Finanční úřad |  |
| 80 | F | F80 | =_xlfn.IFNA(VLOOKUP(D80,MH!A$2:N$547,7,TRUE),"") |  |
| 80 | G | G80 | změna kontroly |  |
| 80 | H | H80 | změna systému kontroly, změna propustnosti |  |
| 81 | A | A81 | 2025-04-13 00:00:00 |  |
| 81 | B | B81 | 1.3 |  |
| 81 | C | C81 | n/a |  |
| 81 | D | D81 | 148 |  |
| 81 | E | E81 | =_xlfn.IFNA(VLOOKUP(D81,MH!A$2:N$547,2,TRUE),"") |  |
| 81 | F | F81 | =_xlfn.IFNA(VLOOKUP(D81,MH!A$2:N$547,7,TRUE),"") |  |
| 81 | G | G81 | změna kontroly |  |
| 81 | H | H81 | změna systému kontroly, změna propustnosti |  |
| 82 | A | A82 | 2025-04-13 00:00:00 |  |
| 82 | B | B82 | 1.3 |  |
| 82 | C | C82 | n/a |  |
| 82 | D | D82 | 160 |  |
| 82 | E | E82 | Prohlášení poplatníka - alespoň jedna sleva |  |
| 82 | F | F82 | DIS |  |
| 82 | G | G82 | odstranění kontroly |  |
| 82 | H | H82 | duplikovaná kontrola 242-249 |  |
| 83 | A | A83 | 2025-04-13 00:00:00 |  |
| 83 | B | B83 | 1.3 |  |
| 83 | C | C83 | n/a |  |
| 83 | D | D83 | 195 |  |
| 83 | E | E83 | Kontrola zúčtovaného příjmu |  |
| 83 | F | F83 | DIS |  |
| 83 | G | G83 | změna kontroly |  |
| 83 | H | H83 | komunikace pí. Sýk. - na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 84 | A | A84 | 2025-04-13 00:00:00 |  |
| 84 | B | B84 | 1.3 |  |
| 84 | C | C84 | n/a |  |
| 84 | D | D84 | 229 |  |
| 84 | E | E84 | =_xlfn.IFNA(VLOOKUP(D84,MH!A$2:N$547,2,TRUE),"") |  |
| 84 | F | F84 | =_xlfn.IFNA(VLOOKUP(D84,MH!A$2:N$547,7,TRUE),"") |  |
| 84 | G | G84 | změna kontroly |  |
| 84 | H | H84 | změna chyb. hlášky |  |
| 85 | A | A85 | 2025-04-13 00:00:00 |  |
| 85 | B | B85 | 1.3 |  |
| 85 | C | C85 | n/a |  |
| 85 | D | D85 | 230 |  |
| 85 | E | E85 | =_xlfn.IFNA(VLOOKUP(D85,MH!A$2:N$547,2,TRUE),"") |  |
| 85 | F | F85 | =_xlfn.IFNA(VLOOKUP(D85,MH!A$2:N$547,7,TRUE),"") |  |
| 85 | G | G85 | změna kontroly |  |
| 85 | H | H85 | změna chyb. hlášky |  |
| 86 | A | A86 | 2025-04-13 00:00:00 |  |
| 86 | B | B86 | 1.3 |  |
| 86 | C | C86 | n/a |  |
| 86 | D | D86 | 242 |  |
| 86 | E | E86 | =_xlfn.IFNA(VLOOKUP(D86,MH!A$2:N$547,2,TRUE),"") |  |
| 86 | F | F86 | =_xlfn.IFNA(VLOOKUP(D86,MH!A$2:N$547,7,TRUE),"") |  |
| 86 | G | G86 | změna kontroly |  |
| 86 | H | H86 | na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 87 | A | A87 | 2025-04-13 00:00:00 |  |
| 87 | B | B87 | 1.3 |  |
| 87 | C | C87 | n/a |  |
| 87 | D | D87 | 245 |  |
| 87 | E | E87 | =_xlfn.IFNA(VLOOKUP(D87,MH!A$2:N$547,2,TRUE),"") |  |
| 87 | F | F87 | =_xlfn.IFNA(VLOOKUP(D87,MH!A$2:N$547,7,TRUE),"") |  |
| 87 | G | G87 | změna kontroly |  |
| 87 | H | H87 | změna chyb. hlášky, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 88 | A | A88 | 2025-04-13 00:00:00 |  |
| 88 | B | B88 | 1.3 |  |
| 88 | C | C88 | n/a |  |
| 88 | D | D88 | 251 |  |
| 88 | E | E88 | =_xlfn.IFNA(VLOOKUP(D88,MH!A$2:N$547,2,TRUE),"") |  |
| 88 | F | F88 | =_xlfn.IFNA(VLOOKUP(D88,MH!A$2:N$547,7,TRUE),"") |  |
| 88 | G | G88 | přidání kontroly |  |
| 88 | H | H88 | iniciováno JMHZ, strukturální kontrola |  |
| 89 | A | A89 | 2025-04-13 00:00:00 |  |
| 89 | B | B89 | 1.3 |  |
| 89 | C | C89 | n/a |  |
| 89 | D | D89 | 253 |  |
| 89 | E | E89 | =_xlfn.IFNA(VLOOKUP(D89,MH!A$2:N$547,2,TRUE),"") |  |
| 89 | F | F89 | =_xlfn.IFNA(VLOOKUP(D89,MH!A$2:N$547,7,TRUE),"") |  |
| 89 | G | G89 | přidání kontroly |  |
| 89 | H | H89 | iniciováno JMHZ, strukturální kontrola |  |
| 90 | A | A90 | 2025-04-14 00:00:00 |  |
| 90 | B | B90 | 1.3 |  |
| 90 | C | C90 | n/a |  |
| 90 | D | D90 | 250 |  |
| 90 | E | E90 | =_xlfn.IFNA(VLOOKUP(D90,MH!A$2:N$547,2,TRUE),"") |  |
| 90 | F | F90 | =_xlfn.IFNA(VLOOKUP(D90,MH!A$2:N$547,7,TRUE),"") |  |
| 90 | G | G90 | přidání kontroly |  |
| 90 | H | H90 | iniciováno JMHZ, strukturální kontrola |  |
| 91 | A | A91 | 2025-04-16 00:00:00 |  |
| 91 | B | B91 | 1.3 |  |
| 91 | C | C91 | n/a |  |
| 91 | D | D91 | 209 |  |
| 91 | E | E91 | =_xlfn.IFNA(VLOOKUP(D91,MH!A$2:N$547,2,TRUE),"") |  |
| 91 | F | F91 | =_xlfn.IFNA(VLOOKUP(D91,MH!A$2:N$547,7,TRUE),"") |  |
| 91 | G | G91 | změna kontroly |  |
| 91 | H | H91 | formalita, oprava atributů |  |
| 92 | A | A92 | 2025-04-16 00:00:00 |  |
| 92 | B | B92 | 1.3 |  |
| 92 | C | C92 | n/a |  |
| 92 | D | D92 | 242 |  |
| 92 | E | E92 | =_xlfn.IFNA(VLOOKUP(D92,MH!A$2:N$547,2,TRUE),"") |  |
| 92 | F | F92 | =_xlfn.IFNA(VLOOKUP(D92,MH!A$2:N$547,7,TRUE),"") |  |
| 92 | G | G92 | změna kontroly |  |
| 92 | H | H92 | změna chyb. hlášky, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 93 | A | A93 | 2025-04-16 00:00:00 |  |
| 93 | B | B93 | 1.3 |  |
| 93 | C | C93 | n/a |  |
| 93 | D | D93 | 244 |  |
| 93 | E | E93 | =_xlfn.IFNA(VLOOKUP(D93,MH!A$2:N$547,2,TRUE),"") |  |
| 93 | F | F93 | =_xlfn.IFNA(VLOOKUP(D93,MH!A$2:N$547,7,TRUE),"") |  |
| 93 | G | G93 | změna kontroly |  |
| 93 | H | H93 | změna chyb. hlášky, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 94 | A | A94 | 2025-04-16 00:00:00 |  |
| 94 | B | B94 | 1.3 |  |
| 94 | C | C94 | n/a |  |
| 94 | D | D94 | 246 |  |
| 94 | E | E94 | =_xlfn.IFNA(VLOOKUP(D94,MH!A$2:N$547,2,TRUE),"") |  |
| 94 | F | F94 | =_xlfn.IFNA(VLOOKUP(D94,MH!A$2:N$547,7,TRUE),"") |  |
| 94 | G | G94 | změna kontroly |  |
| 94 | H | H94 | změna chyb. hlášky, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 95 | A | A95 | 2025-04-16 00:00:00 |  |
| 95 | B | B95 | 1.3 |  |
| 95 | C | C95 | n/a |  |
| 95 | D | D95 | 248 |  |
| 95 | E | E95 | =_xlfn.IFNA(VLOOKUP(D95,MH!A$2:N$547,2,TRUE),"") |  |
| 95 | F | F95 | DIS |  |
| 95 | G | G95 | změna kontroly |  |
| 95 | H | H95 | změna chyb. hlášky, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 96 | A | A96 | 2025-04-17 00:00:00 |  |
| 96 | B | B96 | 1.3 |  |
| 96 | C | C96 | n/a |  |
| 96 | D | D96 | 147 |  |
| 96 | E | E96 | Finanční úřad |  |
| 96 | F | F96 | DIS |  |
| 96 | G | G96 | odstranění kontroly |  |
| 96 | H | H96 | změna typu hlášení, na základě revize FS, vyjádření AK, email komunikace 11.4.2025 |  |
| 97 | A | A97 | 2025-04-17 00:00:00 |  |
| 97 | B | B97 | 1.3 |  |
| 97 | C | C97 | n/a |  |
| 97 | D | D97 | 148 |  |
| 97 | E | E97 | =_xlfn.IFNA(VLOOKUP(D97,MH!A$2:N$547,2,TRUE),"") |  |
| 97 | F | F97 | =_xlfn.IFNA(VLOOKUP(D97,MH!A$2:N$547,7,TRUE),"") |  |
| 97 | G | G97 | změna kontroly |  |
| 97 | H | H97 | změna na původní hodnoty, revize JHMZ / JD |  |
| 98 | A | A98 | 2025-04-24 00:00:00 |  |
| 98 | B | B98 | 1.4 final |  |
| 98 | C | C98 | n/a |  |
| 98 | D | D98 | 163 |  |
| 98 | E | E98 | Kontrola Úhrn vyměřovacích základů zaměstnanců, za které zaměstnavatele uplatňuje slevu na pojistném zaměstnavatele |  |
| 98 | F | F98 | cJMHZ |  |
| 98 | G | G98 | odstranění kontroly |  |
| 98 | H | H98 | duplicita s 207 |  |
| 99 | A | A99 | 2025-04-25 00:00:00 |  |
| 99 | B | B99 | 1.4 final |  |
| 99 | C | C99 | n/a |  |
| 99 | D | D99 | 210 |  |
| 99 | E | E99 | Úhrn vyměřovacích základů zaměstnanců, kteří mají nárok na slevu na pojistném zaměstnance |  |
| 99 | F | F99 | cJMHZ |  |
| 99 | G | G99 | odstranění kontroly |  |
| 99 | H | H99 | duplicita s 213 |  |
| 100 | A | A100 | 2025-04-29 00:00:00 |  |
| 100 | B | B100 | 1.4 final |  |
| 100 | C | C100 | n/a |  |
| 100 | D | D100 | 224 |  |
| 100 | E | E100 | Chybějící dílčí podání |  |
| 100 | F | F100 | cJMHZ |  |
| 100 | G | G100 | odstranění kontroly |  |
| 100 | H | H100 | 29.4.2025 - Soukup Hrušková / Myslivcová / Kalinič us |  |
| 101 | A | A101 | 2025-04-30 00:00:00 |  |
| 101 | B | B101 | 1.4 final |  |
| 101 | C | C101 | n/a |  |
| 101 | D | D101 | 16 |  |
| 101 | E | E101 | Maximální možný odpracovaný počet hodin v měsíci pro DPČ<br>S ohledem na max. možný počet týdnů v měsíci (5) je limit nastaven na: 5*20 (tj. poloviční týdenní úvazek 40:2=20) = 100 |  |
| 101 | F | F101 | cJMHZ |  |
| 101 | G | G101 | odstranění kontroly |  |
| 101 | H | H101 | podbnět od HRIS, po konzultaci pí. Kleňhová - pokyn k odstranění |  |
| 102 | A | A102 | 2025-04-30 00:00:00 |  |
| 102 | B | B102 | 1.4 final |  |
| 102 | C | C102 | n/a |  |
| 102 | D | D102 | 17 |  |
| 102 | E | E102 | Maximální možný odpracovaný počet hodin v měsíci pro DPP<br>S ohledem na max. možný počet týdnů v měsíci (5) je limit nastaven na: 5*40 (tj. max. počet odpracovaných hodin týdně bez přesčasů) = 200 |  |
| 102 | F | F102 | cJMHZ |  |
| 102 | G | G102 | odstranění kontroly |  |
| 102 | H | H102 | podbnět od HRIS, po konzultaci pí. Kle. - pokyn k odstranění |  |
| 103 | A | A103 | 2025-04-30 00:00:00 |  |
| 103 | B | B103 | 1.4 final |  |
| 103 | C | C103 | n/a |  |
| 103 | D | D103 | 228 |  |
| 103 | E | E103 | =_xlfn.IFNA(VLOOKUP(D103,MH!A$2:N$547,2,TRUE),"") |  |
| 103 | F | F103 | =_xlfn.IFNA(VLOOKUP(D103,MH!A$2:N$547,7,TRUE),"") |  |
| 103 | G | G103 | změna kontroly |  |
| 103 | H | H103 | 29.4.2025 - SH / PM / MK |  |
| 104 | A | A104 | 2025-05-06 00:00:00 |  |
| 104 | B | B104 | 1.4 final |  |
| 104 | C | C104 | n/a |  |
| 104 | D | D104 | 242 |  |
| 104 | E | E104 | =_xlfn.IFNA(VLOOKUP(D104,MH!A$2:N$547,2,TRUE),"") |  |
| 104 | F | F104 | =_xlfn.IFNA(VLOOKUP(D104,MH!A$2:N$547,7,TRUE),"") |  |
| 104 | G | G104 | změna kontroly |  |
| 104 | H | H104 | formalita - oprav atributů |  |
| 105 | A | A105 | 2025-05-09 00:00:00 |  |
| 105 | B | B105 | draft |  |
| 105 | C | C105 | n/a |  |
| 105 | D | D105 | 245 |  |
| 105 | E | E105 | Kontrola adekvátních atributů pro výpočet srážkové daňe rezidentů bez prohlášení poplatníka - srážkova daň |  |
| 105 | F | F105 | cJMHZ |  |
| 105 | G | G105 | změna kontroly |  |
| 105 | H | H105 | po revizi VerZ, AKr, HKy (04.09.2025) - změněna podmína mezi 2a 2b je AND |  |
| 106 | A | A106 | 2025-05-12 00:00:00 |  |
| 106 | B | B106 | 1.4 final |  |
| 106 | C | C106 | n/a |  |
| 106 | D | D106 | 21 |  |
| 106 | E | E106 | Celkový počet neodpracovaných hodin |  |
| 106 | F | F106 | DIS |  |
| 106 | G | G106 | odstranění kontroly |  |
| 106 | H | H106 | po konzultaci pí. JK, Kl - odstraněno (dotaz č. 135) |  |
| 107 | A | A107 | 2025-06-16 00:00:00 |  |
| 107 | B | B107 | 1.4 final |  |
| 107 | C | C107 | ZP_TECH_POPIS_018 |  |
| 107 | D | D107 | 255 |  |
| 107 | E | E107 | =_xlfn.IFNA(VLOOKUP(D107,MH!A$2:N$547,2,TRUE),"") |  |
| 107 | F | F107 | ePortál |  |
| 107 | G | G107 | přidání kontroly |  |
| 107 | H | H107 | pro ZP018 zpracování přídána kontrola |  |
| 108 | A | A108 | 2025-06-16 00:00:00 |  |
| 108 | B | B108 | 1.4 final |  |
| 108 | C | C108 | ZP_TECH_POPIS_018 |  |
| 108 | D | D108 | 256 |  |
| 108 | E | E108 | =_xlfn.IFNA(VLOOKUP(D108,MH!A$2:N$547,2,TRUE),"") |  |
| 108 | F | F108 | =_xlfn.IFNA(VLOOKUP(D108,MH!A$2:N$547,7,TRUE),"") |  |
| 108 | G | G108 | přidání kontroly |  |
| 108 | H | H108 | pro ZP018 zpracování přídána kontrola |  |
| 109 | A | A109 | 2025-06-16 00:00:00 |  |
| 109 | B | B109 | 1.4 final |  |
| 109 | C | C109 | ZP_TECH_POPIS_018 |  |
| 109 | D | D109 | 257 |  |
| 109 | E | E109 | =_xlfn.IFNA(VLOOKUP(D109,MH!A$2:N$547,2,TRUE),"") |  |
| 109 | F | F109 | =_xlfn.IFNA(VLOOKUP(D109,MH!A$2:N$547,7,TRUE),"") |  |
| 109 | G | G109 | přidání kontroly |  |
| 109 | H | H109 | pro ZP018 zpracování přídána kontrola |  |
| 110 | A | A110 | 2025-06-16 00:00:00 |  |
| 110 | B | B110 | 1.4 final |  |
| 110 | C | C110 | ZP_TECH_POPIS_018 |  |
| 110 | D | D110 | 260 |  |
| 110 | E | E110 | Existuje více než jedno primární PPV za OIČ v rámci podání.  |  |
| 110 | F | F110 | ePortál |  |
| 110 | G | G110 | přidání kontroly |  |
| 110 | H | H110 | pro ZP018 zpracování přídána kontrola |  |
| 111 | A | A111 | 2025-06-17 00:00:00 |  |
| 111 | B | B111 | 1.4 final |  |
| 111 | C | C111 | n/a |  |
| 111 | D | D111 | 79 |  |
| 111 | E | E111 | =_xlfn.IFNA(VLOOKUP(D111,MH!A$2:N$547,2,TRUE),"") |  |
| 111 | F | F111 | =_xlfn.IFNA(VLOOKUP(D111,MH!A$2:N$547,7,TRUE),"") |  |
| 111 | G | G111 | změna kontroly |  |
| 111 | H | H111 | do kontroly uvedený poivnné atributy: 10420, 10454, 10231, 10232, 10233 |  |
| 112 | A | A112 | 2025-06-17 00:00:00 |  |
| 112 | B | B112 | 1.4 final |  |
| 112 | C | C112 | n/a |  |
| 112 | D | D112 | 103 |  |
| 112 | E | E112 | =_xlfn.IFNA(VLOOKUP(D112,MH!A$2:N$547,2,TRUE),"") |  |
| 112 | F | F112 | =_xlfn.IFNA(VLOOKUP(D112,MH!A$2:N$547,7,TRUE),"") |  |
| 112 | G | G112 | změna kontroly |  |
| 112 | H | H112 | změna kategorie kontroly, přidána pozn. + atribut |  |
| 113 | A | A113 | 2025-06-17 00:00:00 |  |
| 113 | B | B113 | 1.4 final |  |
| 113 | C | C113 | n/a |  |
| 113 | D | D113 | 128 |  |
| 113 | E | E113 | =_xlfn.IFNA(VLOOKUP(D113,MH!A$2:N$547,2,TRUE),"") |  |
| 113 | F | F113 | =_xlfn.IFNA(VLOOKUP(D113,MH!A$2:N$547,7,TRUE),"") |  |
| 113 | G | G113 | změna kontroly |  |
| 113 | H | H113 | po kontrole přidání dalších atributů: 10439, 10453 |  |
| 114 | A | A114 | 2025-06-17 00:00:00 |  |
| 114 | B | B114 | 1.4 final |  |
| 114 | C | C114 | n/a |  |
| 114 | D | D114 | 258 |  |
| 114 | E | E114 | =_xlfn.IFNA(VLOOKUP(D114,MH!A$2:N$547,2,TRUE),"") |  |
| 114 | F | F114 | =_xlfn.IFNA(VLOOKUP(D114,MH!A$2:N$547,7,TRUE),"") |  |
| 114 | G | G114 | přidání kontroly |  |
| 114 | H | H114 | po konzultaci p. Sl., v rámci kontroly a přídání dalších logických kontrol jsme kontrolu přidali |  |
| 115 | A | A115 | 2025-06-17 00:00:00 |  |
| 115 | B | B115 | 1.4 final |  |
| 115 | C | C115 | n/a |  |
| 115 | D | D115 | 259 |  |
| 115 | E | E115 | =_xlfn.IFNA(VLOOKUP(D115,MH!A$2:N$547,2,TRUE),"") |  |
| 115 | F | F115 | =_xlfn.IFNA(VLOOKUP(D115,MH!A$2:N$547,7,TRUE),"") |  |
| 115 | G | G115 | přidání kontroly |  |
| 115 | H | H115 | po konzultaci p. Sl., v rámci kontroly a přídání dalších logických kontrol jsme kontrolu přidali |  |
| 116 | A | A116 | 2025-06-18 00:00:00 |  |
| 116 | B | B116 | 1.4 final |  |
| 116 | C | C116 | ZP_TECH_POPIS_033 |  |
| 116 | D | D116 | 23 |  |
| 116 | E | E116 | =_xlfn.IFNA(VLOOKUP(D116,MH!A$2:N$547,2,TRUE),"") |  |
| 116 | F | F116 | =_xlfn.IFNA(VLOOKUP(D116,MH!A$2:N$547,7,TRUE),"") |  |
| 116 | G | G116 | změna kontroly |  |
| 116 | H | H116 | v rámci ZP_TECH_POPIS_033 odstranění atr. 10278, komunikace Kleňhová M. 20.03.2025 |  |
| 117 | A | A117 | 2025-06-19 00:00:00 |  |
| 117 | B | B117 | 1.4 final |  |
| 117 | C | C117 | n/a |  |
| 117 | D | D117 | 67 |  |
| 117 | E | E117 | Přehled o výši pojistného |  |
| 117 | F | F117 | DIS |  |
| 117 | G | G117 | odstranění kontroly |  |
| 117 | H | H117 | po konzultaci s DIS, tato kontrola, která byla uvedena spíše pro forma odstranena |  |
| 118 | A | A118 | 2025-06-19 00:00:00 |  |
| 118 | B | B118 | 1.4 final |  |
| 118 | C | C118 | n/a |  |
| 118 | D | D118 | 202 |  |
| 118 | E | E118 | Průběh pojištění v daném měsíci |  |
| 118 | F | F118 | DIS |  |
| 118 | G | G118 | změna kontroly |  |
| 118 | H | H118 | formání změna textace kontroly, na základě diskuse s DIS |  |
| 119 | A | A119 | 2025-06-20 00:00:00 |  |
| 119 | B | B119 | 1.4 final |  |
| 119 | C | C119 | n/a |  |
| 119 | D | D119 | 1 |  |
| 119 | E | E119 | =_xlfn.IFNA(VLOOKUP(D119,MH!A$2:N$547,2,TRUE),"") |  |
| 119 | F | F119 | =_xlfn.IFNA(VLOOKUP(D119,MH!A$2:N$547,7,TRUE),"") |  |
| 119 | G | G119 | změna kontroly |  |
| 119 | H | H119 | po zapracování revize p. DM - odstranění ostré nerovnosti |  |
| 120 | A | A120 | 2025-06-20 00:00:00 |  |
| 120 | B | B120 | 1.4 final |  |
| 120 | C | C120 | n/a |  |
| 120 | D | D120 | 2 |  |
| 120 | E | E120 | =_xlfn.IFNA(VLOOKUP(D120,MH!A$2:N$547,2,TRUE),"") |  |
| 120 | F | F120 | =_xlfn.IFNA(VLOOKUP(D120,MH!A$2:N$547,7,TRUE),"") |  |
| 120 | G | G120 | změna kontroly |  |
| 120 | H | H120 | po zapracování revize p. DM - 10245 nahrazní 10477 |  |
| 121 | A | A121 | 2025-06-20 00:00:00 |  |
| 121 | B | B121 | 1.4 final |  |
| 121 | C | C121 | n/a |  |
| 121 | D | D121 | 3 |  |
| 121 | E | E121 | =_xlfn.IFNA(VLOOKUP(D121,MH!A$2:N$547,2,TRUE),"") |  |
| 121 | F | F121 | =_xlfn.IFNA(VLOOKUP(D121,MH!A$2:N$547,7,TRUE),"") |  |
| 121 | G | G121 | změna kontroly |  |
| 121 | H | H121 | po zapracování revize p. DM - zjednodušení kontroly |  |
| 122 | A | A122 | 2025-06-20 00:00:00 |  |
| 122 | B | B122 | 1.4 final |  |
| 122 | C | C122 | n/a |  |
| 122 | D | D122 | 42 |  |
| 122 | E | E122 | =_xlfn.IFNA(VLOOKUP(D122,MH!A$2:N$547,2,TRUE),"") |  |
| 122 | F | F122 | =_xlfn.IFNA(VLOOKUP(D122,MH!A$2:N$547,7,TRUE),"") |  |
| 122 | G | G122 | změna kontroly |  |
| 122 | H | H122 | po zapracování revize p. DM - přidání podmínky  je-li atribut 10372 = "ANO" |  |
| 123 | A | A123 | 2025-06-20 00:00:00 |  |
| 123 | B | B123 | 1.4 final |  |
| 123 | C | C123 | n/a |  |
| 123 | D | D123 | 42 |  |
| 123 | E | E123 | =_xlfn.IFNA(VLOOKUP(D123,MH!A$2:N$547,2,TRUE),"") |  |
| 123 | F | F123 | =_xlfn.IFNA(VLOOKUP(D123,MH!A$2:N$547,7,TRUE),"") |  |
| 123 | G | G123 | změna kontroly |  |
| 123 | H | H123 | při konzultaci s p. DM - změněna formulace |  |
| 124 | A | A124 | 2025-06-20 00:00:00 |  |
| 124 | B | B124 | 1.4 final |  |
| 124 | C | C124 | n/a |  |
| 124 | D | D124 | 45 |  |
| 124 | E | E124 | =_xlfn.IFNA(VLOOKUP(D124,MH!A$2:N$547,2,TRUE),"") |  |
| 124 | F | F124 | =_xlfn.IFNA(VLOOKUP(D124,MH!A$2:N$547,7,TRUE),"") |  |
| 124 | G | G124 | změna kontroly |  |
| 124 | H | H124 | po zapracování revize p. DM - zjednodušení kontroly |  |
| 125 | A | A125 | 2025-06-20 00:00:00 |  |
| 125 | B | B125 | 1.4 final |  |
| 125 | C | C125 | n/a |  |
| 125 | D | D125 | 118 |  |
| 125 | E | E125 | =_xlfn.IFNA(VLOOKUP(D125,MH!A$2:N$547,2,TRUE),"") |  |
| 125 | F | F125 | =_xlfn.IFNA(VLOOKUP(D125,MH!A$2:N$547,7,TRUE),"") |  |
| 125 | G | G125 | změna kontroly |  |
| 125 | H | H125 | po zapracování revize p. DM - přidání pozn. v závorce se zaokrouhlením |  |
| 126 | A | A126 | 2025-06-20 00:00:00 |  |
| 126 | B | B126 | 1.4 final |  |
| 126 | C | C126 | n/a |  |
| 126 | D | D126 | 137 |  |
| 126 | E | E126 | =_xlfn.IFNA(VLOOKUP(D126,MH!A$2:N$547,2,TRUE),"") |  |
| 126 | F | F126 | =_xlfn.IFNA(VLOOKUP(D126,MH!A$2:N$547,7,TRUE),"") |  |
| 126 | G | G126 | změna kontroly |  |
| 126 | H | H126 | po zapracování revize p. DM - zjednodušení kontroly |  |
| 127 | A | A127 | 2025-06-20 00:00:00 |  |
| 127 | B | B127 | 1.4 final |  |
| 127 | C | C127 | n/a |  |
| 127 | D | D127 | 138 |  |
| 127 | E | E127 | =_xlfn.IFNA(VLOOKUP(D127,MH!A$2:N$547,2,TRUE),"") |  |
| 127 | F | F127 | =_xlfn.IFNA(VLOOKUP(D127,MH!A$2:N$547,7,TRUE),"") |  |
| 127 | G | G127 | změna kontroly |  |
| 127 | H | H127 | po zapracování revize p. DM - zjednodušení kontroly |  |
| 128 | A | A128 | 2025-06-20 00:00:00 |  |
| 128 | B | B128 | 1.4 final |  |
| 128 | C | C128 | n/a |  |
| 128 | D | D128 | 164 |  |
| 128 | E | E128 | =_xlfn.IFNA(VLOOKUP(D128,MH!A$2:N$547,2,TRUE),"") |  |
| 128 | F | F128 | =_xlfn.IFNA(VLOOKUP(D128,MH!A$2:N$547,7,TRUE),"") |  |
| 128 | G | G128 | změna kontroly |  |
| 128 | H | H128 | při konzultaci s p. DM - změněna formulace |  |
| 129 | A | A129 | 2025-06-20 00:00:00 |  |
| 129 | B | B129 | 1.4 final |  |
| 129 | C | C129 | n/a |  |
| 129 | D | D129 | 168 |  |
| 129 | E | E129 | =_xlfn.IFNA(VLOOKUP(D129,MH!A$2:N$547,2,TRUE),"") |  |
| 129 | F | F129 | =_xlfn.IFNA(VLOOKUP(D129,MH!A$2:N$547,7,TRUE),"") |  |
| 129 | G | G129 | změna kontroly |  |
| 129 | H | H129 | po konzultaci s p. DM - oprava výpočtového parametru - přídání do byz konstant |  |
| 130 | A | A130 | 2025-06-20 00:00:00 |  |
| 130 | B | B130 | 1.4 final |  |
| 130 | C | C130 | n/a |  |
| 130 | D | D130 | 170 |  |
| 130 | E | E130 | =_xlfn.IFNA(VLOOKUP(D130,MH!A$2:N$547,2,TRUE),"") |  |
| 130 | F | F130 | =_xlfn.IFNA(VLOOKUP(D130,MH!A$2:N$547,7,TRUE),"") |  |
| 130 | G | G130 | změna kontroly |  |
| 130 | H | H130 | po konzultaci s p. DM - oprava výpočtového parametru - přídání do byz konstant |  |
| 131 | A | A131 | 2025-06-20 00:00:00 |  |
| 131 | B | B131 | 1.4 final |  |
| 131 | C | C131 | n/a |  |
| 131 | D | D131 | 202 |  |
| 131 | E | E131 | Průběh pojištění v daném měsíci |  |
| 131 | F | F131 | DIS |  |
| 131 | G | G131 | změna kontroly |  |
| 131 | H | H131 | po zapracování revize p. DM - zjednodušení kontroly |  |
| 132 | A | A132 | 2025-06-20 00:00:00 |  |
| 132 | B | B132 | 1.4 final |  |
| 132 | C | C132 | n/a |  |
| 132 | D | D132 | 213 |  |
| 132 | E | E132 | =_xlfn.IFNA(VLOOKUP(D132,MH!A$2:N$547,2,TRUE),"") |  |
| 132 | F | F132 | =_xlfn.IFNA(VLOOKUP(D132,MH!A$2:N$547,7,TRUE),"") |  |
| 132 | G | G132 | změna kontroly |  |
| 132 | H | H132 | doplněni pole Typ formuláře, odstranění ostré nerovnosti z podmínky |  |
| 133 | A | A133 | 2025-06-20 00:00:00 |  |
| 133 | B | B133 | 1.4 final |  |
| 133 | C | C133 | ZP_TECH_POPIS_016, _017 |  |
| 133 | D | D133 | 254 |  |
| 133 | E | E133 | Musí být uvedena alespoň jedna z hodnot výše exekučních nebo výše insolvenčních srážek. |  |
| 133 | F | F133 | DIS |  |
| 133 | G | G133 | odstranění kontroly |  |
| 133 | H | H133 | atributy 10496, 10499 - odstraněny v DS - ZP_TECH_POPIS_016,  ZP_TECH_POPIS_017 |  |
| 134 | A | A134 | 2025-06-25 00:00:00 |  |
| 134 | B | B134 | 1.4 final |  |
| 134 | C | C134 | n/a |  |
| 134 | D | D134 | 1 |  |
| 134 | E | E134 | =_xlfn.IFNA(VLOOKUP(D134,MH!A$2:N$547,2,TRUE),"") |  |
| 134 | F | F134 | =_xlfn.IFNA(VLOOKUP(D134,MH!A$2:N$547,7,TRUE),"") |  |
| 134 | G | G134 | změna kontroly |  |
| 134 | H | H134 | po konzultaci s p. DM - 24.06.2025 - změna podmínky |  |
| 135 | A | A135 | 2025-06-25 00:00:00 |  |
| 135 | B | B135 | 1.4 final |  |
| 135 | C | C135 | n/a |  |
| 135 | D | D135 | 2 |  |
| 135 | E | E135 | =_xlfn.IFNA(VLOOKUP(D135,MH!A$2:N$547,2,TRUE),"") |  |
| 135 | F | F135 | =_xlfn.IFNA(VLOOKUP(D135,MH!A$2:N$547,7,TRUE),"") |  |
| 135 | G | G135 | změna kontroly |  |
| 135 | H | H135 | po konzultaci s p. DM - 24.06.2025 - změna podmínky |  |
| 136 | A | A136 | 2025-06-25 00:00:00 |  |
| 136 | B | B136 | 1.4 final |  |
| 136 | C | C136 | n/a |  |
| 136 | D | D136 | 3 |  |
| 136 | E | E136 | =_xlfn.IFNA(VLOOKUP(D136,MH!A$2:N$547,2,TRUE),"") |  |
| 136 | F | F136 | =_xlfn.IFNA(VLOOKUP(D136,MH!A$2:N$547,7,TRUE),"") |  |
| 136 | G | G136 | změna kontroly |  |
| 136 | H | H136 | po konzultaci s p. DM - 24.06.2025 - změna podmínky |  |
| 137 | A | A137 | 2025-06-25 00:00:00 |  |
| 137 | B | B137 | 1.4 final |  |
| 137 | C | C137 | n/a |  |
| 137 | D | D137 | 42 |  |
| 137 | E | E137 | =_xlfn.IFNA(VLOOKUP(D137,MH!A$2:N$547,2,TRUE),"") |  |
| 137 | F | F137 | =_xlfn.IFNA(VLOOKUP(D137,MH!A$2:N$547,7,TRUE),"") |  |
| 137 | G | G137 | změna kontroly |  |
| 137 | H | H137 | po konzultaci s p. DM - 24.06.2025 - změna podmínky |  |
| 138 | A | A138 | 2025-06-25 00:00:00 |  |
| 138 | B | B138 | 1.4 final |  |
| 138 | C | C138 | n/a |  |
| 138 | D | D138 | 42 |  |
| 138 | E | E138 | =_xlfn.IFNA(VLOOKUP(D138,MH!A$2:N$547,2,TRUE),"") |  |
| 138 | F | F138 | =_xlfn.IFNA(VLOOKUP(D138,MH!A$2:N$547,7,TRUE),"") |  |
| 138 | G | G138 | změna kontroly |  |
| 138 | H | H138 | po konzultaci s p. DM - 24.06.2025 - změna hlášky |  |
| 139 | A | A139 | 2025-06-25 00:00:00 |  |
| 139 | B | B139 | 1.4 final |  |
| 139 | C | C139 | n/a |  |
| 139 | D | D139 | 45 |  |
| 139 | E | E139 | =_xlfn.IFNA(VLOOKUP(D139,MH!A$2:N$547,2,TRUE),"") |  |
| 139 | F | F139 | =_xlfn.IFNA(VLOOKUP(D139,MH!A$2:N$547,7,TRUE),"") |  |
| 139 | G | G139 | změna kontroly |  |
| 139 | H | H139 | po konzultaci s p. DM - 24.06.2025 - změna podmínky |  |
| 140 | A | A140 | 2025-06-25 00:00:00 |  |
| 140 | B | B140 | 1.4 final |  |
| 140 | C | C140 | n/a |  |
| 140 | D | D140 | 118 |  |
| 140 | E | E140 | =_xlfn.IFNA(VLOOKUP(D140,MH!A$2:N$547,2,TRUE),"") |  |
| 140 | F | F140 | =_xlfn.IFNA(VLOOKUP(D140,MH!A$2:N$547,7,TRUE),"") |  |
| 140 | G | G140 | změna kontroly |  |
| 140 | H | H140 | po konzultaci s p. DM - 24.06.2025 - změna podmínky |  |
| 141 | A | A141 | 2025-06-25 00:00:00 |  |
| 141 | B | B141 | 1.4 final |  |
| 141 | C | C141 | n/a |  |
| 141 | D | D141 | 137 |  |
| 141 | E | E141 | =_xlfn.IFNA(VLOOKUP(D141,MH!A$2:N$547,2,TRUE),"") |  |
| 141 | F | F141 | =_xlfn.IFNA(VLOOKUP(D141,MH!A$2:N$547,7,TRUE),"") |  |
| 141 | G | G141 | změna kontroly |  |
| 141 | H | H141 | po konzultaci s p. DM - 24.06.2025 - změna podmínky |  |
| 142 | A | A142 | 2025-06-25 00:00:00 |  |
| 142 | B | B142 | 1.4 final |  |
| 142 | C | C142 | n/a |  |
| 142 | D | D142 | 138 |  |
| 142 | E | E142 | =_xlfn.IFNA(VLOOKUP(D142,MH!A$2:N$547,2,TRUE),"") |  |
| 142 | F | F142 | =_xlfn.IFNA(VLOOKUP(D142,MH!A$2:N$547,7,TRUE),"") |  |
| 142 | G | G142 | změna kontroly |  |
| 142 | H | H142 | po konzultaci s p. DM - 24.06.2025 - změna podmínky |  |
| 143 | A | A143 | 2025-06-25 00:00:00 |  |
| 143 | B | B143 | 1.4 final |  |
| 143 | C | C143 | n/a |  |
| 143 | D | D143 | 164 |  |
| 143 | E | E143 | =_xlfn.IFNA(VLOOKUP(D143,MH!A$2:N$547,2,TRUE),"") |  |
| 143 | F | F143 | =_xlfn.IFNA(VLOOKUP(D143,MH!A$2:N$547,7,TRUE),"") |  |
| 143 | G | G143 | změna kontroly |  |
| 143 | H | H143 | po konzultaci s p. DM - 24.06.2025 - změna podmínky |  |
| 144 | A | A144 | 2025-06-25 00:00:00 |  |
| 144 | B | B144 | 1.4 final |  |
| 144 | C | C144 | n/a |  |
| 144 | D | D144 | 168 |  |
| 144 | E | E144 | =_xlfn.IFNA(VLOOKUP(D144,MH!A$2:N$547,2,TRUE),"") |  |
| 144 | F | F144 | =_xlfn.IFNA(VLOOKUP(D144,MH!A$2:N$547,7,TRUE),"") |  |
| 144 | G | G144 | změna kontroly |  |
| 144 | H | H144 | po konzultaci s p. Mar. - 24.06.2025 - změna podmínky |  |
| 145 | A | A145 | 2025-06-25 00:00:00 |  |
| 145 | B | B145 | 1.4 final |  |
| 145 | C | C145 | n/a |  |
| 145 | D | D145 | 170 |  |
| 145 | E | E145 | =_xlfn.IFNA(VLOOKUP(D145,MH!A$2:N$547,2,TRUE),"") |  |
| 145 | F | F145 | =_xlfn.IFNA(VLOOKUP(D145,MH!A$2:N$547,7,TRUE),"") |  |
| 145 | G | G145 | změna kontroly |  |
| 145 | H | H145 | po konzultaci s p. Mar. - 24.06.2025 - změna podmínky |  |
| 146 | A | A146 | 2025-06-25 00:00:00 |  |
| 146 | B | B146 | 1.4 final |  |
| 146 | C | C146 | n/a |  |
| 146 | D | D146 | 202 |  |
| 146 | E | E146 | Průběh pojištění v daném měsíci |  |
| 146 | F | F146 | DIS |  |
| 146 | G | G146 | změna kontroly |  |
| 146 | H | H146 | po konzultaci s p. Mar. - 24.06.2025 - změna podmínky |  |
| 147 | A | A147 | 2025-06-26 00:00:00 |  |
| 147 | B | B147 | 1.4 final |  |
| 147 | C | C147 | n/a |  |
| 147 | D | D147 | 106 |  |
| 147 | E | E147 | Kontrola na Zúčtovaný příjem - z toho peněžní příjmy |  |
| 147 | F | F147 | DIS |  |
| 147 | G | G147 | odstranění kontroly |  |
| 147 | H | H147 | po revizi (přidání sloupce Gestor, atr. 10287 vymazán z DS (changelog 4.4.2025)) - kontrola odstraněna |  |
| 148 | A | A148 | 2025-06-26 00:00:00 |  |
| 148 | B | B148 | 1.4 final |  |
| 148 | C | C148 | n/a |  |
| 148 | D | D148 | 231 |  |
| 148 | E | E148 | Kontrola uplatnění slevy za zaměstnance u jednoho zaměstnavatele je pouze jednou |  |
| 148 | F | F148 | cJMHZ |  |
| 148 | G | G148 | odstranění kontroly |  |
| 148 | H | H148 | po revizi s p. Mar. (email) - odstraněna idk 231 |  |
| 149 | A | A149 | 2025-06-26 00:00:00 |  |
| 149 | B | B149 | 1.4 final |  |
| 149 | C | C149 | n/a |  |
| 149 | G | G149 | změna kontroly |  |
| 149 | H | H149 | přidání sloupce Gestor |  |
| 150 | A | A150 | 2025-06-27 00:00:00 |  |
| 150 | B | B150 | 1.4 final |  |
| 150 | C | C150 | n/a |  |
| 150 | D | D150 | 133 |  |
| 150 | E | E150 | Kontrola správnosti Kódu ELDP při zaměstnání malého rozsahu |  |
| 150 | F | F150 | DIS |  |
| 150 | G | G150 | změna kontroly |  |
| 150 | H | H150 | oprava chyby - změna atr. sloupec C - formalita (přidání 10243) |  |
| 151 | A | A151 | 2025-06-27 00:00:00 |  |
| 151 | B | B151 | 1.4 final |  |
| 151 | C | C151 | n/a |  |
| 151 | D | D151 | 133 |  |
| 151 | E | E151 | Kontrola správnosti Kódu ELDP při zaměstnání malého rozsahu |  |
| 151 | F | F151 | DIS |  |
| 151 | G | G151 | změna kontroly |  |
| 151 | H | H151 | oprava chyby - formalita, znění podmínky [0] |  |
| 152 | A | A152 | 2025-06-27 00:00:00 |  |
| 152 | B | B152 | 1.4 final |  |
| 152 | C | C152 | n/a |  |
| 152 | D | D152 | 137 |  |
| 152 | E | E152 | Průběh pojištění v daném měsíci |  |
| 152 | F | F152 | DIS |  |
| 152 | G | G152 | změna kontroly |  |
| 152 | H | H152 | po revizi s p. Mar. (email) - změna atr. sloupec C - formalita |  |
| 153 | A | A153 | 2025-06-27 00:00:00 |  |
| 153 | B | B153 | 1.4 final |  |
| 153 | C | C153 | n/a |  |
| 153 | D | D153 | 138 |  |
| 153 | E | E153 | Průběh pojištění v daném měsíci |  |
| 153 | F | F153 | DIS |  |
| 153 | G | G153 | změna kontroly |  |
| 153 | H | H153 | po revizi s p. Mar. (email) - změna atr. sloupec C - formalita |  |
| 154 | A | A154 | 2025-06-27 00:00:00 |  |
| 154 | B | B154 | 1.4 final |  |
| 154 | C | C154 | n/a |  |
| 154 | D | D154 | 162 |  |
| 154 | E | E154 | Je třeba vyplnit alespoň jeden typ vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a, b nebo c |  |
| 154 | F | F154 | DIS |  |
| 154 | G | G154 | změna kontroly |  |
| 154 | H | H154 | po revizi, přepracování formálního znění<br>+ přídání atr 10502 + příznak pro DIS sloupec R |  |
| 155 | A | A155 | 2025-06-27 00:00:00 |  |
| 155 | B | B155 | 1.4 final |  |
| 155 | C | C155 | n/a |  |
| 155 | D | D155 | 164 |  |
| 155 | E | E155 | Průběh pojištění v daném měsíci |  |
| 155 | F | F155 | DIS |  |
| 155 | G | G155 | změna kontroly |  |
| 155 | H | H155 | po revizi s p. Mar. (email) - změna atr. sloupec C - formalita |  |
| 156 | A | A156 | 2025-06-27 00:00:00 |  |
| 156 | B | B156 | 1.4 final |  |
| 156 | C | C156 | n/a |  |
| 156 | D | D156 | 202 |  |
| 156 | E | E156 | Průběh pojištění v daném měsíci |  |
| 156 | F | F156 | DIS |  |
| 156 | G | G156 | odstranění kontroly |  |
| 156 | H | H156 | po revizi s p. Mar. (email) / p. Hav. - odstraněna idk 202 |  |
| 157 | A | A157 | 2025-07-01 00:00:00 |  |
| 157 | B | B157 | 1.4 final |  |
| 157 | C | C157 | n/a |  |
| 157 | D | D157 | 50 |  |
| 157 | E | E157 | Není vyplněn údaj Vyměřovací základ. |  |
| 157 | F | F157 | DIS |  |
| 157 | G | G157 | změna kontroly |  |
| 157 | H | H157 | po revizi s pí. Mad. (email FW: kontrola idk 50) - přidání ostré nerovnosti v podmínce |  |
| 158 | A | A158 | 2025-07-01 00:00:00 |  |
| 158 | B | B158 | 1.4 final |  |
| 158 | C | C158 | n/a |  |
| 158 | D | D158 | 79 |  |
| 158 | E | E158 | Příjem v daném měsíci |  |
| 158 | F | F158 | DIS |  |
| 158 | G | G158 | změna kontroly |  |
| 158 | H | H158 | oprava - formalita - přidání atributů do sloupce seznam id atributů |  |
| 159 | A | A159 | 2025-07-01 00:00:00 |  |
| 159 | B | B159 | 1.4 final |  |
| 159 | C | C159 | n/a |  |
| 159 | D | D159 | 103 |  |
| 159 | E | E159 | Vykonávaná pozice zaměstnance |  |
| 159 | F | F159 | DIS |  |
| 159 | G | G159 | změna kontroly |  |
| 159 | H | H159 | po konzultaci p. Rí. - zpřesněna podmínka |  |
| 160 | A | A160 | 2025-07-03 00:00:00 |  |
| 160 | B | B160 | 1.4 final |  |
| 160 | C | C160 | n/a |  |
| 160 | D | D160 | 16 |  |
| 160 | G | G160 | odstranění parametru |  |
| 160 | H | H160 | po revizi, odstraněn parametr z kontroly, která byla odstraněna |  |
| 161 | A | A161 | 2025-07-03 00:00:00 |  |
| 161 | B | B161 | 1.4 final |  |
| 161 | C | C161 | n/a |  |
| 161 | D | D161 | 17 |  |
| 161 | G | G161 | odstranění parametru |  |
| 161 | H | H161 | po revizi, odstraněn parametr z kontroly, která byla odstraněna - sheet Parametrické konstanty |  |
| 162 | A | A162 | 2025-07-03 00:00:00 |  |
| 162 | B | B162 | 1.4 final |  |
| 162 | C | C162 | n/a |  |
| 162 | D | D162 | 119 |  |
| 162 | G | G162 | odstranění parametru |  |
| 162 | H | H162 | po revizi, odstraněn parametr z kontroly, která byla odstraněna - sheet Parametrické konstanty |  |
| 163 | A | A163 | 2025-07-04 00:00:00 |  |
| 163 | B | B163 | 1.4 final |  |
| 163 | C | C163 | ZP_TECH_POPIS_042 |  |
| 163 | D | D163 | 30 |  |
| 163 | E | E163 | Náhrady mzdy zúčtované |  |
| 163 | F | F163 | DIS |  |
| 163 | G | G163 | změna kontroly |  |
| 163 | H | H163 | Úprava názvu atributu 10339, Původní název: Náhrady za mzdy za svátky, Nový název: Náhrady za svátky |  |
| 164 | A | A164 | 2025-07-04 00:00:00 |  |
| 164 | B | B164 | 1.4 final |  |
| 164 | C | C164 | ZP_TECH_POPIS_018 |  |
| 164 | D | D164 | 58 |  |
| 164 | E | E164 | Počet kalendářních dnů trvání pojištění v daném kalendářním měsíci |  |
| 164 | F | F164 | DIS |  |
| 164 | G | G164 | změna kontroly |  |
| 164 | H | H164 | Úprava_Změna názvu atributu ID 10356 Počet kalendářních dnů doby důchodového pojištění v daném kalendářním měsíci |  |
| 165 | A | A165 | 2025-07-04 00:00:00 |  |
| 165 | B | B165 | 1.4 final |  |
| 165 | C | C165 | ZP_TECH_POPIS_039 |  |
| 165 | D | D165 | 94 |  |
| 165 | E | E165 | Stanovený fond pro danou profesi (v hodinách měsíčně) |  |
| 165 | F | F165 | DIS |  |
| 165 | G | G165 | změna kontroly |  |
| 165 | H | H165 | Úprava názvu atributu 10259, Původní název: Stanovený fond pro danou profesi (v hodinách měsíčně), Nový název: Pracovní doba stanovená pro danou profesi (v hodinách měsíčně) |  |
| 166 | A | A166 | 2025-07-04 00:00:00 |  |
| 166 | B | B166 | 1.4 final |  |
| 166 | C | C166 | ZP_TECH_POPIS_040 |  |
| 166 | D | D166 | 95 |  |
| 166 | E | E166 | Sjednaný fond pracovní doby (v hodinách měsíčně) |  |
| 166 | F | F166 | DIS |  |
| 166 | G | G166 | změna kontroly |  |
| 166 | H | H166 | Úprava názvu atributu 10260 , Původní název: Sjednaný fond pracovní doby (v hodinách měsíčně), Nový název: Pracovní doba sjednaná (v hodinách měsíčně) |  |
| 167 | A | A167 | 2025-07-04 00:00:00 |  |
| 167 | B | B167 | 1.4 final |  |
| 167 | C | C167 | ZP_TECH_POPIS_018 |  |
| 167 | D | D167 | 134 |  |
| 167 | E | E167 | Počet kalendářních dnů trvání pojištění v daném kalendářním měsíci - interval |  |
| 167 | F | F167 | DIS |  |
| 167 | G | G167 | změna kontroly |  |
| 167 | H | H167 | Úprava_Změna názvu atributu ID 10356 Počet kalendářních dnů doby důchodového pojištění v daném kalendářním měsíci |  |
| 168 | A | A168 | 2025-07-04 00:00:00 |  |
| 168 | B | B168 | 1.4 final |  |
| 168 | C | C168 | ZP_TECH_POPIS_040 |  |
| 168 | D | D168 | 144 |  |
| 168 | E | E168 | Překážky na straně zaměstnance s náhradou mzdy/platu - počet neodpracovaných hodin |  |
| 168 | F | F168 | DIS |  |
| 168 | G | G168 | změna kontroly |  |
| 168 | H | H168 | Úprava názvu atributu 10260 , Původní název: Sjednaný fond pracovní doby (v hodinách měsíčně), Nový název: Pracovní doba sjednaná (v hodinách měsíčně) |  |
| 169 | A | A169 | 2025-07-04 00:00:00 |  |
| 169 | B | B169 | 1.4 final |  |
| 169 | C | C169 | ZP_TECH_POPIS_043 |  |
| 169 | D | D169 | 248 |  |
| 169 | E | E169 | Kontrola vyplnění dat souhrnné vrstvy za zaměstnance jen pro primární pracovněprávní vztah zaměstnance |  |
| 169 | F | F169 | DIS |  |
| 169 | G | G169 | změna kontroly |  |
| 169 | H | H169 | změna názvu atr. 10344 na Čistý příjem Čistá mzda |  |
| 170 | A | A170 | 2025-07-04 00:00:00 |  |
| 170 | B | B170 | 1.4 final |  |
| 170 | C | C170 | ZP_TECH_POPIS_016 |  |
| 170 | D | D170 | 248 |  |
| 170 | E | E170 | Kontrola vyplnění dat souhrnné vrstvy za zaměstnance jen pro primární pracovněprávní vztah zaměstnance |  |
| 170 | F | F170 | DIS |  |
| 170 | G | G170 | změna kontroly |  |
| 170 | H | H170 | odstranění atr. 10496 z kontroly |  |
| 171 | A | A171 | 2025-07-04 00:00:00 |  |
| 171 | B | B171 | 1.4 final |  |
| 171 | C | C171 | ZP_TECH_POPIS_017 |  |
| 171 | D | D171 | 248 |  |
| 171 | E | E171 | Kontrola vyplnění dat souhrnné vrstvy za zaměstnance jen pro primární pracovněprávní vztah zaměstnance |  |
| 171 | F | F171 | DIS |  |
| 171 | G | G171 | změna kontroly |  |
| 171 | H | H171 | odstranění atr. 10499 z kontroly |  |
| 172 | A | A172 | 2025-07-07 00:00:00 |  |
| 172 | B | B172 | 1.4 final |  |
| 172 | C | C172 | n/a |  |
| 172 | D | D172 | 50 |  |
| 172 | E | E172 | Vyměřovací základ není vyplněn |  |
| 172 | F | F172 | DIS |  |
| 172 | G | G172 | změna kontroly |  |
| 172 | H | H172 | po revizi JK, změna podmínky |  |
| 173 | A | A173 | 2025-07-07 00:00:00 |  |
| 173 | B | B173 | 1.4 final |  |
| 173 | C | C173 | ZP_TECH_POPIS_019 |  |
| 173 | D | D173 | 110 |  |
| 173 | E | E173 | Pořadí pro určení výše daňového zvýhodnění tvoří řadu |  |
| 173 | F | F173 | DIS |  |
| 173 | G | G173 | změna kontroly |  |
| 173 | H | H173 | změna podmínky kontroly, přidání poznámky<br> |  |
| 174 | A | A174 | 2025-07-07 00:00:00 |  |
| 174 | B | B174 | 1.4 final |  |
| 174 | C | C174 | n/a |  |
| 174 | D | D174 | 133 |  |
| 174 | E | E174 | Kontrola správnosti Kódu ELDP při zaměstnání malého rozsahu |  |
| 174 | F | F174 | DIS |  |
| 174 | G | G174 | změna kontroly |  |
| 174 | H | H174 | po revizi JK, změna podmínky, přidání 3 kódů ZA, ZB, ZC |  |
| 175 | A | A175 | 2025-07-14 00:00:00 |  |
| 175 | B | B175 | 1.4 final |  |
| 175 | C | C175 | ZP_TECH_POPIS_019 |  |
| 175 | D | D175 | 229 |  |
| 175 | E | E175 | Kontrola kolize pořadí dítěte v měsíci (měsíční zúčtovaní) |  |
| 175 | F | F175 | DIS |  |
| 175 | G | G175 | změna kontroly |  |
| 175 | H | H175 | reformulace podmínky kontroly |  |
| 176 | A | A176 | 2025-07-14 00:00:00 |  |
| 176 | B | B176 | 1.4 final |  |
| 176 | C | C176 | ZP_TECH_POPIS_019 |  |
| 176 | D | D176 | 230 |  |
| 176 | E | E176 | Kontrola kolize pořadí dítěte v měsíci (roční zúčtovaní) |  |
| 176 | F | F176 | DIS |  |
| 176 | G | G176 | změna kontroly |  |
| 176 | H | H176 | reformulace podmínky kontroly |  |
| 177 | A | A177 | 2025-07-15 00:00:00 |  |
| 177 | B | B177 | 1.4 final |  |
| 177 | C | C177 | n/a |  |
| 177 | D | D177 | 261 |  |
| 177 | E | E177 | Kontrola odpovídajícího  ID PPV a VS v systémech ČSSZ |  |
| 177 | F | F177 | DIS |  |
| 177 | G | G177 | změna kontroly |  |
| 177 | H | H177 | reformulace: názvu kontroly, poznámky, vstup. atributů |  |
| 178 | A | A178 | 2025-07-15 00:00:00 |  |
| 178 | B | B178 | 1.4 final |  |
| 178 | C | C178 | n/a |  |
| 178 | D | D178 | 262 |  |
| 178 | E | E178 | Kontrola existence ID PPV v systémech ČSSZ |  |
| 178 | F | F178 | DIS |  |
| 178 | G | G178 | změna kontroly |  |
| 178 | H | H178 | reformulace: názvu kontroly, poznámky, vstup. atributů |  |
| 179 | A | A179 | 2025-07-15 00:00:00 |  |
| 179 | B | B179 | 1.4 final |  |
| 179 | C | C179 | n/a |  |
| 179 | D | D179 | 263 |  |
| 179 | E | E179 | Kontrola existence IK MPSV v systémech ČSSZ |  |
| 179 | F | F179 | DIS |  |
| 179 | G | G179 | změna kontroly |  |
| 179 | H | H179 | reformulace: názvu kontroly, poznámky, vstup. atributů |  |
| 180 | A | A180 | 2025-07-15 00:00:00 |  |
| 180 | B | B180 | 1.4 final |  |
| 180 | C | C180 | n/a |  |
| 180 | D | D180 | 264 |  |
| 180 | E | E180 | Kontrola existence IK MPSV a ID PPV v systémech ČSSZ |  |
| 180 | F | F180 | DIS |  |
| 180 | G | G180 | změna kontroly |  |
| 180 | H | H180 | reformulace: názvu kontroly, poznámky, vstup. atributů |  |
| 181 | A | A181 | 2025-07-18 00:00:00 |  |
| 181 | B | B181 | 1.4 final |  |
| 181 | C | C181 | ZP_TECH_POPIS_052 |  |
| 181 | D | D181 | 242 |  |
| 181 | E | E181 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů s prohlášením poplatníka daně |  |
| 181 | F | F181 | DIS |  |
| 181 | G | G181 | změna kontroly |  |
| 181 | H | H181 | Úprava názvu atributu 10310  <br>Současný název: Sražená daň podle zvláštní sazby daně z příjmu nerezidenta člena orgánu právnické osoby <br>Nový název: Sražená záloha na daň z příjmu nerezidenta člena orgánu právnické osoby |  |
| 182 | A | A182 | 2025-07-18 00:00:00 |  |
| 182 | B | B182 | 1.4 final |  |
| 182 | C | C182 | n/a |  |
| 182 | D | D182 | 244 |  |
| 182 | E | E182 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů bez prohlášení poplatníka - zálohová daň |  |
| 182 | F | F182 | cJMHZ |  |
| 182 | G | G182 | změna kontroly |  |
| 182 | H | H182 | Úprava názvu atributu 10310  <br>Současný název: Sražená daň podle zvláštní sazby daně z příjmu nerezidenta člena orgánu právnické osoby <br>Nový název: Sražená záloha na daň z příjmu nerezidenta člena orgánu právnické osoby |  |
| 183 | A | A183 | 2025-07-23 00:00:00 |  |
| 183 | B | B183 | 1.4 final |  |
| 183 | C | C183 | n/a |  |
| 183 | D | D183 | 2 |  |
| 183 | E | E183 | Úhrn vyměřovacích základů zaměstnanců se slevou |  |
| 183 | F | F183 | cJMHZ |  |
| 183 | G | G183 | odstranění kontroly |  |
| 183 | H | H183 | redundance s idk 207 |  |
| 184 | A | A184 | 2025-07-28 00:00:00 |  |
| 184 | B | B184 | 1.4 final |  |
| 184 | C | C184 | ZP_TECH_POPIS_009, ZP_TECH_POPIS_049 |  |
| 184 | D | D184 | 121 |  |
| 184 | E | E184 | Kontrola vyplnění vyloučených dob dle v § 16 odst. 4 písm |  |
| 184 | F | F184 | DIS |  |
| 184 | G | G184 | změna kontroly |  |
| 184 | H | H184 | přidán atribut 10536 do sčítanců a změněno znaménko |  |
| 185 | A | A185 | 2025-07-28 00:00:00 |  |
| 185 | B | B185 | 1.4 final |  |
| 185 | C | C185 | ZP_TECH_POPIS_010 |  |
| 185 | D | D185 | 256 |  |
| 185 | E | E185 | Kontrola existence max. jednoho primárního PPV za OIČ v rámci zaměstnavatele (celé IČO) |  |
| 185 | F | F185 | cJMHZ |  |
| 185 | G | G185 | odstranění kontroly |  |
| 185 | H | H185 | po interní konzultaci k ZP010 - odstraněno na základě požadavku FS |  |
| 186 | A | A186 | 2025-07-28 00:00:00 |  |
| 186 | B | B186 | 1.4 final |  |
| 186 | C | C186 | ZP_TECH_POPIS_010 |  |
| 186 | D | D186 | 257 |  |
| 186 | E | E186 | Kontrola existence min. jednoho primárního PPV za OIČ v rámci zaměstnavatele (celé IČO) |  |
| 186 | F | F186 | cJMHZ |  |
| 186 | G | G186 | odstranění kontroly |  |
| 186 | H | H186 | po interní konzultaci k ZP010 - odstraněno na základě požadavku FS |  |
| 187 | A | A187 | 2025-07-28 00:00:00 |  |
| 187 | B | B187 | 1.4 final |  |
| 187 | C | C187 | ZP_TECH_POPIS_010 |  |
| 187 | D | D187 | 260 |  |
| 187 | E | E187 | Kontrola existence max. jednoho primárního PPV za OIČ v rámci podání.  |  |
| 187 | F | F187 | ePortál |  |
| 187 | G | G187 | změna kontroly |  |
| 187 | H | H187 | změna poznámky, kategorie kontroly smazána |  |
| 188 | A | A188 | 2025-07-29 00:00:00 |  |
| 188 | B | B188 | 1.4 final |  |
| 188 | C | C188 | ZP_TECH_POPIS_009 |  |
| 188 | D | D188 | 47 |  |
| 188 | E | E188 | Vyloučené doby < = údaji Dny započtené |  |
| 188 | F | F188 | DIS |  |
| 188 | G | G188 | odstranění kontroly |  |
| 188 | H | H188 | po odstranění atr. 10244 |  |
| 189 | A | A189 | 2025-07-29 00:00:00 |  |
| 189 | B | B189 | 1.4 final |  |
| 189 | C | C189 | ZP_TECH_POPIS_009 |  |
| 189 | D | D189 | 48 |  |
| 189 | E | E189 | Vyloučené doby je prázdný, pokud druhý znak údaje Kód ELDP = P |  |
| 189 | F | F189 | DIS |  |
| 189 | G | G189 | odstranění kontroly |  |
| 189 | H | H189 | po odstranění atr. 10244 |  |
| 190 | A | A190 | 2025-07-29 00:00:00 |  |
| 190 | B | B190 | 1.4 final |  |
| 190 | C | C190 | ZP_TECH_POPIS_009 |  |
| 190 | D | D190 | 51 |  |
| 190 | E | E190 | Doby odečtené nevyplňovat, pokud druhý znak údaje Kód ELDP = P |  |
| 190 | F | F190 | DIS |  |
| 190 | G | G190 | odstranění kontroly |  |
| 190 | H | H190 | po odstranění atr. 10246 |  |
| 191 | A | A191 | 2025-07-29 00:00:00 |  |
| 191 | B | B191 | 1.4 final |  |
| 191 | C | C191 | ZP_TECH_POPIS_009 |  |
| 191 | D | D191 | 52 |  |
| 191 | E | E191 | Pokud Doby odečtené jsou uvedeny, pak 2. znak Kód ELDP = D |  |
| 191 | F | F191 | DIS |  |
| 191 | G | G191 | odstranění kontroly |  |
| 191 | H | H191 | po odstranění atr. 10246 |  |
| 192 | A | A192 | 2025-07-29 00:00:00 |  |
| 192 | B | B192 | 1.4 final |  |
| 192 | C | C192 | ZP_TECH_POPIS_009 |  |
| 192 | D | D192 | 53 |  |
| 192 | E | E192 | Odečtené doby >= Vyloučené doby |  |
| 192 | F | F192 | DIS |  |
| 192 | G | G192 | odstranění kontroly |  |
| 192 | H | H192 | po odstranění atr. 10244 |  |
| 193 | A | A193 | 2025-07-29 00:00:00 |  |
| 193 | B | B193 | 1.4 final |  |
| 193 | C | C193 | ZP_TECH_POPIS_009 |  |
| 193 | D | D193 | 59 |  |
| 193 | E | E193 | Vyměřovací základ s podmínkami |  |
| 193 | F | F193 | DIS |  |
| 193 | G | G193 | změna kontroly |  |
| 193 | H | H193 | po odstranění atr. 10244 a 10246 změna atributů a těla podmínky |  |
| 194 | A | A194 | 2025-07-29 00:00:00 |  |
| 194 | B | B194 | 1.4 final |  |
| 194 | C | C194 | ZP_TECH_POPIS_009 |  |
| 194 | D | D194 | 98 |  |
| 194 | E | E194 | Počet dní nesmí být vyšší než počet kalendářních dní v daném měsíci |  |
| 194 | F | F194 | DIS |  |
| 194 | G | G194 | změna kontroly |  |
| 194 | H | H194 | odstranění atr. 10467 |  |
| 195 | A | A195 | 2025-07-29 00:00:00 |  |
| 195 | B | B195 | 1.4 final |  |
| 195 | C | C195 | ZP_TECH_POPIS_009 |  |
| 195 | D | D195 | 166 |  |
| 195 | E | E195 | Kontrola vyplnění odečítaných dnů |  |
| 195 | F | F195 | DIS |  |
| 195 | G | G195 | změna kontroly |  |
| 195 | H | H195 | změněno znaménko, přídání podpodmínky |  |
| 196 | A | A196 | 2025-07-29 00:00:00 |  |
| 196 | B | B196 | 1.4 final |  |
| 196 | C | C196 | ZP_TECH_POPIS_009 |  |
| 196 | D | D196 | 166 |  |
| 196 | E | E196 | Kontrola vyplnění odečítaných dnů |  |
| 196 | F | F196 | DIS |  |
| 196 | G | G196 | změna kontroly |  |
| 196 | H | H196 | odstranění atr. 10467 |  |
| 197 | A | A197 | 2025-07-29 00:00:00 |  |
| 197 | B | B197 | 1.4 final |  |
| 197 | C | C197 | ZP_TECH_POPIS_030 |  |
| 197 | D | D197 | 267 |  |
| 197 | E | E197 | Kontrola nevyplnění dat pro rozklad při nulovém atributu Mzda za práci zúčtovaná |  |
| 197 | F | F197 | DIS |  |
| 197 | G | G197 | přidání kontroly |  |
| 197 | H | H197 | v rámci ZP_TECH_POPIS_030 přidána interakční negativní kontrola - pro IN32 |  |
| 198 | A | A198 | 2025-07-30 00:00:00 |  |
| 198 | B | B198 | 1.4 final |  |
| 198 | C | C198 | ZP_TECH_POPIS_015 |  |
| 198 | D | D198 | 278 |  |
| 198 | E | E198 | Kontrola věku dítěte pro uplatnění - I (výsledek ročního zúčtování sleva na manžela/manželku) |  |
| 198 | F | F198 | DIS |  |
| 198 | G | G198 | přidání kontroly |  |
| 198 | H | H198 | přídání kontroly |  |
| 199 | A | A199 | 2025-07-30 00:00:00 |  |
| 199 | B | B199 | 1.4 final |  |
| 199 | C | C199 | ZP_TECH_POPIS_048 |  |
| 199 | D | D199 | 4 |  |
| 199 | E | E199 | Vypočítané pojistné k úhradě |  |
| 199 | F | F199 | DIS |  |
| 199 | G | G199 | změna kontroly |  |
| 199 | H | H199 | přídání atr. do těla podmínky |  |
| 200 | A | A200 | 2025-07-30 00:00:00 |  |
| 200 | B | B200 | 1.4 final |  |
| 200 | C | C200 | ZP_TECH_POPIS_048 |  |
| 200 | D | D200 | 269 |  |
| 200 | E | E200 | Kontrola Úhrn vyměřovacích základů zaměstnanců, kteří mají nárok na slevu na pojistném zaměstnance |  |
| 200 | G | G200 | přidání kontroly |  |
| 200 | H | H200 | přídání kontroly |  |
| 201 | A | A201 | 2025-07-30 00:00:00 |  |
| 201 | B | B201 | 1.4 final |  |
| 201 | C | C201 | ZP_TECH_POPIS_048 |  |
| 201 | D | D201 | 270 |  |
| 201 | E | E201 | Úhrn slev na pojistném zaměstnanců |  |
| 201 | F | F201 | cJMHZ |  |
| 201 | G | G201 | přidání kontroly |  |
| 201 | H | H201 | přídání kontroly |  |
| 202 | A | A202 | 2025-07-30 00:00:00 |  |
| 202 | B | B202 | 1.4 final |  |
| 202 | C | C202 | ZP_TECH_POPIS_048 |  |
| 202 | D | D202 | 271 |  |
| 202 | E | E202 | Kontrola uplatnění slevy pro ovocnáře |  |
| 202 | F | F202 | DIS |  |
| 202 | G | G202 | přidání kontroly |  |
| 202 | H | H202 | přídání kontroly |  |
| 203 | A | A203 | 2025-07-30 00:00:00 |  |
| 203 | B | B203 | 1.4 final |  |
| 203 | C | C203 | ZP_TECH_POPIS_048 |  |
| 203 | D | D203 | 272 |  |
| 203 | E | E203 | Vypnění výše slevy na pojistném zaměstnance pro ovocnářství a pěstování zeleniny |  |
| 203 | F | F203 | DIS |  |
| 203 | G | G203 | přidání kontroly |  |
| 203 | H | H203 | přídání kontroly |  |
| 204 | A | A204 | 2025-07-30 00:00:00 |  |
| 204 | B | B204 | 1.4 final |  |
| 204 | C | C204 | ZP_TECH_POPIS_048 |  |
| 204 | D | D204 | 273 |  |
| 204 | E | E204 | Kontrola slevy a pojištění pro ovocnářství a pěstování zeleniny |  |
| 204 | F | F204 | DIS |  |
| 204 | G | G204 | přidání kontroly |  |
| 204 | H | H204 | přídání kontroly |  |
| 205 | A | A205 | 2025-07-30 00:00:00 |  |
| 205 | B | B205 | 1.4 final |  |
| 205 | C | C205 | n/a |  |
| 205 | D | D205 | 201 |  |
| 205 | E | E205 | Datum úhrady má být větší rovno datu vyplnění  |  |
| 205 | F | F205 | DIS |  |
| 205 | G | G205 | změna kontroly |  |
| 205 | H | H205 | změna znaménka kontroly (MOu-235) |  |
| 206 | A | A206 | 2025-07-30 00:00:00 |  |
| 206 | B | B206 | 1.4 final |  |
| 206 | C | C206 | ZP_TECH_POPIS_048 |  |
| 206 | D | D206 | 274 |  |
| 206 | E | E206 | Odpovídající výše slevy na pojistném zaměstnance |  |
| 206 | F | F206 | DIS |  |
| 206 | G | G206 | přidání kontroly |  |
| 206 | H | H206 | přídání kontroly |  |
| 207 | A | A207 | 2025-07-30 00:00:00 |  |
| 207 | B | B207 | 1.4 final |  |
| 207 | C | C207 | ZP_TECH_POPIS_048 |  |
| 207 | D | D207 | 275 |  |
| 207 | E | E207 | Kontrola výlučnosti uplatnění slevy |  |
| 207 | F | F207 | DIS |  |
| 207 | G | G207 | přidání kontroly |  |
| 207 | H | H207 | přídání kontroly |  |
| 208 | A | A208 | 2025-07-30 00:00:00 |  |
| 208 | B | B208 | 1.4 final |  |
| 208 | C | C208 | ZP_TECH_POPIS_015 |  |
| 208 | D | D208 | 276 |  |
| 208 | E | E208 | Počet měsíců uplatnění slevy souhlasí s možným počtem uplatnění |  |
| 208 | F | F208 | DIS |  |
| 208 | G | G208 | přidání kontroly |  |
| 208 | H | H208 | přídání kontroly |  |
| 209 | A | A209 | 2025-07-30 00:00:00 |  |
| 209 | B | B209 | 1.4 final |  |
| 209 | C | C209 | ZP_TECH_POPIS_015 |  |
| 209 | D | D209 | 277 |  |
| 209 | E | E209 | Povinné RČ nebo datum narození při uplatnění slevy  podle § 35bb zákona o daních z příjmů (ZDP) |  |
| 209 | F | F209 | DIS |  |
| 209 | G | G209 | přidání kontroly |  |
| 209 | H | H209 | přídání kontroly |  |
| 210 | A | A210 | 2025-07-31 00:00:00 |  |
| 210 | B | B210 | 1.4 final |  |
| 210 | C | C210 | ZP_TECH_POPIS_015 |  |
| 210 | D | D210 | 292 |  |
| 210 | E | E210 | Kontrola věku dítěte pro uplatnění - II (výsledek ročního zúčtování sleva na manžela/manželku) |  |
| 210 | F | F210 | cJMHZ |  |
| 210 | G | G210 | přidání kontroly |  |
| 210 | H | H210 | přidání kontroly |  |
| 211 | A | A211 | 2025-07-31 00:00:00 |  |
| 211 | B | B211 | 1.4 final |  |
| 211 | C | C211 | ZP_TECH_POPIS_031 |  |
| 211 | D | D211 | 281 |  |
| 211 | E | E211 | Kontrola nevyplnění dat pro rozklad při nulových náhradách mzdy zúčtované |  |
| 211 | F | F211 | DIS |  |
| 211 | G | G211 | přidání kontroly |  |
| 211 | H | H211 | přidání kontroly |  |
| 212 | A | A212 | 2025-07-31 00:00:00 |  |
| 212 | B | B212 | 1.4 final |  |
| 212 | C | C212 | ZP_TECH_POPIS_032 |  |
| 212 | D | D212 | 282 |  |
| 212 | E | E212 | Kontrola nevyplnění dat odpracovaných hodin pro zaměstnání v hlubinném hornictví a rizikové práci |  |
| 212 | F | F212 | DIS |  |
| 212 | G | G212 | přidání kontroly |  |
| 212 | H | H212 | přidání kontroly |  |
| 213 | A | A213 | 2025-07-31 00:00:00 |  |
| 213 | B | B213 | 1.4 final |  |
| 213 | C | C213 | ZP_TECH_POPIS_035 |  |
| 213 | D | D213 | 283 |  |
| 213 | E | E213 | Kontrola nevyplnění dat pro zúčtovaný příjem - celkem |  |
| 213 | F | F213 | DIS |  |
| 213 | G | G213 | přidání kontroly |  |
| 213 | H | H213 | přidání kontroly |  |
| 214 | A | A214 | 2025-07-31 00:00:00 |  |
| 214 | B | B214 | 1.4 final |  |
| 214 | C | C214 | ZP_TECH_POPIS_046 |  |
| 214 | D | D214 | 284 |  |
| 214 | E | E214 | Kontrola vyplnění min. jednoho atributu pro částku vyměřovacího základu zaměstnance, ze které je odváděno pojistné |  |
| 214 | F | F214 | DIS |  |
| 214 | G | G214 | přidání kontroly |  |
| 214 | H | H214 | přidání kontroly |  |
| 215 | A | A215 | 2025-07-31 00:00:00 |  |
| 215 | B | B215 | 1.4 final |  |
| 215 | C | C215 | ZP_TECH_POPIS_046 |  |
| 215 | D | D215 | 285 |  |
| 215 | E | E215 | Kontrola sumace částek vyměřovacího základu zaměstnance |  |
| 215 | F | F215 | DIS |  |
| 215 | G | G215 | přidání kontroly |  |
| 215 | H | H215 | přidání kontroly |  |
| 216 | A | A216 | 2025-07-31 00:00:00 |  |
| 216 | B | B216 | 1.4 final |  |
| 216 | C | C216 | ZP_TECH_POPIS_033 |  |
| 216 | D | D216 | 286 |  |
| 216 | E | E216 | Kontrola nevyplnění atributů neodpracovaných hodin. |  |
| 216 | F | F216 | DIS |  |
| 216 | G | G216 | přidání kontroly |  |
| 216 | H | H216 | přidání kontroly |  |
| 217 | A | A217 | 2025-07-31 00:00:00 |  |
| 217 | B | B217 | 1.4 final |  |
| 217 | C | C217 | ZP_TECH_POPIS_045 |  |
| 217 | D | D217 | 287 |  |
| 217 | E | E217 | Kontrola nevyplnění atributů pojištění a vyměřovacího základu. |  |
| 217 | F | F217 | DIS |  |
| 217 | G | G217 | přidání kontroly |  |
| 217 | H | H217 | přidání kontroly |  |
| 218 | A | A218 | 2025-07-31 00:00:00 |  |
| 218 | B | B218 | 1.4 final |  |
| 218 | C | C218 | ZP_TECH_POPIS_045 |  |
| 218 | D | D218 | 288 |  |
| 218 | E | E218 | Kontrola slev při nulový počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb. |  |
| 218 | F | F218 | DIS |  |
| 218 | G | G218 | přidání kontroly |  |
| 218 | H | H218 | přidání kontroly |  |
| 219 | A | A219 | 2025-10-14 00:00:00 |  |
| 219 | B | B219 | 1.4.1 |  |
| 219 | C | C219 | n/a |  |
| 219 | D | D219 | 42 |  |
| 219 | E | E219 | Kontrola atributů v rámci slev na pojistném jsou vázany k druhu činnosti v rozsahu 1 až 9 |  |
| 219 | F | F219 | cJMHZ |  |
| 219 | G | G219 | přidání kontroly |  |
| 219 | H | H219 | po revizi JDv, LRid - přidání na cJMHZ |  |
| 220 | A | A220 | 10/15/20225 |  |
| 220 | B | B220 | 1.4.1 |  |
| 220 | C | C220 | n/a |  |
| 220 | D | D220 | 221 |  |
| 220 | E | E220 | Bezvadná individualizovaná část  |  |
| 220 | F | F220 | cJMHZ |  |
| 220 | G | G220 | odstranění kontroly |  |
| 220 | H | H220 | po revizi JDv, PMys, JHol - odstranění kontroly |  |
| 221 | A | A221 | 2025-09-30 00:00:00 |  |
| 221 | B | B221 | 1.4.1 |  |
| 221 | C | C221 | n/a |  |
| 221 | D | D221 | 243 |  |
| 221 | E | E221 | Kontrola adekvátních atributů pro výpočet zálohy na daň nerezidentů  s prohlášením poplatníka daně |  |
| 221 | F | F221 | cJMHZ |  |
| 221 | G | G221 | změna kontroly |  |
| 221 | H | H221 | po revizi JDv, VZi, LRi - zkrácení chyb. hl. |  |
| 222 | A | A222 | 2025-07-31 00:00:00 |  |
| 222 | B | B222 | 1.4 final |  |
| 222 | C | C222 | ZP_TECH_POPIS_015 |  |
| 222 | D | D222 | 279 |  |
| 222 | E | E222 | Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P |  |
| 222 | F | F222 | DIS |  |
| 222 | G | G222 | přidání kontroly |  |
| 222 | H | H222 | přidání kontroly |  |
| 223 | A | A223 | 2025-07-31 00:00:00 |  |
| 223 | B | B223 | 1.4 final |  |
| 223 | C | C223 | ZP_TECH_POPIS_048 |  |
| 223 | D | D223 | 280 |  |
| 223 | E | E223 | Úhrn slev na pojistném zaměstnanců |  |
| 223 | F | F223 | cJMHZ |  |
| 223 | G | G223 | přidání kontroly |  |
| 223 | H | H223 | přidání kontroly |  |
| 224 | A | A224 | 2025-07-31 00:00:00 |  |
| 224 | B | B224 | 1.4.0.1 |  |
| 224 | C | C224 | n/a |  |
| 224 | D | D224 | 164 |  |
| 224 | E | E224 | Kontrola na uplatnění slevy na pojistném zaměstnavatele v rámci splatnosti pojistného |  |
| 224 | F | F224 | DIS |  |
| 224 | G | G224 | změna kontroly |  |
| 224 | H | H224 | změna vstupní podmínku pro verzi 1.4, atribut 10356 (náhrada za SIT01 - nyní IN35) |  |
| 225 | A | A225 | 2025-07-31 00:00:00 |  |
| 225 | B | B225 | 1.4.0.1 |  |
| 225 | C | C225 | n/a |  |
| 225 | D | D225 | 170 |  |
| 225 | E | E225 | Úhrn slev na pojistném zaměstnanců |  |
| 225 | F | F225 | DIS |  |
| 225 | G | G225 | změna kontroly |  |
| 225 | H | H225 | změna parametru ve výpočtu (LRi-07/29/2025) |  |
| 226 | A | A226 | 2025-08-12 00:00:00 |  |
| 226 | B | B226 | 1.4.0.1 |  |
| 226 | C | C226 | n/a |  |
| 226 | D | D226 | 195 |  |
| 226 | E | E226 | Kontrola zúčtovaného příjmu |  |
| 226 | F | F226 | DIS |  |
| 226 | G | G226 | změna kontroly |  |
| 226 | H | H226 | objevena chyba (JLo) - atr.: 10287, 10288 byly odstraněny 4.4.2025 |  |
| 227 | A | A227 | 2025-08-13 00:00:00 |  |
| 227 | B | B227 | 1.4.0.1 |  |
| 227 | C | C227 | n/a |  |
| 227 | D | D227 | 240 |  |
| 227 | E | E227 | Struktura storno hlášení (celého podání) |  |
| 227 | F | F227 | DIS |  |
| 227 | G | G227 | změna kontroly |  |
| 227 | H | H227 | nález testování 13135 - oprava kontroly MH idk 240 |  |
| 228 | A | A228 | 2025-08-14 00:00:00 |  |
| 228 | B | B228 | 1.4.0.1 |  |
| 228 | C | C228 | n/a |  |
| 228 | D | D228 | 4 |  |
| 228 | E | E228 | Vypočítané pojistné k úhradě |  |
| 228 | F | F228 | DIS |  |
| 228 | G | G228 | změna kontroly |  |
| 228 | H | H228 | revize DMa, změna textace chyb. hl., přidán atr do seznamu atributů |  |
| 229 | A | A229 | 2025-08-14 00:00:00 |  |
| 229 | B | B229 | 1.4.0.1 |  |
| 229 | C | C229 | n/a |  |
| 229 | D | D229 | 10 |  |
| 229 | E | E229 | Pojistné za zaměstnavatele u zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku |  |
| 229 | F | F229 | DIS |  |
| 229 | G | G229 | změna kontroly |  |
| 229 | H | H229 | revize DMa, změna textace chyb. hl. |  |
| 230 | A | A230 | 2025-08-14 00:00:00 |  |
| 230 | B | B230 | 1.4.0.1 |  |
| 230 | C | C230 | n/a |  |
| 230 | D | D230 | 41 |  |
| 230 | E | E230 | ID pracovněprávního vztahu v registru zaměstnance |  |
| 230 | F | F230 | DIS |  |
| 230 | G | G230 | odstranění kontroly |  |
| 230 | H | H230 | revize OCi - redundance s idk 264 |  |
| 231 | A | A231 | 2025-08-14 00:00:00 |  |
| 231 | B | B231 | 1.4.0.1 |  |
| 231 | C | C231 | n/a |  |
| 231 | D | D231 | 42 |  |
| 231 | E | E231 | Kontrola atributů v rámci slev  na pojistném jsou vázany k druhu činnosti v rozsahu 1 až 9 |  |
| 231 | F | F231 | DIS |  |
| 231 | G | G231 | změna kontroly |  |
| 231 | H | H231 | revize DMa, formalita - změna atributů v seznamu atributů |  |
| 232 | A | A232 | 2025-08-14 00:00:00 |  |
| 232 | B | B232 | 1.4.0.1 |  |
| 232 | C | C232 | n/a |  |
| 232 | D | D232 | 45 |  |
| 232 | E | E232 | Rozsah kratší pracovní/služební doby |  |
| 232 | F | F232 | DIS |  |
| 232 | G | G232 | změna kontroly |  |
| 232 | H | H232 | revize DMa, změna textace chyb. hl. |  |
| 233 | A | A233 | 2025-08-14 00:00:00 |  |
| 233 | B | B233 | 1.4.0.1 |  |
| 233 | C | C233 | n/a |  |
| 233 | D | D233 | 118 |  |
| 233 | E | E233 | Pojistné za zaměstnance |  |
| 233 | F | F233 | DIS |  |
| 233 | G | G233 | změna kontroly |  |
| 233 | H | H233 | revize DMa, formalita - změna textace popisu kontroly, význam nezměněn |  |
| 234 | A | A234 | 2025-08-14 00:00:00 |  |
| 234 | B | B234 | 1.4.0.1 |  |
| 234 | C | C234 | n/a |  |
| 234 | D | D234 | 162 |  |
| 234 | E | E234 | Je třeba vyplnit alespoň jeden typ vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a, b nebo c |  |
| 234 | F | F234 | DIS |  |
| 234 | G | G234 | změna kontroly |  |
| 234 | H | H234 | revize DMa, oprava znění kontroly |  |
| 235 | A | A235 | 2025-08-14 00:00:00 |  |
| 235 | B | B235 | 1.4.0.1 |  |
| 235 | C | C235 | n/a |  |
| 235 | D | D235 | 164 |  |
| 235 | E | E235 | Kontrola na uplatnění slevy na pojistném zaměstnavatele v rámci splatnosti pojistného |  |
| 235 | F | F235 | DIS |  |
| 235 | G | G235 | změna kontroly |  |
| 235 | H | H235 | revize DMa, oprava na původní text kontroly |  |
| 236 | A | A236 | 2025-08-14 00:00:00 |  |
| 236 | B | B236 | 1.4.0.1 |  |
| 236 | C | C236 | n/a |  |
| 236 | D | D236 | 165 |  |
| 236 | E | E236 | Kontrola vyplnění vyloučených dob dle  § 18 odst. 7 |  |
| 236 | F | F236 | DIS |  |
| 236 | G | G236 | změna kontroly |  |
| 236 | H | H236 | revize MKl - konzultováno a potvrzeno  s RKuf |  |
| 237 | A | A237 | 2025-08-14 00:00:00 |  |
| 237 | B | B237 | 1.4.0.1 |  |
| 237 | C | C237 | n/a |  |
| 237 | D | D237 | 167 |  |
| 237 | E | E237 | Pojistné za zaměstnavatele u zaměstnanců, kteří vykonávají rizikové zaměstnání |  |
| 237 | F | F237 | DIS |  |
| 237 | G | G237 | změna kontroly |  |
| 237 | H | H237 | revize DMa, změna textace chyb. hl., formalita - vylepšena formulace kontroly, význam je stejný |  |
| 238 | A | A238 | 2025-08-14 00:00:00 |  |
| 238 | B | B238 | 1.4.0.1 |  |
| 238 | C | C238 | n/a |  |
| 238 | D | D238 | 179 |  |
| 238 | E | E238 | Kontrola částky vyměřovacího základu zaměstnance, ze které je placeno pojistné, vůči vyměřovacímu základu zaměstnance |  |
| 238 | F | F238 | DIS |  |
| 238 | G | G238 | odstranění kontroly |  |
| 238 | H | H238 | revize DMa - rozhodnutí pro odstranění  |  |
| 239 | A | A239 | 2025-08-14 00:00:00 |  |
| 239 | B | B239 | 1.4.0.1 |  |
| 239 | C | C239 | n/a |  |
| 239 | D | D239 | 209 |  |
| 239 | E | E239 | Úhrn slev na pojistném zaměstnanců |  |
| 239 | F | F239 | cJMHZ |  |
| 239 | G | G239 | změna kontroly |  |
| 239 | H | H239 | revize DMa, vypuštění atr. 10490 |  |
| 240 | A | A240 | 2025-08-15 00:00:00 |  |
| 240 | B | B240 | 1.4.0.1 |  |
| 240 | C | C240 | n/a |  |
| 240 | D | D240 | 50 |  |
| 240 | E | E240 | Vyměřovací základ není vyplněn |  |
| 240 | F | F240 | DIS |  |
| 240 | G | G240 | změna kontroly |  |
| 240 | H | H240 | revize IMa - formalita - vylepšení popisu podmínky, změna textace chyb. hl. |  |
| 241 | A | A241 | 2025-08-15 00:00:00 |  |
| 241 | B | B241 | 1.4.0.1 |  |
| 241 | C | C241 | n/a |  |
| 241 | D | D241 | 55 |  |
| 241 | E | E241 | Datum do (průběh studia) je dřívější, než datum počátku studia |  |
| 241 | F | F241 | DIS |  |
| 241 | G | G241 | odstranění kontroly |  |
| 241 | H | H241 | revize IMa |  |
| 242 | A | A242 | 2025-08-15 00:00:00 |  |
| 242 | B | B242 | 1.4.0.1 |  |
| 242 | C | C242 | ZP_TECH_POPIS_018 |  |
| 242 | D | D242 | 249 |  |
| 242 | E | E242 | Kontrola vyplnění souhrnné vrstvy, že atribut Primární pracovněprávní vztah zaměstnance je vyplněn za právě jeden pracovně právní vztah zaměstnance u zaměstnavatele |  |
| 242 | F | F242 | cJMHZ |  |
| 242 | G | G242 | odstranění kontroly |  |
| 242 | H | H242 | oprava kontroly v rámci byznys zadání verze 1.4.prefinal - ZP_TECH_POPIS_018 |  |
| 243 | A | A243 | 2025-08-15 00:00:00 |  |
| 243 | B | B243 | 1.4.0.1 |  |
| 243 | C | C243 | n/a |  |
| 243 | D | D243 | 280 |  |
| 243 | E | E243 | Úhrn slev na pojistném zaměstnanců |  |
| 243 | F | F243 | cJMHZ |  |
| 243 | G | G243 | změna kontroly |  |
| 243 | H | H243 | revize DMa, vypuštění atr. 10546 |  |
| 244 | A | A244 | 2025-08-15 00:00:00 |  |
| 244 | B | B244 | 1.4.0.1 |  |
| 244 | C | C244 | n/a |  |
| 244 | D | D244 | 269 |  |
| 244 | E | E244 | Kontrola Úhrn vyměřovacích základů zaměstnanců, kteří mají nárok na slevu na pojistném zaměstnance |  |
| 244 | F | F244 | cJMHZ |  |
| 244 | G | G244 | změna kontroly |  |
| 244 | H | H244 | revize DMa, změna textace chyb. hl., formalita - vylepšen popis atributu 10546 |  |
| 245 | A | A245 | 2025-08-15 00:00:00 |  |
| 245 | B | B245 | 1.4.1 |  |
| 245 | C | C245 | n/a |  |
| 245 | D | D245 | 270 |  |
| 245 | E | E245 | Úhrn slev na pojistném zaměstnanců |  |
| 245 | F | F245 | DIS |  |
| 245 | G | G245 | změna kontroly |  |
| 245 | H | H245 | revize DMa, změna systému kontroly z cJHMZ na DIS |  |
| 246 | A | A246 | 2025-08-15 00:00:00 |  |
| 246 | B | B246 | 1.4.0.1 |  |
| 246 | C | C246 | n/a |  |
| 246 | D | D246 | 274 |  |
| 246 | E | E246 | Odpovídající výše slevy na pojistném zaměstnance |  |
| 246 | F | F246 | DIS |  |
| 246 | G | G246 | odstranění kontroly |  |
| 246 | H | H246 | revize DMa |  |
| 247 | A | A247 | 2025-08-15 00:00:00 |  |
| 247 | B | B247 | 1.4.0.1 |  |
| 247 | C | C247 | n/a |  |
| 247 | D | D247 | 275 |  |
| 247 | E | E247 | Kontrola výlučnosti uplatnění slevy |  |
| 247 | F | F247 | DIS |  |
| 247 | G | G247 | změna kontroly |  |
| 247 | H | H247 | revize DMa, změna textace chyb. hl. |  |
| 248 | A | A248 | 2025-08-15 00:00:00 |  |
| 248 | B | B248 | 1.4.0.1 |  |
| 248 | C | C248 | n/a |  |
| 248 | D | D248 | 284 |  |
| 248 | E | E248 | Kontrola vyplnění min. jednoho atributu pro částku vyměřovacího základu zaměstnance, ze které je odváděno pojistné |  |
| 248 | F | F248 | DIS |  |
| 248 | G | G248 | změna kontroly |  |
| 248 | H | H248 | revize DMa, změna textace chyb. hl., upřesnění podmínky v kontrole |  |
| 249 | A | A249 | 2025-08-15 00:00:00 |  |
| 249 | B | B249 | 1.4.0.1 |  |
| 249 | C | C249 | n/a |  |
| 249 | D | D249 | 285 |  |
| 249 | E | E249 | Kontrola sumy částek vyměřovacího základu zaměstnance |  |
| 249 | F | F249 | DIS |  |
| 249 | G | G249 | odstranění kontroly |  |
| 249 | H | H249 | revize DMa |  |
| 250 | A | A250 | 2025-08-15 00:00:00 |  |
| 250 | B | B250 | 1.4.0.1 |  |
| 250 | C | C250 | n/a |  |
| 250 | D | D250 | 288 |  |
| 250 | E | E250 | Kontrola slev při nulový počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb. |  |
| 250 | F | F250 | DIS |  |
| 250 | G | G250 | odstranění kontroly |  |
| 250 | H | H250 | revize DMa |  |
| 251 | A | A251 | 2025-08-16 00:00:00 |  |
| 251 | B | B251 | 1.4.0.1 |  |
| 251 | C | C251 | n/a |  |
| 251 | D | D251 | 58 |  |
| 251 | E | E251 | Počet kalendářních dnů trvání pojištění v daném kalendářním měsíci |  |
| 251 | F | F251 | DIS |  |
| 251 | G | G251 | změna kontroly |  |
| 251 | H | H251 | revize IMa - upřesněna kontrola |  |
| 252 | A | A252 | 2025-08-16 00:00:00 |  |
| 252 | B | B252 | 1.4.0.1 |  |
| 252 | C | C252 | n/a |  |
| 252 | D | D252 | 59 |  |
| 252 | E | E252 | Vyměřovací základ s podmínkami |  |
| 252 | F | F252 | DIS |  |
| 252 | G | G252 | změna kontroly |  |
| 252 | H | H252 | revize IMa - kontrola, výčet atributů |  |
| 253 | A | A253 | 2025-08-16 00:00:00 |  |
| 253 | B | B253 | 1.4.0.1 |  |
| 253 | C | C253 | n/a |  |
| 253 | D | D253 | 65 |  |
| 253 | E | E253 | Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P |  |
| 253 | F | F253 | DIS |  |
| 253 | G | G253 | změna kontroly |  |
| 253 | H | H253 | revize AKr - formalita, oblast atributů |  |
| 254 | A | A254 | 2025-08-16 00:00:00 |  |
| 254 | B | B254 | 1.4.0.1 |  |
| 254 | C | C254 | n/a |  |
| 254 | D | D254 | 79 |  |
| 254 | E | E254 | Roční zúčtování záloh - Přeplatek nebo nedoplatek z ročního zúčtování |  |
| 254 | F | F254 | DIS |  |
| 254 | G | G254 | změna kontroly |  |
| 254 | H | H254 | revize AKr - oprava kontroly, oprava výčtu atributů |  |
| 255 | A | A255 | 2025-08-16 00:00:00 |  |
| 255 | B | B255 | 1.4.0.1 |  |
| 255 | C | C255 | n/a |  |
| 255 | D | D255 | 80 |  |
| 255 | E | E255 | Dítě, za něhož je uplatňována sleva, musí být mladší než 26 let |  |
| 255 | F | F255 | DIS |  |
| 255 | G | G255 | změna kontroly |  |
| 255 | H | H255 | revize AKr - doplnění kontroly, změna chyb. hl. |  |
| 256 | A | A256 | 2025-08-16 00:00:00 |  |
| 256 | B | B256 | 1.4.0.1 |  |
| 256 | C | C256 | n/a |  |
| 256 | D | D256 | 87 |  |
| 256 | E | E256 | Správnost kódu ELDP |  |
| 256 | F | F256 | DIS |  |
| 256 | G | G256 | změna kontroly |  |
| 256 | H | H256 | revize IMa - formalita, oblast atributů |  |
| 257 | A | A257 | 2025-08-16 00:00:00 |  |
| 257 | B | B257 | 1.4.0.1 |  |
| 257 | C | C257 | n/a |  |
| 257 | D | D257 | 98 |  |
| 257 | E | E257 | Počet dní nesmí být vyšší než počet kalendářních dní v daném měsíci |  |
| 257 | F | F257 | DIS |  |
| 257 | G | G257 | změna kontroly |  |
| 257 | H | H257 | revize IMa - formalita, výčet atributů |  |
| 258 | A | A258 | 2025-08-16 00:00:00 |  |
| 258 | B | B258 | 1.4.0.1 |  |
| 258 | C | C258 | n/a |  |
| 258 | D | D258 | 99 |  |
| 258 | E | E258 | "Platnost kódu od/do" se týká aktuálního měsíce |  |
| 258 | F | F258 | DIS |  |
| 258 | G | G258 | změna kontroly |  |
| 258 | H | H258 | revize IMa - formalita, název kontroly, oblast atributů |  |
| 259 | A | A259 | 2025-08-16 00:00:00 |  |
| 259 | B | B259 | 1.4.0.1 |  |
| 259 | C | C259 | n/a |  |
| 259 | D | D259 | 100 |  |
| 259 | E | E259 | Platnost kódu od je menší než Platnost kódu do |  |
| 259 | F | F259 | DIS |  |
| 259 | G | G259 | změna kontroly |  |
| 259 | H | H259 | revize IMa - formalita, oblast atributů |  |
| 260 | A | A260 | 2025-08-16 00:00:00 |  |
| 260 | B | B260 | 1.4.0.1 |  |
| 260 | C | C260 | n/a |  |
| 260 | D | D260 | 109 |  |
| 260 | E | E260 | Kontrola na Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR |  |
| 260 | F | F260 | DIS |  |
| 260 | G | G260 | změna kontroly |  |
| 260 | H | H260 | revize AKr - změna chyb. hl. |  |
| 261 | A | A261 | 2025-08-16 00:00:00 |  |
| 261 | B | B261 | 1.4.1 |  |
| 261 | C | C261 | ZP_TECH_POPIS_061 |  |
| 261 | D | D261 | 293 |  |
| 261 | E | E261 | Datum od (průběh studia) |  |
| 261 | F | F261 | DIS |  |
| 261 | G | G261 | přidání kontroly |  |
| 261 | H | H261 | revize IMa |  |
| 262 | A | A262 | 2025-08-16 00:00:00 |  |
| 262 | B | B262 | 1.4.1 |  |
| 262 | C | C262 | ZP_TECH_POPIS_061 |  |
| 262 | D | D262 | 294 |  |
| 262 | E | E262 | Datum do (průběh studia) |  |
| 262 | F | F262 | DIS |  |
| 262 | G | G262 | přidání kontroly |  |
| 262 | H | H262 | revize IMa |  |
| 263 | A | A263 | 2025-08-16 00:00:00 |  |
| 263 | B | B263 | 1.4.1 |  |
| 263 | C | C263 | n/a |  |
| 263 | D | D263 | 112 |  |
| 263 | E | E263 | Při uplatnění daňového zvýhodnění na děti je vyplněno alespoň 1 dítě (roční zúčtování) |  |
| 263 | F | F263 | DIS |  |
| 263 | G | G263 | změna kontroly |  |
| 263 | H | H263 | revize AKr - doplnění kontroly |  |
| 264 | A | A264 | 2025-08-16 00:00:00 |  |
| 264 | B | B264 | 1.4.0.1 |  |
| 264 | C | C264 | n/a |  |
| 264 | D | D264 | 110 |  |
| 264 | E | E264 | Pořadí pro určení výše daňového zvýhodnění tvoří řadu |  |
| 264 | F | F264 | DIS |  |
| 264 | G | G264 | změna kontroly |  |
| 264 | H | H264 | revize AKr - doplnění detailu do výčtu atributů v kontrole, změna chyb. hl. |  |
| 265 | A | A265 | 2025-08-16 00:00:00 |  |
| 265 | B | B265 | 1.4.0.1 |  |
| 265 | C | C265 | n/a |  |
| 265 | D | D265 | 111 |  |
| 265 | E | E265 | Počet měsíců uplatnění slevy souhlasí s možným počtem uplatnění |  |
| 265 | F | F265 | DIS |  |
| 265 | G | G265 | změna kontroly |  |
| 265 | H | H265 | revize AKr - změna chyb. hl. |  |
| 266 | A | A266 | 2025-08-16 00:00:00 |  |
| 266 | B | B266 | 1.4.0.1 |  |
| 266 | C | C266 | n/a |  |
| 266 | D | D266 | 124 |  |
| 266 | E | E266 | Kontrola vyplnění údaje za manžela / manželku (roční zúčtování) |  |
| 266 | F | F266 | DIS |  |
| 266 | G | G266 | změna kontroly |  |
| 266 | H | H266 | revize AKr - formalita, doplnění detailu do výčtu atributů v kontrole |  |
| 267 | A | A267 | 2025-08-16 00:00:00 |  |
| 267 | B | B267 | 1.4.0.1 |  |
| 267 | C | C267 | n/a |  |
| 267 | D | D267 | 126 |  |
| 267 | E | E267 | Kontrola na vyplnění údajů další vyživující osoby (roční zúčtování) |  |
| 267 | F | F267 | DIS |  |
| 267 | G | G267 | změna kontroly |  |
| 267 | H | H267 | revize AKr - formalita, doplnění detailu do výčtu atributů v kontrole |  |
| 268 | A | A268 | 2025-08-16 00:00:00 |  |
| 268 | B | B268 | 1.4.0.1 |  |
| 268 | C | C268 | n/a |  |
| 268 | D | D268 | 127 |  |
| 268 | E | E268 | Kontrola na vyplnění údajů další vyživující osoby |  |
| 268 | F | F268 | DIS |  |
| 268 | G | G268 | změna kontroly |  |
| 268 | H | H268 | revize AKr - formalita, doplnění detailu do výčtu atributů v kontrole |  |
| 269 | A | A269 | 2025-08-16 00:00:00 |  |
| 269 | B | B269 | 1.4.0.1 |  |
| 269 | C | C269 | n/a |  |
| 269 | D | D269 | 128 |  |
| 269 | E | E269 | Při uplatnění daňového zvýhodnění na děti je vyplněno alespoň 1 dítě |  |
| 269 | F | F269 | DIS |  |
| 269 | G | G269 | změna kontroly |  |
| 269 | H | H269 | revize AKr - formalita, doplnění detailu do výčtu atributů v kontrole |  |
| 270 | A | A270 | 2025-08-16 00:00:00 |  |
| 270 | B | B270 | 1.4.0.1 |  |
| 270 | C | C270 | n/a |  |
| 270 | D | D270 | 133 |  |
| 270 | E | E270 | Kontrola správnosti Kódu ELDP při zaměstnání malého rozsahu |  |
| 270 | F | F270 | DIS |  |
| 270 | G | G270 | změna kontroly |  |
| 270 | H | H270 | revize IMa - formalita, oblast atributů |  |
| 271 | A | A271 | 2025-08-16 00:00:00 |  |
| 271 | B | B271 | 1.4.1 |  |
| 271 | C | C271 | n/a |  |
| 271 | D | D271 | 242 |  |
| 271 | E | E271 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů s prohlášením poplatníka daně |  |
| 271 | F | F271 | DIS |  |
| 271 | G | G271 | změna kontroly |  |
| 271 | H | H271 | revize AKr - změna chyb. hl. |  |
| 272 | A | A272 | 2025-08-16 00:00:00 |  |
| 272 | B | B272 | 1.4.1 |  |
| 272 | C | C272 | n/a |  |
| 272 | D | D272 | 243 |  |
| 272 | E | E272 | Kontrola adekvátních atributů pro výpočet zálohy na daň nerezidentů  s prohlášením poplatníka daně |  |
| 272 | F | F272 | DIS |  |
| 272 | G | G272 | změna kontroly |  |
| 272 | H | H272 | revize AKr - změna chyb. hl. |  |
| 273 | A | A273 | 2025-08-16 00:00:00 |  |
| 273 | B | B273 | 1.4.0.1 |  |
| 273 | C | C273 | n/a |  |
| 273 | D | D273 | 148 |  |
| 273 | E | E273 | Specifická právní skutečnost |  |
| 273 | F | F273 | DIS |  |
| 273 | G | G273 | změna kontroly |  |
| 273 | H | H273 | revize AKr - formalita, typ formuláře  |  |
| 274 | A | A274 | 2025-08-16 00:00:00 |  |
| 274 | B | B274 | 1.4.1 |  |
| 274 | C | C274 | n/a |  |
| 274 | D | D274 | 215 |  |
| 274 | E | E274 | Kontrola věku dítěte pro uplatnění slevy (měsíční zúčtovaní) |  |
| 274 | F | F274 | DIS |  |
| 274 | G | G274 | změna kontroly |  |
| 274 | H | H274 | revize AKr - doplnění kontroly, změna chyb. hl. |  |
| 275 | A | A275 | 2025-08-16 00:00:00 |  |
| 275 | B | B275 | 1.4.1 |  |
| 275 | C | C275 | ZP_TECH_POPIS_059 |  |
| 275 | D | D275 | 304 |  |
| 275 | E | E275 | Vyplnění položky Základ pro výpočet daně |  |
| 275 | F | F275 | DIS |  |
| 275 | G | G275 | přidání kontroly |  |
| 275 | H | H275 | po revizi AKr  |  |
| 276 | A | A276 | 2025-08-16 00:00:00 |  |
| 276 | B | B276 | 1.4.0.1 |  |
| 276 | C | C276 | n/a |  |
| 276 | D | D276 | 195 |  |
| 276 | E | E276 | Kontrola zúčtovaného příjmu |  |
| 276 | F | F276 | DIS |  |
| 276 | G | G276 | odstranění kontroly |  |
| 276 | H | H276 | revize AKr |  |
| 277 | A | A277 | 2025-08-16 00:00:00 |  |
| 277 | B | B277 | 1.4.0.1 |  |
| 277 | C | C277 | n/a |  |
| 277 | D | D277 | 214 |  |
| 277 | E | E277 | Kontrola věku dítěte pro uplatnění slevy (roční zúčtovaní) |  |
| 277 | F | F277 | DIS |  |
| 277 | G | G277 | změna kontroly |  |
| 277 | H | H277 | revize AKr - doplnění kontroly, změna chyb. hl. |  |
| 278 | A | A278 | 2025-08-16 00:00:00 |  |
| 278 | B | B278 | 1.4.0.1 |  |
| 278 | C | C278 | n/a |  |
| 278 | D | D278 | 248 |  |
| 278 | E | E278 | Kontrola vyplnění dat souhrnné vrstvy za zaměstnance jen pro primární pracovněprávní vztah zaměstnance |  |
| 278 | F | F278 | DIS |  |
| 278 | G | G278 | změna kontroly |  |
| 278 | H | H278 | revize AKr - změna formulace kontroly, změna chyb. hl. |  |
| 279 | A | A279 | 2025-08-16 00:00:00 |  |
| 279 | B | B279 | 1.4.0.1 |  |
| 279 | C | C279 | n/a |  |
| 279 | D | D279 | 265 |  |
| 279 | E | E279 | Pořadí pro určení výše daňového zvýhodnění |  |
| 279 | F | F279 | DIS |  |
| 279 | G | G279 | změna kontroly |  |
| 279 | H | H279 | revize AKr - formalita, typ formuláře |  |
| 280 | A | A280 | 2025-08-16 00:00:00 |  |
| 280 | B | B280 | 1.4.0.1 |  |
| 280 | C | C280 | n/a |  |
| 280 | D | D280 | 241 |  |
| 280 | E | E280 | Kontrola konzistence metatributů GUID pro celé podání |  |
| 280 | F | F280 | cJMHZ |  |
| 280 | G | G280 | změna kontroly |  |
| 280 | H | H280 | revize KMi - formalita, změna gestora |  |
| 281 | A | A281 | 2025-08-16 00:00:00 |  |
| 281 | B | B281 | 1.4.0.1 |  |
| 281 | C | C281 | n/a |  |
| 281 | D | D281 | 281 |  |
| 281 | E | E281 | Kontrola nevyplnění dat pro rozklad při nulových náhradách mzdy zúčtované |  |
| 281 | F | F281 | DIS |  |
| 281 | G | G281 | změna kontroly |  |
| 281 | H | H281 | revize MKl - změna podmínky, odstranění atributů |  |
| 282 | A | A282 | 2025-08-16 00:00:00 |  |
| 282 | B | B282 | 1.4.0.1 |  |
| 282 | C | C282 | n/a |  |
| 282 | D | D282 | 287 |  |
| 282 | E | E282 | Kontrola nevyplnění atributů pojištění a vyměřovacího základu. |  |
| 282 | F | F282 | DIS |  |
| 282 | G | G282 | odstranění kontroly |  |
| 282 | H | H282 | revize IMa |  |
| 283 | A | A283 | 2025-08-18 00:00:00 |  |
| 283 | B | B283 | 1.4.0.1 |  |
| 283 | C | C283 | n/a |  |
| 283 | D | D283 | 3 |  |
| 283 | E | E283 | Sleva na pojistném |  |
| 283 | F | F283 | DIS |  |
| 283 | G | G283 | změna kontroly |  |
| 283 | H | H283 | revize DMa - změna systému kontroly na DIS => nepropustná |  |
| 284 | A | A284 | 2025-08-18 00:00:00 |  |
| 284 | B | B284 | 1.4.0.1 |  |
| 284 | C | C284 | ZP_TECH_POPIS_018 |  |
| 284 | D | D284 | 250 |  |
| 284 | E | E284 | Kontrola existence souhrných dat zaměstnance při opravném podání součásti individualizované části |  |
| 284 | F | F284 | cJMHZ |  |
| 284 | G | G284 | odstranění kontroly |  |
| 284 | H | H284 | oprava kontroly v rámci byznys zadání verze 1.4.prefinal - ZP_TECH_POPIS_018 |  |
| 285 | A | A285 | 2025-08-18 00:00:00 |  |
| 285 | B | B285 | 1.4.0.1 |  |
| 285 | C | C285 | n/a |  |
| 285 | D | D285 | 7 |  |
| 285 | E | E285 | Úhrn vyměřovacích základů zaměstnanců zaměstnavatele, kteří nevykonávají činnost v rizikovém zaměstnání nebo činnost zdravotnického záchranáře nebo člena jednotky HZS podniku je roven vyměřovacím základům všech příslušných zaměstnanců |  |
| 285 | F | F285 | cJMHZ |  |
| 285 | G | G285 | změna kontroly |  |
| 285 | H | H285 | revize DMa - formalita, delší zápis atributu v chyb. hl.  |  |
| 286 | A | A286 | 2025-08-19 00:00:00 |  |
| 286 | B | B286 | 1.4.0.1 |  |
| 286 | C | C286 | n/a |  |
| 286 | D | D286 | 8 |  |
| 286 | E | E286 | Pojistné za zaměstnavatele u zaměstnanců,  kteří nevykonávají činnost v rizikovém zaměstnání nebo činnost zdravotnického záchranáře nebo člena jednotky HZS podniku |  |
| 286 | F | F286 | DIS |  |
| 286 | G | G286 | změna kontroly |  |
| 286 | H | H286 | revize DMa - název kontroly, změna chyb. hlášky  |  |
| 287 | A | A287 | 2025-08-19 00:00:00 |  |
| 287 | B | B287 | 1.4.0.1 |  |
| 287 | C | C287 | n/a |  |
| 287 | D | D287 | 10 |  |
| 287 | E | E287 | Pojistné za zaměstnavatele u zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku |  |
| 287 | F | F287 | DIS |  |
| 287 | G | G287 | změna kontroly |  |
| 287 | H | H287 | revize DMa - změna chyb. Hlášky |  |
| 288 | A | A288 | 2025-08-19 00:00:00 |  |
| 288 | B | B288 | 1.4.0.1 |  |
| 288 | C | C288 | n/a |  |
| 288 | D | D288 | 78 |  |
| 288 | E | E288 | Přeplatek nebo nedoplatek z ročního zúčtování je roven součtu příslušných položek |  |
| 288 | F | F288 | DIS |  |
| 288 | G | G288 | změna kontroly |  |
| 288 | H | H288 | revize JLo (12-08-2025 13:14) - upřesnění kontroly, dat. scénář  |  |
| 289 | A | A289 | 2025-08-19 00:00:00 |  |
| 289 | B | B289 | 1.4.0.1 |  |
| 289 | C | C289 | n/a |  |
| 289 | D | D289 | 79 |  |
| 289 | E | E289 | Roční zúčtování záloh - Přeplatek nebo nedoplatek z ročního zúčtování |  |
| 289 | F | F289 | DIS |  |
| 289 | G | G289 | změna kontroly |  |
| 289 | H | H289 | revize JLo (12-08-2025 13:14) - upřesnění kontroly, dat. scénář  |  |
| 290 | A | A290 | 2025-09-30 00:00:00 |  |
| 290 | B | B290 | 1.4.1 |  |
| 290 | C | C290 | n/a |  |
| 290 | D | D290 | 244 |  |
| 290 | E | E290 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů bez prohlášení poplatníka - zálohová daň |  |
| 290 | F | F290 | cJMHZ |  |
| 290 | G | G290 | změna kontroly |  |
| 290 | H | H290 | po revizi JDv, VZi, LRi - zkrácení chyb. hl. |  |
| 291 | A | A291 | 2025-10-02 00:00:00 |  |
| 291 | B | B291 | 1.4.1 |  |
| 291 | C | C291 | n/a |  |
| 291 | D | D291 | 247 |  |
| 291 | E | E291 | Kontrola prerekvizit pro výpočet daně členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR |  |
| 291 | F | F291 | cJMHZ |  |
| 291 | G | G291 | přidání kontroly |  |
| 291 | H | H291 | po revizi JDv, PSl - přesun kontroly kvůli 10068 na cJHMZ |  |
| 292 | A | A292 | 2025-07-31 00:00:00 |  |
| 292 | B | B292 | 1.4.1 |  |
| 292 | C | C292 | ZP_TECH_POPIS_060 |  |
| 292 | D | D292 | 289 |  |
| 292 | E | E292 | Kontrola součásti individualizované části na uplatnění slevy pojistného zaměstnavatele (znevýhodněné skupiny) na zaevidované "Oznámení záměru uplatňovat slevu na pojistném za zaměstnance" s dopadem na PVPOJ - I |  |
| 292 | F | F292 | cJMHZ |  |
| 292 | G | G292 | přidání kontroly |  |
| 292 | H | H292 | po konzultaci přídání kontroly (SZu-7/31/2025) |  |
| 293 | A | A293 | 2025-08-19 00:00:00 |  |
| 293 | B | B293 | 1.4.1 |  |
| 293 | C | C293 | ZP_TECH_POPIS_060 |  |
| 293 | D | D293 | 289 |  |
| 293 | E | E293 | Kontrola uplatnění slevy na pojistném zaměstnavatele za zaměstnance, za kterého byl oznámen záměr uplatňovat tuto slevu |  |
| 293 | F | F293 | cJMHZ |  |
| 293 | G | G293 | změna kontroly |  |
| 293 | H | H293 | revize DMa - redefinice celé kontroly  |  |
| 294 | A | A294 | 2025-08-19 00:00:00 |  |
| 294 | B | B294 | 1.4.1 |  |
| 294 | C | C294 | ZP_TECH_POPIS_063 |  |
| 294 | D | D294 | 296 |  |
| 294 | E | E294 | Sleva na pojistném zaměstnanců v ovocnářství jen z DPP |  |
| 294 | F | F294 | DIS |  |
| 294 | G | G294 | přidání kontroly |  |
| 294 | H | H294 | revize DMa |  |
| 295 | A | A295 | 2025-08-21 00:00:00 |  |
| 295 | B | B295 | 1.4.1 |  |
| 295 | C | C295 | ZP_TECH_POPIS_060 |  |
| 295 | D | D295 | 289 |  |
| 295 | E | E295 | Kontrola uplatnění slevy na pojistném zaměstnavatele za zaměstnance, za kterého byl oznámen záměr uplatňovat tuto slevu |  |
| 295 | F | F295 | cJMHZ |  |
| 295 | G | G295 | změna kontroly |  |
| 295 | H | H295 | po revizi MSHr, JDv - změna na propustnou |  |
| 296 | A | A296 | 2025-07-31 00:00:00 |  |
| 296 | B | B296 | 1.4.1 |  |
| 296 | C | C296 | ZP_TECH_POPIS_060 |  |
| 296 | D | D296 | 290 |  |
| 296 | E | E296 | Kontrola součásti individualizované části na uplatnění slevy pojistného zaměstnavatele (znevýhodněné skupiny) na zaevidované "Oznámení záměru uplatňovat slevu na pojistném za zaměstnance" s dopadem na PVPOJ - III |  |
| 296 | F | F296 | cJMHZ |  |
| 296 | G | G296 | přidání kontroly |  |
| 296 | H | H296 | po konzultaci přídání kontroly (SZu-7/31/2025) |  |
| 297 | A | A297 | 2025-08-19 00:00:00 |  |
| 297 | B | B297 | 1.4.1 |  |
| 297 | C | C297 | n/a |  |
| 297 | D | D297 | 216 |  |
| 297 | E | E297 | Kontrola součtů vyměřovacího základu zaměstnance |  |
| 297 | F | F297 | DIS |  |
| 297 | G | G297 | změna kontroly |  |
| 297 | H | H297 | revize JLo (12-08-2025 13:14) - upřesnění kontroly, dat. scénář  |  |
| 298 | A | A298 | 2025-08-19 00:00:00 |  |
| 298 | B | B298 | 1.4.1 |  |
| 298 | C | C298 | n/a |  |
| 298 | D | D298 | 299 |  |
| 298 | E | E298 | Kontrola datumu pojištění od a do v průběhu pojištění v měsíci |  |
| 298 | F | F298 | DIS |  |
| 298 | G | G298 | přidání kontroly |  |
| 298 | H | H298 | po revizi JKo, VZi, JDv - přidána kontrola |  |
| 299 | A | A299 | 2025-08-19 00:00:00 |  |
| 299 | B | B299 | 1.4.0.1 |  |
| 299 | C | C299 | n/a |  |
| 299 | D | D299 | 142 |  |
| 299 | E | E299 | Úhrn vyměřovacích základů zaměstnanců zaměstnavatele, kteří vykonávají činnost v rizikovém zaměstnání |  |
| 299 | F | F299 | cJMHZ |  |
| 299 | G | G299 | změna kontroly |  |
| 299 | H | H299 | revize DMa - změna chyb. Hlášky |  |
| 300 | A | A300 | 2025-08-19 00:00:00 |  |
| 300 | B | B300 | 1.4.0.1 |  |
| 300 | C | C300 | n/a |  |
| 300 | D | D300 | 9 |  |
| 300 | E | E300 | Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku |  |
| 300 | F | F300 | cJMHZ |  |
| 300 | G | G300 | změna kontroly |  |
| 300 | H | H300 | revize DMa - změna chyb. Hlášky |  |
| 301 | A | A301 | 2025-08-20 00:00:00 |  |
| 301 | B | B301 | 1.4.0.1 |  |
| 301 | C | C301 | n/a |  |
| 301 | D | D301 | 73 |  |
| 301 | E | E301 | Vyplnění položky Základ pro výpočet zálohy na daň |  |
| 301 | F | F301 | DIS |  |
| 301 | G | G301 | odstranění kontroly |  |
| 301 | H | H301 | po revizi VZi, JDv, HKy, AKr - test. nález / změna byznys zadání |  |
| 302 | A | A302 | 2025-08-20 00:00:00 |  |
| 302 | B | B302 | 1.4.0.1 |  |
| 302 | C | C302 | n/a |  |
| 302 | D | D302 | 230 |  |
| 302 | E | E302 | Kontrola kolize pořadí dítěte v měsíci (roční zúčtovaní) |  |
| 302 | F | F302 | cJMHZ |  |
| 302 | G | G302 | změna kontroly |  |
| 302 | H | H302 | po revizi Akr, HKy - změna na propustnou, systém kontroly na cJMHZ |  |
| 303 | A | A303 | 2025-08-20 00:00:00 |  |
| 303 | B | B303 | 1.4.1 |  |
| 303 | C | C303 | n/a |  |
| 303 | D | D303 | 292 |  |
| 303 | E | E303 | Kontrola věku dítěte pro uplatnění - II (výsledek ročního zúčtování sleva na manžela/manželku)  |  |
| 303 | F | F303 | cJMHZ |  |
| 303 | G | G303 | odstranění kontroly |  |
| 303 | H | H303 | po revizi Akr, HKy - změna na nepropustnou, systém kontroly na DIS, dopřesnění kontroly (část 1c)  |  |
| 304 | A | A304 | 2025-08-20 00:00:00 |  |
| 304 | B | B304 | 1.4.1 |  |
| 304 | C | C304 | n/a |  |
| 304 | D | D304 | 292 |  |
| 304 | E | E304 | Kontrola věku dítěte pro uplatnění - II (výsledek ročního zúčtování sleva na manžela/manželku)  |  |
| 304 | F | F304 | DIS |  |
| 304 | G | G304 | přidání kontroly |  |
| 304 | H | H304 | po revizi Akr, HKy - změna na nepropustnou, systém kontroly na DIS, dopřesnění kontroly (část 1c)  |  |
| 305 | A | A305 | 2025-08-21 00:00:00 |  |
| 305 | B | B305 | 1.4.1 |  |
| 305 | C | C305 | n/a |  |
| 305 | D | D305 | 35 |  |
| 305 | E | E305 | Počet neodpracovaných hodin z důvodu čerpání dovolené na zotavenou x náhrady mzdy za dovolenou |  |
| 305 | F | F305 | DIS |  |
| 305 | G | G305 | změna kontroly |  |
| 305 | H | H305 | po revizi JDv - změna kontroly systému na DIS |  |
| 306 | A | A306 | 2025-08-21 00:00:00 |  |
| 306 | B | B306 | 1.4.1 |  |
| 306 | C | C306 | n/a |  |
| 306 | D | D306 | 235 |  |
| 306 | E | E306 | Neodpovídá skutečný počet formulářů |  |
| 306 | F | F306 | DIS |  |
| 306 | G | G306 | změna kontroly |  |
| 306 | H | H306 | po revizi JDv, PMy, LRi - zvětšen detail kontroly |  |
| 307 | A | A307 | 2025-08-19 00:00:00 |  |
| 307 | B | B307 | 1.4.1 |  |
| 307 | C | C307 | budoucí změn. požadavek ozuspoj |  |
| 307 | D | D307 | 290 |  |
| 307 | E | E307 | Kontrola na výši slevy na pojistném zaměstnavatele uplatněné v opravném hlášení podaném po zákonné lhůtě |  |
| 307 | F | F307 | cJMHZ |  |
| 307 | G | G307 | změna kontroly |  |
| 307 | H | H307 | revize DMa - redefinice celé kontroly  |  |
| 308 | A | A308 | 2025-08-21 00:00:00 |  |
| 308 | B | B308 | 1.4.1 |  |
| 308 | C | C308 | budoucí změn. požadavek ozuspoj |  |
| 308 | D | D308 | 290 |  |
| 308 | E | E308 | Kontrola na výši slevy na pojistném zaměstnavatele uplatněné v opravném hlášení podaném po zákonné lhůtě |  |
| 308 | F | F308 | cJMHZ |  |
| 308 | G | G308 | změna kontroly |  |
| 308 | H | H308 | po revizi MSHr, JDv - změna na propustnou |  |
| 309 | A | A309 | 2025-07-31 00:00:00 |  |
| 309 | B | B309 | 1.4.1 |  |
| 309 | C | C309 | budoucí změn. požadavek ozuspoj |  |
| 309 | D | D309 | 291 |  |
| 309 | E | E309 | Kontrola součásti individualizované části na uplatnění slevy pojistného zaměstnavatele (znevýhodněné skupiny) na zaevidované "Oznámení záměru uplatňovat slevu na pojistném za zaměstnance" s dopadem na PVPOJ - II |  |
| 309 | F | F309 | cJMHZ |  |
| 309 | G | G309 | přidání kontroly |  |
| 309 | H | H309 | po konzultaci přídání kontroly (SZu-7/31/2025) |  |
| 310 | A | A310 | 2025-08-19 00:00:00 |  |
| 310 | B | B310 | 1.4.1 |  |
| 310 | C | C310 | budoucí změn. požadavek ozuspoj |  |
| 310 | D | D310 | 291 |  |
| 310 | E | E310 | Kontrola platnosti záměru ve vztahu k zaměstnání, z něhož je sleva na pojistném zaměstnavatele za zaměstnance uplatňována |  |
| 310 | F | F310 | cJMHZ |  |
| 310 | G | G310 | změna kontroly |  |
| 310 | H | H310 | revize DMa - redefinice celé kontroly  |  |
| 311 | A | A311 | 2025-08-21 00:00:00 |  |
| 311 | B | B311 | 1.4.0.1 |  |
| 311 | C | C311 | n/a |  |
| 311 | D | D311 | 205 |  |
| 311 | E | E311 | Řádné podání musí obsahovat min. jednu součást individualizované části. |  |
| 311 | F | F311 | DIS |  |
| 311 | G | G311 | změna kontroly |  |
| 311 | H | H311 | po revizi JDv - formalita, změna na nepropustnou (kontrola je na DIS, je pouze nepropustná) |  |
| 312 | A | A312 | 2025-08-21 00:00:00 |  |
| 312 | B | B312 | 1.4.0.1 |  |
| 312 | C | C312 | n/a |  |
| 312 | D | D312 | 300 |  |
| 312 | E | E312 | Kontrola na celkový počet formulářů v prvním dílčím podání |  |
| 312 | F | F312 | DIS |  |
| 312 | G | G312 | přidání kontroly |  |
| 312 | H | H312 | po revizi JDv, PMy, LRi - přidání kontroly |  |
| 313 | A | A313 | 2025-08-21 00:00:00 |  |
| 313 | B | B313 | 1.4.0.1 |  |
| 313 | C | C313 | n/a |  |
| 313 | D | D313 | 301 |  |
| 313 | E | E313 | Kontrola na celkový počet formulářů v druhém a dalších dílčích podáních |  |
| 313 | F | F313 | DIS |  |
| 313 | G | G313 | přidání kontroly |  |
| 313 | H | H313 | po revizi JDv, PMy, LRi - přidání kontroly |  |
| 314 | A | A314 | 2025-08-25 00:00:00 |  |
| 314 | B | B314 | 1.4.1 |  |
| 314 | C | C314 | n/a |  |
| 314 | D | D314 | 302 |  |
| 314 | E | E314 | Kód státu zahraniční právnické osoby nebo zahraniční fyzické osoby |  |
| 314 | F | F314 | DIS |  |
| 314 | G | G314 | přidání kontroly |  |
| 314 | H | H314 | pro revizi AKr, JDv, THavr - přidaná kontrola číselníku |  |
| 315 | A | A315 | 2025-08-26 00:00:00 |  |
| 315 | B | B315 | 1.4.0.1 |  |
| 315 | C | C315 | n/a |  |
| 315 | D | D315 | 75 |  |
| 315 | E | E315 | Hodnota musí být vyplněna i v případě nulového základu zvláštní sazby daně, zárověň nesmí být záporná.  |  |
| 315 | F | F315 | DIS |  |
| 315 | G | G315 | odstranění kontroly |  |
| 315 | H | H315 | nález testování - 13472, po diskuzi s VZi - odstraňujeme  |  |
| 316 | A | A316 | 2025-08-26 00:00:00 |  |
| 316 | B | B316 | 1.4.0.1 |  |
| 316 | C | C316 | n/a |  |
| 316 | D | D316 | 76 |  |
| 316 | E | E316 | Hodnota skutečně sražené daňe podle zvláštní sazby daně / měsíc musí být vyplněna i v případě nulových srážek, zároveň nesmí být záporná. |  |
| 316 | F | F316 | DIS |  |
| 316 | G | G316 | odstranění kontroly |  |
| 316 | H | H316 | nález testování - 13472, po diskuzi s VZi - odstraňujeme  |  |
| 317 | A | A317 | 2025-08-26 00:00:00 |  |
| 317 | B | B317 | 1.4.0.1 |  |
| 317 | C | C317 | n/a |  |
| 317 | D | D317 | 303 |  |
| 317 | E | E317 | Kontrola na typ formuláře pro řádné nebo opravné podání |  |
| 317 | F | F317 | DIS |  |
| 317 | G | G317 | přidání kontroly |  |
| 317 | H | H317 | po revizi LRi - přidána další strukurální kontrola |  |
| 318 | A | A318 | 2025-08-27 00:00:00 |  |
| 318 | B | B318 | 1.4.0.1 |  |
| 318 | C | C318 | n/a |  |
| 318 | D | D318 | 162 |  |
| 318 | E | E318 | Pokud vznikla účast na pojistném, je třeba vyplnit alespoň jeden typ vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a, b nebo c |  |
| 318 | F | F318 | DIS |  |
| 318 | G | G318 | změna kontroly |  |
| 318 | H | H318 | revize DMa - změna kontroly |  |
| 319 | A | A319 | 2025-08-27 00:00:00 |  |
| 319 | B | B319 | 1.4.0.1 |  |
| 319 | C | C319 | n/a |  |
| 319 | D | D319 | 244 |  |
| 319 | E | E319 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů bez prohlášení poplatníka - zálohová daň |  |
| 319 | F | F319 | cJMHZ |  |
| 319 | G | G319 | změna kontroly |  |
| 319 | H | H319 | Původní znění:Pro scénář, kdy je vyplňována záloha na sraženou daň, pak nesmí být vyplněny atribut(y): [překlad konkrétních atributů, oddělené čárkou].<br>Nové znění: Pokud zaměstnanec nepodepsal Prohlášení poplatníka, uvedené atributy nemohou být vyplněny.: [překlad konkrétních atributů, oddělené čárkou]. |  |
| 320 | A | A320 | 2025-08-21 00:00:00 |  |
| 320 | B | B320 | 1.4.1 |  |
| 320 | C | C320 | budoucí změn. požadavek ozuspoj |  |
| 320 | D | D320 | 291 |  |
| 320 | E | E320 | Kontrola platnosti záměru ve vztahu k zaměstnání, z něhož je sleva na pojistném zaměstnavatele za zaměstnance uplatňována |  |
| 320 | F | F320 | cJMHZ |  |
| 320 | G | G320 | změna kontroly |  |
| 320 | H | H320 | po revizi MSHr, JDv - změna na propustnou |  |
| 321 | A | A321 | 2025-08-27 00:00:00 |  |
| 321 | B | B321 | 1.4.1 |  |
| 321 | C | C321 | budoucí změn. požadavek ovocnáři |  |
| 321 | D | D321 | 291 |  |
| 321 | E | E321 | Kontrola platnosti záměru ve vztahu k zaměstnání, z něhož je sleva na pojistném zaměstnavatele za zaměstnance uplatňována |  |
| 321 | F | F321 | cJMHZ |  |
| 321 | G | G321 | změna kontroly |  |
| 321 | H | H321 | revize DMa - detail kontroly |  |
| 322 | A | A322 | 2025-08-19 00:00:00 |  |
| 322 | B | B322 | 1.4.1 |  |
| 322 | C | C322 | ZP_TECH_POPIS_060 |  |
| 322 | D | D322 | 295 |  |
| 322 | E | E322 | Kontrola uplatnění slevy na pojistném zaměstnavatele za zaměstnance až po oznámení záměru uplatňovat tuto slevu |  |
| 322 | F | F322 | cJMHZ |  |
| 322 | G | G322 | přidání kontroly |  |
| 322 | H | H322 | revize DMa |  |
| 323 | A | A323 | 2025-08-27 00:00:00 |  |
| 323 | B | B323 | draft |  |
| 323 | C | C323 | n/a |  |
| 323 | D | D323 | 245 |  |
| 323 | E | E323 | Kontrola adekvátních atributů pro výpočet srážkové daňe rezidentů bez prohlášení poplatníka - srážkova daň |  |
| 323 | F | F323 | cJMHZ |  |
| 323 | G | G323 | změna kontroly |  |
| 323 | H | H323 | Původní znění: Pro scénář, kdy je vyplňována daň srážkou, pak nesmí být vyplněny atribut(y): [překlad konkrétních atributů, oddělené čárkou].<br>Nové znění: Pro scénář, kdy je vybírána daň srážkou, pak nesmí být vyplněny atribut(y): [překlad konkrétních atributů, oddělené čárkou]. |  |
| 324 | A | A324 | 2025-08-27 00:00:00 |  |
| 324 | B | B324 | 1.4.0.1 |  |
| 324 | C | C324 | budoucí změn. požadavek |  |
| 324 | D | D324 | 246 |  |
| 324 | E | E324 | Kontrola adekvátních atributů pro výpočet daně členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR |  |
| 324 | F | F324 | DIS |  |
| 324 | G | G324 | změna kontroly |  |
| 324 | H | H324 | Původní znění:Pro scénář, kdy je vyplňována daň srážkou, pak nesmí být vyplněny atribut(y): [překlad konkrétních atributů, oddělené čárkou].<br>Nové znění: Pro scénář, kdy je u daňového nerezidenta, člena orgánů právnických osob, vybírána daň srážkou, pak nesmí být vyplněny atribut(y): [překlad konkrétních atributů, oddělené čárkou]. |  |
| 325 | A | A325 | 2025-08-27 00:00:00 |  |
| 325 | B | B325 | 1.4.0.1 |  |
| 325 | C | C325 | budoucí změn. požadavek |  |
| 325 | D | D325 | 248 |  |
| 325 | E | E325 | Kontrola vyplnění dat souhrnné vrstvy za zaměstnance jen pro primární pracovněprávní vztah zaměstnance |  |
| 325 | F | F325 | DIS |  |
| 325 | G | G325 | změna kontroly |  |
| 325 | H | H325 | Původní znění: Vyplněná položka není určena pro vyplnění u primárního pracovně právního vztahu.<br>Nové znění: Tyto atributy mohou být vyplněny pouze u primárního pracovněprávního vztahu:<br>[překlad konkrétních atributů, oddělené čárkou]. |  |
| 326 | A | A326 | 2025-08-28 00:00:00 |  |
| 326 | B | B326 | 1.4.0.1 |  |
| 326 | C | C326 | n/a |  |
| 326 | D | D326 | 244 |  |
| 326 | E | E326 | Vyplnění položky Základ pro výpočet daně |  |
| 326 | F | F326 | cJMHZ |  |
| 326 | G | G326 | změna kontroly |  |
| 326 | H | H326 | po revizi VerZ, JDv - navržena oprava, zjednodušení kontroly, vypuštění 2 podmínek kontroly |  |
| 327 | A | A327 | 2025-09-05 00:00:00 |  |
| 327 | B | B327 | 1.4.0.1 |  |
| 327 | C | C327 | n/a |  |
| 327 | D | D327 | 244 |  |
| 327 | E | E327 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů bez prohlášení poplatníka - zálohová daň |  |
| 327 | F | F327 | cJMHZ |  |
| 327 | G | G327 | změna kontroly |  |
| 327 | H | H327 | po revizi VerZ, AKr, HKy (04.09.2025) - změněno tělo kontroly - odstraněny některé atributy z podmínky |  |
| 328 | A | A328 | 2025-09-08 00:00:00 |  |
| 328 | B | B328 | 1.4.0.1 |  |
| 328 | C | C328 | n/a |  |
| 328 | D | D328 | 303 |  |
| 328 | E | E328 | Kontrola na typ formuláře pro řádné nebo opravné podání |  |
| 328 | F | F328 | DIS |  |
| 328 | G | G328 | změna kontroly |  |
| 328 | H | H328 | revize LRi, JDv - změna chyb. hl.  |  |
| 329 | A | A329 | 2025-09-10 00:00:00 |  |
| 329 | B | B329 | 1.4.0.1 |  |
| 329 | C | C329 | n/a |  |
| 329 | D | D329 | 133 |  |
| 329 | E | E329 | Kontrola správnosti Kódu ELDP při zaměstnání malého rozsahu |  |
| 329 | F | F329 | DIS |  |
| 329 | G | G329 | změna kontroly |  |
| 329 | H | H329 | revize JDv, detail v těle podmínky, odstranění úvodní redundantní  podmínky |  |
| 330 | A | A330 | 2025-09-10 00:00:00 |  |
| 330 | B | B330 | 1.4.0.1 |  |
| 330 | C | C330 | n/a |  |
| 330 | D | D330 | 305 |  |
| 330 | E | E330 | Jedinečnost GUID podání |  |
| 330 | F | F330 | cJMHZ |  |
| 330 | G | G330 | přidání kontroly |  |
| 330 | H | H330 | revize pro pokrytí bugu - 13343 |  |
| 331 | A | A331 | 2025-09-10 00:00:00 |  |
| 331 | B | B331 | 1.4.0.1 |  |
| 331 | C | C331 | n/a |  |
| 331 | D | D331 | 306 |  |
| 331 | E | E331 | Jedinečnost GUID formuláře |  |
| 331 | F | F331 | cJMHZ |  |
| 331 | G | G331 | přidání kontroly |  |
| 331 | H | H331 | revize pro pokrytí bugu - 13343 |  |
| 332 | A | A332 | 2025-09-12 00:00:00 |  |
| 332 | B | B332 | 1.4.0.1 |  |
| 332 | C | C332 | n/a |  |
| 332 | D | D332 | 59 |  |
| 332 | E | E332 | Vyměřovací základ s podmínkami |  |
| 332 | F | F332 | DIS |  |
| 332 | G | G332 | změna kontroly |  |
| 332 | H | H332 | revize OCi, Jko, JDv - úprava znění, znak změněn na pozici |  |
| 333 | A | A333 | 2025-09-12 00:00:00 |  |
| 333 | B | B333 | 1.4.0.1 |  |
| 333 | C | C333 | n/a |  |
| 333 | D | D333 | 87 |  |
| 333 | E | E333 | Správnost kódu ELDP |  |
| 333 | F | F333 | DIS |  |
| 333 | G | G333 | změna kontroly |  |
| 333 | H | H333 | revize OCi, Jko, JDv - úprava znění, znak změněn na pozici |  |
| 334 | A | A334 | 2025-09-12 00:00:00 |  |
| 334 | B | B334 | 1.4.0.1 |  |
| 334 | C | C334 | n/a |  |
| 334 | D | D334 | 133 |  |
| 334 | E | E334 | Kontrola správnosti Kódu ELDP při zaměstnání malého rozsahu |  |
| 334 | F | F334 | DIS |  |
| 334 | G | G334 | změna kontroly |  |
| 334 | H | H334 | revize OCi, Jko, JDv - úprava znění, znak změněn na pozici |  |
| 335 | A | A335 | 2025-09-12 00:00:00 |  |
| 335 | B | B335 | 1.4.0.1 |  |
| 335 | C | C335 | n/a |  |
| 335 | D | D335 | 134 |  |
| 335 | E | E335 | Počet kalendářních dnů trvání pojištění v daném kalendářním měsíci - interval |  |
| 335 | F | F335 | DIS |  |
| 335 | G | G335 | změna kontroly |  |
| 335 | H | H335 | po revizi JDv - vložení původního textu kontroly z verze 1.3 |  |
| 336 | A | A336 | 2025-09-12 00:00:00 |  |
| 336 | B | B336 | 1.4.0.1 |  |
| 336 | C | C336 | n/a |  |
| 336 | D | D336 | 135 |  |
| 336 | E | E336 | Uvedení trvání pojištění v daném měsíci |  |
| 336 | F | F336 | DIS |  |
| 336 | G | G336 | změna kontroly |  |
| 336 | H | H336 | po revizi JDv - vložení původního textu kontroly z verze 1.3<br><br>revize Oci, Jko, JDv - úprava znění, znak změnněn na pozici |  |
| 337 | A | A337 | 2025-09-12 00:00:00 |  |
| 337 | B | B337 | 1.4.0.1 |  |
| 337 | C | C337 | n/a |  |
| 337 | D | D337 | 135 |  |
| 337 | E | E337 | Uvedení trvání pojištění v daném měsíci |  |
| 337 | F | F337 | DIS |  |
| 337 | G | G337 | změna kontroly |  |
| 337 | H | H337 | revize OCi, Jko, JDv - úprava znění, znak změněn na pozici, přesun 5. části kontroly na cJMHZ idk 309 |  |
| 338 | A | A338 | 2025-09-12 00:00:00 |  |
| 338 | B | B338 | 1.4.0.1 |  |
| 338 | C | C338 | n/a |  |
| 338 | D | D338 | 136 |  |
| 338 | E | E338 | Zaregistrování IK MPSV |  |
| 338 | F | F338 | DIS |  |
| 338 | G | G338 | odstranění kontroly |  |
| 338 | H | H338 | po revizi JDv - 136 redundantní ke kontrolám akce 99 (261, 262, 263, 264) |  |
| 339 | A | A339 | 2025-09-12 00:00:00 |  |
| 339 | B | B339 | 1.4.0.1 |  |
| 339 | C | C339 | n/a |  |
| 339 | D | D339 | 146 |  |
| 339 | E | E339 | Kód pracoviště ČSSZ |  |
| 339 | F | F339 | DIS |  |
| 339 | G | G339 | odstranění kontroly |  |
| 339 | H | H339 | po revizi LRi, JDv - odstreněna kontrola z MH, 10004 je v datové doméně RegZel |  |
| 340 | A | A340 | 2025-09-12 00:00:00 |  |
| 340 | B | B340 | 1.4.1 |  |
| 340 | C | C340 | n/a |  |
| 340 | D | D340 | 307 |  |
| 340 | E | E340 | Kontrola vyplnění dat ELDP |  |
| 340 | F | F340 | DIS |  |
| 340 | G | G340 | přidání kontroly |  |
| 340 | H | H340 | po revizi JDv, JHo, LRi - přidání interakční kontroly č. 35 |  |
| 341 | A | A341 | 2025-09-12 00:00:00 |  |
| 341 | B | B341 | 1.4.0.1 |  |
| 341 | C | C341 | n/a |  |
| 341 | D | D341 | 303 |  |
| 341 | E | E341 | Kontrola na typ formuláře v součásti indiv. části |  |
| 341 | F | F341 | DIS |  |
| 341 | G | G341 | změna kontroly |  |
| 341 | H | H341 | revize JDv, LRi - po diskuzi 11.09.2025 odstraněna část pro storno (pokryto jinou kontrolou) |  |
| 342 | A | A342 | 2025-09-15 00:00:00 |  |
| 342 | B | B342 | 1.4.0.1 |  |
| 342 | C | C342 | n/a |  |
| 342 | D | D342 | 237 |  |
| 342 | E | E342 | Kontrola formulářů v opravném měsíčním hlášení |  |
| 342 | F | F342 | DIS |  |
| 342 | G | G342 | změna kontroly |  |
| 342 | H | H342 | změněn atribut ve výčtu i v popisu, vylepšena textace kontroly |  |
| 343 | A | A343 | 2025-09-15 00:00:00 |  |
| 343 | B | B343 | 1.4.1 |  |
| 343 | C | C343 | n/a |  |
| 343 | D | D343 | 308 |  |
| 343 | E | E343 | Kontrola částí podání ve stronovaném měsíčním hlášení |  |
| 343 | F | F343 | DIS |  |
| 343 | G | G343 | přidání kontroly |  |
| 343 | H | H343 | po revizi PMy, JDv, PSl - přidání analogické kontroly k idk 237 jen pro celé podání |  |
| 344 | A | A344 | 2025-09-16 00:00:00 |  |
| 344 | B | B344 | 1.4.0.1 |  |
| 344 | C | C344 | n/a |  |
| 344 | D | D344 | 309 |  |
| 344 | E | E344 | Uvedení trvání pojištění v daném měsíci |  |
| 344 | F | F344 | cJMHZ |  |
| 344 | G | G344 | přidání kontroly |  |
| 344 | H | H344 | po revizi PSl, JDv - kontrola 135 rozdělena, 4. část přesunuta z DIS na cJMHZ |  |
| 345 | A | A345 | 2025-09-16 00:00:00 |  |
| 345 | B | B345 | 1.4.0.1 |  |
| 345 | C | C345 | n/a |  |
| 345 | D | D345 | 281 |  |
| 345 | E | E345 | Kontrola nevyplnění dat pro rozklad při nulových náhradách mzdy zúčtované |  |
| 345 | F | F345 | DIS |  |
| 345 | G | G345 | změna kontroly |  |
| 345 | H | H345 | po revizi LRi, JDv - oprava v chyb. hl. - smazání posledního názvu atibutu   |  |
| 346 | A | A346 | 2025-09-16 00:00:00 |  |
| 346 | B | B346 | 1.4.0.1 |  |
| 346 | C | C346 | n/a |  |
| 346 | D | D346 | 282 |  |
| 346 | E | E346 | Kontrola nevyplnění dat odpracovaných hodin pro zaměstnání v hlubinném hornictví a rizikové práci |  |
| 346 | F | F346 | DIS |  |
| 346 | G | G346 | změna kontroly |  |
| 346 | H | H346 | po revizi LRi, JDv - oprava v chyb. hl. - smazání posledního názvu atibutu   |  |
| 347 | A | A347 | 2025-09-17 00:00:00 |  |
| 347 | B | B347 | 1.4.1 |  |
| 347 | C | C347 | n/a |  |
| 347 | D | D347 | 215 |  |
| 347 | E | E347 | Kontrola věku dítěte pro uplatnění slevy (měsíční zúčtovaní) |  |
| 347 | F | F347 | DIS |  |
| 347 | G | G347 | změna kontroly |  |
| 347 | H | H347 | po revizi JDv - změna názvu atributu v popisu |  |
| 348 | A | A348 | 2025-09-17 00:00:00 |  |
| 348 | B | B348 | 1.4.1 |  |
| 348 | C | C348 | n/a |  |
| 348 | D | D348 | 215 |  |
| 348 | E | E348 | Kontrola věku dítěte pro uplatnění slevy (měsíční zúčtovaní) |  |
| 348 | F | F348 | DIS |  |
| 348 | G | G348 | změna kontroly |  |
| 348 | H | H348 | po revizi JDv - oprava chyb. hl. |  |
| 349 | A | A349 | 2025-09-17 00:00:00 |  |
| 349 | B | B349 | 1.4.0.1 |  |
| 349 | C | C349 | n/a |  |
| 349 | D | D349 | 133 |  |
| 349 | E | E349 | Kontrola správnosti Kódu ELDP při zaměstnání malého rozsahu |  |
| 349 | F | F349 | cJMHZ |  |
| 349 | G | G349 | změna kontroly |  |
| 349 | H | H349 | po revizi PSl, JDv - kontrola přesunuta z DIS na cJMHZ |  |
| 350 | A | A350 | 2025-09-18 00:00:00 |  |
| 350 | B | B350 | 1.4.0.1 |  |
| 350 | C | C350 | n/a |  |
| 350 | D | D350 | 232 |  |
| 350 | E | E350 | Struktura řádného měsíčního hlášení |  |
| 350 | F | F350 | DIS |  |
| 350 | G | G350 | změna kontroly |  |
| 350 | H | H350 | po revizi JDv, LRi - vylepšení formalizmu kontroly |  |
| 351 | A | A351 | 2025-09-18 00:00:00 |  |
| 351 | B | B351 | 1.4.0.1 |  |
| 351 | C | C351 | n/a |  |
| 351 | D | D351 | 233 |  |
| 351 | E | E351 | Struktura opravného hlášení |  |
| 351 | F | F351 | DIS |  |
| 351 | G | G351 | změna kontroly |  |
| 351 | H | H351 | po revizi JDv, LRi - vylepšení formalizmu kontroly |  |
| 352 | A | A352 | 2025-09-18 00:00:00 |  |
| 352 | B | B352 | 1.4.0.1 |  |
| 352 | C | C352 | n/a |  |
| 352 | D | D352 | 223 |  |
| 352 | E | E352 | Bezvadná pojistná část  |  |
| 352 | F | F352 | cJMHZ |  |
| 352 | G | G352 | změna kontroly |  |
| 352 | H | H352 | po revizi JDv - oprava chyb. hl. |  |
| 353 | A | A353 | 2025-09-18 00:00:00 |  |
| 353 | B | B353 | 1.4.0.1 |  |
| 353 | C | C353 | n/a |  |
| 353 | D | D353 | 222 |  |
| 353 | E | E353 | Bezvadná souhrnná část  |  |
| 353 | F | F353 | cJMHZ |  |
| 353 | G | G353 | změna kontroly |  |
| 353 | H | H353 | po revizi JDv - oprava chyb. hl. |  |
| 354 | A | A354 | 2025-09-19 00:00:00 |  |
| 354 | B | B354 | 1.4.1 |  |
| 354 | C | C354 | n/a |  |
| 354 | D | D354 | 310 |  |
| 354 | E | E354 | Roční zúčtování záloh bylo provedeno |  |
| 354 | F | F354 | DIS |  |
| 354 | G | G354 | přidání kontroly |  |
| 354 | H | H354 | po revizi JDv, THav -přidání kontroly, která zastřeší IN09 |  |
| 355 | A | A355 | 2025-09-19 00:00:00 |  |
| 355 | B | B355 | 1.4.0.1 |  |
| 355 | C | C355 | n/a |  |
| 355 | D | D355 | 311 |  |
| 355 | E | E355 | Roční zúčtování záloh bylo provedeno v jednom měsíci |  |
| 355 | F | F355 | cJMHZ |  |
| 355 | G | G355 | přidání kontroly |  |
| 355 | H | H355 | po revizi JDv, THav -přidání kontextové kontroly, která kontroluje právě jedno roční zúčtování buď měsíci 01 nebo 02 nebo 03 |  |
| 356 | A | A356 | 2025-09-19 00:00:00 |  |
| 356 | B | B356 | 1.4.0.1 |  |
| 356 | C | C356 | n/a |  |
| 356 | D | D356 | 286 |  |
| 356 | E | E356 | Kontrola nevyplnění atributů neodpracovaných hodin. |  |
| 356 | F | F356 | DIS |  |
| 356 | G | G356 | změna kontroly |  |
| 356 | H | H356 | po revizi JDv, JAnd - oprava překlepu v chyb. hlášce (početu -> počtu) |  |
| 357 | A | A357 | 2025-09-19 00:00:00 |  |
| 357 | B | B357 | 1.4.0.1 |  |
| 357 | C | C357 | n/a |  |
| 357 | D | D357 | 312 |  |
| 357 | E | E357 | Pořadí pro určení výše daňového zvýhodnění tvoří řadu ve výsledku ročního zúčtování |  |
| 357 | F | F357 | DIS |  |
| 357 | G | G357 | přidání kontroly |  |
| 357 | H | H357 | po revizi JDv, AKr, HKy - nález z testování, bez bugu - přidání kontroly  |  |
| 358 | A | A358 | 2025-09-22 00:00:00 |  |
| 358 | B | B358 | 1.4.1 |  |
| 358 | C | C358 | n/a |  |
| 358 | D | D358 | 216 |  |
| 358 | E | E358 | Kontrola součtů vyměřovacího základu zaměstnance |  |
| 358 | F | F358 | DIS |  |
| 358 | G | G358 | změna kontroly |  |
| 358 | H | H358 | po revizi JDv - dopřesnění podmínky |  |
| 359 | A | A359 | 2025-09-22 00:00:00 |  |
| 359 | B | B359 | 1.4.1 |  |
| 359 | C | C359 | n/a |  |
| 359 | D | D359 | 313 |  |
| 359 | E | E359 | Shoda vypočtené zálohy na daň se základem |  |
| 359 | F | F359 | DIS |  |
| 359 | G | G359 | přidání kontroly |  |
| 359 | H | H359 | po revizi JDv - přidání kontroly nález: 14117 |  |
| 360 | A | A360 | 2025-09-23 00:00:00 |  |
| 360 | B | B360 | 1.4.0.1 |  |
| 360 | C | C360 | n/a |  |
| 360 | D | D360 | 164 |  |
| 360 | E | E360 | Kontrola na uplatnění slevy na pojistném zaměstnavatele v rámci splatnosti pojistného |  |
| 360 | F | F360 | DIS |  |
| 360 | G | G360 | změna kontroly |  |
| 360 | H | H360 | po revizi JDv - nález: HRIS testování (DMa, MMi), 14167<br><br>přidání podmínky 10032 > 0 |  |
| 361 | A | A361 | 2025-09-23 00:00:00 |  |
| 361 | B | B361 | 1.4.1 |  |
| 361 | C | C361 | n/a |  |
| 361 | D | D361 | 315 |  |
| 361 | E | E361 | Vypočitané pojistné na soc. zabezpečení neodpovídá úhrnu vyměřovacích základů zaměstnanců. |  |
| 361 | F | F361 | DIS |  |
| 361 | G | G361 | přidání kontroly |  |
| 361 | H | H361 | po revizi JDv, VZi - nález: HRIS testování 14108 |  |
| 362 | A | A362 | 2025-09-23 00:00:00 |  |
| 362 | B | B362 | 1.4.1 |  |
| 362 | C | C362 | n/a |  |
| 362 | D | D362 | 316 |  |
| 362 | E | E362 | Kontrola souladu počtu dnů v evidenčním stavu s počtem dnů pojištění dle ELDP |  |
| 362 | F | F362 | DIS |  |
| 362 | G | G362 | přidání kontroly |  |
| 362 | H | H362 | po revizi JDv, VZi - nález: HRIS testování 14108 |  |
| 363 | A | A363 | 2025-09-23 00:00:00 |  |
| 363 | B | B363 | 1.4.1 |  |
| 363 | C | C363 | n/a |  |
| 363 | D | D363 | 317 |  |
| 363 | E | E363 | Výše měsíčního daň. zvýhodnění na děti |  |
| 363 | F | F363 | DIS |  |
| 363 | G | G363 | přidání kontroly |  |
| 363 | H | H363 | po revizi JDv, VZi - nález: HRIS testování 14110 |  |
| 364 | A | A364 | 2025-09-23 00:00:00 |  |
| 364 | B | B364 | 1.4.1 |  |
| 364 | C | C364 | n/a |  |
| 364 | D | D364 | 318 |  |
| 364 | E | E364 | Výše uvedené základní slevy na poplatníka neodpovídá legislativnímu předpisu. |  |
| 364 | F | F364 | DIS |  |
| 364 | G | G364 | přidání kontroly |  |
| 364 | H | H364 | po revizi JDv, VZi - nález: HRIS testování 14110 |  |
| 365 | A | A365 | 2025-09-23 00:00:00 |  |
| 365 | B | B365 | 1.4.1 |  |
| 365 | C | C365 | ZP_TECH_POPIS_071 |  |
| 365 | D | D365 | 319 |  |
| 365 | E | E365 | Kontrola na vyplnění atributů odpovídajícho typu daně |  |
| 365 | F | F365 | DIS |  |
| 365 | G | G365 | přidání kontroly |  |
| 365 | H | H365 | po revizi JDv, VZi - nález: HRIS testování, přidání pozitivní kontroly |  |
| 366 | A | A366 | 2025-09-24 00:00:00 |  |
| 366 | B | B366 | 1.4.1 |  |
| 366 | C | C366 | n/a |  |
| 366 | D | D366 | 321 |  |
| 366 | E | E366 | Pozitivní kontrola na vyplnění adekvátních atributů v souhrnné vrstvě zaměstnance |  |
| 366 | F | F366 | DIS |  |
| 366 | G | G366 | přidání kontroly |  |
| 366 | H | H366 | po revizi JDv, THav - přidání pozitivní kontroly, nález z testování |  |
| 367 | A | A367 | 2025-08-21 00:00:00 |  |
| 367 | B | B367 | 1.4.1 |  |
| 367 | C | C367 | ZP_TECH_POPIS_060 |  |
| 367 | D | D367 | 295 |  |
| 367 | E | E367 | Kontrola uplatnění slevy na pojistném zaměstnavatele za zaměstnance až po oznámení záměru uplatňovat tuto slevu |  |
| 367 | F | F367 | cJMHZ |  |
| 367 | G | G367 | změna kontroly |  |
| 367 | H | H367 | po revizi MSHr, JDv - změna na propustnou |  |
| 368 | A | A368 | 2025-09-24 00:00:00 |  |
| 368 | B | B368 | 1.4.1 |  |
| 368 | C | C368 | n/a |  |
| 368 | D | D368 | 320 |  |
| 368 | E | E368 | Výše vypočtené srážkové daně |  |
| 368 | F | F368 | DIS |  |
| 368 | G | G368 | přidání kontroly |  |
| 368 | H | H368 | po revizi JDv, VZi - nález: testování 14113 |  |
| 369 | A | A369 | 2025-09-25 00:00:00 |  |
| 369 | B | B369 | 1.4.0.1 |  |
| 369 | C | C369 | n/a |  |
| 369 | D | D369 | 306 |  |
| 369 | E | E369 | Jedinečnost GUID formuláře |  |
| 369 | F | F369 | cJMHZ |  |
| 369 | G | G369 | změna kontroly |  |
| 369 | H | H369 | po revizi JDv, JHo - zpřesnění detailu kontroly, nález (13343 - not a bug) |  |
| 370 | A | A370 | 2025-09-25 00:00:00 |  |
| 370 | B | B370 | 1.4.0.1 |  |
| 370 | C | C370 | n/a |  |
| 370 | D | D370 | 305 |  |
| 370 | E | E370 | Jedinečnost GUID podání |  |
| 370 | F | F370 | cJMHZ |  |
| 370 | G | G370 | změna kontroly |  |
| 370 | H | H370 | po revizi JDv, JHo - zpřesnění detailu kontroly, nález (13343 - not a bug) |  |
| 371 | A | A371 | 2025-09-26 00:00:00 |  |
| 371 | B | B371 | 1.4.0.1 |  |
| 371 | C | C371 | n/a |  |
| 371 | D | D371 | 311 |  |
| 371 | E | E371 | Roční zúčtování záloh bylo provedeno v jednom měsíci |  |
| 371 | F | F371 | cJMHZ |  |
| 371 | G | G371 | změna kontroly |  |
| 371 | H | H371 | po revizi JDv, THav - změna detail. těla kontroly, změna chyb. hlášky |  |
| 372 | A | A372 | 2025-10-13 00:00:00 |  |
| 372 | B | B372 | 1.4.1 |  |
| 372 | C | C372 | n/a |  |
| 372 | D | D372 | 296 |  |
| 372 | E | E372 | Sleva na pojistném zaměstnanců v ovocnářství jen z DPP |  |
| 372 | F | F372 | cJMHZ |  |
| 372 | G | G372 | přidání kontroly |  |
| 372 | H | H372 | po revizi JDv, LRid - změna systému kontroly |  |
| 373 | A | A373 | 2025-09-29 00:00:00 |  |
| 373 | B | B373 | 1.4.0.1 |  |
| 373 | C | C373 | n/a |  |
| 373 | D | D373 | 20 |  |
| 373 | E | E373 | Odpracované hodiny |  |
| 373 | F | F373 | DIS |  |
| 373 | G | G373 | změna kontroly |  |
| 373 | H | H373 | po revizi JDv, Jko - nález 14287, HRIS dotaz  |  |
| 374 | A | A374 | 2025-09-29 00:00:00 |  |
| 374 | B | B374 | 1.4.0.1 |  |
| 374 | C | C374 | n/a |  |
| 374 | D | D374 | 110 |  |
| 374 | E | E374 | Pořadí pro určení výše daňového zvýhodnění tvoří řadu |  |
| 374 | F | F374 | DIS |  |
| 374 | G | G374 | změna kontroly |  |
| 374 | H | H374 | po revizi JDv, JAn - oprava chyb. hl., měsící, pokud |  |
| 375 | A | A375 | 2025-09-29 00:00:00 |  |
| 375 | B | B375 | 1.4.1 |  |
| 375 | C | C375 | n/a |  |
| 375 | D | D375 | 33 |  |
| 375 | E | E375 | Počet neodpracovaných hodin s náhradou či nekrácením mzdy x náhrady mzdy |  |
| 375 | F | F375 | DIS |  |
| 375 | G | G375 | odstranění kontroly |  |
| 375 | H | H375 | po revizi JDv, MKl, JKot- HRIS dotaz 313 JDr |  |
| 376 | A | A376 | 2025-09-29 00:00:00 |  |
| 376 | B | B376 | 1.4.0.1 |  |
| 376 | C | C376 | n/a |  |
| 376 | D | D376 | 312 |  |
| 376 | E | E376 | Pořadí pro určení výše daňového zvýhodnění tvoří řadu ve výsledku ročního zúčtování |  |
| 376 | F | F376 | DIS |  |
| 376 | G | G376 | změna kontroly |  |
| 376 | H | H376 | po revizi JDv, JAn - oprava chyb. hl., měsící, pokud |  |
| 377 | A | A377 | 2025-09-30 00:00:00 |  |
| 377 | B | B377 | 1.4.0.1 |  |
| 377 | C | C377 | n/a |  |
| 377 | D | D377 | 246 |  |
| 377 | E | E377 | Kontrola adekvátních atributů pro výpočet daně členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR |  |
| 377 | F | F377 | DIS |  |
| 377 | G | G377 | změna kontroly |  |
| 377 | H | H377 | po revizi JDv, VZi, LRi - zkrácení chyb. hl. |  |
| 378 | A | A378 | 2025-09-30 00:00:00 |  |
| 378 | B | B378 | 1.4.0.1 |  |
| 378 | C | C378 | n/a |  |
| 378 | D | D378 | 248 |  |
| 378 | E | E378 | Kontrola vyplnění dat souhrnné vrstvy za zaměstnance jen pro primární pracovněprávní vztah zaměstnance |  |
| 378 | F | F378 | DIS |  |
| 378 | G | G378 | změna kontroly |  |
| 378 | H | H378 | po revizi JDv, VZi, LRi - zkrácení chyb. hl. |  |
| 379 | A | A379 | 2025-09-30 00:00:00 |  |
| 379 | B | B379 | 1.4.1 |  |
| 379 | C | C379 | n/a |  |
| 379 | D | D379 | 19 |  |
| 379 | E | E379 | Počet odpracovaných dnů |  |
| 379 | F | F379 | DIS |  |
| 379 | G | G379 | odstranění kontroly |  |
| 379 | H | H379 | po revizi JDv - na pokyn AHr odstranění atr. 10267 (nařízení vlády) => odstranění kontroly bez náhrady  |  |
| 380 | A | A380 | 2025-09-30 00:00:00 |  |
| 380 | B | B380 | 1.4.1 |  |
| 380 | C | C380 | n/a |  |
| 380 | D | D380 | 31 |  |
| 380 | E | E380 | Odpracované dny x mzda zúčtovaná |  |
| 380 | F | F380 | DIS |  |
| 380 | G | G380 | odstranění kontroly |  |
| 380 | H | H380 | po revizi JDv - na pokyn AHr odstranění atr. 10267 (nařízení vlády) => odstranění kontroly bez náhrady  |  |
| 381 | A | A381 | 2025-08-19 00:00:00 |  |
| 381 | B | B381 | 1.4.1 |  |
| 381 | C | C381 | ZP_TECH_POPIS_063 |  |
| 381 | D | D381 | 297 |  |
| 381 | E | E381 | Počet zaměstnanců se slevou - pracující důchodci |  |
| 381 | F | F381 | cJMHZ |  |
| 381 | G | G381 | přidání kontroly |  |
| 381 | H | H381 | revize DMa |  |
| 382 | A | A382 | 2025-08-27 00:00:00 |  |
| 382 | B | B382 | 1.4.1 |  |
| 382 | C | C382 | ZP_TECH_POPIS_063 |  |
| 382 | D | D382 | 297 |  |
| 382 | E | E382 | Počet zaměstnanců se slevou – pracující důchodci |  |
| 382 | F | F382 | cJMHZ |  |
| 382 | G | G382 | změna kontroly |  |
| 382 | H | H382 | revize DMa |  |
| 383 | A | A383 | 2025-09-30 00:00:00 |  |
| 383 | B | B383 | draft |  |
| 383 | C | C383 | n/a |  |
| 383 | D | D383 | 245 |  |
| 383 | E | E383 | Kontrola adekvátních atributů pro výpočet srážkové daně rezidentů bez prohlášení poplatníka - srážková daň |  |
| 383 | F | F383 | cJMHZ |  |
| 383 | G | G383 | změna kontroly |  |
| 383 | H | H383 | po revizi JDv, VZi, LRi - zkrácení chyb. hl. |  |
| 384 | A | A384 | 2025-09-30 00:00:00 |  |
| 384 | B | B384 | 1.4.1 |  |
| 384 | C | C384 | n/a |  |
| 384 | D | D384 | 310 |  |
| 384 | E | E384 | Roční zúčtování záloh bylo provedeno |  |
| 384 | F | F384 | DIS |  |
| 384 | G | G384 | změna kontroly |  |
| 384 | H | H384 | po revizi JDv, VZi, LRi - zkrácení chyb. hl. |  |
| 385 | A | A385 | 2025-10-01 00:00:00 |  |
| 385 | B | B385 | 1.4.0.1 |  |
| 385 | C | C385 | n/a |  |
| 385 | D | D385 | 244 |  |
| 385 | E | E385 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů bez prohlášení poplatníka - zálohová daň |  |
| 385 | F | F385 | cJMHZ |  |
| 385 | G | G385 | změna kontroly |  |
| 385 | H | H385 | po revizi JDv, AKr, HKy, VerZ - změna kontroly, přidání podmínky jen 1 VS, změna sumace na 10535 |  |
| 386 | A | A386 | 2025-10-01 00:00:00 |  |
| 386 | B | B386 | 1.4.0.1 |  |
| 386 | C | C386 | n/a |  |
| 386 | D | D386 | 222 |  |
| 386 | E | E386 | Bezvadná souhrnná část  |  |
| 386 | F | F386 | cJMHZ |  |
| 386 | G | G386 | odstranění kontroly |  |
| 386 | H | H386 | po revizi JDv, MKal, MSmr - odstranění (RE: kontrola 222, 223,..) |  |
| 387 | A | A387 | 2025-10-01 00:00:00 |  |
| 387 | B | B387 | 1.4.0.1 |  |
| 387 | C | C387 | n/a |  |
| 387 | D | D387 | 223 |  |
| 387 | E | E387 | Bezvadná pojistná část  |  |
| 387 | F | F387 | cJMHZ |  |
| 387 | G | G387 | odstranění kontroly |  |
| 387 | H | H387 | po revizi JDv, MKal, MSmr - odstranění (RE: kontrola 222, 223,..) |  |
| 388 | A | A388 | 2025-10-01 00:00:00 |  |
| 388 | B | B388 | draft |  |
| 388 | C | C388 | n/a |  |
| 388 | D | D388 | 245 |  |
| 388 | E | E388 | Kontrola adekvátních atributů pro výpočet srážkové daně rezidentů bez prohlášení poplatníka - srážková daň |  |
| 388 | F | F388 | cJMHZ |  |
| 388 | G | G388 | změna kontroly |  |
| 388 | H | H388 | po revizi JDv, AKr, Hky, VerZ - změna kontroly, přidání podmínky jen 1 VS, změna sumace na 10535 |  |
| 389 | A | A389 | 2025-08-19 00:00:00 |  |
| 389 | B | B389 | 1.4.1 |  |
| 389 | C | C389 | ZP_TECH_POPIS_063 |  |
| 389 | D | D389 | 298 |  |
| 389 | E | E389 | Počet zaměstnanců se slevou - ovocnáři |  |
| 389 | F | F389 | cJMHZ |  |
| 389 | G | G389 | přidání kontroly |  |
| 389 | H | H389 | revize DMa |  |
| 390 | A | A390 | 2025-10-02 00:00:00 |  |
| 390 | B | B390 | 1.4.0.1 |  |
| 390 | C | C390 | n/a |  |
| 390 | D | D390 | 243 |  |
| 390 | E | E390 | Kontrola adekvátních atributů pro výpočet zálohy na daň nerezidentů  s prohlášením poplatníka daně |  |
| 390 | F | F390 | cJMHZ |  |
| 390 | G | G390 | změna kontroly |  |
| 390 | H | H390 | po revizi JDv, PSl - přesun kontroly kvůli 10068 na cJHMZ |  |
| 391 | A | A391 | 2025-10-02 00:00:00 |  |
| 391 | B | B391 | 1.4.0.1 |  |
| 391 | C | C391 | n/a |  |
| 391 | D | D391 | 242 |  |
| 391 | E | E391 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů s prohlášením poplatníka daně |  |
| 391 | F | F391 | cJMHZ |  |
| 391 | G | G391 | změna kontroly |  |
| 391 | H | H391 | po revizi JDv, PSl - přesun kontroly kvůli 10068 na cJHMZ |  |
| 392 | A | A392 | 2025-10-06 00:00:00 |  |
| 392 | B | B392 | 1.4.0.1 |  |
| 392 | C | C392 | n/a |  |
| 392 | D | D392 | 80 |  |
| 392 | E | E392 | Dítě, za něhož je uplatňována sleva, musí být mladší než 26 let |  |
| 392 | F | F392 | DIS |  |
| 392 | G | G392 | odstranění kontroly |  |
| 392 | H | H392 | po revizi MOu, JDv, THavr - nalezena duplicita s 215, 80 smazána |  |
| 393 | A | A393 | 2025-08-27 00:00:00 |  |
| 393 | B | B393 | 1.4.1 |  |
| 393 | C | C393 | ZP_TECH_POPIS_063 |  |
| 393 | D | D393 | 298 |  |
| 393 | E | E393 | Počet zaměstnanců se slevou – ovocnáři |  |
| 393 | F | F393 | cJMHZ |  |
| 393 | G | G393 | změna kontroly |  |
| 393 | H | H393 | revize DMa |  |
| 394 | A | A394 | 2025-10-06 00:00:00 |  |
| 394 | B | B394 | 1.4.0.1 |  |
| 394 | C | C394 | n/a |  |
| 394 | D | D394 | 7 |  |
| 394 | E | E394 | Úhrn vyměřovacích základů zaměstnanců zaměstnavatele, kteří nevykonávají činnost v rizikovém zaměstnání nebo činnost zdravotnického záchranáře nebo člena jednotky HZS podniku je roven vyměřovacím základům všech příslušných zaměstnanců |  |
| 394 | F | F394 | cJMHZ |  |
| 394 | G | G394 | změna kontroly |  |
| 394 | H | H394 | po revizi JDv, THavr - v kontrole vyspecifikóvána sum 10477 pro dat. scénáře K-S, Pracovní vztah specifické skupiny, M pěstouni |  |
| 395 | A | A395 | 2025-10-07 00:00:00 |  |
| 395 | B | B395 | 1.4.1 |  |
| 395 | C | C395 | n/a |  |
| 395 | D | D395 | 215 |  |
| 395 | E | E395 | Kontrola věku dítěte pro uplatnění slevy (měsíční zúčtovaní) |  |
| 395 | F | F395 | DIS |  |
| 395 | G | G395 | změna kontroly |  |
| 395 | H | H395 | po revizi MOu, JDv, THavr - vylešeno formální znění |  |
| 396 | A | A396 | 2025-10-07 00:00:00 |  |
| 396 | B | B396 | 1.4.0.1 |  |
| 396 | C | C396 | n/a |  |
| 396 | D | D396 | 227 |  |
| 396 | E | E396 | Neodpovídá počet individualizovaných součástí měsíčního hlášení celkovému počtu |  |
| 396 | F | F396 | cJMHZ |  |
| 396 | G | G396 | změna kontroly |  |
| 396 | H | H396 | po revizi JDv, JHol - vylepšen popis |  |
| 397 | A | A397 | 2025-10-07 00:00:00 |  |
| 397 | B | B397 | 1.4.0.1 |  |
| 397 | C | C397 | ZP_TECH_POPIS_071 |  |
| 397 | D | D397 | 325 |  |
| 397 | E | E397 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů - zálohová daň |  |
| 397 | F | F397 | cJMHZ |  |
| 397 | G | G397 | přidání kontroly |  |
| 397 | H | H397 | po revizi JDv, VerZ - přidání kontroly - vychází z původní 244, změna chyb. hl., změna těla kontroly |  |
| 398 | A | A398 | 2025-10-08 00:00:00 |  |
| 398 | B | B398 | 1.4.0.1 |  |
| 398 | C | C398 | n/a |  |
| 398 | D | D398 | 134 |  |
| 398 | E | E398 | Počet kalendářních dnů trvání pojištění v daném kalendářním měsíci - interval |  |
| 398 | F | F398 | DIS |  |
| 398 | G | G398 | změna kontroly |  |
| 398 | H | H398 | po revizi JDv, MHej - doladění textu kontroly |  |
| 399 | A | A399 | 2025-10-08 00:00:00 |  |
| 399 | B | B399 | 1.4.0.1 |  |
| 399 | C | C399 | n/a |  |
| 399 | D | D399 | 204 |  |
| 399 | E | E399 | Stornování součástí individualizované části |  |
| 399 | F | F399 | DIS |  |
| 399 | G | G399 | změna kontroly |  |
| 399 | H | H399 | po revizi JDv, JAnd - nález překlepu |  |
| 400 | A | A400 | 2025-10-08 00:00:00 |  |
| 400 | B | B400 | 1.4.0.1 |  |
| 400 | C | C400 | n/a |  |
| 400 | D | D400 | 294 |  |
| 400 | E | E400 | Datum do (průběh studia) |  |
| 400 | F | F400 | DIS |  |
| 400 | G | G400 | odstranění kontroly |  |
| 400 | H | H400 | po revizi JDv, JAnd - nález redundantní kontroly |  |
| 401 | A | A401 | 2025-10-06 00:00:00 |  |
| 401 | B | B401 | 1.4.1 |  |
| 401 | C | C401 | n/a |  |
| 401 | D | D401 | 306 |  |
| 401 | E | E401 | Jedinečnost GUID formuláře |  |
| 401 | F | F401 | cJMHZ |  |
| 401 | G | G401 | změna kontroly |  |
| 401 | H | H401 | po revizi JDv, MKal - kontrola GUID form. (10012) v  podání (10001), změna chyb. hl. |  |
| 402 | A | A402 | 2025-10-09 00:00:00 |  |
| 402 | B | B402 | 1.4.0.1 |  |
| 402 | C | C402 | n/a |  |
| 402 | D | D402 | 60 |  |
| 402 | E | E402 | Datum nastání specifické právní skutečnosti |  |
| 402 | F | F402 | DIS |  |
| 402 | G | G402 | změna kontroly |  |
| 402 | H | H402 | po revizi JDv, THavr - změna operandu  |  |
| 403 | A | A403 | 2025-10-09 00:00:00 |  |
| 403 | B | B403 | 1.4.0.1 |  |
| 403 | C | C403 | n/a |  |
| 403 | D | D403 | 190 |  |
| 403 | E | E403 | Stornování celého řádného podání |  |
| 403 | F | F403 | DIS |  |
| 403 | G | G403 | změna kontroly |  |
| 403 | H | H403 | po revizi JDv, JAnd - změna chyb hl.  |  |
| 404 | A | A404 | 2025-10-13 00:00:00 |  |
| 404 | B | B404 | 1.4.1 |  |
| 404 | C | C404 | ZP_TECH_POPIS_071 |  |
| 404 | D | D404 | 319 |  |
| 404 | E | E404 | Kontrola na vyplnění atributů odpovídajícho typu daně |  |
| 404 | F | F404 | cJMHZ |  |
| 404 | G | G404 | přidání kontroly |  |
| 404 | H | H404 | po revizi JDv, LRid - změna systému kontroly |  |
| 405 | A | A405 | 2025-09-24 00:00:00 |  |
| 405 | B | B405 | 1.4.1 |  |
| 405 | C | C405 | n/a |  |
| 405 | D | D405 | 323 |  |
| 405 | E | E405 | Kontrola datové integrity podání |  |
| 405 | F | F405 | cJMHZ |  |
| 405 | G | G405 | přidání kontroly |  |
| 405 | H | H405 | po revizi JDv, JHo, MSm - přidání obecné eskalační chyby pro cJMHZ, nález z testování |  |
| 406 | A | A406 | 2025-10-14 00:00:00 |  |
| 406 | B | B406 | 1.4.1 |  |
| 406 | C | C406 | n/a |  |
| 406 | D | D406 | 42 |  |
| 406 | E | E406 | Kontrola atributů v rámci slev na pojistném jsou vázany k druhu činnosti v rozsahu 1 až 9 |  |
| 406 | F | F406 | DIS |  |
| 406 | G | G406 | odstranění kontroly |  |
| 406 | H | H406 | po revizi JDv, LRid - odstranění na DIS |  |
| 407 | A | A407 | 2025-10-14 00:00:00 |  |
| 407 | B | B407 | 1.4.0.1 |  |
| 407 | C | C407 | n/a |  |
| 407 | D | D407 | 135 |  |
| 407 | E | E407 | Uvedení trvání pojištění v daném měsíci |  |
| 407 | F | F407 | DIS |  |
| 407 | G | G407 | změna kontroly |  |
| 407 | H | H407 | po revizi JDv, Mhej, JarK  - opraveno dle KK_59_59-cast-1-poz.xml |  |
| 408 | A | A408 | 10/15/20225 |  |
| 408 | B | B408 | 1.4.1 |  |
| 408 | C | C408 | n/a |  |
| 408 | D | D408 | 323 |  |
| 408 | E | E408 | Kontrola datové integrity podání |  |
| 408 | F | F408 | cJMHZ |  |
| 408 | G | G408 | změna kontroly |  |
| 408 | H | H408 | po revizi JDv, THavr - odsouhlasení fin. Znění |  |
| 409 | A | A409 | 2025-10-14 00:00:00 |  |
| 409 | B | B409 | draft |  |
| 409 | C | C409 | n/a |  |
| 409 | D | D409 | 327 |  |
| 409 | E | E409 | Pojištění od  a do musí být pro rozhodný měsíc a rok |  |
| 409 | F | F409 | DIS |  |
| 409 | G | G409 | přidání kontroly |  |
| 409 | H | H409 | po revizi JDv, THavr - nahradí idk 130 a 293<br><br>byla smazána |  |
| 410 | A | A410 | 2025-09-26 00:00:00 |  |
| 410 | B | B410 | 1.4.1 |  |
| 410 | C | C410 | n/a |  |
| 410 | D | D410 | 324 |  |
| 410 | E | E410 | Roční zúčtování záloh bylo provedeno v jednom měsíci (leden, únor) |  |
| 410 | F | F410 | cJMHZ |  |
| 410 | G | G410 | přidání kontroly |  |
| 410 | H | H410 | po revizi JDv, THav - přidání kontroly k interakci IN09 (10320) |  |
| 411 | A | A411 | 2025-10-08 00:00:00 |  |
| 411 | B | B411 | 1.4.1 |  |
| 411 | C | C411 | n/a |  |
| 411 | D | D411 | 326 |  |
| 411 | E | E411 | Chybný GUID řádného podání |  |
| 411 | F | F411 | cJMHZ |  |
| 411 | G | G411 | přidání kontroly |  |
| 411 | H | H411 | po revizi PMys, JDv - nález z testování |  |
| 412 | A | A412 | 10/15/20225 |  |
| 412 | B | B412 | draft |  |
| 412 | C | C412 | n/a |  |
| 412 | D | D412 | 130 |  |
| 412 | E | E412 | Datum do (průběh studia) je v budoucnosti |  |
| 412 | F | F412 | DIS |  |
| 412 | G | G412 | odstranění kontroly |  |
| 412 | H | H412 | po revizi JDv, THavr - nahradí idk 130 a 293 |  |
| 413 | A | A413 | 10/15/20225 |  |
| 413 | B | B413 | draft |  |
| 413 | C | C413 | n/a |  |
| 413 | D | D413 | 293 |  |
| 413 | E | E413 | Datum od (průběh studia) |  |
| 413 | F | F413 | DIS |  |
| 413 | G | G413 | změna kontroly |  |
| 413 | H | H413 | po revizi JDv, THavr - nahradí idk 130 a 293 |  |
| 414 | A | A414 | 10/15/20225 |  |
| 414 | B | B414 | 1.4.1 |  |
| 414 | C | C414 | n/a |  |
| 414 | D | D414 | 214 |  |
| 414 | E | E414 | Kontrola věku dítěte pro uplatnění slevy (roční zúčtovaní) |  |
| 414 | F | F414 | DIS |  |
| 414 | G | G414 | změna kontroly |  |
| 414 | H | H414 | po revizi JDv, JAnd - změna chyb hl.  |  |
| 415 | A | A415 | 10/16/20225 |  |
| 415 | B | B415 | 1.4.1 |  |
| 415 | C | C415 | ZP_TECH_POPIS_069 |  |
| 415 | D | D415 | 150 |  |
| 415 | E | E415 | Typ kolektivní smlouvy/dohody |  |
| 415 | F | F415 | DIS |  |
| 415 | G | G415 | změna kontroly |  |
| 415 | H | H415 | po revizi JDv - ZP06, změna chyb. hl. |  |
| 416 | A | A416 | 10/16/20225 |  |
| 416 | B | B416 | 1.4.1 |  |
| 416 | C | C416 | ZP_TECH_POPIS_064 |  |
| 416 | D | D416 | 328 |  |
| 416 | E | E416 | Kontrola nevyplnění údajů při nulovém počtu dnů doby odečítané po dosažení důchodového věku |  |
| 416 | F | F416 | DIS |  |
| 416 | G | G416 | přidání kontroly |  |
| 416 | H | H416 | po revizi JDv - přidání kontroly v rámci ZP_TECH_POPIS_064 |  |
| 417 | A | A417 | 10/16/20225 |  |
| 417 | B | B417 | 1.4.1 |  |
| 417 | C | C417 | ZP_TECH_POPIS_064 |  |
| 417 | D | D417 | 329 |  |
| 417 | E | E417 | Kontrola nevyplnění údajů důvodů při nulové době vyloučených dob |  |
| 417 | F | F417 | DIS |  |
| 417 | G | G417 | přidání kontroly |  |
| 417 | H | H417 | po revizi JDv - přidání kontroly v rámci ZP_TECH_POPIS_064 |  |
| 418 | A | A418 | 10/17/20225 |  |
| 418 | B | B418 | 1.4.1 |  |
| 418 | C | C418 | ZP_TECH_POPIS_064 |  |
| 418 | D | D418 | 330 |  |
| 418 | E | E418 | Kontrola povinnosti uvedení kódu ELDP při započtených dnech důchodového pojištění |  |
| 418 | F | F418 | DIS |  |
| 418 | G | G418 | přidání kontroly |  |
| 418 | H | H418 | po revizi JDv - přidání kontroly v rámci ZP_TECH_POPIS_064 |  |
| 419 | A | A419 | 10/17/20225 |  |
| 419 | B | B419 | 1.4.1 |  |
| 419 | C | C419 | ZP_TECH_POPIS_064 |  |
| 419 | D | D419 | 307 |  |
| 419 | E | E419 | Kontrola vyplnění dat ELDP |  |
| 419 | F | F419 | DIS |  |
| 419 | G | G419 | změna kontroly |  |
| 419 | H | H419 | po revizi JDv - změna kontroly v rámci ZP_TECH_POPIS_064 |  |
| 420 | A | A420 | 10/17/20225 |  |
| 420 | B | B420 | 1.4.1 |  |
| 420 | C | C420 | ZP_TECH_POPIS_064 |  |
| 420 | D | D420 | 59 |  |
| 420 | E | E420 | Vyměřovací základ s podmínkami |  |
| 420 | F | F420 | DIS |  |
| 420 | G | G420 | změna kontroly |  |
| 420 | H | H420 | po revizi JDv - změna kontroly v rámci ZP_TECH_POPIS_064 |  |
| 421 | A | A421 | 10/17/20225 |  |
| 421 | B | B421 | 1.4.1 |  |
| 421 | C | C421 | ZP_TECH_POPIS_064 |  |
| 421 | D | D421 | 135 |  |
| 421 | E | E421 | Uvedení trvání pojištění v daném měsíci |  |
| 421 | F | F421 | DIS |  |
| 421 | G | G421 | změna kontroly |  |
| 421 | H | H421 | po revizi JDv - zpřesněn popis kontroly |  |
| 422 | A | A422 | 10/17/20225 |  |
| 422 | B | B422 | 1.4.1 |  |
| 422 | C | C422 | ZP_TECH_POPIS_071 |  |
| 422 | D | D422 | 109 |  |
| 422 | E | E422 | Kontrola na Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR |  |
| 422 | F | F422 | DIS |  |
| 422 | G | G422 | změna kontroly |  |
| 422 | H | H422 | po revizi JDv - přejmenovaný atribut 10416 |  |
| 423 | A | A423 | 10/17/20225 |  |
| 423 | B | B423 | 1.4.1 |  |
| 423 | C | C423 | ZP_TECH_POPIS_071 |  |
| 423 | D | D423 | 248 |  |
| 423 | E | E423 | Kontrola vyplnění dat souhrnné vrstvy za zaměstnance jen pro primární pracovněprávní vztah zaměstnance |  |
| 423 | F | F423 | DIS |  |
| 423 | G | G423 | změna kontroly |  |
| 423 | H | H423 | po revizi JDv - změněny atributy / chyb. hl. |  |
| 424 | A | A424 | 10/17/20225 |  |
| 424 | B | B424 | 1.4.1 |  |
| 424 | C | C424 | ZP_TECH_POPIS_071 |  |
| 424 | D | D424 | 283 |  |
| 424 | E | E424 | Kontrola nevyplnění dat pro zúčtovaný příjem - celkem |  |
| 424 | F | F424 | DIS |  |
| 424 | G | G424 | změna kontroly |  |
| 424 | H | H424 | po revizi JDv - změněny atributy / chyb. hl. |  |
| 425 | A | A425 | 10/22/20225 |  |
| 425 | B | B425 | 1.4.1 |  |
| 425 | C | C425 | ZP_TECH_POPIS_060 |  |
| 425 | D | D425 | 295 |  |
| 425 | E | E425 | Kontrola uplatnění slevy na pojistném zaměstnavatele za zaměstnance až po oznámení záměru uplatňovat tuto slevu |  |
| 425 | F | F425 | cJMHZ |  |
| 425 | G | G425 | změna kontroly |  |
| 425 | H | H425 | po revizi JDv - zaslán detailnější specifikace p. DMar, diskutováno VerZ, implelementace variantně do jedné kontroly (NV) |  |
| 426 | A | A426 | 10/22/20225 |  |
| 426 | B | B426 | 1.4.1 |  |
| 426 | C | C426 | n/a |  |
| 426 | D | D426 | 238 |  |
| 426 | E | E426 | Kontrola konzistence klíčů GUID, ikmpsv, idppv v části individualizované součásti při změně dat |  |
| 426 | F | F426 | cJMHZ |  |
| 426 | G | G426 | změna kontroly |  |
| 426 | H | H426 | po revizi JDv - oprava chyb. hl. |  |
| 427 | A | A427 | 10/22/20225 |  |
| 427 | B | B427 | 1.4.1 |  |
| 427 | C | C427 | n/a |  |
| 427 | D | D427 | 284 |  |
| 427 | E | E427 | Kontrola vyplnění min. jednoho atributu pro částku vyměřovacího základu zaměstnance, ze které je odváděno pojistné |  |
| 427 | F | F427 | DIS |  |
| 427 | G | G427 | změna kontroly |  |
| 427 | H | H427 | po revizi JDv - dotaz 235 MOu, dopřesnění vstupních podmínek dle idk 216, fin. Konzultováno s VerZ |  |
| 428 | A | A428 | 10/23/20225 |  |
| 428 | B | B428 | 1.4.1 |  |
| 428 | C | C428 | n/a |  |
| 428 | D | D428 | 130 |  |
| 428 | E | E428 | Kontrola, že datum od je nižší nebo roven než datum do (průběh studia) |  |
| 428 | F | F428 | DIS |  |
| 428 | G | G428 | změna kontroly |  |
| 428 | H | H428 | po revizi JDv, JarK, JLau - přepis kontroly |  |
| 429 | A | A429 | 10/23/20225 |  |
| 429 | B | B429 | 1.4.1 |  |
| 429 | C | C429 | n/a |  |
| 429 | D | D429 | 293 |  |
| 429 | E | E429 | Kontrola na datum od a do (průběh studia) jsou v rámci vykazovaného měsíce |  |
| 429 | F | F429 | DIS |  |
| 429 | G | G429 | změna kontroly |  |
| 429 | H | H429 | po revizi JDv, JarK, JLau - přepis kontroly |  |
| 430 | A | A430 | 10/31/20225 |  |
| 430 | B | B430 | 1.4.1 |  |
| 430 | C | C430 | n/a |  |
| 430 | D | D430 | 331 |  |
| 430 | E | E430 | Typ Odloženého příjmu |  |
| 430 | F | F430 | DIS |  |
| 430 | G | G430 | přidání kontroly |  |
| 430 | H | H430 | po revizi JDv, LRi - přidání kontroly |  |
| 431 | A | A431 | 2025-11-03 00:00:00 |  |
| 431 | B | B431 | 1.4.1 |  |
| 431 | C | C431 | n/a |  |
| 431 | D | D431 | 165 |  |
| 431 | E | E431 | Kontrola vyplnění vyloučených dob dle  § 18 odst. 7 |  |
| 431 | F | F431 | DIS |  |
| 431 | G | G431 | změna kontroly |  |
| 431 | H | H431 | po revizi JDv, MHej - vylepšení definice kontroly, vazba jen na platné dat. scénáře |  |
| 432 | A | A432 | 2025-11-03 00:00:00 |  |
| 432 | B | B432 | 1.4.1 |  |
| 432 | C | C432 | n/a |  |
| 432 | D | D432 | 317 |  |
| 432 | E | E432 | Výše měsíčního daň. zvýhodnění na děti |  |
| 432 | F | F432 | DIS |  |
| 432 | G | G432 | změna kontroly |  |
| 432 | H | H432 | po revizi JDv, VZi, LRi - doplnění multiplikátoru pro ZTP |  |
| 433 | A | A433 | 2025-11-04 00:00:00 |  |
| 433 | B | B433 | 1.4.1 |  |
| 433 | C | C433 | n/a |  |
| 433 | D | D433 | 315 |  |
| 433 | E | E433 | Vypočitané pojistné na soc. zabezpečení neodpovídá úhrnu vyměřovacích základů zaměstnanců. |  |
| 433 | F | F433 | DIS |  |
| 433 | G | G433 | změna kontroly |  |
| 433 | H | H433 | pro revizi JDv, DMa - revize znění kontroly |  |
| 434 | A | A434 | 2025-11-04 00:00:00 |  |
| 434 | B | B434 | 1.4.1 |  |
| 434 | C | C434 | n/a |  |
| 434 | D | D434 | 121 |  |
| 434 | E | E434 | Kontrola vyplnění vyloučených dob dle § 16 odst. 4 písm |  |
| 434 | F | F434 | DIS |  |
| 434 | G | G434 | změna kontroly |  |
| 434 | H | H434 | po revizi JDv, JAn  - oprava chyb. hlášky |  |
| 435 | A | A435 | 2025-11-05 00:00:00 |  |
| 435 | B | B435 | 1.4.1 |  |
| 435 | C | C435 | n/a |  |
| 435 | D | D435 | 317 |  |
| 435 | E | E435 | Výše měsíčního daň. zvýhodnění na děti |  |
| 435 | F | F435 | DIS |  |
| 435 | G | G435 | změna kontroly |  |
| 435 | H | H435 | po revizi JDv, THa, MFo - vylepšen popis kontroly |  |
| 436 | A | A436 | 2025-11-10 00:00:00 |  |
| 436 | B | B436 | 1.4.1 |  |
| 436 | C | C436 | n/a |  |
| 436 | D | D436 | 61 |  |
| 436 | E | E436 | Globální kontrola XSD schématu |  |
| 436 | F | F436 | DIS |  |
| 436 | G | G436 | změna kontroly |  |
| 436 | H | H436 | po revizi JDv, THa, MFo - vylepšen popis kontroly |  |
| 437 | A | A437 | 2025-11-10 00:00:00 |  |
| 437 | B | B437 | 1.4.1 |  |
| 437 | C | C437 | n/a |  |
| 437 | D | D437 | 112 |  |
| 437 | E | E437 | Při uplatnění daňového zvýhodnění na děti je vyplněno alespoň 1 dítě (roční zúčtování) |  |
| 437 | F | F437 | DIS |  |
| 437 | G | G437 | změna kontroly |  |
| 437 | H | H437 | po revizi MFo, RNe, JDv - vylepšen popis kontroly, změna ch. hl. |  |
| 438 | A | A438 | 2025-11-10 00:00:00 |  |
| 438 | B | B438 | 1.4.1 |  |
| 438 | C | C438 | n/a |  |
| 438 | D | D438 | 126 |  |
| 438 | E | E438 | Kontrola na vyplnění údajů další vyživující osoby (roční zúčtování) |  |
| 438 | F | F438 | DIS |  |
| 438 | G | G438 | změna kontroly |  |
| 438 | H | H438 | po revizi MFo, RNe, JDv - vylepšen popis kontroly |  |
| 439 | A | A439 | 2025-11-10 00:00:00 |  |
| 439 | B | B439 | 1.4.1 |  |
| 439 | C | C439 | n/a |  |
| 439 | D | D439 | 328 |  |
| 439 | E | E439 | Kontrola nevyplnění údajů při nulovém počtu dnů doby odečítané po dosažení důchodového věku |  |
| 439 | F | F439 | DIS |  |
| 439 | G | G439 | změna kontroly |  |
| 439 | H | H439 | po revizi JDv, JAnd - oprava překlepu v chyb. hlášce (dvojitá mezera) |  |
| 440 | A | A440 | 2025-12-10 00:00:00 |  |
| 440 | B | B440 | 1.4.1 |  |
| 440 | C | C440 | n/a |  |
| 440 | D | D440 | 279 |  |
| 440 | E | E440 | Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P |  |
| 440 | F | F440 | DIS |  |
| 440 | G | G440 | odstranění kontroly |  |
| 440 | H | H440 | po revizi RNe, JDv - redundance k idk 65 |  |
| 441 | A | A441 | 2025-12-10 00:00:00 |  |
| 441 | B | B441 | 1.4.1 |  |
| 441 | C | C441 | n/a |  |
| 441 | D | D441 | 326 |  |
| 441 | E | E441 | Kontrola právě jednoho řádného podání |  |
| 441 | F | F441 | cJMHZ |  |
| 441 | G | G441 | změna kontroly |  |
| 441 | H | H441 | po revizi JDv, JAnd, PMys - dopřesnění kontroly, změna názvu kontroly |  |
| 442 | A | A442 | 2025-11-13 00:00:00 |  |
| 442 | B | B442 | 1.4.1 |  |
| 442 | C | C442 | n/a |  |
| 442 | D | D442 | 318 |  |
| 442 | E | E442 | Výše uvedené základní slevy na poplatníka neodpovídá legislativnímu předpisu. |  |
| 442 | F | F442 | DIS |  |
| 442 | G | G442 | změna kontroly |  |
| 442 | H | H442 | po revizi JDv, AKr - změna kontroly, vymázana část s null |  |
| 443 | A | A443 | 2025-11-13 00:00:00 |  |
| 443 | B | B443 | 1.4.1 |  |
| 443 | C | C443 | n/a |  |
| 443 | D | D443 | 87 |  |
| 443 | E | E443 | Správnost kódu ELDP |  |
| 443 | F | F443 | DIS |  |
| 443 | G | G443 | odstranění kontroly |  |
| 443 | H | H443 | po revizi JDv, MHej, LRi -  změna systému |  |
| 444 | A | A444 | 2025-11-13 00:00:00 |  |
| 444 | B | B444 | 1.4.1 |  |
| 444 | C | C444 | n/a |  |
| 444 | D | D444 | 87 |  |
| 444 | E | E444 | Správnost kódu ELDP |  |
| 444 | F | F444 | cJMHZ |  |
| 444 | G | G444 | přidání kontroly |  |
| 444 | H | H444 | po revizi JDv, MHej, LRi -  změna systému |  |
| 445 | A | A445 | 2025-11-14 00:00:00 |  |
| 445 | B | B445 | draft |  |
| 445 | C | C445 | n/a |  |
| 445 | D | D445 | 313 |  |
| 445 | E | E445 | Shoda vypočtené zálohy na daň se základem |  |
| 445 | F | F445 | DIS |  |
| 445 | G | G445 | změna kontroly |  |
| 445 | H | H445 | revize kontroly na základě připomínek od GFŘ - JDv, VZi, THa, AKr - přidána sazba 23% - prozatím jako draft |  |
| 446 | A | A446 | 2025-11-14 00:00:00 |  |
| 446 | B | B446 | 1.4.1 |  |
| 446 | C | C446 | n/a |  |
| 446 | D | D446 | 319 |  |
| 446 | E | E446 | Kontrola na vyplnění atributů odpovídajícho typu daně |  |
| 446 | F | F446 | cJMHZ |  |
| 446 | G | G446 | změna kontroly |  |
| 446 | H | H446 | po revizi JDv, AKr - změna kontroly vložen 10535 místo 10245 |  |
| 447 | A | A447 | 2025-11-18 00:00:00 |  |
| 447 | B | B447 | 1.4.1 |  |
| 447 | C | C447 | n/a |  |
| 447 | D | D447 | 316 |  |
| 447 | E | E447 | Kontrola souladu počtu dnů v evidenčním stavu s počtem dnů pojištění dle ELDP |  |
| 447 | F | F447 | DIS |  |
| 447 | G | G447 | odstranění kontroly |  |
| 447 | H | H447 | po revizi JDv, MFo - kontrola odstraněna |  |
| 448 | A | A448 | 2025-11-18 00:00:00 |  |
| 448 | B | B448 | 1.4.1 |  |
| 448 | C | C448 | n/a |  |
| 448 | D | D448 | 295 |  |
| 448 | E | E448 | Kontrola uplatnění slevy na pojistném zaměstnavatele za zaměstnance až po oznámení záměru uplatňovat tuto slevu |  |
| 448 | F | F448 | cJMHZ |  |
| 448 | G | G448 | změna kontroly |  |
| 448 | H | H448 | po revizi JDv, MKa - vylepšen detail kontroly, přidána podmínková prerekvizita: a uvedené období ZAMERY_SLEV.ZAMER_OD a ZAMERY_SLEV.ZAMER_DO spadá do období definovaného atributy (10010) Měsíc a (10011) Rok |  |
| 449 | A | A449 | 2025-11-19 00:00:00 |  |
| 449 | B | B449 | 1.4.1 |  |
| 449 | C | C449 | n/a |  |
| 449 | D | D449 | 243 |  |
| 449 | E | E449 | Kontrola adekvátních atributů pro výpočet zálohy na daň nerezidentů  s prohlášením poplatníka daně |  |
| 449 | F | F449 | cJMHZ |  |
| 449 | G | G449 | změna kontroly |  |
| 449 | H | H449 | po revizi JDv, HKy, Akr - úprava textace chybové hlášky |  |
| 450 | A | A450 | 2025-11-19 00:00:00 |  |
| 450 | B | B450 | 1.4.1 |  |
| 450 | C | C450 | n/a |  |
| 450 | D | D450 | 245 |  |
| 450 | E | E450 | Kontrola adekvátních atributů pro výpočet srážkové daně rezidentů bez prohlášení poplatníka - srážková daň |  |
| 450 | F | F450 | cJMHZ |  |
| 450 | G | G450 | změna kontroly |  |
| 450 | H | H450 | po revizi JDv, HKy, Akr - revize znění kontroly |  |
| 451 | A | A451 | 2025-11-19 00:00:00 |  |
| 451 | B | B451 | 1.4.1 |  |
| 451 | C | C451 | n/a |  |
| 451 | D | D451 | 246 |  |
| 451 | E | E451 | Kontrola adekvátních atributů pro výpočet daně členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR |  |
| 451 | F | F451 | DIS |  |
| 451 | G | G451 | odstranění kontroly |  |
| 451 | H | H451 | po revizi JDv, HKy, Akr - kontrola odstraněna |  |
| 452 | A | A452 | 2025-11-19 00:00:00 |  |
| 452 | B | B452 | 1.4.1 |  |
| 452 | C | C452 | n/a |  |
| 452 | D | D452 | 247 |  |
| 452 | E | E452 | Kontrola prerekvizit pro výpočet daně členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR |  |
| 452 | F | F452 | cJMHZ |  |
| 452 | G | G452 | odstranění kontroly |  |
| 452 | H | H452 | po revizi JDv, HKy, Akr - kontrola odstraněna |  |
| 453 | A | A453 | 2025-11-19 00:00:00 |  |
| 453 | B | B453 | 1.4.1 |  |
| 453 | C | C453 | n/a |  |
| 453 | D | D453 | 319 |  |
| 453 | E | E453 | Kontrola na vyplnění atributů odpovídajícho typu daně |  |
| 453 | F | F453 | cJMHZ |  |
| 453 | G | G453 | odstranění kontroly |  |
| 453 | H | H453 | po revizi JDv, HKy, Akr - kontrola odstraněna |  |
| 454 | A | A454 | 2025-11-19 00:00:00 |  |
| 454 | B | B454 | 1.4.1 |  |
| 454 | C | C454 | n/a |  |
| 454 | D | D454 | 324 |  |
| 454 | E | E454 | Atribut žádosti o roční zúčtování daně byl vyplněn pouze jednom měsíci (leden nebo únor) |  |
| 454 | F | F454 | cJMHZ |  |
| 454 | G | G454 | odstranění kontroly |  |
| 454 | H | H454 | po revizi JDv, HKy, Akr - kontrola odstraněna |  |
| 455 | A | A455 | 2025-11-20 00:00:00 |  |
| 455 | B | B455 | 1.4.1 |  |
| 455 | C | C455 | n/a |  |
| 455 | D | D455 | 267 |  |
| 455 | E | E455 | Kontrola nevyplnění dat pro rozklad při nulovém atributu Mzda za práci zúčtovaná |  |
| 455 | F | F455 | DIS |  |
| 455 | G | G455 | změna kontroly |  |
| 455 | H | H455 | po revizi RNe, JDv - oprava textu chybové hlášky |  |
| 456 | A | A456 | 2025-11-19 00:00:00 |  |
| 456 | B | B456 | 1.4.1 |  |
| 456 | C | C456 | n/a |  |
| 456 | D | D456 | 295 |  |
| 456 | E | E456 | Kontrola uplatnění slevy na pojistném zaměstnavatele za zaměstnance až po oznámení záměru uplatňovat tuto slevu |  |
| 456 | F | F456 | cJMHZ |  |
| 456 | G | G456 | změna kontroly |  |
| 456 | H | H456 | po revizi JDv, THa, MFo - vylepšen popis kontroly: ...spadá celé do období definovaného... |  |
| 457 | A | A457 | 2025-11-19 00:00:00 |  |
| 457 | B | B457 | 1.4.1 |  |
| 457 | C | C457 | n/a |  |
| 457 | D | D457 | 313 |  |
| 457 | E | E457 | Shoda vypočtené zálohy na daň se základem |  |
| 457 | F | F457 | DIS |  |
| 457 | G | G457 | změna kontroly |  |
| 457 | H | H457 | po revizi JDv, MFo, HKy, Akr - revize znění na základě připomínek GFŘ |  |
| 458 | A | A458 | 2025-11-20 00:00:00 |  |
| 458 | B | B458 | 1.4.1 |  |
| 458 | C | C458 | n/a |  |
| 458 | D | D458 | 217 |  |
| 458 | E | E458 | Chybný GUID podání. |  |
| 458 | F | F458 | cJMHZ |  |
| 458 | G | G458 | změna kontroly |  |
| 458 | H | H458 | po revizi JDv, MSmr - zobecnění, "opravné" odstraněno, změna ch. hl. |  |
| 459 | A | A459 | 2025-11-21 00:00:00 |  |
| 459 | B | B459 | 1.4.1 |  |
| 459 | C | C459 | n/a |  |
| 459 | D | D459 | 34 |  |
| 459 | E | E459 | =_xlfn.IFNA(VLOOKUP(D459,MH!A$2:K$528,2,FALSE), "") |  |
| 459 | F | F459 | DIS |  |
| 459 | G | G459 | změna kontroly |  |
| 459 | H | H459 | po revizi RNe, JDv - oprava textu chybové hlášky |  |
| 460 | A | A460 | 2025-11-21 00:00:00 |  |
| 460 | B | B460 | 1.4.1 |  |
| 460 | C | C460 | n/a |  |
| 460 | D | D460 | 36 |  |
| 460 | E | E460 | Počet přesčasových hodin x příplatky za práci přesčas |  |
| 460 | F | F460 | DIS |  |
| 460 | G | G460 | změna kontroly |  |
| 460 | H | H460 | po revizi RNe - oprava textu chybové hlášky |  |
| 461 | A | A461 | 2025-11-21 00:00:00 |  |
| 461 | B | B461 | 1.4.1 |  |
| 461 | C | C461 | n/a |  |
| 461 | D | D461 | 167 |  |
| 461 | E | E461 | Pojistné za zaměstnavatele u zaměstnanců, kteří vykonávají rizikové zaměstnání |  |
| 461 | F | F461 | DIS |  |
| 461 | G | G461 | změna kontroly |  |
| 461 | H | H461 | po revizi RNe - oprava textu chybové hlášky |  |
| 462 | A | A462 | 2025-11-24 00:00:00 |  |
| 462 | B | B462 | 1.4.1 |  |
| 462 | C | C462 | n/a |  |
| 462 | D | D462 | 164 |  |
| 462 | E | E462 | Kontrola na uplatnění slevy na pojistném zaměstnavatele v rámci splatnosti pojistného |  |
| 462 | F | F462 | DIS |  |
| 462 | G | G462 | změna kontroly |  |
| 462 | H | H462 | po revizi JDv - jen přidání poznámky, lhůsta splatnosti |  |
| 463 | A | A463 | 2025-11-25 00:00:00 |  |
| 463 | B | B463 | 1.4.1 |  |
| 463 | C | C463 | n/a |  |
| 463 | D | D463 | 164 |  |
| 463 | E | E463 | Kontrola na uplatnění slevy na pojistném zaměstnavatele v rámci splatnosti pojistného |  |
| 463 | F | F463 | DIS |  |
| 463 | G | G463 | změna kontroly |  |
| 463 | H | H463 | po revizi JDv, THa - vypnutí kontroly pro podání v měsících - 1Q2026 |  |
| 464 | A | A464 | 2025-11-26 00:00:00 |  |
| 464 | B | B464 | 1.4.1 |  |
| 464 | C | C464 | n/a |  |
| 464 | D | D464 | 37 |  |
| 464 | E | E464 | Formát IK MPSV |  |
| 464 | F | F464 | DIS |  |
| 464 | G | G464 | změna kontroly |  |
| 464 | H | H464 | po revizi JDv, MFo, RNe - upřesnění kontroly (zpřesnění definice k IK MPSV) |  |
| 465 | A | A465 | 2025-11-25 00:00:00 |  |
| 465 | B | B465 | 1.4.1.1 |  |
| 465 | C | C465 | n/a |  |
| 465 | D | D465 | 332 |  |
| 465 | E | E465 | Povinnost atributu primární pracovněprávní pravní vztah zaměstnance v jednotlivých dat. scénářích |  |
| 465 | F | F465 | DIS |  |
| 465 | G | G465 | změna kontroly |  |
| 465 | H | H465 | po revizi JDv, THa - na základě změny povinnosti atributu, přidána logická kontrola (detail v chglogu v DS) |  |
| 466 | A | A466 | 2025-11-28 00:00:00 |  |
| 466 | B | B466 | 1.4.1.1 |  |
| 466 | C | C466 | n/a |  |
| 466 | D | D466 | 207 |  |
| 466 | E | E466 | Úhrn vyměřovacích základů zaměstnanců, za které zaměstnavatel uplatňuje slevu na pojistném zaměstnavatele |  |
| 466 | F | F466 | cJMHZ |  |
| 466 | G | G466 | změna kontroly |  |
| 466 | H | H466 | po revizi JDv, THa - změna typu chyby na ePortálu na => propustnou |  |
| 467 | A | A467 | 2025-11-28 00:00:00 |  |
| 467 | B | B467 | 1.4.1.1 |  |
| 467 | C | C467 | n/a |  |
| 467 | D | D467 | 209 |  |
| 467 | E | E467 | Úhrn slev na pojistném zaměstnanců |  |
| 467 | F | F467 | cJMHZ |  |
| 467 | G | G467 | změna kontroly |  |
| 467 | H | H467 | po revizi JDv, THa - změna typu chyby na ePortálu na => propustnou |  |
| 468 | A | A468 | 2025-10-02 00:00:00 |  |
| 468 | B | B468 | 1.4.1.1 |  |
| 468 | C | C468 | n/a |  |
| 468 | D | D468 | 243 |  |
| 468 | E | E468 | Kontrola adekvátních atributů pro výpočet zálohy na daň nerezidentů  s prohlášením poplatníka daně |  |
| 468 | F | F468 | cJMHZ |  |
| 468 | G | G468 | změna kontroly |  |
| 468 | H | H468 | po revizi JDv, THa, MFo, RNe - po revizi a přidány do negativní kontroly atributy pro srážkovou daň |  |
| 469 | A | A469 | 2025-12-03 00:00:00 |  |
| 469 | B | B469 | 1.4.1.1 |  |
| 469 | C | C469 | n/a |  |
| 469 | D | D469 | 313 |  |
| 469 | E | E469 | Shoda vypočtené zálohy na daň se základem |  |
| 469 | F | F469 | DIS |  |
| 469 | G | G469 | změna kontroly |  |
| 469 | H | H469 | po revizi JDV, MFo, Akr - po konzultaci s pí. Vaňk., rozšířen detail popisu kontroly |  |
| 470 | A | A470 | 2025-12-04 00:00:00 |  |
| 470 | B | B470 | 1.4.1.1 |  |
| 470 | C | C470 | n/a |  |
| 470 | D | D470 | 299 |  |
| 470 | E | E470 | Kontrola datumu pojištění od a do v průběhu pojištění v měsíci |  |
| 470 | F | F470 | DIS |  |
| 470 | G | G470 | změna kontroly |  |
| 470 | H | H470 | po revizi JDv, THa - vylepšen popis kontroly + změ |  |
| 471 | A | A471 | 2025-12-04 00:00:00 |  |
| 471 | B | B471 | storno |  |
| 471 | C | C471 | n/a |  |
| 471 | D | D471 | 313 |  |
| 471 | E | E471 | Shoda vypočtené zálohy na daň se základem |  |
| 471 | F | F471 | DIS |  |
| 471 | G | G471 | odstranění kontroly |  |
| 471 | H | H471 | po revizi JDv, MFo, THa - po konzultaci s GFR, je potřeba implementovat propustnou kontrolu, je třeba změn. požadavek + nař. vlády |  |
| 472 | A | A472 | 2025-12-05 00:00:00 |  |
| 472 | B | B472 | 1.4.1.1 |  |
| 472 | C | C472 | n/a |  |
| 472 | D | D472 | 190 |  |
| 472 | E | E472 | Stornování celého řádného podání |  |
| 472 | F | F472 | DIS |  |
| 472 | G | G472 | změna kontroly |  |
| 472 | H | H472 | po revizi MFo, JDv, PMy - rozšířen detail popisu kontroly |  |
| 473 | A | A473 | 2025-12-05 00:00:00 |  |
| 473 | B | B473 | 1.4.1.1 |  |
| 473 | C | C473 | n/a |  |
| 473 | D | D473 | 204 |  |
| 473 | E | E473 | Stornování součástí individualizované části |  |
| 473 | F | F473 | DIS |  |
| 473 | G | G473 | změna kontroly |  |
| 473 | H | H473 | po revizi MFo, JDv, PMy - rozšířen detail popisu kontroly |  |
| 474 | A | A474 | 2025-12-08 00:00:00 |  |
| 474 | B | B474 | 1.4.1.1 |  |
| 474 | C | C474 | n/a |  |
| 474 | D | D474 | 29 |  |
| 474 | E | E474 | Příplatky |  |
| 474 | F | F474 | DIS |  |
| 474 | G | G474 | změna kontroly |  |
| 474 | H | H474 | po revizi MFo, JDv, RKu, MKl  - upraven výpočet v popisu kontroly - odstraněn atribut (10333) |  |
| 475 | A | A475 | 2025-12-08 00:00:00 |  |
| 475 | B | B475 | 1.4.1.1 |  |
| 475 | C | C475 | n/a |  |
| 475 | D | D475 | 317 |  |
| 475 | E | E475 | Výše měsíčního daň. zvýhodnění na děti |  |
| 475 | F | F475 | DIS |  |
| 475 | G | G475 | změna kontroly |  |
| 475 | H | H475 | po revizi JDv, VeZ - upraven detail popisu kontroly |  |
| 476 | A | A476 | 2025-12-08 00:00:00 |  |
| 476 | B | B476 | 1.4.1.1 |  |
| 476 | C | C476 | n/a |  |
| 476 | D | D476 | 317 |  |
| 476 | E | E476 | Výše měsíčního daň. zvýhodnění na děti |  |
| 476 | F | F476 | DIS |  |
| 476 | G | G476 | změna kontroly |  |
| 476 | H | H476 | po revizi JDv, VeZ - vylepšen detail popisu |  |
| 477 | A | A477 | 2025-12-10 00:00:00 |  |
| 477 | B | B477 | 1.4.1.1 |  |
| 477 | C | C477 | n/a |  |
| 477 | D | D477 | 205 |  |
| 477 | E | E477 | Řádné podání musí obsahovat min. jednu součást individualizované části. |  |
| 477 | F | F477 | DIS |  |
| 477 | G | G477 | odstranění kontroly |  |
| 477 | H | H477 | po revizi JDv, MFo, THa, RNe - odstranění kontroly z důvodu redundance s idk 232 |  |
| 478 | A | A478 | 2025-12-10 00:00:00 |  |
| 478 | B | B478 | 1.4.1.1 |  |
| 478 | C | C478 | n/a |  |
| 478 | D | D478 | 333 |  |
| 478 | E | E478 | Časové omezení uplatnění slevy na pojistném (01–03/2026) |  |
| 478 | F | F478 | DIS |  |
| 478 | G | G478 | přidání kontroly |  |
| 478 | H | H478 | po revizi JDv, DMa - přidání kontroly |  |
| 479 | A | A479 | 2025-12-11 00:00:00 |  |
| 479 | B | B479 | smazáno |  |
| 479 | C | C479 | n/a |  |
| 479 | D | D479 | 32 |  |
| 479 | E | E479 | Odpracované hodiny x mzda zúčtovaná |  |
| 479 | F | F479 | DIS |  |
| 479 | G | G479 | změna kontroly |  |
| 479 | H | H479 | po revizi JDv, DVe - suspendování kontroly |  |
| 480 | A | A480 | 2025-12-12 00:00:00 |  |
| 480 | B | B480 | 1.4.1.1 |  |
| 480 | C | C480 | n/a |  |
| 480 | D | D480 | 261 |  |
| 480 | E | E480 | Kontrola odpovídajícího  ID PPV a VS v systémech ČSSZ |  |
| 480 | F | F480 | DIS |  |
| 480 | G | G480 | změna kontroly |  |
| 480 | H | H480 | po revizi RNe - revize možnosti validace na validátoru |  |
| 481 | A | A481 | 2025-12-15 00:00:00 |  |
| 481 | B | B481 | 1.4.1.2 |  |
| 481 | C | C481 | n/a |  |
| 481 | D | D481 | 81 |  |
| 481 | E | E481 | Rodné číslo splňuje modulo |  |
| 481 | F | F481 | DIS |  |
| 481 | G | G481 | změna kontroly |  |
| 481 | H | H481 | po revizi JDv - do kontroly přidány atributy 10457, 10542 |  |
| 482 | A | A482 | 2025-12-17 00:00:00 |  |
| 482 | B | B482 | 1.4.1.2 |  |
| 482 | C | C482 | n/a |  |
| 482 | D | D482 | 74 |  |
| 482 | E | E482 | Výše vyplaceného měsíčního daňového bonusu |  |
| 482 | F | F482 | cJMHZ |  |
| 482 | G | G482 | změna kontroly |  |
| 482 | H | H482 | po revizi JDv, THa, AKr - oprava, změna na propustnou kontrolu na prevalidační vrstvě - ePortál |  |
| 483 | A | A483 | 2025-12-17 00:00:00 |  |
| 483 | B | B483 | 1.4.1.2 |  |
| 483 | C | C483 | n/a |  |
| 483 | D | D483 | 230 |  |
| 483 | E | E483 | Kontrola kolize pořadí dítěte v měsíci (roční zúčtovaní) |  |
| 483 | F | F483 | cJMHZ |  |
| 483 | G | G483 | změna kontroly |  |
| 483 | H | H483 | po revizi JDv, THa, AKr - oprava, změna na propustnou kontrolu na prevalidační vrstvě - ePortál |  |
| 484 | A | A484 | 2025-12-17 00:00:00 |  |
| 484 | B | B484 | 1.4.1.2 |  |
| 484 | C | C484 | n/a |  |
| 484 | D | D484 | 148 |  |
| 484 | E | E484 | Specifická právní skutečnost |  |
| 484 | F | F484 | DIS |  |
| 484 | G | G484 | změna kontroly |  |
| 484 | H | H484 | po revizi JDv, THa, AKr - přidání nepropustné kontroly na prevalidační vrstvě - ePortál |  |
| 485 | A | A485 | 2025-12-18 00:00:00 |  |
| 485 | B | B485 | 1.4.1.2 |  |
| 485 | C | C485 | n/a |  |
| 485 | D | D485 | 37 |  |
| 485 | E | E485 | Formát IK MPSV |  |
| 485 | F | F485 | DIS |  |
| 485 | G | G485 | změna kontroly |  |
| 485 | H | H485 | po revizi JDv, RNe - upřesnění kontroly (pravidlo pro IK MPSV)<br>(Přidáno do WIKI : Na první pozici identifikátoru IK MPSV (OIČ) je vždy číslice 1.) |  |
| 486 | A | A486 | 2025-12-19 00:00:00 |  |
| 486 | B | B486 | 1.4.1.2 |  |
| 486 | C | C486 | n/a |  |
| 486 | D | D486 | 253 |  |
| 486 | E | E486 | Kontrola unikátnosti ID PPV v rámci dílčího podání |  |
| 486 | F | F486 | DIS |  |
| 486 | G | G486 | změna kontroly |  |
| 486 | H | H486 | po revizi JDv, THa - přidání podmínky vyjimky pro scénář odloženého příjmu |  |
| 487 | A | A487 | 2025-12-22 00:00:00 |  |
| 487 | B | B487 | 1.4.1.2 |  |
| 487 | C | C487 | n/a |  |
| 487 | D | D487 | 334 |  |
| 487 | E | E487 | Kontrola ztotožnění |  |
| 487 | F | F487 | DIS |  |
| 487 | G | G487 | přidání kontroly |  |
| 487 | H | H487 | po revizi JDv, LRi - přidání kontroly pro ztožnění dle identifikace (BAM) - typ F2 |  |
| 488 | A | A488 | 2025-12-31 00:00:00 |  |
| 488 | B | B488 | 1.4.1.2 |  |
| 488 | C | C488 | n/a |  |
| 488 | D | D488 | 320 |  |
| 488 | E | E488 | Výše vypočtené srážkové daně |  |
| 488 | F | F488 | DIS |  |
| 488 | G | G488 | odstranění kontroly |  |
| 488 | H | H488 | po revizi JDv, VerZ, MarO - kontrola odstraněna  |  |
| 489 | A | A489 | 2026-01-07 00:00:00 |  |
| 489 | B | B489 | 1.4.1.2 |  |
| 489 | C | C489 | n/a |  |
| 489 | D | D489 | 74 |  |
| 489 | E | E489 | Výše vyplaceného měsíčního daňového bonusu |  |
| 489 | F | F489 | cJMHZ |  |
| 489 | G | G489 | změna kontroly |  |
| 489 | H | H489 | po revizi JDv, THa, AKr - oprava, změna zpět na nepropustnou kontrolu na prevalidační vrstvě - ePortál |  |
| 490 | A | A490 | 2026-01-07 00:00:00 |  |
| 490 | B | B490 | 1.4.1.2 |  |
| 490 | C | C490 | n/a |  |
| 490 | D | D490 | 230 |  |
| 490 | E | E490 | Kontrola kolize pořadí dítěte v měsíci (roční zúčtovaní) |  |
| 490 | F | F490 | cJMHZ |  |
| 490 | G | G490 | změna kontroly |  |
| 490 | H | H490 | po revizi JDv, THa, AKr - oprava, změna zpět na nepropustnou kontrolu na prevalidační vrstvě - ePortál |  |
| 491 | A | A491 | 2026-01-09 00:00:00 |  |
| 491 | B | B491 | 1.4.1.2 |  |
| 491 | C | C491 | n/a |  |
| 491 | D | D491 | 325 |  |
| 491 | E | E491 | Kontrola adekvátních atributů pro výpočet zálohy na daň rezidentů - zálohová daň |  |
| 491 | F | F491 | cJMHZ |  |
| 491 | G | G491 | změna kontroly |  |
| 491 | H | H491 | po revizi JDv, THa, AKr, HKy - reformulace logického operandu z "nebo" na "a zároveň" |  |
| 492 | A | A492 | 2026-01-09 00:00:00 |  |
| 492 | B | B492 | 1.4.1.2 |  |
| 492 | C | C492 | n/a |  |
| 492 | D | D492 | 65 |  |
| 492 | E | E492 | Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P |  |
| 492 | F | F492 | DIS |  |
| 492 | G | G492 | odstranění kontroly |  |
| 492 | H | H492 | po revizi JDv, THa, AKr, HKy - v rámci optimalizace vypnuto |  |
| 493 | A | A493 | 2026-01-09 00:00:00 |  |
| 493 | B | B493 | 1.4.1.2 |  |
| 493 | C | C493 | n/a |  |
| 493 | D | D493 | 83 |  |
| 493 | E | E493 | Rodné číslo souhlasí s uvedeným datem narození - vyživující osoba |  |
| 493 | F | F493 | DIS |  |
| 493 | G | G493 | odstranění kontroly |  |
| 493 | H | H493 | po revizi JDv, THa, AKr, HKy - v rámci optimalizace vypnuto |  |
| 494 | A | A494 | 2026-01-09 00:00:00 |  |
| 494 | B | B494 | 1.4.1.2 |  |
| 494 | C | C494 | n/a |  |
| 494 | D | D494 | 279 |  |
| 494 | E | E494 | Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P |  |
| 494 | F | F494 | DIS |  |
| 494 | G | G494 | odstranění kontroly |  |
| 494 | H | H494 | po revizi JDv, THa, AKr, HKy - v rámci optimalizace vypnuto |  |
| 495 | A | A495 | 2026-01-13 00:00:00 |  |
| 495 | B | B495 | 1.4.1.2 |  |
| 495 | C | C495 | n/a |  |
| 495 | D | D495 | 99 |  |
| 495 | E | E495 | "Platnost kódu od/do" se týká aktuálního měsíce |  |
| 495 | F | F495 | DIS |  |
| 495 | G | G495 | změna kontroly |  |
| 495 | H | H495 | po revizi JDv, HRIS 445 - přidáná vyjimka spuštění kontroly pro dat. scénář odloženého příjmu |  |
| 496 | A | A496 | 2026-01-13 00:00:00 |  |
| 496 | B | B496 | 1.4.1.2 |  |
| 496 | C | C496 | n/a |  |
| 496 | D | D496 | 335 |  |
| 496 | E | E496 | Kontrola správnosti atributu Obec |  |
| 496 | F | F496 | DIS |  |
| 496 | G | G496 | přidání kontroly |  |
| 496 | H | H496 | po revizi JDv, THa přidáná kontrola pro verifikaci atributu Obec z číselníku CISOB |  |
| 497 | A | A497 | 2026-01-16 00:00:00 |  |
| 497 | B | B497 | 1.4.1.2 |  |
| 497 | C | C497 | n/a |  |
| 497 | D | D497 | 291 |  |
| 497 | E | E497 | Kontrola platnosti záměru ve vztahu k zaměstnání, z něhož je sleva na pojistném zaměstnavatele za zaměstnance uplatňována |  |
| 497 | F | F497 | cJMHZ |  |
| 497 | G | G497 | změna kontroly |  |
| 497 | H | H497 | po revizi JDv, DMa -tato kontrola přesenuta do stavu draft |  |
| 498 | A | A498 | 2026-01-16 00:00:00 |  |
| 498 | B | B498 | 1.4.1.2 |  |
| 498 | C | C498 | n/a |  |
| 498 | D | D498 | 295 |  |
| 498 | E | E498 | Kontrola uplatnění slevy na pojistném zaměstnavatele za zaměstnance až po oznámení záměru uplatňovat tuto slevu |  |
| 498 | F | F498 | cJMHZ |  |
| 498 | G | G498 | změna kontroly |  |
| 498 | H | H498 | po revizi JDv, DMa -tato kontrola přesenuta do stavu draft |  |
| 499 | A | A499 | 2026-01-16 00:00:00 |  |
| 499 | B | B499 | 1.4.1.2 |  |
| 499 | C | C499 | n/a |  |
| 499 | D | D499 | 116 |  |
| 499 | E | E499 | Povinné RČ nebo datum narození ve výsledku ročného zúčtování |  |
| 499 | F | F499 | DIS |  |
| 499 | G | G499 | odstranění kontroly |  |
| 499 | H | H499 | po revizi JDv, THa, AKr, HKy - v rámci optimalizace vypnuto |  |
| 500 | A | A500 | 2026-01-16 00:00:00 |  |
| 500 | B | B500 | 1.4.1.2 |  |
| 500 | C | C500 | n/a |  |
| 500 | D | D500 | 81 |  |
| 500 | E | E500 | Rodné číslo splňuje modulo |  |
| 500 | F | F500 | DIS |  |
| 500 | G | G500 | změna kontroly |  |
| 500 | H | H500 | po revizi JDv, THa, AKr, HKy - v rámci optimalizace vypnuto odstraněny atributy |  |

- Počet uvedených buněk (nenulová hodnota a/nebo komentář): **3989**

---

## List: Popis propustnosti
- Rozsah listu dle `dimensions`: `B2:G12`

| Řádek | Sloupec | Buňka | Hodnota | Komentář |
|---:|:---:|:---:|---|---|
| 2 | B | B2 | vstupy dat |  |
| 2 | C | C2 | webový prohlížeč |  |
| 2 | D | D2 | APEP, ISDS |  |
| 3 | C | C3 | e-Portál |  |
| 3 | D | D3 | DIS |  |
| 3 | E | E3 | cJHMZ |  |
| 4 | B | B4 | NEPROPUSTNÁ |  |
| 4 | C | C4 | ano |  |
| 4 | D | D4 | ano |  |
| 4 | E | E4 | ano |  |
| 5 | B | B5 | PROPUSTNÁ |  |
| 5 | C | C5 | ano |  |
| 5 | D | D5 | ne |  |
| 5 | E | E5 | ano |  |
| 7 | B | B7 | Pojem  |  |
| 7 | C | C7 | Vysvětlení |  |
| 7 | E | E7 | Následek |  |
| 7 | F | F7 | Další postup |  |
| 7 | G | G7 | Konzumace  |  |
| 8 | B | B8 | Kanál pro vykonávání kontroly |  |
| 8 | C | C8 | ePortál, DIS, cJMHZ |  |
| 9 | B | B9 | Typ kontroly |  |
| 9 | C | C9 | Nepropustná, propustná  |  |
| 10 | B | B10 | Částečné přijetí  |  |
| 10 | C | C10 | Podání je přijato v částech, které jsou bezvadné. |  |
| 11 | B | B11 | Nepropustná kontrola |  |
| 11 | C | C11 | Nepropustná kontrola je kontrola na technické nebo  formální vady (s výjimkou méně závažných), které způsobí následek v podobě neúčinnosti podání, jeho části nebo součásti. |  |
| 11 | E | E11 | 1) v případě formální vady, dojde k zamítnutí části nebo součásti podání - částečné přijetí.<br>2) v případě technické vady nebo v případě vady všech částech podání, dojde k zamítnutí celého podání.  |  |
| 11 | F | F11 | Výzva k podání opravného ohlášení (§13 návrhu zákona o JMHZ).  |  |
| 11 | G | G11 | Tato nevalidní data nebudou standardně zpřístupněna uživatelům údajů. Pokud budou vady v jiných atributech než pro FS, budou po první automatizované výzvě zpřístupněna uživatelům údajů FS  (pouze pro uživatele údajů FS). |  |
| 12 | B | B12 | Propustná kontrola |  |
| 12 | C | C12 | Propustná kontrola je kontrola na méně závažné vady podání, které nezpůsobí následek v podobě neúčinnosti podání.  |  |
| 12 | E | E12 | Nezpůsobuje neúčinnost části nebo součásti podání. |  |
| 12 | F | F12 | Bez výzvy na zaměstnavatele. |  |
| 12 | G | G12 | Tato nevalidní data budou poskytnuta uživatelům údajů bezodkladně po jejich přijetí (s informací, že se jedná o propustnou vadu). |  |

- Počet uvedených buněk (nenulová hodnota a/nebo komentář): **35**

---

## List: Kategorie kontrol
- Rozsah listu dle `dimensions`: `A1:I43`

| Řádek | Sloupec | Buňka | Hodnota | Komentář |
|---:|:---:|:---:|---|---|
| 1 | A | A1 | PODÁNÍ |  |
| 2 | A | A2 | Typ kontroly |  |
| 2 | B | B2 | Zákon o JMHZ |  |
| 2 | C | C2 | Pořadí |  |
| 2 | D | D2 | Kategorie kontroly |  |
| 2 | E | E2 | Komponenta realizující kontrolu  |  |
| 2 | F | F2 | Příklady kategorie kontrol |  |
| 2 | G | G2 | Zdroj kontrol |  |
| 2 | H | H2 | Předpoklad |  |
| 3 | A | A3 | technická |  |
| 3 | B | B3 | § 9 zákona o JMHZ - Technická vada podání |  |
| 3 | C | C3 | 1 | tc={05CC11B1-901D-4383-9256-5A30FD5F983B}: [Komentář ve vlákně]<br><br>Vaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924<br><br>Komentář:<br>    Nemusí být zřejmé, že se jedná o konkrétní podání JMHZ |
| 3 | D | D3 | Zpráva byla předána přes správné rozhraní |  |
| 3 | E | E3 | IKR |  |
| 3 | F | F3 | Registrace ZEC není podána rozhraním pro MĚS HLA |  |
| 3 | G | G3 | Zákon o JMHZ § 8 |  |
| 3 | H | H3 | Přijetí podání (v případě nesplnění je odmítnuto celé podání - neúčinné podání) |  |
| 4 | C | C4 | 2 | tc={DB1B8D52-0FD1-4A79-9B6B-2A82974ABD99}: [Komentář ve vlákně]<br><br>Vaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924<br><br>Komentář:<br>    Nemusí být zřejmé, že se jedná o konkrétní podání JMHZ |
| 4 | D | D4 | Kontrola platnosti elektronického podpisu |  |
| 4 | E | E4 | DIS |  |
| 4 | F | F4 | Kontrola šifrovacího certifikátu a podpisového certifikátu |  |
| 4 | G | G4 | Technický popis podání |  |
| 5 | C | C5 | 3 | tc={86962566-7E0C-4AC3-AF1A-6FE0275FE826}: [Komentář ve vlákně]<br><br>Vaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924<br><br>Komentář:<br>    Nemusí být zřejmé, že se jedná o konkrétní podání JMHZ |
| 5 | D | D5 | Kontrola autentizace + autorizace |  |
| 5 | E | E5 | DIS, MIP |  |
| 5 | F | F5 | Kontrola na mandatní registr   |  |
| 5 | G | G5 | Technický popis podání |  |
| 6 | C | C6 | 4 | tc={82759D02-8CF3-4C98-93E1-772FCB81CFE5}: [Komentář ve vlákně]<br><br>Vaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924<br><br>Komentář:<br>    DIS zašle informaci o zamítnutí podání do cJMHZ |
| 6 | D | D6 | Kontrola XML proti XSD (kontrola čitelnosti) - zjednodušené XSD |  |
| 6 | E | E6 | DIS |  |
| 6 | F | F6 | Kontrola XML proti XSD - jestli obsahuje všechny tagy a je čitelné XML  |  |
| 6 | G | G6 | XSD |  |
| 7 | C | C7 | 5 | tc={DDC94635-A053-4644-B49F-239332D7C52A}: [Komentář ve vlákně]<br><br>Vaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924<br><br>Komentář:<br>    DIS zašle informaci o zamítnutí podání do cJMHZ |
| 7 | D | D7 | Strukturální kontroly |  |
| 7 | E | E7 | DIS, cJMHZ |  |
| 7 | F | F7 | 1. DP obsahuje povinné části |  |
| 8 | C | C8 | 6 | tc={345D0349-8378-45C4-9523-FFEF89EE1CB5}: [Komentář ve vlákně]<br><br>Vaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924<br><br>Komentář:<br>    DIS zašle informaci o zamítnutí podání do cJMHZ |
| 8 | D | D8 | Kontrola období podání (metadata) |  |
| 8 | E | E8 | DIS |  |
| 8 | F | F8 | Podání může být podáno nejdříve 1. následujícího měsíce, za který je podáváno |  |
| 8 | G | G8 | Technický popis podání |  |
| 9 | C | C9 | 7 | tc={695177AC-7C82-4958-8F07-BFDDFF25DF40}: [Komentář ve vlákně]<br><br>Vaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924<br><br>Komentář:<br>    DIS zašle informaci o zamítnutí podání do cJMHZ |
| 9 | D | D9 | Velikost zprávy |  |
| 9 | E | E9 | DIS |  |
| 9 | F | F9 | limit 1500 formulářů na dílčí podání |  |
| 9 | G | G9 | Definice omezení dle IT ČSSZ |  |
| 10 | C | C10 | 8 | tc={EE28866A-C11A-442B-95C0-CF58B4B62E12}: [Komentář ve vlákně]<br><br>Vaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924<br><br>Komentář:<br>    DIS zašle informaci o zamítnutí podání do cJMHZ |
| 10 | D | D10 | Duplicita zprávy |  |
| 10 | E | E10 | DIS |  |
| 10 | F | F10 | Totožné dílčí podání (se stejným obsahem) |  |
| 11 | C | C11 | 9 |  |
| 11 | D | D11 | Kontroly (technické) na cJMHZ |  |
| 11 | E | E11 | cJMHZ |  |
| 11 | F | F11 | Duplicita GUID, podání obsahuje všechny validní části, vyplněné totožné datum podání |  |
| 12 | C | C12 | 10 |  |
| 12 | D | D12 | Posouzení ne/účinnosti podání |  |
| 12 | E | E12 | cJMHZ |  |
| 12 | F | F12 | Zamítnutí celého podání (všech dílčích podání) na základě neúčinnosti alespoň 1 dílčího podání |  |
| 13 | D | D13 | metodický pokyn - technická vada v dílčím podání, cJMHZ pošle protokol o neúčinnosti celého podání (stejný GUID u 1 VS, za 1 období), zavedení message do Kafky o neúčinnosti 1 dílčího podání (platí i pro 1 DP) |  |
| 14 | A | A14 | formální |  |
| 14 | B | B14 | § 10 zákona o JMHZ - Formální vada podání |  |
| 14 | C | C14 | 1 |  |
| 14 | D | D14 | Kontroly dílčích formulářů dle XSD na povinnosti, formát dat, omezení datového typu, kontrola na použití dle číselníku. |  |
| 14 | E | E14 | DIS |  |
| 14 | F | F14 | RČ jen 9 nebo 10 znaků, nejčastěji je používán limit 255 znaků, RČ a IK MPSV - kontrola na modulo 11, datum ve formátu DD/MM/RRRR, kontrola na číselníkové hodnoty - například pohlaví počítáno z RČ proti číselníku pohlaví  |  |
| 14 | G | G14 | datový slovník, excel interakce, implementačně XSD |  |
| 14 | H | H14 | Parsování na jednotlivé formuláře (v případě nesplnění je odmítnut formulář nebo PVPOJ; je umožněno částečné přijetí); ČSSZ vyhodnocuje jako nepropustnou chybu (pro všechny uživatele), pro FS vyhodnoceno jako propustná chyba - pokud se chyba týká jen údajů, které FS nekonzumuje.  |  |
| 15 | C | C15 | 2 |  |
| 15 | D | D15 | Kontrola na ne/ztotožněnou osobu. |  |
| 15 | E | E15 | DIS |  |
| 15 | F | F15 | Kontrola OIČ na kmenové evidence a konflikty na ztotožnění  |  |
| 15 | G | G15 | definice aplikačních kontrol - excel |  |
| 16 | C | C16 | 3 |  |
| 16 | D | D16 | Kontrola na duplicitu formulářů v rámci jednoho podání. |  |
| 16 | E | E16 | DIS |  |
| 16 | F | F16 | Duplicitní podání stejného ZEC a ID PPV |  |
| 16 | G | G16 | definice aplikačních kontrol - excel |  |
| 17 | C | C17 | 4 |  |
| 17 | D | D17 | Všechny ostatní aplikační kontroly nad daty formulářů realizované v DIS. |  |
| 17 | E | E17 | DIS |  |
| 17 | F | F17 | Např. uhrnVymerovacichZakladu <=uhrnVymerovacichZakladuBezni +uhrnVymerovacichZakladuZachranari. |  |
| 17 | G | G17 | definice aplikačních kontrol - excel |  |
| 18 | C | C18 | 5 |  |
| 18 | D | D18 | Kontroly daného podání proti datům v bázi cJMHZ realizované v cJMHZ. |  |
| 18 | E | E18 | cJMHZ |  |
| 18 | F | F18 | Kontrola podání vůči KE ZAM - počet součástí za období  |  |
| 18 | G | G18 | definice aplikačních kontrol - excel |  |
| 27 | A | A27 | Legenda: |  |
| 27 | B | B27 | ZEL |  |
| 27 | C | C27 | zaměstnavatel |  |
| 28 | B | B28 | ZEC |  |
| 28 | C | C28 | zaměstnanec |  |
| 29 | B | B29 | MĚS HLA |  |
| 29 | C | C29 | jednotné měsíční hlášení |  |

- Počet uvedených buněk (nenulová hodnota a/nebo komentář): **94**

---

## List: Parametrické konstanty
- Rozsah listu dle `dimensions`: `A1:F24`

| Řádek | Sloupec | Buňka | Hodnota | Komentář |
|---:|:---:|:---:|---|---|
| 1 | A | A1 | ID kontroly |  |
| 1 | B | B1 | Název konstanty |  |
| 2 | C | C2 | 2025-01 |  |
| 2 | D | D2 | 2026-01 |  |
| 2 | E | E2 | 2027-01 |  |
| 2 | F | F2 | 2028-01 |  |
| 3 | A | A3 | 8, 315 |  |
| 3 | B | B3 | pojistné za zaměstnavatele (10024, 10478) |  |
| 3 | C | C3 | 0.248 |  |
| 3 | D | D3 | 0.248 |  |
| 3 | E | E3 | 0.248 |  |
| 3 | F | F3 | 0.248 |  |
| 4 | A | A4 | 10, 315 |  |
| 4 | B | B4 | Pojistné za zaměstnavatele (10026, 10479) |  |
| 4 | C | C4 | 0.288 |  |
| 4 | D | D4 | 0.298  |  |
| 4 | E | E4 | 0.298 |  |
| 4 | F | F4 | 0.298  |  |
| 5 | A | A5 | 167, 315 |  |
| 5 | B | B5 | Pojistné za zaměstnavatele (10484, 10480) |  |
| 5 | C | C5 | 0.268 |  |
| 5 | D | D5 | 0.278 |  |
| 5 | E | E5 | 0.288 |  |
| 5 | F | F5 | 0.298 |  |
| 6 | A | A6 | 3 |  |
| 6 | B | B6 | Sleva na pojistném |  |
| 6 | C | C6 | 5 |  |
| 6 | D | D6 | 5 |  |
| 7 | A | A7 | 118 |  |
| 7 | B | B7 | Pojistné za zaměstnance - sazbu pojistného na důchodové pojištění placenou zaměstnancem |  |
| 7 | C | C7 | 0.071 |  |
| 7 | D | D7 | 0.071 |  |
| 8 | A | A8 | 168 |  |
| 8 | B | B8 | Pojistné za zaměstnance - sazbu pojistného na důchodové pojištění placenou zaměstnancem (delta) |  |
| 8 | C | C8 | 0.07171 |  |
| 8 | D | D8 | 0.07171 |  |
| 9 | A | A9 | 170 |  |
| 9 | B | B9 | Úhrn slev na pojistném zaměstnanců - Sazbu slevy na pojistném na sociální zabezpečení podle § 7a zákona č. 589/1992 Sb |  |
| 9 | C | C9 | 0.065 |  |
| 9 | D | D9 | 0.065 |  |
| 10 | A | A10 | 170 |  |
| 10 | B | B10 | Úhrn slev na pojistném zaměstnanců - Sazbu slevy na pojistném na sociální zabezpečení podle § 7a zákona č. 589/1992 Sb (delta) |  |
| 10 | C | C10 | 0.06565 |  |
| 10 | D | D10 | 0.06565 |  |
| 11 | A | A11 | 15 |  |
| 11 | B | B11 | Maximální možný počet odpracovaných hodin |  |
| 11 | C | C11 | 240 |  |
| 11 | D | D11 | 240 |  |
| 12 | A | A12 | 45 |  |
| 12 | B | B12 | Rozsah kratší pracovní/služební doby |  |
| 12 | C | C12 | 30 |  |
| 12 | D | D12 | 30 |  |
| 13 | A | A13 | 244, 245, 325 |  |
| 13 | B | B13 | Rozhodná hranice příjmu pro účast na pojištění u ZMR (zaměstnání malého rozsahu) |  |
| 13 | C | C13 | 4500 |  |
| 13 | D | D13 | 4500 |  |
| 14 | A | A14 | 244, 245, 325 |  |
| 14 | B | B14 | Rozhodná hranice pro vznik účasti na pojištění u DPP |  |
| 14 | C | C14 | 11500 |  |
| 14 | D | D14 | 12000 |  |
| 15 | A | A15 | 74 |  |
| 15 | B | B15 | Výše vyplaceného měsíčního daňového bonusu |  |
| 15 | C | C15 | 50 |  |
| 15 | D | D15 | 50 |  |
| 16 | A | A16 | 271 |  |
| 16 | B | B16 | Průměrná mzda dle § 23b odst. 4 ZPSZ zaokrouhlená na celou pětisetkorunu dolů |  |
| 16 | C | C16 | 46500 |  |
| 16 | D | D16 | 49000 |  |
| 17 | A | A17 | 317 |  |
| 17 | B | B17 | Výše měsíčního daň. zvýhodnění na děti, I. |  |
| 17 | C | C17 | 1267 |  |
| 17 | D | D17 | 1267 |  |
| 18 | A | A18 | 317 |  |
| 18 | B | B18 | Výše měsíčního daň. zvýhodnění na děti, II. |  |
| 18 | C | C18 | 1860 |  |
| 18 | D | D18 | 1860 |  |
| 19 | A | A19 | 317 |  |
| 19 | B | B19 | Výše měsíčního daň. zvýhodnění na děti, III. |  |
| 19 | C | C19 | 2320 |  |
| 19 | D | D19 | 2320 |  |
| 20 | A | A20 | 313, 320 |  |
| 20 | B | B20 | Sazba zálohové, srážkové daně |  |
| 20 | C | C20 | 15 |  |
| 20 | D | D20 | 15 |  |
| 21 | A | A21 | 318 |  |
| 21 | B | B21 | Měsíční sleva na poplatníka |  |
| 21 | C | C21 | 2570 |  |
| 21 | D | D21 | 2570 |  |
| 22 | A | A22 | 317 |  |
| 22 | B | B22 | Výše měsíčního daň. zvýhodnění na děti, násobek za ZTP |  |
| 22 | C | C22 | 2 |  |
| 22 | D | D22 | 2 |  |
| 23 | A | A23 | 313 |  |
| 23 | B | B23 | Sazba zálohové daně (základ daně přesahující 3 násobek průměrné mzdy) |  |
| 23 | C | C23 | 23 |  |
| 23 | D | D23 | 23 |  |
| 24 | A | A24 | 313 |  |
| 24 | B | B24 | Průměrná měsíční mzda  |  |
| 24 | C | C24 | 46557 |  |
| 24 | D | D24 | 48967 |  |

- Počet uvedených buněk (nenulová hodnota a/nebo komentář): **100**

---

## List: temp3
- Rozsah listu dle `dimensions`: `A1:H8`

| Řádek | Sloupec | Buňka | Hodnota | Komentář |
|---:|:---:|:---:|---|---|
| 1 | A | A1 | verze |  |
| 1 | G | G1 | ANO |  |
| 1 | H | H1 | Pozitivní |  |
| 2 | A | A2 | 1.4.0 |  |
| 2 | G | G2 | NE |  |
| 2 | H | H2 | Negativní |  |
| 3 | A | A3 | 1.4.0.1 |  |
| 4 | A | A4 | 1.4.1 |  |
| 5 | A | A5 | 1.4.1.1 |  |
| 6 | A | A6 | 1.4.1.2 |  |
| 7 | A | A7 | draft |  |
| 8 | A | A8 | smazáno |  |

- Počet uvedených buněk (nenulová hodnota a/nebo komentář): **12**

---
