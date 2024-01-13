## 🚑 MyClinic App

This project was created as part of my Software Engineering class (Nov 2021) where my team and I created the app to help clinics manage their doctors and patients through desktop and web applications.

## 🛠️ Technologies and tools

- `C#`
- `.NET Framework 4.8`
- `ASP.NET`
- `Windows Forms`
- `Dependency Injection`
- `Database programming and planning`
- `Three-layer app`
- `Regex`
- `Unit tests`

## 💭 Creating process and app details

Before we started creating the app, my team and I created an ER diagram to help us visualize the database, table relations, and necessary columns. Then, we split our tasks so we could simulate working in a real environment and also speed up the process of creating the final app. On this project, I was mainly in charge of managing our repository, taking care of issues and pull requests, and when it came to coding I worked on creating the presentation layer on the web with ASP.NET and some little things with the desktop version.

This app was created as a three-layer app consisting of a Data Layer, Business Layer, and Presentation Layer(Desktop and Web). For our database, we used Microsoft SQL Server LocalDB as it was enough for our purposes. We also created Unite tests for all three layers and classes (Admin, Doctor, Patient).

The app is created so admins can log in to manage doctors, so they can add new doctors, update their data, and also change their working status if they leave the clinic (we implemented soft delete so we can keep doctor information even when he is no longer working there). When it comes to doctors, each doctor has an account where he can manage his patients, give them diagnoses, and check their medical history. Patients on their account have the option to manage their data, view past reports and medical history, and also calculate their BMI.

## 📸 Demo Images:

<details> 
  <summary><h3>Web App</h3></summary>

  #

![Screenshot1](https://i.ibb.co/M2wRZBD/screencapture-localhost-44363-Patient-Panel-2024-01-13-23-36-16.png)

 #

![Screenshot2](https://i.ibb.co/FK2gKDt/screencapture-localhost-44363-Patient-Management-2024-01-13-23-35-11.png)

 #

![Screenshot3](https://i.ibb.co/qW0CGj9/screencapture-localhost-44363-Doctor-Management-2024-01-13-23-32-51.png)


 #

![Screenshot4](https://i.ibb.co/ccRyR4v/image.png)

 #

![Screenshot5](https://i.ibb.co/GVycLKw/chrome-F3s-K478-X2h.png)

</details>
<details> 
  <summary><h3>Desktop App</h3></summary>

   #

![Screenshot1](https://i.ibb.co/Q6ms0jB/Presentation-Layer-Desktop-GY6-RCRb2md.png)

 #

![Screenshot2](https://i.ibb.co/6PMjntN/Presentation-Layer-Desktop-Has-BQULo-TT.png)

 #

![Screenshot3](https://i.ibb.co/NV409y3/Presentation-Layer-Desktop-n28-IWQ5y-Oz.png)

 #

![Screenshot4](https://i.ibb.co/0hGy7pF/Presentation-Layer-Desktop-s-Oyp-Y3z0el.png)

 #

![Screenshot5](https://i.ibb.co/NV409y3/Presentation-Layer-Desktop-n28-IWQ5y-Oz.png)
</details>
