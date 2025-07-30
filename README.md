 Dependency Injection Örneği – ASP.NET Core Web API 
Bu proje, Dependency Injection (DI) prensibini ASP.NET Core Web API ortamında Interface (arayüz) odaklı yapıyla örneklemektedir.
IClassRoom, ITeacher üzerinden hareket ederek gevşek bağlı, test edilebilir ve esnek bir yapı sağlar.

🧱 Katmanlar ve Sınıflar
🔷 ITeacher.cs
GetInfo() metodunu tanımlar.

Tüm öğretmen sınıflarının uyması gereken arayüzdür.

🔷 Teacher.cs
ITeacher arayüzünü uygular.

FirstName ve LastName özellikleri içerir.

GetInfo() metodu ad + soyadı döner.

🔷 IClassRoom.cs
GetTeacherInfo() metodunu tanımlar.

🔷 ClassRoom.cs
IClassRoom arayüzünü uygular.

GetTeacherInfo(), içindeki öğretmeni çağırır.

🔷 ClassRoomController.cs
IClassRoom bağımlılığı dışarıdan alınır.

/api/classroom/getteacherinfo endpoint’iyle öğretmen bilgisi döner.

