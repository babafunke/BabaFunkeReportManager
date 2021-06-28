[![Blog Inspiration (BabaFunke.DataAccess)](https://img.shields.io/badge/Blog-Inspiration-yellowgreen.svg?style=flat-square)](https://daddycreates.com/creating-more-family-time-with-azure-functions/)
# Introduction 
BabaFunkeReportManager is an Azure Functions project that uses TimerTrigger to automate the process of curating a list of customers, processing them into a CSV file and sending as email attachments to selected recipients. It was inspired by the need to gain more family time by automating what used to be a manual process for tracking customer sign-ups and reporting for my app. See background info below for more.

BabaFunkeCustomer.Web is an Asp.Net Core Web Api project to demonstrate the use of the Azure Functions. It's consists of a single endpoint to return mock customer data.

# Build and Test
Clone this git repo to access both projects. Ensure you make a few changes as follows:
* Replace the Sender's email with yours in the Startup.cs file in BabaFunkeReportManager project
* Replace the SendGrid Api Key in the Startup.cs file in BabaFunkeReportManager project
* Replace the Recipient's email address in the EmailService.cs in BabaFunkeReportManager project

# Background
For more on the project's background and walkthrough, read my post [Creating more Family time with Azure Functions](https://daddycreates.com/creating-more-family-time-with-azure-functions/)
