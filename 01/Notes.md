## [Version Control System](https://www.atlassian.com/git/tutorials/what-is-version-control)
- We use VCSs to collaborate as a team of programmars, track changes, do code review and much more...
- This can be of 2 types
	- Distributed VCS
		- Github, BitBucket, Gitlab etc...
	- Centralized VCS
		- TFS, VSTS, SVN
- ![Version control system board work](https://github.com/Tech-Training-2021/Neosoft-dotnet/blob/main/01/Images/1VCS%20.png)
# Git
## VCS -- DVCS and CVCS
## Basic Git and commands
- `cd 'path'` -> change directory
- `cd ..` -> moves a level up
	- use arrow keys to see history of previously use commands
	- history -> gives a track of all commands you have used in the current session
- `cd ./ tab key` -> gives the auto-completion of the file/directory
- `ls` -> list all the files and directories
- `mkdir 'directory name'` -> make directory
- `touch 'file name.extension'` -> creates a file
- `git clone 'url'` -> adds the local workspace in your machine
- `git add` -> adds the file you target to add to git
- `git add -A` -> adds all the file
- `git commit -m 'message'` -> Stage changes and commit to git as a new node
- `git push` -> push changes to git server
- `git status` -> see the new tracks/ changes made in local workspace
- `git pull` -> retrieve changes from the git server (updates your workspace with latest code)
- `pwd` -> print where directory

### Demo for cloning to the repo
- `cd C:/Training`   - to navigate to a directory
- `cd cyient-locusit/`
- `git clone https://github.com/Tech-Training-2021/Cyient-locusit` - to make a local copy of the repo
- `cd Cyient-locusit/`
- `cd 01/`
 
 ### Demo to create a **Hello World** console app in [VSCode](https://code.visualstudio.com/docs/languages/dotnet)
 - navigate to respective folder using `cd <path>`
 - use command `dotnet --version` to check if .Net 6 is installed. It should return like this `6.0.100-preview.6.21355.2`
 - use command `dotnet new console -o 'HelloWorld'` to create a new console app
 - navigate to newly created HelloWorld folder `cd HelloWorld`
 - compile the code within HelloWorld folder `dotnet build`
 - run the program `dotnet run`
