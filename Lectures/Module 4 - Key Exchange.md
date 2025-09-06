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
# Diffie-Hellman (DH) Key Exchange
G -> generator / primitive root
N -> Modulus, large prime
G < N
Number set { 0 -> n-1 } module arthemtic
Client 1 pick X (random, computes (g^x) mod N = val(a)
Client 2 pick Y, computer (g^Y) mod N = val(b)
c(1) sends  val(a) to (c2)
c(2) sends val(b) to c(1)
c(1) calculates (g^y)^x
c(2) calculates (g^x)^y
Attack knows what g^x and g^y but cannot find g^(xy) as they can only calculate g^(x+y)

 a Generator is in {0 -> n-1}. G needs to traverse the whole set when taken the power Y and mod N
 G & N can be precomputed and global constants so that the major work of effort doesn't have to be duplicated. 
You cannot find x from G^X because log(g)G^x cannot be solved in a finite field, called discrete log over a finite field.

This method does not provide authentication, only allows to create a shared key.

RSA superseded DH algorithm 
DH 1024 is = 80 bit symmetric, and so its the smallest it should be taken.

# Elliptic Curve Cryptography (ECC)
Similar to DH. Gaining populator, much faster.
Abelian Groups - A set with defined operator that is commutative
Finite Abelian Group - 
Finite Fields -
Instead of taking numbers on a 1 dimensional line (0,1,2,3,4) take the numbers on a curve using  a 2d graph. y^2 = x^3 +ax +b
a and b are constant. you can take (x,y) to transform into a number.
This function generates psudo random numbers when only taken inteigers
Take two points on the curve and draw a line between them then extend that line until either end hits another part of the curve. first point should be a tangent and the other point should be 2p, you can then calculate -2p.
Its easy to add multiple and subtract using this math but its hard to divide, so its hard to reverse engineer the secrete values..
256-bit keys in ECC have the same strength as 3072-bit RSA or DH