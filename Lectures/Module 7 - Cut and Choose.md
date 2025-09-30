# Blind Signatures
Normally two rules when signing
* should not sign anything sent and return it
* Perturb the input
Bind signatures ignore this. The signer should not know what they are signing. They are sent a hash and sign it.
Here is how it can be done 'securely'
Steps:
- Client sends value to signer (as a blind value)
- The signer then signs it and returns the signatures
- The client then appends the signed blinded value to the actual doc effectively deblinding it.
Client generates random R signs r with signers public key then multiplies the original document with the publicly signed R (mod N).
The client sends this new value to the signer. The signer then signs this value aka returns a
Eprivate (document * Epublic(R))

Because signatures are exponents
Document * R ^ e (public key) is signed and becomes
(Document * R ^ e) ^ d (private key) which is mathematically the same as
(document ^ d) * r
The client can then divide by r to get the signed document aka document ^ d


*note this still should not be done*

# Anonymous Money Order
A normal electric money order as discussed before can be made anonymous by creating a blind signature on the document request itself so that only the bank can decode the information about the transfer.

# Cut & Choose
take a cake, divide it into too and then the other person chooses what side of the cake to keep.
- In the money order order instead of putting a serial number put a random number as an 'id string' 
- Then the client blinds it using another random number generated also unique for each money order
- The client generates 100 of these and sends them all to the bank
- Then the bank picks one of the many orders requested. and then requests the blinding factor for all other money orders. The bank will then verify all other 99 money orders
- This ensures the blinded document is valid as it is improbable that the client cheated only that one document and didn't get caught

# Graph Isomorphism and Zero Knowledge Proofs
lookup information on Ali Baba's Cave (proof)
 what is a graph isomorphism? how do you know two graphs are the same thing?
 Cube Connected Cycle ie Hypercube are two graphs that are different but are the same thing
 Isomorphic = identical
 Representation can be imagined via an adjacency matrix (doesn't map order information)
 How to prove the are the same without providing correspondence which is the secrete information.
 How to know the two are the same with zero knowledge of the graphs
Take the adjacency matrix then give the graph G0 that is isomorphic to A and B.
ie give the new adjacency matrix that is permuted differently
Then the tester takes a or b and demands the client that the chosen one can map to G0. this gives a 50% chance of succeeding
Repeat the above step for for the G0->Gn
# FFS Proof of Identity
Feige-Fiat-Shamir
Peggy has a private identity S and a public identity Y {(y= (S^2 mod n)),n}
Peggy generates R, sends R^ to victor and he has Y that is S^2
Victor sends p 0 or 1 to Peggy if 0 Peggy sends R if 1 Peggy sends S * R
Victor and comput (SR)^2 which = S^2 * R^ 2 and victory can then device R^ 2 and sqroot the result to get S
If victory always sends R the imposter can create a random number that satisfies R^2 / S^ 2 all of which is public information. R = square root of (R^2 * s^2)
# Oblivious Transfer
how to transfer secret without the transferer not know what secret was transferred
Bob sends exponent, mod (p* q), and encryption of the secrete
Quadratic residue theory - using modulus math the square root of 1 with mod 15 is: 1,4,11,14. The last number is N - the first sqrt. one is srqroot with p where the mod result is 1 then add one the other is one is srqroot with q where the mod result is 1 then add one. thus 4 sqroots
Alice sends to bob x^2, x is random
bob finds 4 sqroots of x^ 2. which is either +a or -a one of these is X if alice. do this again for b. alic can factorize N.

1 of 2 transfer
Bob generates 2 key pairs: k11,k12 and k21, k22
Bob sends K11 and k21
Alice picks r and a key, (k11) encrypts and sends to bob
Bob decrypts x with k12 and k22 resulting in r and r'
Bob encrypts S1 and S2 using R and R1 then sends both
Alice decrypts both with R.
Alice doesn't know which one is the secret