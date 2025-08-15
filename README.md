# PLINQ va LINQ misollari (C#)

Ushbu loyiha **LINQ** va **PLINQ** imkoniyatlaridan foydalanib turli ma'lumotlarni filtrlash, guruhlash va saralash bo‘yicha amaliy misollarni o‘z ichiga oladi.

## 📋 Loyihaning maqsadi
- LINQ va PLINQ sintaksisini o‘rganish
- Ma'lumotlarni filtrlay olish
- Guruhlash va sanash
- Saralash va eng katta qiymatlarni tanlash
- Tub sonlarni filtrlash

## 📂 Loyiha tarkibi
Loyihada quyidagi obyektlar mavjud:
- **Person** – ism va yoshga ega shaxs
- **Car** – model va yilga ega avtomobil

### **1️⃣ 30 yoshdan katta odamlarni topish (PLINQ)**
```csharp
IEnumerable<string> person =
    from peoples in people.AsParallel()
    where peoples.Age > 30
    select peoples.Name;
```
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/5b33de2d-25dc-4bbb-8b77-2920e1220bdf" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/6b0dd325-cf8e-4ca9-88fa-c6ff2173ec44" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/1bd3d679-8efd-4c7c-9dff-29045513f526" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/ae1ed1b9-6861-4702-b96a-f31392b165b0" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/6eff9df0-2971-4f01-b72d-4f30b7e510fd" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/d90d5fa9-bdd4-4b3f-ab22-8c4566164505" />
