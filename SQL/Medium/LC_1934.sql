select 
    s.user_id,
    case 
        when c.user_id is null then 0
        else
            round (
                sum ( 
                    case
                        when action = 'confirmed' then 1
                        else 0
                    end
                ) 
            / cast( count( c.user_id ) as float)
            , 2)
    end as confirmation_rate
from Signups s
left join Confirmations c
on s.user_id = c.user_id
group by s.user_id, c.user_id;