# Datový slovník JMHZ – vertikální struktura buněk (verze 1.4.1.2)
Každý list je uveden samostatně, každá neprázdná buňka je na jednom řádku.

## Titulní strana

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|6|A|A6|Název projektu: Zajištění redesignu agendy zaměstnanosti s ohledem na digitalizaci procesů a snížení administrativní zátěže||
|7|A|A7|Registrační číslo projektu: CZ.31.2.0/0.0/0.0/23_090/0010634||
|9|A|A9|MPSV poskytuje dodavatelům za účelem analýzy dopadů zákona o JMHZ popis datových položek, které budou zaměstnavatelé uvádět v povinných hlášeních podle zákona o JMHZ. Popis je poskytován s výhradou případných změn, protože u zákona o JMHZ ani u nařízení vlády, které bude zákonné povinnosti předávat povinná hlášení konkretizovat, ještě nebyl ukončen legislativní proces a v jeho průběhu nejsou vyloučeny změny vyvolané průběhem zbývající části legislativního procesu. Změny mohou být nutné, pokud dojde k uplatnění pozměňovacích návrhů v Senátu a jejich schválení Poslaneckou sněmovnou. Rovněž nelze vyloučit změny v případě zásadních připomínek uplatněných při projednávání nařízení vlády k JMHZ Legislativní radou vlády ČR.||

## Verze

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Verze souboru||
|1|B|B1|Datum publikace verze||
|2|A|A2|1.4.1||
|2|B|B2|7.11.2025||
|3|A|A3|1.4.1.1||
|3|B|B3|28.11.2025||
|4|A|A4|1.4.1.2||
|4|B|B4|19.1.2026||

## Legenda

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|ZÁLOŽKA||
|1|B|B1|OBLAST SLOUPCŮ||
|1|C|C1|NÁZEV SLOUPCE||
|1|D|D1|POPIS SLOUPCE||
|2|A|A2|SLOVNÍK||
|2|C|C2|ID ATRIBUTU||
|2|D|D2|ID atributu přidělené datovým týmem pro daný atribut. ID je svázáno s atributem napevno, při změnách zůstává stejné. Zaniká až se zánikem atributu.||
|3|B|B3|BUSINESS POPIS||
|3|C|C3|NÁZEV ATRIBUTU||
|3|D|D3|Název atributu, který vzešel ze sběru datové potřeby||
|4|C|C4|OBLAST ATRIBUTU||
|4|D|D4|Neboli také folder - nejvyšší členění atributů do jednotlivých oblastí||
|5|C|C5|TŘÍDA||
|5|D|D5|Nižší členění vzájemně souvisejících atributů do tříd||
|6|C|C6|PODTŘÍDA||
|6|D|D6|Nejnižší členění vzájemně souvisejících atributů do podtříd||
|7|B|B7|TECHNICKÝ POPIS||
|7|C|C7|DATOVÝ TYP||
|7|D|D7|Obecný datový typ vycházející ze sběru datové potřeby||
|8|C|C8|ČETNOST||
|8|D|D8|Četnost atributu. Atributy navrhované jako vícečetné označeny jako 1-N.||
|9|C|C9|ČÍSELNÍK / VÝČET HODNOT||
|9|D|D9|Pokud má atribut datový typ = číselník, pak je zde uveden buď formou odkazu na záložku excelu, kde je detail číselníku, anebo formou výčtu hodnot||
|10|C|C10|PREFILL - TYP||
|10|D|D10|Funkce na předvyplňování položek pro ePortál - zdroj předvyplnění||
|11|C|C11|PREFILL - POZNÁMKA||
|11|D|D11|Funkce na předvyplňování položek pro ePortál - doplnění informací k předvyplnění||
|12|B|B12|SBĚR V RÁMCI TYPU HLÁŠENÍ V JMHZ||
|12|C|C12|REG. ZAMĚSTNAVATELE||
|12|D|D12|Atribut obsažen v rámci hlášení Registrace zaměstnavatele||
|13|C|C13|REG. ZAMĚSTNANCE||
|13|D|D13|Atribut obsažen v rámci hlášení Registrace zaměstnance||
|14|C|C14|MĚSÍČNÍ||
|14|D|D14|Atribut obsažen v rámci měsíčního hlášení. Speciální kódy jako např. x01 apod. symbolizují pořadí měsíců v roce, ve kterých se atribut vyplňuje (např. x010203 = atribut se nabízí k vyplnění v hlášení za leden, únor a březen).||
|15|B|B15|UŽIVATELÉ ATRIBUTU||
|15|C|C15|ČSSZ||
|15|D|D15|Uživatelem (konzumentem) atributu bude ČSSZ||
|16|C|C16|FS||
|16|D|D16|Uživatelem (konzumentem) atributu bude Finanční správa (Generální finanční ředitelství)||
|17|C|C17|MPSV||
|17|D|D17|Uživatelem (konzumentem) atributu bude Ministerstvo práce a sociálních věcí (včetně Úřadu práce)||
|18|C|C18|ČSÚ||
|18|D|D18|Uživatelem (konzumentem) atributu bude Český statistický úřad||
|19|B|B19|POZNÁMKA||
|19|C|C19|POZNÁMKA K ATRIBUTU||
|19|D|D19|Poznámka k významu nebo zpracování atributu||
|20|B|B20|POPIS||
|20|C|C20|VÝZNAMOVÝ POPIS ATRIBUTU||
|20|D|D20|Významový popis atributu - může vycházet z legislativy, z existujících formulářů apod.||
|21|A|A21|CHANGELOG||
|21|B|B21|-||
|21|C|C21|DATUM ZMĚNY||
|21|D|D21|Datum, kdy byla změna zanesena do datového slovníku||
|22|C|C22|VERZE||
|22|D|D22|Verze dokumentace, ke které daná změna přísluší||
|23|C|C23|ZMĚNOVÝ POŽADAVEK||
|23|D|D23|ID změnového požadavku ze seznamu změnových požadavků||
|24|C|C24|ID ATRIBUTU||
|24|D|D24|ID atributu, kterého se změna týká||
|25|C|C25|NÁZEV ATRIBUTU||
|25|D|D25|Název atributu, kterého se změna týká||
|26|C|C26|OBLAST ATRIBUTU||
|26|D|D26|Oblast atributu, kterého se změna týká||
|27|C|C27|TŘÍDA||
|27|D|D27|Třída atributu, kterého se změna týká||
|28|C|C28|PODTŘÍDA||
|28|D|D28|Podtřída atributu, kterého se změna týká||
|29|C|C29|REG. ZAMĚSTNAVATELE||
|29|D|D29|Příslušnost změny k podání Registrace zaměstnavatele||
|30|C|C30|REG. ZAMĚSTNANCE||
|30|D|D30|Příslušnost změny k podání Registrace zaměstnance||
|31|C|C31|MĚSÍČNÍ HLÁŠENÍ||
|31|D|D31|Příslušnost změny k Měsíčnímu hlášení||
|32|C|C32|TYP ZMĚNY||
|32|D|D32|Typ změny - např. přidání / odebrání / přejmenování atributu apod. Může být i změna globálního charakteru (odebrání sloupce apod.)||
|33|C|C33|POPIS ZMĚNY||
|33|D|D33|Doplňující informace ke změně (specifikace, důvod apod.)||
|34|A|A34|CIS <název číselníku>||
|34|C|C34|<všechny sloupce>||
|34|D|D34|Záložky s detailním popisem číselníků||

## SLOVNÍK

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|B|B1|BUSINESS POPIS||
|1|F|F1|TECHNICKÝ POPIS||
|1|P|P1|SBĚR V RÁMCI TYPU HLÁŠENÍ V JMHZ||
|1|S|S1|UŽIVATELÉ ATRIBUTU||
|1|W|W1|POZNÁMKA||
|1|X|X1|POPIS||
|2|A|A2|ID ATRIBUTU||
|2|B|B2|NÁZEV ATRIBUTU||
|2|C|C2|OBLAST ATRIBUTU||
|2|D|D2|TŘÍDA||
|2|E|E2|PODTŘÍDA||
|2|F|F2|DATOVÝ TYP||
|2|G|G2|DATOVÝ TYP - UPŘESNĚNÍ||
|2|H|H2|ČETNOST||
|2|I|I2|XSD MAPOVÁNÍ REGZEC||
|2|J|J2|XSD MAPOVÁNÍ MH - VÝJIMKA PRO FORMULÁŘ ODLOŽENÝ PŘÍJEM V POZNÁMCE|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    Pro formulář Odložený příjem se u všech výskytů elementu “eldpSeznam” před něj přidává nadřazená struktura “eldpObdobi.obdobi.”, tzn. výsledný element bude např. “pojisteni.eldpObdobi.obdobi.eldpSeznam.eldp.kod (ID 10240)”|
|2|K|K2|ISPV MAPOVÁNÍ||
|2|L|L2|ČÍSELNÍK||
|2|M|M2|PREFILL EPORTAL||
|2|N|N2|VÝPOČET - EDITOVATELNOST||
|2|O|O2|VÝPOČET - VZOREC||
|2|P|P2|REG. ZAMĚSTNAVATELE||
|2|Q|Q2|REG. ZAMĚSTNANCE||
|2|R|R2|MĚSÍČNÍ|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    Číslo u znaku x znamená měsíc, ve kterém se atribut vyplňuje. Např. x010203 = atribut se vyplňuje v lednovém, únorovém a březnovém hlášení.|
|2|S|S2|ČSSZ||
|2|T|T2|FS||
|2|U|U2|MPSV||
|2|V|V2|ČSÚ||
|2|W|W2|POZNÁMKA K ATRIBUTU||
|2|X|X2|VÝZNAMOVÝ POPIS ATRIBUTU|admin:\nNeslouží k technické definici atributu, obsahuje pouze významový popis pole na původních formulářích. |
|3|A|A3|10001||
|3|B|B3|GUID podání||
|3|C|C3|Meta atributy||
|3|D|D3|Podání||
|3|F|F3|text||
|3|J|J3|hlavicka.idPodani (ID 10001)||
|3|M|M3|N/A||
|3|R|R3|x||
|3|V|V3|x||
|3|W|W3|Technický atribut, nebude na formuláři, generuje se na straně zaměstnavatele||
|4|A|A4|10470||
|4|B|B4|Kanál podání||
|4|C|C4|Meta atributy||
|4|D|D4|Podání||
|4|F|F4|číselník||
|4|M|M4|N/A||
|4|R|R4|x||
|4|W|W4|Technický atribut, nebude na formuláři, využitelné pro statistiky, případně vracení podání stejným kanálem||
|5|A|A5|10002||
|5|B|B5|Pořadí balíku dat||
|5|C|C5|Meta atributy||
|5|D|D5|Podání||
|5|F|F5|číslo||
|5|G|G5|celé číslo||
|5|J|J5|hlavicka.balikPoradi (ID 10002)||
|5|M|M5|N/A||
|5|R|R5|x||
|5|W|W5|Technický atribut, nebude na formuláři, generuje se na straně zaměstnavatele||
|6|A|A6|10003||
|6|B|B6|Počet balíků dat||
|6|C|C6|Meta atributy||
|6|D|D6|Podání||
|6|F|F6|číslo||
|6|G|G6|celé číslo||
|6|J|J6|hlavicka.balikyPocet (ID 10003)||
|6|M|M6|N/A||
|6|R|R6|x||
|6|W|W6|Technický atribut, nebude na formuláři, generuje se na straně zaměstnavatele||
|7|A|A7|10015||
|7|B|B7|Počet formulářů v balíku dat||
|7|C|C7|Meta atributy||
|7|D|D7|Podání||
|7|F|F7|číslo||
|7|G|G7|celé číslo||
|7|J|J7|formularePocetVBaliku (ID 10015)||
|7|M|M7|N/A||
|7|R|R7|x||
|7|W|W7|Technický atribut, nebude na formuláři, generuje se na straně zaměstnavatele||
|8|A|A8|10488||
|8|B|B8|Počet formulářů celkem||
|8|C|C8|Meta atributy||
|8|D|D8|Podání||
|8|F|F8|číslo||
|8|G|G8|celé číslo||
|8|J|J8|formularePocetCelkem (ID 10488)||
|8|M|M8|N/A||
|8|R|R8|x||
|8|W|W8|Technický atribut, nebude na formuláři, generuje se na straně zaměstnavatele||
|9|A|A9|10004||
|9|B|B9|Pracoviště ÚSSZ (OSSZ/PSSZ/MSSZ Brno)||
|9|C|C9|Meta atributy||
|9|D|D9|Podání||
|9|F|F9|číselník||
|9|I|I9|employees.employee.dep (ID 10004)||
|9|J|J9| ||
|9|L|L9|CIS Okresy||
|9|P|P9|x|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    U přihlášky zaměstnavatele není znám, relevantní pouze pro hlášení REGZEL_DOPL a odhlášku.|
|9|Q|Q9|x||
|9|S|S9|x||
|9|W|W9|V rámci nové legislativy (od 1.1.2025) může být příslušné SSZ až výstupem registrace - tzn. nebylo by na vstupu registrace zaměstnavatele||
|9|X|X9|Trojmístný číselný kód místně příslušné OSSZ, u které je zaměstnavatel veden v registru zaměstnavatelů. Místní příslušnost OSSZ/PSSZ/MSSZ Brno (dále jen OSSZ) se řídí sídlem zaměstnavatele, pokud nemá mzdovou účtárnu nebo pokud místo mzdové účtárny je shodné se sídlem zaměstnavatele; nebo místem mzdové účtárny, pokud zaměstnavatel má mzdovou účtárnu a místo mzdové účtárny není shodné se sídlem zaměstnavatele. V případě zaměstnavatele - fyzické osoby se za sídlo považuje místo jejího trvalého pobytu v ČR, jde-li o cizince místo hlášeného pobytu v ČR. Nemá-li fyzická osoba – zaměstnavatel v ČR trvalý ani hlášený pobyt řídí se místní příslušnost OSSZ místem podnikání (popř. místo výkonu práce jeho zaměstnanců) v ČR. Je-li zahraniční právnická osoba zaměstnavatelem, který nemá na území ČR sídlo útvaru, který vede evidenci mezd, byla určena jako místně příslušná PSSZ, Praha 8, Trojská 1997.||
|10|A|A10|10411||
|10|B|B10|Finančnímu úřadu pro / Specializovanému finančnímu úřadu||
|10|C|C10|Meta atributy||
|10|D|D10|Podání||
|10|F|F10|číselník||
|10|L|L10|CIS GFŘ pracoviště||
|10|P|P10|x||
|10|T|T10|x||
|10|X|X10|Čtyřmístný číselný kód místně příslušného FÚ/SFÚ, u které je zaměstnavatel veden.||
|11|A|A11|10412||
|11|B|B11|Územní pracoviště v, ve, pro  ||
|11|C|C11|Meta atributy||
|11|D|D11|Podání||
|11|F|F11|číselník||
|11|L|L11|CIS GFŘ pracoviště||
|11|P|P11|x||
|11|T|T11|x||
|11|X|X11|Čtyřmístný číselný kód místně příslušného územního pracoviště FÚ, u kterého je zaměstnavatel veden. Specializovaný finanční úřad nemá územní pracoviště.||
|12|A|A12|10005||
|12|B|B12|Datum a čas vyplnění podání||
|12|C|C12|Meta atributy||
|12|D|D12|Podání||
|12|F|F12|datumčas||
|12|I|I12|employees.employee.dat (ID 10005)||
|12|J|J12|hlavicka.datumVyplneni (ID 10005)||
|12|M|M12|ne - read only pole||
|12|P|P12|x||
|12|Q|Q12|x||
|12|R|R12|x||
|12|S|S12|x||
|12|T|T12|x||
|12|U|U12|x||
|12|V|V12|x||
|13|A|A13|10006||
|13|B|B13|Datum a čas přijetí podání||
|13|C|C13|Meta atributy||
|13|D|D13|Podání||
|13|F|F13|datumčas||
|13|M|M13|N/A||
|13|R|R13|x||
|13|S|S13|x||
|13|T|T13|x||
|13|U|U13|x||
|13|V|V13|x||
|13|W|W13|Technický atribut, nebude na formuláři, generuje se v okamžiku přijetí formuláře||
|14|A|A14|10007||
|14|B|B14|Typ podání||
|14|C|C14|Meta atributy||
|14|D|D14|Podání||
|14|F|F14|číselník||
|14|J|J14|hlavicka.typPodani (ID 10007)||
|14|L|L14|CIS Typ podání||
|14|M|M14|N/A||
|14|R|R14|x||
|14|S|S14|x||
|14|T|T14|x||
|14|U|U14|x||
|14|V|V14|x||
|15|A|A15|10008||
|15|B|B15|Typ akce||
|15|C|C15|Meta atributy||
|15|D|D15|Formulář||
|15|F|F15|číselník||
|15|I|I15|employees.employee.act (ID 10008)||
|15|J|J15| ||
|15|L|L15|CIS Typ akce||
|15|Q|Q15|x||
|15|S|S15|x||
|15|T|T15|x||
|15|U|U15|x||
|15|V|V15|x||
|16|A|A16|10009||
|16|B|B16|Platnost akce ke dni||
|16|C|C16|Meta atributy||
|16|D|D16|Formulář||
|16|F|F16|datum||
|16|I|I16|employees.employee.fro (ID 10009)||
|16|J|J16| ||
|16|Q|Q16|x||
|16|S|S16|x||
|16|T|T16|x||
|16|U|U16|x||
|16|V|V16|x||
|17|A|A17|10010||
|17|B|B17|Měsíc||
|17|C|C17|Meta atributy||
|17|D|D17|Podání||
|17|F|F17|číslo||
|17|G|G17|celé číslo||
|17|J|J17|hlavicka.mesic (ID 10010)||
|17|M|M17|N/A||
|17|R|R17|x||
|17|S|S17|x||
|17|T|T17|x||
|17|U|U17|x||
|17|V|V17|x||
|18|A|A18|10011||
|18|B|B18|Rok||
|18|C|C18|Meta atributy||
|18|D|D18|Podání||
|18|F|F18|číslo||
|18|G|G18|celé číslo||
|18|J|J18|hlavicka.rok (ID 10011)||
|18|M|M18|N/A||
|18|R|R18|x||
|18|S|S18|x||
|18|T|T18|x||
|18|U|U18|x||
|18|V|V18|x||
|19|A|A19|10012||
|19|B|B19|GUID formuláře||
|19|C|C19|Meta atributy||
|19|D|D19|Formulář||
|19|F|F19|text||
|19|J|J19|hlavicka.idFormulare (ID 10012)||
|19|M|M19|N/A||
|19|R|R19|x||
|19|W|W19|Technický atribut, nebude na formuláři, bez vazby na GUID podání, generuje se na straně zaměstnavatele||
|20|A|A20|10016||
|20|B|B20|Typ formuláře||
|20|C|C20|Meta atributy||
|20|D|D20|Formulář||
|20|F|F20|číselník||
|20|J|J20|hlavicka.typFormulare (ID 10016)||
|20|L|L20|CIS Typ formuláře||
|20|M|M20|N/A||
|20|R|R20|x||
|20|S|S20|x||
|20|T|T20|x||
|20|U|U20|x||
|20|V|V20|x||
|21|A|A21|10017||
|21|B|B21|Stav formuláře||
|21|C|C21|Meta atributy||
|21|D|D21|Formulář||
|21|F|F21|číselník||
|21|L|L21|CIS Stav formuláře||
|21|M|M21|N/A||
|21|R|R21|x||
|21|W|W21|Technický atribut, nebude na formuláři, zapíše DIS na základě zpracování formuláře||
|22|A|A22|10018||
|22|B|B22|Důvod odmítnutí||
|22|C|C22|Meta atributy||
|22|D|D22|Formulář||
|22|F|F22|číselník||
|22|L|L22|CIS Důvod odmítnutí||
|22|M|M22|N/A||
|22|R|R22|x||
|22|W|W22|Technický atribut, nebude na formuláři, zapíše DIS na základě zpracování formuláře||
|23|A|A23|10019||
|23|B|B23|Datum a čas zpracování formuláře||
|23|C|C23|Meta atributy||
|23|D|D23|Formulář||
|23|F|F23|datumčas||
|23|M|M23|N/A||
|23|R|R23|x||
|23|W|W23|Technický atribut, nebude na formuláři, zapíše DIS na základě zpracování formuláře||
|24|A|A24|10020||
|24|B|B24|Datum a čas zapsání osobního identifikačního čísla||
|24|C|C24|Meta atributy||
|24|D|D24|Formulář||
|24|F|F24|datumčas||
|24|M|M24|N/A||
|24|R|R24|x||
|24|W|W24|Technický atribut, nebude na formuláři, zapíše se na základě ztotožnění v KE||
|25|A|A25|10495||
|25|B|B25|Primární pracovněprávní vztah zaměstnance||
|25|C|C25|Meta atributy||
|25|D|D25|Formulář||
|25|F|F25|příznak||
|25|J|J25|hlavicka.primarniPpv (ID 10495)||
|25|M|M25|předchozí období||
|25|R|R25|x||
|25|T|T25|x||
|25|U|U25|x||
|25|V|V25|x||
|25|W|W25|Příznak označující pracovněprávní vztah, který bude nosičem souhrnných dat zaměstnance.||
|26|A|A26|10548||
|26|B|B26|Typ Odloženého příjmu||
|26|C|C26|Meta atributy||
|26|D|D26|Formulář||
|26|F|F26|číselník||
|26|J|J26|typ (ID 10548)||
|26|L|L26|CIS Typ Odloženého příjmu||
|26|M|M26|ne - specifické||
|26|R|R26|x||
|26|S|S26|x||
|26|T|T26|x||
|26|X|X26|Výběr situace, pro kterou je Odložený příjem hlášen||
|27|A|A27|10023||
|27|B|B27|Úhrn vyměřovacích základů zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|27|C|C27|Přehled o výši pojistného||
|27|D|D27|Odváděné pojistné||
|27|F|F27|číslo||
|27|G|G27|celé číslo||
|27|J|J27|pojistne.zakladZamestnavateleA (ID 10023)||
|27|K|K27| ||
|27|M|M27|předchozí období||
|27|N|N27|A||
|27|O|O27|= ∑ (n) atribut „10478"||
|27|P|P27| ||
|27|R|R27|x||
|27|S|S27|x||
|27|V|V27|x||
|27|X|X27|Vyměřovací základ zaměstnavatele podle § 5a odst. 1 písm. a)||
|28|A|A28|10024||
|28|B|B28|Pojistné za zaměstnavatele u zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|28|C|C28|Přehled o výši pojistného||
|28|D|D28|Odváděné pojistné||
|28|F|F28|číslo||
|28|G|G28|celé číslo||
|28|J|J28|pojistne.pojistneZamestnavateleA (ID 10024)||
|28|K|K28| ||
|28|M|M28|předchozí období||
|28|N|N28|N||
|28|O|O28|= 0,248 * "10023", = kontrola MH.8||
|28|P|P28| ||
|28|R|R28|x||
|28|S|S28|x||
|28|V|V28|x||
|28|X|X28|Pojistné za zaměstnavatele (zaokrouhlené na celé koruny směrem nahoru) ve výši 24,8 % z úhrnu vyměřovacích základů (10023).||
|29|A|A29|10025||
|29|B|B29|Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku||
|29|C|C29|Přehled o výši pojistného||
|29|D|D29|Odváděné pojistné||
|29|F|F29|číslo||
|29|G|G29|celé číslo||
|29|J|J29|pojistne.zakladZamestnavateleB (ID 10025)||
|29|K|K29| ||
|29|M|M29|předchozí období||
|29|N|N29|A||
|29|O|O29|= ∑ (n) atribut „10479"||
|29|P|P29| ||
|29|R|R29|x||
|29|S|S29|x||
|29|V|V29|x||
|29|X|X29|Vyměřovací základ zaměstnavatele podle § 5a odst. 1 písm. b)||
|30|A|A30|10026||
|30|B|B30|Pojistné za zaměstnavatele u zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku||
|30|C|C30|Přehled o výši pojistného||
|30|D|D30|Odváděné pojistné||
|30|F|F30|číslo||
|30|G|G30|celé číslo||
|30|J|J30|pojistne.pojistneZamestnavateleB (ID 10026)||
|30|K|K30| ||
|30|M|M30|předchozí období||
|30|N|N30|N||
|30|O|O30|= 0,298 * "10025", = kontrola MH.10||
|30|P|P30| ||
|30|R|R30|x||
|30|S|S30|x||
|30|V|V30|x||
|30|X|X30|Pojistné za zaměstnavatele (zaokrouhlené na celé koruny směrem nahoru), a to za kalendářní měsíce roku 2025 ve výši 28,8 % a počínaje rokem 2026 ve výši 29,8 % z úhrnu vyměřovacích základů (10025).||
|31|A|A31|10483||
|31|B|B31|Úhrn vyměřovacích základů zaměstnanců, kteří vykonávají rizikové zaměstnání||
|31|C|C31|Přehled o výši pojistného||
|31|D|D31|Odváděné pojistné||
|31|F|F31|číslo||
|31|G|G31|celé číslo||
|31|J|J31|pojistne.zakladZamestnavateleC (ID 10483)||
|31|K|K31| ||
|31|M|M31|předchozí období||
|31|N|N31|A||
|31|O|O31|= ∑ (n) atribut „10480"||
|31|P|P31| ||
|31|Q|Q31| ||
|31|R|R31|x||
|31|S|S31|x||
|31|V|V31|x||
|31|X|X31|Vyměřovací základ zaměstnavatele podle § 5a odst. 1 písm. c)||
|32|A|A32|10484||
|32|B|B32|Pojistné za zaměstnavatele u zaměstnanců, kteří vykonávají rizikové zaměstnání||
|32|C|C32|Přehled o výši pojistného||
|32|D|D32|Odváděné pojistné||
|32|F|F32|číslo||
|32|G|G32|celé číslo||
|32|J|J32|pojistne.pojistneZamestnavateleC (ID 10484)||
|32|K|K32| ||
|32|M|M32|předchozí období||
|32|N|N32|N||
|32|O|O32|= 0,268 * "10483", = kontrola MH.167||
|32|P|P32| ||
|32|R|R32|x||
|32|S|S32|x||
|32|V|V32|x||
|32|X|X32|Pojistné za zaměstnavatele (zaokrouhlené na celé koruny směrem nahoru), a to za kalendářní měsíce roku 2025 ve výši 26,8 %, roku 2026 ve výši 27,8 %, roku 2027 ve výši 28,8 % a počínaje rokem 2028 ve výši 29,8 % z úhrnu vyměřovacích základů (10483).||
|33|A|A33|10027||
|33|B|B33|Pojistné za zaměstnavatele celkem (součet úhrnů)||
|33|C|C33|Přehled o výši pojistného||
|33|D|D33|Odváděné pojistné||
|33|F|F33|číslo||
|33|G|G33|celé číslo||
|33|J|J33|pojistne.pojistneZamestnavateleCelkem (ID 10027)||
|33|K|K33| ||
|33|M|M33|předchozí období||
|33|N|N33|N||
|33|O|O33|= "10024" + "10026" + "10484", = kontrola MH.11||
|33|P|P33| ||
|33|R|R33|x||
|33|S|S33|x||
|33|V|V33|x||
|33|X|X33|Pojistné za zaměstnavatele celkem, tj. součet dílčích částek pojistného uvedených v atributech 10024, 10026 a 10484||
|34|A|A34|10028||
|34|B|B34|Pojistné za zaměstnance||
|34|C|C34|Přehled o výši pojistného||
|34|D|D34|Odváděné pojistné||
|34|F|F34|číslo||
|34|G|G34|celé číslo||
|34|J|J34|pojistne.pojistneZamestnance (ID 10028)||
|34|K|K34| ||
|34|M|M34|předchozí období||
|34|N|N34|A||
|34|O|O34|= ∑ (n), úhrn pojistného všech zaměstnanců ("10370"), = kontrola MH.12||
|34|P|P34| ||
|34|R|R34|x||
|34|S|S34|x||
|34|V|V34|x||
|34|X|X34|Úhrn pojistného za všechny zaměstnance. Pojistné za zaměstnance činí 7,1 % z vyměřovacího základu zaměstnance a zaokrouhluje se v každém jednotlivém případě na celé koruny směrem nahoru||
|35|A|A35|10029||
|35|B|B35|Pojistné celkem||
|35|C|C35|Přehled o výši pojistného||
|35|D|D35|Odváděné pojistné||
|35|F|F35|číslo||
|35|G|G35|celé číslo||
|35|J|J35|pojistne.pojistneCelkem (ID 10029)||
|35|K|K35| ||
|35|M|M35|předchozí období||
|35|N|N35|N||
|35|O|O35|="10027" + "10028", = kontrola MH.13||
|35|P|P35| ||
|35|R|R35|x||
|35|S|S35|x||
|35|V|V35|x||
|35|X|X35|Součet pojistného za zaměstnavatele (10027) a pojistného za zaměstnance (10028).||
|36|A|A36|10030||
|36|B|B36|Počet zaměstnanců||
|36|C|C36|Přehled o výši pojistného||
|36|D|D36|Slevy na pojistném zaměstnavatele||
|36|F|F36|číslo||
|36|G|G36|celé číslo||
|36|J|J36|slevaZamestnavatele.pocetZamestnancu (ID 10030)||
|36|K|K36| ||
|36|M|M36|předchozí období||
|36|N|N36|A||
|36|O|O36|= ∑ (n), zaměstnanci uplatňující slevu ("10372"), = kontrola MH.1||
|36|P|P36| ||
|36|R|R36|x||
|36|S|S36|x||
|36|V|V36|x||
|36|X|X36|Počet zaměstnanců, za které zaměstnavatel uplatňuje slevu na pojistném v souladu s § 7a a násl. zákona č. 589/1992 Sb.||
|37|A|A37|10031||
|37|B|B37|Úhrn vyměřovacích základů zaměstnanců||
|37|C|C37|Přehled o výši pojistného||
|37|D|D37|Slevy na pojistném zaměstnavatele||
|37|F|F37|číslo||
|37|G|G37|celé číslo||
|37|J|J37|slevaZamestnavatele.uhrnVymerovacichZakladu (ID 10031)||
|37|K|K37| ||
|37|M|M37|předchozí období||
|37|N|N37|A||
|37|O|O37|= ∑ (n), vymeřovacích základů zaměstnanců ("10245", kteří uplatňují slevu ("10372"), = kontrola MH.2||
|37|P|P37| ||
|37|R|R37|x||
|37|S|S37|x||
|37|V|V37|x||
|37|X|X37|Úhrn vyměřovacích základů těchto zaměstnanců (zahrnutých do počtu 10030), a to ze zaměstnání v pracovním (služebním) poměru, z nichž zaměstnavatel slevu na pojistném uplatňuje (vykonává-li zaměstnanec u zaměstnavatele více takových zaměstnání, náleží sleva na pojistném jen z jednoho zaměstnání).||
|38|A|A38|10032||
|38|B|B38|Sleva na pojistném zaměstnavatele||
|38|C|C38|Přehled o výši pojistného||
|38|D|D38|Slevy na pojistném zaměstnavatele||
|38|F|F38|číslo||
|38|G|G38|celé číslo||
|38|J|J38|slevaZamestnavatele.pojistneSleva (ID 10032)||
|38|K|K38| ||
|38|M|M38|předchozí období||
|38|N|N38|N||
|38|O|O38|= ROUNDUP(0,05*"10031"), = kontrola MH.3||
|38|P|P38| ||
|38|R|R38|x||
|38|S|S38|x||
|38|V|V38|x||
|38|X|X38|Sleva na pojistném zaměstnavatele, která činí 5 % z úhrnu vyměřovacích základů zaměstnanců (10031)||
|39|A|A39|10485||
|39|B|B39|Počet zaměstnanců||
|39|C|C39|Přehled o výši pojistného||
|39|D|D39|Slevy na pojistném zaměstnanců||
|39|E|E39|Pracující důchodci||
|39|F|F39|číslo||
|39|G|G39|celé číslo||
|39|J|J39|slevyZamestnancu.pocetZamestnancu (ID 10485)||
|39|K|K39| ||
|39|M|M39|předchozí období||
|39|N|N39|A||
|39|O|O39|= ∑ (n), zaměstnanci uplatňující slevu ("10490")||
|39|P|P39| ||
|39|R|R39|x||
|39|S|S39|x||
|39|V|V39|x||
|39|X|X39|Počet zaměstnanců, kteří mají v kalendářním měsíci nárok na slevu na pojistném podle § 7d a násl. zákona č. 589/1992 Sb.; započtou se pouze zaměstnanci, kteří mají povinnost v příslušném měsíci platit pojistné, a jejichž sleva je tedy nenulová; zaměstnanec, který má u zaměstnavatele více pojistných vztahů, bude započten pouze jednou.||
|40|A|A40|10486||
|40|B|B40|Úhrn vyměřovacích základů zaměstnanců||
|40|C|C40|Přehled o výši pojistného||
|40|D|D40|Slevy na pojistném zaměstnanců||
|40|E|E40|Pracující důchodci||
|40|F|F40|číslo||
|40|G|G40|celé číslo||
|40|J|J40|slevyZamestnancu.uhrnVymerovacichZakladu (ID 10486)||
|40|K|K40| ||
|40|M|M40|předchozí období||
|40|N|N40|A||
|40|O|O40|= ∑ (n), vymeřovacích základů zaměstnanců ("10477"), kteří uplatňují slevu ("10490")||
|40|P|P40| ||
|40|R|R40|x||
|40|S|S40|x||
|40|V|V40|x||
|40|X|X40|Úhrn vyměřovacích základů těchto zaměstnanců (zahrnutých do počtu 10485)||
|41|A|A41|10487||
|41|B|B41|Úhrn slev na pojistném zaměstnanců||
|41|C|C41|Přehled o výši pojistného||
|41|D|D41|Slevy na pojistném zaměstnanců||
|41|E|E41|Pracující důchodci||
|41|F|F41|číslo||
|41|G|G41|celé číslo||
|41|J|J41|slevyZamestnancu.pojistneSleva (ID 10487)||
|41|K|K41| ||
|41|M|M41|předchozí období||
|41|N|N41|A||
|41|O|O41|= ∑ (n), slev na pojistném zaměstnanců ("10491"), kteří uplatňují slevu ("10490")||
|41|P|P41| ||
|41|R|R41|x||
|41|S|S41|x||
|41|V|V41|x||
|41|X|X41|Úhrn slev na pojistném těchto zaměstnanců||
|42|A|A42|10543||
|42|B|B42|Počet zaměstnanců||
|42|C|C42|Přehled o výši pojistného||
|42|D|D42|Slevy na pojistném zaměstnanců||
|42|E|E42|Ovocnářství a pěstování zeleniny||
|42|F|F42|číslo||
|42|G|G42|celé číslo||
|42|J|J42|slevyZamestnancuOvoZel.pocetZamestnancu (ID 10543)||
|42|K|K42| ||
|42|M|M42|předchozí období||
|42|N|N42|A||
|42|O|O42|= ∑ (n), zaměstnanci uplatňující slevu ("10546")||
|42|P|P42| ||
|42|R|R42|x||
|42|S|S42|x||
|42|V|V42|x||
|42|X|X42|Počet zaměstnanců, kteří mají v kalendářním měsíci nárok na slevu na pojistném zaměstnance v ovocnářství a při pěstování zeleniny. Započtou se pouze zaměstnanci, kteří by jinak měli povinnost v příslušném měsíci platit pojistné a jejichž sleva je tedy nenulová. Zaměstnanec, který má u zaměstnavatele více DPP, z nichž má nárok na slevu, bude započten pouze jednou. Atribut může nabývat pouze celých nezáporných čísel.||
|43|A|A43|10544||
|43|B|B43|Úhrn vyměřovacích základů zaměstnanců||
|43|C|C43|Přehled o výši pojistného||
|43|D|D43|Slevy na pojistném zaměstnanců||
|43|E|E43|Ovocnářství a pěstování zeleniny||
|43|F|F43|číslo||
|43|G|G43|celé číslo||
|43|J|J43|slevyZamestnancuOvoZel.uhrnVymerovacichZakladu (ID 10544)||
|43|K|K43| ||
|43|M|M43|předchozí období||
|43|N|N43|A||
|43|O|O43|= ∑ (n), vymeřovacích základů zaměstnanců ("10477"), kteří uplatňují slevu ("10546")||
|43|P|P43| ||
|43|R|R43|x||
|43|S|S43|x||
|43|V|V43|x||
|43|X|X43|Úhrn vyměřovacích základů zaměstnanců, kteří mají v kalendářním měsíci nárok na slevu na pojistném zaměstnance v ovocnářství a při pěstování zeleniny. Atribut může nabývat pouze celých nezáporných čísel. Vykázaná hodnota bude součtem atributu 10477 dotčených zaměstnanců.||
|44|A|A44|10545||
|44|B|B44|Úhrn slev na pojistném zaměstnanců||
|44|C|C44|Přehled o výši pojistného||
|44|D|D44|Slevy na pojistném zaměstnanců||
|44|E|E44|Ovocnářství a pěstování zeleniny||
|44|F|F44|číslo||
|44|G|G44|celé číslo||
|44|J|J44|slevyZamestnancuOvoZel.pojistneSleva (ID 10545)||
|44|K|K44| ||
|44|M|M44|předchozí období||
|44|N|N44|A||
|44|O|O44|= ∑ (n), slev na pojistném zaměstnanců ("10547"), kteří uplatňují slevu ("10546")||
|44|P|P44| ||
|44|R|R44|x||
|44|S|S44|x||
|44|V|V44|x||
|44|X|X44|Úhrn slev na pojistném zaměstnanců, kteří mají v kalendářním měsíci nárok na slevu na pojistném zaměstnance v ovocnářství a při pěstování zeleniny. Atribut může nabývat pouze celých nezáporných čísel. Vykázaná hodnota bude součtem nového atributu v individualizované části XX sleva na pojistném zaměstnance v ovocnářství a při pěstování zeleniny. Hodnota údaje je dána výrazem v absolutní hodnotě: \|1 – (7,1 % úhrnu vyměřovacích základů zaměstnanců / úhrn slev na pojistném zaměstnanců)\| <= 0,01 nebo \|7,1 % úhrnu vyměřovacích základů zaměstnanců – úhrn slev na pojistném zaměstnanců\| <= 100; tzn. akceptovány budou hodnoty, kdy úhrn slev na pojistném zaměstnanců je větší než 7,171 % úhrnu vyměřovacích základů zaměstnanců, ale rozdíl částek je <= 100 (obě podmínky musejí být porušeny současně, aby nebyl údaj akceptován). Zároveň vždy platí, že úhrn slev na pojistném zaměstnanců ≥ 7,1 % úhrnu vyměřovacích základů zaměstnanců (zaokrouhleno na celé koruny směrem nahoru).||
|45|A|A45|10033||
|45|B|B45|Vypočítané pojistné (rozdíl mezi pojistným celkem a slevou na pojistném)||
|45|C|C45|Přehled o výši pojistného||
|45|D|D45|Pojistné k úhradě||
|45|F|F45|číslo||
|45|G|G45|celé číslo||
|45|J|J45|pojistneUhrada (ID 10033)||
|45|M|M45|předchozí období||
|45|N|N45|N||
|45|O|O45|= "10029" - "10032" - "10487" - "10545", = kontrola MH.4||
|45|P|P45| ||
|45|R|R45|x||
|45|S|S45|x||
|45|V|V45|x||
|45|X|X45|Rozdíl mezi celkovým pojistným (10029) a slevou na pojistném zaměstnavatele (10032) a úhrnem slev na pojistném zaměstnanců (10487). Tuto částku je zaměstnavatel povinen odvést na příslušný účet příslušné správy sociálního zabezpečení.||
|46|A|A46|10034||
|46|B|B46|Úhrn skutečně sražených záloh na dani po slevách||
|46|C|C46|Souhrnná vrstva||
|46|D|D46|Daňové údaje||
|46|F|F46|číslo||
|46|G|G46|celé číslo||
|46|J|J46|danUdajeMesic.danZalohaPoSleve (ID 10034)||
|46|K|K46| ||
|46|M|M46|předchozí období||
|46|N|N46|A||
|46|O|O46|= ∑ Skutečně sražená záloha na daň po uplatnění slev ("10305") na všech PPV zaměstnavatele ||
|46|P|P46| ||
|46|R|R46|x||
|46|T|T46|x||
|46|V|V46|x||
|46|X|X46|Úhrn záloh na daň po měsíčních slevách na dani, které byly za příslušný kalendářní měsíc sraženy.||
|47|A|A47|10035||
|47|B|B47|Úhrn vyplacených měsíčních daňových bonusů||
|47|C|C47|Souhrnná vrstva||
|47|D|D47|Daňové údaje||
|47|F|F47|číslo||
|47|G|G47|celé číslo||
|47|J|J47|danUdajeMesic.danBonus (ID 10035)||
|47|K|K47| ||
|47|M|M47|předchozí období||
|47|R|R47|x||
|47|T|T47|x||
|47|V|V47|x||
|47|X|X47|Úhrn částek měsíčních daňových bonusů vyplacených podle § 35d odst. 4 zákona za příslušný kalendářní měsíc.||
|48|A|A48|10036||
|48|B|B48|Úhrn přeplatků na dani a nedoplatků daně z ročního zúčtování||
|48|C|C48|Souhrnná vrstva||
|48|D|D48|Daňové údaje||
|48|F|F48|číslo||
|48|G|G48|celé číslo (může být záporné)||
|48|J|J48|danUdajeRok.danPreplatek (ID 10036)||
|48|K|K48| ||
|48|M|M48|ne - jiná periodicita||
|48|R|R48|x010203||
|48|T|T48|x||
|48|V|V48|x||
|48|X|X48|Přeplatek z ročního zúčtování záloh na daň za příslušné zdaňovací období.||
|49|A|A49|10037||
|49|B|B49|Úhrn doplatků na daňových bonusech vyplacených zaměstnancům a vrácených přeplatků daňových bonusů  zaměstnanci z ročního zúčtování||
|49|C|C49|Souhrnná vrstva||
|49|D|D49|Daňové údaje||
|49|F|F49|číslo||
|49|G|G49|celé číslo (může být záporné)||
|49|J|J49|danUdajeRok.danBonusDoplatek (ID 10037)||
|49|K|K49| ||
|49|M|M49|ne - jiná periodicita||
|49|R|R49|x010203||
|49|T|T49|x||
|49|V|V49|x||
|49|X|X49|Doplatky na daňovém bonusu z ročního zúčtování daňového zvýhodnění za příslušné zdaňovací období, vyplacených podle § 35d odst. 8 zákona při zúčtování mzdy za příslušný kalendářní měsíc.||
|50|A|A50|10452||
|50|B|B50|Podíl osob se zdravotním postižením na celkovém počtu zaměstnanců||
|50|C|C50|Souhrnná vrstva||
|50|D|D50|Plnění povinného podílu zaměstnávání OZP||
|50|F|F50|číslo||
|50|G|G50|desetinné číslo (2)||
|50|J|J50|zamestnavatelUdajeRok.zamestnavaniOzp.podilZamZtp (ID 10452)||
|50|K|K50| ||
|50|M|M50|ne - jiná periodicita||
|50|R|R50|x12||
|50|U|U50|x||
|50|V|V50|x||
|50|X|X50|Zaměstnavatel s více než 25 zaměstnanci v pracovním poměru má povinnost zaměstnávat OZP ve výši povinného podílu těchto osob na celkovém počtu zaměstnanců zaměstnavatele. Pro povinného podílu je rozhodný průměrný roční přepočtený počet zaměstnanců. Způsob výpočtu průměrného přepočteného počtu zaměstnanců stanoví ministerstvo prováděcím právním předpisem (vyhláška č. 518/2004 Sb.) Výpočet podílu se zjišťuje na dvě platná desetinná místa.\n(U zaměstnavatelů, kteří jsou agenturou práce, se do celkového počtu zaměstnanců v pracovním poměru nezapočítají zaměstnanci, kteří jsou dočasně přidělení k výkonu práce k uživateli.)||
|51|A|A51|10038||
|51|B|B51|Průměrný roční přepočtený počet zaměstnanců||
|51|C|C51|Souhrnná vrstva||
|51|D|D51|Plnění povinného podílu zaměstnávání OZP||
|51|F|F51|číslo||
|51|G|G51|desetinné číslo (2)||
|51|J|J51|zamestnavatelUdajeRok.zamestnavaniOzp.zecPocetPrepRok (ID 10038)||
|51|K|K51| ||
|51|M|M51|ne - jiná periodicita||
|51|R|R51|x12||
|51|T|T51|x||
|51|U|U51|x||
|51|V|V51|x||
|51|W|W51|na 2 desetinná místa||
|51|X|X51|Do počtu odpracovaných hodin se započítávají všechny skutečně odpracované hodiny (tzn. i hodiny odpracované přesčas) zaměstnanci v pracovním poměru, včetně zaměstnanců pracujících na místech obsazovaných volbou nebo jmenováním.\nDo počtu odpracovaných hodin se nezapočítávají hodiny:\n       odpracované zaměstnanci, na jejichž zaměstnávání se povinnost uvedená v § 81 zákona o zaměstnanosti nevztahuje (§ 147 zákona o zaměstnanosti – příslušníci a vojáci z povolání ve služebním poměru, zaměstnanci obce zařazení do obecní policie, občanští zaměstnanci ozbrojených sil České republiky, báňští inspektoři a členové výjezdových skupin zdravotnické záchranné služby),\n       odpracované na základě dohod o pracích konaných mimo pracovní poměr.\nPočet odpracovaných hodin se zvyšuje o neodpracované hodiny:\n       v důsledku čerpání dovolené na zotavenou,\n       v důsledku dočasné pracovní neschopnosti, za kterou je poskytováno nemocenské,\n       z důvodu překážek v práci na straně zaměstnavatele,\n       z důvodu překážek v práci na straně zaměstnance, pokud se jedná o překážky, při kterých má zaměstnanec nárok na náhradu mzdy nebo platu,\n       v důsledku ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné.\nDo počtu neodpracovaných hodin, o které se zvyšují odpracované hodiny, se započítávají pouze hodiny, které by zaměstnanec odpracoval v rámci rozvržení své pracovní doby.\nDo počtu neodpracovaných hodin, o které se zvyšují odpracované hodiny, se nezapočítávají:\n       doby pracovní neschopnosti, za které nejsou poskytovány dávky nemocenského pojištění,\n       doby, za které jsou poskytovány dávky nemocenského pojištění, ale které nejsou pracovní neschopností (mateřská dovolená).\nCelkovou stanovenou týdenní pracovní dobou bez svátků se rozumí fond pracovní doby bez svátků, stanovený u zaměstnavatele nebo vyplývající z obecně závazných právních předpisů.\nJestliže zaměstnavatel zaměstnává zaměstnance v různých pracovních režimech (např. jednosměnný a směnný provoz), zjišťuje se průměrný roční přepočtený počet zaměstnanců v každém pracovním režimu samostatně a součet průměrných přepočtených počtů z jednotlivých pracovních režimů, který se provádí na dvě platná desetinná místa, tvoří celkový roční přepočtený počet zaměstnanců zaměstnavatele.\nK individuálním úpravám pracovní doby se nepřihlíží, použije se při nich celkový roční fond pracovní doby, odpovídající fondu pracovní doby zaměstnance pracujícího po stanovenou týdenní pracovní dobu v příslušném pracovním režimu. Při nerovnoměrném rozvržení pracovní doby a u domáckých zaměstnanců se vychází z nominálního fondu pracovní doby.\nVysvětlení: Jedná se např. o tzv. krátké a dlouhé týdny. Pokud není stanovená týdenní pracovní doba uvedena v pracovní smlouvě, zaměstnavatel je dle § 31 zákoníku práce povinen seznámit fyzickou osobu s pracovními podmínkami a zároveň je dle § 37 zákoníku práce povinen informovat zaměstnance o obsahu pracovního poměru, kdy sděluje údaj o týdenní pracovní době a jejím rozvržení.\nV případě zkrácení stanovené týdenní pracovní doby kolektivní smlouvou nebo vnitřním předpisem (bez snižování mzdy) zaměstnavatel zjišťuje fond pracovní doby dle počtu pracovních dnů v kalendářním roce. Kolektivní smlouvu nebo vnitřní předpis doloží při kontrole. Zkrácení stanovené týdenní pracovní doby nemůže být uplatněno organizační složkou státu.\nProvozuje-li zaměstnavatel svou činnost pouze po část kalendářního roku, součet odpracovaných a neodpracovaných hodin se dělí pouze poměrnou částí celkového ročního fondu pracovní doby připadající na ty měsíce, ve kterých byla činnost vykonávána. Došlo – li k zahájení nebo ukončení činnosti v průběhu kalendářního měsíce, započítává se tento měsíc do poměrné části celkového ročního fondu pracovní doby jako celý.\nPočátkem provozování činnosti zaměstnavatele se rozumí přijetí prvního zaměstnance do pracovního poměru.\nVýpočet průměrných přepočtených počtů zaměstnanců se zjišťuje na dvě platná desetinná místa.\nPříklad:\na)    1,353 →1,35\nb)    1,357→1,35||
|52|A|A52|10039||
|52|B|B52|Průměrný roční přepočtený počet zaměstnanců, kteří jsou OZP||
|52|C|C52|Souhrnná vrstva||
|52|D|D52|Plnění povinného podílu zaměstnávání OZP||
|52|F|F52|číslo||
|52|G|G52|desetinné číslo (2)||
|52|J|J52|zamestnavatelUdajeRok.zamestnavaniOzp.zecPocetPrepOzpRok (ID 10039)||
|52|K|K52| ||
|52|M|M52|ne - jiná periodicita||
|52|R|R52|x12||
|52|T|T52|x||
|52|U|U52|x||
|52|V|V52|x||
|52|W|W52|na 2 desetinná místa||
|52|X|X52|Průměrný roční přepočtený počet zaměstnanců, kteří jsou OZP, se zjišťuje stejným způsobem jako celkový průměrný roční přepočtený počet zaměstnanců. Každého zaměstnance, který je osobou s těžším zdravotním postižením, si zaměstnavatel pro tento účel započítává třikrát.\nTrojnásobek průměrného ročního přepočteného počtu zaměstnanců, kteří jsou osobami s těžším zdravotním postižením, se sečte s průměrným ročním přepočteným počtem ostatních zaměstnanců, kteří jsou OZP, a výsledkem je počet zaměstnanců se zdravotním postižením, které zaměstnavatel ve sledovaném roce zaměstnával.\nVýpočet se provede na dvě platná desetinná místa.||
|53|A|A53|10408||
|53|B|B53|Specifická právní skutečnost||
|53|C|C53|Souhrnná vrstva||
|53|D|D53|Specifická právní skutečnost||
|53|F|F53|číselník||
|53|J|J53|specifickaSkutecnost.typ (ID 10408)||
|53|K|K53| ||
|53|L|L53|CIS Rozhodná skutečnost||
|53|M|M53|ne - specifické||
|53|R|R53|x||
|53|T|T53|x||
|53|V|V53|x||
|53|X|X53|Číselníková hodnota dle relevantního typu právní skutečnosti.||
|54|A|A54|10409||
|54|B|B54|Datum nastání specifické právní skutečnosti||
|54|C|C54|Souhrnná vrstva||
|54|D|D54|Specifická právní skutečnost||
|54|F|F54|datum||
|54|J|J54|specifickaSkutecnost.datum (ID 10409)||
|54|K|K54| ||
|54|M|M54|ne - specifické||
|54|R|R54|x||
|54|T|T54|x||
|54|V|V54|x||
|54|W|W54|závislé na vyplnění Typu rozhodné skutečnosti, datum musí být v měsíci, za které je hlášení podáváno||
|54|X|X54|Datum rozhodné skutečnosti (pokud nastala RS, musí být provedena kontrola na časové období, tj. že datum rozhodné skutečnosti spadá do kalendářního měsíce, za které se podává hlášení).||
|55|A|A55|10214||
|55|B|B55|Typ kolektivní smlouvy||
|55|C|C55|Souhrnná vrstva||
|55|D|D55|Kolektivní smlouva k 31.12.||
|55|F|F55|číselník||
|55|H|H55|1-N||
|55|J|J55|zamestnavatelUdajeRok.kolektivniSmlouvy.kolektivniSmlouva.typKolektSmlouvy (ID 10214)||
|55|K|K55| ||
|55|L|L55|CIS Kolektivní smlouva||
|55|M|M55|ne - jiná periodicita||
|55|R|R55|x12||
|55|U|U55|x||
|55|V|V55|x||
|55|W|W55|roční periodicita, vybíráno v lednu, výběr 1 - N možností z číselníku||
|55|X|X55|Uvede se typ kolektivní smlouvy dle číselníku.\n0 neexistuje\n1 podniková kolektivní smlouva\n2 Kolektivní smlouva vyššího stupně na základě členství zaměstnavatele v zaměstnavatelském svazu, který kolektivní smlouvu vyššího stupně uzavřel\n3 Kolektivní smlouva vyššího stupně na základě rozšíření její závaznosti (podle § 7 zákona č. 2/1991 Sb. o kolektivním vyjednávání, ve znění pozdějších předpisů)\nAby bylo možné zpracovat data pro Eurostat, bude nutné mít k těmto kódům k dispozici i informaci o konkrétním odborovém či zaměstnavatelském svazu.||
|56|A|A56|10220||
|56|B|B56|Forma||
|56|C|C56|Souhrnná vrstva||
|56|D|D56|Hospodářská a finanční kontrola k 31.12.||
|56|F|F56|číselník||
|56|J|J56|zamestnavatelUdajeRok.formaVlastnictvi (ID 10220)||
|56|K|K56| ||
|56|L|L56|CIS Hospodářská a finanční kontrola||
|56|M|M56|ne - jiná periodicita||
|56|R|R56|x12||
|56|U|U56|x||
|56|V|V56|x||
|56|W|W56|roční periodicita, vybíráno v lednu||
|56|X|X56|Forma hospodářské a finanční kontroly (požaduje Eurostat) podle číselníku ISPV:\n- plně ve veřejném vlastnictví\n- plně v soukromém nebo družstebvním vlastnictví\n- ve sdíleném vlastnictví s většinovým veřejným podílem\n- ve většinovém vlastnictví s většinovým soukromým nebo družstevním podílem\n\nPoznámka: do veřejného vlastnictví patří společnosti ve vlastnictví státu, kraje, města, obce a společnosti zřízené na základě zvláštního zákona (církve, charity, vysoké školy, zdravotní pojišťovny, veřejnoprávní instiituce). U spolků je vlastnictví odvozeno od vlastnictví jednotlivých členů spolku, přičemž spolek tvořený fyzickými osobami je považován jako plně v soukromém nebo družstevním vlastnictví. U obecně prospěšných společností, ústavů, nadací, nadačních fondů, apod. je rozhodující vlastnictví zakladatelů, přičemž pokud jsou zakladateli fyzické osoby, je uvedená společnost plně v soukromém nebo družstevním vlastnictví.||
|57|A|A57|10286||
|57|B|B57|Zúčtovaný příjem - celkem||
|57|C|C57|Souhrnná data zaměstnance||
|57|D|D57|Příjem||
|57|F|F57|číslo||
|57|G|G57|celé číslo||
|57|J|J57|souhrnDataZec.prijmy.zuctovanoCelkem (ID 10286)||
|57|K|K57| ||
|57|M|M57|předchozí období||
|57|R|R57|x||
|57|T|T57|x||
|57|U|U57|x||
|57|V|V57|x||
|57|X|X57|Zúčtovaný příjem od zaměstnavatele, tj. včetně příjmů osvobozených a příjmů podléhajících dani vybírané srážkou podle zvláštní sazby daně. I v případě nulových zúčtovaných příjmů musí být uvedena nula.||
|58|A|A58|10416||
|58|B|B58|Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR||
|58|C|C58|Souhrnná data zaměstnance||
|58|D|D58|Příjem||
|58|F|F58|číslo||
|58|G|G58|celé číslo||
|58|J|J58|souhrnDataZec.prijmy.odmenyNerezident (ID 10416)||
|58|K|K58| ||
|58|M|M58|předchozí období||
|58|R|R58|x||
|58|T|T58|x||
|58|V|V58|x||
|58|W|W58|Vyplňuje se pouze v případě Kódu činnosti "S"||
|59|A|A59|10289||
|59|B|B59|Osvobozené příjmy ze zúčtovaných příjmů - celkem||
|59|C|C59|Souhrnná data zaměstnance||
|59|D|D59|Příjem||
|59|F|F59|číslo||
|59|G|G59|celé číslo||
|59|J|J59|souhrnDataZec.prijmy.osvobozenoCelkem (ID 10289)||
|59|K|K59| ||
|59|M|M59|předchozí období||
|59|R|R59|x||
|59|T|T59|x||
|59|U|U59|x||
|59|V|V59|x||
|59|X|X59|Částka - úhrn osvobozených příjmů (např. příspěvky zaměstnavatele na produkty na stáří).||
|60|A|A60|10417||
|60|B|B60|Příspěvek zaměstnavatele na produkty spoření na stáří a pojištění dlouhodobé péče z osvobozených příjmů - celkem||
|60|C|C60|Souhrnná data zaměstnance||
|60|D|D60|Příjem||
|60|E|E60|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|60|F|F60|číslo||
|60|G|G60|celé číslo (může být záporné)||
|60|J|J60|souhrnDataZec.prijmy.prispevekZamestnavatele.prispevekZelSporeniOsvob (ID 10417)||
|60|K|K60| ||
|60|M|M60|předchozí období||
|60|R|R60|x||
|60|T|T60|x||
|60|U|U60|x||
|60|V|V60|x||
|60|X|X60|Bez náplně jen popis k níže uvedeným položkám § 15a ZDP||
|61|A|A61|10292||
|61|B|B61|Příspěvek na penzijní připojištění se státním příspěvkem||
|61|C|C61|Souhrnná data zaměstnance||
|61|D|D61|Příjem||
|61|E|E61|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|61|F|F61|číslo||
|61|G|G61|celé číslo (může být záporné)||
|61|J|J61|souhrnDataZec.prijmy.prispevekZamestnavatele.prispevekPenzPripoj (ID 10292)||
|61|K|K61| ||
|61|M|M61|předchozí období||
|61|R|R61|x||
|61|T|T61|x||
|61|U|U61|x||
|61|V|V61|x||
|61|X|X61|Částka - osvobozeného příjmu podle § 6 odst. 9 písm. m) ZDP dle jednotlivého produktu||
|62|A|A62|10293||
|62|B|B62|Příspěvek na doplňkové penzijní spoření||
|62|C|C62|Souhrnná data zaměstnance||
|62|D|D62|Příjem||
|62|E|E62|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|62|F|F62|číslo||
|62|G|G62|celé číslo (může být záporné)||
|62|J|J62|souhrnDataZec.prijmy.prispevekZamestnavatele.prispevekDoplnPenzPripoj (ID 10293)||
|62|K|K62| ||
|62|M|M62|předchozí období||
|62|R|R62|x||
|62|T|T62|x||
|62|U|U62|x||
|62|V|V62|x||
|62|X|X62|Částka - osvobozeného příjmu podle § 6 odst. 9 písm. m) ZDP dle jednotlivého produktu||
|63|A|A63|10294||
|63|B|B63|Příspěvek na penzijní pojištění||
|63|C|C63|Souhrnná data zaměstnance||
|63|D|D63|Příjem||
|63|E|E63|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|63|F|F63|číslo||
|63|G|G63|celé číslo (může být záporné)||
|63|J|J63|souhrnDataZec.prijmy.prispevekZamestnavatele.prispevekPenzPoj (ID 10294)||
|63|K|K63| ||
|63|M|M63|předchozí období||
|63|R|R63|x||
|63|T|T63|x||
|63|U|U63|x||
|63|V|V63|x||
|63|X|X63|Částka - osvobozeného příjmu podle § 6 odst. 9 písm. m) ZDP dle jednotlivého produktu||
|64|A|A64|10295||
|64|B|B64|Příspěvek na soukromé životní pojištění||
|64|C|C64|Souhrnná data zaměstnance||
|64|D|D64|Příjem||
|64|E|E64|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|64|F|F64|číslo||
|64|G|G64|celé číslo||
|64|J|J64|souhrnDataZec.prijmy.prispevekZamestnavatele.prispevekZivotPoj (ID 10295)||
|64|K|K64| ||
|64|M|M64|předchozí období||
|64|R|R64|x||
|64|T|T64|x||
|64|U|U64|x||
|64|V|V64|x||
|64|X|X64|Částka - osvobozeného příjmu podle § 6 odst. 9 písm. m) ZDP dle jednotlivého produktu||
|65|A|A65|10296||
|65|B|B65|Příspěvek na dlouhodobý investiční produkt||
|65|C|C65|Souhrnná data zaměstnance||
|65|D|D65|Příjem||
|65|E|E65|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|65|F|F65|číslo||
|65|G|G65|celé číslo||
|65|J|J65|souhrnDataZec.prijmy.prispevekZamestnavatele.prispevekDip (ID 10296)||
|65|K|K65| ||
|65|M|M65|předchozí období||
|65|R|R65|x||
|65|T|T65|x||
|65|U|U65|x||
|65|V|V65|x||
|65|X|X65|Částka - osvobozeného příjmu podle § 6 odst. 9 písm. m) ZDP dle jednotlivého produktu||
|66|A|A66|10418||
|66|B|B66|Příspěvek na pojištění dlouhodobé péče||
|66|C|C66|Souhrnná data zaměstnance||
|66|D|D66|Příjem||
|66|E|E66|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|66|F|F66|číslo||
|66|G|G66|celé číslo||
|66|J|J66|souhrnDataZec.prijmy.prispevekZamestnavatele.prispevekZelPojDlPece (ID 10418)||
|66|K|K66| ||
|66|M|M66|předchozí období||
|66|R|R66|x||
|66|T|T66|x||
|66|V|V66|x||
|66|X|X66|Částka - osvobozeného příjmu podle § 6 odst. 9 písm. m) ZDP dle jednotlivého produktu||
|67|A|A67|10419||
|67|B|B67|Prohlášení poplatníka daně z příjmů ze závislé činnosti||
|67|C|C67|Souhrnná data zaměstnance||
|67|D|D67|Výpočet zálohy na daň||
|67|F|F67|příznak||
|67|J|J67|souhrnDataZec.prohlaseniPoplatnika (ID 10419)||
|67|K|K67| ||
|67|M|M67|předchozí období||
|67|R|R67|x||
|67|T|T67|x||
|67|V|V67|x||
|67|X|X67|Zaměstnanec (poplatník) učinil u zaměstnavatele prohlášení  k dani z příjmu ze závislé činnosti (VÝJIMKOU člena orgánu právnické osoby nerezidenta).||
|68|A|A68|10297||
|68|B|B68|Základ pro výpočet zálohy na daň||
|68|C|C68|Souhrnná data zaměstnance||
|68|D|D68|Výpočet zálohy na daň||
|68|F|F68|číslo||
|68|G|G68|celé číslo||
|68|J|J68|souhrnDataZec.zalohaNaDan.zakladDane (ID 10297)||
|68|K|K68| ||
|68|M|M68|předchozí období||
|68|P|P68| ||
|68|R|R68|x||
|68|T|T68|x||
|68|U|U68|x||
|68|V|V68|x||
|68|X|X68|Částka -  úhrn příjmů ze závislé činnosti zúčtovaných nebo vyplacených poplatníkovi za kalendářní měsíc nebo za zdaňovací období, s výjimkou příjmu, který není předmětem daně, který je od daně osvobozen nebo z něhož je daň vybírána srážkou podle zvláštní sazby daně.||
|69|A|A69|10298||
|69|B|B69|Vypočtená záloha na daň||
|69|C|C69|Souhrnná data zaměstnance||
|69|D|D69|Výpočet zálohy na daň||
|69|F|F69|číslo||
|69|G|G69|celé číslo||
|69|J|J69|souhrnDataZec.zalohaNaDan.vypoctenaZaloha (ID 10298)||
|69|K|K69| ||
|69|M|M69|předchozí období||
|69|R|R69|x||
|69|T|T69|x||
|69|U|U69|x||
|69|V|V69|x||
|69|X|X69|Částka -zaměstnavatel vypočte zálohu na daň z příjmů fyzických osob ze závislé činnosti ze základu pro výpočet zálohy.||
|70|A|A70|10299||
|70|B|B70|Základní sleva na poplatníka||
|70|C|C70|Souhrnná data zaměstnance||
|70|D|D70|Výpočet zálohy na daň||
|70|F|F70|číslo||
|70|G|G70|celé číslo||
|70|J|J70|souhrnDataZec.prohlaseniPoplatnikaDane.zakladniSleva (ID 10299)||
|70|K|K70| ||
|70|M|M70|předchozí období||
|70|R|R70|x||
|70|T|T70|x||
|70|U|U70|x||
|70|V|V70|x||
|70|X|X70|Částka podle § 35ba odst. 1 písm. a) ZDP – tj. 1/12 ze základní slevy (pro rok 2024 z částky 2 570 Kč měsíčně). Pokud zaměstnanec učinil prohlášení k dani. ||
|71|A|A71|10300||
|71|B|B71|Základní sleva na invaliditu (I. nebo II. Stupeň)||
|71|C|C71|Souhrnná data zaměstnance||
|71|D|D71|Výpočet zálohy na daň||
|71|F|F71|číslo||
|71|G|G71|celé číslo||
|71|J|J71|souhrnDataZec.prohlaseniPoplatnikaDane.zakladniSlevaInvalidita12 (ID 10300)||
|71|K|K71| ||
|71|M|M71|předchozí období||
|71|R|R71|x||
|71|T|T71|x||
|71|U|U71|x||
|71|V|V71|x||
|71|X|X71|Částka podle § 35ba odst. 1 písmeno c) ZDP – 1/12 základní slevy na invaliditu (tj. pro rok 2024 částka 210 Kč měsíčně), pokud byl zaměstnanci přiznán invalidní důchod pro invaliditu I. nebo II. stupně z důchodového pojištění podle zákona o důchodovém pojištění nebo zanikl-li nárok na částečný invalidní důchod z důvodu souběhu nároku na výplatu tohoto invalidního důchodu a starobního důchodu. Pokud zaměstnanec učinil prohlášení k dani. ||
|72|A|A72|10301||
|72|B|B72|Rozšířená sleva na invaliditu (III. Stupeň)||
|72|C|C72|Souhrnná data zaměstnance||
|72|D|D72|Výpočet zálohy na daň||
|72|F|F72|číslo||
|72|G|G72|celé číslo||
|72|J|J72|souhrnDataZec.prohlaseniPoplatnikaDane.rozsirenaSlevaInvalidita3 (ID 10301)||
|72|K|K72| ||
|72|M|M72|předchozí období||
|72|R|R72|x||
|72|T|T72|x||
|72|U|U72|x||
|72|V|V72|x||
|72|X|X72|Částka podle § 35ba odst. 1 písmeno d) ZDP – 1/12 rozšířené slevy na invaliditu (tj. pro rok 2024 částka 420 Kč měsíčně), pokud byl zaměstnanci přiznán invalidní důchod pro invaliditu III. stupně nebo jiný důchod z důchodového pojištění podle zákona o důchodovém pojištění, u něhož jednou z podmínek přiznání je, že je invalidní ve III. stupni, zanikl-li nárok na plný invalidní důchod z důvodu souběhu nároku na výplatu invalidního důchodu pro invaliditu III. stupně a starobního důchodu nebo je poplatník podle zvláštních předpisů plně invalidní, avšak jeho žádost o plný invalidní důchod byla zamítnuta z jiných důvodů než proto, že není plně invalidní.  Pokud zaměstnanec učinil prohlášení k dani. ||
|73|A|A73|10302||
|73|B|B73|Sleva na držitele průkazu ZTP/P||
|73|C|C73|Souhrnná data zaměstnance||
|73|D|D73|Výpočet zálohy na daň||
|73|F|F73|číslo||
|73|G|G73|celé číslo||
|73|J|J73|souhrnDataZec.prohlaseniPoplatnikaDane.slevaZTPP (ID 10302)||
|73|K|K73| ||
|73|M|M73|předchozí období||
|73|R|R73|x||
|73|T|T73|x||
|73|U|U73|x||
|73|V|V73|x||
|73|X|X73|Částka podle § 35ba odst. 1 písmeno e) ZDP – 1/12 slevy na ZTP/P (tj. pro rok 2024 částka 1 345 Kč měsíčně) pokud byl zaměstnanci přiznán nárok na průkaz ZTP/P a pokud zaměstnanec učinil prohlášení k dani. ||
|74|A|A74|10303||
|74|B|B74|Měsíční daňové zvýhodnění na děti||
|74|C|C74|Souhrnná data zaměstnance||
|74|D|D74|Výpočet zálohy na daň||
|74|F|F74|číslo||
|74|G|G74|celé číslo||
|74|J|J74|souhrnDataZec.prohlaseniPoplatnikaDane.danoveZvyhodneniDetiMesic (ID 10303)||
|74|K|K74| ||
|74|M|M74|předchozí období||
|74|R|R74|x||
|74|T|T74|x||
|74|U|U74|x||
|74|V|V74|x||
|74|X|X74|Částka daňového zvýhodnění podle § 35c a § 35d ZDP v úhrnu za všechny vyživované děti. Pozn.: Pořadí dítěte uvést položku pod názvem "Daňové zvýhodnění na dítě bylo uplatněno ve výši na jedno dítě, ve výši na druhé dítě, a ve výši na třetí a každé další dítě". Číselná hodnota této položky  musí nabývat hodnot 1, 2 nebo 3, tj. nesmí být větší jak 3. V případě, že zaměstnannec uplatňuje 4. a další dítě, potom tato hodnota má vždy číselnou hodnotu 3. Hodnotu si vyplňuje poplatník sám. Ke zvážení je rolovací okénko s přednabídkou hodnot 1,2,3.||
|75|A|A75|10453||
|75|B|B75|Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba||
|75|C|C75|Souhrnná data zaměstnance||
|75|D|D75|Výpočet zálohy na daň||
|75|E|E75|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|75|F|F75|příznak||
|75|J|J75|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.vyzivujeJinaOsoba (ID 10453)||
|75|K|K75| ||
|75|M|M75|předchozí období||
|75|R|R75|x||
|75|T|T75|x||
|76|A|A76|10431||
|76|B|B76|Jméno||
|76|C|C76|Souhrnná data zaměstnance||
|76|D|D76|Výpočet zálohy na daň||
|76|E|E76|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|76|F|F76|text||
|76|H|H76|1-N||
|76|J|J76|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.jineOsoby.jinaOsoba.jmeno (ID 10431)||
|76|K|K76| ||
|76|M|M76|předchozí období||
|76|R|R76|x||
|76|T|T76|x||
|77|A|A77|10432||
|77|B|B77|Příjmení||
|77|C|C77|Souhrnná data zaměstnance||
|77|D|D77|Výpočet zálohy na daň||
|77|E|E77|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|77|F|F77|text||
|77|H|H77|1-N||
|77|J|J77|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.jineOsoby.jinaOsoba.prijmeni (ID 10432)||
|77|K|K77| ||
|77|M|M77|předchozí období||
|77|R|R77|x||
|77|T|T77|x||
|78|A|A78|10433||
|78|B|B78|Datum narození||
|78|C|C78|Souhrnná data zaměstnance||
|78|D|D78|Výpočet zálohy na daň||
|78|E|E78|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|78|F|F78|datum||
|78|H|H78|1-N||
|78|J|J78|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.jineOsoby.jinaOsoba.datumNarozeni (ID 10433)||
|78|K|K78| ||
|78|M|M78|předchozí období||
|78|R|R78|x||
|78|T|T78|x||
|79|A|A79|10434||
|79|B|B79|Rodné číslo||
|79|C|C79|Souhrnná data zaměstnance||
|79|D|D79|Výpočet zálohy na daň||
|79|E|E79|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|79|F|F79|text||
|79|H|H79|1-N||
|79|J|J79|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.jineOsoby.jinaOsoba.rodneCislo (ID 10434)||
|79|K|K79| ||
|79|M|M79|předchozí období||
|79|R|R79|x||
|79|T|T79|x||
|80|A|A80|10435||
|80|B|B80|Jméno||
|80|C|C80|Souhrnná data zaměstnance||
|80|D|D80|Výpočet zálohy na daň||
|80|E|E80|Vyživované děti||
|80|F|F80|text||
|80|H|H80|1-N||
|80|J|J80|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.vyzivovaneDeti.vyzivovaneDite.dite.jmeno (ID 10435)||
|80|K|K80| ||
|80|M|M80|předchozí období||
|80|R|R80|x||
|80|T|T80|x||
|80|U|U80|x||
|81|A|A81|10436||
|81|B|B81|Příjmení||
|81|C|C81|Souhrnná data zaměstnance||
|81|D|D81|Výpočet zálohy na daň||
|81|E|E81|Vyživované děti||
|81|F|F81|text||
|81|H|H81|1-N||
|81|J|J81|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.vyzivovaneDeti.vyzivovaneDite.dite.prijmeni (ID 10436)||
|81|K|K81| ||
|81|M|M81|předchozí období||
|81|R|R81|x||
|81|T|T81|x||
|81|U|U81|x||
|82|A|A82|10437||
|82|B|B82|Datum narození||
|82|C|C82|Souhrnná data zaměstnance||
|82|D|D82|Výpočet zálohy na daň||
|82|E|E82|Vyživované děti||
|82|F|F82|datum||
|82|H|H82|1-N||
|82|J|J82|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.vyzivovaneDeti.vyzivovaneDite.dite.datumNarozeni (ID 10437)||
|82|K|K82| ||
|82|M|M82|předchozí období||
|82|R|R82|x||
|82|T|T82|x||
|82|U|U82|x||
|83|A|A83|10438||
|83|B|B83|Rodné číslo||
|83|C|C83|Souhrnná data zaměstnance||
|83|D|D83|Výpočet zálohy na daň||
|83|E|E83|Vyživované děti||
|83|F|F83|text||
|83|H|H83|1-N||
|83|J|J83|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.vyzivovaneDeti.vyzivovaneDite.dite.rodneCislo (ID 10438)||
|83|K|K83| ||
|83|M|M83|předchozí období||
|83|R|R83|x||
|83|T|T83|x||
|83|U|U83|x||
|84|A|A84|10439||
|84|B|B84|Průkaz ZTP/P||
|84|C|C84|Souhrnná data zaměstnance||
|84|D|D84|Výpočet zálohy na daň||
|84|E|E84|Vyživované děti||
|84|F|F84|příznak||
|84|H|H84|1-N||
|84|J|J84|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.vyzivovaneDeti.vyzivovaneDite.prukazZtpp (ID 10439)||
|84|K|K84| ||
|84|M|M84|předchozí období||
|84|R|R84|x||
|84|T|T84|x||
|84|X|X84|Průkaz ZTP/P náleží osobám se zvlášť těžkým funkčním postižením nebo úplným postižením pohyblivosti nebo orientace s potřebou průvodce, včetně osob s poruchou autistického spektra. Zvlášť těžkým funkčním postižením pohyblivosti a úplným postižením pohyblivosti se rozumí stav, kdy osoba je při dlouhodobě nepříznivém zdravotním stavu schopna chůze v domácím prostředí se značnými obtížemi, popřípadě není schopna chůze, v exteriéru není schopna samostatné chůze a pohyb je možný zpravidla jen na invalidním vozíku. Zvlášť těžkým funkčním postižením orientace a úplným postižením orientace se rozumí stav, kdy osoba při dlouhodobě nepříznivém zdravotním stavu není schopna samostatné orientace v exteriéru.||
|85|A|A85|10440||
|85|B|B85|Pořadí pro určení výše daňového zvýhodnění||
|85|C|C85|Souhrnná data zaměstnance||
|85|D|D85|Výpočet zálohy na daň||
|85|E|E85|Vyživované děti||
|85|F|F85|číselník||
|85|H|H85|1-N||
|85|J|J85|souhrnDataZec.prohlaseniPoplatnikaDane.zvyhodneniDetiMesic.vyzivovaneDeti.vyzivovaneDite.poradi (ID 10440)||
|85|K|K85| ||
|85|L|L85|CIS Pořadí dítěte||
|85|M|M85|předchozí období||
|85|R|R85|x||
|85|T|T85|x||
|85|X|X85|Pro "Pořadí dítěte pro určení výše daňového zvýhodnění"  = číselná hodnota, a to na jedno dítě  „1.“  na druhé dítě  „2.“, na třetí a každé další vyživované dítě  „3.“ Poplatník si sám určuje pořadí dítěte. Pořadí nemusí být chronologické.||
|86|A|A86|10304||
|86|B|B86|Měsíční sleva na děti||
|86|C|C86|Souhrnná data zaměstnance||
|86|D|D86|Výpočet zálohy na daň||
|86|F|F86|číslo||
|86|G|G86|celé číslo||
|86|J|J86|souhrnDataZec.prohlaseniPoplatnikaDane.slevaDite (ID 10304)||
|86|K|K86| ||
|86|M|M86|předchozí období||
|86|R|R86|x||
|86|T|T86|x||
|86|U|U86|x||
|86|V|V86|x||
|86|X|X86|Částka daňového zvýhodnění formou slevy na děti uplatněné maximálně do výše vypočtené zálohy na daň po slevě (§ 35c ZDP).||
|87|A|A87|10305||
|87|B|B87|Skutečně sražená záloha na daň po uplatnění slev||
|87|C|C87|Souhrnná data zaměstnance||
|87|D|D87|Výpočet zálohy na daň||
|87|F|F87|číslo||
|87|G|G87|celé číslo||
|87|J|J87|souhrnDataZec.zalohaNaDan.danZalohaPoSleve (ID 10305)||
|87|K|K87| ||
|87|M|M87|předchozí období||
|87|R|R87|x||
|87|T|T87|x||
|87|U|U87|x||
|87|V|V87|x||
|87|X|X87|Částka skutečně sražené zálohy na daň po uplatněné slevě na děti. Může nabývat jen hodnoty větší nebo rovné nule (nemůže mít zápornou hodnotu), v případě kladné hodnoty nemůže být nižší než 50 Kč - lze nastavit automatickou kontrolu.||
|88|A|A88|10306||
|88|B|B88|Výše vyplaceného měsíčního daňového bonusu||
|88|C|C88|Souhrnná data zaměstnance||
|88|D|D88|Výpočet zálohy na daň||
|88|F|F88|číslo||
|88|G|G88|celé číslo||
|88|J|J88|souhrnDataZec.zalohaNaDan.danBonus (ID 10306)||
|88|K|K88| ||
|88|M|M88|předchozí období||
|88|R|R88|x||
|88|T|T88|x||
|88|U|U88|x||
|88|V|V88|x||
|88|X|X88|Částka vyplaceného měsíčního daňového bonusu podle § 35d odst. 4 ZDP||
|89|A|A89|10307||
|89|B|B89|Základ pro výpočet daně podle zvláštní sazby daně||
|89|C|C89|Souhrnná data zaměstnance||
|89|D|D89|Výpočet daně podle zvláštní sazby daně ||
|89|F|F89|číslo||
|89|G|G89|celé číslo||
|89|J|J89|souhrnDataZec.zvlastniSazbaDane.zakladDane (ID 10307)||
|89|K|K89| ||
|89|M|M89|předchozí období||
|89|R|R89|x||
|89|T|T89|x||
|89|U|U89|x||
|89|V|V89|x||
|89|X|X89|Částka základu daně podle § 36 ZDP (tj., příjmů podle § 6 odst.4 ZDP - dohody o provedení práce, zaměstnání malého rozsahu a odměny členů orgánů právnických osob nerezidentů).||
|90|A|A90|10308||
|90|B|B90|Odměna člena (nerezidenta) orgánu právnické osoby||
|90|C|C90|Souhrnná data zaměstnance||
|90|D|D90|Výpočet daně podle zvláštní sazby daně ||
|90|F|F90|číslo||
|90|G|G90|celé číslo||
|90|J|J90|souhrnDataZec.zvlastniSazbaDane.odmenaNerezident (ID 10308)||
|90|K|K90| ||
|90|M|M90|předchozí období||
|90|R|R90|x||
|90|T|T90|x||
|90|U|U90|x||
|90|V|V90|x||
|91|A|A91|10309||
|91|B|B91|Skutečně sražená daň podle zvláštní sazby daně / měsíc||
|91|C|C91|Souhrnná data zaměstnance||
|91|D|D91|Výpočet daně podle zvláštní sazby daně ||
|91|F|F91|číslo||
|91|G|G91|celé číslo||
|91|J|J91|souhrnDataZec.zvlastniSazbaDane.srazenaDan (ID 10309)||
|91|K|K91| ||
|91|M|M91|předchozí období||
|91|R|R91|x||
|91|T|T91|x||
|91|U|U91|x||
|91|V|V91|x||
|91|X|X91|Částka daně sražená podle § 36 ZDP.  ||
|92|A|A92|10310||
|92|B|B92|Sražená záloha na daň z příjmu nerezidenta člena orgánu právnické osoby||
|92|C|C92|Souhrnná data zaměstnance||
|92|D|D92|Výpočet daně podle zvláštní sazby daně ||
|92|F|F92|číslo||
|92|G|G92|celé číslo||
|92|J|J92|souhrnDataZec.zvlastniSazbaDane.srazenaDanNerezident (ID 10310)||
|92|K|K92| ||
|92|M|M92|předchozí období||
|92|R|R92|x||
|92|T|T92|x||
|92|U|U92|x||
|92|V|V92|x||
|93|A|A93|10313||
|93|B|B93|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. následujícího roku - příjmy zdaněné zálohou na daň celkem||
|93|C|C93|Souhrnná data zaměstnance||
|93|D|D93|Roční úhrny jednotlivých položek||
|93|F|F93|číslo||
|93|G|G93|celé číslo||
|93|J|J93|souhrnDataZec.rocniUhrny.prijemZdanitelnyCelkem (ID 10313)||
|93|K|K93| ||
|93|M|M93|ne - jiná periodicita||
|93|R|R93|x01||
|93|T|T93|x||
|93|V|V93|x||
|93|X|X93|Částka za předcházející období (r-1) podklad pro předvyplnění daňového přiznání.||
|94|A|A94|10317||
|94|B|B94|Skutečně sražená záloha na daň z příjmů vyplacených nebo obdržených do 31.1. následujícího roku||
|94|C|C94|Souhrnná data zaměstnance||
|94|D|D94|Roční úhrny jednotlivých položek||
|94|F|F94|číslo||
|94|G|G94|celé číslo||
|94|J|J94|souhrnDataZec.rocniUhrny.zalohaPrijmy (ID 10317)||
|94|K|K94| ||
|94|M|M94|ne - jiná periodicita||
|94|R|R94|x01||
|94|T|T94|x||
|94|V|V94|x||
|94|X|X94|Částka za předcházející období (r-1) podklad pro předvyplnění daňového přiznání.||
|95|A|A95|10316||
|95|B|B95|Doplatky příjmů zúčtovaných v minulých zdaňovacích obdobích zdanitelných v ČR zdaněné zálohou na daň vyplacené nebo obdržené do 31.1. následujícího roku||
|95|C|C95|Souhrnná data zaměstnance||
|95|D|D95|Roční úhrny jednotlivých položek||
|95|F|F95|číslo||
|95|G|G95|celé číslo||
|95|J|J95|souhrnDataZec.rocniUhrny.prijemZdanitelnyDoplatek (ID 10316)||
|95|K|K95| ||
|95|M|M95|ne - jiná periodicita||
|95|R|R95|x01||
|95|T|T95|x||
|95|V|V95|x||
|95|X|X95|Částka za předcházející období (r-1) podklad pro předvyplnění daňového přiznání.||
|96|A|A96|10318||
|96|B|B96|Skutečně sražená záloha na daň z doplatků příjmů zdanitelných v ČR||
|96|C|C96|Souhrnná data zaměstnance||
|96|D|D96|Roční úhrny jednotlivých položek||
|96|F|F96|číslo||
|96|G|G96|celé číslo||
|96|J|J96|souhrnDataZec.rocniUhrny.zalohaDoplatky (ID 10318)||
|96|K|K96| ||
|96|M|M96|ne - jiná periodicita||
|96|R|R96|x01||
|96|T|T96|x||
|96|V|V96|x||
|96|X|X96|Částka za předcházející období (r-1) podklad pro předvyplnění daňového přiznání.||
|97|A|A97|10311||
|97|B|B97|Příjmy podléhající srážkové dani podle zvláštní sazby daně vyplacené nebo obdržené do 31.1. následujícího roku||
|97|C|C97|Souhrnná data zaměstnance||
|97|D|D97|Roční úhrny jednotlivých položek||
|97|F|F97|číslo||
|97|G|G97|celé číslo||
|97|J|J97|souhrnDataZec.rocniUhrny.prijemSrazkDanZvlSazba (ID 10311)||
|97|K|K97| ||
|97|M|M97|ne - jiná periodicita||
|97|R|R97|x01||
|97|T|T97|x||
|97|V|V97|x||
|97|X|X97|Částka za předcházející období (r-1) podklad pro předvyplnění daňového přiznání.||
|98|A|A98|10312||
|98|B|B98|Skutečně sražená daň vybíraná srážkou podle zvláštní sazby daně||
|98|C|C98|Souhrnná data zaměstnance||
|98|D|D98|Roční úhrny jednotlivých položek||
|98|F|F98|číslo||
|98|G|G98|celé číslo||
|98|J|J98|souhrnDataZec.rocniUhrny.danSrazenaZvlSazba (ID 10312)||
|98|K|K98| ||
|98|M|M98|ne - jiná periodicita||
|98|R|R98|x01||
|98|T|T98|x||
|98|V|V98|x||
|98|X|X98|Částka za předcházející období (r-1) podklad pro předvyplnění daňového přiznání.||
|99|A|A99|10319||
|99|B|B99|Zaměstnanec požádal o provedení ročního zúčtování||
|99|C|C99|Souhrnná data zaměstnance||
|99|D|D99|Roční zúčtování||
|99|F|F99|příznak||
|99|J|J99|souhrnDataZec.rocniUhrny.rocniZuctovaniZadost (ID 10319)||
|99|K|K99| ||
|99|M|M99|ne - jiná periodicita||
|99|R|R99|x0102||
|99|T|T99|x||
|99|X|X99|Zaškrtnuta varianta ANO - žádost zaměstnance o provedení roční zúčtování záloh za období r-1.\nZaškrtnuta varianta NE - nebylo požadováno roční zúčtování zaměstnancem.||
|100|A|A100|10320||
|100|B|B100|Roční zúčtování záloh bylo provedeno||
|100|C|C100|Souhrnná data zaměstnance||
|100|D|D100|Roční zúčtování||
|100|F|F100|příznak||
|100|J|J100|souhrnDataZec.rocniUhrny.rocniZuctovaniProvedeno (ID 10320)||
|100|K|K100| ||
|100|M|M100|ne - jiná periodicita||
|100|R|R100|x010203||
|100|T|T100|x||
|100|V|V100|x||
|100|X|X100|Zaškrtnuta varianta ANO -  bylo provedeno roční zúčtování zaměstnavatelem.\nZaškrtnuta varianta NE -  nebylo provedeno roční zúčtování zaměstnavatelem.||
|101|A|A101|10321||
|101|B|B101|Přeplatek nebo nedoplatek z ročního zúčtování||
|101|C|C101|Souhrnná data zaměstnance||
|101|D|D101|Výsledek ročního zúčtování||
|101|F|F101|číslo||
|101|G|G101|celé číslo (může být záporné)||
|101|J|J101|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.preplatekRok (ID 10321)||
|101|K|K101| ||
|101|M|M101|ne - jiná periodicita||
|101|R|R101|x010203||
|101|T|T101|x||
|101|U|U101|x||
|101|V|V101|x||
|101|X|X101|\nČástka - přeplatek nebo nedoplatek z ročního zúčtování - z toho přeplatek na dani, nebo nedoplatek daně||
|102|A|A102|10322||
|102|B|B102|Přeplatek nebo nedoplatek z ročního zúčtování - z toho přeplatek na dani nebo nedoplatek daně||
|102|C|C102|Souhrnná data zaměstnance||
|102|D|D102|Výsledek ročního zúčtování||
|102|F|F102|číslo||
|102|G|G102|celé číslo (může být záporné)||
|102|J|J102|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.danPreplatekRok (ID 10322)||
|102|K|K102| ||
|102|M|M102|ne - jiná periodicita||
|102|R|R102|x010203||
|102|T|T102|x||
|102|U|U102|x||
|102|V|V102|x||
|102|X|X102|<10321> z toho přeplatek na dani nebo nedoplatek daně||
|103|A|A103|10323||
|103|B|B103|Přeplatek nebo nedoplatek z ročního zúčtování - z toho doplatek na daňovém bonusu nebo přeplacená částka daňového bonusu zaměstnanci||
|103|C|C103|Souhrnná data zaměstnance||
|103|D|D103|Výsledek ročního zúčtování||
|103|F|F103|číslo||
|103|G|G103|celé číslo (může být záporné)||
|103|J|J103|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.danBonusPreplatekRok (ID 10323)||
|103|K|K103| ||
|103|M|M103|ne - jiná periodicita||
|103|R|R103|x010203||
|103|T|T103|x||
|103|U|U103|x||
|103|V|V103|x||
|103|X|X103|<10321> z toho doplatek na daňovém bonusu nebo přeplacená částka daňového bonusu zaměstnanci||
|104|A|A104|10420||
|104|B|B104|Uplatněna sleva na manželku / manžela||
|104|C|C104|Souhrnná data zaměstnance||
|104|D|D104|Výsledek ročního zúčtování||
|104|E|E104|Sleva na manželku / manžela||
|104|F|F104|příznak||
|104|J|J104|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.uplatnenaSlevaNaPartnera (ID 10420)||
|104|K|K104| ||
|104|M|M104|ne - jiná periodicita||
|104|R|R104|x010203||
|104|T|T104|x||
|104|V|V104|x||
|104|X|X104|Uplatnění nároku za příslušné zdaňovací období slevu na manžela. Pod uplatněním slev na manželku/manžela rozumí i registrované partnerství.||
|105|A|A105|10421||
|105|B|B105|Jméno manželky / manžela||
|105|C|C105|Souhrnná data zaměstnance||
|105|D|D105|Výsledek ročního zúčtování||
|105|E|E105|Sleva na manželku / manžela||
|105|F|F105|text||
|105|H|H105|1-N||
|105|J|J105|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.partnerUdaje.jmeno (ID 10421)||
|105|K|K105| ||
|105|M|M105|ne - jiná periodicita||
|105|R|R105|x010203||
|105|T|T105|x||
|106|A|A106|10422||
|106|B|B106|Příjmení manželky / manžela||
|106|C|C106|Souhrnná data zaměstnance||
|106|D|D106|Výsledek ročního zúčtování||
|106|E|E106|Sleva na manželku / manžela||
|106|F|F106|text||
|106|H|H106|1-N||
|106|J|J106|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.partnerUdaje.prijmeni (ID 10422)||
|106|K|K106| ||
|106|M|M106|ne - jiná periodicita||
|106|R|R106|x010203||
|106|T|T106|x||
|107|A|A107|10423||
|107|B|B107|Rodné číslo manželky / manžela||
|107|C|C107|Souhrnná data zaměstnance||
|107|D|D107|Výsledek ročního zúčtování||
|107|E|E107|Sleva na manželku / manžela||
|107|F|F107|text||
|107|H|H107|1-N||
|107|J|J107|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.partnerUdaje.datumNarozeni (ID 10423)||
|107|K|K107| ||
|107|M|M107|ne - jiná periodicita||
|107|R|R107|x010203||
|107|T|T107|x||
|108|A|A108|10424||
|108|B|B108|Datum narození manželky / manžela||
|108|C|C108|Souhrnná data zaměstnance||
|108|D|D108|Výsledek ročního zúčtování||
|108|E|E108|Sleva na manželku / manžela||
|108|F|F108|datum||
|108|H|H108|1-N||
|108|J|J108|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.partnerUdaje.rodneCislo (ID 10424)||
|108|K|K108| ||
|108|M|M108|ne - jiná periodicita||
|108|R|R108|x010203||
|108|T|T108|x||
|109|A|A109|10425||
|109|B|B109|Držitelka / držitel karty ZTP/P||
|109|C|C109|Souhrnná data zaměstnance||
|109|D|D109|Výsledek ročního zúčtování||
|109|E|E109|Sleva na manželku / manžela||
|109|F|F109|příznak||
|109|H|H109|1-N||
|109|J|J109|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.prukazZtpp (ID 10425)||
|109|K|K109| ||
|109|M|M109|ne - jiná periodicita||
|109|R|R109|x010203||
|109|T|T109|x||
|110|A|A110|10426||
|110|B|B110|Počet měsíců uplatnění slevy||
|110|C|C110|Souhrnná data zaměstnance||
|110|D|D110|Výsledek ročního zúčtování||
|110|E|E110|Sleva na manželku / manžela||
|110|F|F110|číslo||
|110|G|G110|celé číslo||
|110|H|H110|1-N||
|110|J|J110|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.slevaPocetMesicu (ID 10426)||
|110|K|K110| ||
|110|M|M110|ne - jiná periodicita||
|110|R|R110|x010203||
|110|T|T110|x||
|111|A|A111|10430||
|111|B|B111|Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P||
|111|C|C111|Souhrnná data zaměstnance||
|111|D|D111|Výsledek ročního zúčtování||
|111|E|E111|Sleva na manželku / manžela||
|111|F|F111|číslo||
|111|G|G111|celé číslo||
|111|H|H111|1-N||
|111|J|J111|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.slevaPocetMesicuZtpp (ID 10430)||
|111|K|K111| ||
|111|M|M111|ne - jiná periodicita||
|111|R|R111|x010203||
|111|T|T111|x||
|112|A|A112|10539||
|112|B|B112|Jméno dítěte||
|112|C|C112|Souhrnná data zaměstnance||
|112|D|D112|Výsledek ročního zúčtování||
|112|E|E112|Sleva na manželku / manžela||
|112|F|F112|text||
|112|H|H112|1-N pro každou manželku / manžela||
|112|J|J112|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.deti.dite.jmeno (ID 10539)||
|112|K|K112| ||
|112|M|M112|ne - jiná periodicita||
|112|R|R112|x010203||
|112|T|T112|x||
|113|A|A113|10540||
|113|B|B113|Příjmení dítěte||
|113|C|C113|Souhrnná data zaměstnance||
|113|D|D113|Výsledek ročního zúčtování||
|113|E|E113|Sleva na manželku / manžela||
|113|F|F113|text||
|113|H|H113|1-N pro každou manželku / manžela||
|113|J|J113|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.deti.dite.prijmeni (ID 10540)||
|113|K|K113| ||
|113|M|M113|ne - jiná periodicita||
|113|R|R113|x010203||
|113|T|T113|x||
|114|A|A114|10541||
|114|B|B114|Datum narození dítěte||
|114|C|C114|Souhrnná data zaměstnance||
|114|D|D114|Výsledek ročního zúčtování||
|114|E|E114|Sleva na manželku / manžela||
|114|F|F114|datum||
|114|H|H114|1-N pro každou manželku / manžela||
|114|J|J114|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.deti.dite.datumNarozeni (ID 10541)||
|114|K|K114| ||
|114|M|M114|ne - jiná periodicita||
|114|R|R114|x010203||
|114|T|T114|x||
|115|A|A115|10542||
|115|B|B115|Rodné číslo dítěte||
|115|C|C115|Souhrnná data zaměstnance||
|115|D|D115|Výsledek ročního zúčtování||
|115|E|E115|Sleva na manželku / manžela||
|115|F|F115|text||
|115|H|H115|1-N pro každou manželku / manžela||
|115|J|J115|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.slevaNaPartnera.partner.deti.dite.rodneCislo (ID 10542)||
|115|K|K115| ||
|115|M|M115|ne - jiná periodicita||
|115|R|R115|x010203||
|115|T|T115|x||
|116|A|A116|10454||
|116|B|B116|Uplatněno daňové zvýhodnění na děti ||
|116|C|C116|Souhrnná data zaměstnance||
|116|D|D116|Výsledek ročního zúčtování||
|116|E|E116|Daňové zvýhodnění na děti||
|116|F|F116|příznak||
|116|J|J116|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.uplatnenoZvyhodneniNaDeti (ID 10454)||
|116|K|K116| ||
|116|M|M116|ne - jiná periodicita||
|116|R|R116|x010203||
|116|T|T116|x||
|116|V|V116|x||
|117|A|A117|10455||
|117|B|B117|Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba||
|117|C|C117|Souhrnná data zaměstnance||
|117|D|D117|Výsledek ročního zúčtování||
|117|E|E117|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|117|F|F117|příznak||
|117|J|J117|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.vyzivujeJinaOsoba (ID 10455)||
|117|K|K117| ||
|117|M|M117|ne - jiná periodicita||
|117|R|R117|x010203||
|117|T|T117|x||
|118|A|A118|10441||
|118|B|B118|Jméno||
|118|C|C118|Souhrnná data zaměstnance||
|118|D|D118|Výsledek ročního zúčtování||
|118|E|E118|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|118|F|F118|text||
|118|H|H118|1-N||
|118|J|J118|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.jineOsoby.jinaOsoba.osoba.jmeno (ID 10441)||
|118|K|K118| ||
|118|M|M118|ne - jiná periodicita||
|118|R|R118|x010203||
|118|T|T118|x||
|119|A|A119|10442||
|119|B|B119|Příjmení||
|119|C|C119|Souhrnná data zaměstnance||
|119|D|D119|Výsledek ročního zúčtování||
|119|E|E119|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|119|F|F119|text||
|119|H|H119|1-N||
|119|J|J119|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.jineOsoby.jinaOsoba.osoba.prijmeni (ID 10442)||
|119|K|K119| ||
|119|M|M119|ne - jiná periodicita||
|119|R|R119|x010203||
|119|T|T119|x||
|120|A|A120|10443||
|120|B|B120|Datum narození||
|120|C|C120|Souhrnná data zaměstnance||
|120|D|D120|Výsledek ročního zúčtování||
|120|E|E120|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|120|F|F120|datum||
|120|H|H120|1-N||
|120|J|J120|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.jineOsoby.jinaOsoba.osoba.datumNarozeni (ID 10443)||
|120|K|K120| ||
|120|M|M120|ne - jiná periodicita||
|120|R|R120|x010203||
|120|T|T120|x||
|121|A|A121|10444||
|121|B|B121|Rodné číslo||
|121|C|C121|Souhrnná data zaměstnance||
|121|D|D121|Výsledek ročního zúčtování||
|121|E|E121|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|121|F|F121|text||
|121|H|H121|1-N||
|121|J|J121|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.jineOsoby.jinaOsoba.osoba.rodneCislo (ID 10444)||
|121|K|K121| ||
|121|M|M121|ne - jiná periodicita||
|121|R|R121|x010203||
|121|T|T121|x||
|122|A|A122|10445||
|122|B|B122|Měsíce vyživování||
|122|C|C122|Souhrnná data zaměstnance||
|122|D|D122|Výsledek ročního zúčtování||
|122|E|E122|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|122|F|F122|pole||
|122|H|H122|1-N||
|122|J|J122|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.jineOsoby.jinaOsoba.mesiceVyzivovani (ID 10445)||
|122|K|K122| ||
|122|M|M122|ne - jiná periodicita||
|122|R|R122|x010203||
|122|T|T122|x||
|123|A|A123|10446||
|123|B|B123|Jméno||
|123|C|C123|Souhrnná data zaměstnance||
|123|D|D123|Výsledek ročního zúčtování||
|123|E|E123|Vyživované děti||
|123|F|F123|text||
|123|H|H123|1-N||
|123|J|J123|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.vyzivovaneDeti.vyzivovaneDite.dite.jmeno (ID 10446)||
|123|K|K123| ||
|123|M|M123|ne - jiná periodicita||
|123|R|R123|x010203||
|123|T|T123|x||
|124|A|A124|10447||
|124|B|B124|Příjmení||
|124|C|C124|Souhrnná data zaměstnance||
|124|D|D124|Výsledek ročního zúčtování||
|124|E|E124|Vyživované děti||
|124|F|F124|text||
|124|H|H124|1-N||
|124|J|J124|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.vyzivovaneDeti.vyzivovaneDite.dite.prijmeni (ID 10447)||
|124|K|K124| ||
|124|M|M124|ne - jiná periodicita||
|124|R|R124|x010203||
|124|T|T124|x||
|125|A|A125|10448||
|125|B|B125|Datum narození||
|125|C|C125|Souhrnná data zaměstnance||
|125|D|D125|Výsledek ročního zúčtování||
|125|E|E125|Vyživované děti||
|125|F|F125|datum||
|125|H|H125|1-N||
|125|J|J125|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.vyzivovaneDeti.vyzivovaneDite.dite.datumNarozeni (ID 10448)||
|125|K|K125| ||
|125|M|M125|ne - jiná periodicita||
|125|R|R125|x010203||
|125|T|T125|x||
|126|A|A126|10449||
|126|B|B126|Rodné číslo||
|126|C|C126|Souhrnná data zaměstnance||
|126|D|D126|Výsledek ročního zúčtování||
|126|E|E126|Vyživované děti||
|126|F|F126|text||
|126|H|H126|1-N||
|126|J|J126|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.vyzivovaneDeti.vyzivovaneDite.dite.rodneCislo (ID 10449)||
|126|K|K126| ||
|126|M|M126|ne - jiná periodicita||
|126|R|R126|x010203||
|126|T|T126|x||
|127|A|A127|10450||
|127|B|B127|Průkaz ZTP/P v jednotlivých měsících||
|127|C|C127|Souhrnná data zaměstnance||
|127|D|D127|Výsledek ročního zúčtování||
|127|E|E127|Vyživované děti||
|127|F|F127|pole||
|127|H|H127|1-N||
|127|J|J127|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.vyzivovaneDeti.vyzivovaneDite.prukazZtpp (ID 10450)||
|127|K|K127| ||
|127|M|M127|ne - jiná periodicita||
|127|R|R127|x010203||
|127|T|T127|x||
|128|A|A128|10451||
|128|B|B128|Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících||
|128|C|C128|Souhrnná data zaměstnance||
|128|D|D128|Výsledek ročního zúčtování||
|128|E|E128|Vyživované děti||
|128|F|F128|pole (číselník)||
|128|H|H128|1-N||
|128|J|J128|souhrnDataZec.rocniUhrny.vysledekRocnihoZuctovani.zvyhodneniNaDeti.vyzivovaneDeti.vyzivovaneDite.poradi (ID 10451)||
|128|K|K128| ||
|128|L|L128|CIS Pořadí dítěte||
|128|M|M128|ne - jiná periodicita||
|128|R|R128|x010203||
|128|T|T128|x||
|128|X|X128|Pole číselníkových hodnot||
|129|A|A129|10344||
|129|B|B129|Čistý příjem||
|129|C|C129|Souhrnná data zaměstnance||
|129|D|D129|Mzda||
|129|E|E129|Výdělek||
|129|F|F129|číslo||
|129|G|G129|celé číslo||
|129|J|J129|souhrnDataZec.mzdaCista.mzdaCista (ID 10344)||
|129|K|K129| ||
|129|M|M129|předchozí období||
|129|R|R129|x||
|129|U|U129|x||
|129|V|V129|x||
|129|X|X129|Informace se sleduje pro potřeby dávek státní sociální podpory. \nZapočítává se příjem ze závislé činnosti podle ZDP, s výjimkou částky, která se považuje za příjem z důvodu bezplatného používání motorového vozidla pro služební i soukromé účely (§ 6 odst. 6), a s výjimkou částky odpovídající příjmu, kterého dosáhlo nezaopatřené dítě. Do rozhodného příjmu se nezapočítává daňový bonus (§ 35c ZDP). Patří sem i příjmy podle § 192 odst. 3 ZP. \nTzv. čistý příjem - příjem po odpočtu výdajů vynaložených na jejich dosažení, zajištění a udržení, po odpočtu dalších výdajů, odpočítávaných z takových příjmů podle ZDP, dále po odpočtu pojistného na sociální zabezpečení a příspěvku na státní politiku zaměstnanosti a pojistného na veřejné zdravotní pojištění a po odpočtu daně z příjmu, která připadá na tento příjem.\nV případě, že příjem nabývá záporné hodnoty, uvede se hodnota „0“. ||
|130|A|A130|10116||
|130|B|B130|Srážky na základě nařízeného soudního nebo správního výkonu rozhodnutí, konkursu nebo dohody o srážkách z příjmu||
|130|C|C130|Souhrnná data zaměstnance||
|130|D|D130|Mzda||
|130|E|E130|Srážky ze mzdy||
|130|F|F130|příznak||
|130|J|J130|souhrnDataZec.mzdaCista.srazkyZeMzdyEvidovany (ID 10116)||
|130|K|K130| ||
|130|M|M130|předchozí období||
|130|R|R130|x||
|130|S|S130|x||
|130|U|U130|x||
|130|X|X130|Podle ustanovení § 83 odst. 2 písm. a) zákona č. 58/1991 Sb., ve znění pozdějších předpisů  je zaměstnavatel povinen do 8 dnů ode dne,  kdy obdržel výzvu územní správy sociálního zabezpečení sepisující nebo přijímající žádost  dávku důchodového pojištění, sdělit písemně této správě, zda provádí z příjmu žadatele o dávku důchodového pojištění srážky na základě nařízeného soudního nebo správního výkonu rozhodnutí, konkursu nebo dohody o srážkách z příjmu uzavřené podle občanského zákoníku, označení toho, kdo toto rozhodnutí vydal, a číslo jednací tohoto rozhodnutí, a jde-li o srážky na výživné, zda se jedná o běžné nebo dlužné výživné a jaká je jeho výše.\nPodobnou povinnost ukládá zaměstnavateli § 97 odst. 6 zákona č. 187/2006 Sb.,ve znění pozdějších předpisů, podle kterého je-li u zaměstnance nařízen výkon rozhodnutí srážkami ze mzdy, je zaměstnavatel povinen spolu s údaji potřebnými pro výpočet dávek předat územní správě sociálního zabezpečení podklady pro provádění srážek z dávek nemocenského pojištění; těmito podklady se rozumí kopie usnesení o nařízení výkonu rozhodnutí, sdělení výše dosud provedených srážek a sdělení, jaká část základní částky nemá být územní správou sociálního zabezpečení srážena. ||
|131|A|A131|10348||
|131|B|B131|Mzda/plat nebo jeho část vyplacena v hotovosti ||
|131|C|C131|Souhrnná data zaměstnance||
|131|D|D131|Mzda||
|131|E|E131|Výdělek osob OZP||
|131|F|F131|příznak||
|131|J|J131|souhrnDataZec.mzdaCista.vydelekOZP.mzdaOzpHotovost (ID 10348)||
|131|K|K131| ||
|131|M|M131|předchozí období||
|131|R|R131|x||
|131|U|U131|x||
|131|X|X131|V případě, že je zaměstnanec osobou se zdravotním postižením podle § 67 zákona č. 435/2004 Sb., o zaměstnanosti a zaměstnavatel je současně uznaným zaměstnavatelem na chráněném trhu práce podle § 78 zákona č. 435/2004 Sb., o zaměstnanosti, uvede se, zda v daném kalendářním měsíci byla vyplacena mzda / plat nebo jakákoliv její část v hotovosti. Zaměstnavatel uvede ANO, pokud jakákoliv část mzdy / platu byla vyplacena v hotovosti. Zaměstnavatel uveden NE, pokud celá mzda / plat byla vyplacena bezhotovostně.||
|132|A|A132|10349||
|132|B|B132|Provedeny srážky ze mzdy nebo platu určené k uspokojení plnění zaměstnavatele||
|132|C|C132|Souhrnná data zaměstnance||
|132|D|D132|Mzda||
|132|E|E132|Výdělek osob OZP||
|132|F|F132|příznak||
|132|J|J132|souhrnDataZec.mzdaCista.vydelekOZP.mzdaOzpSrazka (ID 10349)||
|132|K|K132| ||
|132|M|M132|předchozí období||
|132|R|R132|x||
|132|U|U132|x||
|132|X|X132|Srážky ze mzdy nebo platu určených k uspokojení plnění zaměstnavatele podle občanského zákoníku, s výjimkou srážek provedených k uhrazení škody, za kterou zaměstnanec odpovídá, nebo příspěvku zaměstnance na stravování podle ustanovení § 236 zákoníku práce||
|133|A|A133|10347||
|133|B|B133|Datum úhrady mzdy včetně odvodů na soc. a zdravotní pojištění||
|133|C|C133|Souhrnná data zaměstnance||
|133|D|D133|Mzda||
|133|E|E133|Výdělek osob OZP||
|133|F|F133|datum||
|133|J|J133|souhrnDataZec.mzdaCista.vydelekOZP.mzdaOzpUhradaDatum (ID 10347)||
|133|K|K133| ||
|133|M|M133|ne - datum||
|133|R|R133|x||
|133|U|U133|x||
|133|X|X133|V případě, že zaměstnavatel za daný kalendářní měsíc požaduje od Úřadu práce ČR na základě s ním uzavřené písemné dohody poskytnutí mzdového příspěvku aktivní politiky zaměstnanosti podle zákona č. 435/2004 Sb., o zaměstnanosti, uvede se datum úhrady mzdy a datum, kdy zaměstnavatel odvedl za zaměstnance umístěného na nástroji aktivní politiky zaměstnanosti pojistné na sociální zabezpečení a příspěvek na státní politiku zaměstnanosti a pojistné na veřejné zdravotní pojištění. \n\nPro účely aktivní politiky zaměstnanosti se vyplacením mzdy rozumí okamžik, kdy dojde k zaplacení mzdy zaměstnanci v hotovosti, okamžik odepsání částky mzdy z účtu zaměstnavatele, je-li odesílána na účet zaměstnance, nebo okamžik přijetí platby k úhradě poštovním poukazem poskytovatelem poštovních služeb. Odvedení pojistného je upraveno v ustanovení § 19 odst. 2 zákona o sociálním pojištění a v ustanovení § 17 odst. 2 zákona o zdravotním pojištění a v případě bezhotovostní platby se jím rozumí den připsání pojistného na účet příslušné okresní správy sociálního zabezpečení nebo den připsání pojistného na učet příslušné zdravotní pojišťovny, v případě platby v hotovosti okamžik zaplacení pojistného přímo zaměstnanci příslušné zdravotní pojišťovny.||
|134|A|A134|10350||
|134|B|B134|Srážky k uspokojení plnění zaměstnavatele podle občanského zákoníku||
|134|C|C134|Souhrnná data zaměstnance||
|134|D|D134|Mzda||
|134|E|E134|Srážky ze mzdy||
|134|F|F134|číslo||
|134|G|G134|celé číslo||
|134|J|J134|souhrnDataZec.mzdaCista.srazky.srazkaPlneniZel (ID 10350)||
|134|K|K134| ||
|134|M|M134|předchozí období||
|134|R|R134|x||
|134|U|U134|x||
|134|V|V134|x||
|134|X|X134|Srážky k uspokojení plnění zaměstnavatele podle občanského zákoníku||
|135|A|A135|10351||
|135|B|B135|Srážky k uhrazení škody, za kterou odpovídá zaměstnanec||
|135|C|C135|Souhrnná data zaměstnance||
|135|D|D135|Mzda||
|135|E|E135|Srážky ze mzdy||
|135|F|F135|číslo||
|135|G|G135|celé číslo||
|135|J|J135|souhrnDataZec.mzdaCista.srazky.srazkaSkodaZec (ID 10351)||
|135|K|K135| ||
|135|M|M135|předchozí období||
|135|R|R135|x||
|135|U|U135|x||
|135|V|V135|x||
|135|X|X135|Srážky k uhrazení škody, za kterou odpovídá zaměstnanec||
|136|A|A136|10352||
|136|B|B136|Srážky na závodní stravování pode §236 zákoníku práce,||
|136|C|C136|Souhrnná data zaměstnance||
|136|D|D136|Mzda||
|136|E|E136|Srážky ze mzdy||
|136|F|F136|číslo||
|136|G|G136|celé číslo||
|136|J|J136|souhrnDataZec.mzdaCista.srazky.srazkaStrava (ID 10352)||
|136|K|K136| ||
|136|M|M136|předchozí období||
|136|R|R136|x||
|136|U|U136|x||
|136|V|V136|x||
|136|X|X136|Srážky na závodní stravování pode §236 zákoníku práce,||
|137|A|A137|10353||
|137|B|B137|Srážky k uspokojení závazků zaměstnance podle § 146 písm. b) zákoníku práce||
|137|C|C137|Souhrnná data zaměstnance||
|137|D|D137|Mzda||
|137|E|E137|Srážky ze mzdy||
|137|F|F137|číslo||
|137|G|G137|celé číslo||
|137|J|J137|souhrnDataZec.mzdaCista.srazky.srazkaZavazkyZec (ID 10353)||
|137|K|K137| ||
|137|M|M137|předchozí období||
|137|R|R137|x||
|137|U|U137|x||
|137|V|V137|x||
|137|X|X137|Srážky k uspokojení závazků zaměstnance podle § 146 písm. b) zákoníku práce||
|138|A|A138|10482||
|138|B|B138|Zdravotní pojištění||
|138|C|C138|Souhrnná data zaměstnance||
|138|D|D138|Pojistné za zaměstnavatele||
|138|F|F138|číslo||
|138|G|G138|celé číslo||
|138|J|J138|souhrnDataZec.zdravPojZamestnavatel.zdravotniPojisteni (ID 10482)||
|138|K|K138| ||
|138|M|M138|předchozí období||
|138|R|R138|x||
|138|S|S138|x||
|138|U|U138|x||
|138|V|V138|x||
|138|X|X138|Uvede se výše pojistného na veřejné zdravotní pojištění, které zaměstnavatel za sebe odvedl z vyměřovacího základu zaměstnance.||
|139|A|A139|10371||
|139|B|B139|Zdravotní pojištění||
|139|C|C139|Souhrnná data zaměstnance||
|139|D|D139|Pojistné za zaměstnance||
|139|F|F139|číslo||
|139|G|G139|celé číslo||
|139|J|J139|souhrnDataZec.zdravPojZamestnanec.zdravotniPojisteni (ID 10371)||
|139|K|K139| ||
|139|M|M139|předchozí období||
|139|R|R139|x||
|139|U|U139|x||
|139|V|V139|x||
|139|X|X139|Uvede se výše pojistného na veřejné zdravotní pojištění, které zaměstnavatel za zaměstnance odvedl.||
|140|A|A140|10051||
|140|B|B140|IK MPSV (Osobní identifikační číslo - OIČ)||
|140|C|C140|Zaměstnanec / Žák / Student ||
|140|D|D140|Základní identifikace||
|140|F|F140|číslo||
|140|G|G140|celé číslo||
|140|I|I140|employees.employee.client.ikmpsv (ID 10051)||
|140|J|J140|identifikace.ikMpsv (ID 10051)||
|140|M|M140|ne - identifikace||
|140|Q|Q140|x||
|140|R|R140|x||
|140|S|S140|x||
|140|T|T140|x||
|140|U|U140|x||
|140|V|V140|x||
|140|W|W140|pokud není vytvořena vazba mezi ZEL a ZEC, pak jde jen o pomocný údaj (při registraci zaměstnance)||
|140|X|X140|Jednotný bezvýznamový unikátní identifikátor resortu MPSV, kterým zaměstnanec již nyní disponuje nebo který obdrží při první registraci. Tento identifikátor se váže k jedné identitě a je neměnný (Změna identifikátoru je možná, za podmínek, že se jedná o spojení nebo rozdělení duplicitně vydaných IK MPSV. Platné je vždy nově vydané.). ||
|141|A|A141|10461||
|141|B|B141|AIFO||
|141|C|C141|Zaměstnanec / Žák / Student ||
|141|D|D141|Základní identifikace||
|141|F|F141|číslo||
|141|G|G141|celé číslo||
|141|P|P141|bez sběru, získá se až na backendu||
|141|T|T141|x||
|141|U|U141|x||
|141|V|V141|x||
|141|W|W141|nebudeme prezentovat na FE, bude pouze předáváno konzumentům v rámci registrace zaměstnance||
|141|X|X141| ||
|142|A|A142|10053||
|142|B|B142|Příjmení||
|142|C|C142|Zaměstnanec / Žák / Student ||
|142|D|D142|Základní identifikace||
|142|F|F142|text||
|142|I|I142|employees.employee.client.name.sur (ID 10053)||
|142|J|J142|identifikace.prijmeni (ID 10053)||
|142|M|M142|ne - identifikace||
|142|Q|Q142|x||
|142|R|R142|x||
|142|S|S142|x||
|142|T|T142|x||
|142|U|U142|x||
|142|V|V142|x||
|142|X|X142|Příjmení platné v den provádění zápisu||
|143|A|A143|10054||
|143|B|B143|Jméno||
|143|C|C143|Zaměstnanec / Žák / Student ||
|143|D|D143|Základní identifikace||
|143|F|F143|text||
|143|I|I143|employees.employee.client.name.fir (ID 10054)||
|143|J|J143|identifikace.jmeno (ID 10054)||
|143|M|M143|ne - identifikace||
|143|Q|Q143|x||
|143|R|R143|x||
|143|S|S143|x||
|143|T|T143|x||
|143|U|U143|x||
|143|V|V143|x||
|143|X|X143|Jméno v nezkrácené podobě obsažené v dokladech prokazujících totožnost pojištěnce. Pokud má pojištěnec více jmen, uvedou se všechna dle dokladů (do využití počtu úhozů), oddělí se mezerou.||
|144|A|A144|10055||
|144|B|B144|Titul||
|144|C|C144|Zaměstnanec / Žák / Student ||
|144|D|D144|Základní identifikace||
|144|F|F144|text||
|144|I|I144|employees.employee.client.name.tit (ID 10055)||
|144|J|J144| ||
|144|Q|Q144|x||
|144|S|S144|x||
|144|T|T144|x||
|144|U|U144|x||
|144|V|V144|x||
|144|X|X144|Akademické tituly uváděné běžně používanými zkratkami (např. Mgr., JUDr.). V případě více titulů se oddělují mezerou. Údaj je nepovinný||
|145|A|A145|10056||
|145|B|B145|Datum narození||
|145|C|C145|Zaměstnanec / Žák / Student ||
|145|D|D145|Základní identifikace||
|145|F|F145|datum||
|145|I|I145|employees.employee.client.birth.dat (ID 10056)||
|145|J|J145|identifikace.datumNarozeni (ID 10056)||
|145|K|K145| ||
|145|M|M145|ne - identifikace||
|145|Q|Q145|x||
|145|R|R145|x||
|145|S|S145|x||
|145|T|T145|x||
|145|U|U145|x||
|145|V|V145|x||
|145|X|X145|Uvádí se běžným způsobem s tečkami nebo mezerami mezi dnem, měsícem a rokem ve tvaru D(DD).M(MM).RRRR (např. 1. 7. 1965)||
|146|A|A146|10057||
|146|B|B146|Rodné číslo||
|146|C|C146|Zaměstnanec / Žák / Student ||
|146|D|D146|Základní identifikace||
|146|F|F146|text||
|146|I|I146|employees.employee.client.bno (ID 10057/10058)||
|146|J|J146| ||
|146|Q|Q146|x||
|146|S|S146|x||
|146|T|T146|x||
|146|U|U146|x||
|146|V|V146|x||
|146|X|X146|Devítimístný nebo desetimístný číselný znak bez mezer (u občanů narozených po 31. 12. 1953 je rodné číslo desetimístné). U devítimístného rodného čísla je při elektronickém vyplňování třeba uvést skutečně 9 znaků (nesmí být proveden zápis mezery na desátém místě). Rodné číslo je nezastupitelným identifikačním údajem, který je třeba vyplňovat vždy i u cizích státních příslušníků. V případě, že cizí státní příslušník nemá při oznámení o nástupu dosud rodné číslo (RČ) ani evidenční číslo pojištěnce (EČP) přiděleno, tento údaj se na tiskopisu nevyplňuje. Podání lze zaslat elektronicky, podmínkou je správné vyplnění data narození a dalších povinných údajů formuláře. Po přidělení rodného čísla příslušnou institucí se rodné číslo pojištěnce nahlásí příslušné OSSZ. Rodné číslo je základním identifikátorem pojištěnce, proto je nutné dbát zvýšené pozornosti při vyplňování tohoto údaje, popř. jeho ověření. U cizích státních příslušníků nelze do pole „Rodné číslo“ uvádět jiné druhy identifikátorů (např. identifikátor VZP apod.). Upozornění: Občané Slovenské republiky, jimž bylo rodné číslo přiděleno po 31. 12. 1992, jsou taktéž považováni za cizince a toto „slovenské“ rodné číslo tak nelze pro účely vyplňování tiskopisů použít. V případě, že není RČ, přidělí správce agendy EČP (evidenční číslo pojištěnce).||
|147|A|A147|10058||
|147|B|B147|EČP||
|147|C|C147|Zaměstnanec / Žák / Student ||
|147|D|D147|Základní identifikace||
|147|F|F147|text||
|147|I|I147|employees.employee.client.bno (ID 10057/10058)||
|147|J|J147| ||
|147|Q|Q147|x||
|147|S|S147|x||
|147|T|T147|x||
|147|U|U147|x||
|147|V|V147|x||
|147|X|X147|Evidenční číslo pojištěnce (EČP) je interní identifikátor osoby, která nemá přidělené rodné číslo (cizinci). EČP přiděluje ČSSZ. Devítimístný nebo desetimístný číselný znak bez mezer (u občanů narozených po 31. 12. 1953 je EČP rodné číslo desetimístné). U devítimístného EČProdného čísla je při elektronickém vyplňování třeba uvést skutečně 9 znaků (nesmí být proveden zápis mezery na desátém místě). EČPRodné číslo je nezastupitelným identifikačním údajem, který je třeba vyplňovat, nebylo-li osobě dosud přiděleno rodné číslo vždy i u cizích státních příslušníků. Pokud bylo následně přiděleno rodné číslo, EČP se již neuvádí. V případě, že cizí státní příslušník nemá při oznámení o nástupu dosud rodné číslo (RČ) ani evidenční číslo pojištěnce (EČP) přiděleno, tento údaj se na tiskopisu nevyplňuje. Podání lze zaslat elektronicky, podmínkou je správné vyplnění data narození a dalších povinných údajů formuláře. Po přidělení rodného čísla příslušnou institucí se rodné číslo pojištěnce nahlásí příslušné OSSZ. EČPRodné číslo je základním identifikátorem pojištěnce, proto je nutné dbát zvýšené pozornosti při vyplňování tohoto údaje, popř. jeho ověření. U cizích státních příslušníků nelze do pole „EČPRodné číslo“ uvádět jiné druhy identifikátorů (např. identifikátor VZP apod.). Upozornění: Občané Slovenské republiky, jimž bylo rodné číslo přiděleno po 31. 12. 1992, jsou taktéž považováni za cizince a toto „slovenské“ rodné číslo tak nelze pro účely vyplňování tiskopisů použít. V případě, že není RČ, přidělí správce agendy EČP (evidenční číslo pojištěnce).||
|148|A|A148|10059||
|148|B|B148|Pohlaví||
|148|C|C148|Zaměstnanec / Žák / Student ||
|148|D|D148|Základní identifikace||
|148|F|F148|číselník||
|148|I|I148|employees.employee.client.stat.mal (ID 10059)||
|148|J|J148| ||
|148|L|L148|CIS Pohlaví||
|148|Q|Q148|x||
|148|S|S148|x||
|148|T|T148|x||
|148|U|U148|x||
|148|V|V148|x||
|148|X|X148|Pohlaví zaměstnance dle číselníku.||
|149|A|A149|10060||
|149|B|B149|VČP||
|149|C|C149|Zaměstnanec / Žák / Student ||
|149|D|D149|Základní identifikace||
|149|F|F149|číslo||
|149|G|G149|celé číslo||
|149|I|I149|employees.employee.client.vcp (ID 10060)||
|149|J|J149| ||
|149|Q|Q149|x||
|149|T|T149|x||
|149|V|V149|x||
|149|X|X149|Číslo přidělené správcem daně v případech, kdy poplatník nemá RČ.||
|150|A|A150|10061||
|150|B|B150|Typ daňové identifikace||
|150|C|C150|Zaměstnanec / Žák / Student ||
|150|D|D150|Daňová identifikace ve státě rezidence||
|150|F|F150|číselník||
|150|I|I150|employees.employee.client.taxidrezid.type (ID 10061)||
|150|J|J150| ||
|150|L|L150|CIS Typ daňové identifikace||
|150|Q|Q150|x||
|150|T|T150|x||
|150|V|V150|x||
|150|X|X150|Identifikátor používaný v zemi daňové rezidence (Číselník - Typ daňové identifikace: D – DIČ, R – RČ, S – Sociální pojištění, J – jiné). Příloha č.2 VDA - mezinárodní výměna informací.||
|151|A|A151|10062||
|151|B|B151|Daňový identifikátor ve státě rezidence||
|151|C|C151|Zaměstnanec / Žák / Student ||
|151|D|D151|Daňová identifikace ve státě rezidence||
|151|F|F151|text||
|151|I|I151|employees.employee.client.taxidrezid.num (ID 10062)||
|151|J|J151| ||
|151|Q|Q151|x||
|151|T|T151|x||
|151|V|V151|x||
|151|X|X151|Jedná se o číslo daňové identifikace přidělené ve státě daňové rezidence (příloha č.2 VDA - mezinárodní výměna informací). Bude vyplněno pouze u cizinců.||
|152|A|A152|10063||
|152|B|B152|Rodné příjmení||
|152|C|C152|Zaměstnanec / Žák / Student ||
|152|D|D152|Základní identifikace||
|152|F|F152|text||
|152|I|I152|employees.employee.client.birth.nam (ID 10063)||
|152|J|J152| ||
|152|Q|Q152|x||
|152|S|S152|x||
|152|T|T152|x||
|152|V|V152|x||
|152|W|W152|u rezidentů je možné jej získat z ROBu||
|152|X|X152|Rodné příjmení dle záznamů obsažených v dokladech prokazujících totožnost zaměstnance||
|153|A|A153|10064||
|153|B|B153|Dřívější příjmení||
|153|C|C153|Zaměstnanec / Žák / Student ||
|153|D|D153|Základní identifikace||
|153|F|F153|text||
|153|I|I153|employees.employee.client.name.ona (ID 10064)||
|153|J|J153| ||
|153|Q|Q153|x||
|153|S|S153|x||
|153|T|T153|x||
|153|V|V153|x||
|153|X|X153|Všechna předchozí příjmení, bez aktuálního příjmení a rodného příjmení. Jednotlivá příjmení se oddělují čárkou (např. Nováková, Doležalová, Nguyen Quoc, Mc Donaldová). Pokud zaměstnanec další předchozí příjmení nemá, pole se nevyplňuje.||
|154|A|A154|10065||
|154|B|B154|Stát||
|154|C|C154|Zaměstnanec / Žák / Student ||
|154|D|D154|Základní identifikace||
|154|E|E154|Místo narození||
|154|F|F154|číselník||
|154|I|I154|employees.employee.client.birth.stat (ID 10065)||
|154|J|J154| ||
|154|L|L154|CIS Stát||
|154|Q|Q154|x||
|154|S|S154|x||
|154|T|T154|x||
|154|U|U154|x||
|154|V|V154|x||
|154|X|X154|Stát narození. Pro označení státu se použije číselník států||
|155|A|A155|10066||
|155|B|B155|Obec||
|155|C|C155|Zaměstnanec / Žák / Student ||
|155|D|D155|Základní identifikace||
|155|E|E155|Místo narození||
|155|F|F155|text||
|155|I|I155|employees.employee.client.birth.cit (ID 10066)||
|155|J|J155| ||
|155|Q|Q155|x||
|155|S|S155|x||
|155|U|U155|x||
|155|V|V155|x||
|155|X|X155|Obec narození.||
|156|A|A156|10067||
|156|B|B156|Státní občanství||
|156|C|C156|Zaměstnanec / Žák / Student ||
|156|D|D156|Základní identifikace||
|156|F|F156|číselník||
|156|I|I156|employees.employee.client.stat.cnt (ID 10067)||
|156|J|J156| ||
|156|L|L156|CIS Stát||
|156|Q|Q156|x||
|156|S|S156|x||
|156|T|T156|x||
|156|U|U156|x||
|156|V|V156|x||
|156|X|X156|Státní občanství je osobní právní poměr určitého jednotlivce k určitému státu, pro nějž je charakteristická jeho trvalost. Státní občanství je fakticky souhrn práv a povinností mezi osobou a určitým státem, přičemž jen na státní občany se vztahují veškeré práva a povinnosti daného státu. Zaznamenává se pomocí dvoumístného kódu číselníku států. Pro Českou republiku se používá kód CZ. Pokud má pojištěnec více státních občanství, z nichž je jedno v České republice, uvádí se CZ. Pokud má pojištěnec více státních občanství a nemá občanství v České republice, uvede se občanství dle jeho uvážení.||
|157|A|A157|10068||
|157|B|B157|Kód státu rezidenství||
|157|C|C157|Zaměstnanec / Žák / Student ||
|157|D|D157|Daňová identifikace ve státě rezidence||
|157|F|F157|číselník||
|157|I|I157|employees.employee.client.taxidrezid.stat (ID 10068)||
|157|J|J157| ||
|157|L|L157|CIS Stát||
|157|Q|Q157|x||
|157|S|S157|x||
|157|T|T157|x||
|157|U|U157|x||
|157|V|V157|x||
|157|W|W157|FS: Údaj bude vyplněn i v případě zaměstnanců rezidentů ČR (CZ). Budeli vyplněno CZ, potom se neotevírají položky nerezidentů.\nKód bude vybírán a měněn v rámci procesu registrace zaměstnance. Návrh FS je, aby byl zároveň needitovatelně zobrazován v rámci měsíčního hlášení s návodem, jak lze kód změnit.||
|157|X|X157|Kód státu, jehož je zaměstnanec rezidentem.  Údaj bude vyplněn i v případě zaměstnanců rezidentů ČR (CZ). Budeli vyplněno CZ, potom se neotevírají položky nerezidentů.||
|158|A|A158|10459||
|158|B|B158|Platnost změny kódu státu rezidentství od||
|158|C|C158|Zaměstnanec / Žák / Student ||
|158|D|D158|Daňová identifikace ve státě rezidence||
|158|F|F158|datum||
|158|I|I158|employees.employee.client.taxidrezid.statchang (ID 10459)||
|158|J|J158| ||
|158|Q|Q158|x||
|158|T|T158|x||
|158|U|U158|x||
|158|V|V158|x||
|158|X|X158|Datum platnosti změny kódu státu rezidentství. ||
|159|A|A159|10069||
|159|B|B159|Typ dokladu||
|159|C|C159|Zaměstnanec / Žák / Student ||
|159|D|D159|Prokázání totožnosti||
|159|E|E159|Doklad||
|159|F|F159|číselník||
|159|I|I159|employees.employee.client.proofid.type (ID 10069)||
|159|J|J159| ||
|159|L|L159|CIS Typ dokladu||
|159|Q|Q159|x||
|159|S|S159|x||
|159|T|T159|x||
|159|U|U159|x||
|159|V|V159|x||
|159|W|W159|pouze pro nerezidenty, u rezidentů je možné získat z ROBu||
|159|X|X159|Průkazem totožnosti je myšlen: průkaz o povolení k pobytu (např. zaměstnanecká karta) nebo občanský průkaz jiného členského státu EU.\nCestovním pasem je myšlen cestovní pas.\nOstatními doklady jsou myšleny: cestovní průkaz totožnosti, vízový štítek v cestovním dokladu nebo povolení k pobytu vydané jiným státem EU). ||
|160|A|A160|10070||
|160|B|B160|Číslo dokladu||
|160|C|C160|Zaměstnanec / Žák / Student ||
|160|D|D160|Prokázání totožnosti||
|160|E|E160|Doklad||
|160|F|F160|text||
|160|I|I160|employees.employee.client.proofid.num (ID 10070)||
|160|J|J160| ||
|160|Q|Q160|x||
|160|S|S160|x||
|160|T|T160|x||
|160|U|U160|x||
|160|V|V160|x||
|160|W|W160|pouze pro nerezidenty, u rezidentů je možné získat z ROBu||
|160|X|X160|Číslo dokladu prokazujícího totožnost - provazba na řádek typ dokladu (příloha č.2 VDA - mezinárodní výměna informací).||
|161|A|A161|10071||
|161|B|B161|Orgán, který vydal doklad v zahraničí||
|161|C|C161|Zaměstnanec / Žák / Student ||
|161|D|D161|Prokázání totožnosti||
|161|E|E161|Doklad||
|161|F|F161|text||
|161|I|I161|employees.employee.client.proofid.foreigninst (ID 10071)||
|161|J|J161| ||
|161|Q|Q161|x||
|161|S|S161|x||
|161|U|U161|x||
|161|V|V161|x||
|161|W|W161|pouze pro nerezidenty, u rezidentů je možné získat z ROBu||
|161|X|X161|Textová informace uvádějící název a obec orgánu, který doklad prokazující totožnost vydal ( např. Municipal office, Preston)||
|162|A|A162|10072||
|162|B|B162|Kód státu, který doklady vydal||
|162|C|C162|Zaměstnanec / Žák / Student ||
|162|D|D162|Prokázání totožnosti||
|162|E|E162|Doklad||
|162|F|F162|číselník||
|162|I|I162|employees.employee.client.proofid.stat (ID 10072)||
|162|J|J162| ||
|162|L|L162|CIS Stát||
|162|Q|Q162|x||
|162|S|S162|x||
|162|T|T162|x||
|162|U|U162|x||
|162|V|V162|x||
|162|W|W162|pouze pro nerezidenty, u rezidentů je možné získat z ROBu||
|162|X|X162|Jedná se o kód státu, který vydal doklad prokazující totožnost zaměstnance cizince, provazba na řádky typ dokladu a č. dokladu,  (příloha č.2 VDA - mezinárodní výměna informací).||
|163|A|A163|10076||
|163|B|B163|Kód adresního místa||
|163|C|C163|Zaměstnanec / Žák / Student ||
|163|D|D163|Adresa||
|163|E|E163|Trvalý pobyt||
|163|F|F163|text||
|163|I|I163|employees.employee.client.adr.ruianpoint (ID 10076)||
|163|J|J163| ||
|163|Q|Q163|x|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    Trvalá adresa se nebude vyplńovat u rezidentů, ale bude se dotahovat z ROB.|
|163|S|S163|x||
|163|T|T163|x||
|163|U|U163|x||
|163|V|V163|x||
|163|W|W163|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|164|A|A164|10077||
|164|B|B164|Ulice||
|164|C|C164|Zaměstnanec / Žák / Student ||
|164|D|D164|Adresa||
|164|E|E164|Trvalý pobyt||
|164|F|F164|text||
|164|I|I164|employees.employee.client.adr.str (ID 10077)||
|164|J|J164| ||
|164|Q|Q164|x|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    Trvalá adresa se nebude vyplńovat u rezidentů, ale bude se dotahovat z ROB.|
|164|S|S164|x||
|164|T|T164|x||
|164|U|U164|x||
|164|V|V164|x||
|164|W|W164|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|165|A|A165|10078||
|165|B|B165|Číslo popisné ||
|165|C|C165|Zaměstnanec / Žák / Student ||
|165|D|D165|Adresa||
|165|E|E165|Trvalý pobyt||
|165|F|F165|text||
|165|I|I165|employees.employee.client.adr.num (ID 10078)||
|165|J|J165| ||
|165|Q|Q165|x|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    Trvalá adresa se nebude vyplńovat u rezidentů, ale bude se dotahovat z ROB.|
|165|S|S165|x||
|165|T|T165|x||
|165|U|U165|x||
|165|V|V165|x||
|165|W|W165|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|166|A|A166|10079||
|166|B|B166|Číslo orientační||
|166|C|C166|Zaměstnanec / Žák / Student ||
|166|D|D166|Adresa||
|166|E|E166|Trvalý pobyt||
|166|F|F166|text||
|166|I|I166|employees.employee.client.adr.onum (ID 10079)||
|166|J|J166| ||
|166|Q|Q166|x|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    Trvalá adresa se nebude vyplńovat u rezidentů, ale bude se dotahovat z ROB.|
|166|S|S166|x||
|166|T|T166|x||
|166|U|U166|x||
|166|V|V166|x||
|166|W|W166|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|167|A|A167|10080||
|167|B|B167|Obec||
|167|C|C167|Zaměstnanec / Žák / Student ||
|167|D|D167|Adresa||
|167|E|E167|Trvalý pobyt||
|167|F|F167|text||
|167|I|I167|employees.employee.client.adr.cit (ID 10080)||
|167|J|J167| ||
|167|Q|Q167|x|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    Trvalá adresa se nebude vyplńovat u rezidentů, ale bude se dotahovat z ROB.|
|167|S|S167|x||
|167|T|T167|x||
|167|U|U167|x||
|167|V|V167|x||
|167|W|W167|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|168|A|A168|10082||
|168|B|B168|PSČ||
|168|C|C168|Zaměstnanec / Žák / Student ||
|168|D|D168|Adresa||
|168|E|E168|Trvalý pobyt||
|168|F|F168|text||
|168|I|I168|employees.employee.client.adr.pnu (ID 10082)||
|168|J|J168| ||
|168|Q|Q168|x|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    Trvalá adresa se nebude vyplńovat u rezidentů, ale bude se dotahovat z ROB.|
|168|S|S168|x||
|168|T|T168|x||
|168|U|U168|x||
|168|V|V168|x||
|168|W|W168|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|169|A|A169|10083||
|169|B|B169|Stát||
|169|C|C169|Zaměstnanec / Žák / Student ||
|169|D|D169|Adresa||
|169|E|E169|Trvalý pobyt||
|169|F|F169|číselník||
|169|I|I169|employees.employee.client.adr.cnt (ID 10083)||
|169|J|J169| ||
|169|L|L169|CIS Stát||
|169|Q|Q169|x|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    Trvalá adresa se nebude vyplńovat u rezidentů, ale bude se dotahovat z ROB.|
|169|S|S169|x||
|169|T|T169|x||
|169|U|U169|x||
|169|V|V169|x||
|169|W|W169|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|170|A|A170|10505||
|170|B|B170|Kód adresního místa||
|170|C|C170|Zaměstnanec / Žák / Student ||
|170|D|D170|Adresa||
|170|E|E170|Kontaktní adresa||
|170|F|F170|text||
|170|I|I170|employees.employee.client.cdr.ruianpoint (ID 10505)||
|170|J|J170| ||
|170|Q|Q170|x||
|170|S|S170|x||
|170|T|T170|x||
|170|U|U170|x||
|170|V|V170|x||
|171|A|A171|10506||
|171|B|B171|Ulice||
|171|C|C171|Zaměstnanec / Žák / Student ||
|171|D|D171|Adresa||
|171|E|E171|Kontaktní adresa||
|171|F|F171|text||
|171|I|I171|employees.employee.client.cdr.str (ID 10506)||
|171|J|J171| ||
|171|Q|Q171|x||
|171|S|S171|x||
|171|T|T171|x||
|171|U|U171|x||
|171|V|V171|x||
|172|A|A172|10507||
|172|B|B172|Číslo popisné ||
|172|C|C172|Zaměstnanec / Žák / Student ||
|172|D|D172|Adresa||
|172|E|E172|Kontaktní adresa||
|172|F|F172|text||
|172|I|I172|employees.employee.client.cdr.num (ID 10507)||
|172|J|J172| ||
|172|Q|Q172|x||
|172|S|S172|x||
|172|T|T172|x||
|172|U|U172|x||
|172|V|V172|x||
|173|A|A173|10508||
|173|B|B173|Číslo orientační||
|173|C|C173|Zaměstnanec / Žák / Student ||
|173|D|D173|Adresa||
|173|E|E173|Kontaktní adresa||
|173|F|F173|text||
|173|I|I173|employees.employee.client.cdr.onum (ID 10508)||
|173|J|J173| ||
|173|Q|Q173|x||
|173|S|S173|x||
|173|T|T173|x||
|173|U|U173|x||
|173|V|V173|x||
|174|A|A174|10509||
|174|B|B174|Obec||
|174|C|C174|Zaměstnanec / Žák / Student ||
|174|D|D174|Adresa||
|174|E|E174|Kontaktní adresa||
|174|F|F174|text||
|174|I|I174|employees.employee.client.cdr.cit (ID 10509)||
|174|J|J174| ||
|174|Q|Q174|x||
|174|S|S174|x||
|174|T|T174|x||
|174|U|U174|x||
|174|V|V174|x||
|175|A|A175|10510||
|175|B|B175|PSČ||
|175|C|C175|Zaměstnanec / Žák / Student ||
|175|D|D175|Adresa||
|175|E|E175|Kontaktní adresa||
|175|F|F175|text||
|175|I|I175|employees.employee.client.cdr.pnu (ID 10510)||
|175|J|J175| ||
|175|Q|Q175|x||
|175|S|S175|x||
|175|T|T175|x||
|175|U|U175|x||
|175|V|V175|x||
|176|A|A176|10511||
|176|B|B176|Stát||
|176|C|C176|Zaměstnanec / Žák / Student ||
|176|D|D176|Adresa||
|176|E|E176|Kontaktní adresa||
|176|F|F176|číselník||
|176|I|I176|employees.employee.client.cdr.cnt (ID 10511)||
|176|J|J176| ||
|176|L|L176|CIS Stát||
|176|Q|Q176|x||
|176|S|S176|x||
|176|T|T176|x||
|176|U|U176|x||
|176|V|V176|x||
|177|A|A177|10512||
|177|B|B177|Kód adresního místa||
|177|C|C177|Zaměstnanec / Žák / Student ||
|177|D|D177|Adresa||
|177|E|E177|Adresa v ČR, je-li trvalý pobyt mimo||
|177|F|F177|text||
|177|I|I177|employees.employee.client.fdr.ruianpoint (ID 10512)||
|177|J|J177| ||
|177|Q|Q177|x||
|177|S|S177|x||
|177|T|T177|x||
|177|U|U177|x||
|177|V|V177|x||
|178|A|A178|10513||
|178|B|B178|Ulice||
|178|C|C178|Zaměstnanec / Žák / Student ||
|178|D|D178|Adresa||
|178|E|E178|Adresa v ČR, je-li trvalý pobyt mimo||
|178|F|F178|text||
|178|I|I178|employees.employee.client.fdr.str (ID 10513)||
|178|J|J178| ||
|178|Q|Q178|x||
|178|S|S178|x||
|178|T|T178|x||
|178|U|U178|x||
|178|V|V178|x||
|179|A|A179|10514||
|179|B|B179|Číslo popisné ||
|179|C|C179|Zaměstnanec / Žák / Student ||
|179|D|D179|Adresa||
|179|E|E179|Adresa v ČR, je-li trvalý pobyt mimo||
|179|F|F179|text||
|179|I|I179|employees.employee.client.fdr.num (ID 10514)||
|179|J|J179| ||
|179|Q|Q179|x||
|179|S|S179|x||
|179|T|T179|x||
|179|U|U179|x||
|179|V|V179|x||
|180|A|A180|10515||
|180|B|B180|Číslo orientační||
|180|C|C180|Zaměstnanec / Žák / Student ||
|180|D|D180|Adresa||
|180|E|E180|Adresa v ČR, je-li trvalý pobyt mimo||
|180|F|F180|text||
|180|I|I180|employees.employee.client.fdr.onum (ID 10515)||
|180|J|J180| ||
|180|Q|Q180|x||
|180|S|S180|x||
|180|T|T180|x||
|180|U|U180|x||
|180|V|V180|x||
|181|A|A181|10516||
|181|B|B181|Obec||
|181|C|C181|Zaměstnanec / Žák / Student ||
|181|D|D181|Adresa||
|181|E|E181|Adresa v ČR, je-li trvalý pobyt mimo||
|181|F|F181|text||
|181|I|I181|employees.employee.client.fdr.cit (ID 10516)||
|181|J|J181| ||
|181|Q|Q181|x||
|181|S|S181|x||
|181|T|T181|x||
|181|U|U181|x||
|181|V|V181|x||
|182|A|A182|10517||
|182|B|B182|PSČ||
|182|C|C182|Zaměstnanec / Žák / Student ||
|182|D|D182|Adresa||
|182|E|E182|Adresa v ČR, je-li trvalý pobyt mimo||
|182|F|F182|text||
|182|I|I182|employees.employee.client.fdr.pnu (ID 10517)||
|182|J|J182| ||
|182|Q|Q182|x||
|182|S|S182|x||
|182|T|T182|x||
|182|U|U182|x||
|182|V|V182|x||
|183|A|A183|10519||
|183|B|B183|Ulice||
|183|C|C183|Zaměstnanec / Žák / Student ||
|183|D|D183|Adresa||
|183|E|E183|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|183|F|F183|text||
|183|I|I183|employees.employee.client.rdr.str (ID 10519)||
|183|J|J183| ||
|183|Q|Q183|x||
|183|T|T183|x||
|184|A|A184|10520||
|184|B|B184|Číslo popisné ||
|184|C|C184|Zaměstnanec / Žák / Student ||
|184|D|D184|Adresa||
|184|E|E184|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|184|F|F184|text||
|184|I|I184|employees.employee.client.rdr.num (ID 10520)||
|184|J|J184| ||
|184|Q|Q184|x||
|184|T|T184|x||
|185|A|A185|10521||
|185|B|B185|Číslo orientační||
|185|C|C185|Zaměstnanec / Žák / Student ||
|185|D|D185|Adresa||
|185|E|E185|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|185|F|F185|text||
|185|I|I185|employees.employee.client.rdr.onum (ID 10521)||
|185|J|J185| ||
|185|Q|Q185|x||
|185|T|T185|x||
|186|A|A186|10523||
|186|B|B186|Obec||
|186|C|C186|Zaměstnanec / Žák / Student ||
|186|D|D186|Adresa||
|186|E|E186|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|186|F|F186|text||
|186|I|I186|employees.employee.client.rdr.cit (ID 10523)||
|186|J|J186| ||
|186|Q|Q186|x||
|186|T|T186|x||
|187|A|A187|10522||
|187|B|B187|PSČ||
|187|C|C187|Zaměstnanec / Žák / Student ||
|187|D|D187|Adresa||
|187|E|E187|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|187|F|F187|text||
|187|I|I187|employees.employee.client.rdr.pnu (ID 10522)||
|187|J|J187| ||
|187|Q|Q187|x||
|187|T|T187|x||
|188|A|A188|10524||
|188|B|B188|Stát||
|188|C|C188|Zaměstnanec / Žák / Student ||
|188|D|D188|Adresa||
|188|E|E188|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|188|F|F188|číselník||
|188|I|I188|employees.employee.client.rdr.cnt (ID 10524)||
|188|J|J188| ||
|188|L|L188|CIS Stát||
|188|Q|Q188|x||
|188|T|T188|x||
|188|V|V188|x||
|189|A|A189|10086||
|189|B|B189|Zdravotní omezení přiznané od||
|189|C|C189|Zaměstnanec / Žák / Student ||
|189|D|D189|Deklarované skutečnosti ze strany zaměstnance||
|189|E|E189|Zdravotní omezení||
|189|F|F189|datum||
|189|I|I189|employees.employee.fact.healtrest.fro (ID 10086)||
|189|J|J189| ||
|189|Q|Q189|x||
|189|S|S189|x||
|189|T|T189|x||
|189|U|U189|x||
|189|V|V189|x||
|189|X|X189|Datum, kdy byl zaměstnanec orgánem sociálního zabezpečení uznán invalidní ve třetím, druhém nebo prvním stupni nebo zdravotně znevýhodněnou osobou (OZZ).||
|190|A|A190|10087||
|190|B|B190|Zdravotní omezení přiznané do||
|190|C|C190|Zaměstnanec / Žák / Student ||
|190|D|D190|Deklarované skutečnosti ze strany zaměstnance||
|190|E|E190|Zdravotní omezení||
|190|F|F190|datum||
|190|I|I190|employees.employee.fact.healtrest.to (ID 10087)||
|190|J|J190| ||
|190|Q|Q190|x||
|190|S|S190|x||
|190|T|T190|x||
|190|U|U190|x||
|190|V|V190|x||
|190|X|X190|Datum, do kterého je zaměstnanec orgánem sociálního zabezpečení uznán invalidní ve třetím, druhém nebo prvním stupni nebo zdravotně znevýhodněnou osobou (OZZ).||
|191|A|A191|10090||
|191|B|B191|Držitel karty ZTP/P||
|191|C|C191|Zaměstnanec / Žák / Student ||
|191|D|D191|Deklarované skutečnosti ze strany zaměstnance||
|191|E|E191|Příznaky||
|191|F|F191|příznak||
|191|I|I191|employees.employee.fact.ztp (ID 10090)||
|191|J|J191| ||
|191|Q|Q191|x||
|191|T|T191|x||
|191|V|V191|x||
|191|X|X191|Nárok na průkaz osoby se zdravotním postižením označený symbolem „ZTP/P“ (průkaz ZTP/P) má osoba se zvlášť těžkým funkčním postižením nebo úplným postižením pohyblivosti nebo orientace s potřebou průvodce, včetně osob s poruchou autistického spektra.||
|192|A|A192|10085||
|192|B|B192|Typ zdravotního omezení||
|192|C|C192|Zaměstnanec / Žák / Student ||
|192|D|D192|Deklarované skutečnosti ze strany zaměstnance||
|192|E|E192|Zdravotní omezení||
|192|F|F192|číselník||
|192|I|I192|employees.employee.fact.healtrest.type (ID 10085)||
|192|J|J192| ||
|192|L|L192|CIS Typ zdravotního omezení||
|192|P|P192| ||
|192|Q|Q192|x||
|192|S|S192|x||
|192|T|T192|x||
|192|U|U192|x||
|192|V|V192|x||
|192|X|X192|Přiznaný pokles pracovní schopnosti, který nastal z důvodu dlouhodobě nepříznivého zdravotního stavu, a to v rozsahu nejméně o 35 %. Podle míry poklesu pracovní schopnosti pojištěnce zákon o důchodovém pojištění rozlišuje 3 stupně invalidity. Specifickou skupinou osob se zdravotním postižením jsou osoby zdravotně znevýhodněné (OZZ), které nejsou invalidní, ale dlouhodobě nepříznivý zdravotní stav jim omezuje schopnost pracovního uplatnění.\nStatus OZZ se prokazuje buď rozhodnutím (s vyznačením nabytí právní moci), nebo potvrzením, které na žádost občana vydá příslušná OSSZ. Status OZP se prokazuje buď posudkem o invaliditě, nebo potvrzením vydaným příslušnou OSSZ. ||
|193|A|A193|10091||
|193|B|B193|Nejvyšší dosažené vzdělání podle KKOV||
|193|C|C193|Zaměstnanec / Žák / Student ||
|193|D|D193|Vzdělání||
|193|F|F193|číselník||
|193|I|I193|employees.employee.fact.highedu (ID 10091)||
|193|J|J193| ||
|193|L|L193|CIS Kategorie dosaženého vzdělání||
|193|P|P193| ||
|193|Q|Q193|x||
|193|S|S193|x||
|193|U|U193|x||
|193|V|V193|x||
|193|X|X193|Nejvyšší dosažené vzdělání - nejvyšší stupeň vzdělání dosažený v rámci formálního vzdělávání a doložený certifikátem (závěrečné vysvědčení, výuční list, maturitní vysvědčení, vysvědčení o absolutoriu a diplom absolventa vyšší odborné školy, vysokoškolský diplom, ...). Sleduje se kategorie dosaženého vzdělání podle KKOV. Viz schéma vzdělávací soustavy ČR https://www.dzs.cz/sites/default/files/2022-06/CZ_Schema_2021_22.pdf||
|194|A|A194|10092||
|194|B|B194|Specifikace||
|194|C|C194|Zaměstnanec / Žák / Student ||
|194|D|D194|Pojištění||
|194|E|E194|Cizozemský nositel pojištění||
|194|F|F194|číselník||
|194|I|I194|employees.employee.forin.cur (ID 10092)||
|194|J|J194| ||
|194|L|L194|CIS Specifikace cizozemského nositele pojištění||
|194|Q|Q194|x||
|194|S|S194|x||
|194|V|V194|x||
|194|W|W194|Pokud Druh činnosti = N, pak se v číselníku nezobrazuje hodnota N - není||
|194|X|X194|Údaje se vyplňují v případě, že zaměstnanec byl účasten sociálního (popř. zdravotního nebo úrazového) pojištění v cizině a zaměstnavatel je jeho prvním zaměstnavatelem po skončení této účasti. Pokud zaměstnanec nebyl v předchozí době účasten pojištění v cizině, údaje se nevyplňují. Údaje se uvádějí také v případě, kdy zaměstnanec přestal podléhat českým právním předpisům o sociálním (zdravotním, úrazovém) pojištění a začal podléhat cizím právním předpisům (hlášení o skončení příslušnosti k českým právním předpisům), tj. uvádějí se údaje o současném cizozemském nositeli pojištění. V nezbytných případech, kdy zaměstnanec nezná název a adresu této cizozemské pojišťovny, uvede se alespoň stát, ve kterém byl účasten pojištění, popř. lze uvést název a adresu bývalého zaměstnavatele. Pokud je uveden kterýkoli z údajů v této sekci, musí být uveden i kód státu. Název cizozemského nositele pojištění – uvádí se v nezkrácené podobě název příslušné cizozemské pojišťovny, u které byl zaměstnanec účasten pojištění v cizině. U zaměstnanců, kteří byli pojištěni na Slovensku před 1. 1. 1993, postačí uvést Slovensko - znak SK; jde-li o pojištění na Slovensku po 31. 12. 1992, je nositelem pojištění Sociálna poisťovňa. V případě hlášení změny příslušnosti k cizím právním předpisům, resp. vzniku nebo skončení příslušnosti k českým právním předpisům, musí být tento údaj povinně vyplněn. Specifikace cizozemského nositele pojištění – použije se číselník. Kód S se použije v případě oznámení skončení příslušnosti k českým právním předpisům. Kód P se použije v případě oznámení vzniku příslušnosti k českým právním předpisům. Ulice - uvádí se nezkráceně dle adresy sídla cizozemského nositele pojištění, při neexistenci ulice se tento údaj nevyplňuje. Dále se vyplňuje číslo popisné a je-li známo, pak i číslo orientační. Obec – uvádí se v nezkrácené podobě dle sídla cizozemského nositele pojištění. Post Code – uvádí se zahraniční poštovní směrovací kód. Pokud není možné směrovací kód zjistit, uvede se 99999. Stát - uvádí se dvoumístný kód státu - použije se číselník států. Při existenci předchozího nebo současného cizozemského nositele pojištění musí být údaj vždy povinně vyplněn. \nCizozemské číslo pojištění – uvádí se číslo pojištěnce přidělené cizozemským nositelem pojištění. Pokud není možné číslo pojištěnce zjistit, údaj se nevyplňuje. V případě hlášení změny příslušnosti k cizím právním předpisům, resp. skončení příslušnosti k českým právním předpisům, musí být tento údaj vyplněn.||
|195|A|A195|10093||
|195|B|B195|Název nositele||
|195|C|C195|Zaměstnanec / Žák / Student ||
|195|D|D195|Pojištění||
|195|E|E195|Cizozemský nositel pojištění||
|195|F|F195|text||
|195|I|I195|employees.employee.forin.nam (ID 10093)||
|195|J|J195| ||
|195|Q|Q195|x||
|195|S|S195|x||
|196|A|A196|10094||
|196|B|B196|Ulice||
|196|C|C196|Zaměstnanec / Žák / Student ||
|196|D|D196|Pojištění||
|196|E|E196|Cizozemský nositel pojištění||
|196|F|F196|text||
|196|I|I196|employees.employee.forin.str (ID 10094)||
|196|J|J196| ||
|196|Q|Q196|x||
|196|S|S196|x||
|197|A|A197|10095||
|197|B|B197|Číslo popisné ||
|197|C|C197|Zaměstnanec / Žák / Student ||
|197|D|D197|Pojištění||
|197|E|E197|Cizozemský nositel pojištění||
|197|F|F197|text||
|197|I|I197|employees.employee.forin.num (ID 10095)||
|197|J|J197| ||
|197|Q|Q197|x||
|197|S|S197|x||
|198|A|A198|10096||
|198|B|B198|Číslo orientační||
|198|C|C198|Zaměstnanec / Žák / Student ||
|198|D|D198|Pojištění||
|198|E|E198|Cizozemský nositel pojištění||
|198|F|F198|text||
|198|I|I198|employees.employee.forin.onum (ID 10096)||
|198|J|J198| ||
|198|Q|Q198|x||
|198|S|S198|x||
|199|A|A199|10097||
|199|B|B199|Obec||
|199|C|C199|Zaměstnanec / Žák / Student ||
|199|D|D199|Pojištění||
|199|E|E199|Cizozemský nositel pojištění||
|199|F|F199|text||
|199|I|I199|employees.employee.forin.cit (ID 10097)||
|199|J|J199| ||
|199|Q|Q199|x||
|199|S|S199|x||
|200|A|A200|10098||
|200|B|B200|PSČ||
|200|C|C200|Zaměstnanec / Žák / Student ||
|200|D|D200|Pojištění||
|200|E|E200|Cizozemský nositel pojištění||
|200|F|F200|text||
|200|I|I200|employees.employee.forin.pnu (ID 10098)||
|200|J|J200| ||
|200|Q|Q200|x||
|200|S|S200|x||
|201|A|A201|10099||
|201|B|B201|Stát||
|201|C|C201|Zaměstnanec / Žák / Student ||
|201|D|D201|Pojištění||
|201|E|E201|Cizozemský nositel pojištění||
|201|F|F201|číselník||
|201|I|I201|employees.employee.forin.cnt (ID 10099)||
|201|J|J201| ||
|201|L|L201|CIS Stát||
|201|Q|Q201|x||
|201|S|S201|x||
|201|V|V201|x||
|202|A|A202|10100||
|202|B|B202|Cizozemské číslo pojištění||
|202|C|C202|Zaměstnanec / Žák / Student ||
|202|D|D202|Pojištění||
|202|E|E202|Cizozemský nositel pojištění||
|202|F|F202|text||
|202|I|I202|employees.employee.forin.id (ID 10100)||
|202|J|J202| ||
|202|Q|Q202|x||
|202|S|S202|x||
|202|V|V202|x||
|203|A|A203|10101||
|203|B|B203|Sektor (účel pojištění)||
|203|C|C203|Zaměstnanec / Žák / Student ||
|203|D|D203|Pojištění||
|203|E|E203|Cizozemský nositel pojištění||
|203|F|F203|číselník||
|203|I|I203|employees.employee.forin.sec (ID 10101)||
|203|J|J203| ||
|203|L|L203|CIS Sektor||
|203|Q|Q203|x||
|203|S|S203|x||
|203|V|V203|x||
|203|X|X203|Elektronická výměna informací o sociálním zabezpečení (EESSI) je elektronický systém pro výměnu informací v oblasti sociálního zabezpečení migrujúcích pracovníků. Údaj slouží pro snadnou komunikaci v rámci členských států. ||
|204|A|A204|10102||
|204|B|B204|Kód zdravotní pojišťovny||
|204|C|C204|Zaměstnanec / Žák / Student ||
|204|D|D204|Pojištění||
|204|E|E204|Zdravotní a nemocenské pojištění||
|204|F|F204|číselník||
|204|I|I204|employees.employee.insh.cnr (ID 10102)||
|204|J|J204| ||
|204|L|L204|CIS Zdravotní pojišťovny||
|204|Q|Q204|x||
|204|S|S204|x||
|204|U|U204|x||
|204|V|V204|x||
|204|X|X204|Uvede se trojmístný kód zdravotní pojišťovny v ČR, u které je zaměstnanec v době podání registrace zaměstnance s akcí 1 registrován. Použije se číselník ČSSZ – CIS – Zdravotní pojišťovny.\nUpozornění: Došlo k rozšíření číselníku C_ZPOJ (zdravotních pojišťoven) o novou hodnotu 999 (“Ostatní”), která se použije například v těchto případech:\n• Zaměstnanec (cizinec) je pojištěn u komerční pojišťovny (zaměstnanec nemá na území ČR trvalý pobyt a současně je zaměstnán u zaměstnavatele se sídlem mimo ČR);\n• Cizinec bez trvalého pobytu na území ČR pracující u zaměstnavatele se sídlem v ČR na DPP bez účasti na pojištění, který není povinně účasten veřejného zdravotního pojištění.||
|205|A|A205|10104||
|205|B|B205|Název předchozího orgánu, který prováděl nemocenské pojištění||
|205|C|C205|Zaměstnanec / Žák / Student ||
|205|D|D205|Pojištění||
|205|E|E205|Zdravotní a nemocenské pojištění||
|205|F|F205|text||
|205|I|I205|employees.employee.insp.nam (ID 10104)||
|205|J|J205| ||
|205|Q|Q205|x||
|205|S|S205|x||
|205|V|V205|x||
|205|X|X205|Plný název orgánu, jiného než ČSSZ, u kterého byl zaměstnanec v ČR registrován a který prováděl jeho nemocenské pojištění (např. MO, MV), před jeho registrací u ČSSZ. Pokud pojištění jiný orgán než ČSSZ neprováděl, údaj se nevyplňuje.||
|206|A|A206|10103||
|206|B|B206|Název současného orgánu, který provádí nemocenské pojištění||
|206|C|C206|Zaměstnanec / Žák / Student ||
|206|D|D206|Pojištění||
|206|E|E206|Zdravotní a nemocenské pojištění||
|206|F|F206|text||
|206|I|I206|employees.employee.inso.nam (ID 10103)||
|206|J|J206| ||
|206|Q|Q206|x||
|206|S|S206|x||
|206|V|V206|x||
|206|X|X206|Název orgánu, jiného než ČSSZ, který v době podání oznámení současně provádí v ČR nemocenské pojištění zaměstnance (např. MO, MV). Pokud jiný orgán současně nemocenské pojištění zaměstnance v ČR neprovádí, údaj se nevyplňuje||
|207|A|A207|10414||
|207|B|B207|Volný přístup na trh práce||
|207|C|C207|Zaměstnanec / Žák / Student ||
|207|D|D207|Zaměstnanec bez státního občanství ČR||
|207|F|F207|příznak||
|207|I|I207|employees.employee.nocitizen.freeacc (ID 10414)||
|207|J|J207| ||
|207|Q|Q207|x||
|207|U|U207|x||
|207|V|V207|x||
|207|X|X207|Stav, kdy cizinec nepotřebuje pro výkon práce na území ČR některý z druhů pracovního oprávnění (zaměstnanecká karta / modrá karta / karta vnitropodnikově převedeného zaměstnance / povolení k zaměstnání); odvíjí se od statusu cizince: občané EU/EHP a Švýcarska a jejich rodinní příslušníci (včetně rodinných příslušníků občanů ČR) a cizinci uvedení v § 98 zákona o zaměstnanosti (s výjimkou písm. f) - i) a k)) mají volný přístup na trh práce; jedná se o výběrovou podmínku (tj. zaměstnavatel vybere buď 101 nebo 102); !!! NUTNÉ doplnit rozdělení statusů (viz výše: EU občan / rodinný příslušník / cizinec podle § 98 písm. a) - atd.) !!!||
|208|A|A208|10105||
|208|B|B208|Důvod pro volný přístup na trh práce||
|208|C|C208|Zaměstnanec / Žák / Student ||
|208|D|D208|Zaměstnanec bez státního občanství ČR||
|208|F|F208|číselník||
|208|I|I208|employees.employee.nocitizen.perm (ID 10105)||
|208|J|J208| ||
|208|L|L208|CIS Důvod pro volný přístup na trh práce||
|208|Q|Q208|x||
|208|U|U208|x||
|208|V|V208|x||
|208|X|X208|Stav, kdy cizinec potřebuje pro výkon práce na území ČR některý z druhů pracovního oprávnění (zaměstnanecká karta / modrá karta / karta vnitropodnikově převedeného zaměstnance / povolení k zaměstnání); jedná se o výběrovou podmínku (buď 101 nebo 102)||
|209|A|A209|10106||
|209|B|B209|Druh pracovního oprávnění||
|209|C|C209|Zaměstnanec / Žák / Student ||
|209|D|D209|Zaměstnanec bez státního občanství ČR||
|209|F|F209|číselník||
|209|I|I209|employees.employee.nocitizen.permtype (ID 10106)||
|209|J|J209| ||
|209|L|L209|CIS Druh pracovního oprávnění||
|209|P|P209| ||
|209|Q|Q209|x||
|209|U|U209|x||
|209|V|V209|x||
|209|X|X209|Druh pracovního oprávnění na základě kterého bude cizinec pracovat v ČR. Jedná se o jeden z následujících 4 typů pracovního oprávnění - Zaměstnanecká karta, Povolení k zaměstnání, Modrá karta, Karta vnitropodnikově převedeného zaměstnance.||
|210|A|A210|10107||
|210|B|B210|Vydala Krajská pobočka ÚP ČR||
|210|C|C210|Zaměstnanec / Žák / Student ||
|210|D|D210|Zaměstnanec bez státního občanství ČR||
|210|F|F210|číselník||
|210|I|I210|employees.employee.nocitizen.issue (ID 10107)||
|210|J|J210| ||
|210|L|L210|CIS Krajské pobočky ÚP ČR||
|210|Q|Q210|x||
|210|U|U210|x||
|210|V|V210|x||
|210|X|X210|Krajská pobočka ÚP ČR, která vydala Povolení k zaměstnání (zobrazit tedy jen při výběru druhu pracovního oprávnění Povolení k zaměstnání). Uvádí se hodnota z číselníku 14 krajských poboček ÚP.||
|211|A|A211|10108||
|211|B|B211|Identifikátor pracovního oprávnění||
|211|C|C211|Zaměstnanec / Žák / Student ||
|211|D|D211|Zaměstnanec bez státního občanství ČR||
|211|F|F211|text||
|211|I|I211|employees.employee.nocitizen.permid (ID 10108)||
|211|J|J211| ||
|211|Q|Q211|x||
|211|U|U211|x||
|211|V|V211|x||
|211|X|X211|Jednoznačný identifikátor předmětného pracovního oprávnění uvedeného v řádku 103. Jedná se o číslo pracovního oprávnění druhu uvedeného v řádku 103 (Zaměstnanecká karta, Povolení k zaměstnání, Modrá karta, Karta vnitropodnikově převedeného zaměstnance).||
|212|A|A212|10109||
|212|B|B212|Trvání oprávnění od||
|212|C|C212|Zaměstnanec / Žák / Student ||
|212|D|D212|Zaměstnanec bez státního občanství ČR||
|212|E|E212|Doba oprávnění||
|212|F|F212|datum||
|212|I|I212|employees.employee.nocitizen.permfro (ID 10109)||
|212|J|J212| ||
|212|Q|Q212|x||
|212|U|U212|x||
|212|V|V212|x||
|212|X|X212|Datum vydání pracovního oprávnění.||
|213|A|A213|10110||
|213|B|B213|Trvání oprávnění do||
|213|C|C213|Zaměstnanec / Žák / Student ||
|213|D|D213|Zaměstnanec bez státního občanství ČR||
|213|E|E213|Doba oprávnění||
|213|F|F213|datum||
|213|I|I213|employees.employee.nocitizen.permto (ID 10110)||
|213|J|J213| ||
|213|Q|Q213|x||
|213|U|U213|x||
|213|V|V213|x||
|213|X|X213|Datum konce platnosti pracovního oprávnění.||
|214|A|A214|10427||
|214|B|B214|Příslušnost k cizím právním předpisům||
|214|C|C214|Zaměstnanec / Žák / Student ||
|214|D|D214|Příslušnost k cizím právním předpisům||
|214|F|F214|příznak||
|214|I|I214|employees.employee.forinreg.juris (ID 10427)||
|214|J|J214| ||
|214|Q|Q214|x||
|214|S|S214|x||
|214|V|V214|x||
|214|X|X214|Zaměstnanec podléhá právním předpisům sociálního zabezpečení jiného státu||
|215|A|A215|10428||
|215|B|B215|Kód státu||
|215|C|C215|Zaměstnanec / Žák / Student ||
|215|D|D215|Příslušnost k cizím právním předpisům||
|215|F|F215|číselník||
|215|I|I215|employees.employee.forinreg.state (ID 10428)||
|215|J|J215| ||
|215|L|L215|CIS Stát||
|215|Q|Q215|x||
|215|S|S215|x||
|215|V|V215|x||
|215|X|X215|Kód státu ke kterému se příslušnost vztahuje - viz číselník.||
|216|A|A216|10113||
|216|B|B216|Druh důchodu||
|216|C|C216|Zaměstnanec / Žák / Student ||
|216|D|D216|Důchod||
|216|E|E216|Vyplácený jiným (i zahraničním) nositelem pojištění||
|216|F|F216|číselník||
|216|I|I216|employees.employee.pens.typ (ID 10113)||
|216|J|J216| ||
|216|L|L216|CIS Druh důchodu||
|216|Q|Q216|x||
|216|S|S216|x||
|216|U|U216|x||
|216|V|V216|x||
|216|W|W216|1 - N typů důchodu podle číselníku||
|216|X|X216|Uvádějí se důchody vyplácené jiným (i zahraničním) nositelem pojištění. Důchody vyplácené ČSSZ se neuvádějí.\nDůchody dle definovaného číselníku ČSSZ.\n1 – starobní\n2 – invalidní 3. stupně\n8 – invalidní 1. nebo 2. stupně\nA – cizí charakteru starobního\nB – cizí charakteru invalidního 3. stupně\nC – cizí charakteru invalidního 1. nebo 2. stupně||
|217|A|A217|10114||
|217|B|B217|Pobírán od||
|217|C|C217|Zaměstnanec / Žák / Student ||
|217|D|D217|Důchod||
|217|E|E217|Vyplácený jiným (i zahraničním) nositelem pojištění||
|217|F|F217|datum||
|217|I|I217|employees.employee.pens.tak (ID 10114)||
|217|J|J217| ||
|217|Q|Q217|x||
|217|S|S217|x||
|217|V|V217|x||
|217|W|W217|1 - N typů důchodu podle číselníku||
|217|X|X217|Datum přiznání důchodu vypláceného jiným (i zahraničním) nositelem pojištění.||
|218|A|A218|10115||
|218|B|B218|Poživatel předčasného starobního důchodu||
|218|C|C218|Zaměstnanec / Žák / Student ||
|218|D|D218|Důchod||
|218|E|E218|Starobní||
|218|F|F218|příznak||
|218|I|I218|employees.employee.pens.early (ID 10115)||
|218|J|J218| ||
|218|Q|Q218|x||
|218|S|S218|x||
|218|U|U218|x||
|218|V|V218|x||
|218|X|X218|Zaměstnanci byl před dosažením důchodového věku přiznán tzv. předčasný starobní důchod.||
|219|A|A219|10504||
|219|B|B219|Poživatel starobního důchodu se sníženým důchodovým věkem ||
|219|C|C219|Zaměstnanec / Žák / Student ||
|219|D|D219|Důchod||
|219|E|E219|Starobní||
|219|F|F219|příznak||
|219|I|I219|employees.employee.pens.reducedAge (ID 10504)||
|219|J|J219| ||
|219|Q|Q219|x||
|219|S|S219|x||
|219|V|V219|x||
|220|A|A220|10117||
|220|B|B220|Přihlášení dne||
|220|C|C220|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|220|F|F220|datum||
|220|P|P220|x||
|220|S|S220|x||
|220|T|T220|x||
|220|U|U220|x||
|220|V|V220|x||
|220|X|X220|Do 8 kalendářních dnů od nástupu do zaměstnání prvního zaměstnance, který je účasten nemocenského pojištění či prvního zaměstnance na DPP.||
|221|A|A221|10118||
|221|B|B221|Typ přihlášky||
|221|C|C221|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|221|F|F221|číselník||
|221|L|L221|CIS Typ přihlášky||
|221|P|P221|x||
|221|S|S221|x||
|221|T|T221|x||
|221|U|U221|x||
|221|V|V221|x||
|221|X|X221|Přihláška je podávána za zaměstnavatele či mzdovu účtárnu. Pokud zaměstnavatel má více mzdových účtáren, popř. jednu mzdovou účtárnu, jejíž adresa není shodná se sídlem zaměstnavatele, je povinen přihlásit všechny své mzdové účtárny s uvedením jejich adresy a osob, které jsou za ně oprávněny jednat jménem zaměstnavatele. \nMzdovou účtárnou se rozumí útvar zaměstnavatele, ve kterém je vedena evidence mezd nebo platů zaměstnanců; je-li zaměstnavatelem stát, rozumí se mzdovou účtárnou útvar příslušné organizační složky státu, ve kterém je vedena evidence platů.||
|222|A|A222|10119||
|222|B|B222|Typ zaměstnavatele||
|222|C|C222|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|222|D|D222|Identifikace||
|222|F|F222|číselník||
|222|L|L222|CIS Typ zaměstnavatele||
|222|P|P222|x||
|222|S|S222|x||
|222|T|T222|x||
|222|U|U222|x||
|222|V|V222|x||
|222|X|X222|Zaměstnavatel je fyzická nepodnikající, fyzická podnikající nebo právnická osoba, která zaměstnává jiné fyzické osoby.||
|223|A|A223|10120||
|223|B|B223|Název zaměstnavatele||
|223|C|C223|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|223|D|D223|Identifikace||
|223|F|F223|text||
|223|I|I223|employees.employee.comp.nam (ID 10120)||
|223|J|J223| ||
|223|P|P223|x||
|223|Q|Q223|x||
|223|S|S223|x||
|223|T|T223|x||
|223|U|U223|x||
|223|V|V223|x||
|223|W|W223|V rámci REGZEC na ePortalu by se needitovatelně předvyplňoval, u API by pak bylo nutné jej posílat||
|223|X|X223|Celý název, pod kterým je zaměstnavatel zapsán v obchodním, živnostenském nebo jiném rejstříku.||
|224|A|A224|10121||
|224|B|B224|Identifikační číslo (IČO, IČ)||
|224|C|C224|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|224|D|D224|Identifikace||
|224|F|F224|text||
|224|P|P224|x||
|224|S|S224|x||
|224|T|T224|x||
|224|U|U224|x||
|224|V|V224|x||
|224|X|X224|Identifikační číslo osoby přidělené zaměstnavateli při registraci v obchodním, živnostenském nebo jiném rejstříku, resp. v ROS. IČO se uvede včetně úvodních nul. ||
|225|A|A225|10122||
|225|B|B225|Individuální číslo||
|225|C|C225|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|225|D|D225|Identifikace||
|225|F|F225|text||
|225|P|P225|x||
|225|S|S225|x||
|225|T|T225|x||
|225|U|U225|x||
|225|V|V225|x||
|225|X|X225|Individuální (identifikační) číslo přidělené zaměstnavateli - zahraničnímu subjektu v cizině. U subjektu, který nemá IČ přiděleno, se údaj nevyplňuje. ||
|226|A|A226|10123||
|226|B|B226|VČP||
|226|C|C226|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|226|D|D226|Identifikace||
|226|F|F226|číslo||
|226|G|G226|celé číslo||
|226|P|P226|x||
|226|T|T226|x||
|226|V|V226|x||
|226|X|X226|Vlastní číslo plátce (VČP), které správce daně přiděluje v případě, že subjekt nemá DIČ / RČ / IČO  (zahraniční osoby). ||
|227|A|A227|10124||
|227|B|B227|Stát, který IČ vydal||
|227|C|C227|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|227|D|D227|Identifikace||
|227|F|F227|číselník||
|227|L|L227|CIS Stát||
|227|P|P227|x||
|227|S|S227|x||
|227|T|T227|x||
|227|U|U227|x||
|227|V|V227|x||
|227|X|X227|Relevantní pro zahraniční subjekty - kód státu, který individuální číslo vydal.||
|228|A|A228|10125||
|228|B|B228|Rodné číslo||
|228|C|C228|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|228|D|D228|Identifikace||
|228|F|F228|text||
|228|P|P228|x||
|228|S|S228|x||
|228|T|T228|x||
|228|U|U228|x||
|228|V|V228|x||
|228|X|X228|Devítimístný nebo desetimístný číselný znak bez mezer (u občanů narozených po 31. 12. 1953 je rodné číslo desetimístné). U devítimístného rodného čísla je při elektronickém vyplňování třeba uvést skutečně 9 znaků (nesmí být proveden zápis mezery na desátém místě). Rodné číslo je nezastupitelným identifikačním údajem, který je třeba vyplňovat vždy i u cizích státních příslušníků. V případě, že cizí státní příslušník nemá při oznámení o nástupu dosud rodné číslo (RČ) ani evidenční číslo pojištěnce (EČP) přiděleno, tento údaj se na tiskopisu nevyplňuje. Po přidělení rodného čísla příslušnou institucí se rodné číslo pojištěnce nahlásí příslušné OSSZ. Rodné číslo je základním identifikátorem pojištěnce, proto je nutné dbát zvýšené pozornosti při vyplňování tohoto údaje, popř. jeho ověření. U cizích státních příslušníků nelze do pole „Rodné číslo“ uvádět jiné druhy identifikátorů (např. identifikátor VZP apod.). Upozornění: Občané Slovenské republiky, jimž bylo rodné číslo přiděleno po 31. 12. 1992, jsou taktéž považováni za cizince a toto „slovenské“ rodné číslo tak nelze pro účely vyplňování tiskopisů použít. V případě, že není RČ, přidělí správce agendy EČP (evidenční číslo pojištěnce).||
|229|A|A229|10126||
|229|B|B229|EČP||
|229|C|C229|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|229|D|D229|Identifikace||
|229|F|F229|text||
|229|P|P229|x||
|229|S|S229|x||
|229|T|T229|x||
|229|U|U229|x||
|229|V|V229|x||
|229|X|X229|Evidenční číslo pojištěnce (EČP) je interní identifikátor osoby, která nemá přidělené rodné číslo (cizinci). EČP přiděluje ČSSZ. Devítimístný nebo desetimístný číselný znak bez mezer (u občanů narozených po 31. 12. 1953 je EČP desetimístné). U devítimístného EČP je při elektronickém vyplňování třeba uvést skutečně 9 znaků (nesmí být proveden zápis mezery na desátém místě). EČP je nezastupitelným identifikačním údajem, který je třeba vyplňovat, nebylo-li osobě dosud přiděleno rodné číslo. Pokud bylo následně přiděleno rodné číslo, EČP se již neuvádí. V případě, že cizí státní příslušník nemá dosud rodné číslo (RČ) ani evidenční číslo pojištěnce (EČP) přiděleno, tento údaj se na tiskopisu nevyplňuje.  EČP je základním identifikátorem pojištěnce, proto je nutné dbát zvýšené pozornosti při vyplňování tohoto údaje, popř. jeho ověření. U cizích státních příslušníků nelze do pole „EČP“ uvádět jiné druhy identifikátorů (např. identifikátor VZP apod.). Upozornění: Občané Slovenské republiky, jimž bylo rodné číslo přiděleno po 31. 12. 1992, jsou taktéž považováni za cizince a toto „slovenské“ rodné číslo tak nelze pro účely vyplňování tiskopisů použít. V případě, že není RČ, přidělí správce agendy EČP (evidenční číslo pojištěnce).||
|230|A|A230|10127||
|230|B|B230|Počet zaměstnanců||
|230|C|C230|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|230|D|D230|Atributy subjektu||
|230|F|F230|číslo||
|230|G|G230|celé číslo||
|230|P|P230|x||
|230|S|S230|x||
|230|T|T230|x||
|230|U|U230|x||
|230|V|V230|x||
|230|X|X230|Počet zaměstnanců, pro které účtárna vede evidenci mezd ke dni jejího přihlášení.||
|231|A|A231|10128||
|231|B|B231|Předchozí registrace u OSSZ/PSSZ/MSSZ Brno||
|231|C|C231|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|231|D|D231|Kódy SSZ||
|231|F|F231|číselník||
|231|L|L231|CIS Okresy||
|231|P|P231|x||
|231|S|S231|x||
|231|X|X231|Zaměstnavatel, který byl v minulosti veden v evidenci některé z OSSZ/PSSZ/MSSZ Brno a po odhlášení z této evidence znovu začal zaměstnávat zaměstnance, kteří jsou účastni nemocenského pojištění nebo zaměstnance činné na základě dohody o provedení práce, nejsou-li účastni pojištění. Předchozí registrace zaměstnavatele u OSSZ/PSSZ/MSSZ Brno je uvedena dle organizačních jednotek ČSSZ.||
|232|A|A232|10129||
|232|B|B232|Kód adresního místa||
|232|C|C232|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|232|D|D232|Adresa||
|232|F|F232|text||
|232|P|P232|x||
|232|S|S232|x||
|232|T|T232|x||
|232|U|U232|x||
|232|V|V232|x||
|232|W|W232|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|232|X|X232|Kód adresního místa dle RÚIAN, neboli Registru územní identifikace, adres a nemovitostí.||
|233|A|A233|10130||
|233|B|B233|Ulice||
|233|C|C233|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|233|D|D233|Adresa||
|233|F|F233|text||
|233|P|P233|x||
|233|S|S233|x||
|233|T|T233|x||
|233|U|U233|x||
|233|V|V233|x||
|233|W|W233|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|234|A|A234|10131||
|234|B|B234|Číslo popisné ||
|234|C|C234|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|234|D|D234|Adresa||
|234|F|F234|text||
|234|P|P234|x||
|234|S|S234|x||
|234|T|T234|x||
|234|U|U234|x||
|234|V|V234|x||
|234|W|W234|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|235|A|A235|10132||
|235|B|B235|Číslo orientační||
|235|C|C235|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|235|D|D235|Adresa||
|235|F|F235|text||
|235|P|P235|x||
|235|S|S235|x||
|235|T|T235|x||
|235|U|U235|x||
|235|V|V235|x||
|235|W|W235|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|236|A|A236|10133||
|236|B|B236|Obec||
|236|C|C236|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|236|D|D236|Adresa||
|236|F|F236|text||
|236|P|P236|x||
|236|S|S236|x||
|236|T|T236|x||
|236|U|U236|x||
|236|V|V236|x||
|236|W|W236|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|237|A|A237|10135||
|237|B|B237|PSČ||
|237|C|C237|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|237|D|D237|Adresa||
|237|F|F237|text||
|237|P|P237|x||
|237|S|S237|x||
|237|T|T237|x||
|237|U|U237|x||
|237|V|V237|x||
|237|W|W237|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|238|A|A238|10136||
|238|B|B238|Stát||
|238|C|C238|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|238|D|D238|Adresa||
|238|F|F238|číselník||
|238|L|L238|CIS Stát||
|238|P|P238|x||
|238|S|S238|x||
|238|T|T238|x||
|238|U|U238|x||
|238|V|V238|x||
|238|W|W238|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|239|A|A239|10137||
|239|B|B239|Email||
|239|C|C239|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|239|D|D239|Kontakty||
|239|F|F239|text||
|239|P|P239|x||
|239|S|S239|x||
|239|T|T239|x||
|239|U|U239|x||
|239|V|V239|x||
|240|A|A240|10138||
|240|B|B240|Telefon||
|240|C|C240|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|240|D|D240|Kontakty||
|240|F|F240|text||
|240|P|P240|x||
|240|S|S240|x||
|240|T|T240|x||
|240|U|U240|x||
|240|V|V240|x||
|241|A|A241|10139||
|241|B|B241|ID datové schránky||
|241|C|C241|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|241|D|D241|Kontakty||
|241|F|F241|text||
|241|P|P241|x||
|241|S|S241|x||
|241|T|T241|x||
|241|U|U241|x||
|241|V|V241|x||
|242|A|A242|10140||
|242|B|B242|ID datové schránky pro notifikace zpracování||
|242|C|C242|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|242|D|D242|Kontakty||
|242|F|F242|text||
|242|P|P242|x||
|242|S|S242|x||
|243|A|A243|10141||
|243|B|B243|Fax||
|243|C|C243|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|243|D|D243|Kontakty||
|243|F|F243|text||
|243|P|P243|x||
|243|S|S243|x||
|244|A|A244|10143||
|244|B|B244|Název původního zaměstnavatele||
|244|C|C244|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|244|D|D244|Vznik||
|244|E|E244|Právní nástupnictví||
|244|F|F244|text||
|244|P|P244|x||
|244|S|S244|x||
|244|T|T244|x||
|244|U|U244|x||
|244|V|V244|x||
|244|W|W244|Zůstane zachován princip ze současné Přihlášky do registru zaměstnavatelů, kde se data na formuláři sbírají, ale slouží pouze pro informaci zpracovatelům, nikde se dále neukládají a nezpracovávají.||
|244|X|X244|Celý název, pod kterým je zaměstnavatel zapsán v obchodním, živnostenském nebo jiném rejstříku, a obec sídla. Pokud je zaměstnavatelem fyzická osoba, uvádí se jméno a příjmení fyzické osoby a obec sídla, tj. obec, ve které má trvalý pobyt (bydliště), a to i v případě zaměstnavatele registrovaného v zahraničí.||
|245|A|A245|10144||
|245|B|B245|IČ (popř. individuální číslo původního zaměstnavatele)||
|245|C|C245|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|245|D|D245|Vznik||
|245|E|E245|Právní nástupnictví||
|245|F|F245|text||
|245|P|P245|x||
|245|S|S245|x||
|245|T|T245|x||
|245|U|U245|x||
|245|V|V245|x||
|245|X|X245|Identifikační číslo osoby přidělené zaměstnavateli při registraci v obchodním, živnostenském nebo jiném rejstříku, resp. v ROS. IČO se uvede včetně úvodních nul, popř. individuální (identifikační) číslo přidělené zaměstnavateli - zahraničnímu subjektu. U subjektu, který nemá IČ přiděleno, se údaj nevyplňuje. ||
|246|A|A246|10145||
|246|B|B246|Rodné číslo původního zaměstnavatele||
|246|C|C246|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|246|D|D246|Vznik||
|246|E|E246|Právní nástupnictví||
|246|F|F246|text||
|246|P|P246|x||
|246|S|S246|x||
|246|T|T246|x||
|246|U|U246|x||
|246|V|V246|x||
|246|X|X246|Devítimístný nebo desetimístný číselný znak bez mezer (u občanů narozených po 31. 12. 1953 je rodné číslo desetimístné). U devítimístného rodného čísla je při elektronickém vyplňování třeba uvést skutečně 9 znaků (nesmí být proveden zápis mezery na desátém místě).||
|247|A|A247|10146||
|247|B|B247|EČP původního zaměstnavatele||
|247|C|C247|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|247|D|D247|Vznik||
|247|E|E247|Právní nástupnictví||
|247|F|F247|text||
|247|P|P247|x||
|247|S|S247|x||
|247|T|T247|x||
|247|V|V247|x||
|247|X|X247|V případě, že zaměstnavatel nemá RČ, přidělí správce agendy EČP (evidenční číslo pojištěnce). Pokud cizí státní příslušník nemá při oznámení o nástupu  rodné číslo (RČ) ani evidenční číslo pojištěnce (EČP) přiděleno, tento údaj se na tiskopisu nevyplňuje.  ||
|248|A|A248|10458||
|248|B|B248|VČP původního zaměstnavatele||
|248|C|C248|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|248|D|D248|Vznik||
|248|E|E248|Právní nástupnictví||
|248|F|F248|text||
|248|P|P248|x||
|248|T|T248|x||
|248|V|V248|x||
|248|X|X248|Vlastní číslo plátce (VČP), které správce daně přiděluje v případě, že subjekt nemá DIČ / RČ / IČO  (zahraniční osoby). ||
|249|A|A249|10147||
|249|B|B249|Variabilní symbol původního zaměstnavatele||
|249|C|C249|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|249|D|D249|Vznik||
|249|E|E249|Právní nástupnictví||
|249|F|F249|text||
|249|P|P249|x||
|249|S|S249|x||
|249|T|T249|x||
|249|V|V249|x||
|249|X|X249|Variabilní symbol přidělený zaměstnavateli (mzdové účtárně) jako plátci pojistného OSSZ.||
|250|A|A250|10148||
|250|B|B250|Typ odhlášky||
|250|C|C250|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|250|D|D250|Odhlášení z registru||
|250|F|F250|číselník||
|250|L|L250|CIS Typ odhlášky||
|250|P|P250|x||
|250|S|S250|x||
|250|T|T250|x||
|250|U|U250|x||
|250|V|V250|x||
|250|X|X250|Odhláška je podávána za zaměstnavatele či mzdovu účtárnu.||
|251|A|A251|10149||
|251|B|B251|Datum zániku zaměstnavatele / zrušení mzdové účtárny||
|251|C|C251|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|251|D|D251|Odhlášení z registru||
|251|F|F251|datum||
|251|P|P251|x||
|251|S|S251|x||
|251|T|T251|x||
|251|U|U251|x||
|251|V|V251|x||
|251|X|X251|Datum zániku, zrušení.||
|252|A|A252|10150||
|252|B|B252|Název||
|252|C|C252|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|252|D|D252|Archivace dokladů||
|252|F|F252|text||
|252|P|P252|x||
|252|S|S252|x||
|252|U|U252|x||
|252|V|V252|x||
|252|X|X252|Celý název, pod kterým je zaměstnavatel zapsán v obchodním, živnostenském nebo jiném rejstříku, a obec sídla. Pokud je zaměstnavatelem fyzická osoba, uvádí se jméno a příjmení fyzické osoby a obec sídla, tj. obec, ve které má trvalý pobyt (bydliště), a to i v případě zaměstnavatele registrovaného v zahraničí.||
|253|A|A253|10151||
|253|B|B253|Kód adresního místa||
|253|C|C253|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|253|D|D253|Archivace dokladů||
|253|E|E253|Adresa||
|253|F|F253|text||
|253|P|P253|x||
|253|S|S253|x||
|253|U|U253|x||
|253|V|V253|x||
|253|W|W253|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|253|X|X253|Kód adresního místa dle RÚIAN, neboli Registru územní identifikace, adres a nemovitostí.||
|254|A|A254|10152||
|254|B|B254|Ulice ||
|254|C|C254|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|254|D|D254|Archivace dokladů||
|254|E|E254|Adresa||
|254|F|F254|text||
|254|P|P254|x||
|254|S|S254|x||
|254|U|U254|x||
|254|V|V254|x||
|254|W|W254|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|255|A|A255|10153||
|255|B|B255|Číslo popisné ||
|255|C|C255|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|255|D|D255|Archivace dokladů||
|255|E|E255|Adresa||
|255|F|F255|text||
|255|P|P255|x||
|255|S|S255|x||
|255|U|U255|x||
|255|V|V255|x||
|255|W|W255|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|256|A|A256|10154||
|256|B|B256|Číslo orientační||
|256|C|C256|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|256|D|D256|Archivace dokladů||
|256|E|E256|Adresa||
|256|F|F256|text||
|256|P|P256|x||
|256|S|S256|x||
|256|U|U256|x||
|256|V|V256|x||
|256|W|W256|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|257|A|A257|10155||
|257|B|B257|Obec||
|257|C|C257|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|257|D|D257|Archivace dokladů||
|257|E|E257|Adresa||
|257|F|F257|text||
|257|P|P257|x||
|257|S|S257|x||
|257|U|U257|x||
|257|V|V257|x||
|257|W|W257|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|258|A|A258|10157||
|258|B|B258|PSČ||
|258|C|C258|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|258|D|D258|Archivace dokladů||
|258|E|E258|Adresa||
|258|F|F258|text||
|258|P|P258|x||
|258|S|S258|x||
|258|U|U258|x||
|258|V|V258|x||
|258|W|W258|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|259|A|A259|10158||
|259|B|B259|Stát||
|259|C|C259|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|259|D|D259|Archivace dokladů||
|259|E|E259|Adresa||
|259|F|F259|číselník||
|259|L|L259|CIS Stát||
|259|P|P259|x||
|259|S|S259|x||
|259|U|U259|x||
|259|V|V259|x||
|259|W|W259|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|260|A|A260|10159||
|260|B|B260|Název právního nástupce||
|260|C|C260|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|260|D|D260|Právní nástupnictví při zániku||
|260|F|F260|text||
|260|H|H260|1-N||
|260|P|P260|x||
|260|S|S260|x||
|260|U|U260|x||
|260|V|V260|x||
|260|W|W260|1 - N subjektů právního nástupnictví||
|260|X|X260|Celý název, pod kterým je zaměstnavatel zapsán v obchodním, živnostenském nebo jiném rejstříku, a obec sídla. Pokud je zaměstnavatelem fyzická osoba, uvádí se jméno a příjmení fyzické osoby a obec sídla, tj. obec, ve které má trvalý pobyt (bydliště), a to i v případě zaměstnavatele registrovaného v zahraničí.||
|261|A|A261|10160||
|261|B|B261|Variabilní symbol||
|261|C|C261|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|261|D|D261|Právní nástupnictví při zániku||
|261|F|F261|text||
|261|H|H261|1-N||
|261|P|P261|x||
|261|S|S261|x||
|261|V|V261|x||
|261|W|W261|1 - N subjektů právního nástupnictví||
|261|X|X261|Variabilní symbol přidělený zaměstnavateli (mzdové účtárně) jako plátci pojistného OSSZ.||
|262|A|A262|10161||
|262|B|B262|Identifikační číslo (IČO, IČ)||
|262|C|C262|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|262|D|D262|Právní nástupnictví při zániku||
|262|F|F262|text||
|262|H|H262|1-N||
|262|P|P262|x||
|262|S|S262|x||
|262|U|U262|x||
|262|V|V262|x||
|262|W|W262|1 - N subjektů právního nástupnictví||
|262|X|X262|Identifikační číslo osoby přidělené zaměstnavateli při registraci v obchodním, živnostenském nebo jiném rejstříku, resp. v ROS. IČO se uvede včetně úvodních nul.  ||
|263|A|A263|10162||
|263|B|B263|Individuální číslo||
|263|C|C263|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|263|D|D263|Právní nástupnictví při zániku||
|263|F|F263|text||
|263|H|H263|1-N||
|263|P|P263|x||
|263|S|S263|x||
|263|V|V263|x||
|263|W|W263|1 - N subjektů právního nástupnictví||
|263|X|X263|Individuální (identifikační) číslo přidělené zaměstnavateli - zahraničnímu subjektu, popř. Individuální číslo přidělené zaměstnavateli - zahraničnímu subjektu. U subjektu, který nemá IČ přiděleno, se údaj nevyplňuje. ||
|264|A|A264|10163||
|264|B|B264|Rodné číslo||
|264|C|C264|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|264|D|D264|Právní nástupnictví při zániku||
|264|F|F264|text||
|264|H|H264|1-N||
|264|P|P264|x||
|264|S|S264|x||
|264|U|U264|x||
|264|V|V264|x||
|264|W|W264|1 - N subjektů právního nástupnictví||
|264|X|X264|Devítimístný nebo desetimístný číselný znak bez mezer (u občanů narozených po 31. 12. 1953 je rodné číslo desetimístné). U devítimístného rodného čísla je při elektronickém vyplňování třeba uvést skutečně 9 znaků (nesmí být proveden zápis mezery na desátém místě).||
|265|A|A265|10164||
|265|B|B265|EČP||
|265|C|C265|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|265|D|D265|Právní nástupnictví při zániku||
|265|F|F265|text||
|265|H|H265|1-N||
|265|P|P265|x||
|265|S|S265|x||
|265|V|V265|x||
|265|W|W265|1 - N subjektů právního nástupnictví||
|265|X|X265|V případě, že zaměstnavatel nemá RČ, přidělí správce agendy EČP (evidenční číslo pojištěnce). Pokud cizí státní příslušník nemá při oznámení o nástupu  rodné číslo (RČ) ani evidenční číslo pojištěnce (EČP) přiděleno, tento údaj se na tiskopisu nevyplňuje.  ||
|266|A|A266|10165||
|266|B|B266|Kód adresního místa||
|266|C|C266|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|266|D|D266|Právní nástupnictví při zániku||
|266|E|E266|Adresa||
|266|F|F266|text||
|266|H|H266|1-N||
|266|P|P266|x||
|266|S|S266|x||
|266|U|U266|x||
|266|V|V266|x||
|266|W|W266|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|266|X|X266|Kód adresního místa dle RÚIAN, neboli Registru územní identifikace, adres a nemovitostí.||
|267|A|A267|10166||
|267|B|B267|Ulice ||
|267|C|C267|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|267|D|D267|Právní nástupnictví při zániku||
|267|E|E267|Adresa||
|267|F|F267|text||
|267|H|H267|1-N||
|267|P|P267|x||
|267|S|S267|x||
|267|U|U267|x||
|267|V|V267|x||
|267|W|W267|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|268|A|A268|10167||
|268|B|B268|Číslo popisné ||
|268|C|C268|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|268|D|D268|Právní nástupnictví při zániku||
|268|E|E268|Adresa||
|268|F|F268|text||
|268|H|H268|1-N||
|268|P|P268|x||
|268|S|S268|x||
|268|U|U268|x||
|268|V|V268|x||
|268|W|W268|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|269|A|A269|10168||
|269|B|B269|Číslo orientační||
|269|C|C269|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|269|D|D269|Právní nástupnictví při zániku||
|269|E|E269|Adresa||
|269|F|F269|text||
|269|H|H269|1-N||
|269|P|P269|x||
|269|S|S269|x||
|269|U|U269|x||
|269|V|V269|x||
|269|W|W269|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|270|A|A270|10169||
|270|B|B270|Obec||
|270|C|C270|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|270|D|D270|Právní nástupnictví při zániku||
|270|E|E270|Adresa||
|270|F|F270|text||
|270|H|H270|1-N||
|270|P|P270|x||
|270|S|S270|x||
|270|U|U270|x||
|270|V|V270|x||
|270|W|W270|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|271|A|A271|10171||
|271|B|B271|PSČ||
|271|C|C271|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|271|D|D271|Právní nástupnictví při zániku||
|271|E|E271|Adresa||
|271|F|F271|text||
|271|H|H271|1-N||
|271|P|P271|x||
|271|S|S271|x||
|271|U|U271|x||
|271|V|V271|x||
|271|W|W271|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|272|A|A272|10172||
|272|B|B272|Stát||
|272|C|C272|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|272|D|D272|Právní nástupnictví při zániku||
|272|E|E272|Adresa||
|272|F|F272|číselník||
|272|H|H272|1-N||
|272|L|L272|CIS Stát||
|272|P|P272|x||
|272|S|S272|x||
|272|U|U272|x||
|272|V|V272|x||
|272|W|W272|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|273|A|A273|10173||
|273|B|B273|Název mzdové účtárny||
|273|C|C273|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|273|D|D273|Právní nástupnictví při zániku||
|273|E|E273|Mzdová účtárna||
|273|F|F273|text||
|273|H|H273|1-N||
|273|P|P273|x||
|273|S|S273|x||
|273|V|V273|x||
|273|W|W273|Pro každý subjekt právního nástupnictví||
|274|A|A274|10174||
|274|B|B274|Kód adresního místa||
|274|C|C274|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|274|D|D274|Právní nástupnictví při zániku||
|274|E|E274|Mzdová účtárna||
|274|F|F274|text||
|274|H|H274|1-N||
|274|P|P274|x||
|274|S|S274|x||
|274|V|V274|x||
|274|W|W274|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|275|A|A275|10175||
|275|B|B275|Ulice ||
|275|C|C275|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|275|D|D275|Právní nástupnictví při zániku||
|275|E|E275|Mzdová účtárna||
|275|F|F275|text||
|275|H|H275|1-N||
|275|P|P275|x||
|275|S|S275|x||
|275|V|V275|x||
|275|W|W275|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|276|A|A276|10176||
|276|B|B276|Číslo popisné ||
|276|C|C276|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|276|D|D276|Právní nástupnictví při zániku||
|276|E|E276|Mzdová účtárna||
|276|F|F276|text||
|276|H|H276|1-N||
|276|P|P276|x||
|276|S|S276|x||
|276|V|V276|x||
|276|W|W276|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|277|A|A277|10177||
|277|B|B277|Číslo orientační||
|277|C|C277|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|277|D|D277|Právní nástupnictví při zániku||
|277|E|E277|Mzdová účtárna||
|277|F|F277|text||
|277|H|H277|1-N||
|277|P|P277|x||
|277|S|S277|x||
|277|V|V277|x||
|277|W|W277|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|278|A|A278|10178||
|278|B|B278|Obec||
|278|C|C278|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|278|D|D278|Právní nástupnictví při zániku||
|278|E|E278|Mzdová účtárna||
|278|F|F278|text||
|278|H|H278|1-N||
|278|P|P278|x||
|278|S|S278|x||
|278|V|V278|x||
|278|W|W278|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|279|A|A279|10180||
|279|B|B279|PSČ||
|279|C|C279|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|279|D|D279|Právní nástupnictví při zániku||
|279|E|E279|Mzdová účtárna||
|279|F|F279|text||
|279|H|H279|1-N||
|279|P|P279|x||
|279|S|S279|x||
|279|V|V279|x||
|279|W|W279|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|280|A|A280|10181||
|280|B|B280|Stát||
|280|C|C280|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|280|D|D280|Právní nástupnictví při zániku||
|280|E|E280|Mzdová účtárna||
|280|F|F280|číselník||
|280|H|H280|1-N||
|280|L|L280|CIS Stát||
|280|P|P280|x||
|280|S|S280|x||
|280|V|V280|x||
|280|W|W280|Pro každý subjekt právního nástupnictví; pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|281|A|A281|10182||
|281|B|B281|Název mzdové účtárny||
|281|C|C281|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|281|D|D281|Mzdová účtárna zaměstnavatele||
|281|F|F281|text||
|281|H|H281|1-N||
|281|P|P281|x||
|281|S|S281|x||
|281|V|V281|x|admin:\npouze v případě zadání více mzdových účtáren|
|281|W|W281|1 - N objektů Mzdová účtárna zaměstnavatele||
|282|A|A282|10183||
|282|B|B282|Příjmení oprávněné osoby||
|282|C|C282|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|282|D|D282|Mzdová účtárna zaměstnavatele||
|282|F|F282|text||
|282|H|H282|1-N||
|282|P|P282|x||
|282|S|S282|x||
|282|V|V282|x|admin:\npouze v případě zadání více mzdových účtáren|
|282|X|X282|Jméno a příjmení zaměstnavatele, pod kterým je zaměstnavatel evidován v obchodním, živnostenském nebo jiném rejstříku, resp. v ROS||
|283|A|A283|10184||
|283|B|B283|Jméno oprávněné osoby||
|283|C|C283|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|283|D|D283|Mzdová účtárna zaměstnavatele||
|283|F|F283|text||
|283|H|H283|1-N||
|283|P|P283|x||
|283|S|S283|x||
|283|V|V283|x|admin:\npouze v případě zadání více mzdových účtáren|
|283|X|X283|Jméno a příjmení zaměstnavatele, pod kterým je zaměstnavatel evidován v obchodním, živnostenském nebo jiném rejstříku, resp. v ROS||
|284|A|A284|10185||
|284|B|B284|Telefon||
|284|C|C284|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|284|D|D284|Mzdová účtárna zaměstnavatele||
|284|F|F284|text||
|284|H|H284|1-N||
|284|P|P284|x||
|284|S|S284|x||
|284|T|T284|x||
|284|V|V284|x||
|285|A|A285|10186||
|285|B|B285|Kód adresního místa||
|285|C|C285|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|285|D|D285|Mzdová účtárna zaměstnavatele||
|285|E|E285|Adresa||
|285|F|F285|text||
|285|H|H285|1-N||
|285|P|P285|x||
|285|S|S285|x||
|285|V|V285|x||
|285|W|W285|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|285|X|X285|Kód adresního místa dle RÚIAN, neboli Registru územní identifikace, adres a nemovitostí.||
|286|A|A286|10187||
|286|B|B286|Ulice ||
|286|C|C286|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|286|D|D286|Mzdová účtárna zaměstnavatele||
|286|E|E286|Adresa||
|286|F|F286|text||
|286|H|H286|1-N||
|286|P|P286|x||
|286|S|S286|x||
|286|V|V286|x||
|286|W|W286|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|287|A|A287|10188||
|287|B|B287|Číslo popisné ||
|287|C|C287|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|287|D|D287|Mzdová účtárna zaměstnavatele||
|287|E|E287|Adresa||
|287|F|F287|text||
|287|H|H287|1-N||
|287|P|P287|x||
|287|S|S287|x||
|287|V|V287|x||
|287|W|W287|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|288|A|A288|10189||
|288|B|B288|Číslo orientační||
|288|C|C288|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|288|D|D288|Mzdová účtárna zaměstnavatele||
|288|E|E288|Adresa||
|288|F|F288|text||
|288|H|H288|1-N||
|288|P|P288|x||
|288|S|S288|x||
|288|V|V288|x||
|288|W|W288|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|289|A|A289|10190||
|289|B|B289|Obec||
|289|C|C289|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|289|D|D289|Mzdová účtárna zaměstnavatele||
|289|E|E289|Adresa||
|289|F|F289|text||
|289|H|H289|1-N||
|289|P|P289|x||
|289|S|S289|x||
|289|V|V289|x||
|289|W|W289|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|290|A|A290|10192||
|290|B|B290|PSČ||
|290|C|C290|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|290|D|D290|Mzdová účtárna zaměstnavatele||
|290|E|E290|Adresa||
|290|F|F290|text||
|290|H|H290|1-N||
|290|P|P290|x||
|290|S|S290|x||
|290|V|V290|x||
|290|W|W290|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|291|A|A291|10193||
|291|B|B291|Stát||
|291|C|C291|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|291|D|D291|Mzdová účtárna zaměstnavatele||
|291|E|E291|Adresa||
|291|F|F291|číselník||
|291|H|H291|1-N||
|291|L|L291|CIS Stát||
|291|P|P291|x||
|291|S|S291|x||
|291|V|V291|x||
|291|W|W291|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|292|A|A292|10194||
|292|B|B292|Počet zaměstnanců, pro které účtárna vede evidenci mezd ke dni jejího přihlášení||
|292|C|C292|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|292|D|D292|Mzdová účtárna zaměstnavatele||
|292|F|F292|číslo||
|292|G|G292|celé číslo||
|292|H|H292|1-N||
|292|P|P292|x||
|292|S|S292|x||
|292|X|X292|Počet zaměstnanců, pro které účtárna vede evidenci mezd ke dni jejího přihlášení.||
|293|A|A293|10456||
|293|B|B293|Okruh zaměstnanců, pro které účtárna vede evidenci mezd ke dni jejího přihlášení||
|293|C|C293|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|293|D|D293|Mzdová účtárna zaměstnavatele||
|293|F|F293|text||
|293|H|H293|1-N||
|293|P|P293|x||
|293|S|S293|x||
|294|A|A294|10195||
|294|B|B294|Datum vzniku mzdové účtárny||
|294|C|C294|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|294|D|D294|Mzdová účtárna zaměstnavatele||
|294|F|F294|datum||
|294|H|H294|1-N||
|294|P|P294|x||
|294|S|S294|x||
|295|A|A295|10197||
|295|B|B295|Předčíslí účtu||
|295|C|C295|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|295|D|D295|Peněžní účty||
|295|F|F295|text||
|295|H|H295|1-N||
|295|P|P295|x||
|295|S|S295|x||
|295|T|T295|x||
|295|W|W295|1 - N bankovních účtů (všechny účty zaměstnavatele)||
|296|A|A296|10198||
|296|B|B296|Číslo účtu||
|296|C|C296|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|296|D|D296|Peněžní účty||
|296|F|F296|text||
|296|H|H296|1-N||
|296|P|P296|x||
|296|S|S296|x||
|296|T|T296|x||
|297|A|A297|10199||
|297|B|B297|Kód banky||
|297|C|C297|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|297|D|D297|Peněžní účty||
|297|F|F297|číselník||
|297|H|H297|1-N||
|297|L|L297|CIS Kódy bank||
|297|P|P297|x||
|297|S|S297|x||
|297|T|T297|x||
|297|X|X297|Kódem banky je čtyřmístný číselný kód, který slouží k jednoznačné identifikaci každého poskytovatele platebních služeb, tedy nejen bank. Kód banky je poskytovatelům platebních služeb přidělován Českou národní bankou a slouží pouze pro platební styk v rámci České republiky.||
|298|A|A298|10200||
|298|B|B298|IBAN||
|298|C|C298|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|298|D|D298|Peněžní účty||
|298|F|F298|text||
|298|H|H298|1-N||
|298|P|P298|x||
|298|S|S298|x||
|298|T|T298|x||
|298|X|X298|IBAN (International Bank Account Number) je formát čísla účtu definovaný mezinárodní normou ISO 13616. Slouží k podpoře automatizovaného zpracování přeshraničních příkazů, zrychlení, zjednodušení a zlevnění přeshraničního platebního styku a snížení počtu chyb z důvodu nesprávně zadaného čísla účtu.||
|299|A|A299|10201||
|299|B|B299|Název peněžního ústavu||
|299|C|C299|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|299|D|D299|Peněžní účty||
|299|E|E299|Peněžní ústav||
|299|F|F299|číselník||
|299|H|H299|1-N||
|299|L|L299|CIS Kódy bank||
|299|P|P299|x||
|299|S|S299|x||
|299|T|T299|x||
|300|A|A300|10203||
|300|B|B300|Ulice ||
|300|C|C300|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|300|D|D300|Peněžní účty||
|300|E|E300|Peněžní ústav||
|300|F|F300|text||
|300|H|H300|1-N||
|300|P|P300|x||
|300|S|S300|x||
|300|T|T300|x||
|300|W|W300|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|301|A|A301|10204||
|301|B|B301|Číslo popisné ||
|301|C|C301|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|301|D|D301|Peněžní účty||
|301|E|E301|Peněžní ústav||
|301|F|F301|text||
|301|H|H301|1-N||
|301|P|P301|x||
|301|S|S301|x||
|301|T|T301|x||
|301|W|W301|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|302|A|A302|10205||
|302|B|B302|Číslo orientační||
|302|C|C302|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|302|D|D302|Peněžní účty||
|302|E|E302|Peněžní ústav||
|302|F|F302|text||
|302|H|H302|1-N||
|302|P|P302|x||
|302|S|S302|x||
|302|T|T302|x||
|302|W|W302|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|303|A|A303|10206||
|303|B|B303|Obec||
|303|C|C303|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|303|D|D303|Peněžní účty||
|303|E|E303|Peněžní ústav||
|303|F|F303|text||
|303|H|H303|1-N||
|303|P|P303|x||
|303|S|S303|x||
|303|T|T303|x||
|303|W|W303|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|304|A|A304|10208||
|304|B|B304|PSČ||
|304|C|C304|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|304|D|D304|Peněžní účty||
|304|E|E304|Peněžní ústav||
|304|F|F304|text||
|304|H|H304|1-N||
|304|P|P304|x||
|304|S|S304|x||
|304|T|T304|x||
|304|W|W304|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|305|A|A305|10209||
|305|B|B305|Stát||
|305|C|C305|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|305|D|D305|Peněžní účty||
|305|E|E305|Peněžní ústav||
|305|F|F305|číselník||
|305|H|H305|1-N||
|305|L|L305|CIS Stát||
|305|P|P305|x||
|305|S|S305|x||
|305|T|T305|x||
|305|W|W305|Pro adresy v RUIAN se používá pouze atribut Kód adresního místa, u adres mimo RUIAN se používají ostatní atributy adresy.||
|306|A|A306|10460||
|306|B|B306|Odvětví||
|306|C|C306|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|306|D|D306|Ekonomická činnost||
|306|F|F306|číselník||
|306|L|L306|CIS Klasifikace ekonomických činností||
|306|U|U306|x||
|306|V|V306|x||
|306|W|W306|Atribut bez sběru, který bude přiřazován automaticky. Bude uložen v cJMHZ a poskytován ke konzumaci. Nebude v primárním registru zaměstnavatelů.||
|306|X|X306|Odvětví ekonomické činnosti - ČSÚ - Klasifikace ekonomických činností - CZ-NACE,  https://www.czso.cz/csu/czso/klasifikace_ekonomickych_cinnosti_cz_nace ||
|307|A|A307|10210||
|307|B|B307|Agentura práce||
|307|C|C307|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|307|D|D307|Ekonomická činnost||
|307|F|F307|příznak||
|307|P|P307|x||
|307|T|T307|x||
|307|U|U307|x||
|307|V|V307|x||
|307|X|X307|Agentury práce jsou právnické nebo fyzické osoby, které mají povolení k příslušné formě zprostředkování zaměstnání, udělené Generálním ředitelstvím Úřadu práce.||
|308|A|A308|10211||
|308|B|B308|Písemná dohoda o uznání za zaměstnavatele na chráněném trhu práce dle ustanovení § 78 zákona o zaměstnanosti||
|308|C|C308|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|308|D|D308|Chráněný trh práce||
|308|F|F308|příznak||
|308|P|P308|x||
|308|U|U308|x||
|308|V|V308|x||
|308|W|W308|potenciálně možné zjišťovat z aplikací OK systemu, pak by nebylo potřeba vybírat||
|308|X|X308|Dohoda o uznání zaměstnavatele se uzavírá v rámci místní působnosti krajské pobočky ÚP ČR, v jejímž obvodu má sídlo zaměstnavatel, který je právnickou osobou, nebo v jejímž obvodu má bydliště zaměstnavatel, který je fyzickou osobou. ||
|309|A|A309|10212||
|309|B|B309|Integrační sociální podnik||
|309|C|C309|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|309|D|D309|Sociální podnik||
|309|F|F309|příznak||
|309|P|P309|x||
|309|U|U309|x||
|309|V|V309|x||
|309|W|W309|Legislativa ve schvalování||
|309|X|X309|Integrační sociální podnik je fyzická nebo právnická osoba, které je přiznán status integračního sociálního podniku.||
|310|A|A310|10221||
|310|B|B310|Variabilní symbol||
|310|C|C310|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|310|F|F310|text||
|310|I|I310|employees.employee.comp.vs (ID 10221)||
|310|J|J310|hlavicka.variabilniSymbol (ID 10221)||
|310|K|K310| ||
|310|M|M310|ne - identifikace||
|310|P|P310|x|[Komentář ve vlákně]\n\nVaše verze aplikace Excel vám umožňuje číst tento komentář ve vlákně, ale jakékoli jeho úpravy se odeberou, pokud se soubor otevře v novější verzi aplikace Excel. Další informace: https://go.microsoft.com/fwlink/?linkid=870924\n\nKomentář:\n    U přihlášky zaměstnavatele není znám, relevantní pouze pro hlášení REGZEL_DOPL a odhlášku.|
|310|Q|Q310|x||
|310|R|R310|x||
|310|S|S310|x||
|310|T|T310|x||
|310|U|U310|x||
|310|V|V310|x||
|310|W|W310|výstupní atribut procesu Registrace zaměstnance||
|310|X|X310|Variabilní symbol přidělený zaměstnavateli (mzdové účtárně) jako plátci pojistného OSSZ.||
|311|A|A311|10222||
|311|B|B311|Nový variabilní symbol||
|311|C|C311|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|311|F|F311|text||
|311|I|I311|employees.employee.comp.nvs (ID 10222)||
|311|J|J311| ||
|311|Q|Q311|x||
|311|S|S311|x||
|311|T|T311|x||
|311|U|U311|x||
|311|V|V311|x||
|311|X|X311|Variabilní symbol zaměstnavatele (organizační složky, mzdové účtárny), u něhož je zaměstnanec zaměstnán po převodu.||
|312|A|A312|10223||
|312|B|B312|Datum nástupu do zaměstnání||
|312|C|C312|Vykonávaná pozice zaměstnance||
|312|D|D312|Nástup do zaměstnání||
|312|F|F312|datum||
|312|I|I312|employees.employee.job.fro (ID 10223)||
|312|J|J312|identifikace.datumNastupu (ID 10223)||
|312|K|K312| ||
|312|M|M312|ne - identifikace||
|312|Q|Q312|x||
|312|R|R312|x||
|312|S|S312|x||
|312|T|T312|x||
|312|U|U312|x||
|312|V|V312|x||
|312|W|W312|Mapování na související VZT atributy, které správně interpretují tento atribut z důvodu převodu zaměstnance:\nPV_NP_ZAMESTNANEC.DUVOD_UKONCENI\nPV_NP_ZAMESTNANEC.DUVOD_PRIHLASENI\nPV_NP_ZAMESTNANEC.UCAST_OD\nPV_NP_ZAMESTNANEC.PREDCHOZI_PV||
|312|X|X312|Datum skutečného nástupu do práce – den, měsíc, rok, nikoli datum uzavření pracovněprávního vztahu nebo datum, které je sjednáno jako vstup do zaměstnání v pracovní smlouvě. Za den nástupu do zaměstnání se u zaměstnance v pracovním poměru a státního zaměstnance podle zákona o státní službě považuje také den přede dnem nástupu do práce, za který příslušela náhrada mzdy nebo platu nebo za který se plat nebo mzda nekrátí. V takovém případě je tedy zaměstnanec účasten pojištění ode dne, v němž by nastoupil do práce, kdyby na tento den nepřipadla překážka v práci, za kterou je zaměstnavatel povinen zaměstnanci nahradit ztrátu mzdy. Podle zákoníku práce je zaměstnavatel povinen poskytovat náhradu mzdy ve stanovených případech, mj. i za státní svátek, který připadl podle rozvrhu pracovní doby na pracovní den zaměstnance. Den pracovního volna (např. sobota, neděle), za který zaměstnanci dle rozvrhu pracovní doby nenáleží měsíční mzda, tak nemůže být považován za den nástupu do práce. U smluvních zaměstnanců se uvádí datum, od kterého zaměstnanec začal vykonávat práci pro smluvního zaměstnavatele na území ČR. U zaměstnání malého rozsahu a zaměstnanců činných na základě dohody o provedení práce se uvádí datum skutečného nástupu do zaměstnání, nikoli datum vzniku účasti na pojištění. Datum platnosti nástupu do zaměstnání může být pouze dřívější nebo aktuální.||
|313|A|A313|10224||
|313|B|B313|Datum skončení zaměstnání||
|313|C|C313|Vykonávaná pozice zaměstnance||
|313|D|D313|Ukončení zaměstnání||
|313|F|F313|datum||
|313|I|I313|employees.employee.job.to (ID 10224)||
|313|J|J313| ||
|313|Q|Q313|x||
|313|S|S313|x||
|313|T|T313|x||
|313|U|U313|x||
|313|V|V313|x||
|313|X|X313|Den, měsíc a rok, kterým doba zaměstnání skončila (např. skončení pracovního poměru, dohody o pracovní činnosti, u člena družstva vykonávajícího práci pro družstvo mimo pracovněprávní vztah den, v němž naposledy vykonával práci pro družstvo za odměnu). U smluvních zaměstnanců se uvádí den, kterým skončil výkon práce pro smluvního zaměstnavatele v ČR. U zaměstnání malého rozsahu se uvádí den skončení doby zaměstnání, nikoli datum skončení účasti na pojištění. U zaměstnance činného na základě dohody o provedení práce se uvádí den uplynutí doby, na kterou byla dohoda sjednána. Datum platnosti skončení doby zaměstnání může být pouze dřívější nebo aktuální.||
|314|A|A314|10225||
|314|B|B314|Zaměstnání ukončeno smrtí||
|314|C|C314|Vykonávaná pozice zaměstnance||
|314|D|D314|Ukončení zaměstnání||
|314|F|F314|příznak||
|314|I|I314|employees.employee.job.endbydeath (ID 10225)||
|314|J|J314| ||
|314|Q|Q314|x||
|314|S|S314|x||
|314|V|V314|x||
|314|X|X314|Zaměstnání bylo ukončeno smrtí.||
|315|A|A315|10226||
|315|B|B315|Zaměstnanec nenastoupil||
|315|C|C315|Vykonávaná pozice zaměstnance||
|315|D|D315|Ukončení zaměstnání||
|315|F|F315|příznak||
|315|I|I315|employees.employee.job.notstart (ID 10226)||
|315|J|J315| ||
|315|Q|Q315|x||
|315|S|S315|x||
|315|U|U315|x||
|315|V|V315|x||
|315|X|X315|(Potenciální) zaměstnanec nenastoupil.||
|316|A|A316|10227||
|316|B|B316|Vznik zaměstnání||
|316|C|C316|Vykonávaná pozice zaměstnance||
|316|D|D316|Nástup do zaměstnání||
|316|F|F316|datum||
|316|I|I316|employees.employee.job.contractfro (ID 10227)||
|316|J|J316| ||
|316|Q|Q316|x||
|316|S|S316|x||
|316|U|U316|x||
|316|V|V316|x||
|316|X|X316|Uvede se datum vzniku pracovněprávního vztahu (pracovní poměr, dohoda o pracovní činnosti, dohoda o provedení práce) / služebního poměru na základě uzavřené smlouvy nebo dohody o pracovní činnosti, dohody o provedení práce – den, měsíc, rok (nemusí být totožné s datem skutečného nástupu do zaměstnání).||
|317|A|A317|10228||
|317|B|B317|ID pracovněprávního vztahu (Identifikátor zaměstnání)||
|317|C|C317|Vykonávaná pozice zaměstnance||
|317|F|F317|číslo||
|317|G|G317|celé číslo||
|317|I|I317|employees.employee.job.oid (ID 10228)||
|317|J|J317|identifikace.idPpv (ID 10228)||
|317|M|M317|ne - identifikace||
|317|Q|Q317|x||
|317|R|R317|x||
|317|S|S317|x||
|317|T|T317|x||
|317|U|U317|x||
|317|V|V317|x||
|317|W|W317|výstupní atribut u registrace zaměstnance, vstupní atribut u měsíčního hlášení||
|317|X|X317| ||
|318|A|A318|10243||
|318|B|B318|Zaměstnání malého rozsahu||
|318|C|C318|Vykonávaná pozice zaměstnance||
|318|D|D318|Rozsah zaměstnání||
|318|F|F318|příznak||
|318|I|I318|employees.employee.job.sme (ID 10243)||
|318|J|J318| ||
|318|Q|Q318|x||
|318|S|S318|x||
|318|T|T318|x||
|318|V|V318|x||
|318|W|W318|1 - N kódů ELDP||
|318|X|X318|Jde o zaměstnání, u kterého není splněna podmínka sjednaného příjmu alespoň ve výš rozhodného příjmu za měsíc, případně není-li příjem sjednán vůbec. Při výkonu zaměstnání malého rozsahu je zaměstnanec pojištěn jen v těch kalendářních měsících, v nichž jeho příjem dosáhl výše alespoň rozhodného příjmü.||
|319|A|A319|10526||
|319|B|B319|Předpokládané/á místo/a výkonu práce||
|319|C|C319|Vykonávaná pozice zaměstnance||
|319|D|D319|Předpokládané místo výkonu práce||
|319|F|F319|text||
|319|I|I319|employees.employee.job.preplace (ID 10526)||
|319|J|J319| ||
|319|Q|Q319|x||
|319|U|U319|x||
|319|V|V319|x||
|319|X|X319|Název jednoho nebo více míst výkonu práce zaměstnance. Uvedou se všechna konkrétní místa možného výkonu práce, kde zaměstnanec bude vykonávat práci. Pokud je místo výkonu práce shodné s adresou sídla zaměstnavatele, stačí do pole uvést „sídlo zaměstnavatele. Údaj slouží zejména pro výkon činnosti kontrolních orgánů.||
|320|A|A320|10527||
|320|B|B320|Místo výkonu práce uvedené v pracovní smlouvě zaměstnance||
|320|C|C320|Vykonávaná pozice zaměstnance||
|320|D|D320|Místo výkonu práce ze smlouvy||
|320|F|F320|text||
|320|I|I320|employees.employee.job.contractplace (ID 10527)||
|320|J|J320| ||
|320|Q|Q320|x||
|320|T|T320|x||
|320|U|U320|x||
|320|V|V320|x||
|320|X|X320|Název místa výkonu práce, kterým je místo v obci uvedené v pracovní smlouvě\nzaměstnance. Je-li v pracovní smlouvě uvedeno jako místo výkonu práce území více obcí, nebo jde-li o zaměstnance na základě dohody o pracích konaných mimo pracovní poměr nebo zaměstnance ve smyslu § 6 zákona č. 586/1992 Sb., o daních z příjmů, ve znění pozdějších předpisů (dále jen „zákon“), bez pracovněprávního vztahu, použije se pro účely vyplnění položky jako místo výkonu\npráce místo pobytu nebo sídlo plátce daně (zaměstnavatele). Místo „pravidelného pracoviště“ pro účely aplikace zákona č. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů, není rozhodné.||
|321|A|A321|10528||
|321|B|B321|Název obce||
|321|C|C321|Vykonávaná pozice zaměstnance||
|321|D|D321|Místo výkonu práce ze smlouvy||
|321|F|F321|text||
|321|I|I321|employees.employee.job.cit (ID 10528)||
|321|J|J321| ||
|321|Q|Q321|x||
|321|T|T321|x||
|321|U|U321|x||
|321|V|V321|x||
|321|X|X321|Název obce, na jejímž katastrálním území je umístěno místo výkonu práce||
|322|A|A322|10529||
|322|B|B322|Kód obce||
|322|C|C322|Vykonávaná pozice zaměstnance||
|322|D|D322|Místo výkonu práce ze smlouvy||
|322|F|F322|číselník||
|322|I|I322|employees.employee.job.municode (ID 10529)||
|322|J|J322| ||
|322|L|L322|CIS Obce||
|322|Q|Q322|x||
|322|T|T322|x||
|322|U|U322|x||
|322|V|V322|x||
|322|X|X322|Kód obce, na jejímž katastrálním území je umístěno místo výkonu práce \nViz vyhláška č. 301/2025 Sb., o podílu jednotlivých obcí na stanovených procentních částech celostátního hrubého výnosu daně z přidané hodnoty a daní z příjmů.||
|323|A|A323|10229||
|323|B|B323|Obec||
|323|C|C323|Vykonávaná pozice zaměstnance||
|323|D|D323|Místo výkonu práce / činnosti||
|323|E|E323|Adresa||
|323|F|F323|text||
|323|J|J323|vykonavanaPozice.mistoVykonuPrace.obec (ID 10229)||
|323|K|K323| ||
|323|M|M323|předchozí období||
|323|R|R323|x||
|323|S|S323|x||
|323|T|T323|x||
|323|U|U323|x||
|323|V|V323|x||
|323|W|W323|požadavek FS konzumovat k 1.12.||
|323|X|X323|Uvede se obec, na jejímž území výkon práce probíhal. Pokud v daném měsíci místo výkonu práce bylo umístěno ve více obcích, pak se uvede obec, kde výkon práce probíhal převážně nebo obec kde je umístěna provozovna, v níž zaměstnanec zahajoval práci. K záznamu využijte číselník obcí. \nV případě, že v daném měsíci výkon práce probíhal převážně mimo ČR, ale i v ČR, uvede se obec v ČR dle výše uvedených pravidel. V případě, že místo výkonu bylo umístěno pouze mimo území ČR, vyplní se obec sídla zaměstnavatele (umístění provozovny).||
|324|A|A324|10230||
|324|B|B324|Kód obce||
|324|C|C324|Vykonávaná pozice zaměstnance||
|324|D|D324|Místo výkonu práce / činnosti||
|324|E|E324|Adresa||
|324|F|F324|číselník||
|324|J|J324|vykonavanaPozice.mistoVykonuPrace.kodObce (ID 10230)||
|324|K|K324| ||
|324|L|L324|CIS Obce||
|324|M|M324|předchozí období||
|324|R|R324|x||
|324|S|S324|x||
|324|T|T324|x||
|324|U|U324|x||
|324|V|V324|x||
|324|X|X324|Šestimístný kód -  Použije se číselník obcí viz vyhláška o procentním podílu jednotlivých obcí na částech celostátního hrubého výnosu daně z přidané hodnoty a daní z příjmů (přílohy č.1 VDA).||
|325|A|A325|10231||
|325|B|B325|Stát||
|325|C|C325|Vykonávaná pozice zaměstnance||
|325|D|D325|Místo výkonu práce / činnosti||
|325|E|E325|Adresa||
|325|F|F325|číselník||
|325|J|J325|vykonavanaPozice.mistoVykonuPrace.kodStatu (ID 10231)||
|325|K|K325| ||
|325|L|L325|CIS Stát||
|325|M|M325|předchozí období||
|325|R|R325|x||
|325|S|S325|x||
|325|T|T325|x||
|325|U|U325|x||
|325|V|V325|x||
|325|X|X325|Pro označení státu se použije číselník států.||
|326|A|A326|10232||
|326|B|B326|Mzdový příspěvek v rámci nástrojů APZ||
|326|C|C326|Vykonávaná pozice zaměstnance||
|326|D|D326|Pracovní místo / pozice||
|326|E|E326|APZ||
|326|F|F326|příznak||
|326|J|J326|vykonavanaPozice.uplatnujiPrispevekApz (ID 10232)||
|326|K|K326| ||
|326|M|M326|předchozí období||
|326|R|R326|x||
|326|U|U326|x||
|326|V|V326|x||
|326|X|X326|Mzdový příspěvek zaměstnavateli v rámci aktivní politiky zaměstnansoti při uplatnění uchazečů o zaměstnání. ||
|327|A|A327|10233||
|327|B|B327|Nástroj (opatření)||
|327|C|C327|Vykonávaná pozice zaměstnance||
|327|D|D327|Pracovní místo / pozice||
|327|E|E327|APZ||
|327|F|F327|číselník||
|327|J|J327|vykonavanaPozice.nastrojApzKod (ID 10233)||
|327|K|K327| ||
|327|L|L327|CIS Nástroj||
|327|M|M327|předchozí období||
|327|P|P327| ||
|327|R|R327|x||
|327|U|U327|x||
|327|V|V327|x||
|327|X|X327|Uvedení nástroje:\n§112 zákona o zaměstnanosti – veřejně prospěšné práce\n§113 zákona o zaměstnanosti – společensky účelné pracovní místo vyhrazené\n§ 106 zákona o zaměstnanosti - sdílené pracovní místo \nostatní mzdové nástroje||
|328|A|A328|10234||
|328|B|B328|Profese||
|328|C|C328|Vykonávaná pozice zaměstnance||
|328|D|D328|Profese||
|328|F|F328|číselník||
|328|I|I328|employees.employee.job.prof.clas (ID 10234)||
|328|J|J328| ||
|328|L|L328|CIS Klasifikace zaměstnání||
|328|Q|Q328|x||
|328|S|S328|x||
|328|U|U328|x||
|328|V|V328|x||
|328|W|W328|Bude potřeba vybírat minimálně 4místné kódy.||
|328|X|X328|Kód klasifikace zaměstnání příslušného pracovního poměru zaměstnance podle klasifikace ČSÚ (klasifikace CZ-ISCO). Klasifikace platí od 1.1.2011 a je závazná pro všechna statistická zjišťování prováděná podle § 19 odst. 2 zákona č. 89/1995 Sb., o státní statistické službě, ve znění pozdějších předpisů. Pětimístný kód se přiřazuje podle převážně vykonávaného zaměstnání.||
|329|A|A329|10235||
|329|B|B329|Název pozice||
|329|C|C329|Vykonávaná pozice zaměstnance||
|329|D|D329|Pracovní místo / pozice||
|329|F|F329|text||
|329|I|I329|employees.employee.job.position.name (ID 10235)||
|329|J|J329| ||
|329|Q|Q329|x||
|329|S|S329|x||
|329|U|U329|x||
|329|V|V329|x||
|329|X|X329|Název pracovní pozice, který je ve společnosti používaný - jde o název používaný v pracovní smlouvě nebo v organizačním řádu společnosti.||
|330|A|A330|10238||
|330|B|B330|Vedoucí zaměstnanec||
|330|C|C330|Vykonávaná pozice zaměstnance||
|330|D|D330|Pracovní místo / pozice||
|330|F|F330|příznak||
|330|I|I330|employees.employee.job.position.lead (ID 10238)||
|330|J|J330| ||
|330|Q|Q330|x||
|330|U|U330|x||
|330|V|V330|x||
|330|X|X330|Pro účely strukturálních mzdových statistik:\nVedoucími zaměstnanci zaměstnavatele se rozumějí zaměstnanci, kteří jsou na jednotlivých stupních řízení zaměstnavatele oprávněni stanovit a ukládat podřízeným zaměstnancům pracovní úkoly, organizovat, řídit a kontrolovat jejich práci a dávat jim k tomu účelu závazné pokyny. Vedoucím zaměstnancem je nebo se za vedoucího zaměstnance považuje rovněž vedoucí organizační složky státu.\nUvádí se A/N||
|331|A|A331|10239||
|331|B|B331|Druh činnosti||
|331|C|C331|Vykonávaná pozice zaměstnance||
|331|D|D331|Činnost||
|331|F|F331|číselník||
|331|I|I331|employees.employee.job.rel (ID 10239)||
|331|J|J331| ||
|331|L|L331|CIS Druh činnosti||
|331|M|M331|ne - identifikace||
|331|Q|Q331|x||
|331|R|R331|x||
|331|S|S331|x||
|331|T|T331|x||
|331|U|U331|x||
|331|V|V331|x||
|331|X|X331|Obsah definován číselníkem ČSSZ||
|332|A|A332|10502||
|332|B|B332|Bližší určení pracovněprávního vztahu||
|332|C|C332|Vykonávaná pozice zaměstnance||
|332|D|D332|Činnost||
|332|F|F332|číselník||
|332|I|I332|employees.employee.job.relDetail (ID 10502)||
|332|J|J332| ||
|332|L|L332|CIS Bližší určení pracovněprávního vztahu||
|332|M|M332| ||
|332|Q|Q332|x||
|332|S|S332|x||
|332|W|W332|pro účely JMHZ k přiřazení správné datové sady pro měsíční hlášení||
|332|X|X332|Pokud byla u údaje „Druh činnosti“ vybrána číselníková hodnota 1 – 9, je možno následně označit údaj „Bližší určení  PV“, který je údajem nepovinným. Po jeho označení je nutno vybrat (označit) mezi 2 nabízenými variantami:\n•	Výkon trestu odnětí svobody / zabezpečovací detence \n•	Pracovní vztah specifické skupiny \n\n„Pracovní vztah specifické skupiny“ se týká těchto druhů činností uváděných pod kódem 1 - 9:\no	soudců\no	členů zastupitelstev územních samosprávních celků (zvolených do funkcí, jež zastupitelstvo obce určilo jako funkce, pro které budou členové zastupitelstva obce uvolněni)	\no	poslanců Poslanecké sněmovny PČR, senátorů Senátu PČR, členů vlády, prezidenta, viceprezidenta a členů NKÚ, členy RRTV, finančního arbitra a jeho zástupce, veřejného ochránce práv a jeho zástupce, členů Rady Ústavu pro studium totalitních režimů, členů Rady Českého telekomunikačního úřadu, členů Rady Energetického regulačního úřadu, členů Národní rozpočtové rady	\no	fyzických osob neuvedených v § 5, písm. a) bodech 1 až 21 ZNP, s výjimkou členů zastupitelstev územních samosprávných celků a zastupitelstev městských částí nebo městských obvodů územně členěných statutárních měst a hlavního města Prahy volených do funkcí, jež zastupitelstvo neurčilo jako funkce, pro které budou členové zastupitelstva uvolněni, v době zaměstnání, pokud jim v souvislosti se zaměstnáním plynou nebo by mohly plynout příjmy ze závislé činnosti, které jsou nebo by byly, pokud by podléhaly zdanění v České republice, předmětem daně z příjmu podle zvláštního právního předpisu75) a nejsou od této daně osvobozeny,   \no	státních zástupců vykonávajících v České republice funkci evropských pověřených žalobců, kteří jsou zařazeni do okruhu pojištěných osob ode dne 1. 12. 2019 podle ustanovení § 167g ZNP.||
|333|A|A333|10247||
|333|B|B333|Funkční požitky dle § 6 odst. 10 ZDP||
|333|C|C333|Vykonávaná pozice zaměstnance||
|333|D|D333|Činnost||
|333|F|F333|příznak||
|333|J|J333|vykonavanaPozice.funkcniPozitky (ID 10247)||
|333|K|K333| ||
|333|M|M333|předchozí období||
|333|R|R333|x||
|333|V|V333|x||
|333|X|X333|Jedná se o příjmy podle § 6 odst.10 ZDP například příjmy představitelů státní moci (senátorů, poslanců, soudců), spolků, komor, orgánů obcí apod. ||
|334|A|A334|10248||
|334|B|B334|Vzdělání požadované pro výkon profese||
|334|C|C334|Vykonávaná pozice zaměstnance||
|334|D|D334|Profese||
|334|F|F334|číselník||
|334|I|I334|employees.employee.job.prof.edu (ID 10248)||
|334|J|J334| ||
|334|L|L334|CIS Kategorie dosaženého vzdělání||
|334|Q|Q334|x||
|334|U|U334|x||
|334|V|V334|x||
|334|X|X334|Minimální stupeň vzdělání požadovaného pro výkon povolání podle Kategorie dosaženého vzdělání (https://isv.gov.cz/ccis/detail/877da162-e430-44d4-8ff1-64059eb4c659). Nejvyšší dosažené vzdělání zaměstnance musí odpovídat tomuto atributu (dosažené vzdělání nesmí být nižší než požadované vzdělání uvedeného u volného pracovního místa zaměstnavatele na základě kterého bylo pracovní oprávnění vydáno).||
|335|A|A335|10249||
|335|B|B335|Postavení v zaměstnání||
|335|C|C335|Vykonávaná pozice zaměstnance||
|335|D|D335|Forma práce||
|335|F|F335|číselník||
|335|I|I335|employees.employee.job.relat (ID 10249)||
|335|J|J335| ||
|335|K|K335| ||
|335|L|L335|CIS Klasifikace postavení v zaměstnání||
|335|Q|Q335|x||
|335|T|T335|x||
|335|U|U335|x||
|335|V|V335|x||
|335|X|X335|Kód postavení v zaměstnání pro určení typu pracovněprávního vztahu mezi zaměstnancem (jeho pracovním poměrem) a ekonomickým subjektem||
|336|A|A336|10251||
|336|B|B336|Zaměstnání za účelem dočasného přidělení u uživatele||
|336|C|C336|Vykonávaná pozice zaměstnance||
|336|D|D336|Forma práce||
|336|E|E336|Dočasné přidělení||
|336|F|F336|příznak||
|336|J|J336|vykonavanaPozice.docasnePrideleniEvidovano (ID 10251)||
|336|K|K336| ||
|336|M|M336|předchozí období||
|336|R|R336|x||
|336|T|T336|x||
|336|U|U336|x||
|336|V|V336|x||
|336|X|X336|Zaměstnávání fyzických osob za účelem výkonu jejich práce pro uživatele, kterým se rozumí jiná právnická nebo fyzická osoba, která práci přiděluje a dohlíží na její provedení - § 14 odst. 1 písm. b) zákona č. 435/2004 Sb., o zaměstnanosti, ve znění pozdějších předpisů||
|337|A|A337|10252||
|337|B|B337|IČO uživatele||
|337|C|C337|Vykonávaná pozice zaměstnance||
|337|D|D337|Forma práce||
|337|E|E337|Dočasné přidělení||
|337|F|F337|text||
|337|H|H337|1-N||
|337|J|J337|vykonavanaPozice.docasnePrideleni.uzivatel.ico (ID 10252)||
|337|K|K337| ||
|337|M|M337|předchozí období||
|337|R|R337|x||
|337|T|T337|x||
|337|U|U337|x||
|337|V|V337|x||
|337|X|X337|Identifikační číslo osoby přidělené zaměstnavateli při registraci v obchodním, živnostenském nebo jiném rejstříku, resp. v ROS. IČO se uvede včetně úvodních nul. ||
|338|A|A338|10457||
|338|B|B338|Rodné číslo uživatele||
|338|C|C338|Vykonávaná pozice zaměstnance||
|338|D|D338|Forma práce||
|338|E|E338|Dočasné přidělení||
|338|F|F338|text||
|338|H|H338|1-N||
|338|J|J338|vykonavanaPozice.docasnePrideleni.uzivatel.rodneCislo (ID 10457)||
|338|K|K338| ||
|338|M|M338|předchozí období||
|338|R|R338|x||
|338|T|T338|x||
|338|U|U338|x||
|338|V|V338|x||
|338|X|X338|Devítimístný nebo desetimístný číselný znak bez mezer (u občanů narozených po 31. 12. 1953 je rodné číslo desetimístné). U devítimístného rodného čísla je při elektronickém vyplňování třeba uvést skutečně 9 znaků (nesmí být proveden zápis mezery na desátém místě).||
|339|A|A339|10492||
|339|B|B339|Kód státu zahraniční právnické osoby nebo zahraniční fyzické osoby||
|339|C|C339|Vykonávaná pozice zaměstnance||
|339|D|D339|Forma práce||
|339|E|E339|Dočasné přidělení||
|339|F|F339|číselník||
|339|H|H339|1-N||
|339|J|J339|vykonavanaPozice.docasnePrideleni.uzivatel.zahranicniOsoba.kodStatu (ID 10492)||
|339|K|K339| ||
|339|L|L339|CIS Stát||
|339|M|M339|předchozí období||
|339|R|R339|x||
|339|T|T339|x||
|339|U|U339|x||
|339|V|V339|x||
|340|A|A340|10493||
|340|B|B340|Registrační číslo zahraniční právnické osoby nebo identifikace zahraniční fyzické osoby||
|340|C|C340|Vykonávaná pozice zaměstnance||
|340|D|D340|Forma práce||
|340|E|E340|Dočasné přidělení||
|340|F|F340|text||
|340|H|H340|1-N||
|340|J|J340|vykonavanaPozice.docasnePrideleni.uzivatel.zahranicniOsoba.identifikace (ID 10493)||
|340|K|K340| ||
|340|M|M340|předchozí období||
|340|R|R340|x||
|340|T|T340|x||
|340|U|U340|x||
|340|V|V340|x||
|341|A|A341|10494||
|341|B|B341|Název zahraniční právnické osoby nebo zahraniční fyzické osoby||
|341|C|C341|Vykonávaná pozice zaměstnance||
|341|D|D341|Forma práce||
|341|E|E341|Dočasné přidělení||
|341|F|F341|text||
|341|H|H341|1-N||
|341|J|J341|vykonavanaPozice.docasnePrideleni.uzivatel.zahranicniOsoba.nazev (ID 10494)||
|341|K|K341| ||
|341|M|M341|předchozí období||
|341|R|R341|x||
|341|T|T341|x||
|341|U|U341|x||
|341|V|V341|x||
|342|A|A342|10255||
|342|B|B342|Pracovní režim||
|342|C|C342|Vykonávaná pozice zaměstnance||
|342|D|D342|Režim práce||
|342|F|F342|číselník||
|342|I|I342|employees.employee.job.workmode (ID 10255)||
|342|J|J342| ||
|342|L|L342|CIS Pracovní režim||
|342|P|P342| ||
|342|Q|Q342|x||
|342|S|S342|x||
|342|U|U342|x||
|342|V|V342|x||
|342|X|X342|§ 78        (1) Pro účely úpravy pracovní doby a doby odpočinku je\nd) dvousměnným pracovním režimem režim práce, v němž se zaměstnanci vzájemně pravidelně střídají ve 2 směnách v rámci 24 hodin po sobě jdoucích,\ne) vícesměnným pracovním režimem režim práce, v němž se zaměstnanci vzájemně pravidelně střídají ve 3 nebo více směnách v rámci 24 hodin po sobě jdoucích,\ng) nepřetržitým provozem provoz, který vyžaduje výkon práce 24 hodin denně po 7 dnů v týdnu,||
|343|A|A343|10407||
|343|B|B343|Nepřetržitý provoz||
|343|C|C343|Vykonávaná pozice zaměstnance||
|343|D|D343|Režim práce||
|343|F|F343|příznak||
|343|I|I343|employees.employee.job.cont (ID 10407)||
|343|J|J343| ||
|343|Q|Q343|x||
|343|S|S343|x||
|343|U|U343|x||
|343|V|V343|x||
|344|A|A344|10258||
|344|B|B344|Práce probíhá převážně||
|344|C|C344|Vykonávaná pozice zaměstnance||
|344|D|D344|Místo výkonu práce / činnosti||
|344|E|E344|Výkon práce OZP||
|344|F|F344|číselník||
|344|I|I344|employees.employee.job.place (ID 10258)||
|344|J|J344| ||
|344|L|L344|CIS Průběh práce||
|344|P|P344| ||
|344|Q|Q344|x||
|344|U|U344|x||
|344|V|V344|x||
|344|X|X344|Výkon práce OZP dle číselníku.||
|345|A|A345|10259||
|345|B|B345|Pracovní doba stanovená pro danou profesi (v hodinách měsíčně)||
|345|C|C345|Vykonávaná pozice zaměstnance||
|345|D|D345|Fond pracovní doby||
|345|F|F345|číslo||
|345|G|G345|desetinné číslo (3)||
|345|J|J345|vykonavanaPozice.fondPracovniDoby.stanovenyFond (ID 10259)||
|345|K|K345|ISPV (FONDSTA)||
|345|M|M345|předchozí období||
|345|R|R345|x||
|345|V|V345|x||
|345|X|X345|Stanovený fond je plánovaný hodinový fond pracovní doby pro danou pracovní pozici odpovídající plnému pracovnímu úvazku. Uvádí se celkový počet hodin za pracovní dny (včetně svátky v jinak pracovní dny), po které byl zaměstnanec v daném měsíci v evidenčním stavu (od počátku roku do konce sledovaného období).||
|346|A|A346|10260||
|346|B|B346|Pracovní doba sjednaná (v hodinách měsíčně)||
|346|C|C346|Vykonávaná pozice zaměstnance||
|346|D|D346|Fond pracovní doby||
|346|F|F346|číslo||
|346|G|G346|desetinné číslo (3)||
|346|J|J346|vykonavanaPozice.fondPracovniDoby.sjednanyFond (ID 10260)||
|346|K|K346|ISPV (FONDSJE)||
|346|M|M346|předchozí období||
|346|R|R346|x||
|346|V|V346|x||
|346|X|X346|Sjednaný fond je plánovaný hodinový fond pracovní doby daného zaměstnance. Uvádí se celkový počet hodin za pracovní dny (včetně svátky v jinak pracovní dny), po které byl zaměstnanec v daném měsíci v evidenčním stavu a odpovídá výši úvazku zaměstnance. Pokud má zaměstnanec zkrácený úvazek, je sjednaný fond pracovní doby nižší než stanovený fond pracovní doby. Pokud pracuje na plný úvazek, je stejný jako stanovený fond pracovní doby pro danou profesi.||
|347|A|A347|10261||
|347|B|B347|Stanovená týdenní pracovní doba zaměstnance (§79 zákoníku práce)||
|347|C|C347|Vykonávaná pozice zaměstnance||
|347|D|D347|Fond pracovní doby||
|347|F|F347|číslo||
|347|G|G347|desetinné číslo (2)||
|347|J|J347|vykonavanaPozice.fondPracovniDoby.stanovenaTydenniDoba (ID 10261)||
|347|K|K347| ||
|347|M|M347|předchozí období||
|347|R|R347|x||
|347|U|U347|x||
|347|V|V347|x||
|347|X|X347|Délka týdenní pracovní doby se označuje jako stanovená týdenní pracovní doba. Maximální délka stanovené týdenní pracovní doby vychází z Úmluvy č. 1 Mezinárodní organizace práce o délce pracovní doby zaměstnanců v průmyslu a ze vztahujících se směrnic Evropské unie. Délka pracovní doby je omezena týdnem a její maximálně přípustný rozsah je stanoven v závislosti na zvoleném pracovním režimu, anebo závisí na druhu práce, kterou zaměstnanec koná.||
|348|A|A348|10263||
|348|B|B348|Datum od||
|348|C|C348|Průběh teoretické a praktické přípravy||
|348|F|F348|datum||
|348|H|H348|1-N||
|348|J|J348|teoretickaPraktickaPriprava.obdobi.datumOd (ID 10263)||
|348|K|K348| ||
|348|M|M348|ne - datum||
|348|R|R348|x||
|348|S|S348|x||
|348|V|V348|x||
|348|X|X348|Datum zahájení teoretické a praktické přípravy bez věkového omezení. ||
|349|A|A349|10264||
|349|B|B349|Datum do||
|349|C|C349|Průběh teoretické a praktické přípravy||
|349|F|F349|datum||
|349|H|H349|1-N||
|349|J|J349|teoretickaPraktickaPriprava.obdobi.datumDo (ID 10264)||
|349|K|K349| ||
|349|M|M349|ne - datum||
|349|R|R349|x||
|349|S|S349|x||
|349|V|V349|x||
|349|X|X349|Datum ukončení teoretické a praktické přípravy.||
|350|A|A350|10265||
|350|B|B350|Počet dní v evidenčním stavu||
|350|C|C350|Průběh zaměstnání v daném měsíci||
|350|D|D350|Odpracované dny||
|350|F|F350|číslo||
|350|G|G350|celé číslo||
|350|J|J350|prubehZamestnani.odpracovaneDny.dnyEvidencniStav (ID 10265)||
|350|K|K350|ISPV (EVIDDNY)||
|350|M|M350|předchozí období||
|350|R|R350|x||
|350|U|U350|x||
|350|V|V350|x||
|350|X|X350|Uvede se počet dní v měsíci, ve kterých byl zaměstnanec v daném pracovním/služebním/členském poměru v evidenčním stavu zaměstnanců.\nV případě zaměstnanců pracujících na základě dohody o pracích konaných mimo pracovní poměr se uvede nulová hodnota.||
|351|A|A351|10267||
|351|B|B351|Počet odpracovaných dnů||
|351|C|C351|Průběh zaměstnání v daném měsíci||
|351|D|D351|Odpracované dny||
|351|F|F351|číslo||
|351|G|G351|celé číslo||
|351|J|J351|prubehZamestnani.odpracovaneDny.dnyOdpracovanePocet (ID 10267)||
|351|K|K351| ||
|351|M|M351|předchozí období||
|351|R|R351|x||
|351|S|S351|x||
|351|T|T351|x||
|351|V|V351|x||
|351|X|X351|Odpracovaná doba zaměstnance v daném pracovním poměru (podle § 353 odst. 2 a 3 ZP) v kumulaci od počátku roku do konce sledovaného období v hodinách včetně přesčasových hodin. Nezahrnují se neodpracované hodiny za svátky v jinak pracovní dny, i když se měsíční mzda ne||
|352|A|A352|10268||
|352|B|B352|Počet odpracovaných hodin||
|352|C|C352|Průběh zaměstnání v daném měsíci||
|352|D|D352|Odpracované hodiny||
|352|F|F352|číslo||
|352|G|G352|desetinné číslo (3)||
|352|J|J352|prubehZamestnani.odpracovaneHodiny.pocet (ID 10268)||
|352|K|K352|ISPV (ODPRACD)||
|352|M|M352|předchozí období||
|352|R|R352|x||
|352|S|S352|x||
|352|U|U352|x||
|352|V|V352|x||
|352|X|X352|Skutečně odpracované hodiny ve stanovené pracovní době, v přesčase (za hodiny odpracované v přesčase se nepovažují hodiny, za které bylo poskytnuto náhradní volno), čas strávený přípravou pracoviště, čištěním nástrojů a přístrojů, čekáním na práci (např. při poruše, nehodě, výluce). Nezahrnují se hodiny placené, ale neodpracované (např.. svátky, dovolená), nepřítomnost z důvodu nemoci apod.||
|353|A|A353|10269||
|353|B|B353|Přesčasové hodiny (z odpracovaných)||
|353|C|C353|Průběh zaměstnání v daném měsíci||
|353|D|D353|Odpracované hodiny||
|353|F|F353|číslo||
|353|G|G353|desetinné číslo (3)||
|353|J|J353|prubehZamestnani.odpracovaneHodiny.rozpad.prescas (ID 10269)||
|353|K|K353|ISPV (PRESCAS)||
|353|M|M353|předchozí období||
|353|R|R353|x||
|353|V|V353|x||
|353|X|X353|Počet přesčasových hodin odpracovaných v daném měsíci. Za hodiny odpracované v přesčase se považuje každá hodina odpracovaná zaměstnancem na příkaz zaměstnavatele nebo s jeho souhlasem nad stanovenou týdenní pracovní dobu. Jedná se o přesčasové hodiny, za které byl poskytnut příplatek (vč. přesčasů odpracovaných dle ustanovení § 114 odst. 3 ZP), i přesčasové hodiny, za které může být v budoucnu čerpáno náhradní volno. Hodiny, za které bylo poskytnuto náhradní volno, se do přesčasu nezapočítávají. Hodiny náhradního volna za přesčas odpracovaný v předchozích měsících se zahrnují jako záporné (výsledná hodnota položky tak může být i záporná). ||
|354|A|A354|10270||
|354|B|B354|Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - uran||
|354|C|C354|Průběh zaměstnání v daném měsíci||
|354|D|D354|Odpracované směny||
|354|E|E354|Hlubinné hornictví||
|354|F|F354|číslo||
|354|G|G354|celé číslo||
|354|J|J354|prubehZamestnani.odpracovaneHodiny.rozpad.hornictvi.smenyUran (ID 10270)||
|354|K|K354| ||
|354|M|M354|předchozí období||
|354|R|R354|x||
|354|S|S354|x||
|354|V|V354|x||
|354|X|X354|Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - uran za dané období||
|355|A|A355|10271||
|355|B|B355|Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - ostatní||
|355|C|C355|Průběh zaměstnání v daném měsíci||
|355|D|D355|Odpracované směny||
|355|E|E355|Hlubinné hornictví||
|355|F|F355|číslo||
|355|G|G355|celé číslo||
|355|J|J355|prubehZamestnani.odpracovaneHodiny.rozpad.hornictvi.smenyOstatni (ID 10271)||
|355|K|K355| ||
|355|M|M355|předchozí období||
|355|R|R355|x||
|355|S|S355|x||
|355|V|V355|x||
|355|X|X355|Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - ostatní za dané období||
|356|A|A356|10272||
|356|B|B356|Datum dosažení expozice NPE||
|356|C|C356|Průběh zaměstnání v daném měsíci||
|356|D|D356|Odpracované směny||
|356|E|E356|Hlubinné hornictví||
|356|F|F356|datum||
|356|J|J356|prubehZamestnani.odpracovaneHodiny.rozpad.hornictvi.expoziceNpeDosazeniDatum (ID 10272)||
|356|K|K356| ||
|356|M|M356|ne - datum||
|356|R|R356|x||
|356|S|S356|x||
|356|V|V356|x||
|356|X|X356|Datum, kdy zaměstnanec dosáhl nejvyšší přípustnou expozici.||
|357|A|A357|10273||
|357|B|B357|Počet odpracovaných hodin v rámci rizikové práce (§ 37d odst. 2 ZDP), práce zdravotnického záchranáře (§ 37d odst. 3) a práce člena jednotky HZS podniku (§ 37d odst. 3)  ||
|357|C|C357|Průběh zaměstnání v daném měsíci||
|357|D|D357|Odpracované hodiny||
|357|E|E357|Riziková práce||
|357|F|F357|číslo||
|357|G|G357|celé číslo||
|357|J|J357|prubehZamestnani.odpracovaneHodiny.rozpad.riziko.hodinyOdpracovanePocet (ID 10273)||
|357|K|K357| ||
|357|M|M357|předchozí období||
|357|R|R357|x||
|357|S|S357|x||
|357|U|U357|x||
|357|V|V357|x||
|357|X|X357|Počet opracovaných hodin v rámci rizikové práce (§ 37d odst. 2 ZDP), práce zdravotnického záchranáře (§ 37d odst. 3) a práce člena jednotky HZS podniku (§ 37d odst. 3)  celkem. Doba výkonu rizikové práce, při které působí na zaměstnance současně více rizikových faktorů, se hodnotí pouze jednou. Do počtu hodin rizikové práce se nezahrnuje riziková práce, která je současně výkonem práce zdravotnického záchranáře nebo člena jednotky HSZ podniku.||
|358|A|A358|10274||
|358|B|B358|Kategorizace rizika||
|358|C|C358|Průběh zaměstnání v daném měsíci||
|358|D|D358|Odpracované hodiny||
|358|E|E358|Riziková práce||
|358|F|F358|číselník||
|358|H|H358|1-N||
|358|J|J358|prubehZamestnani.odpracovaneHodiny.rozpad.riziko.kategorizaceRizika (ID 10274)||
|358|K|K358| ||
|358|L|L358|CIS Kategorizace rizika||
|358|M|M358|předchozí období||
|358|R|R358|x||
|358|S|S358|x||
|358|U|U358|x||
|358|V|V358|x||
|358|W|W358|1 - N kategorií rizika||
|359|A|A359|10275||
|359|B|B359|Celkový počet neodpracovaných hodin||
|359|C|C359|Průběh zaměstnání v daném měsíci||
|359|D|D359|Neodpracované hodiny||
|359|F|F359|číslo||
|359|G|G359|desetinné číslo (3)||
|359|J|J359|prubehZamestnani.neodpracovaneHodiny.hodinyNeodpracCelkem (ID 10275)||
|359|K|K359|ISPV (ABSCELK)||
|359|M|M359|předchozí období||
|359|R|R359|x||
|359|U|U359|x||
|359|V|V359|x||
|359|X|X359|Celkový počet neodpracovaných hodin od začátku měsíce ze sjednaného hodinového fondu  pracovní doby daného pracovního/služebního poměru zaměstnance. Např. dovolená, svátky v jinak pracovní dny (zahrnují se i neodpracované hodiny, kdy se měsíční mzda nekrátí), doba překážek v práci, doba pracovní neschopnosti, ošetřování člena rodiny, neplacené volno, atd. V případě DPP a DPČ se jedná o omluvené neodpracované hodiny (zejména dovolená, překážky v práci, doba pracovní neschopnosti).||
|360|A|A360|10276||
|360|B|B360|Počet neodpracovaných hodin s náhradou či nekrácením mzdy||
|360|C|C360|Průběh zaměstnání v daném měsíci||
|360|D|D360|Neodpracované hodiny||
|360|F|F360|číslo||
|360|G|G360|desetinné číslo (3)||
|360|J|J360|prubehZamestnani.neodpracovaneHodiny.hodinyNeodpracNahrada (ID 10276)||
|360|K|K360|ISPV (ABSPLAC)||
|360|M|M360|předchozí období||
|360|R|R360|x||
|360|V|V360|x||
|360|X|X360|Počet neodpracovaných hodin s náhradou či nekrácením mzdy za sledovaný měsíc. Uvedou se neodpracované hodiny s náhradou mzdy z důvodů dovolené, svátků v jinak pracovní dny (zahrnují se i neodpracované dny, kdy se mzda nekrátí), důležitých překážek v práci na straně zaměstnance, překážek v práci z důvodu obecného zájmu a překážek v práci na straně zaměstnavatele. Neuvádí se hodiny neodpracované z důvodu dočasné pracovní neschopnosti a ošetřování člena rodiny.||
|361|A|A361|10278||
|361|B|B361|Počet neodpracovaných hodin z důvodu dočasné pracovní neschopnosti, za které je ze strany zaměstnavatele poskytována náhrada mzdy ||
|361|C|C361|Průběh zaměstnání v daném měsíci||
|361|D|D361|Neodpracované hodiny||
|361|F|F361|číslo||
|361|G|G361|desetinné číslo (3)||
|361|J|J361|prubehZamestnani.neodpracovaneHodiny.hodinyNeodpracNeschop (ID 10278)||
|361|K|K361|ISPV (ABSNEMZ)||
|361|M|M361|předchozí období||
|361|R|R361|x||
|361|U|U361|x||
|361|V|V361|x||
|361|X|X361|Počet hodin z fondu pracovní doby neodpracovaných z důvodu dočasné pracovní neschopnosti (příp. karantény), za které se neposkytuje nemocenská dávka podle zákona o nemocenském pojištění (zákon č. 187/2006 Sb.). Jedná se tedy o dny nemoci, kdy náhradu mzdy platí zaměstnavatel.||
|362|A|A362|10277||
|362|B|B362|Počet neodpracovaných hodin v důsledku dočasné pracovní neschopnosti bez náhrady mzdy hrazené zaměstnavatelem||
|362|C|C362|Průběh zaměstnání v daném měsíci||
|362|D|D362|Neodpracované hodiny||
|362|F|F362|číslo||
|362|G|G362|desetinné číslo (3)||
|362|J|J362|prubehZamestnani.neodpracovaneHodiny.hodinyNeodpracBezNahrady (ID 10277)||
|362|K|K362|ISPV (rozdíl položek ABSNEMOC-ABSNEMZ)||
|362|M|M362|předchozí období||
|362|R|R362|x||
|362|V|V362|x||
|362|X|X362|Počet hodin z fondu pracovní doby neodpracovaných z důvodu dočasné pracovní neschopnosti (příp. karantény), za které se neposkytuje náhrada mzdy. Do této položky se nezahrnuje ošetřování člena rodiny.||
|363|A|A363|10279||
|363|B|B363|Počet neodpracovaných hodin v důsledku čerpání dovolené na zotavenou||
|363|C|C363|Průběh zaměstnání v daném měsíci||
|363|D|D363|Neodpracované hodiny||
|363|F|F363|číslo||
|363|G|G363|desetinné číslo (3)||
|363|J|J363|prubehZamestnani.neodpracovaneHodiny.hodinyNeodpracDovol (ID 10279)||
|363|K|K363|ISPV (ABSDOVOL)||
|363|M|M363|předchozí období||
|363|R|R363|x||
|363|U|U363|x||
|363|V|V363|x||
|363|X|X363|Počet čerpaných hodin dovolené v daném měsíci. Nepatří sem proplacená dovolená.||
|364|A|A364|10280||
|364|B|B364|Počet neodpracovaných hodin v důsledku ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné ||
|364|C|C364|Průběh zaměstnání v daném měsíci||
|364|D|D364|Neodpracované hodiny||
|364|F|F364|číslo||
|364|G|G364|celé číslo||
|364|J|J364|prubehZamestnani.neodpracovaneHodiny.hodinyNeodpracOcr (ID 10280)||
|364|K|K364| ||
|364|M|M364|předchozí období||
|364|R|R364|x||
|364|U|U364|x||
|364|V|V364|x||
|364|X|X364|Počet neodpracovaných hodin v důsledku ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné||
|365|A|A365|10471||
|365|B|B365|Překážky na straně zaměstnance s náhradou mzdy/platu - počet neodpracovaných hodin||
|365|C|C365|Průběh zaměstnání v daném měsíci||
|365|D|D365|Překážky v práci||
|365|F|F365|číslo||
|365|G|G365|desetinné číslo (3)||
|365|J|J365|prubehZamestnani.prekazkyVPraci.prekazkaZamestnanec (ID 10471)||
|365|K|K365| ||
|365|M|M365|předchozí období||
|365|R|R365|x||
|365|U|U365|x||
|365|V|V365|x||
|365|X|X365|Překážky v práci na straně zaměstnavatele,||
|366|A|A366|10472||
|366|B|B366|Překážky na straně zaměstnavatele - počet neodpracovaných hodin||
|366|C|C366|Průběh zaměstnání v daném měsíci||
|366|D|D366|Překážky v práci||
|366|F|F366|číslo||
|366|G|G366|desetinné číslo (3)||
|366|J|J366|prubehZamestnani.prekazkyVPraci.prekazkaZamestnavatel (ID 10472)||
|366|K|K366| ||
|366|M|M366|předchozí období||
|366|R|R366|x||
|366|U|U366|x||
|366|V|V366|x||
|366|X|X366|Překážky v práci na straně zaměstnance, pokud se jedná o překážky, při kterých má zaměstnanec nárok na náhradu mzdy nebo platu (tyto překážky stanovuje NV 590/2006). ||
|367|A|A367|10535||
|367|B|B367|Základ pro výpočet daně||
|367|C|C367|Příjem v daném měsíci||
|367|D|D367|Daň||
|367|F|F367|číslo||
|367|G|G367|celé číslo||
|367|J|J367|prijem.dan.zakladDane (ID 10535)||
|367|M|M367|předchozí období||
|367|R|R367|x||
|367|T|T367|x||
|367|V|V367|x||
|367|X|X367|Jedná se o atribut na úrovni PPV, do kterého bude Zaměstnavatel uvádět částky základu pro výpočet zálohy na daň nebo výpočet daně podle srážkové daně. Určení, o jaký typ zálohy na daň se u PPV jedná FS pozná z atributu 10239 – Druh činnosti, který bude u každého PPV přiřazen.||
|368|A|A368|10410||
|368|B|B368|Výplatní termín při nastání specifické právní skutečnosti||
|368|C|C368|Příjem v daném měsíci||
|368|D|D368|Specifická právní skutečnost||
|368|F|F368|datum||
|368|J|J368|prijem.specifickaSkutecnost.vyplatniTermin (ID 10410)||
|368|K|K368| ||
|368|M|M368|ne - datum||
|368|R|R368|x||
|368|T|T368|x||
|368|W|W368|Relevantní pouze pokud je na úrovni Zaměstnavatele vyplněn Typ a Datum Rozhodné skutečnosti.||
|368|X|X368|Datum, kdy nastala skutečnost vztahující se ke kódu vyúčtování.||
|369|A|A369|10328||
|369|B|B369|Mzda za práci zúčtovaná||
|369|C|C369|Mzda||
|369|D|D369|Mzda zúčtovaná||
|369|F|F369|číslo||
|369|G|G369|celé číslo||
|369|J|J369|mzda.mzdaZuctovana (ID 10328)||
|369|K|K369|ISPV (MZDA)||
|369|M|M369|předchozí období||
|369|R|R369|x||
|369|V|V369|x||
|369|X|X369|Peněžní plnění nebo naturální mzdy a platy za práci, kterou zaměstnanec vykonal v pracovním poměru. Jedná se o základní mzdy/tarifní platy, příplatky a ostatní složky mzdy stanovené dle § 109 odst. 2 až 4 zákona c. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů, ve znění pozdějších předpisů). Jedná se o mzdy bez OON snížené o náhrady mzdy. Za mzdu se nepovažují plnění poskytnutá podle zvláštních předpisů v souvislosti se zaměstnáním, např.:\n- náhrada mzdy\n- odstupné\n- cestovní náhrady\n- výnosy z kapitálových podílů (akcií) nebo obligací\n- odměna za pracovní pohotovost\nPři uplatnění konta pracovní doby se neuvádí dosažená mzda podle § 120 odst. 2 písm. b) ZP. Nezahrnují se plnění, která nemají charakter mzdy za práci (např. odměny za pracovní a životní jubilea, odměny při narození dítěte, odměny při podchodu do důchodu, ...)||
|370|A|A370|10329||
|370|B|B370|Tarifní mzdy||
|370|C|C370|Mzda||
|370|D|D370|Mzda zúčtovaná||
|370|F|F370|číslo||
|370|G|G370|celé číslo||
|370|J|J370|mzda.mzdaRozpad.tarif (ID 10329)||
|370|M|M370|předchozí období||
|370|R|R370|x||
|370|V|V370|x||
|370|X|X370|Základní mzdy/platy(tarify) vyplácené za práci podle mzdových a platových tarifů zaměstnancům v úkolových, časových a měsíčních typech odměňování. Zahrnuje se také "základní" složka smluvních mezd nebo celá smluvní mzdy, pokud není členěna na tarifní a pobídkovou složku.||
|371|A|A371|10330||
|371|B|B371|Prémie a odměny pravidelné||
|371|C|C371|Mzda||
|371|D|D371|Mzda zúčtovaná||
|371|F|F371|číslo||
|371|G|G371|celé číslo||
|371|J|J371|mzda.mzdaRozpad.odmenyPravidelne (ID 10330)||
|371|K|K371|ISPV (POPRAV)||
|371|M|M371|předchozí období||
|371|R|R371|x||
|371|V|V371|x||
|371|X|X371|Jedná se o prémie a odměny pravidelně měsíčně zúčtované se mzdou za daný kalendářní měsíc. Patří sem i pohyblivá složka mzdy (výkonnostní, motivační), která je označovaná za osobní příplatek.||
|372|A|A372|10331||
|372|B|B372|Prémie a odměny nepravidelné||
|372|C|C372|Mzda||
|372|D|D372|Mzda zúčtovaná||
|372|F|F372|číslo||
|372|G|G372|celé číslo||
|372|J|J372|mzda.mzdaRozpad.odmenyNepravidelne (ID 10331)||
|372|K|K372|ISPV (PONEPRAV)||
|372|M|M372|předchozí období||
|372|R|R372|x||
|372|V|V372|x||
|372|X|X372|Jedná se odměny a prémie nepravidelně zúčtované ve mzdě za daný měsíc. Zahrnují se sem všechny platby zaměstnancům, které nejsou pravidelně zúčtovány ve mzdě ve výplatním období. Do nepravidelných odměn se zahrnují např. 13. a 14. mzdy, čtvrtletní a pololetní odměny, mimořádné odměny. Nezahrnují se položky, které nejsou mzdou. ||
|373|A|A373|10332||
|373|B|B373|Příplatky celkem||
|373|C|C373|Mzda||
|373|D|D373|Příplatky||
|373|F|F373|číslo||
|373|G|G373|celé číslo||
|373|J|J373|mzda.mzdaRozpad.priplatky.celkem (ID 10332)||
|373|K|K373| ||
|373|M|M373|předchozí období||
|373|R|R373|x||
|373|V|V373|x||
|373|X|X373|Jde o součet příplatků (z celkové mzdy) zúčtované v daným měsíci. Zahrnuje pouze zákonné příplatky\n- za práci ve svátek,\n- za práci v noci,\n- za práci o sobotách a nedělích,\n- za práci ve ztíženém a zdraví škodlivém pracovním prostředí\nnebo příplatky, které má  společnost zakotvené ve vnitřním předpisu nebo v kolektivní smlouvě, např. příplatek za\n- směnnost,\n- práci ve výškách,\n- uznané certifikáty,\n- zaškolování nových zaměstnanců, ....\nPatří sem i nedoplatek do minimální a zaručené mzdy.\nNejsou zahrnuty pohyblivé složky mzdy (výkonnostní, motivační), ty se započítávají do prémií a odměn pravidelných. Příplatek za přesčas se uvádí samostatně.||
|374|A|A374|10333||
|374|B|B374|Příplatky za práci přesčas||
|374|C|C374|Mzda||
|374|D|D374|Příplatky||
|374|F|F374|číslo||
|374|G|G374|celé číslo||
|374|J|J374|mzda.mzdaRozpad.priplatky.prescas (ID 10333)||
|374|K|K374|ISPV (PRIPCAS)||
|374|M|M374|předchozí období||
|374|R|R374|x||
|374|V|V374|x||
|374|X|X374|Příplatky za přesčasovou práci podle § 114, resp. 127 zákona c. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů, nebo vnitřního mzdového předpisu. ||
|375|A|A375|10334||
|375|B|B375|Příplatky za práci v noci||
|375|C|C375|Mzda||
|375|D|D375|Příplatky||
|375|F|F375|číslo||
|375|G|G375|celé číslo||
|375|J|J375|mzda.mzdaRozpad.priplatky.nocni (ID 10334)||
|375|K|K375| ||
|375|M|M375|předchozí období||
|375|R|R375|x||
|375|V|V375|x||
|375|X|X375|Příplatky za noční práci podle § 116, resp. 125 č. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů, nebo vnitřního mzdového předpisu. ||
|376|A|A376|10335||
|376|B|B376|Příplatky za práci o sobotách a nedělích||
|376|C|C376|Mzda||
|376|D|D376|Příplatky||
|376|F|F376|číslo||
|376|G|G376|celé číslo||
|376|J|J376|mzda.mzdaRozpad.priplatky.sobotaNedele (ID 10335)||
|376|K|K376| ||
|376|M|M376|předchozí období||
|376|R|R376|x||
|376|V|V376|x||
|376|X|X376|Příplatky za práci v sobotu a neděli podle § 118, resp. 126 č. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů, nebo vnitřního mzdového předpisu. ||
|377|A|A377|10336||
|377|B|B377|Příplatky za práci ve svátek||
|377|C|C377|Mzda||
|377|D|D377|Příplatky||
|377|F|F377|číslo||
|377|G|G377|celé číslo||
|377|J|J377|mzda.mzdaRozpad.priplatky.svatek (ID 10336)||
|377|K|K377| ||
|377|M|M377|předchozí období||
|377|R|R377|x||
|377|V|V377|x||
|377|X|X377|Příplatky za práci ve svátek podle § 115, resp. 135 č. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů, nebo vnitřního mzdového předpisu. ||
|378|A|A378|10337||
|378|B|B378|Náhrady mzdy zúčtované||
|378|C|C378|Mzda||
|378|D|D378|Náhrady||
|378|F|F378|číslo||
|378|G|G378|celé číslo||
|378|J|J378|mzda.nahrady.mzdyZuctovane (ID 10337)||
|378|K|K378|ISPV (NAHRADY)||
|378|M|M378|předchozí období||
|378|R|R378|x||
|378|U|U378|x||
|378|V|V378|x||
|378|X|X378|Součet všech náhrad mzdy/platu, které hradí zaměstnavatel na základě zákona c. 262/2006 Sb., zákoník práce, resp. zákona č. 221/1999 Sb., o vojácích z povoláníve znění pozdějších předpisů, nebo kolektivní smlouvy za neodpracovaný čas pro překážky na straně zaměstnance a na straně zaměstnavatele (včetně náhrady mzdy/platu při okamžitém zrušení pracovního poměru zaměstnancem podle § 56, odst. 2 zákona c. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů) a za dobu čerpání dovolené a placených svátku. Pokud jsou náhrady mezd/platu součástí smluvních mezd/platů, pak se zde samostatně nevykazují. Do náhrad mezd se nezahrnují náhrady mzdy nebo platu za dobu trvání dočasné pracovní neschopnosti nebo karantény placené zaměstnavatelem (§ 192 odst. 1 a 2 zákona c. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů).\nJedná se o náhrady za dobu specifikovanou v položce "Počet neodpracovaných hodin s náhradou či nekrácením mzdy".||
|379|A|A379|10338||
|379|B|B379|Náhrady za dovolenou||
|379|C|C379|Mzda||
|379|D|D379|Náhrady||
|379|F|F379|číslo||
|379|G|G379|celé číslo||
|379|J|J379|mzda.nahrady.dovolena (ID 10338)||
|379|K|K379| ||
|379|M|M379|předchozí období||
|379|R|R379|x||
|379|U|U379|x||
|379|V|V379|x||
|379|X|X379|Náhrady mzdy/platu za dovolenou na zotavenou, dodatkovou dovolenou apod. podle zákona č. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů, smluv a mzdových předpisů.\nCelková částka služebního příjmu za dobu služebního  volna zúčtovaná k výplatě příslušníkovi v Kč jako kumulace za sledované období.||
|380|A|A380|10339||
|380|B|B380|Náhrady za svátky||
|380|C|C380|Mzda||
|380|D|D380|Náhrady||
|380|F|F380|číslo||
|380|G|G380|celé číslo||
|380|J|J380|mzda.nahrady.svatky (ID 10339)||
|380|K|K380| ||
|380|M|M380|předchozí období||
|380|R|R380|x||
|380|U|U380|x||
|380|V|V380|x||
|380|X|X380|Náhrady mzdy/platu za státní svátky a dny pracovního klidu, připadající na jinak běžné pracovní dny dle § 115 odst. 3 zákona č. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů, resp. zákona č. 221/1999 Sb., o vojácích z povolání, ve znění pozdějších předpisů.||
|381|A|A381|10340||
|381|B|B381|Náhrady - překážky na straně zaměstnavatele||
|381|C|C381|Mzda||
|381|D|D381|Náhrady||
|381|F|F381|číslo||
|381|G|G381|celé číslo||
|381|J|J381|mzda.nahrady.prekazkyZamestnavatel (ID 10340)||
|381|K|K381| ||
|381|M|M381|předchozí období||
|381|R|R381|x||
|381|U|U381|x||
|381|V|V381|x||
|381|X|X381|Náhrady mzdy/platu za prostoje (nezaviněné zaměstnancem a nezaplacené ve mzdách za vykonanou práci), za výluky a náhrady při zaměstnavatelem organizovaném zkrácení časového fondu (při překážkách na straně zaměstnavatele dle § 207 až 210 zákona č. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů). Náhrada mzdy/platu ve výši průměrného výdělku za dobu, která odpovídá délce výpovědní doby, příslušející zaměstnanci, který okamžitě zrušil pracovní poměr (§ 56, odst. 2 zákona č. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů).||
|382|A|A382|10341||
|382|B|B382|Náhrady - překážky na straně zaměstnance||
|382|C|C382|Mzda||
|382|D|D382|Náhrady||
|382|F|F382|číslo||
|382|G|G382|celé číslo||
|382|J|J382|mzda.nahrady.prekazkyZamestnanec (ID 10341)||
|382|K|K382| ||
|382|M|M382|předchozí období||
|382|R|R382|x||
|382|U|U382|x||
|382|V|V382|x||
|382|X|X382|Náhrady mzdy/platu za důležité překážky v práci, které zaměstnanci přísluší podle § 199 zákona č. 262/2006 Sb., zákoník práce, ve znění pozdějších předpisů, kolektivní smlouvy nebo vnitřních předpisů. Jde zejména o náhradu za  poskytnuté volno při vyšetření nebo ošetření zaměstnance nebo rodinného příslušníka ve zdravotnickém zařízení, narození dítěte, úmrtí rodinného příslušníka, svatbě vlastní nebo dětí či rodičů apod.||
|383|A|A383|10342||
|383|B|B383|Náhrady při dočasné pracovní neschopnosti (bez srážek nad rámec §192/3 zákoníku práce)||
|383|C|C383|Mzda||
|383|D|D383|Náhrady||
|383|F|F383|číslo||
|383|G|G383|celé číslo||
|383|J|J383|mzda.nahrady.docasnaNeschopnost (ID 10342)||
|383|K|K383| ||
|383|M|M383|předchozí období||
|383|R|R383|x||
|383|U|U383|x||
|383|V|V383|x||
|383|X|X383|Celková částka náhrad mzdy/platu zúčtovaná k výplatě zaměstnanci za dobu trvání dočasné pracovní neschopnosti nebo karantény placené zaměstnavatelem za daný měsíc. Jedná se pouze o částky placené zaměstnavatelem podle § 192 zákoníku práce, nikoliv nemocenské dávky.  ||
|384|A|A384|10343||
|384|B|B384|Odměny za pracovní pohotovost||
|384|C|C384|Mzda||
|384|D|D384|Odměny||
|384|F|F384|číslo||
|384|G|G384|celé číslo||
|384|J|J384|mzda.odmeny.pohotovost (ID 10343)||
|384|K|K384|IPSV (POHOTOV)||
|384|M|M384|předchozí období||
|384|R|R384|x||
|384|V|V384|x||
|384|X|X384|Odměny za pracovní pohotovost zúčtované v daném měsíci podle § 140 ZP.||
|385|A|A385|10345||
|385|B|B385|Průměrný (hrubý) hodinový výdělek||
|385|C|C385|Mzda||
|385|D|D385|Výdělek||
|385|F|F385|číslo||
|385|G|G385|desetinné číslo (3)||
|385|J|J385|mzda.vydelek.vydelekPrumernyHod (ID 10345)||
|385|K|K385|ISPV (PRUMVYD)||
|385|M|M385|předchozí období||
|385|R|R385|x||
|385|V|V385|x||
|385|X|X385|Průměrný výdělek zjištěný pro náhrady mzdy zaměstnance v daném pracovním poměru podle § 33 a §356 odst. 1 ZP.  Jde o průměrný hodinový výdělek vypočtený z mezd za poslední čtvrtletí a používaný pro výpočet náhrad mezd v následujícím čtvrtletí.||
|386|A|A386|10354||
|386|B|B386|Pojištění od||
|386|C|C386|Průběh pojištění v daném měsíci||
|386|D|D386|Trvání pojištění||
|386|F|F386|datum||
|386|J|J386|pojisteni.trvani.pojisteniOd (ID 10354)||
|386|K|K386| ||
|386|M|M386|ne - datum||
|386|R|R386|x||
|386|S|S386|x||
|386|T|T386|x||
|386|U|U386|x||
|386|V|V386|x||
|386|X|X386|Datum, od kterého ve sledovaném období trvá pojištění.||
|387|A|A387|10355||
|387|B|B387|Pojištění do||
|387|C|C387|Průběh pojištění v daném měsíci||
|387|D|D387|Trvání pojištění||
|387|F|F387|datum||
|387|J|J387|pojisteni.trvani.pojisteniDo (ID 10355)||
|387|K|K387| ||
|387|M|M387|ne - datum||
|387|R|R387|x||
|387|S|S387|x||
|387|T|T387|x||
|387|U|U387|x||
|387|V|V387|x||
|387|X|X387|Datum, do kterého trvá pojištění.||
|388|A|A388|10240||
|388|B|B388|Kód ELDP||
|388|C|C388|Průběh pojištění v daném měsíci||
|388|D|D388|ELDP||
|388|F|F388|číselník||
|388|H|H388|1-N||
|388|J|J388|pojisteni.eldpSeznam.eldp.kod (ID 10240)||
|388|K|K388| ||
|388|L|L388|CIS Kód ELDP||
|388|M|M388|předchozí období||
|388|R|R388|x||
|388|S|S388|x||
|388|T|T388|x||
|388|V|V388|x||
|388|W|W388|1 - N kódů ELDP, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|388|X|X388|Kód ELDP se vyplňuje ve tvaru trojmístného údaje, který obsahuje tři dále uvedené znaky/proměnné: \n\nPrvní znak trojmístného údaje se vyplňuje hodnotou „1” – „9” a „A” – „ZC”. Označuje druh výdělečné činnosti a umožňuje rozlišení více pojistných vztahů u téhož zaměstnavatele.  \nDruhý znak trojmístného údaje umožňuje rozlišení situací, kdy:  \n•	jsou po skončení výdělečné činnosti dodatečně zúčtovány příjmy započitatelné do vyměřovacího základu (uvede se znak „P“).\n•	do zaměstnání nastupuje pojištěnec, který již dovršil důchodový věk, pobírá starobní důchod ve výši poloviny nebo starobní důchod vůbec nepobírá, případně, pojištěnec za trvání výdělečné činnosti dovršuje důchodový věk a jeho pojištění trvá i nadále (uvede se znak „D“), \n•	je nutné hodnotit jako dobu důchodového pojištění pouze část měsíce (uvede se znak „V“).\nTřetí znak trojmístného údaje se vyplňuje:\n•	hodnotou „B“, „E“, „F“, „J“,  „V“ a „Z“ v situacích, kdy není provádějícím orgánem sociálního zabezpečení ČSSZ\n•	hodnotou  „T“ v případě výkonu výdělečné činnosti ve výkonu trestu, ve výkonu zabezpečovací detence a nebo ve vazbě.||
|389|A|A389|10241||
|389|B|B389|Platnost kódu od||
|389|C|C389|Průběh pojištění v daném měsíci||
|389|D|D389|ELDP||
|389|F|F389|datum||
|389|H|H389|1-N||
|389|J|J389|pojisteni.eldpSeznam.eldp.platnostOd (ID 10241)||
|389|K|K389| ||
|389|M|M389|ne - datum||
|389|R|R389|x||
|389|S|S389|x||
|389|T|T389|x||
|389|V|V389|x||
|389|W|W389|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|389|X|X389|Datum platnosti kódu ELDP.||
|390|A|A390|10242||
|390|B|B390|Platnost kódu do||
|390|C|C390|Průběh pojištění v daném měsíci||
|390|D|D390|ELDP||
|390|F|F390|datum||
|390|H|H390|1-N||
|390|J|J390|pojisteni.eldpSeznam.eldp.platnostDo (ID 10242)||
|390|K|K390| ||
|390|M|M390|ne - datum||
|390|R|R390|x||
|390|S|S390|x||
|390|T|T390|x||
|390|V|V390|x||
|390|W|W390|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|390|X|X390|Datum skončení platnosti kódu ELDP.||
|391|A|A391|10356||
|391|B|B391|Počet kalendářních dnů trvání doby důchodového pojištění v daném kalendářním měsíci||
|391|C|C391|Průběh pojištění v daném měsíci||
|391|D|D391|ELDP||
|391|F|F391|číslo||
|391|G|G391|celé číslo||
|391|H|H391|1-N||
|391|J|J391|pojisteni.eldpSeznam.eldp.pocetDnu (ID 10356)||
|391|K|K391| ||
|391|M|M391|předchozí období||
|391|R|R391|x||
|391|S|S391|x||
|391|T|T391|x||
|391|U|U391|x||
|391|V|V391|x||
|391|W|W391|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|391|X|X391|Počet kalendářních dnů trvání pojištění v daném kalendářním měsíci. Uvádí se počet kalendářních dnů trvání pojištění v daném měsíci. ||
|392|A|A392|10245||
|392|B|B392|Vyměřovací základ||
|392|C|C392|Průběh pojištění v daném měsíci||
|392|D|D392|ELDP||
|392|F|F392|číslo||
|392|G|G392|celé číslo||
|392|H|H392|1-N||
|392|J|J392|pojisteni.eldpSeznam.eldp.vymerovaciZaklad (ID 10245)||
|392|K|K392| ||
|392|M|M392|předchozí období||
|392|R|R392|x||
|392|S|S392|x||
|392|T|T392|x||
|392|V|V392|x||
|392|W|W392|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|392|X|X392|Uvádí se zúčtovaný příjem započitatelný do vyměřovacího základu pro stanovení pojistného ve smyslu § 5 odst. 1 a odst. 4 zákona č. 589/1992 Sb. Vyměřovací základ se do ELDP uvádí v plné výši bez ohledu na skutečnost, že odvodu pojistného podléhá, ve smyslu § 15a\nzákona č. 589/1992 Sb., pouze maximální vyměřovací základ.||
|393|A|A393|10357||
|393|B|B393|Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|393|C|C393|Průběh pojištění v daném měsíci||
|393|D|D393|ELDP||
|393|E|E393|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|393|F|F393|číslo||
|393|G|G393|celé číslo||
|393|H|H393|1-N||
|393|J|J393|pojisteni.eldpSeznam.eldp.vylouceneDny.vylouceneDobyCelkem (ID 10357)||
|393|K|K393| ||
|393|M|M393|předchozí období||
|393|N|N393|N||
|393|O|O393|= "10358" + "10359" + "10360" + "10362" + "10536"\n----\npotřeba doplnit infobox, že položka může být přepsána, neboť v ojedinělých situacích neplatně rozvázaného pracovní poměru se do položky ještě dopočítává související doba||
|393|P|P393| ||
|393|R|R393|x||
|393|S|S393|x||
|393|T|T393|x||
|393|V|V393|x||
|393|W|W393|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|393|X|X393|Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) zákona č. 155/1995 Sb. - počet dnů||
|394|A|A394|10358||
|394|B|B394|Počet dnů trvání dočasné pracovní neschopnosti||
|394|C|C394|Průběh pojištění v daném měsíci||
|394|D|D394|ELDP||
|394|E|E394|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|394|F|F394|číslo||
|394|G|G394|celé číslo||
|394|H|H394|1-N||
|394|J|J394|pojisteni.eldpSeznam.eldp.vylouceneDny.docasNeschopnost (ID 10358)||
|394|K|K394| ||
|394|M|M394|předchozí období||
|394|R|R394|x||
|394|S|S394|x||
|394|V|V394|x||
|394|W|W394|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|394|X|X394|Počet dnů trvání dočasné pracovní neschopnosti||
|395|A|A395|10359||
|395|B|B395|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|395|C|C395|Průběh pojištění v daném měsíci||
|395|D|D395|ELDP||
|395|E|E395|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|395|F|F395|číslo||
|395|G|G395|celé číslo||
|395|H|H395|1-N||
|395|J|J395|pojisteni.eldpSeznam.eldp.vylouceneDny.penezitaPomocMaterstvi (ID 10359)||
|395|K|K395| ||
|395|M|M395|předchozí období||
|395|R|R395|x||
|395|S|S395|x||
|395|V|V395|x||
|395|W|W395|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|395|X|X395|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|396|A|A396|10360||
|396|B|B396|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|396|C|C396|Průběh pojištění v daném měsíci||
|396|D|D396|ELDP||
|396|E|E396|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|396|F|F396|číslo||
|396|G|G396|celé číslo||
|396|H|H396|1-N||
|396|J|J396|pojisteni.eldpSeznam.eldp.vylouceneDny.osetrovaniClenaRodiny (ID 10360)||
|396|K|K396| ||
|396|M|M396|předchozí období||
|396|R|R396|x||
|396|S|S396|x||
|396|V|V396|x||
|396|W|W396|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|396|X|X396|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|397|A|A397|10362||
|397|B|B397|Počet dnů čerpání otcovské||
|397|C|C397|Průběh pojištění v daném měsíci||
|397|D|D397|ELDP||
|397|E|E397|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|397|F|F397|číslo||
|397|G|G397|celé číslo||
|397|H|H397|1-N||
|397|J|J397|pojisteni.eldpSeznam.eldp.vylouceneDny.otcovska (ID 10362)||
|397|K|K397| ||
|397|M|M397|předchozí období||
|397|R|R397|x||
|397|S|S397|x||
|397|V|V397|x||
|397|W|W397|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|397|X|X397|Počet dnů čerpání otcovské||
|398|A|A398|10536||
|398|B|B398|Počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb.||
|398|C|C398|Průběh pojištění v daném měsíci||
|398|D|D398|ELDP||
|398|E|E398|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|398|F|F398|číslo||
|398|G|G398|celé číslo||
|398|H|H398|1-N||
|398|J|J398|pojisteni.eldpSeznam.eldp.vylouceneDny.vyloucenePar16 (ID 10536)||
|398|K|K398| ||
|398|M|M398|předchozí období||
|398|R|R398|x||
|398|S|S398|x||
|398|V|V398|x||
|398|W|W398|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|398|X|X398|Počet dnů podle ustanovení § 16 odst. 4 písm. j) zákona č. 155/1995 Sb. ||
|399|A|A399|10366||
|399|B|B399|Vyloučené dny podle § 18 odst. 7 zákona č. 187/2006 Sb.||
|399|C|C399|Průběh pojištění v daném měsíci||
|399|D|D399|ELDP||
|399|E|E399|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|399|F|F399|číslo||
|399|G|G399|celé číslo||
|399|H|H399|1-N||
|399|J|J399|pojisteni.eldpSeznam.eldp.vylouceneDny.vyloucenePar18 (ID 10366)||
|399|K|K399| ||
|399|M|M399|předchozí období||
|399|N|N399|N||
|399|O|O399|= "10473" + "10474" + "10475"||
|399|P|P399| ||
|399|R|R399|x||
|399|S|S399|x||
|399|V|V399|x||
|399|W|W399|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|399|X|X399|Vyloučené dny podle § 18 odst. 7 zákona č. 187/2006 Sb. - počet kalendářních dnů||
|400|A|A400|10473||
|400|B|B400|Počet dnů omluvené nepřítomnosti, za které nenáleží náhrada příjmu (neplacené volno, stávka)||
|400|C|C400|Průběh pojištění v daném měsíci||
|400|D|D400|ELDP||
|400|E|E400|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|400|F|F400|číslo||
|400|G|G400|celé číslo||
|400|H|H400|1-N||
|400|J|J400|pojisteni.eldpSeznam.eldp.vylouceneDny.omluvenaNepritomnost (ID 10473)||
|400|K|K400| ||
|400|M|M400|předchozí období||
|400|R|R400|x||
|400|S|S400|x||
|400|V|V400|x||
|400|W|W400|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|400|X|X400|Počet dnů omluvené nepřítomnosti, za které nenáleží náhrada příjmu (neplacené volno,     stávka)||
|401|A|A401|10474||
|401|B|B401|Počet dnů dočasné pracovní neschopnosti nebo karantény, za které náleží náhrada příjmu||
|401|C|C401|Průběh pojištění v daném měsíci||
|401|D|D401|ELDP||
|401|E|E401|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|401|F|F401|číslo||
|401|G|G401|celé číslo||
|401|H|H401|1-N||
|401|J|J401|pojisteni.eldpSeznam.eldp.vylouceneDny.pracovniNeschopnost (ID 10474)||
|401|K|K401| ||
|401|M|M401|předchozí období||
|401|R|R401|x||
|401|S|S401|x||
|401|V|V401|x||
|401|W|W401|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|401|X|X401|Počet dnů dočasné pracovní neschopnosti nebo karantény, za které náleží náhrada příjmu||
|402|A|A402|10475||
|402|B|B402|Počet dnů, za které bylo zaměstnanci vypláceno nemocenské, peněžitá pomoc v mateřství, otcovská, ošetřovné nebo dlouhodobé ošetřovné ||
|402|C|C402|Průběh pojištění v daném měsíci||
|402|D|D402|ELDP||
|402|E|E402|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|402|F|F402|číslo||
|402|G|G402|celé číslo||
|402|H|H402|1-N||
|402|J|J402|pojisteni.eldpSeznam.eldp.vylouceneDny.vyplaceniDavek (ID 10475)||
|402|K|K402| ||
|402|M|M402|předchozí období||
|402|R|R402|x||
|402|S|S402|x||
|402|V|V402|x||
|402|W|W402|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|402|X|X402|Počet dnů, za které bylo zaměstnanci vypláceno nemocenské, peněžitá pomoc v mateřství, otcovská, ošetřovné nebo dlouhodobé ošetřovné ||
|403|A|A403|10375||
|403|B|B403|Doby odečítané po důchodovém věku - počet dnů||
|403|C|C403|Průběh pojištění v daném měsíci||
|403|D|D403|ELDP||
|403|E|E403|Odečítané dny||
|403|F|F403|číslo||
|403|G|G403|celé číslo||
|403|H|H403|1-N||
|403|J|J403|pojisteni.eldpSeznam.eldp.odecitaneDny.odecitaneDobyCelkem (ID 10375)||
|403|K|K403| ||
|403|M|M403|předchozí období||
|403|N|N403|N||
|403|O|O403|= "10462" + "10463" + "10464" + "10465" + "10466" + "10468" + "10469"||
|403|P|P403| ||
|403|R|R403|x||
|403|S|S403|x||
|403|T|T403|x||
|403|V|V403|x||
|403|W|W403|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|403|X|X403|Uvádí se počet kalendářních dnů odečítaných výdělečně činnému pojištěnci po dovršení důchodovém věku.||
|404|A|A404|10462||
|404|B|B404|Počet dnů trvání dočasné pracovní neschopnosti (karanténa)||
|404|C|C404|Průběh pojištění v daném měsíci||
|404|D|D404|ELDP||
|404|E|E404|Odečítané dny||
|404|F|F404|číslo||
|404|G|G404|celé číslo||
|404|H|H404|1-N||
|404|J|J404|pojisteni.eldpSeznam.eldp.odecitaneDny.pracovniNeschopnost (ID 10462)||
|404|K|K404| ||
|404|M|M404|předchozí období||
|404|R|R404|x||
|404|S|S404|x||
|404|V|V404|x||
|404|W|W404|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|404|X|X404|Počet dnů trvání dočasné pracovní neschopnosti (karanténa)||
|405|A|A405|10463||
|405|B|B405|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|405|C|C405|Průběh pojištění v daném měsíci||
|405|D|D405|ELDP||
|405|E|E405|Odečítané dny||
|405|F|F405|číslo||
|405|G|G405|celé číslo||
|405|H|H405|1-N||
|405|J|J405|pojisteni.eldpSeznam.eldp.odecitaneDny.materstvi (ID 10463)||
|405|K|K405| ||
|405|M|M405|předchozí období||
|405|R|R405|x||
|405|S|S405|x||
|405|V|V405|x||
|405|W|W405|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|405|X|X405|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|406|A|A406|10464||
|406|B|B406|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|406|C|C406|Průběh pojištění v daném měsíci||
|406|D|D406|ELDP||
|406|E|E406|Odečítané dny||
|406|F|F406|číslo||
|406|G|G406|celé číslo||
|406|H|H406|1-N||
|406|J|J406|pojisteni.eldpSeznam.eldp.odecitaneDny.osetrovaniSNarokem (ID 10464)||
|406|K|K406| ||
|406|M|M406|předchozí období||
|406|R|R406|x||
|406|S|S406|x||
|406|V|V406|x||
|406|W|W406|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|406|X|X406|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|407|A|A407|10465||
|407|B|B407|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné ||
|407|C|C407|Průběh pojištění v daném měsíci||
|407|D|D407|ELDP||
|407|E|E407|Odečítané dny||
|407|F|F407|číslo||
|407|G|G407|celé číslo||
|407|H|H407|1-N||
|407|J|J407|pojisteni.eldpSeznam.eldp.odecitaneDny.osetrovaniBezNaroku (ID 10465)||
|407|K|K407| ||
|407|M|M407|předchozí období||
|407|R|R407|x||
|407|S|S407|x||
|407|V|V407|x||
|407|W|W407|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|407|X|X407|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné ||
|408|A|A408|10466||
|408|B|B408|Počet dnů čerpání otcovské||
|408|C|C408|Průběh pojištění v daném měsíci||
|408|D|D408|ELDP||
|408|E|E408|Odečítané dny||
|408|F|F408|číslo||
|408|G|G408|celé číslo||
|408|H|H408|1-N||
|408|J|J408|pojisteni.eldpSeznam.eldp.odecitaneDny.otcovska (ID 10466)||
|408|K|K408| ||
|408|M|M408|předchozí období||
|408|R|R408|x||
|408|S|S408|x||
|408|V|V408|x||
|408|W|W408|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|408|X|X408|Počet dnů čerpání otcovské||
|409|A|A409|10468||
|409|B|B409|Počet dnů čerpání neplaceného volna||
|409|C|C409|Průběh pojištění v daném měsíci||
|409|D|D409|ELDP||
|409|E|E409|Odečítané dny||
|409|F|F409|číslo||
|409|G|G409|celé číslo||
|409|H|H409|1-N||
|409|J|J409|pojisteni.eldpSeznam.eldp.odecitaneDny.neplaceneVolno (ID 10468)||
|409|K|K409| ||
|409|M|M409|předchozí období||
|409|R|R409|x||
|409|S|S409|x||
|409|V|V409|x||
|409|W|W409|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|409|X|X409|Počet dnů čerpání neplaceného volna||
|410|A|A410|10469||
|410|B|B410|Počet dnů čerpání neplaceného volna||
|410|C|C410|Průběh pojištění v daném měsíci||
|410|D|D410|ELDP||
|410|E|E410|Odečítané dny||
|410|F|F410|číslo||
|410|G|G410|celé číslo||
|410|H|H410|1-N||
|410|J|J410|pojisteni.eldpSeznam.eldp.odecitaneDny.neomluveneAbsence (ID 10469)||
|410|K|K410| ||
|410|M|M410|předchozí období||
|410|R|R410|x||
|410|S|S410|x||
|410|V|V410|x||
|410|W|W410|Vyplňuje se zvlášť pro každý ELDP kód, vyplňuje se pro každý měsíc dat. scénáře Odložený příjem||
|410|X|X410|Počet dnů neomluvené absence||
|411|A|A411|10537||
|411|B|B411|Měsíc, za který je hlášeno||
|411|C|C411|Průběh pojištění v daném měsíci||
|411|D|D411|ELDP||
|411|E|E411|Odložený příjem||
|411|F|F411|číslo||
|411|G|G411|celé číslo||
|411|H|H411|1-N||
|411|J|J411|pojisteni.eldpObdobi.obdobi.mesic (ID 10537)||
|411|M|M411|ne - specifické||
|411|R|R411|x||
|411|S|S411|x||
|411|T|T411|x||
|411|V|V411|x||
|411|W|W411|Pro účely dat. scénáře Odložený příjem, vytvoří se tolik elementů, kolik je potřeba evidovat měsíců||
|411|X|X411|Měsíc, za který je hlášeno - scénář pro odložený příjem.||
|412|A|A412|10538||
|412|B|B412|Rok, za který je hlášeno||
|412|C|C412|Průběh pojištění v daném měsíci||
|412|D|D412|ELDP||
|412|E|E412|Odložený příjem||
|412|F|F412|číslo||
|412|G|G412|celé číslo||
|412|H|H412|1-N||
|412|J|J412|pojisteni.eldpObdobi.obdobi.rok (ID 10538)||
|412|M|M412|ne - specifické||
|412|R|R412|x||
|412|S|S412|x||
|412|T|T412|x||
|412|V|V412|x||
|412|W|W412|Pro účely dat. scénáře Odložený příjem, vytvoří se tolik elementů, kolik je potřeba evidovat měsíců||
|412|X|X412|Rok, za který je hlášeno - scénář pro odložený příjem.||
|413|A|A413|10476||
|413|B|B413|Vykázaný příjem z nepojištěné činnosti ||
|413|C|C413|Průběh pojištění v daném měsíci||
|413|D|D413|Vyměřovací základ||
|413|F|F413|číslo||
|413|G|G413|celé číslo||
|413|J|J413|pojisteni.vymerovaciZaklad.prijemNepojistenaCinnost (ID 10476)||
|413|K|K413| ||
|413|M|M413|předchozí období||
|413|R|R413|x||
|413|S|S413|x||
|413|V|V413|x||
|413|X|X413|Zúčtovaný příjem z DPP, ze kterého se neodvádí pojistné na sociální zabezpečení.||
|414|A|A414|10477||
|414|B|B414|Částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné||
|414|C|C414|Průběh pojištění v daném měsíci||
|414|D|D414|Vyměřovací základ||
|414|F|F414|číslo||
|414|G|G414|celé číslo||
|414|J|J414|pojisteni.vymerovaciZaklad.castkaOdvodPojistneho (ID 10477)||
|414|K|K414| ||
|414|M|M414|předchozí období||
|414|P|P414| ||
|414|R|R414|x||
|414|S|S414|x||
|414|V|V414|x||
|414|X|X414|Částka vyměřovacího základu zaměstnance (atribut 10245), z níž zaměstnanec platí pojistné. Zaměstnanec neplatí pojistné z částky, která u jednoho zaměstnavatele přesahuje tzv. maximální vyměřovací základ. Pokud zaměstnanec nedosáhl v kalendářním roce u zaměstnavatele tzv. maximální vyměřovací základ, bude atribut 10477 roven atributu 10245. ||
|415|A|A415|10478||
|415|B|B415|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ ||
|415|C|C415|Průběh pojištění v daném měsíci||
|415|D|D415|Vyměřovací základ||
|415|F|F415|číslo||
|415|G|G415|celé číslo||
|415|J|J415|pojisteni.vymerovaciZakladParagraf5.pismenoA (ID 10478)||
|415|K|K415| ||
|415|M|M415|předchozí období||
|415|R|R415|x||
|415|S|S415|x||
|415|V|V415|x||
|415|X|X415|Částka vyměřovacímu základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ.||
|416|A|A416|10479||
|416|B|B416|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ ||
|416|C|C416|Průběh pojištění v daném měsíci||
|416|D|D416|Vyměřovací základ||
|416|F|F416|číslo||
|416|G|G416|celé číslo||
|416|J|J416|pojisteni.vymerovaciZakladParagraf5.pismenoB (ID 10479)||
|416|K|K416| ||
|416|M|M416|předchozí období||
|416|R|R416|x||
|416|S|S416|x||
|416|V|V416|x||
|416|X|X416|Částka vyměřovacímu základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ||
|417|A|A417|10480||
|417|B|B417|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ ||
|417|C|C417|Průběh pojištění v daném měsíci||
|417|D|D417|Vyměřovací základ||
|417|F|F417|číslo||
|417|G|G417|celé číslo||
|417|J|J417|pojisteni.vymerovaciZakladParagraf5.pismenoC (ID 10480)||
|417|K|K417| ||
|417|M|M417|předchozí období||
|417|R|R417|x||
|417|S|S417|x||
|417|V|V417|x||
|417|X|X417|Částka vyměřovacímu základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ||
|418|A|A418|10481||
|418|B|B418|Pojistné na sociální zabezpečení ||
|418|C|C418|Průběh pojištění v daném měsíci||
|418|D|D418|Pojistné za zaměstnavatele||
|418|F|F418|číslo||
|418|G|G418|celé číslo||
|418|J|J418|pojisteni.pojisteniZamestnavatel.socialniPojisteni (ID 10481)||
|418|K|K418| ||
|418|M|M418|předchozí období||
|418|N|N418|N||
|418|O|O418|= (0,248*"10478", zaokrouhl. na celé Kč nahoru) + (0,298*"10479", zaokrouhl. na celé Kč nahoru) + (0,278*"10480", zaokrouhl. na celé Kč nahoru)\n\nNEBO\n\n= 0.248*"10477", pokud atributy 10478, 10479 a 10480 nejsou k dispozici v rámci datového scénáře\n----\nplatné pro rok 2026||
|418|P|P418| ||
|418|R|R418|x||
|418|S|S418|x||
|418|U|U418|x||
|418|V|V418|x||
|418|X|X418|Pojistné na sociální zabezpečení a příspěvek na státní politiku zaměstnanosti, které je povinen platit zaměstnavatel; (24,8 % z částky vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ; zaokrouhleno na celé koruny nahoru) + (X % z částky vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ;  zaokrouhleno na celé koruny směrem nahoru), kde X v roce 2025 činí 28,8 % a od roku 2026 činí 29,8 %.||
|419|A|A419|10370||
|419|B|B419|Sociální pojištění||
|419|C|C419|Průběh pojištění v daném měsíci||
|419|D|D419|Pojistné za zaměstnance||
|419|F|F419|číslo||
|419|G|G419|celé číslo||
|419|J|J419|pojisteni.pojisteniZamestnanec.socialniPojisteni (ID 10370)||
|419|K|K419| ||
|419|M|M419|předchozí období||
|419|N|N419|N||
|419|O|O419|= 0,071 * "10477, zaokrouhlit na celé Kč nahoru, = kontrola MH.118||
|419|P|P419| ||
|419|R|R419|x||
|419|S|S419|x||
|419|U|U419|x||
|419|V|V419|x||
|419|X|X419|Pojistné na sociální zabezpečení, které je povinen platit zaměstnanec (7,1 % z částky uvedené v atributu 10477)||
|420|A|A420|10372||
|420|B|B420|Sleva na pojistném zaměstnavatele||
|420|C|C420|Průběh pojištění v daném měsíci||
|420|D|D420|Sleva na pojistném zaměstnavatele||
|420|F|F420|příznak||
|420|J|J420|pojisteni.slevaZamestnavatele.slevaZamestnavateleEvidovana (ID 10372)||
|420|K|K420| ||
|420|M|M420|předchozí období||
|420|R|R420|x||
|420|S|S420|x||
|420|V|V420|x||
|420|X|X420|Pokud zaměstnavatel za zaměstnance z příslušného zaměstnání uplatňuje slevu na popjistném zaměstnavatele, uvede se ANO, jinak se uvede NE||
|421|A|A421|10373||
|421|B|B421|Rozsah kratší pracovní/služební doby||
|421|C|C421|Průběh pojištění v daném měsíci||
|421|D|D421|Sleva na pojistném zaměstnavatele||
|421|F|F421|číslo||
|421|G|G421|celé číslo||
|421|J|J421|pojisteni.slevaZamestnavatele.slevaZamestnavateleRozpad.pracovniDobaKratsi (ID 10373)||
|421|K|K421| ||
|421|M|M421|předchozí období||
|421|R|R421|x||
|421|S|S421|x||
|421|V|V421|x||
|421|X|X421|Sjednání kratší pracovní/služební doby je podmínkou nároku na slevu na pojistném na SZ za daného zaměstnance. Limit počtu 30 hodin týdně platí pro všechna zaměstnání v pracovním/služebním poměru zaměstnance dohromady.\nÚdaj se uvádí pouze tehdy, je-li údaj Důvod uplatnění slevy = A až F; je-li údaj 8 = G, pak se údaj neuvádí; jako rozsah kratší pracovní (služební) doby se uvádí týdenní počet hodin ze všech zaměstnání v pracovním (služebním) poměru zaměstnance u zaměstnavatele, tedy včetně takových zaměstnání zaměstnance, ze kterých zaměstnavatel slevu na pojistném neuplatňuje a která ani nezakládají účast na pojištění (tento rozsah činí nejvýše 30 hodin) ; rozsah se vykazuje v hodinách nejvýše na dvě desetinná místa||
|422|A|A422|10374||
|422|B|B422|Důvod uplatnění slevy||
|422|C|C422|Průběh pojištění v daném měsíci||
|422|D|D422|Sleva na pojistném zaměstnavatele||
|422|F|F422|číselník||
|422|J|J422|pojisteni.slevaZamestnavatele.slevaZamestnavateleRozpad.duvodUplatneni (ID 10374)||
|422|K|K422| ||
|422|L|L422|CIS Důvod uplatnění slevy||
|422|M|M422|předchozí období||
|422|R|R422|x||
|422|S|S422|x||
|422|U|U422|x||
|422|V|V422|x||
|422|X|X422|Uvádí se jedno z písmen A až G, podle toho, z jakého důvodu je sleva na pojistném za zaměstnance uplatňována dle § 7a odst. 1 zákona č. 589/1992 Sb. Je-li splněno více důvodů, vždy se uvede jen jeden.\nZaměstnavatel má nárok na slevu na pojistném za kalendářní měsíc za zaměstnance v pracovním nebo služebním poměru, který\na) dosáhl alespoň 55 let,\nb) pečuje o dítě mladší 10 let, jehož je rodičem, nebo které má v péči nahrazující péči rodičů na základě rozhodnutí příslušného orgánu; za rozhodnutí příslušného orgánu se považuje rozhodnutí uvedené v § 7 odst. 10 zákona o státní sociální podpoře,\nc) pečuje o osobu blízkou mladší 10 let, která je závislá na pomoci jiné osoby ve stupni I (lehká závislost), nebo o osobu blízkou, která je závislá na pomoci jiné osoby ve stupni II (středně těžká závislost) nebo stupni III (těžká závislost) anebo stupni IV (úplná závislost); osoba blízká se posuzuje podle § 24 odst. 1 zákona o důchodovém pojištění,\nd) se zároveň připravuje na budoucí povolání studiem a je mladší 26 let; studium se posuzuje podle § 21 odst. 1 písm. a), § 22 a 23 zákona o důchodovém pojištění,\ne) v období 12 kalendářních měsíců před kalendářním měsícem, za který se sleva na pojistném uplatňuje, nastoupil jako uchazeč o zaměstnání na rekvalifikaci podle § 109 nebo 109a zákona o zaměstnanosti,\nf) je osobou se zdravotním postižením podle § 67 odst. 2 zákona o zaměstnanosti, nebo\ng) je mladší 21 let.\nHodnotu F nelze uvést u zaměstnance zaměstnavatele, který je zaměstnavatelem uznaným za zaměstnavatele na chráněném trhu práce podle § 78 ZoZ.||
|423|A|A423|10490||
|423|B|B423|Sleva na pojistném zaměstnance||
|423|C|C423|Průběh pojištění v daném měsíci||
|423|D|D423|Sleva na pojistném zaměstnanců||
|423|E|E423|Pracující důchodci||
|423|F|F423|příznak||
|423|J|J423|pojisteni.slevaZamestnance.slevaZamestnanceEvidovana (ID 10490)||
|423|K|K423| ||
|423|M|M423|předchozí období||
|423|R|R423|x||
|423|S|S423|x||
|423|U|U423|x||
|423|V|V423|x||
|423|X|X423|Pokud zaměstnanec u zaměstnavatele za příslušný kalendářní měsíc uplatnil slevu na pojistném zaměstnance, uvede se ANO, jinak se uvede NE||
|424|A|A424|10491||
|424|B|B424|Výše slevy na pojistném zaměstnance||
|424|C|C424|Průběh pojištění v daném měsíci||
|424|D|D424|Sleva na pojistném zaměstnanců||
|424|E|E424|Pracující důchodci||
|424|F|F424|číslo||
|424|G|G424|celé číslo||
|424|J|J424|pojisteni.slevaZamestnance.slevaZamestnance.vyseSlevy (ID 10491)||
|424|K|K424| ||
|424|M|M424|předchozí období||
|424|N|N424|N||
|424|O|O424|= 0,065 * "10477", zaokrouhlit na celé Kč nahoru||
|424|P|P424| ||
|424|R|R424|x||
|424|S|S424|x||
|424|U|U424|x||
|424|V|V424|x||
|424|X|X424|Sleva na pojistném zaměstnance činí 6,5 % z částky uvedené v atributu 10477||
|425|A|A425|10546||
|425|B|B425|Sleva na pojistném zaměstnance||
|425|C|C425|Průběh pojištění v daném měsíci||
|425|D|D425|Sleva na pojistném zaměstnanců||
|425|E|E425|Ovocnářství a pěstování zeleniny||
|425|F|F425|příznak||
|425|J|J425|pojisteni.slevaZamestnance.slevaZamestnanceOvoZelEvidovana (ID 10546)||
|425|K|K425| ||
|425|M|M425|předchozí období||
|425|R|R425|x||
|425|S|S425|x||
|425|V|V425|x||
|426|A|A426|10547||
|426|B|B426|Výše slevy na pojistném zaměstnance||
|426|C|C426|Průběh pojištění v daném měsíci||
|426|D|D426|Sleva na pojistném zaměstnanců||
|426|E|E426|Ovocnářství a pěstování zeleniny||
|426|F|F426|číslo||
|426|G|G426|celé číslo||
|426|J|J426|pojisteni.slevaZamestnance.slevaZamestnanceOvoZel.vyseSlevy (ID 10547)||
|426|K|K426| ||
|426|M|M426|předchozí období||
|426|N|N426|N||
|426|O|O426|= 0,071 * "10477", zaokrouhlit na celé Kč nahoru||
|426|P|P426| ||
|426|R|R426|x||
|426|S|S426|x||
|426|V|V426|x||
|427|A|A427|10376||
|427|B|B427|Důvod neposkytnutí podkladů||
|427|C|C427|Ukončení pracovněprávního vztahu||
|427|D|D427|Informace pro podporu v nezaměstnanosti||
|427|E|E427|Důvody||
|427|F|F427|číselník||
|427|I|I427|employees.employee.unemplcomp.rsn (ID 10376)||
|427|J|J427| ||
|427|L|L427|CIS Důvod neposkytnutí podkladů||
|427|Q|Q427|x||
|427|U|U427|x||
|427|X|X427|Vyplňuje se v případě, že pojištěnec, u něhož skončilo zaměstnání, nemůže být evidován jako uchazeč o zaměstnání nebo u vybraných zaměstnání. Použije se číselník důvodů neposkytnutí podkladů pro ÚP (podpora v nezaměstnanosti).\n2 - starobní důchod nebo zaměstnání bez účasti na pojištění - pojištěnec, jemuž skončilo zaměstnání, je poživatelem starobního důchodu, nebo skončené zaměstnání nezaložilo zaměstnanci účast na pojištění; \n3 - vybraná zaměstnání - soudci, členové zastupitelstev územních samosprávních celků, poslanci Poslanecké sněmovny PČR, senátoři Senátu PČR, členové vlády, prezident, viceprezident a členové NKÚ, členové RRTV, finanční arbitr a jeho zástupce, veřejný ochránce práv a jeho zástupce, členové Rady Ústavu pro studium totalitních režimů, členové Rady Českého telekomunikačního úřadu, členové Rady Energetického regulačního úřadu, členové Národní rozpočtové rady, pracovníci v pracovním vztahu podle cizích právních předpisů, fyzické osoby neuvedené v § 5, písm. a) bodech 1 až 21 zákona č. 187/2006 Sb., s výjimkou členů zastupitelstev územních samosprávných celků a zastupitelstev městských částí nebo městských obvodů územně členěných statutárních měst a hlavního města Prahy zvolených do funkcí, jež zastupitelstvo neurčilo jako funkce, pro které budou členové zastupitelstva uvolněni, státní zástupci vykonávající v ČR funkci evropských pověřených žalobců (§ 167g zákona č. 187/2006 Sb.)\nV případě vybrání důvodu neposkytnutí podkladů pro ÚP typu 1 a 2 se nevyplňují žádné údaje z této části. V případě vybrání typu 3 nebo v případě uvedení druhu výdělečné činnosti M, N, O, P, Q, R, S (List Číselník ČSSZ_Druh činnosti) se nevyplňují údaje „Druh zaměstnání“, „Důvod ukončení pracovněprávního vztahu“ a „Důvod ukončení služebního poměru“.||
|428|A|A428|10525||
|428|B|B428|Druh zaměstnání||
|428|C|C428|Ukončení pracovněprávního vztahu||
|428|D|D428|Informace pro podporu v nezaměstnanosti||
|428|F|F428|číselník||
|428|I|I428|employees.employee.unemplcomp.typeempl (ID 10525)||
|428|J|J428| ||
|428|L|L428|CIS Druh zaměstnání||
|428|Q|Q428|x||
|428|U|U428|x||
|428|V|V428|x||
|429|A|A429|10377||
|429|B|B429|Průměrný měsíční čistý (pravděpodobný) výdělek||
|429|C|C429|Ukončení pracovněprávního vztahu||
|429|D|D429|Informace pro podporu v nezaměstnanosti||
|429|E|E429|Výdělek||
|429|F|F429|číslo||
|429|G|G429|celé číslo||
|429|I|I429|employees.employee.unemplcomp.avgmonear (ID 10377)||
|429|J|J429| ||
|429|Q|Q429|x||
|429|U|U429|x||
|429|V|V429|x||
|429|X|X429|Uvede se konkrétní částka, kdy se průměrný čistý měsíční výdělek zjistí z průměrného měsíčního hrubého výdělku odečtením pojistného na sociální zabezpečení a příspěvku na státní politiku zaměstnanosti, pojistné na všeobecné zdravotní pojištění a zálohy na daň z příjmů fyzických osob ze závislé činnosti. Daňový bonus se při výpočtu nepřičítá. Pro výpočet se použijí podmínky a sazby platné pro zaměstnance v měsíci, v němž se průměrný čistý měsíční čistý výdělek zjišťuje. Pokud nemůže být zjištěn průměrný měsíční čistý výdělek, uvede se pravděpodobný výdělek. Jestliže zaměstnanec v rozhodném období neodpracoval alespoň 21 dnů, použije se pravděpodobný výdělek, který se zjistí z hrubé mzdy nebo platu, které zaměstnanec dosáhl od počátku rozhodného období, popřípadě z hrubé mzdy nebo platu, které by zřejmě dosáhl; přitom se přihlédne zejména k obvyklé výši jednotlivých složek mzdy nebo platu zaměstnance nebo ke mzdě nebo platu zaměstnanců vykonávajících stejnou práci nebo práci stejné hodnoty.||
|430|A|A430|10378||
|430|B|B430|Náleží||
|430|C|C430|Ukončení pracovněprávního vztahu||
|430|D|D430|Odchodné / odbytné / odstupné||
|430|F|F430|příznak||
|430|I|I430|employees.employee.unemplcomp.belong (ID 10378)||
|430|J|J430| ||
|430|Q|Q430|x||
|430|V|V430|x||
|430|X|X430|Odstupné plní satisfakční funkci, tedy jakési odškodné, které vyplácí zaměstnavatel zaměstnanci při skončení pracovního poměru výpovědí. Nárok na odstupné vznikne zaměstnanci, kterému dal zaměstnavatel výpověď z důvodu, kdy se ruší podnik zaměstnavatele nebo jeho část, přemísťuje-li se zaměstnavatel nebo jeho část, nebo v případě, kdy se zaměstnanec stane nadbytečným vzhledem k rozhodnutí zaměstnavatele nebo příslušného orgánu o změně jeho úkolů.\nOdchodné je institu, který může podle § 29 odst. 3 zákoníku práce zaměstnavatel sjednat s vedoucím zaměstnancem, u něhož se pracovní poměr zakládá jmenováním nebo volbou.||
|431|A|A431|10379||
|431|B|B431|Vyplaceno v plné výši  ||
|431|C|C431|Ukončení pracovněprávního vztahu||
|431|D|D431|Odchodné / odbytné / odstupné||
|431|F|F431|příznak||
|431|I|I431|employees.employee.unemplcomp.fullpay (ID 10379)||
|431|J|J431| ||
|431|Q|Q431|x||
|431|V|V431|x||
|431|X|X431|Uvede se, zda bylo vyplaceno v plné výči či nikoli.||
|432|A|A432|10380||
|432|B|B432|Důvod ukončení pracovně právního vztahu||
|432|C|C432|Ukončení pracovněprávního vztahu||
|432|D|D432|Informace pro podporu v nezaměstnanosti||
|432|E|E432|Důvody||
|432|F|F432|číselník||
|432|I|I432|employees.employee.unemplcomp.rsnterempl (ID 10380)||
|432|J|J432| ||
|432|L|L432|CIS Důvod ukončení pracovněprávního vztahu||
|432|Q|Q432|x||
|432|U|U432|x||
|432|V|V432|x||
|432|X|X432|Důvod ukončení PPV. V případě pracovněprávního vztahu se použije číselník důvodů ukončení pracovněprávního vztahu pro ÚP. V případě vybrání důvodu neposkytnutí podkladů pro ÚP typu 1, 2 a 3 nebo v případě uvedení druhu výdělečné činnosti M, N, O, P, Q, R, S (List Číselník ČSSZ_Druh činnosti), se údaj „Důvod ukončení pracovněprávního vztahu” neuvádí.||
|433|A|A433|10381||
|433|B|B433|Důvod ukončení služebního poměru||
|433|C|C433|Ukončení pracovněprávního vztahu||
|433|D|D433|Informace pro podporu v nezaměstnanosti||
|433|E|E433|Důvody||
|433|F|F433|číselník||
|433|I|I433|employees.employee.unemplcomp.rsnterrel (ID 10381)||
|433|J|J433| ||
|433|L|L433|CIS Důvod ukončení služebního poměru||
|433|Q|Q433|x||
|433|U|U433|x||
|433|V|V433|x||
|433|X|X433|Důvod ukončení služebního poměru. V případě služebního poměru podle zákona č. 234/2014 Sb. se použije číselník důvodů ukončení služebního poměru pro ÚP. V případě vybrání důvodu neposkytnutí podkladů pro ÚP typu 1, 2 a 3, se údaj „Důvod ukončení služebního poměru” neuvádí.||
|434|A|A434|10534||
|434|B|B434|Důvod předčasného ukončení ||
|434|C|C434|Ukončení pracovněprávního vztahu||
|434|D|D434|Informace k zaměstnávání cizinců||
|434|E|E434|Důvody||
|434|F|F434|číselník||
|434|I|I434|employees.employee.unemplcomp.earlyterm (ID 10534)||
|434|J|J434| ||
|434|L|L434|CIS Důvod předčasného ukončení||
|434|Q|Q434|x||
|434|U|U434|x||
|434|X|X434|Předčasné ukončení (přesněji „ukončení zaměstnání před uplynutím doby, na kterou bylo vydáno povolení k zaměstnání, zaměstnanecká karta nebo modrá karta“) – podle § 88 odst. 1 písm. b) zákona o zaměstnanosti.\nDůvod ukončení:\n- výpověď z některého z důvodů uvedených v § 52 písm. a) až e) zákoníku práce nebo dohodou z týchž důvodů\n- okamžitým zrušením podle § 56 zákoníku práce\n- z jiného důvodu||
|435|A|A435|10530||
|435|B|B435|Jednorázová náhrada při skončení pracovního poměru (§271ca ZP)||
|435|C|C435|Ukončení pracovněprávního vztahu||
|435|D|D435|Odchodné / odbytné / odstupné||
|435|E|E435|Náhrady||
|435|F|F435|číslo||
|435|G|G435|celé číslo||
|435|I|I435|employees.employee.unemplcomp.replacement (ID 10530)||
|435|J|J435| ||
|435|Q|Q435|x||
|435|V|V435|x||
|435|X|X435|Jednorázová náhrada při ukončení pracovního poměru poskytnutá zaměstnanci v důsledku rozvázání pracovního poměru z důvodu dlouhodobého pozbytí způsobilosti konat dále dosavadní práci pro pracovní úraz, nemoc z povolání nebo ohrožení touto nemocí (dříve odstupné) dle zákona č. 120/2025 Sb.||
|436|A|A436|10531||
|436|B|B436|Odstupné podle § 67 odst. 1 ZP||
|436|C|C436|Ukončení pracovněprávního vztahu||
|436|D|D436|Odchodné / odbytné / odstupné||
|436|F|F436|číslo||
|436|G|G436|celé číslo||
|436|I|I436|employees.employee.unemplcomp.goldenhandshake (ID 10531)||
|436|J|J436| ||
|436|Q|Q436|x||
|436|V|V436|x||
|436|X|X436|Kompenzace zaměstnanci v zákonem vymezených případech nepříznivých důsledků spojených se skončením pracovního poměru. Uvede se konkrétní výše.||
|437|A|A437|10532||
|437|B|B437|Odchodné||
|437|C|C437|Ukončení pracovněprávního vztahu||
|437|D|D437|Odchodné / odbytné / odstupné||
|437|F|F437|číslo||
|437|G|G437|celé číslo||
|437|I|I437|employees.employee.unemplcomp.severancepay (ID 10532)||
|437|J|J437| ||
|437|Q|Q437|x||
|437|V|V437|x||
|437|X|X437|Při zániku služebního poměru je náropk na odchodné, a to za předpokladu, že pokud vznikl nárok na výsluhový příspěvek a místo vyplácení výsluhového příspěvku nebyl zvolen nárok na výplatu odbytného.||
|438|A|A438|10533||
|438|B|B438|Odbytné||
|438|C|C438|Ukončení pracovněprávního vztahu||
|438|D|D438|Odchodné / odbytné / odstupné||
|438|F|F438|číslo||
|438|G|G438|celé číslo||
|438|I|I438|employees.employee.unemplcomp.disposal (ID 10533)||
|438|J|J438| ||
|438|Q|Q438|x||
|438|V|V438|x||
|438|X|X438|Dojde-li k tomu, že je státní zaměstnanec z organizačních důvodů zařazen mimo výkon služby, například proto, že jeho místo bylo v důsledku změny systemizace zrušeno a nebylo nalezeno jiné vhodné služební místo, je státní zaměstnanec zařazen mimo výkon služby. Pokud v této době není státnímu zaměstnanci nalezeno vhodné služební místo, musí služební orgán rozhodnout o skončení služebního poměru. Podle § 72 odst. 2 zákona o státní službě má v takovém případě státní zaměstnanec právo na výplatu odbytného. Jeho výše se odvíjí od délky trvání služebního poměru.||
|439|A|A439|10386||
|439|B|B439|Doba trvání důchodového pojištění ze zaměstnání od||
|439|C|C439|Ukončení pracovněprávního vztahu||
|439|D|D439|Informace pro podporu v nezaměstnanosti||
|439|E|E439|Důchodové pojištění||
|439|F|F439|datum||
|439|H|H439|1-N||
|439|I|I439|employees.employee.unemplcomp.pensionperiod.fro (ID 10386)||
|439|J|J439| ||
|439|Q|Q439|x||
|439|U|U439|x||
|439|V|V439|x||
|439|W|W439|1 - N datumových intervalů od - do||
|439|X|X439|Uvede se konkrétní období nebo jednotlivé intervaly (od – do), a to za poslední dva roky, tzn. za posledních 24 měsíců, před skončením zaměstnání. Pokud v posledních 24 měsících před datem ukončení zaměstnání neexistuje u zaměstnance doba považovaná za dobu důchodového pojištění, uvede se doba, po kterou byl zaměstnanec v rámci daného pracovního poměru pojištěn, byť bude tato doba starší 24 měsíců před ukončením pracovního poměru.||
|440|A|A440|10387||
|440|B|B440|Doba trvání důchodového pojištění ze zaměstnání do||
|440|C|C440|Ukončení pracovněprávního vztahu||
|440|D|D440|Informace pro podporu v nezaměstnanosti||
|440|E|E440|Důchodové pojištění||
|440|F|F440|datum||
|440|H|H440|1-N||
|440|I|I440|employees.employee.unemplcomp.pensionperiod.to (ID 10387)||
|440|J|J440| ||
|440|Q|Q440|x||
|440|U|U440|x||
|440|V|V440|x||
|440|W|W440|1 - N datumových intervalů od - do||
|440|X|X440|Uvede se konkrétní období nebo jednotlivé intervaly (od – do), a to za poslední dva roky, tzn. za posledních 24 měsíců, před skončením zaměstnání. Pokud v posledních 24 měsících před datem ukončení zaměstnání neexistuje u zaměstnance doba považovaná za dobu důchodového pojištění, uvede se doba, po kterou byl zaměstnanec v rámci daného pracovního poměru pojištěn, byť bude tato doba starší 24 měsíců před ukončením pracovního poměru.||
|441|A|A441|10396||
|441|B|B441|Název přílohy||
|441|C|C441|Příloha||
|441|F|F441|text||
|441|H|H441|1-N||
|441|I|I441|employees.employee.attachs.attach.name (ID 10396)||
|441|J|J441| ||
|441|Q|Q441|x||
|441|S|S441|x (napřímo, mimo JMHZ)||
|441|W|W441|1 - N objektů příloh||
|442|A|A442|10397||
|442|B|B442|Popis přílohy||
|442|C|C442|Příloha||
|442|F|F442|text||
|442|H|H442|1-N||
|442|I|I442|employees.employee.attachs.attach.desc (ID 10397)||
|442|J|J442| ||
|442|Q|Q442|x||
|442|S|S442|x (napřímo, mimo JMHZ)||
|442|W|W442|1 - N objektů příloh||
|443|A|A443|10399||
|443|B|B443|DMS reference||
|443|C|C443|Příloha||
|443|F|F443|text||
|443|H|H443|1-N||
|443|P|P443|bez sběru, získá se až na backendu||
|443|S|S443|x (napřímo, mimo JMHZ)||
|443|W|W443|1 - N objektů příloh||
|444|A|A444|10400||
|444|B|B444|Data přílohy||
|444|C|C444|Příloha||
|444|F|F444|text / binární||
|444|H|H444|1-N||
|444|I|I444|employees.employee.attachs.attach.data (ID 10400)||
|444|J|J444| ||
|444|Q|Q444|x||
|444|S|S444|x (napřímo, mimo JMHZ)||
|444|W|W444|1 - N objektů příloh||

## Changelog

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|DATUM ZMĚNY||
|1|B|B1|VERZE||
|1|C|C1|ZMĚNOVÝ POŽADAVEK||
|1|D|D1|ID ATRIBUTU||
|1|E|E1|NÁZEV ATRIBUTU||
|1|F|F1|OBLAST ATRIBUTU||
|1|G|G1|TŘÍDA||
|1|H|H1|PODTŘÍDA||
|1|I|I1|REG. ZAMĚSTNAVATELE||
|1|J|J1|REG. ZAMĚSTNANCE||
|1|K|K1|MĚSÍČNÍ||
|1|L|L1|TYP ZMĚNY||
|1|M|M1|POPIS ZMĚNY||
|2|A|A2|22.2.2024||
|2|B|B2|1.0||
|2|E|E2|Stupeň školy||
|2|F|F2|Zaměstnanec / Žák / Student ||
|2|G|G2|Vzdělání||
|2|H|H2|Škola||
|2|L|L2|odstranění atributu||
|2|M|M2|odstranění informací o průběhu vzdělávání||
|3|A|A3|22.2.2024||
|3|B|B3|1.0||
|3|E|E3|Typ školy||
|3|F|F3|Zaměstnanec / Žák / Student ||
|3|G|G3|Vzdělání||
|3|H|H3|Škola||
|3|L|L3|odstranění atributu||
|3|M|M3|odstranění informací o průběhu vzdělávání||
|4|A|A4|22.2.2024||
|4|B|B4|1.0||
|4|E|E4|Obor||
|4|F|F4|Zaměstnanec / Žák / Student ||
|4|G|G4|Vzdělání||
|4|H|H4|Škola||
|4|L|L4|odstranění atributu||
|4|M|M4|odstranění informací o průběhu vzdělávání||
|5|A|A5|22.2.2024||
|5|B|B5|1.0||
|5|E|E5|Forma studia||
|5|F|F5|Zaměstnanec / Žák / Student ||
|5|G|G5|Vzdělání||
|5|H|H5|Škola||
|5|L|L5|odstranění atributu||
|5|M|M5|odstranění informací o průběhu vzdělávání||
|6|A|A6|22.2.2024||
|6|B|B6|1.0||
|6|E|E6|Studijní program||
|6|F|F6|Zaměstnanec / Žák / Student ||
|6|G|G6|Vzdělání||
|6|H|H6|Škola||
|6|L|L6|odstranění atributu||
|6|M|M6|odstranění informací o průběhu vzdělávání||
|7|A|A7|22.2.2024||
|7|B|B7|1.0||
|7|E|E7|Studium od||
|7|F|F7|Zaměstnanec / Žák / Student ||
|7|G|G7|Vzdělání||
|7|H|H7|Škola||
|7|L|L7|odstranění atributu||
|7|M|M7|odstranění informací o průběhu vzdělávání||
|8|A|A8|22.2.2024||
|8|B|B8|1.0||
|8|E|E8|Studium do||
|8|F|F8|Zaměstnanec / Žák / Student ||
|8|G|G8|Vzdělání||
|8|H|H8|Škola||
|8|L|L8|odstranění atributu||
|8|M|M8|odstranění informací o průběhu vzdělávání||
|9|A|A9|22.2.2024||
|9|B|B9|1.0||
|9|E|E9|Doba přerušení od||
|9|F|F9|Zaměstnanec / Žák / Student ||
|9|G|G9|Vzdělání||
|9|H|H9|Škola||
|9|L|L9|odstranění atributu||
|9|M|M9|odstranění informací o průběhu vzdělávání||
|10|A|A10|22.2.2024||
|10|B|B10|1.0||
|10|E|E10|Doba přerušení do||
|10|F|F10|Zaměstnanec / Žák / Student ||
|10|G|G10|Vzdělání||
|10|H|H10|Škola||
|10|L|L10|odstranění atributu||
|10|M|M10|odstranění informací o průběhu vzdělávání||
|11|A|A11|22.2.2024||
|11|B|B11|1.0||
|11|E|E11|V případě studia v zahraničí - doklad NOSTRIFIKOVÁN v ČR||
|11|F|F11|Zaměstnanec / Žák / Student ||
|11|G|G11|Vzdělání||
|11|H|H11|Škola||
|11|L|L11|odstranění atributu||
|11|M|M11|odstranění kompletního folderu 11 (úrazy)||
|12|A|A12|22.2.2024||
|12|B|B12|1.0||
|12|E|E12|-||
|12|F|F12|-||
|12|G|G12|-||
|12|L|L12|globální||
|12|M|M12|odstranění konzumenta SÚIP (kompletního sloupce)||
|13|A|A13|22.2.2024||
|13|B|B13|1.0||
|13|E|E13|Druh úrazu||
|13|F|F13|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|13|G|G13|Data úrazu||
|13|L|L13|odstranění atributu||
|13|M|M13|odstranění kompletního folderu 11 (úrazy)||
|14|A|A14|22.2.2024||
|14|B|B14|1.0||
|14|E|E14|Evidenční číslo úrazu||
|14|F|F14|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|14|G|G14|Data úrazu||
|14|L|L14|odstranění atributu||
|14|M|M14|odstranění kompletního folderu 11 (úrazy)||
|15|A|A15|22.2.2024||
|15|B|B15|1.0||
|15|E|E15|Činnost při které k úrazu došlo||
|15|F|F15|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|15|G|G15|Data úrazu||
|15|L|L15|odstranění atributu||
|15|M|M15|odstranění kompletního folderu 11 (úrazy)||
|16|A|A16|22.2.2024||
|16|B|B16|1.0||
|16|E|E16|Datum a čas úrazu||
|16|F|F16|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|16|G|G16|Data úrazu||
|16|L|L16|odstranění atributu||
|16|M|M16|odstranění kompletního folderu 11 (úrazy)||
|17|A|A17|22.2.2024||
|17|B|B17|1.0||
|17|E|E17|Den v týdnu||
|17|F|F17|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|17|G|G17|Data úrazu||
|17|L|L17|odstranění atributu||
|17|M|M17|odstranění kompletního folderu 11 (úrazy)||
|18|A|A18|22.2.2024||
|18|B|B18|1.0||
|18|E|E18|Datum úmrtí úrazem postiženého zaměstnance||
|18|F|F18|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|18|G|G18|Data úrazu||
|18|L|L18|odstranění atributu||
|18|M|M18|odstranění kompletního folderu 11 (úrazy)||
|19|A|A19|22.2.2024||
|19|B|B19|1.0||
|19|E|E19|Příčina úrazu||
|19|F|F19|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|19|G|G19|Data úrazu||
|19|L|L19|odstranění atributu||
|19|M|M19|odstranění kompletního folderu 11 (úrazy)||
|20|A|A20|22.2.2024||
|20|B|B20|1.0||
|20|E|E20|Počet hodin odpracovaných bechrostředně před vznikem úrazu||
|20|F|F20|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|20|G|G20|Data úrazu||
|20|L|L20|odstranění atributu||
|20|M|M20|odstranění kompletního folderu 11 (úrazy)||
|21|A|A21|22.2.2024||
|21|B|B21|1.0||
|21|E|E21|Předpokládaná pracovní doba zraněného v den úrazu od||
|21|F|F21|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|21|G|G21|Data úrazu||
|21|L|L21|odstranění atributu||
|21|M|M21|odstranění kompletního folderu 11 (úrazy)||
|22|A|A22|22.2.2024||
|22|B|B22|1.0||
|22|E|E22|Předpokládaná pracovní doba zraněného v den úrazu do||
|22|F|F22|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|22|G|G22|Data úrazu||
|22|L|L22|odstranění atributu||
|22|M|M22|odstranění kompletního folderu 11 (úrazy)||
|23|A|A23|22.2.2024||
|23|B|B23|1.0||
|23|E|E23|Zdroj úrazu||
|23|F|F23|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|23|G|G23|Data úrazu||
|23|L|L23|odstranění atributu||
|23|M|M23|odstranění kompletního folderu 11 (úrazy)||
|24|A|A24|22.2.2024||
|24|B|B24|1.0||
|24|E|E24|Popis úrazového děje||
|24|F|F24|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|24|G|G24|Data úrazu||
|24|L|L24|odstranění atributu||
|24|M|M24|odstranění kompletního folderu 11 (úrazy)||
|25|A|A25|22.2.2024||
|25|B|B25|1.0||
|25|E|E25|Porušené předpisy||
|25|F|F25|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|25|G|G25|Data úrazu||
|25|L|L25|odstranění atributu||
|25|M|M25|odstranění kompletního folderu 11 (úrazy)||
|26|A|A26|22.2.2024||
|26|B|B26|1.0||
|26|E|E26|Druh zranění||
|26|F|F26|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|26|G|G26|Data úrazu||
|26|H|H26|Zranění||
|26|L|L26|odstranění atributu||
|26|M|M26|odstranění kompletního folderu 11 (úrazy)||
|27|A|A27|22.2.2024||
|27|B|B27|1.0||
|27|E|E27|Zraněná část těla||
|27|F|F27|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|27|G|G27|Data úrazu||
|27|H|H27|Zranění||
|27|L|L27|odstranění atributu||
|27|M|M27|odstranění kompletního folderu 11 (úrazy)||
|28|A|A28|22.2.2024||
|28|B|B28|1.0||
|28|E|E28|Počet zraněných osob celkem||
|28|F|F28|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|28|G|G28|Data úrazu||
|28|H|H28|Zranění||
|28|L|L28|odstranění atributu||
|28|M|M28|odstranění kompletního folderu 11 (úrazy)||
|29|A|A29|22.2.2024||
|29|B|B29|1.0||
|29|E|E29|Ulice||
|29|F|F29|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|29|G|G29|Místo úrazu||
|29|H|H29|Adresa||
|29|L|L29|odstranění atributu||
|29|M|M29|odstranění kompletního folderu 11 (úrazy)||
|30|A|A30|22.2.2024||
|30|B|B30|1.0||
|30|E|E30|Číslo popisné ||
|30|F|F30|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|30|G|G30|Místo úrazu||
|30|H|H30|Adresa||
|30|L|L30|odstranění atributu||
|30|M|M30|odstranění kompletního folderu 11 (úrazy)||
|31|A|A31|22.2.2024||
|31|B|B31|1.0||
|31|E|E31|Číslo orientační||
|31|F|F31|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|31|G|G31|Místo úrazu||
|31|H|H31|Adresa||
|31|L|L31|odstranění atributu||
|31|M|M31|odstranění kompletního folderu 11 (úrazy)||
|32|A|A32|22.2.2024||
|32|B|B32|1.0||
|32|E|E32|Obec||
|32|F|F32|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|32|G|G32|Místo úrazu||
|32|H|H32|Adresa||
|32|L|L32|odstranění atributu||
|32|M|M32|odstranění kompletního folderu 11 (úrazy)||
|33|A|A33|22.2.2024||
|33|B|B33|1.0||
|33|E|E33|Pošta||
|33|F|F33|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|33|G|G33|Místo úrazu||
|33|H|H33|Adresa||
|33|L|L33|odstranění atributu||
|33|M|M33|odstranění kompletního folderu 11 (úrazy)||
|34|A|A34|22.2.2024||
|34|B|B34|1.0||
|34|E|E34|PSČ||
|34|F|F34|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|34|G|G34|Místo úrazu||
|34|H|H34|Adresa||
|34|L|L34|odstranění atributu||
|34|M|M34|odstranění kompletního folderu 11 (úrazy)||
|35|A|A35|22.2.2024||
|35|B|B35|1.0||
|35|E|E35|Stát||
|35|F|F35|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|35|G|G35|Místo úrazu||
|35|H|H35|Adresa||
|35|L|L35|odstranění atributu||
|35|M|M35|odstranění kompletního folderu 11 (úrazy)||
|36|A|A36|22.2.2024||
|36|B|B36|1.0||
|36|E|E36|Kód obce||
|36|F|F36|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|36|G|G36|Místo úrazu||
|36|H|H36|Adresa||
|36|L|L36|odstranění atributu||
|36|M|M36|odstranění kompletního folderu 11 (úrazy)||
|37|A|A37|22.2.2024||
|37|B|B37|1.0||
|37|E|E37|Typ místa, kde k úrazu došlo||
|37|F|F37|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|37|G|G37|Místo úrazu||
|37|H|H37|Specifikace místa úrazu||
|37|L|L37|odstranění atributu||
|37|M|M37|odstranění kompletního folderu 11 (úrazy)||
|38|A|A38|22.2.2024||
|38|B|B38|1.0||
|38|E|E38|Pro postiženého zaměstnance je místo úrazu pravidelným pracovištěm||
|38|F|F38|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|38|G|G38|Místo úrazu||
|38|H|H38|Specifikace místa úrazu||
|38|L|L38|odstranění atributu||
|38|M|M38|odstranění kompletního folderu 11 (úrazy)||
|39|A|A39|22.2.2024||
|39|B|B39|1.0||
|39|E|E39|Úraz se stal na pracovišti jiného zaměstnavatele||
|39|F|F39|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|39|G|G39|Místo úrazu||
|39|H|H39|Specifikace místa úrazu||
|39|L|L39|odstranění atributu||
|39|M|M39|odstranění kompletního folderu 11 (úrazy)||
|40|A|A40|22.2.2024||
|40|B|B40|1.0||
|40|E|E40|Typ subjektu||
|40|F|F40|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|40|G|G40|Zaměstnavatel, u kterého k úrazu došlo (pokud se liší od uvedeného v části 2.)||
|40|L|L40|odstranění atributu||
|40|M|M40|odstranění kompletního folderu 11 (úrazy)||
|41|A|A41|22.2.2024||
|41|B|B41|1.0||
|41|E|E41|Název||
|41|F|F41|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|41|G|G41|Zaměstnavatel, u kterého k úrazu došlo (pokud se liší od uvedeného v části 2.)||
|41|L|L41|odstranění atributu||
|41|M|M41|odstranění kompletního folderu 11 (úrazy)||
|42|A|A42|22.2.2024||
|42|B|B42|1.0||
|42|E|E42|Jméno||
|42|F|F42|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|42|G|G42|Zaměstnavatel, u kterého k úrazu došlo (pokud se liší od uvedeného v části 2.)||
|42|L|L42|odstranění atributu||
|42|M|M42|odstranění kompletního folderu 11 (úrazy)||
|43|A|A43|22.2.2024||
|43|B|B43|1.0||
|43|E|E43|Příjmení||
|43|F|F43|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|43|G|G43|Zaměstnavatel, u kterého k úrazu došlo (pokud se liší od uvedeného v části 2.)||
|43|L|L43|odstranění atributu||
|43|M|M43|odstranění kompletního folderu 11 (úrazy)||
|44|A|A44|22.2.2024||
|44|B|B44|1.0||
|44|E|E44|Identifikační číslo (IČO, IČ)||
|44|F|F44|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|44|G|G44|Zaměstnavatel, u kterého k úrazu došlo (pokud se liší od uvedeného v části 2.)||
|44|L|L44|odstranění atributu||
|44|M|M44|odstranění kompletního folderu 11 (úrazy)||
|45|A|A45|22.2.2024||
|45|B|B45|1.0||
|45|E|E45|Hlavní činnost zaměstnavatetele (CZ-NACE)||
|45|F|F45|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|45|G|G45|Zaměstnavatel, u kterého k úrazu došlo (pokud se liší od uvedeného v části 2.)||
|45|L|L45|odstranění atributu||
|45|M|M45|odstranění kompletního folderu 11 (úrazy)||
|46|A|A46|22.2.2024||
|46|B|B46|1.0||
|46|E|E46|Roky||
|46|F|F46|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|46|G|G46|Délka trvání základního pracovněprávního vztahu u zaměstnavatele||
|46|L|L46|odstranění atributu||
|46|M|M46|odstranění kompletního folderu 11 (úrazy)||
|47|A|A47|22.2.2024||
|47|B|B47|1.0||
|47|E|E47|Měsíce||
|47|F|F47|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|47|G|G47|Délka trvání základního pracovněprávního vztahu u zaměstnavatele||
|47|L|L47|odstranění atributu||
|47|M|M47|odstranění kompletního folderu 11 (úrazy)||
|48|A|A48|22.2.2024||
|48|B|B48|1.0||
|48|E|E48|od||
|48|F|F48|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|48|G|G48|Po úrazu||
|48|H|H48|Pracovní neschopnost následkem úrazu||
|48|L|L48|odstranění atributu||
|48|M|M48|odstranění kompletního folderu 11 (úrazy)||
|49|A|A49|22.2.2024||
|49|B|B49|1.0||
|49|E|E49|do||
|49|F|F49|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|49|G|G49|Po úrazu||
|49|H|H49|Pracovní neschopnost následkem úrazu||
|49|L|L49|odstranění atributu||
|49|M|M49|odstranění kompletního folderu 11 (úrazy)||
|50|A|A50|22.2.2024||
|50|B|B50|1.0||
|50|E|E50|Alkohol||
|50|F|F50|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|50|G|G50|Po úrazu||
|50|H|H50|Kontrola přítomnosti návykových látek||
|50|L|L50|odstranění atributu||
|50|M|M50|odstranění kompletního folderu 11 (úrazy)||
|51|A|A51|22.2.2024||
|51|B|B51|1.0||
|51|E|E51|Ostatní návykové látky||
|51|F|F51|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|51|G|G51|Po úrazu||
|51|H|H51|Kontrola přítomnosti návykových látek||
|51|L|L51|odstranění atributu||
|51|M|M51|odstranění kompletního folderu 11 (úrazy)||
|52|A|A52|22.2.2024||
|52|B|B52|1.0||
|52|E|E52|Přijatá opatření||
|52|F|F52|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|52|G|G52|Po úrazu||
|52|L|L52|odstranění atributu||
|52|M|M52|odstranění kompletního folderu 11 (úrazy)||
|53|A|A53|22.2.2024||
|53|B|B53|1.0||
|53|E|E53|Vyjádření úrazem postiženého zaměstnance a svědků úrazu, případně dalších osob||
|53|F|F53|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|53|G|G53|Po úrazu||
|53|L|L53|odstranění atributu||
|53|M|M53|odstranění kompletního folderu 11 (úrazy)||
|54|A|A54|22.2.2024||
|54|B|B54|1.0||
|54|E|E54|Hospitalizace úrazem postiženého zaměstnance přesáhla 5 kalendářních dnů||
|54|F|F54|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|54|G|G54|Po úrazu||
|54|L|L54|odstranění atributu||
|54|M|M54|odstranění kompletního folderu 11 (úrazy)||
|55|A|A55|22.2.2024||
|55|B|B55|1.0||
|55|E|E55|Jiné změny||
|55|F|F55|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|55|G|G55|Po úrazu||
|55|L|L55|odstranění atributu||
|55|M|M55|odstranění kompletního folderu 11 (úrazy)||
|56|A|A56|22.2.2024||
|56|B|B56|1.0||
|56|E|E56|Prohlášení o pravdivosti poskytnutých informací a důsledků v případě opaku||
|56|F|F56|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|56|G|G56|Po úrazu||
|56|H|H56|Prohlášení zaměstnavatele||
|56|L|L56|odstranění atributu||
|56|M|M56|odstranění kompletního folderu 11 (úrazy)||
|57|A|A57|22.2.2024||
|57|B|B57|1.0||
|57|E|E57|Prohlášení o uznání pracovního úrazu||
|57|F|F57|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|57|G|G57|Po úrazu||
|57|H|H57|Prohlášení zaměstnavatele||
|57|L|L57|odstranění atributu||
|57|M|M57|odstranění kompletního folderu 11 (úrazy)||
|58|A|A58|22.2.2024||
|58|B|B58|1.0||
|58|E|E58|Úraz vyšetřován Policií ČR||
|58|F|F58|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|58|G|G58|Po úrazu||
|58|L|L58|odstranění atributu||
|58|M|M58|odstranění kompletního folderu 11 (úrazy)||
|59|A|A59|22.2.2024||
|59|B|B59|1.0||
|59|E|E59|Jméno||
|59|F|F59|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|59|G|G59|Zúčastněné osoby ||
|59|H|H59|Ohlašovatel úrazu||
|59|L|L59|odstranění atributu||
|59|M|M59|odstranění kompletního folderu 11 (úrazy)||
|60|A|A60|22.2.2024||
|60|B|B60|1.0||
|60|E|E60|Příjmení||
|60|F|F60|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|60|G|G60|Zúčastněné osoby ||
|60|H|H60|Ohlašovatel úrazu||
|60|L|L60|odstranění atributu||
|60|M|M60|odstranění kompletního folderu 11 (úrazy)||
|61|A|A61|22.2.2024||
|61|B|B61|1.0||
|61|E|E61|Vztah k zaměstnavateli úrazem postiženého zaměstnance||
|61|F|F61|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|61|G|G61|Zúčastněné osoby ||
|61|H|H61|Ohlašovatel úrazu||
|61|L|L61|odstranění atributu||
|61|M|M61|odstranění kompletního folderu 11 (úrazy)||
|62|A|A62|22.2.2024||
|62|B|B62|1.0||
|62|E|E62|Telefonické spojení na ohlašovatele||
|62|F|F62|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|62|G|G62|Zúčastněné osoby ||
|62|H|H62|Ohlašovatel úrazu||
|62|L|L62|odstranění atributu||
|62|M|M62|odstranění kompletního folderu 11 (úrazy)||
|63|A|A63|22.2.2024||
|63|B|B63|1.0||
|63|E|E63|Jméno||
|63|F|F63|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|63|G|G63|Zúčastněné osoby ||
|63|H|H63|Svědek||
|63|L|L63|odstranění atributu||
|63|M|M63|odstranění kompletního folderu 11 (úrazy)||
|64|A|A64|22.2.2024||
|64|B|B64|1.0||
|64|E|E64|Příjmení||
|64|F|F64|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|64|G|G64|Zúčastněné osoby ||
|64|H|H64|Svědek||
|64|L|L64|odstranění atributu||
|64|M|M64|odstranění kompletního folderu 11 (úrazy)||
|65|A|A65|22.2.2024||
|65|B|B65|1.0||
|65|E|E65|Jméno||
|65|F|F65|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|65|G|G65|Zúčastněné osoby ||
|65|H|H65|Zástupce zaměstnanců pro bezpečnost a ochranu zdraví při práci||
|65|L|L65|odstranění atributu||
|65|M|M65|odstranění kompletního folderu 11 (úrazy)||
|66|A|A66|22.2.2024||
|66|B|B66|1.0||
|66|E|E66|Příjmení||
|66|F|F66|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|66|G|G66|Zúčastněné osoby ||
|66|H|H66|Zástupce zaměstnanců pro bezpečnost a ochranu zdraví při práci||
|66|L|L66|odstranění atributu||
|66|M|M66|odstranění kompletního folderu 11 (úrazy)||
|67|A|A67|22.2.2024||
|67|B|B67|1.0||
|67|E|E67|Jméno||
|67|F|F67|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|67|G|G67|Zúčastněné osoby ||
|67|H|H67|Za odborovou organizaci||
|67|L|L67|odstranění atributu||
|67|M|M67|odstranění kompletního folderu 11 (úrazy)||
|68|A|A68|22.2.2024||
|68|B|B68|1.0||
|68|E|E68|Příjmení||
|68|F|F68|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|68|G|G68|Zúčastněné osoby ||
|68|H|H68|Za odborovou organizaci||
|68|L|L68|odstranění atributu||
|68|M|M68|odstranění kompletního folderu 11 (úrazy)||
|69|A|A69|22.2.2024||
|69|B|B69|1.0||
|69|E|E69|Jméno||
|69|F|F69|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|69|G|G69|Zúčastněné osoby ||
|69|H|H69|Za zaměstnavatele||
|69|L|L69|odstranění atributu||
|69|M|M69|odstranění kompletního folderu 11 (úrazy)||
|70|A|A70|22.2.2024||
|70|B|B70|1.0||
|70|E|E70|Příjmení||
|70|F|F70|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|70|G|G70|Zúčastněné osoby ||
|70|H|H70|Za zaměstnavatele||
|70|L|L70|odstranění atributu||
|70|M|M70|odstranění kompletního folderu 11 (úrazy)||
|71|A|A71|22.2.2024||
|71|B|B71|1.0||
|71|E|E71|Pracovní zařazení||
|71|F|F71|Záznam o úrazu, záznam o úrazu - hlášení změn, ohlášení úrazu||
|71|G|G71|Zúčastněné osoby ||
|71|H|H71|Za zaměstnavatele||
|71|L|L71|odstranění atributu||
|71|M|M71|odstranění kompletního folderu 11 (úrazy)||
|72|A|A72|1.3.2024||
|72|B|B72|1.0||
|72|E|E72|Variabilní symbol mzdové účtárny||
|72|F|F72|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|72|G|G72|Mzdová účtárna zaměstnavatele||
|72|L|L72|přidání atributu||
|72|M|M72|přidání výstupního atributu pro rozlišení jednotlivých mzdových účtáren||
|73|A|A73|1.3.2024||
|73|B|B73|1.0||
|73|E|E73|<atributy týkající se registrace zaměstnance>||
|73|F|F73|-||
|73|G|G73|-||
|73|L|L73|změna typu hlášení||
|73|M|M73|rozdělení atributů na ty, které se ukládají pod IK MPSV a které pod ID PPV||
|74|A|A74|7.3.2024||
|74|B|B74|1.0||
|74|E|E74|Variabilní symbol zaměstnavatele||
|74|F|F74|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|74|G|G74|-||
|74|L|L74|přejmenování atributu||
|74|M|M74|přejmenování atributu Nový variabilní symbol -> Variabilní symbol zaměstnavatele||
|75|A|A75|13.3.2024||
|75|B|B75|1.0||
|75|E|E75|Důvod podání||
|75|F|F75|Meta atributy||
|75|G|G75|-||
|75|L|L75|odstranění atributu||
|75|M|M75|Odstranění atributu a číselníku na základě rozhodnutí o nepotřebnosti registrace vůči konkrétní instituci (ČSSZ vs. FS)||
|76|A|A76|9.4.2024||
|76|B|B76|1.0||
|76|E|E76|Individuální číslo||
|76|F|F76|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|76|G|G76|Identifikace||
|76|L|L76|přidání atributu||
|77|A|A77|9.4.2024||
|77|B|B77|1.0||
|77|E|E77|Typ odhlášky||
|77|F|F77|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|77|G|G77|Odhlášení z registru||
|77|L|L77|přidání atributu||
|78|A|A78|9.4.2024||
|78|B|B78|1.0||
|78|E|E78|Datum zániku||
|78|F|F78|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|78|G|G78|Odhlášení z registru||
|78|L|L78|přidání atributu||
|79|A|A79|9.4.2024||
|79|B|B79|1.0||
|79|E|E79|Název||
|79|F|F79|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|79|G|G79|Odhlášení z registru||
|79|H|H79|Archivace dokladů||
|79|L|L79|přidání atributu||
|80|A|A80|9.4.2024||
|80|B|B80|1.0||
|80|E|E80|Ulice ||
|80|F|F80|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|80|G|G80|Odhlášení z registru||
|80|H|H80|Archivace dokladů||
|80|L|L80|přidání atributu||
|81|A|A81|9.4.2024||
|81|B|B81|1.0||
|81|E|E81|Číslo popisné ||
|81|F|F81|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|81|G|G81|Odhlášení z registru||
|81|H|H81|Archivace dokladů||
|81|L|L81|přidání atributu||
|82|A|A82|9.4.2024||
|82|B|B82|1.0||
|82|E|E82|Číslo orientační||
|82|F|F82|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|82|G|G82|Odhlášení z registru||
|82|H|H82|Archivace dokladů||
|82|L|L82|přidání atributu||
|83|A|A83|9.4.2024||
|83|B|B83|1.0||
|83|E|E83|Obec||
|83|F|F83|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|83|G|G83|Odhlášení z registru||
|83|H|H83|Archivace dokladů||
|83|L|L83|přidání atributu||
|84|A|A84|9.4.2024||
|84|B|B84|1.0||
|84|E|E84|PSČ||
|84|F|F84|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|84|G|G84|Odhlášení z registru||
|84|H|H84|Archivace dokladů||
|84|L|L84|přidání atributu||
|85|A|A85|9.4.2024||
|85|B|B85|1.0||
|85|E|E85|Stát||
|85|F|F85|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|85|G|G85|Odhlášení z registru||
|85|H|H85|Archivace dokladů||
|85|L|L85|přidání atributu||
|86|A|A86|9.4.2024||
|86|B|B86|1.0||
|86|E|E86|Název právního nástupce||
|86|F|F86|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|86|G|G86|Odhlášení z registru||
|86|H|H86|Právní nástupnictví||
|86|L|L86|přidání atributu||
|87|A|A87|9.4.2024||
|87|B|B87|1.0||
|87|E|E87|Variabilní symbol||
|87|F|F87|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|87|G|G87|Odhlášení z registru||
|87|H|H87|Právní nástupnictví||
|87|L|L87|přidání atributu||
|88|A|A88|9.4.2024||
|88|B|B88|1.0||
|88|E|E88|Identifikační číslo (IČO, IČ)||
|88|F|F88|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|88|G|G88|Odhlášení z registru||
|88|H|H88|Právní nástupnictví||
|88|L|L88|přidání atributu||
|89|A|A89|9.4.2024||
|89|B|B89|1.0||
|89|E|E89|Individuální číslo||
|89|F|F89|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|89|G|G89|Odhlášení z registru||
|89|H|H89|Právní nástupnictví||
|89|L|L89|přidání atributu||
|90|A|A90|9.4.2024||
|90|B|B90|1.0||
|90|E|E90|RČ||
|90|F|F90|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|90|G|G90|Odhlášení z registru||
|90|H|H90|Právní nástupnictví||
|90|L|L90|přidání atributu||
|91|A|A91|9.4.2024||
|91|B|B91|1.0||
|91|E|E91|Ulice ||
|91|F|F91|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|91|G|G91|Odhlášení z registru||
|91|H|H91|Právní nástupnictví||
|91|L|L91|přidání atributu||
|92|A|A92|9.4.2024||
|92|B|B92|1.0||
|92|E|E92|Číslo popisné ||
|92|F|F92|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|92|G|G92|Odhlášení z registru||
|92|H|H92|Právní nástupnictví||
|92|L|L92|přidání atributu||
|93|A|A93|9.4.2024||
|93|B|B93|1.0||
|93|E|E93|Číslo orientační||
|93|F|F93|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|93|G|G93|Odhlášení z registru||
|93|H|H93|Právní nástupnictví||
|93|L|L93|přidání atributu||
|94|A|A94|9.4.2024||
|94|B|B94|1.0||
|94|E|E94|Obec||
|94|F|F94|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|94|G|G94|Odhlášení z registru||
|94|H|H94|Právní nástupnictví||
|94|L|L94|přidání atributu||
|95|A|A95|9.4.2024||
|95|B|B95|1.0||
|95|E|E95|PSČ||
|95|F|F95|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|95|G|G95|Odhlášení z registru||
|95|H|H95|Právní nástupnictví||
|95|L|L95|přidání atributu||
|96|A|A96|9.4.2024||
|96|B|B96|1.0||
|96|E|E96|Stát||
|96|F|F96|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|96|G|G96|Odhlášení z registru||
|96|H|H96|Právní nástupnictví||
|96|L|L96|přidání atributu||
|97|A|A97|9.4.2024||
|97|B|B97|1.0||
|97|E|E97|Nový variabilní symbol||
|97|F|F97|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|97|L|L97|přidání atributu||
|98|A|A98|15.4.2024||
|98|B|B98|1.0||
|98|E|E98|Platnost akce ke dni||
|98|F|F98|Meta atributy||
|98|L|L98|přidání atributu||
|99|A|A99|15.4.2024||
|99|B|B99|1.0||
|99|E|E99|Příjmení||
|99|F|F99|Zaměstnanec / Žák / Student ||
|99|G|G99|Základní ídentifikace||
|99|L|L99|změna typu hlášení||
|99|M|M99|přidání k měsíčnímu hlášení||
|100|A|A100|15.4.2024||
|100|B|B100|1.0||
|100|E|E100|Jméno||
|100|F|F100|Zaměstnanec / Žák / Student ||
|100|G|G100|Základní ídentifikace||
|100|L|L100|změna typu hlášení||
|100|M|M100|přidání k měsíčnímu hlášení||
|101|A|A101|15.4.2024||
|101|B|B101|1.0||
|101|E|E101|Datum narození||
|101|F|F101|Zaměstnanec / Žák / Student ||
|101|G|G101|Základní ídentifikace||
|101|L|L101|změna typu hlášení||
|101|M|M101|přidání k měsíčnímu hlášení||
|102|A|A102|15.4.2024||
|102|B|B102|1.0||
|102|E|E102|Datum nástupu do zaměstnání||
|102|F|F102|Vykonávaná pozice zaměstnance||
|102|L|L102|změna typu hlášení||
|102|M|M102|přidání k měsíčnímu hlášení||
|103|A|A103|15.4.2024||
|103|B|B103|1.0||
|103|E|E103|Druh činnosti||
|103|F|F103|Vykonávaná pozice zaměstnance||
|103|G|G103|Činnost||
|103|L|L103|změna typu hlášení||
|103|M|M103|přidání k měsíčnímu hlášení||
|104|A|A104|17.4.2024||
|104|B|B104|1.0||
|104|E|E104|ID pracovněprávního vztahu||
|104|F|F104|Vykonávaná pozice zaměstnance||
|104|L|L104|odstranění atributu||
|104|M|M104|po domluvě v rámci týmu||
|105|A|A105|17.4.2024||
|105|B|B105|1.0||
|105|E|E105|Obec||
|105|F|F105|Vykonávaná pozice zaměstnance||
|105|G|G105|Místo výkonu práce / činnosti||
|105|L|L105|změna typu hlášení||
|105|M|M105|registrace zaměstnance -> měsíční||
|106|A|A106|17.4.2024||
|106|B|B106|1.0||
|106|E|E106|Kód obce||
|106|F|F106|Vykonávaná pozice zaměstnance||
|106|G|G106|Místo výkonu práce / činnosti||
|106|L|L106|změna typu hlášení||
|106|M|M106|registrace zaměstnance -> měsíční||
|107|A|A107|17.4.2024||
|107|B|B107|1.0||
|107|E|E107|Stát||
|107|F|F107|Vykonávaná pozice zaměstnance||
|107|G|G107|Místo výkonu práce / činnosti||
|107|L|L107|změna typu hlášení||
|107|M|M107|registrace zaměstnance -> měsíční||
|108|A|A108|17.4.2024||
|108|B|B108|1.0||
|108|E|E108|Orgán, který vydal doklad v zahraničí||
|108|F|F108|Zaměstnanec / Žák / Student ||
|108|G|G108|Prokázání totožnosti||
|108|H|H108|Doklad||
|108|L|L108|změna datového typu||
|108|M|M108|číslo -> text||
|109|A|A109|23.4.2024||
|109|B|B109|1.0||
|109|E|E109|Státní příslušnost||
|109|F|F109|Zaměstnanec / Žák / Student ||
|109|G|G109|Základní ídentifikace||
|109|L|L109|přejmenování atributu||
|110|A|A110|3.5.2024||
|110|B|B110|1.0||
|110|E|E110|-||
|110|F|F110|-||
|110|G|G110|-||
|110|L|L110|globální||
|110|M|M110|přidání číselníků k číselníkovým proměnným||
|111|A|A111|9.5.2024||
|111|B|B111|1.0||
|111|E|E111|ID pracovněprávního vztahu||
|111|F|F111|Vykonávaná pozice zaměstnance||
|111|L|L111|přidání atributu||
|111|M|M111|po domluvě v rámci týmu||
|112|A|A112|9.5.2024||
|112|B|B112|1.0||
|112|E|E112|Datum||
|112|F|F112|Vykonávaná pozice zaměstnance||
|112|G|G112|Nástup do zaměstnání||
|112|L|L112|přejmenování atributu||
|113|A|A113|9.5.2024||
|113|B|B113|1.0||
|113|E|E113|Datum||
|113|F|F113|Vykonávaná pozice zaměstnance||
|113|G|G113|Nástup do zaměstnání||
|113|L|L113|změna třídy atributu||
|114|A|A114|9.5.2024||
|114|B|B114|1.0||
|114|E|E114|Datum||
|114|F|F114|Vykonávaná pozice zaměstnance||
|114|G|G114|Ukončení zaměstnání||
|114|L|L114|přejmenování atributu||
|115|A|A115|9.5.2024||
|115|B|B115|1.0||
|115|E|E115|Datum||
|115|F|F115|Vykonávaná pozice zaměstnance||
|115|G|G115|Ukončení zaměstnání||
|115|L|L115|změna třídy atributu||
|116|A|A116|9.5.2024||
|116|B|B116|1.0||
|116|E|E116|Zaměstnání ukončeno smrtí||
|116|F|F116|Vykonávaná pozice zaměstnance||
|116|G|G116|Ukončení zaměstnání||
|116|L|L116|přidání atributu||
|117|A|A117|9.5.2024||
|117|B|B117|1.0||
|117|E|E117|Zaměstnanec nenastoupil||
|117|F|F117|Vykonávaná pozice zaměstnance||
|117|G|G117|Ukončení zaměstnání||
|117|L|L117|přidání atributu||
|118|A|A118|9.5.2024||
|118|B|B118|1.0||
|118|E|E118|Vznik zaměstnání||
|118|F|F118|Vykonávaná pozice zaměstnance||
|118|G|G118|Nástup do zaměstnání||
|118|L|L118|změna třídy atributu||
|119|A|A119|9.5.2024||
|119|B|B119|1.0||
|119|E|E119|Vznik příslušnosti k českým právním předpisům||
|119|F|F119|Vykonávaná pozice zaměstnance||
|119|G|G119|Příslušnost k předpisům||
|119|L|L119|přidání atributu||
|120|A|A120|9.5.2024||
|120|B|B120|1.0||
|120|E|E120|Skončení příslušnosti k českým právním předpisům||
|120|F|F120|Vykonávaná pozice zaměstnance||
|120|G|G120|Příslušnost k předpisům||
|120|L|L120|přidání atributu||
|121|A|A121|9.5.2024||
|121|B|B121|1.0||
|121|E|E121|Změna povinnosti - cizinec povolení nepotřebuje ode dne||
|121|F|F121|Zaměstnanec / Žák / Student ||
|121|G|G121|Pracovní oprávnění cizince||
|121|H|H121|Doba oprávnění||
|121|L|L121|přidání atributu||
|122|A|A122|10.5.2024||
|122|B|B122|1.0||
|122|E|E122|Datum zániku zaměstnavatele / zrušení mzdové účtárny||
|122|F|F122|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|122|G|G122|Odhlášení z registru||
|122|L|L122|přejmenování atributu||
|123|A|A123|10.5.2024||
|123|B|B123|1.0||
|123|E|E123|Název||
|123|F|F123|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|123|G|G123|Archivace dokladů||
|123|L|L123|změna třídy atributu||
|124|A|A124|10.5.2024||
|124|B|B124|1.0||
|124|E|E124|Ulice ||
|124|F|F124|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|124|G|G124|Archivace dokladů||
|124|L|L124|změna třídy atributu||
|125|A|A125|10.5.2024||
|125|B|B125|1.0||
|125|E|E125|Číslo popisné ||
|125|F|F125|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|125|G|G125|Archivace dokladů||
|125|L|L125|změna třídy atributu||
|126|A|A126|10.5.2024||
|126|B|B126|1.0||
|126|E|E126|Číslo orientační||
|126|F|F126|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|126|G|G126|Archivace dokladů||
|126|L|L126|změna třídy atributu||
|127|A|A127|10.5.2024||
|127|B|B127|1.0||
|127|E|E127|Obec||
|127|F|F127|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|127|G|G127|Archivace dokladů||
|127|L|L127|změna třídy atributu||
|128|A|A128|10.5.2024||
|128|B|B128|1.0||
|128|E|E128|PSČ||
|128|F|F128|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|128|G|G128|Archivace dokladů||
|128|L|L128|změna třídy atributu||
|129|A|A129|10.5.2024||
|129|B|B129|1.0||
|129|E|E129|Stát||
|129|F|F129|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|129|G|G129|Archivace dokladů||
|129|L|L129|změna třídy atributu||
|130|A|A130|10.5.2024||
|130|B|B130|1.0||
|130|E|E130|Název právního nástupce||
|130|F|F130|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|130|G|G130|Právní nástupnictví||
|130|L|L130|změna třídy atributu||
|131|A|A131|10.5.2024||
|131|B|B131|1.0||
|131|E|E131|Variabilní symbol||
|131|F|F131|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|131|G|G131|Právní nástupnictví||
|131|L|L131|změna třídy atributu||
|132|A|A132|10.5.2024||
|132|B|B132|1.0||
|132|E|E132|Identifikační číslo (IČO, IČ)||
|132|F|F132|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|132|G|G132|Právní nástupnictví||
|132|L|L132|změna třídy atributu||
|133|A|A133|10.5.2024||
|133|B|B133|1.0||
|133|E|E133|Individuální číslo||
|133|F|F133|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|133|G|G133|Právní nástupnictví||
|133|L|L133|změna třídy atributu||
|134|A|A134|10.5.2024||
|134|B|B134|1.0||
|134|E|E134|RČ||
|134|F|F134|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|134|G|G134|Právní nástupnictví||
|134|L|L134|změna třídy atributu||
|135|A|A135|10.5.2024||
|135|B|B135|1.0||
|135|E|E135|Ulice ||
|135|F|F135|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|135|G|G135|Právní nástupnictví||
|135|L|L135|změna třídy atributu||
|136|A|A136|10.5.2024||
|136|B|B136|1.0||
|136|E|E136|Číslo popisné ||
|136|F|F136|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|136|G|G136|Právní nástupnictví||
|136|L|L136|změna třídy atributu||
|137|A|A137|10.5.2024||
|137|B|B137|1.0||
|137|E|E137|Číslo orientační||
|137|F|F137|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|137|G|G137|Právní nástupnictví||
|137|L|L137|změna třídy atributu||
|138|A|A138|10.5.2024||
|138|B|B138|1.0||
|138|E|E138|Obec||
|138|F|F138|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|138|G|G138|Právní nástupnictví||
|138|L|L138|změna třídy atributu||
|139|A|A139|10.5.2024||
|139|B|B139|1.0||
|139|E|E139|PSČ||
|139|F|F139|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|139|G|G139|Právní nástupnictví||
|139|L|L139|změna třídy atributu||
|140|A|A140|10.5.2024||
|140|B|B140|1.0||
|140|E|E140|Stát||
|140|F|F140|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|140|G|G140|Právní nástupnictví||
|140|L|L140|změna třídy atributu||
|141|A|A141|10.5.2024||
|141|B|B141|1.0||
|141|E|E141|Název mzdové účtárny||
|141|F|F141|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|141|G|G141|Právní nástupnictví||
|141|H|H141|Mzdová účtárna||
|141|L|L141|změna třídy atributu||
|142|A|A142|10.5.2024||
|142|B|B142|1.0||
|142|E|E142|Ulice ||
|142|F|F142|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|142|G|G142|Právní nástupnictví||
|142|H|H142|Mzdová účtárna||
|142|L|L142|změna třídy atributu||
|143|A|A143|10.5.2024||
|143|B|B143|1.0||
|143|E|E143|Číslo popisné ||
|143|F|F143|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|143|G|G143|Právní nástupnictví||
|143|H|H143|Mzdová účtárna||
|143|L|L143|změna třídy atributu||
|144|A|A144|10.5.2024||
|144|B|B144|1.0||
|144|E|E144|Číslo orientační||
|144|F|F144|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|144|G|G144|Právní nástupnictví||
|144|H|H144|Mzdová účtárna||
|144|L|L144|změna třídy atributu||
|145|A|A145|10.5.2024||
|145|B|B145|1.0||
|145|E|E145|Obec||
|145|F|F145|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|145|G|G145|Právní nástupnictví||
|145|H|H145|Mzdová účtárna||
|145|L|L145|změna třídy atributu||
|146|A|A146|10.5.2024||
|146|B|B146|1.0||
|146|E|E146|PSČ||
|146|F|F146|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|146|G|G146|Právní nástupnictví||
|146|H|H146|Mzdová účtárna||
|146|L|L146|změna třídy atributu||
|147|A|A147|10.5.2024||
|147|B|B147|1.0||
|147|E|E147|Stát||
|147|F|F147|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|147|G|G147|Právní nástupnictví||
|147|H|H147|Mzdová účtárna||
|147|L|L147|změna třídy atributu||
|148|A|A148|10.5.2024||
|148|B|B148|1.0||
|148|E|E148|Písemná dohoda o uznání za zaměstnavatele na chráněném trhu práce dle ustanovení § 78 zákona o zaměstnanosti||
|148|F|F148|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|148|G|G148|Chráněný trh práce||
|148|L|L148|přidání atributu||
|149|A|A149|10.5.2024||
|149|B|B149|1.0||
|149|E|E149|Typ||
|149|F|F149|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|149|G|G149|Atributy subjektu||
|149|H|H149|Kolektivní smlouva||
|149|L|L149|přejmenování atributu||
|150|A|A150|10.5.2024||
|150|B|B150|1.0||
|150|E|E150|Název odborového svazu||
|150|F|F150|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|150|G|G150|Atributy subjektu||
|150|H|H150|Kolektivní smlouva||
|150|L|L150|přidání atributu||
|151|A|A151|10.5.2024||
|151|B|B151|1.0||
|151|E|E151|Název zaměstnavtelského svazu||
|151|F|F151|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|151|G|G151|Atributy subjektu||
|151|H|H151|Kolektivní smlouva||
|151|L|L151|přidání atributu||
|152|A|A152|10.5.2024||
|152|B|B152|1.0||
|152|E|E152|Zaměstnání za účelem dočasného přidělení u jiného zaměstnavatele||
|152|F|F152|Vykonávaná pozice zaměstnance||
|152|G|G152|Forma práce||
|152|H|H152|Dočasné přidělení||
|152|L|L152|změna třídy atributu||
|153|A|A153|10.5.2024||
|153|B|B153|1.0||
|153|E|E153|IČO zaměstnavatele||
|153|F|F153|Vykonávaná pozice zaměstnance||
|153|G|G153|Forma práce||
|153|H|H153|Dočasné přidělení||
|153|L|L153|přidání atributu||
|154|A|A154|13.5.2024||
|154|B|B154|1.0||
|154|E|E154|VČP||
|154|F|F154|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|154|G|G154|Identifikace||
|154|L|L154|přidání atributu||
|155|A|A155|13.5.2024||
|155|B|B155|1.0||
|155|E|E155|Klasifikace v rámci nástroje APZ||
|155|F|F155|Vykonávaná pozice zaměstnance||
|155|G|G155|Pracovní místo / pozice||
|155|H|H155|APZ||
|155|L|L155|změna třídy atributu||
|156|A|A156|13.5.2024||
|156|B|B156|1.0||
|156|E|E156|Číslo dohody||
|156|F|F156|Vykonávaná pozice zaměstnance||
|156|G|G156|Pracovní místo / pozice||
|156|H|H156|APZ||
|156|L|L156|přidání atributu||
|157|A|A157|13.5.2024||
|157|B|B157|1.0||
|157|E|E157|Číslo projektu||
|157|F|F157|Vykonávaná pozice zaměstnance||
|157|G|G157|Pracovní místo / pozice||
|157|H|H157|APZ||
|157|L|L157|přidání atributu||
|158|A|A158|13.5.2024||
|158|B|B158|1.0||
|158|E|E158|Počet odpracovaných směn v profesi zdravotnického záchranáře nebo člena HZS podniku, kde je definice těchto zaměstnání v § 37d ZDP||
|158|F|F158|Průběh zaměstnání v daném měsíci||
|158|G|G158|Odpracované směny||
|158|L|L158|přidání atributu||
|159|A|A159|13.5.2024||
|159|B|B159|1.0||
|159|E|E159|Počet odpracovaných hodin v rámci rizikové práce (§ 37d odst. 2 ZDP), práce zdravotnického záchranáře (§ 37d odst. 3) a práce člena jednotky HZS podniku (§ 37d odst. 3)  ||
|159|F|F159|Průběh zaměstnání v daném měsíci||
|159|G|G159|Odpracované hodiny||
|159|L|L159|přidání atributu||
|160|A|A160|13.5.2024||
|160|B|B160|1.0||
|160|E|E160|Kategorizace rizika||
|160|F|F160|Průběh zaměstnání v daném měsíci||
|160|G|G160|Odpracované hodiny||
|160|L|L160|přidání atributu||
|161|A|A161|13.5.2024||
|161|B|B161|1.0||
|161|E|E161|Úhrn zúčtovaných příjmů / hrubá mzda - celkem||
|161|F|F161|Příjem v daném měsíci||
|161|G|G161|Výpočet daně||
|161|L|L161|přejmenování atributu||
|162|A|A162|13.5.2024||
|162|B|B162|1.0||
|162|E|E162|Úhrn zúčtovaných příjmů / hrubá mzda - peněžní příjmy||
|162|F|F162|Příjem v daném měsíci||
|162|G|G162|Výpočet daně||
|162|L|L162|přidání atributu||
|163|A|A163|13.5.2024||
|163|B|B163|1.0||
|163|E|E163|Úhrn zúčtovaných příjmů / hrubá mzda - nepeněžní příjmy / naturální mzda||
|163|F|F163|Příjem v daném měsíci||
|163|G|G163|Výpočet daně||
|163|L|L163|přidání atributu||
|164|A|A164|13.5.2024||
|164|B|B164|1.0||
|164|E|E164|Úhrn osvobozených příjmů (ze zúčtovaných) - celkem||
|164|F|F164|Příjem v daném měsíci||
|164|G|G164|Výpočet daně||
|164|L|L164|přejmenování atributu||
|165|A|A165|13.5.2024||
|165|B|B165|1.0||
|165|E|E165|Úhrn osvobozených příjmů (ze zúčtovaných) - peněžní příjmy||
|165|F|F165|Příjem v daném měsíci||
|165|G|G165|Výpočet daně||
|165|L|L165|přidání atributu||
|166|A|A166|13.5.2024||
|166|B|B166|1.0||
|166|E|E166|Úhrn osvobozených příjmů (ze zúčtovaných) - nepeněžní příjmy / naturální mzda||
|166|F|F166|Příjem v daném měsíci||
|166|G|G166|Výpočet daně||
|166|L|L166|přidání atributu||
|167|A|A167|13.5.2024||
|167|B|B167|1.0||
|167|E|E167|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. (§ 5 odst. 4 ZDP) - celkem||
|167|F|F167|Příjem v daném měsíci||
|167|G|G167|Roční úhrny jednotlivých položek||
|167|L|L167|přejmenování atributu||
|168|A|A168|13.5.2024||
|168|B|B168|1.0||
|168|E|E168|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. (§ 5 odst. 4 ZDP) - peněžní příjmy||
|168|F|F168|Příjem v daném měsíci||
|168|G|G168|Roční úhrny jednotlivých položek||
|168|L|L168|přidání atributu||
|169|A|A169|13.5.2024||
|169|B|B169|1.0||
|169|E|E169|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. (§ 5 odst. 4 ZDP) - nepeněžní příjmy / naturální mzda||
|169|F|F169|Příjem v daném měsíci||
|169|G|G169|Roční úhrny jednotlivých položek||
|169|L|L169|přidání atributu||
|170|A|A170|13.5.2024||
|170|B|B170|1.0||
|170|E|E170|Hrubá mzda||
|170|F|F170|Příjem v daném měsíci||
|170|G|G170|Výdělek||
|170|L|L170|odstranění atributu||
|171|A|A171|14.5.2024||
|171|B|B171|1.0||
|171|E|E171|Průměrný evidenční počet zaměstnanců ve fyzických osobách (bez DPP a DPČ)||
|171|F|F171|Nadstavba||
|171|G|G171|Počet zaměstnanců||
|171|L|L171|přidání atributu||
|171|M|M171|rozšíření nadstavby od ČSÚ||
|172|A|A172|14.5.2024||
|172|B|B172|1.0||
|172|E|E172|Průměrný evidenční počet zaměstnanců přepočtený (bez DPP a DPČ) ||
|172|F|F172|Nadstavba||
|172|G|G172|Počet zaměstnanců||
|172|L|L172|přidání atributu||
|172|M|M172|rozšíření nadstavby od ČSÚ||
|173|A|A173|14.5.2024||
|173|B|B173|1.0||
|173|E|E173|Počet osob pracujících na DPP (fyzické osoby)||
|173|F|F173|Nadstavba||
|173|G|G173|Počet zaměstnanců||
|173|L|L173|přidání atributu||
|173|M|M173|rozšíření nadstavby od ČSÚ||
|174|A|A174|14.5.2024||
|174|B|B174|1.0||
|174|E|E174|Počet osob pracujících na DPČ (fyzické osoby)||
|174|F|F174|Nadstavba||
|174|G|G174|Počet zaměstnanců||
|174|L|L174|přidání atributu||
|174|M|M174|rozšíření nadstavby od ČSÚ||
|175|A|A175|14.5.2024||
|175|B|B175|1.0||
|175|E|E175|Počet odpracovaných hodin zaměstnanci v evidenčním počtu||
|175|F|F175|Nadstavba||
|175|G|G175|Odpracované hodiny||
|175|L|L175|přidání atributu||
|175|M|M175|rozšíření nadstavby od ČSÚ||
|176|A|A176|14.5.2024||
|176|B|B176|1.0||
|176|E|E176|Počet odpracovaných hodin osobami pracujícími na DPP||
|176|F|F176|Nadstavba||
|176|G|G176|Odpracované hodiny||
|176|L|L176|přidání atributu||
|176|M|M176|rozšíření nadstavby od ČSÚ||
|177|A|A177|14.5.2024||
|177|B|B177|1.0||
|177|E|E177|Počet odpracovaných hodin osobami pracujícími na DPČ||
|177|F|F177|Nadstavba||
|177|G|G177|Odpracované hodiny||
|177|L|L177|přidání atributu||
|177|M|M177|rozšíření nadstavby od ČSÚ||
|178|A|A178|14.5.2024||
|178|B|B178|1.0||
|178|E|E178|Vyplacená hrubá mzda (včetně příplatků a náhrad mzdy, bez náhrad za nemocenskou placených zaměstnavatelem) – bez OON ||
|178|F|F178|Nadstavba||
|178|G|G178|Mzda||
|178|L|L178|přidání atributu||
|178|M|M178|rozšíření nadstavby od ČSÚ||
|179|A|A179|14.5.2024||
|179|B|B179|1.0||
|179|E|E179|Vyplacené odměny celkem||
|179|F|F179|Nadstavba||
|179|G|G179|Mzda||
|179|L|L179|přidání atributu||
|179|M|M179|rozšíření nadstavby od ČSÚ||
|180|A|A180|14.5.2024||
|180|B|B180|1.0||
|180|E|E180|Vyplacené odměny z DPP||
|180|F|F180|Nadstavba||
|180|G|G180|Mzda||
|180|L|L180|přidání atributu||
|180|M|M180|rozšíření nadstavby od ČSÚ||
|181|A|A181|14.5.2024||
|181|B|B181|1.0||
|181|E|E181|Vyplacené odměny z DPČ||
|181|F|F181|Nadstavba||
|181|G|G181|Mzda||
|181|L|L181|přidání atributu||
|181|M|M181|rozšíření nadstavby od ČSÚ||
|182|A|A182|21.5.2024||
|182|B|B182|1.0||
|182|E|E182|Datum zjištění pro případ podání následného vyúčtování||
|182|F|F182|Příjem v daném měsíci||
|182|G|G182|Přeplatek nedoplatek||
|182|L|L182|odstranění atributu||
|182|M|M182|oponentura DS||
|183|A|A183|21.5.2024||
|183|B|B183|1.0||
|183|E|E183|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. (§ 5 odst. 4 ZDP) - příjmy zdanitelné zálohou na daň - celkem||
|183|F|F183|Příjem v daném měsíci||
|183|G|G183|Roční úhrny jednotlivých položek||
|183|L|L183|přejmenování atributu||
|183|M|M183|oponentura DS||
|184|A|A184|21.5.2024||
|184|B|B184|1.0||
|184|E|E184|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. (§ 5 odst. 4 ZDP) - příjmy zdanitelné zálohou na daň - peněžní příjmy||
|184|F|F184|Příjem v daném měsíci||
|184|G|G184|Roční úhrny jednotlivých položek||
|184|L|L184|přejmenování atributu||
|184|M|M184|oponentura DS||
|185|A|A185|21.5.2024||
|185|B|B185|1.0||
|185|E|E185|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. (§ 5 odst. 4 ZDP) - příjmy zdanitelné zálohou na daň - nepeněžní příjmy / naturální mzda||
|185|F|F185|Příjem v daném měsíci||
|185|G|G185|Roční úhrny jednotlivých položek||
|185|L|L185|přejmenování atributu||
|185|M|M185|oponentura DS||
|186|A|A186|21.5.2024||
|186|B|B186|1.0||
|186|E|E186|Doplatky příjmů zdanitelných v ČR podle § 5 odst. 4 ZDP (za předcházející období) - zálohová daň||
|186|F|F186|Příjem v daném měsíci||
|186|G|G186|Roční úhrny jednotlivých položek||
|186|L|L186|přejmenování atributu||
|186|M|M186|oponentura DS||
|187|A|A187|21.5.2024||
|187|B|B187|1.0||
|187|E|E187|Název||
|187|F|F187|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|187|G|G187|Peněžní účty||
|187|H|H187|Peněžní ústav||
|187|L|L187|přejmenování atributu||
|187|M|M187|vytvoření třídy pro Peněžní ústav||
|188|A|A188|21.5.2024||
|188|B|B188|1.0||
|188|E|E188|Název||
|188|F|F188|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|188|G|G188|Peněžní účty||
|188|H|H188|Peněžní ústav||
|188|L|L188|změna třídy atributu||
|188|M|M188|vytvoření třídy pro Peněžní ústav||
|189|A|A189|21.5.2024||
|189|B|B189|1.0||
|189|E|E189|Ulice ||
|189|F|F189|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|189|G|G189|Peněžní účty||
|189|H|H189|Peněžní ústav||
|189|L|L189|změna třídy atributu||
|189|M|M189|vytvoření třídy pro Peněžní ústav||
|190|A|A190|21.5.2024||
|190|B|B190|1.0||
|190|E|E190|Číslo popisné ||
|190|F|F190|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|190|G|G190|Peněžní účty||
|190|H|H190|Peněžní ústav||
|190|L|L190|změna třídy atributu||
|190|M|M190|vytvoření třídy pro Peněžní ústav||
|191|A|A191|21.5.2024||
|191|B|B191|1.0||
|191|E|E191|Číslo orientační||
|191|F|F191|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|191|G|G191|Peněžní účty||
|191|H|H191|Peněžní ústav||
|191|L|L191|změna třídy atributu||
|191|M|M191|vytvoření třídy pro Peněžní ústav||
|192|A|A192|21.5.2024||
|192|B|B192|1.0||
|192|E|E192|Obec||
|192|F|F192|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|192|G|G192|Peněžní účty||
|192|H|H192|Peněžní ústav||
|192|L|L192|změna třídy atributu||
|192|M|M192|vytvoření třídy pro Peněžní ústav||
|193|A|A193|21.5.2024||
|193|B|B193|1.0||
|193|E|E193|PSČ||
|193|F|F193|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|193|G|G193|Peněžní účty||
|193|H|H193|Peněžní ústav||
|193|L|L193|změna třídy atributu||
|193|M|M193|vytvoření třídy pro Peněžní ústav||
|194|A|A194|21.5.2024||
|194|B|B194|1.0||
|194|E|E194|Stát||
|194|F|F194|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|194|G|G194|Peněžní účty||
|194|H|H194|Peněžní ústav||
|194|L|L194|změna třídy atributu||
|194|M|M194|vytvoření třídy pro Peněžní ústav||
|195|A|A195|21.5.2024||
|195|B|B195|1.0||
|195|E|E195|Ulice ||
|195|F|F195|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|195|G|G195|Archivace dokladů||
|195|H|H195|Adresa||
|195|L|L195|změna třídy atributu||
|195|M|M195|vytvoření třídy pro Adresu||
|196|A|A196|21.5.2024||
|196|B|B196|1.0||
|196|E|E196|Číslo popisné ||
|196|F|F196|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|196|G|G196|Archivace dokladů||
|196|H|H196|Adresa||
|196|L|L196|změna třídy atributu||
|196|M|M196|vytvoření třídy pro Adresu||
|197|A|A197|21.5.2024||
|197|B|B197|1.0||
|197|E|E197|Číslo orientační||
|197|F|F197|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|197|G|G197|Archivace dokladů||
|197|H|H197|Adresa||
|197|L|L197|změna třídy atributu||
|197|M|M197|vytvoření třídy pro Adresu||
|198|A|A198|21.5.2024||
|198|B|B198|1.0||
|198|E|E198|Obec||
|198|F|F198|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|198|G|G198|Archivace dokladů||
|198|H|H198|Adresa||
|198|L|L198|změna třídy atributu||
|198|M|M198|vytvoření třídy pro Adresu||
|199|A|A199|21.5.2024||
|199|B|B199|1.0||
|199|E|E199|PSČ||
|199|F|F199|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|199|G|G199|Archivace dokladů||
|199|H|H199|Adresa||
|199|L|L199|změna třídy atributu||
|199|M|M199|vytvoření třídy pro Adresu||
|200|A|A200|21.5.2024||
|200|B|B200|1.0||
|200|E|E200|Stát||
|200|F|F200|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|200|G|G200|Archivace dokladů||
|200|H|H200|Adresa||
|200|L|L200|změna třídy atributu||
|200|M|M200|vytvoření třídy pro Adresu||
|201|A|A201|21.5.2024||
|201|B|B201|1.0||
|201|E|E201|Ulice ||
|201|F|F201|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|201|G|G201|Právní nástupnictví||
|201|H|H201|Adresa||
|201|L|L201|změna třídy atributu||
|201|M|M201|vytvoření třídy pro Adresu||
|202|A|A202|21.5.2024||
|202|B|B202|1.0||
|202|E|E202|Číslo popisné ||
|202|F|F202|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|202|G|G202|Právní nástupnictví||
|202|H|H202|Adresa||
|202|L|L202|změna třídy atributu||
|202|M|M202|vytvoření třídy pro Adresu||
|203|A|A203|21.5.2024||
|203|B|B203|1.0||
|203|E|E203|Číslo orientační||
|203|F|F203|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|203|G|G203|Právní nástupnictví||
|203|H|H203|Adresa||
|203|L|L203|změna třídy atributu||
|203|M|M203|vytvoření třídy pro Adresu||
|204|A|A204|21.5.2024||
|204|B|B204|1.0||
|204|E|E204|Obec||
|204|F|F204|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|204|G|G204|Právní nástupnictví||
|204|H|H204|Adresa||
|204|L|L204|změna třídy atributu||
|204|M|M204|vytvoření třídy pro Adresu||
|205|A|A205|21.5.2024||
|205|B|B205|1.0||
|205|E|E205|PSČ||
|205|F|F205|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|205|G|G205|Právní nástupnictví||
|205|H|H205|Adresa||
|205|L|L205|změna třídy atributu||
|205|M|M205|vytvoření třídy pro Adresu||
|206|A|A206|21.5.2024||
|206|B|B206|1.0||
|206|E|E206|Stát||
|206|F|F206|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|206|G|G206|Právní nástupnictví||
|206|H|H206|Adresa||
|206|L|L206|změna třídy atributu||
|206|M|M206|vytvoření třídy pro Adresu||
|207|A|A207|22.5.2024||
|207|B|B207|1.0||
|207|E|E207|Kód adresního místa||
|207|F|F207|Zaměstnanec / Žák / Student ||
|207|G|G207|Adresa||
|207|L|L207|přidání atributu||
|207|M|M207|převedení adres na RUIAN||
|208|A|A208|22.5.2024||
|208|B|B208|1.0||
|208|E|E208|Kód adresního místa||
|208|F|F208|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|208|G|G208|Adresa||
|208|L|L208|přidání atributu||
|208|M|M208|převedení adres na RUIAN||
|209|A|A209|22.5.2024||
|209|B|B209|1.0||
|209|E|E209|Kód adresního místa||
|209|F|F209|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|209|G|G209|Peněžní účty||
|209|H|H209|Peněžní ústav||
|209|L|L209|přidání atributu||
|209|M|M209|převedení adres na RUIAN||
|210|A|A210|22.5.2024||
|210|B|B210|1.0||
|210|E|E210|Kód adresního místa||
|210|F|F210|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|210|G|G210|Archivace dokladů||
|210|H|H210|Adresa||
|210|L|L210|přidání atributu||
|210|M|M210|převedení adres na RUIAN||
|211|A|A211|22.5.2024||
|211|B|B211|1.0||
|211|E|E211|Kód adresního místa||
|211|F|F211|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|211|G|G211|Právní nástupnictví||
|211|H|H211|Adresa||
|211|L|L211|přidání atributu||
|211|M|M211|převedení adres na RUIAN||
|212|A|A212|22.5.2024||
|212|B|B212|1.0||
|212|E|E212|Kód adresního místa||
|212|F|F212|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|212|G|G212|Mzdová účtárna zaměstnavatele||
|212|H|H212|Adresa||
|212|L|L212|přidání atributu||
|212|M|M212|převedení adres na RUIAN||
|213|A|A213|22.5.2024||
|213|B|B213|1.0||
|213|E|E213|Kód adresního místa||
|213|F|F213|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|213|G|G213|Peněžní účty||
|213|H|H213|Peněžní ústav||
|213|L|L213|přidání atributu||
|213|M|M213|převedení adres na RUIAN||
|214|A|A214|22.5.2024||
|214|B|B214|1.0||
|214|E|E214|Pošta||
|214|F|F214|Zaměstnanec / Žák / Student ||
|214|G|G214|Adresa||
|214|L|L214|odstranění atributu||
|214|M|M214|převedení adres na RUIAN||
|215|A|A215|22.5.2024||
|215|B|B215|1.0||
|215|E|E215|Kód obce||
|215|F|F215|Zaměstnanec / Žák / Student ||
|215|G|G215|Adresa||
|215|L|L215|odstranění atributu||
|215|M|M215|převedení adres na RUIAN||
|216|A|A216|23.5.2024||
|216|B|B216|1.0||
|216|E|E216|Daňové identifikační číslo (DIČ)||
|216|F|F216|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|216|G|G216|Identifikace||
|216|L|L216|odstranění atributu||
|216|M|M216|hodnotu je možné složit z ostatních identifikátorů||
|217|A|A217|23.5.2024||
|217|B|B217|1.0||
|217|E|E217|Výše naturální mzdy z hrubé mzdy||
|217|F|F217|Příjem v daném měsíci||
|217|G|G217|Výdělek||
|217|L|L217|odstranění atributu||
|217|M|M217|atribut omylem zůstal po odstranění Hrubé mzdy||
|218|A|A218|23.5.2024||
|218|B|B218|1.0||
|218|E|E218|Daňové identifikační číslo (DIČ)||
|218|F|F218|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|218|G|G218|Identifikace||
|218|L|L218|odstranění atributu||
|218|M|M218|oponentura DS||
|219|A|A219|24.5.2024||
|219|B|B219|1.0||
|219|E|E219|Datum vydání||
|219|F|F219|Zaměstnanec / Žák / Student ||
|219|G|G219|Prokázání totožnosti||
|219|H|H219|Doklad||
|219|L|L219|přidání atributu||
|219|M|M219|oponentura DS||
|220|A|A220|24.5.2024||
|220|B|B220|1.0||
|220|E|E220|Datum platnosti||
|220|F|F220|Zaměstnanec / Žák / Student ||
|220|G|G220|Prokázání totožnosti||
|220|H|H220|Doklad||
|220|L|L220|přidání atributu||
|220|M|M220|oponentura DS||
|221|A|A221|24.5.2024||
|221|B|B221|1.0||
|221|E|E221|Telefon||
|221|F|F221|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|221|G|G221|Mzdová účtárna zaměstnavatele||
|221|L|L221|přidání atributu||
|221|M|M221|oponentura DS||
|222|A|A222|24.5.2024||
|222|B|B222|1.0||
|222|E|E222|Pracovně právní vztah||
|222|F|F222|Vykonávaná pozice zaměstnance||
|222|G|G222|Forma práce||
|222|L|L222|přejmenování atributu||
|222|M|M222|konsolidace s DV||
|223|A|A223|24.5.2024||
|223|B|B223|1.0||
|223|E|E223|Oznámená DPP||
|223|F|F223|Vykonávaná pozice zaměstnance||
|223|G|G223|Forma práce||
|223|L|L223|přidání atributu||
|223|M|M223|oponentura DS||
|224|A|A224|27.5.2024||
|224|B|B224|1.0||
|224|E|E224|Typ rozhodné skutečnosti||
|224|F|F224|Příjem v daném měsíci||
|224|G|G224|Přeplatek nedoplatek||
|224|H|H224|Rozhodná skutečnost||
|224|L|L224|přidání atributu||
|224|M|M224|oponentura DS||
|225|A|A225|27.5.2024||
|225|B|B225|1.0||
|225|E|E225|Datum||
|225|F|F225|Příjem v daném měsíci||
|225|G|G225|Přeplatek nedoplatek||
|225|H|H225|Rozhodná skutečnost||
|225|L|L225|přidání atributu||
|225|M|M225|oponentura DS||
|226|A|A226|27.5.2024||
|226|B|B226|1.0||
|226|E|E226|Výplatní termín||
|226|F|F226|Příjem v daném měsíci||
|226|G|G226|Přeplatek nedoplatek||
|226|H|H226|Rozhodná skutečnost||
|226|L|L226|přidání atributu||
|226|M|M226|oponentura DS||
|227|A|A227|27.5.2024||
|227|B|B227|1.0||
|227|E|E227|Pojištění od||
|227|F|F227|Průběh pojištění v daném měsíci||
|227|G|G227|Trvání pojištění||
|227|L|L227|přidání atributu||
|227|M|M227|oponentura DS||
|228|A|A228|27.5.2024||
|228|B|B228|1.0||
|228|E|E228|Pojištění do||
|228|F|F228|Průběh pojištění v daném měsíci||
|228|G|G228|Trvání pojištění||
|228|L|L228|přidání atributu||
|228|M|M228|oponentura DS||
|229|A|A229|27.5.2024||
|229|B|B229|1.0||
|229|E|E229|Státní občanství||
|229|F|F229|Zaměstnanec / Žák / Student ||
|229|G|G229|Základní ídentifikace||
|229|L|L229|přejmenování atributu||
|229|M|M229|konsolidace s DV||
|230|A|A230|27.5.2024||
|230|B|B230|1.0||
|230|E|E230|Kód obce||
|230|F|F230|Zaměstnanec / Žák / Student ||
|230|G|G230|Adresa||
|230|L|L230|přidání atributu||
|230|M|M230|univerzalizace objektu adresy||
|231|A|A231|27.5.2024||
|231|B|B231|1.0||
|231|E|E231|Kód obce||
|231|F|F231|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|231|G|G231|Adresa||
|231|L|L231|přidání atributu||
|231|M|M231|univerzalizace objektu adresy||
|232|A|A232|27.5.2024||
|232|B|B232|1.0||
|232|E|E232|Kód obce||
|232|F|F232|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|232|G|G232|Archivace dokladů||
|232|H|H232|Adresa||
|232|L|L232|přidání atributu||
|232|M|M232|univerzalizace objektu adresy||
|233|A|A233|27.5.2024||
|233|B|B233|1.0||
|233|E|E233|Kód obce||
|233|F|F233|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|233|G|G233|Právní nástupnictví||
|233|H|H233|Adresa||
|233|L|L233|přidání atributu||
|233|M|M233|univerzalizace objektu adresy||
|234|A|A234|27.5.2024||
|234|B|B234|1.0||
|234|E|E234|Kód obce||
|234|F|F234|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|234|G|G234|Právní nástupnictví||
|234|H|H234|Mzdová účtárna||
|234|L|L234|přidání atributu||
|234|M|M234|univerzalizace objektu adresy||
|235|A|A235|27.5.2024||
|235|B|B235|1.0||
|235|E|E235|Kód obce||
|235|F|F235|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|235|G|G235|Mzdová účtárna zaměstnavatele||
|235|H|H235|Adresa||
|235|L|L235|přidání atributu||
|235|M|M235|univerzalizace objektu adresy||
|236|A|A236|27.5.2024||
|236|B|B236|1.0||
|236|E|E236|Kód obce||
|236|F|F236|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|236|G|G236|Peněžní účty||
|236|H|H236|Peněžní ústav||
|236|L|L236|přidání atributu||
|236|M|M236|univerzalizace objektu adresy||
|237|A|A237|27.5.2024||
|237|B|B237|1.0||
|237|E|E237|Rodné číslo||
|237|F|F237|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|237|G|G237|Identifikace||
|237|L|L237|přejmenování atributu||
|237|M|M237|sjednocení se zbytkem slovníku||
|238|A|A238|27.5.2024||
|238|B|B238|1.0||
|238|E|E238|Kód OSSZ||
|238|F|F238|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|238|G|G238|Kódy SSZ||
|238|L|L238|odstranění atributu||
|238|M|M238|duplicita||
|239|A|A239|27.5.2024||
|239|B|B239|1.0||
|239|E|E239|EČP||
|239|F|F239|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|239|G|G239|Identifikace||
|239|L|L239|přidání atributu||
|239|M|M239|sjednocení se zbytkem slovníku||
|240|A|A240|27.5.2024||
|240|B|B240|1.0||
|240|E|E240|Rodné číslo původního zaměstnavatele||
|240|F|F240|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|240|G|G240|Vznik||
|240|H|H240|Právní nástupnictví||
|240|L|L240|přejmenování atributu||
|240|M|M240|sjednocení se zbytkem slovníku||
|241|A|A241|28.5.2024||
|241|B|B241|1.0||
|241|E|E241|Typ zdravotního omezení||
|241|F|F241|Zaměstnanec / Žák / Student ||
|241|G|G241|Deklarované skutečnosti ze strany zaměstnance||
|241|H|H241|Zdravotní omezení||
|241|L|L241|přejmenování atributu||
|241|M|M241|přejmenování kvůli záměně s ustáleným pojmem Zdravotní znevýhodnění||
|242|A|A242|28.5.2024||
|242|B|B242|1.0||
|242|E|E242|Zdravotní omezení přiznané od||
|242|F|F242|Zaměstnanec / Žák / Student ||
|242|G|G242|Deklarované skutečnosti ze strany zaměstnance||
|242|H|H242|Zdravotní omezení||
|242|L|L242|přejmenování atributu||
|242|M|M242|přejmenování kvůli záměně s ustáleným pojmem Zdravotní znevýhodnění||
|243|A|A243|28.5.2024||
|243|B|B243|1.0||
|243|E|E243|Zdravotní omezení přiznané do||
|243|F|F243|Zaměstnanec / Žák / Student ||
|243|G|G243|Deklarované skutečnosti ze strany zaměstnance||
|243|H|H243|Zdravotní omezení||
|243|L|L243|přejmenování atributu||
|243|M|M243|přejmenování kvůli záměně s ustáleným pojmem Zdravotní znevýhodnění||
|244|A|A244|29.5.2024||
|244|B|B244|1.0||
|244|E|E244|Vydala Krajská pobočka ÚP ČR||
|244|F|F244|Zaměstnanec / Žák / Student ||
|244|G|G244|Pracovní oprávnění cizince||
|244|L|L244|přidání atributu||
|244|M|M244|oponentura DS||
|245|A|A245|29.5.2024||
|245|B|B245|1.0||
|245|E|E245|Pohlaví||
|245|F|F245|Zaměstnanec / Žák / Student ||
|245|G|G245|Základní ídentifikace||
|245|L|L245|změna datového typu||
|245|M|M245|číselník -> výčet||
|246|A|A246|30.5.2024||
|246|B|B246|1.0||
|246|E|E246|EČP původního zaměstnavatele||
|246|F|F246|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|246|G|G246|Vznik||
|246|H|H246|Právní nástupnictví||
|246|L|L246|přidání atributu||
|246|M|M246|oponentura DS||
|247|A|A247|30.5.2024||
|247|B|B247|1.0||
|247|E|E247|EČP||
|247|F|F247|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|247|G|G247|Právní nástupnictví||
|247|L|L247|přidání atributu||
|247|M|M247|oponentura DS||
|248|A|A248|30.5.2024||
|248|B|B248|1.0||
|248|E|E248|Rodné číslo||
|248|F|F248|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|248|G|G248|Právní nástupnictví||
|248|L|L248|přejmenování atributu||
|248|M|M248|sjednocení se zbytkem slovníku||
|249|A|A249|30.5.2024||
|249|B|B249|1.0||
|249|E|E249|ID datové schránky pro notifikace zpracování||
|249|F|F249|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|249|G|G249|Kontakty||
|249|L|L249|přidání atributu||
|249|M|M249|oponentura DS||
|250|A|A250|3.6.2024||
|250|B|B250|1.0||
|250|E|E250|Odvětví||
|250|F|F250|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|250|G|G250|Ekonomická činnost||
|250|L|L250|odstranění atributu||
|250|M|M250|odebráno na základě schůzek s ČSÚ a MPSV||
|251|A|A251|3.6.2024||
|251|B|B251|1.0||
|251|E|E251|Úhrn vyměřovacích základů zaměstnanců, kteří nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|251|F|F251|Souhrnná vrstva||
|251|G|G251|Odváděné pojistné||
|251|L|L251|změna třídy atributu||
|251|M|M251|úprava názvu třídy na Souhrnná vrstva||
|252|A|A252|3.6.2024||
|252|B|B252|1.0||
|252|E|E252|Pojistné za zaměstnavatele u zaměstnanců, kteří nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|252|F|F252|Souhrnná vrstva||
|252|G|G252|Odváděné pojistné||
|252|L|L252|změna třídy atributu||
|252|M|M252|úprava názvu třídy na Souhrnná vrstva||
|253|A|A253|3.6.2024||
|253|B|B253|1.0||
|253|E|E253|Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku||
|253|F|F253|Souhrnná vrstva||
|253|G|G253|Odváděné pojistné||
|253|L|L253|změna třídy atributu||
|253|M|M253|úprava názvu třídy na Souhrnná vrstva||
|254|A|A254|3.6.2024||
|254|B|B254|1.0||
|254|E|E254|Pojistné za zaměstnavatele u zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku||
|254|F|F254|Souhrnná vrstva||
|254|G|G254|Odváděné pojistné||
|254|L|L254|změna třídy atributu||
|254|M|M254|úprava názvu třídy na Souhrnná vrstva||
|255|A|A255|3.6.2024||
|255|B|B255|1.0||
|255|E|E255|Pojistné za zaměstnavatele celkem (součet úhrnů)||
|255|F|F255|Souhrnná vrstva||
|255|G|G255|Odváděné pojistné||
|255|L|L255|změna třídy atributu||
|255|M|M255|úprava názvu třídy na Souhrnná vrstva||
|256|A|A256|3.6.2024||
|256|B|B256|1.0||
|256|E|E256|Pojistné za zaměstnance||
|256|F|F256|Souhrnná vrstva||
|256|G|G256|Odváděné pojistné||
|256|L|L256|změna třídy atributu||
|256|M|M256|úprava názvu třídy na Souhrnná vrstva||
|257|A|A257|3.6.2024||
|257|B|B257|1.0||
|257|E|E257|Pojistné celkem||
|257|F|F257|Souhrnná vrstva||
|257|G|G257|Odváděné pojistné||
|257|L|L257|změna třídy atributu||
|257|M|M257|úprava názvu třídy na Souhrnná vrstva||
|258|A|A258|3.6.2024||
|258|B|B258|1.0||
|258|E|E258|Počet zaměstnanců||
|258|F|F258|Souhrnná vrstva||
|258|G|G258|Slevy na pojistném||
|258|L|L258|změna třídy atributu||
|258|M|M258|úprava názvu třídy na Souhrnná vrstva||
|259|A|A259|3.6.2024||
|259|B|B259|1.0||
|259|E|E259|Úhrn vyměřovacích základů zaměstnanců||
|259|F|F259|Souhrnná vrstva||
|259|G|G259|Slevy na pojistném||
|259|L|L259|změna třídy atributu||
|259|M|M259|úprava názvu třídy na Souhrnná vrstva||
|260|A|A260|3.6.2024||
|260|B|B260|1.0||
|260|E|E260|Sleva na pojistném||
|260|F|F260|Souhrnná vrstva||
|260|G|G260|Slevy na pojistném||
|260|L|L260|změna třídy atributu||
|260|M|M260|úprava názvu třídy na Souhrnná vrstva||
|261|A|A261|3.6.2024||
|261|B|B261|1.0||
|261|E|E261|Vypočítané pojistné (rozdíl mezi pojistným celkem a slevou na pojistném)||
|261|F|F261|Souhrnná vrstva||
|261|G|G261|Pojistné k úhradě||
|261|L|L261|změna třídy atributu||
|261|M|M261|úprava názvu třídy na Souhrnná vrstva||
|262|A|A262|3.6.2024||
|262|B|B262|1.0||
|262|E|E262|Skutečně sražená záloha na daň po slevě||
|262|F|F262|Souhrnná vrstva||
|262|G|G262|Daň||
|262|H|H262|Měsíční údaj||
|262|L|L262|změna třídy atributu||
|262|M|M262|úprava názvu třídy na Souhrnná vrstva||
|263|A|A263|3.6.2024||
|263|B|B263|1.0||
|263|E|E263|Výše vyplaceného měsíčního daňového bonusu||
|263|F|F263|Souhrnná vrstva||
|263|G|G263|Daň||
|263|H|H263|Měsíční údaj||
|263|L|L263|změna třídy atributu||
|263|M|M263|úprava názvu třídy na Souhrnná vrstva||
|264|A|A264|3.6.2024||
|264|B|B264|1.0||
|264|E|E264|Přeplatek daně z ročního zúčtování||
|264|F|F264|Souhrnná vrstva||
|264|G|G264|Daň||
|264|H|H264|Údaj ve stanoveném období||
|264|L|L264|změna třídy atributu||
|264|M|M264|úprava názvu třídy na Souhrnná vrstva||
|265|A|A265|3.6.2024||
|265|B|B265|1.0||
|265|E|E265|Doplatek na daňovém bonusu z ročního zúčtování||
|265|F|F265|Souhrnná vrstva||
|265|G|G265|Daň||
|265|H|H265|Údaj ve stanoveném období||
|265|L|L265|změna třídy atributu||
|265|M|M265|úprava názvu třídy na Souhrnná vrstva||
|266|A|A266|3.6.2024||
|266|B|B266|1.0||
|266|E|E266|Průměrný roční přepočtený počet zaměstnanců||
|266|F|F266|Souhrnná vrstva||
|266|G|G266|Plnění povinného podílu zaměstnávání OZP||
|266|L|L266|změna třídy atributu||
|266|M|M266|úprava názvu třídy na Souhrnná vrstva||
|267|A|A267|3.6.2024||
|267|B|B267|1.0||
|267|E|E267|Průměrný roční přepočtený počet zaměstnanců, kteří jsou Och||
|267|F|F267|Souhrnná vrstva||
|267|G|G267|Plnění povinného podílu zaměstnávání OZP||
|267|L|L267|změna třídy atributu||
|267|M|M267|úprava názvu třídy na Souhrnná vrstva||
|268|A|A268|3.6.2024||
|268|B|B268|1.0||
|268|E|E268|Průměrný evidenční počet zaměstnanců ve fyzických osobách (bez DPP a DPČ)||
|268|F|F268|Souhrnná vrstva||
|268|G|G268|Počet zaměstnanců||
|268|L|L268|změna třídy atributu||
|268|M|M268|úprava názvu třídy na Souhrnná vrstva||
|269|A|A269|3.6.2024||
|269|B|B269|1.0||
|269|E|E269|Průměrný evidenční počet zaměstnanců přepočtený (bez DPP a DPČ) ||
|269|F|F269|Souhrnná vrstva||
|269|G|G269|Počet zaměstnanců||
|269|L|L269|změna třídy atributu||
|269|M|M269|úprava názvu třídy na Souhrnná vrstva||
|270|A|A270|3.6.2024||
|270|B|B270|1.0||
|270|E|E270|Počet osob pracujících na DPP (fyzické osoby)||
|270|F|F270|Souhrnná vrstva||
|270|G|G270|Počet zaměstnanců||
|270|L|L270|změna třídy atributu||
|270|M|M270|úprava názvu třídy na Souhrnná vrstva||
|271|A|A271|3.6.2024||
|271|B|B271|1.0||
|271|E|E271|Počet osob pracujících na DPČ (fyzické osoby)||
|271|F|F271|Souhrnná vrstva||
|271|G|G271|Počet zaměstnanců||
|271|L|L271|změna třídy atributu||
|271|M|M271|úprava názvu třídy na Souhrnná vrstva||
|272|A|A272|3.6.2024||
|272|B|B272|1.0||
|272|E|E272|Počet odpracovaných hodin zaměstnanci v evidenčním počtu||
|272|F|F272|Souhrnná vrstva||
|272|G|G272|Odpracované hodiny||
|272|L|L272|změna třídy atributu||
|272|M|M272|úprava názvu třídy na Souhrnná vrstva||
|273|A|A273|3.6.2024||
|273|B|B273|1.0||
|273|E|E273|Počet odpracovaných hodin osobami pracujícími na DPP||
|273|F|F273|Souhrnná vrstva||
|273|G|G273|Odpracované hodiny||
|273|L|L273|změna třídy atributu||
|273|M|M273|úprava názvu třídy na Souhrnná vrstva||
|274|A|A274|3.6.2024||
|274|B|B274|1.0||
|274|E|E274|Počet odpracovaných hodin osobami pracujícími na DPČ||
|274|F|F274|Souhrnná vrstva||
|274|G|G274|Odpracované hodiny||
|274|L|L274|změna třídy atributu||
|274|M|M274|úprava názvu třídy na Souhrnná vrstva||
|275|A|A275|3.6.2024||
|275|B|B275|1.0||
|275|E|E275|Vyplacená hrubá mzda (včetně příplatků a náhrad mzdy, bez náhrad za nemocenskou placených zaměstnavatelem) – bez OON ||
|275|F|F275|Souhrnná vrstva||
|275|G|G275|Mzda||
|275|L|L275|změna třídy atributu||
|275|M|M275|úprava názvu třídy na Souhrnná vrstva||
|276|A|A276|3.6.2024||
|276|B|B276|1.0||
|276|E|E276|Vyplacené odměny celkem||
|276|F|F276|Souhrnná vrstva||
|276|G|G276|Mzda||
|276|L|L276|změna třídy atributu||
|276|M|M276|úprava názvu třídy na Souhrnná vrstva||
|277|A|A277|3.6.2024||
|277|B|B277|1.0||
|277|E|E277|Vyplacené odměny z DPP||
|277|F|F277|Souhrnná vrstva||
|277|G|G277|Mzda||
|277|L|L277|změna třídy atributu||
|277|M|M277|úprava názvu třídy na Souhrnná vrstva||
|278|A|A278|3.6.2024||
|278|B|B278|1.0||
|278|E|E278|Vyplacené odměny z DPČ||
|278|F|F278|Souhrnná vrstva||
|278|G|G278|Mzda||
|278|L|L278|změna třídy atributu||
|278|M|M278|úprava názvu třídy na Souhrnná vrstva||
|279|A|A279|5.6.2024||
|279|B|B279|1.0||
|279|E|E279|Typ podání||
|279|F|F279|Meta atributy||
|279|L|L279|odstranění atributu||
|279|M|M279|včetně odstranění číselníku||
|280|A|A280|5.6.2024||
|280|B|B280|1.0||
|280|E|E280|Název právního nástupce||
|280|F|F280|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|280|G|G280|Právní nástupnictví při zániku||
|280|L|L280|změna třídy atributu||
|280|M|M280|rozlišení právního nástupnictví při vzniku a při zániku||
|281|A|A281|5.6.2024||
|281|B|B281|1.0||
|281|E|E281|Variabilní symbol||
|281|F|F281|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|281|G|G281|Právní nástupnictví při zániku||
|281|L|L281|změna třídy atributu||
|281|M|M281|rozlišení právního nástupnictví při vzniku a při zániku||
|282|A|A282|5.6.2024||
|282|B|B282|1.0||
|282|E|E282|Identifikační číslo (IČO, IČ)||
|282|F|F282|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|282|G|G282|Právní nástupnictví při zániku||
|282|L|L282|změna třídy atributu||
|282|M|M282|rozlišení právního nástupnictví při vzniku a při zániku||
|283|A|A283|5.6.2024||
|283|B|B283|1.0||
|283|E|E283|Individuální číslo||
|283|F|F283|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|283|G|G283|Právní nástupnictví při zániku||
|283|L|L283|změna třídy atributu||
|283|M|M283|rozlišení právního nástupnictví při vzniku a při zániku||
|284|A|A284|5.6.2024||
|284|B|B284|1.0||
|284|E|E284|Rodné číslo||
|284|F|F284|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|284|G|G284|Právní nástupnictví při zániku||
|284|L|L284|změna třídy atributu||
|284|M|M284|rozlišení právního nástupnictví při vzniku a při zániku||
|285|A|A285|5.6.2024||
|285|B|B285|1.0||
|285|E|E285|EČP||
|285|F|F285|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|285|G|G285|Právní nástupnictví při zániku||
|285|L|L285|změna třídy atributu||
|285|M|M285|rozlišení právního nástupnictví při vzniku a při zániku||
|286|A|A286|5.6.2024||
|286|B|B286|1.0||
|286|E|E286|Kód adresního místa||
|286|F|F286|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|286|G|G286|Právní nástupnictví při zániku||
|286|H|H286|Adresa||
|286|L|L286|změna třídy atributu||
|286|M|M286|rozlišení právního nástupnictví při vzniku a při zániku||
|287|A|A287|5.6.2024||
|287|B|B287|1.0||
|287|E|E287|Ulice ||
|287|F|F287|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|287|G|G287|Právní nástupnictví při zániku||
|287|H|H287|Adresa||
|287|L|L287|změna třídy atributu||
|287|M|M287|rozlišení právního nástupnictví při vzniku a při zániku||
|288|A|A288|5.6.2024||
|288|B|B288|1.0||
|288|E|E288|Číslo popisné ||
|288|F|F288|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|288|G|G288|Právní nástupnictví při zániku||
|288|H|H288|Adresa||
|288|L|L288|změna třídy atributu||
|288|M|M288|rozlišení právního nástupnictví při vzniku a při zániku||
|289|A|A289|5.6.2024||
|289|B|B289|1.0||
|289|E|E289|Číslo orientační||
|289|F|F289|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|289|G|G289|Právní nástupnictví při zániku||
|289|H|H289|Adresa||
|289|L|L289|změna třídy atributu||
|289|M|M289|rozlišení právního nástupnictví při vzniku a při zániku||
|290|A|A290|5.6.2024||
|290|B|B290|1.0||
|290|E|E290|Obec||
|290|F|F290|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|290|G|G290|Právní nástupnictví při zániku||
|290|H|H290|Adresa||
|290|L|L290|změna třídy atributu||
|290|M|M290|rozlišení právního nástupnictví při vzniku a při zániku||
|291|A|A291|5.6.2024||
|291|B|B291|1.0||
|291|E|E291|Kód obce||
|291|F|F291|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|291|G|G291|Právní nástupnictví při zániku||
|291|H|H291|Adresa||
|291|L|L291|změna třídy atributu||
|291|M|M291|rozlišení právního nástupnictví při vzniku a při zániku||
|292|A|A292|5.6.2024||
|292|B|B292|1.0||
|292|E|E292|PSČ||
|292|F|F292|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|292|G|G292|Právní nástupnictví při zániku||
|292|H|H292|Adresa||
|292|L|L292|změna třídy atributu||
|292|M|M292|rozlišení právního nástupnictví při vzniku a při zániku||
|293|A|A293|5.6.2024||
|293|B|B293|1.0||
|293|E|E293|Stát||
|293|F|F293|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|293|G|G293|Právní nástupnictví při zániku||
|293|H|H293|Adresa||
|293|L|L293|změna třídy atributu||
|293|M|M293|rozlišení právního nástupnictví při vzniku a při zániku||
|294|A|A294|5.6.2024||
|294|B|B294|1.0||
|294|E|E294|Název mzdové účtárny||
|294|F|F294|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|294|G|G294|Právní nástupnictví při zániku||
|294|H|H294|Mzdová účtárna||
|294|L|L294|změna třídy atributu||
|294|M|M294|rozlišení právního nástupnictví při vzniku a při zániku||
|295|A|A295|5.6.2024||
|295|B|B295|1.0||
|295|E|E295|Kód adresního místa||
|295|F|F295|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|295|G|G295|Právní nástupnictví při zániku||
|295|H|H295|Mzdová účtárna||
|295|L|L295|změna třídy atributu||
|295|M|M295|rozlišení právního nástupnictví při vzniku a při zániku||
|296|A|A296|5.6.2024||
|296|B|B296|1.0||
|296|E|E296|Ulice ||
|296|F|F296|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|296|G|G296|Právní nástupnictví při zániku||
|296|H|H296|Mzdová účtárna||
|296|L|L296|změna třídy atributu||
|296|M|M296|rozlišení právního nástupnictví při vzniku a při zániku||
|297|A|A297|5.6.2024||
|297|B|B297|1.0||
|297|E|E297|Číslo popisné ||
|297|F|F297|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|297|G|G297|Právní nástupnictví při zániku||
|297|H|H297|Mzdová účtárna||
|297|L|L297|změna třídy atributu||
|297|M|M297|rozlišení právního nástupnictví při vzniku a při zániku||
|298|A|A298|5.6.2024||
|298|B|B298|1.0||
|298|E|E298|Číslo orientační||
|298|F|F298|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|298|G|G298|Právní nástupnictví při zániku||
|298|H|H298|Mzdová účtárna||
|298|L|L298|změna třídy atributu||
|298|M|M298|rozlišení právního nástupnictví při vzniku a při zániku||
|299|A|A299|5.6.2024||
|299|B|B299|1.0||
|299|E|E299|Obec||
|299|F|F299|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|299|G|G299|Právní nástupnictví při zániku||
|299|H|H299|Mzdová účtárna||
|299|L|L299|změna třídy atributu||
|299|M|M299|rozlišení právního nástupnictví při vzniku a při zániku||
|300|A|A300|5.6.2024||
|300|B|B300|1.0||
|300|E|E300|Kód obce||
|300|F|F300|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|300|G|G300|Právní nástupnictví při zániku||
|300|H|H300|Mzdová účtárna||
|300|L|L300|změna třídy atributu||
|300|M|M300|rozlišení právního nástupnictví při vzniku a při zániku||
|301|A|A301|5.6.2024||
|301|B|B301|1.0||
|301|E|E301|PSČ||
|301|F|F301|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|301|G|G301|Právní nástupnictví při zániku||
|301|H|H301|Mzdová účtárna||
|301|L|L301|změna třídy atributu||
|301|M|M301|rozlišení právního nástupnictví při vzniku a při zániku||
|302|A|A302|5.6.2024||
|302|B|B302|1.0||
|302|E|E302|Stát||
|302|F|F302|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|302|G|G302|Právní nástupnictví při zániku||
|302|H|H302|Mzdová účtárna||
|302|L|L302|změna třídy atributu||
|302|M|M302|rozlišení právního nástupnictví při vzniku a při zániku||
|303|A|A303|5.6.2024||
|303|B|B303|1.0||
|303|E|E303|Kód ELDP||
|303|F|F303|Vykonávaná pozice zaměstnance||
|303|G|G303|Činnost||
|303|H|H303|ELDP||
|303|L|L303|přejmenování atributu||
|303|M|M303|vytvoření podtřídy ELDP||
|304|A|A304|5.6.2024||
|304|B|B304|1.0||
|304|E|E304|Kód ELDP||
|304|F|F304|Vykonávaná pozice zaměstnance||
|304|G|G304|Činnost||
|304|H|H304|ELDP||
|304|L|L304|změna třídy atributu||
|304|M|M304|vytvoření podtřídy ELDP||
|305|A|A305|5.6.2024||
|305|B|B305|1.0||
|305|E|E305|Platnost kódu od||
|305|F|F305|Vykonávaná pozice zaměstnance||
|305|G|G305|Činnost||
|305|H|H305|ELDP||
|305|L|L305|přidání atributu||
|305|M|M305|přidání atributu po dohodě na schůzce s ČSSZ||
|306|A|A306|5.6.2024||
|306|B|B306|1.0||
|306|E|E306|Platnost kódu do||
|306|F|F306|Vykonávaná pozice zaměstnance||
|306|G|G306|Činnost||
|306|H|H306|ELDP||
|306|L|L306|přidání atributu||
|306|M|M306|přidání atributu po dohodě na schůzce s ČSSZ||
|307|A|A307|5.6.2024||
|307|B|B307|1.0||
|307|E|E307|Zaměstnání malého rozsahu||
|307|F|F307|Vykonávaná pozice zaměstnance||
|307|G|G307|Činnost||
|307|H|H307|ELDP||
|307|L|L307|přidání atributu||
|307|M|M307|přidání atributu po dohodě na schůzce s ČSSZ||
|308|A|A308|5.6.2024||
|308|B|B308|1.0||
|308|E|E308|Vyloučené doby||
|308|F|F308|Vykonávaná pozice zaměstnance||
|308|G|G308|Činnost||
|308|H|H308|ELDP||
|308|L|L308|přidání atributu||
|308|M|M308|přidání atributu po dohodě na schůzce s ČSSZ||
|309|A|A309|5.6.2024||
|309|B|B309|1.0||
|309|E|E309|Vyměřovací základ||
|309|F|F309|Vykonávaná pozice zaměstnance||
|309|G|G309|Činnost||
|309|H|H309|ELDP||
|309|L|L309|přidání atributu||
|309|M|M309|přidání atributu po dohodě na schůzce s ČSSZ||
|310|A|A310|5.6.2024||
|310|B|B310|1.0||
|310|E|E310|Doby odečtené||
|310|F|F310|Vykonávaná pozice zaměstnance||
|310|G|G310|Činnost||
|310|H|H310|ELDP||
|310|L|L310|přidání atributu||
|310|M|M310|přidání atributu po dohodě na schůzce s ČSSZ||
|311|A|A311|11.6.2024||
|311|B|B311|1.0||
|311|E|E311|Student mladší 26 let||
|311|F|F311|Zaměstnanec / Žák / Student ||
|311|G|G311|Deklarované skutečnosti ze strany zaměstnance||
|311|H|H311|Studium||
|311|L|L311|přejmenování atributu||
|312|A|A312|11.6.2024||
|312|B|B312|1.0||
|312|E|E312|Proti zaměstnanci je vedena exekuce nebo výkon rozhodnutí ||
|312|F|F312|Zaměstnanec / Žák / Student ||
|312|G|G312|Deklarované skutečnosti ze strany zaměstnance||
|312|H|H312|Příznaky||
|312|L|L312|odstranění atributu||
|313|A|A313|11.6.2024||
|313|B|B313|1.0||
|313|E|E313|Zaměstnanci byl udělen azyl / doplňková ochrana||
|313|F|F313|Zaměstnanec / Žák / Student ||
|313|G|G313|Deklarované skutečnosti ze strany zaměstnance||
|313|H|H313|Příznaky||
|313|L|L313|odstranění atributu||
|314|A|A314|11.6.2024||
|314|B|B314|1.0||
|314|E|E314|Zaměstnanci je poskytována služba sociální prevence (§53 a 70 zákona o sociálních službách)||
|314|F|F314|Zaměstnanec / Žák / Student ||
|314|G|G314|Deklarované skutečnosti ze strany zaměstnance||
|314|H|H314|Příznaky||
|314|L|L314|odstranění atributu||
|315|A|A315|11.6.2024||
|315|B|B315|1.0||
|315|E|E315|Zaměstnanec je bez přístřeší ||
|315|F|F315|Zaměstnanec / Žák / Student ||
|315|G|G315|Deklarované skutečnosti ze strany zaměstnance||
|315|H|H315|Příznaky||
|315|L|L315|odstranění atributu||
|316|A|A316|11.6.2024||
|316|B|B316|1.0||
|316|E|E316|Zaměstnanec je po výkonu trestu odnětí svobody nebo ochranného opatření zabezpečovací detence||
|316|F|F316|Zaměstnanec / Žák / Student ||
|316|G|G316|Deklarované skutečnosti ze strany zaměstnance||
|316|H|H316|Příznaky||
|316|L|L316|odstranění atributu||
|317|A|A317|11.6.2024||
|317|B|B317|1.0||
|317|E|E317|Srážky na základě nařízeného soudního nebo správního výkonu rozhodnutí, konkursu nebo dohody o srážkách z příjmu||
|317|F|F317|Zaměstnanec / Žák / Student ||
|317|G|G317|Srážky z příjmu||
|317|L|L317|přidání atributu||
|317|M|M317|respektive přesunutí atributu z původní exekuce v deklarovaných skutečnostech||
|318|A|A318|11.6.2024||
|318|B|B318|1.0||
|318|E|E318|Integrační sociální podnik||
|318|F|F318|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|318|G|G318|Sociální podnik||
|318|L|L318|přidání atributu||
|319|A|A319|11.6.2024||
|319|B|B319|1.0||
|319|E|E319|Typ||
|319|F|F319|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|319|G|G319|Kolektivní smlouva k 31.12.||
|319|L|L319|změna třídy atributu||
|320|A|A320|11.6.2024||
|320|B|B320|1.0||
|320|E|E320|Název||
|320|F|F320|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|320|G|G320|Kolektivní smlouva k 31.12.||
|320|H|H320|Odborový svaz||
|320|L|L320|přejmenování atributu||
|321|A|A321|11.6.2024||
|321|B|B321|1.0||
|321|E|E321|Název||
|321|F|F321|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|321|G|G321|Kolektivní smlouva k 31.12.||
|321|H|H321|Odborový svaz||
|321|L|L321|změna třídy atributu||
|322|A|A322|11.6.2024||
|322|B|B322|1.0||
|322|E|E322|Název||
|322|F|F322|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|322|G|G322|Kolektivní smlouva k 31.12.||
|322|H|H322|Zaměstnavatelský svaz||
|322|L|L322|přejmenování atributu||
|323|A|A323|11.6.2024||
|323|B|B323|1.0||
|323|E|E323|Název||
|323|F|F323|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|323|G|G323|Kolektivní smlouva k 31.12.||
|323|H|H323|Zaměstnavatelský svaz||
|323|L|L323|změna třídy atributu||
|324|A|A324|11.6.2024||
|324|B|B324|1.0||
|324|E|E324|Identifikační číslo||
|324|F|F324|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|324|G|G324|Kolektivní smlouva k 31.12.||
|324|H|H324|Odborový svaz||
|324|L|L324|přidání atributu||
|325|A|A325|11.6.2024||
|325|B|B325|1.0||
|325|E|E325|Identifikační číslo||
|325|F|F325|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|325|G|G325|Kolektivní smlouva k 31.12.||
|325|H|H325|Zaměstnavatelský svaz||
|325|L|L325|přidání atributu||
|326|A|A326|11.6.2024||
|326|B|B326|1.0||
|326|E|E326|Počet odborových organizací u zaměstnavatele ||
|326|F|F326|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|326|G|G326|Odborová organizace k 31.12.||
|326|L|L326|změna třídy atributu||
|327|A|A327|11.6.2024||
|327|B|B327|1.0||
|327|E|E327|Zahraniční kapitál - země původu||
|327|F|F327|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|327|G|G327|Kapitál||
|327|L|L327|změna třídy atributu||
|328|A|A328|11.6.2024||
|328|B|B328|1.0||
|328|E|E328|Forma||
|328|F|F328|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|328|G|G328|Hospodářská a finanční kontrola||
|328|L|L328|změna třídy atributu||
|329|A|A329|12.6.2024||
|329|B|B329|1.0||
|329|E|E329|Mzdový příspěvek v rámci nástrojů APZ||
|329|F|F329|Mzdový příspěvek v rámci nástrojů APZ||
|329|G|G329|Pracovní místo / pozice||
|329|H|H329|APZ||
|329|L|L329|přidání atributu||
|330|A|A330|12.6.2024||
|330|B|B330|1.0||
|330|E|E330|Nástroj (opatření)||
|330|F|F330|Vykonávaná pozice zaměstnance||
|330|G|G330|Pracovní místo / pozice||
|330|H|H330|APZ||
|330|L|L330|přejmenování atributu||
|331|A|A331|12.6.2024||
|331|B|B331|1.0||
|331|E|E331|Číslo dohody s ÚP ČR||
|331|F|F331|Vykonávaná pozice zaměstnance||
|331|G|G331|Pracovní místo / pozice||
|331|H|H331|APZ||
|331|L|L331|přejmenování atributu||
|332|A|A332|13.6.2024||
|332|B|B332|1.0||
|332|E|E332|Vznik příslušnosti k českým právním předpisům||
|332|F|F332|Vykonávaná pozice zaměstnance||
|332|G|G332|Příslušnost k předpisům||
|332|L|L332|odstranění atributu||
|332|M|M332|na základě duplicity se stojnejmennou akcí a atributem Platnost akce ke dni||
|333|A|A333|13.6.2024||
|333|B|B333|1.0||
|333|E|E333|Skončení příslušnosti k českým právním předpisům||
|333|F|F333|Vykonávaná pozice zaměstnance||
|333|G|G333|Příslušnost k předpisům||
|333|L|L333|odstranění atributu||
|333|M|M333|na základě duplicity se stojnejmennou akcí a atributem Platnost akce ke dni||
|334|A|A334|13.6.2024||
|334|B|B334|1.0||
|334|E|E334|Zaměstnání malého rozsahu||
|334|F|F334|Průběh zaměstnání v daném měsíci||
|334|G|G334|Rozsah zaměstnání||
|334|L|L334|odstranění atributu||
|334|M|M334|na základě duplicity se stejnojmenným atributem v rámci ELDP třídy||
|335|A|A335|17.6.2024||
|335|B|B335|1.0||
|335|E|E335|Zdrav. záchranář a člen HZS podniku od||
|335|F|F335|Vykonávaná pozice zaměstnance||
|335|G|G335|Profese||
|335|L|L335|odstranění atributu||
|335|M|M335|po dohodě je dostačující počet odpracovaných hodin ve folderu 5||
|336|A|A336|17.6.2024||
|336|B|B336|1.0||
|336|E|E336|Zdrav. záchranář a člen HZS podniku do||
|336|F|F336|Vykonávaná pozice zaměstnance||
|336|G|G336|Profese||
|336|L|L336|odstranění atributu||
|336|M|M336|po dohodě je dostačující počet odpracovaných hodin ve folderu 5||
|337|A|A337|18.6.2024||
|337|B|B337|1.0||
|337|E|E337|Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - uran||
|337|F|F337|Průběh zaměstnání v daném měsíci||
|337|G|G337|Odpracované směny||
|337|H|H337|Hlubinné hornictví||
|337|L|L337|změna třídy atributu||
|338|A|A338|18.6.2024||
|338|B|B338|1.0||
|338|E|E338|Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - ostatní||
|338|F|F338|Průběh zaměstnání v daném měsíci||
|338|G|G338|Odpracované směny||
|338|H|H338|Hlubinné hornictví||
|338|L|L338|změna třídy atributu||
|339|A|A339|18.6.2024||
|339|B|B339|1.0||
|339|E|E339|Datum dosažení expozice NPE||
|339|F|F339|Průběh zaměstnání v daném měsíci||
|339|G|G339|Odpracované směny||
|339|H|H339|Hlubinné hornictví||
|339|L|L339|změna třídy atributu||
|340|A|A340|18.6.2024||
|340|B|B340|1.0||
|340|E|E340|Počet odpracovaných hodin v rámci rizikové práce (§ 37d odst. 2 ZDP), práce zdravotnického záchranáře (§ 37d odst. 3) a práce člena jednotky HZS podniku (§ 37d odst. 3)  ||
|340|F|F340|Průběh zaměstnání v daném měsíci||
|340|G|G340|Odpracované hodiny||
|340|H|H340|Riziková práce||
|340|L|L340|změna třídy atributu||
|341|A|A341|18.6.2024||
|341|B|B341|1.0||
|341|E|E341|Kategorizace rizika||
|341|F|F341|Průběh zaměstnání v daném měsíci||
|341|G|G341|Odpracované hodiny||
|341|H|H341|Riziková práce||
|341|L|L341|změna třídy atributu||
|342|A|A342|19.6.2024||
|342|B|B342|1.0||
|342|E|E342|Typ identifikátoru zaměstnance||
|342|F|F342|Přehled o výši pojistného||
|342|G|G342|Přehled zaměstnanců s uplatněnou slevou na pojistném||
|342|L|L342|přidání atributu||
|342|M|M342|na základě nutnosti vytvoření seznamu zaměstnanců s uplatněnou slevou na pojistném||
|343|A|A343|19.6.2024||
|343|B|B343|1.0||
|343|E|E343|Identifikátor zaměstnance||
|343|F|F343|Přehled o výši pojistného||
|343|G|G343|Přehled zaměstnanců s uplatněnou slevou na pojistném||
|343|L|L343|přidání atributu||
|343|M|M343|na základě nutnosti vytvoření seznamu zaměstnanců s uplatněnou slevou na pojistném||
|344|A|A344|19.6.2024||
|344|B|B344|1.0||
|344|E|E344|Úhrn vyměřovacích základů zaměstnanců, kteří nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|344|F|F344|Přehled o výši pojistného||
|344|G|G344|Souhrn||
|344|H|H344|Odváděné pojistné||
|344|L|L344|změna oblasti atributu||
|344|M|M344|vytvoření nového folderu pro data PVPOJ||
|345|A|A345|19.6.2024||
|345|B|B345|1.0||
|345|E|E345|Pojistné za zaměstnavatele u zaměstnanců, kteří nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|345|F|F345|Přehled o výši pojistného||
|345|G|G345|Souhrn||
|345|H|H345|Odváděné pojistné||
|345|L|L345|změna oblasti atributu||
|345|M|M345|vytvoření nového folderu pro data PVPOJ||
|346|A|A346|19.6.2024||
|346|B|B346|1.0||
|346|E|E346|Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku||
|346|F|F346|Přehled o výši pojistného||
|346|G|G346|Souhrn||
|346|H|H346|Odváděné pojistné||
|346|L|L346|změna oblasti atributu||
|346|M|M346|vytvoření nového folderu pro data PVPOJ||
|347|A|A347|19.6.2024||
|347|B|B347|1.0||
|347|E|E347|Pojistné za zaměstnavatele u zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku||
|347|F|F347|Přehled o výši pojistného||
|347|G|G347|Souhrn||
|347|H|H347|Odváděné pojistné||
|347|L|L347|změna oblasti atributu||
|347|M|M347|vytvoření nového folderu pro data PVPOJ||
|348|A|A348|19.6.2024||
|348|B|B348|1.0||
|348|E|E348|Pojistné za zaměstnavatele celkem (součet úhrnů)||
|348|F|F348|Přehled o výši pojistného||
|348|G|G348|Souhrn||
|348|H|H348|Odváděné pojistné||
|348|L|L348|změna oblasti atributu||
|348|M|M348|vytvoření nového folderu pro data PVPOJ||
|349|A|A349|19.6.2024||
|349|B|B349|1.0||
|349|E|E349|Pojistné za zaměstnance||
|349|F|F349|Přehled o výši pojistného||
|349|G|G349|Souhrn||
|349|H|H349|Odváděné pojistné||
|349|L|L349|změna oblasti atributu||
|349|M|M349|vytvoření nového folderu pro data PVPOJ||
|350|A|A350|19.6.2024||
|350|B|B350|1.0||
|350|E|E350|Pojistné celkem||
|350|F|F350|Přehled o výši pojistného||
|350|G|G350|Souhrn||
|350|H|H350|Odváděné pojistné||
|350|L|L350|změna oblasti atributu||
|350|M|M350|vytvoření nového folderu pro data PVPOJ||
|351|A|A351|19.6.2024||
|351|B|B351|1.0||
|351|E|E351|Počet zaměstnanců||
|351|F|F351|Přehled o výši pojistného||
|351|G|G351|Souhrn||
|351|H|H351|Slevy na pojistném||
|351|L|L351|změna oblasti atributu||
|351|M|M351|vytvoření nového folderu pro data PVPOJ||
|352|A|A352|19.6.2024||
|352|B|B352|1.0||
|352|E|E352|Úhrn vyměřovacích základů zaměstnanců||
|352|F|F352|Přehled o výši pojistného||
|352|G|G352|Souhrn||
|352|H|H352|Slevy na pojistném||
|352|L|L352|změna oblasti atributu||
|352|M|M352|vytvoření nového folderu pro data PVPOJ||
|353|A|A353|19.6.2024||
|353|B|B353|1.0||
|353|E|E353|Sleva na pojistném||
|353|F|F353|Přehled o výši pojistného||
|353|G|G353|Souhrn||
|353|H|H353|Slevy na pojistném||
|353|L|L353|změna oblasti atributu||
|353|M|M353|vytvoření nového folderu pro data PVPOJ||
|354|A|A354|19.6.2024||
|354|B|B354|1.0||
|354|E|E354|Vypočítané pojistné (rozdíl mezi pojistným celkem a slevou na pojistném)||
|354|F|F354|Přehled o výši pojistného||
|354|G|G354|Souhrn||
|354|H|H354|Pojistné k úhradě||
|354|L|L354|změna oblasti atributu||
|354|M|M354|vytvoření nového folderu pro data PVPOJ||
|355|A|A355|20.6.2024||
|355|B|B355|1.0||
|355|E|E355|Forma||
|355|F|F355|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|355|G|G355|Hospodářská a finanční kontrola k 31.12.||
|355|L|L355|změna třídy atributu||
|356|A|A356|24.6.2024||
|356|B|B356|1.0||
|356|E|E356|Datum úhrady mzdy včetně odvodů na soc. a zdravotní pojištění||
|356|F|F356|Příjem v daném měsíci||
|356|G|G356|Výdělek||
|356|L|L356|změna třídy atributu||
|357|A|A357|25.6.2024||
|357|B|B357|1.0||
|357|E|E357|Typ podání||
|357|F|F357|Meta atributy||
|357|L|L357|přidání atributu||
|357|M|M357|návrat atributu pro rozlišení typu měsíčního podání||
|358|A|A358|25.6.2024||
|358|B|B358|1.0||
|358|E|E358|Typ akce||
|358|F|F358|Meta atributy||
|358|L|L358|přejmenování atributu||
|358|M|M358|přejmenování z původního Subtyp podání - sladění s ONZ + změna názvu číselníku||
|359|A|A359|25.6.2024||
|359|B|B359|1.0||
|359|E|E359|Typ formuláře||
|359|F|F359|Zaměstnanec / Žák / Student ||
|359|G|G359|Meta atributy||
|359|L|L359|přejmenování atributu||
|359|M|M359|přejmenování z původního Operace + změna z číselníku na výčet hodnot||
|360|A|A360|25.6.2024||
|360|B|B360|1.0||
|360|E|E360|IK MPSV||
|360|F|F360|Zaměstnanec / Žák / Student ||
|360|G|G360|Základní ídentifikace||
|360|L|L360|změna třídy atributu||
|361|A|A361|25.6.2024||
|361|B|B361|1.0||
|361|E|E361|Student mladší 26 let||
|361|F|F361|Zaměstnanec / Žák / Student ||
|361|G|G361|Deklarované skutečnosti ze strany zaměstnance||
|361|H|H361|Studium||
|361|L|L361|odstranění atributu||
|361|M|M361|atribut není nutné deklarovat, vyplnění se v rámci důvodu slevy na pojistné||
|362|A|A362|25.6.2024||
|362|B|B362|1.0||
|362|E|E362|Pečující o dítě do 4 let věku||
|362|F|F362|Zaměstnanec / Žák / Student ||
|362|G|G362|Deklarované skutečnosti ze strany zaměstnance||
|362|H|H362|Péče||
|362|L|L362|přejmenování atributu||
|362|M|M362|na základě odstranění možností výčtu||
|363|A|A363|25.6.2024||
|363|B|B363|1.0||
|363|E|E363|Pečující o dítě do 4 let věku||
|363|F|F363|Zaměstnanec / Žák / Student ||
|363|G|G363|Deklarované skutečnosti ze strany zaměstnance||
|363|H|H363|Péče||
|363|L|L363|změna datového typu||
|363|M|M363|výčet -> příznak (odstranění možností výčtu)||
|364|A|A364|25.6.2024||
|364|B|B364|1.0||
|364|E|E364|Pečující o osobu blízkou do 10 let věku , která je závislá na pomoci jiné osoby ve stupni I||
|364|F|F364|Zaměstnanec / Žák / Student ||
|364|G|G364|Deklarované skutečnosti ze strany zaměstnance||
|364|H|H364|Péče||
|364|L|L364|odstranění atributu||
|364|M|M364|atribut není nutné deklarovat, vyplnění se v rámci důvodu slevy na pojistné||
|365|A|A365|25.6.2024||
|365|B|B365|1.0||
|365|E|E365|Pečující o osobu blízkou, která je závislá na pomoci jiné osoby ve stupni II až IV||
|365|F|F365|Zaměstnanec / Žák / Student ||
|365|G|G365|Deklarované skutečnosti ze strany zaměstnance||
|365|H|H365|Péče||
|365|L|L365|odstranění atributu||
|365|M|M365|atribut není nutné deklarovat, vyplnění se v rámci důvodu slevy na pojistné||
|366|A|A366|25.6.2024||
|366|B|B366|1.0||
|366|E|E366|V období 12 kalendářních měsíců před kalendářním měsícem, za který se sleva na pojistném uplatňuje, nastoupil jako uchazeč o zaměstnání na rekvalifikaci||
|366|F|F366|Zaměstnanec / Žák / Student ||
|366|G|G366|Deklarované skutečnosti ze strany zaměstnance||
|366|H|H366|Příznaky||
|366|L|L366|odstranění atributu||
|366|M|M366|atribut není nutné deklarovat, vyplnění se v rámci důvodu slevy na pojistné||
|367|A|A367|25.6.2024||
|367|B|B367|1.0||
|367|E|E367|Číslo dohody s ÚP ČR||
|367|F|F367|Vykonávaná pozice zaměstnance||
|367|G|G367|Pracovní místo / pozice||
|367|H|H367|APZ||
|367|L|L367|odstranění atributu||
|368|A|A368|25.6.2024||
|368|B|B368|1.0||
|368|E|E368|Číslo projektu||
|368|F|F368|Vykonávaná pozice zaměstnance||
|368|G|G368|Pracovní místo / pozice||
|368|H|H368|APZ||
|368|L|L368|odstranění atributu||
|369|A|A369|26.6.2024||
|369|B|B369|1.0||
|369|E|E369|BSI||
|369|F|F369|Zaměstnanec / Žák / Student ||
|369|G|G369|Základní ídentifikace||
|369|L|L369|přidání atributu||
|369|M|M369|atribut pro účely jednoznačného ztotožnění fyzické osoby||
|370|A|A370|27.6.2024||
|370|B|B370|1.0||
|370|E|E370|Vyplacená hrubá mzda (včetně příplatků a náhrad mzdy, bez náhrad za nemocenskou placených zaměstnavatelem) – bez OON ||
|370|F|F370|Souhrnná vrstva||
|370|G|G370|Výdělek||
|370|L|L370|změna třídy atributu||
|370|M|M370|na základě interní konzultace||
|371|A|A371|27.6.2024||
|371|B|B371|1.0||
|371|E|E371|Vyplacené odměny celkem||
|371|F|F371|Souhrnná vrstva||
|371|G|G371|Výdělek||
|371|L|L371|změna třídy atributu||
|371|M|M371|na základě interní konzultace||
|372|A|A372|27.6.2024||
|372|B|B372|1.0||
|372|E|E372|Vyplacené odměny z DPP||
|372|F|F372|Souhrnná vrstva||
|372|G|G372|Výdělek||
|372|L|L372|změna třídy atributu||
|372|M|M372|na základě interní konzultace||
|373|A|A373|27.6.2024||
|373|B|B373|1.0||
|373|E|E373|Vyplacené odměny z DPČ||
|373|F|F373|Souhrnná vrstva||
|373|G|G373|Výdělek||
|373|L|L373|změna třídy atributu||
|373|M|M373|na základě interní konzultace||
|374|A|A374|27.6.2024||
|374|B|B374|1.0||
|374|E|E374|GUID podání||
|374|F|F374|Meta atributy||
|374|G|G374|Podání||
|374|L|L374|přidání atributu||
|374|M|M374|v rámci hromadného přidání technických atributů||
|375|A|A375|27.6.2024||
|375|B|B375|1.0||
|375|E|E375|Pořadí balíku dat||
|375|F|F375|Meta atributy||
|375|G|G375|Podání||
|375|L|L375|přidání atributu||
|375|M|M375|v rámci hromadného přidání technických atributů||
|376|A|A376|27.6.2024||
|376|B|B376|1.0||
|376|E|E376|Počet balíků dat||
|376|F|F376|Meta atributy||
|376|G|G376|Podání||
|376|L|L376|přidání atributu||
|376|M|M376|v rámci hromadného přidání technických atributů||
|377|A|A377|27.6.2024||
|377|B|B377|1.0||
|377|E|E377|Typ formuláře||
|377|F|F377|Meta atributy||
|377|G|G377|Formulář||
|377|L|L377|změna třídy atributu||
|377|M|M377|v rámci hromadného přidání technických atributů||
|378|A|A378|27.6.2024||
|378|B|B378|1.0||
|378|E|E378|Místně příslušná OSSZ/PSSZ/MSSZ Brno||
|378|F|F378|Meta atributy||
|378|G|G378|Podání||
|378|L|L378|změna třídy atributu||
|378|M|M378|v rámci hromadného přidání technických atributů||
|379|A|A379|27.6.2024||
|379|B|B379|1.0||
|379|E|E379|Datum a čas vyplnění podání||
|379|F|F379|Meta atributy||
|379|G|G379|Podání||
|379|L|L379|změna třídy atributu||
|379|M|M379|v rámci hromadného přidání technických atributů||
|380|A|A380|27.6.2024||
|380|B|B380|1.0||
|380|E|E380|Datum a čas přijetí podání||
|380|F|F380|Meta atributy||
|380|G|G380|Podání||
|380|L|L380|změna třídy atributu||
|380|M|M380|v rámci hromadného přidání technických atributů||
|381|A|A381|27.6.2024||
|381|B|B381|1.0||
|381|E|E381|Typ podání||
|381|F|F381|Meta atributy||
|381|G|G381|Podání||
|381|L|L381|změna třídy atributu||
|381|M|M381|v rámci hromadného přidání technických atributů||
|382|A|A382|27.6.2024||
|382|B|B382|1.0||
|382|E|E382|Typ akce||
|382|F|F382|Meta atributy||
|382|G|G382|Podání||
|382|L|L382|změna třídy atributu||
|382|M|M382|v rámci hromadného přidání technických atributů||
|383|A|A383|27.6.2024||
|383|B|B383|1.0||
|383|E|E383|Platnost akce ke dni||
|383|F|F383|Meta atributy||
|383|G|G383|Podání||
|383|L|L383|změna třídy atributu||
|383|M|M383|v rámci hromadného přidání technických atributů||
|384|A|A384|27.6.2024||
|384|B|B384|1.0||
|384|E|E384|Měsíc||
|384|F|F384|Meta atributy||
|384|G|G384|Podání||
|384|L|L384|změna třídy atributu||
|384|M|M384|v rámci hromadného přidání technických atributů||
|385|A|A385|27.6.2024||
|385|B|B385|1.0||
|385|E|E385|Rok||
|385|F|F385|Meta atributy||
|385|G|G385|Podání||
|385|L|L385|změna třídy atributu||
|385|M|M385|v rámci hromadného přidání technických atributů||
|386|A|A386|27.6.2024||
|386|B|B386|1.0||
|386|E|E386|GUID formuláře||
|386|F|F386|Meta atributy||
|386|G|G386|Formulář||
|386|L|L386|přidání atributu||
|386|M|M386|v rámci hromadného přidání technických atributů||
|387|A|A387|27.6.2024||
|387|B|B387|1.0||
|387|E|E387|Pořadí balíku dat||
|387|F|F387|Meta atributy||
|387|G|G387|Formulář||
|387|L|L387|přidání atributu||
|387|M|M387|v rámci hromadného přidání technických atributů||
|388|A|A388|27.6.2024||
|388|B|B388|1.0||
|388|E|E388|Pořadí formuláře||
|388|F|F388|Meta atributy||
|388|G|G388|Formulář||
|388|L|L388|přidání atributu||
|388|M|M388|v rámci hromadného přidání technických atributů||
|389|A|A389|27.6.2024||
|389|B|B389|1.0||
|389|E|E389|Počet formulářů||
|389|F|F389|Meta atributy||
|389|G|G389|Formulář||
|389|L|L389|přidání atributu||
|389|M|M389|v rámci hromadného přidání technických atributů||
|390|A|A390|27.6.2024||
|390|B|B390|1.0||
|390|E|E390|Stav formuláře||
|390|F|F390|Meta atributy||
|390|G|G390|Formulář||
|390|L|L390|přidání atributu||
|390|M|M390|v rámci hromadného přidání technických atributů||
|391|A|A391|27.6.2024||
|391|B|B391|1.0||
|391|E|E391|Důvod odmítnutí||
|391|F|F391|Meta atributy||
|391|G|G391|Formulář||
|391|L|L391|přidání atributu||
|391|M|M391|v rámci hromadného přidání technických atributů||
|392|A|A392|27.6.2024||
|392|B|B392|1.0||
|392|E|E392|Datum a čas zpracování formuláře||
|392|F|F392|Meta atributy||
|392|G|G392|Formulář||
|392|L|L392|přidání atributu||
|392|M|M392|v rámci hromadného přidání technických atributů||
|393|A|A393|27.6.2024||
|393|B|B393|1.0||
|393|E|E393|Datum a čas zapsání IK MPSV||
|393|F|F393|Meta atributy||
|393|G|G393|Formulář||
|393|L|L393|přidání atributu||
|393|M|M393|v rámci hromadného přidání technických atributů||
|394|A|A394|27.6.2024||
|394|B|B394|1.0||
|394|E|E394|Název přílohy||
|394|F|F394|Příloha||
|394|L|L394|přidání atributu||
|394|M|M394|v rámci hromadného přidání technických atributů||
|395|A|A395|27.6.2024||
|395|B|B395|1.0||
|395|E|E395|Popis přílohy||
|395|F|F395|Příloha||
|395|L|L395|přidání atributu||
|395|M|M395|v rámci hromadného přidání technických atributů||
|396|A|A396|27.6.2024||
|396|B|B396|1.0||
|396|E|E396|Formát souboru||
|396|F|F396|Příloha||
|396|L|L396|přidání atributu||
|396|M|M396|v rámci hromadného přidání technických atributů||
|397|A|A397|27.6.2024||
|397|B|B397|1.0||
|397|E|E397|DMS reference||
|397|F|F397|Příloha||
|397|L|L397|přidání atributu||
|397|M|M397|v rámci hromadného přidání technických atributů||
|398|A|A398|27.6.2024||
|398|B|B398|1.0||
|398|E|E398|Data přílohy||
|398|F|F398|Příloha||
|398|L|L398|přidání atributu||
|398|M|M398|v rámci hromadného přidání technických atributů||
|399|A|A399|27.6.2024||
|399|B|B399|1.0||
|399|E|E399|<všechny atributy s datovým typem Výčet>||
|399|F|F399|-||
|399|G|G399|-||
|399|L|L399|globální||
|399|M|M399|změna datových typů výčet -> číselník (na základě dohody s dodavatelem Eviden)||
|400|A|A400|28.6.2024||
|400|B|B400|1.0||
|400|D|D400|10251||
|400|E|E400|Zaměstnání za účelem dočasného přidělení u uživatele||
|400|F|F400|Vykonávaná pozice zaměstnance||
|400|G|G400|Forma práce||
|400|H|H400|Dočasné přidělení||
|400|L|L400|přejmenování atributu||
|400|M|M400|zpřesnění názvu atributu ||
|401|A|A401|1.7.2024||
|401|B|B401|1.0||
|401|D|D401|10251||
|401|E|E401|Zaměstnání za účelem dočasného přidělení u uživatele||
|401|F|F401|Vykonávaná pozice zaměstnance||
|401|G|G401|Forma práce||
|401|H|H401|Dočasné přidělení||
|401|L|L401|změna typu hlášení||
|401|M|M401|registrace zaměstnance -> měsíční||
|402|A|A402|1.7.2024||
|402|B|B402|1.0||
|402|D|D402|10252||
|402|E|E402|IČO zaměstnavatele||
|402|F|F402|Vykonávaná pozice zaměstnance||
|402|G|G402|Forma práce||
|402|H|H402|Dočasné přidělení||
|402|L|L402|změna typu hlášení||
|402|M|M402|registrace zaměstnance -> měsíční||
|403|A|A403|10.7.2024||
|403|B|B403|1.0||
|403|D|D403|10055||
|403|E|E403|Titul||
|403|F|F403|Zaměstnanec / Žák / Student ||
|403|G|G403|Základní identifikace||
|403|L|L403|změna datového typu||
|403|M|M403|číselník -> text||
|404|A|A404|11.7.2024||
|404|B|B404|1.0||
|404|D|D404|10232||
|404|E|E404|Mzdový příspěvek v rámci nástrojů APZ||
|404|F|F404|Mzdový příspěvek v rámci nástrojů APZ||
|404|G|G404|Pracovní místo / pozice||
|404|H|H404|APZ||
|404|L|L404|změna typu hlášení||
|404|M|M404|registrace zaměstnance -> měsíční||
|405|A|A405|11.7.2024||
|405|B|B405|1.0||
|405|D|D405|10233||
|405|E|E405|Nástroj (opatření)||
|405|F|F405|Vykonávaná pozice zaměstnance||
|405|G|G405|Pracovní místo / pozice||
|405|H|H405|APZ||
|405|L|L405|změna typu hlášení||
|405|M|M405|registrace zaměstnance -> měsíční||
|406|A|A406|11.7.2024||
|406|B|B406|1.0||
|406|D|D406|10282||
|406|E|E406|Důvod - zaměstnanec||
|406|F|F406|Průběh zaměstnání v daném měsíci||
|406|G|G406|Překážky v práci||
|406|L|L406|přejmenování atributu||
|406|M|M406|rozlišení Důvodů překážek v práci na straně zaměstnance a zaměstnavatele||
|407|A|A407|11.7.2024||
|407|B|B407|1.0||
|407|D|D407|10282||
|407|E|E407|Důvod - zaměstnanec||
|407|F|F407|Průběh zaměstnání v daném měsíci||
|407|G|G407|Překážky v práci||
|407|L|L407|přidání číselníku||
|407|M|M407|rozlišení Důvodů překážek v práci na straně zaměstnance a zaměstnavatele||
|408|A|A408|11.7.2024||
|408|B|B408|1.0||
|408|D|D408|10401||
|408|E|E408|Důvod - zaměstnavatel||
|408|F|F408|Průběh zaměstnání v daném měsíci||
|408|G|G408|Překážky v práci||
|408|L|L408|přidání atributu||
|408|M|M408|rozlišení Důvodů překážek v práci na straně zaměstnance a zaměstnavatele||
|409|A|A409|16.7.2024||
|409|B|B409|1.0||
|409|D|D409|10402||
|409|E|E409|Název subjektu, za který je plněno||
|409|F|F409|Mzdové nároky||
|409|G|G409|Úřad práce||
|409|L|L409|přidání atributu||
|409|M|M409|úprava v rámci finálního řešení kvazizaměstnavatelů||
|410|A|A410|16.7.2024||
|410|B|B410|1.0||
|410|D|D410|10403||
|410|E|E410|IČO subjektu, za který je plněno||
|410|F|F410|Mzdové nároky||
|410|G|G410|Úřad práce||
|410|L|L410|přidání atributu||
|410|M|M410|úprava v rámci finálního řešení kvazizaměstnavatelů||
|411|A|A411|16.7.2024||
|411|B|B411|1.0||
|411|D|D411|10213||
|411|E|E411|Zahraniční kapitál - země původu||
|411|F|F411|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|411|G|G411|Kapitál||
|411|L|L411|odstranění atributu||
|412|A|A412|16.7.2024||
|412|B|B412|1.0||
|412|D|D412|10388||
|412|E|E412|Vypláceno ÚP/Dodavatel||
|412|F|F412|Mzdové nároky||
|412|G|G412|Úřad práce||
|412|L|L412|přejmenování atributu||
|413|A|A413|16.7.2024||
|413|B|B413|1.0||
|413|D|D413|10388||
|413|E|E413|Vypláceno ÚP/Dodavatel||
|413|F|F413|Mzdové nároky||
|413|G|G413|Úřad práce||
|413|L|L413|změna datového typu||
|413|M|M413|číslo -> příznak||
|414|A|A414|16.7.2024||
|414|B|B414|1.0||
|414|D|D414|10389||
|414|E|E414|Výplaty a zdanění ÚP/Dodavatel||
|414|F|F414|Mzdové nároky||
|414|G|G414|Úřad práce||
|414|L|L414|přejmenování atributu||
|415|A|A415|16.7.2024||
|415|B|B415|1.0||
|415|D|D415|10324||
|415|E|E415|Nedoplatek z ročního zúčtování||
|415|F|F415|Příjem v daném měsíci||
|415|G|G415|Přeplatek nedoplatek||
|415|L|L415|odstranění atributu||
|416|A|A416|16.7.2024||
|416|B|B416|1.0||
|416|D|D416|10404||
|416|E|E416|Podíl zahraničního kapitálu||
|416|F|F416|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|416|G|G416|Kapitál k 31.12.||
|416|L|L416|přidání atributu||
|417|A|A417|16.7.2024||
|417|B|B417|1.0||
|417|D|D417|10405||
|417|E|E417|První země původu podle velikosti ||
|417|F|F417|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|417|G|G417|Kapitál k 31.12.||
|417|L|L417|přidání atributu||
|418|A|A418|16.7.2024||
|418|B|B418|1.0||
|418|D|D418|10406||
|418|E|E418|Druhá země původu podle velikosti ||
|418|F|F418|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|418|G|G418|Kapitál k 31.12.||
|418|L|L418|přidání atributu||
|419|A|A419|17.7.2024||
|419|B|B419|1.0||
|419|D|D419|10255||
|419|E|E419|Pracovní režim||
|419|F|F419|Vykonávaná pozice zaměstnance||
|419|G|G419|Režim práce||
|419|L|L419|přejmenování atributu||
|420|A|A420|17.7.2024||
|420|B|B420|1.0||
|420|D|D420|10255||
|420|E|E420|Pracovní režim||
|420|F|F420|Vykonávaná pozice zaměstnance||
|420|G|G420|Režim práce||
|420|L|L420|úprava číselníku||
|421|A|A421|17.7.2024||
|421|B|B421|1.0||
|421|D|D421|10407||
|421|E|E421|Nepřetržitý provoz||
|421|F|F421|Vykonávaná pozice zaměstnance||
|421|G|G421|Režim práce||
|421|L|L421|přidání atributu||
|422|A|A422|17.7.2024||
|422|B|B422|1.0||
|422|D|D422|10256||
|422|E|E422|Fyzická náročnost||
|422|F|F422|Vykonávaná pozice zaměstnance||
|422|G|G422|Náročnost práce||
|422|L|L422|odstranění atributu||
|423|A|A423|17.7.2024||
|423|B|B423|1.0||
|423|D|D423|10257||
|423|E|E423|Psychická náročnost||
|423|F|F423|Vykonávaná pozice zaměstnance||
|423|G|G423|Náročnost práce||
|423|L|L423|odstranění atributu||
|424|A|A424|17.7.2024||
|424|B|B424|1.0||
|424|D|D424|10262||
|424|E|E424|Kód studia||
|424|F|F424|Průběh studia (teoretické a praktické přípravy)||
|424|L|L424|odstranění atributu||
|425|A|A425|17.7.2024||
|425|B|B425|1.0||
|425|D|D425|10346||
|425|E|E425|Pravděpodobná výše příjmu||
|425|F|F425|Příjem v daném měsíci||
|425|G|G425|Výdělek||
|425|L|L425|odstranění atributu||
|426|A|A426|17.7.2024||
|426|B|B426|1.0||
|426|D|D426|10347||
|426|E|E426|Datum úhrady mzdy včetně odvodů na soc. a zdravotní pojištění||
|426|F|F426|Příjem v daném měsíci||
|426|G|G426|Výdělek osob OZP||
|426|L|L426|změna třídy atributu||
|427|A|A427|17.7.2024||
|427|B|B427|1.0||
|427|D|D427|10369||
|427|E|E427|Zdravotní pojištění||
|427|F|F427|Průběh pojištění v daném měsíci||
|427|G|G427|Pojistné za zaměstnavatele||
|427|L|L427|odstranění atributu||
|428|A|A428|17.7.2024||
|428|B|B428|1.0||
|428|D|D428|10368||
|428|E|E428|Sociální pojištění||
|428|F|F428|Průběh pojištění v daném měsíci||
|428|G|G428|Pojistné za zaměstnavatele||
|428|H|H428|Dotované pracovní místo||
|428|L|L428|změna třídy atributu||
|429|A|A429|17.7.2024||
|429|B|B429|1.0||
|429|D|D429|10368||
|429|E|E429|Sociální pojištění, příspěvek na státní politiku zaměstnanosti, zdravotní pojištění||
|429|F|F429|Průběh pojištění v daném měsíci||
|429|G|G429|Pojistné za zaměstnavatele||
|429|H|H429|Dotované pracovní místo||
|429|L|L429|přejmenování atributu||
|430|A|A430|18.7.2024||
|430|B|B430|1.0||
|430|D|D430|10119||
|430|E|E430|Typ zaměstnavatele||
|430|F|F430|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|430|G|G430|Identifikace||
|430|L|L430|úprava číselníku||
|431|A|A431|25.7.2024||
|431|B|B431|1.0||
|431|D|D431|10408||
|431|E|E431|Typ rozhodné skutečnosti||
|431|F|F431|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|431|G|G431|Rozhodná skutečnost||
|431|L|L431|přidání atributu||
|431|M|M431|na podnět GFŘ||
|432|A|A432|25.7.2024||
|432|B|B432|1.0||
|432|D|D432|10409||
|432|E|E432|Datum||
|432|F|F432|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|432|G|G432|Rozhodná skutečnost||
|432|L|L432|přidání atributu||
|432|M|M432|na podnět GFŘ||
|433|A|A433|25.7.2024||
|433|B|B433|1.0||
|433|D|D433|10410||
|433|E|E433|Výplatní termín||
|433|F|F433|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|433|G|G433|Rozhodná skutečnost||
|433|L|L433|přidání atributu||
|433|M|M433|na podnět GFŘ||
|434|A|A434|25.7.2024||
|434|B|B434|1.0||
|434|D|D434|10008||
|434|E|E434|Typ akce||
|434|F|F434|Meta atributy||
|434|G|G434|Podání||
|434|L|L434|úprava číselníku||
|435|A|A435|29.7.2024||
|435|B|B435|1.0||
|435|D|D435|10411||
|435|E|E435|Finančnímu úřadu pro / Specializovanému finančnímu úřadu||
|435|F|F435|Meta atributy||
|435|G|G435|Podání||
|435|L|L435|přidání atributu||
|435|M|M435|na podnět GFŘ||
|436|A|A436|29.7.2024||
|436|B|B436|1.0||
|436|D|D436|10412||
|436|E|E436|Územní pracoviště v, ve, pro  ||
|436|F|F436|Meta atributy||
|436|G|G436|Podání||
|436|L|L436|přidání atributu||
|436|M|M436|na podnět GFŘ||
|437|A|A437|30.7.2024||
|437|B|B437|1.0||
|437|D|D437|10040||
|437|E|E437|Průměrný evidenční počet zaměstnanců ve fyzických osobách (bez DPP a DPČ)||
|437|F|F437|Souhrnná vrstva||
|437|G|G437|Počet zaměstnanců||
|437|L|L437|odstranění atributu||
|437|M|M437|na podnět ČSÚ||
|438|A|A438|30.7.2024||
|438|B|B438|1.0||
|438|D|D438|10041||
|438|E|E438|Průměrný evidenční počet zaměstnanců přepočtený (bez DPP a DPČ) ||
|438|F|F438|Souhrnná vrstva||
|438|G|G438|Počet zaměstnanců||
|438|L|L438|odstranění atributu||
|438|M|M438|na podnět ČSÚ||
|439|A|A439|30.7.2024||
|439|B|B439|1.0||
|439|D|D439|10042||
|439|E|E439|Počet osob pracujících na DPP (fyzické osoby)||
|439|F|F439|Souhrnná vrstva||
|439|G|G439|Počet zaměstnanců||
|439|L|L439|odstranění atributu||
|439|M|M439|na podnět ČSÚ||
|440|A|A440|30.7.2024||
|440|B|B440|1.0||
|440|D|D440|10043||
|440|E|E440|Počet osob pracujících na DPČ (fyzické osoby)||
|440|F|F440|Souhrnná vrstva||
|440|G|G440|Počet zaměstnanců||
|440|L|L440|odstranění atributu||
|440|M|M440|na podnět ČSÚ||
|441|A|A441|30.7.2024||
|441|B|B441|1.0||
|441|D|D441|10044||
|441|E|E441|Počet odpracovaných hodin zaměstnanci v evidenčním počtu||
|441|F|F441|Souhrnná vrstva||
|441|G|G441|Odpracované hodiny||
|441|L|L441|odstranění atributu||
|441|M|M441|na podnět ČSÚ||
|442|A|A442|30.7.2024||
|442|B|B442|1.0||
|442|D|D442|10045||
|442|E|E442|Počet odpracovaných hodin osobami pracujícími na DPP||
|442|F|F442|Souhrnná vrstva||
|442|G|G442|Odpracované hodiny||
|442|L|L442|odstranění atributu||
|442|M|M442|na podnět ČSÚ||
|443|A|A443|30.7.2024||
|443|B|B443|1.0||
|443|D|D443|10046||
|443|E|E443|Počet odpracovaných hodin osobami pracujícími na DPČ||
|443|F|F443|Souhrnná vrstva||
|443|G|G443|Odpracované hodiny||
|443|L|L443|odstranění atributu||
|443|M|M443|na podnět ČSÚ||
|444|A|A444|30.7.2024||
|444|B|B444|1.0||
|444|D|D444|10047||
|444|E|E444|Vyplacená hrubá mzda (včetně příplatků a náhrad mzdy, bez náhrad za nemocenskou placených zaměstnavatelem) – bez OON ||
|444|F|F444|Souhrnná vrstva||
|444|G|G444|Výdělek||
|444|L|L444|odstranění atributu||
|444|M|M444|na podnět ČSÚ||
|445|A|A445|30.7.2024||
|445|B|B445|1.0||
|445|D|D445|10048||
|445|E|E445|Vyplacené odměny celkem||
|445|F|F445|Souhrnná vrstva||
|445|G|G445|Výdělek||
|445|L|L445|odstranění atributu||
|445|M|M445|na podnět ČSÚ||
|446|A|A446|30.7.2024||
|446|B|B446|1.0||
|446|D|D446|10049||
|446|E|E446|Vyplacené odměny z DPP||
|446|F|F446|Souhrnná vrstva||
|446|G|G446|Výdělek||
|446|L|L446|odstranění atributu||
|446|M|M446|na podnět ČSÚ||
|447|A|A447|30.7.2024||
|447|B|B447|1.0||
|447|D|D447|10050||
|447|E|E447|Vyplacené odměny z DPČ||
|447|F|F447|Souhrnná vrstva||
|447|G|G447|Výdělek||
|447|L|L447|odstranění atributu||
|447|M|M447|na podnět ČSÚ||
|448|A|A448|30.7.2024||
|448|B|B448|1.0||
|448|D|D448|10281||
|448|E|E448|Ze strany||
|448|F|F448|Průběh zaměstnání v daném měsíci||
|448|G|G448|Překážky v práci||
|448|L|L448|úprava číselníku||
|449|A|A449|30.7.2024||
|449|B|B449|1.0||
|449|D|D449|10278||
|449|E|E449|Počet neodpracovaných hodin z důvodu dočasné pracovní neschopnosti, za které je ze strany zaměstnavatele poskytována náhrada mzdy ||
|449|F|F449|Průběh zaměstnání v daném měsíci||
|449|G|G449|Neodpracované hodiny||
|449|L|L449|přejmenování atributu||
|450|A|A450|30.7.2024||
|450|B|B450|1.0||
|450|D|D450|10277||
|450|E|E450|Počet neodpracovaných hodin v důsledku dočasné pracovní neschopnosti bez náhrady mzdy ||
|450|F|F450|Průběh zaměstnání v daném měsíci||
|450|G|G450|Neodpracované hodiny||
|450|L|L450|přejmenování atributu||
|451|A|A451|30.7.2024||
|451|B|B451|1.0||
|451|D|D451|10413||
|451|E|E451|Počet neodpracovaných dní||
|451|F|F451|Průběh zaměstnání v daném měsíci||
|451|G|G451|Překážky v práci||
|451|L|L451|přidání atributu||
|452|A|A452|30.7.2024||
|452|B|B452|1.0||
|452|D|D452|10285||
|452|E|E452|Počet neodpracovaných hodin||
|452|F|F452|Průběh zaměstnání v daném měsíci||
|452|G|G452|Překážky v práci||
|452|L|L452|přejmenování atributu||
|453|A|A453|31.7.2024||
|453|B|B453|1.0||
|453|D|D453|10060||
|453|E|E453|VČP||
|453|F|F453|Zaměstnanec / Žák / Student ||
|453|G|G453|Základní identifikace||
|453|L|L453|změna třídy atributu||
|454|A|A454|31.7.2024||
|454|B|B454|1.0||
|454|D|D454|10061||
|454|E|E454|Typ daňové identifikace||
|454|F|F454|Zaměstnanec / Žák / Student ||
|454|G|G454|Daňová identifikace ve státě rezidence||
|454|L|L454|změna třídy atributu||
|455|A|A455|31.7.2024||
|455|B|B455|1.0||
|455|D|D455|10062||
|455|E|E455|TIN||
|455|F|F455|Zaměstnanec / Žák / Student gdgGQsvd58LW||
|455|G|G455|Daňová identifikace ve státě rezidence||
|455|L|L455|změna třídy atributu||
|456|A|A456|31.7.2024||
|456|B|B456|1.0||
|456|D|D456|10068||
|456|E|E456|Kód státu rezidenství||
|456|F|F456|Zaměstnanec / Žák / Student ||
|456|G|G456|Daňová identifikace ve státě rezidence||
|456|L|L456|změna třídy atributu||
|457|A|A457|31.7.2024||
|457|B|B457|1.0||
|457|D|D457|10062||
|457|E|E457|Daňový identifikátor ve státě rezidence||
|457|F|F457|Zaměstnanec / Žák / Student ||
|457|G|G457|Daňová identifikace ve státě rezidence||
|457|L|L457|přejmenování atributu||
|458|A|A458|5.8.2024||
|458|B|B458|1.0||
|458|D|D458|10409||
|458|E|E458|Datum rozhodné skutečnosti||
|458|F|F458|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|458|G|G458|Rozhodná skutečnost||
|458|L|L458|přejmenování atributu||
|459|A|A459|5.8.2024||
|459|B|B459|1.0||
|459|D|D459|10410||
|459|E|E459|Výplatní termín||
|459|F|F459|Příjem v daném měsíci||
|459|G|G459|Rozhodná skutečnost||
|459|L|L459|změna oblasti atributu||
|460|A|A460|6.8.2024||
|460|B|B460|1.0||
|460|D|D460|10238||
|460|E|E460|Vedoucí zaměstnanec||
|460|F|F460|Vykonávaná pozice zaměstnance||
|460|G|G460|Pracovní místo / pozice||
|460|L|L460|změna datového typu||
|460|M|M460|text -> příznak||
|461|A|A461|7.8.2024||
|461|B|B461|1.0||
|461|D|D461|10004||
|461|E|E461|Pracoviště ÚSSZ (OSSZ/PSSZ/MSSZ Brno)||
|461|F|F461|Meta atributy||
|461|G|G461|Podání||
|461|L|L461|přejmenování atributu||
|462|A|A462|7.8.2024||
|462|B|B462|1.0||
|462|D|D462|10007||
|462|E|E462|Typ podání||
|462|F|F462|Meta atributy||
|462|G|G462|Podání||
|462|L|L462|úprava číselníku||
|462|M|M462|terminologie nové -> řádné||
|463|A|A463|7.8.2024||
|463|B|B463|1.0||
|463|D|D463|10016||
|463|E|E463|Typ formuláře||
|463|F|F463|Meta atributy||
|463|G|G463|Formulář||
|463|L|L463|úprava číselníku||
|463|M|M463|terminologie nový -> řádný||
|464|A|A464|7.8.2024||
|464|B|B464|1.0||
|464|D|D464|10105||
|464|E|E464|Oprávnění pro výkon pracovní činnosti / Statut cizince||
|464|F|F464|Zaměstnanec / Žák / Student ||
|464|G|G464|Pracovní oprávnění cizince||
|464|L|L464|přejmenování atributu||
|464|M|M464|na základě připomínky k prototypu #192||
|465|A|A465|8.8.2024||
|465|B|B465|1.0||
|465|D|D465|10252||
|465|E|E465|IČO uživatele||
|465|F|F465|Vykonávaná pozice zaměstnance||
|465|G|G465|Forma práce||
|465|H|H465|Dočasné přidělení||
|465|L|L465|přejmenování atributu||
|466|A|A466|9.8.2024||
|466|B|B466|1.0||
|466|D|D466|10052||
|466|E|E466|BSI||
|466|F|F466|Zaměstnanec / Žák / Student ||
|466|G|G466|Základní identifikace||
|466|L|L466|odstranění atributu||
|466|M|M466|na základě změny konceptu ztotožňování||
|467|A|A467|9.8.2024||
|467|B|B467|1.0||
|467|D|D467|10375||
|467|E|E467|Doby odečítané po důchodovém věku - počet dnů||
|467|F|F467|Průběh pojištění v daném měsíci||
|467|G|G467|Odečítané dny||
|467|L|L467|změna třídy atributu||
|467|M|M467|upřesnění třídy atributu||
|468|A|A468|12.8.2024||
|468|B|B468|1.0||
|468|D|D468|10325||
|468|E|E468|Typ rozhodné skutečnosti||
|468|F|F468|Příjem v daném měsíci||
|468|G|G468|Přeplatek nedoplatek||
|468|H|H468|Rozhodná skutečnost||
|468|L|L468|odstranění atributu||
|468|M|M468|dodatečné smazání po přesunu do jiné oblasti||
|469|A|A469|12.8.2024||
|469|B|B469|1.0||
|469|D|D469|10326||
|469|E|E469|Datum||
|469|F|F469|Příjem v daném měsíci||
|469|G|G469|Přeplatek nedoplatek||
|469|H|H469|Rozhodná skutečnost||
|469|L|L469|odstranění atributu||
|469|M|M469|dodatečné smazání po přesunu do jiné oblasti||
|470|A|A470|12.8.2024||
|470|B|B470|1.0||
|470|D|D470|10327||
|470|E|E470|Výplatní termín||
|470|F|F470|Příjem v daném měsíci||
|470|G|G470|Přeplatek nedoplatek||
|470|H|H470|Rozhodná skutečnost||
|470|L|L470|odstranění atributu||
|470|M|M470|dodatečné smazání po přesunu do jiné oblasti||
|471|A|A471|12.8.2024||
|471|B|B471|1.0||
|471|D|D471|10321||
|471|E|E471|Přeplatek daně z ročního zúčtování||
|471|F|F471|Příjem v daném měsíci||
|471|G|G471|Přeplatek / doplatek||
|471|L|L471|změna třídy atributu||
|471|M|M471|na základě dřívějšího odebrání nedoplatku z třídy||
|472|A|A472|12.8.2024||
|472|B|B472|1.0||
|472|D|D472|10322||
|472|E|E472|Přeplatek daně||
|472|F|F472|Příjem v daném měsíci||
|472|G|G472|Přeplatek / doplatek||
|472|L|L472|změna třídy atributu||
|472|M|M472|na základě dřívějšího odebrání nedoplatku z třídy||
|473|A|A473|12.8.2024||
|473|B|B473|1.0||
|473|D|D473|10323||
|473|E|E473|Doplatek na daňovém bonusu z ročního zúčtování||
|473|F|F473|Příjem v daném měsíci||
|473|G|G473|Přeplatek / doplatek||
|473|L|L473|změna třídy atributu||
|473|M|M473|na základě dřívějšího odebrání nedoplatku z třídy||
|474|A|A474|19.8.2024||
|474|B|B474|1.0||
|474|D|D474|10411||
|474|E|E474|Finančnímu úřadu pro / Specializovanému finančnímu úřadu||
|474|F|F474|Meta atributy||
|474|G|G474|Podání||
|474|L|L474|změna typu hlášení||
|474|M|M474|na základě konzultace s FS všechna -> registrace zaměstnavatele||
|475|A|A475|19.8.2024||
|475|B|B475|1.0||
|475|D|D475|10412||
|475|E|E475|Územní pracoviště v, ve, pro  ||
|475|F|F475|Meta atributy||
|475|G|G475|Podání||
|475|L|L475|změna typu hlášení||
|475|M|M475|na základě konzultace s FS všechna -> registrace zaměstnavatele||
|476|A|A476|21.8.2024||
|476|B|B476|1.0||
|476|D|D476|10414||
|476|E|E476|Volný přístup na trh práce||
|476|F|F476|Zaměstnanec / Žák / Student ||
|476|G|G476|Zaměstnanec bez státního občanství ČR||
|476|L|L476|přidání atributu||
|477|A|A477|21.8.2024||
|477|B|B477|1.0||
|477|D|D477|10105||
|477|E|E477|Oprávnění pro výkon pracovní činnosti / Statut cizince||
|477|F|F477|Zaměstnanec / Žák / Student ||
|477|G|G477|Zaměstnanec bez státního občanství ČR||
|477|L|L477|změna třídy atributu||
|478|A|A478|21.8.2024||
|478|B|B478|1.0||
|478|D|D478|10106||
|478|E|E478|Druh pracovního oprávnění||
|478|F|F478|Zaměstnanec / Žák / Student ||
|478|G|G478|Zaměstnanec bez státního občanství ČR||
|478|L|L478|změna třídy atributu||
|479|A|A479|21.8.2024||
|479|B|B479|1.0||
|479|D|D479|10107||
|479|E|E479|Vydala Krajská pobočka ÚP ČR||
|479|F|F479|Zaměstnanec / Žák / Student ||
|479|G|G479|Zaměstnanec bez státního občanství ČR||
|479|L|L479|změna třídy atributu||
|480|A|A480|21.8.2024||
|480|B|B480|1.0||
|480|D|D480|10108||
|480|E|E480|Identifikátor pracovního oprávnění||
|480|F|F480|Zaměstnanec / Žák / Student ||
|480|G|G480|Zaměstnanec bez státního občanství ČR||
|480|L|L480|změna třídy atributu||
|481|A|A481|21.8.2024||
|481|B|B481|1.0||
|481|D|D481|10109||
|481|E|E481|Trvání oprávnění od||
|481|F|F481|Zaměstnanec / Žák / Student ||
|481|G|G481|Zaměstnanec bez státního občanství ČR||
|481|L|L481|změna třídy atributu||
|482|A|A482|21.8.2024||
|482|B|B482|1.0||
|482|D|D482|10110||
|482|E|E482|Trvání oprávnění do||
|482|F|F482|Zaměstnanec / Žák / Student ||
|482|G|G482|Zaměstnanec bez státního občanství ČR||
|482|L|L482|změna třídy atributu||
|483|A|A483|21.8.2024||
|483|B|B483|1.0||
|483|D|D483|10111||
|483|E|E483|Prodloužení||
|483|F|F483|Zaměstnanec / Žák / Student ||
|483|G|G483|Zaměstnanec bez státního občanství ČR||
|483|L|L483|změna třídy atributu||
|484|A|A484|21.8.2024||
|484|B|B484|1.0||
|484|D|D484|10112||
|484|E|E484|Změna povinnosti - cizinec povolení nepotřebuje ode dne||
|484|F|F484|Zaměstnanec / Žák / Student ||
|484|G|G484|Zaměstnanec bez státního občanství ČR||
|484|L|L484|změna třídy atributu||
|485|A|A485|22.8.2024||
|485|B|B485|1.0||
|485|D|D485|10286||
|485|E|E485|Zúčtovaný příjem - celkem||
|485|F|F485|Příjem v daném měsíci||
|485|G|G485|Výpočet daně||
|485|L|L485|přejmenování atributu||
|486|A|A486|22.8.2024||
|486|B|B486|1.0||
|486|D|D486|10287||
|486|E|E486|Zúčtovaný příjem - z toho peněžní příjmy||
|486|F|F486|Příjem v daném měsíci||
|486|G|G486|Výpočet daně||
|486|L|L486|přejmenování atributu||
|487|A|A487|22.8.2024||
|487|B|B487|1.0||
|487|D|D487|10288||
|487|E|E487|Zúčtovaný příjem - z toho nepeněžní příjmy / naturální mzda||
|487|F|F487|Příjem v daném měsíci||
|487|G|G487|Výpočet daně||
|487|L|L487|přejmenování atributu||
|488|A|A488|22.8.2024||
|488|B|B488|1.0||
|488|D|D488|10415||
|488|E|E488|Zúčtovaný příjem - z toho příjem za bezplatné používání motorového vozidla||
|488|F|F488|Příjem v daném měsíci||
|488|G|G488|Výpočet daně||
|488|L|L488|přidání atributu||
|489|A|A489|22.8.2024||
|489|B|B489|1.0||
|489|D|D489|10416||
|489|E|E489|Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR||
|489|F|F489|Příjem v daném měsíci||
|489|G|G489|Výpočet daně||
|489|L|L489|přidání atributu||
|490|A|A490|22.8.2024||
|490|B|B490|1.0||
|490|D|D490|10289||
|490|E|E490|Osvobozené příjmy ze zúčtovaných příjmů - celkem||
|490|F|F490|Příjem v daném měsíci||
|490|G|G490|Výpočet daně||
|490|L|L490|přejmenování atributu||
|491|A|A491|22.8.2024||
|491|B|B491|1.0||
|491|D|D491|10290||
|491|E|E491|Osvobozené příjmy ze zúčtovaných příjmů - z toho peněžní příjmy||
|491|F|F491|Příjem v daném měsíci||
|491|G|G491|Výpočet daně||
|491|L|L491|přejmenování atributu||
|492|A|A492|22.8.2024||
|492|B|B492|1.0||
|492|D|D492|10291||
|492|E|E492|Osvobozené příjmy ze zúčtovaných příjmů - z toho nepeněžní příjmy / naturální mzda||
|492|F|F492|Příjem v daném měsíci||
|492|G|G492|Výpočet daně||
|492|L|L492|přejmenování atributu||
|493|A|A493|22.8.2024||
|493|B|B493|1.0||
|493|D|D493|10417||
|493|E|E493|Příspěvek zaměstnavatele na produkty spoření na stáří a pojištění dlouhodobé péče z osvobozených příjmů - celkem||
|493|F|F493|Příjem v daném měsíci||
|493|G|G493|Příspěvek zaměstnavatele  (z úhrnu osvobozených příjmů)||
|493|L|L493|přidání atributu||
|494|A|A494|22.8.2024||
|494|B|B494|1.0||
|494|D|D494|10418||
|494|E|E494|Příspěvek na pojištění dlouhodobé péče||
|494|F|F494|Příjem v daném měsíci||
|494|G|G494|Příspěvek zaměstnavatele  (z úhrnu osvobozených příjmů)||
|494|L|L494|přidání atributu||
|495|A|A495|22.8.2024||
|495|B|B495|1.0||
|495|D|D495|10286||
|495|E|E495|Zúčtovaný příjem - celkem||
|495|F|F495|Příjem v daném měsíci||
|495|G|G495|Příjem||
|495|L|L495|změna třídy atributu||
|496|A|A496|22.8.2024||
|496|B|B496|1.0||
|496|D|D496|10287||
|496|E|E496|Zúčtovaný příjem - z toho peněžní příjmy||
|496|F|F496|Příjem v daném měsíci||
|496|G|G496|Příjem||
|496|L|L496|změna třídy atributu||
|497|A|A497|22.8.2024||
|497|B|B497|1.0||
|497|D|D497|10288||
|497|E|E497|Zúčtovaný příjem - z toho nepeněžní příjmy / naturální mzda||
|497|F|F497|Příjem v daném měsíci||
|497|G|G497|Příjem||
|497|L|L497|změna třídy atributu||
|498|A|A498|22.8.2024||
|498|B|B498|1.0||
|498|D|D498|10415||
|498|E|E498|Zúčtovaný příjem - z toho příjem za bezplatné používání motorového vozidla||
|498|F|F498|Příjem v daném měsíci||
|498|G|G498|Příjem||
|498|L|L498|změna třídy atributu||
|499|A|A499|22.8.2024||
|499|B|B499|1.0||
|499|D|D499|10416||
|499|E|E499|Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR||
|499|F|F499|Příjem v daném měsíci||
|499|G|G499|Příjem||
|499|L|L499|změna třídy atributu||
|500|A|A500|22.8.2024||
|500|B|B500|1.0||
|500|D|D500|10289||
|500|E|E500|Osvobozené příjmy ze zúčtovaných příjmů - celkem||
|500|F|F500|Příjem v daném měsíci||
|500|G|G500|Příjem||
|500|L|L500|změna třídy atributu||
|501|A|A501|22.8.2024||
|501|B|B501|1.0||
|501|D|D501|10290||
|501|E|E501|Osvobozené příjmy ze zúčtovaných příjmů - z toho peněžní příjmy||
|501|F|F501|Příjem v daném měsíci||
|501|G|G501|Příjem||
|501|L|L501|změna třídy atributu||
|502|A|A502|22.8.2024||
|502|B|B502|1.0||
|502|D|D502|10291||
|502|E|E502|Osvobozené příjmy ze zúčtovaných příjmů - z toho nepeněžní příjmy / naturální mzda||
|502|F|F502|Příjem v daném měsíci||
|502|G|G502|Příjem||
|502|L|L502|změna třídy atributu||
|503|A|A503|22.8.2024||
|503|B|B503|1.0||
|503|D|D503|10417||
|503|E|E503|Příspěvek zaměstnavatele na produkty spoření na stáří a pojištění dlouhodobé péče z osvobozených příjmů - celkem||
|503|F|F503|Příjem v daném měsíci||
|503|G|G503|Příjem||
|503|H|H503|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|503|L|L503|změna třídy atributu||
|504|A|A504|22.8.2024||
|504|B|B504|1.0||
|504|D|D504|10292||
|504|E|E504|Příspěvek na penzijní připojištění se státním příspěvkem||
|504|F|F504|Příjem v daném měsíci||
|504|G|G504|Příjem||
|504|H|H504|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|504|L|L504|změna třídy atributu||
|505|A|A505|22.8.2024||
|505|B|B505|1.0||
|505|D|D505|10293||
|505|E|E505|Příspěvek na doplňkové penzijní spoření||
|505|F|F505|Příjem v daném měsíci||
|505|G|G505|Příjem||
|505|H|H505|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|505|L|L505|změna třídy atributu||
|506|A|A506|22.8.2024||
|506|B|B506|1.0||
|506|D|D506|10294||
|506|E|E506|Příspěvek na penzijní pojištění||
|506|F|F506|Příjem v daném měsíci||
|506|G|G506|Příjem||
|506|H|H506|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|506|L|L506|změna třídy atributu||
|507|A|A507|22.8.2024||
|507|B|B507|1.0||
|507|D|D507|10295||
|507|E|E507|Příspěvek na soukromé životní pojištění||
|507|F|F507|Příjem v daném měsíci||
|507|G|G507|Příjem||
|507|H|H507|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|507|L|L507|změna třídy atributu||
|508|A|A508|22.8.2024||
|508|B|B508|1.0||
|508|D|D508|10296||
|508|E|E508|Příspěvek na dlouhodobý investiční produkt||
|508|F|F508|Příjem v daném měsíci||
|508|G|G508|Příjem||
|508|H|H508|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|508|L|L508|změna třídy atributu||
|509|A|A509|22.8.2024||
|509|B|B509|1.0||
|509|D|D509|10418||
|509|E|E509|Příspěvek na pojištění dlouhodobé péče||
|509|F|F509|Příjem v daném měsíci||
|509|G|G509|Příjem||
|509|H|H509|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|509|L|L509|změna třídy atributu||
|510|A|A510|22.8.2024||
|510|B|B510|1.0||
|510|D|D510|10419||
|510|E|E510|Prohlášení poplatníka daně z příjmů ze závislé činnosti||
|510|F|F510|Příjem v daném měsíci||
|510|G|G510|Výpočet zálohy na daň||
|510|L|L510|přidání atributu||
|511|A|A511|22.8.2024||
|511|B|B511|1.0||
|511|D|D511|10298||
|511|E|E511|Vypočtená záloha na daň||
|511|F|F511|Příjem v daném měsíci||
|511|G|G511|Výpočet daně||
|511|L|L511|přejmenování atributu||
|512|A|A512|22.8.2024||
|512|B|B512|1.0||
|512|D|D512|10305||
|512|E|E512|Skutečně sražená záloha na daň po uplatnění slev||
|512|F|F512|Příjem v daném měsíci||
|512|G|G512|Výpočet daně||
|512|L|L512|přejmenování atributu||
|513|A|A513|22.8.2024||
|513|B|B513|1.0||
|513|D|D513|10297||
|513|E|E513|Základ pro výpočet zálohy na daň||
|513|F|F513|Příjem v daném měsíci||
|513|G|G513|Výpočet zálohy na daň||
|513|L|L513|změna třídy atributu||
|514|A|A514|22.8.2024||
|514|B|B514|1.0||
|514|D|D514|10298||
|514|E|E514|Vypočtená záloha na daň||
|514|F|F514|Příjem v daném měsíci||
|514|G|G514|Výpočet zálohy na daň||
|514|L|L514|změna třídy atributu||
|515|A|A515|22.8.2024||
|515|B|B515|1.0||
|515|D|D515|10299||
|515|E|E515|Základní sleva na poplatníka||
|515|F|F515|Příjem v daném měsíci||
|515|G|G515|Výpočet zálohy na daň||
|515|L|L515|změna třídy atributu||
|516|A|A516|22.8.2024||
|516|B|B516|1.0||
|516|D|D516|10300||
|516|E|E516|Základní sleva na invaliditu (I. nebo II. Stupeň)||
|516|F|F516|Příjem v daném měsíci||
|516|G|G516|Výpočet zálohy na daň||
|516|L|L516|změna třídy atributu||
|517|A|A517|22.8.2024||
|517|B|B517|1.0||
|517|D|D517|10301||
|517|E|E517|Rozšířená sleva na invaliditu (III. Stupeň)||
|517|F|F517|Příjem v daném měsíci||
|517|G|G517|Výpočet zálohy na daň||
|517|L|L517|změna třídy atributu||
|518|A|A518|22.8.2024||
|518|B|B518|1.0||
|518|D|D518|10302||
|518|E|E518|Sleva na držitele průkazu ZTP/P||
|518|F|F518|Příjem v daném měsíci||
|518|G|G518|Výpočet zálohy na daň||
|518|L|L518|změna třídy atributu||
|519|A|A519|22.8.2024||
|519|B|B519|1.0||
|519|D|D519|10303||
|519|E|E519|Měsíční daňové zvýhodnění na děti||
|519|F|F519|Příjem v daném měsíci||
|519|G|G519|Výpočet zálohy na daň||
|519|L|L519|změna třídy atributu||
|520|A|A520|22.8.2024||
|520|B|B520|1.0||
|520|D|D520|10304||
|520|E|E520|Měsíční sleva na děti||
|520|F|F520|Příjem v daném měsíci||
|520|G|G520|Výpočet zálohy na daň||
|520|L|L520|změna třídy atributu||
|521|A|A521|22.8.2024||
|521|B|B521|1.0||
|521|D|D521|10305||
|521|E|E521|Skutečně sražená záloha na daň po uplatnění slev||
|521|F|F521|Příjem v daném měsíci||
|521|G|G521|Výpočet zálohy na daň||
|521|L|L521|změna třídy atributu||
|522|A|A522|22.8.2024||
|522|B|B522|1.0||
|522|D|D522|10306||
|522|E|E522|Výše vyplaceného měsíčního daňového bonusu||
|522|F|F522|Příjem v daném měsíci||
|522|G|G522|Výpočet zálohy na daň||
|522|L|L522|změna třídy atributu||
|523|A|A523|22.8.2024||
|523|B|B523|1.0||
|523|D|D523|10307||
|523|E|E523|Základ pro výpočet daně podle zvláštní sazby daně||
|523|F|F523|Příjem v daném měsíci||
|523|G|G523|Výpočet daně podle zvláštní sazby daně ||
|523|L|L523|změna třídy atributu||
|524|A|A524|22.8.2024||
|524|B|B524|1.0||
|524|D|D524|10308||
|524|E|E524|Odměna člena (nerezidenta) orgánu právnické osoby||
|524|F|F524|Příjem v daném měsíci||
|524|G|G524|Výpočet daně podle zvláštní sazby daně ||
|524|L|L524|změna třídy atributu||
|525|A|A525|22.8.2024||
|525|B|B525|1.0||
|525|D|D525|10309||
|525|E|E525|Skutečně sražená daň podle zvláštní sazby daně / měsíc||
|525|F|F525|Příjem v daném měsíci||
|525|G|G525|Výpočet daně podle zvláštní sazby daně ||
|525|L|L525|změna třídy atributu||
|526|A|A526|22.8.2024||
|526|B|B526|1.0||
|526|D|D526|10310||
|526|E|E526|Sražená daň podle zvláštní sazby daně z příjmu nerezidenta člena orgánu právnické osoby||
|526|F|F526|Příjem v daném měsíci||
|526|G|G526|Výpočet daně podle zvláštní sazby daně ||
|526|L|L526|změna třídy atributu||
|527|A|A527|23.8.2024||
|527|B|B527|1.0||
|527|D|D527|10313||
|527|E|E527|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. následujícího roku - příjmy zdaněné zálohou na daň celkem||
|527|F|F527|Příjem v daném měsíci||
|527|G|G527|Roční úhrny jednotlivých položek||
|527|L|L527|přejmenování atributu||
|528|A|A528|23.8.2024||
|528|B|B528|1.0||
|528|D|D528|10314||
|528|E|E528|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. (§ 5 odst. 4 ZDP) - příjmy zdanitelné zálohou na daň - peněžní příjmy||
|528|F|F528|Příjem v daném měsíci||
|528|G|G528|Roční úhrny jednotlivých položek||
|528|L|L528|odstranění atributu||
|529|A|A529|23.8.2024||
|529|B|B529|1.0||
|529|D|D529|10315||
|529|E|E529|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. (§ 5 odst. 4 ZDP) - příjmy zdanitelné zálohou na daň - nepeněžní příjmy / naturální mzda||
|529|F|F529|Příjem v daném měsíci||
|529|G|G529|Roční úhrny jednotlivých položek||
|529|L|L529|odstranění atributu||
|530|A|A530|23.8.2024||
|530|B|B530|1.0||
|530|D|D530|10316||
|530|E|E530|Doplatky příjmů zúčtovaných v minulých zdaňovacích obdobích zdanitelných v ČR zdaněné zálohou na daň vyplacené nebo obdržené do 31.1. následujícího roku||
|530|F|F530|Příjem v daném měsíci||
|530|G|G530|Roční úhrny jednotlivých položek||
|530|L|L530|přejmenování atributu||
|531|A|A531|23.8.2024||
|531|B|B531|1.0||
|531|D|D531|10317||
|531|E|E531|Skutečně sražená záloha na daň z příjmů vyplacených nebo obdržených do 31.1. následujícího roku||
|531|F|F531|Příjem v daném měsíci||
|531|G|G531|Roční úhrny jednotlivých položek||
|531|L|L531|přejmenování atributu||
|532|A|A532|23.8.2024||
|532|B|B532|1.0||
|532|D|D532|10318||
|532|E|E532|Skutečně sražená záloha na daň z doplatků příjmů zdanitelných v ČR||
|532|F|F532|Příjem v daném měsíci||
|532|G|G532|Roční úhrny jednotlivých položek||
|532|L|L532|přejmenování atributu||
|533|A|A533|23.8.2024||
|533|B|B533|1.0||
|533|D|D533|10319||
|533|E|E533|Zaměstnanec požádal o provedení ročního zúčtování||
|533|F|F533|Příjem v daném měsíci||
|533|G|G533|Roční zúčtování||
|533|L|L533|přejmenování atributu||
|534|A|A534|23.8.2024||
|534|B|B534|1.0||
|534|D|D534|10321||
|534|E|E534|Přeplatek nebo nedoplatek z ročního zúčtování||
|534|F|F534|Příjem v daném měsíci||
|534|G|G534|Přeplatek / doplatek||
|534|L|L534|přejmenování atributu||
|535|A|A535|23.8.2024||
|535|B|B535|1.0||
|535|D|D535|10322||
|535|E|E535|Přeplatek nebo nedoplatek z ročního zúčtování - z toho přeplatek na dani nebo nedoplatek daně||
|535|F|F535|Příjem v daném měsíci||
|535|G|G535|Přeplatek / doplatek||
|535|L|L535|přejmenování atributu||
|536|A|A536|23.8.2024||
|536|B|B536|1.0||
|536|D|D536|10323||
|536|E|E536|Přeplatek nebo nedoplatek z ročního zúčtování - z toho doplatek na daňovém bonusu nebo přeplacená částka daňového bonusu zaměstnanci||
|536|F|F536|Příjem v daném měsíci||
|536|G|G536|Přeplatek / doplatek||
|536|L|L536|přejmenování atributu||
|537|A|A537|23.8.2024||
|537|B|B537|1.0||
|537|D|D537|10321||
|537|E|E537|Přeplatek nebo nedoplatek z ročního zúčtování||
|537|F|F537|Příjem v daném měsíci||
|537|G|G537|Přeplatek / doplatek||
|537|L|L537|změna datového typu||
|537|M|M537|příznak -> číslo||
|538|A|A538|26.8.2024||
|538|B|B538|1.0||
|538|D|D538|10105||
|538|E|E538|Oprávnění pro výkon pracovní činnosti||
|538|F|F538|Zaměstnanec / Žák / Student ||
|538|G|G538|Zaměstnanec bez státního občanství ČR||
|538|L|L538|přejmenování atributu||
|539|A|A539|26.8.2024||
|539|B|B539|1.0||
|539|D|D539|10321||
|539|E|E539|Přeplatek nebo nedoplatek z ročního zúčtování||
|539|F|F539|Příjem v daném měsíci||
|539|G|G539|Výsledek ročního zúčtování||
|539|L|L539|změna třídy atributu||
|540|A|A540|26.8.2024||
|540|B|B540|1.0||
|540|D|D540|10322||
|540|E|E540|Přeplatek nebo nedoplatek z ročního zúčtování - z toho přeplatek na dani nebo nedoplatek daně||
|540|F|F540|Příjem v daném měsíci||
|540|G|G540|Výsledek ročního zúčtování||
|540|L|L540|změna třídy atributu||
|541|A|A541|26.8.2024||
|541|B|B541|1.0||
|541|D|D541|10323||
|541|E|E541|Přeplatek nebo nedoplatek z ročního zúčtování - z toho doplatek na daňovém bonusu nebo přeplacená částka daňového bonusu zaměstnanci||
|541|F|F541|Příjem v daném měsíci||
|541|G|G541|Výsledek ročního zúčtování||
|541|L|L541|změna třídy atributu||
|542|A|A542|27.8.2024||
|542|B|B542|1.0||
|542|D|D542|10420||
|542|E|E542|Uplatněna sleva na manželku / manžela||
|542|F|F542|Příjem v daném měsíci||
|542|G|G542|Výsledek ročního zúčtování||
|542|H|H542|Sleva na maželku / manžela||
|542|L|L542|přidání atributu||
|543|A|A543|27.8.2024||
|543|B|B543|1.0||
|543|D|D543|10421||
|543|E|E543|Jméno manželky / manžela||
|543|F|F543|Příjem v daném měsíci||
|543|G|G543|Výsledek ročního zúčtování||
|543|H|H543|Sleva na maželku / manžela||
|543|L|L543|přidání atributu||
|544|A|A544|27.8.2024||
|544|B|B544|1.0||
|544|D|D544|10422||
|544|E|E544|Příjmení manželky / manžela||
|544|F|F544|Příjem v daném měsíci||
|544|G|G544|Výsledek ročního zúčtování||
|544|H|H544|Sleva na maželku / manžela||
|544|L|L544|přidání atributu||
|545|A|A545|27.8.2024||
|545|B|B545|1.0||
|545|D|D545|10423||
|545|E|E545|Rodné číslo manželky / manžela||
|545|F|F545|Příjem v daném měsíci||
|545|G|G545|Výsledek ročního zúčtování||
|545|H|H545|Sleva na maželku / manžela||
|545|L|L545|přidání atributu||
|546|A|A546|27.8.2024||
|546|B|B546|1.0||
|546|D|D546|10424||
|546|E|E546|Datum narození manželky / manžela||
|546|F|F546|Příjem v daném měsíci||
|546|G|G546|Výsledek ročního zúčtování||
|546|H|H546|Sleva na maželku / manžela||
|546|L|L546|přidání atributu||
|547|A|A547|27.8.2024||
|547|B|B547|1.0||
|547|D|D547|10425||
|547|E|E547|Držitelka / držitel karty ZTP/P||
|547|F|F547|Příjem v daném měsíci||
|547|G|G547|Výsledek ročního zúčtování||
|547|H|H547|Sleva na maželku / manžela||
|547|L|L547|přidání atributu||
|548|A|A548|27.8.2024||
|548|B|B548|1.0||
|548|D|D548|10426||
|548|E|E548|Počet měsíců||
|548|F|F548|Příjem v daném měsíci||
|548|G|G548|Výsledek ročního zúčtování||
|548|H|H548|Sleva na maželku / manžela||
|548|L|L548|přidání atributu||
|549|A|A549|27.8.2024||
|549|B|B549|1.0||
|549|D|D549|10376||
|549|E|E549|Důvod neposkytnutí podkladů||
|549|F|F549|Informace pro podporu v nezaměstnanosti||
|549|G|G549|Důvody||
|549|L|L549|úprava číselníku||
|550|A|A550|27.8.2024||
|550|B|B550|1.0||
|550|D|D550|10410||
|550|E|E550|Výplatní termín při nastání rozhodné skutečnosti||
|550|F|F550|Příjem v daném měsíci||
|550|G|G550|Rozhodná skutečnost||
|550|L|L550|přejmenování atributu||
|551|A|A551|28.8.2024||
|551|B|B551|1.0||
|551|D|D551|10427||
|551|E|E551|Příslušnost k cizím právním předpisům||
|551|F|F551|Zaměstnanec / Žák / Student ||
|551|G|G551|Příslušnost k cizím právním předpisům||
|551|L|L551|přidání atributu||
|552|A|A552|28.8.2024||
|552|B|B552|1.0||
|552|D|D552|10428||
|552|E|E552|Kód státu||
|552|F|F552|Zaměstnanec / Žák / Student ||
|552|G|G552|Příslušnost k cizím právním předpisům||
|552|L|L552|přidání atributu||
|553|A|A553|28.8.2024||
|553|B|B553|1.0||
|553|D|D553|10008||
|553|E|E553|Typ akce||
|553|F|F553|Meta atributy||
|553|G|G553|Podání||
|553|L|L553|úprava číselníku||
|553|M|M553|přidán Převod zaměstnance k jinému zaměstnavateli||
|554|A|A554|28.8.2024||
|554|B|B554|1.0||
|554|D|D554|10429||
|554|E|E554|Zařazení do skupiny podle náročnosti vykonávané práce||
|554|F|F554|Vykonávaná pozice zaměstnance||
|554|G|G554|Profese||
|554|L|L554|přidání atributu||
|555|A|A555|28.8.2024||
|555|B|B555|1.0||
|555|D|D555|10426||
|555|E|E555|Počet měsíců uplatnění slevy||
|555|F|F555|Příjem v daném měsíci||
|555|G|G555|Výsledek ročního zúčtování||
|555|H|H555|Sleva na maželku / manžela||
|555|L|L555|přejmenování atributu||
|556|A|A556|28.8.2024||
|556|B|B556|1.0||
|556|D|D556|10430||
|556|E|E556|Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P||
|556|F|F556|Příjem v daném měsíci||
|556|G|G556|Výsledek ročního zúčtování||
|556|H|H556|Sleva na maželku / manžela||
|556|L|L556|přidání atributu||
|557|A|A557|28.8.2024||
|557|B|B557|1.0||
|557|D|D557|10034||
|557|E|E557|Úhrn skutečně sražených záloh na dani po slevách||
|557|F|F557|Souhrnná vrstva||
|557|G|G557|Daň||
|557|H|H557|Měsíční údaj||
|557|L|L557|přejmenování atributu||
|558|A|A558|28.8.2024||
|558|B|B558|1.0||
|558|D|D558|10035||
|558|E|E558|Úhrn vyplacených měsíčních daňových bonusů||
|558|F|F558|Souhrnná vrstva||
|558|G|G558|Daň||
|558|H|H558|Měsíční údaj||
|558|L|L558|přejmenování atributu||
|559|A|A559|28.8.2024||
|559|B|B559|1.0||
|559|D|D559|10036||
|559|E|E559|Úhrn přeplatků na dani a nedoplatků daně z ročního zúčtování||
|559|F|F559|Souhrnná vrstva||
|559|G|G559|Daň||
|559|H|H559|Údaj ve stanoveném období||
|559|L|L559|přejmenování atributu||
|560|A|A560|28.8.2024||
|560|B|B560|1.0||
|560|D|D560|10037||
|560|E|E560|Úhrn doplatků na daňových bonusech vyplacených zaměstnancům a vrácených přeplatků daňových bonusů  zaměstnanci z ročního zúčtování \nDoplatek na daňovém bonusu z ročního zúčtování||
|560|F|F560|Souhrnná vrstva||
|560|G|G560|Daň||
|560|H|H560|Údaj ve stanoveném období||
|560|L|L560|přejmenování atributu||
|561|A|A561|28.8.2024||
|561|B|B561|1.0||
|561|D|D561|10034||
|561|E|E561|Úhrn skutečně sražených záloh na dani po slevách||
|561|F|F561|Souhrnná vrstva||
|561|G|G561|Daňové údaje||
|561|L|L561|změna třídy atributu||
|562|A|A562|28.8.2024||
|562|B|B562|1.0||
|562|D|D562|10035||
|562|E|E562|Úhrn vyplacených měsíčních daňových bonusů||
|562|F|F562|Souhrnná vrstva||
|562|G|G562|Daňové údaje||
|562|L|L562|změna třídy atributu||
|563|A|A563|28.8.2024||
|563|B|B563|1.0||
|563|D|D563|10036||
|563|E|E563|Úhrn přeplatků na dani a nedoplatků daně z ročního zúčtování||
|563|F|F563|Souhrnná vrstva||
|563|G|G563|Daňové údaje||
|563|L|L563|změna třídy atributu||
|564|A|A564|28.8.2024||
|564|B|B564|1.0||
|564|D|D564|10037||
|564|E|E564|Úhrn doplatků na daňových bonusech vyplacených zaměstnancům a vrácených přeplatků daňových bonusů  zaměstnanci z ročního zúčtování \nDoplatek na daňovém bonusu z ročního zúčtování||
|564|F|F564|Souhrnná vrstva||
|564|G|G564|Daňové údaje||
|564|L|L564|změna třídy atributu||
|565|A|A565|28.8.2024||
|565|B|B565|1.0||
|565|D|D565|10034||
|565|E|E565|Úhrn skutečně sražených záloh na dani po slevách||
|565|F|F565|Souhrnná vrstva||
|565|G|G565|Daňové údaje||
|565|L|L565|změna typu hlášení||
|566|A|A566|28.8.2024||
|566|B|B566|1.0||
|566|D|D566|10035||
|566|E|E566|Úhrn vyplacených měsíčních daňových bonusů||
|566|F|F566|Souhrnná vrstva||
|566|G|G566|Daňové údaje||
|566|L|L566|změna typu hlášení||
|567|A|A567|28.8.2024||
|567|B|B567|1.0||
|567|D|D567|10036||
|567|E|E567|Úhrn přeplatků na dani a nedoplatků daně z ročního zúčtování||
|567|F|F567|Souhrnná vrstva||
|567|G|G567|Daňové údaje||
|567|L|L567|změna typu hlášení||
|568|A|A568|28.8.2024||
|568|B|B568|1.0||
|568|D|D568|10037||
|568|E|E568|Úhrn doplatků na daňových bonusech vyplacených zaměstnancům a vrácených přeplatků daňových bonusů  zaměstnanci z ročního zúčtování \nDoplatek na daňovém bonusu z ročního zúčtování||
|568|F|F568|Souhrnná vrstva||
|568|G|G568|Daňové údaje||
|568|L|L568|změna typu hlášení||
|569|A|A569|6.9.2024||
|569|B|B569|1.0||
|569|D|D569|10215||
|569|E|E569|Název||
|569|F|F569|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|569|G|G569|Kolektivní smlouva k 31.12.||
|569|H|H569|Odborový svaz||
|569|L|L569|změna četnosti||
|570|A|A570|6.9.2024||
|570|B|B570|1.0||
|570|D|D570|10216||
|570|E|E570|Identifikační číslo||
|570|F|F570|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|570|G|G570|Kolektivní smlouva k 31.12.||
|570|H|H570|Odborový svaz||
|570|L|L570|změna četnosti||
|571|A|A571|6.9.2024||
|571|B|B571|1.0||
|571|D|D571|10217||
|571|E|E571|Název||
|571|F|F571|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|571|G|G571|Kolektivní smlouva k 31.12.||
|571|H|H571|Zaměstnavatelský svaz||
|571|L|L571|změna četnosti||
|572|A|A572|6.9.2024||
|572|B|B572|1.0||
|572|D|D572|10218||
|572|E|E572|Identifikační číslo||
|572|F|F572|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|572|G|G572|Kolektivní smlouva k 31.12.||
|572|H|H572|Zaměstnavatelský svaz||
|572|L|L572|změna četnosti||
|573|A|A573|6.9.2024||
|573|B|B573|1.0||
|573|D|D573|10431||
|573|E|E573|Jméno||
|573|F|F573|Příjem v daném měsíci||
|573|G|G573|Výpočet zálohy na daň||
|573|H|H573|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|573|L|L573|přidání atributu||
|574|A|A574|6.9.2024||
|574|B|B574|1.0||
|574|D|D574|10432||
|574|E|E574|Příjmení||
|574|F|F574|Příjem v daném měsíci||
|574|G|G574|Výpočet zálohy na daň||
|574|H|H574|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|574|L|L574|přidání atributu||
|575|A|A575|6.9.2024||
|575|B|B575|1.0||
|575|D|D575|10433||
|575|E|E575|Datum narození||
|575|F|F575|Příjem v daném měsíci||
|575|G|G575|Výpočet zálohy na daň||
|575|H|H575|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|575|L|L575|přidání atributu||
|576|A|A576|6.9.2024||
|576|B|B576|1.0||
|576|D|D576|10434||
|576|E|E576|Rodné číslo||
|576|F|F576|Příjem v daném měsíci||
|576|G|G576|Výpočet zálohy na daň||
|576|H|H576|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|576|L|L576|přidání atributu||
|577|A|A577|6.9.2024||
|577|B|B577|1.0||
|577|D|D577|10435||
|577|E|E577|Jméno||
|577|F|F577|Příjem v daném měsíci||
|577|G|G577|Výpočet zálohy na daň||
|577|H|H577|Vyživované děti||
|577|L|L577|přidání atributu||
|578|A|A578|6.9.2024||
|578|B|B578|1.0||
|578|D|D578|10436||
|578|E|E578|Příjmení||
|578|F|F578|Příjem v daném měsíci||
|578|G|G578|Výpočet zálohy na daň||
|578|H|H578|Vyživované děti||
|578|L|L578|přidání atributu||
|579|A|A579|6.9.2024||
|579|B|B579|1.0||
|579|D|D579|10437||
|579|E|E579|Datum narození||
|579|F|F579|Příjem v daném měsíci||
|579|G|G579|Výpočet zálohy na daň||
|579|H|H579|Vyživované děti||
|579|L|L579|přidání atributu||
|580|A|A580|6.9.2024||
|580|B|B580|1.0||
|580|D|D580|10438||
|580|E|E580|Rodné číslo||
|580|F|F580|Příjem v daném měsíci||
|580|G|G580|Výpočet zálohy na daň||
|580|H|H580|Vyživované děti||
|580|L|L580|přidání atributu||
|581|A|A581|6.9.2024||
|581|B|B581|1.0||
|581|D|D581|10439||
|581|E|E581|Průkaz ZTP/P||
|581|F|F581|Příjem v daném měsíci||
|581|G|G581|Výpočet zálohy na daň||
|581|H|H581|Vyživované děti||
|581|L|L581|přidání atributu||
|582|A|A582|6.9.2024||
|582|B|B582|1.0||
|582|D|D582|10440||
|582|E|E582|Pořadí pro určení výše daňového zvýhodnění||
|582|F|F582|Příjem v daném měsíci||
|582|G|G582|Výpočet zálohy na daň||
|582|H|H582|Vyživované děti||
|582|L|L582|přidání atributu||
|583|A|A583|6.9.2024||
|583|B|B583|1.0||
|583|D|D583|10441||
|583|E|E583|Jméno||
|583|F|F583|Příjem v daném měsíci||
|583|G|G583|Výsledek ročního zúčtování||
|583|H|H583|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|583|L|L583|přidání atributu||
|584|A|A584|6.9.2024||
|584|B|B584|1.0||
|584|D|D584|10442||
|584|E|E584|Příjmení||
|584|F|F584|Příjem v daném měsíci||
|584|G|G584|Výsledek ročního zúčtování||
|584|H|H584|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|584|L|L584|přidání atributu||
|585|A|A585|6.9.2024||
|585|B|B585|1.0||
|585|D|D585|10443||
|585|E|E585|Datum narození||
|585|F|F585|Příjem v daném měsíci||
|585|G|G585|Výsledek ročního zúčtování||
|585|H|H585|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|585|L|L585|přidání atributu||
|586|A|A586|6.9.2024||
|586|B|B586|1.0||
|586|D|D586|10444||
|586|E|E586|Rodné číslo||
|586|F|F586|Příjem v daném měsíci||
|586|G|G586|Výsledek ročního zúčtování||
|586|H|H586|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|586|L|L586|přidání atributu||
|587|A|A587|6.9.2024||
|587|B|B587|1.0||
|587|D|D587|10445||
|587|E|E587|Měsíce vyživování||
|587|F|F587|Příjem v daném měsíci||
|587|G|G587|Výsledek ročního zúčtování||
|587|H|H587|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|587|L|L587|přidání atributu||
|588|A|A588|6.9.2024||
|588|B|B588|1.0||
|588|D|D588|10446||
|588|E|E588|Jméno||
|588|F|F588|Příjem v daném měsíci||
|588|G|G588|Výsledek ročního zúčtování||
|588|H|H588|Vyživované děti||
|588|L|L588|přidání atributu||
|589|A|A589|6.9.2024||
|589|B|B589|1.0||
|589|D|D589|10447||
|589|E|E589|Příjmení||
|589|F|F589|Příjem v daném měsíci||
|589|G|G589|Výsledek ročního zúčtování||
|589|H|H589|Vyživované děti||
|589|L|L589|přidání atributu||
|590|A|A590|6.9.2024||
|590|B|B590|1.0||
|590|D|D590|10448||
|590|E|E590|Datum narození||
|590|F|F590|Příjem v daném měsíci||
|590|G|G590|Výsledek ročního zúčtování||
|590|H|H590|Vyživované děti||
|590|L|L590|přidání atributu||
|591|A|A591|6.9.2024||
|591|B|B591|1.0||
|591|D|D591|10449||
|591|E|E591|Rodné číslo||
|591|F|F591|Příjem v daném měsíci||
|591|G|G591|Výsledek ročního zúčtování||
|591|H|H591|Vyživované děti||
|591|L|L591|přidání atributu||
|592|A|A592|6.9.2024||
|592|B|B592|1.0||
|592|D|D592|10450||
|592|E|E592|Průkaz ZTP/P v jednotlivých měsících||
|592|F|F592|Příjem v daném měsíci||
|592|G|G592|Výsledek ročního zúčtování||
|592|H|H592|Vyživované děti||
|592|L|L592|přidání atributu||
|593|A|A593|6.9.2024||
|593|B|B593|1.0||
|593|D|D593|10451||
|593|E|E593|Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících||
|593|F|F593|Příjem v daném měsíci||
|593|G|G593|Výsledek ročního zúčtování||
|593|H|H593|Vyživované děti||
|593|L|L593|přidání atributu||
|594|A|A594|10.9.2024||
|594|B|B594|1.0||
|594|D|D594|10452||
|594|E|E594|Podíl osob se zdravotním postižením na celkovém počtu zaměstnanců||
|594|F|F594|Souhrnná vrstva||
|594|G|G594|Plnění povinného podílu zaměstnávání OZP||
|594|L|L594|přidání atributu||
|595|A|A595|10.9.2024||
|595|B|B595|1.0||
|595|D|D595|10311||
|595|E|E595|Příjmy podléhající srážkové dani podle zvláštní sazby daně vyplacené nebo obdržené do 31.1. následujícího roku||
|595|F|F595|Příjem v daném měsíci||
|595|G|G595|Roční úhrny jednotlivých položek||
|595|L|L595|přejmenování atributu||
|596|A|A596|11.9.2024||
|596|B|B596|1.0||
|596|D|D596|10453||
|596|E|E596|Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba||
|596|F|F596|Příjem v daném měsíci||
|596|G|G596|Výpočet zálohy na daň||
|596|H|H596|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|596|L|L596|přidání atributu||
|597|A|A597|11.9.2024||
|597|B|B597|1.0||
|597|D|D597|10454||
|597|E|E597|Uplatněno daňové zvýhodnění na děti ||
|597|F|F597|Příjem v daném měsíci||
|597|G|G597|Výsledek ročního zúčtování||
|597|H|H597|Daňové zvýhodnění na děti||
|597|L|L597|přidání atributu||
|598|A|A598|11.9.2024||
|598|B|B598|1.0||
|598|D|D598|10455||
|598|E|E598|Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba||
|598|F|F598|Příjem v daném měsíci||
|598|G|G598|Výsledek ročního zúčtování||
|598|H|H598|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|598|L|L598|přidání atributu||
|599|A|A599|12.9.2024||
|599|B|B599|1.0||
|599|D|D599|10390||
|599|E|E599|Pořadí dítěte||
|599|F|F599|Informace o dětech, na které je uplatňováno daňové zvýhodnění v daném měsíci||
|599|G|G599|Pořadí||
|599|L|L599|odstranění atributu||
|600|A|A600|12.9.2024||
|600|B|B600|1.0||
|600|D|D600|10391||
|600|E|E600|Jméno||
|600|F|F600|Informace o dětech, na které je uplatňováno daňové zvýhodnění v daném měsíci||
|600|G|G600|Identifikace||
|600|L|L600|odstranění atributu||
|601|A|A601|12.9.2024||
|601|B|B601|1.0||
|601|D|D601|10392||
|601|E|E601|Příjmení||
|601|F|F601|Informace o dětech, na které je uplatňováno daňové zvýhodnění v daném měsíci||
|601|G|G601|Identifikace||
|601|L|L601|odstranění atributu||
|602|A|A602|12.9.2024||
|602|B|B602|1.0||
|602|D|D602|10393||
|602|E|E602|Rodné číslo||
|602|F|F602|Informace o dětech, na které je uplatňováno daňové zvýhodnění v daném měsíci||
|602|G|G602|Identifikace||
|602|L|L602|odstranění atributu||
|603|A|A603|12.9.2024||
|603|B|B603|1.0||
|603|D|D603|10394||
|603|E|E603|Datum narození||
|603|F|F603|Informace o dětech, na které je uplatňováno daňové zvýhodnění v daném měsíci||
|603|G|G603|Identifikace||
|603|L|L603|odstranění atributu||
|604|A|A604|12.9.2024||
|604|B|B604|1.0||
|604|D|D604|10395||
|604|E|E604|Průkaz ZTP/P||
|604|F|F604|Informace o dětech, na které je uplatňováno daňové zvýhodnění v daném měsíci||
|604|G|G604|Status invalidity||
|604|L|L604|odstranění atributu||
|605|A|A605|16.9.2024||
|605|B|B605|1.0||
|605|D|D605|10290||
|605|E|E605|Osvobozené příjmy ze zúčtovaných příjmů - z toho peněžní příjmy||
|605|F|F605|Příjem v daném měsíci||
|605|G|G605|Příjem||
|605|L|L605|odstranění atributu||
|606|A|A606|16.9.2024||
|606|B|B606|1.0||
|606|D|D606|10291||
|606|E|E606|Osvobozené příjmy ze zúčtovaných příjmů - z toho nepeněžní příjmy / naturální mzda||
|606|F|F606|Příjem v daném měsíci||
|606|G|G606|Příjem||
|606|L|L606|odstranění atributu||
|607|A|A607|16.9.2024||
|607|B|B607|1.0||
|607|D|D607|10308||
|607|E|E607|Odměna člena (nerezidenta) orgánu právnické osoby||
|607|F|F607|Příjem v daném měsíci||
|607|G|G607|Výpočet daně podle zvláštní sazby daně ||
|607|L|L607|odstranění atributu||
|608|A|A608|16.9.2024||
|608|B|B608|1.0||
|608|D|D608|10310||
|608|E|E608|Sražená daň podle zvláštní sazby daně z příjmu nerezidenta člena orgánu právnické osoby||
|608|F|F608|Příjem v daném měsíci||
|608|G|G608|Výpočet daně podle zvláštní sazby daně ||
|608|L|L608|odstranění atributu||
|609|A|A609|18.9.2024||
|609|B|B609|1.0||
|609|D|D609|10194||
|609|E|E609|Počet zaměstnanců, pro které účtárna vede evidenci mezd ke dni jejího přihlášení||
|609|F|F609|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|609|G|G609|Mzdová účtárna zaměstnavatele||
|609|L|L609|přejmenování atributu||
|610|A|A610|18.9.2024||
|610|B|B610|1.0||
|610|D|D610|10194||
|610|E|E610|Počet zaměstnanců, pro které účtárna vede evidenci mezd ke dni jejího přihlášení||
|610|F|F610|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|610|G|G610|Mzdová účtárna zaměstnavatele||
|610|L|L610|změna datového typu||
|611|A|A611|18.9.2024||
|611|B|B611|1.0||
|611|D|D611|10456||
|611|E|E611|Okruh zaměstnanců, pro které účtárna vede evidenci mezd ke dni jejího přihlášení||
|611|F|F611|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|611|G|G611|Mzdová účtárna zaměstnavatele||
|611|L|L611|přidání atributu||
|612|A|A612|18.9.2024||
|612|B|B612|1.0||
|612|D|D612|10457||
|612|E|E612|Rodné číslo uživatele||
|612|F|F612|Vykonávaná pozice zaměstnance||
|612|G|G612|Forma práce||
|612|H|H612|Dočasné přidělení||
|612|L|L612|přidání atributu||
|613|A|A613|24.9.2024||
|613|B|B613|1.0||
|613|D|D613|10008||
|613|E|E613|Typ akce||
|613|F|F613|Meta atributy||
|613|G|G613|Podání||
|613|L|L613|úprava číselníku||
|614|A|A614|27.9.2024||
|614|B|B614|1.0||
|614|D|D614|10075||
|614|E|E614|Typ adresy||
|614|F|F614|Zaměstnanec / Žák / Student ||
|614|G|G614|Adresa||
|614|L|L614|úprava číselníku||
|615|A|A615|27.9.2024||
|615|B|B615|1.0||
|615|D|D615|10237||
|615|E|E615|Pozice vykonávana do||
|615|F|F615|Vykonávaná pozice zaměstnance||
|615|G|G615|Pracovní místo / pozice||
|615|L|L615|odstranění atributu||
|615|M|M615|na základě konzultace s ČSÚ odstraněno pro přebytečnost||
|616|A|A616|27.9.2024||
|616|B|B616|1.0||
|616|D|D616|10253||
|616|E|E616|Sjednaná doba||
|616|F|F616|Vykonávaná pozice zaměstnance||
|616|G|G616|Forma práce||
|616|L|L616|odstranění atributu||
|616|M|M616|informace je obsažena číselníkem CZ-ICSE u jiného atributu||
|617|A|A617|1.10.2024||
|617|B|B617|1.0||
|617|D|D617|10458||
|617|E|E617|VČP původního zaměstnavatele||
|617|F|F617|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|617|G|G617|Vznik||
|617|H|H617|Právní nástupnictví||
|617|L|L617|přidání atributu||
|617|M|M617|konsolidace s datovou větou||
|618|A|A618|8.10.2024||
|618|B|B618|1.1||
|618|C|C618|ZP004||
|618|D|D618|10243||
|618|E|E618|Zaměstnání malého rozsahu||
|618|F|F618|Vykonávaná pozice zaměstnance||
|618|G|G618|Činnost||
|618|H|H618|ELDP||
|618|J|J618|x||
|618|K|K618|x||
|618|L|L618|změna typu hlášení||
|618|M|M618|měsíční -> registrace zaměstnance||
|619|A|A619|8.10.2024||
|619|B|B619|1.1||
|619|C|C619|ZP004||
|619|D|D619|10008||
|619|E|E619|Typ akce||
|619|F|F619|Meta atributy||
|619|G|G619|Podání||
|619|J|J619|x||
|619|L|L619|úprava číselníku||
|619|M|M619|úprava kódů v číselníku podle zjištění Aricomy||
|620|A|A620|8.10.2024||
|620|B|B620|1.1||
|620|C|C620|ZP004||
|620|D|D620|10101||
|620|E|E620|Sektor (účel pojištění)||
|620|F|F620|Zaměstnanec / Žák / Student ||
|620|G|G620|Pojištění||
|620|H|H620|Cizozemský nositel pojištění||
|620|J|J620|x||
|620|L|L620|úprava číselníku||
|620|M|M620|přejmenování položky s id = 8||
|621|A|A621|11.10.2024||
|621|B|B621|1.1||
|621|C|C621|ZP004||
|621|D|D621|10101||
|621|E|E621|Sektor (účel pojištění)||
|621|F|F621|Zaměstnanec / Žák / Student ||
|621|G|G621|Pojištění||
|621|H|H621|Cizozemský nositel pojištění||
|621|J|J621|x||
|621|L|L621|úprava číselníku||
|621|M|M621|úprava kódů položek||
|622|A|A622|16.10.2024||
|622|B|B622|1.1||
|622|C|C622|ZP004||
|622|D|D622|10263||
|622|E|E622|Datum od||
|622|F|F622|Průběh studia (teoretické a praktické přípravy)||
|622|K|K622|x||
|622|L|L622|změna četnosti||
|622|M|M622|změna na vícečetný atribut||
|623|A|A623|16.10.2024||
|623|B|B623|1.1||
|623|C|C623|ZP004||
|623|D|D623|10264||
|623|E|E623|Datum do||
|623|F|F623|Průběh studia (teoretické a praktické přípravy)||
|623|K|K623|x||
|623|L|L623|změna četnosti||
|623|M|M623|změna na vícečetný atribut||
|624|A|A624|17.10.2024||
|624|B|B624|1.1||
|624|C|C624|ZP004||
|624|D|D624|10081||
|624|E|E624|Kód obce||
|624|F|F624|Zaměstnanec / Žák / Student ||
|624|G|G624|Adresa||
|624|J|J624|x||
|624|L|L624|odstranění atributu||
|624|M|M624|položka nebyla dohledána ve vyhlášce 117/2024, ostatní konzumenti již nepožadují||
|625|A|A625|18.10.2024||
|625|B|B625|1.1||
|625|C|C625|ZP001||
|625|D|D625|10388||
|625|E|E625|Vypláceno ÚP/Dodavatel||
|625|F|F625|Mzdové nároky||
|625|G|G625|Úřad práce||
|625|K|K625|x||
|625|L|L625|odstranění atributu||
|625|M|M625|odstraněno na základě změny pojetí oblasti kvazizaměstnavatelů||
|626|A|A626|18.10.2024||
|626|B|B626|1.1||
|626|C|C626|ZP001||
|626|D|D626|10389||
|626|E|E626|Výplaty a zdanění ÚP/Dodavatel||
|626|F|F626|Mzdové nároky||
|626|G|G626|Úřad práce||
|626|K|K626|x||
|626|L|L626|odstranění atributu||
|626|M|M626|odstraněno na základě změny pojetí oblasti kvazizaměstnavatelů||
|627|A|A627|18.10.2024||
|627|B|B627|1.1||
|627|C|C627|ZP001||
|627|D|D627|10402||
|627|E|E627|Název subjektu, za který je plněno||
|627|F|F627|Mzdové nároky||
|627|G|G627|Úřad práce||
|627|K|K627|x||
|627|L|L627|odstranění atributu||
|627|M|M627|odstraněno na základě změny pojetí oblasti kvazizaměstnavatelů||
|628|A|A628|18.10.2024||
|628|B|B628|1.1||
|628|C|C628|ZP001||
|628|D|D628|10403||
|628|E|E628|IČO subjektu, za který je plněno||
|628|F|F628|Mzdové nároky||
|628|G|G628|Úřad práce||
|628|K|K628|x||
|628|L|L628|odstranění atributu||
|628|M|M628|odstraněno na základě změny pojetí oblasti kvazizaměstnavatelů||
|629|A|A629|5.11.2024||
|629|B|B629|1.1||
|629|C|C629|ZP005||
|629|D|D629|10105||
|629|E|E629|Oprávnění pro výkon pracovní činnosti||
|629|F|F629|Zaměstnanec / Žák / Student ||
|629|G|G629|Zaměstnanec bez státního občanství ČR||
|629|J|J629|x||
|629|L|L629|úprava číselníku||
|629|M|M629|revize kódů na základě konzultace s Aricomou||
|630|A|A630|5.11.2024||
|630|B|B630|1.1||
|630|C|C630|ZP004||
|630|D|D630|10459||
|630|E|E630|Platnost změny kódu státu rezidentství od||
|630|F|F630|Zaměstnanec / Žák / Student ||
|630|G|G630|Daňová identifikace ve státě rezidence||
|630|J|J630|x||
|630|L|L630|přidání atributu||
|630|M|M630|na základě potřeby FS||
|631|A|A631|5.11.2024||
|631|B|B631|1.1||
|631|C|C631|ZP005||
|631|D|D631|10034||
|631|E|E631|Úhrn skutečně sražených záloh na dani po slevách||
|631|F|F631|Souhrnná vrstva||
|631|G|G631|Daňové údaje||
|631|K|K631|x||
|631|L|L631|změna periodicity hlášení||
|631|M|M631|specifické měsíce x010203 -> všechny měsíce (na základě rozhodnutí FS)||
|632|A|A632|5.11.2024||
|632|B|B632|1.1||
|632|C|C632|ZP005||
|632|D|D632|10035||
|632|E|E632|Úhrn vyplacených měsíčních daňových bonusů||
|632|F|F632|Souhrnná vrstva||
|632|G|G632|Daňové údaje||
|632|K|K632|x||
|632|L|L632|změna periodicity hlášení||
|632|M|M632|specifické měsíce x010203 -> všechny měsíce (na základě rozhodnutí FS)||
|633|A|A633|6.11.2024||
|633|B|B633|1.1||
|633|C|C633|ZP004||
|633|D|D633|10134||
|633|E|E633|Kód obce||
|633|F|F633|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|633|G|G633|Adresa||
|633|I|I633|x||
|633|L|L633|odstranění atributu||
|633|M|M633|odstraněno po konzultaci s Aricomou||
|634|A|A634|6.11.2024||
|634|B|B634|1.1||
|634|C|C634|ZP004||
|634|D|D634|10156||
|634|E|E634|Kód obce||
|634|F|F634|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|634|G|G634|Archivace dokladů||
|634|H|H634|Adresa||
|634|I|I634|x||
|634|L|L634|odstranění atributu||
|634|M|M634|odstraněno po konzultaci s Aricomou||
|635|A|A635|6.11.2024||
|635|B|B635|1.1||
|635|C|C635|ZP004||
|635|D|D635|10170||
|635|E|E635|Kód obce||
|635|F|F635|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|635|G|G635|Právní nástupnictví při zániku||
|635|H|H635|Adresa||
|635|I|I635|x||
|635|L|L635|odstranění atributu||
|635|M|M635|odstraněno po konzultaci s Aricomou||
|636|A|A636|6.11.2024||
|636|B|B636|1.1||
|636|C|C636|ZP004||
|636|D|D636|10179||
|636|E|E636|Kód obce||
|636|F|F636|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|636|G|G636|Právní nástupnictví při zániku||
|636|H|H636|Mzdová účtárna||
|636|I|I636|x||
|636|L|L636|odstranění atributu||
|636|M|M636|odstraněno po konzultaci s Aricomou||
|637|A|A637|6.11.2024||
|637|B|B637|1.1||
|637|C|C637|ZP004||
|637|D|D637|10191||
|637|E|E637|Kód obce||
|637|F|F637|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|637|G|G637|Mzdová účtárna zaměstnavatele||
|637|H|H637|Adresa||
|637|I|I637|x||
|637|L|L637|odstranění atributu||
|637|M|M637|odstraněno po konzultaci s Aricomou||
|638|A|A638|6.11.2024||
|638|B|B638|1.1||
|638|C|C638|ZP004||
|638|D|D638|10207||
|638|E|E638|Kód obce||
|638|F|F638|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|638|G|G638|Peněžní účty||
|638|H|H638|Peněžní ústav||
|638|I|I638|x||
|638|L|L638|odstranění atributu||
|638|M|M638|odstraněno po konzultaci s Aricomou||
|639|A|A639|7.11.2024||
|639|B|B639|1.1||
|639|C|C639|ZP004||
|639|D|D639|10202||
|639|E|E639|Kód adresního místa||
|639|F|F639|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|639|G|G639|Peněžní účty||
|639|H|H639|Peněžní ústav||
|639|I|I639|x||
|639|L|L639|odstranění atributu||
|639|M|M639|odstraněno po konzultaci s Aricomou||
|640|A|A640|7.11.2024||
|640|B|B640|1.1||
|640|C|C640|ZP004||
|640|D|D640|10196||
|640|E|E640|Variabilní symbol mzdové účtárny||
|640|F|F640|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|640|G|G640|Mzdová účtárna zaměstnavatele||
|640|I|I640|x||
|640|L|L640|odstranění atributu||
|640|M|M640|sloučeno do obecného atributu Variabilní symbol po konzultaci s Aricomou||
|641|A|A641|7.11.2024||
|641|B|B641|1.1||
|641|C|C641|ZP004||
|641|D|D641|10221||
|641|E|E641|Variabilní symbol||
|641|F|F641|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|641|I|I641|x||
|641|L|L641|přejmenování atributu||
|641|M|M641|zobecnění atributu po konzultaci s Aricomou||
|642|A|A642|8.11.2024||
|642|B|B642|1.1||
|642|C|C642|ZP004||
|642|D|D642|10060||
|642|E|E642|VČP||
|642|F|F642|Zaměstnanec / Žák / Student ||
|642|G|G642|Základní identifikace||
|642|J|J642|x||
|642|L|L642|změna datového typu||
|642|M|M642|text -> číslo (unifikace s datovými typy Aricomy)||
|643|A|A643|8.11.2024||
|643|B|B643|1.1||
|643|C|C643|ZP004||
|643|D|D643|10123||
|643|E|E643|VČP||
|643|F|F643|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|643|G|G643|Identifikace||
|643|I|I643|x||
|643|L|L643|změna datového typu||
|643|M|M643|text -> číslo (unifikace s datovými typy Aricomy)||
|644|A|A644|8.11.2024||
|644|B|B644|1.1||
|644|C|C644|ZP004||
|644|D|D644|10062||
|644|E|E644|Daňový identifikátor ve státě rezidence||
|644|F|F644|Zaměstnanec / Žák / Student ||
|644|G|G644|Daňová identifikace ve státě rezidence||
|644|J|J644|x||
|644|L|L644|změna datového typu||
|644|M|M644|číslo -> text (unifikace s datovými typy Aricomy)||
|645|A|A645|8.11.2024||
|645|B|B645|1.1||
|645|C|C645|ZP004||
|645|D|D645|10070||
|645|E|E645|Číslo dokladu||
|645|F|F645|Zaměstnanec / Žák / Student ||
|645|G|G645|Prokázání totožnosti||
|645|H|H645|Doklad||
|645|J|J645|x||
|645|L|L645|změna datového typu||
|645|M|M645|číslo -> text (unifikace s datovými typy Aricomy)||
|646|A|A646|10.11.2024||
|646|B|B646|1.1||
|646|C|C646|ZP005||
|646|D|D646|10372||
|646|E|E646|Sleva na pojistném||
|646|F|F646|Průběh pojištění v daném měsíci||
|646|G|G646|Sleva na pojistném||
|646|K|K646|x||
|646|L|L646|přejmenování atributu||
|646|M|M646|přejmenování na žádost ČSSZ||
|647|A|A647|12.11.2024||
|647|B|B647|1.1||
|647|C|C647|ZP004||
|647|D|D647|10117||
|647|E|E647|Přihlášení dne||
|647|F|F647|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|647|I|I647|x||
|647|L|L647|přejmenování atributu||
|647|M|M647|přejmenování v rámci sloučení atributů registrace a vzniku zaměstnavatele na základě rozhodnutí ČSSZ||
|648|A|A648|12.11.2024||
|648|B|B648|1.1||
|648|C|C648|ZP004||
|648|D|D648|10142||
|648|E|E648|Datum||
|648|F|F648|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|648|G|G648|Vznik||
|648|I|I648|x||
|648|L|L648|odstranění atributu||
|648|M|M648|odstranění v rámci sloučení atributů registrace a vzniku zaměstnavatele na základě rozhodnutí ČSSZ||
|649|A|A649|13.11.2024||
|649|B|B649|1.1||
|649|C|C649|ZP005||
|649|D|D649|10201||
|649|E|E649|Název peněžního ústavu||
|649|F|F649|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|649|G|G649|Peněžní účty||
|649|H|H649|Peněžní ústav||
|649|I|I649|x||
|649|L|L649|přejmenování atributu||
|649|M|M649|přejmenování na žádost FS||
|650|A|A650|13.11.2024||
|650|B|B650|1.1||
|650|C|C650|ZP005||
|650|D|D650|10408||
|650|E|E650|Specifická právní skutečnost||
|650|F|F650|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|650|G|G650|Rozhodná skutečnost||
|650|K|K650|x||
|650|L|L650|přejmenování atributu||
|650|M|M650|přejmenování na žádost FS||
|651|A|A651|13.11.2024||
|651|B|B651|1.1||
|651|C|C651|ZP005||
|651|D|D651|10409||
|651|E|E651|Datum nastání specifické právní skutečnosti||
|651|F|F651|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|651|G|G651|Rozhodná skutečnost||
|651|K|K651|x||
|651|L|L651|přejmenování atributu||
|651|M|M651|přejmenování na žádost FS||
|652|A|A652|13.11.2024||
|652|B|B652|1.1||
|652|C|C652|ZP005||
|652|D|D652|10410||
|652|E|E652|Výplatní termín při nastání specifické právní skutečnosti||
|652|F|F652|Příjem v daném měsíci||
|652|G|G652|Rozhodná skutečnost||
|652|K|K652|x||
|652|L|L652|přejmenování atributu||
|652|M|M652|přejmenování na žádost FS||
|653|A|A653|13.11.2024||
|653|B|B653|1.1||
|653|C|C653|ZP005||
|653|D|D653|10408||
|653|E|E653|Specifická právní skutečnost||
|653|F|F653|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|653|G|G653|Specifická právní skutečnost||
|653|K|K653|x||
|653|L|L653|změna třídy atributu||
|653|M|M653|změna třídy na žádost FS||
|654|A|A654|13.11.2024||
|654|B|B654|1.1||
|654|C|C654|ZP005||
|654|D|D654|10409||
|654|E|E654|Datum nastání specifické právní skutečnosti||
|654|F|F654|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|654|G|G654|Specifická právní skutečnost||
|654|K|K654|x||
|654|L|L654|změna třídy atributu||
|654|M|M654|změna třídy na žádost FS||
|655|A|A655|13.11.2024||
|655|B|B655|1.1||
|655|C|C655|ZP005||
|655|D|D655|10410||
|655|E|E655|Výplatní termín při nastání specifické právní skutečnosti||
|655|F|F655|Příjem v daném měsíci||
|655|G|G655|Specifická právní skutečnost||
|655|K|K655|x||
|655|L|L655|změna třídy atributu||
|655|M|M655|změna třídy na žádost FS||
|656|A|A656|13.11.2024||
|656|B|B656|1.1||
|656|C|C656|ZP005||
|656|D|D656|10007||
|656|E|E656|Typ podání||
|656|F|F656|Meta atributy||
|656|G|G656|Podání||
|656|K|K656|x||
|656|L|L656|úprava číselníku||
|656|M|M656|odstranění technické hodnoty Zneplatněné po komentáři ze strany FS||
|657|A|A657|13.11.2024||
|657|B|B657|1.1||
|657|C|C657|ZP005||
|657|D|D657|10016||
|657|E|E657|Typ formuláře||
|657|F|F657|Meta atributy||
|657|G|G657|Formulář||
|657|J|J657|x||
|657|K|K657|x||
|657|L|L657|úprava číselníku||
|657|M|M657|odstranění technické hodnoty Zneplatněný po komentáři ze strany FS||
|658|A|A658|13.11.2024||
|658|B|B658|1.1||
|658|C|C658|ZP005||
|658|D|D658|10068||
|658|E|E658|Kód státu rezidenství||
|658|F|F658|Zaměstnanec / Žák / Student ||
|658|G|G658|Daňová identifikace ve státě rezidence||
|658|K|K658|x||
|658|L|L658|změna typu hlášení||
|658|M|M658|přidání atributu do měsíčního hlášení s poznámkou po komentáři ze strany FS||
|659|A|A659|13.11.2024||
|659|B|B659|1.1||
|659|C|C659|ZP005||
|659|D|D659|10282||
|659|E|E659|Důvod - zaměstnanec||
|659|F|F659|Průběh zaměstnání v daném měsíci||
|659|G|G659|Překážky v práci||
|659|K|K659|x||
|659|L|L659|úprava číselníku||
|659|M|M659|na základě požadavku ČSÚ||
|660|A|A660|13.11.2024||
|660|B|B660|1.1||
|660|C|C660|ZP005||
|660|D|D660|10460||
|660|E|E660|Odvětví||
|660|F|F660|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|660|G|G660|Ekonomická činnost||
|660|L|L660|přidání atributu||
|660|M|M660|přidání dříve odebraného atributu na základě připomínky ČSÚ a konzultace s architekturou||
|661|A|A661|14.11.2024||
|661|B|B661|1.1||
|661|C|C661|ZP005||
|661|D|D661|10328||
|661|E|E661|Mzda za práci zúčtovaná||
|661|F|F661|Příjem v daném měsíci||
|661|G|G661|Mzda||
|661|K|K661|x||
|661|L|L661|přejmenování atributu||
|661|M|M661|na základě požadavku ČSÚ||
|662|A|A662|14.11.2024||
|662|B|B662|1.1||
|662|C|C662|ZP004||
|662|D|D662|10461||
|662|E|E662|AIFO||
|662|F|F662|Zaměstnanec / Žák / Student ||
|662|G|G662|Základní identifikace||
|662|J|J662|x||
|662|L|L662|přidání atributu||
|662|M|M662|přidání atributu na základě změny architektonického pojetí||
|663|A|A663|14.11.2024||
|663|B|B663|1.1||
|663|C|C663|ZP005||
|663|D|D663|10018||
|663|E|E663|Důvod odmítnutí||
|663|F|F663|Meta atributy||
|663|G|G663|Formulář||
|663|J|J663|x||
|663|K|K663|x||
|663|L|L663|úprava číselníku||
|663|M|M663|doplnění číselníku ze strany Eviden||
|664|A|A664|14.11.2024||
|664|B|B664|1.1||
|664|C|C664|ZP005||
|664|D|D664|10398||
|664|E|E664|Formát souboru||
|664|F|F664|Příloha||
|664|J|J664|x||
|664|L|L664|odstranění atributu||
|664|M|M664|odstraněno po konzultaci s Aricomou||
|665|A|A665|14.11.2024||
|665|B|B665|1.1||
|665|C|C665|ZP005||
|665|D|D665|10358||
|665|E|E665|Počet dnů trvání dočasné pracovní neschopnosti (karanténa)||
|665|F|F665|Průběh pojištění v daném měsíci||
|665|G|G665|Vyloučené dny||
|665|K|K665|x||
|665|L|L665|přejmenování atributu||
|665|M|M665|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|666|A|A666|14.11.2024||
|666|B|B666|1.1||
|666|C|C666|ZP005||
|666|D|D666|10359||
|666|E|E666|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|666|F|F666|Průběh pojištění v daném měsíci||
|666|G|G666|Vyloučené dny||
|666|K|K666|x||
|666|L|L666|přejmenování atributu||
|666|M|M666|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|667|A|A667|14.11.2024||
|667|B|B667|1.1||
|667|C|C667|ZP005||
|667|D|D667|10361||
|667|E|E667|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné ||
|667|F|F667|Průběh pojištění v daném měsíci||
|667|G|G667|Vyloučené dny||
|667|K|K667|x||
|667|L|L667|odstranění atributu||
|667|M|M667|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|668|A|A668|14.11.2024||
|668|B|B668|1.1||
|668|C|C668|ZP005||
|668|D|D668|10363||
|668|E|E668|Počet dnů rodičovské dovolené||
|668|F|F668|Průběh pojištění v daném měsíci||
|668|G|G668|Vyloučené dny||
|668|K|K668|x||
|668|L|L668|odstranění atributu||
|668|M|M668|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|669|A|A669|14.11.2024||
|669|B|B669|1.1||
|669|C|C669|ZP005||
|669|D|D669|10364||
|669|E|E669|Počet dnů čerpání neplaceného volna||
|669|F|F669|Průběh pojištění v daném měsíci||
|669|G|G669|Vyloučené dny||
|669|K|K669|x||
|669|L|L669|odstranění atributu||
|669|M|M669|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|670|A|A670|14.11.2024||
|670|B|B670|1.1||
|670|C|C670|ZP005||
|670|D|D670|10365||
|670|E|E670|Počet dnů neomluvené absence||
|670|F|F670|Průběh pojištění v daném měsíci||
|670|G|G670|Vyloučené dny||
|670|K|K670|x||
|670|L|L670|odstranění atributu||
|670|M|M670|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|671|A|A671|14.11.2024||
|671|B|B671|1.1||
|671|C|C671|ZP005||
|671|D|D671|10462||
|671|E|E671|Počet dnů trvání dočasné pracovní neschopnosti (karanténa)||
|671|F|F671|Průběh pojištění v daném měsíci||
|671|G|G671|Odečítané dny||
|671|K|K671|x||
|671|L|L671|přidání atributu||
|671|M|M671|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|672|A|A672|14.11.2024||
|672|B|B672|1.1||
|672|C|C672|ZP005||
|672|D|D672|10463||
|672|E|E672|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|672|F|F672|Průběh pojištění v daném měsíci||
|672|G|G672|Odečítané dny||
|672|K|K672|x||
|672|L|L672|přidání atributu||
|672|M|M672|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|673|A|A673|14.11.2024||
|673|B|B673|1.1||
|673|C|C673|ZP005||
|673|D|D673|10464||
|673|E|E673|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|673|F|F673|Průběh pojištění v daném měsíci||
|673|G|G673|Odečítané dny||
|673|K|K673|x||
|673|L|L673|přidání atributu||
|673|M|M673|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|674|A|A674|14.11.2024||
|674|B|B674|1.1||
|674|C|C674|ZP005||
|674|D|D674|10465||
|674|E|E674|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné ||
|674|F|F674|Průběh pojištění v daném měsíci||
|674|G|G674|Odečítané dny||
|674|K|K674|x||
|674|L|L674|přidání atributu||
|674|M|M674|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|675|A|A675|14.11.2024||
|675|B|B675|1.1||
|675|C|C675|ZP005||
|675|D|D675|10466||
|675|E|E675|Počet dnů čerpání otcovské||
|675|F|F675|Průběh pojištění v daném měsíci||
|675|G|G675|Odečítané dny||
|675|K|K675|x||
|675|L|L675|přidání atributu||
|675|M|M675|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|676|A|A676|14.11.2024||
|676|B|B676|1.1||
|676|C|C676|ZP005||
|676|D|D676|10467||
|676|E|E676|Počet dnů rodičovské dovolené||
|676|F|F676|Průběh pojištění v daném měsíci||
|676|G|G676|Odečítané dny||
|676|K|K676|x||
|676|L|L676|přidání atributu||
|676|M|M676|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|677|A|A677|14.11.2024||
|677|B|B677|1.1||
|677|C|C677|ZP005||
|677|D|D677|10468||
|677|E|E677|Počet dnů čerpání neplaceného volna||
|677|F|F677|Průběh pojištění v daném měsíci||
|677|G|G677|Odečítané dny||
|677|K|K677|x||
|677|L|L677|přidání atributu||
|677|M|M677|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|678|A|A678|14.11.2024||
|678|B|B678|1.1||
|678|C|C678|ZP005||
|678|D|D678|10469||
|678|E|E678|Počet dnů neomluvené absence||
|678|F|F678|Průběh pojištění v daném měsíci||
|678|G|G678|Odečítané dny||
|678|K|K678|x||
|678|L|L678|přidání atributu||
|678|M|M678|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|679|A|A679|14.11.2024||
|679|B|B679|1.1||
|679|C|C679|ZP005||
|679|D|D679|10263||
|679|E|E679|Datum od||
|679|F|F679|Průběh teoretické a praktické přípravy||
|679|K|K679|x||
|679|L|L679|přejmenování oblasti atributu||
|679|M|M679|na základě požadavku ČSSZ||
|680|A|A680|14.11.2024||
|680|B|B680|1.1||
|680|C|C680|ZP005||
|680|D|D680|10264||
|680|E|E680|Datum do||
|680|F|F680|Průběh teoretické a praktické přípravy||
|680|K|K680|x||
|680|L|L680|přejmenování oblasti atributu||
|680|M|M680|na základě požadavku ČSSZ||
|681|A|A681|19.11.2024||
|681|B|B681|1.1||
|681|C|C681|ZP004||
|681|D|D681|10470||
|681|E|E681|Kanál podání||
|681|F|F681|Meta atributy||
|681|G|G681|Podání||
|681|I|I681|x||
|681|J|J681|x||
|681|K|K681|x||
|681|L|L681|přidání atributu||
|681|M|M681|na základě konzultace architektury||
|682|A|A682|19.11.2024||
|682|B|B682|1.1||
|682|C|C682|ZP004||
|682|D|D682|10008||
|682|E|E682|Typ akce||
|682|F|F682|Meta atributy||
|682|G|G682|Podání||
|682|J|J682|x||
|682|L|L682|úprava číselníku||
|682|M|M682|přidání akcí na základě konzultace s metodiky ČSSZ||
|683|A|A683|19.11.2024||
|683|B|B683|1.1||
|683|C|C683|ZP004||
|683|D|D683|10007||
|683|E|E683|Typ podání||
|683|F|F683|Meta atributy||
|683|G|G683|Podání||
|683|K|K683|x||
|683|L|L683|změna typu hlášení||
|683|M|M683|odebrání z Registrace zaměstnance po konzultaci s metodiky ONZ||
|684|A|A684|20.11.2024||
|684|B|B684|1.1||
|684|C|C684|ZP003||
|684|D|D684|10021||
|684|E|E684|Typ identifikátoru zaměstnance||
|684|F|F684|Přehled o výši pojistného||
|684|G|G684|Přehled zaměstnanců s uplatněnou slevou na pojistném||
|684|K|K684|x||
|684|L|L684|odstranění atributu||
|684|M|M684|odebrání v rámci zrušení individuální části PVPOJ||
|685|A|A685|20.11.2024||
|685|B|B685|1.1||
|685|C|C685|ZP003||
|685|D|D685|10022||
|685|E|E685|Identifikátor zaměstnance||
|685|F|F685|Přehled o výši pojistného||
|685|G|G685|Přehled zaměstnanců s uplatněnou slevou na pojistném||
|685|K|K685|x||
|685|L|L685|odstranění atributu||
|685|M|M685|odebrání v rámci zrušení individuální části PVPOJ||
|686|A|A686|25.11.2024||
|686|B|B686|1.1||
|686|C|C686|ZP004||
|686|D|D686|10008||
|686|E|E686|Typ akce||
|686|F|F686|Meta atributy||
|686|G|G686|Podání||
|686|J|J686|x||
|686|L|L686|úprava číselníku||
|686|M|M686|přidání akcí na základě konzultace s metodiky ČSSZ||
|687|A|A687|28.11.2024||
|687|B|B687|1.1||
|687|C|C687|ZP005||
|687|D|D687|10088||
|687|E|E687|Poživatel důchodu||
|687|F|F687|Zaměstnanec / Žák / Student ||
|687|G|G687|Důchod||
|687|H|H687|Vyplácený ČSSZ||
|687|J|J687|x||
|687|L|L687|změna třídy atributu||
|687|M|M687|připomínka z OŘ 3. kolo - rekategorizace důchodů||
|688|A|A688|28.11.2024||
|688|B|B688|1.1||
|688|C|C688|ZP005||
|688|D|D688|10088||
|688|E|E688|Druh důchodu||
|688|F|F688|Zaměstnanec / Žák / Student ||
|688|G|G688|Důchod||
|688|H|H688|Vyplácený ČSSZ||
|688|J|J688|x||
|688|L|L688|přejmenování atributu||
|688|M|M688|připomínka z OŘ 3. kolo - rekategorizace důchodů||
|689|A|A689|28.11.2024||
|689|B|B689|1.1||
|689|C|C689|ZP004||
|689|D|D689|10266||
|689|E|E689|Poslední den v evidenčním stavu (při ukončení zaměstnání)||
|689|F|F689|Průběh zaměstnání v daném měsíci||
|689|G|G689|Odpracované dny||
|689|K|K689|x||
|689|L|L689|odstranění atributu||
|689|M|M689|na základě konzultace s ČSÚ||
|690|A|A690|29.11.2024||
|690|B|B690|1.1||
|690|C|C690|ZP007||
|690|D|D690|10274||
|690|E|E690|Kategorizace rizika||
|690|F|F690|Průběh zaměstnání v daném měsíci||
|690|G|G690|Odpracované hodiny||
|690|H|H690|Riziková práce||
|690|K|K690|x||
|690|L|L690|úprava číselníku||
|690|M|M690|důchodová reforma||
|691|A|A691|29.11.2024||
|691|B|B691|1.1||
|691|C|C691|ZP005||
|691|D|D691|10281||
|691|E|E691|Ze strany||
|691|F|F691|Průběh zaměstnání v daném měsíci||
|691|G|G691|Překážky v práci||
|691|K|K691|x||
|691|L|L691|odstranění atributu||
|691|M|M691|zjednodušení sekce Překážky v práci||
|692|A|A692|29.11.2024||
|692|B|B692|1.1||
|692|C|C692|ZP005||
|692|D|D692|10282||
|692|E|E692|Důvod - zaměstnanec||
|692|F|F692|Průběh zaměstnání v daném měsíci||
|692|G|G692|Překážky v práci||
|692|K|K692|x||
|692|L|L692|odstranění atributu||
|692|M|M692|zjednodušení sekce Překážky v práci||
|693|A|A693|29.11.2024||
|693|B|B693|1.1||
|693|C|C693|ZP005||
|693|D|D693|10401||
|693|E|E693|Důvod - zaměstnavatel||
|693|F|F693|Průběh zaměstnání v daném měsíci||
|693|G|G693|Překážky v práci||
|693|K|K693|x||
|693|L|L693|odstranění atributu||
|693|M|M693|zjednodušení sekce Překážky v práci||
|694|A|A694|29.11.2024||
|694|B|B694|1.1||
|694|C|C694|ZP005||
|694|D|D694|10283||
|694|E|E694|Překážky v práci od||
|694|F|F694|Průběh zaměstnání v daném měsíci||
|694|G|G694|Překážky v práci||
|694|K|K694|x||
|694|L|L694|odstranění atributu||
|694|M|M694|zjednodušení sekce Překážky v práci||
|695|A|A695|29.11.2024||
|695|B|B695|1.1||
|695|C|C695|ZP005||
|695|D|D695|10284||
|695|E|E695|Překážky v práci do||
|695|F|F695|Průběh zaměstnání v daném měsíci||
|695|G|G695|Překážky v práci||
|695|K|K695|x||
|695|L|L695|odstranění atributu||
|695|M|M695|zjednodušení sekce Překážky v práci||
|696|A|A696|29.11.2024||
|696|B|B696|1.1||
|696|C|C696|ZP005||
|696|D|D696|10413||
|696|E|E696|Počet neodpracovaných dní||
|696|F|F696|Průběh zaměstnání v daném měsíci||
|696|G|G696|Překážky v práci||
|696|K|K696|x||
|696|L|L696|odstranění atributu||
|696|M|M696|zjednodušení sekce Překážky v práci||
|697|A|A697|29.11.2024||
|697|B|B697|1.1||
|697|C|C697|ZP005||
|697|D|D697|10285||
|697|E|E697|Počet neodpracovaných hodin||
|697|F|F697|Průběh zaměstnání v daném měsíci||
|697|G|G697|Překážky v práci||
|697|K|K697|x||
|697|L|L697|odstranění atributu||
|697|M|M697|zjednodušení sekce Překážky v práci||
|698|A|A698|29.11.2024||
|698|B|B698|1.1||
|698|C|C698|ZP005||
|698|D|D698|10471||
|698|E|E698|Překážky na straně zaměstnance s náhradou mzdy/platu - počet neodpracovaných hodin||
|698|F|F698|Průběh zaměstnání v daném měsíci||
|698|G|G698|Překážky v práci||
|698|K|K698|x||
|698|L|L698|přidání atributu||
|698|M|M698|zjednodušení sekce Překážky v práci||
|699|A|A699|29.11.2024||
|699|B|B699|1.1||
|699|C|C699|ZP005||
|699|D|D699|10472||
|699|E|E699|Překážky na straně zaměstnavatele - počet neodpracovaných hodin||
|699|F|F699|Průběh zaměstnání v daném měsíci||
|699|G|G699|Překážky v práci||
|699|K|K699|x||
|699|L|L699|přidání atributu||
|699|M|M699|zjednodušení sekce Překážky v práci||
|700|A|A700|29.11.2024||
|700|B|B700|1.1||
|700|C|C700|ZP004||
|700|D|D700|10358||
|700|E|E700|Počet dnů trvání dočasné pracovní neschopnosti||
|700|F|F700|Průběh pojištění v daném měsíci||
|700|G|G700|Vyloučené dny||
|700|K|K700|x||
|700|L|L700|přejmenování atributu||
|700|M|M700|revert předchozího přejmenování na základě nové verze DV||
|701|A|A701|29.11.2024||
|701|B|B701|1.1||
|701|C|C701|ZP005||
|701|D|D701|10473||
|701|E|E701|Počet dnů omluvené nepřítomnosti, za které nenáleží náhrada příjmu (neplacené volno, stávka)||
|701|F|F701|Průběh pojištění v daném měsíci||
|701|G|G701|Vyloučené dny||
|701|K|K701|x||
|701|L|L701|přidání atributu||
|701|M|M701|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|702|A|A702|29.11.2024||
|702|B|B702|1.1||
|702|C|C702|ZP005||
|702|D|D702|10474||
|702|E|E702|Počet dnů dočasné pracovní neschopnosti nebo karantény, za které náleží náhrada příjmu||
|702|F|F702|Průběh pojištění v daném měsíci||
|702|G|G702|Vyloučené dny||
|702|K|K702|x||
|702|L|L702|přidání atributu||
|702|M|M702|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|703|A|A703|29.11.2024||
|703|B|B703|1.1||
|703|C|C703|ZP005||
|703|D|D703|10475||
|703|E|E703|Počet dnů, za které bylo zaměstnanci vypláceno nemocenské, peněžitá pomoc v mateřství, otcovská, ošetřovné nebo dlouhodobé ošetřovné ||
|703|F|F703|Průběh pojištění v daném měsíci||
|703|G|G703|Vyloučené dny||
|703|K|K703|x||
|703|L|L703|přidání atributu||
|703|M|M703|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|704|A|A704|29.11.2024||
|704|B|B704|1.1||
|704|C|C704|ZP005||
|704|D|D704|10357||
|704|E|E704|Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) zákona č. 155/1995 Sb.||
|704|F|F704|Průběh pojištění v daném měsíci||
|704|G|G704|Vyloučené dny||
|704|H|H704|§ 16 odst. 4 písm. a) zákona č. 155/1995 Sb.||
|704|K|K704|x||
|704|L|L704|změna třídy atributu||
|704|M|M704|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|705|A|A705|29.11.2024||
|705|B|B705|1.1||
|705|C|C705|ZP005||
|705|D|D705|10358||
|705|E|E705|Počet dnů trvání dočasné pracovní neschopnosti (karanténa)||
|705|F|F705|Průběh pojištění v daném měsíci||
|705|G|G705|Vyloučené dny||
|705|H|H705|§ 16 odst. 4 písm. a) zákona č. 155/1995 Sb.||
|705|K|K705|x||
|705|L|L705|změna třídy atributu||
|705|M|M705|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|706|A|A706|29.11.2024||
|706|B|B706|1.1||
|706|C|C706|ZP005||
|706|D|D706|10359||
|706|E|E706|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|706|F|F706|Průběh pojištění v daném měsíci||
|706|G|G706|Vyloučené dny||
|706|H|H706|§ 16 odst. 4 písm. a) zákona č. 155/1995 Sb.||
|706|K|K706|x||
|706|L|L706|změna třídy atributu||
|706|M|M706|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|707|A|A707|29.11.2024||
|707|B|B707|1.1||
|707|C|C707|ZP005||
|707|D|D707|10360||
|707|E|E707|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|707|F|F707|Průběh pojištění v daném měsíci||
|707|G|G707|Vyloučené dny||
|707|H|H707|§ 16 odst. 4 písm. a) zákona č. 155/1995 Sb.||
|707|K|K707|x||
|707|L|L707|změna třídy atributu||
|707|M|M707|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|708|A|A708|29.11.2024||
|708|B|B708|1.1||
|708|C|C708|ZP005||
|708|D|D708|10362||
|708|E|E708|Počet dnů čerpání otcovské||
|708|F|F708|Průběh pojištění v daném měsíci||
|708|G|G708|Vyloučené dny||
|708|H|H708|§ 16 odst. 4 písm. a) zákona č. 155/1995 Sb.||
|708|K|K708|x||
|708|L|L708|změna třídy atributu||
|708|M|M708|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|709|A|A709|29.11.2024||
|709|B|B709|1.1||
|709|C|C709|ZP005||
|709|D|D709|10366||
|709|E|E709|Vyloučené dny podle § 18 odst. 7 zákona č. 187/2006 Sb.||
|709|F|F709|Průběh pojištění v daném měsíci||
|709|G|G709|Vyloučené dny||
|709|H|H709|§ 18 odst. 7 zákona č. 187/2006 Sb.||
|709|K|K709|x||
|709|L|L709|změna třídy atributu||
|709|M|M709|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|710|A|A710|29.11.2024||
|710|B|B710|1.1||
|710|C|C710|ZP005||
|710|D|D710|10473||
|710|E|E710|Počet dnů omluvené nepřítomnosti, za které nenáleží náhrada příjmu (neplacené volno, stávka)||
|710|F|F710|Průběh pojištění v daném měsíci||
|710|G|G710|Vyloučené dny||
|710|H|H710|§ 18 odst. 7 zákona č. 187/2006 Sb.||
|710|K|K710|x||
|710|L|L710|změna třídy atributu||
|710|M|M710|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|711|A|A711|29.11.2024||
|711|B|B711|1.1||
|711|C|C711|ZP005||
|711|D|D711|10474||
|711|E|E711|Počet dnů dočasné pracovní neschopnosti nebo karantény, za které náleží náhrada příjmu||
|711|F|F711|Průběh pojištění v daném měsíci||
|711|G|G711|Vyloučené dny||
|711|H|H711|§ 18 odst. 7 zákona č. 187/2006 Sb.||
|711|K|K711|x||
|711|L|L711|změna třídy atributu||
|711|M|M711|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|712|A|A712|29.11.2024||
|712|B|B712|1.1||
|712|C|C712|ZP005||
|712|D|D712|10475||
|712|E|E712|Počet dnů, za které bylo zaměstnanci vypláceno nemocenské, peněžitá pomoc v mateřství, otcovská, ošetřovné nebo dlouhodobé ošetřovné ||
|712|F|F712|Průběh pojištění v daném měsíci||
|712|G|G712|Vyloučené dny||
|712|H|H712|§ 18 odst. 7 zákona č. 187/2006 Sb.||
|712|K|K712|x||
|712|L|L712|změna třídy atributu||
|712|M|M712|na základě změny pojetí vyloučených / odečítaných dnů / dob||
|713|A|A713|29.11.2024||
|713|B|B713|1.1||
|713|C|C713|ZP008||
|713|D|D713|10476||
|713|E|E713|Vykázaný příjem z nepojištěné činnosti ||
|713|F|F713|Průběh pojištění v daném měsíci||
|713|G|G713|Vyměřovací základ||
|713|K|K713|x||
|713|L|L713|přidání atributu||
|713|M|M713|zařazeno na základě změny legislativy k DPP||
|714|A|A714|29.11.2024||
|714|B|B714|1.1||
|714|C|C714|ZP003||
|714|D|D714|10477||
|714|E|E714|Částka vyměřovacího základu zaměstnance, ze kterého je odváděno pojistné||
|714|F|F714|Průběh pojištění v daném měsíci||
|714|G|G714|Vyměřovací základ||
|714|K|K714|x||
|714|L|L714|přidání atributu||
|714|M|M714|Změny ve formuláři PVPOJ||
|715|A|A715|29.11.2024||
|715|B|B715|1.1||
|715|C|C715|ZP003||
|715|D|D715|10478||
|715|E|E715|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) chSZ ||
|715|F|F715|Průběh pojištění v daném měsíci||
|715|G|G715|Vyměřovací základ||
|715|K|K715|x||
|715|L|L715|přidání atributu||
|715|M|M715|Změny ve formuláři PVPOJ||
|716|A|A716|29.11.2024||
|716|B|B716|1.1||
|716|C|C716|ZP003||
|716|D|D716|10479||
|716|E|E716|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) chSZ ||
|716|F|F716|Průběh pojištění v daném měsíci||
|716|G|G716|Vyměřovací základ||
|716|K|K716|x||
|716|L|L716|přidání atributu||
|716|M|M716|Změny ve formuláři PVPOJ||
|717|A|A717|29.11.2024||
|717|B|B717|1.1||
|717|C|C717|ZP007||
|717|D|D717|10480||
|717|E|E717|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) chSZ ||
|717|F|F717|Průběh pojištění v daném měsíci||
|717|G|G717|Vyměřovací základ||
|717|K|K717|x||
|717|L|L717|přidání atributu||
|717|M|M717|důchodová reforma||
|718|A|A718|29.11.2024||
|718|B|B718|1.1||
|718|C|C718|ZP003||
|718|D|D718|10368||
|718|E|E718|Sociální pojištění, příspěvek na státní politiku zaměstnanosti, zdravotní pojištění||
|718|F|F718|Průběh pojištění v daném měsíci||
|718|G|G718|Pojistné za zaměstnavatele||
|718|H|H718|Dotované pracovní místo||
|718|K|K718|x||
|718|L|L718|odstranění atributu||
|718|M|M718|Změny ve formuláři PVPOJ||
|719|A|A719|29.11.2024||
|719|B|B719|1.1||
|719|C|C719|ZP003||
|719|D|D719|10481||
|719|E|E719|Pojistné na sociální zabezpečení ||
|719|F|F719|Průběh pojištění v daném měsíci||
|719|G|G719|Pojistné za zaměstnavatele||
|719|K|K719|x||
|719|L|L719|přidání atributu||
|719|M|M719|Změny ve formuláři PVPOJ||
|720|A|A720|29.11.2024||
|720|B|B720|1.1||
|720|C|C720|ZP003||
|720|D|D720|10482||
|720|E|E720|Zdravotní pojištění||
|720|F|F720|Průběh pojištění v daném měsíci||
|720|G|G720|Pojistné za zaměstnavatele||
|720|K|K720|x||
|720|L|L720|přidání atributu||
|720|M|M720|Změny ve formuláři PVPOJ||
|721|A|A721|29.11.2024||
|721|B|B721|1.1||
|721|C|C721|ZP004||
|721|D|D721|10198||
|721|E|E721|Číslo účtu||
|721|F|F721|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|721|G|G721|Peněžní účty||
|721|I|I721|x||
|721|L|L721|změna ID atributu||
|721|M|M721|oprava nesmyslného ID atributu, které se do sdíleného souboru dostalo||
|722|A|A722|29.11.2024||
|722|B|B722|1.1||
|722|C|C722|ZP005||
|722|D|D722|10240||
|722|E|E722|Kód ELDP||
|722|F|F722|Průběh pojištění v daném měsíci||
|722|G|G722|Činnost||
|722|H|H722|ELDP||
|722|K|K722|x||
|722|L|L722|změna oblasti atributu||
|722|M|M722|připomínka z OŘ 3. kolo - ČSÚ||
|723|A|A723|29.11.2024||
|723|B|B723|1.1||
|723|C|C723|ZP005||
|723|D|D723|10241||
|723|E|E723|Platnost kódu od||
|723|F|F723|Průběh pojištění v daném měsíci||
|723|G|G723|Činnost||
|723|H|H723|ELDP||
|723|K|K723|x||
|723|L|L723|změna oblasti atributu||
|723|M|M723|připomínka z OŘ 3. kolo - ČSÚ||
|724|A|A724|29.11.2024||
|724|B|B724|1.1||
|724|C|C724|ZP005||
|724|D|D724|10242||
|724|E|E724|Platnost kódu do||
|724|F|F724|Průběh pojištění v daném měsíci||
|724|G|G724|Činnost||
|724|H|H724|ELDP||
|724|K|K724|x||
|724|L|L724|změna oblasti atributu||
|724|M|M724|připomínka z OŘ 3. kolo - ČSÚ||
|725|A|A725|29.11.2024||
|725|B|B725|1.1||
|725|C|C725|ZP005||
|725|D|D725|10243||
|725|E|E725|Zaměstnání malého rozsahu||
|725|F|F725|Průběh pojištění v daném měsíci||
|725|G|G725|Činnost||
|725|H|H725|ELDP||
|725|K|K725|x||
|725|L|L725|změna oblasti atributu||
|725|M|M725|připomínka z OŘ 3. kolo - ČSÚ||
|726|A|A726|29.11.2024||
|726|B|B726|1.1||
|726|C|C726|ZP005||
|726|D|D726|10244||
|726|E|E726|Vyloučené doby||
|726|F|F726|Průběh pojištění v daném měsíci||
|726|G|G726|Činnost||
|726|H|H726|ELDP||
|726|K|K726|x||
|726|L|L726|změna oblasti atributu||
|726|M|M726|připomínka z OŘ 3. kolo - ČSÚ||
|727|A|A727|29.11.2024||
|727|B|B727|1.1||
|727|C|C727|ZP005||
|727|D|D727|10245||
|727|E|E727|Vyměřovací základ||
|727|F|F727|Průběh pojištění v daném měsíci||
|727|G|G727|Činnost||
|727|H|H727|ELDP||
|727|K|K727|x||
|727|L|L727|změna oblasti atributu||
|727|M|M727|připomínka z OŘ 3. kolo - ČSÚ||
|728|A|A728|29.11.2024||
|728|B|B728|1.1||
|728|C|C728|ZP005||
|728|D|D728|10246||
|728|E|E728|Doby odečtené||
|728|F|F728|Průběh pojištění v daném měsíci||
|728|G|G728|Činnost||
|728|H|H728|ELDP||
|728|K|K728|x||
|728|L|L728|změna oblasti atributu||
|728|M|M728|připomínka z OŘ 3. kolo - ČSÚ||
|729|A|A729|29.11.2024||
|729|B|B729|1.1||
|729|C|C729|ZP005||
|729|D|D729|10240||
|729|E|E729|Kód ELDP||
|729|F|F729|Průběh pojištění v daném měsíci||
|729|G|G729|ELDP||
|729|K|K729|x||
|729|L|L729|změna třídy atributu||
|729|M|M729|připomínka z OŘ 3. kolo - ČSÚ||
|730|A|A730|29.11.2024||
|730|B|B730|1.1||
|730|C|C730|ZP005||
|730|D|D730|10241||
|730|E|E730|Platnost kódu od||
|730|F|F730|Průběh pojištění v daném měsíci||
|730|G|G730|ELDP||
|730|K|K730|x||
|730|L|L730|změna třídy atributu||
|730|M|M730|připomínka z OŘ 3. kolo - ČSÚ||
|731|A|A731|29.11.2024||
|731|B|B731|1.1||
|731|C|C731|ZP005||
|731|D|D731|10242||
|731|E|E731|Platnost kódu do||
|731|F|F731|Průběh pojištění v daném měsíci||
|731|G|G731|ELDP||
|731|K|K731|x||
|731|L|L731|změna třídy atributu||
|731|M|M731|připomínka z OŘ 3. kolo - ČSÚ||
|732|A|A732|29.11.2024||
|732|B|B732|1.1||
|732|C|C732|ZP005||
|732|D|D732|10243||
|732|E|E732|Zaměstnání malého rozsahu||
|732|F|F732|Průběh pojištění v daném měsíci||
|732|G|G732|ELDP||
|732|K|K732|x||
|732|L|L732|změna třídy atributu||
|732|M|M732|připomínka z OŘ 3. kolo - ČSÚ||
|733|A|A733|29.11.2024||
|733|B|B733|1.1||
|733|C|C733|ZP005||
|733|D|D733|10244||
|733|E|E733|Vyloučené doby||
|733|F|F733|Průběh pojištění v daném měsíci||
|733|G|G733|ELDP||
|733|K|K733|x||
|733|L|L733|změna třídy atributu||
|733|M|M733|připomínka z OŘ 3. kolo - ČSÚ||
|734|A|A734|29.11.2024||
|734|B|B734|1.1||
|734|C|C734|ZP005||
|734|D|D734|10245||
|734|E|E734|Vyměřovací základ||
|734|F|F734|Průběh pojištění v daném měsíci||
|734|G|G734|ELDP||
|734|K|K734|x||
|734|L|L734|změna třídy atributu||
|734|M|M734|připomínka z OŘ 3. kolo - ČSÚ||
|735|A|A735|29.11.2024||
|735|B|B735|1.1||
|735|C|C735|ZP005||
|735|D|D735|10246||
|735|E|E735|Doby odečtené||
|735|F|F735|Průběh pojištění v daném měsíci||
|735|G|G735|ELDP||
|735|K|K735|x||
|735|L|L735|změna třídy atributu||
|735|M|M735|připomínka z OŘ 3. kolo - ČSÚ||
|736|A|A736|29.11.2024||
|736|B|B736|1.1||
|736|C|C736|ZP005||
|736|D|D736|10249||
|736|E|E736|Postavení v zaměstnání||
|736|F|F736|Vykonávaná pozice zaměstnance||
|736|G|G736|Forma práce||
|736|J|J736|x||
|736|L|L736|přejmenování atributu||
|736|M|M736|připomínka z OŘ 3. kolo - ČSÚ||
|737|A|A737|29.11.2024||
|737|B|B737|1.1||
|737|C|C737|ZP005||
|737|D|D737|10259||
|737|E|E737|Stanovený fond pro danou profesi (v hodinách měsíčně)||
|737|F|F737|Vykonávaná pozice zaměstnance||
|737|G|G737|Fond pracovní doby||
|737|J|J737|x||
|737|K|K737|x||
|737|L|L737|změna typu hlášení||
|737|M|M737|registrace zaměstnance -> měsíční, připomínka z OŘ 3. kolo - ČSÚ||
|738|A|A738|29.11.2024||
|738|B|B738|1.1||
|738|C|C738|ZP005||
|738|D|D738|10260||
|738|E|E738|Sjednaný fond pracovní doby (v hodinách měsíčně)||
|738|F|F738|Vykonávaná pozice zaměstnance||
|738|G|G738|Fond pracovní doby||
|738|J|J738|x||
|738|K|K738|x||
|738|L|L738|změna typu hlášení||
|738|M|M738|registrace zaměstnance -> měsíční, připomínka z OŘ 3. kolo - ČSÚ||
|739|A|A739|29.11.2024||
|739|B|B739|1.1||
|739|C|C739|ZP005||
|739|D|D739|10261||
|739|E|E739|Stanovená týdenní pracovní doba zaměstnance (§79 zákoníku práce)||
|739|F|F739|Vykonávaná pozice zaměstnance||
|739|G|G739|Fond pracovní doby||
|739|J|J739|x||
|739|K|K739|x||
|739|L|L739|změna typu hlášení||
|739|M|M739|registrace zaměstnance -> měsíční, připomínka z OŘ 3. kolo - ČSÚ||
|740|A|A740|29.11.2024||
|740|B|B740|1.1||
|740|C|C740|ZP007||
|740|D|D740|10023||
|740|E|E740|Úhrn vyměřovacích základů zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|740|F|F740|Přehled o výši pojistného||
|740|G|G740|Souhrn||
|740|H|H740|Odváděné pojistné||
|740|K|K740|x||
|740|L|L740|přejmenování atributu||
|740|M|M740|důchodová reforma||
|741|A|A741|29.11.2024||
|741|B|B741|1.1||
|741|C|C741|ZP007||
|741|D|D741|10024||
|741|E|E741|Pojistné za zaměstnavatele u zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|741|F|F741|Přehled o výši pojistného||
|741|G|G741|Souhrn||
|741|H|H741|Odváděné pojistné||
|741|K|K741|x||
|741|L|L741|přejmenování atributu||
|741|M|M741|důchodová reforma||
|742|A|A742|29.11.2024||
|742|B|B742|1.1||
|742|C|C742|ZP007||
|742|D|D742|10483||
|742|E|E742|Úhrn vyměřovacích základů zaměstnanců, kteří vykonávají rizikové zaměstnání||
|742|F|F742|Přehled o výši pojistného||
|742|G|G742|Souhrn||
|742|H|H742|Odváděné pojistné||
|742|K|K742|x||
|742|L|L742|přidání atributu||
|742|M|M742|důchodová reforma||
|743|A|A743|29.11.2024||
|743|B|B743|1.1||
|743|C|C743|ZP007||
|743|D|D743|10484||
|743|E|E743|Pojistné za zaměstnavatele u zaměstnanců, kteří vykonávají rizikové zaměstnání||
|743|F|F743|Přehled o výši pojistného||
|743|G|G743|Souhrn||
|743|H|H743|Odváděné pojistné||
|743|K|K743|x||
|743|L|L743|přidání atributu||
|743|M|M743|důchodová reforma||
|744|A|A744|29.11.2024||
|744|B|B744|1.1||
|744|C|C744|ZP007||
|744|D|D744|10030||
|744|E|E744|Počet zaměstnanců||
|744|F|F744|Přehled o výši pojistného||
|744|G|G744|Souhrn||
|744|H|H744|Slevy na pojistném zaměstnavatele||
|744|K|K744|x||
|744|L|L744|změna třídy atributu||
|744|M|M744|důchodová reforma||
|745|A|A745|29.11.2024||
|745|B|B745|1.1||
|745|C|C745|ZP007||
|745|D|D745|10031||
|745|E|E745|Úhrn vyměřovacích základů zaměstnanců||
|745|F|F745|Přehled o výši pojistného||
|745|G|G745|Souhrn||
|745|H|H745|Slevy na pojistném zaměstnavatele||
|745|K|K745|x||
|745|L|L745|změna třídy atributu||
|745|M|M745|důchodová reforma||
|746|A|A746|29.11.2024||
|746|B|B746|1.1||
|746|C|C746|ZP007||
|746|D|D746|10032||
|746|E|E746|Sleva na pojistném||
|746|F|F746|Přehled o výši pojistného||
|746|G|G746|Souhrn||
|746|H|H746|Slevy na pojistném zaměstnavatele||
|746|K|K746|x||
|746|L|L746|změna třídy atributu||
|746|M|M746|důchodová reforma||
|747|A|A747|29.11.2024||
|747|B|B747|1.1||
|747|C|C747|ZP007||
|747|D|D747|10032||
|747|E|E747|Sleva na pojistném zaměstnavatele||
|747|F|F747|Přehled o výši pojistného||
|747|G|G747|Souhrn||
|747|H|H747|Slevy na pojistném zaměstnavatele||
|747|K|K747|x||
|747|L|L747|přejmenování atributu||
|747|M|M747|důchodová reforma||
|748|A|A748|29.11.2024||
|748|B|B748|1.1||
|748|C|C748|ZP007||
|748|D|D748|10485||
|748|E|E748|Počet zaměstnanců||
|748|F|F748|Přehled o výši pojistného||
|748|G|G748|Souhrn||
|748|H|H748|Slevy na pojistném zaměstnanců||
|748|K|K748|x||
|748|L|L748|přidání atributu||
|748|M|M748|důchodová reforma||
|749|A|A749|29.11.2024||
|749|B|B749|1.1||
|749|C|C749|ZP007||
|749|D|D749|10486||
|749|E|E749|Úhrn vyměřovacích základů zaměstnanců||
|749|F|F749|Přehled o výši pojistného||
|749|G|G749|Souhrn||
|749|H|H749|Slevy na pojistném zaměstnanců||
|749|K|K749|x||
|749|L|L749|přidání atributu||
|749|M|M749|důchodová reforma||
|750|A|A750|29.11.2024||
|750|B|B750|1.1||
|750|C|C750|ZP007||
|750|D|D750|10487||
|750|E|E750|Úhrn slev na pojistném zaměstnanců||
|750|F|F750|Přehled o výši pojistného||
|750|G|G750|Souhrn||
|750|H|H750|Slevy na pojistném zaměstnanců||
|750|K|K750|x||
|750|L|L750|přidání atributu||
|750|M|M750|důchodová reforma||
|751|A|A751|3.12.2024||
|751|B|B751|1.2||
|751|C|C751|ZP021||
|751|D|D751|10008||
|751|E|E751|Typ akce||
|751|F|F751|Meta atributy||
|751|G|G751|Podání||
|751|J|J751|x||
|751|L|L751|úprava číselníku||
|751|M|M751|změna názvů akcí na základě konzultace s ČSSZ||
|752|A|A752|9.12.2024||
|752|B|B752|1.2||
|752|C|C752|ZP021||
|752|D|D752|10223||
|752|E|E752|Datum nástupu do zaměstnání||
|752|F|F752|Vykonávaná pozice zaměstnance||
|752|G|G752|Nástup do zaměstnání||
|752|J|J752|x||
|752|K|K752|x||
|752|L|L752|přejmenování atributu||
|752|M|M752|oponentura registrace zaměstnance od ČSSZ||
|753|A|A753|9.12.2024||
|753|B|B753|1.2||
|753|C|C753|ZP021||
|753|D|D753|10224||
|753|E|E753|Datum skončení zaměstnání||
|753|F|F753|Vykonávaná pozice zaměstnance||
|753|G|G753|Ukončení zaměstnání||
|753|J|J753|x||
|753|L|L753|přejmenování atributu||
|753|M|M753|oponentura registrace zaměstnance od ČSSZ||
|754|A|A754|9.12.2024||
|754|B|B754|1.2||
|754|C|C754|ZP021||
|754|D|D754|10243||
|754|E|E754|Zaměstnání malého rozsahu||
|754|F|F754|Vykonávaná pozice zaměstnance||
|754|G|G754|ELDP||
|754|J|J754|x||
|754|L|L754|změna oblasti atributu||
|754|M|M754|oponentura registrace zaměstnance od ČSSZ||
|755|A|A755|9.12.2024||
|755|B|B755|1.2||
|755|C|C755|ZP021||
|755|D|D755|10243||
|755|E|E755|Zaměstnání malého rozsahu||
|755|F|F755|Vykonávaná pozice zaměstnance||
|755|G|G755|Rozsah zaměstnání||
|755|J|J755|x||
|755|L|L755|změna třídy atributu||
|755|M|M755|oponentura registrace zaměstnance od ČSSZ||
|756|A|A756|10.12.2024||
|756|B|B756|1.2||
|756|C|C756|ZP021||
|756|D|D756|10254||
|756|E|E756|Odměňování podle zákona||
|756|F|F756|Vykonávaná pozice zaměstnance||
|756|G|G756|Odměňování||
|756|J|J756|x||
|756|L|L756|odstranění atributu||
|756|M|M756|po konzultaci v rámci datového týmu (atribut je pokryt číselníkem CZ-ICSE)||
|757|A|A757|12.12.2024||
|757|B|B757|1.2||
|757|C|C757|ZP021||
|757|D|D757|10088||
|757|E|E757|Druh důchodu||
|757|F|F757|Zaměstnanec / Žák / Student ||
|757|G|G757|Důchod||
|757|H|H757|Vyplácený ČSSZ||
|757|J|J757|x||
|757|L|L757|úprava číselníku||
|757|M|M757|rozšíření číselníku na základě konzultace k důchodové reformě s ČSSZ||
|758|A|A758|17.12.2024||
|758|B|B758|1.2||
|758|C|C758|ZP021||
|758|D|D758|10089||
|758|E|E758|V období 12 kalendářních měsíců před kalendářním měsícem, za který se sleva na pojistném uplatňuje, nastoupil jako uchazeč o zaměstnání na rekvalifikaci||
|758|F|F758|Zaměstnanec / Žák / Student ||
|758|G|G758|Deklarované skutečnosti ze strany zaměstnance||
|758|H|H758|Příznaky||
|758|K|K758|x||
|758|L|L758|odstranění atributu||
|758|M|M758|odstranění atributu, který byl dříve odstraněn z DV, v rámci čištění datového slovníku||
|759|A|A759|27.1.2025||
|759|B|B759|1.2||
|759|C|C759|ZP021||
|759|D|D759|10008||
|759|E|E759|Typ akce||
|759|F|F759|Meta atributy||
|759|G|G759|Formulář||
|759|J|J759|x||
|759|L|L759|změna třídy atributu||
|759|M|M759|oprava třídy nesprávně zařazeného atributu||
|760|A|A760|27.1.2025||
|760|B|B760|1.2||
|760|C|C760|ZP021||
|760|D|D760|10009||
|760|E|E760|Platnost akce ke dni||
|760|F|F760|Meta atributy||
|760|G|G760|Formulář||
|760|J|J760|x||
|760|L|L760|změna třídy atributu||
|760|M|M760|oprava třídy nesprávně zařazeného atributu||
|761|A|A761|29.1.2025||
|761|B|B761|1.2||
|761|C|C761|ZP021||
|761|D|D761|10148||
|761|E|E761|Typ odhlášky||
|761|F|F761|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|761|G|G761|Odhlášení z registru||
|761|I|I761|x||
|761|L|L761|úprava konzumace atributu||
|761|M|M761|přidání FS mezi konzumenty na žádost FS||
|762|A|A762|29.1.2025||
|762|B|B762|1.2||
|762|C|C762|ZP021||
|762|D|D762|10149||
|762|E|E762|Datum zániku zaměstnavatele / zrušení mzdové účtárny||
|762|F|F762|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|762|G|G762|Odhlášení z registru||
|762|I|I762|x||
|762|L|L762|úprava konzumace atributu||
|762|M|M762|přidání FS mezi konzumenty na žádost FS||
|763|A|A763|31.1.2025||
|763|B|B763|1.2||
|763|C|C763|ZP021||
|763|D|D763|10013||
|763|E|E763|Pořadí balíku dat||
|763|F|F763|Meta atributy||
|763|G|G763|Formulář||
|763|J|J763|x||
|763|K|K763|x||
|763|L|L763|odstranění atributu||
|763|M|M763|odstranění atributu z metadat po revizi ze strany OK system a potvrzení od Eviden||
|764|A|A764|31.1.2025||
|764|B|B764|1.2||
|764|C|C764|ZP021||
|764|D|D764|10014||
|764|E|E764|Pořadí formuláře||
|764|F|F764|Meta atributy||
|764|G|G764|Formulář||
|764|J|J764|x||
|764|K|K764|x||
|764|L|L764|odstranění atributu||
|764|M|M764|odstranění  atributu z metadat po revizi ze strany OK system a potvrzení od Eviden||
|765|A|A765|31.1.2025||
|765|B|B765|1.2||
|765|C|C765|ZP021||
|765|D|D765|10015||
|765|E|E765|Počet formulářů v balíku dat||
|765|F|F765|Meta atributy||
|765|G|G765|Formulář||
|765|J|J765|x||
|765|K|K765|x||
|765|L|L765|přejmenování atributu||
|765|M|M765|přejmenování atributu z metadat po revizi ze strany OK system a potvrzení od Eviden||
|766|A|A766|31.1.2025||
|766|B|B766|1.2||
|766|C|C766|ZP021||
|766|D|D766|10015||
|766|E|E766|Počet formulářů v balíku dat||
|766|F|F766|Meta atributy||
|766|G|G766|Podání||
|766|J|J766|x||
|766|K|K766|x||
|766|L|L766|změna třídy atributu||
|766|M|M766|změna třídy atributu z metadat po revizi ze strany OK system a potvrzení od Eviden||
|767|A|A767|31.1.2025||
|767|B|B767|1.2||
|767|C|C767|ZP021||
|767|D|D767|10488||
|767|E|E767|Počet formulářů celkem||
|767|F|F767|Meta atributy||
|767|G|G767|Podání||
|767|J|J767|x||
|767|K|K767|x||
|767|L|L767|přidání atributu||
|767|M|M767|rozdělení atributu z metadat po revizi ze strany OK system a potvrzení od Eviden||
|768|A|A768|5.2.2025||
|768|B|B768|1.2||
|768|C|C768|ZP021||
|768|D|D768|10038||
|768|E|E768|Průměrný roční přepočtený počet zaměstnanců||
|768|F|F768|Souhrnná vrstva||
|768|G|G768|Plnění povinného podílu zaměstnávání OZP||
|768|K|K768|x||
|768|L|L768|odstranění prefillu||
|768|M|M768|po domluvě v rámci technického a procesního týmu||
|769|A|A769|5.2.2025||
|769|B|B769|1.2||
|769|C|C769|ZP021||
|769|D|D769|10039||
|769|E|E769|Průměrný roční přepočtený počet zaměstnanců, kteří jsou OZP||
|769|F|F769|Souhrnná vrstva||
|769|G|G769|Plnění povinného podílu zaměstnávání OZP||
|769|K|K769|x||
|769|L|L769|odstranění prefillu||
|769|M|M769|po domluvě v rámci technického a procesního týmu||
|770|A|A770|7.2.2025||
|770|B|B770|1.2||
|770|C|C770|ZP022||
|770|D|D770|10024||
|770|E|E770|Pojistné za zaměstnavatele u zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|770|F|F770|Přehled o výši pojistného||
|770|G|G770|Souhrn||
|770|H|H770|Odváděné pojistné||
|770|K|K770|x||
|770|L|L770|úprava prefillu - vzorce||
|770|M|M770|= 0,248 * "10023", = kontrola MH.8||
|771|A|A771|7.2.2025||
|771|B|B771|1.2||
|771|C|C771|ZP022||
|771|D|D771|10026||
|771|E|E771|Pojistné za zaměstnavatele u zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku||
|771|F|F771|Přehled o výši pojistného||
|771|G|G771|Souhrn||
|771|H|H771|Odváděné pojistné||
|771|K|K771|x||
|771|L|L771|úprava prefillu - vzorce||
|771|M|M771|= 0,298 * "10025", = kontrola MH.10||
|772|A|A772|7.2.2025||
|772|B|B772|1.2||
|772|C|C772|ZP022||
|772|D|D772|10484||
|772|E|E772|Pojistné za zaměstnavatele u zaměstnanců, kteří vykonávají rizikové zaměstnání||
|772|F|F772|Přehled o výši pojistného||
|772|G|G772|Souhrn||
|772|H|H772|Odváděné pojistné||
|772|K|K772|x||
|772|L|L772|úprava prefillu - vzorce||
|772|M|M772|= 0,268 * "10484", = kontrola MH.167||
|773|A|A773|7.2.2025||
|773|B|B773|1.2||
|773|C|C773|ZP022||
|773|D|D773|10027||
|773|E|E773|Pojistné za zaměstnavatele celkem (součet úhrnů)||
|773|F|F773|Přehled o výši pojistného||
|773|G|G773|Souhrn||
|773|H|H773|Odváděné pojistné||
|773|K|K773|x||
|773|L|L773|úprava prefillu - vzorce||
|773|M|M773|= "10024" + "10026" + "10484", = kontrola MH.11||
|774|A|A774|7.2.2025||
|774|B|B774|1.2||
|774|C|C774|ZP022||
|774|D|D774|10029||
|774|E|E774|Pojistné celkem||
|774|F|F774|Přehled o výši pojistného||
|774|G|G774|Souhrn||
|774|H|H774|Odváděné pojistné||
|774|K|K774|x||
|774|L|L774|úprava prefillu - vzorce||
|774|M|M774|="10027" + "10028", = kontrola MH.13||
|775|A|A775|7.2.2025||
|775|B|B775|1.2||
|775|C|C775|ZP022||
|775|D|D775|10032||
|775|E|E775|Sleva na pojistném zaměstnavatele||
|775|F|F775|Přehled o výši pojistného||
|775|G|G775|Souhrn||
|775|H|H775|Slevy na pojistném zaměstnavatele||
|775|K|K775|x||
|775|L|L775|úprava prefillu - vzorce||
|775|M|M775|= ROUNDUP(5% z ∑ (n) Vymeřovacích základů zaměstnanců, kteří uplatňují slevu), = kontrola MH.3||
|776|A|A776|7.2.2025||
|776|B|B776|1.2||
|776|C|C776|ZP022||
|776|D|D776|10033||
|776|E|E776|Vypočítané pojistné (rozdíl mezi pojistným celkem a slevou na pojistném)||
|776|F|F776|Přehled o výši pojistného||
|776|G|G776|Souhrn||
|776|H|H776|Pojistné k úhradě||
|776|K|K776|x||
|776|L|L776|úprava prefillu - vzorce||
|776|M|M776|= "10029" - "10032" - "10487", = kontrola MH.4||
|777|A|A777|7.2.2025||
|777|B|B777|1.2||
|777|C|C777|ZP022||
|777|D|D777|10286||
|777|E|E777|Zúčtovaný příjem - celkem||
|777|F|F777|Příjem v daném měsíci||
|777|G|G777|Příjem||
|777|K|K777|x||
|777|L|L777|úprava prefillu - vzorce||
|777|M|M777|= "10287" + "10288"||
|778|A|A778|7.2.2025||
|778|B|B778|1.2||
|778|C|C778|ZP022||
|778|D|D778|10297||
|778|E|E778|Základ pro výpočet zálohy na daň||
|778|F|F778|Příjem v daném měsíci||
|778|G|G778|Výpočet zálohy na daň||
|778|K|K778|x||
|778|L|L778|úprava prefillu - vzorce||
|778|M|M778|=ROUNDUP("10286" - "10289"; do 100 Kč se zaokrouhlí na celé koruny nahoru a nad 100 Kč na celé stokoruny nahoru)||
|779|A|A779|7.2.2025||
|779|B|B779|1.2||
|779|C|C779|ZP022||
|779|D|D779|10357||
|779|E|E779|Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) zákona č. 155/1995 Sb.||
|779|F|F779|Průběh pojištění v daném měsíci||
|779|G|G779|Vyloučené dny||
|779|H|H779|§ 16 odst. 4 písm. a) zákona č. 155/1995 Sb.||
|779|K|K779|x||
|779|L|L779|úprava prefillu - vzorce||
|779|M|M779|= "10358" + "10359" + "10360" + "10362"||
|780|A|A780|7.2.2025||
|780|B|B780|1.2||
|780|C|C780|ZP022||
|780|D|D780|10482||
|780|E|E780|Zdravotní pojištění||
|780|F|F780|Průběh pojištění v daném měsíci||
|780|G|G780|Pojistné za zaměstnavatele||
|780|K|K780|x||
|780|L|L780|úprava prefillu - vzorce||
|780|M|M780|=0,09 * "10367"||
|781|A|A781|7.2.2025||
|781|B|B781|1.2||
|781|C|C781|ZP022||
|781|D|D781|10370||
|781|E|E781|Sociální pojištění||
|781|F|F781|Průběh pojištění v daném měsíci||
|781|G|G781|Pojistné za zaměstnance||
|781|K|K781|x||
|781|L|L781|úprava prefillu - vzorce||
|781|M|M781|=0,071 * "10367"||
|782|A|A782|7.2.2025||
|782|B|B782|1.2||
|782|C|C782|ZP022||
|782|D|D782|10371||
|782|E|E782|Zdravotní pojištění||
|782|F|F782|Průběh pojištění v daném měsíci||
|782|G|G782|Pojistné za zaměstnance||
|782|K|K782|x||
|782|L|L782|úprava prefillu - vzorce||
|782|M|M782|=0,045 * "10367"||
|783|A|A783|17.2.2025||
|783|B|B783|1.2||
|783|C|C783|ZP022||
|783|D|D783|10010||
|783|E|E783|Měsíc||
|783|F|F783|Meta atributy||
|783|G|G783|Podání||
|783|K|K783|x||
|783|L|L783|úprava prefillu - poznámky||
|783|M|M783|Oprava prefillu||
|784|A|A784|17.2.2025||
|784|B|B784|1.2||
|784|C|C784|ZP022||
|784|D|D784|10011||
|784|E|E784|Rok||
|784|F|F784|Meta atributy||
|784|G|G784|Podání||
|784|K|K784|x||
|784|L|L784|úprava prefillu - poznámky||
|784|M|M784|Oprava prefillu||
|785|A|A785|18.2.2025||
|785|B|B785|1.2||
|785|C|C785|ZP021||
|785|D|D785|10489||
|785|E|E785|Bankovní spojení||
|785|F|F785|Přehled o výši pojistného||
|785|G|G785|Souhrn||
|785|H|H785|Platební údaje||
|785|K|K785|x||
|785|L|L785|přidání atributu||
|785|M|M785|Na základě rozhodnutí dodavatele (Eviden) a architektury||
|786|A|A786|21.2.2025||
|786|B|B786|1.2||
|786|C|C786|ZP022||
|786|D|D786|10297||
|786|E|E786|Základ pro výpočet zálohy na daň||
|786|F|F786|Příjem v daném měsíci||
|786|G|G786|Výpočet zálohy na daň||
|786|K|K786|x||
|786|L|L786|úprava prefillu - vzorce||
|786|M|M786|Oprava prefillu na žádost GFŘ - doplnění atributu do vzozrce||
|787|A|A787|21.2.2025||
|787|B|B787|1.2||
|787|C|C787|ZP022||
|787|D|D787|10032||
|787|E|E787|Sleva na pojistném zaměstnavatele||
|787|F|F787|Přehled o výši pojistného||
|787|G|G787|Souhrn||
|787|H|H787|Slevy na pojistném zaměstnavatele||
|787|K|K787|x||
|787|L|L787|úprava prefillu - vzorce||
|787|M|M787|změna na referencování na atribut 10031||
|788|A|A788|21.2.2025||
|788|B|B788|1.2||
|788|C|C788|ZP022||
|788|D|D788|10367||
|788|E|E788|Vyměřovací základ||
|788|F|F788|Průběh pojištění v daném měsíci||
|788|G|G788|Vyměřovací základ||
|788|K|K788|x||
|788|L|L788|úprava prefillu - zrušení||
|788|M|M788|Zrušení předvyplňování atributu na základě validace s business vlastníkem||
|789|A|A789|21.2.2025||
|789|B|B789|1.2||
|789|C|C789|ZP022||
|789|D|D789|10481||
|789|E|E789|Pojistné na sociální zabezpečení ||
|789|F|F789|Průběh pojištění v daném měsíci||
|789|G|G789|Pojistné za zaměstnavatele||
|789|K|K789|x||
|789|L|L789|úprava prefillu - vzorce||
|789|M|M789|Úprava vzorce předvyplňování atributu na základě validace s business vlastníkem||
|790|A|A790|21.2.2025||
|790|B|B790|1.2||
|790|C|C790|ZP022||
|790|D|D790|10370||
|790|E|E790|Sociální pojištění||
|790|F|F790|Průběh pojištění v daném měsíci||
|790|G|G790|Pojistné za zaměstnance||
|790|K|K790|x||
|790|L|L790|úprava prefillu - vzorce||
|790|M|M790|doplněno zaokrouhlování ve výpočtu a reference na kontrolu||
|791|A|A791|21.2.2025||
|791|B|B791|1.2||
|791|C|C791|ZP022||
|791|D|D791|10371||
|791|E|E791|Zdravotní pojištění||
|791|F|F791|Průběh pojištění v daném měsíci||
|791|G|G791|Pojistné za zaměstnance||
|791|K|K791|x||
|791|L|L791|úprava prefillu - vzorce||
|791|M|M791|doplněno zaokrouhlování ve výpočtu a reference na kontrolu||
|792|A|A792|24.2.2025||
|792|B|B792|1.2||
|792|C|C792|ZP022||
|792|D|D792|10028||
|792|E|E792|Pojistné za zaměstnance||
|792|F|F792|Přehled o výši pojistného||
|792|G|G792|Souhrn||
|792|H|H792|Odváděné pojistné||
|792|K|K792|x||
|792|L|L792|nově definovaný prefill - vzorec||
|792|M|M792|stanovení způsobu předvyplnění u atributu||
|793|A|A793|24.2.2025||
|793|B|B793|1.2||
|793|C|C793|ZP022||
|793|D|D793|10030||
|793|E|E793|Počet zaměstnanců||
|793|F|F793|Přehled o výši pojistného||
|793|G|G793|Souhrn||
|793|H|H793|Slevy na pojistném zaměstnavatele||
|793|K|K793|x||
|793|L|L793|nově definovaný prefill - vzorec||
|793|M|M793|stanovení způsobu předvyplnění u atributu||
|794|A|A794|24.2.2025||
|794|B|B794|1.2||
|794|C|C794|ZP022||
|794|D|D794|10031||
|794|E|E794|Úhrn vyměřovacích základů zaměstnanců||
|794|F|F794|Přehled o výši pojistného||
|794|G|G794|Souhrn||
|794|H|H794|Slevy na pojistném zaměstnavatele||
|794|K|K794|x||
|794|L|L794|nově definovaný prefill - vzorec||
|794|M|M794|stanovení způsobu předvyplnění u atributu||
|795|A|A795|25.2.2025||
|795|B|B795|1.2||
|795|C|C795|ZP022||
|795|D|D795|10477||
|795|E|E795|Částka vyměřovacího základu zaměstnance, ze kterého je odváděno pojistné||
|795|F|F795|Průběh pojištění v daném měsíci||
|795|G|G795|Vyměřovací základ||
|795|K|K795|x||
|795|L|L795|úprava prefillu - vzorce||
|795|M|M795|Doplněn vzorec pro výpočet||
|796|A|A796|27.2.2025||
|796|B|B796|1.2||
|796|C|C796|ZP021||
|796|D|D796|10367||
|796|E|E796|Vyměřovací základ||
|796|F|F796|Průběh pojištění v daném měsíci||
|796|G|G796|Vyměřovací základ||
|796|K|K796|x||
|796|L|L796|odstranění atributu||
|796|M|M796|na základě dohody s ČSSZ pro jeho nadbytečnost - údaj se dá dovodit součtem všech 10245 v daném měsíci||
|797|A|A797|27.2.2025||
|797|B|B797|1.2||
|797|C|C797|ZP021||
|797|D|D797|10250||
|797|E|E797|Oznámená DPP||
|797|F|F797|Vykonávaná pozice zaměstnance||
|797|G|G797|Forma práce||
|797|J|J797|x||
|797|L|L797|odstranění atributu||
|797|M|M797|na základě změny legislativy||
|798|A|A798|27.2.2025||
|798|B|B798|1.2||
|798|C|C798|ZP021||
|798|D|D798|10004||
|798|E|E798|Pracoviště ÚSSZ (OSSZ/PSSZ/MSSZ Brno)||
|798|F|F798|Meta atributy||
|798|G|G798|Podání||
|798|I|I798|x||
|798|J|J798|x||
|798|K|K798|x||
|798|L|L798|změna typu hlášení||
|798|M|M798|na základě požadavku metodiky ČSSZ||
|799|A|A799|27.2.2025||
|799|B|B799|1.2||
|799|C|C799|ZP021||
|799|D|D799|10411||
|799|E|E799|Finančnímu úřadu pro / Specializovanému finančnímu úřadu||
|799|F|F799|Meta atributy||
|799|G|G799|Podání||
|799|I|I799|x||
|799|J|J799|x||
|799|K|K799|x||
|799|L|L799|změna typu hlášení||
|799|M|M799|na základě vyjádření GFŘ||
|800|A|A800|27.2.2025||
|800|B|B800|1.2||
|800|C|C800|ZP021||
|800|D|D800|10412||
|800|E|E800|Územní pracoviště v, ve, pro  ||
|800|F|F800|Meta atributy||
|800|G|G800|Podání||
|800|I|I800|x||
|800|J|J800|x||
|800|K|K800|x||
|800|L|L800|změna typu hlášení||
|800|M|M800|na základě vyjádření GFŘ||
|801|A|A801|28.2.2025||
|801|B|B801|1.2||
|801|C|C801|ZP020||
|801|D|D801|10372||
|801|E|E801|Sleva na pojistném zaměstnavatele||
|801|F|F801|Průběh pojištění v daném měsíci||
|801|G|G801|Sleva na pojistném||
|801|K|K801|x||
|801|L|L801|přejmenování atributu||
|801|M|M801|Změny ve formuláři PVPOJ||
|802|A|A802|28.2.2025||
|802|B|B802|1.2||
|802|C|C802|ZP020||
|802|D|D802|10490||
|802|E|E802|Sleva na pojistném zaměstnance||
|802|F|F802|Průběh pojištění v daném měsíci||
|802|G|G802|Sleva na pojistném||
|802|K|K802|x||
|802|L|L802|přidání atributu||
|802|M|M802|Změny ve formuláři PVPOJ||
|803|A|A803|28.2.2025||
|803|B|B803|1.2||
|803|C|C803|ZP020||
|803|D|D803|10491||
|803|E|E803|Výše slevy na pojistném zaměstnance||
|803|F|F803|Průběh pojištění v daném měsíci||
|803|G|G803|Sleva na pojistném||
|803|K|K803|x||
|803|L|L803|přidání atributu||
|803|M|M803|Změny ve formuláři PVPOJ||
|804|A|A804|3.3.2025||
|804|B|B804|1.2||
|804|C|C804|ZP022||
|804|D|D804|10031||
|804|E|E804|Úhrn vyměřovacích základů zaměstnanců||
|804|F|F804|Přehled o výši pojistného||
|804|G|G804|Souhrn||
|804|H|H804|Slevy na pojistném zaměstnavatele||
|804|K|K804|x||
|804|L|L804|úprava prefillu - vzorce||
|804|M|M804|nahrazení zrušeného atributu v důsledku změny z 28.2.2025 v tomto change logu||
|805|A|A805|3.3.2025||
|805|B|B805|1.2||
|805|C|C805|ZP022||
|805|D|D805|10485||
|805|E|E805|Počet zaměstnanců||
|805|F|F805|Přehled o výši pojistného||
|805|G|G805|Souhrn||
|805|H|H805|Slevy na pojistném zaměstnanců||
|805|K|K805|x||
|805|L|L805|nově definovaný prefill - vzorec||
|805|M|M805|Doplněn vzorec pro výpočet na základě nově přidaného atributu||
|806|A|A806|3.3.2025||
|806|B|B806|1.2||
|806|C|C806|ZP022||
|806|D|D806|10486||
|806|E|E806|Úhrn vyměřovacích základů zaměstnanců||
|806|F|F806|Přehled o výši pojistného||
|806|G|G806|Souhrn||
|806|H|H806|Slevy na pojistném zaměstnanců||
|806|K|K806|x||
|806|L|L806|nově definovaný prefill - vzorec||
|806|M|M806|Doplněn vzorec pro výpočet na základě nově přidaného atributu||
|807|A|A807|3.3.2025||
|807|B|B807|1.2||
|807|C|C807|ZP022||
|807|D|D807|10487||
|807|E|E807|Úhrn slev na pojistném zaměstnanců||
|807|F|F807|Přehled o výši pojistného||
|807|G|G807|Souhrn||
|807|H|H807|Slevy na pojistném zaměstnanců||
|807|K|K807|x||
|807|L|L807|nově definovaný prefill - vzorec||
|807|M|M807|Doplněn vzorec pro výpočet na základě nově přidaného atributu||
|808|A|A808|3.3.2025||
|808|B|B808|1.2||
|808|C|C808|ZP022||
|808|D|D808|10356||
|808|E|E808|Počet kalendářních dnů trvání pojištění v daném kalendářním měsíci||
|808|F|F808|Průběh pojištění v daném měsíci||
|808|G|G808|Trvání pojištění||
|808|K|K808|x||
|808|L|L808|odstranění prefillu||
|808|M|M808|odstranění poznámky s dohadem o možnosti předvyplnění||
|809|A|A809|3.3.2025||
|809|B|B809|1.2||
|809|C|C809|ZP022||
|809|D|D809|10375||
|809|E|E809|Doby odečítané po důchodovém věku - počet dnů||
|809|F|F809|Průběh pojištění v daném měsíci||
|809|G|G809|Odečítané dny||
|809|K|K809|x||
|809|L|L809|odstranění prefillu||
|809|M|M809|odstranění poznámky s dohadem o možnosti předvyplnění||
|810|A|A810|3.3.2025||
|810|B|B810|1.2||
|810|C|C810|ZP022||
|810|D|D810|10482||
|810|E|E810|Zdravotní pojištění||
|810|F|F810|Průběh pojištění v daném měsíci||
|810|G|G810|Pojistné za zaměstnavatele||
|810|K|K810|x||
|810|L|L810|úprava prefillu - vzorce||
|810|M|M810|nahrazení zrušeného atributu v důsledku změny z 28.2.2025 v tomto change logu||
|811|A|A811|3.3.2025||
|811|B|B811|1.2||
|811|C|C811|ZP022||
|811|D|D811|10370||
|811|E|E811|Sociální pojištění||
|811|F|F811|Průběh pojištění v daném měsíci||
|811|G|G811|Pojistné za zaměstnance||
|811|K|K811|x||
|811|L|L811|úprava prefillu - vzorce||
|811|M|M811|nahrazení zrušeného atributu v důsledku změny z 28.2.2025 v tomto change logu||
|812|A|A812|3.3.2025||
|812|B|B812|1.2||
|812|C|C812|ZP022||
|812|D|D812|10371||
|812|E|E812|Zdravotní pojištění||
|812|F|F812|Průběh pojištění v daném měsíci||
|812|G|G812|Pojistné za zaměstnance||
|812|K|K812|x||
|812|L|L812|úprava prefillu - vzorce||
|812|M|M812|nahrazení zrušeného atributu v důsledku změny z 28.2.2025 v tomto change logu||
|813|A|A813|3.3.2025||
|813|B|B813|1.2||
|813|C|C813|ZP021||
|813|D|D813|10239||
|813|E|E813|Druh činnosti||
|813|F|F813|Vykonávaná pozice zaměstnance||
|813|G|G813|Činnost||
|813|J|J813|x||
|813|K|K813|x||
|813|L|L813|úprava číselníku||
|813|M|M813|úprava kódů položek podle dokumentace od Aricomy||
|814|A|A814|3.3.2025||
|814|B|B814|1.2||
|814|C|C814|ZP023||
|814|D|D814|10492||
|814|E|E814|Kód státu zahraniční právnické osoby nebo zahraniční fyzické osoby||
|814|F|F814|Vykonávaná pozice zaměstnance||
|814|G|G814|Forma práce||
|814|H|H814|Dočasné přidělení||
|814|K|K814|x||
|814|L|L814|přidání atributu||
|814|M|M814|Rozšíření identifikátorů pro Dočasné přidělení u uživatele na žádost MPSV Sekce 4||
|815|A|A815|3.3.2025||
|815|B|B815|1.2||
|815|C|C815|ZP023||
|815|D|D815|10493||
|815|E|E815|Registrační číslo zahraniční právnické osoby nebo identifikace zahraniční fyzické osoby||
|815|F|F815|Vykonávaná pozice zaměstnance||
|815|G|G815|Forma práce||
|815|H|H815|Dočasné přidělení||
|815|K|K815|x||
|815|L|L815|přidání atributu||
|815|M|M815|Rozšíření identifikátorů pro Dočasné přidělení u uživatele na žádost MPSV Sekce 4||
|816|A|A816|3.3.2025||
|816|B|B816|1.2||
|816|C|C816|ZP023||
|816|D|D816|10494||
|816|E|E816|Název zahraniční právnické osoby nebo zahraniční fyzické osoby||
|816|F|F816|Vykonávaná pozice zaměstnance||
|816|G|G816|Forma práce||
|816|H|H816|Dočasné přidělení||
|816|K|K816|x||
|816|L|L816|přidání atributu||
|816|M|M816|Rozšíření identifikátorů pro Dočasné přidělení u uživatele na žádost MPSV Sekce 4||
|817|A|A817|4.3.2025||
|817|B|B817|1.3||
|817|D|D817|10370||
|817|E|E817|Sociální pojištění||
|817|F|F817|Průběh pojištění v daném měsíci||
|817|G|G817|Pojistné za zaměstnance||
|817|K|K817|x||
|817|L|L817|úprava prefillu - vzorce||
|817|M|M817|změna atributu vyměřovacího základu na 10477||
|818|A|A818|4.3.2025||
|818|B|B818|1.3||
|818|D|D818|10486||
|818|E|E818|Úhrn vyměřovacích základů zaměstnanců||
|818|F|F818|Přehled o výši pojistného||
|818|G|G818|Souhrn||
|818|H|H818|Slevy na pojistném zaměstnanců||
|818|K|K818|x||
|818|L|L818|úprava prefillu - vzorce||
|818|M|M818|změna atributu vyměřovacího základu na 10477||
|819|A|A819|4.3.2025||
|819|B|B819|1.3||
|819|D|D819|10491||
|819|E|E819|Výše slevy na pojistném zaměstnance||
|819|F|F819|Průběh pojištění v daném měsíci||
|819|G|G819|Sleva na pojistném||
|819|K|K819|x||
|819|L|L819|nově definovaný prefill - vzorec||
|819|M|M819|Doplněn vzorec pro výpočet na základě nově přidaného atributu a změna typu prefill||
|820|A|A820|6.3.2025||
|820|B|B820|1.3||
|820|D|D820|10239||
|820|E|E820|Druh činnosti||
|820|F|F820|Vykonávaná pozice zaměstnance||
|820|G|G820|Činnost||
|820|J|J820|x||
|820|K|K820|x||
|820|L|L820|úprava číselníku||
|820|M|M820|na základě změny číselníku ze strany architektury ČSSZ||
|821|A|A821|7.3.2025||
|821|B|B821|1.3||
|821|D|D821|10482||
|821|E|E821|Zdravotní pojištění||
|821|F|F821|Průběh pojištění v daném měsíci||
|821|G|G821|Pojistné za zaměstnavatele||
|821|K|K821|x||
|821|L|L821|odstranění prefillu||
|821|M|M821|zrušení pedvyplnění, zdravotní pojišťovny nejsou zapojeny v úvodní fázi||
|822|A|A822|7.3.2025||
|822|B|B822|1.3||
|822|D|D822|10371||
|822|E|E822|Zdravotní pojištění||
|822|F|F822|Průběh pojištění v daném měsíci||
|822|G|G822|Pojistné za zaměstnance||
|822|K|K822|x||
|822|L|L822|odstranění prefillu||
|822|M|M822|zrušení pedvyplnění, zdravotní pojišťovny nejsou zapojeny v úvodní fázi||
|823|A|A823|7.3.2025||
|823|B|B823|1.3||
|823|D|D823|10473||
|823|E|E823|Počet dnů omluvené nepřítomnosti, za které nenáleží náhrada příjmu (neplacené volno, stávka)||
|823|F|F823|Průběh pojištění v daném měsíci||
|823|G|G823|Vyloučené dny||
|823|H|H823|§ 18 odst. 7 zákona č. 187/2006 Sb.||
|823|K|K823|x||
|823|L|L823|úprava konzumace atributu||
|823|M|M823|přidání ČSÚ mezi uživatele atributu na základě žádosti ČSÚ zprostředkované MPSV sekcí 7||
|824|A|A824|7.3.2025||
|824|B|B824|1.3||
|824|D|D824|10474||
|824|E|E824|Počet dnů dočasné pracovní neschopnosti nebo karantény, za které náleží náhrada příjmu||
|824|F|F824|Průběh pojištění v daném měsíci||
|824|G|G824|Vyloučené dny||
|824|H|H824|§ 18 odst. 7 zákona č. 187/2006 Sb.||
|824|K|K824|x||
|824|L|L824|úprava konzumace atributu||
|824|M|M824|přidání ČSÚ mezi uživatele atributu na základě žádosti ČSÚ zprostředkované MPSV sekcí 7||
|825|A|A825|7.3.2025||
|825|B|B825|1.3||
|825|D|D825|10475||
|825|E|E825|Počet dnů, za které bylo zaměstnanci vypláceno nemocenské, peněžitá pomoc v mateřství, otcovská, ošetřovné nebo dlouhodobé ošetřovné ||
|825|F|F825|Průběh pojištění v daném měsíci||
|825|G|G825|Vyloučené dny||
|825|H|H825|§ 18 odst. 7 zákona č. 187/2006 Sb.||
|825|K|K825|x||
|825|L|L825|úprava konzumace atributu||
|825|M|M825|přidání ČSÚ mezi uživatele atributu na základě žádosti ČSÚ zprostředkované MPSV sekcí 7||
|826|A|A826|7.3.2025||
|826|B|B826|1.3||
|826|D|D826|10476||
|826|E|E826|Vykázaný příjem z nepojištěné činnosti ||
|826|F|F826|Průběh pojištění v daném měsíci||
|826|G|G826|Vyměřovací základ||
|826|K|K826|x||
|826|L|L826|úprava konzumace atributu||
|826|M|M826|přidání ČSÚ mezi uživatele atributu na základě žádosti ČSÚ zprostředkované MPSV sekcí 7||
|827|A|A827|7.3.2025||
|827|B|B827|1.3||
|827|D|D827|10480||
|827|E|E827|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ ||
|827|F|F827|Průběh pojištění v daném měsíci||
|827|G|G827|Vyměřovací základ||
|827|K|K827|x||
|827|L|L827|úprava konzumace atributu||
|827|M|M827|přidání ČSÚ mezi uživatele atributu na základě žádosti ČSÚ zprostředkované MPSV sekcí 7||
|828|A|A828|10.3.2025||
|828|B|B828|1.3||
|828|D|D828|10001||
|828|E|E828|GUID podání||
|828|F|F828|Meta atributy||
|828|G|G828|Podání||
|828|I|I828|x||
|828|J|J828|x||
|828|L|L828|změna typu hlášení||
|828|M|M828|redukce nevyužitých atributů z REGZEC a REGZEL podání na podnět architektury||
|829|A|A829|10.3.2025||
|829|B|B829|1.3||
|829|D|D829|10470||
|829|E|E829|Kanál podání||
|829|F|F829|Meta atributy||
|829|G|G829|Podání||
|829|I|I829|x||
|829|J|J829|x||
|829|L|L829|změna typu hlášení||
|829|M|M829|redukce nevyužitých atributů z REGZEC a REGZEL podání na podnět architektury||
|830|A|A830|10.3.2025||
|830|B|B830|1.3||
|830|D|D830|10002||
|830|E|E830|Pořadí balíku dat||
|830|F|F830|Meta atributy||
|830|G|G830|Podání||
|830|J|J830|x||
|830|L|L830|změna typu hlášení||
|830|M|M830|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|831|A|A831|10.3.2025||
|831|B|B831|1.3||
|831|D|D831|10003||
|831|E|E831|Počet balíků dat||
|831|F|F831|Meta atributy||
|831|G|G831|Podání||
|831|J|J831|x||
|831|L|L831|změna typu hlášení||
|831|M|M831|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|832|A|A832|10.3.2025||
|832|B|B832|1.3||
|832|D|D832|10015||
|832|E|E832|Počet formulářů v balíku dat||
|832|F|F832|Meta atributy||
|832|G|G832|Podání||
|832|J|J832|x||
|832|L|L832|změna typu hlášení||
|832|M|M832|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|833|A|A833|10.3.2025||
|833|B|B833|1.3||
|833|D|D833|10488||
|833|E|E833|Počet formulářů celkem||
|833|F|F833|Meta atributy||
|833|G|G833|Podání||
|833|J|J833|x||
|833|L|L833|změna typu hlášení||
|833|M|M833|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|834|A|A834|10.3.2025||
|834|B|B834|1.3||
|834|D|D834|10006||
|834|E|E834|Datum a čas přijetí podání||
|834|F|F834|Meta atributy||
|834|G|G834|Podání||
|834|I|I834|x||
|834|J|J834|x||
|834|L|L834|změna typu hlášení||
|834|M|M834|redukce nevyužitých atributů z REGZEC a REGZEL podání na podnět architektury||
|835|A|A835|10.3.2025||
|835|B|B835|1.3||
|835|D|D835|10012||
|835|E|E835|GUID formuláře||
|835|F|F835|Meta atributy||
|835|G|G835|Formulář||
|835|J|J835|x||
|835|L|L835|změna typu hlášení||
|835|M|M835|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|836|A|A836|10.3.2025||
|836|B|B836|1.3||
|836|D|D836|10016||
|836|E|E836|Typ formuláře||
|836|F|F836|Meta atributy||
|836|G|G836|Formulář||
|836|J|J836|x||
|836|L|L836|změna typu hlášení||
|836|M|M836|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|837|A|A837|10.3.2025||
|837|B|B837|1.3||
|837|D|D837|10017||
|837|E|E837|Stav formuláře||
|837|F|F837|Meta atributy||
|837|G|G837|Formulář||
|837|J|J837|x||
|837|L|L837|změna typu hlášení||
|837|M|M837|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|838|A|A838|10.3.2025||
|838|B|B838|1.3||
|838|D|D838|10018||
|838|E|E838|Důvod odmítnutí||
|838|F|F838|Meta atributy||
|838|G|G838|Formulář||
|838|J|J838|x||
|838|L|L838|změna typu hlášení||
|838|M|M838|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|839|A|A839|10.3.2025||
|839|B|B839|1.3||
|839|D|D839|10019||
|839|E|E839|Datum a čas zpracování formuláře||
|839|F|F839|Meta atributy||
|839|G|G839|Formulář||
|839|J|J839|x||
|839|L|L839|změna typu hlášení||
|839|M|M839|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|840|A|A840|10.3.2025||
|840|B|B840|1.3||
|840|D|D840|10020||
|840|E|E840|Datum a čas zapsání IK MPSV||
|840|F|F840|Meta atributy||
|840|G|G840|Formulář||
|840|J|J840|x||
|840|L|L840|změna typu hlášení||
|840|M|M840|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|841|A|A841|10.3.2025||
|841|B|B841|1.3||
|841|D|D841|10461||
|841|E|E841|AIFO||
|841|F|F841|Zaměstnanec / Žák / Student ||
|841|G|G841|Základní identifikace||
|841|J|J841|x||
|841|L|L841|změna typu hlášení||
|841|M|M841|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|842|A|A842|10.3.2025||
|842|B|B842|1.3||
|842|D|D842|10399||
|842|E|E842|DMS reference||
|842|F|F842|Příloha||
|842|J|J842|x||
|842|L|L842|změna typu hlášení||
|842|M|M842|redukce nevyužitých atributů z REGZEC podání na podnět architektury||
|843|A|A843|12.3.2025||
|843|B|B843|1.3||
|843|D|D843|10075||
|843|E|E843|Typ adresy||
|843|F|F843|Zaměstnanec / Žák / Student ||
|843|G|G843|Adresa||
|843|J|J843|x||
|843|L|L843|úprava číselníku||
|843|M|M843|na žádost metodiky ČSSZ||
|844|A|A844|19.3.2025||
|844|B|B844|1.3||
|844|D|D844|10381||
|844|E|E844|Důvod ukončení služebního poměru||
|844|F|F844|Informace pro podporu v nezaměstnanosti||
|844|G|G844|Důvody||
|844|J|J844|x||
|844|L|L844|úprava číselníku||
|844|M|M844|na základě aktualizace číselníku ze strany MPSV||
|845|A|A845|19.3.2025||
|845|B|B845|1.3||
|845|D|D845|10328||
|845|E|E845|Mzda za práci zúčtovaná||
|845|F|F845|Mzda||
|845|G|G845|Mzda zúčtovaná||
|845|K|K845|x||
|845|L|L845|změna oblasti a třídy atributu||
|845|M|M845|na základě konzultace s výrobci SW||
|846|A|A846|19.3.2025||
|846|B|B846|1.3||
|846|D|D846|10329||
|846|E|E846|Tarifní mzdy||
|846|F|F846|Mzda||
|846|G|G846|Mzda zúčtovaná||
|846|K|K846|x||
|846|L|L846|změna oblasti a třídy atributu||
|846|M|M846|na základě konzultace s výrobci SW||
|847|A|A847|19.3.2025||
|847|B|B847|1.3||
|847|D|D847|10330||
|847|E|E847|Prémie a odměny pravidelné||
|847|F|F847|Mzda||
|847|G|G847|Mzda zúčtovaná||
|847|K|K847|x||
|847|L|L847|změna oblasti a třídy atributu||
|847|M|M847|na základě konzultace s výrobci SW||
|848|A|A848|19.3.2025||
|848|B|B848|1.3||
|848|D|D848|10331||
|848|E|E848|Prémie a odměny nepravidelné||
|848|F|F848|Mzda||
|848|G|G848|Mzda zúčtovaná||
|848|K|K848|x||
|848|L|L848|změna oblasti a třídy atributu||
|848|M|M848|na základě konzultace s výrobci SW||
|849|A|A849|19.3.2025||
|849|B|B849|1.3||
|849|D|D849|10332||
|849|E|E849|Příplatky celkem||
|849|F|F849|Mzda||
|849|G|G849|Příplatky||
|849|K|K849|x||
|849|L|L849|změna oblasti atributu||
|849|M|M849|na základě konzultace s výrobci SW||
|850|A|A850|19.3.2025||
|850|B|B850|1.3||
|850|D|D850|10333||
|850|E|E850|Příplatky za práci přesčas||
|850|F|F850|Mzda||
|850|G|G850|Příplatky||
|850|K|K850|x||
|850|L|L850|změna oblasti atributu||
|850|M|M850|na základě konzultace s výrobci SW||
|851|A|A851|19.3.2025||
|851|B|B851|1.3||
|851|D|D851|10334||
|851|E|E851|Příplatky za práci v noci||
|851|F|F851|Mzda||
|851|G|G851|Příplatky||
|851|K|K851|x||
|851|L|L851|změna oblasti atributu||
|851|M|M851|na základě konzultace s výrobci SW||
|852|A|A852|19.3.2025||
|852|B|B852|1.3||
|852|D|D852|10335||
|852|E|E852|Příplatky za práci o sobotách a nedělích||
|852|F|F852|Mzda||
|852|G|G852|Příplatky||
|852|K|K852|x||
|852|L|L852|změna oblasti atributu||
|852|M|M852|na základě konzultace s výrobci SW||
|853|A|A853|19.3.2025||
|853|B|B853|1.3||
|853|D|D853|10336||
|853|E|E853|Příplatky za práci ve svátek||
|853|F|F853|Mzda||
|853|G|G853|Příplatky||
|853|K|K853|x||
|853|L|L853|změna oblasti atributu||
|853|M|M853|na základě konzultace s výrobci SW||
|854|A|A854|19.3.2025||
|854|B|B854|1.3||
|854|D|D854|10337||
|854|E|E854|Náhrady mzdy zúčtované||
|854|F|F854|Mzda||
|854|G|G854|Náhrady||
|854|K|K854|x||
|854|L|L854|změna oblasti atributu||
|854|M|M854|na základě konzultace s výrobci SW||
|855|A|A855|19.3.2025||
|855|B|B855|1.3||
|855|D|D855|10338||
|855|E|E855|Náhrady za dovolenou||
|855|F|F855|Mzda||
|855|G|G855|Náhrady||
|855|K|K855|x||
|855|L|L855|změna oblasti atributu||
|855|M|M855|na základě konzultace s výrobci SW||
|856|A|A856|19.3.2025||
|856|B|B856|1.3||
|856|D|D856|10339||
|856|E|E856|Náhrady za mzdy za svátky||
|856|F|F856|Mzda||
|856|G|G856|Náhrady||
|856|K|K856|x||
|856|L|L856|změna oblasti atributu||
|856|M|M856|na základě konzultace s výrobci SW||
|857|A|A857|19.3.2025||
|857|B|B857|1.3||
|857|D|D857|10340||
|857|E|E857|Náhrady - překážky na straně zaměstnavatele||
|857|F|F857|Mzda||
|857|G|G857|Náhrady||
|857|K|K857|x||
|857|L|L857|změna oblasti atributu||
|857|M|M857|na základě konzultace s výrobci SW||
|858|A|A858|19.3.2025||
|858|B|B858|1.3||
|858|D|D858|10341||
|858|E|E858|Náhrady - překážky na straně zaměstnance||
|858|F|F858|Mzda||
|858|G|G858|Náhrady||
|858|K|K858|x||
|858|L|L858|změna oblasti atributu||
|858|M|M858|na základě konzultace s výrobci SW||
|859|A|A859|19.3.2025||
|859|B|B859|1.3||
|859|D|D859|10342||
|859|E|E859|Náhrady při dočasné pracovní neschopnosti (bez srážek nad rámec §192/3 zákoníku práce)||
|859|F|F859|Mzda||
|859|G|G859|Náhrady||
|859|K|K859|x||
|859|L|L859|změna oblasti atributu||
|859|M|M859|na základě konzultace s výrobci SW||
|860|A|A860|19.3.2025||
|860|B|B860|1.3||
|860|D|D860|10343||
|860|E|E860|Odměny za pracovní pohotovost||
|860|F|F860|Mzda||
|860|G|G860|Odměny||
|860|K|K860|x||
|860|L|L860|změna oblasti atributu||
|860|M|M860|na základě konzultace s výrobci SW||
|861|A|A861|19.3.2025||
|861|B|B861|1.3||
|861|D|D861|10344||
|861|E|E861|Čistá mzda||
|861|F|F861|Mzda||
|861|G|G861|Výdělek||
|861|K|K861|x||
|861|L|L861|změna oblasti atributu||
|861|M|M861|na základě konzultace s výrobci SW||
|862|A|A862|19.3.2025||
|862|B|B862|1.3||
|862|D|D862|10345||
|862|E|E862|Průměrný (hrubý) hodinový výdělek||
|862|F|F862|Mzda||
|862|G|G862|Výdělek||
|862|K|K862|x||
|862|L|L862|změna oblasti atributu||
|862|M|M862|na základě konzultace s výrobci SW||
|863|A|A863|19.3.2025||
|863|B|B863|1.3||
|863|D|D863|10348||
|863|E|E863|Mzda/plat nebo jeho část vyplacena v hotovosti ||
|863|F|F863|Mzda||
|863|G|G863|Výdělek osob OZP||
|863|K|K863|x||
|863|L|L863|změna oblasti atributu||
|863|M|M863|na základě konzultace s výrobci SW||
|864|A|A864|19.3.2025||
|864|B|B864|1.3||
|864|D|D864|10349||
|864|E|E864|Provedeny srážky ze mzdy nebo platu určené k uspokojení plnění zaměstnavatele||
|864|F|F864|Mzda||
|864|G|G864|Výdělek osob OZP||
|864|K|K864|x||
|864|L|L864|změna oblasti atributu||
|864|M|M864|na základě konzultace s výrobci SW||
|865|A|A865|19.3.2025||
|865|B|B865|1.3||
|865|D|D865|10347||
|865|E|E865|Datum úhrady mzdy včetně odvodů na soc. a zdravotní pojištění||
|865|F|F865|Mzda||
|865|G|G865|Výdělek osob OZP||
|865|K|K865|x||
|865|L|L865|změna oblasti atributu||
|865|M|M865|na základě konzultace s výrobci SW||
|866|A|A866|19.3.2025||
|866|B|B866|1.3||
|866|D|D866|10350||
|866|E|E866|Srážky k uspokojení plnění zaměstnavatele podle občanského zákoníku||
|866|F|F866|Mzda||
|866|G|G866|Srážky ze mzdy||
|866|K|K866|x||
|866|L|L866|změna oblasti atributu||
|866|M|M866|na základě konzultace s výrobci SW||
|867|A|A867|19.3.2025||
|867|B|B867|1.3||
|867|D|D867|10351||
|867|E|E867|Srážky k uhrazení škody, za kterou odpovídá zaměstnanec||
|867|F|F867|Mzda||
|867|G|G867|Srážky ze mzdy||
|867|K|K867|x||
|867|L|L867|změna oblasti atributu||
|867|M|M867|na základě konzultace s výrobci SW||
|868|A|A868|19.3.2025||
|868|B|B868|1.3||
|868|D|D868|10352||
|868|E|E868|Srážky na závodní stravování pode §236 zákoníku práce,||
|868|F|F868|Mzda||
|868|G|G868|Srážky ze mzdy||
|868|K|K868|x||
|868|L|L868|změna oblasti atributu||
|868|M|M868|na základě konzultace s výrobci SW||
|869|A|A869|19.3.2025||
|869|B|B869|1.3||
|869|D|D869|10353||
|869|E|E869|Srážky k uspokojení závazků zaměstnance podle § 146 písm. b) zákoníku práce||
|869|F|F869|Mzda||
|869|G|G869|Srážky ze mzdy||
|869|K|K869|x||
|869|L|L869|změna oblasti atributu||
|869|M|M869|na základě konzultace s výrobci SW||
|870|A|A870|19.3.2025||
|870|B|B870|1.3||
|870|D|D870|10376||
|870|E|E870|Důvod neposkytnutí podkladů||
|870|F|F870|Ukončení pracovněprávního vztahu||
|870|G|G870|Informace pro podporu v nezaměstnanosti||
|870|H|H870|Důvody||
|870|J|J870|x||
|870|L|L870|změna oblasti a třídy atributu||
|870|M|M870|na základě konzultace s výrobci SW||
|871|A|A871|19.3.2025||
|871|B|B871|1.3||
|871|D|D871|10377||
|871|E|E871|Průměrný měsíční čistý (pravděpodobný) výdělek||
|871|F|F871|Ukončení pracovněprávního vztahu||
|871|G|G871|Informace pro podporu v nezaměstnanosti||
|871|H|H871|Výdělek||
|871|J|J871|x||
|871|L|L871|změna oblasti a třídy atributu||
|871|M|M871|na základě konzultace s výrobci SW||
|872|A|A872|19.3.2025||
|872|B|B872|1.3||
|872|D|D872|10378||
|872|E|E872|Náleží||
|872|F|F872|Ukončení pracovněprávního vztahu||
|872|G|G872|Odchodné / odbytné / odstupné||
|872|J|J872|x||
|872|L|L872|změna oblasti atributu||
|872|M|M872|na základě konzultace s výrobci SW||
|873|A|A873|19.3.2025||
|873|B|B873|1.3||
|873|D|D873|10379||
|873|E|E873|Vyplaceno v plné výši  ||
|873|F|F873|Ukončení pracovněprávního vztahu||
|873|G|G873|Odchodné / odbytné / odstupné||
|873|J|J873|x||
|873|L|L873|změna oblasti atributu||
|873|M|M873|na základě konzultace s výrobci SW||
|874|A|A874|19.3.2025||
|874|B|B874|1.3||
|874|D|D874|10380||
|874|E|E874|Důvod ukončení pracovně právního vztahu||
|874|F|F874|Ukončení pracovněprávního vztahu||
|874|G|G874|Informace pro podporu v nezaměstnanosti||
|874|H|H874|Důvody||
|874|J|J874|x||
|874|L|L874|změna oblasti a třídy atributu||
|874|M|M874|na základě konzultace s výrobci SW||
|875|A|A875|19.3.2025||
|875|B|B875|1.3||
|875|D|D875|10381||
|875|E|E875|Důvod ukončení služebního poměru||
|875|F|F875|Ukončení pracovněprávního vztahu||
|875|G|G875|Informace pro podporu v nezaměstnanosti||
|875|H|H875|Důvody||
|875|J|J875|x||
|875|L|L875|změna oblasti a třídy atributu||
|875|M|M875|na základě konzultace s výrobci SW||
|876|A|A876|19.3.2025||
|876|B|B876|1.3||
|876|D|D876|10382||
|876|E|E876|Násobek příjmu: (PV) Odstupné dle § 67 odst. 1 ZP||
|876|F|F876|Ukončení pracovněprávního vztahu||
|876|G|G876|Odchodné / odbytné / odstupné||
|876|J|J876|x||
|876|L|L876|změna oblasti atributu||
|876|M|M876|na základě konzultace s výrobci SW||
|877|A|A877|19.3.2025||
|877|B|B877|1.3||
|877|D|D877|10383||
|877|E|E877|Násobek příjmu: (PV) Odstupné dle § 67 odst. 2 ZP||
|877|F|F877|Ukončení pracovněprávního vztahu||
|877|G|G877|Odchodné / odbytné / odstupné||
|877|J|J877|x||
|877|L|L877|změna oblasti atributu||
|877|M|M877|na základě konzultace s výrobci SW||
|878|A|A878|19.3.2025||
|878|B|B878|1.3||
|878|D|D878|10384||
|878|E|E878|Násobek příjmu: (SP) Odchodné||
|878|F|F878|Ukončení pracovněprávního vztahu||
|878|G|G878|Odchodné / odbytné / odstupné||
|878|J|J878|x||
|878|L|L878|změna oblasti atributu||
|878|M|M878|na základě konzultace s výrobci SW||
|879|A|A879|19.3.2025||
|879|B|B879|1.3||
|879|D|D879|10385||
|879|E|E879|Násobek příjmu: (SP) Odbytné||
|879|F|F879|Ukončení pracovněprávního vztahu||
|879|G|G879|Odchodné / odbytné / odstupné||
|879|J|J879|x||
|879|L|L879|změna oblasti atributu||
|879|M|M879|na základě konzultace s výrobci SW||
|880|A|A880|19.3.2025||
|880|B|B880|1.3||
|880|D|D880|10386||
|880|E|E880|Doba trvání důchodového pojištění ze zaměstnání od||
|880|F|F880|Ukončení pracovněprávního vztahu||
|880|G|G880|Informace pro podporu v nezaměstnanosti||
|880|H|H880|Důchodové pojištění||
|880|J|J880|x||
|880|L|L880|změna oblasti a třídy atributu||
|880|M|M880|na základě konzultace s výrobci SW||
|881|A|A881|19.3.2025||
|881|B|B881|1.3||
|881|D|D881|10387||
|881|E|E881|Doba trvání důchodového pojištění ze zaměstnání do||
|881|F|F881|Ukončení pracovněprávního vztahu||
|881|G|G881|Informace pro podporu v nezaměstnanosti||
|881|H|H881|Důchodové pojištění||
|881|J|J881|x||
|881|L|L881|změna oblasti a třídy atributu||
|881|M|M881|na základě konzultace s výrobci SW||
|882|A|A882|21.3.2025||
|882|B|B882|1.3||
|882|D|D882|10065||
|882|E|E882|Stát||
|882|F|F882|Zaměstnanec / Žák / Student ||
|882|G|G882|Základní identifikace||
|882|H|H882|Místo narození||
|882|J|J882|x||
|882|L|L882|úprava číselníku||
|882|M|M882|na základě rozhodnutí architektury ČSSZ||
|883|A|A883|21.3.2025||
|883|B|B883|1.3||
|883|D|D883|10067||
|883|E|E883|Státní občanství||
|883|F|F883|Zaměstnanec / Žák / Student ||
|883|G|G883|Základní identifikace||
|883|J|J883|x||
|883|L|L883|úprava číselníku||
|883|M|M883|na základě rozhodnutí architektury ČSSZ||
|884|A|A884|21.3.2025||
|884|B|B884|1.3||
|884|D|D884|10068||
|884|E|E884|Kód státu rezidenství||
|884|F|F884|Zaměstnanec / Žák / Student ||
|884|G|G884|Daňová identifikace ve státě rezidence||
|884|J|J884|x||
|884|K|K884|x||
|884|L|L884|úprava číselníku||
|884|M|M884|na základě rozhodnutí architektury ČSSZ||
|885|A|A885|21.3.2025||
|885|B|B885|1.3||
|885|D|D885|10072||
|885|E|E885|Kód státu, který doklady vydal||
|885|F|F885|Zaměstnanec / Žák / Student ||
|885|G|G885|Prokázání totožnosti||
|885|H|H885|Doklad||
|885|J|J885|x||
|885|L|L885|úprava číselníku||
|885|M|M885|na základě rozhodnutí architektury ČSSZ||
|886|A|A886|21.3.2025||
|886|B|B886|1.3||
|886|D|D886|10083||
|886|E|E886|Stát||
|886|F|F886|Zaměstnanec / Žák / Student ||
|886|G|G886|Adresa||
|886|J|J886|x||
|886|L|L886|úprava číselníku||
|886|M|M886|na základě rozhodnutí architektury ČSSZ||
|887|A|A887|21.3.2025||
|887|B|B887|1.3||
|887|D|D887|10099||
|887|E|E887|Stát||
|887|F|F887|Zaměstnanec / Žák / Student ||
|887|G|G887|Pojištění||
|887|H|H887|Cizozemský nositel pojištění||
|887|J|J887|x||
|887|L|L887|úprava číselníku||
|887|M|M887|na základě rozhodnutí architektury ČSSZ||
|888|A|A888|21.3.2025||
|888|B|B888|1.3||
|888|D|D888|10428||
|888|E|E888|Kód státu||
|888|F|F888|Zaměstnanec / Žák / Student ||
|888|G|G888|Příslušnost k cizím právním předpisům||
|888|J|J888|x||
|888|L|L888|úprava číselníku||
|888|M|M888|na základě rozhodnutí architektury ČSSZ||
|889|A|A889|21.3.2025||
|889|B|B889|1.3||
|889|D|D889|10124||
|889|E|E889|Stát, který IČ vydal||
|889|F|F889|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|889|G|G889|Identifikace||
|889|I|I889|x||
|889|L|L889|úprava číselníku||
|889|M|M889|na základě rozhodnutí architektury ČSSZ||
|890|A|A890|21.3.2025||
|890|B|B890|1.3||
|890|D|D890|10136||
|890|E|E890|Stát||
|890|F|F890|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|890|G|G890|Adresa||
|890|I|I890|x||
|890|L|L890|úprava číselníku||
|890|M|M890|na základě rozhodnutí architektury ČSSZ||
|891|A|A891|21.3.2025||
|891|B|B891|1.3||
|891|D|D891|10158||
|891|E|E891|Stát||
|891|F|F891|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|891|G|G891|Archivace dokladů||
|891|H|H891|Adresa||
|891|I|I891|x||
|891|L|L891|úprava číselníku||
|891|M|M891|na základě rozhodnutí architektury ČSSZ||
|892|A|A892|21.3.2025||
|892|B|B892|1.3||
|892|D|D892|10172||
|892|E|E892|Stát||
|892|F|F892|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|892|G|G892|Právní nástupnictví při zániku||
|892|H|H892|Adresa||
|892|I|I892|x||
|892|L|L892|úprava číselníku||
|892|M|M892|na základě rozhodnutí architektury ČSSZ||
|893|A|A893|21.3.2025||
|893|B|B893|1.3||
|893|D|D893|10181||
|893|E|E893|Stát||
|893|F|F893|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|893|G|G893|Právní nástupnictví při zániku||
|893|H|H893|Mzdová účtárna||
|893|I|I893|x||
|893|L|L893|úprava číselníku||
|893|M|M893|na základě rozhodnutí architektury ČSSZ||
|894|A|A894|21.3.2025||
|894|B|B894|1.3||
|894|D|D894|10193||
|894|E|E894|Stát||
|894|F|F894|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|894|G|G894|Mzdová účtárna zaměstnavatele||
|894|H|H894|Adresa||
|894|I|I894|x||
|894|L|L894|úprava číselníku||
|894|M|M894|na základě rozhodnutí architektury ČSSZ||
|895|A|A895|21.3.2025||
|895|B|B895|1.3||
|895|D|D895|10209||
|895|E|E895|Stát||
|895|F|F895|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|895|G|G895|Peněžní účty||
|895|H|H895|Peněžní ústav||
|895|I|I895|x||
|895|L|L895|úprava číselníku||
|895|M|M895|na základě rozhodnutí architektury ČSSZ||
|896|A|A896|21.3.2025||
|896|B|B896|1.3||
|896|D|D896|10405||
|896|E|E896|První země původu podle velikosti ||
|896|F|F896|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|896|G|G896|Kapitál k 31.12.||
|896|K|K896|x||
|896|L|L896|úprava číselníku||
|896|M|M896|na základě rozhodnutí architektury ČSSZ||
|897|A|A897|21.3.2025||
|897|B|B897|1.3||
|897|D|D897|10406||
|897|E|E897|Druhá země původu podle velikosti ||
|897|F|F897|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|897|G|G897|Kapitál k 31.12.||
|897|K|K897|x||
|897|L|L897|úprava číselníku||
|897|M|M897|na základě rozhodnutí architektury ČSSZ||
|898|A|A898|21.3.2025||
|898|B|B898|1.3||
|898|D|D898|10231||
|898|E|E898|Stát||
|898|F|F898|Vykonávaná pozice zaměstnance||
|898|G|G898|Místo výkonu práce / činnosti||
|898|H|H898|Adresa||
|898|K|K898|x||
|898|L|L898|úprava číselníku||
|898|M|M898|na základě rozhodnutí architektury ČSSZ||
|899|A|A899|21.3.2025||
|899|B|B899|1.3||
|899|D|D899|10492||
|899|E|E899|Kód státu zahraniční právnické osoby nebo zahraniční fyzické osoby||
|899|F|F899|Vykonávaná pozice zaměstnance||
|899|G|G899|Forma práce||
|899|H|H899|Dočasné přidělení||
|899|K|K899|x||
|899|L|L899|úprava číselníku||
|899|M|M899|na základě rozhodnutí architektury ČSSZ||
|900|A|A900|21.3.2025||
|900|B|B900|1.3||
|900|D|D900|10073||
|900|E|E900|Datum vydání||
|900|F|F900|Zaměstnanec / Žák / Student ||
|900|G|G900|Prokázání totožnosti||
|900|H|H900|Doklad||
|900|J|J900|x||
|900|L|L900|odstranění atributu||
|900|M|M900|na základě požadavku ze sběru datové potřeby||
|901|A|A901|21.3.2025||
|901|B|B901|1.3||
|901|D|D901|10074||
|901|E|E901|Datum platnosti||
|901|F|F901|Zaměstnanec / Žák / Student ||
|901|G|G901|Prokázání totožnosti||
|901|H|H901|Doklad||
|901|J|J901|x||
|901|L|L901|odstranění atributu||
|901|M|M901|na základě požadavku ze sběru datové potřeby||
|902|A|A902|21.3.2025||
|902|B|B902|1.3||
|902|D|D902|10404||
|902|E|E902|Podíl zahraničního kapitálu||
|902|F|F902|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|902|G|G902|Kapitál k 31.12.||
|902|K|K902|x||
|902|L|L902|odstranění atributu||
|902|M|M902|na základě požadavku ze sběru datové potřeby||
|903|A|A903|21.3.2025||
|903|B|B903|1.3||
|903|D|D903|10405||
|903|E|E903|První země původu podle velikosti ||
|903|F|F903|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|903|G|G903|Kapitál k 31.12.||
|903|K|K903|x||
|903|L|L903|odstranění atributu||
|903|M|M903|na základě požadavku ze sběru datové potřeby||
|904|A|A904|21.3.2025||
|904|B|B904|1.3||
|904|D|D904|10406||
|904|E|E904|Druhá země původu podle velikosti ||
|904|F|F904|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|904|G|G904|Kapitál k 31.12.||
|904|K|K904|x||
|904|L|L904|odstranění atributu||
|904|M|M904|na základě požadavku ze sběru datové potřeby||
|905|A|A905|21.3.2025||
|905|B|B905|1.3||
|905|D|D905|10429||
|905|E|E905|Zařazení do skupiny podle náročnosti vykonávané práce||
|905|F|F905|Vykonávaná pozice zaměstnance||
|905|G|G905|Profese||
|905|J|J905|x||
|905|L|L905|odstranění atributu||
|905|M|M905|na základě požadavku ze sběru datové potřeby||
|906|A|A906|21.3.2025||
|906|B|B906|1.3||
|906|D|D906|10489||
|906|E|E906|Bankovní spojení||
|906|F|F906|Přehled o výši pojistného||
|906|G|G906|Souhrn||
|906|H|H906|Platební údaje||
|906|K|K906|x||
|906|L|L906|odstranění atributu||
|906|M|M906|na základě požadavku ČSSZ||
|907|A|A907|21.3.2025||
|907|B|B907|1.3||
|907|D|D907|10236||
|907|E|E907|Pozice vykonávana od||
|907|F|F907|Vykonávaná pozice zaměstnance||
|907|G|G907|Pracovní místo / pozice||
|907|J|J907|x||
|907|L|L907|odstranění atributu||
|907|M|M907|na žádost ČSÚ (na základě dotazů od výrobců SW)||
|908|A|A908|21.3.2025||
|908|B|B908|1.3||
|908|D|D908|10308||
|908|E|E908|Odměna člena (nerezidenta) orgánu právnické osoby||
|908|F|F908|Příjem v daném měsíci||
|908|G|G908|Výpočet daně podle zvláštní sazby daně ||
|908|K|K908|x||
|908|L|L908|přidání atributu||
|908|M|M908|návrat atributu do DS na žádost FS||
|909|A|A909|21.3.2025||
|909|B|B909|1.3||
|909|D|D909|10310||
|909|E|E909|Sražená daň podle zvláštní sazby daně z příjmu nerezidenta člena orgánu právnické osoby||
|909|F|F909|Příjem v daném měsíci||
|909|G|G909|Výpočet daně podle zvláštní sazby daně ||
|909|K|K909|x||
|909|L|L909|přidání atributu||
|909|M|M909|návrat atributu do DS na žádost FS||
|910|A|A910|21.3.2025||
|910|B|B910|1.3||
|910|D|D910|10376||
|910|E|E910|Důvod neposkytnutí podkladů||
|910|F|F910|Ukončení pracovněprávního vztahu||
|910|G|G910|Informace pro podporu v nezaměstnanosti||
|910|H|H910|Důvody||
|910|J|J910|x||
|910|L|L910|úprava číselníku||
|910|M|M910|na žádost MPSV (na základě dotazů od výrobců SW)||
|911|A|A911|21.3.2025||
|911|B|B911|1.3||
|911|D|D911|10255||
|911|E|E911|Pracovní režim||
|911|F|F911|Vykonávaná pozice zaměstnance||
|911|G|G911|Režim práce||
|911|J|J911|x||
|911|L|L911|úprava číselníku||
|911|M|M911|na žádost ČSÚ (na základě dotazů od výrobců SW)||
|912|A|A912|21.3.2025||
|912|B|B912|1.3||
|912|D|D912|10495||
|912|E|E912|Primární pracovněprávní vztah zaměstnance||
|912|F|F912|Meta atributy||
|912|G|G912|Formulář||
|912|K|K912|x||
|912|L|L912|přidání atributu||
|912|M|M912|v rámci vytvoření nosiče pro souhrnná data zaměstnance||
|913|A|A913|21.3.2025||
|913|B|B913|1.3||
|913|D|D913|10415||
|913|E|E913|Zúčtovaný příjem - z toho příjem za bezplatné používání motorového vozidla||
|913|F|F913|Příjem v daném měsíci||
|913|G|G913|Příjem||
|913|K|K913|x||
|913|L|L913|odstranění atributu||
|913|M|M913|na základě vyjasnění ze sběru datové potřeby||
|914|A|A914|24.3.2025||
|914|B|B914|1.3||
|914|D|D914|10419||
|914|E|E914|Prohlášení poplatníka daně z příjmů ze závislé činnosti||
|914|F|F914|Souhrnná data zaměstnance||
|914|G|G914|Výpočet zálohy na daň||
|914|K|K914|x||
|914|L|L914|změna oblasti a třídy atributu||
|914|M|M914|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|915|A|A915|24.3.2025||
|915|B|B915|1.3||
|915|D|D915|10297||
|915|E|E915|Základ pro výpočet zálohy na daň||
|915|F|F915|Souhrnná data zaměstnance||
|915|G|G915|Výpočet zálohy na daň||
|915|K|K915|x||
|915|L|L915|změna oblasti a třídy atributu||
|915|M|M915|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|916|A|A916|24.3.2025||
|916|B|B916|1.3||
|916|D|D916|10298||
|916|E|E916|Vypočtená záloha na daň||
|916|F|F916|Souhrnná data zaměstnance||
|916|G|G916|Výpočet zálohy na daň||
|916|K|K916|x||
|916|L|L916|změna oblasti a třídy atributu||
|916|M|M916|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|917|A|A917|24.3.2025||
|917|B|B917|1.3||
|917|D|D917|10299||
|917|E|E917|Základní sleva na poplatníka||
|917|F|F917|Souhrnná data zaměstnance||
|917|G|G917|Výpočet zálohy na daň||
|917|K|K917|x||
|917|L|L917|změna oblasti a třídy atributu||
|917|M|M917|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|918|A|A918|24.3.2025||
|918|B|B918|1.3||
|918|D|D918|10300||
|918|E|E918|Základní sleva na invaliditu (I. nebo II. Stupeň)||
|918|F|F918|Souhrnná data zaměstnance||
|918|G|G918|Výpočet zálohy na daň||
|918|K|K918|x||
|918|L|L918|změna oblasti a třídy atributu||
|918|M|M918|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|919|A|A919|24.3.2025||
|919|B|B919|1.3||
|919|D|D919|10301||
|919|E|E919|Rozšířená sleva na invaliditu (III. Stupeň)||
|919|F|F919|Souhrnná data zaměstnance||
|919|G|G919|Výpočet zálohy na daň||
|919|K|K919|x||
|919|L|L919|změna oblasti a třídy atributu||
|919|M|M919|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|920|A|A920|24.3.2025||
|920|B|B920|1.3||
|920|D|D920|10302||
|920|E|E920|Sleva na držitele průkazu ZTP/P||
|920|F|F920|Souhrnná data zaměstnance||
|920|G|G920|Výpočet zálohy na daň||
|920|K|K920|x||
|920|L|L920|změna oblasti a třídy atributu||
|920|M|M920|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|921|A|A921|24.3.2025||
|921|B|B921|1.3||
|921|D|D921|10303||
|921|E|E921|Měsíční daňové zvýhodnění na děti||
|921|F|F921|Souhrnná data zaměstnance||
|921|G|G921|Výpočet zálohy na daň||
|921|K|K921|x||
|921|L|L921|změna oblasti a třídy atributu||
|921|M|M921|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|922|A|A922|24.3.2025||
|922|B|B922|1.3||
|922|D|D922|10453||
|922|E|E922|Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba||
|922|F|F922|Souhrnná data zaměstnance||
|922|G|G922|Výpočet zálohy na daň||
|922|H|H922|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|922|K|K922|x||
|922|L|L922|změna oblasti a třídy atributu||
|922|M|M922|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|923|A|A923|24.3.2025||
|923|B|B923|1.3||
|923|D|D923|10431||
|923|E|E923|Jméno||
|923|F|F923|Souhrnná data zaměstnance||
|923|G|G923|Výpočet zálohy na daň||
|923|H|H923|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|923|K|K923|x||
|923|L|L923|změna oblasti a třídy atributu||
|923|M|M923|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|924|A|A924|24.3.2025||
|924|B|B924|1.3||
|924|D|D924|10432||
|924|E|E924|Příjmení||
|924|F|F924|Souhrnná data zaměstnance||
|924|G|G924|Výpočet zálohy na daň||
|924|H|H924|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|924|K|K924|x||
|924|L|L924|změna oblasti a třídy atributu||
|924|M|M924|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|925|A|A925|24.3.2025||
|925|B|B925|1.3||
|925|D|D925|10433||
|925|E|E925|Datum narození||
|925|F|F925|Souhrnná data zaměstnance||
|925|G|G925|Výpočet zálohy na daň||
|925|H|H925|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|925|K|K925|x||
|925|L|L925|změna oblasti a třídy atributu||
|925|M|M925|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|926|A|A926|24.3.2025||
|926|B|B926|1.3||
|926|D|D926|10434||
|926|E|E926|Rodné číslo||
|926|F|F926|Souhrnná data zaměstnance||
|926|G|G926|Výpočet zálohy na daň||
|926|H|H926|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|926|K|K926|x||
|926|L|L926|změna oblasti a třídy atributu||
|926|M|M926|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|927|A|A927|24.3.2025||
|927|B|B927|1.3||
|927|D|D927|10435||
|927|E|E927|Jméno||
|927|F|F927|Souhrnná data zaměstnance||
|927|G|G927|Výpočet zálohy na daň||
|927|H|H927|Vyživované děti||
|927|K|K927|x||
|927|L|L927|změna oblasti a třídy atributu||
|927|M|M927|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|928|A|A928|24.3.2025||
|928|B|B928|1.3||
|928|D|D928|10436||
|928|E|E928|Příjmení||
|928|F|F928|Souhrnná data zaměstnance||
|928|G|G928|Výpočet zálohy na daň||
|928|H|H928|Vyživované děti||
|928|K|K928|x||
|928|L|L928|změna oblasti a třídy atributu||
|928|M|M928|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|929|A|A929|24.3.2025||
|929|B|B929|1.3||
|929|D|D929|10437||
|929|E|E929|Datum narození||
|929|F|F929|Souhrnná data zaměstnance||
|929|G|G929|Výpočet zálohy na daň||
|929|H|H929|Vyživované děti||
|929|K|K929|x||
|929|L|L929|změna oblasti a třídy atributu||
|929|M|M929|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|930|A|A930|24.3.2025||
|930|B|B930|1.3||
|930|D|D930|10438||
|930|E|E930|Rodné číslo||
|930|F|F930|Souhrnná data zaměstnance||
|930|G|G930|Výpočet zálohy na daň||
|930|H|H930|Vyživované děti||
|930|K|K930|x||
|930|L|L930|změna oblasti a třídy atributu||
|930|M|M930|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|931|A|A931|24.3.2025||
|931|B|B931|1.3||
|931|D|D931|10439||
|931|E|E931|Průkaz ZTP/P||
|931|F|F931|Souhrnná data zaměstnance||
|931|G|G931|Výpočet zálohy na daň||
|931|H|H931|Vyživované děti||
|931|K|K931|x||
|931|L|L931|změna oblasti a třídy atributu||
|931|M|M931|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|932|A|A932|24.3.2025||
|932|B|B932|1.3||
|932|D|D932|10440||
|932|E|E932|Pořadí pro určení výše daňového zvýhodnění||
|932|F|F932|Souhrnná data zaměstnance||
|932|G|G932|Výpočet zálohy na daň||
|932|H|H932|Vyživované děti||
|932|K|K932|x||
|932|L|L932|změna oblasti a třídy atributu||
|932|M|M932|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|933|A|A933|24.3.2025||
|933|B|B933|1.3||
|933|D|D933|10304||
|933|E|E933|Měsíční sleva na děti||
|933|F|F933|Souhrnná data zaměstnance||
|933|G|G933|Výpočet zálohy na daň||
|933|K|K933|x||
|933|L|L933|změna oblasti a třídy atributu||
|933|M|M933|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|934|A|A934|24.3.2025||
|934|B|B934|1.3||
|934|D|D934|10305||
|934|E|E934|Skutečně sražená záloha na daň po uplatnění slev||
|934|F|F934|Souhrnná data zaměstnance||
|934|G|G934|Výpočet zálohy na daň||
|934|K|K934|x||
|934|L|L934|změna oblasti a třídy atributu||
|934|M|M934|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|935|A|A935|24.3.2025||
|935|B|B935|1.3||
|935|D|D935|10306||
|935|E|E935|Výše vyplaceného měsíčního daňového bonusu||
|935|F|F935|Souhrnná data zaměstnance||
|935|G|G935|Výpočet zálohy na daň||
|935|K|K935|x||
|935|L|L935|změna oblasti a třídy atributu||
|935|M|M935|vytvoření oblasti Souhrnná data zaměstnance (změnový požadavek FS)||
|936|A|A936|24.3.2025||
|936|B|B936|1.3||
|936|D|D936|10344||
|936|E|E936|Čistá mzda||
|936|F|F936|Souhrnná data zaměstnance||
|936|G|G936|Mzda||
|936|H|H936|Výdělek||
|936|K|K936|x||
|936|L|L936|změna oblasti a třídy atributu||
|936|M|M936|vytvoření oblasti Souhrnná data zaměstnance (na základě dotazů výrobců SW)||
|937|A|A937|24.3.2025||
|937|B|B937|1.3||
|937|D|D937|10116||
|937|E|E937|Srážky na základě nařízeného soudního nebo správního výkonu rozhodnutí, konkursu nebo dohody o srážkách z příjmu||
|937|F|F937|Souhrnná data zaměstnance||
|937|G|G937|Srážky z příjmu||
|937|J|J937|x||
|937|K|K937|x||
|937|L|L937|změna typu hlášení||
|937|M|M937|vytvoření oblasti Souhrnná data zaměstnance (na základě dotazů výrobců SW)||
|938|A|A938|24.3.2025||
|938|B|B938|1.3||
|938|D|D938|10116||
|938|E|E938|Srážky na základě nařízeného soudního nebo správního výkonu rozhodnutí, konkursu nebo dohody o srážkách z příjmu||
|938|F|F938|Souhrnná data zaměstnance||
|938|G|G938|Srážky z příjmu||
|938|K|K938|x||
|938|L|L938|změna oblasti atributu||
|938|M|M938|vytvoření oblasti Souhrnná data zaměstnance (na základě dotazů výrobců SW)||
|939|A|A939|24.3.2025||
|939|B|B939|1.3||
|939|D|D939|10116||
|939|E|E939|Srážky na základě nařízeného soudního nebo správního výkonu rozhodnutí, konkursu nebo dohody o srážkách z příjmu||
|939|F|F939|Souhrnná data zaměstnance||
|939|G|G939|Srážky z příjmu||
|939|K|K939|x||
|939|L|L939|úprava konzumace atributu||
|939|M|M939|přidání MPSV ke konzumentům atributu||
|940|A|A940|24.3.2025||
|940|B|B940|1.3||
|940|D|D940|10482||
|940|E|E940|Zdravotní pojištění||
|940|F|F940|Souhrnná data zaměstnance||
|940|G|G940|Pojistné za zaměstnavatele||
|940|K|K940|x||
|940|L|L940|změna oblasti atributu||
|940|M|M940|vytvoření oblasti Souhrnná data zaměstnance (na základě dotazů výrobců SW)||
|941|A|A941|24.3.2025||
|941|B|B941|1.3||
|941|D|D941|10371||
|941|E|E941|Zdravotní pojištění||
|941|F|F941|Souhrnná data zaměstnance||
|941|G|G941|Pojistné za zaměstnance||
|941|K|K941|x||
|941|L|L941|změna oblasti atributu||
|941|M|M941|vytvoření oblasti Souhrnná data zaměstnance (na základě dotazů výrobců SW)||
|942|A|A942|25.3.2025||
|942|B|B942|1.3||
|942|D|D942|10496||
|942|E|E942|Výše exekučních srážek ze mzdy včetně výše tzv. nezabavitelné částky||
|942|F|F942|Souhrnná data zaměstnance||
|942|G|G942|Mzda||
|942|H|H942|Srážky ze mzdy||
|942|K|K942|x||
|942|L|L942|přidání atributu||
|942|M|M942|na základě požadavku MPSV||
|943|A|A943|25.3.2025||
|943|B|B943|1.3||
|943|D|D943|10497||
|943|E|E943|Výše exekučních srážek z důchodů včetně výše tzv. nezabavitelné částky||
|943|F|F943|Souhrnná data zaměstnance||
|943|G|G943|Mzda||
|943|H|H943|Srážky ze mzdy||
|943|K|K943|x||
|943|L|L943|přidání atributu||
|943|M|M943|na základě požadavku MPSV||
|944|A|A944|25.3.2025||
|944|B|B944|1.3||
|944|D|D944|10498||
|944|E|E944|Výše exekučních srážek z nemocenských dávek včetně výše tzv. nezabavitelné částky||
|944|F|F944|Souhrnná data zaměstnance||
|944|G|G944|Mzda||
|944|H|H944|Srážky ze mzdy||
|944|K|K944|x||
|944|L|L944|přidání atributu||
|944|M|M944|na základě požadavku MPSV||
|945|A|A945|25.3.2025||
|945|B|B945|1.3||
|945|D|D945|10499||
|945|E|E945|Výše insolvenčních srážek ze mzdy včetně výše tzv. nezabavitelné částky||
|945|F|F945|Souhrnná data zaměstnance||
|945|G|G945|Mzda||
|945|H|H945|Srážky ze mzdy||
|945|K|K945|x||
|945|L|L945|přidání atributu||
|945|M|M945|na základě požadavku MPSV||
|946|A|A946|25.3.2025||
|946|B|B946|1.3||
|946|D|D946|10500||
|946|E|E946|Výše insolvenčních srážek z důchodů včetně výše tzv. nezabavitelné částky||
|946|F|F946|Souhrnná data zaměstnance||
|946|G|G946|Mzda||
|946|H|H946|Srážky ze mzdy||
|946|K|K946|x||
|946|L|L946|přidání atributu||
|946|M|M946|na základě požadavku MPSV||
|947|A|A947|25.3.2025||
|947|B|B947|1.3||
|947|D|D947|10501||
|947|E|E947|Výše insolvenčních srážek z nemocenských dávek včetně výše tzv. nezabavitelné částky||
|947|F|F947|Souhrnná data zaměstnance||
|947|G|G947|Mzda||
|947|H|H947|Srážky ze mzdy||
|947|K|K947|x||
|947|L|L947|přidání atributu||
|947|M|M947|na základě požadavku MPSV||
|948|A|A948|25.3.2025||
|948|B|B948|1.3||
|948|D|D948|10120||
|948|E|E948|Název zaměstnavatele||
|948|F|F948|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|948|G|G948|Identifikace||
|948|J|J948|x||
|948|L|L948|změna typu hlášení||
|948|M|M948|na základě požadavku metodiky ČSSZ přidáno do Registrace zaměstnance||
|949|A|A949|26.3.2025||
|949|B|B949|1.3||
|949|D|D949|10502||
|949|E|E949|Bližší určení pracovněprávního vztahu||
|949|F|F949|Vykonávaná pozice zaměstnance||
|949|G|G949|Činnost||
|949|J|J949|x||
|949|L|L949|přidání atributu||
|949|M|M949|na základě domluvy s ČSSZ v rámci nového designu situací||
|950|A|A950|26.3.2025||
|950|B|B950|1.3||
|950|D|D950|10503||
|950|E|E950|V daném měsíci nevznikla účast na pojištění||
|950|F|F950|Průběh pojištění v daném měsíci||
|950|K|K950|x||
|950|L|L950|přidání atributu||
|950|M|M950|po domluvě s metodiky ČSSZ k jednoduššímu rozpoznání, že v daném měsíci není účast na pojištění||
|951|A|A951|26.3.2025||
|951|B|B951|1.3||
|951|D|D951|10002||
|951|E|E951|Pořadí balíku dat||
|951|F|F951|Meta atributy||
|951|G|G951|Podání||
|951|K|K951|x||
|951|L|L951|změna povinnosti||
|951|M|M951|povinný -> nepovinný na základě rozhodnutí architektury kvůli omezení posílaných dat pro akci Storno||
|952|A|A952|26.3.2025||
|952|B|B952|1.3||
|952|D|D952|10003||
|952|E|E952|Počet balíků dat||
|952|F|F952|Meta atributy||
|952|G|G952|Podání||
|952|K|K952|x||
|952|L|L952|změna povinnosti||
|952|M|M952|povinný -> nepovinný na základě rozhodnutí architektury kvůli omezení posílaných dat pro akci Storno||
|953|A|A953|26.3.2025||
|953|B|B953|1.3||
|953|D|D953|10015||
|953|E|E953|Počet formulářů v balíku dat||
|953|F|F953|Meta atributy||
|953|G|G953|Podání||
|953|K|K953|x||
|953|L|L953|změna povinnosti||
|953|M|M953|povinný -> nepovinný na základě rozhodnutí architektury kvůli omezení posílaných dat pro akci Storno||
|954|A|A954|26.3.2025||
|954|B|B954|1.3||
|954|D|D954|10488||
|954|E|E954|Počet formulářů celkem||
|954|F|F954|Meta atributy||
|954|G|G954|Podání||
|954|K|K954|x||
|954|L|L954|změna povinnosti||
|954|M|M954|povinný -> nepovinný na základě rozhodnutí architektury kvůli omezení posílaných dat pro akci Storno||
|955|A|A955|27.3.2025||
|955|B|B955|1.3||
|955|D|D955|10101||
|955|E|E955|Sektor (účel pojištění)||
|955|F|F955|Zaměstnanec / Žák / Student ||
|955|G|G955|Pojištění||
|955|H|H955|Cizozemský nositel pojištění||
|955|J|J955|x||
|955|L|L955|úprava konzumace atributu||
|955|M|M955|na základě požadavku ČSÚ||
|956|A|A956|27.3.2025||
|956|B|B956|1.3||
|956|D|D956|10459||
|956|E|E956|Platnost změny kódu státu rezidentství od||
|956|F|F956|Zaměstnanec / Žák / Student ||
|956|G|G956|Daňová identifikace ve státě rezidence||
|956|J|J956|x||
|956|L|L956|úprava konzumace atributu||
|956|M|M956|na základě požadavku ČSÚ||
|957|A|A957|27.3.2025||
|957|B|B957|1.3||
|957|D|D957|10115||
|957|E|E957|Poživatel předčasného starobního důchodu||
|957|F|F957|Zaměstnanec / Žák / Student ||
|957|G|G957|Důchod||
|957|H|H957|Starobní||
|957|J|J957|x||
|957|L|L957|změna třídy atributu||
|957|M|M957|úprava třídy pro přidání nového atributu||
|958|A|A958|27.3.2025||
|958|B|B958|1.3||
|958|C|C958|ZP007||
|958|D|D958|10504||
|958|E|E958|Poživatel starobního důchodu se sníženým důchodovým věkem ||
|958|F|F958|Zaměstnanec / Žák / Student ||
|958|G|G958|Důchod||
|958|H|H958|Starobní||
|958|J|J958|x||
|958|L|L958|přidání atributu||
|958|M|M958|na základě žádosti ČSSZ (důchodová reforma)||
|959|A|A959|27.3.2025||
|959|B|B959|1.3||
|959|D|D959|10214||
|959|E|E959|Typ kolektivní smlouvy||
|959|F|F959|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|959|G|G959|Kolektivní smlouva k 31.12.||
|959|K|K959|x||
|959|L|L959|přejmenování atributu||
|959|M|M959|na základě požadavku ČSSZ||
|960|A|A960|27.3.2025||
|960|B|B960|1.3||
|960|D|D960|10356||
|960|E|E960|Počet kalendářních dnů doby důchodového pojištění v daném kalendářním měsíci||
|960|F|F960|Průběh pojištění v daném měsíci||
|960|G|G960|Trvání pojištění||
|960|K|K960|x||
|960|L|L960|přejmenování atributu||
|960|M|M960|na základě požadavku ČSSZ||
|961|A|A961|28.3.2025||
|961|B|B961|1.3||
|961|D|D961|10102||
|961|E|E961|Kód zdravotní pojišťovny||
|961|F|F961|Zaměstnanec / Žák / Student ||
|961|G|G961|Pojištění||
|961|H|H961|Zdravotní a nemocenské pojištění||
|961|J|J961|x||
|961|L|L961|úprava číselníku||
|961|M|M961|úprava zdroje číselníku||
|962|A|A962|28.3.2025||
|962|B|B962|1.3||
|962|D|D962|10116||
|962|E|E962|Srážky na základě nařízeného soudního nebo správního výkonu rozhodnutí, konkursu nebo dohody o srážkách z příjmu||
|962|F|F962|Souhrnná data zaměstnance||
|962|G|G962|Mzda||
|962|H|H962|Srážky ze mzdy||
|962|K|K962|x||
|962|L|L962|změna třídy atributu||
|962|M|M962|konsolidace třídy pro srážky ze mzdy||
|963|A|A963|28.3.2025||
|963|B|B963|1.3||
|963|D|D963|10497||
|963|E|E963|Výše exekučních srážek z důchodů včetně výše tzv. nezabavitelné částky||
|963|F|F963|Souhrnná data zaměstnance||
|963|G|G963|Mzda||
|963|H|H963|Srážky ze mzdy||
|963|K|K963|x||
|963|L|L963|odstranění atributu||
|963|M|M963|na základě revertu požadavku na přidání od ČSSZ||
|964|A|A964|28.3.2025||
|964|B|B964|1.3||
|964|D|D964|10498||
|964|E|E964|Výše exekučních srážek z nemocenských dávek včetně výše tzv. nezabavitelné částky||
|964|F|F964|Souhrnná data zaměstnance||
|964|G|G964|Mzda||
|964|H|H964|Srážky ze mzdy||
|964|K|K964|x||
|964|L|L964|odstranění atributu||
|964|M|M964|na základě revertu požadavku na přidání od ČSSZ||
|965|A|A965|28.3.2025||
|965|B|B965|1.3||
|965|D|D965|10500||
|965|E|E965|Výše insolvenčních srážek z důchodů včetně výše tzv. nezabavitelné částky||
|965|F|F965|Souhrnná data zaměstnance||
|965|G|G965|Mzda||
|965|H|H965|Srážky ze mzdy||
|965|K|K965|x||
|965|L|L965|odstranění atributu||
|965|M|M965|na základě revertu požadavku na přidání od ČSSZ||
|966|A|A966|28.3.2025||
|966|B|B966|1.3||
|966|D|D966|10501||
|966|E|E966|Výše insolvenčních srážek z nemocenských dávek včetně výše tzv. nezabavitelné částky||
|966|F|F966|Souhrnná data zaměstnance||
|966|G|G966|Mzda||
|966|H|H966|Srážky ze mzdy||
|966|K|K966|x||
|966|L|L966|odstranění atributu||
|966|M|M966|na základě revertu požadavku na přidání od ČSSZ||
|967|A|A967|28.3.2025||
|967|B|B967|1.3||
|967|D|D967|10215||
|967|E|E967|Název||
|967|F|F967|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|967|G|G967|Kolektivní smlouva k 31.12.||
|967|H|H967|Odborový svaz||
|967|K|K967|x||
|967|L|L967|odstranění atributu||
|967|M|M967|na základě požadavku MPSV / ČSÚ||
|968|A|A968|28.3.2025||
|968|B|B968|1.3||
|968|D|D968|10216||
|968|E|E968|Identifikační číslo||
|968|F|F968|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|968|G|G968|Kolektivní smlouva k 31.12.||
|968|H|H968|Odborový svaz||
|968|K|K968|x||
|968|L|L968|odstranění atributu||
|968|M|M968|na základě požadavku MPSV / ČSÚ||
|969|A|A969|28.3.2025||
|969|B|B969|1.3||
|969|D|D969|10217||
|969|E|E969|Název||
|969|F|F969|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|969|G|G969|Kolektivní smlouva k 31.12.||
|969|H|H969|Zaměstnavatelský svaz||
|969|K|K969|x||
|969|L|L969|odstranění atributu||
|969|M|M969|na základě požadavku MPSV / ČSÚ||
|970|A|A970|28.3.2025||
|970|B|B970|1.3||
|970|D|D970|10218||
|970|E|E970|Identifikační číslo||
|970|F|F970|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|970|G|G970|Kolektivní smlouva k 31.12.||
|970|H|H970|Zaměstnavatelský svaz||
|970|K|K970|x||
|970|L|L970|odstranění atributu||
|970|M|M970|na základě požadavku MPSV / ČSÚ||
|971|A|A971|28.3.2025||
|971|B|B971|1.3||
|971|D|D971|10219||
|971|E|E971|Počet odborových organizací u zaměstnavatele ||
|971|F|F971|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|971|G|G971|Odborová organizace k 31.12.||
|971|K|K971|x||
|971|L|L971|odstranění atributu||
|971|M|M971|na základě požadavku MPSV / ČSÚ||
|972|A|A972|28.3.2025||
|972|B|B972|1.3||
|972|D|D972|10249||
|972|E|E972|Postavení v zaměstnání||
|972|F|F972|Vykonávaná pozice zaměstnance||
|972|G|G972|Forma práce||
|972|J|J972|x||
|972|L|L972|úprava číselníku||
|972|M|M972|úprava zdroje číselníku (změna CZ-ICSE na Národní klasifikaci postavení v zaměstnání NKPZ)||
|973|A|A973|4.4.2025||
|973|B|B973|1.3||
|973|D|D973|10297||
|973|E|E973|Základ pro výpočet zálohy na daň||
|973|F|F973|Souhrnná data zaměstnance||
|973|G|G973|Výpočet zálohy na daň||
|973|K|K973|x||
|973|L|L973|změna povinnosti||
|973|M|M973|P -> N oprava obecné povinnosti pro XSD||
|974|A|A974|4.4.2025||
|974|B|B974|1.3||
|974|D|D974|10298||
|974|E|E974|Vypočtená záloha na daň||
|974|F|F974|Souhrnná data zaměstnance||
|974|G|G974|Výpočet zálohy na daň||
|974|K|K974|x||
|974|L|L974|změna povinnosti||
|974|M|M974|P -> N oprava obecné povinnosti pro XSD||
|975|A|A975|4.4.2025||
|975|B|B975|1.3||
|975|D|D975|10305||
|975|E|E975|Skutečně sražená záloha na daň po uplatnění slev||
|975|F|F975|Souhrnná data zaměstnance||
|975|G|G975|Výpočet zálohy na daň||
|975|K|K975|x||
|975|L|L975|změna povinnosti||
|975|M|M975|P -> N oprava obecné povinnosti pro XSD||
|976|A|A976|4.4.2025||
|976|B|B976|1.3||
|976|D|D976|10287||
|976|E|E976|Zúčtovaný příjem - z toho peněžní příjmy||
|976|F|F976|Příjem v daném měsíci||
|976|G|G976|Příjem||
|976|K|K976|x||
|976|L|L976|odstranění atributu||
|976|M|M976|po konzultaci mezi MF a FS||
|977|A|A977|4.4.2025||
|977|B|B977|1.3||
|977|D|D977|10288||
|977|E|E977|Zúčtovaný příjem - z toho nepeněžní příjmy / naturální mzda||
|977|F|F977|Příjem v daném měsíci||
|977|G|G977|Příjem||
|977|K|K977|x||
|977|L|L977|odstranění atributu||
|977|M|M977|po konzultaci mezi MF a FS||
|978|A|A978|9.4.2025||
|978|B|B978|1.3||
|978|D|D978|10008||
|978|E|E978|Typ akce||
|978|F|F978|Meta atributy||
|978|G|G978|Formulář||
|978|J|J978|x||
|978|L|L978|úprava číselníku||
|978|M|M978|odstranění akcí a přejmenování stávajících akcí po konzultaci s ČSSZ||
|979|A|A979|16.4.2025||
|979|B|B979|1.4 prefinal||
|979|D|D979|10239||
|979|E|E979|Druh činnosti||
|979|F|F979|Vykonávaná pozice zaměstnance||
|979|G|G979|Činnost||
|979|J|J979|x||
|979|K|K979|x||
|979|L|L979|úprava číselníku||
|979|M|M979|na základě rozšíření číselníku ze strany ČSSZ||
|980|A|A980|24.4.2025||
|980|B|B980|1.4 prefinal||
|980|D|D980|10310||
|980|E|E980|Sražená daň podle zvláštní sazby daně z příjmu nerezidenta člena orgánu právnické osoby||
|980|F|F980|Příjem v daném měsíci||
|980|G|G980|Výpočet daně podle zvláštní sazby daně ||
|980|K|K980|x||
|980|L|L980|úprava datových scénářů||
|980|M|M980|oprava omezení na jeden konkrétní datový scénář||
|981|A|A981|7.5.2025||
|981|B|B981|1.4 prefinal||
|981|D|D981|10075||
|981|E|E981|Typ adresy||
|981|F|F981|Zaměstnanec / Žák / Student ||
|981|G|G981|Adresa||
|981|J|J981|x||
|981|L|L981|odstranění atributu||
|981|M|M981|na základě redesignu adres podle současného stavu||
|982|A|A982|7.5.2025||
|982|B|B982|1.4 prefinal||
|982|D|D982|10076||
|982|E|E982|Kód adresního místa||
|982|F|F982|Zaměstnanec / Žák / Student ||
|982|G|G982|Adresa||
|982|H|H982|Trvalý pobyt||
|982|J|J982|x||
|982|L|L982|změna třídy atributu||
|982|M|M982|na základě redesignu adres podle současného stavu||
|983|A|A983|7.5.2025||
|983|B|B983|1.4 prefinal||
|983|D|D983|10077||
|983|E|E983|Ulice||
|983|F|F983|Zaměstnanec / Žák / Student ||
|983|G|G983|Adresa||
|983|H|H983|Trvalý pobyt||
|983|J|J983|x||
|983|L|L983|změna třídy atributu||
|983|M|M983|na základě redesignu adres podle současného stavu||
|984|A|A984|7.5.2025||
|984|B|B984|1.4 prefinal||
|984|D|D984|10078||
|984|E|E984|Číslo popisné ||
|984|F|F984|Zaměstnanec / Žák / Student ||
|984|G|G984|Adresa||
|984|H|H984|Trvalý pobyt||
|984|J|J984|x||
|984|L|L984|změna třídy atributu||
|984|M|M984|na základě redesignu adres podle současného stavu||
|985|A|A985|7.5.2025||
|985|B|B985|1.4 prefinal||
|985|D|D985|10079||
|985|E|E985|Číslo orientační||
|985|F|F985|Zaměstnanec / Žák / Student ||
|985|G|G985|Adresa||
|985|H|H985|Trvalý pobyt||
|985|J|J985|x||
|985|L|L985|změna třídy atributu||
|985|M|M985|na základě redesignu adres podle současného stavu||
|986|A|A986|7.5.2025||
|986|B|B986|1.4 prefinal||
|986|D|D986|10080||
|986|E|E986|Obec||
|986|F|F986|Zaměstnanec / Žák / Student ||
|986|G|G986|Adresa||
|986|H|H986|Trvalý pobyt||
|986|J|J986|x||
|986|L|L986|změna třídy atributu||
|986|M|M986|na základě redesignu adres podle současného stavu||
|987|A|A987|7.5.2025||
|987|B|B987|1.4 prefinal||
|987|D|D987|10082||
|987|E|E987|PSČ||
|987|F|F987|Zaměstnanec / Žák / Student ||
|987|G|G987|Adresa||
|987|H|H987|Trvalý pobyt||
|987|J|J987|x||
|987|L|L987|změna třídy atributu||
|987|M|M987|na základě redesignu adres podle současného stavu||
|988|A|A988|7.5.2025||
|988|B|B988|1.4 prefinal||
|988|D|D988|10083||
|988|E|E988|Stát||
|988|F|F988|Zaměstnanec / Žák / Student ||
|988|G|G988|Adresa||
|988|H|H988|Trvalý pobyt||
|988|J|J988|x||
|988|L|L988|změna třídy atributu||
|988|M|M988|na základě redesignu adres podle současného stavu||
|989|A|A989|7.5.2025||
|989|B|B989|1.4 prefinal||
|989|D|D989|10076||
|989|E|E989|Kód adresního místa||
|989|F|F989|Zaměstnanec / Žák / Student ||
|989|G|G989|Adresa||
|989|H|H989|Trvalý pobyt||
|989|J|J989|x||
|989|L|L989|změna četnosti||
|989|M|M989|multi -> single (na základě redesignu adres podle současného stavu)||
|990|A|A990|7.5.2025||
|990|B|B990|1.4 prefinal||
|990|D|D990|10077||
|990|E|E990|Ulice||
|990|F|F990|Zaměstnanec / Žák / Student ||
|990|G|G990|Adresa||
|990|H|H990|Trvalý pobyt||
|990|J|J990|x||
|990|L|L990|změna četnosti||
|990|M|M990|multi -> single (na základě redesignu adres podle současného stavu)||
|991|A|A991|7.5.2025||
|991|B|B991|1.4 prefinal||
|991|D|D991|10078||
|991|E|E991|Číslo popisné ||
|991|F|F991|Zaměstnanec / Žák / Student ||
|991|G|G991|Adresa||
|991|H|H991|Trvalý pobyt||
|991|J|J991|x||
|991|L|L991|změna četnosti||
|991|M|M991|multi -> single (na základě redesignu adres podle současného stavu)||
|992|A|A992|7.5.2025||
|992|B|B992|1.4 prefinal||
|992|D|D992|10079||
|992|E|E992|Číslo orientační||
|992|F|F992|Zaměstnanec / Žák / Student ||
|992|G|G992|Adresa||
|992|H|H992|Trvalý pobyt||
|992|J|J992|x||
|992|L|L992|změna četnosti||
|992|M|M992|multi -> single (na základě redesignu adres podle současného stavu)||
|993|A|A993|7.5.2025||
|993|B|B993|1.4 prefinal||
|993|D|D993|10080||
|993|E|E993|Obec||
|993|F|F993|Zaměstnanec / Žák / Student ||
|993|G|G993|Adresa||
|993|H|H993|Trvalý pobyt||
|993|J|J993|x||
|993|L|L993|změna četnosti||
|993|M|M993|multi -> single (na základě redesignu adres podle současného stavu)||
|994|A|A994|7.5.2025||
|994|B|B994|1.4 prefinal||
|994|D|D994|10082||
|994|E|E994|PSČ||
|994|F|F994|Zaměstnanec / Žák / Student ||
|994|G|G994|Adresa||
|994|H|H994|Trvalý pobyt||
|994|J|J994|x||
|994|L|L994|změna četnosti||
|994|M|M994|multi -> single (na základě redesignu adres podle současného stavu)||
|995|A|A995|7.5.2025||
|995|B|B995|1.4 prefinal||
|995|D|D995|10083||
|995|E|E995|Stát||
|995|F|F995|Zaměstnanec / Žák / Student ||
|995|G|G995|Adresa||
|995|H|H995|Trvalý pobyt||
|995|J|J995|x||
|995|L|L995|změna četnosti||
|995|M|M995|multi -> single (na základě redesignu adres podle současného stavu)||
|996|A|A996|7.5.2025||
|996|B|B996|1.4 prefinal||
|996|D|D996|10505||
|996|E|E996|Kód adresního místa||
|996|F|F996|Zaměstnanec / Žák / Student ||
|996|G|G996|Adresa||
|996|H|H996|Kontaktní adresa||
|996|J|J996|x||
|996|L|L996|přidání atributu||
|996|M|M996|na základě redesignu adres podle současného stavu||
|997|A|A997|7.5.2025||
|997|B|B997|1.4 prefinal||
|997|D|D997|10506||
|997|E|E997|Ulice||
|997|F|F997|Zaměstnanec / Žák / Student ||
|997|G|G997|Adresa||
|997|H|H997|Kontaktní adresa||
|997|J|J997|x||
|997|L|L997|přidání atributu||
|997|M|M997|na základě redesignu adres podle současného stavu||
|998|A|A998|7.5.2025||
|998|B|B998|1.4 prefinal||
|998|D|D998|10507||
|998|E|E998|Číslo popisné ||
|998|F|F998|Zaměstnanec / Žák / Student ||
|998|G|G998|Adresa||
|998|H|H998|Kontaktní adresa||
|998|J|J998|x||
|998|L|L998|přidání atributu||
|998|M|M998|na základě redesignu adres podle současného stavu||
|999|A|A999|7.5.2025||
|999|B|B999|1.4 prefinal||
|999|D|D999|10508||
|999|E|E999|Číslo orientační||
|999|F|F999|Zaměstnanec / Žák / Student ||
|999|G|G999|Adresa||
|999|H|H999|Kontaktní adresa||
|999|J|J999|x||
|999|L|L999|přidání atributu||
|999|M|M999|na základě redesignu adres podle současného stavu||
|1000|A|A1000|7.5.2025||
|1000|B|B1000|1.4 prefinal||
|1000|D|D1000|10509||
|1000|E|E1000|Obec||
|1000|F|F1000|Zaměstnanec / Žák / Student ||
|1000|G|G1000|Adresa||
|1000|H|H1000|Kontaktní adresa||
|1000|J|J1000|x||
|1000|L|L1000|přidání atributu||
|1000|M|M1000|na základě redesignu adres podle současného stavu||
|1001|A|A1001|7.5.2025||
|1001|B|B1001|1.4 prefinal||
|1001|D|D1001|10510||
|1001|E|E1001|PSČ||
|1001|F|F1001|Zaměstnanec / Žák / Student ||
|1001|G|G1001|Adresa||
|1001|H|H1001|Kontaktní adresa||
|1001|J|J1001|x||
|1001|L|L1001|přidání atributu||
|1001|M|M1001|na základě redesignu adres podle současného stavu||
|1002|A|A1002|7.5.2025||
|1002|B|B1002|1.4 prefinal||
|1002|D|D1002|10511||
|1002|E|E1002|Stát||
|1002|F|F1002|Zaměstnanec / Žák / Student ||
|1002|G|G1002|Adresa||
|1002|H|H1002|Kontaktní adresa||
|1002|J|J1002|x||
|1002|L|L1002|přidání atributu||
|1002|M|M1002|na základě redesignu adres podle současného stavu||
|1003|A|A1003|7.5.2025||
|1003|B|B1003|1.4 prefinal||
|1003|D|D1003|10512||
|1003|E|E1003|Kód adresního místa||
|1003|F|F1003|Zaměstnanec / Žák / Student ||
|1003|G|G1003|Adresa||
|1003|H|H1003|Adresa v ČR, je-li trvalý pobyt mimo||
|1003|J|J1003|x||
|1003|L|L1003|přidání atributu||
|1003|M|M1003|na základě redesignu adres podle současného stavu||
|1004|A|A1004|7.5.2025||
|1004|B|B1004|1.4 prefinal||
|1004|D|D1004|10513||
|1004|E|E1004|Ulice||
|1004|F|F1004|Zaměstnanec / Žák / Student ||
|1004|G|G1004|Adresa||
|1004|H|H1004|Adresa v ČR, je-li trvalý pobyt mimo||
|1004|J|J1004|x||
|1004|L|L1004|přidání atributu||
|1004|M|M1004|na základě redesignu adres podle současného stavu||
|1005|A|A1005|7.5.2025||
|1005|B|B1005|1.4 prefinal||
|1005|D|D1005|10514||
|1005|E|E1005|Číslo popisné ||
|1005|F|F1005|Zaměstnanec / Žák / Student ||
|1005|G|G1005|Adresa||
|1005|H|H1005|Adresa v ČR, je-li trvalý pobyt mimo||
|1005|J|J1005|x||
|1005|L|L1005|přidání atributu||
|1005|M|M1005|na základě redesignu adres podle současného stavu||
|1006|A|A1006|7.5.2025||
|1006|B|B1006|1.4 prefinal||
|1006|D|D1006|10515||
|1006|E|E1006|Číslo orientační||
|1006|F|F1006|Zaměstnanec / Žák / Student ||
|1006|G|G1006|Adresa||
|1006|H|H1006|Adresa v ČR, je-li trvalý pobyt mimo||
|1006|J|J1006|x||
|1006|L|L1006|přidání atributu||
|1006|M|M1006|na základě redesignu adres podle současného stavu||
|1007|A|A1007|7.5.2025||
|1007|B|B1007|1.4 prefinal||
|1007|D|D1007|10516||
|1007|E|E1007|Obec||
|1007|F|F1007|Zaměstnanec / Žák / Student ||
|1007|G|G1007|Adresa||
|1007|H|H1007|Adresa v ČR, je-li trvalý pobyt mimo||
|1007|J|J1007|x||
|1007|L|L1007|přidání atributu||
|1007|M|M1007|na základě redesignu adres podle současného stavu||
|1008|A|A1008|7.5.2025||
|1008|B|B1008|1.4 prefinal||
|1008|D|D1008|10517||
|1008|E|E1008|PSČ||
|1008|F|F1008|Zaměstnanec / Žák / Student ||
|1008|G|G1008|Adresa||
|1008|H|H1008|Adresa v ČR, je-li trvalý pobyt mimo||
|1008|J|J1008|x||
|1008|L|L1008|přidání atributu||
|1008|M|M1008|na základě redesignu adres podle současného stavu||
|1009|A|A1009|7.5.2025||
|1009|B|B1009|1.4 prefinal||
|1009|D|D1009|10518||
|1009|E|E1009|Kód adresního místa||
|1009|F|F1009|Zaměstnanec / Žák / Student ||
|1009|G|G1009|Adresa||
|1009|H|H1009|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1009|J|J1009|x||
|1009|L|L1009|přidání atributu||
|1009|M|M1009|na základě redesignu adres podle současného stavu||
|1010|A|A1010|7.5.2025||
|1010|B|B1010|1.4 prefinal||
|1010|D|D1010|10519||
|1010|E|E1010|Ulice||
|1010|F|F1010|Zaměstnanec / Žák / Student ||
|1010|G|G1010|Adresa||
|1010|H|H1010|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1010|J|J1010|x||
|1010|L|L1010|přidání atributu||
|1010|M|M1010|na základě redesignu adres podle současného stavu||
|1011|A|A1011|7.5.2025||
|1011|B|B1011|1.4 prefinal||
|1011|D|D1011|10520||
|1011|E|E1011|Číslo popisné ||
|1011|F|F1011|Zaměstnanec / Žák / Student ||
|1011|G|G1011|Adresa||
|1011|H|H1011|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1011|J|J1011|x||
|1011|L|L1011|přidání atributu||
|1011|M|M1011|na základě redesignu adres podle současného stavu||
|1012|A|A1012|7.5.2025||
|1012|B|B1012|1.4 prefinal||
|1012|D|D1012|10521||
|1012|E|E1012|Číslo orientační||
|1012|F|F1012|Zaměstnanec / Žák / Student ||
|1012|G|G1012|Adresa||
|1012|H|H1012|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1012|J|J1012|x||
|1012|L|L1012|přidání atributu||
|1012|M|M1012|na základě redesignu adres podle současného stavu||
|1013|A|A1013|7.5.2025||
|1013|B|B1013|1.4 prefinal||
|1013|D|D1013|10522||
|1013|E|E1013|Obec||
|1013|F|F1013|Zaměstnanec / Žák / Student ||
|1013|G|G1013|Adresa||
|1013|H|H1013|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1013|J|J1013|x||
|1013|L|L1013|přidání atributu||
|1013|M|M1013|na základě redesignu adres podle současného stavu||
|1014|A|A1014|7.5.2025||
|1014|B|B1014|1.4 prefinal||
|1014|D|D1014|10523||
|1014|E|E1014|PSČ||
|1014|F|F1014|Zaměstnanec / Žák / Student ||
|1014|G|G1014|Adresa||
|1014|H|H1014|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1014|J|J1014|x||
|1014|L|L1014|přidání atributu||
|1014|M|M1014|na základě redesignu adres podle současného stavu||
|1015|A|A1015|7.5.2025||
|1015|B|B1015|1.4 prefinal||
|1015|D|D1015|10524||
|1015|E|E1015|Stát||
|1015|F|F1015|Zaměstnanec / Žák / Student ||
|1015|G|G1015|Adresa||
|1015|H|H1015|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1015|J|J1015|x||
|1015|L|L1015|přidání atributu||
|1015|M|M1015|na základě redesignu adres podle současného stavu||
|1016|A|A1016|7.5.2025||
|1016|B|B1016|1.4 prefinal||
|1016|D|D1016|10525||
|1016|E|E1016|Druh zaměstnání||
|1016|F|F1016|Ukončení pracovněprávního vztahu||
|1016|G|G1016|Informace pro podporu v nezaměstnanosti||
|1016|J|J1016|x||
|1016|L|L1016|přidání atributu||
|1016|M|M1016|přidáno po konzultaci s metodiky kvůli existujícím kontrolám||
|1017|A|A1017|7.5.2025||
|1017|B|B1017|1.4 prefinal||
|1017|C|C1017|ZP_TECH_POPIS_012||
|1017|D|D1017|10088||
|1017|E|E1017|Druh důchodu||
|1017|F|F1017|Zaměstnanec / Žák / Student ||
|1017|G|G1017|Důchod||
|1017|H|H1017|Vyplácený ČSSZ||
|1017|J|J1017|x||
|1017|L|L1017|odstranění atributu||
|1017|M|M1017|odebráno po konzultaci s metodiky||
|1018|A|A1018|7.5.2025||
|1018|B|B1018|1.4 prefinal||
|1018|C|C1018|ZP_TECH_POPIS_002||
|1018|D|D1018|10111||
|1018|E|E1018|Prodloužení||
|1018|F|F1018|Zaměstnanec / Žák / Student ||
|1018|G|G1018|Zaměstnanec bez státního občanství ČR||
|1018|H|H1018|Doba oprávnění||
|1018|J|J1018|x||
|1018|L|L1018|odstranění atributu||
|1018|M|M1018|odebráno po konzultaci s metodiky||
|1019|A|A1019|7.5.2025||
|1019|B|B1019|1.4 prefinal||
|1019|D|D1019|10112||
|1019|E|E1019|Změna povinnosti - cizinec povolení nepotřebuje ode dne||
|1019|F|F1019|Zaměstnanec / Žák / Student ||
|1019|G|G1019|Zaměstnanec bez státního občanství ČR||
|1019|H|H1019|Doba oprávnění||
|1019|J|J1019|x||
|1019|L|L1019|odstranění atributu||
|1019|M|M1019|odebráno po konzultaci s metodiky||
|1020|A|A1020|7.5.2025||
|1020|B|B1020|1.4 prefinal||
|1020|D|D1020|10051||
|1020|E|E1020|IK MPSV (Osobní identifikační číslo - OIČ)||
|1020|F|F1020|Zaměstnanec / Žák / Student ||
|1020|G|G1020|Základní identifikace||
|1020|J|J1020|x||
|1020|K|K1020|x||
|1020|L|L1020|přejmenování atributu||
|1020|M|M1020|sladění se zákonem||
|1021|A|A1021|7.5.2025||
|1021|B|B1021|1.4 prefinal||
|1021|C|C1021|ZP_TECH_POPIS_003||
|1021|D|D1021|10105||
|1021|E|E1021|Oprávnění pro výkon pracovní činnosti||
|1021|F|F1021|Zaměstnanec / Žák / Student ||
|1021|G|G1021|Zaměstnanec bez státního občanství ČR||
|1021|J|J1021|x||
|1021|L|L1021|úprava číselníku||
|1021|M|M1021|úprava a rozšíření číselníku||
|1022|A|A1022|7.5.2025||
|1022|B|B1022|1.4 prefinal||
|1022|D|D1022|10085||
|1022|E|E1022|Typ zdravotního omezení||
|1022|F|F1022|Zaměstnanec / Žák / Student ||
|1022|G|G1022|Deklarované skutečnosti ze strany zaměstnance||
|1022|H|H1022|Zdravotní omezení||
|1022|J|J1022|x||
|1022|L|L1022|úprava číselníku||
|1022|M|M1022|oprava nesprávně uvedeného zákona u položky číselníku||
|1023|A|A1023|8.5.2025||
|1023|B|B1023|1.4 prefinal||
|1023|C|C1023|AMCH||
|1023|D|D1023|10065||
|1023|E|E1023|Stát||
|1023|F|F1023|Zaměstnanec / Žák / Student ||
|1023|G|G1023|Základní identifikace||
|1023|H|H1023|Místo narození||
|1023|J|J1023|x||
|1023|L|L1023|úprava konzumace atributu||
|1023|M|M1023|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1024|A|A1024|8.5.2025||
|1024|B|B1024|1.4 prefinal||
|1024|C|C1024|AMCH||
|1024|D|D1024|10115||
|1024|E|E1024|Poživatel předčasného starobního důchodu||
|1024|F|F1024|Zaměstnanec / Žák / Student ||
|1024|G|G1024|Důchod||
|1024|H|H1024|Starobní||
|1024|J|J1024|x||
|1024|L|L1024|úprava konzumace atributu||
|1024|M|M1024|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1025|A|A1025|8.5.2025||
|1025|B|B1025|1.4 prefinal||
|1025|C|C1025|AMCH||
|1025|D|D1025|10504||
|1025|E|E1025|Poživatel starobního důchodu se sníženým důchodovým věkem ||
|1025|F|F1025|Zaměstnanec / Žák / Student ||
|1025|G|G1025|Důchod||
|1025|H|H1025|Starobní||
|1025|J|J1025|x||
|1025|L|L1025|úprava konzumace atributu||
|1025|M|M1025|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání ČSÚ)||
|1026|A|A1026|8.5.2025||
|1026|B|B1026|1.4 prefinal||
|1026|C|C1026|AMCH||
|1026|D|D1026|10226||
|1026|E|E1026|Zaměstnanec nenastoupil||
|1026|F|F1026|Vykonávaná pozice zaměstnance||
|1026|G|G1026|Ukončení zaměstnání||
|1026|J|J1026|x||
|1026|L|L1026|úprava konzumace atributu||
|1026|M|M1026|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání ČSSZ)||
|1027|A|A1027|8.5.2025||
|1027|B|B1027|1.4 prefinal||
|1027|C|C1027|AMCH||
|1027|D|D1027|10238||
|1027|E|E1027|Vedoucí zaměstnanec||
|1027|F|F1027|Vykonávaná pozice zaměstnance||
|1027|G|G1027|Pracovní místo / pozice||
|1027|J|J1027|x||
|1027|L|L1027|úprava konzumace atributu||
|1027|M|M1027|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1028|A|A1028|9.5.2025||
|1028|B|B1028|1.4 prefinal||
|1028|C|C1028|AMCH||
|1028|D|D1028|10117||
|1028|E|E1028|Přihlášení dne||
|1028|F|F1028|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1028|I|I1028|x||
|1028|L|L1028|úprava konzumace atributu||
|1028|M|M1028|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1029|A|A1029|9.5.2025||
|1029|B|B1029|1.4 prefinal||
|1029|C|C1029|AMCH||
|1029|D|D1029|10118||
|1029|E|E1029|Typ přihlášky||
|1029|F|F1029|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1029|I|I1029|x||
|1029|L|L1029|úprava konzumace atributu||
|1029|M|M1029|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1030|A|A1030|9.5.2025||
|1030|B|B1030|1.4 prefinal||
|1030|C|C1030|AMCH||
|1030|D|D1030|10127||
|1030|E|E1030|Počet zaměstnanců||
|1030|F|F1030|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1030|G|G1030|Atributy subjektu||
|1030|I|I1030|x||
|1030|L|L1030|úprava konzumace atributu||
|1030|M|M1030|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1031|A|A1031|9.5.2025||
|1031|B|B1031|1.4 prefinal||
|1031|C|C1031|AMCH||
|1031|D|D1031|10143||
|1031|E|E1031|Název původního zaměstnavatele||
|1031|F|F1031|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1031|G|G1031|Vznik||
|1031|H|H1031|Právní nástupnictví||
|1031|I|I1031|x||
|1031|L|L1031|úprava konzumace atributu||
|1031|M|M1031|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1032|A|A1032|9.5.2025||
|1032|B|B1032|1.4 prefinal||
|1032|C|C1032|AMCH||
|1032|D|D1032|10144||
|1032|E|E1032|IČ (popř. individuální číslo původního zaměstnavatele)||
|1032|F|F1032|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1032|G|G1032|Vznik||
|1032|H|H1032|Právní nástupnictví||
|1032|I|I1032|x||
|1032|L|L1032|úprava konzumace atributu||
|1032|M|M1032|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1033|A|A1033|9.5.2025||
|1033|B|B1033|1.4 prefinal||
|1033|C|C1033|AMCH||
|1033|D|D1033|10145||
|1033|E|E1033|Rodné číslo původního zaměstnavatele||
|1033|F|F1033|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1033|G|G1033|Vznik||
|1033|H|H1033|Právní nástupnictví||
|1033|I|I1033|x||
|1033|L|L1033|úprava konzumace atributu||
|1033|M|M1033|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1034|A|A1034|9.5.2025||
|1034|B|B1034|1.4 prefinal||
|1034|C|C1034|AMCH||
|1034|D|D1034|10148||
|1034|E|E1034|Typ odhlášky||
|1034|F|F1034|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1034|G|G1034|Odhlášení z registru||
|1034|I|I1034|x||
|1034|L|L1034|úprava konzumace atributu||
|1034|M|M1034|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1035|A|A1035|9.5.2025||
|1035|B|B1035|1.4 prefinal||
|1035|C|C1035|AMCH||
|1035|D|D1035|10149||
|1035|E|E1035|Datum zániku zaměstnavatele / zrušení mzdové účtárny||
|1035|F|F1035|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1035|G|G1035|Odhlášení z registru||
|1035|I|I1035|x||
|1035|L|L1035|úprava konzumace atributu||
|1035|M|M1035|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1036|A|A1036|9.5.2025||
|1036|B|B1036|1.4 prefinal||
|1036|C|C1036|AMCH||
|1036|D|D1036|10150||
|1036|E|E1036|Název||
|1036|F|F1036|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1036|G|G1036|Archivace dokladů||
|1036|I|I1036|x||
|1036|L|L1036|úprava konzumace atributu||
|1036|M|M1036|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1037|A|A1037|9.5.2025||
|1037|B|B1037|1.4 prefinal||
|1037|C|C1037|AMCH||
|1037|D|D1037|10151||
|1037|E|E1037|Kód adresního místa||
|1037|F|F1037|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1037|G|G1037|Archivace dokladů||
|1037|H|H1037|Adresa||
|1037|I|I1037|x||
|1037|L|L1037|úprava konzumace atributu||
|1037|M|M1037|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1038|A|A1038|9.5.2025||
|1038|B|B1038|1.4 prefinal||
|1038|C|C1038|AMCH||
|1038|D|D1038|10152||
|1038|E|E1038|Ulice ||
|1038|F|F1038|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1038|G|G1038|Archivace dokladů||
|1038|H|H1038|Adresa||
|1038|I|I1038|x||
|1038|L|L1038|úprava konzumace atributu||
|1038|M|M1038|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1039|A|A1039|9.5.2025||
|1039|B|B1039|1.4 prefinal||
|1039|C|C1039|AMCH||
|1039|D|D1039|10153||
|1039|E|E1039|Číslo popisné ||
|1039|F|F1039|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1039|G|G1039|Archivace dokladů||
|1039|H|H1039|Adresa||
|1039|I|I1039|x||
|1039|L|L1039|úprava konzumace atributu||
|1039|M|M1039|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1040|A|A1040|9.5.2025||
|1040|B|B1040|1.4 prefinal||
|1040|C|C1040|AMCH||
|1040|D|D1040|10154||
|1040|E|E1040|Číslo orientační||
|1040|F|F1040|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1040|G|G1040|Archivace dokladů||
|1040|H|H1040|Adresa||
|1040|I|I1040|x||
|1040|L|L1040|úprava konzumace atributu||
|1040|M|M1040|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1041|A|A1041|9.5.2025||
|1041|B|B1041|1.4 prefinal||
|1041|C|C1041|AMCH||
|1041|D|D1041|10155||
|1041|E|E1041|Obec||
|1041|F|F1041|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1041|G|G1041|Archivace dokladů||
|1041|H|H1041|Adresa||
|1041|I|I1041|x||
|1041|L|L1041|úprava konzumace atributu||
|1041|M|M1041|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1042|A|A1042|9.5.2025||
|1042|B|B1042|1.4 prefinal||
|1042|C|C1042|AMCH||
|1042|D|D1042|10157||
|1042|E|E1042|PSČ||
|1042|F|F1042|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1042|G|G1042|Archivace dokladů||
|1042|H|H1042|Adresa||
|1042|I|I1042|x||
|1042|L|L1042|úprava konzumace atributu||
|1042|M|M1042|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1043|A|A1043|9.5.2025||
|1043|B|B1043|1.4 prefinal||
|1043|C|C1043|AMCH||
|1043|D|D1043|10158||
|1043|E|E1043|Stát||
|1043|F|F1043|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1043|G|G1043|Archivace dokladů||
|1043|H|H1043|Adresa||
|1043|I|I1043|x||
|1043|L|L1043|úprava konzumace atributu||
|1043|M|M1043|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1044|A|A1044|9.5.2025||
|1044|B|B1044|1.4 prefinal||
|1044|C|C1044|AMCH||
|1044|D|D1044|10159||
|1044|E|E1044|Název právního nástupce||
|1044|F|F1044|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1044|G|G1044|Právní nástupnictví při zániku||
|1044|I|I1044|x||
|1044|L|L1044|úprava konzumace atributu||
|1044|M|M1044|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1045|A|A1045|9.5.2025||
|1045|B|B1045|1.4 prefinal||
|1045|C|C1045|AMCH||
|1045|D|D1045|10161||
|1045|E|E1045|Identifikační číslo (IČO, IČ)||
|1045|F|F1045|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1045|G|G1045|Právní nástupnictví při zániku||
|1045|I|I1045|x||
|1045|L|L1045|úprava konzumace atributu||
|1045|M|M1045|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1046|A|A1046|9.5.2025||
|1046|B|B1046|1.4 prefinal||
|1046|C|C1046|AMCH||
|1046|D|D1046|10163||
|1046|E|E1046|Rodné číslo||
|1046|F|F1046|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1046|G|G1046|Právní nástupnictví při zániku||
|1046|I|I1046|x||
|1046|L|L1046|úprava konzumace atributu||
|1046|M|M1046|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1047|A|A1047|9.5.2025||
|1047|B|B1047|1.4 prefinal||
|1047|C|C1047|AMCH||
|1047|D|D1047|10165||
|1047|E|E1047|Kód adresního místa||
|1047|F|F1047|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1047|G|G1047|Právní nástupnictví při zániku||
|1047|H|H1047|Adresa||
|1047|I|I1047|x||
|1047|L|L1047|úprava konzumace atributu||
|1047|M|M1047|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1048|A|A1048|9.5.2025||
|1048|B|B1048|1.4 prefinal||
|1048|C|C1048|AMCH||
|1048|D|D1048|10166||
|1048|E|E1048|Ulice ||
|1048|F|F1048|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1048|G|G1048|Právní nástupnictví při zániku||
|1048|H|H1048|Adresa||
|1048|I|I1048|x||
|1048|L|L1048|úprava konzumace atributu||
|1048|M|M1048|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1049|A|A1049|9.5.2025||
|1049|B|B1049|1.4 prefinal||
|1049|C|C1049|AMCH||
|1049|D|D1049|10167||
|1049|E|E1049|Číslo popisné ||
|1049|F|F1049|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1049|G|G1049|Právní nástupnictví při zániku||
|1049|H|H1049|Adresa||
|1049|I|I1049|x||
|1049|L|L1049|úprava konzumace atributu||
|1049|M|M1049|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1050|A|A1050|9.5.2025||
|1050|B|B1050|1.4 prefinal||
|1050|C|C1050|AMCH||
|1050|D|D1050|10168||
|1050|E|E1050|Číslo orientační||
|1050|F|F1050|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1050|G|G1050|Právní nástupnictví při zániku||
|1050|H|H1050|Adresa||
|1050|I|I1050|x||
|1050|L|L1050|úprava konzumace atributu||
|1050|M|M1050|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1051|A|A1051|9.5.2025||
|1051|B|B1051|1.4 prefinal||
|1051|C|C1051|AMCH||
|1051|D|D1051|10169||
|1051|E|E1051|Obec||
|1051|F|F1051|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1051|G|G1051|Právní nástupnictví při zániku||
|1051|H|H1051|Adresa||
|1051|I|I1051|x||
|1051|L|L1051|úprava konzumace atributu||
|1051|M|M1051|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1052|A|A1052|9.5.2025||
|1052|B|B1052|1.4 prefinal||
|1052|C|C1052|AMCH||
|1052|D|D1052|10171||
|1052|E|E1052|PSČ||
|1052|F|F1052|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1052|G|G1052|Právní nástupnictví při zániku||
|1052|H|H1052|Adresa||
|1052|I|I1052|x||
|1052|L|L1052|úprava konzumace atributu||
|1052|M|M1052|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1053|A|A1053|9.5.2025||
|1053|B|B1053|1.4 prefinal||
|1053|C|C1053|AMCH||
|1053|D|D1053|10172||
|1053|E|E1053|Stát||
|1053|F|F1053|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1053|G|G1053|Právní nástupnictví při zániku||
|1053|H|H1053|Adresa||
|1053|I|I1053|x||
|1053|L|L1053|úprava konzumace atributu||
|1053|M|M1053|konsolidace se zákony, na základě kterých jsou atributy konzumovány (přidání MPSV)||
|1054|A|A1054|14.5.2025||
|1054|B|B1054|1.4 prefinal||
|1054|D|D1054|10228||
|1054|E|E1054|ID pracovněprávního vztahu (Identifikátor zaměstnání)||
|1054|F|F1054|Vykonávaná pozice zaměstnance||
|1054|J|J1054|x||
|1054|K|K1054|x||
|1054|L|L1054|přejmenování atributu||
|1054|M|M1054|sladění se zákonem||
|1055|A|A1055|21.5.2024||
|1055|B|B1055|1.4 prefinal||
|1055|D|D1055|10004||
|1055|E|E1055|Pracoviště ÚSSZ (OSSZ/PSSZ/MSSZ Brno)||
|1055|F|F1055|Meta atributy||
|1055|G|G1055|Podání||
|1055|I|I1055|x||
|1055|L|L1055|změna typu hlášení||
|1055|M|M1055|přidání k Registraci zaměstnavatele pro účely hlášení REGZEL_DOPL||
|1056|A|A1056|21.5.2024||
|1056|B|B1056|1.4 prefinal||
|1056|D|D1056|10068||
|1056|E|E1056|Kód státu rezidenství||
|1056|F|F1056|Zaměstnanec / Žák / Student ||
|1056|G|G1056|Daňová identifikace ve státě rezidence||
|1056|K|K1056|x||
|1056|L|L1056|změna typu hlášení||
|1056|M|M1056|odebrání ze sběru v rámci měsíčního hlášení, zůstává požadavek FS na jeho needitovatelné zobrazování u měsíčního hlášení||
|1057|A|A1057|23.5.2025||
|1057|B|B1057|1.4 prefinal||
|1057|D|D1057|10240||
|1057|E|E1057|Kód ELDP||
|1057|F|F1057|Průběh pojištění v daném měsíci||
|1057|G|G1057|ELDP||
|1057|K|K1057|x||
|1057|L|L1057|úprava číselníku||
|1057|M|M1057|aktualizace číselníku na pokyn ČSSZ||
|1058|A|A1058|24.5.2025||
|1058|B|B1058|1.4 prefinal||
|1058|D|D1058|10233||
|1058|E|E1058|Nástroj (opatření)||
|1058|F|F1058|Vykonávaná pozice zaměstnance||
|1058|G|G1058|Pracovní místo / pozice||
|1058|H|H1058|APZ||
|1058|K|K1058|x||
|1058|L|L1058|úprava číselníku||
|1058|M|M1058|přidání číselníků CIS nástroj a hodnoty k číselníkovým proměnným||
|1059|A|A1059|29.5.2025||
|1059|B|B1059|1.4 prefinal||
|1059|D|D1059|10247||
|1059|E|E1059|Funkční požitky dle § 6 odst. 10 ZDP||
|1059|F|F1059|Vykonávaná pozice zaměstnance||
|1059|G|G1059|Činnost||
|1059|K|K1059|x||
|1059|L|L1059|změna business vlastníka||
|1059|M|M1059|FS -> ČSÚ po konzultaci s FS||
|1060|A|A1060|30.5.2025||
|1060|B|B1060|1.4 prefinal||
|1060|D|D1060|10007||
|1060|E|E1060|Typ podání||
|1060|F|F1060|Meta atributy||
|1060|G|G1060|Podání||
|1060|K|K1060|x||
|1060|L|L1060|úprava číselníku||
|1060|M|M1060|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1061|A|A1061|30.5.2025||
|1061|B|B1061|1.4 prefinal||
|1061|D|D1061|10016||
|1061|E|E1061|Typ formuláře||
|1061|F|F1061|Meta atributy||
|1061|G|G1061|Formulář||
|1061|K|K1061|x||
|1061|L|L1061|úprava číselníku||
|1061|M|M1061|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1062|A|A1062|30.5.2025||
|1062|B|B1062|1.4 prefinal||
|1062|D|D1062|10017||
|1062|E|E1062|Stav formuláře||
|1062|F|F1062|Meta atributy||
|1062|G|G1062|Formulář||
|1062|K|K1062|x||
|1062|L|L1062|úprava číselníku||
|1062|M|M1062|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1063|A|A1063|30.5.2025||
|1063|B|B1063|1.4 prefinal||
|1063|D|D1063|10059||
|1063|E|E1063|Pohlaví||
|1063|F|F1063|Zaměstnanec / Žák / Student ||
|1063|G|G1063|Základní identifikace||
|1063|J|J1063|x||
|1063|L|L1063|úprava číselníku||
|1063|M|M1063|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1064|A|A1064|30.5.2025||
|1064|B|B1064|1.4 prefinal||
|1064|D|D1064|10085||
|1064|E|E1064|Typ zdravotního omezení||
|1064|F|F1064|Zaměstnanec / Žák / Student ||
|1064|G|G1064|Deklarované skutečnosti ze strany zaměstnance||
|1064|H|H1064|Zdravotní omezení||
|1064|J|J1064|x||
|1064|L|L1064|úprava číselníku||
|1064|M|M1064|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1065|A|A1065|30.5.2025||
|1065|B|B1065|1.4 prefinal||
|1065|D|D1065|10092||
|1065|E|E1065|Specifikace||
|1065|F|F1065|Zaměstnanec / Žák / Student ||
|1065|G|G1065|Pojištění||
|1065|H|H1065|Cizozemský nositel pojištění||
|1065|J|J1065|x||
|1065|L|L1065|úprava číselníku||
|1065|M|M1065|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1066|A|A1066|30.5.2025||
|1066|B|B1066|1.4 prefinal||
|1066|D|D1066|10106||
|1066|E|E1066|Druh pracovního oprávnění||
|1066|F|F1066|Zaměstnanec / Žák / Student ||
|1066|G|G1066|Zaměstnanec bez státního občanství ČR||
|1066|J|J1066|x||
|1066|L|L1066|úprava číselníku||
|1066|M|M1066|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1067|A|A1067|30.5.2025||
|1067|B|B1067|1.4 prefinal||
|1067|D|D1067|10502||
|1067|E|E1067|Bližší určení pracovněprávního vztahu||
|1067|F|F1067|Vykonávaná pozice zaměstnance||
|1067|G|G1067|Činnost||
|1067|J|J1067|x||
|1067|L|L1067|úprava číselníku||
|1067|M|M1067|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1068|A|A1068|2.6.2025||
|1068|B|B1068|1.4 prefinal||
|1068|D|D1068|10255||
|1068|E|E1068|Pracovní režim||
|1068|F|F1068|Vykonávaná pozice zaměstnance||
|1068|G|G1068|Režim práce||
|1068|J|J1068|x||
|1068|L|L1068|úprava číselníku||
|1068|M|M1068|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1069|A|A1069|2.6.2025||
|1069|B|B1069|1.4 prefinal||
|1069|D|D1069|10258||
|1069|E|E1069|Práce probíhá převážně||
|1069|F|F1069|Vykonávaná pozice zaměstnance||
|1069|G|G1069|Místo výkonu práce / činnosti||
|1069|H|H1069|Výkon práce OZP||
|1069|J|J1069|x||
|1069|L|L1069|úprava číselníku||
|1069|M|M1069|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1070|A|A1070|2.6.2025||
|1070|B|B1070|1.4 prefinal||
|1070|D|D1070|10525||
|1070|E|E1070|Druh zaměstnání||
|1070|F|F1070|Ukončení pracovněprávního vztahu||
|1070|G|G1070|Informace pro podporu v nezaměstnanosti||
|1070|J|J1070|x||
|1070|L|L1070|úprava číselníku||
|1070|M|M1070|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1071|A|A1071|3.6.2025||
|1071|B|B1071|1.4 prefinal||
|1071|D|D1071|10118||
|1071|E|E1071|Typ přihlášky||
|1071|F|F1071|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1071|I|I1071|x||
|1071|L|L1071|úprava číselníku||
|1071|M|M1071|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1072|A|A1072|3.6.2025||
|1072|B|B1072|1.4 prefinal||
|1072|D|D1072|10119||
|1072|E|E1072|Typ zaměstnavatele||
|1072|F|F1072|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1072|G|G1072|Identifikace||
|1072|I|I1072|x||
|1072|L|L1072|úprava číselníku||
|1072|M|M1072|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1073|A|A1073|3.6.2025||
|1073|B|B1073|1.4 prefinal||
|1073|D|D1073|10148||
|1073|E|E1073|Typ odhlášky||
|1073|F|F1073|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1073|G|G1073|Odhlášení z registru||
|1073|I|I1073|x||
|1073|L|L1073|úprava číselníku||
|1073|M|M1073|hromadný převod výčtů na číselníky na jednotlivých záložkách||
|1074|A|A1074|13.6.2025||
|1074|B|B1074|1.4 prefinal||
|1074|D|D1074|10376||
|1074|E|E1074|Důvod neposkytnutí podkladů||
|1074|F|F1074|Ukončení pracovněprávního vztahu||
|1074|G|G1074|Informace pro podporu v nezaměstnanosti||
|1074|J|J1074|x||
|1074|L|L1074|úprava číselníku||
|1074|M|M1074|Uprava textace pro hodnot 2 a 3. Uprava textace od UP||
|1075|A|A1075|17.6.2025||
|1075|B|B1075|1.4 prefinal||
|1075|D|D1075|10247||
|1075|E|E1075|Funkční požitky dle § 6 odst. 10 ZDP||
|1075|F|F1075|Vykonávaná pozice zaměstnance||
|1075|G|G1075|Činnost||
|1075|K|K1075|x||
|1075|L|L1075|úprava konzumace atributu||
|1075|M|M1075|odebrání konzumace na žádost FS||
|1076|A|A1076|20.6.2025||
|1076|B|B1076|1.4 prefinal||
|1076|C|C1076|ZP_TECH_POPIS_013||
|1076|D|D1076|10248||
|1076|E|E1076|Vzdělání požadované pro výkon profese||
|1076|F|F1076|Vykonávaná pozice zaměstnance||
|1076|G|G1076|Profese||
|1076|J|J1076|x||
|1076|L|L1076|přejmenování atributu||
|1076|M|M1076|ZP||
|1077|A|A1077|20.6.2025||
|1077|B|B1077|1.4 prefinal||
|1077|C|C1077|ZP_TECH_POPIS_016||
|1077|D|D1077|10496||
|1077|E|E1077|Výše exekučních srážek ze mzdy včetně výše tzv. nezabavitelné částky||
|1077|F|F1077|Souhrnná data zaměstnance||
|1077|G|G1077|Mzda||
|1077|H|H1077|Srážky ze mzdy||
|1077|K|K1077|x||
|1077|L|L1077|odstranění atributu||
|1077|M|M1077|ZP||
|1078|A|A1078|20.6.2025||
|1078|B|B1078|1.4 prefinal||
|1078|C|C1078|ZP_TECH_POPIS_017||
|1078|D|D1078|10499||
|1078|E|E1078|Výše insolvenčních srážek ze mzdy včetně výše tzv. nezabavitelné částky||
|1078|F|F1078|Souhrnná data zaměstnance||
|1078|G|G1078|Mzda||
|1078|H|H1078|Srážky ze mzdy||
|1078|K|K1078|x||
|1078|L|L1078|odstranění atributu||
|1078|M|M1078|ZP||
|1079|A|A1079|27.6.2025||
|1079|B|B1079|1.4 prefinal||
|1079|C|C1079|ZP_TECH_POPIS_018||
|1079|D|D1079|10356||
|1079|E|E1079|Počet kalendářních dnů trvání doby důchodového pojištění v daném kalendářním měsíci||
|1079|F|F1079|Průběh pojištění v daném měsíci||
|1079|G|G1079|Trvání pojištění||
|1079|K|K1079|x||
|1079|L|L1079|přejmenování atributu||
|1079|M|M1079|ZP||
|1080|A|A1080|27.6.2025||
|1080|B|B1080|1.4 prefinal||
|1080|C|C1080|ZP_TECH_POPIS_020||
|1080|D|D1080|10105||
|1080|E|E1080|Důvod pro volný přístup na trh práce||
|1080|F|F1080|Zaměstnanec / Žák / Student ||
|1080|G|G1080|Zaměstnanec bez státního občanství ČR||
|1080|J|J1080|x||
|1080|L|L1080|přejmenování atributu||
|1080|M|M1080|ZP||
|1081|A|A1081|27.6.2025||
|1081|B|B1081|1.4 prefinal||
|1081|C|C1081|ZP_TECH_POPIS_021||
|1081|D|D1081|10084||
|1081|E|E1081|Pečující o dítě do 4 let věku||
|1081|F|F1081|Zaměstnanec / Žák / Student ||
|1081|G|G1081|Deklarované skutečnosti ze strany zaměstnance||
|1081|H|H1081|Péče||
|1081|J|J1081|x||
|1081|L|L1081|odstranění atributu||
|1081|M|M1081|ZP||
|1082|A|A1082|1.7.2025||
|1082|B|B1082|1.4 prefinal||
|1082|C|C1082|ZP_TECH_POPIS_026||
|1082|D|D1082|10382||
|1082|E|E1082|Násobek příjmu: (PV) Odstupné dle § 67 odst. 1 ZP||
|1082|F|F1082|Ukončení pracovněprávního vztahu||
|1082|G|G1082|Odchodné / odbytné / odstupné||
|1082|J|J1082|x||
|1082|L|L1082|odstranění atributu||
|1082|M|M1082|ZP||
|1083|A|A1083|1.7.2025||
|1083|B|B1083|1.4 prefinal||
|1083|C|C1083|ZP_TECH_POPIS_027||
|1083|D|D1083|10383||
|1083|E|E1083|Násobek příjmu: (PV) Odstupné dle § 67 odst. 2 ZP||
|1083|F|F1083|Ukončení pracovněprávního vztahu||
|1083|G|G1083|Odchodné / odbytné / odstupné||
|1083|J|J1083|x||
|1083|L|L1083|odstranění atributu||
|1083|M|M1083|ZP||
|1084|A|A1084|1.7.2025||
|1084|B|B1084|1.4 prefinal||
|1084|C|C1084|ZP_TECH_POPIS_028||
|1084|D|D1084|10384||
|1084|E|E1084|Násobek příjmu: (SP) Odchodné||
|1084|F|F1084|Ukončení pracovněprávního vztahu||
|1084|G|G1084|Odchodné / odbytné / odstupné||
|1084|J|J1084|x||
|1084|L|L1084|odstranění atributu||
|1084|M|M1084|ZP||
|1085|A|A1085|1.7.2025||
|1085|B|B1085|1.4 prefinal||
|1085|C|C1085|ZP_TECH_POPIS_029||
|1085|D|D1085|10385||
|1085|E|E1085|Násobek příjmu: (SP) Odbytné||
|1085|F|F1085|Ukončení pracovněprávního vztahu||
|1085|G|G1085|Odchodné / odbytné / odstupné||
|1085|J|J1085|x||
|1085|L|L1085|odstranění atributu||
|1085|M|M1085|ZP||
|1086|A|A1086|3.7.2025||
|1086|B|B1086|1.4 prefinal||
|1086|C|C1086|ZP_TECH_POPIS_022||
|1086|D|D1086|10530||
|1086|E|E1086|Jednorázová náhrada při skončení pracovního poměru (§271ca ZP)||
|1086|F|F1086|Ukončení pracovněprávního vztahu||
|1086|G|G1086|Odchodné / odbytné / odstupné||
|1086|H|H1086|Náhrady||
|1086|J|J1086|x||
|1086|L|L1086|přidání atributu||
|1086|M|M1086|ZP||
|1087|A|A1087|3.7.2025||
|1087|B|B1087|1.4 prefinal||
|1087|C|C1087|ZP_TECH_POPIS_023||
|1087|D|D1087|10531||
|1087|E|E1087|Odstupné podle § 67 odst. 1 ZP||
|1087|F|F1087|Ukončení pracovněprávního vztahu||
|1087|G|G1087|Odchodné / odbytné / odstupné||
|1087|J|J1087|x||
|1087|L|L1087|přidání atributu||
|1087|M|M1087|ZP||
|1088|A|A1088|3.7.2025||
|1088|B|B1088|1.4 prefinal||
|1088|C|C1088|ZP_TECH_POPIS_024||
|1088|D|D1088|10532||
|1088|E|E1088|Odchodné||
|1088|F|F1088|Ukončení pracovněprávního vztahu||
|1088|G|G1088|Odchodné / odbytné / odstupné||
|1088|J|J1088|x||
|1088|L|L1088|přidání atributu||
|1088|M|M1088|ZP||
|1089|A|A1089|3.7.2025||
|1089|B|B1089|1.4 prefinal||
|1089|C|C1089|ZP_TECH_POPIS_025||
|1089|D|D1089|10533||
|1089|E|E1089|Odbytné||
|1089|F|F1089|Ukončení pracovněprávního vztahu||
|1089|G|G1089|Odchodné / odbytné / odstupné||
|1089|J|J1089|x||
|1089|L|L1089|přidání atributu||
|1089|M|M1089|ZP||
|1090|A|A1090|4.7.2025||
|1090|B|B1090|1.4 prefinal||
|1090|C|C1090|ZP_TECH_POPIS_036||
|1090|D|D1090|10534||
|1090|E|E1090|Důvod předčasného ukončení ||
|1090|F|F1090|Ukončení pracovněprávního vztahu||
|1090|G|G1090|Informace k zaměstnávání cizinců||
|1090|H|H1090|Důvody||
|1090|J|J1090|x||
|1090|L|L1090|přidání atributu||
|1090|M|M1090|ZP||
|1091|A|A1091|4.7.2025||
|1091|B|B1091|1.4 prefinal||
|1091|C|C1091|ZP_TECH_POPIS_039||
|1091|D|D1091|10069||
|1091|E|E1091|Typ dokladu||
|1091|F|F1091|Zaměstnanec / Žák / Student ||
|1091|G|G1091|Prokázání totožnosti||
|1091|H|H1091|Doklad||
|1091|J|J1091|x||
|1091|L|L1091|úprava číselníku||
|1091|M|M1091|ZP||
|1092|A|A1092|4.7.2025||
|1092|B|B1092|1.4 prefinal||
|1092|C|C1092|ZP_TECH_POPIS_040||
|1092|D|D1092|10260||
|1092|E|E1092|Pracovní doba sjednaná (v hodinách měsíčně)||
|1092|F|F1092|Vykonávaná pozice zaměstnance||
|1092|G|G1092|Fond pracovní doby||
|1092|K|K1092|x||
|1092|L|L1092|přejmenování atributu||
|1092|M|M1092|ZP||
|1093|A|A1093|4.7.2025||
|1093|B|B1093|1.4 prefinal||
|1093|C|C1093|ZP_TECH_POPIS_051||
|1093|D|D1093|10259||
|1093|E|E1093|Pracovní doba stanovená pro danou profesi (v hodinách měsíčně)||
|1093|F|F1093|Vykonávaná pozice zaměstnance||
|1093|G|G1093|Fond pracovní doby||
|1093|K|K1093|x||
|1093|L|L1093|přejmenování atributu||
|1093|M|M1093|ZP||
|1094|A|A1094|4.7.2025||
|1094|B|B1094|1.4 prefinal||
|1094|C|C1094|ZP_TECH_POPIS_041||
|1094|D|D1094|10277||
|1094|E|E1094|Počet neodpracovaných hodin v důsledku dočasné pracovní neschopnosti bez náhrady mzdy hrazené zaměstnavatelem||
|1094|F|F1094|Průběh zaměstnání v daném měsíci||
|1094|G|G1094|Neodpracované hodiny||
|1094|K|K1094|x||
|1094|L|L1094|přejmenování atributu||
|1094|M|M1094|ZP||
|1095|A|A1095|4.7.2025||
|1095|B|B1095|1.4 prefinal||
|1095|C|C1095|ZP_TECH_POPIS_042||
|1095|D|D1095|10339||
|1095|E|E1095|Náhrady za svátky||
|1095|F|F1095|Mzda||
|1095|G|G1095|Náhrady||
|1095|K|K1095|x||
|1095|L|L1095|přejmenování atributu||
|1095|M|M1095|ZP||
|1096|A|A1096|4.7.2025||
|1096|B|B1096|1.4 prefinal||
|1096|C|C1096|ZP_TECH_POPIS_043||
|1096|D|D1096|10344||
|1096|E|E1096|Čistý příjem||
|1096|F|F1096|Souhrnná data zaměstnance||
|1096|G|G1096|Mzda||
|1096|H|H1096|Výdělek||
|1096|K|K1096|x||
|1096|L|L1096|přejmenování atributu||
|1096|M|M1096|ZP||
|1097|A|A1097|7.7.2025||
|1097|B|B1097|1.4 prefinal||
|1097|C|C1097|ZP_TECH_POPIS_001||
|1097|D|D1097|10526||
|1097|E|E1097|Předpokládané/á místo/a výkonu práce||
|1097|F|F1097|Vykonávaná pozice zaměstnance||
|1097|G|G1097|Předpokládané místo výkonu práce||
|1097|J|J1097|x||
|1097|L|L1097|přidání atributu||
|1097|M|M1097|ZP||
|1098|A|A1098|7.7.2025||
|1098|B|B1098|1.4 prefinal||
|1098|C|C1098|ZP_TECH_POPIS_004||
|1098|D|D1098|10527||
|1098|E|E1098|Místo výkonu práce uvedené v pracovní smlouvě zaměstnance||
|1098|F|F1098|Vykonávaná pozice zaměstnance||
|1098|G|G1098|Místo výkonu práce ze smlouvy||
|1098|J|J1098|x||
|1098|L|L1098|přidání atributu||
|1098|M|M1098|ZP||
|1099|A|A1099|7.7.2025||
|1099|B|B1099|1.4 prefinal||
|1099|C|C1099|ZP_TECH_POPIS_005||
|1099|D|D1099|10528||
|1099|E|E1099|Název obce||
|1099|F|F1099|Vykonávaná pozice zaměstnance||
|1099|G|G1099|Místo výkonu práce ze smlouvy||
|1099|J|J1099|x||
|1099|L|L1099|přidání atributu||
|1099|M|M1099|ZP||
|1100|A|A1100|7.7.2025||
|1100|B|B1100|1.4 prefinal||
|1100|C|C1100|ZP_TECH_POPIS_006||
|1100|D|D1100|10529||
|1100|E|E1100|Kód obce||
|1100|F|F1100|Vykonávaná pozice zaměstnance||
|1100|G|G1100|Místo výkonu práce ze smlouvy||
|1100|J|J1100|x||
|1100|L|L1100|přidání atributu||
|1100|M|M1100|ZP||
|1101|A|A1101|8.7.2025||
|1101|B|B1101|1.4 prefinal||
|1101|C|C1101|ZP_TECH_POPIS_010||
|1101|D|D1101|10286||
|1101|E|E1101|Zúčtovaný příjem - celkem||
|1101|F|F1101|Souhrnná data zaměstnance||
|1101|G|G1101|Příjem||
|1101|K|K1101|x||
|1101|L|L1101|změna oblasti a třídy atributu||
|1101|M|M1101|ZP||
|1102|A|A1102|8.7.2025||
|1102|B|B1102|1.4 prefinal||
|1102|C|C1102|ZP_TECH_POPIS_010||
|1102|D|D1102|10416||
|1102|E|E1102|Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR||
|1102|F|F1102|Souhrnná data zaměstnance||
|1102|G|G1102|Příjem||
|1102|K|K1102|x||
|1102|L|L1102|změna oblasti a třídy atributu||
|1102|M|M1102|ZP||
|1103|A|A1103|8.7.2025||
|1103|B|B1103|1.4 prefinal||
|1103|C|C1103|ZP_TECH_POPIS_010||
|1103|D|D1103|10289||
|1103|E|E1103|Osvobozené příjmy ze zúčtovaných příjmů - celkem||
|1103|F|F1103|Souhrnná data zaměstnance||
|1103|G|G1103|Příjem||
|1103|K|K1103|x||
|1103|L|L1103|změna oblasti a třídy atributu||
|1103|M|M1103|ZP||
|1104|A|A1104|8.7.2025||
|1104|B|B1104|1.4 prefinal||
|1104|C|C1104|ZP_TECH_POPIS_010||
|1104|D|D1104|10417||
|1104|E|E1104|Příspěvek zaměstnavatele na produkty spoření na stáří a pojištění dlouhodobé péče z osvobozených příjmů - celkem||
|1104|F|F1104|Souhrnná data zaměstnance||
|1104|G|G1104|Příjem||
|1104|H|H1104|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1104|K|K1104|x||
|1104|L|L1104|změna oblasti a třídy atributu||
|1104|M|M1104|ZP||
|1105|A|A1105|8.7.2025||
|1105|B|B1105|1.4 prefinal||
|1105|C|C1105|ZP_TECH_POPIS_010||
|1105|D|D1105|10292||
|1105|E|E1105|Příspěvek na penzijní připojištění se státním příspěvkem||
|1105|F|F1105|Souhrnná data zaměstnance||
|1105|G|G1105|Příjem||
|1105|H|H1105|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1105|K|K1105|x||
|1105|L|L1105|změna oblasti a třídy atributu||
|1105|M|M1105|ZP||
|1106|A|A1106|8.7.2025||
|1106|B|B1106|1.4 prefinal||
|1106|C|C1106|ZP_TECH_POPIS_010||
|1106|D|D1106|10293||
|1106|E|E1106|Příspěvek na doplňkové penzijní spoření||
|1106|F|F1106|Souhrnná data zaměstnance||
|1106|G|G1106|Příjem||
|1106|H|H1106|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1106|K|K1106|x||
|1106|L|L1106|změna oblasti a třídy atributu||
|1106|M|M1106|ZP||
|1107|A|A1107|8.7.2025||
|1107|B|B1107|1.4 prefinal||
|1107|C|C1107|ZP_TECH_POPIS_010||
|1107|D|D1107|10294||
|1107|E|E1107|Příspěvek na penzijní pojištění||
|1107|F|F1107|Souhrnná data zaměstnance||
|1107|G|G1107|Příjem||
|1107|H|H1107|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1107|K|K1107|x||
|1107|L|L1107|změna oblasti a třídy atributu||
|1107|M|M1107|ZP||
|1108|A|A1108|8.7.2025||
|1108|B|B1108|1.4 prefinal||
|1108|C|C1108|ZP_TECH_POPIS_010||
|1108|D|D1108|10295||
|1108|E|E1108|Příspěvek na soukromé životní pojištění||
|1108|F|F1108|Souhrnná data zaměstnance||
|1108|G|G1108|Příjem||
|1108|H|H1108|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1108|K|K1108|x||
|1108|L|L1108|změna oblasti a třídy atributu||
|1108|M|M1108|ZP||
|1109|A|A1109|8.7.2025||
|1109|B|B1109|1.4 prefinal||
|1109|C|C1109|ZP_TECH_POPIS_010||
|1109|D|D1109|10296||
|1109|E|E1109|Příspěvek na dlouhodobý investiční produkt||
|1109|F|F1109|Souhrnná data zaměstnance||
|1109|G|G1109|Příjem||
|1109|H|H1109|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1109|K|K1109|x||
|1109|L|L1109|změna oblasti a třídy atributu||
|1109|M|M1109|ZP||
|1110|A|A1110|8.7.2025||
|1110|B|B1110|1.4 prefinal||
|1110|C|C1110|ZP_TECH_POPIS_010||
|1110|D|D1110|10418||
|1110|E|E1110|Příspěvek na pojištění dlouhodobé péče||
|1110|F|F1110|Souhrnná data zaměstnance||
|1110|G|G1110|Příjem||
|1110|H|H1110|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1110|K|K1110|x||
|1110|L|L1110|změna oblasti a třídy atributu||
|1110|M|M1110|ZP||
|1111|A|A1111|10.7.2025||
|1111|B|B1111|1.4 prefinal||
|1111|C|C1111|ZP_TECH_POPIS_010||
|1111|D|D1111|10307||
|1111|E|E1111|Základ pro výpočet daně podle zvláštní sazby daně||
|1111|F|F1111|Souhrnná data zaměstnance||
|1111|G|G1111|Výpočet daně podle zvláštní sazby daně ||
|1111|K|K1111|x||
|1111|L|L1111|změna oblasti a třídy atributu||
|1111|M|M1111|ZP||
|1112|A|A1112|10.7.2025||
|1112|B|B1112|1.4 prefinal||
|1112|C|C1112|ZP_TECH_POPIS_010||
|1112|D|D1112|10308||
|1112|E|E1112|Odměna člena (nerezidenta) orgánu právnické osoby||
|1112|F|F1112|Souhrnná data zaměstnance||
|1112|G|G1112|Výpočet daně podle zvláštní sazby daně ||
|1112|K|K1112|x||
|1112|L|L1112|změna oblasti a třídy atributu||
|1112|M|M1112|ZP||
|1113|A|A1113|10.7.2025||
|1113|B|B1113|1.4 prefinal||
|1113|C|C1113|ZP_TECH_POPIS_010||
|1113|D|D1113|10309||
|1113|E|E1113|Skutečně sražená daň podle zvláštní sazby daně / měsíc||
|1113|F|F1113|Souhrnná data zaměstnance||
|1113|G|G1113|Výpočet daně podle zvláštní sazby daně ||
|1113|K|K1113|x||
|1113|L|L1113|změna oblasti a třídy atributu||
|1113|M|M1113|ZP||
|1114|A|A1114|10.7.2025||
|1114|B|B1114|1.4 prefinal||
|1114|C|C1114|ZP_TECH_POPIS_010||
|1114|D|D1114|10310||
|1114|E|E1114|Sražená daň podle zvláštní sazby daně z příjmu nerezidenta člena orgánu právnické osoby||
|1114|F|F1114|Souhrnná data zaměstnance||
|1114|G|G1114|Výpočet daně podle zvláštní sazby daně ||
|1114|K|K1114|x||
|1114|L|L1114|změna oblasti a třídy atributu||
|1114|M|M1114|ZP||
|1115|A|A1115|10.7.2025||
|1115|B|B1115|1.4 prefinal||
|1115|C|C1115|ZP_TECH_POPIS_010||
|1115|D|D1115|10313||
|1115|E|E1115|Zdanitelné příjmy v ČR vyplacené nebo obdržené do 31.1. následujícího roku - příjmy zdaněné zálohou na daň celkem||
|1115|F|F1115|Souhrnná data zaměstnance||
|1115|G|G1115|Roční úhrny jednotlivých položek||
|1115|K|K1115|x||
|1115|L|L1115|změna oblasti a třídy atributu||
|1115|M|M1115|ZP||
|1116|A|A1116|10.7.2025||
|1116|B|B1116|1.4 prefinal||
|1116|C|C1116|ZP_TECH_POPIS_010||
|1116|D|D1116|10317||
|1116|E|E1116|Skutečně sražená záloha na daň z příjmů vyplacených nebo obdržených do 31.1. následujícího roku||
|1116|F|F1116|Souhrnná data zaměstnance||
|1116|G|G1116|Roční úhrny jednotlivých položek||
|1116|K|K1116|x||
|1116|L|L1116|změna oblasti a třídy atributu||
|1116|M|M1116|ZP||
|1117|A|A1117|10.7.2025||
|1117|B|B1117|1.4 prefinal||
|1117|C|C1117|ZP_TECH_POPIS_010||
|1117|D|D1117|10316||
|1117|E|E1117|Doplatky příjmů zúčtovaných v minulých zdaňovacích obdobích zdanitelných v ČR zdaněné zálohou na daň vyplacené nebo obdržené do 31.1. následujícího roku||
|1117|F|F1117|Souhrnná data zaměstnance||
|1117|G|G1117|Roční úhrny jednotlivých položek||
|1117|K|K1117|x||
|1117|L|L1117|změna oblasti a třídy atributu||
|1117|M|M1117|ZP||
|1118|A|A1118|10.7.2025||
|1118|B|B1118|1.4 prefinal||
|1118|C|C1118|ZP_TECH_POPIS_010||
|1118|D|D1118|10318||
|1118|E|E1118|Skutečně sražená záloha na daň z doplatků příjmů zdanitelných v ČR||
|1118|F|F1118|Souhrnná data zaměstnance||
|1118|G|G1118|Roční úhrny jednotlivých položek||
|1118|K|K1118|x||
|1118|L|L1118|změna oblasti a třídy atributu||
|1118|M|M1118|ZP||
|1119|A|A1119|10.7.2025||
|1119|B|B1119|1.4 prefinal||
|1119|C|C1119|ZP_TECH_POPIS_010||
|1119|D|D1119|10311||
|1119|E|E1119|Příjmy podléhající srážkové dani podle zvláštní sazby daně vyplacené nebo obdržené do 31.1. následujícího roku||
|1119|F|F1119|Souhrnná data zaměstnance||
|1119|G|G1119|Roční úhrny jednotlivých položek||
|1119|K|K1119|x||
|1119|L|L1119|změna oblasti a třídy atributu||
|1119|M|M1119|ZP||
|1120|A|A1120|10.7.2025||
|1120|B|B1120|1.4 prefinal||
|1120|C|C1120|ZP_TECH_POPIS_010||
|1120|D|D1120|10312||
|1120|E|E1120|Skutečně sražená daň vybíraná srážkou podle zvláštní sazby daně||
|1120|F|F1120|Souhrnná data zaměstnance||
|1120|G|G1120|Roční úhrny jednotlivých položek||
|1120|K|K1120|x||
|1120|L|L1120|změna oblasti a třídy atributu||
|1120|M|M1120|ZP||
|1121|A|A1121|10.7.2025||
|1121|B|B1121|1.4 prefinal||
|1121|C|C1121|ZP_TECH_POPIS_010||
|1121|D|D1121|10319||
|1121|E|E1121|Zaměstnanec požádal o provedení ročního zúčtování||
|1121|F|F1121|Souhrnná data zaměstnance||
|1121|G|G1121|Roční zúčtování||
|1121|K|K1121|x||
|1121|L|L1121|změna oblasti a třídy atributu||
|1121|M|M1121|ZP||
|1122|A|A1122|10.7.2025||
|1122|B|B1122|1.4 prefinal||
|1122|C|C1122|ZP_TECH_POPIS_010||
|1122|D|D1122|10320||
|1122|E|E1122|Roční zúčtování záloh bylo provedeno||
|1122|F|F1122|Souhrnná data zaměstnance||
|1122|G|G1122|Roční zúčtování||
|1122|K|K1122|x||
|1122|L|L1122|změna oblasti a třídy atributu||
|1122|M|M1122|ZP||
|1123|A|A1123|10.7.2025||
|1123|B|B1123|1.4 prefinal||
|1123|C|C1123|ZP_TECH_POPIS_010||
|1123|D|D1123|10321||
|1123|E|E1123|Přeplatek nebo nedoplatek z ročního zúčtování||
|1123|F|F1123|Souhrnná data zaměstnance||
|1123|G|G1123|Výsledek ročního zúčtování||
|1123|K|K1123|x||
|1123|L|L1123|změna oblasti a třídy atributu||
|1123|M|M1123|ZP||
|1124|A|A1124|10.7.2025||
|1124|B|B1124|1.4 prefinal||
|1124|C|C1124|ZP_TECH_POPIS_010||
|1124|D|D1124|10322||
|1124|E|E1124|Přeplatek nebo nedoplatek z ročního zúčtování - z toho přeplatek na dani nebo nedoplatek daně||
|1124|F|F1124|Souhrnná data zaměstnance||
|1124|G|G1124|Výsledek ročního zúčtování||
|1124|K|K1124|x||
|1124|L|L1124|změna oblasti a třídy atributu||
|1124|M|M1124|ZP||
|1125|A|A1125|10.7.2025||
|1125|B|B1125|1.4 prefinal||
|1125|C|C1125|ZP_TECH_POPIS_010||
|1125|D|D1125|10323||
|1125|E|E1125|Přeplatek nebo nedoplatek z ročního zúčtování - z toho doplatek na daňovém bonusu nebo přeplacená částka daňového bonusu zaměstnanci||
|1125|F|F1125|Souhrnná data zaměstnance||
|1125|G|G1125|Výsledek ročního zúčtování||
|1125|K|K1125|x||
|1125|L|L1125|změna oblasti a třídy atributu||
|1125|M|M1125|ZP||
|1126|A|A1126|10.7.2025||
|1126|B|B1126|1.4 prefinal||
|1126|C|C1126|ZP_TECH_POPIS_010||
|1126|D|D1126|10420||
|1126|E|E1126|Uplatněna sleva na manželku / manžela||
|1126|F|F1126|Souhrnná data zaměstnance||
|1126|G|G1126|Výsledek ročního zúčtování||
|1126|H|H1126|Sleva na manželku / manžela||
|1126|K|K1126|x||
|1126|L|L1126|změna oblasti a třídy atributu||
|1126|M|M1126|ZP||
|1127|A|A1127|10.7.2025||
|1127|B|B1127|1.4 prefinal||
|1127|C|C1127|ZP_TECH_POPIS_010||
|1127|D|D1127|10421||
|1127|E|E1127|Jméno manželky / manžela||
|1127|F|F1127|Souhrnná data zaměstnance||
|1127|G|G1127|Výsledek ročního zúčtování||
|1127|H|H1127|Sleva na manželku / manžela||
|1127|K|K1127|x||
|1127|L|L1127|změna oblasti a třídy atributu||
|1127|M|M1127|ZP||
|1128|A|A1128|10.7.2025||
|1128|B|B1128|1.4 prefinal||
|1128|C|C1128|ZP_TECH_POPIS_010||
|1128|D|D1128|10422||
|1128|E|E1128|Příjmení manželky / manžela||
|1128|F|F1128|Souhrnná data zaměstnance||
|1128|G|G1128|Výsledek ročního zúčtování||
|1128|H|H1128|Sleva na manželku / manžela||
|1128|K|K1128|x||
|1128|L|L1128|změna oblasti a třídy atributu||
|1128|M|M1128|ZP||
|1129|A|A1129|10.7.2025||
|1129|B|B1129|1.4 prefinal||
|1129|C|C1129|ZP_TECH_POPIS_010||
|1129|D|D1129|10423||
|1129|E|E1129|Rodné číslo manželky / manžela||
|1129|F|F1129|Souhrnná data zaměstnance||
|1129|G|G1129|Výsledek ročního zúčtování||
|1129|H|H1129|Sleva na manželku / manžela||
|1129|K|K1129|x||
|1129|L|L1129|změna oblasti a třídy atributu||
|1129|M|M1129|ZP||
|1130|A|A1130|10.7.2025||
|1130|B|B1130|1.4 prefinal||
|1130|C|C1130|ZP_TECH_POPIS_010||
|1130|D|D1130|10424||
|1130|E|E1130|Datum narození manželky / manžela||
|1130|F|F1130|Souhrnná data zaměstnance||
|1130|G|G1130|Výsledek ročního zúčtování||
|1130|H|H1130|Sleva na manželku / manžela||
|1130|K|K1130|x||
|1130|L|L1130|změna oblasti a třídy atributu||
|1130|M|M1130|ZP||
|1131|A|A1131|10.7.2025||
|1131|B|B1131|1.4 prefinal||
|1131|C|C1131|ZP_TECH_POPIS_010||
|1131|D|D1131|10425||
|1131|E|E1131|Držitelka / držitel karty ZTP/P||
|1131|F|F1131|Souhrnná data zaměstnance||
|1131|G|G1131|Výsledek ročního zúčtování||
|1131|H|H1131|Sleva na manželku / manžela||
|1131|K|K1131|x||
|1131|L|L1131|změna oblasti a třídy atributu||
|1131|M|M1131|ZP||
|1132|A|A1132|10.7.2025||
|1132|B|B1132|1.4 prefinal||
|1132|C|C1132|ZP_TECH_POPIS_010||
|1132|D|D1132|10426||
|1132|E|E1132|Počet měsíců uplatnění slevy||
|1132|F|F1132|Souhrnná data zaměstnance||
|1132|G|G1132|Výsledek ročního zúčtování||
|1132|H|H1132|Sleva na manželku / manžela||
|1132|K|K1132|x||
|1132|L|L1132|změna oblasti a třídy atributu||
|1132|M|M1132|ZP||
|1133|A|A1133|10.7.2025||
|1133|B|B1133|1.4 prefinal||
|1133|C|C1133|ZP_TECH_POPIS_010||
|1133|D|D1133|10430||
|1133|E|E1133|Počet měsíců uplatnění slevy - z toho počet měsíců ZTP/P||
|1133|F|F1133|Souhrnná data zaměstnance||
|1133|G|G1133|Výsledek ročního zúčtování||
|1133|H|H1133|Sleva na manželku / manžela||
|1133|K|K1133|x||
|1133|L|L1133|změna oblasti a třídy atributu||
|1133|M|M1133|ZP||
|1134|A|A1134|10.7.2025||
|1134|B|B1134|1.4 prefinal||
|1134|C|C1134|ZP_TECH_POPIS_010||
|1134|D|D1134|10454||
|1134|E|E1134|Uplatněno daňové zvýhodnění na děti ||
|1134|F|F1134|Souhrnná data zaměstnance||
|1134|G|G1134|Výsledek ročního zúčtování||
|1134|H|H1134|Daňové zvýhodnění na děti||
|1134|K|K1134|x||
|1134|L|L1134|změna oblasti a třídy atributu||
|1134|M|M1134|ZP||
|1135|A|A1135|10.7.2025||
|1135|B|B1135|1.4 prefinal||
|1135|C|C1135|ZP_TECH_POPIS_010||
|1135|D|D1135|10455||
|1135|E|E1135|Vyživuje tytéž děti v téže společně hospodařící domácnosti i jiná osoba||
|1135|F|F1135|Souhrnná data zaměstnance||
|1135|G|G1135|Výsledek ročního zúčtování||
|1135|H|H1135|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|1135|K|K1135|x||
|1135|L|L1135|změna oblasti a třídy atributu||
|1135|M|M1135|ZP||
|1136|A|A1136|10.7.2025||
|1136|B|B1136|1.4 prefinal||
|1136|C|C1136|ZP_TECH_POPIS_010||
|1136|D|D1136|10441||
|1136|E|E1136|Jméno||
|1136|F|F1136|Souhrnná data zaměstnance||
|1136|G|G1136|Výsledek ročního zúčtování||
|1136|H|H1136|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|1136|K|K1136|x||
|1136|L|L1136|změna oblasti a třídy atributu||
|1136|M|M1136|ZP||
|1137|A|A1137|10.7.2025||
|1137|B|B1137|1.4 prefinal||
|1137|C|C1137|ZP_TECH_POPIS_010||
|1137|D|D1137|10442||
|1137|E|E1137|Příjmení||
|1137|F|F1137|Souhrnná data zaměstnance||
|1137|G|G1137|Výsledek ročního zúčtování||
|1137|H|H1137|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|1137|K|K1137|x||
|1137|L|L1137|změna oblasti a třídy atributu||
|1137|M|M1137|ZP||
|1138|A|A1138|10.7.2025||
|1138|B|B1138|1.4 prefinal||
|1138|C|C1138|ZP_TECH_POPIS_010||
|1138|D|D1138|10443||
|1138|E|E1138|Datum narození||
|1138|F|F1138|Souhrnná data zaměstnance||
|1138|G|G1138|Výsledek ročního zúčtování||
|1138|H|H1138|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|1138|K|K1138|x||
|1138|L|L1138|změna oblasti a třídy atributu||
|1138|M|M1138|ZP||
|1139|A|A1139|10.7.2025||
|1139|B|B1139|1.4 prefinal||
|1139|C|C1139|ZP_TECH_POPIS_010||
|1139|D|D1139|10444||
|1139|E|E1139|Rodné číslo||
|1139|F|F1139|Souhrnná data zaměstnance||
|1139|G|G1139|Výsledek ročního zúčtování||
|1139|H|H1139|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|1139|K|K1139|x||
|1139|L|L1139|změna oblasti a třídy atributu||
|1139|M|M1139|ZP||
|1140|A|A1140|10.7.2025||
|1140|B|B1140|1.4 prefinal||
|1140|C|C1140|ZP_TECH_POPIS_010||
|1140|D|D1140|10445||
|1140|E|E1140|Měsíce vyživování||
|1140|F|F1140|Souhrnná data zaměstnance||
|1140|G|G1140|Výsledek ročního zúčtování||
|1140|H|H1140|Jiná osoba vyživující děti ve společně hospodařící domácnosti||
|1140|K|K1140|x||
|1140|L|L1140|změna oblasti a třídy atributu||
|1140|M|M1140|ZP||
|1141|A|A1141|10.7.2025||
|1141|B|B1141|1.4 prefinal||
|1141|C|C1141|ZP_TECH_POPIS_010||
|1141|D|D1141|10446||
|1141|E|E1141|Jméno||
|1141|F|F1141|Souhrnná data zaměstnance||
|1141|G|G1141|Výsledek ročního zúčtování||
|1141|H|H1141|Vyživované děti||
|1141|K|K1141|x||
|1141|L|L1141|změna oblasti a třídy atributu||
|1141|M|M1141|ZP||
|1142|A|A1142|10.7.2025||
|1142|B|B1142|1.4 prefinal||
|1142|C|C1142|ZP_TECH_POPIS_010||
|1142|D|D1142|10447||
|1142|E|E1142|Příjmení||
|1142|F|F1142|Souhrnná data zaměstnance||
|1142|G|G1142|Výsledek ročního zúčtování||
|1142|H|H1142|Vyživované děti||
|1142|K|K1142|x||
|1142|L|L1142|změna oblasti a třídy atributu||
|1142|M|M1142|ZP||
|1143|A|A1143|10.7.2025||
|1143|B|B1143|1.4 prefinal||
|1143|C|C1143|ZP_TECH_POPIS_010||
|1143|D|D1143|10448||
|1143|E|E1143|Datum narození||
|1143|F|F1143|Souhrnná data zaměstnance||
|1143|G|G1143|Výsledek ročního zúčtování||
|1143|H|H1143|Vyživované děti||
|1143|K|K1143|x||
|1143|L|L1143|změna oblasti a třídy atributu||
|1143|M|M1143|ZP||
|1144|A|A1144|10.7.2025||
|1144|B|B1144|1.4 prefinal||
|1144|C|C1144|ZP_TECH_POPIS_010||
|1144|D|D1144|10449||
|1144|E|E1144|Rodné číslo||
|1144|F|F1144|Souhrnná data zaměstnance||
|1144|G|G1144|Výsledek ročního zúčtování||
|1144|H|H1144|Vyživované děti||
|1144|K|K1144|x||
|1144|L|L1144|změna oblasti a třídy atributu||
|1144|M|M1144|ZP||
|1145|A|A1145|10.7.2025||
|1145|B|B1145|1.4 prefinal||
|1145|C|C1145|ZP_TECH_POPIS_010||
|1145|D|D1145|10450||
|1145|E|E1145|Průkaz ZTP/P v jednotlivých měsících||
|1145|F|F1145|Souhrnná data zaměstnance||
|1145|G|G1145|Výsledek ročního zúčtování||
|1145|H|H1145|Vyživované děti||
|1145|K|K1145|x||
|1145|L|L1145|změna oblasti a třídy atributu||
|1145|M|M1145|ZP||
|1146|A|A1146|10.7.2025||
|1146|B|B1146|1.4 prefinal||
|1146|C|C1146|ZP_TECH_POPIS_010||
|1146|D|D1146|10451||
|1146|E|E1146|Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících||
|1146|F|F1146|Souhrnná data zaměstnance||
|1146|G|G1146|Výsledek ročního zúčtování||
|1146|H|H1146|Vyživované děti||
|1146|K|K1146|x||
|1146|L|L1146|změna oblasti a třídy atributu||
|1146|M|M1146|ZP||
|1147|A|A1147|11.7.2025||
|1147|B|B1147|1.4 prefinal||
|1147|C|C1147|ZP_TECH_POPIS_034||
|1147|D|D1147|10535||
|1147|E|E1147|Základ pro výpočet daně||
|1147|F|F1147|Příjem v daném měsíci||
|1147|G|G1147|Daň||
|1147|K|K1147|x||
|1147|L|L1147|přidání atributu||
|1147|M|M1147|ZP||
|1148|A|A1148|11.7.2025||
|1148|B|B1148|1.4 prefinal||
|1148|C|C1148|ZP_TECH_POPIS_011||
|1148|D|D1148|10348||
|1148|E|E1148|Mzda/plat nebo jeho část vyplacena v hotovosti ||
|1148|F|F1148|Souhrnná data zaměstnance||
|1148|G|G1148|Mzda||
|1148|H|H1148|Výdělek osob OZP||
|1148|K|K1148|x||
|1148|L|L1148|změna oblasti a třídy atributu||
|1148|M|M1148|ZP||
|1149|A|A1149|11.7.2025||
|1149|B|B1149|1.4 prefinal||
|1149|C|C1149|ZP_TECH_POPIS_011||
|1149|D|D1149|10349||
|1149|E|E1149|Provedeny srážky ze mzdy nebo platu určené k uspokojení plnění zaměstnavatele||
|1149|F|F1149|Souhrnná data zaměstnance||
|1149|G|G1149|Mzda||
|1149|H|H1149|Výdělek osob OZP||
|1149|K|K1149|x||
|1149|L|L1149|změna oblasti a třídy atributu||
|1149|M|M1149|ZP||
|1150|A|A1150|11.7.2025||
|1150|B|B1150|1.4 prefinal||
|1150|C|C1150|ZP_TECH_POPIS_011||
|1150|D|D1150|10347||
|1150|E|E1150|Datum úhrady mzdy včetně odvodů na soc. a zdravotní pojištění||
|1150|F|F1150|Souhrnná data zaměstnance||
|1150|G|G1150|Mzda||
|1150|H|H1150|Výdělek osob OZP||
|1150|K|K1150|x||
|1150|L|L1150|změna oblasti a třídy atributu||
|1150|M|M1150|ZP||
|1151|A|A1151|11.7.2025||
|1151|B|B1151|1.4 prefinal||
|1151|C|C1151|ZP_TECH_POPIS_011||
|1151|D|D1151|10350||
|1151|E|E1151|Srážky k uspokojení plnění zaměstnavatele podle občanského zákoníku||
|1151|F|F1151|Souhrnná data zaměstnance||
|1151|G|G1151|Mzda||
|1151|H|H1151|Srážky ze mzdy||
|1151|K|K1151|x||
|1151|L|L1151|změna oblasti a třídy atributu||
|1151|M|M1151|ZP||
|1152|A|A1152|11.7.2025||
|1152|B|B1152|1.4 prefinal||
|1152|C|C1152|ZP_TECH_POPIS_011||
|1152|D|D1152|10351||
|1152|E|E1152|Srážky k uhrazení škody, za kterou odpovídá zaměstnanec||
|1152|F|F1152|Souhrnná data zaměstnance||
|1152|G|G1152|Mzda||
|1152|H|H1152|Srážky ze mzdy||
|1152|K|K1152|x||
|1152|L|L1152|změna oblasti a třídy atributu||
|1152|M|M1152|ZP||
|1153|A|A1153|11.7.2025||
|1153|B|B1153|1.4 prefinal||
|1153|C|C1153|ZP_TECH_POPIS_011||
|1153|D|D1153|10352||
|1153|E|E1153|Srážky na závodní stravování pode §236 zákoníku práce,||
|1153|F|F1153|Souhrnná data zaměstnance||
|1153|G|G1153|Mzda||
|1153|H|H1153|Srážky ze mzdy||
|1153|K|K1153|x||
|1153|L|L1153|změna oblasti a třídy atributu||
|1153|M|M1153|ZP||
|1154|A|A1154|11.7.2025||
|1154|B|B1154|1.4 prefinal||
|1154|C|C1154|ZP_TECH_POPIS_011||
|1154|D|D1154|10353||
|1154|E|E1154|Srážky k uspokojení závazků zaměstnance podle § 146 písm. b) zákoníku práce||
|1154|F|F1154|Souhrnná data zaměstnance||
|1154|G|G1154|Mzda||
|1154|H|H1154|Srážky ze mzdy||
|1154|K|K1154|x||
|1154|L|L1154|změna oblasti a třídy atributu||
|1154|M|M1154|ZP||
|1155|A|A1155|11.7.2025||
|1155|B|B1155|1.4 prefinal||
|1155|C|C1155|ZP_TECH_POPIS_019||
|1155|D|D1155|10440||
|1155|E|E1155|Pořadí pro určení výše daňového zvýhodnění||
|1155|F|F1155|Souhrnná data zaměstnance||
|1155|G|G1155|Výpočet zálohy na daň||
|1155|H|H1155|Vyživované děti||
|1155|K|K1155|x||
|1155|L|L1155|změna datového typu||
|1155|M|M1155|ZP||
|1156|A|A1156|14.7.2025||
|1156|B|B1156|1.4 prefinal||
|1156|D|D1156|10020||
|1156|E|E1156|Datum a čas zapsání osobního identifikačního čísla||
|1156|F|F1156|Meta atributy||
|1156|G|G1156|Formulář||
|1156|K|K1156|x||
|1156|L|L1156|přejmenování atributu||
|1156|M|M1156|sjednocení s legislativním názvem||
|1157|A|A1157|15.7.2025||
|1157|B|B1157|1.4 prefinal||
|1157|C|C1157|ZP_TECH_POPIS_009||
|1157|D|D1157|10536||
|1157|E|E1157|Počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb.||
|1157|F|F1157|Průběh pojištění v daném měsíci||
|1157|G|G1157|Vyloučené dny||
|1157|K|K1157|x||
|1157|L|L1157|přidání atributu||
|1157|M|M1157|ZP||
|1158|A|A1158|15.7.2025||
|1158|B|B1158|1.4 prefinal||
|1158|C|C1158|ZP_TECH_POPIS_049||
|1158|D|D1158|10244||
|1158|E|E1158|Vyloučené doby||
|1158|F|F1158|Průběh pojištění v daném měsíci||
|1158|G|G1158|ELDP||
|1158|K|K1158|x||
|1158|L|L1158|odstranění atributu||
|1158|M|M1158|ZP||
|1159|A|A1159|15.7.2025||
|1159|B|B1159|1.4 prefinal||
|1159|C|C1159|ZP_TECH_POPIS_049||
|1159|D|D1159|10246||
|1159|E|E1159|Doby odečtené||
|1159|F|F1159|Průběh pojištění v daném měsíci||
|1159|G|G1159|ELDP||
|1159|K|K1159|x||
|1159|L|L1159|odstranění atributu||
|1159|M|M1159|ZP||
|1160|A|A1160|15.7.2025||
|1160|B|B1160|1.4 prefinal||
|1160|C|C1160|ZP_TECH_POPIS_049||
|1160|D|D1160|10467||
|1160|E|E1160|Počet dnů rodičovské dovolené||
|1160|F|F1160|Průběh pojištění v daném měsíci||
|1160|G|G1160|Odečítané dny||
|1160|K|K1160|x||
|1160|L|L1160|odstranění atributu||
|1160|M|M1160|ZP||
|1161|A|A1161|15.7.2025||
|1161|B|B1161|1.4 prefinal||
|1161|C|C1161|ZP_TECH_POPIS_009||
|1161|D|D1161|10357||
|1161|E|E1161|Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1161|F|F1161|Průběh pojištění v daném měsíci||
|1161|G|G1161|ELDP||
|1161|H|H1161|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1161|K|K1161|x||
|1161|L|L1161|přejmenování atributu||
|1161|M|M1161|ZP - přejmenování kvůli rozšíření součtu o dílčí atribut||
|1162|A|A1162|16.7.2025||
|1162|B|B1162|1.4 prefinal||
|1162|C|C1162|ZP_TECH_POPIS_049||
|1162|D|D1162|10356||
|1162|E|E1162|Počet kalendářních dnů trvání doby důchodového pojištění v daném kalendářním měsíci||
|1162|F|F1162|Průběh pojištění v daném měsíci||
|1162|G|G1162|ELDP||
|1162|K|K1162|x||
|1162|L|L1162|změna třídy atributu||
|1162|M|M1162|ZP||
|1163|A|A1163|16.7.2025||
|1163|B|B1163|1.4 prefinal||
|1163|C|C1163|ZP_TECH_POPIS_049||
|1163|D|D1163|10357||
|1163|E|E1163|Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1163|F|F1163|Průběh pojištění v daném měsíci||
|1163|G|G1163|ELDP||
|1163|H|H1163|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1163|K|K1163|x||
|1163|L|L1163|změna třídy atributu||
|1163|M|M1163|ZP||
|1164|A|A1164|16.7.2025||
|1164|B|B1164|1.4 prefinal||
|1164|C|C1164|ZP_TECH_POPIS_049||
|1164|D|D1164|10358||
|1164|E|E1164|Počet dnů trvání dočasné pracovní neschopnosti||
|1164|F|F1164|Průběh pojištění v daném měsíci||
|1164|G|G1164|ELDP||
|1164|H|H1164|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1164|K|K1164|x||
|1164|L|L1164|změna třídy atributu||
|1164|M|M1164|ZP||
|1165|A|A1165|16.7.2025||
|1165|B|B1165|1.4 prefinal||
|1165|C|C1165|ZP_TECH_POPIS_049||
|1165|D|D1165|10359||
|1165|E|E1165|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|1165|F|F1165|Průběh pojištění v daném měsíci||
|1165|G|G1165|ELDP||
|1165|H|H1165|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1165|K|K1165|x||
|1165|L|L1165|změna třídy atributu||
|1165|M|M1165|ZP||
|1166|A|A1166|16.7.2025||
|1166|B|B1166|1.4 prefinal||
|1166|C|C1166|ZP_TECH_POPIS_049||
|1166|D|D1166|10360||
|1166|E|E1166|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|1166|F|F1166|Průběh pojištění v daném měsíci||
|1166|G|G1166|ELDP||
|1166|H|H1166|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1166|K|K1166|x||
|1166|L|L1166|změna třídy atributu||
|1166|M|M1166|ZP||
|1167|A|A1167|16.7.2025||
|1167|B|B1167|1.4 prefinal||
|1167|C|C1167|ZP_TECH_POPIS_049||
|1167|D|D1167|10362||
|1167|E|E1167|Počet dnů čerpání otcovské||
|1167|F|F1167|Průběh pojištění v daném měsíci||
|1167|G|G1167|ELDP||
|1167|H|H1167|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1167|K|K1167|x||
|1167|L|L1167|změna třídy atributu||
|1167|M|M1167|ZP||
|1168|A|A1168|16.7.2025||
|1168|B|B1168|1.4 prefinal||
|1168|C|C1168|ZP_TECH_POPIS_049||
|1168|D|D1168|10536||
|1168|E|E1168|Počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb.||
|1168|F|F1168|Průběh pojištění v daném měsíci||
|1168|G|G1168|ELDP||
|1168|H|H1168|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1168|K|K1168|x||
|1168|L|L1168|změna třídy atributu||
|1168|M|M1168|ZP||
|1169|A|A1169|16.7.2025||
|1169|B|B1169|1.4 prefinal||
|1169|C|C1169|ZP_TECH_POPIS_049||
|1169|D|D1169|10366||
|1169|E|E1169|Vyloučené dny podle § 18 odst. 7 zákona č. 187/2006 Sb.||
|1169|F|F1169|Průběh pojištění v daném měsíci||
|1169|G|G1169|ELDP||
|1169|H|H1169|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|1169|L|L1169|změna třídy atributu||
|1169|M|M1169|ZP||
|1170|A|A1170|16.7.2025||
|1170|B|B1170|1.4 prefinal||
|1170|C|C1170|ZP_TECH_POPIS_049||
|1170|D|D1170|10473||
|1170|E|E1170|Počet dnů omluvené nepřítomnosti, za které nenáleží náhrada příjmu (neplacené volno, stávka)||
|1170|F|F1170|Průběh pojištění v daném měsíci||
|1170|G|G1170|ELDP||
|1170|H|H1170|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|1170|L|L1170|změna třídy atributu||
|1170|M|M1170|ZP||
|1171|A|A1171|16.7.2025||
|1171|B|B1171|1.4 prefinal||
|1171|C|C1171|ZP_TECH_POPIS_049||
|1171|D|D1171|10474||
|1171|E|E1171|Počet dnů dočasné pracovní neschopnosti nebo karantény, za které náleží náhrada příjmu||
|1171|F|F1171|Průběh pojištění v daném měsíci||
|1171|G|G1171|ELDP||
|1171|H|H1171|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|1171|L|L1171|změna třídy atributu||
|1171|M|M1171|ZP||
|1172|A|A1172|16.7.2025||
|1172|B|B1172|1.4 prefinal||
|1172|C|C1172|ZP_TECH_POPIS_049||
|1172|D|D1172|10475||
|1172|E|E1172|Počet dnů, za které bylo zaměstnanci vypláceno nemocenské, peněžitá pomoc v mateřství, otcovská, ošetřovné nebo dlouhodobé ošetřovné ||
|1172|F|F1172|Průběh pojištění v daném měsíci||
|1172|G|G1172|ELDP||
|1172|H|H1172|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|1172|L|L1172|změna třídy atributu||
|1172|M|M1172|ZP||
|1173|A|A1173|16.7.2025||
|1173|B|B1173|1.4 prefinal||
|1173|C|C1173|ZP_TECH_POPIS_049||
|1173|D|D1173|10375||
|1173|E|E1173|Doby odečítané po důchodovém věku - počet dnů||
|1173|F|F1173|Průběh pojištění v daném měsíci||
|1173|G|G1173|ELDP||
|1173|H|H1173|Odečítané dny||
|1173|K|K1173|x||
|1173|L|L1173|změna třídy atributu||
|1173|M|M1173|ZP||
|1174|A|A1174|16.7.2025||
|1174|B|B1174|1.4 prefinal||
|1174|C|C1174|ZP_TECH_POPIS_049||
|1174|D|D1174|10462||
|1174|E|E1174|Počet dnů trvání dočasné pracovní neschopnosti (karanténa)||
|1174|F|F1174|Průběh pojištění v daném měsíci||
|1174|G|G1174|ELDP||
|1174|H|H1174|Odečítané dny||
|1174|K|K1174|x||
|1174|L|L1174|změna třídy atributu||
|1174|M|M1174|ZP||
|1175|A|A1175|16.7.2025||
|1175|B|B1175|1.4 prefinal||
|1175|C|C1175|ZP_TECH_POPIS_049||
|1175|D|D1175|10463||
|1175|E|E1175|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|1175|F|F1175|Průběh pojištění v daném měsíci||
|1175|G|G1175|ELDP||
|1175|H|H1175|Odečítané dny||
|1175|K|K1175|x||
|1175|L|L1175|změna třídy atributu||
|1175|M|M1175|ZP||
|1176|A|A1176|16.7.2025||
|1176|B|B1176|1.4 prefinal||
|1176|C|C1176|ZP_TECH_POPIS_049||
|1176|D|D1176|10464||
|1176|E|E1176|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|1176|F|F1176|Průběh pojištění v daném měsíci||
|1176|G|G1176|ELDP||
|1176|H|H1176|Odečítané dny||
|1176|K|K1176|x||
|1176|L|L1176|změna třídy atributu||
|1176|M|M1176|ZP||
|1177|A|A1177|16.7.2025||
|1177|B|B1177|1.4 prefinal||
|1177|C|C1177|ZP_TECH_POPIS_049||
|1177|D|D1177|10465||
|1177|E|E1177|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné ||
|1177|F|F1177|Průběh pojištění v daném měsíci||
|1177|G|G1177|ELDP||
|1177|H|H1177|Odečítané dny||
|1177|K|K1177|x||
|1177|L|L1177|změna třídy atributu||
|1177|M|M1177|ZP||
|1178|A|A1178|16.7.2025||
|1178|B|B1178|1.4 prefinal||
|1178|C|C1178|ZP_TECH_POPIS_049||
|1178|D|D1178|10466||
|1178|E|E1178|Počet dnů čerpání otcovské||
|1178|F|F1178|Průběh pojištění v daném měsíci||
|1178|G|G1178|ELDP||
|1178|H|H1178|Odečítané dny||
|1178|K|K1178|x||
|1178|L|L1178|změna třídy atributu||
|1178|M|M1178|ZP||
|1179|A|A1179|16.7.2025||
|1179|B|B1179|1.4 prefinal||
|1179|C|C1179|ZP_TECH_POPIS_049||
|1179|D|D1179|10468||
|1179|E|E1179|Počet dnů čerpání neplaceného volna||
|1179|F|F1179|Průběh pojištění v daném měsíci||
|1179|G|G1179|ELDP||
|1179|H|H1179|Odečítané dny||
|1179|K|K1179|x||
|1179|L|L1179|změna třídy atributu||
|1179|M|M1179|ZP||
|1180|A|A1180|16.7.2025||
|1180|B|B1180|1.4 prefinal||
|1180|C|C1180|ZP_TECH_POPIS_049||
|1180|D|D1180|10469||
|1180|E|E1180|Počet dnů neomluvené absence||
|1180|F|F1180|Průběh pojištění v daném měsíci||
|1180|G|G1180|ELDP||
|1180|H|H1180|Odečítané dny||
|1180|K|K1180|x||
|1180|L|L1180|změna třídy atributu||
|1180|M|M1180|ZP||
|1181|A|A1181|16.7.2025||
|1181|B|B1181|1.4 prefinal||
|1181|C|C1181|ZP_TECH_POPIS_049||
|1181|D|D1181|10357||
|1181|E|E1181|Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1181|F|F1181|Průběh pojištění v daném měsíci||
|1181|G|G1181|ELDP||
|1181|H|H1181|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1181|K|K1181|x||
|1181|L|L1181|úprava prefillu - vzorce||
|1181|M|M1181|ZP||
|1182|A|A1182|16.7.2025||
|1182|B|B1182|1.4 prefinal||
|1182|C|C1182|ZP_TECH_POPIS_049||
|1182|D|D1182|10375||
|1182|E|E1182|Doby odečítané po důchodovém věku - počet dnů||
|1182|F|F1182|Průběh pojištění v daném měsíci||
|1182|G|G1182|ELDP||
|1182|H|H1182|Odečítané dny||
|1182|K|K1182|x||
|1182|L|L1182|přidání prefillu||
|1182|M|M1182|ZP||
|1183|A|A1183|16.7.2025||
|1183|B|B1183|1.4 prefinal||
|1183|C|C1183|ZP_TECH_POPIS_007||
|1183|D|D1183|10537||
|1183|E|E1183|Měsíc, za který je hlášeno||
|1183|F|F1183|Průběh pojištění v daném měsíci||
|1183|G|G1183|ELDP||
|1183|H|H1183|Odložený příjem||
|1183|K|K1183|x||
|1183|L|L1183|přidání atributu||
|1183|M|M1183|ZP||
|1184|A|A1184|16.7.2025||
|1184|B|B1184|1.4 prefinal||
|1184|C|C1184|ZP_TECH_POPIS_007||
|1184|D|D1184|10538||
|1184|E|E1184|Rok, za který je hlášeno||
|1184|F|F1184|Průběh pojištění v daném měsíci||
|1184|G|G1184|ELDP||
|1184|H|H1184|Odložený příjem||
|1184|K|K1184|x||
|1184|L|L1184|přidání atributu||
|1184|M|M1184|ZP||
|1185|A|A1185|16.7.2025||
|1185|B|B1185|1.4 prefinal||
|1185|C|C1185|ZP_TECH_POPIS_049||
|1185|D|D1185|10357||
|1185|E|E1185|Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1185|F|F1185|Průběh pojištění v daném měsíci||
|1185|G|G1185|ELDP||
|1185|H|H1185|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1185|K|K1185|x||
|1185|L|L1185|úprava konzumace atributu||
|1185|M|M1185|ZP - náhrada konzumace FS za smazaný atribut 10244||
|1186|A|A1186|16.7.2025||
|1186|B|B1186|1.4 prefinal||
|1186|C|C1186|ZP_TECH_POPIS_049||
|1186|D|D1186|10375||
|1186|E|E1186|Doby odečítané po důchodovém věku - počet dnů||
|1186|F|F1186|Průběh pojištění v daném měsíci||
|1186|G|G1186|ELDP||
|1186|H|H1186|Odečítané dny||
|1186|K|K1186|x||
|1186|L|L1186|úprava konzumace atributu||
|1186|M|M1186|ZP - náhrada konzumace FS za smazaný atribut 10246||
|1187|A|A1187|22.7.2025||
|1187|B|B1187|1.4 final||
|1187|D|D1187|10477||
|1187|E|E1187|Částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné||
|1187|F|F1187|Průběh pojištění v daném měsíci||
|1187|G|G1187|Vyměřovací základ||
|1187|K|K1187|x||
|1187|L|L1187|přejmenování atributu||
|1187|M|M1187|zpřesnění názvu na žádost ČSSZ||
|1188|A|A1188|22.7.2025||
|1188|B|B1188|1.4 final||
|1188|D|D1188|10502||
|1188|E|E1188|Bližší určení pracovněprávního vztahu||
|1188|F|F1188|Vykonávaná pozice zaměstnance||
|1188|G|G1188|Činnost||
|1188|J|J1188|x||
|1188|L|L1188|úprava konzumace atributu||
|1188|M|M1188|přidání chybějící konzumace u ČSSZ||
|1189|A|A1189|22.7.2025||
|1189|B|B1189|1.4 final||
|1189|C|C1189|ZP_TECH_POPIS_015||
|1189|D|D1189|10539||
|1189|E|E1189|Jméno dítěte||
|1189|F|F1189|Souhrnná data zaměstnance||
|1189|G|G1189|Výsledek ročního zúčtování||
|1189|H|H1189|Sleva na manželku / manžela||
|1189|K|K1189|x||
|1189|L|L1189|přidání atributu||
|1189|M|M1189|ZP||
|1190|A|A1190|22.7.2025||
|1190|B|B1190|1.4 final||
|1190|C|C1190|ZP_TECH_POPIS_015||
|1190|D|D1190|10540||
|1190|E|E1190|Příjmení dítěte||
|1190|F|F1190|Souhrnná data zaměstnance||
|1190|G|G1190|Výsledek ročního zúčtování||
|1190|H|H1190|Sleva na manželku / manžela||
|1190|K|K1190|x||
|1190|L|L1190|přidání atributu||
|1190|M|M1190|ZP||
|1191|A|A1191|22.7.2025||
|1191|B|B1191|1.4 final||
|1191|C|C1191|ZP_TECH_POPIS_015||
|1191|D|D1191|10541||
|1191|E|E1191|Datum narození dítěte||
|1191|F|F1191|Souhrnná data zaměstnance||
|1191|G|G1191|Výsledek ročního zúčtování||
|1191|H|H1191|Sleva na manželku / manžela||
|1191|K|K1191|x||
|1191|L|L1191|přidání atributu||
|1191|M|M1191|ZP||
|1192|A|A1192|22.7.2025||
|1192|B|B1192|1.4 final||
|1192|C|C1192|ZP_TECH_POPIS_015||
|1192|D|D1192|10542||
|1192|E|E1192|Rodné číslo dítěte||
|1192|F|F1192|Souhrnná data zaměstnance||
|1192|G|G1192|Výsledek ročního zúčtování||
|1192|H|H1192|Sleva na manželku / manžela||
|1192|K|K1192|x||
|1192|L|L1192|přidání atributu||
|1192|M|M1192|ZP||
|1193|A|A1193|22.7.2025||
|1193|B|B1193|1.4 final||
|1193|C|C1193|ZP_TECH_POPIS_019||
|1193|D|D1193|10451||
|1193|E|E1193|Pořadí pro určení výše daňového zvýhodnění v jednotlivých měsících||
|1193|F|F1193|Souhrnná data zaměstnance||
|1193|G|G1193|Výsledek ročního zúčtování||
|1193|H|H1193|Vyživované děti||
|1193|K|K1193|x||
|1193|L|L1193|změna datového typu||
|1193|M|M1193|ZP||
|1194|A|A1194|22.7.2025||
|1194|B|B1194|1.4 final||
|1194|C|C1194|ZP_TECH_POPIS_030||
|1194|D|D1194|10329||
|1194|E|E1194|Tarifní mzdy||
|1194|F|F1194|Mzda||
|1194|G|G1194|Mzda zúčtovaná||
|1194|K|K1194|x||
|1194|L|L1194|úprava datových scénářů||
|1194|M|M1194|ZP||
|1195|A|A1195|22.7.2025||
|1195|B|B1195|1.4 final||
|1195|C|C1195|ZP_TECH_POPIS_030||
|1195|D|D1195|10330||
|1195|E|E1195|Prémie a odměny pravidelné||
|1195|F|F1195|Mzda||
|1195|G|G1195|Mzda zúčtovaná||
|1195|K|K1195|x||
|1195|L|L1195|úprava datových scénářů||
|1195|M|M1195|ZP||
|1196|A|A1196|22.7.2025||
|1196|B|B1196|1.4 final||
|1196|C|C1196|ZP_TECH_POPIS_030||
|1196|D|D1196|10331||
|1196|E|E1196|Prémie a odměny nepravidelné||
|1196|F|F1196|Mzda||
|1196|G|G1196|Mzda zúčtovaná||
|1196|K|K1196|x||
|1196|L|L1196|úprava datových scénářů||
|1196|M|M1196|ZP||
|1197|A|A1197|22.7.2025||
|1197|B|B1197|1.4 final||
|1197|C|C1197|ZP_TECH_POPIS_030||
|1197|D|D1197|10332||
|1197|E|E1197|Příplatky celkem||
|1197|F|F1197|Mzda||
|1197|G|G1197|Příplatky||
|1197|K|K1197|x||
|1197|L|L1197|úprava datových scénářů||
|1197|M|M1197|ZP||
|1198|A|A1198|22.7.2025||
|1198|B|B1198|1.4 final||
|1198|C|C1198|ZP_TECH_POPIS_030||
|1198|D|D1198|10333||
|1198|E|E1198|Příplatky za práci přesčas||
|1198|F|F1198|Mzda||
|1198|G|G1198|Příplatky||
|1198|K|K1198|x||
|1198|L|L1198|úprava datových scénářů||
|1198|M|M1198|ZP||
|1199|A|A1199|22.7.2025||
|1199|B|B1199|1.4 final||
|1199|C|C1199|ZP_TECH_POPIS_030||
|1199|D|D1199|10334||
|1199|E|E1199|Příplatky za práci v noci||
|1199|F|F1199|Mzda||
|1199|G|G1199|Příplatky||
|1199|K|K1199|x||
|1199|L|L1199|úprava datových scénářů||
|1199|M|M1199|ZP||
|1200|A|A1200|22.7.2025||
|1200|B|B1200|1.4 final||
|1200|C|C1200|ZP_TECH_POPIS_030||
|1200|D|D1200|10335||
|1200|E|E1200|Příplatky za práci o sobotách a nedělích||
|1200|F|F1200|Mzda||
|1200|G|G1200|Příplatky||
|1200|K|K1200|x||
|1200|L|L1200|úprava datových scénářů||
|1200|M|M1200|ZP||
|1201|A|A1201|22.7.2025||
|1201|B|B1201|1.4 final||
|1201|C|C1201|ZP_TECH_POPIS_030||
|1201|D|D1201|10336||
|1201|E|E1201|Příplatky za práci ve svátek||
|1201|F|F1201|Mzda||
|1201|G|G1201|Příplatky||
|1201|K|K1201|x||
|1201|L|L1201|úprava datových scénářů||
|1201|M|M1201|ZP||
|1202|A|A1202|23.7.2025||
|1202|B|B1202|1.4 final||
|1202|C|C1202|ZP_TECH_POPIS_032||
|1202|D|D1202|10269||
|1202|E|E1202|Přesčasové hodiny (z odpracovaných)||
|1202|F|F1202|Průběh zaměstnání v daném měsíci||
|1202|G|G1202|Odpracované hodiny||
|1202|K|K1202|x||
|1202|L|L1202|úprava datových scénářů||
|1202|M|M1202|ZP||
|1203|A|A1203|23.7.2025||
|1203|B|B1203|1.4 final||
|1203|C|C1203|ZP_TECH_POPIS_032||
|1203|D|D1203|10270||
|1203|E|E1203|Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - uran||
|1203|F|F1203|Průběh zaměstnání v daném měsíci||
|1203|G|G1203|Odpracované směny||
|1203|H|H1203|Hlubinné hornictví||
|1203|K|K1203|x||
|1203|L|L1203|úprava datových scénářů||
|1203|M|M1203|ZP||
|1204|A|A1204|23.7.2025||
|1204|B|B1204|1.4 final||
|1204|C|C1204|ZP_TECH_POPIS_032||
|1204|D|D1204|10271||
|1204|E|E1204|Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - ostatní||
|1204|F|F1204|Průběh zaměstnání v daném měsíci||
|1204|G|G1204|Odpracované směny||
|1204|H|H1204|Hlubinné hornictví||
|1204|K|K1204|x||
|1204|L|L1204|úprava datových scénářů||
|1204|M|M1204|ZP||
|1205|A|A1205|23.7.2025||
|1205|B|B1205|1.4 final||
|1205|C|C1205|ZP_TECH_POPIS_032||
|1205|D|D1205|10272||
|1205|E|E1205|Datum dosažení expozice NPE||
|1205|F|F1205|Průběh zaměstnání v daném měsíci||
|1205|G|G1205|Odpracované směny||
|1205|H|H1205|Hlubinné hornictví||
|1205|K|K1205|x||
|1205|L|L1205|úprava datových scénářů||
|1205|M|M1205|ZP||
|1206|A|A1206|23.7.2025||
|1206|B|B1206|1.4 final||
|1206|C|C1206|ZP_TECH_POPIS_032||
|1206|D|D1206|10273||
|1206|E|E1206|Počet odpracovaných hodin v rámci rizikové práce (§ 37d odst. 2 ZDP), práce zdravotnického záchranáře (§ 37d odst. 3) a práce člena jednotky HZS podniku (§ 37d odst. 3)  ||
|1206|F|F1206|Průběh zaměstnání v daném měsíci||
|1206|G|G1206|Odpracované hodiny||
|1206|H|H1206|Riziková práce||
|1206|K|K1206|x||
|1206|L|L1206|úprava datových scénářů||
|1206|M|M1206|ZP||
|1207|A|A1207|23.7.2025||
|1207|B|B1207|1.4 final||
|1207|C|C1207|ZP_TECH_POPIS_032||
|1207|D|D1207|10274||
|1207|E|E1207|Kategorizace rizika||
|1207|F|F1207|Průběh zaměstnání v daném měsíci||
|1207|G|G1207|Odpracované hodiny||
|1207|H|H1207|Riziková práce||
|1207|K|K1207|x||
|1207|L|L1207|úprava datových scénářů||
|1207|M|M1207|ZP||
|1208|A|A1208|24.7.2025||
|1208|B|B1208|1.4 final||
|1208|C|C1208|ZP_TECH_POPIS_035||
|1208|D|D1208|10416||
|1208|E|E1208|Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR||
|1208|F|F1208|Souhrnná data zaměstnance||
|1208|G|G1208|Příjem||
|1208|K|K1208|x||
|1208|L|L1208|úprava datových scénářů||
|1208|M|M1208|ZP||
|1209|A|A1209|24.7.2025||
|1209|B|B1209|1.4 final||
|1209|C|C1209|ZP_TECH_POPIS_035||
|1209|D|D1209|10289||
|1209|E|E1209|Osvobozené příjmy ze zúčtovaných příjmů - celkem||
|1209|F|F1209|Souhrnná data zaměstnance||
|1209|G|G1209|Příjem||
|1209|K|K1209|x||
|1209|L|L1209|úprava datových scénářů||
|1209|M|M1209|ZP||
|1210|A|A1210|24.7.2025||
|1210|B|B1210|1.4 final||
|1210|C|C1210|ZP_TECH_POPIS_035||
|1210|D|D1210|10417||
|1210|E|E1210|Příspěvek zaměstnavatele na produkty spoření na stáří a pojištění dlouhodobé péče z osvobozených příjmů - celkem||
|1210|F|F1210|Souhrnná data zaměstnance||
|1210|G|G1210|Příjem||
|1210|H|H1210|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1210|K|K1210|x||
|1210|L|L1210|úprava datových scénářů||
|1210|M|M1210|ZP||
|1211|A|A1211|24.7.2025||
|1211|B|B1211|1.4 final||
|1211|C|C1211|ZP_TECH_POPIS_035||
|1211|D|D1211|10292||
|1211|E|E1211|Příspěvek na penzijní připojištění se státním příspěvkem||
|1211|F|F1211|Souhrnná data zaměstnance||
|1211|G|G1211|Příjem||
|1211|H|H1211|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1211|K|K1211|x||
|1211|L|L1211|úprava datových scénářů||
|1211|M|M1211|ZP||
|1212|A|A1212|24.7.2025||
|1212|B|B1212|1.4 final||
|1212|C|C1212|ZP_TECH_POPIS_035||
|1212|D|D1212|10293||
|1212|E|E1212|Příspěvek na doplňkové penzijní spoření||
|1212|F|F1212|Souhrnná data zaměstnance||
|1212|G|G1212|Příjem||
|1212|H|H1212|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1212|K|K1212|x||
|1212|L|L1212|úprava datových scénářů||
|1212|M|M1212|ZP||
|1213|A|A1213|24.7.2025||
|1213|B|B1213|1.4 final||
|1213|C|C1213|ZP_TECH_POPIS_035||
|1213|D|D1213|10294||
|1213|E|E1213|Příspěvek na penzijní pojištění||
|1213|F|F1213|Souhrnná data zaměstnance||
|1213|G|G1213|Příjem||
|1213|H|H1213|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1213|K|K1213|x||
|1213|L|L1213|úprava datových scénářů||
|1213|M|M1213|ZP||
|1214|A|A1214|24.7.2025||
|1214|B|B1214|1.4 final||
|1214|C|C1214|ZP_TECH_POPIS_035||
|1214|D|D1214|10295||
|1214|E|E1214|Příspěvek na soukromé životní pojištění||
|1214|F|F1214|Souhrnná data zaměstnance||
|1214|G|G1214|Příjem||
|1214|H|H1214|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1214|K|K1214|x||
|1214|L|L1214|úprava datových scénářů||
|1214|M|M1214|ZP||
|1215|A|A1215|24.7.2025||
|1215|B|B1215|1.4 final||
|1215|C|C1215|ZP_TECH_POPIS_035||
|1215|D|D1215|10296||
|1215|E|E1215|Příspěvek na dlouhodobý investiční produkt||
|1215|F|F1215|Souhrnná data zaměstnance||
|1215|G|G1215|Příjem||
|1215|H|H1215|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1215|K|K1215|x||
|1215|L|L1215|úprava datových scénářů||
|1215|M|M1215|ZP||
|1216|A|A1216|24.7.2025||
|1216|B|B1216|1.4 final||
|1216|C|C1216|ZP_TECH_POPIS_035||
|1216|D|D1216|10418||
|1216|E|E1216|Příspěvek na pojištění dlouhodobé péče||
|1216|F|F1216|Souhrnná data zaměstnance||
|1216|G|G1216|Příjem||
|1216|H|H1216|Příspěvek zaměstnavatele (z osvobozených příjmů)||
|1216|K|K1216|x||
|1216|L|L1216|úprava datových scénářů||
|1216|M|M1216|ZP||
|1217|A|A1217|24.7.2025||
|1217|B|B1217|1.4 final||
|1217|C|C1217|ZP_TECH_POPIS_035||
|1217|D|D1217|10308||
|1217|E|E1217|Odměna člena (nerezidenta) orgánu právnické osoby||
|1217|F|F1217|Souhrnná data zaměstnance||
|1217|G|G1217|Výpočet daně podle zvláštní sazby daně ||
|1217|K|K1217|x||
|1217|L|L1217|úprava datových scénářů||
|1217|M|M1217|ZP||
|1218|A|A1218|24.7.2025||
|1218|B|B1218|1.4 final||
|1218|C|C1218|ZP_TECH_POPIS_035||
|1218|D|D1218|10309||
|1218|E|E1218|Skutečně sražená daň podle zvláštní sazby daně / měsíc||
|1218|F|F1218|Souhrnná data zaměstnance||
|1218|G|G1218|Výpočet daně podle zvláštní sazby daně ||
|1218|K|K1218|x||
|1218|L|L1218|úprava datových scénářů||
|1218|M|M1218|ZP||
|1219|A|A1219|24.7.2025||
|1219|B|B1219|1.4 final||
|1219|C|C1219|ZP_TECH_POPIS_035||
|1219|D|D1219|10310||
|1219|E|E1219|Sražená daň podle zvláštní sazby daně z příjmu nerezidenta člena orgánu právnické osoby||
|1219|F|F1219|Souhrnná data zaměstnance||
|1219|G|G1219|Výpočet daně podle zvláštní sazby daně ||
|1219|K|K1219|x||
|1219|L|L1219|úprava datových scénářů||
|1219|M|M1219|ZP||
|1220|A|A1220|25.7.2025||
|1220|B|B1220|1.4 final||
|1220|C|C1220|ZP_TECH_POPIS_044||
|1220|D|D1220|10503||
|1220|E|E1220|V daném měsíci nevznikla účast na pojištění||
|1220|F|F1220|Průběh pojištění v daném měsíci||
|1220|K|K1220|x||
|1220|L|L1220|odstranění atributu||
|1220|M|M1220|ZP||
|1221|A|A1221|25.7.2025||
|1221|B|B1221|1.4 final||
|1221|C|C1221|ZP_TECH_POPIS_044||
|1221|D|D1221|10482||
|1221|E|E1221|Zdravotní pojištění||
|1221|F|F1221|Souhrnná data zaměstnance||
|1221|G|G1221|Pojistné za zaměstnavatele||
|1221|K|K1221|x||
|1221|L|L1221|úprava datových scénářů||
|1221|M|M1221|ZP||
|1222|A|A1222|25.7.2025||
|1222|B|B1222|1.4 final||
|1222|C|C1222|ZP_TECH_POPIS_044||
|1222|D|D1222|10371||
|1222|E|E1222|Zdravotní pojištění||
|1222|F|F1222|Souhrnná data zaměstnance||
|1222|G|G1222|Pojistné za zaměstnance||
|1222|K|K1222|x||
|1222|L|L1222|úprava datových scénářů||
|1222|M|M1222|ZP||
|1223|A|A1223|25.7.2025||
|1223|B|B1223|1.4 final||
|1223|C|C1223|ZP_TECH_POPIS_044||
|1223|D|D1223|10354||
|1223|E|E1223|Pojištění od||
|1223|F|F1223|Průběh pojištění v daném měsíci||
|1223|G|G1223|Trvání pojištění||
|1223|K|K1223|x||
|1223|L|L1223|úprava datových scénářů||
|1223|M|M1223|ZP||
|1224|A|A1224|25.7.2025||
|1224|B|B1224|1.4 final||
|1224|C|C1224|ZP_TECH_POPIS_044||
|1224|D|D1224|10355||
|1224|E|E1224|Pojištění do||
|1224|F|F1224|Průběh pojištění v daném měsíci||
|1224|G|G1224|Trvání pojištění||
|1224|K|K1224|x||
|1224|L|L1224|úprava datových scénářů||
|1224|M|M1224|ZP||
|1225|A|A1225|25.7.2025||
|1225|B|B1225|1.4 final||
|1225|C|C1225|ZP_TECH_POPIS_044||
|1225|D|D1225|10240||
|1225|E|E1225|Kód ELDP||
|1225|F|F1225|Průběh pojištění v daném měsíci||
|1225|G|G1225|ELDP||
|1225|K|K1225|x||
|1225|L|L1225|úprava datových scénářů||
|1225|M|M1225|ZP||
|1226|A|A1226|25.7.2025||
|1226|B|B1226|1.4 final||
|1226|C|C1226|ZP_TECH_POPIS_044||
|1226|D|D1226|10241||
|1226|E|E1226|Platnost kódu od||
|1226|F|F1226|Průběh pojištění v daném měsíci||
|1226|G|G1226|ELDP||
|1226|K|K1226|x||
|1226|L|L1226|úprava datových scénářů||
|1226|M|M1226|ZP||
|1227|A|A1227|25.7.2025||
|1227|B|B1227|1.4 final||
|1227|C|C1227|ZP_TECH_POPIS_044||
|1227|D|D1227|10242||
|1227|E|E1227|Platnost kódu do||
|1227|F|F1227|Průběh pojištění v daném měsíci||
|1227|G|G1227|ELDP||
|1227|K|K1227|x||
|1227|L|L1227|úprava datových scénářů||
|1227|M|M1227|ZP||
|1228|A|A1228|25.7.2025||
|1228|B|B1228|1.4 final||
|1228|C|C1228|ZP_TECH_POPIS_044||
|1228|D|D1228|10356||
|1228|E|E1228|Počet kalendářních dnů trvání doby důchodového pojištění v daném kalendářním měsíci||
|1228|F|F1228|Průběh pojištění v daném měsíci||
|1228|G|G1228|ELDP||
|1228|K|K1228|x||
|1228|L|L1228|úprava datových scénářů||
|1228|M|M1228|ZP||
|1229|A|A1229|25.7.2025||
|1229|B|B1229|1.4 final||
|1229|C|C1229|ZP_TECH_POPIS_044||
|1229|D|D1229|10245||
|1229|E|E1229|Vyměřovací základ||
|1229|F|F1229|Průběh pojištění v daném měsíci||
|1229|G|G1229|ELDP||
|1229|K|K1229|x||
|1229|L|L1229|úprava datových scénářů||
|1229|M|M1229|ZP||
|1230|A|A1230|25.7.2025||
|1230|B|B1230|1.4 final||
|1230|C|C1230|ZP_TECH_POPIS_044||
|1230|D|D1230|10481||
|1230|E|E1230|Pojistné na sociální zabezpečení ||
|1230|F|F1230|Průběh pojištění v daném měsíci||
|1230|G|G1230|Pojistné za zaměstnavatele||
|1230|K|K1230|x||
|1230|L|L1230|úprava datových scénářů||
|1230|M|M1230|ZP||
|1231|A|A1231|25.7.2025||
|1231|B|B1231|1.4 final||
|1231|C|C1231|ZP_TECH_POPIS_044||
|1231|D|D1231|10370||
|1231|E|E1231|Sociální pojištění||
|1231|F|F1231|Průběh pojištění v daném měsíci||
|1231|G|G1231|Pojistné za zaměstnance||
|1231|K|K1231|x||
|1231|L|L1231|úprava datových scénářů||
|1231|M|M1231|ZP||
|1232|A|A1232|25.7.2025||
|1232|B|B1232|1.4 final||
|1232|C|C1232|ZP_TECH_POPIS_044||
|1232|D|D1232|10372||
|1232|E|E1232|Sleva na pojistném zaměstnavatele||
|1232|F|F1232|Průběh pojištění v daném měsíci||
|1232|G|G1232|Sleva na pojistném||
|1232|K|K1232|x||
|1232|L|L1232|úprava datových scénářů||
|1232|M|M1232|ZP||
|1233|A|A1233|25.7.2025||
|1233|B|B1233|1.4 final||
|1233|C|C1233|ZP_TECH_POPIS_044||
|1233|D|D1233|10490||
|1233|E|E1233|Sleva na pojistném zaměstnance||
|1233|F|F1233|Průběh pojištění v daném měsíci||
|1233|G|G1233|Sleva na pojistném||
|1233|K|K1233|x||
|1233|L|L1233|úprava datových scénářů||
|1233|M|M1233|ZP||
|1234|A|A1234|27.7.2025||
|1234|B|B1234|1.4 final||
|1234|C|C1234|ZP_TECH_POPIS_045||
|1234|D|D1234|10357||
|1234|E|E1234|Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1234|F|F1234|Průběh pojištění v daném měsíci||
|1234|G|G1234|ELDP||
|1234|H|H1234|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1234|K|K1234|x||
|1234|L|L1234|úprava datových scénářů||
|1234|M|M1234|ZP||
|1235|A|A1235|27.7.2025||
|1235|B|B1235|1.4 final||
|1235|C|C1235|ZP_TECH_POPIS_045||
|1235|D|D1235|10358||
|1235|E|E1235|Počet dnů trvání dočasné pracovní neschopnosti||
|1235|F|F1235|Průběh pojištění v daném měsíci||
|1235|G|G1235|ELDP||
|1235|H|H1235|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1235|K|K1235|x||
|1235|L|L1235|úprava datových scénářů||
|1235|M|M1235|ZP||
|1236|A|A1236|27.7.2025||
|1236|B|B1236|1.4 final||
|1236|C|C1236|ZP_TECH_POPIS_045||
|1236|D|D1236|10359||
|1236|E|E1236|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|1236|F|F1236|Průběh pojištění v daném měsíci||
|1236|G|G1236|ELDP||
|1236|H|H1236|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1236|K|K1236|x||
|1236|L|L1236|úprava datových scénářů||
|1236|M|M1236|ZP||
|1237|A|A1237|27.7.2025||
|1237|B|B1237|1.4 final||
|1237|C|C1237|ZP_TECH_POPIS_045||
|1237|D|D1237|10360||
|1237|E|E1237|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|1237|F|F1237|Průběh pojištění v daném měsíci||
|1237|G|G1237|ELDP||
|1237|H|H1237|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1237|K|K1237|x||
|1237|L|L1237|úprava datových scénářů||
|1237|M|M1237|ZP||
|1238|A|A1238|27.7.2025||
|1238|B|B1238|1.4 final||
|1238|C|C1238|ZP_TECH_POPIS_045||
|1238|D|D1238|10362||
|1238|E|E1238|Počet dnů čerpání otcovské||
|1238|F|F1238|Průběh pojištění v daném měsíci||
|1238|G|G1238|ELDP||
|1238|H|H1238|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1238|K|K1238|x||
|1238|L|L1238|úprava datových scénářů||
|1238|M|M1238|ZP||
|1239|A|A1239|27.7.2025||
|1239|B|B1239|1.4 final||
|1239|C|C1239|ZP_TECH_POPIS_045||
|1239|D|D1239|10536||
|1239|E|E1239|Počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb.||
|1239|F|F1239|Průběh pojištění v daném měsíci||
|1239|G|G1239|ELDP||
|1239|H|H1239|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1239|K|K1239|x||
|1239|L|L1239|úprava datových scénářů||
|1239|M|M1239|ZP||
|1240|A|A1240|27.7.2025||
|1240|B|B1240|1.4 final||
|1240|C|C1240|ZP_TECH_POPIS_045||
|1240|D|D1240|10375||
|1240|E|E1240|Doby odečítané po důchodovém věku - počet dnů||
|1240|F|F1240|Průběh pojištění v daném měsíci||
|1240|G|G1240|ELDP||
|1240|H|H1240|Odečítané dny||
|1240|K|K1240|x||
|1240|L|L1240|úprava datových scénářů||
|1240|M|M1240|ZP||
|1241|A|A1241|27.7.2025||
|1241|B|B1241|1.4 final||
|1241|C|C1241|ZP_TECH_POPIS_045||
|1241|D|D1241|10462||
|1241|E|E1241|Počet dnů trvání dočasné pracovní neschopnosti (karanténa)||
|1241|F|F1241|Průběh pojištění v daném měsíci||
|1241|G|G1241|ELDP||
|1241|H|H1241|Odečítané dny||
|1241|K|K1241|x||
|1241|L|L1241|úprava datových scénářů||
|1241|M|M1241|ZP||
|1242|A|A1242|27.7.2025||
|1242|B|B1242|1.4 final||
|1242|C|C1242|ZP_TECH_POPIS_045||
|1242|D|D1242|10463||
|1242|E|E1242|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|1242|F|F1242|Průběh pojištění v daném měsíci||
|1242|G|G1242|ELDP||
|1242|H|H1242|Odečítané dny||
|1242|K|K1242|x||
|1242|L|L1242|úprava datových scénářů||
|1242|M|M1242|ZP||
|1243|A|A1243|27.7.2025||
|1243|B|B1243|1.4 final||
|1243|C|C1243|ZP_TECH_POPIS_045||
|1243|D|D1243|10464||
|1243|E|E1243|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|1243|F|F1243|Průběh pojištění v daném měsíci||
|1243|G|G1243|ELDP||
|1243|H|H1243|Odečítané dny||
|1243|K|K1243|x||
|1243|L|L1243|úprava datových scénářů||
|1243|M|M1243|ZP||
|1244|A|A1244|27.7.2025||
|1244|B|B1244|1.4 final||
|1244|C|C1244|ZP_TECH_POPIS_045||
|1244|D|D1244|10465||
|1244|E|E1244|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné ||
|1244|F|F1244|Průběh pojištění v daném měsíci||
|1244|G|G1244|ELDP||
|1244|H|H1244|Odečítané dny||
|1244|K|K1244|x||
|1244|L|L1244|úprava datových scénářů||
|1244|M|M1244|ZP||
|1245|A|A1245|27.7.2025||
|1245|B|B1245|1.4 final||
|1245|C|C1245|ZP_TECH_POPIS_045||
|1245|D|D1245|10466||
|1245|E|E1245|Počet dnů čerpání otcovské||
|1245|F|F1245|Průběh pojištění v daném měsíci||
|1245|G|G1245|ELDP||
|1245|H|H1245|Odečítané dny||
|1245|K|K1245|x||
|1245|L|L1245|úprava datových scénářů||
|1245|M|M1245|ZP||
|1246|A|A1246|27.7.2025||
|1246|B|B1246|1.4 final||
|1246|C|C1246|ZP_TECH_POPIS_045||
|1246|D|D1246|10468||
|1246|E|E1246|Počet dnů čerpání neplaceného volna||
|1246|F|F1246|Průběh pojištění v daném měsíci||
|1246|G|G1246|ELDP||
|1246|H|H1246|Odečítané dny||
|1246|K|K1246|x||
|1246|L|L1246|úprava datových scénářů||
|1246|M|M1246|ZP||
|1247|A|A1247|27.7.2025||
|1247|B|B1247|1.4 final||
|1247|C|C1247|ZP_TECH_POPIS_045||
|1247|D|D1247|10469||
|1247|E|E1247|Počet dnů neomluvené absence||
|1247|F|F1247|Průběh pojištění v daném měsíci||
|1247|G|G1247|ELDP||
|1247|H|H1247|Odečítané dny||
|1247|K|K1247|x||
|1247|L|L1247|úprava datových scénářů||
|1247|M|M1247|ZP||
|1248|A|A1248|27.7.2025||
|1248|B|B1248|1.4 final||
|1248|C|C1248|ZP_TECH_POPIS_045||
|1248|D|D1248|10477||
|1248|E|E1248|Částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné||
|1248|F|F1248|Průběh pojištění v daném měsíci||
|1248|G|G1248|Vyměřovací základ||
|1248|K|K1248|x||
|1248|L|L1248|úprava datových scénářů||
|1248|M|M1248|ZP||
|1249|A|A1249|27.7.2025||
|1249|B|B1249|1.4 final||
|1249|C|C1249|ZP_TECH_POPIS_045||
|1249|D|D1249|10478||
|1249|E|E1249|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ ||
|1249|F|F1249|Průběh pojištění v daném měsíci||
|1249|G|G1249|Vyměřovací základ||
|1249|K|K1249|x||
|1249|L|L1249|úprava datových scénářů||
|1249|M|M1249|ZP||
|1250|A|A1250|27.7.2025||
|1250|B|B1250|1.4 final||
|1250|C|C1250|ZP_TECH_POPIS_045||
|1250|D|D1250|10479||
|1250|E|E1250|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ ||
|1250|F|F1250|Průběh pojištění v daném měsíci||
|1250|G|G1250|Vyměřovací základ||
|1250|K|K1250|x||
|1250|L|L1250|úprava datových scénářů||
|1250|M|M1250|ZP||
|1251|A|A1251|27.7.2025||
|1251|B|B1251|1.4 final||
|1251|C|C1251|ZP_TECH_POPIS_045||
|1251|D|D1251|10480||
|1251|E|E1251|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ ||
|1251|F|F1251|Průběh pojištění v daném měsíci||
|1251|G|G1251|Vyměřovací základ||
|1251|K|K1251|x||
|1251|L|L1251|úprava datových scénářů||
|1251|M|M1251|ZP||
|1252|A|A1252|28.7.2025||
|1252|B|B1252|1.4 final||
|1252|C|C1252|ZP_TECH_POPIS_047||
|1252|D|D1252|10490||
|1252|E|E1252|Sleva na pojistném zaměstnance||
|1252|F|F1252|Průběh pojištění v daném měsíci||
|1252|G|G1252|Sleva na pojistném||
|1252|K|K1252|x||
|1252|L|L1252|úprava datových scénářů||
|1252|M|M1252|ZP||
|1253|A|A1253|28.7.2025||
|1253|B|B1253|1.4 final||
|1253|C|C1253|ZP_TECH_POPIS_047||
|1253|D|D1253|10491||
|1253|E|E1253|Výše slevy na pojistném zaměstnance||
|1253|F|F1253|Průběh pojištění v daném měsíci||
|1253|G|G1253|Sleva na pojistném||
|1253|K|K1253|x||
|1253|L|L1253|úprava datových scénářů||
|1253|M|M1253|ZP||
|1254|A|A1254|28.7.2025||
|1254|B|B1254|1.4 final||
|1254|C|C1254|ZP_TECH_POPIS_052||
|1254|D|D1254|10310||
|1254|E|E1254|Sražená záloha na daň z příjmu nerezidenta člena orgánu právnické osoby||
|1254|F|F1254|Souhrnná data zaměstnance||
|1254|G|G1254|Výpočet daně podle zvláštní sazby daně ||
|1254|K|K1254|x||
|1254|L|L1254|přejmenování atributu||
|1254|M|M1254|ZP||
|1255|A|A1255|28.7.2025||
|1255|B|B1255|1.4 final||
|1255|C|C1255|ZP_TECH_POPIS_054||
|1255|D|D1255|10270||
|1255|E|E1255|Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - uran||
|1255|F|F1255|Průběh zaměstnání v daném měsíci||
|1255|G|G1255|Odpracované směny||
|1255|H|H1255|Hlubinné hornictví||
|1255|K|K1255|x||
|1255|L|L1255|úprava datových scénářů||
|1255|M|M1255|ZP||
|1256|A|A1256|28.7.2025||
|1256|B|B1256|1.4 final||
|1256|C|C1256|ZP_TECH_POPIS_054||
|1256|D|D1256|10271||
|1256|E|E1256|Počet odpracovaných směn v zaměstnání v hlubinném hornictví  definovaném v § 37b ZDP - ostatní||
|1256|F|F1256|Průběh zaměstnání v daném měsíci||
|1256|G|G1256|Odpracované směny||
|1256|H|H1256|Hlubinné hornictví||
|1256|K|K1256|x||
|1256|L|L1256|úprava datových scénářů||
|1256|M|M1256|ZP||
|1257|A|A1257|28.7.2025||
|1257|B|B1257|1.4 final||
|1257|C|C1257|ZP_TECH_POPIS_054||
|1257|D|D1257|10272||
|1257|E|E1257|Datum dosažení expozice NPE||
|1257|F|F1257|Průběh zaměstnání v daném měsíci||
|1257|G|G1257|Odpracované směny||
|1257|H|H1257|Hlubinné hornictví||
|1257|K|K1257|x||
|1257|L|L1257|úprava datových scénářů||
|1257|M|M1257|ZP||
|1258|A|A1258|28.7.2025||
|1258|B|B1258|1.4 final||
|1258|C|C1258|ZP_TECH_POPIS_054||
|1258|D|D1258|10273||
|1258|E|E1258|Počet odpracovaných hodin v rámci rizikové práce (§ 37d odst. 2 ZDP), práce zdravotnického záchranáře (§ 37d odst. 3) a práce člena jednotky HZS podniku (§ 37d odst. 3)  ||
|1258|F|F1258|Průběh zaměstnání v daném měsíci||
|1258|G|G1258|Odpracované hodiny||
|1258|H|H1258|Riziková práce||
|1258|K|K1258|x||
|1258|L|L1258|úprava datových scénářů||
|1258|M|M1258|ZP||
|1259|A|A1259|28.7.2025||
|1259|B|B1259|1.4 final||
|1259|C|C1259|ZP_TECH_POPIS_054||
|1259|D|D1259|10274||
|1259|E|E1259|Kategorizace rizika||
|1259|F|F1259|Průběh zaměstnání v daném měsíci||
|1259|G|G1259|Odpracované hodiny||
|1259|H|H1259|Riziková práce||
|1259|K|K1259|x||
|1259|L|L1259|úprava datových scénářů||
|1259|M|M1259|ZP||
|1260|A|A1260|28.7.2025||
|1260|B|B1260|1.4 final||
|1260|C|C1260|ZP_TECH_POPIS_046||
|1260|D|D1260|10478||
|1260|E|E1260|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ ||
|1260|F|F1260|Průběh pojištění v daném měsíci||
|1260|G|G1260|Vyměřovací základ||
|1260|K|K1260|x||
|1260|L|L1260|úprava datových scénářů||
|1260|M|M1260|ZP||
|1261|A|A1261|28.7.2025||
|1261|B|B1261|1.4 final||
|1261|C|C1261|ZP_TECH_POPIS_046||
|1261|D|D1261|10479||
|1261|E|E1261|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ ||
|1261|F|F1261|Průběh pojištění v daném měsíci||
|1261|G|G1261|Vyměřovací základ||
|1261|K|K1261|x||
|1261|L|L1261|úprava datových scénářů||
|1261|M|M1261|ZP||
|1262|A|A1262|28.7.2025||
|1262|B|B1262|1.4 final||
|1262|C|C1262|ZP_TECH_POPIS_046||
|1262|D|D1262|10480||
|1262|E|E1262|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ ||
|1262|F|F1262|Průběh pojištění v daném měsíci||
|1262|G|G1262|Vyměřovací základ||
|1262|K|K1262|x||
|1262|L|L1262|úprava datových scénářů||
|1262|M|M1262|ZP||
|1263|A|A1263|29.7.2025||
|1263|B|B1263|1.4 final||
|1263|C|C1263|ZP_TECH_POPIS_048||
|1263|D|D1263|10023||
|1263|E|E1263|Úhrn vyměřovacích základů zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|1263|F|F1263|Přehled o výši pojistného||
|1263|G|G1263|Odváděné pojistné||
|1263|K|K1263|x||
|1263|L|L1263|změna třídy atributu||
|1263|M|M1263|ZP||
|1264|A|A1264|29.7.2025||
|1264|B|B1264|1.4 final||
|1264|C|C1264|ZP_TECH_POPIS_048||
|1264|D|D1264|10024||
|1264|E|E1264|Pojistné za zaměstnavatele u zaměstnanců, kteří nevykonávají činnost v rizikovém zaměstnání nebo nejsou zdravotnickými záchranáři nebo členy HZS podniku||
|1264|F|F1264|Přehled o výši pojistného||
|1264|G|G1264|Odváděné pojistné||
|1264|K|K1264|x||
|1264|L|L1264|změna třídy atributu||
|1264|M|M1264|ZP||
|1265|A|A1265|29.7.2025||
|1265|B|B1265|1.4 final||
|1265|C|C1265|ZP_TECH_POPIS_048||
|1265|D|D1265|10025||
|1265|E|E1265|Úhrn vyměřovacích základů zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku||
|1265|F|F1265|Přehled o výši pojistného||
|1265|G|G1265|Odváděné pojistné||
|1265|K|K1265|x||
|1265|L|L1265|změna třídy atributu||
|1265|M|M1265|ZP||
|1266|A|A1266|29.7.2025||
|1266|B|B1266|1.4 final||
|1266|C|C1266|ZP_TECH_POPIS_048||
|1266|D|D1266|10026||
|1266|E|E1266|Pojistné za zaměstnavatele u zaměstnanců, kteří jsou zdravotnickými záchranáři nebo členy HZS podniku||
|1266|F|F1266|Přehled o výši pojistného||
|1266|G|G1266|Odváděné pojistné||
|1266|K|K1266|x||
|1266|L|L1266|změna třídy atributu||
|1266|M|M1266|ZP||
|1267|A|A1267|29.7.2025||
|1267|B|B1267|1.4 final||
|1267|C|C1267|ZP_TECH_POPIS_048||
|1267|D|D1267|10483||
|1267|E|E1267|Úhrn vyměřovacích základů zaměstnanců, kteří vykonávají rizikové zaměstnání||
|1267|F|F1267|Přehled o výši pojistného||
|1267|G|G1267|Odváděné pojistné||
|1267|K|K1267|x||
|1267|L|L1267|změna třídy atributu||
|1267|M|M1267|ZP||
|1268|A|A1268|29.7.2025||
|1268|B|B1268|1.4 final||
|1268|C|C1268|ZP_TECH_POPIS_048||
|1268|D|D1268|10484||
|1268|E|E1268|Pojistné za zaměstnavatele u zaměstnanců, kteří vykonávají rizikové zaměstnání||
|1268|F|F1268|Přehled o výši pojistného||
|1268|G|G1268|Odváděné pojistné||
|1268|K|K1268|x||
|1268|L|L1268|změna třídy atributu||
|1268|M|M1268|ZP||
|1269|A|A1269|29.7.2025||
|1269|B|B1269|1.4 final||
|1269|C|C1269|ZP_TECH_POPIS_048||
|1269|D|D1269|10027||
|1269|E|E1269|Pojistné za zaměstnavatele celkem (součet úhrnů)||
|1269|F|F1269|Přehled o výši pojistného||
|1269|G|G1269|Odváděné pojistné||
|1269|K|K1269|x||
|1269|L|L1269|změna třídy atributu||
|1269|M|M1269|ZP||
|1270|A|A1270|29.7.2025||
|1270|B|B1270|1.4 final||
|1270|C|C1270|ZP_TECH_POPIS_048||
|1270|D|D1270|10028||
|1270|E|E1270|Pojistné za zaměstnance||
|1270|F|F1270|Přehled o výši pojistného||
|1270|G|G1270|Odváděné pojistné||
|1270|K|K1270|x||
|1270|L|L1270|změna třídy atributu||
|1270|M|M1270|ZP||
|1271|A|A1271|29.7.2025||
|1271|B|B1271|1.4 final||
|1271|C|C1271|ZP_TECH_POPIS_048||
|1271|D|D1271|10029||
|1271|E|E1271|Pojistné celkem||
|1271|F|F1271|Přehled o výši pojistného||
|1271|G|G1271|Odváděné pojistné||
|1271|K|K1271|x||
|1271|L|L1271|změna třídy atributu||
|1271|M|M1271|ZP||
|1272|A|A1272|29.7.2025||
|1272|B|B1272|1.4 final||
|1272|C|C1272|ZP_TECH_POPIS_048||
|1272|D|D1272|10030||
|1272|E|E1272|Počet zaměstnanců||
|1272|F|F1272|Přehled o výši pojistného||
|1272|G|G1272|Slevy na pojistném zaměstnavatele||
|1272|K|K1272|x||
|1272|L|L1272|změna třídy atributu||
|1272|M|M1272|ZP||
|1273|A|A1273|29.7.2025||
|1273|B|B1273|1.4 final||
|1273|C|C1273|ZP_TECH_POPIS_048||
|1273|D|D1273|10031||
|1273|E|E1273|Úhrn vyměřovacích základů zaměstnanců||
|1273|F|F1273|Přehled o výši pojistného||
|1273|G|G1273|Slevy na pojistném zaměstnavatele||
|1273|K|K1273|x||
|1273|L|L1273|změna třídy atributu||
|1273|M|M1273|ZP||
|1274|A|A1274|29.7.2025||
|1274|B|B1274|1.4 final||
|1274|C|C1274|ZP_TECH_POPIS_048||
|1274|D|D1274|10032||
|1274|E|E1274|Sleva na pojistném zaměstnavatele||
|1274|F|F1274|Přehled o výši pojistného||
|1274|G|G1274|Slevy na pojistném zaměstnavatele||
|1274|K|K1274|x||
|1274|L|L1274|změna třídy atributu||
|1274|M|M1274|ZP||
|1275|A|A1275|29.7.2025||
|1275|B|B1275|1.4 final||
|1275|C|C1275|ZP_TECH_POPIS_048||
|1275|D|D1275|10485||
|1275|E|E1275|Počet zaměstnanců||
|1275|F|F1275|Přehled o výši pojistného||
|1275|G|G1275|Slevy na pojistném zaměstnanců||
|1275|H|H1275|Pracující důchodci||
|1275|K|K1275|x||
|1275|L|L1275|změna třídy atributu||
|1275|M|M1275|ZP||
|1276|A|A1276|29.7.2025||
|1276|B|B1276|1.4 final||
|1276|C|C1276|ZP_TECH_POPIS_048||
|1276|D|D1276|10486||
|1276|E|E1276|Úhrn vyměřovacích základů zaměstnanců||
|1276|F|F1276|Přehled o výši pojistného||
|1276|G|G1276|Slevy na pojistném zaměstnanců||
|1276|H|H1276|Pracující důchodci||
|1276|K|K1276|x||
|1276|L|L1276|změna třídy atributu||
|1276|M|M1276|ZP||
|1277|A|A1277|29.7.2025||
|1277|B|B1277|1.4 final||
|1277|C|C1277|ZP_TECH_POPIS_048||
|1277|D|D1277|10487||
|1277|E|E1277|Úhrn slev na pojistném zaměstnanců||
|1277|F|F1277|Přehled o výši pojistného||
|1277|G|G1277|Slevy na pojistném zaměstnanců||
|1277|H|H1277|Pracující důchodci||
|1277|K|K1277|x||
|1277|L|L1277|změna třídy atributu||
|1277|M|M1277|ZP||
|1278|A|A1278|29.7.2025||
|1278|B|B1278|1.4 final||
|1278|C|C1278|ZP_TECH_POPIS_048||
|1278|D|D1278|10033||
|1278|E|E1278|Vypočítané pojistné (rozdíl mezi pojistným celkem a slevou na pojistném)||
|1278|F|F1278|Přehled o výši pojistného||
|1278|G|G1278|Pojistné k úhradě||
|1278|K|K1278|x||
|1278|L|L1278|změna třídy atributu||
|1278|M|M1278|ZP||
|1279|A|A1279|29.7.2025||
|1279|B|B1279|1.4 final||
|1279|C|C1279|ZP_TECH_POPIS_048||
|1279|D|D1279|10543||
|1279|E|E1279|Počet zaměstnanců||
|1279|F|F1279|Přehled o výši pojistného||
|1279|G|G1279|Slevy na pojistném zaměstnanců||
|1279|H|H1279|Ovocnářství a pěstování zeleniny||
|1279|K|K1279|x||
|1279|L|L1279|přidání atributu||
|1279|M|M1279|ZP||
|1280|A|A1280|29.7.2025||
|1280|B|B1280|1.4 final||
|1280|C|C1280|ZP_TECH_POPIS_048||
|1280|D|D1280|10544||
|1280|E|E1280|Úhrn vyměřovacích základů zaměstnanců||
|1280|F|F1280|Přehled o výši pojistného||
|1280|G|G1280|Slevy na pojistném zaměstnanců||
|1280|H|H1280|Ovocnářství a pěstování zeleniny||
|1280|K|K1280|x||
|1280|L|L1280|přidání atributu||
|1280|M|M1280|ZP||
|1281|A|A1281|29.7.2025||
|1281|B|B1281|1.4 final||
|1281|C|C1281|ZP_TECH_POPIS_048||
|1281|D|D1281|10545||
|1281|E|E1281|Úhrn slev na pojistném zaměstnanců||
|1281|F|F1281|Přehled o výši pojistného||
|1281|G|G1281|Slevy na pojistném zaměstnanců||
|1281|H|H1281|Ovocnářství a pěstování zeleniny||
|1281|K|K1281|x||
|1281|L|L1281|přidání atributu||
|1281|M|M1281|ZP||
|1282|A|A1282|29.7.2025||
|1282|B|B1282|1.4 final||
|1282|C|C1282|ZP_TECH_POPIS_048||
|1282|D|D1282|10372||
|1282|E|E1282|Sleva na pojistném zaměstnavatele||
|1282|F|F1282|Průběh pojištění v daném měsíci||
|1282|G|G1282|Sleva na pojistném zaměstnavatele||
|1282|K|K1282|x||
|1282|L|L1282|změna třídy atributu||
|1282|M|M1282|ZP||
|1283|A|A1283|29.7.2025||
|1283|B|B1283|1.4 final||
|1283|C|C1283|ZP_TECH_POPIS_048||
|1283|D|D1283|10373||
|1283|E|E1283|Rozsah kratší pracovní/služební doby||
|1283|F|F1283|Průběh pojištění v daném měsíci||
|1283|G|G1283|Sleva na pojistném zaměstnavatele||
|1283|K|K1283|x||
|1283|L|L1283|změna třídy atributu||
|1283|M|M1283|ZP||
|1284|A|A1284|29.7.2025||
|1284|B|B1284|1.4 final||
|1284|C|C1284|ZP_TECH_POPIS_048||
|1284|D|D1284|10374||
|1284|E|E1284|Důvod uplatnění slevy||
|1284|F|F1284|Průběh pojištění v daném měsíci||
|1284|G|G1284|Sleva na pojistném zaměstnavatele||
|1284|K|K1284|x||
|1284|L|L1284|změna třídy atributu||
|1284|M|M1284|ZP||
|1285|A|A1285|29.7.2025||
|1285|B|B1285|1.4 final||
|1285|C|C1285|ZP_TECH_POPIS_048||
|1285|D|D1285|10490||
|1285|E|E1285|Sleva na pojistném zaměstnance||
|1285|F|F1285|Průběh pojištění v daném měsíci||
|1285|G|G1285|Sleva na pojistném zaměstnanců||
|1285|H|H1285|Pracující důchodci||
|1285|K|K1285|x||
|1285|L|L1285|změna třídy atributu||
|1285|M|M1285|ZP||
|1286|A|A1286|29.7.2025||
|1286|B|B1286|1.4 final||
|1286|C|C1286|ZP_TECH_POPIS_048||
|1286|D|D1286|10491||
|1286|E|E1286|Výše slevy na pojistném zaměstnance||
|1286|F|F1286|Průběh pojištění v daném měsíci||
|1286|G|G1286|Sleva na pojistném zaměstnanců||
|1286|H|H1286|Pracující důchodci||
|1286|K|K1286|x||
|1286|L|L1286|změna třídy atributu||
|1286|M|M1286|ZP||
|1287|A|A1287|29.7.2025||
|1287|B|B1287|1.4 final||
|1287|C|C1287|ZP_TECH_POPIS_048||
|1287|D|D1287|10546||
|1287|E|E1287|Sleva na pojistném zaměstnance||
|1287|F|F1287|Průběh pojištění v daném měsíci||
|1287|G|G1287|Sleva na pojistném zaměstnanců||
|1287|H|H1287|Ovocnářství a pěstování zeleniny||
|1287|K|K1287|x||
|1287|L|L1287|přidání atributu||
|1287|M|M1287|ZP||
|1288|A|A1288|29.7.2025||
|1288|B|B1288|1.4 final||
|1288|C|C1288|ZP_TECH_POPIS_048||
|1288|D|D1288|10547||
|1288|E|E1288|Výše slevy na pojistném zaměstnance||
|1288|F|F1288|Průběh pojištění v daném měsíci||
|1288|G|G1288|Sleva na pojistném zaměstnanců||
|1288|H|H1288|Ovocnářství a pěstování zeleniny||
|1288|K|K1288|x||
|1288|L|L1288|přidání atributu||
|1288|M|M1288|ZP||
|1289|A|A1289|30.7.2025||
|1289|B|B1289|1.4 final||
|1289|C|C1289|ZP_TECH_POPIS_056||
|1289|D|D1289|10374||
|1289|E|E1289|Důvod uplatnění slevy||
|1289|F|F1289|Průběh pojištění v daném měsíci||
|1289|G|G1289|Sleva na pojistném zaměstnavatele||
|1289|K|K1289|x||
|1289|L|L1289|úprava konzumace atributu||
|1289|M|M1289|ZP||
|1290|A|A1290|30.7.2025||
|1290|B|B1290|1.4 final||
|1290|C|C1290|ZP_TECH_POPIS_056||
|1290|D|D1290|10490||
|1290|E|E1290|Sleva na pojistném zaměstnance||
|1290|F|F1290|Průběh pojištění v daném měsíci||
|1290|G|G1290|Sleva na pojistném zaměstnanců||
|1290|H|H1290|Pracující důchodci||
|1290|K|K1290|x||
|1290|L|L1290|úprava konzumace atributu||
|1290|M|M1290|ZP||
|1291|A|A1291|30.7.2025||
|1291|B|B1291|1.4 final||
|1291|C|C1291|ZP_TECH_POPIS_056||
|1291|D|D1291|10491||
|1291|E|E1291|Výše slevy na pojistném zaměstnance||
|1291|F|F1291|Průběh pojištění v daném měsíci||
|1291|G|G1291|Sleva na pojistném zaměstnanců||
|1291|H|H1291|Pracující důchodci||
|1291|K|K1291|x||
|1291|L|L1291|úprava konzumace atributu||
|1291|M|M1291|ZP||
|1292|A|A1292|30.7.2025||
|1292|B|B1292|1.4 final||
|1292|C|C1292|ZP_TECH_POPIS_053||
|1292|D|D1292|10376||
|1292|E|E1292|Důvod neposkytnutí podkladů||
|1292|F|F1292|Ukončení pracovněprávního vztahu||
|1292|G|G1292|Informace pro podporu v nezaměstnanosti||
|1292|H|H1292|Důvody||
|1292|J|J1292|x||
|1292|L|L1292|úprava číselníku||
|1292|M|M1292|ZP||
|1293|A|A1293|30.7.2025||
|1293|B|B1293|1.4 final||
|1293|D|D1293|10518||
|1293|E|E1293|Kód adresního místa||
|1293|F|F1293|Zaměstnanec / Žák / Student ||
|1293|G|G1293|Adresa||
|1293|H|H1293|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1293|J|J1293|x||
|1293|L|L1293|odstranění atributu||
|1293|M|M1293|není relevantní pro zahraniční adresy||
|1294|A|A1294|31.7.2025||
|1294|B|B1294|1.4 final||
|1294|C|C1294|ZP_TECH_POPIS_015||
|1294|D|D1294|10539||
|1294|E|E1294|Jméno dítěte||
|1294|F|F1294|Souhrnná data zaměstnance||
|1294|G|G1294|Výsledek ročního zúčtování||
|1294|H|H1294|Sleva na manželku / manžela||
|1294|K|K1294|x||
|1294|L|L1294|změna četnosti||
|1294|M|M1294|ZP||
|1295|A|A1295|31.7.2025||
|1295|B|B1295|1.4 final||
|1295|C|C1295|ZP_TECH_POPIS_015||
|1295|D|D1295|10540||
|1295|E|E1295|Příjmení dítěte||
|1295|F|F1295|Souhrnná data zaměstnance||
|1295|G|G1295|Výsledek ročního zúčtování||
|1295|H|H1295|Sleva na manželku / manžela||
|1295|K|K1295|x||
|1295|L|L1295|změna četnosti||
|1295|M|M1295|ZP||
|1296|A|A1296|31.7.2025||
|1296|B|B1296|1.4 final||
|1296|C|C1296|ZP_TECH_POPIS_015||
|1296|D|D1296|10541||
|1296|E|E1296|Datum narození dítěte||
|1296|F|F1296|Souhrnná data zaměstnance||
|1296|G|G1296|Výsledek ročního zúčtování||
|1296|H|H1296|Sleva na manželku / manžela||
|1296|K|K1296|x||
|1296|L|L1296|změna četnosti||
|1296|M|M1296|ZP||
|1297|A|A1297|31.7.2025||
|1297|B|B1297|1.4 final||
|1297|C|C1297|ZP_TECH_POPIS_015||
|1297|D|D1297|10542||
|1297|E|E1297|Rodné číslo dítěte||
|1297|F|F1297|Souhrnná data zaměstnance||
|1297|G|G1297|Výsledek ročního zúčtování||
|1297|H|H1297|Sleva na manželku / manžela||
|1297|K|K1297|x||
|1297|L|L1297|změna četnosti||
|1297|M|M1297|ZP||
|1298|A|A1298|8.8.2025||
|1298|B|B1298|1.4 final||
|1298|D|D1298|10228||
|1298|E|E1298|ID pracovněprávního vztahu (Identifikátor zaměstnání)||
|1298|F|F1298|Vykonávaná pozice zaměstnance||
|1298|J|J1298|x||
|1298|K|K1298|x||
|1298|L|L1298|změna datového typu||
|1298|M|M1298|oprava datového typu text -> číslo||
|1299|A|A1299|18.8.2025||
|1299|B|B1299|1.4 final||
|1299|D|D1299|10018||
|1299|E|E1299|Důvod odmítnutí||
|1299|F|F1299|Meta atributy||
|1299|G|G1299|Formulář||
|1299|K|K1299|x||
|1299|L|L1299|úprava číselníku||
|1299|M|M1299|oprava duplicity chybového kódu, update číselníku z databázových hodnot||
|1300|A|A1300|29.8.2025||
|1300|B|B1300|1.4 final||
|1300|C|C1300|ZP_TECH_POPIS_057||
|1300|D|D1300|10535||
|1300|E|E1300|Základ pro výpočet daně||
|1300|F|F1300|Příjem v daném měsíci||
|1300|G|G1300|Daň||
|1300|K|K1300|x||
|1300|L|L1300|úprava konzumace atributu||
|1300|M|M1300|uplatněná připomínka ČSÚ v připomínkovém řízení||
|1301|A|A1301|29.8.2025||
|1301|B|B1301|1.4 final||
|1301|C|C1301|ZP_TECH_POPIS_057||
|1301|D|D1301|10524||
|1301|E|E1301|Stát||
|1301|F|F1301|Zaměstnanec / Žák / Student ||
|1301|G|G1301|Adresa||
|1301|H|H1301|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1301|J|J1301|x||
|1301|L|L1301|úprava konzumace atributu||
|1301|M|M1301|uplatněná připomínka ČSÚ v připomínkovém řízení||
|1302|A|A1302|29.8.2025||
|1302|B|B1302|1.4 final||
|1302|C|C1302|ZP_TECH_POPIS_057||
|1302|D|D1302|10526||
|1302|E|E1302|Předpokládané/á místo/a výkonu práce||
|1302|F|F1302|Vykonávaná pozice zaměstnance||
|1302|G|G1302|Předpokládané místo výkonu práce||
|1302|J|J1302|x||
|1302|L|L1302|úprava konzumace atributu||
|1302|M|M1302|uplatněná připomínka ČSÚ v připomínkovém řízení||
|1303|A|A1303|29.8.2025||
|1303|B|B1303|1.4 final||
|1303|C|C1303|ZP_TECH_POPIS_057||
|1303|D|D1303|10527||
|1303|E|E1303|Místo výkonu práce uvedené v pracovní smlouvě zaměstnance||
|1303|F|F1303|Vykonávaná pozice zaměstnance||
|1303|G|G1303|Místo výkonu práce ze smlouvy||
|1303|J|J1303|x||
|1303|L|L1303|úprava konzumace atributu||
|1303|M|M1303|uplatněná připomínka ČSÚ v připomínkovém řízení||
|1304|A|A1304|29.8.2025||
|1304|B|B1304|1.4 final||
|1304|C|C1304|ZP_TECH_POPIS_057||
|1304|D|D1304|10528||
|1304|E|E1304|Název obce||
|1304|F|F1304|Vykonávaná pozice zaměstnance||
|1304|G|G1304|Místo výkonu práce ze smlouvy||
|1304|J|J1304|x||
|1304|L|L1304|úprava konzumace atributu||
|1304|M|M1304|uplatněná připomínka ČSÚ v připomínkovém řízení||
|1305|A|A1305|29.8.2025||
|1305|B|B1305|1.4 final||
|1305|C|C1305|ZP_TECH_POPIS_057||
|1305|D|D1305|10529||
|1305|E|E1305|Kód obce||
|1305|F|F1305|Vykonávaná pozice zaměstnance||
|1305|G|G1305|Místo výkonu práce ze smlouvy||
|1305|J|J1305|x||
|1305|L|L1305|úprava konzumace atributu||
|1305|M|M1305|uplatněná připomínka ČSÚ v připomínkovém řízení||
|1306|A|A1306|4.9.2025||
|1306|B|B1306|1.4 final||
|1306|D|D1306|10267||
|1306|E|E1306|Počet odpracovaných dnů||
|1306|F|F1306|Průběh zaměstnání v daném měsíci||
|1306|G|G1306|Odpracované dny||
|1306|K|K1306|x||
|1306|L|L1306|úprava konzumace atributu||
|1306|M|M1306|uplatněná připomínka FS v připomínkovém řízení||
|1307|A|A1307|4.9.2025||
|1307|B|B1307|1.4 final||
|1307|D|D1307|10354||
|1307|E|E1307|Pojištění od||
|1307|F|F1307|Průběh pojištění v daném měsíci||
|1307|G|G1307|Trvání pojištění||
|1307|K|K1307|x||
|1307|L|L1307|úprava konzumace atributu||
|1307|M|M1307|uplatněná připomínka FS v připomínkovém řízení||
|1308|A|A1308|4.9.2025||
|1308|B|B1308|1.4 final||
|1308|D|D1308|10355||
|1308|E|E1308|Pojištění do||
|1308|F|F1308|Průběh pojištění v daném měsíci||
|1308|G|G1308|Trvání pojištění||
|1308|K|K1308|x||
|1308|L|L1308|úprava konzumace atributu||
|1308|M|M1308|uplatněná připomínka FS v připomínkovém řízení||
|1309|A|A1309|4.9.2025||
|1309|B|B1309|1.4 final||
|1309|D|D1309|10241||
|1309|E|E1309|Platnost kódu od||
|1309|F|F1309|Průběh pojištění v daném měsíci||
|1309|G|G1309|ELDP||
|1309|K|K1309|x||
|1309|L|L1309|úprava konzumace atributu||
|1309|M|M1309|uplatněná připomínka FS v připomínkovém řízení||
|1310|A|A1310|4.9.2025||
|1310|B|B1310|1.4 final||
|1310|D|D1310|10242||
|1310|E|E1310|Platnost kódu do||
|1310|F|F1310|Průběh pojištění v daném měsíci||
|1310|G|G1310|ELDP||
|1310|K|K1310|x||
|1310|L|L1310|úprava konzumace atributu||
|1310|M|M1310|uplatněná připomínka FS v připomínkovém řízení||
|1311|A|A1311|4.9.2025||
|1311|B|B1311|1.4 final||
|1311|D|D1311|10356||
|1311|E|E1311|Počet kalendářních dnů trvání doby důchodového pojištění v daném kalendářním měsíci||
|1311|F|F1311|Průběh pojištění v daném měsíci||
|1311|G|G1311|ELDP||
|1311|K|K1311|x||
|1311|L|L1311|úprava konzumace atributu||
|1311|M|M1311|uplatněná připomínka FS v připomínkovém řízení||
|1312|A|A1312|4.9.2025||
|1312|B|B1312|1.4 final||
|1312|D|D1312|10537||
|1312|E|E1312|Měsíc, za který je hlášeno||
|1312|F|F1312|Průběh pojištění v daném měsíci||
|1312|G|G1312|ELDP||
|1312|H|H1312|Odložený příjem||
|1312|K|K1312|x||
|1312|L|L1312|úprava konzumace atributu||
|1312|M|M1312|uplatněná připomínka FS v připomínkovém řízení||
|1313|A|A1313|4.9.2025||
|1313|B|B1313|1.4 final||
|1313|D|D1313|10538||
|1313|E|E1313|Rok, za který je hlášeno||
|1313|F|F1313|Průběh pojištění v daném měsíci||
|1313|G|G1313|ELDP||
|1313|H|H1313|Odložený příjem||
|1313|K|K1313|x||
|1313|L|L1313|úprava konzumace atributu||
|1313|M|M1313|uplatněná připomínka FS v připomínkovém řízení||
|1314|A|A1314|12.9.2025||
|1314|B|B1314|1.4.1||
|1314|C|C1314|ZP_TECH_POPIS_065||
|1314|D|D1314|10214||
|1314|E|E1314|Kolektivní smlouva/dohoda||
|1314|F|F1314|Zaměstnavatel  / Škola / Vzdělávací zařízení||
|1314|G|G1314|Kolektivní smlouva k 31.12.||
|1314|K|K1314|x||
|1314|L|L1314|úprava číselníku||
|1315|A|A1315|12.9.2025||
|1315|B|B1315|1.4.1||
|1315|C|C1315|ZP_TECH_POPIS_062||
|1315|D|D1315|10476||
|1315|E|E1315|Započitatelný příjem pro účely nemocenského pojištění||
|1315|F|F1315|Průběh pojištění v daném měsíci||
|1315|G|G1315|Vyměřovací základ||
|1315|K|K1315|x||
|1315|L|L1315|úprava datových scénářů||
|1316|A|A1316|12.9.2025||
|1316|B|B1316|1.4.1||
|1316|C|C1316|ZP_TECH_POPIS_064||
|1316|D|D1316|10240||
|1316|E|E1316|Kód ELDP||
|1316|F|F1316|Průběh pojištění v daném měsíci||
|1316|G|G1316|ELDP||
|1316|K|K1316|x||
|1316|L|L1316|změna povinnosti||
|1317|A|A1317|12.9.2025||
|1317|B|B1317|1.4.1||
|1317|C|C1317|ZP_TECH_POPIS_064||
|1317|D|D1317|10241||
|1317|E|E1317|Platnost kódu od||
|1317|F|F1317|Průběh pojištění v daném měsíci||
|1317|G|G1317|ELDP||
|1317|K|K1317|x||
|1317|L|L1317|změna povinnosti||
|1318|A|A1318|12.9.2025||
|1318|B|B1318|1.4.1||
|1318|C|C1318|ZP_TECH_POPIS_064||
|1318|D|D1318|10242||
|1318|E|E1318|Platnost kódu do||
|1318|F|F1318|Průběh pojištění v daném měsíci||
|1318|G|G1318|ELDP||
|1318|K|K1318|x||
|1318|L|L1318|změna povinnosti||
|1319|A|A1319|12.9.2025||
|1319|B|B1319|1.4.1||
|1319|C|C1319|ZP_TECH_POPIS_064||
|1319|D|D1319|10240||
|1319|E|E1319|Kód ELDP||
|1319|F|F1319|Průběh pojištění v daném měsíci||
|1319|G|G1319|ELDP||
|1319|K|K1319|x||
|1319|L|L1319|změna podmínky povinnosti||
|1320|A|A1320|12.9.2025||
|1320|B|B1320|1.4.1||
|1320|C|C1320|ZP_TECH_POPIS_064||
|1320|D|D1320|10241||
|1320|E|E1320|Platnost kódu od||
|1320|F|F1320|Průběh pojištění v daném měsíci||
|1320|G|G1320|ELDP||
|1320|K|K1320|x||
|1320|L|L1320|změna podmínky povinnosti||
|1321|A|A1321|12.9.2025||
|1321|B|B1321|1.4.1||
|1321|C|C1321|ZP_TECH_POPIS_064||
|1321|D|D1321|10242||
|1321|E|E1321|Platnost kódu do||
|1321|F|F1321|Průběh pojištění v daném měsíci||
|1321|G|G1321|ELDP||
|1321|K|K1321|x||
|1321|L|L1321|změna podmínky povinnosti||
|1322|A|A1322|12.9.2025||
|1322|B|B1322|1.4.1||
|1322|C|C1322|ZP_TECH_POPIS_064||
|1322|D|D1322|10241||
|1322|E|E1322|Platnost kódu od||
|1322|F|F1322|Průběh pojištění v daném měsíci||
|1322|G|G1322|ELDP||
|1322|K|K1322|x||
|1322|L|L1322|úprava datových scénářů||
|1323|A|A1323|12.9.2025||
|1323|B|B1323|1.4.1||
|1323|C|C1323|ZP_TECH_POPIS_064||
|1323|D|D1323|10242||
|1323|E|E1323|Platnost kódu do||
|1323|F|F1323|Průběh pojištění v daném měsíci||
|1323|G|G1323|ELDP||
|1323|K|K1323|x||
|1323|L|L1323|úprava datových scénářů||
|1324|A|A1324|12.9.2025||
|1324|B|B1324|1.4.1||
|1324|C|C1324|ZP_TECH_POPIS_064||
|1324|D|D1324|10357||
|1324|E|E1324|Vyloučené doby - doba trvání omluvných důvodů uvedených v § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1324|F|F1324|Průběh pojištění v daném měsíci||
|1324|G|G1324|ELDP||
|1324|H|H1324|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1324|K|K1324|x||
|1324|L|L1324|změna podmínky povinnosti||
|1325|A|A1325|12.9.2025||
|1325|B|B1325|1.4.1||
|1325|C|C1325|ZP_TECH_POPIS_064||
|1325|D|D1325|10358||
|1325|E|E1325|Počet dnů trvání dočasné pracovní neschopnosti||
|1325|F|F1325|Průběh pojištění v daném měsíci||
|1325|G|G1325|ELDP||
|1325|H|H1325|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1325|K|K1325|x||
|1325|L|L1325|změna podmínky povinnosti||
|1326|A|A1326|12.9.2025||
|1326|B|B1326|1.4.1||
|1326|C|C1326|ZP_TECH_POPIS_064||
|1326|D|D1326|10359||
|1326|E|E1326|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|1326|F|F1326|Průběh pojištění v daném měsíci||
|1326|G|G1326|ELDP||
|1326|H|H1326|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1326|K|K1326|x||
|1326|L|L1326|změna podmínky povinnosti||
|1327|A|A1327|12.9.2025||
|1327|B|B1327|1.4.1||
|1327|C|C1327|ZP_TECH_POPIS_064||
|1327|D|D1327|10360||
|1327|E|E1327|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|1327|F|F1327|Průběh pojištění v daném měsíci||
|1327|G|G1327|ELDP||
|1327|H|H1327|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1327|K|K1327|x||
|1327|L|L1327|změna podmínky povinnosti||
|1328|A|A1328|12.9.2025||
|1328|B|B1328|1.4.1||
|1328|C|C1328|ZP_TECH_POPIS_064||
|1328|D|D1328|10362||
|1328|E|E1328|Počet dnů čerpání otcovské||
|1328|F|F1328|Průběh pojištění v daném měsíci||
|1328|G|G1328|ELDP||
|1328|H|H1328|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1328|K|K1328|x||
|1328|L|L1328|změna podmínky povinnosti||
|1329|A|A1329|12.9.2025||
|1329|B|B1329|1.4.1||
|1329|C|C1329|ZP_TECH_POPIS_064||
|1329|D|D1329|10536||
|1329|E|E1329|Počet dnů podle § 16 odst. 4 písm. j) zákona č. 155/1995 Sb.||
|1329|F|F1329|Průběh pojištění v daném měsíci||
|1329|G|G1329|ELDP||
|1329|H|H1329|Vyloučené dny § 16 odst. 4 písm. a) a j) zákona č. 155/1995 Sb.||
|1329|K|K1329|x||
|1329|L|L1329|změna podmínky povinnosti||
|1330|A|A1330|12.9.2025||
|1330|B|B1330|1.4.1||
|1330|C|C1330|ZP_TECH_POPIS_064||
|1330|D|D1330|10366||
|1330|E|E1330|Vyloučené dny podle § 18 odst. 7 zákona č. 187/2006 Sb.||
|1330|F|F1330|Průběh pojištění v daném měsíci||
|1330|G|G1330|ELDP||
|1330|H|H1330|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|1330|K|K1330|x||
|1330|L|L1330|změna podmínky povinnosti||
|1331|A|A1331|12.9.2025||
|1331|B|B1331|1.4.1||
|1331|C|C1331|ZP_TECH_POPIS_064||
|1331|D|D1331|10473||
|1331|E|E1331|Počet dnů omluvené nepřítomnosti, za které nenáleží náhrada příjmu (neplacené volno, stávka)||
|1331|F|F1331|Průběh pojištění v daném měsíci||
|1331|G|G1331|ELDP||
|1331|H|H1331|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|1331|K|K1331|x||
|1331|L|L1331|změna podmínky povinnosti||
|1332|A|A1332|12.9.2025||
|1332|B|B1332|1.4.1||
|1332|C|C1332|ZP_TECH_POPIS_064||
|1332|D|D1332|10474||
|1332|E|E1332|Počet dnů dočasné pracovní neschopnosti nebo karantény, za které náleží náhrada příjmu||
|1332|F|F1332|Průběh pojištění v daném měsíci||
|1332|G|G1332|ELDP||
|1332|H|H1332|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|1332|K|K1332|x||
|1332|L|L1332|změna podmínky povinnosti||
|1333|A|A1333|12.9.2025||
|1333|B|B1333|1.4.1||
|1333|C|C1333|ZP_TECH_POPIS_064||
|1333|D|D1333|10475||
|1333|E|E1333|Počet dnů, za které bylo zaměstnanci vypláceno nemocenské, peněžitá pomoc v mateřství, otcovská, ošetřovné nebo dlouhodobé ošetřovné ||
|1333|F|F1333|Průběh pojištění v daném měsíci||
|1333|G|G1333|ELDP||
|1333|H|H1333|Vyloučené dny § 18 odst. 7 zákona č. 187/2006 Sb.||
|1333|K|K1333|x||
|1333|L|L1333|změna podmínky povinnosti||
|1334|A|A1334|15.9.2025||
|1334|B|B1334|1.4.1||
|1334|C|C1334|ZP_TECH_POPIS_064||
|1334|D|D1334|10462||
|1334|E|E1334|Počet dnů trvání dočasné pracovní neschopnosti (karanténa)||
|1334|F|F1334|Průběh pojištění v daném měsíci||
|1334|G|G1334|ELDP||
|1334|H|H1334|Odečítané dny||
|1334|K|K1334|x||
|1334|L|L1334|změna povinnosti||
|1335|A|A1335|15.9.2025||
|1335|B|B1335|1.4.1||
|1335|C|C1335|ZP_TECH_POPIS_064||
|1335|D|D1335|10463||
|1335|E|E1335|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|1335|F|F1335|Průběh pojištění v daném měsíci||
|1335|G|G1335|ELDP||
|1335|H|H1335|Odečítané dny||
|1335|K|K1335|x||
|1335|L|L1335|změna povinnosti||
|1336|A|A1336|15.9.2025||
|1336|B|B1336|1.4.1||
|1336|C|C1336|ZP_TECH_POPIS_064||
|1336|D|D1336|10464||
|1336|E|E1336|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|1336|F|F1336|Průběh pojištění v daném měsíci||
|1336|G|G1336|ELDP||
|1336|H|H1336|Odečítané dny||
|1336|K|K1336|x||
|1336|L|L1336|změna povinnosti||
|1337|A|A1337|15.9.2025||
|1337|B|B1337|1.4.1||
|1337|C|C1337|ZP_TECH_POPIS_064||
|1337|D|D1337|10465||
|1337|E|E1337|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné ||
|1337|F|F1337|Průběh pojištění v daném měsíci||
|1337|G|G1337|ELDP||
|1337|H|H1337|Odečítané dny||
|1337|K|K1337|x||
|1337|L|L1337|změna povinnosti||
|1338|A|A1338|15.9.2025||
|1338|B|B1338|1.4.1||
|1338|C|C1338|ZP_TECH_POPIS_064||
|1338|D|D1338|10466||
|1338|E|E1338|Počet dnů čerpání otcovské||
|1338|F|F1338|Průběh pojištění v daném měsíci||
|1338|G|G1338|ELDP||
|1338|H|H1338|Odečítané dny||
|1338|K|K1338|x||
|1338|L|L1338|změna povinnosti||
|1339|A|A1339|15.9.2025||
|1339|B|B1339|1.4.1||
|1339|C|C1339|ZP_TECH_POPIS_064||
|1339|D|D1339|10468||
|1339|E|E1339|Počet dnů čerpání neplaceného volna||
|1339|F|F1339|Průběh pojištění v daném měsíci||
|1339|G|G1339|ELDP||
|1339|H|H1339|Odečítané dny||
|1339|K|K1339|x||
|1339|L|L1339|změna povinnosti||
|1340|A|A1340|15.9.2025||
|1340|B|B1340|1.4.1||
|1340|C|C1340|ZP_TECH_POPIS_064||
|1340|D|D1340|10469||
|1340|E|E1340|Počet dnů neomluvené absence||
|1340|F|F1340|Průběh pojištění v daném měsíci||
|1340|G|G1340|ELDP||
|1340|H|H1340|Odečítané dny||
|1340|K|K1340|x||
|1340|L|L1340|změna povinnosti||
|1341|A|A1341|15.9.2025||
|1341|B|B1341|1.4.1||
|1341|C|C1341|ZP_TECH_POPIS_064||
|1341|D|D1341|10462||
|1341|E|E1341|Počet dnů trvání dočasné pracovní neschopnosti (karanténa)||
|1341|F|F1341|Průběh pojištění v daném měsíci||
|1341|G|G1341|ELDP||
|1341|H|H1341|Odečítané dny||
|1341|K|K1341|x||
|1341|L|L1341|změna podmínky povinnosti||
|1342|A|A1342|15.9.2025||
|1342|B|B1342|1.4.1||
|1342|C|C1342|ZP_TECH_POPIS_064||
|1342|D|D1342|10463||
|1342|E|E1342|Počet dnů čerpání peněžité pomoci v mateřství (do dne předcházejícímu porodu)||
|1342|F|F1342|Průběh pojištění v daném měsíci||
|1342|G|G1342|ELDP||
|1342|H|H1342|Odečítané dny||
|1342|K|K1342|x||
|1342|L|L1342|změna podmínky povinnosti||
|1343|A|A1343|15.9.2025||
|1343|B|B1343|1.4.1||
|1343|C|C1343|ZP_TECH_POPIS_064||
|1343|D|D1343|10464||
|1343|E|E1343|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které náleží ošetřovné/dlouhodobé ošetřovné||
|1343|F|F1343|Průběh pojištění v daném měsíci||
|1343|G|G1343|ELDP||
|1343|H|H1343|Odečítané dny||
|1343|K|K1343|x||
|1343|L|L1343|změna podmínky povinnosti||
|1344|A|A1344|15.9.2025||
|1344|B|B1344|1.4.1||
|1344|C|C1344|ZP_TECH_POPIS_064||
|1344|D|D1344|10465||
|1344|E|E1344|Počet dnů ošetřování dítěte nebo péče o ně nebo ošetřování jiného člena domácnosti, za které nenáleží ošetřovné ||
|1344|F|F1344|Průběh pojištění v daném měsíci||
|1344|G|G1344|ELDP||
|1344|H|H1344|Odečítané dny||
|1344|K|K1344|x||
|1344|L|L1344|změna podmínky povinnosti||
|1345|A|A1345|15.9.2025||
|1345|B|B1345|1.4.1||
|1345|C|C1345|ZP_TECH_POPIS_064||
|1345|D|D1345|10466||
|1345|E|E1345|Počet dnů čerpání otcovské||
|1345|F|F1345|Průběh pojištění v daném měsíci||
|1345|G|G1345|ELDP||
|1345|H|H1345|Odečítané dny||
|1345|K|K1345|x||
|1345|L|L1345|změna podmínky povinnosti||
|1346|A|A1346|15.9.2025||
|1346|B|B1346|1.4.1||
|1346|C|C1346|ZP_TECH_POPIS_064||
|1346|D|D1346|10468||
|1346|E|E1346|Počet dnů čerpání neplaceného volna||
|1346|F|F1346|Průběh pojištění v daném měsíci||
|1346|G|G1346|ELDP||
|1346|H|H1346|Odečítané dny||
|1346|K|K1346|x||
|1346|L|L1346|změna podmínky povinnosti||
|1347|A|A1347|15.9.2025||
|1347|B|B1347|1.4.1||
|1347|C|C1347|ZP_TECH_POPIS_064||
|1347|D|D1347|10469||
|1347|E|E1347|Počet dnů neomluvené absence||
|1347|F|F1347|Průběh pojištění v daném měsíci||
|1347|G|G1347|ELDP||
|1347|H|H1347|Odečítané dny||
|1347|K|K1347|x||
|1347|L|L1347|změna podmínky povinnosti||
|1348|A|A1348|15.9.2025||
|1348|B|B1348|1.4.1||
|1348|C|C1348|ZP_TECH_POPIS_064||
|1348|D|D1348|10476||
|1348|E|E1348|Započitatelný příjem pro účely nemocenského pojištění||
|1348|F|F1348|Průběh pojištění v daném měsíci||
|1348|G|G1348|Vyměřovací základ||
|1348|K|K1348|x||
|1348|L|L1348|úprava datových scénářů||
|1349|A|A1349|15.9.2025||
|1349|B|B1349|1.4.1||
|1349|C|C1349|ZP_TECH_POPIS_064||
|1349|D|D1349|10477||
|1349|E|E1349|Částka vyměřovacího základu zaměstnance, ze které je odváděno pojistné||
|1349|F|F1349|Průběh pojištění v daném měsíci||
|1349|G|G1349|Vyměřovací základ||
|1349|K|K1349|x||
|1349|L|L1349|úprava datových scénářů||
|1350|A|A1350|15.9.2025||
|1350|B|B1350|1.4.1||
|1350|C|C1350|ZP_TECH_POPIS_064||
|1350|D|D1350|10478||
|1350|E|E1350|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. a) ZPSZ ||
|1350|F|F1350|Průběh pojištění v daném měsíci||
|1350|G|G1350|Vyměřovací základ||
|1350|K|K1350|x||
|1350|L|L1350|úprava datových scénářů||
|1351|A|A1351|15.9.2025||
|1351|B|B1351|1.4.1||
|1351|C|C1351|ZP_TECH_POPIS_064||
|1351|D|D1351|10479||
|1351|E|E1351|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. b) ZPSZ ||
|1351|F|F1351|Průběh pojištění v daném měsíci||
|1351|G|G1351|Vyměřovací základ||
|1351|K|K1351|x||
|1351|L|L1351|úprava datových scénářů||
|1352|A|A1352|15.9.2025||
|1352|B|B1352|1.4.1||
|1352|C|C1352|ZP_TECH_POPIS_064||
|1352|D|D1352|10480||
|1352|E|E1352|Částka vyměřovacího základu zaměstnance, která vstupuje do částky vyměřovacího základu zaměstnavatele podle § 5a odst. 1 písm. c) ZPSZ ||
|1352|F|F1352|Průběh pojištění v daném měsíci||
|1352|G|G1352|Vyměřovací základ||
|1352|K|K1352|x||
|1352|L|L1352|úprava datových scénářů||
|1353|A|A1353|15.9.2025||
|1353|B|B1353|1.4.1||
|1353|C|C1353|ZP_TECH_POPIS_064||
|1353|D|D1353|10481||
|1353|E|E1353|Pojistné na sociální zabezpečení ||
|1353|F|F1353|Průběh pojištění v daném měsíci||
|1353|G|G1353|Pojistné za zaměstnavatele||
|1353|K|K1353|x||
|1353|L|L1353|úprava datových scénářů||
|1354|A|A1354|15.9.2025||
|1354|B|B1354|1.4.1||
|1354|C|C1354|ZP_TECH_POPIS_064||
|1354|D|D1354|10370||
|1354|E|E1354|Sociální pojištění||
|1354|F|F1354|Průběh pojištění v daném měsíci||
|1354|G|G1354|Pojistné za zaměstnance||
|1354|K|K1354|x||
|1354|L|L1354|úprava datových scénářů||
|1355|A|A1355|15.9.2025||
|1355|B|B1355|1.4.1||
|1355|C|C1355|ZP_TECH_POPIS_064||
|1355|D|D1355|10372||
|1355|E|E1355|Sleva na pojistném zaměstnavatele||
|1355|F|F1355|Průběh pojištění v daném měsíci||
|1355|G|G1355|Sleva na pojistném zaměstnavatele||
|1355|K|K1355|x||
|1355|L|L1355|úprava datových scénářů||
|1356|A|A1356|15.9.2025||
|1356|B|B1356|1.4.1||
|1356|C|C1356|ZP_TECH_POPIS_064||
|1356|D|D1356|10490||
|1356|E|E1356|Sleva na pojistném zaměstnance||
|1356|F|F1356|Průběh pojištění v daném měsíci||
|1356|G|G1356|Sleva na pojistném zaměstnanců||
|1356|H|H1356|Pracující důchodci||
|1356|K|K1356|x||
|1356|L|L1356|úprava datových scénářů||
|1357|A|A1357|15.9.2025||
|1357|B|B1357|1.4.1||
|1357|C|C1357|ZP_TECH_POPIS_064||
|1357|D|D1357|10546||
|1357|E|E1357|Sleva na pojistném zaměstnance||
|1357|F|F1357|Průběh pojištění v daném měsíci||
|1357|G|G1357|Sleva na pojistném zaměstnanců||
|1357|H|H1357|Ovocnářství a pěstování zeleniny||
|1357|K|K1357|x||
|1357|L|L1357|úprava datových scénářů||
|1358|A|A1358|16.9.2025||
|1358|B|B1358|1.4.1||
|1358|D|D1358|10523||
|1358|E|E1358|Obec||
|1358|F|F1358|Zaměstnanec / Žák / Student ||
|1358|G|G1358|Adresa||
|1358|H|H1358|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1358|J|J1358|x||
|1358|L|L1358|oprava ID atributu||
|1358|M|M1358|narovnání ID atributů podle Definice externí datové věty||
|1359|A|A1359|16.9.2025||
|1359|B|B1359|1.4.1||
|1359|D|D1359|10522||
|1359|E|E1359|PSČ||
|1359|F|F1359|Zaměstnanec / Žák / Student ||
|1359|G|G1359|Adresa||
|1359|H|H1359|Adresa bydliště ve státě, jehož je zaměstnanec rezidentem||
|1359|J|J1359|x||
|1359|L|L1359|oprava ID atributu||
|1359|M|M1359|narovnání ID atributů podle Definice externí datové věty||
|1360|A|A1360|6.10.2025||
|1360|B|B1360|1.4.1||
|1360|D|D1360|10104||
|1360|E|E1360|Název předchozího orgánu, který prováděl nemocenské pojištění||
|1360|F|F1360|Zaměstnanec / Žák / Student ||
|1360|G|G1360|Pojištění||
|1360|H|H1360|Zdravotní a nemocenské pojištění||
|1360|J|J1360|x||
|1360|L|L1360|oprava ID atributu||
|1360|M|M1360|narovnání ID atributů podle Definice externí datové věty||
|1361|A|A1361|6.10.2025||
|1361|B|B1361|1.4.1||
|1361|D|D1361|10103||
|1361|E|E1361|Název současného orgánu, který provádí nemocenské pojištění||
|1361|F|F1361|Zaměstnanec / Žák / Student ||
|1361|G|G1361|Pojištění||
|1361|H|H1361|Zdravotní a nemocenské pojištění||
|1361|J|J1361|x||
|1361|L|L1361|oprava ID atributu||
|1361|M|M1361|narovnání ID atributů podle Definice externí datové věty||
|1362|A|A1362|13.10.2025||
|1362|B|B1362|1.4.1||
|1362|C|C1362|ZP_TECH_POPIS_071||
|1362|D|D1362|10416||
|1362|E|E1362|Zúčtovaný příjem - z toho odměny členů orgánů právnických osob, kteří jsou daňovými nerezidenty ČR||
|1362|F|F1362|Souhrnná data zaměstnance||
|1362|G|G1362|Příjem||
|1362|K|K1362|x||
|1362|L|L1362|úprava datových scénářů||
|1363|A|A1363|13.10.2025||
|1363|B|B1363|1.4.1||
|1363|C|C1363|ZP_TECH_POPIS_071||
|1363|D|D1363|10308||
|1363|E|E1363|Odměna člena (nerezidenta) orgánu právnické osoby||
|1363|F|F1363|Souhrnná data zaměstnance||
|1363|G|G1363|Výpočet daně podle zvláštní sazby daně ||
|1363|K|K1363|x||
|1363|L|L1363|úprava datových scénářů||
|1364|A|A1364|13.10.2025||
|1364|B|B1364|1.4.1||
|1364|C|C1364|ZP_TECH_POPIS_071||
|1364|D|D1364|10310||
|1364|E|E1364|Sražená záloha na daň z příjmu nerezidenta člena orgánu právnické osoby||
|1364|F|F1364|Souhrnná data zaměstnance||
|1364|G|G1364|Výpočet daně podle zvláštní sazby daně ||
|1364|K|K1364|x||
|1364|L|L1364|úprava datových scénářů||
|1365|A|A1365|17.10.2025||
|1365|B|B1365|1.4.1||
|1365|D|D1365|10255||
|1365|E|E1365|Pracovní režim||
|1365|F|F1365|Vykonávaná pozice zaměstnance||
|1365|G|G1365|Režim práce||
|1365|J|J1365|x||
|1365|L|L1365|úprava číselníku||
|1365|M|M1365|oprava nekonzistence vůči číselníkovým kódům v UDZ||
|1366|A|A1366|20.10.2025||
|1366|B|B1366|1.4.1||
|1366|D|D1366|10408||
|1366|E|E1366|Specifická právní skutečnost||
|1366|F|F1366|Souhrnná vrstva||
|1366|G|G1366|Specifická právní skutečnost||
|1366|K|K1366|x||
|1366|L|L1366|změna oblasti atributu||
|1366|M|M1366|přesun atributů do nové oblasti, aby jejich zařazení odpovídalo Nařízení vlády a XSD||
|1367|A|A1367|20.10.2025||
|1367|B|B1367|1.4.1||
|1367|D|D1367|10409||
|1367|E|E1367|Datum nastání specifické právní skutečnosti||
|1367|F|F1367|Souhrnná vrstva||
|1367|G|G1367|Specifická právní skutečnost||
|1367|K|K1367|x||
|1367|L|L1367|změna oblasti atributu||
|1367|M|M1367|přesun atributů do nové oblasti, aby jejich zařazení odpovídalo Nařízení vlády a XSD||
|1368|A|A1368|20.10.2025||
|1368|B|B1368|1.4.1||
|1368|D|D1368|10214||
|1368|E|E1368|Kolektivní smlouva/dohoda||
|1368|F|F1368|Souhrnná vrstva||
|1368|G|G1368|Kolektivní smlouva k 31.12.||
|1368|K|K1368|x||
|1368|L|L1368|změna oblasti atributu||
|1368|M|M1368|přesun atributů do nové oblasti, aby jejich zařazení odpovídalo Nařízení vlády a XSD||
|1369|A|A1369|20.10.2025||
|1369|B|B1369|1.4.1||
|1369|D|D1369|10220||
|1369|E|E1369|Forma||
|1369|F|F1369|Souhrnná vrstva||
|1369|G|G1369|Hospodářská a finanční kontrola k 31.12.||
|1369|K|K1369|x||
|1369|L|L1369|změna oblasti atributu||
|1369|M|M1369|přesun atributů do nové oblasti, aby jejich zařazení odpovídalo Nařízení vlády a XSD||
|1370|A|A1370|22.10.2025||
|1370|B|B1370|1.4.1||
|1370|C|C1370|ZP_TECH_POPIS_007||
|1370|D|D1370|10548||
|1370|E|E1370|Typ Odloženého příjmu||
|1370|F|F1370|Meta atributy||
|1370|G|G1370|Formulář||
|1370|K|K1370|x||
|1370|L|L1370|přidání atributu||
|1370|M|M1370|přidání nového metadatového atributu pro technické účely cJMHZ||
|1371|A|A1371|23.10.2025||
|1371|B|B1371|1.4.1||
|1371|C|C1371|ZP_TECH_POPIS_066||
|1371|D|D1371|10267||
|1371|E|E1371|Počet odpracovaných dnů||
|1371|F|F1371|Průběh zaměstnání v daném měsíci||
|1371|G|G1371|Odpracované dny||
|1371|K|K1371|x||
|1371|L|L1371|změna povinnosti||
|1371|M|M1371|P -> N, dočasná úprava pro ZP_TECH_POPIS_066 (změna povinnosti místo odstranění atributu)||
|1372|A|A1372|30.10.2025||
|1372|B|B1372|1.4.1||
|1372|D|D1372|10059||
|1372|E|E1372|Pohlaví||
|1372|F|F1372|Zaměstnanec / Žák / Student ||
|1372|G|G1372|Základní identifikace||
|1372|J|J1372|x||
|1372|L|L1372|úprava číselníku||
|1372|M|M1372|narovnání kódů číselníku proti reálné implementaci||
|1373|A|A1373|6.11.2025||
|1373|B|B1373|1.4.1||
|1373|D|D1373|10113||
|1373|E|E1373|Druh důchodu||
|1373|F|F1373|Zaměstnanec / Žák / Student ||
|1373|G|G1373|Důchod||
|1373|H|H1373|Vyplácený jiným (i zahraničním) nositelem pojištění||
|1373|J|J1373|x||
|1373|L|L1373|změna četnosti||
|1373|M|M1373|odebrání multiplicity na základě implementace na DIS a v UDZ||
|1374|A|A1374|6.11.2025||
|1374|B|B1374|1.4.1||
|1374|D|D1374|10114||
|1374|E|E1374|Pobírán od||
|1374|F|F1374|Zaměstnanec / Žák / Student ||
|1374|G|G1374|Důchod||
|1374|H|H1374|Vyplácený jiným (i zahraničním) nositelem pojištění||
|1374|J|J1374|x||
|1374|L|L1374|změna četnosti||
|1374|M|M1374|odebrání multiplicity na základě implementace na DIS a v UDZ||
|1375|A|A1375|7.11.2025||
|1375|B|B1375|1.4.1||
|1375|D|D1375|10529||
|1375|E|E1375|Kód obce||
|1375|F|F1375|Vykonávaná pozice zaměstnance||
|1375|G|G1375|Místo výkonu práce ze smlouvy||
|1375|J|J1375|x||
|1375|L|L1375|úprava číselníku||
|1375|M|M1375|změna odkazu na číselník podle nové vyhlášky||
|1376|A|A1376|7.11.2025||
|1376|B|B1376|1.4.1||
|1376|D|D1376|10230||
|1376|E|E1376|Kód obce||
|1376|F|F1376|Vykonávaná pozice zaměstnance||
|1376|G|G1376|Místo výkonu práce / činnosti||
|1376|H|H1376|Adresa||
|1376|K|K1376|x||
|1376|L|L1376|úprava číselníku||
|1376|M|M1376|změna odkazu na číselník podle nové vyhlášky||
|1377|A|A1377|26.11.2025||
|1377|B|B1377|1.4.1.1||
|1377|D|D1377|10495||
|1377|E|E1377|Primární pracovněprávní vztah zaměstnance||
|1377|F|F1377|Meta atributy||
|1377|G|G1377|Formulář||
|1377|K|K1377|x||
|1377|L|L1377|změna povinnosti||
|1377|M|M1377|znepovinnění atributu P -> N vzhledem k umístění atributu do hlavičky z rozhodnutí dodavatele. V datových scénářích, kde musí zůstat povinné, bude vyřešeno logickou kontrolou||
|1378|A|A1378|6.1.2026||
|1378|B|B1378|1.4.1.1||
|1378|D|D1378|10548||
|1378|E|E1378|Typ Odloženého příjmu||
|1378|F|F1378|Meta atributy||
|1378|G|G1378|Formulář||
|1378|K|K1378|x||
|1378|L|L1378|úprava číselníku||
|1378|M|M1378|přidání hodnot 5 a 6 na základě požadavku dodavatelů HRIS||
|1379|A|A1379|16.1.2026||
|1379|B|B1379|1.4.1.2||
|1379|D|D1379|10529||
|1379|E|E1379|Kód obce||
|1379|F|F1379|Vykonávaná pozice zaměstnance||
|1379|G|G1379|Místo výkonu práce ze smlouvy||
|1379|J|J1379|x||
|1379|L|L1379|úprava číselníku||
|1379|M|M1379|změna odkazu na číselník podle nové vyhlášky||
|1380|A|A1380|16.1.2026||
|1380|B|B1380|1.4.1.2||
|1380|D|D1380|10230||
|1380|E|E1380|Kód obce||
|1380|F|F1380|Vykonávaná pozice zaměstnance||
|1380|G|G1380|Místo výkonu práce / činnosti||
|1380|H|H1380|Adresa||
|1380|K|K1380|x||
|1380|L|L1380|úprava číselníku||
|1380|M|M1380|změna odkazu na číselník podle nové vyhlášky||
|1381|A|A1381|16.1.2026||
|1381|B|B1381|1.4.1.2||
|1381|J|J1381|x||
|1381|K|K1381|x||
|1381|L|L1381|globální||
|1381|M|M1381|přidání sloupců pro mapování XSD elementů na atributy||

## CIS Okresy

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|C|C1|Popis v tiskopisech||
|1|E|E1|Zdroj:||
|1|F|F1|ČSSZ||
|1|H|H1|SLOVNÍK||
|2|A|A2|110||
|2|B|B2|Praha 10||
|2|C|C2|PSSZ (110)||
|2|E|E2|Popis:||
|2|F|F2|Číselník okresů||
|3|A|A3|111||
|3|B|B3|Praha 1||
|3|C|C3|PSSZ (111)||
|3|E|E3|URL:||
|3|F|F3|https://data.cssz.cz/web/otevrena-data/tabulka-ciselnik-okresu||
|4|A|A4|112||
|4|B|B4|Praha 2||
|4|C|C4|PSSZ (112)||
|5|A|A5|113||
|5|B|B5|Praha 3||
|5|C|C5|PSSZ (113)||
|6|A|A6|114||
|6|B|B6|Praha 4||
|6|C|C6|PSSZ (114)||
|7|A|A7|115||
|7|B|B7|Praha 5||
|7|C|C7|PSSZ (115)||
|8|A|A8|116||
|8|B|B8|Praha 6||
|8|C|C8|PSSZ (116)||
|9|A|A9|117||
|9|B|B9|Praha 7||
|9|C|C9|PSSZ (117)||
|10|A|A10|118||
|10|B|B10|Praha 8||
|10|C|C10|PSSZ (118)||
|11|A|A11|119||
|11|B|B11|Praha 9||
|11|C|C11|PSSZ (119)||
|12|A|A12|121||
|12|B|B12|Praha 5 - Jihozápadní Město||
|12|C|C12|PSSZ (121)||
|13|A|A13|122||
|13|B|B13|Praha 4 - Modřany||
|13|C|C13|PSSZ (122)||
|14|A|A14|123||
|14|B|B14|Praha 4 - Jižní Město||
|14|C|C14|PSSZ (123)||
|15|A|A15|220||
|15|B|B15|Benešov||
|15|C|C15|OSSZ Benešov||
|16|A|A16|221||
|16|B|B16|Beroun||
|16|C|C16|OSSZ Beroun||
|17|A|A17|222||
|17|B|B17|Kladno||
|17|C|C17|OSSZ Kladno||
|18|A|A18|223||
|18|B|B18|Kolín||
|18|C|C18|OSSZ Kolín||
|19|A|A19|224||
|19|B|B19|Kutná Hora||
|19|C|C19|OSSZ Kutná Hora||
|20|A|A20|225||
|20|B|B20|Mělník||
|20|C|C20|OSSZ Mělník||
|21|A|A21|226||
|21|B|B21|Mladá Boleslav||
|21|C|C21|OSSZ Mladá Boleslav||
|22|A|A22|227||
|22|B|B22|Nymburk||
|22|C|C22|OSSZ Nymburk||
|23|A|A23|228||
|23|B|B23|Praha-východ||
|23|C|C23|OSSZ Praha-východ||
|24|A|A24|229||
|24|B|B24|Praha-západ||
|24|C|C24|OSSZ Praha-západ||
|25|A|A25|230||
|25|B|B25|Příbram||
|25|C|C25|OSSZ Příbram||
|26|A|A26|231||
|26|B|B26|Rakovník||
|26|C|C26|OSSZ Rakovník||
|27|A|A27|332||
|27|B|B27|České Budějovice||
|27|C|C27|OSSZ České Budějovice||
|28|A|A28|333||
|28|B|B28|Český Krumlov||
|28|C|C28|OSSZ Český Krumlov||
|29|A|A29|334||
|29|B|B29|Jindřichův Hradec||
|29|C|C29|OSSZ Jindřichův Hradec||
|30|A|A30|335||
|30|B|B30|Pelhřimov||
|30|C|C30|OSSZ Pelhřimov||
|31|A|A31|336||
|31|B|B31|Písek||
|31|C|C31|OSSZ Písek||
|32|A|A32|337||
|32|B|B32|Prachatice||
|32|C|C32|OSSZ Prachatice||
|33|A|A33|338||
|33|B|B33|Strakonice||
|33|C|C33|OSSZ Strakonice||
|34|A|A34|339||
|34|B|B34|Tábor||
|34|C|C34|OSSZ Tábor||
|35|A|A35|440||
|35|B|B35|Domažlice||
|35|C|C35|OSSZ Domažlice||
|36|A|A36|441||
|36|B|B36|Cheb||
|36|C|C36|OSSZ Cheb||
|37|A|A37|442||
|37|B|B37|Karlovy Vary||
|37|C|C37|OSSZ Karlovy Vary||
|38|A|A38|443||
|38|B|B38|Klatovy||
|38|C|C38|OSSZ Klatovy||
|39|A|A39|444||
|39|B|B39|Plzeň-město||
|39|C|C39|OSSZ Plzeň-město||
|40|A|A40|445||
|40|B|B40|Plzeň-jih||
|40|C|C40|OSSZ Plzeň-jih||
|41|A|A41|446||
|41|B|B41|Plzeň-sever||
|41|C|C41|OSSZ Plzeň-sever||
|42|A|A42|447||
|42|B|B42|Rokycany||
|42|C|C42|OSSZ Rokycany||
|43|A|A43|448||
|43|B|B43|Sokolov||
|43|C|C43|OSSZ Sokolov||
|44|A|A44|449||
|44|B|B44|Tachov||
|44|C|C44|OSSZ Tachov||
|45|A|A45|550||
|45|B|B45|Česká Lípa||
|45|C|C45|OSSZ Česká Lípa||
|46|A|A46|551||
|46|B|B46|Děčín||
|46|C|C46|OSSZ Děčín||
|47|A|A47|552||
|47|B|B47|Chomutov||
|47|C|C47|OSSZ Chomutov||
|48|A|A48|553||
|48|B|B48|Jablonec nad Nisou||
|48|C|C48|OSSZ Jablonec nad Nisou||
|49|A|A49|554||
|49|B|B49|Liberec||
|49|C|C49|OSSZ Liberec||
|50|A|A50|555||
|50|B|B50|Litoměřice||
|50|C|C50|OSSZ Litoměřice||
|51|A|A51|556||
|51|B|B51|Louny||
|51|C|C51|OSSZ Louny||
|52|A|A52|557||
|52|B|B52|Most||
|52|C|C52|OSSZ Most||
|53|A|A53|558||
|53|B|B53|Teplice||
|53|C|C53|OSSZ Teplice||
|54|A|A54|559||
|54|B|B54|Ústí nad Labem||
|54|C|C54|OSSZ Ústí nad Labem||
|55|A|A55|660||
|55|B|B55|Havlíčkův Brod||
|55|C|C55|OSSZ Havlíčkův Brod||
|56|A|A56|661||
|56|B|B56|Hradec Králové||
|56|C|C56|OSSZ Hradec Králové||
|57|A|A57|662||
|57|B|B57|Chrudim||
|57|C|C57|OSSZ Chrudim||
|58|A|A58|663||
|58|B|B58|Jičín||
|58|C|C58|OSSZ Jičín||
|59|A|A59|664||
|59|B|B59|Náchod||
|59|C|C59|OSSZ Náchod||
|60|A|A60|665||
|60|B|B60|Pardubice||
|60|C|C60|OSSZ Pardubice||
|61|A|A61|666||
|61|B|B61|Rychnov nad Kněžnou||
|61|C|C61|OSSZ Rychnov nad Kněžnou||
|62|A|A62|667||
|62|B|B62|Semily||
|62|C|C62|OSSZ Semily||
|63|A|A63|668||
|63|B|B63|Svitavy||
|63|C|C63|OSSZ Svitavy||
|64|A|A64|669||
|64|B|B64|Trutnov||
|64|C|C64|OSSZ Trutnov||
|65|A|A65|670||
|65|B|B65|Ústí nad Orlicí||
|65|C|C65|OSSZ Ústí nad Orlicí||
|66|A|A66|771||
|66|B|B66|Blansko||
|66|C|C66|OSSZ Blansko||
|67|A|A67|772||
|67|B|B67|Brno||
|67|C|C67|MSSZ Brno||
|68|A|A68|773||
|68|B|B68|Brno-venkov||
|68|C|C68|OSSZ Brno-venkov||
|69|A|A69|774||
|69|B|B69|Břeclav||
|69|C|C69|OSSZ Břeclav||
|70|A|A70|775||
|70|B|B70|Zlín||
|70|C|C70|OSSZ Zlín||
|71|A|A71|776||
|71|B|B71|Hodonín||
|71|C|C71|OSSZ Hodonín||
|72|A|A72|777||
|72|B|B72|Jihlava||
|72|C|C72|OSSZ Jihlava||
|73|A|A73|778||
|73|B|B73|Kroměříž||
|73|C|C73|OSSZ Kroměříž||
|74|A|A74|779||
|74|B|B74|Prostějov||
|74|C|C74|OSSZ Prostějov||
|75|A|A75|780||
|75|B|B75|Třebíč||
|75|C|C75|OSSZ Třebíč||
|76|A|A76|781||
|76|B|B76|Uherské Hradiště||
|76|C|C76|OSSZ Uherské Hradiště||
|77|A|A77|782||
|77|B|B77|Vyškov||
|77|C|C77|OSSZ Vyškov||
|78|A|A78|783||
|78|B|B78|Znojmo||
|78|C|C78|OSSZ Znojmo||
|79|A|A79|784||
|79|B|B79|Žďár nad Sázavou||
|79|C|C79|OSSZ Žďár nad Sázavou||
|80|A|A80|884||
|80|B|B80|Jeseník||
|80|C|C80|OSSZ Jeseník||
|81|A|A81|885||
|81|B|B81|Bruntál||
|81|C|C81|OSSZ Bruntál||
|82|A|A82|886||
|82|B|B82|Frýdek-Místek||
|82|C|C82|OSSZ Frýdek-Místek||
|83|A|A83|887||
|83|B|B83|Karviná||
|83|C|C83|OSSZ Karviná||
|84|A|A84|888||
|84|B|B84|Nový Jičín||
|84|C|C84|OSSZ Nový Jičín||
|85|A|A85|889||
|85|B|B85|Olomouc||
|85|C|C85|OSSZ Olomouc||
|86|A|A86|890||
|86|B|B86|Opava||
|86|C|C86|OSSZ Opava||
|87|A|A87|891||
|87|B|B87|Ostrava||
|87|C|C87|OSSZ Ostrava||
|88|A|A88|892||
|88|B|B88|Přerov||
|88|C|C88|OSSZ Přerov||
|89|A|A89|893||
|89|B|B89|Šumperk||
|89|C|C89|OSSZ Šumperk||
|90|A|A90|894||
|90|B|B90|Vsetín||
|90|C|C90|OSSZ Vsetín||

## CIS GFŘ pracoviště

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Číslo pracoviště||
|1|B|B1|Nadřízené pracoviště||
|1|C|C1|Název pracoviště||
|1|E|E1|Zdroj:||
|1|F|F1|GFŘ||
|1|H|H1|SLOVNÍK||
|2|A|A2|2000||
|2|B|B2|2000||
|2|C|C2|Finanční úřad pro hlavní město Prahu||
|2|E|E2|Popis:||
|2|F|F2|Číselník pracovišť GFŘ||
|3|A|A3|2001||
|3|B|B3|2000||
|3|C|C3|Územní pracoviště pro Prahu 1||
|3|E|E3|URL:||
|4|A|A4|2002||
|4|B|B4|2000||
|4|C|C4|Územní pracoviště pro Prahu 2||
|4|E|E4|Poznámka:||
|4|F|F4|Slouží jako podklad jak pro nadřazený úřad, tak pro podřízené pracoviště||
|5|A|A5|2003||
|5|B|B5|2000||
|5|C|C5|Územní pracoviště pro Prahu 3||
|6|A|A6|2004||
|6|B|B6|2000||
|6|C|C6|Územní pracoviště pro Prahu 4||
|7|A|A7|2005||
|7|B|B7|2000||
|7|C|C7|Územní pracoviště pro Prahu 5||
|8|A|A8|2006||
|8|B|B8|2000||
|8|C|C8|Územní pracoviště pro Prahu 6||
|9|A|A9|2007||
|9|B|B9|2000||
|9|C|C9|Územní pracoviště pro Prahu 7||
|10|A|A10|2008||
|10|B|B10|2000||
|10|C|C10|Územní pracoviště pro Prahu 8||
|11|A|A11|2009||
|11|B|B11|2000||
|11|C|C11|Územní pracoviště pro Prahu 9||
|12|A|A12|2010||
|12|B|B12|2000||
|12|C|C12|Územní pracoviště pro Prahu 10||
|13|A|A13|2011||
|13|B|B13|2000||
|13|C|C13|Územní pracoviště pro Prahu - Jižní Město||
|14|A|A14|2012||
|14|B|B14|2000||
|14|C|C14|Územní pracoviště v Praze - Modřanech||
|15|A|A15|2100||
|15|B|B15|2100||
|15|C|C15|Finanční úřad pro Středočeský kraj||
|16|A|A16|2101||
|16|B|B16|2100||
|16|C|C16|Územní pracoviště Praha – východ||
|17|A|A17|2102||
|17|B|B17|2100||
|17|C|C17|Územní pracoviště Praha – západ||
|18|A|A18|2103||
|18|B|B18|2100||
|18|C|C18|Územní pracoviště v Benešově||
|19|A|A19|2104||
|19|B|B19|2100||
|19|C|C19|Územní pracoviště v Berouně||
|20|A|A20|2105||
|20|B|B20|2101||
|20|C|C20|Územní pracoviště v Brandýse n L - Staré Boleslavi||
|21|A|A21|2106||
|21|B|B21|2113||
|21|C|C21|Územní pracoviště v Čáslavi||
|22|A|A22|2109||
|22|B|B22|2104||
|22|C|C22|Územní pracoviště v Hořovicích||
|23|A|A23|2110||
|23|B|B23|2100||
|23|C|C23|Územní pracoviště v Kladně||
|24|A|A24|2111||
|24|B|B24|2100||
|24|C|C24|Územní pracoviště v Kolíně||
|25|A|A25|2112||
|25|B|B25|2114||
|25|C|C25|Územní pracoviště v Kralupech nad Vltavou||
|26|A|A26|2113||
|26|B|B26|2100||
|26|C|C26|Územní pracoviště v Kutné Hoře||
|27|A|A27|2114||
|27|B|B27|2100||
|27|C|C27|Územní pracoviště v Mělníce||
|28|A|A28|2115||
|28|B|B28|2100||
|28|C|C28|Územní pracoviště v Mladé Boleslavi||
|29|A|A29|2118||
|29|B|B29|2100||
|29|C|C29|Územní pracoviště v Nymburku||
|30|A|A30|2119||
|30|B|B30|2118||
|30|C|C30|Územní pracoviště v Poděbradech||
|31|A|A31|2120||
|31|B|B31|2100||
|31|C|C31|Územní pracoviště v Příbrami||
|32|A|A32|2121||
|32|B|B32|2100||
|32|C|C32|Územní pracoviště v Rakovníku||
|33|A|A33|2122||
|33|B|B33|2100||
|33|C|C33|Územní pracoviště v Říčanech||
|34|A|A34|2124||
|34|B|B34|2110||
|34|C|C34|Územní pracoviště ve Slaném||
|35|A|A35|2125||
|35|B|B35|2103||
|35|C|C35|Územní pracoviště ve Vlašimi||
|36|A|A36|2200||
|36|B|B36|2200||
|36|C|C36|Finanční úřad pro Jihočeský kraj||
|37|A|A37|2201||
|37|B|B37|2200||
|37|C|C37|Územní pracoviště v Českých Budějovicích||
|38|A|A38|2203||
|38|B|B38|2200||
|38|C|C38|Územní pracoviště v Českém Krumlově||
|39|A|A39|2205||
|39|B|B39|2200||
|39|C|C39|Územní pracoviště v Jindřichově Hradci||
|40|A|A40|2208||
|40|B|B40|2200||
|40|C|C40|Územní pracoviště v Písku||
|41|A|A41|2209||
|41|B|B41|2200||
|41|C|C41|Územní pracoviště v Prachaticích||
|42|A|A42|2211||
|42|B|B42|2200||
|42|C|C42|Územní pracoviště ve Strakonicích||
|43|A|A43|2212||
|43|B|B43|2200||
|43|C|C43|Územní pracoviště v Táboře||
|44|A|A44|2300||
|44|B|B44|2300||
|44|C|C44|Finanční úřad pro Plzeňský kraj||
|45|A|A45|2301||
|45|B|B45|2300||
|45|C|C45|Územní pracoviště v Plzni||
|46|A|A46|2302||
|46|B|B46|2300||
|46|C|C46|Územní pracoviště Plzeň - sever||
|47|A|A47|2303||
|47|B|B47|2300||
|47|C|C47|Územní pracoviště Plzeň - jih||
|48|A|A48|2305||
|48|B|B48|2300||
|48|C|C48|Územní pracoviště v Domažlicích||
|49|A|A49|2308||
|49|B|B49|2300||
|49|C|C49|Územní pracoviště v Klatovech||
|50|A|A50|2312||
|50|B|B50|2300||
|50|C|C50|Územní pracoviště v Rokycanech||
|51|A|A51|2313||
|51|B|B51|2300||
|51|C|C51|Územní pracoviště v Tachově||
|52|A|A52|2400||
|52|B|B52|2400||
|52|C|C52|Finanční úřad pro Karlovarský kraj||
|53|A|A53|2401||
|53|B|B53|2400||
|53|C|C53|Územní pracoviště v Karlových Varech||
|54|A|A54|2403||
|54|B|B54|2400||
|54|C|C54|Územní pracoviště v Chebu||
|55|A|A55|2407||
|55|B|B55|2400||
|55|C|C55|Územní pracoviště v Sokolově||
|56|A|A56|2500||
|56|B|B56|2500||
|56|C|C56|Finanční úřad pro Ústecký kraj||
|57|A|A57|2501||
|57|B|B57|2500||
|57|C|C57|Územní pracoviště v Ústí nad Labem||
|58|A|A58|2503||
|58|B|B58|2500||
|58|C|C58|Územní pracoviště v Děčíně||
|59|A|A59|2504||
|59|B|B59|2500||
|59|C|C59|Územní pracoviště v Chomutově||
|60|A|A60|2505||
|60|B|B60|2504||
|60|C|C60|Územní pracoviště v Kadani||
|61|A|A61|2507||
|61|B|B61|2500||
|61|C|C61|Územní pracoviště v Litoměřicích||
|62|A|A62|2509||
|62|B|B62|2500||
|62|C|C62|Územní pracoviště v Lounech||
|63|A|A63|2510||
|63|B|B63|2500||
|63|C|C63|Územní pracoviště v Mostě||
|64|A|A64|2512||
|64|B|B64|2507||
|64|C|C64|Územní pracoviště v Roudnici nad Labem||
|65|A|A65|2513||
|65|B|B65|2503||
|65|C|C65|Územní pracoviště v Rumburku||
|66|A|A66|2514||
|66|B|B66|2500||
|66|C|C66|Územní pracoviště v Teplicích||
|67|A|A67|2515||
|67|B|B67|2509||
|67|C|C67|Územní pracoviště v Žatci||
|68|A|A68|2600||
|68|B|B68|2600||
|68|C|C68|Finanční úřad pro Liberecký kraj||
|69|A|A69|2601||
|69|B|B69|2600||
|69|C|C69|Územní pracoviště v Liberci||
|70|A|A70|2602||
|70|B|B70|2600||
|70|C|C70|Územní pracoviště v České Lípě||
|71|A|A71|2604||
|71|B|B71|2600||
|71|C|C71|Územní pracoviště v Jablonci nad Nisou||
|72|A|A72|2607||
|72|B|B72|2600||
|72|C|C72|Územní pracoviště v Semilech||
|73|A|A73|2609||
|73|B|B73|2607||
|73|C|C73|Územní pracoviště v Turnově||
|74|A|A74|2700||
|74|B|B74|2700||
|74|C|C74|Finanční úřad pro Královéhradecký kraj||
|75|A|A75|2701||
|75|B|B75|2700||
|75|C|C75|Územní pracoviště v Hradci Králové||
|76|A|A76|2707||
|76|B|B76|2700||
|76|C|C76|Územní pracoviště v Jičíně||
|77|A|A77|2709||
|77|B|B77|2700||
|77|C|C77|Územní pracoviště v Náchodě||
|78|A|A78|2712||
|78|B|B78|2700||
|78|C|C78|Územní pracoviště v Rychnově nad Kněžnou||
|79|A|A79|2713||
|79|B|B79|2700||
|79|C|C79|Územní pracoviště v Trutnově||
|80|A|A80|2800||
|80|B|B80|2800||
|80|C|C80|Finanční úřad pro Pardubický kraj||
|81|A|A81|2801||
|81|B|B81|2800||
|81|C|C81|Územní pracoviště v Pardubicích||
|82|A|A82|2804||
|82|B|B82|2800||
|82|C|C82|Územní pracoviště v Chrudimi||
|83|A|A83|2808||
|83|B|B83|2800||
|83|C|C83|Územní pracoviště ve Svitavách||
|84|A|A84|2809||
|84|B|B84|2800||
|84|C|C84|Územní pracoviště v Ústí nad Orlicí||
|85|A|A85|2810||
|85|B|B85|2809||
|85|C|C85|Územní pracoviště ve Vysokém Mýtě||
|86|A|A86|2811||
|86|B|B86|2800||
|86|C|C86|Územní pracoviště v Žamberku||
|87|A|A87|2900||
|87|B|B87|2900||
|87|C|C87|Finanční úřad pro Kraj Vysočina||
|88|A|A88|2901||
|88|B|B88|2900||
|88|C|C88|Územní pracoviště v Jihlavě||
|89|A|A89|2903||
|89|B|B89|2900||
|89|C|C89|Územní pracoviště v Havlíčkově Brodě||
|90|A|A90|2910||
|90|B|B90|2900||
|90|C|C90|Územní pracoviště v Pelhřimově||
|91|A|A91|2912||
|91|B|B91|2900||
|91|C|C91|Územní pracoviště v Třebíči||
|92|A|A92|2913||
|92|B|B92|2900||
|92|C|C92|Územní pracoviště ve Velkém Meziříčí||
|93|A|A93|2914||
|93|B|B93|2900||
|93|C|C93|Územní pracoviště ve Žďáru nad Sázavou||
|94|A|A94|3000||
|94|B|B94|3000||
|94|C|C94|Finanční úřad pro Jihomoravský kraj||
|95|A|A95|3001||
|95|B|B95|3000||
|95|C|C95|Územní pracoviště Brno I||
|96|A|A96|3002||
|96|B|B96|3000||
|96|C|C96|Územní pracoviště Brno II||
|97|A|A97|3003||
|97|B|B97|3000||
|97|C|C97|Územní pracoviště Brno III||
|98|A|A98|3004||
|98|B|B98|3000||
|98|C|C98|Územní pracoviště Brno IV||
|99|A|A99|3005||
|99|B|B99|3000||
|99|C|C99|Územní pracoviště Brno-venkov||
|100|A|A100|3006||
|100|B|B100|3000||
|100|C|C100|Územní pracoviště v Blansku||
|101|A|A101|3007||
|101|B|B101|3006||
|101|C|C101|Územní pracoviště v Boskovicích||
|102|A|A102|3008||
|102|B|B102|3000||
|102|C|C102|Územní pracoviště v Břeclavi||
|103|A|A103|3010||
|103|B|B103|3000||
|103|C|C103|Územní pracoviště v Hodoníně||
|104|A|A104|3011||
|104|B|B104|3008||
|104|C|C104|Územní pracoviště v Hustopečích||
|105|A|A105|3013||
|105|B|B105|3000||
|105|C|C105|Územní pracoviště v Kyjově||
|106|A|A106|3018||
|106|B|B106|3013||
|106|C|C106|Územní pracoviště ve Veselí nad Moravou||
|107|A|A107|3019||
|107|B|B107|3000||
|107|C|C107|Územní pracoviště ve Vyškově||
|108|A|A108|3020||
|108|B|B108|3000||
|108|C|C108|Územní pracoviště ve Znojmě||
|109|A|A109|3100||
|109|B|B109|3100||
|109|C|C109|Finanční úřad pro Olomoucký kraj||
|110|A|A110|3101||
|110|B|B110|3100||
|110|C|C110|Územní pracoviště v Olomouci||
|111|A|A111|3102||
|111|B|B111|3107||
|111|C|C111|Územní pracoviště v Hranicích||
|112|A|A112|3103||
|112|B|B112|3100||
|112|C|C112|Územní pracoviště v Jeseníku||
|113|A|A113|3106||
|113|B|B113|3100||
|113|C|C113|Územní pracoviště v Prostějově||
|114|A|A114|3107||
|114|B|B114|3100||
|114|C|C114|Územní pracoviště v Přerově||
|115|A|A115|3108||
|115|B|B115|3101||
|115|C|C115|Územní pracoviště ve Šternberku||
|116|A|A116|3109||
|116|B|B116|3100||
|116|C|C116|Územní pracoviště v Šumperku||
|117|A|A117|3110||
|117|B|B117|3109||
|117|C|C117|Územní pracoviště v Zábřehu||
|118|A|A118|3200||
|118|B|B118|3200||
|118|C|C118|Finanční úřad pro Moravskoslezský kraj||
|119|A|A119|3201||
|119|B|B119|3200||
|119|C|C119|Územní pracoviště Ostrava I||
|120|A|A120|3202||
|120|B|B120|3200||
|120|C|C120|Územní pracoviště Ostrava II||
|121|A|A121|3203||
|121|B|B121|3200||
|121|C|C121|Územní pracoviště Ostrava III||
|122|A|A122|3205||
|122|B|B122|3200||
|122|C|C122|Územní pracoviště v Bruntále||
|123|A|A123|3207||
|123|B|B123|3200||
|123|C|C123|Územní pracoviště ve Frýdku-Místku||
|124|A|A124|3210||
|124|B|B124|3212||
|124|C|C124|Územní pracoviště v Havířově||
|125|A|A125|3212||
|125|B|B125|3200||
|125|C|C125|Územní pracoviště v Karviné||
|126|A|A126|3213||
|126|B|B126|3215||
|126|C|C126|Územní pracoviště v Kopřivnici||
|127|A|A127|3214||
|127|B|B127|3205||
|127|C|C127|Územní pracoviště v Krnově||
|128|A|A128|3215||
|128|B|B128|3200||
|128|C|C128|Územní pracoviště v Novém Jičíně||
|129|A|A129|3216||
|129|B|B129|3200||
|129|C|C129|Územní pracoviště v Opavě||
|130|A|A130|3218||
|130|B|B130|3207||
|130|C|C130|Územní pracoviště v Třinci||
|131|A|A131|3300||
|131|B|B131|3300||
|131|C|C131|Finanční úřad pro Zlínský kraj||
|132|A|A132|3301||
|132|B|B132|3300||
|132|C|C132|Územní pracoviště ve Zlíně||
|133|A|A133|3304||
|133|B|B133|3300||
|133|C|C133|Územní pracoviště v Kroměříži||
|134|A|A134|3306||
|134|B|B134|3301||
|134|C|C134|Územní pracoviště v Otrokovicích||
|135|A|A135|3307||
|135|B|B135|3310||
|135|C|C135|Územní pracoviště v Rožnově pod Radhoštěm||
|136|A|A136|3308||
|136|B|B136|3309||
|136|C|C136|Územní pracoviště v Uherském Brodě||
|137|A|A137|3309||
|137|B|B137|3300||
|137|C|C137|Územní pracoviště v Uherském Hradišti||
|138|A|A138|3310||
|138|B|B138|3300||
|138|C|C138|Územní pracoviště ve Valašském Meziříčí||
|139|A|A139|3312||
|139|B|B139|3300||
|139|C|C139|Územní pracoviště ve Vsetíně||
|140|A|A140|4000||
|140|B|B140|4000||
|140|C|C140|Specializovaný finanční úřad||
|141|A|A141|7000||
|141|B|B141|7000||
|141|C|C141|Generální finanční ředitelství||

## CIS Typ podání

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|Eviden||
|1|G|G1|SLOVNÍK||
|2|A|A2|R||
|2|B|B2|řádné||
|2|D|D2|Popis:||
|3|A|A3|O||
|3|B|B3|opravné||
|3|D|D3|URL:||
|4|A|A4|S||
|4|B|B4|storno||

## CIS Typ akce

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|MPSV||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Registrace zaměstnance - Nástup do zaměstnání, Oznámení o zahájení přípravy pro zaměstnání, Oznámení o zahájení PPV jiného než základního||
|2|D|D2|Popis:||
|2|E|E2|Číselník akcí formuláře, částečně přebírá hodnoty původního ONZ||
|3|A|A3|2||
|3|B|B3|Registrace zaměstnance - Skončení zaměstnání, Oznámení o skončení přípravy pro zaměstnání, Oznámení o skončení PPV jiného než základního  ||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|Registrace zaměstnance - Změna údajů zaměstnance||
|5|A|A5|4||
|5|B|B5|Registrace zaměstnance - Oprava chybných údajů zaměstnance||
|6|A|A6|5||
|6|B|B6|Registrace zaměstnance - Převod zaměstnance k jinému VS||
|7|A|A7|6||
|7|B|B7|Registrace zaměstnance - Vznik příslušnosti k českým právním předpisům||
|8|A|A8|7||
|8|B|B8|Registrace zaměstnance - Skončení příslušnosti k českým právním předpisům||
|9|A|A9|8||
|9|B|B9|Storno (výmaz) zaměstnání, přípravy pro zaměstnání, PPV jiného než základního||

## CIS Typ formuláře

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|Eviden||
|1|G|G1|SLOVNÍK||
|2|A|A2|R||
|2|B|B2|řádný||
|2|D|D2|Popis:||
|3|A|A3|O||
|3|B|B3|opravný||
|3|D|D3|URL:||
|4|A|A4|S||
|4|B|B4|storno||

## CIS Stav formuláře

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|Eviden||
|1|G|G1|SLOVNÍK||
|2|A|A2|P||
|2|B|B2|přijato||
|2|D|D2|Popis:||
|3|A|A3|O||
|3|B|B3|odmítnuto||
|3|D|D3|URL:||
|4|A|A4|C||
|4|B|B4|čekající na ztotožnění||

## CIS Důvod odmítnutí

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|Eviden||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Chybí element {0}.||
|2|D|D2|Popis:||
|2|E|E2|Důvod odmítnutí podání / formuláře||
|3|A|A3|2||
|3|B|B3|Položka {0} ({1}) je povinná.||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|Položka {0} ({1}) neobsahuje povolenou numerickou hodnotu.||
|4|D|D4|Poznámka:||
|5|A|A5|4||
|5|B|B5|Položka {0} ({1}) nesplňuje omezení na délku hodnoty (povolená délka: {2} znaků).||
|6|A|A6|5||
|6|B|B6|Položka {0} ({1}) obsahuje nepovolené znaky (nepovolený znak: {2}=0x{3:x8}).||
|7|A|A7|6||
|7|B|B7|Položka {0} ({1}) neobsahuje povolenou číselníkovou hodnotu.||
|8|A|A8|7||
|8|B|B8|Položka {0} ({1}) nesplňuje restrikce na přípustné hodnoty (není to datum).||
|9|A|A9|8||
|9|B|B9|Položka {0} ({1}) je datum vyšší než aktuální.||
|10|A|A10|9||
|10|B|B10|Položka {0}; ({1}) obsahuje nepovolenou hodnotu. Povolené hodnoty: {2}.||
|11|A|A11|10||
|11|B|B11|Chybný jmenný prostor (očekáváno {0}).||
|12|A|A12|11||
|12|B|B12|Datum od" položky {0} ({1}) je větší než "datum do" položky {2} ({3}).||
|13|A|A13|12||
|13|B|B13|Čas od" položky {0} ({1}) je větší než "čas do" položky {2} ({3}).||
|14|A|A14|13||
|14|B|B14|Datum v položce {0} ({1}) je vyšší než aktuální datum.||
|15|A|A15|14||
|15|B|B15|Chybějící nebo neznámý typ dokumentu.||
|16|A|A16|16||
|16|B|B16|Položka {0} ({1}) musí být v intervalu {2} - {3} včetně.||
|17|A|A17|17||
|17|B|B17|Položka {0} musí být větší než {1}.||
|18|A|A18|18||
|18|B|B18|Položka {0} musí být větší než nebo rovná {1}.||
|19|A|A19|19||
|19|B|B19|Neplatné IČPE v položce {0}.||
|20|A|A20|20||
|20|B|B20|Pouze jedna z položek ({0}) smí mít hodnotu A.||
|21|A|A21|21||
|21|B|B21|Alespoň jedna z položek ({0}) musí mít hodnotu  A.||
|22|A|A22|22||
|22|B|B22|Pro IČPE (které je součástí položky Číslo rozhodnutí) neprošla kontrola podle 8. kontrolní číslice (Luhnův algoritmus).||
|23|A|A23|23||
|23|B|B23|Položka {0} se vyskytuje v DV i když logicky nemá.||
|24|A|A24|24||
|24|B|B24|Hodnota položky {0} nemůže být záporná.||
|25|A|A25|25||
|25|B|B25|Položka {0} musí mít max. {1} desetinných míst.||
|26|A|A26|26||
|26|B|B26|Podání nelze přijmout k dalšímu zpracování||
|27|A|A27|27||
|27|B|B27|Neplatné IČPE {0} {1}.||
|28|A|A28|61||
|28|B|B28|Text z XML/XSD validace…||
|29|A|A29|62||
|29|B|B29|Podání musí obsahovat právě jeden formulář.||
|30|A|A30|63||
|30|B|B30|Variabilní symbol z GovTalk obálky {0} není shodný s VS ve formuláři.||
|31|A|A31|64||
|31|B|B31|Datová věta neobsahuje ani jeden záznam.||
|32|A|A32|17804||
|32|B|B32|Blok datové věty nebyl nalezen.||
|33|A|A33|17805||
|33|B|B33|Nepodařilo se dekódovat data.||
|34|A|A34|17807||
|34|B|B34|Nepodařilo se dekódovat podpis.||
|35|A|A35|17806||
|35|B|B35|Neznámá verze obálky nebo nezašifrovaná data.||
|36|A|A36|17801||
|36|B|B36|Neplatná obálka ČSSZ.||
|37|A|A37|17803||
|37|B|B37|Podpis datové věty nebyl nalezen.||
|38|A|A38|17808||
|38|B|B38|Neplatné číslo verze obálky ČSSZ.||
|39|A|A39|17820||
|39|B|B39|Při ověřování podpisu došlo k chybě.||
|40|A|A40|17835||
|40|B|B40|Nepodařilo se dekomprimovat data.||
|41|A|A41|17810||
|41|B|B41|Při dešifrování došlo k chybě.||
|42|A|A42|17814||
|42|B|B42|E-podání mohlo být zasláno zastaralou verzí programu nebo se e-podání nepodařilo dešifrovat.||
|43|A|A43|17833||
|43|B|B43|Při ověřování certifikátu použitého k podpisu došlo k chybě.||
|44|A|A44|17824||
|44|B|B44|Při ověřování podpisu došlo k chybě.||
|45|A|A45|17832||
|45|B|B45|Nepodařilo se načíst informace o certifikátu podpisu.||
|46|A|A46|17837||
|46|B|B46|Při pokusu o načtení dešifrovaných dat došlo k chybě.||
|47|A|A47|17836||
|47|B|B47|Struktura po dešifrování není XML.||
|48|A|A48|17840||
|48|B|B48|Vstupní datová věta je prázdná.||
|49|A|A49|17800||
|49|B|B49|Při zpracování podání došlo k nespecifikované chybě.||
|50|A|A50|17830||
|50|B|B50|Neplatný podpis (Pro podpis použitá lišící se datová věta).||
|51|A|A51|17839||
|51|B|B51|Certifikát použitý k podpisu obsahuje neplatné údaje.||
|52|A|A52|300||
|52|B|B52|Podání ČSSZ ID {0} je duplicitní. Nalezené duplicity: {1} ||
|53|A|A53|310||
|53|B|B53|Podání e-služby ({class}) není možné na ČSSZ podat pomocí vstupního kanálu ({source}). Kontaktujte pracovníka OSSZ.||
|54|A|A54|101||
|54|B|B54|Certifikát použitý k podpisu není platný kvalifikovaný certifikát.||
|55|A|A55|105||
|55|B|B55|Platnost vašeho podpisového klíče vypršela. Zajistěte si kvalifikovaný certifikát||
|56|A|A56|102||
|56|B|B56|Digitální podpis e-podání není platný.||
|57|A|A57|104||
|57|B|B57|Chyba při ověřování podpisu.||
|58|A|A58|103||
|58|B|B58|Pověření k dané e-službě ({class}) není zaznamenáno v registru podávajících na OSSZ nebo certifikát||
|59|A|A59|201||
|59|B|B59|Neplatný šifrovací certifikát.||
|60|A|A60|202||
|60|B|B60|Platnost certifikátu||
|61|A|A61|302||
|61|B|B61|Podání bylo vyhodnoceno jako duplicitní. Podrobnosti nejsou k dispozici.||
|62|A|A62|400||
|62|B|B62|Při zpracování podání došlo k chybě. Zkontrolujte data.||
|63|A|A63|305||
|63|B|B63|Počet formulářů v podání musí být mezi 1 až 1500||

## CIS Typ Odloženého příjmu

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|Nový číselník||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Příjem po skončení zaměstnaneckého poměru (např. vyplácení bonusů)||
|2|D|D2|Popis:||
|2|E|E2|Typ situace pro Odložený příjem||
|3|A|A3|2||
|3|B|B3|Náhrada mzdy při neplatném ukončení pracovního poměru - PPV dále neprobíhá||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|Náhrada mzdy při neplatném ukončení pracovního poměru - PPV dále probíhá||
|4|D|D4|Poznámka:||
|5|A|A5|4||
|5|B|B5|Roční zúčtování po skončení zaměstnaneckého poměru||
|6|A|A6|5||
|6|B|B6|Příjem po skončení zaměstnaneckého poměru + Roční zúčtování po skončení zaměstnaneckého poměru||
|7|A|A7|6||
|7|B|B7|Náhrada mzdy při neplatném ukončení pracovního poměru + Roční zúčtování po skončení zaměstnaneckého poměru||

## CIS Pořadí dítěte

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|Změnový požadavek ZP_TECH_POPIS_019 Finanční správy||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|první||
|2|D|D2|Popis:||
|2|E|E2|Pořadí dětí pro uplatnění daňového zvýhodnění na děti||
|3|A|A3|2||
|3|B|B3|druhé||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|třetí a další||
|4|D|D4|Poznámka:||
|5|A|A5|N||
|5|B|B5|neuplatněno||

## CIS Pohlaví

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|M||
|2|B|B2|mužské||
|2|D|D2|Popis:||
|2|E|E2|Číselník C_POHL||
|3|A|A3|Ž||
|3|B|B3|ženské||
|3|D|D3|URL:||
|3|E|E3|https://www.cssz.cz/documents/20143/179422/C_POHL.htm||

## CIS Typ daňové identifikace

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|GFŘ, Příloha č.2 VDA - mezinárodní výměna informací||
|1|G|G1|SLOVNÍK||
|2|A|A2|D||
|2|B|B2|DIČ||
|2|D|D2|Popis:||
|3|A|A3|R||
|3|B|B3|RČ||
|3|D|D3|URL:||
|4|A|A4|S||
|4|B|B4|Sociální pojištění||
|5|A|A5|J||
|5|B|B5|Jiné||

## CIS Stát

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|D|D1|Zdroj:||
|1|E|E1|ČSÚ||
|1|G|G1|SLOVNÍK||
|2|D|D2|Popis:||
|2|E|E2|Číselník zemí (CZEM)\nPředmětem Číselníku zemí (CZEM) (kód 1186) jsou samostatné země a závislá území světa a jejich numerické kódy.\nČíselník CZEM byl zaveden sdělením ČSÚ.\nČíselník CZEM vychází z mezinárodní normy ISO 3166-1.||
|3|D|D3|URL:||
|3|E|E3|https://apl2.czso.cz/iSMS/cisdata.jsp?kodcis=1186||

## CIS Typ dokladu

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|GFŘ, Příloha č.2 VDA - mezinárodní výměna informací||
|1|G|G1|SLOVNÍK||
|2|A|A2|I||
|2|B|B2|Průkaz totožnosti||
|2|D|D2|Popis:||
|2|E|E2|Seznam typů dokladu k prokázání totožnosti||
|3|A|A3|P||
|3|B|B3|Pas||
|3|D|D3|URL:||
|4|A|A4|O||
|4|B|B4|Ostatní||

## CIS Typ zdravotního omezení

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|Externí datová věta REGZEC||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|III. stupeň invalidity||
|2|D|D2|Popis:||
|3|A|A3|2||
|3|B|B3|III. stupeň invalidity - schopnost výdělečné činnosti za zcela mimořádných podmínek (§39 odst. 4 písm. f zákona č. 155/1995 Sb.) ||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|II. stupeň invalidity||
|4|D|D4|Poznámka: ||
|5|A|A5|4||
|5|B|B5|I. stupeň invalidity||
|6|A|A6|5||
|6|B|B6|Přiznaný POUZE statut OZZ (osoba zdravotně znevýhodněná)||

## CIS Kategorie dosaženého vzdělá

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|C|C1|Zkrácený název||
|1|E|E1|Zdroj:||
|1|F|F1|MŠMT: BADV Kategorie dosaženého vzdělání podle KKOV||
|1|H|H1|SLOVNÍK||
|2|A|A2|A||
|2|B|B2|Bez vzdělání||
|2|C|C2|Bez vzdělání||
|2|E|E2|Popis:||
|2|F|F2|Číselník BADV Kategorie dosaženého vzdělání podel KKOV||
|3|A|A3|B||
|3|B|B3|Neúplné základní vzdělání||
|3|C|C3|Neúplné základní vzdělání||
|3|E|E3|URL:||
|3|F|F3|URL||
|4|A|A4|C||
|4|B|B4|Základní vzdělání||
|4|C|C4|Základní vzdělání||
|4|E|E4|Poznámka: ||
|4|F|F4|Výsledný kód oboru vzdělání by měl být převeden do klasifikace CZ-ISCED 2011 https://www.czso.cz/csu/czso/klasifikace_vzdelani_cz_isced_2011||
|5|A|A5|D||
|5|B|B5|Nižší střední vzdělání||
|5|C|C5|Nižší střední vzdělání||
|6|A|A6|E||
|6|B|B6|Nižší střední odborné vzdělání||
|6|C|C6|Nižší střed.odbor.vzděl.||
|7|A|A7|H||
|7|B|B7|Střední odborné vzdělání s výučním listem||
|7|C|C7|Stř.odb.vzd.s výuč.listem||
|8|A|A8|J||
|8|B|B8|Střední nebo střední odborné vzdělání bez maturity i výučního listu||
|8|C|C8|Stř./stř.odb.bez Mat.a VL||
|9|A|A9|K||
|9|B|B9|Úplné střední všeobecné vzdělání||
|9|C|C9|Úplné stř.všeob.vzdělání||
|10|A|A10|L||
|10|B|B10|Úplné střední odborné vzdělání s vyučením i maturitou||
|10|C|C10|Úpl.stř.odb.vzd.s VL i Ma||
|11|A|A11|M||
|11|B|B11|Úplné střední odborné vzdělání s maturitou (bez vyučení)||
|11|C|C11|Úpl.stř.odb.vz.s M bez VL||
|12|A|A12|N||
|12|B|B12|Vyšší odborné vzdělání||
|12|C|C12|Vyšší odborné vzdělání||
|13|A|A13|P||
|13|B|B13|Vyšší odborné vzdělání v konzervatoři||
|13|C|C13|Vyšší odb.vzd.konzervatoř||
|14|A|A14|R||
|14|B|B14|Vysokoškolské bakalářské vzdělání||
|14|C|C14|VŠ bakalářské vzdělání||
|15|A|A15|T||
|15|B|B15|Vysokoškolské magisterské vzdělání||
|15|C|C15|Vysokoškolské mag.vzděl.||
|16|A|A16|V||
|16|B|B16|Vysokoškolské doktorské vzdělání||
|16|C|C16|Vysokoškolské dokt.vzděl.||

## CIS Specifikace cizozemského no

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|P||
|2|B|B2|poslední||
|2|D|D2|Popis:||
|3|A|A3|S||
|3|B|B3|současný||
|3|D|D3|URL:||
|3|E|E3|https://www.cssz.cz/documents/20143/179422/C_SCIP.htm||
|4|A|A4|N||
|4|B|B4|není||

## CIS Sektor

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|Číselník EESSI - Sektor||
|1|G|G1|SLOVNÍK||
|2|A|A2|01||
|2|B|B2|Pracovní úrazy nemoci z povolání||
|2|D|D2|Popis:||
|2|E|E2|Číselník EESSI - Sektor (pro Zahraniční PIN) ||
|3|A|A3|02||
|3|B|B3|Rodinné dávky||
|3|D|D3|URL:||
|4|A|A4|03||
|4|B|B4|Vše||
|5|A|A5|04||
|5|B|B5|Důchody||
|6|A|A6|05||
|6|B|B6|Vymáhání a zápočty||
|7|A|A7|06||
|7|B|B7|Nemoc||
|8|A|A8|07||
|8|B|B8|Dávky v nezaměstnanosti||
|9|A|A9|08||
|9|B|B9|jiné||

## CIS Zdravotní pojišťovny

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|D|D2|Popis:||
|2|E|E2|C_ZPOJ||
|3|D|D3|URL:||
|3|E|E3|URL||

## CIS Důvod pro volný přístup na 

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|MPSV||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|§ 87 Občan EU/EHP a Švýcarska||
|2|D|D2|Popis:||
|3|A|A3|2||
|3|B|B3|§ 87 Občan Spojeného království Velké Británie a Severního Irska (beneficient výstupové dohody)||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|§ 87 Rodinný příslušník občana EU/EHP nebo Švýcarska (včetně ČR) ||
|5|A|A5|4||
|5|B|B5|§ 98 písm. a) Povolen trvalý pobyt - dočasná ochrana Ukrajina||
|6|A|A6|5||
|6|B|B6|§ 98 písm. a) Povolen trvalý pobyt - mimo ochranu Ukrajina||
|7|A|A7|6||
|7|B|B7|§ 98 písm. b): Rodinný příslušník člena diplomatické mise ||
|8|A|A8|7||
|8|B|B8|§ 98 písm. c) Udělen azyl nebo doplňková ochrana||
|9|A|A9|8||
|9|B|B9|§ 98 písm. d) Krátkodobá prac. činnost (do 7 dnů)||
|10|A|A10|9||
|10|B|B10|§ 98 písm. e) Mezinárodní smlouva||
|11|A|A11|10||
|11|B|B11|§ 98 písm. j) Příprava na budoucí povolání||
|12|A|A12|11||
|12|B|B12|§ 98 písm. l): Dlouhodobý pobyt za účelem společného soužití rodiny||
|13|A|A13|12||
|13|B|B13|§ 98 písm. m) Rezident jiného státu EU||
|14|A|A14|13||
|14|B|B14|§ 98 písm. n): Soustavná vzdělávací nebo vědecká činnost||
|15|A|A15|14||
|15|B|B15|§ 98 písm. o) Získané SŠ, VOŠ nebo VŠ vzdělání||
|16|A|A16|15||
|16|B|B16|§ 98 písm. p) Dlouhodobý pobyt za účelem ochrany||
|17|A|A17|16||
|17|B|B17|§ 98 písm. r) Duchovní církve registrované v ČR||
|18|A|A18|17||
|18|B|B18|§ 98 písm. s) Vnitropodnikově převedený zaměstnanec (z EU)||
|19|A|A19|18||
|19|B|B19|§ 98 písm. t) výkon práce v zájmu ČR||
|20|A|A20|19||
|20|B|B20|§ 98 písm. u): Občan státu nevyžadujícího pracovní oprávnění (whitelist)||
|21|A|A21|20||
|21|B|B21|§ 98 písm. v): Umělecká činnost||
|22|A|A22|21||
|22|B|B22|§ 98a Vyslání - zvyšování dovedností||

## CIS Druh pracovního oprávnění

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód||
|1|B|B1|Název pobočky||
|1|D|D1|Zdroj:||
|1|E|E1|Externí datová věta REGZEC||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|povolení k zaměstnání||
|2|D|D2|Popis:||
|3|A|A3|2||
|3|B|B3|zaměstnanecká karta||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|karta vnitropodnikově převedeného zaměstnance||
|5|A|A5|4||
|5|B|B5|modrá karta||

## CIS Krajské pobočky ÚP ČR

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód||
|1|B|B1|Název pobočky||
|1|D|D1|Zdroj:||
|1|E|E1|ÚP ČR||
|1|G|G1|SLOVNÍK||
|2|A|A2|HMP||
|2|B|B2|Krajská pobočka pro hlavní město Prahu||
|2|D|D2|Popis:||
|2|E|E2|Číselník krajských poboček ÚP ČR, hodnoty a kód položky převzaty ze záložky z originální datové věty||
|3|A|A3|JMK||
|3|B|B3|Krajská pobočka v Brně||
|3|D|D3|URL:||
|4|A|A4|JCK||
|4|B|B4|Krajská pobočka v Českých Budějovicích||
|5|A|A5|HKK||
|5|B|B5|Krajská pobočka v Hradci Králové||
|6|A|A6|VYK||
|6|B|B6|Krajská pobočka v Jihlavě||
|7|A|A7|KVK||
|7|B|B7|Krajská pobočka v Karlových Varech||
|8|A|A8|LBK||
|8|B|B8|Krajská pobočka v Liberci||
|9|A|A9|OLK||
|9|B|B9|Krajská pobočka v Olomouci||
|10|A|A10|MSK||
|10|B|B10|Krajská pobočka v Ostravě||
|11|A|A11|PAK||
|11|B|B11|Krajská pobočka v Pardubicích||
|12|A|A12|PMK||
|12|B|B12|Krajská pobočka v Plzni||
|13|A|A13|SCK||
|13|B|B13|Krajská pobočka v Příbrami||
|14|A|A14|ULK||
|14|B|B14|Krajská pobočka v Ústí nad Labem||
|15|A|A15|ZLK||
|15|B|B15|Krajská pobočka ve Zlíně||

## CIS Druh důchodu

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|starobní||
|2|D|D2|Popis:||
|2|E|E2|Hodnoty a kód položky převzaty ze záložky z originální datové věty||
|3|A|A3|2||
|3|B|B3|invalidní 3. stupně||
|3|D|D3|URL:||
|4|A|A4|8||
|4|B|B4|invalidní 1. nebo 2. stupně||
|5|A|A5|A||
|5|B|B5|cizí charakteru starobního||
|6|A|A6|B||
|6|B|B6|cizí charakteru invalidního 3. stupně||
|7|A|A7|C||
|7|B|B7|cizí charakteru invalidního 1. nebo 2. stupně||

## CIS Typ přihlášky

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Zaměstnavatel||
|2|D|D2|Popis:||
|2|E|E2|Formulář Přihláška do registru zaměstnavatelů||
|3|A|A3|2||
|3|B|B3|Mzdová účtárna||
|3|D|D3|URL:||

## CIS Typ zaměstnavatele

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Právnická osoba||
|2|D|D2|Popis:||
|2|E|E2|Formulář Přihláška do registru zaměstnavatelů||
|3|A|A3|2||
|3|B|B3|Fyzická osoba podnikající||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|Fyzická osoba nepodnikající||

## CIS Typ odhlášky

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Zaměstnavatel||
|2|D|D2|Popis:||
|2|E|E2|Formulář Odhláška z registru zaměstnavatelů||
|3|A|A3|2||
|3|B|B3|Mzdová účtárna||
|3|D|D3|URL:||

## CIS Kódy bank

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČNB||
|1|G|G1|SLOVNÍK||
|2|D|D2|Popis:||
|2|E|E2|Číselník kódů bank||
|3|D|D3|URL:||
|3|E|E3|https://www.cnb.cz/export/sites/cnb/cs/platebni-styk/.galleries/ucty_kody_bank/download/kody_bank_CR.pdf||

## CIS Klasifikace ekonomických či

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSÚ||
|1|G|G1|SLOVNÍK||
|2|D|D2|Popis:||
|2|E|E2|Klasifikace ekonomických činností||
|3|D|D3|URL:||
|3|E|E3|https://www.czso.cz/csu/czso/klasifikace_ekonomickych_cinnosti_cz_nace||
|4|D|D4|Poznámka:||

## CIS Rozhodná skutečnost

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|GFŘ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|smrt zůstavitele (§ 239b odst. 4 daňového řádu)||
|2|D|D2|Popis:||
|2|E|E2|Číselník rozhodných skutečností||
|3|A|A3|2||
|3|B|B3|zánik právnické osoby bez likvidace (§ 240a daňového řádu)||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|vstup právnické osoby do likvidace (§ 240c odst. 2 daňového řádu)||
|4|D|D4|Poznámka:||
|5|A|A5|4||
|5|B|B5|zpracování návrhu na použití likvidačního zůstatku (§ 240c odst. 3 daňového řádu)||
|6|A|A6|5||
|6|B|B6|zánik povinnosti odvést daň vybíranou srážkou před uplynutím kalendářního roku (§ 234 daňového řádu)||
|7|A|A7|6||
|7|B|B7|skončení řízení o pozůstalosti (§ 239b odst. 5 daňového řádu)||
|8|A|A8|7||
|8|B|B8|předložení řádné zprávy o zpeněžování majetku likvidační podstaty nebo jeho části soudu (§ 239c daňového řádu)||
|9|A|A9|8||
|9|B|B9|účinnost rozhodnutí o úpadku (§ 244 odst. 1 daňového řádu)||
|10|A|A10|9||
|10|B|B10|předložení konečné zprávy (§ 244 odst. 3 a 4 daňového řádu)||
|11|A|A11|10||
|11|B|B11|převod části privatizovaného majetku státního podniku (§ 240d daňového řádu)||
|12|A|A12|11||
|12|B|B12|ukončení správy svěřenského fondu (§ 240e odst. 2 daňového řádu) – účinnost od 1. 7. 2025||
|13|A|A13|12||
|13|B|B13|zánik svěřenského fondu (§ 240e odst. 3 daňového řádu) – účinnost od 1. 7. 2025||

## CIS Kolektivní smlouva

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|MPSV||
|1|G|G1|SLOVNÍK||
|2|A|A2|0||
|2|B|B2|neexistuje||
|2|D|D2|Popis:||
|2|E|E2|Číselník MPSV Kolektivní smlouvy, hodnoty a kód položky převzaty ze záložky z originální datové věty||
|3|A|A3|1||
|3|B|B3|podniková kolektivní smlouva||
|3|D|D3|URL:||
|4|A|A4|2||
|4|B|B4|Kolektivní smlouva vyššího stupně na základě členství zaměstnavatele v zaměstnavatelském svazu, který kolektivní smlouvu vyššího stupně uzavřel||
|5|A|A5|3||
|5|B|B5|Kolektivní smlouva vyššího stupně na základě rozšíření její závaznosti (podle § 7 zákona č. 2/1991 Sb. o kolektivním vyjednávání, ve znění pozdějších předpisů)||
|6|A|A6|4||
|6|B|B6|Kolektivní dohoda||
|7|A|A7|5||
|7|B|B7|Kolektivní dohoda vyššího stupně||

## CIS Hospodářská a finanční kont

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ISPV||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|plně ve veřejném vlastnictví||
|2|D|D2|Popis:||
|2|E|E2|Číselník ISPV, hodnoty a kód položky převzaty ze záložky z originální datové věty||
|3|A|A3|2||
|3|B|B3|plně v soukromém nebo družstevním vlastnictví||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|ve sdíleném vlastnictví s většinovým veřejným podílem||
|4|D|D4|Poznámka:||
|4|E|E4|Do veřejného vlastnictví patří společnosti ve vlastnictví státu, kraje, města, obce a společnosti zřízené na základě zvláštního zákona (církve, charity, vysoké školy, zdravotní pojišťovny, veřejnoprávní instiituce). U spolků je vlastnictví odvozeno od vlastnictví jednotlivých členů spolku, přičemž spolek tvořený fyzickými osobami je považován jako plně v soukromém nebo družstevním vlastnictví. U obecně prospěšných společností, ústavů, nadací, nadačních fondů, apod. je rozhodující vlastnictví zakladatelů, přičemž pokud jsou zakladateli fyzické osoby, je uvedená společnost plně v soukromém nebo družstevním vlastnictví.||
|5|A|A5|4||
|5|B|B5|ve většinovém vlastnictví s většinovým soukromým nebo družstevním podílem||

## CIS Obce

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|GFŘ||
|1|G|G1|SLOVNÍK||
|2|D|D2|Popis:||
|2|E|E2|Šestimístný kód, zdrojem je Vyhláška O procentním podílu jednotlivých obcí na částech celostátního hrubého výnosu daně z přidané hodnoty a daní z příjmů (přílohy č.1 VDA)||
|3|D|D3|URL:||
|3|E|E3|URL||

## CIS Nástroj (opatření)

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|C|C1|Popis položky||
|1|D|D1|Zdroj:||
|1|E|E1|Eviden||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|VPP||
|2|C|C2|§112 zákona o zaměstnanosti – veřejně prospěšné práce||
|2|D|D2|Popis:||
|2|E|E2|Nástroj (opatření) / formuláře||
|3|A|A3|2||
|3|B|B3|SÚPM||
|3|C|C3|§113 zákona o zaměstnanosti – společensky účelné pracovní místo vyhrazené||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|sdílené pracovní místo||
|4|C|C4|§ 106 zákona o zaměstnanosti - sdílené pracovní místo ||
|4|D|D4|Poznámka:||
|5|A|A5|4||
|5|B|B5|ostatní mzdové příspěvky||
|5|C|C5|ostatní mzdové nástroje||

## CIS Klasifikace v zaměstnání

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSÚ||
|1|G|G1|SLOVNÍK||
|2|D|D2|Popis:||
|2|E|E2|Klasifikace zaměstnání CZ-ISCO||
|3|D|D3|URL:||
|3|E|E3|URL||

## CIS Druh činnosti

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|první pracovní poměr||
|2|D|D2|Popis:||
|2|E|E2|Číselník ČSSZ Druh činnosti, hodnoty a kód položky převzaty ze záložky z originální datové věty||
|3|A|A3|2||
|3|B|B3|druhý pracovní poměr u téhož zaměstnavatele||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|třetí pracovní poměr u téhož zaměstnavatele||
|5|A|A5|4||
|5|B|B5|čtvrtý pracovní poměr u téhož zaměstnavatele||
|6|A|A6|5||
|6|B|B6|pátý pracovní poměr u téhož zaměstnavatele||
|7|A|A7|6||
|7|B|B7|šestý pracovní poměr u téhož zaměstnavatele||
|8|A|A8|7||
|8|B|B8|sedmý pracovní poměr u téhož zaměstnavatele||
|9|A|A9|8||
|9|B|B9|osmý pracovní poměr u téhož zaměstnavatele||
|10|A|A10|9||
|10|B|B10|devátý pracovní poměr u téhož zaměstnavatele||
|11|A|A11|10||
|11|B|B11|osoby se zdravotním postižením v teoretické a praktické přípravě pro zaměstnání||
|12|A|A12|11||
|12|B|B12|osoby s příjmem v důsledku škod vzniklých při plnění pracovních úkolů||
|13|A|A13|12||
|13|B|B13|osoby s příjmem vypláceným na základě smluvního vztahu prostřednictvím osoby se sídlem nebo bydlištěm v zahraničí||
|14|A|A14|13||
|14|B|B14|osoby s příjmem ze závislé činnosti vyplácené plátcem, u kterého není závislá činnost vykonávána||
|15|A|A15|14||
|15|B|B15|neuvolněný člen zastupitelstva||
|16|A|A16|A||
|16|B|B16|dohoda o pracovní činnosti||
|17|A|A17|B||
|17|B|B17|druhá dohoda o pracovní činnosti u téhož zaměstnavatele||
|18|A|A18|C||
|18|B|B18|třetí dohoda o pracovní činnosti u téhož zaměstnavatele||
|19|A|A19|D||
|19|B|B19|čtvrtá dohoda o pracovní činnosti u téhož zaměstnavatele||
|20|A|A20|E||
|20|B|B20|pátá dohoda o pracovní činnosti u téhož zaměstnavatele||
|21|A|A21|F||
|21|B|B21|šestá dohoda o pracovní činnosti u téhož zaměstnavatele||
|22|A|A22|G||
|22|B|B22|sedmá dohoda o pracovní činnosti u téhož zaměstnavatele||
|23|A|A23|H||
|23|B|B23|osmá dohoda o pracovní činnosti u téhož zaměstnavatele||
|24|A|A24|I||
|24|B|B24|devátá dohoda o pracovní činnosti u téhož zaměstnavatele||
|25|A|A25|J||
|25|B|B25|desátá dohoda o pracovní činnosti u téhož zaměstnavatele||
|26|A|A26|K||
|26|B|B26|dobrovolný pracovník pečovatelské služby||
|27|A|A27|M||
|27|B|B27|pěstouni/osoby pečující a osoby v evidenci ve zvláštních případech||
|28|A|A28|N||
|28|B|B28|smluvní zaměstnanec||
|29|A|A29|O||
|29|B|B29|člen družstva||
|30|A|A30|P||
|30|B|B30|Prokuristé||
|31|A|A31|Q||
|31|B|B31|členové kolektivních orgánů právnických osob||
|32|A|A32|R||
|32|B|B32|Likvidátoři||
|33|A|A33|S||
|33|B|B33|společník, jednatel, komanditista, ředitel obecně prospěšné společnosti, osoby pověřené obchodním vedením na základě smluvního zastoupení||
|34|A|A34|T||
|34|B|B34|první dohoda o provedení práce u téhož zaměstnavatele||
|35|A|A35|U||
|35|B|B35|druhá dohoda o provedení práce u téhož zaměstnavatele||
|36|A|A36|V||
|36|B|B36|třetí dohoda o provedení práce u téhož zaměstnavatele||
|37|A|A37|W||
|37|B|B37|čtvrtá dohoda o provedení práce u téhož zaměstnavatele||
|38|A|A38|X||
|38|B|B38|pátá dohoda o provedení práce u téhož zaměstnavatele||
|39|A|A39|Y||
|39|B|B39|šestá dohoda o provedení práce u téhož zaměstnavatele||
|40|A|A40|Z||
|40|B|B40|sedmá dohoda o provedení práce u téhož zaměstnavatele||
|41|A|A41|ZA||
|41|B|B41|osmá dohoda o provedení práce u téhož zaměstnavatele||
|42|A|A42|ZB||
|42|B|B42|devátá dohoda o provedení práce u téhož zaměstnavatele||
|43|A|A43|ZC||
|43|B|B43|desátá dohoda o provedení práce u téhož zaměstnavatele||
|46|A|A46|Kód pro pracovní poměr se použije i pro pracovní vztahy:||
|47|A|A47|•      soudců||
|48|A|A48|•      členů zastupitelstev územních samosprávních celků||
|49|A|A49|•      poslanců Poslanecké sněmovny PČR, senátorů Senátu PČR, členů vlády, prezidenta, viceprezidenta a členů NKÚ, členy RRTV, finančního arbitra a jeho zástupce, veřejného ochránce práv a jeho zástupce, členů Rady Ústavu pro studium totalitních režimů, členů Rady Českého telekomunikačního úřadu, členů Rady Energetického regulačního úřadu, členů Národní rozpočtové rady||
|50|A|A50|•      pracovníků v pracovním vztahu podle cizích právních předpisů||
|51|A|A51|•      fyzických osob neuvedených v § 5, písm. a) bodech 1 až 21 ZNP, s výjimkou členů zastupitelstev územních samosprávných celků a zastupitelstev městských částí nebo městských obvodů územně členěných statutárních měst a hlavního města Prahy volených do funkcí, jež zastupitelstvo neurčilo jako funkce, pro které budou členové zastupitelstva uvolněni||
|52|A|A52|•      státních zaměstnanců (služební poměr dle zákona č. 234/2014 Sb., o státní službě)||
|53|A|A53|•      státních zástupců vykonávajících v České republice funkci evropských pověřených žalobců, kteří jsou zařazeni do okruhu pojištěných osob ode dne 1. 12. 2019 podle ustanovení § 167g ZNP||

## CIS Bližší určení pracovněprávn

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Žádné||
|2|D|D2|Popis:||
|2|E|E2|Číselnk vytvořený pro vyčlenění speciální skupin pracovních vztahů z Druhu činnosti 1 - 9 ve vazbě na měsíční hlášení||
|3|A|A3|2||
|3|B|B3|Výkon trestu odnětí svobody/Zabezpečovací detence ||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|Pracovní vztah specifické skupiny ||

## CIS Klasif. postavení v zaměstn

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSÚ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2| Zaměstnanci||
|2|D|D2|Popis:||
|2|E|E2|Národní klasifikace postavení v zaměstnání (NKPZ)||
|3|A|A3|11||
|3|B|B3|Zaměstnanci v pracovním poměru||
|3|D|D3|URL:||
|3|E|E3|Národní klasifikace postavení v zaměstnání (NKPZ) \| Statistika||
|4|A|A4|111||
|4|B|B4|Zaměstnanci na základě pracovní smlouvy||
|5|A|A5|1111||
|5|B|B5|Zaměstnanci v pracovním poměru na dobu neurčitou||
|6|A|A6|1112||
|6|B|B6|Zaměstnanci v pracovním poměru na dobu určitou||
|7|A|A7|112||
|7|B|B7|Zaměstnanci jmenovaní nebo volení||
|8|A|A8|1121||
|8|B|B8|Zaměstnanci jmenovaní||
|9|A|A9|1122||
|9|B|B9|Zaměstnanci volení (kromě členů produkčních družstev)||
|10|A|A10|12||
|10|B|B10|Zaměstnanci na základě dohod||
|11|A|A11|121||
|11|B|B11|Zaměstnanci na základě dohod o pracovní činnosti||
|12|A|A12|1211||
|12|B|B12|Zaměstnanci na základě dohod o pracovní činnosti na dobu neurčitou||
|13|A|A13|1212||
|13|B|B13|Zaměstnanci na základě dohod o pracovní činnosti na dobu určitou||
|14|A|A14|122||
|14|B|B14|Zaměstnanci na základě dohod o provedení práce||
|15|A|A15|1221||
|15|B|B15|Zaměstnanci na základě dohod o provedení práce na dobu neurčitou||
|16|A|A16|1222||
|16|B|B16|Zaměstnanci na základě dohod o provedení práce na dobu určitou||
|17|A|A17|13||
|17|B|B17|Zaměstnanci ve služebním poměru||
|18|A|A18|131||
|18|B|B18|Příslušníci armády||
|19|A|A19|1311||
|19|B|B19|Vojáci z povolání||
|20|A|A20|1312||
|20|B|B20|Vojáci v základní službě||
|21|A|A21|1313||
|21|B|B21|Vojáci v aktivní záloze/v záloze povolaní k výkonu vojenské činnosti||
|22|A|A22|132||
|22|B|B22|Zaměstnanci ve služebním poměru podle služebního zákona||
|23|A|A23|1321||
|23|B|B23|Zaměstnanci ve služebním poměru podle služebního zákona na dobu neurčitou||
|24|A|A24|1322||
|24|B|B24|Zaměstnanci ve služebním poměru podle služebního zákona na dobu určitou||
|25|A|A25|133||
|25|B|B25|Policisté||
|26|A|A26|1331||
|26|B|B26|Policisté ve služebním poměru na dobu neurčitou||
|27|A|A27|1332||
|27|B|B27|Policisté ve služebním poměru na dobu určitou||
|28|A|A28|134||
|28|B|B28|Ostatní zaměstnanci ve služebním poměru podle zákona č. 361/2003, kteří nejsou policisté||
|29|A|A29|1341||
|29|B|B29|Ostatní zaměstnanci ve služebním poměru na dobu neurčitou||
|30|A|A30|1342||
|30|B|B30|Ostatní zaměstnanci ve služebním poměru na dobu určitou||
|31|A|A31|14||
|31|B|B31|Učni vykonávající placenou práci\n\n||
|32|A|A32|141\n||
|32|B|B32|Učni vykonávající placenou práci||
|33|A|A33|1410||
|33|B|B33|Učni vykonávající placenou práci||
|34|A|A34|2||
|34|B|B34|Zaměstnavatelé||
|35|A|A35|21||
|35|B|B35|Zaměstnavatelé – fyzické osoby||
|36|A|A36|211||
|36|B|B36|Zaměstnavatelé – fyzické osoby||
|37|A|A37|2111||
|37|B|B37|Zaměstnavatelé – fyzické osoby, zapsané v obchodním rejstříku||
|38|A|A38|2112||
|38|B|B38|Zaměstnavatelé – fyzické osoby, podnikající na základě živnostenského oprávnění (kromě zapsaných v obchodním rejstříku)||
|39|A|A39|2113||
|39|B|B39|Zaměstnavatelé – fyzické osoby, podnikající na základě jiného oprávnění||
|40|A|A40|2114||
|40|B|B40|Zaměstnavatelé – fyzické osoby, provozující zemědělskou činnost, zapsané do evidence podle zvláštního předpisu||
|41|A|A41|2119||
|41|B|B41|Zaměstnavatelé – fyzické osoby jinde neuvedené||
|42|A|A42|22||
|42|B|B42| Zaměstnavatelé – právnické osoby (ředitelé – vlastníci)||
|43|A|A43|221||
|43|B|B43|Zaměstnavatelé – právnické osoby (ředitelé – vlastníci)||
|44|A|A44|2210||
|44|B|B44|Zaměstnavatelé – právnické osoby (ředitelé – vlastníci)||
|45|A|A45|3||
|45|B|B45|Osoby pracující na vlastní účet||
|46|A|A46|31||
|46|B|B46|Osoby pracující na vlastní účet||
|47|A|A47|311||
|47|B|B47|Osoby pracující na vlastní účet||
|48|A|A48|3111||
|48|B|B48|Osoby pracující na vlastní účet, zapsané v obchodním rejstříku (kromě zaměstnavatelů)||
|49|A|A49|3112||
|49|B|B49|Osoby pracující na vlastní účet na základě živnostenského oprávnění (kromě zaměstnavatelů a osob zapsaných v obchodním rejstříku)||
|50|A|A50|3113||
|50|B|B50|Osoby pracující na vlastní účet na základě jiného oprávnění (kromě zaměstnavatelů)||
|51|A|A51|3114||
|51|B|B51|Osoby provozující zemědělskou činnost, zapsané do evidence podle zvláštního předpisu (kromě zaměstnavatelů)||
|52|A|A52|3119||
|52|B|B52|Osoby pracující na vlastní účet jinde neuvedené||
|53|A|A53|4||
|53|B|B53|Členové produkčních družstev||
|54|A|A54|41||
|54|B|B54|Členové produkčních družstev||
|55|A|A55|411||
|55|B|B55|Členové produkčních družstev||
|56|A|A56|4111||
|56|B|B56|Členové zemědělských družstev||
|57|A|A57|4112||
|57|B|B57|Členové ostatních produkčních družstev||
|58|A|A58|5||
|58|B|B58|Pomáhající rodinní příslušníci||
|59|A|A59|51||
|59|B|B59|Pomáhající rodinní příslušníci||
|60|A|A60|511||
|60|B|B60|Pomáhající rodinní příslušníci||
|61|A|A61|5111||
|61|B|B61|Pomáhající rodinní příslušníci při podnikatelské činnosti||
|62|A|A62|5119||
|62|B|B62|Pomáhající rodinní příslušníci ostatní||
|63|A|A63|6||
|63|B|B63|Osoby neklasifikované podle postavení v zaměstnání||
|64|A|A64|61||
|64|B|B64|Osoby neklasifikované podle postavení v zaměstnání||
|65|A|A65|611||
|65|B|B65|Osoby neklasifikované podle postavení v zaměstnání||
|66|A|A66|6110||
|66|B|B66|Osoby neklasifikované podle postavení v zaměstnání||

## CIS Pracovní režim

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Jednosměnný pracovní režim||
|2|D|D2|Popis:||
|2|E|E2|Hodnoty a kód položky převzaty ze záložky z originální datové věty||
|3|A|A3|2||
|3|B|B3|Dvousměnný pracovní režim||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|Vícesměnný pracovní režim||
|5|A|A5|4||
|5|B|B5|Neuvedeno||

## CIS Průběh práce

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|V prostorách zaměstnavatele||
|2|D|D2|Popis:||
|2|E|E2|Hodnoty a kód položky převzaty ze záložky z originální datové věty||
|3|A|A3|2||
|3|B|B3|U zákazníka||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|Bydliště zaměstnance||
|5|A|A5|4||
|5|B|B5|Jinde||

## CIS Kategorizace rizika

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Práce zařazená do kategorie 4||
|2|D|D2|Popis:||
|2|E|E2|Číselník Kategorizace rizika, hodnoty a kód položky převzaty z originální datové věty||
|3|A|A3|6||
|3|B|B3|Práce zdravotnického záchranáře||
|3|D|D3|URL:||
|4|A|A4|7||
|4|B|B4|Práce člena jednotky HZS podniku||

## CIS Kód ELDP

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1D+||
|2|B|B2|1D+ - jeden prac. poměr u zaměst. - výdělečná čin. po dovršení důchodového věku||
|2|D|D2|Popis:||
|2|E|E2|Číselník kódů ELDP||
|3|A|A3|1DE||
|3|B|B3|1DE - voják v evidenci -  výdělečná čin. po dovršení důchodového věku - Ministerstvo obrany||
|3|D|D3|URL:||
|4|A|A4|1DF||
|4|B|B4|1DF - jeden prac. poměr u zaměst. - výdělečná činnost po dovršení důchodového věku - ozbrojené složky||
|5|A|A5|1DB||
|5|B|B5|1DB - jeden prac. poměr u zaměst. - výdělečná čin. po dovršení důchodového věku - ozbrojené složky||
|6|A|A6|1DJ||
|6|B|B6|1DJ - jeden prac. poměr u zaměst. - výdělečná čin. po dovršení důchodového věku - ozbrojené složky||
|7|A|A7|1DT||
|7|B|B7|1DT - jeden prac. poměr u zaměst. - výdělečná čin. po dovršení důchodového věku - ozbrojené složky||
|8|A|A8|1DV||
|8|B|B8|1DV - jeden prac. poměr u zaměst. - výdělečná čin. po dovršení důchodového věku - ozbrojené složky||
|9|A|A9|1DZ||
|9|B|B9|1DZ - voják v záloze - výdělečná čin. po dovršení důchodového věku - ministerstvo obrany||
|10|A|A10|1ME||
|10|B|B10|1ME - voják v evidenci -  dávky nemoc. pojištění - Ministerstvo obrany||
|11|A|A11|1MF||
|11|B|B11|1MF - jeden prac. poměr u zaměst. - dávky nemoc. pojištění - ozbrojené složky||
|12|A|A12|1MB||
|12|B|B12|1MB - jeden prac. poměr u zaměst. - dávky nemoc. pojištění - ozbrojené složky||
|13|A|A13|1MJ||
|13|B|B13|1MJ - jeden prac. poměr u zaměst. - dávky nemoc. pojištění - ozbrojené složky||
|14|A|A14|1MT||
|14|B|B14|1MT - jeden prac. poměr u zaměst. - dávky nemoc. pojištění - ozbrojené složky||
|15|A|A15|1MV||
|15|B|B15|1MV - jeden prac. poměr u zaměst. - dávky nemoc. pojištění - ozbrojené složky||
|16|A|A16|1MZ||
|16|B|B16|1MZ - voják v záloze -  dávky nemoc. pojištění - Ministerstvo obrany||
|17|A|A17|1NE||
|17|B|B17|1NE - voják v evidenci - dávky nemoc. pojištění - Ministerstvo obrany||
|18|A|A18|1NF||
|18|B|B18|1NF - jeden prac. poměr u zaměst. - dávky nemoc. pojištění - ozbrojené složky||
|19|A|A19|1NB||
|19|B|B19|1NB - jeden prac. poměr u zaměst. - dávky nemoc. pojištění - ozbrojené složky||
|20|A|A20|1NJ||
|20|B|B20|1NJ - jeden prac. poměr u zaměst. - dávky nemoc. pojištění - ozbrojené složky||
|21|A|A21|1NT||
|21|B|B21|1NT - jeden prac. poměr u zaměst. - dávky nemoc. pojištění - ozbrojené složky||
|22|A|A22|1NV||
|22|B|B22|1NV - jeden prac. poměr u zaměst. - dávky nemoc. pojištění - ozbrojené složky||
|23|A|A23|1NZ||
|23|B|B23|1NZ - voják v záloze - dávky nemoc. pojištění - Ministerstvo obrany||
|24|A|A24|1P+||
|24|B|B24|1P+ - jeden prac. poměr u zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|25|A|A25|1PF||
|25|B|B25|1PF - jeden prac. poměr u zaměst. - dodat. zúčtování příjmu po skončení výdělečné čin. - ozbrojené složky,||
|26|A|A26|1PB||
|26|B|B26|1PB - jeden prac. poměr u zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin. - ozbrojené složky||
|27|A|A27|1PJ||
|27|B|B27|1PJ - jeden prac. poměr u zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin. - ozbrojené složky||
|28|A|A28|1PT||
|28|B|B28|1PT - jeden prac. poměr u zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin. - ozbrojené složky||
|29|A|A29|1PV||
|29|B|B29|1PV - jeden prac. poměr u zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin. - ozbrojené složky||
|30|A|A30|1V+||
|30|B|B30|1V+ - jeden prac. poměr u zaměst. - výjimka: vojenská služba, nepl. skončení PP ||
|31|A|A31|1VE||
|31|B|B31|1VE - voják v evidenci -  výjimka, nepl. skončení PP - Ministerstvo obrany||
|32|A|A32|1VF||
|32|B|B32|1VF - jeden prac. poměr u zaměst. - výjimka: vojenská služba, nepl. skončení PP - ozbrojené složky||
|33|A|A33|1VB||
|33|B|B33|1VB - jeden prac. poměr u zaměst. - výjimka: vojenská služba, nepl. skončení PP - ozbrojené složky||
|34|A|A34|1VJ||
|34|B|B34|1VJ - jeden prac. poměr u zaměst. - výjimka: vojenská služba, nepl. skončení PP - ozbrojené složky||
|35|A|A35|1VV||
|35|B|B35|1VV - jeden prac. poměr u zaměst. - výjimka: vojenská služba, nepl. skončení PP - ozbrojené složky||
|36|A|A36|1VZ||
|36|B|B36|1VZ - voják v záloze -  výjimka, nepl. skončení PP - Ministerstvo obrany||
|37|A|A37|1++||
|37|B|B37|1++ - jeden prac. poměr u zaměst. ||
|38|A|A38|1+E||
|38|B|B38|1+E - voják v evidenci -  Ministerstvo obrany||
|39|A|A39|1+F||
|39|B|B39|1+F - jeden prac. poměr u zaměst. - ozbrojené složky||
|40|A|A40|1+B||
|40|B|B40|1+B - jeden prac. poměr u zaměst. -  ozbrojené složky||
|41|A|A41|1+J||
|41|B|B41|1+J - jeden prac. poměr u zaměst. - ozbrojené složky||
|42|A|A42|1+T||
|42|B|B42|1+T - jeden prac. poměr u zaměst. - ozbrojené složky||
|43|A|A43|1+V||
|43|B|B43|1+V - jeden prac. poměr u zaměst. - ozbrojené složky||
|44|A|A44|1+Z||
|44|B|B44|1+Z - voják v záloze -  Ministerstvo obrany||
|45|A|A45|2D+||
|45|B|B45|2D+ - druhý souběžný prac. poměr u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|46|A|A46|2P+||
|46|B|B46|2P+ - druhý souběžný prac. poměr u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin. ||
|47|A|A47|2V+||
|47|B|B47|2V+ - druhý souběžný prac. poměr u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|48|A|A48|2++||
|48|B|B48|2++ - druhý souběžný prac. poměr u téhož zaměst. ||
|49|A|A49|3D+||
|49|B|B49|3D+ - třetí souběžný prac. poměr u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|50|A|A50|3P+||
|50|B|B50|3P+ - třetí souběžný prac. poměr u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|51|A|A51|3V+||
|51|B|B51|3V+ - třetí souběžný prac. poměr u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|52|A|A52|3++||
|52|B|B52|3++ - třetí souběžný prac. poměr u téhož zaměst. ||
|53|A|A53|4D+||
|53|B|B53|4D+ - čtvrtý souběžný prac. poměr u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|54|A|A54|4P+||
|54|B|B54|4P+ - čtvrtý souběžný prac. poměr u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|55|A|A55|4V+||
|55|B|B55|4V+ - čtvrtý souběžný prac. poměr u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|56|A|A56|4++||
|56|B|B56|4++ - čtvrtý souběžný prac. poměr u téhož zaměst. ||
|57|A|A57|5D+||
|57|B|B57|5D+ - pátý souběžný prac. poměr u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|58|A|A58|5P+||
|58|B|B58|5P+ - pátý souběžný prac. poměr u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|59|A|A59|5V+||
|59|B|B59|5V+ - pátý souběžný prac. poměr u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|60|A|A60|5++||
|60|B|B60|5++ - pátý souběžný prac. poměr u téhož zaměst. ||
|61|A|A61|6D+||
|61|B|B61|6D+ - šestý souběžný prac. poměr u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|62|A|A62|6P+||
|62|B|B62|6P+ - šestý souběžný prac. poměr u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|63|A|A63|6V+||
|63|B|B63|6V+ - šestý souběžný prac. poměr u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|64|A|A64|6++||
|64|B|B64|6++ - šestý souběžný prac. poměr u téhož zaměst. ||
|65|A|A65|7D+||
|65|B|B65|7D+ - sedmý souběžný prac. poměr u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|66|A|A66|7P+||
|66|B|B66|7P+ - sedmý souběžný prac. poměr u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|67|A|A67|7V+||
|67|B|B67|7V+ - sedmý souběžný prac. poměr u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|68|A|A68|7++||
|68|B|B68|7++ - sedmý souběžný prac. poměr u téhož zaměst. ||
|69|A|A69|8D+||
|69|B|B69|8D+ - osmý souběžný prac. poměr u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|70|A|A70|8P+||
|70|B|B70|8P+ - osmý souběžný prac. poměr u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|71|A|A71|8V+||
|71|B|B71|8V+ - osmý souběžný prac. poměr u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|72|A|A72|8++||
|72|B|B72|8++ - osmý souběžný prac. poměr u téhož zaměst. ||
|73|A|A73|9D+||
|73|B|B73|9D+ - devátý souběžný prac. poměr u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|74|A|A74|9P+||
|74|B|B74|9P+ - devátý souběžný prac. poměr u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|75|A|A75|9V+||
|75|B|B75|9V+ - devátý souběžný prac. poměr u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|76|A|A76|9++||
|76|B|B76|9++ - devátý souběžný prac. poměr u téhož zaměst. ||
|77|A|A77|AD+||
|77|B|B77|AD+ - dohoda o prac. čin. - výdělečná čin. po dovršení důchodového věku||
|78|A|A78|ADT||
|78|B|B78|ADT - dohoda o prac. čin. - výdělečná čin. po dovršení důchodového věku - ozbrojené složky||
|79|A|A79|AMT||
|79|B|B79|AMT - dohoda o prac. čin. - dávky nemoc. pojištění - ozbrojené složky||
|80|A|A80|ANT||
|80|B|B80|ANT - dohoda o prac. čin. - dávky nemoc. pojištění - ozbrojené složky||
|81|A|A81|AP+||
|81|B|B81|AP+ - dohoda o prac. čin. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|82|A|A82|APT||
|82|B|B82|APT - dohoda o prac. čin. - dodat. zúčtování příjmů po skončení výdělečné čin. - ozbrojené složky||
|83|A|A83|AV+||
|83|B|B83|AV+ - dohoda o prac. čin. - výjimka: vojenská služba, nepl. skončení PP||
|84|A|A84|A++||
|84|B|B84|A++ - dohoda o prac. čin. ||
|85|A|A85|A+T||
|85|B|B85|A+T - dohoda o prac. čin.  - ozbrojené složky||
|86|A|A86|BD+||
|86|B|B86|BD+ - druhá souběžná dohoda o prac. čin. u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|87|A|A87|BP+||
|87|B|B87|BP+ - druhá souběžná dohoda o prac. čin. u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|88|A|A88|BV+||
|88|B|B88|BV+ - druhá souběžná dohoda o prac. čin. u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|89|A|A89|B++||
|89|B|B89|B++ - druhá souběžná dohoda o prac. čin. u téhož zaměst. ||
|90|A|A90|CD+||
|90|B|B90|CD+ - třetí souběžná dohoda o prac. čin. u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|91|A|A91|CP+||
|91|B|B91|CP+ - třetí souběžná dohoda o prac. čin. u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|92|A|A92|CV+||
|92|B|B92|CV+ - třetí souběžná dohoda o prac. čin. u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|93|A|A93|C++||
|93|B|B93|C++ - třetí souběžná dohoda o prac. čin. u téhož zaměst. ||
|94|A|A94|DD+||
|94|B|B94|DD+ - čtvrtá souběžná dohoda o prac. čin. u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|95|A|A95|DP+||
|95|B|B95|DP+ - čtvrtá souběžná dohoda o prac. čin. u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|96|A|A96|DV+||
|96|B|B96|DV+ - čtvrtá souběžná dohoda o prac. čin. u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|97|A|A97|D++||
|97|B|B97|D++ - čtvrtá souběžná dohoda o prac. čin. u téhož zaměst. ||
|98|A|A98|ED+||
|98|B|B98|ED+ - pátá souběžná dohoda o prac. čin. u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|99|A|A99|EP+||
|99|B|B99|EP+ - pátá souběžná dohoda o prac. čin. u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|100|A|A100|EV+||
|100|B|B100|EV+ - pátá souběžná dohoda o prac. čin. u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|101|A|A101|E++||
|101|B|B101|E++ - pátá souběžná dohoda o prac. čin. u téhož zaměst. ||
|102|A|A102|FD+||
|102|B|B102|FD+ - šestá souběžná dohoda o prac. čin. u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|103|A|A103|FP+||
|103|B|B103|FP+ - šestá souběžná dohoda o prac. čin. u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|104|A|A104|FV+||
|104|B|B104|FV+ - šestá souběžná dohoda o prac. čin. u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|105|A|A105|F++||
|105|B|B105|F++ - šestá souběžná dohoda o prac. čin. u téhož zaměst. ||
|106|A|A106|GD+||
|106|B|B106|GD+ - sedmá souběžná dohoda o prac. čin. u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|107|A|A107|GP+||
|107|B|B107|GP+ - sedmá souběžná dohoda o prac. čin. u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|108|A|A108|GV+||
|108|B|B108|GV+ - sedmá souběžná dohoda o prac. čin. u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|109|A|A109|G++||
|109|B|B109|G++ - sedmá souběžná dohoda o prac. čin. u téhož zaměst. ||
|110|A|A110|HD+||
|110|B|B110|HD+ - osmá souběžná dohoda o prac. čin. u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|111|A|A111|HP+||
|111|B|B111|HP+ - osmá souběžná dohoda o prac. čin. u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|112|A|A112|HV+||
|112|B|B112|HV+ - osmá souběžná dohoda o prac. čin. u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|113|A|A113|H++||
|113|B|B113|H++ - osmá souběžná dohoda o prac. čin. u téhož zaměst. ||
|114|A|A114|ID+||
|114|B|B114|ID+ - devátá souběžná dohoda o prac. čin. u téhož zaměst. - výdělečná čin. po dovršení důchodového věku||
|115|A|A115|IP+||
|115|B|B115|IP+ - devátá souběžná dohoda o prac. čin. u téhož zaměst. - dodat. zúčtování příjmů po skončení výdělečné čin.||
|116|A|A116|IV+||
|116|B|B116|IV+ - devátá souběžná dohoda o prac. čin. u téhož zaměst. - výjimka: vojenská služba, nepl. skončení PP||
|117|A|A117|I++||
|117|B|B117|I++ - devátá souběžná dohoda o prac. čin. u téhož zaměst. ||
|118|A|A118|JD+||
|118|B|B118|JD+ - desátá souběžná dohoda o prac. čin. u téhož zaměst.  - výdělečná čin. po dovršení důchodového věku||
|119|A|A119|JP+||
|119|B|B119|JP+ - desátá souběžná dohoda o prac. čin. u téhož zaměst.  - dodat. zúčtování příjmů po skončení výdělečné čin.||
|120|A|A120|JV+||
|120|B|B120|JV+ - desátá souběžná dohoda o prac. čin. u téhož zaměst.  - výjimka: vojenská služba, nepl. skončení PP||
|121|A|A121|J++||
|121|B|B121|J++ - desátá souběžná dohoda o prac. čin. u téhož zaměst.  ||
|122|A|A122|KD+||
|122|B|B122|KD+ - dobrovolný pracovník pečovatelské služby - výdělečná čin. po dovršení důchodového věku||
|123|A|A123|KP+||
|123|B|B123|KP+ - dobrovolný pracovník pečovatelské služby - dodat. zúčtování příjmů po skončení výdělečné čin.||
|124|A|A124|KV+||
|124|B|B124|KV+ - dobrovolný pracovník pečovatelské služby - výjimka: vojenská služba, nepl. skončení PP||
|125|A|A125|K++||
|125|B|B125|K++ - dobrovolný pracovník pečovatelské služby ||
|126|A|A126|MD+||
|126|B|B126|MD+ - pěstouni ve zvláštních případech - výdělečná čin. po dovršení důchodového věku||
|127|A|A127|MP+||
|127|B|B127|MP+ - pěstouni ve zvláštních případech - dodat. zúčtování příjmů po skončení výdělečné čin.||
|128|A|A128|MV+||
|128|B|B128|MV+ - pěstouni ve zvláštních případech - výjimka: vojenská služba, nepl. skončení PP||
|129|A|A129|M++||
|129|B|B129|M++ - pěstouni ve zvláštních případech ||
|130|A|A130|ND+||
|130|B|B130|ND+ - smluvní zaměstnanec - výdělečná čin. po dovršení důchodového věku||
|131|A|A131|NP+||
|131|B|B131|NP+ - smluvní zaměstnanec - dodat. zúčtování příjmů po skončení výdělečné čin.||
|132|A|A132|NV+||
|132|B|B132|NV+ - smluvní zaměstnanec - výjimka: vojenská služba, nepl. skončení PP||
|133|A|A133|N++||
|133|B|B133|N++ - smluvní zaměstnanec ||
|134|A|A134|OD+||
|134|B|B134|OD+ - člen družstva - výdělečná čin. po dovršení důchodového věku||
|135|A|A135|OP+||
|135|B|B135|OP+ - člen družstva - dodat. zúčtování příjmů po skončení výdělečné čin.||
|136|A|A136|OV+||
|136|B|B136|OV+ - člen družstva - výjimka: vojenská služba, nepl. skončení PP||
|137|A|A137|O++||
|137|B|B137|O++ - člen družstva ||
|138|A|A138|PD+||
|138|B|B138|PD+ - prokurista - výdělečná čin. po dovršení důchodového věku||
|139|A|A139|PV+||
|139|B|B139|PV+ - prokurista - výjimka: vojenská služba, nepl. skončení PP||
|140|A|A140|P++||
|140|B|B140|P++ - prokurista ||
|141|A|A141|PP+||
|141|B|B141|PP+ - prokurista - dodat. zúčtování příjmů po skončení výdělečné čin.||
|142|A|A142|RD+||
|142|B|B142|RD+ - likvidátor - výdělečná činnost po dovršení důchodového věku||
|143|A|A143|RP+||
|143|B|B143|RP+ - likvidátor - dodat. zúčtování příjmů po skončení výdělečné čin.||
|144|A|A144|RV+||
|144|B|B144|RV+ - likvidátor - výjimka: vojenská služba, nepl. skončení PP||
|145|A|A145|R++||
|145|B|B145|R++ - likvidátor ||
|146|A|A146|SD+||
|146|B|B146|SD+ - společník, jednatel, komanditista, ředitel o.p.s - výdělečná čin. po dovršení důchodového věku||
|147|A|A147|SP+||
|147|B|B147|SP+ - společník, jednatel, komanditista, ředitel o.p.s - dodat. zúčtování příjmů po skončení výdělečné čin.||
|148|A|A148|SV+||
|148|B|B148|SV+ - společník, jednatel, komanditista, ředitel o.p.s - výjimka: vojenská služba, nepl. skončení PP||
|149|A|A149|S++||
|149|B|B149|S++ - společník, jednatel, komanditista, ředitel o.p.s ||
|150|A|A150|QD+||
|150|B|B150|QD+ - členové kolektivních orgánů právnických osob - výdělečná činnost po dovršení důchodového věku||
|151|A|A151|QP+||
|151|B|B151|QP+ - členové kolektivních orgánů právnických osob - dodat. zúčtování příjmů po skončení výdělečné čin.||
|152|A|A152|QV+||
|152|B|B152|QV+ - členové kolektivních orgánů právnických osob - výjimka: vojenská služba, nepl. skončení PP||
|153|A|A153|Q++||
|153|B|B153|Q++ - členové kolektivních orgánů právnických osob ||
|154|A|A154|TD+||
|154|B|B154|TD+ - první dohoda o provedení práce - výdělečná činnost po dovršení důchodového věku||
|155|A|A155|TV+||
|155|B|B155|TV+ - první dohoda o provedení práce - výjimka: vojenská služba, nepl. skončení PP||
|156|A|A156|T++||
|156|B|B156|T++ - první dohoda o provedení práce ||
|157|A|A157|TDT||
|157|B|B157|TDT - první dohoda o provedení práce - výdělečná činnost po dovršení důchodového věku - ozbrojené složky||
|158|A|A158|TNT||
|158|B|B158|TNT - první dohoda o provedení práce - dávky nemoc. pojištění - ozbrojené složky||
|159|A|A159|TMT||
|159|B|B159|TMT - první dohoda o provedení práce - dávky nemoc. pojištění - ozbrojené složky||
|160|A|A160|T+T||
|160|B|B160|T+T - první dohoda o provedení práce  - ozbrojené složky||
|161|A|A161|UD+||
|161|B|B161|UD+ - druhá souběžná dohoda o provedení práce u téhož zaměstnavatele - výdělečná činnost po dovršení důchodového věku||
|162|A|A162|UV+||
|162|B|B162|UV+ - druhá souběžná dohoda o provedení práce u téhož zaměstnavatele - výjimka: vojenská služba, nepl. skončení PP||
|163|A|A163|U++||
|163|B|B163|U++ - druhá souběžná dohoda o provedení práce u téhož zaměstnavatele ||
|164|A|A164|VD+||
|164|B|B164|VD+ - třetí souběžná dohoda o provedení práce u téhož zaměstnavatele - výdělečná činnost po dovršení důchodového věku||
|165|A|A165|VV+||
|165|B|B165|VV+ - třetí souběžná dohoda o provedení práce u téhož zaměstnavatele - výjimka: vojenská služba, nepl. skončení PP||
|166|A|A166|V++||
|166|B|B166|V++ - třetí souběžná dohoda o provedení práce u téhož zaměstnavatele ||
|167|A|A167|WD+||
|167|B|B167|WD+ - čtvrtá souběžná dohoda o provedení práce u téhož zaměstnavatele - výdělečná činnost po dovršení důchodového věku||
|168|A|A168|WV+||
|168|B|B168|WV+ - čtvrtá souběžná dohoda o provedení práce u téhož zaměstnavatele - výjimka: vojenská služba, nepl. skončení PP||
|169|A|A169|W++||
|169|B|B169|W++ - čtvrtá souběžná dohoda o provedení práce u téhož zaměstnavatele ||
|170|A|A170|XD+||
|170|B|B170|XD+ - pátá souběžná dohoda o provedení práce u téhož zaměstnavatele - výdělečná činnost po dovršení důchodového věku||
|171|A|A171|XV+||
|171|B|B171|XV+ - pátá souběžná dohoda o provedení práce u téhož zaměstnavatele - výjimka: vojenská služba, nepl. skončení PP||
|172|A|A172|X++||
|172|B|B172|X++ - pátá souběžná dohoda o provedení práce u téhož zaměstnavatele ||
|173|A|A173|YD+||
|173|B|B173|YD+ - šestá souběžná dohoda o provedení práce u téhož zaměstnavatele - výdělečná činnost po dovršení důchodového věku||
|174|A|A174|YV+||
|174|B|B174|YV+ - šestá souběžná dohoda o provedení práce u téhož zaměstnavatele - výjimka: vojenská služba, nepl. skončení PP||
|175|A|A175|Y++||
|175|B|B175|Y++ - šestá souběžná dohoda o provedení práce u téhož zaměstnavatele ||
|176|A|A176|ZD+||
|176|B|B176|ZD+ - sedmá souběžná dohoda o provedení práce u téhož zaměstnavatele - výdělečná činnost po dovršení důchodového věku||
|177|A|A177|ZV+||
|177|B|B177|ZV+ - sedmá souběžná dohoda o provedení práce u téhož zaměstnavatele - výjimka: vojenská služba, nepl. skončení PP||
|178|A|A178|Z++||
|178|B|B178|Z++ - sedmá souběžná dohoda o provedení práce u téhož zaměstnavatele ||
|179|A|A179|ZAD+||
|179|B|B179|ZAD+ - osmá souběžná dohoda o provedení práce u téhož zaměstnavatele - výdělečná činnost po dovršení důchodového věku||
|180|A|A180|ZAV+||
|180|B|B180|ZAV+ - osmá souběžná dohoda o provedení práce u téhož zaměstnavatele - výjimka: vojenská služba, nepl. skončení PP||
|181|A|A181|ZA++||
|181|B|B181|ZA++ - osmá souběžná dohoda o provedení práce u téhož zaměstnavatele ||
|182|A|A182|ZBD+||
|182|B|B182|ZBD+ - devátá souběžná dohoda o provedení práce u téhož zaměstnavatele - výdělečná činnost po dovršení důchodového věku||
|183|A|A183|ZBV+||
|183|B|B183|ZBV+ - devátá souběžná dohoda o provedení práce u téhož zaměstnavatele - výjimka: vojenská služba, nepl. skončení PP||
|184|A|A184|ZB++||
|184|B|B184|ZB++ - devátá souběžná dohoda o provedení práce u téhož zaměstnavatele ||
|185|A|A185|ZCD+||
|185|B|B185|ZCD+ - desátá souběžná dohoda o provedení práce u téhož zaměstnavatele - výdělečná činnost po dovršení důchodového věku||
|186|A|A186|ZCV+||
|186|B|B186|ZCV+ - desátá souběžná dohoda o provedení práce u téhož zaměstnavatele - výjimka: vojenská služba, nepl. skončení PP||
|187|A|A187|ZC++||
|187|B|B187|ZC++ - desátá souběžná dohoda o provedení práce u téhož zaměstnavatele ||

## CIS Důvod uplatnění slevy

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|A||
|2|B|B2|dosáhl alespoň 55 let||
|2|D|D2|Popis:||
|2|E|E2|Číselník Důvod uplatnění slevy, hodnoty a kód položky převzaty z originální datové věty||
|3|A|A3|B||
|3|B|B3|pečuje o dítě mladší 10 let, jehož je rodičem, nebo které má v péči nahrazující péči rodičů na základě rozhodnutí příslušného orgánu; za rozhodnutí příslušného orgánu se považuje rozhodnutí uvedené v § 7 odst. 10 zákona o státní sociální podpoře||
|3|D|D3|URL:||
|4|A|A4|C||
|4|B|B4|pečuje o osobu blízkou mladší 10 let, která je závislá na pomoci jiné osoby ve stupni I (lehká závislost), nebo o osobu blízkou, která je závislá na pomoci jiné osoby ve stupni II (středně těžká závislost) nebo stupni III (těžká závislost) anebo stupni IV (úplná závislost); osoba blízká se posuzuje podle § 24 odst. 1 zákona o důchodovém pojištění||
|4|D|D4|Poznámka:||
|4|E|E4|Uvádí se jedno z písmen A až G, podle toho, z jakého důvodu je sleva na pojistném za zaměstnance uplatňována dle § 7a odst. 1 zákona č. 589/1992 Sb. Je-li splněno více důvodů, vždy se uvede jen jeden.\nZaměstnavatel má nárok na slevu na pojistném za kalendářní měsíc za zaměstnance v pracovním nebo služebním poměru, který||
|5|A|A5|D||
|5|B|B5|se zároveň připravuje na budoucí povolání studiem a je mladší 26 let; studium se posuzuje podle § 21 odst. 1 písm. a), § 22 a 23 zákona o důchodovém pojištění||
|6|A|A6|E||
|6|B|B6|v období 12 kalendářních měsíců před kalendářním měsícem, za který se sleva na pojistném uplatňuje, nastoupil jako uchazeč o zaměstnání na rekvalifikaci podle § 109 nebo 109a zákona o zaměstnanosti||
|7|A|A7|F||
|7|B|B7|je osobou se zdravotním postižením podle § 67 odst. 2 zákona o zaměstnanosti||
|8|A|A8|G||
|8|B|B8|je mladší 21 let||

## CIS Důvod neposkytnutí podkladů

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ÚP||
|1|G|G1|SLOVNÍK||
|2|A|A2|2||
|2|B|B2|starobní důchod, zaměstnání bez účasti na pojištění - pojištěnec, jemuž skončilo zaměstnání, je poživatelem starobního důchodu, nebo skončené zaměstnání nezaložilo zaměstnanci účast na pojištění||
|2|D|D2|Popis:||
|2|E|E2|Číselník Důvodů neposkytnutí podkladů pro ÚP (podpora v nezaměstnanosti)||
|3|A|A3|3||
|3|B|B3|vybraná zaměstnání - soudci, členové zastupitelstev územních samosprávních celků, poslanci Poslanecké sněmovny PČR, senátoři Senátu PČR, členové vlády, prezident, viceprezident a členové NKÚ, členové RRTV, finanční arbitr a jeho zástupce, veřejný ochránce práv a jeho zástupce, členové Rady Ústavu pro studium totalitních režimů, členové Rady Českého telekomunikačního úřadu, členové Rady Energetického regulačního úřadu, členové Národní rozpočtové rady, pracovníci v pracovním vztahu podle cizích právních předpisů, fyzické osoby neuvedené v § 5, písm. a) bodech 1 až 21 zákona č. 187/2006 Sb., s výjimkou členů zastupitelstev územních samosprávných celků a zastupitelstev městských částí nebo městských obvodů územně členěných statutárních měst a hlavního města Prahy zvolených do funkcí, jež zastupitelstvo neurčilo jako funkce, pro které budou členové zastupitelstva uvolněni, státní zástupci vykonávající v ČR funkci evropských pověřených žalobců (§ 167g zákona č. 187/2006 Sb.)||
|3|D|D3|URL:||
|3|E|E3|Vyplňuje se v případě, že pojištěnec, u něhož skončilo zaměstnání, nemůže být evidován jako uchazeč o zaměstnání nebo u vybraných zaměstnání. Hodnoty a kód položky převzaty z originální datové věty.||

## CIS Druh zaměstnání

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ČSSZ||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|pracovněprávní vztah||
|2|D|D2|Popis:||
|2|E|E2|C_DRUHZAMUP  Číselník druhů zaměstnání pro ÚP (podpora v nezaměstnanosti)||
|3|A|A3|2||
|3|B|B3|služební poměr podle zákona č. 234/2014 Sb||
|3|D|D3|URL:||
|3|E|E3|https://www.cssz.cz/documents/20143/179422/C_DRUHZAMUP.htm||

## CIS Důvod ukončení PPV

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ÚP||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Ukončení PP cizince či osoby bez státní příslušnosti (§ 48 odst./3 zák. č. 262/2006 Sb., ve znění pozdějších předpisů (dále jen „ZP‘‘))||
|2|D|D2|Popis:||
|2|E|E2|Číselník důvodů ukončení pracovněprávního vztahu (PPV)||
|3|A|A3|2||
|3|B|B3|Dohodou se zaměstnavatelem (§ 49 ZP)||
|3|D|D3|URL:||
|3|E|E3|Číselník důvodů ukončení pracovněprávního vztahu pro ÚP (podpora v nezaměstnanosti)||
|4|A|A4|3||
|4|B|B4|Výpověď ze strany zaměstnance (§ 50 odst. /3 ZP)||
|4|D|D4|Poznámka:||
|4|E|E4|Pokud je vybrán druh zaměstnání pro ÚP typu 1 (pracovněprávní vztah), použije se číselník důvodů ukončení pracovněprávního vztahu pro ÚP (podpora v nezaměstnanosti). V případě vybrání důvodu neposkytnutí podkladů pro ÚP typu 1, 2 a 3 nebo v případě uvedení druhu výdělečné činnosti M, N, O, P, Q, R, S (List Číselník ČSSZ_Druh činnosti), se údaj „Důvod ukončení pracovněprávního vztahu” neuvádí.||
|5|A|A5|4||
|5|B|B5|Organizační důvod (§ 52 písm. /a-c ZP)||
|6|A|A6|5||
|6|B|B6|Zdravotní důvody (§ 52 písm./d, § 52 písm. /e, § 56 odst. /1 písm. a ZP)||
|7|A|A7|6||
|7|B|B7|Zaměstnanec nesplňuje předpoklady nebo požadavky pro výkon sjednané práce (§ 52 písm. /f ZP)||
|8|A|A8|7||
|8|B|B8|Porušení povinností zaměstnancem zvlášť hrubým způsobem (§ 52 písm. /g první část věty nebo § 55 odst. /1 písm. b ZP)||
|9|A|A9|8||
|9|B|B9|Soustavné méně závažné porušení povinností zaměstnancem (§ 52 písm. /g druhá část věty ZP)||
|10|A|A10|9||
|10|B|B10|Porušení režimu dočasně práce neschopného zvlášť hrubým způsobem (§ 52 písm. /h ZP)||
|11|A|A11|10||
|11|B|B11|Okamžité zrušení pracovního poměru z důvodu pravomocného odsouzení pro úmyslný trestný čin (§ 55 odst. /1 písm. a ZP)||
|12|A|A12|11||
|12|B|B12|Porušení podstatné povinností zaměstnavatelem (§ 56 odst. /1 písm. b ZP)||
|13|A|A13|12||
|13|B|B13|Doba určitá (§ 65 ZP)||
|14|A|A14|13||
|14|B|B14|Ve zkušební době zaměstnavatelem (§ 66 ZP)||
|15|A|A15|14||
|15|B|B15|Ve zkušební době zaměstnancem (§ 66 ZP)||
|16|A|A16|15||
|16|B|B16|Ostatní||

## CIS Důvod ukončení služ. poměru

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|ÚP||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|§ 71 zák. č. 234/2014 Sb. - doba určitá||
|2|D|D2|Popis:||
|2|E|E2|Číselník důvodů ukončení služebního poměru||
|3|A|A3|2||
|3|B|B3|§ 72 odst. /1 písm. a), c-e) zák. č. 234/2014 Sb.||
|3|D|D3|URL:||
|3|E|E3|Číselník důvodů ukončení služebního poměru pro ÚP (podpora v nezaměstnanosti)||
|4|A|A4|3||
|4|B|B4|§ 73 zák. č. 234/2014 Sb. - na žádost zaměstnance + § 73a zák. č. 234/2014 Sb. – na základě dohody mezi představeným a služebním orgánem||
|4|D|D4|Poznámka:||
|4|E|E4|Pokud je vybrán druh zaměstnání pro ÚP typu 2 (služební poměr podle zákona č. 234/2014 Sb.), použije se číselník důvodů ukončení služebního poměru pro ÚP (podpora v nezaměstnanosti). V případě vybrání důvodu neposkytnutí podkladů pro ÚP typu 1, 2 a 3, se údaj „Důvod ukončení služebního poměru” neuvádí.||
|5|A|A5|4||
|5|B|B5|§ 74 odst. /1 písm. a-i) a § 74 odst. /2 zák. č. 234/2014 Sb.||
|6|A|A6|5||
|6|B|B6|Ostatní||
|7|A|A7|6||
|7|B|B7|§ 72 odst. /1 písm. b) zák. č. 234/2014 Sb. ||

## CIS Důvod předčasného ukončení

|row|col|cell|value|comment|
|---|---|----|-----|--------|
|1|A|A1|Kód položky||
|1|B|B1|Název položky||
|1|D|D1|Zdroj:||
|1|E|E1|MPSV||
|1|G|G1|SLOVNÍK||
|2|A|A2|1||
|2|B|B2|Výpověď z některého z důvodů uvedených v § 52 písm. a) až e) zákoníku práce nebo dohodou z týchž důvodů||
|2|D|D2|Popis:||
|2|E|E2|Číselník důvodů ukončení zaměstnání ||
|3|A|A3|2||
|3|B|B3|Okamžitým zrušením podle § 56 zákoníku práce||
|3|D|D3|URL:||
|4|A|A4|3||
|4|B|B4|Z jiného důvodu||
|4|D|D4|Poznámka:||
