Primarily used to speed up indexing.
Take data use a function to compress it to a small number of bits.
Collisions will occur.
# Cryptographic hashes
No collisions. collisions would create security problems. This really is just that is almost impossible to find a collision.  You should not be able to engineer a collision.
This can be refereed to as secure hash, collision resistant and collision free hashes.
# Merkle Damgard Construction
also called as compression
split data into blocks n bits wide. padding is used to make the data conformant to the n size. Padding is a fixed patern.
Take each block into a function with an initialization vector. The output of each block is fed in as init vector for the next.
Finally a finalization permeation is applied on the completed output (not in blocks).

-----------------------------------------
# MD5
Message Digest 5, 128 bit hash by Ronald Rivest  in 1992. Weaknesses discovered in 2010.
Was able to find duplicate  hash values. and they were eventually able to find a duplicate value for a given hash value. 
MD5 creates chunks of 512 bits from the input data.
Digest is often the name for the hash output.
Takes 128 bit input and breaks it into 32 bit chunks. Feed each block into md5 function.
Take 4 predetermined blocks of data (static and always used), Take all of these blocks and shift each block. except you do an xor on the first block using input (Mi 128 bits) and again xored against a constant ki and then circle shift the first block. After 64 rounds d becomes the output of the first 128 bits of the input. There are a lot more different things that are done here. This is just an overview. The first collision found was two nearly identical sequences that produced the same output. So some things caused little/no avalanche affect.
# SHA
sha1 is very similar to MD5. SHA1 produces a 20 byte output
SHA3 is the new standard. Found in a new compition and beat out MD6. Found by Guido Bertoni, Joan Daemen, and Gilles Van Assche, and Michael Peeters. Has a different internal structure then md5 and sha1.