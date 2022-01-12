# Pegasus C# Candidate Test

## Welcome!

First and foremost, Congratulations for making it this far. We wish you the best of luck with this test.

The purpose of the test is for us to evaluate how you approach solving a given problem.

We will be assessing you based on the following:

0. Did you solve the actual problem(s) presented by the test.
1. Code practices and quality applied to the situation.
2. Relevant questions asked when and where necessary.
3. Collaboration with test administrator and / or other staff members.
4. How you use the time you have.

## Getting Started

You will need to clone this repository to your machine. From there you'll need to 
create a new branch of the repository in the following format.

(NOTE: If you received this via a packaged file (ie: Zip), please disregard this section.)

[firstname]_[lastname]

## Project Structure

 - TodoUi - the user interface for the todo application
 - TodoApi - the back end for the todo application
 - TodoApiTests - houses the unit tests for todo api

## The Test

We present you with the Pegasus TODO application.

It's not much, but once you're done with it, it will
be spectacular and Production ready.

These are our requirements / tasks:

 - Task: Clone this repository to your local machine, create
      a branch for the repository with the name [firstname]_[lastname] and switch to this new branch and begin development. (Disregard if you received this via a package)
 
 - Feature: Add New Todo Item
 - Feature: Update Todo Item
 - Feature: Archive Todo Item
 - Feature: Delete Todo Item
 - Feature: Persist Todo Items
 - Feature: Track When Todo Items are created or changed
 - Feature: Assign a Todo Item to a Person
 - Feature: Bulk Assign Selected Todo Items to a Person
 - Feature: Email a Person when a Todo Item is assigned to them

- Epic: Create the TodoUi using a web front end of your choice
   ie: React, Angular, Knockout, etc that will consume the web
      api.
 
 - Technical: Unit Tests
 - Technical: Dockerfile for Todo WebApi
 - Technical: Bundle and minify the web front end where appropriate
 - Technical: Getting ALL todo's would not work with large data-sets in the real world.
    consider another approach to this.

## Recommendations / Hints / Suggestions

 - Complete as much as you can to the best of your ability. However, if you run out of
    time or miss something, don't fret. We will still assess you on what is existing and
    how you approached that portion.
    
 - It's better to attempt to complete something and not finish it, then not attempt it at all.
 
 - A little git help:
 ```
    git clone [repository]
    git checkout -b "your_name"
 ```
 
 - Git commit frequently.
 
 - Your choice of web front end will not be assessed, but rather how functional it is.
 
 - For persistence, this is left open to you as to how you implement. However,
    for extra points we'd recommend the use of Entity Framework Core.
    
 - Bonus points are awarded for niceties such as a nice looking UI that's easy to work with
    or technical features that make the project easier to compile / run etc. HOWEVER, this
    should only be worked on if you have the time.