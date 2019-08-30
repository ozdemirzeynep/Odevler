

create view [tumgorunum] as
select AdSoyad, dersID, ogrenciID
from ogrenciler as og
inner join  donemdersleri as dd ON og.ID = dd.ogrenciID
inner join dersler as d ON d.ID = dd.dersID;



