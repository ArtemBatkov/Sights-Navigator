# <p align="center">Sight Navigator</p>
## &emsp;**Description** 
#### &emsp;City Navigator app is a product that can help people to find some sights in the exact city, select them and add them to their favorite list.  

<br>

## &emsp;**Technologies**
#### &emsp;The app is focused on cross-platform development. To build it, .NET MAUI was selected as for designing tool. The framework allows you to create a code once and then apply it to many OS like Windows, Android, iOS, and Mac. 

<br>

## &emsp;**Challanges**
#### &emsp;The project uses an open-source API called OpenTripMap API that was selected as an engine for sights searching. The API works unstable, it has many unstructured data while parsing JSON, and it also has many time request restrictions, but it is a free API. Overall, it is not the best choice to apply such API to this idea.
The second API is used here Google Places API, and it is used for fetching some images of cities that were added to the favorite list.

<br>

## &emsp;**APK** 
#### &emsp;You can download the .apk and install the on your machine by following the <a href="https://drive.google.com/file/d/1gZZJQyTuSPUTk_wZHfXu9WeWS2SLO9bz/view?usp=sharing">link</a>.

<br>

##  &emsp;**How it works**

<div align="center">

 ![MainPage](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/487898c0-8e2c-4980-be8e-f21c8c1f06c9) 
<br>
Screenshot 1 -- The MainPage represents the initial page of the app. It contains the query string, button search and navigation to the "Trip" page.
<br><br>

![MainPage in details](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/487898c0-8e2c-4980-be8e-f21c8c1f06c9)
<br>
Screenshot 2 -- MainPage marker attributes
<br><br>

 ![MainPage searching](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/f2828960-9a63-4934-b989-a6b6ae959213)
<br>
Screenshot 3 -- MainPage, search has started
<br><br>
 
 ![MainPage search results](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/0d838845-804c-4231-ab19-8997e5c154d7)
<br>
Screenshot 4 -- MainPage, sight list has been found. If a sight doesn't keep an image it will be replaced by the default sight image (photo #2)
<br><br>

![MainPage load more](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/11963efc-b53d-4771-ba6d-829455d46c59)
<br>
Screenshot 5 -- MainPage, "LoadMore" button appears when the page reaches the end, and it allows users to download more sights if they exist.  
<br><br>

![MainPage load more action](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/5217b962-0ff0-4e8c-afaa-93b8c8eb69cc)
<br>
Screenshot 6 -- MainPage, "LoadMore" shows the process is executing now.  
<br><br>


![DetailedPage 1](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/7924497d-2e8a-42f6-be0d-ea06515f62ad)
<br>
Screenshot 7 -- Detailed Page. When a sight is selected, Detailed Page pops up, and shows all possible information related to the sight: Title, Image, Description.  
<br><br>

![DetailedPage 2](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/bd338192-1e01-4fb4-bcf3-053a3574b9fb)
<br>
Screenshot 8 -- Detailed Page. Here, the sight can be added to the favorites list by pressing "heart" button. Now it has unactive state.
<br><br>
 
![DetailedPage 3](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/9b00fb1e-1d0b-401a-af02-f0170501ed2f)
<br>
Screenshot 9 -- Detailed Page. When "heart" button is read that indecated the sight was successfully added to the trip list.
<br><br>
 
 ![MainPage problems and issues](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/ddad1b5f-38a8-4bcb-9a7e-d27f9c584a41)
<br>
Screenshot 10 -- MainPage, some of the sights can't contain an image or title. This example doesn't have both of them. However, it is fine because it was discussed on "OpenTripMap" documentation.
<br><br>
 
 ![Trip Page 1](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/05bec8dd-f967-4bf1-860a-3b18ab5cb309)
<br>
Screenshot 11 -- From MainPage to Trip navigation Page.
<br><br>
 
 ![Trip Page 2](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/d5b29f02-ea02-4630-a193-db7511e48bf5)
<br>
Screenshot 12 -- Trip Page. Here is a list of cities that contain some favorite places. Now it keeps 2 cities: Toronto and Vancouver.
<br><br>
 
  ![Trip Detailed Page 1](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/da3ac0ea-f6a4-4c68-8812-e40c23b15d6f)
<br>
Screenshot 13 -- Trip Detailed Page. Inside of the Trip Detailed Page a list of favorite sights can be seen. Also, the page sets the current background for this city. Here can be found a church that was added before. 
<br><br>
 
 ![Trip Detailed Page 2](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/2b172de8-50fc-44ed-9edf-c130ca36f08f)
<br>
Screenshot 14 -- Trip Detailed Page. When a favorite sight is selected, it navigates to the Detailed Page. 
<br><br>
 
  ![Trip Detailed Page 2](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/b86260ae-fa7d-480f-a483-a39fad7b860f)
<br>
Screenshot 15 -- Trip Detailed Page pushes to Detailed Page. Here, the sight can be unselected if it is reuired.
<br><br>
 
![Trip Detailed Page 3](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/cfe61721-74e2-482e-9c40-be6b6d18af6b)
<br>
Screenshot 17 -- Unselect our sight and go back.
<br><br>
 
 ![Trip Detailed Page 4](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/84a14685-6b4f-4309-b528-668735ec4d6c)
<br>
Screenshot 18 -- Trip Detailed Page. Now the sight was removed from the list.
<br><br>

 
  ![Trip Detailed Page 5](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/080f03d3-fe3f-48d8-a5eb-10fa3815afaa)
<br>
Screenshot 19 -- Click on "Edit" to change the background if it is possible for the city. 
<br><br>
 
   ![Trip Edit Page](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/633e850d-5821-4e96-9917-db61232df7b9)
<br>
Screenshot 20 -- Trip Edit Page. There is a list of possible backgrounds related to this city. Only one can be picked and all changes will be applied for the city.
<br><br>
 
 
![Trip Edit Page](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/58e96bb3-59ae-438c-8ef2-29fdcd1f5ea7)
<br>
Screenshot 21 -- Trip Detailed Page. The background has changed.
<br><br>
 
 ![Trip Page](https://github.com/ArtemBatkov/Sights-Navigator/assets/110242091/eda21af2-7c4f-436f-91f6-7219625337ab)
<br>
Screenshot 21 -- Trip Page. The avatar has changed.
<br><br>
 

 
</div>

 I am considering implementing an update for my application that will allow users to save a list of cities, which will be remembered when the app is relaunched.
 


<br>

## &emsp;**Conclusion** 
#### 
 
  &emsp;The app showcases my proficiency in coding and architectural design, highlighting my ability to make informed decisions when selecting and researching API documentation. Throughout this project, I gained valuable experience in handling service restrictions and further deepened my understanding of Dependency Injection.
  
  
  &emsp;While the app is a testament to my skills, it's important to note that users may encounter certain inconveniences. Specifically, the current version lacks font size adaptation functionality, making it less optimal for non-standard font sizes. We recognize the significance of font size adaptability and its impact on the overall user experience. As we move forward, we are committed to prioritizing the implementation of font size adaptation techniques in our future projects. This will ensure optimal readability across different devices and font settings, enhancing the overall user satisfaction.
  
  &emsp;Additionally, I intend to make the app open source and potentially publish it on the Play Market in the future. By sharing the code with the developer community, I hope to contribute to the collective knowledge and foster collaboration among fellow developers.
  
  &emsp;In conclusion, this project has been a valuable learning experience, allowing me to hone my skills and uncover areas for improvement. By addressing the font size adaptability issue and exploring opportunities for further development, I aim to create even more user-friendly and robust applications in the future.
 
