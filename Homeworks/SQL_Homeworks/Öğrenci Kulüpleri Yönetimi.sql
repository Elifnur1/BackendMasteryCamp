CREATE TABLE kulüpler
(
    kulüp_id INT PRIMARY KEY,
    kulüp_adi NVARCHAR(10),
    kurulusyılı DATE

)
CREATE TABLE oğrencikulüp
(
    oğrenciID INT PRIMARY KEY,
    oğrenciadi NVARCHAR(100),
    öğrencisoyadı NVARCHAR(100),
    kulüp_id INT,
    rol NVARCHAR(10),
    katılımtarihi DATE
        FOREIGN KEY (kulüp_id) REFERENCES kulüpler (kulüp_id)
)
INSERT INTO kulüpler
    (kulüp_adi)
VALUES
    ('Tiyatro Kulübü');
INSERT INTO kulüpler
    (kulüp_adi)
VALUES
    ('Müzik Kulübü');
INSERT INTO kulüpler
    (kulüp_adi)
VALUES
    ('Spor Kulübü');
INSERT INTO kulüpler
    (kulüp_adi)
VALUES
    ('Bilim Kulübü');
INSERT INTO kulüpler
    (kulüp_adi)
VALUES
    ('Sanat Kulübü');


INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Ahmet', 'Yılmaz', 'Oyuncu', 1);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Elif', 'Demir', 'Yönetmen', 1);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Mehmet', 'Kaya', 'Işık Asistanı', 1);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Zeynep', 'Aydın', 'Ses Teknisyeni', 1);


INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Ayşe', 'Çelik', 'Şarkıcı', 2);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Canan', 'Koç', 'Gitarist', 2);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Burak', 'Akman', 'Davulcu', 2);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Emre', 'Polat', 'Piyanist', 2);


INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Fatma', 'Öz', 'Basketbolcu', 3);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Oğuzhan', 'Yılmaz', 'Futbolcu', 3);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Sibel', 'Kara', 'Voleybolcu', 3);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Ali', 'Çetin', 'Atlet', 3);


INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Selin', 'Arslan', 'Araştırmacı', 4);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Kerem', 'Yücel', 'Deney Asistanı', 4);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Derya', 'Tan', 'Proje Yöneticisi', 4);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Baran', 'Uslu', 'Sunucu', 4);


INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Aslı', 'Korkmaz', 'Ressam', 5);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Mert', 'Yıldız', 'Heykeltıraş', 5);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Ece', 'Kılıç', 'Seramikçi', 5);
INSERT INTO oğrencikulüp
    (oğrenciadi,öğrencisoyadı,rol,kulüp_id)
VALUES
    ('Deniz', 'Güzel', 'Grafik Tasarımcı', 5);


SELECT ok.oğrenciID, .oğrenciadi, ok.öğrencisoyadı, k.kulüp_id, k.kulüp_adi
FROM kulüpler k JOIN oğrencikulüp ok ON k.kulüp_id=ok.kulüp_id
GROUP BY ok.oğrenciID,.oğrenciadi,ok.öğrencisoyadı,k.kulüp_id,k.kulüp_adi

SELECT ok.oğrenciID, .oğrenciadi, ok.öğrencisoyadı, ok.rol
from kulüpler k JOIN oğrencikulüp ok ON k.kulüp_id=ok.kulüp_id
WHERE k.kulüp_adi='Tiyatro'
GROUP BY ok.oğrenciID,.oğrenciadi,ok.öğrencisoyadı,ok.rol

SELECT
    ok.oğrenciadi,
    ok.öğrencisoyadı,
    k.kulüp_adi
FROM
    oğrencikulüp ok
    JOIN
    kulüpler k ON ok.kulüp_id = k.kulüp_id
WHERE 
    ok.rol = 'Başkan';

SELECT k.kulüp_id, k.kulüp_adi, COUNT(ok.oğrenciID)  as [Üye sayısı]
FROM kulüpler k JOIN oğrencikulüp ok ON k.kulüp_id=ok.kulüp_id
GROUP BY k.kulüp_id,k.kulüp_adi

SELECT
    ok.oğrenciadi,
    ok.öğrencisoyadı,
    ok.rol
FROM
    kulüpler k
    JOIN
    oğrencikulüp ok ON k.kulüp_id = ok.kulüp_id
WHERE 
   k.kurulusyılı = (SELECT MIN(kurulusyılı)
FROM kulüpler);


SELECT
    ok.oğrenciadi,
    ok.öğrencisoyadı,
    k.kulüp_adi,
    ok.katılımtarihi
FROM
    oğrencikulüp ok
    JOIN
    kulüpler k ON ok.kulüp_id = k.kulüp_id;


SELECT DISTINCT
    ok.rol
FROM
    oğrencikulüp ok
    JOIN
    kulüpler k ON ok.kulüp_id = k.kulüp_id
WHERE 
    k.kulüp_adi = 'Müzik Kulübü';


SELECT
    k.kulüp_adi,
    COUNT(ok.oğrenciID) AS başkan_sayısı
FROM
    kulüpler k
    LEFT JOIN
    oğrencikulüp ok on k.kulüp_id = ok.kulüp_id
WHERE 
    ok.rol = 'Başkan'
GROUP BY 
    k.kulüp_id, k.kulüp_adi;


SELECT top 1
    ok.oğrenciadi,
    ok.öğrencisoyadı,
    k.kulüp_adi,
    ok.katılımtarihi
FROM
    oğrencikulüp ok
    JOIN
    kulüpler k ON ok.kulüp_id = k.kulüp_id
ORDER BY 
    ok.katılımtarihi DESC


SELECT
    ok.oğrenciadi,
    ok.öğrencisoyadı,
    COUNT(ok.kulüp_id) AS 'kulüp_sayısı'
FROM
    oğrencikulüp ok
GROUP BY 
    ok.oğrenciID, ok.oğrenciadi, ok.öğrencisoyadı
HAVING 
    'kulüp_sayısı ' > 1;

