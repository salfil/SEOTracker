# InfoTrack SEO Tracker

This is an ASP.NET MVC web application that checks where a given URL ranks in Google search results for a specified keyword.  
Due to Google’s scraping restrictions, the app uses a saved mock HTML file to simulate the search results and demonstrate the core functionality.

---

## Technologies Used

- ASP.NET MVC (.NET Framework 4.x)
- C#
- Razor Views (CSHTML)

---

## Features

- Enter any search keyword (e.g., `land registry searches`)
- Enter the target domain URL (e.g., `www.infotrack.co.uk`)
- Returns the ranking positions of the URL in the top 100 results

---

## How to Run Locally

### Prerequisites

- Windows OS
- Visual Studio 2022 (or 2019) with ASP.NET workload installed
- .NET Framework 4.x (should be installed with Visual Studio)
- Ideally .NET 8, which was the version used on the this occasion. 

### Steps

1. **Clone the repository or download the zip file of the code and extract the zip folder**

Download the code as a zip file and extract it. 

git clone https://github.com/salfil/SEOTracker.git


2. **Open the solution **

Open InfoTrackSeoSolution.sln in Visual Studio.

3. **Set Startup Project**

Right-click on InfoTrackSeo.Web project in Solution Explorer.

Select Set as Startup Project.

4. **Run the Application**

Press F5 or click Start Debugging.

The web application will launch in your default browser.

Use the form to enter a search keyword and a URL.

Click Search to see the ranking positions based on the mock data.

**Notes**
Because Google enforces rate limiting, you may occasionally receive a "429 Too Many Requests" error.

To mitigate this:

Avoid making frequent automated requests in quick succession.

Wait for a cooldown period (e.g., a few minutes) before retrying.

Consider running the app at off-peak hours or with longer intervals between searches.
