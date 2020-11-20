API:-

PostMan-Documentation :-     https://documenter.getpostman.com/view/10028723/TVengpVv

Master Data (for populating dropdowns) 
GET 
•	/api/skill - [get list of skill groups and Data in Groups, 4 in this case (technical/business/certification/languages)] 

--> one single API request - /api/skills/:skillgroupid to fetch all skills based on skill group id parameter 
•	/api/skills/1 – [get master technical skills data] 
•	/api/skills/2 - [get master business skills data] 
•	/api/skills/3 - [get master certification skills data] 
•	/api/skills/4 - [get master language skills data] 

 
--> one single API request - /api/proficiencies/:skillgroupid to fetch all proficiencies based on skill group id parameter 
•	/api/proficiency/1 – [get technical proficiencies] 
•	/api/proficiency/2 – [get business proficiencies] 
•	/api/proficiency/3 - [get certification related proficiencies] 
•	/api/proficiency/4 - [get language proficiencies]
 
User Specific Skills 
GET 
•	/api/techskill/ - [get user’s technical skills with corresponding proficiency level] 
•	/api/busskill/  - [get user’s business skills with corresponding proficiency level] 
•	/api/certification/  - [get user’s certification skills with corresponding proficiency level] 
•	/api/language/  - [get user’s language skills with corresponding proficiency level] 

 
POST 
•	/api/techskill/ - [assign a new Technical skill]
•	/api/busskill/  - [assign a new Business skill ]
•	/api/certification/  - [assign a Certification]
•	/api/language/  - [assign a Language]
 
PUT 
•	/api/techskill/id - [Update Technical skill]
•	/api/busskill/id  - [UpdateBusiness skill ]
•	/api/certification/id  - [Update Certification]
•	/api/language/id  - [Update Language]
 
DELETE 
•	/api/techskill/id - [Delete Technical skill]
•	/api/busskill/id  - [Delete Business skill ]
•	/api/certification/id  - [Delete  Certification]
•	/api/language/id  - [Delete  Language]
