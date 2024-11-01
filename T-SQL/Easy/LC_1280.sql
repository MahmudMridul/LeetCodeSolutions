select *,
( select count(ex.student_id) from Examinations ex 
    where ex.student_id = st.student_id and 
    ex.subject_name = sb.subject_name ) as attended_exams
from 
    Students st
cross join
    Subjects sb
order by
    st.student_id,
    sb.subject_name