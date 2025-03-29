insert into equips(serial, type, model)
values('s1','t1','m1'),
      ('s2','t2','m2')
;

select model
from equips
where serial = 's2'
;