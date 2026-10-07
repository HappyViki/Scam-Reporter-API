# 🚨 Scam Reporter

A simple web application for reporting and viewing scams.

This is a **group project** between two friends with two goals: build something useful, and build something that helps us grow our skills and prepare for careers in tech.

The project started when my friend showed me a scam-reporting website she had used in the past. She wanted to create a new version that would be easier to use while giving us an opportunity to practice building and securing a real web application.

<img width="50%" alt="Screenshot of scam reporter site with form on left and list of test scams on right." src="https://github.com/user-attachments/assets/3a0375b9-b025-4cd2-a6fe-67e507a7bf7b" />

## 👩‍💻 About the Project

I'm responsible for **application development**, while my friend is focusing on **cybersecurity**.

### My role
- Designing and developing the application
- Building the C#/.NET API
- Working with the data model and API endpoints
- Building the frontend
- Deploying the application

### My friend's role
- Defining security requirements
- Pentesting / ethical hacking
- Identifying potential vulnerabilities
- Helping define validation and security specifications

We'll implement validation and other requirements together as the project develops.

We're treating this as a real collaborative development project rather than just a tutorial exercise.

## 🛠️ Tech Stack

- **C#**
- **.NET 10**
- **ASP.NET Core Minimal API**
- **HTML / CSS / JavaScript**
- **Bootstrap**
- **Railway**
- **Git / GitHub**
- **AWS** *(planned deployment)*
- **MySQL or SQL Server** *(planned database)*

## Why .NET Minimal API?

I've previously worked with **.NET MAUI** and **ASP.NET MVC**, but most of my strongest web development experience has been with **React, JavaScript, TypeScript, Next.js, Express.js, and Node.js**.

When I learned that ASP.NET Core Minimal APIs provide a lightweight way to build APIs that felt conceptually similar to creating an Express.js API, I immediately wanted to try it.

It turned out to be a great fit for this project.

I was able to go from an idea to a deployed .NET application on Railway within a few hours while following [Microsoft's .NET tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-10.0&tabs=visual-studio-code) and using AI assistance as a development tool.

More importantly, the project gave me an opportunity to apply concepts I already knew from JavaScript/Node.js development to the .NET ecosystem.

## 📋 Current Features

Users can submit information about suspected scams, including:

- Scam description
- Phone number
- Email address
- Website

The application also displays submitted scam reports.

The project is intentionally starting simple. It currently supports the **create and read** portions of the application rather than being a full CRUD application. We're planning to expand the validation, security, data storage, and functionality as we continue developing it.

## 💾 Data Storage

The application currently uses an **in-memory data store**.

This was intentional for the MVP: it allowed us to focus on getting the API and core application functionality working without introducing database infrastructure before we needed it.

As the project moves toward a more production-oriented architecture, we plan to replace the in-memory storage with a persistent relational database, most likely **MySQL or SQL Server**.

This will also give me an opportunity to work through the process of connecting a .NET application to a persistent database and eventually incorporating that database into the AWS deployment architecture.

## 🔐 Security & Validation

Security is an important part of this project because one of the project's goals is to give my friend hands-on experience with cybersecurity and pentesting.

We are currently working toward a validation and security specification that will cover areas such as:

- Input validation
- Malicious or unexpected input
- Duplicate submissions
- Abuse prevention
- API security
- Data validation

These requirements will be implemented incrementally as the project develops.

## 🚀 Deployment

The application is currently deployed on **Railway** as our initial MVP.

The decision to use Railway was intentional: we wanted to get a **minimum viable product online as quickly as possible** rather than spending the early stages of the project working through production infrastructure.

Once we have the core application and security requirements in place, we plan to move the application into the **AWS ecosystem**.

I've previously worked with AWS, so this will give me an opportunity to build on that experience while working with **AWS and .NET together**.

We're particularly interested in eventually deploying the application in a setup that more closely resembles a real-world production application, including cloud infrastructure, deployment processes, persistent data storage, and the supporting services an application like this would need.

This is especially valuable to us because **.NET and AWS are both relevant technologies in the Knoxville technology job market**, so we're intentionally using this project to build experience that translates to the types of engineering environments we're interested in.

## 🎯 Why We're Building It

This project is about more than creating a scam-reporting website.

We're both using it as a way to:

- Practice building a complete application
- Work collaboratively on a shared codebase
- Learn from each other's areas of interest
- Build something we can put on our portfolios
- Gain experience with real-world requirements
- Practice security and testing
- Learn technologies outside our usual comfort zones

For me, it's also an opportunity to get more hands-on experience with modern **C# and .NET** while building on my existing **AWS and SQL** experience.

For my friend, it's an opportunity to practice **cybersecurity, pentesting, and security requirements** on a real application.

## 🧪 What's Next?

Planned improvements include:

- [ ] Implement validation requirements
- [ ] Add additional security protections
- [ ] Penetration testing
- [ ] Improve duplicate/abuse detection
- [ ] Improve error handling
- [ ] Expand the API
- [ ] Replace in-memory storage with MySQL or SQL Server
- [ ] Improve the user experience
- [ ] Deploy to the AWS ecosystem
- [ ] Develop a more production-oriented cloud architecture
- [ ] Add additional scam-reporting features

## 💡 What I've Learned

One of my favorite parts of this project has been seeing how quickly concepts transfer between technologies.

Coming primarily from a **MERN** background, I initially approached Minimal API from a familiar perspective.

That mindset made it much easier to jump into C# and ASP.NET Core and start building.

I'm looking forward to continuing to expand the application, experimenting with AWS deployment, adding persistent database storage, and learning how far we can take it! 🚀
