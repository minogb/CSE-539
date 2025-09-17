Also called one way functions. Fundamentally true one way functions cannot be proved even if they cannot prove a duplicate exists
A function that takes a variable input runs it through a deterministic and creates a fixed data output. This is not reversable because the output is smaller than output. Fundamentally multiple inputs can map to the same output. In crypto this is a problem. An additional problem is that the hash functions can be reversed, the output can never represent the input.
# Birthday Attacks
If there are 23 people in a room, two people may have the same birthday, 50% of the time.
The more numbers are picked the more likely duplicates are created. This does not increases the chance of picking a chosen number twice.
Failure point should be calculated at about 50% chance not 100%
Effects hash functions. about the sqrt of N.
Given one value find another value with the same hash. This is about 2^n
Given two values find any pair of values that have the same hash. This is about 2^(n/2)

minimum of 256 to create a 128 bit strong hash to avoid this attack.

# MD5
Most common hash function is MD5, invented by Rivest. There have been other versions but they all had issues and they kept being fixed culminating in MD5, today MD5 is known to be broken and has been replaced [[#SHA]], secure hash algorithm.
Message Digest 5, 128 bit hash by Ronald Rivest  in 1992. Weaknesses discovered in 2010.
Was able to find duplicate  hash values. and they were eventually able to find a duplicate value for a given hash value. 
MD5 creates chunks of 512 bits from the input data.
Digest is often the name for the hash output.
Takes 128 bit input and breaks it into 32 bit chunks. Feed each block into md5 function.
Take 4 predetermined blocks of data (static and always used), Take all of these blocks and shift each block. except you do an xor on the first block using input (Mi 128 bits) and again xored against a constant ki and then circle shift the first block. After 64 rounds d becomes the output of the first 128 bits of the input. There are a lot more different things that are done here. This is just an overview. The first collision found was two nearly identical sequences that produced the same output. So some things caused little/no avalanche affect.
# SHA
sha1 is very similar to MD5. SHA1 produces a 20 byte output
SHA3 is the new standard. Found in a new compition and beat out MD6. Found by Guido Bertoni, Joan Daemen, and Gilles Van Assche, and Michael Peeters. Has a different internal structure then md5 and sha1.