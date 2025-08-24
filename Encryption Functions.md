also know as a one way trapdoor function as once executed it cannot go back, but there is a secrete trapdoor to go back.
This function is lossless as the output is not smaller then the input.
Jumble encryption, substitute cyphers, ect... how they were jumbled or subsisted is the secrete trap door. Simplistic functions like these often have correlation between the output and input.
The use of keys allow a two way encryption decryption, another thing that is not present in hash functions.
Symmetric encryption use the same key for encryption and decryption. asymmetric use a public (decryption) and private (encryption) key. For every private key there is exactly one public key.
Symmetric encryption are often ad hawk and can use any technique almost at random and don't require much number theory to design and can use things like lookup tables and often use different algorithms to encrypt and decrypt. Hard to described, easy to execute.
Asymmetric encryption are very number theory derived and are often more simple but are more computational difficult.  Easy to describe, hard toe execute.
Two kinds of symmetric encryption. Block and stream. Stream encrypts on bit at a time. Input-> (random number (key is seed)) and xored -> output. RC4 uses this.
Polyalphabetic cypher -  stream encryption
Monoalphabetic cypher - block encryption, can have repeated blocks, but because it uses blocks not single characters it is almost impossible.
# Terms
## EBC
Electronic Code Book -> mono
## CBC 
Cipher Block Changing. Input ->< key -> output. can be changed to input->key -> xor (init vector, static) -> ouput. The current round output is the init vector of the next.
## Key Strength
How much work do you have to do to brute force the key. 2^n. it is hard to prove that this is the actual strength. multiple keys that create the same output reduce the key strength.
DES is believed to be 2^56 strong despite being week to brute force. There are some known keys that are bad but this does not change the overall strength
## Avalanche effect
1 bit change in input causes a large change in the output.
1 bit change in key causes a large change in the output.
## Cryptanalyses
Find weaknesses in a cipher. at its most basic it is cipher text only, given cipher text only find the key or plain text.
Known plain text attack. Using the plain and cipher can you find the key?
Linear cryptanalysis and diff cryptanalysis the attacker chooses the plain text.
differential, keep changing the input to see if you can reverse engineer the key.
## Steganography
not cryptography this is hiding data. Great way to provide plausibility of saying there is no hidden message when combined with cryptography.
Input -> secrete algorithm -> output. 
## Block Encryption
Going from plain text to cipher using a key. Assuming Block Encryption.
Block Encryption says plaintext size is fixed (block). n bits -> encryptor -> n bits output and key has n bits. The n bit input is sacred the other things can change. Larger plain text then the input block are just feed in as blocks after the other.
Jumble -> permute. Use aa in put and move it to another part in the block using a table to lookup with a key to find the output location. The position of the bit is change d in the input before encryption
Substitute if A then put B.
These types of methods are used in symmetric cypher and are adhock.
Shannon says encryption is built on two principles confusion and diffusion. confusion is related to permutation and diffusion is related to substitution but these mappings can be differed either way.
Confusion says 1 bit of output is derived from many bits of input. The input has not direct connection to the output.
Diffusion says changing on bit of the input causes a change in 50% of the output. Small changes in the input make large changes in the output. Every bit of the input effects the output.
Permute substitute network, aes uses this, Block -> permute -> block. break the output block into smaller block. Use a table to substitute the output. That whole sequence is called a 'round'.
Feistal function/cipher take in the input for a round, divide it into two. Input R maps to the left of the output and also feeds into a function with the key. The left part is then xored with that function output and then mapped to the right part of the output. the function is a non linear feistel function, use pbox or sbox. Feistal function is used heavily in DES.
a xor b = c. a xor c = b.

Sbox = subsitution box
Pbox = permutation box
# DES
replaced by [[#AES]]
# RSA
Also known as ECC.
First known open source algorithm is DES, digital encryption standard. From NSA/NIST(IBM). Despite being the founding of modern crypto it is no longer used as it can be easily brute forced with short keys. 56 Bits
# AES
AES, advanced encryption standard replaced DES and is in use today. 128/256/512 bits.
# Ceaser cipher
is most likely the first know encryption method, from around 50bc. The alphabet is shifted by X number of character in the alphabet ie A->C is a 2 shift. The key is number of shifts.
Can be broken with brute force, at most 25 attempts.
letter frequency analysis, in English the most common letter is e. if you can find what letter is you can you find the key.
Monoalphabetic cypher, one letter is always transalated to another.
# Vigenere cipher
invented in 1553.
Take a plaintext, you take your key and use the key and input as a two axis lookup. The key is repeated to match the input.
Difficult to brute force.
Polyalphabetic cypher, one letter is not always translated to another.
Kasiski in 1863 figured out how to break it. Certain pairs of characters in cipher text. If xy is appears multiple time in the output, the length of the difference is the length of the key or a multiple. once one letter is identified the output is simply ceaser cipher.
