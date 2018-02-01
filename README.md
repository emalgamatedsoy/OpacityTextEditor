# OpacityTextEditor

This is a small text editor that I have created in order to allow for the editing window to become opaque, such that someone who is taking
notes will be able to write while looking through the editor.
<br>
<br>
This program is designed for someone who is running a windows computer and needs to observe documents while taking notes at the same time.
<br>
<br>
For the technicalities, this program was written with the .NET framework (4.6.1) and written in c#.
<br>
<br>
I used visual studio 2017 to write this program.
<br>
<br>
<br>
Currently associated with this project, there needs to be a few changes..
<br>
<ul>
 <li>
The text editor can only handle <b>2^32 characters</b> before an overflow occurs.
For the purpose of writing this program, I wouldn't expect someone to load a text file with more than 2.4 billion characters.
 </li>
 <li>
   Adding a temp-file for each time there is a load or a save such that text document backup is made.
 </li>
 <li>
  there is no documentation on this program aside from this markdown file.
 </li>
 <li>
  inserting a "find" function, which will allow the string to be parsed to find occurences of text; highlighting text also.
 </li>
 <li>
  create label in main form that displays the file handle of the loaded file. (should be separate from main class)
 </li>
</ul>
<br>
<br>
any contribution would be appreciated by anyone who wishes to do so; I'll examine pull requests on the dev branch.
<br>
note:
<br>
<b>This is freeware, and not intended to be sold, nor re-sold.</b>

