# PayrollProject
## General Git Workflow for Project

<ol>
	<li>Pull from master to branch</li>
		<ul>
			<li><code>git pull -r origin master</code></li>
			<li>We should always be rebasing to keep commit history clean</li>
		</ul>
	<li>Make changes on local branch</li>
	<li>Test changes</li>
	<li>Show changes and which files are currently staged</li>
		<ul>
		<li><code>git status</code></li>
		</ul>
	<li>Add changes</li>
		<ul>
			<li><code>git add file1 file2 ...</code></li> <li><code>git add .</code></li>
			<li>Second option stages all changes</li>
		</ul>
	<li>Commit changes </li>
		<ul>
		<li><code>git commit -m "descriptive message"</code></li>
		</ul>
	<li>Pull again in case master has changed</li>
		<ul>
			<li><code>git pull -r origin master</code></li>
		</ul>
	<li>Push to branch</li>
		<ul>
			<li><code>git push origin branch_name</code></li>
			<li>We should pretty much never be pushing directly to master (except at the beginning when we're setting things up)</li>
		</ul>
	<li>Submit pull request on Github when it's ready to be in master</li>
</ol>

# Links
<ul>
	<li><a href="https://medium.com/@andrewgoldis/how-to-document-source-code-responsibly-2b2f303aa525">Source Code Documentation</a></li>
	<li><a href="http://faculty.cs.niu.edu/~mcmahon/CS241/c241man/node6.html">Documentation Standards</a></li>
	<li><a href="https://github.com/git/git/blob/master/Documentation/CodingGuidelines">Git Coding Guidelines</a></li>
</ul>