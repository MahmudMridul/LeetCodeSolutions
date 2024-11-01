with TotalUsers as (
    select count(*) as total from Users
),
MainTable as (
    select r.contest_id, count(r.contest_id) as count, tu.total
    from Register r
    cross join TotalUsers tu
    group by r.contest_id, tu.total
)
select contest_id, Round((count * 1.00 /total * 1.00) * 100 ,2) as percentage from MainTable
order by percentage desc, contest_id asc