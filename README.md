# DevProject_Test
Application to find the occurrences of URL in Google.com

Designing an application that receives a string of Keywords and a string of URL. Keyword is passed to Www.google.com.au. This is than processed to return a string of numbers for where the resulting URL is found in Google.

Example: "1, 10, 33" or "0"

Developed application without using third party tools to scrap through HTML.Using HttpWebRequest to get the HTML of Google Search.
Used regular expressions to collect all the links on the page.
Loop through each link, check for the url you have passed and store it in Ditionary.
Initialize a counter, when we find a url, we store counter as key and URL as value.
Rturning key from dictionary.

