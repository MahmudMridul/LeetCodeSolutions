select today.id
from 
    Weather today
    inner join
    Weather yes
    on
    today.recordDate = dateadd(day, 1, yes.recordDate)
where
    today.temperature > yes.temperature;
