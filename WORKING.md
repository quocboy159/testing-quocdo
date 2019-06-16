# DoVanQuoc-Testing

## 1. Archivement
    a. Created a page web application that list customers and can searchable as requirement 
    b. Used these technologies as expect
    c. Checked in code to GitHub sucessfully.
    
## 2. Technologies and Architecture
    a. These technologies used in back-end including:
        + Netcore 2.1
        + LINQtoCSV
    b. These technologies used in front-end including:  
        + Vuejs 2.5
        + axios
        + Vuetify
        + Vuex (State management) => this is a bonus
    c. Architechture in back-end
        + Dependency Injection
        + CQRS => This one is help the project can make the code easy maintainable, readble, improve performance for complexity business. 
                  And it is really apply SOLID principle. As requirement, currently I only can apply a part of of CQRS, that is Query but I                   also build a fully structure for it
                  
  ## 3. Timeline
     a. Preparation: 1h
     b. Build struture: 4h
     c. Code functionality: 3h
     d. Check in Github and Testing: 1h
  
  ## 4. How to run
     a. Get code from link: https://github.com/quocboy159/testing-quocdo.git
     b. Before build you have to setup latest version Vue, .netcore 2.1 SDK
     c. After get code done, you will get 2 forders: ACME_BE(back-end), ACME_UI(front-end) 
     d. Access into ACME_BE, open CMD or Git bash and do step by step as bellow:
        + dotnet build
        + dotnet run --project ACME.API
     e. Access into ACME_UI, open CMD or Git bash and do step by step as bellow:
        + npm install
        + npm start
     h. Open browser and type http://localhost:8080
     
  ## 5. Reference link source: https://github.com/quocboy159/testing-quocdo
