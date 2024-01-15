# SQL

## Copilot
/* Create a query for the Users table that counts the number of logins 
grouped by year and month, 
sorted by date so the latest dates comes first. 
Only include the top 100 rows.
*/


## Chat
I have over two million rows in the Users table. When I try to find a specific user by email it takes a long time to get the results. How can I improve that?

Please make sure that no duplicate email addresses are allowed



# Dotnet

## Copilot

// Create a class called User with properties for Id, Name, Email and LastLogin

## Cmd+I
Make sure that Email is a proper email address

Make sure that Name is required and not longer than 20 chars

## Chat

I want to setup EF Core for the User class and the Users table. What do I need to do and can you give me the code needed to use it in my controllers?

I already have a SQL Server table called Users that I want to use for this entity. How ever, in my table the LastLogin field is called last_login. How can I use the existing table and make sure the property and db column match even though the name is not exactly right?

## Chat QrController

### Alt 1
Please update the selected code to use the QRCoder nuget package instead. 

dotcore does not support Bitmap. Get a byte[] and return that directly using a File result instead.

### Alt 2
Please refactor this code to avoid using googleapis. Instead, find a Nuget package that can create a Png QR code and return that as a FileResult. Cache the output for 5 minutes.

Use OutputCache instead of a memory cache

Size should be the total width of the finished QR code. The argument to GetGraphics is the size of each block. Calculate how big each block needs to be in order to make the output size x size px.


# React

## Cmd+I in ListReviews.tsx
create a component that uses a useEffect to fetch data from https://example.com/reviews and stores the JSON response in a state variable. The response is an array of object that contains proerties with name and score. Render a component that lists all reviews with a header for the name and a number for the score. 

## Chat
I've heard people say online that fetching data inside a useEffect is a bad practice and that libraries like React Query should be used. Please explain why and show me how I can use React Query instead.

## Copilot in badexemple.ts
Naming things, regex, functions

email regex
social security regex
function doStuff()

Try again by:

import { Transaction } from './transactions';

and make a function to calculateTotalAmount.


/tests

/explain

@workspace /new Create a html website with an index file and and a contact page. The layout should be a header with the title "Copilot" and the background should be dark blue. The title should be big and white. The content should never be wider than 800px and also be responsive to fit all devices. The footer should have a light green background and say "Copilot is awesome!"




