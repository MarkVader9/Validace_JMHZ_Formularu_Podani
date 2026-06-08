
Private Sub Command1_Click()
BylStiskPreoctu = 1
Command1.Enabled = False

TestZmenPoPrepoctu ("Přepočet")
   StartPrep
End Sub

Public Sub StartPrep()
       '  On Error GoTo Command1_Click_Err
    Dim MaxM As String
    Dim Cpol As Integer
    Dim a As Integer
    Dim i As Integer
    Dim RsPojjSum As Recordset
    Dim MaxRsPojjSum As Integer
    Dim RsPojj As Recordset
    Dim MaxRsPojj As Integer
    Dim PojjKod As String
    Dim CisPolM As Integer
    Dim ZamTyp As String
    Dim FNameP2 As String
    Dim Presundobirky As String
    Dim veta As String
    Dim SumaDoKonstan As Double
    Dim MAxKonstanty As Integer
    Dim SumMesic As Double
    Dim Sum272(25) As Double
    Dim Sum471(25) As Double
    Dim Sum472(25) As Double
    Dim Sum476(25) As Double
    Dim Sum274(25) As Double
    Dim Sum277(25) As Double
    Dim Sum354(25) As Double
    Dim KodPojjMesic(25) As String
    Dim PocLidi(25) As Integer
    Dim Promile As Single
    Dim aaa As Integer
    Dim zamm As Integer
    Dim jj As Integer
    Dim PZam As Integer
    Dim MinMes As Integer
    Dim MinRok As Integer
    Dim VetaVstup As String
   ' Dim FName As String
    Dim FNameShl As String
    Dim DenSV As Single
    Dim s As String
   Dim RokOd As Integer
   Dim RokDo As Integer
   Dim MesOd As Integer
   Dim MesDo As Integer
 Dim DatEldpOd1 As Date
Dim OsobC As String
Dim cesta As String
Dim cesta2 As String
     PZam = 0
     
''Dim Konst(30) As Single

Presundobirky = ""
  MaxRsPojj = 0
  MaxRsPojjSum = 0
 ' nactení konstant ------
    ' RsKonstanty.MoveFirst: MAxKonstanty = RsKonstanty.RecordCount
    '  For i = 1 To MAxKonstanty: Konst(i) = Val(RsKonstanty.Fields("ponapln")): RsKonstanty.MoveNext: Next i
      
      On Error GoTo NeniPoj
    Set RsPojjSum = DbUdaje.OpenRecordset("SELECT * FROM PojSum")
      On Error GoTo NeniPoj
        RsPojjSum.MoveLast
        RsPojjSum.MoveFirst
        MaxRsPojjSum = RsPojjSum.RecordCount
NeniPoj:

    Set RsPojj = DbUdaje.OpenRecordset("SELECT * FROM Pojistovny WHERE trim(PojNazev) <> """"") ' otevři tabulku
        RsPojj.MoveLast
        RsPojj.MoveFirst
        MaxRsPojj = RsPojj.RecordCount
      
   
          For a = 1 To MaxRsPojj  ' vynuluj součty
            Sum272(a) = 0
            Sum471(a) = 0
            Sum472(a) = 0
            Sum476(a) = 0
            Sum274(a) = 0
            Sum277(a) = 0
            Sum354(a) = 0
            KodPojjMesic(a) = " "
            PocLidi(a) = 0
          Next a

  
  
            RsPamch.AddNew
              RsPamch.Fields("Datum") = Format(date, "dd/mm/yyyy")
              RsPamch.Fields("Cas") = Format(Time, "hh/mm/ss")
              RsPamch.Fields("OsCislo") = "0"
              RsPamch.Fields("CisPol") = "0"
              RsPamch.Fields("Napln") = "Přepočet spuštěn"
              RsPamch.Fields("Rezerva") = " "
            RsPamch.Update
  
   Zodd = 0
        Frame3.Visible = True
        Frame3.Caption = " Probíhá přepočet všech zaměstnanců - prosím čekejte "
        ProgressBar1.Value = 0
        ProgressBar1.Max = MaxZam ' při databazi  počet záznamů v Rs
        i = 1
            For a = 1 To 800
              SumaMzd(a) = 0
            Next a
          
     FNameP2 = PathPilirII & "Pil" & Format(Datum(1, SysMes, SysRok), "yyyymm") & ".txt" 'strana 2
      On Error Resume Next
      Open FNameP2 For Output As #2 ' druhej pilíř
       
     Command3.Visible = True
     zamm = PocetZamA
         aaa = 1
         jj = 1
         
 
   FNameShl = PathTXT & "\SocHlZ.txt" ' zapíše lidi pro Soc slevu formulář
     If FileExist(FNameShl) = 1 Then: Kill FNameShl
   Open FNameShl For Output As #1
         
   OsobC = ZOsCislo
   Promile = Val(Replace(Trim(RsFirma.Fields("FKoopPr")), ",", "."))
  KrokJM
  StartDB
     Do
        NahrajZam (ZOsCislo)
      Command3.Caption = " Budu přepočítávat " & Str(zamm) & " zaměstnanců - přepočteno " & Str(aaa)
       
   '   If InStr(O(166), "msss") > 0 Then
   '     P(130) = Mid(O(166), 1, InStr(O(166), "msss") - 1) + "msssvejprty.cz"
   '   End If
       
       
ResultText(1) = "VypoctiDuchod"
ResultCislo(1) = Val(O(199))
ResultText(2) = O(20)
ResultText(3) = O(100)
FrmOdd.VypoctiDuchod
'MsgBox (O(224) & "   " & ResultText(1))
O(224) = ResultText(1)
ResultText(1) = ""
ResultCislo(1) = 0
ResultText(2) = ""
ResultText(3) = ""
       
       
       
       If Trim(O(166)) > 4 And Trim(P(130)) = "" Then: P(130) = O(166): O(166) = "" ' Zrušení položky emailu a nahrazení jinou
       O(166) = ""
       If Trim(P(130)) = "" Then: P(130) = "@"
      If InStr(1, P(397), "směnn") = 0 Then
       If P(20) <> "Turnusová" And Trim(P(397)) = "" Then: P(397) = "jednosměnný"
       If P(20) = "Turnusová" And Trim(P(397)) = "" Then: P(397) = "dvousměnný"
      End If
     If SysRok = 2025 Then: O(149) = ""
 
If O(179) = "Ano " Then
   If Mid(O(174), 1, 10) = "00.00.0000" Then: DatOd = Datum(1, SysMes, SysRok)
   If Mid(O(174), 1, 10) <> "00.00.0000" And Trim(O(174)) <> "" Then: DatOd = CDate(Mid(O(174), 1, 10))
   If Mid(O(173), 1, 10) = "00.00.0000" Then: DatDo = DateSerial(SysRok, SysMes + 1, 0)
   If Mid(O(173), 1, 10) <> "00.00.0000" And Trim(O(173)) <> "" Then: DatDo = CDate(Mid(O(173), 1, 10))
   M(116) = 1
   If DatOd > DateSerial(SysRok, SysMes + 1, 0) Then: M(116) = 0:
   If DatDo < Datum(1, SysMes, SysRok) Then: M(116) = 0
   If O(116) = "Ano" Then: M(119) = M(116)
End If
If O(354) = "MD" Then
  MesOd = CInt(Mid(Mid(O(350), 1, 10), 4, 2)): RokOd = CInt(Mid(Mid(O(350), 1, 10), 7, 4))
  MesDo = CInt(Mid(Mid(O(352), 1, 10), 4, 2)): RokDo = CInt(Mid(Mid(O(352), 1, 10), 7, 4))
  i = 0
  If RokOd <= SysRok And RokDo >= SysRok And Mid(O(350), 1, 10) <> "00.00.0000" Then
     If RokDo > SysRok Then: MesDo = 12
     If RokOd < SysRok Then: MesOd = 1
     If MesOd <= SysMes And MesDo >= SysMes And Mid(O(352), 1, 10) <> "00.00.0000" Then: i = 1
      
  End If
  If i = 1 Then: O(227) = "E  mateřská dovolená": O(228) = O(310): O(229) = O(340)
' MsgBox (MesOd & "   " & MesDo & "   " & RokOd & "   " & RokDo & "   " & i)
End If
           MaxM = RsM.RecordCount ' počet položek v recordsetu
  
          RsPojj.MoveFirst
         For a = 1 To MaxRsPojj ' přes všechny pojistovny
     
           If Trim(RsPojj.Fields("PojZkratka")) = Trim(P(49)) Then
            M(117) = Val(Trim(RsPojj.Fields("PojKod")))
            P(638) = M(117)
            Sum272(a) = Sum272(a) + M(272)
            Sum471(a) = Sum471(a) + M(471)
            Sum472(a) = Sum472(a) + M(472)
            Sum476(a) = Sum476(a) + M(476)
            Sum274(a) = Sum274(a) + M(274)
            Sum277(a) = Sum277(a) + M(277)
            Sum354(a) = Sum354(a) + M(354)
           'If Trim(ZOsCislo) = "220" Then: MsgBox (M(491))
             If Trim(P(46)) <> "Nedaněno" And Trim(P(117)) <> "Ne" And M(491) + M(493) > 0 Then
                 PocLidi(a) = PocLidi(a) + 1
                 If Trim(P(51)) = "Činnost malého rozsahu" And M(272) <= 2500 Then: PocLidi(a) = PocLidi(a) - 1
                 If O(320) = "Dohoda o prov.p" And M(272) = 0 Then: PocLidi(a) = PocLidi(a) - 1
               ' If P(49) = "ZPMVCR" Then: MsgBox (ZOsCislo & ZPrijmeni)
             End If
             
              KodPojjMesic(a) = Trim(RsPojj.Fields("PojKod"))
           End If
           RsPojj.MoveNext
         Next a
      
          If Trim(O(320)) = "Neuvolnění" Then: O(269) = "14 Neuvolněný"
       If Trim(P(5)) = "" Then
         P(5) = "1112"
         If Mid(O(340), 1, 10) = "00.00.0000" Then: P(5) = "1111"
       End If
           ZamTyp = UCase$(Mid$(O(269), 1, 1))      ' pro zákonn= poj.
             If ZamTyp = "S" And O(320) = "Hlavní" Then: ZamTyp = "H"
             If O(320) = "Uvolnění" Then: ZamTyp = "S"
             
           M(296) = 0
        If ZamTyp <> "S" And ZamTyp <> "R" And ZamTyp <> "P" Then
           M(296) = M(271) + M(261) + M(251) + M(411) + M(355)
           M(279) = Round(M(296) * (Promile / 1000), 4)

        
         If SysRok = 2025 And SysMes < 4 Then
           M(296) = M(271) + M(261) + M(251) + M(331) + M(411) + M(355)
           M(279) = Round(M(296) * (Promile / 1000), 4)
         End If
 
        End If
        M(466) = Abs(O(320) = "Dohoda o čin.")
        M(467) = Abs(O(320) = "Dohoda o prov.p")
        
            M(82) = 0
              For DenSV = 1 To Len(KalVeta(3))
              If Mid(KalVeta(2), DenSV, 1) <> "S" And Mid(KalVeta(2), DenSV, 1) <> "N" Then
               If Mid(KalVeta(3), DenSV, 1) = "S" Then
                If Trim(Mid(KalVeta(1), DenSV * 2 - 1, 2)) = "" Then
                   M(82) = M(82) + Val(P(23))
                End If
               End If
              End If
             Next DenSV
      
     If SysMes = 2 And SysRok = 2017 Then: DatumOprava
     If Val(P(105)) = Val(P(62)) Then: P(105) = 0: P(106) = 0: UlozDataP
     DetiOdecet
      ResultText(10) = "Prep"
         PZam = PZam + 1
 If Mid(LicenceCis, 11, 8) = IcoZitkova And O(328) = "Ano" Then: PZam = PZam - 1
'  If Mid(LicenceCis, 11, 8) = IcoZitkova And O(328) <> "Ano" Then: PZam = PZam + 1

    If Trim(P(268)) <> "Ano" Then: P(268) = "Ne"
    
        Alg3
          
    If M(7) = 0 And M(465) <> 0 Then: O(327) = "H-4.Odlož.příjem":

         M(422) = M(422) + 1000  ' kontrola že prošel algM M(422) = M(422) + 1000  ' kontrola že prošel algM
   '      If Val(P(30)) > 0 Then: PrepOdLedna
         M(422) = M(422) + 1    ' kontrola že prošel FrmDovolenaGraf.Display
        
       If O(100) <> "" Or O(13) <> "" Then
' If Val(O(120)) <> 100 Then: x = x + 1: Hlaska(x) = "Parametry mzdy nejsou úplné!!! Je rozděleno pouze " + Str(Val(O(121)) + Val(O(122)) + Val(O(123)) + Val(O(124)) + Val(O(125)) + Val(O(126)) + Val(O(127)) + Val(O(128))) + "% mzdy. Opravte v Osobním odd. dole v položce - Parametry pro rozdělení mzdy"
 i = 0: M(500) = 0
 
  For a = 1 To 8
     M(500 + a) = 0: M(510 + a) = 0: M(520 + a) = 0: M(530 + a) = 0
      If i = 0 And Val(O(120 + a)) > 0 Then
        i = a
      Else
        If Oprava(500 + a) = 0 Then: M(500 + a) = Round(M(202) * Val(O(120 + a)) / 100, 2)
        If Oprava(510 + a) = 0 Then: M(510 + a) = Round((M(273) + M(252) + M(412)) * Val(O(120 + a)) / 100, 2)
        If Oprava(520 + a) = 0 Then: M(520 + a) = Round(M(274) * Val(O(120 + a)) / 100, 2)
        If Oprava(530 + a) = 0 Then: M(530 + a) = Round((M(655) + M(656)) * Val(O(120 + a)) / 100, 2)
        M(500) = M(500) + M(500 + a) + M(510 + a) + M(520 + a) + M(530 + a)
      End If
  Next a
  
 If Oprava(500 + i) = 0 Then: M(500 + i) = Round(M(202) - (M(501) + M(502) + M(503) + M(504) + M(505) + M(506) + M(507) + M(508)), 2)
 If Oprava(510 + i) = 0 Then: M(510 + i) = Round(M(273) + M(252) + M(412) - (M(511) + M(512) + M(513) + M(514) + M(515) + M(516) + M(517 + M(518))), 2)
 If Oprava(520 + i) = 0 Then: M(520 + i) = Round(M(274) - (M(521) + M(522) + M(523) + M(524) + M(525) + M(526) + M(527) + M(528)), 2)
 If Oprava(530 + i) = 0 Then: M(530 + i) = Round((M(655) + M(656)) - (M(531) + M(532) + M(533) + M(534) + M(535) + M(536) + M(537) + M(538)), 2)
 
 M(500) = M(500) + M(500 + i) + M(510 + i) + M(520 + i) + M(530 + i)
 
Else
   M(500) = 0
    For a = 1 To 8
      M(500 + a) = 0: M(510 + a) = 0: M(520 + a) = 0: M(530 + a) = 0
    Next a
End If
  
If M(561) + M(562) + M(563) + M(564) + M(565) + M(566) + M(567) + M(568) > 0 Then

i = 0: M(500) = 0
  For a = 1 To 8
     M(500 + a) = 0: M(510 + a) = 0: M(520 + a) = 0: M(530 + a) = 0
      If i = 0 And M(560 + a) > 0 Then: i = a
       
        If Oprava(500 + a) = 0 Then: M(500 + a) = Round(M(202) / M(2) * M(560 + a), 2)
        If Oprava(510 + a) = 0 Then: M(510 + a) = Round((M(273) + M(252) + M(412)) / M(2) * M(560 + a), 2)
        If Oprava(520 + a) = 0 Then: M(520 + a) = Round(M(274) / M(2) * M(560 + a), 2)
        If Oprava(530 + a) = 0 Then: M(530 + a) = Round((M(655) + M(656)) / M(2) * M(560 + a), 2)
        M(500) = M(500) + M(500 + a) ' + M(510 + a) + M(520 + a) + M(530 + a)
     
    Next a
' If M(561) + M(562) + M(563) + M(564) + M(565) + M(566) + M(567) <> M(2) Then: x = x + 1: Hlaska(x) = " V Parametrickém rozdělení mezd nesouhlasí rozdělení hodin !!!" + Str(M(561) + M(562) + M(563) + M(564) + M(565) + M(566) + M(567)) + " <> " + Str(M(2))
' If Oprava(500 + i) = 0 Then: M(500 + i) = Round(M(202) - (M(501) + M(502) + M(503) + M(504) + M(505) + M(506) + M(507) + M(508)), 2)
' If Oprava(510 + i) = 0 Then: M(510 + i) = Round(M(273) - (M(511) + M(512) + M(513) + M(514) + M(515) + M(516) + M(517 + M(518))), 2)
' If Oprava(520 + i) = 0 Then: M(520 + i) = Round(M(274) - (M(521) + M(522) + M(523) + M(524) + M(525) + M(526) + M(527) + M(528)), 2)
' If Oprava(530 + i) = 0 Then: M(530 + i) = Round((M(655) + M(656)) - (M(531) + M(532) + M(533) + M(534) + M(535) + M(536) + M(537) + M(538)), 2)
 
' M(500) = M(500) + M(500 + a) '+ M(510 + i) + M(520 + i) + M(530 + i)
Else
 If Val(O(120)) = 0 Then
   M(500) = 0
    For a = 1 To 8
      M(500 + a) = 0: M(510 + a) = 0: M(520 + a) = 0: M(530 + a) = 0
    Next a
 End If
End If
   
  
   ' If FirmaIco = IcoLoffler Then ' Loffler
   '  If (Trim(P(3)) = "" Or Trim(P(3)) = "0") Then
   '   If NahrajOsPam(ZOsCislo, 6, 2020) = 1 Then: P(3) = OldP(3)
   '  End If
   ' End If
   
 
   
      MinMes = SysMes - 1
      MinRok = SysRok
      If MinMes = 0 Then: MinMes = 12: MinRok = SysRok - 1
      If NahrajOsPam(ZOsCislo, MinMes, MinRok) = 1 Then
      
          a = 0
           For i = 200 To 216 Step 2
              a = a + 1
              
           If SysMes = 1 Then
             O(51 + i) = O(270 + a)
             If Trim(O(51 + i)) = "" Then: O(51 + i) = "X"
           Else
             If Trim(OldO(51 + i)) = "" Then:
             OldO(51 + i) = String(SysMes - 1, "X")
             If Trim(O(51 + i)) = "" Then
               O(51 + i) = "X"
             Else
               O(51 + i) = OldO(51 + i) + O(270 + a)
             End If
           End If
           Next i
          If Trim(OldP(510)) <> "" Then
            If Trim(OldP(510)) <> Trim(P(510)) Then: MsgBox ("Změna účtu pro výplatu - (položka P510)  u zaměstnance: " & vbCrLf + Trim(ZOsCislo) + " " + Trim(ZJmeno) + " " + Trim(ZPrijmeni) & vbCrLf + "č.ú. minulý měsíc " + Trim(OldP(510)) & vbCrLf + "       tento   měsíc " + P(510) & vbCrLf + "Zkontrolujte si číslo účtu PRO NEMOC v okně P279 nyní je: " + P(469))
   
          End If
      End If
  If NahrajOsPam(ZOsCislo, SysMes, SysRok) = 1 Then:
      ResultText(10) = ""
          If Trim(P(48)) <> "" Then
            If Trim(P(49)) <> Trim(P(48)) Then: MsgBox ("Změna zdravotní pojišťovny u zaměstnance: " & vbCrLf + Trim(ZOsCislo) + " " + Trim(ZJmeno) + " " + Trim(ZPrijmeni) & vbCrLf + "č.ú. minulý měsíc " + Trim(P(48)) & vbCrLf + "       tento   měsíc " + P(49))
          End If

      If SysRok > 2020 Then
         DovolenaUlozRadek2021
      Else
         DovolenaUlozRadek
      End If
     If SysMes = 12 And SysRok = 2025 Then
      P(280) = "": P(281) = "": P(283) = "": P(525) = "": P(285) = "": P(287) = "": P(282) = "": P(288) = "": P(286) = "": P(290) = "": P(291) = "":
      P(293) = "": P(526) = "": P(295) = "": P(297) = "": P(292) = "": P(298) = "": P(296) = "": P(300) = "": P(301) = "": P(303) = "": P(527) = "":
      P(305) = "": P(307) = "": P(302) = "": P(308) = "": P(306) = "": P(310) = "": P(311) = "": P(313) = "": P(528) = "": P(315) = "": P(317) = "":
      P(312) = "": P(318) = "": P(316) = "": P(320) = "": P(321) = "": P(323) = "": P(529) = "": P(325) = "": P(327) = "": P(322) = "": P(328) = "":
      P(326) = "": P(350) = "": P(351) = "": P(353) = "": P(223) = "": P(354) = "": P(355) = "": P(358) = "": P(352) = "": P(356) = "": P(357) = "":
      P(360) = "": P(361) = "": P(363) = "": P(225) = "": P(364) = "": P(365) = "": P(368) = "": P(362) = "": P(366) = "": P(367) = "": P(370) = "":
      P(371) = "": P(226) = "": P(373) = "": P(374) = "": P(375) = "": P(378) = "": P(372) = "": P(376) = "": P(377) = "": P(380) = "": P(381) = "":
      P(383) = "": P(227) = "": P(384) = "": P(385) = "": P(388) = "": P(382) = "": P(386) = "": P(387) = "": P(390) = "": P(391) = "": P(393) = "":
      P(228) = "": P(394) = "": P(395) = "": P(398) = "": P(392) = "": P(396) = ""
     End If
    If Mid(O(232), 1, 10) <> "00.00.0000" And Mid(O(237), 1, 10) = "00.00.0000" Then: O(237) = O(232)
    If Trim(O(163)) <> "" Then: O(166) = "CZ"
    If Trim(O(112)) = "ČR" Then: O(112) = "CZ"
    If Trim(O(155)) = "ČR" Then: O(155) = "CZ"
    If Mid(O(269), 1, 1) = "S" Then: O(327) = "I-Činnost krátkodobá"
    'If M(479) > 0 Then: O(495) = Str(M(479))
   ' If Trim(P(5)) = "" Then
      If Mid(O(340), 1, 10) = "00.00.0000" Then
      P(5) = "1111"
       If O(320) = "Uvolnění" Or O(320) = "Neuvolnění" Then: P(5) = "1122"
       If O(320) = "Dohoda o čin." Then: P(5) = "1211"
       If O(320) = "Dohoda o prov.p" Then: P(5) = "1221"
      Else
      P(5) = "1112"
       If O(320) = "Uvolnění" Or O(320) = "Neuvolnění" Then: P(5) = "1122"
       If O(320) = "Dohoda o čin." Then: P(5) = "1222"
       If O(320) = "Dohoda o prov.p" Then: P(5) = "1222"
      End If
    'End If
    If Trim(O(10)) = Trim(O(11)) Then: O(11) = ""
    If Mid(P(60), 1, 10) = "00.00.0000" Or Trim(P(60)) = "" Then
      P(60) = O(310): P(429) = O(340)
    End If
      ELDPos
    If SysMes > 2 Then: P(108) = "Ne"



      If P(10) = "D1-4" Then: P(10) = "D1-6"
      If P(10) = "D1-4/Dohoda" Then: P(10) = "D1-6/Dohoda"
     ' If SysMes = 1 And SysRok = 2019 And FirmaIco = IcoLoffler And O(320) = "Hlavní" Then: P(79) = Konst(23)
      If Konst(24) = 0 Then: P(36) = 0: P(154) = 0
      If M(260) - (M(275) + M(211) + M(290) + M(420) + M(421) + M(680) + M(460) + M(450) + M(362)) <> 0 And M(260) > 0 Then: MsgBox (ZOsCislo & "  " & ZPrijmeni & " Zkontrolujte všechny srážky včetně doplatku!!!")
     ' MsgBox (Konst(24))
      
      
      
             On Error Resume Next
          ProgressBar1.Value = jj
          jj = jj + 1

            For a = 1 To 800
              SumaMzd(a) = SumaMzd(a) + M(a)
            Next a
         
            If P(250) = "Ano" Then
                  veta = Trim(O(100)) & Space(12 - Len(Trim(O(100))))
                  veta = veta & Trim(ZJmeno) & Space(20 - Len(Trim(ZJmeno)))
                  veta = veta & Trim(ZPrijmeni) & Space(30 - Len(Trim(ZPrijmeni)))
                  veta = veta & Trim(ZOsCislo) & Space(15 - Len(Trim(ZOsCislo)))
                  veta = veta & Trim(Str(M(271) + M(261) + M(251) + M(331) + M(411))) & Space(10 - Len(Trim(Str(M(271) + M(261) + M(251) + M(331) + M(411)))))
                  veta = veta & Trim(Str(M(294))) & Space(10 - Len(Trim(Str(M(294)))))
                  veta = veta & Trim(Str(M(293))) & Space(10 - Len(Trim(Str(M(293)))))
                  veta = veta & Trim(Str(M(295))) & Space(10 - Len(Trim(Str(M(295)))))
                  veta = veta & Trim(Str(M(283))) & Space(10 - Len(Trim(Str(M(283)))))
                  veta = veta & Trim(Str(M(299))) & Space(10 - Len(Trim(Str(M(299)))))
                 Print #2, veta
             End If
      
setu:
   aaa = aaa + 1
     M(111) = 1
      If Trim(P(16)) = "" Then: P(16) = "0"
      If Trim(P(19)) = "" Then: P(19) = "0"
      
    If M(261) + M(332) + M(333) > 0 Then ' udaje o zaměstnancích pro hlášení na Socialku
      VetaVstup = ZPrijmeni + Space(26 - Len(ZPrijmeni))
      VetaVstup = VetaVstup + ZJmeno + Space(25 - Len(ZJmeno))
      VetaVstup = VetaVstup + " " + Trim(Mid(O(20), 1, 10)) + " "
           
      If Trim(O(100)) <> "" Then
        VetaVstup = VetaVstup + O(100) + Space(20 - Len(O(100)))
      Else
        VetaVstup = VetaVstup + O(13) + Space(20 - Len(O(13)))
      End If
       
      VetaVstup = VetaVstup + Str(M(261) + M(332) + M(333)) + Space(20 - Len(Str(M(261) + M(332) + M(333))))
      
      s = ""
      If Trim(P(267)) = "Starší 55 let" Or Mid(Trim(P(267)), 1, 2) = "a " Then: s = "a"
      If Trim(P(267)) = "Péče o dítě" Or Mid(Trim(P(267)), 1, 2) = "b " Then: s = "b"
      If Trim(P(267)) = "Péče o závislou" Or Mid(Trim(P(267)), 1, 2) = "c " Then: s = "c"
      If Trim(P(267)) = "Studium" Or Mid(Trim(P(267)), 1, 2) = "d " Then: s = "d"
      If Trim(P(267)) = "Rekvalifikace" Or Mid(Trim(P(267)), 1, 2) = "e " Then: s = "e"
      If Trim(P(267)) = "Invalidita" Or Mid(Trim(P(267)), 1, 2) = "f " Then: s = "f"
      If Trim(P(267)) = "Mladší 21 let" Or Mid(Trim(P(267)), 1, 2) = "g " Then: s = "g"
    
      
      
      VetaVstup = VetaVstup + Space(9) + s + Space(10) ' důvod uplatnění slevy
    If s <> "g" Then
      VetaVstup = VetaVstup + Space(8) + Trim(Str(Round(Val(P(26)), 3))) + Space(12) ' rozsah kratší prac. doby v hodinách
    End If
     Print #1, VetaVstup
    End If
    
    cesta = PathXml + "\Zamestnanci.xml"
    If Trim(O(14)) = "" Then: Call ZpracujJMHZ(cesta)
    
   ' cesta2 = PathXml + "\Guid.xml"
   
   ' Call NactiGUID

      If Val(P(492)) = 0 Or Trim(P(492)) = "" Then: P(492) = Trim(Str(Round(Val(P(26)) / Val(P(25)) * 100, 2))) ' stanovený uvazek
      If Trim(O(128)) = "0" Then: O(128) = ""
      
      UlozDataO
      UlozDataP
      UlozDataM
      
      
    Loop Until KrokZam = 0
   Close #1
    
  
 ' MsgBox (PocetZamA & "   " & aaa - 1)
   
  
    Close #2 ' druhej pilíř
    
       '=== uložení sumy do tabulky RekapSum
     Set Rszam1 = DbUdaje.OpenRecordset("SELECT * FROM RekapSum WHERE Mesic = " & SysMes & " order by  PoCislo")
            Rszam1.MoveLast
            Rszam1.MoveFirst
          
            For a = 1 To 800
              Rszam1.Edit
               Rszam1.Fields("PoSuma") = SumaMzd(a)
               Rszam1.Fields("PoCislo") = a

                   RsKonstanty.MoveLast
                   RsKonstanty.MoveFirst
                   MAxKonstanty = RsKonstanty.RecordCount

               If a = 290 And SumaMzd(a) < 0 Then
                   SumaDoKonstan = SumaMzd(290) - SumaMzd(285) - SumaMzd(286)
                     For i = 1 To MAxKonstanty
                      If SysMes = 1 And i = 18 Then
                         RsKonstanty.Edit: RsKonstanty.Fields("ponapln") = Str(SumaDoKonstan): RsKonstanty.Update
                           Msg = "Daň je uložena pro pozdější odpočet: " & Str(SumaDoKonstan) & ",- Kč": MsgVykricnik
                       End If 'SysMes = 1
                       
                      If SysMes = 2 And i = 19 Then
                         RsKonstanty.Edit: RsKonstanty.Fields("ponapln") = Str(SumaDoKonstan): RsKonstanty.Update
                           Msg = "Daň je uložena pro pozdější odpočet: " & Str(SumaDoKonstan) & ",- Kč": MsgVykricnik
                       End If 'SysMes = 1
                       
                      If SysMes = 3 And i = 20 Then
                         RsKonstanty.Edit: RsKonstanty.Fields("ponapln") = Str(SumaDoKonstan): RsKonstanty.Update
                           Msg = "Daň je uložena pro pozdější odpočet: " & Str(SumaDoKonstan) & ",- Kč": MsgVykricnik
                       End If 'SysMes = 1
                       
                       RsKonstanty.MoveNext
                     Next i
              End If ' If a = 290 And SumaMzd(a) < 0 Then
              
              If a = 290 And SumaMzd(a) >= 0 Then
                     For i = 1 To MAxKonstanty
                      If SysMes = 1 And i = 18 Then: RsKonstanty.Edit: RsKonstanty.Fields("ponapln") = Str(0): RsKonstanty.Update
                      If SysMes = 2 And i = 19 Then: RsKonstanty.Edit: RsKonstanty.Fields("ponapln") = Str(0): RsKonstanty.Update
                      If SysMes = 3 And i = 20 Then: RsKonstanty.Edit: RsKonstanty.Fields("ponapln") = Str(0): RsKonstanty.Update
                       RsKonstanty.MoveNext
                     Next i
                 
               End If ' a = 290 And SumaMzd(a) >= 0
               
              Rszam1.Update
              Rszam1.MoveNext
            Next a
          
       '=== uložení sumy do tabulky PojSuma
       

     If MaxRsPojjSum <> 0 Then ' vymaž staré údaje v tabulce
       RsPojjSum.MoveFirst
        For a = 1 To MaxRsPojjSum
          RsPojjSum.Delete
          RsPojjSum.MoveNext
        Next a
     End If
   
           For a = 1 To MaxRsPojj ' přes všechny pojistovny
             If Trim(KodPojjMesic(a)) <> "" Then
               RsPojjSum.AddNew
               RsPojjSum.Fields("PojKod") = Trim(KodPojjMesic(a))
               RsPojjSum.Fields("PocetLidi") = PocLidi(a)  ' počet lidí v pojišťovně
               RsPojjSum.Fields("ZpVymZakl") = Sum272(a)        ' 272
               RsPojjSum.Fields("ZpZaklOrgCely") = Sum471(a)    ' 471
               RsPojjSum.Fields("ZpZaklZamCely") = Sum472(a)    ' 472
               RsPojjSum.Fields("ZaklVratka") = Sum476(a)       ' 476
               RsPojjSum.Fields("ZdrPojOrgan") = Sum274(a)      ' 274
               RsPojjSum.Fields("ZdrPojZam") = Sum277(a)        ' 277
               RsPojjSum.Fields("VymZaklNadLimit") = Sum354(a)  ' 354
               RsPojjSum.Update
            End If
          Next a

          
 
            RsPamch.AddNew
              RsPamch.Fields("Datum") = Format(date, "dd/mm/yyyy")
              RsPamch.Fields("Cas") = Format(Time, "hh/mm/ss")
              RsPamch.Fields("OsCislo") = "0"
              RsPamch.Fields("CisPol") = "0"
              RsPamch.Fields("Napln") = "Přepočet skončen"
              RsPamch.Fields("Rezerva") = " "
            RsPamch.Update
  If zamm = aaa - 1 Then
 
       'Msg = " Přepočet všech zaměstnanců je hotov. " + Presundobirky: MsgInfo
       Text1.Text = "Přepočet všech zaměstnanců je hotov. "
       Command2.Enabled = True
   Else
       Msg = " Přepočet všech zaměstnanců neproběhl korektně! Spusťte přepočet znovu a pokud se situace bude opakovat zavolejte Salary s.r.o." + Presundobirky: MsgInfo
  End If
      ' Covid2020
        Frame3.Visible = False
        Zodd = 1
      
       Set RsKonstanty = DbUdaje.OpenRecordset("SELECT * FROM konstanty ")
       RsKonstanty.MoveLast: RsKonstanty.MoveFirst: MAxKonstanty = RsKonstanty.RecordCount
       RsKonstanty.MoveFirst
       
       PrepocetAnoNe = False
            For a = 1 To 16 'MAxKonstanty
                If a = 16 Then
                  RsKonstanty.Edit
                  RsKonstanty.Fields("PoNapln") = 0
                  RsKonstanty.Update
                  End If
              RsKonstanty.MoveNext
            Next a
               
  
ZOsCislo = OsobC
NahrajZam (OsobC)
           
' FNameT = PathExe & "\PocZam.txt"  ' pomocnej soubor pro tisk
 On Error Resume Next
                Open PathExe & "\PocZam.txt" For Output As #1 ' otevři soubor s číslem 1
Print #1, Trim(Str(PZam))

 Close #1

               
'  KrokJM
'  StartDB
'If RsFirma.Fields("FCovidC") = "N" Then: Unload Me
'         Exit Sub

'Command1_Click_Err:
'        MsgBox Err.Description & vbCrLf & _
'               "in Salary2008.FrmPrepocVsem.Command1_Click " & _
'               "at line " & Erl, _
'               vbExclamation + vbOKOnly, "Application Error"
'        Resume Next
 End Sub

Private Sub Command2_Click()
BylStiskPreoctu = 0
  Unload Me
End Sub

Private Sub Command4_Click()
Frame2.Visible = False
 Unload Me
End Sub

Private Sub Form_Load()
Dim zamm As Integer
   Text1.Text = "Přepočet také provádí součtování některých rekapitulací"
Command1.Enabled = True
Command2.Enabled = False
  If Trim(ResultText(1)) = "X" Then
    Text1.Text = "Po poslední úpravě mezd nebyl Přepočet spuštěn!" '& vbCrLf
    ResultText(1) = ""
  End If
End Sub
Public Sub Covid2020()
Dim Rk(800) As Double
Dim tx(10) As String
If RsFirma.Fields("FCovidC") = "A" And SysRok = 2020 Then  ' Covid 2020 6-8

 If SysMes > 5 And SysMes < 9 Then
    
        OldDbUdaj = "U" & Format(Datum(1, 3, 2020), "yyyymm") & ".mdb"
        oldPathDta = PathAdres + "\" + OldDbUdaj ' cesta k datům pam, osobní
        Set OldDbUdaje = OpenDatabase(oldPathDta, True, False, ";pwd=Salary21")
        Set RsRk = OldDbUdaje.OpenRecordset("SELECT * FROM RekapSum WHERE Mesic = " & 3 & " order by  PoCislo")
           RsRk.MoveLast
           RsRk.MoveFirst
    
        For i = 1 To 800: Rk(i) = RsRk.Fields("posuma"): RsRk.MoveNext: Next i
          
           Frame2.Visible = True: Frame2.Height = 4095: Frame2.Width = 8655: Frame2.Top = 120: Frame2.Left = 120:
    
     tx(1) = "             "
     tx(2) = "               úhrn vyměřovácích základů na soc. poj."
     tx(3) = "-----------------------------------------------------"
     tx(4) = " březen 2020                " + Str(Rk(271))
     tx(5) = "              z března 90 % " + Str(Round(Rk(271) * 0.9 + 0.4999))
     tx(6) = " tento měsíc                " + Str(SumaMzd(271))
     tx(7) = "-----------------------------------------------------"
    
    If SumaMzd(271) >= Round(Rk(271) * 0.9 + 0.4999) Then
       tx(8) = " Příjem za tento měsíc je vyšší než 90% března"
       tx(9) = "     Tato část podmínek splňuje"
       tx(10) = " nárok na slevu na sociálním pojištění."
       
    Else
       tx(8) = " Příjem za tento měsíc je vyšší než 90% března"
       tx(9) = "           Tato část podmínek bohužel"
       tx(10) = " NEsplňuje nárok na slevu na sociálním pojištění."
       
    End If
    
    Text2.Text = ""
    Text2.Font.Size = 7 * sizeFactor
    Text2.Font.Bold = True
    
    For i = 1 To 10
         Text2.Text = Text2.Text & tx(i) & vbCrLf
    Next i

 End If
End If
End Sub
Public Sub Display()
  Me.Show vbModal
End Sub

Private Sub DovolenaUlozRadek()


  Text = Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124)
  If SysMes = 1 Or Trim(P(31)) = "" Then P(31) = Text
 
  T = Trim(Str(Round(M(60) / Val(P(23)), 2))):
   
    
 If M(Round(M(60) / Val(P(23)), 2)) >= 1 Then
   T = Replace(FormatNumber(T, 2), ",", "."): T = Replace(T, ".00", "   ")
 End If
  
     If Len(T) > 4 Then
       T = Mid(T, 1, 5)
     Else
       T = Space(5 - Len(T)) + T
     End If
     
  P(31) = Mid(Mid(P(31), 1, ((SysMes) * 6) - 5) + Mid(T, 1, 5) + Text, 1, 73)           ' Načte výběr dovolené do řádku pro Přehled
   
   

End Sub
Private Sub DovolenaUlozRadek2021()


  Text = Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124) + "     " + Chr(124)
  If SysMes = 1 Or Trim(P(31)) = "" Then P(31) = Text
 
  T = Trim(Str(Round(M(60), 1))):
   
   If Val(P(23)) = 0 Then: MsgBox (Trim(ZOsCislo) & " " & Trim(ZPrijmeni) & " " & Trim(ZJmeno) & " Chybí úvazek na den v Pam! Opravte a spuťte Přepočet znovu!!!"): Exit Sub
 If M(Round(M(60) / Val(P(23)), 2)) >= 1 Then
   T = Replace(FormatNumber(T, 2), ",", "."): T = Replace(T, ".00", "   ")
 End If
  
     If Len(T) > 4 Then
       T = Mid(T, 1, 5)
     Else
       T = Space(5 - Len(T)) + T
     End If
     
  P(31) = Mid(Mid(P(31), 1, ((SysMes) * 6) - 5) + Mid(T, 1, 5) + Text, 1, 73)           ' Načte výběr dovolené do řádku pro Přehled
   
   

End Sub
Private Sub ELDPos()

Dim Ss As String
Dim s1 As String
Dim s2 As String
Dim Kod1 As String
Dim Kod2 As String
Dim Kod3 As String
Dim DatEldpOd1 As Date
Dim DatEldpDo1 As Date
Dim DatEldpOd2 As Date
Dim DatEldpDo2 As Date
Dim DatEldpOd3 As Date
Dim DatEldpDo3 As Date
Dim DatEldpKonecPP As Date

Kod1 = Mid(O(269), 1, 1)
Kod2 = "+"
Kod3 = "+"
O(247) = " "
O(248) = "00.00.0000"
O(249) = "00.00.0000"
O(287) = " "
O(288) = "00.00.0000"
O(289) = "00.00.0000"

 If Trim(O(320)) = "Člen družstva" Then: Kod3 = "+"
' If Trim(O(320)) = "Společník" Then: Kod3 = "S"
 If Trim(O(320)) = "Komandista/Jednatel" Then: Kod3 = "+"

If Mid(O(269), 1, 1) = "S" Or Mid(O(269), 1, 1) = "O" Then: Kod3 = "+"
Ss = Mid(P(60), 1, 10)

If IsNumeric(Left$(Ss, 2)) And IsNumeric(Mid$(Ss, 4, 2)) And IsNumeric(Right$(Ss, 4)) Then
    DatEldpOd1 = DateSerial(Right$(Ss, 4), Mid$(Ss, 4, 2), Left$(Ss, 2))
   If DatEldpOd1 < Datum(1, SysMes, SysRok) Then: DatEldpOd1 = Datum(1, SysMes, SysRok)
Else
   ' MsgBox "Nekorektní datum nástupu O310"
End If
'MsgBox (DatEldpOd1)

Ss = Mid(P(429), 1, 10)
If Ss <> "00.00.0000" Then
  If IsNumeric(Left$(Ss, 2)) And IsNumeric(Mid$(Ss, 4, 2)) And IsNumeric(Right$(Ss, 4)) Then
    DatEldpDo1 = DateSerial(Right$(Ss, 4), Mid$(Ss, 4, 2), Left$(Ss, 2))
    DatEldpKonecPP = DatEldpDo1
   If DatEldpDo1 > Datum(PoslednihoS, SysMes, SysRok) Then
        DatEldpDo1 = Datum(PoslednihoS, SysMes, SysRok)
        
    End If
  Else
   ' MsgBox "Nekorektní datum nástupu O340"
  End If
   
Else
 DatEldpDo1 = Datum(PoslednihoS, SysMes, SysRok)
 DatEldpKonecPP = DatEldpDo1
End If

O(227) = Kod1 + Kod2 + Kod3
O(247) = " "
O(287) = " "
Ss = Mid(O(222), 1, 10)
If Ss <> "00.00.0000" And Trim(Ss) <> "" Then
  If IsNumeric(Left$(Ss, 2)) And IsNumeric(Mid$(Ss, 4, 2)) And IsNumeric(Right$(Ss, 4)) Then
    DatEldpOd2 = DateSerial(Right$(Ss, 4), Mid$(Ss, 4, 2), Left$(Ss, 2))
   If DatEldpOd2 > Datum(PoslednihoS, SysMes, SysRok) Then: DatEldpOd2 = 0: GoTo Utec:
      DatEldpDo2 = Datum(PoslednihoS, SysMes, SysRok)
      
    If DatEldpKonecPP < DatEldpDo2 Then: DatEldpDo2 = DatEldpKonecPP
   
     If Month(DatEldpOd2) = SysMes And Year(DatEldpOd2) = SysRok Then
     
       If Day(DatEldpOd2) > 1 Then: DatEldpDo1 = Datum(Day(DatEldpOd2) - 1, Month(DatEldpOd2), Year(DatEldpOd2)): Kod2 = "D": O(247) = Kod1 + Kod2 + Kod3:
       If Day(DatEldpOd2) = 1 Then: DatEldpOd1 = DatEldpOd2: DatEldpDo1 = Datum(PoslednihoS, SysMes, SysRok): DatEldpOd2 = 0: DatEldpDo2 = 0: Kod2 = "D": O(247) = Kod1 + Kod2 + Kod3:
       
     End If

     If DatEldpOd2 < Datum(1, SysMes, SysRok) Then
       Kod2 = "D"
       O(227) = Kod1 + Kod2 + Kod3
       If Mid(P(60), 1, 10) <> DatEldpOd1 And Val(Mid$(P(60), 4, 2)) <> SysMes And Val(Mid$(P(60), 7, 4)) <> SysRok Then: DatEldpOd1 = Datum(1, SysMes, SysRok): DatEldpDo1 = Datum(PoslednihoS, SysMes, SysRok): O(248) = "00.00.0000": O(249) = "00.00.0000"
       
     End If

     If DatEldpOd2 > Datum(PoslednihoS, SysMes, SysRok) Then
       O(248) = "00.00.0000": O(249) = "00.00.0000"
     End If
     
     
     If Mid(O(248), 1, 10) = "00.00.0000" Then: DatEldpDo1 = DatEldpDo2
       
Utec:
 End If
 
End If


     If Day(DatEldpKonecPP) < PoslednihoS And Month(DatEldpKonecPP) = SysMes And Year(DatEldpKonecPP) = SysRok Then
     'MsgBox (Mid(KalVeta(5), Day(DatEldpKonecPP) * 2 + 1, 1))
           If Mid(KalVeta(5), Day(DatEldpKonecPP) * 2 + 1, 1) = "N" Then: s2 = "N":
           If Mid(KalVeta(5), Day(DatEldpKonecPP) * 2 + 1, 1) = "U" Then: s2 = "N":
           If Mid(KalVeta(5), Day(DatEldpKonecPP) * 2 + 1, 1) = "C" Then: s2 = "M":
           If s2 = "N" Or s2 = "M" Then
              s1 = Mid(KalVeta(5), Day(DatEldpKonecPP) * 2 + 1, 62)
              i = (AbsencePocet(s1, "N") + AbsencePocet(s1, "U") + AbsencePocet(s1, "C")) / 2
           Else
              GoTo utec2
           End If


           If Mid(O(227), 2, 1) = "D" Then

             O(247) = Kod1 + s2 + Kod3
            DatEldpDo1 = Datum(Day(DatEldpKonecPP), Month(DatEldpKonecPP), Year(DatEldpKonecPP))
            DatEldpOd2 = Datum(Day(DatEldpKonecPP + 1), Month(DatEldpKonecPP), Year(DatEldpKonecPP))
            DatEldpDo2 = Datum(Day(DatEldpKonecPP) + i, SysMes, SysRok)

             O(287) = " ":
             O(288) = "00.00.0000":
             O(289) = "00.00.0000":
           End If
           If Mid(O(227), 2, 1) = "+" And Mid(O(247), 2, 1) <> "D" Then

             O(247) = Kod1 + s2 + Kod3
            DatEldpDo1 = Datum(Day(DatEldpKonecPP), Month(DatEldpKonecPP), Year(DatEldpKonecPP))
            DatEldpOd2 = Datum(Day(DatEldpKonecPP + 1), Month(DatEldpKonecPP), Year(DatEldpKonecPP))
            DatEldpDo2 = Datum(Day(DatEldpKonecPP) + i, SysMes, SysRok)

             O(287) = " ":
             O(288) = "00.00.0000":
             O(289) = "00.00.0000":
           End If
           If Mid(O(247), 2, 1) = "D" Then
              O(287) = Kod1 + s2 + Kod3
            DatEldpDo2 = Datum(Day(DatEldpKonecPP), Month(DatEldpKonecPP), Year(DatEldpKonecPP))
            DatEldpOd3 = Datum(Day(DatEldpKonecPP + 1), Month(DatEldpKonecPP), Year(DatEldpKonecPP))
            DatEldpDo3 = Datum(Day(DatEldpKonecPP) + i, SysMes, SysRok)

           End If
utec2:
     End If
 
  If DatEldpKonecPP < Datum(1, SysMes, SysRok) Then
           If Mid(KalVeta(5), 1, 1) = "N" Then: Kod2 = "N":
           If Mid(KalVeta(5), 1, 1) = "U" Then: Kod2 = "N":
           If Mid(KalVeta(5), 1, 1) = "C" Then: Kod2 = "M":
           If M(260) > 0 Then: Kod2 = "P"
       O(227) = Kod1 + Kod2 + Kod3
       O(247) = " "
       O(287) = " "
       DatEldpOd1 = 0
       DatEldpDo1 = 0
       DatEldpOd2 = 0
       DatEldpDo2 = 0
       DatEldpOd3 = 0
       DatEldpDo3 = 0
  End If
  
  If Trim(O(247)) = "" Then: DatEldpOd2 = 0: DatEldpDo2 = 0
  If Trim(O(287)) = "" Then: DatEldpOd3 = 0: DatEldpDo3 = 0
  If DatEldpOd1 <> 0 Then: O(228) = DateStr(DatEldpOd1)
  If DatEldpDo1 <> 0 Then: O(229) = DateStr(DatEldpDo1)
  If DatEldpOd2 <> 0 Then: O(248) = DateStr(DatEldpOd2)
  If DatEldpDo2 <> 0 Then: O(249) = DateStr(DatEldpDo2)
  If DatEldpOd3 <> 0 Then: O(288) = DateStr(DatEldpOd3)
  If DatEldpDo3 <> 0 Then: O(289) = DateStr(DatEldpDo3)
'            MsgBox (i & "  " & DatEldpOd1 & "  " & DatEldpDo1 & " / " & O(247) & "  " & DatEldpOd2 & "  " & DatEldpDo2 & " / " & O(287) & "  " & DatEldpOd3 & "  " & DatEldpDo3)
      If O(320) = "Neuvolnění" Then
      'MsgBox (Val(Trim(O(227))))
           If Len(Trim(O(227))) = 3 Then: O(227) = "14" + Mid(O(227), 2, 2)
           If Len(Trim(O(247))) = 3 Then: O(247) = "14" + Mid(O(247), 2, 2)
           If Len(Trim(O(287))) = 3 Then: O(287) = "14" + Mid(O(287), 2, 2)
       End If

End Sub
Public Sub ZpracujJMHZ(cesta As String)
    Dim fso As Object
    Set fso = CreateObject("Scripting.FileSystemObject")
    
    ' 1. SCÉNÁŘ: Uživatel zadal cestu k celé SLOŽCE
    If fso.FolderExists(cesta) Then
        Dim fld As Object
        Dim Fl As Object
        
        Set fld = fso.GetFolder(cesta)
        For Each Fl In fld.Files
            ' Zpracujeme pouze soubory s příponou XML
            If LCase(fso.GetExtensionName(Fl.Name)) = "xml" Then
                ZpracujJedenXMLSoubor fso, Fl.Path
            End If
        Next Fl
 '       MsgBox "Zpracování složky dokončeno.", vbInformation
        
    ' 2. SCÉNÁŘ: Uživatel zadal cestu přímo k XML SOUBORU
    ElseIf fso.FileExists(cesta) Then
        If LCase(fso.GetExtensionName(cesta)) = "xml" Then
            ZpracujJedenXMLSoubor fso, cesta
  '          MsgBox "Zpracování souboru dokončeno.", vbInformation
        Else
            MsgBox "Zadaný soubor není ve formátu XML.", vbExclamation
        End If
        
    ' 3. SCÉNÁŘ: Cesta je zcela neplatná
    Else
      Exit Sub
        MsgBox "Zadaná cesta neexistuje (nenalezena složka ani soubor): " & vbCrLf & cesta, vbCritical
    End If
    
    Set fso = Nothing
End Sub

' Pomocná procedura pro samotné čtení dat z jednoho XML

Private Sub ZpracujJedenXMLSoubor(fso As Object, filePath As String)
    Dim xmlDoc As Object
    Dim nodeList As Object
    Dim nodeZamestnanec As Object
    Dim node As Object
    Dim strKDC As String
    Dim strRC As String
    Dim strECP As String
    Dim strIKMPSV As String
    Dim strIDPPV As String
    Dim isCizinec As Boolean
    
    Set xmlDoc = CreateObject("MSXML2.DOMDocument.6.0")
    xmlDoc.async = False
    xmlDoc.Load filePath
    
    If xmlDoc.parseError.ErrorCode = 0 Then
        Set nodeList = xmlDoc.getElementsByTagName("Zamestnanec")
        
        For Each nodeZamestnanec In nodeList
            strKDC = ""
            strRC = ""
            strECP = ""
            strIKMPSV = ""
            strIDPPV = ""
            isCizinec = False
            
            Set node = nodeZamestnanec.SelectSingleNode("KodDruhuCinnosti")
            If Not node Is Nothing Then strKDC = node.Text

            Set node = nodeZamestnanec.SelectSingleNode("IdZamestnani")
            If Not node Is Nothing Then strIDPPV = node.Text
            
            Set node = nodeZamestnanec.SelectSingleNode("OIC")
            If Not node Is Nothing Then strIKMPSV = node.Text

            Set node = nodeZamestnanec.SelectSingleNode("EvidencniCisloPojistence")
            If Not node Is Nothing Then
                strECP = node.Text
                isCizinec = True
            End If
            
            Set node = nodeZamestnanec.SelectSingleNode("RodneCislo")
            If Not node Is Nothing Then strRC = node.Text
            
            ' Logika Vašeho mzdového SW
            If isCizinec Or (strECP <> "") Then
             '   Debug.Print "Nalezen CIZINEC: EČP = " & strECP & " | IK MPSV = " & strIKMPSV & " | ID PPV = " & strIDPPV
                If strKDC = Trim(Mid(O(269), 1, 2)) And Trim(O(13)) = strECP Then: O(14) = strIKMPSV: O(15) = strIDPPV
                ' Zde doplňte SQL UPDATE / naplnění karty cizince
            Else
                ' Debug.Print "Nalezen OBČAN ČR: RČ = " & strRC & " | IK MPSV = " & strIKMPSV & " | ID PPV = " & strIDPPV
                
            If strKDC = Trim(Mid(O(269), 1, 2)) And Trim(O(100)) = strRC Then: O(14) = strIKMPSV: O(15) = strIDPPV
                
                ' Zde doplňte SQL UPDATE / naplnění karty běžného zaměstnance
            End If
        Next nodeZamestnanec
    Else
        Debug.Print "Chyba parsování souboru: " & filePath & " (Důvod: " & xmlDoc.parseError.reason & ")"
    End If
    
    Set xmlDoc = Nothing
    Set nodeList = Nothing
    Set nodeZamestnanec = Nothing
    Set node = Nothing
End Sub
Private Sub NactiGUID()
    Dim xmlDoc As Object
    Dim nodeList As Object
    Dim nodeZamestnanec As Object
    Dim node As Object
    Dim strIDPPV As String

   ' If Trim(ZOsCislo) <> "80" Then: Exit Sub
    Set xmlDoc = CreateObject("MSXML2.DOMDocument.6.0")
    xmlDoc.async = False
    xmlDoc.Load PathXml + "\Guid.xml"
    
    If xmlDoc.parseError.ErrorCode = 0 Then
        Set nodeList = xmlDoc.getElementsByTagName("GUID")
        
        For Each nodeformularOsoby In nodeList
        
            strIDPPV = ""
                        
            Set node = nodeZamestnanec.SelectSingleNode("form:idPpv")
            If Not node Is Nothing Then:
            strIDPPV = node.Text
            
                    
            If Trim(strIDPPV) = Trim(O(15)) Then: P(643) = strIDPPV
'            MsgBox (strIDPPV & "  " & O(15)): Exit Sub
        Next nodeformularOsoby
    Else
        Debug.Print "Chyba parsování souboru: " & filePath & " (Důvod: " & xmlDoc.parseError.reason & ")"
    End If
    
    Set xmlDoc = Nothing
    Set nodeList = Nothing
    Set nodeZamestnanec = Nothing
    Set node = Nothing
End Sub
