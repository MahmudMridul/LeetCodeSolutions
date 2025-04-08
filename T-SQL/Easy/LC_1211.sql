select 
    query_name, 
    round(avg(rating / (position*1.0)), 2) as quality,
    round((count(case when rating < 3 then 1 end) / (count(query_name)*1.0)) * 100, 2) as poor_query_percentage
from Queries
group by query_name;