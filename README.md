Grep
====
Requirements:

Grep should behave like <a href="http://unixhelp.ed.ac.uk/CGI/man-cgi?grep">Unix Grep</a> for the most part.

At first we'll just make it a super simple version of grep with just a few command line options.

The program...

1. Must be called grep.  It should build grep.exe.
2. Must be a CLI program.
3. -r or -R means recursive search.
4. -v means invert match.  Find things that _don't_ match this pattern.
5. -l suppress normal output and just show file names.
6. -i ignore case. 
7. Syntax should look like this:  grep <options> <pattern> <file/directory>
8. Options are optional.  Options begin with - and are 1 character. (-r,-v, -i or -l for now).
9. Pattern is required.
10. File/directory is optional, defaults to all files in current directory.  Uses regex to match when used.
11. Should output like: <file>: <matching line in file> ex: default.html: <body>

