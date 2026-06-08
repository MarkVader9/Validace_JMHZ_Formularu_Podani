Samozřejmě, zde je upravený a přehledně naformátovaný skript **REVIZE 002**, zachovávající úhlednou strukturu a veškerá důležitá metodická upozornění pro vývojáře.

Tato verze bezpečně zpracuje jak **přímou cestu ke konkrétnímu XML souboru**, tak **cestu k celé složce** plné exportů od ČSSZ.

---

### 🛠️ Požadavky pro spuštění ve VB6:
Abyste tento kód mohli ve VB6 zkompilovat a spustit, musíte mít v projektu aktivované následující reference (*Project -> References*):
1. **Microsoft XML, v6.0** (nebo v3.0) – pro práci s `DOMDocument` (parsování struktury XML).
2. **Microsoft Scripting Runtime** – pro práci s `FileSystemObject` (validace a čtení složek/souborů).

---

### 💻 VB6 Skript: REGZEC_IMPORTUJ_ID_UDAJE_OD_CSSZ (REVIZE-002)

```vb
' ==============================================================================
' Modul:      Zpracování XML exportu zaměstnanců JMHZ (Aricoma/CSSZ)
' Revize:     002 (Podpora pro zadání cesty ke složce i přímo k XML souboru)
' ==============================================================================
Option Explicit

' ------------------------------------------------------------------------------
' HLAVNÍ FUNKCE: Přijímá cestu (ke složce nebo přímo k souboru .xml)
' ------------------------------------------------------------------------------
Public Sub ZpracujJMHZ(cesta As String)
    Dim fso As Object
    Set fso = CreateObject("Scripting.FileSystemObject")
    
    ' SCÉNÁŘ 1: Uživatel zadal cestu k celé SLOŽCE
    If fso.FolderExists(cesta) Then
        Dim fld As Object
        Dim fl As Object
        
        Set fld = fso.GetFolder(cesta)
        
        ' Průchod všemi soubory ve složce
        For Each fl In fld.Files
            If LCase(fso.GetExtensionName(fl.Name)) = "xml" Then
                ZpracujJedenXMLSoubor fso, fl.Path
            End If
        Next fl
        MsgBox "Zpracování složky dokončeno.", vbInformation
        
    ' SCÉNÁŘ 2: Uživatel zadal cestu přímo k XML SOUBORU
    ElseIf fso.FileExists(cesta) Then
        If LCase(fso.GetExtensionName(cesta)) = "xml" Then
            ZpracujJedenXMLSoubor fso, cesta
            MsgBox "Zpracování souboru dokončeno.", vbInformation
        Else
            MsgBox "Zadaný soubor není ve formátu XML.", vbExclamation
        End If
        
    ' SCÉNÁŘ 3: Cesta je zcela neplatná (neexistuje)
    Else
        MsgBox "Zadaná cesta neexistuje (nenalezena složka ani soubor): " & vbCrLf & cesta, vbCritical
    End If
    
    Set fso = Nothing
End Sub

' ------------------------------------------------------------------------------
' POMOCNÁ FUNKCE: Samotná extrakce a parsování dat z jednoho XML souboru
' ------------------------------------------------------------------------------
Private Sub ZpracujJedenXMLSoubor(fso As Object, filePath As String)
    Dim xmlDoc As Object
    Dim nodeList As Object
    Dim nodeZamestnanec As Object
    Dim node As Object
    
    ' Datové proměnné pro mzdový software
    Dim strRC As String
    Dim strECP As String
    Dim strIKMPSV As String
    Dim strIDPPV As String
    Dim isCizinec As Boolean
    
    ' Inicializace XML DOM
    Set xmlDoc = CreateObject("MSXML2.DOMDocument.6.0")
    xmlDoc.async = False
    xmlDoc.Load filePath
    
    ' Pokud se XML načte bez chyb, zahájíme parsování
    If xmlDoc.parseError.ErrorCode = 0 Then
        
        ' Načteme všechny uzly typu <Zamestnanec>
        Set nodeList = xmlDoc.getElementsByTagName("Zamestnanec")
        
        For Each nodeZamestnanec In nodeList
            strRC = ""
            strECP = ""
            strIKMPSV = ""
            strIDPPV = ""
            isCizinec = False
            
            ' 1. Načtení Identifikátoru PPV
            Set node = nodeZamestnanec.selectSingleNode("IdZamestnani")
            If Not node Is Nothing Then strIDPPV = node.Text
            
            ' 2. Načtení Osobního identifikačního čísla (OIČ / IK MPSV)
            Set node = nodeZamestnanec.selectSingleNode("OIC")
            If Not node Is Nothing Then strIKMPSV = node.Text
            
            ' 3. Zpracování identifikátorů osoby (EČP má prioritu u cizinců)
            Set node = nodeZamestnanec.selectSingleNode("EvidencniCisloPojistence")
            If Not node Is Nothing Then
                strECP = node.Text
                isCizinec = True
            End If
            
            Set node = nodeZamestnanec.selectSingleNode("RodneCislo")
            If Not node Is Nothing Then strRC = node.Text
            
            ' ------------------------------------------------------------------
            ' ZDE SE VOLÁ LOGIKA VAŠEHO MZDOVÉHO SOFTWARU (SQL UPDATE / INSERT)
            ' ------------------------------------------------------------------
            If isCizinec Or (strECP <> "") Then
                Debug.Print "Nalezen CIZINEC:"
                Debug.Print "--> Aktualizuji kartu zaměstnance, priorita EČP: " & strECP
                Debug.Print "--> Doplňuji IK MPSV: " & strIKMPSV & " a ID PPV: " & strIDPPV
                
                ' Zde doplňte vlastní kód pro uložení cizince do databáze SW
            Else
                Debug.Print "Nalezen OBČAN ČR:"
                Debug.Print "--> Aktualizuji kartu zaměstnance přes RČ: " & strRC
                Debug.Print "--> Doplňuji IK MPSV: " & strIKMPSV & " a ID PPV: " & strIDPPV
                
                ' Zde doplňte vlastní kód pro uložení běžného občana do databáze SW
            End If
            
        Next nodeZamestnanec
    Else
        ' Chybový výpis v případě poškozeného XML
        Debug.Print "Chyba parsování souboru: " & filePath & " (Důvod: " & xmlDoc.parseError.reason & ")"
    End If
    
    ' Úklid paměti po zpracování souboru
    Set xmlDoc = Nothing
    Set nodeList = Nothing
    Set nodeZamestnanec = Nothing
    Set node = Nothing
End Sub
```

---

### 💡 Na co si dát jako vývojář pozor (Shrnutí procesní logiky):

*   **Změna v Revizi 002:** Hlavní funkce nyní používá rozhodovací logiku `If fso.FolderExists(...)` a `ElseIf fso.FileExists(...)`. Parsovací kód byl vyčleněn do bezpečné `Private Sub`, takže se neopakuje a kód je modulární. Můžete tak skriptu předat cestu `C:\Exporty\` i `C:\Exporty\SeznamZamestnancu.xml` a v obou případech proběhne korektně.
*   **Terminologický rozdíl (OIC vs. IK MPSV):** XML schéma `SeznamZamestnancu.xsd` používá tag `<OIC>` (Osobní identifikační číslo), avšak datový slovník podání REGZEC (ID 10051) a Měsíčního hlášení tento údaj eviduje pod technickým názvem **IK MPSV**. Databázové sloupce ve vašem SW by měly reflektovat název, který používáte pro generování XML podání.
*   **Terminologický rozdíl (IdZamestnani vs. ID PPV):** XML tag se jmenuje `<IdZamestnani>`, ale v datové větě REGZEC jej budete emitovat do atributu `oid` (ID 10228) a komunikovat o něm jako o **ID PPV**.
*   **Prioritizace EČP u cizinců (Q&A 93):** Metodika upozorňuje na specifické chování u cizinců. Pokud cizinec nemá české rodné číslo, systém ČSSZ mu přiděluje Evidenční číslo pojištěnce (EČP). Váš mzdový software musí zajistit, že jakmile je u pracovníka detekováno EČP, **bude se toto EČP vždy prioritně emitovat do XML REGZEC** (atribut `bno`) namísto jakéhokoliv formálního nebo dočasného "rodného čísla". Předejdete tím zamítnutí dávek na straně ePortálu ČSSZ.