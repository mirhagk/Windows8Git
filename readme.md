Windows 8 Git Client
===

This project is the source repository for the windows 8 git client. This app will be a windows 8 app that will try to enable as many git commands as possible using a visual interface, similar to the Github for windows client. It may include a command line tool as well. The core of this project is the git client, which uses [libgit2sharp](https://github.com/libgit2/libgit2sharp/wiki) to perform all the git commands.

Current State
---

This application is currently in the early development/planning stages. The app has not been released, and won't be released until it reaches version 0.5 (it will be released as a beta then). Then once 1.0 is released, the core features will have been implemented and the full version will be released. The plan is to have 0.5 be enough to use it to develop this repository.

Plan
---

The current released version is in bold, and the current development version is in italics.

* *Version 0.1* - Supports creating and viewing the list of local repositories
* Version 0.2 - Supports viewing the history of commits and creating a commit
* Version 0.3 - Supports connecting to a remote repository (github is the focus)
* Version 0.4 - Supports pushing and pulling between a local and remote repository
* Version 0.5 - Supports "sync" button that works much like Github for windows client
* Version 0.6 - Supports navigating through the repository, being able to open files to edit them (using an external editor)
* Version 0.7 - Supports branches
* Version 0.8 - Shows differences between files in commit history and since the last commit
* Version 0.9 - Supports executing basic git commands through a command line-like interface.
* Version 1.0 - Supports settings, setting global gitignore files, default gitignore/gitattribute files, etc