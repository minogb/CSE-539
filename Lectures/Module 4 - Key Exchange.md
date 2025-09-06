First solution used solved by Diffie and Hellman. Merkle was most likely first one to actually solve it.
# Merkle's
Not what is currently used.
Create a puzzle.
* Easy to create
* hard to solve
* Easy to verify correct solution
E(key, R) = x. Get people to brute force the key. The solution is the key.
Create a table containing the index, puzzle, solution, E soluction index. The final column is the encryption of the index with the solution as the key.
Client A, C(A), creates the table sends a table only with the index and puzzles to client B. C(B) chooses a puzzle and sends the solution back to C(A). C(A) looks up the solution using the encryption of the solution. The solution becomes the shared key. Eventually the key can be broken but it remains secrete for a time.
# Diffie-Hellman Key Exchange
