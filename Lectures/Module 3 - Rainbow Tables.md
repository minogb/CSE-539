Dictionary generated brute force - all possible passwords
A couple of ways of generating a dictionary are: given a hash: start generating passwords and hashes (slow, probably infeasible), or pre-generate all password and hashes (store then search). Each are Infeasible on there own.
Rainbow tables are a mix of the two. Store a subset and then use a technique to figure out how to attack passwords.
## how to build
* Start with a dictionary of candidate passwords, say 1 million
* Compute the hash 1, of the password 1 (don't store). Reverse the hash to password to password 1.2 by doing math and tables to convert the original hash to some ascii string.
* create the hash of password 1.2. keep doing this for a while. so that the width of the table is as wide as the height of the rainbow table.
* Do the above for each password.
* Store the last hash of the row above. so store pw(1) and hash(n)
* This allows us generate the trillion passwords from the stored 2 million values.
While this could result in N * n converge, in reality this generates a good amount of collisions. (for each collision it would create duplicate for up to each item remaining in the row)
## Attacking
Assume the stolen pw file stores passwords as hashes and not salted and assume the hash is not a lookup, although it could be.
Do the reversal  function on the stolen file a million times, each time checking for a lookup on the stored hashed file. If at any point you hit a value you can back-lookup the hash by recalculating the rainbow table hash passwords chain.
## Solution
Salt nearly eliminates this attack because it forces to recalculate the whole rainbow table.