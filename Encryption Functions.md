Encryption functions are two way functions where you can only get out of the trap with secrete knowledge. This has led it to be also known as the one way trapdoor, where knowledge of the secret trapdoor is required to 'escape'. This function is also require dot be lossless as such the output is always greater than or equal to the output in length. There can be many ways to create the encryption such as jumbling or substitution.
There two main ways to achieve the secret: [[#Symmetric Encryption|symmetric]] or [[#Asymmetric Encryption|asymmetric]] with a wide verify of encryption [[#Techniques]].
The strength of the cypher is measured with its key strength. Normally this is 2^n, however due to birthday attacks this is actually 2^(n/2).
# Symmetric Encryption
This method uses the same key to encrypt and decrypt values and is the most common historically. It is also easier to implement adhawk [[#Techniques]]. While simpler this also makes them faster and are often used when transmitting larger amounts of data. Symmetric can be completed with stream or block cyphers and are often initialized with [[Number Theory#CSPRNG|random value]].
# Asymmetric Encryption
This form of encryption is newer and relies on a lot of [[Number Theory]], primarily including large numbers, and prime numbers.
# Cyphers
## Polyalphabetic
Values are encrypted on at a time such as with ceaser or visionare and are considired stream cyphers.
## Monoalphabetic
block encryption, can have repeated blocks, but because it uses blocks not single characters it is almost impossible.
# Techniques
## Table
## Number Theory
## Substitution
## XOR
## EBC
Electronic Code Book -> mono
## CBC 
Cipher Block Changing.  Take the plain text and then xor it with an initialization vector. Then use a block cypher with a key to create cypher text. Every consecutive block uses the last block cipher text as the initialization vector.
## S-BOX
This is an example recipe for generating an sbox
* No output bit of an sbox should be too clos to a linear function of the input
* If l and r bits are fixed and 4 middle bits are varied, each possible 4 bit result is obtained once
* 2 inputs vary in 1 bit, output varies in 2 bits
* 2 inputs vary in 2 middle bits, the output varies in at least 2 bits
* 2 inputs are different on 1st 2bits and the same on hte last two bits, the ouput is different.
* ect....
## P-BOX
## Expansion
Feistel Function - Expansion of the 32 bit data to a 48 bit by shifting. xored with the key. compressed with an sbox and ran through a pbox.
## Contraction

# Terms

## Avalanche effect
1 bit change in input causes a large change in the output.
1 bit change in key causes a large change in the output.
## Block Encryption
Going from plain text to cipher using a key. Assuming Block Encryption.
Block Encryption says plaintext size is fixed (block). n bits -> encryptor -> n bits output and key has n bits. The n bit input is sacred the other things can change. Larger plain text then the input block are just feed in as blocks after the other.
Jumble -> permute. Use an input and move it to another part in the block using a table to lookup with a key to find the output location. The position of the bit is change d in the input before encryption
Substitute if A then put B.
These types of methods are used in symmetric cypher and are adhock.
Shannon says encryption is built on two principles confusion and diffusion. confusion is related to permutation and diffusion is related to substitution but these mappings can be differed either way.
Confusion says 1 bit of output is derived from many bits of input. The input has not direct connection to the output.
Diffusion says changing on bit of the input causes a change in 50% of the output. Small changes in the input make large changes in the output. Every bit of the input effects the output.
Permute substitute network, aes uses this, Block -> permute -> block. break the output block into smaller block. Use a table to substitute the output. That whole sequence is called a 'round'.
Feistal function/cipher take in the input for a round, divide it into two. Input R maps to the left of the output and also feeds into a function with the key. The left part is then xored with that function output and then mapped to the right part of the output. the function is a non linear feistel function, use pbox or sbox. Feistal function is used heavily in DES.
a xor b = c. a xor c = b.
## Key Scheduling
Key expansion or key scheduling, inital key expanded to many keys one per round, each 16 bits.
Rotate, shift, and rcon for each round key. each round key is done the same to get the next round key. Generates 10 for 128 bit key size, 12 rounds for 192 key size, 14 for 256 bits.
### RCON
R constant, multiplication involving a bunch of constants.
# DES
replaced by [[#AES]]
Data Encryption Standard ~ 1973 NIST issued RFP in the winner "Lucifer" by IBM Lucifer was modified by NSA to DES.
Optimized for performance on hardware.
Symmetric block Cipher. this does not destroy data.
Never been broken but was broken to brute force due to its small key size and advances in computers.
Plaintext -> initial premutation -> 16 rounds -> Final permutation -> Cipher text
Uses S-Box substitution, p-Box permutation, and Feistel Function.
NSA made some minor changes to the SBox, these changes by nsa created conspiracies that said nsa introduced by a backdoor. However no one could find the back door.
In the early 2000's people discovered a technique for differential cryptanalysis to find minor weaknesses in ciphers. This showed lucifer has weakness but des does not.
Data is broken into 64 bit blocks and each bit block is broken into two 32 bit chunks, left and right. the key is 64 bits long but each byte has a parity hence only 56 bits of the key are significant. this is called key scheduling Initial premutation is performed before the encryption rounds. Final permutation is done after all rounds.
Left is xored with the right block that has been ran through a Feistel function with a round key then stored as the next right block. Right block is set unchanged into the left block. This happens 16 times.
The round key is derived from the 56 bit key to get 16 bit sub keys. each master key can generate 16 total keys. each half of the master key is shifted left or right in a circular rotation the compressed toa 48 bit round key. 
Decipher due to the properties of xor on the right block can be used to xor the left other with the use of the key.
AES is way faster than 3DES which is the secure way to use DES. First pass with k1 to encrypt then k2 to decrypt then k3 to encrypt
## Key scheduling
Take each byte one bit is a parity bit. This was designed to detect potential errors in hardware.
# RSA
Also known as ECC. and the foundation of #PKI - public key infrastructure 
First known open source algorithm is DES, digital encryption standard. From NSA/NIST(IBM). Despite being the founding of modern crypto it is no longer used as it can be easily brute forced with short keys. 56 Bits
Rivest, Shamir, Adelman. 197, patented in 1983, public in 2000.
Asymmetric Cipher Block. at most 2048 bit blocks
No know flaws. Mathematically proven two be secure. Can be broke in if people  can factorize large primes.
1024 bit rsa keys are as strong as 80 bit symmetric keys. 2048 bit rsa recommended. RSA is slow.
Plain -> k1 encrypt -> k2 decrypt -> plaintext
k1 encryption key is usually exposed to the public. k2 decryption is stored privately. This allows everyone to talk to a single person without anyone else determining the value.
Take two large prime numbers. P and q. the composite number N
phy N = (p-1) * (q-1) euler's totient formula - 1763
N is 2048 bits
phy n is the number of numbers in 0>2^1024 that  are coprime to N.
If you can find the factor of two large primes reliably RSA is broken. But this has been known to be basically impossible.
pick an encryption key e such that e is relatively prime to phy n. public modulus.
Then search of the decryption key such that (e* d)%phy(n) = 1. needs extended Euclidian algorithm.
Now k1 = <e,N> public key for encryption.
K2 = <d,N> decryption or private key.
cipher = (m)^e % N
plain = c^d %N = (m^e)^d % N
# AES
AES, advanced encryption standard replaced DES and is in use today. 128/256/512 bits.
Advanced Encryption Standard - 2002
Symmetric block Cipher
Industry standard.  NIST standard as of 2002. Rijndael cipher by cincent rijmen and joan daemen. Uses permutation substation network. Data blocks are 128 bit, key size can be 128,192, or 256. Key sizes just changes the key scheduling. Internal state for input is: 4x4 matrix, 16 bits per entry, 128 bit total.
Optimized for performance on software.
May have an attack that will reduce the attack from 127 bits to 126 bits.
## Rounds
State - current state of the cipher text before it is cipher and after it is input.
* Add Round key
xor bits some bits of the input with some bits round key. first round only.
* Sub bytes
use s-boxes to transform. Take the input and use a s-table to generate the next state.
* Shift rows
shift rows of state.
* Mix columns
Use formulas to replace columns. Complex matrix algorithm. A column is a column of the 4x4 matrix.
* Add round key
xor bits of round key. first round only

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
# OTP
One time pad
Only unconditionally secure cipher.
Plaintext, choose a key, where the length of the key is equal to the length of plain text. Make sure the key is random. Do a bit wise xor to create a cipher.
This is not practical the recipient must have the key, but the key must be generated with each message. The key cannot be reused.
If you send out a whole bunch of pads out with them. Then each time they receive a message they just cycle through the pad. Was use in ships for ww2.
If you repeat the key to cypher say two blocks p1 and p2 the output c1 and c2 xored together are equal to p1 xor p2.
# RC-4
Rivest Cipher - 4
Stream Cipher
Has problems, stream cipher is out of fashion. Retired in 2015.
Key size of 40-2048 bits.
It has a random number generator to xor plain text to create an output stream.
It has an internal state then it shuffles the internal 256 bytes state. Parts of the key are mashed into the initial key state. The randomness of the output of the state relies on the randomness of the key. There are additional actions performed to ensure its crytp randomness.
* Step 1: KSA - key scheduling algorithm, the key is mixed with an internal 2048 bit state (256 bytes)
* Step 2: PRGA - Pseudo random generation algorithm that produces a large number of random 8 bit numbers.
Used in WEP, WPA, BitTorrent, PDF, ect... Banned for SSL/TLS (was used in the early days). FTP never used RC-4 and instead uses ssl.
# KSA
S is an array of bytes
~~~
for i 0 -> 255 {
 s[i] = i
}
for i 0 -> 255{
	j = (j+s[i] + key[i % keylenght]) % 256
	swap values of s[i] and s[j]
}
~~~
# PRGA
S is an array of bytes and it generates byte, 8 bits at a time.
```
while generating{
	i = (i+1)%256
	j = (j+s[i])%256
	swap s[i] and s[j]
	output << s[s(s[i]+s[j])%256]
}
```