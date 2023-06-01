use [SqlDbSample]

/* 
Sample data in tables:

select * from Books
select * from Reviewers
select * from Ratings

To do: 
Write a query to select titles of all books that have at least one rating of 4 or higher.
Titles must be ordered alphabetically, The result should be:

title
A Tale Of Two Cities
The Hobbit

*/

select b.title
from books as b inner join ratings as r on b.id = r.book_id
where rating >= 4
order by b.title asc
