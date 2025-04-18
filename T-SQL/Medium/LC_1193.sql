select 
    convert(varchar(7), trans_date, 120) month, 
    country, 
    count(*) trans_count, 
    count(case when state = 'approved' then 1 end) approved_count,
    sum(amount) trans_total_amount,
    sum(case when state = 'approved' then amount else 0 end) approved_total_amount
from Transactions
group by convert(varchar(7), trans_date, 120), country;