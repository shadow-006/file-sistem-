# Fayl Meneceri

C# Windows Forms ilə yazılmış sadə fayl meneceridir.

## Nələr edir

- Qovluq seçir və içindəki `*.txt` faylları siyahıda göstərir
- Seçilmiş faylın adını və ölçüsünü göstərir
- Faylı açıb mətnini redaktə etməyə imkan verir
- Dəyişiklikləri yadda saxlayır
- Təsdiqdən sonra faylı silir

## Qovluq quruluşu

```
FaylMeneceri.sln
FaylMeneceri/
  FaylMeneceri.csproj
  Program.cs
  Form1.cs
  Form1.Designer.cs
```

## Necə işə salmaq

1. `FaylMeneceri.sln` faylını Visual Studio ilə açın.
2. `F5` düyməsi ilə layihəni başladın.

Komanda sətri ilə:

```
dotnet run --project FaylMeneceri
```

## Tələb

.NET 10 SDK (Windows)
