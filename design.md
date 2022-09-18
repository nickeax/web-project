OVERVIEW
From a single command line entry, create directory structure and all base files and linkage for a Web project.

REQUIREMENTS

- The command line argument string will need to represent any required directory structure
- Listed files will be created and placed in the specified folders

FEATURES
A command line interface will be used to describe the file structure and associated files.

- Directory structure
- Files
- JavaScript Classes

List the required directory structure first, then the file names that go into each folder:
\$ web-project DIR|

NESTED FOLDER CREATION (from command line arguments)

- Folders will be listed in order of dependency with their parent folder preceding
- The folders section of the command line argument will begin with DIR and end with the pipe character
- Files will be listed with their required name and their parent folder.
  \$ web-project PROJECT_NAME DIR^root-index.html^root-src-js^

USE CASES
I wish to create a simple Web project that consists of an index.html, index.css, index.js and a .gitignore file. The folder structure will be as follows:
index.html

CONSTRUCTING PROJECTS
[WebProject] : [Project]
- The [WebProject] will be the default project type and only one implemented to begin with.
- A WebProject will have consist of [index.html], [index.css], [index.js] and [.gitignore]
- The directory structure will be:
  ROOT
  - index.html
  - .gitignore
    SRC
  - JS
  - - index.js
  - CSS
  - - index.js

[WebProject]
[HTMLFile]
 - Links <- List of string
 - Style <- List of string
