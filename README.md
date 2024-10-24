
## Kullanım

### Gereksinimler

- .NET Framework veya .NET Core
- C# derleyici

### Kurulum

1. Projeyi klonlayın veya indirin:
   ```bash
   git clone https://github.com/kullanici_adi/calisan-temsilci.git
   cd calisan-temsilci
   ```

2. Projeyi açın ve çalıştırın:
   ```bash
   dotnet run
   ```

### Çalışma Prensibi

Program çalıştırıldığında, örnek çalışanlar oluşturulur ve her birinin `Gorev` metodu çağrılarak konsola görevleri yazdırılır.

## Kod Yapısı

### Sınıflar

- **Employee**: Ortak özellikleri ve `Gorev` metodunu tanımlar.
- **YazilimGelistirici**: `Employee` sınıfından türetilmiştir ve yazılım geliştirme görevini belirtir.
- **ProjeYoneticisi**: Proje yönetimi görevini belirtir.
- **SatisTemsilcisi**: Satış temsilcisi görevini belirtir.

### Örnek Çalışma

Program çalıştığında aşağıdaki gibi bir çıktı verir:

```
Hasan Çıldırmış, Yazılım Geliştirici olarak çalışıyorum.
Ayşe Yılmaz, Proje Yöneticisi olarak çalışıyorum.
Mehmet Demir, Satış Temsilcisi olarak çalışıyorum.
```


