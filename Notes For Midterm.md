
| Terms            | Explanation                                                                                                                                                                |
| ---------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Round            | Things done to a block of data for encryption, done in series to complete actions to to the whole input.                                                                   |
| S-Box            | Substitution box, a cryptographical function (hash or other) to replace some value with another                                                                            |
| P-Box            | Permutation Box - Bit shift to transpose values                                                                                                                            |
| Feistal Function | An alternative to S/PBox design where actions are done on the right side of the plain text with the key and xored against the left side, then stored as the new left side. |
| Generator        | A prime number, g, that when raised to X, and mod with N will cycle through all values of N. g^x mod N = {0...n-1}                                                         |
| Avalanch Effect  | Every act done to the input will change more than 50% of the output                                                                                                        |
| Crypto analysis  | The act of reviewing cryptographic functions to analysis weeknessses                                                                                                       |
| Steganography    | The act of disguising data in the open                                                                                                                                     |
| Key Strength     | Strength of the output of the hash represented in bits. 2^(n/2)                                                                                                            |
| Expansion        | The act of expanding a value, such as part of a key to generate new values. For example DES uses part of a key to generate round keys.                                     |
| Compression      | The act of compressing data. ie hashing                                                                                                                                    |

| Tests     | Explination                                                            |
| --------- | ---------------------------------------------------------------------- |
| Frequency | How often a value occurs in a set                                      |
| Seriel    | Looks for a series of values in a set                                  |
| Poker     | Test the independence of a subset of values (5 length) in a larger set |
| Gap       | Test the distance between values in a set or sequence                  |

Methods
* One Time Passwords - passwords generated from a shared secrete where a hash series is created
* One Time Pad - A single use key that is larger than the input
* Merkel's Key Exchange - a proof of work key is created with puzzles, each key is one use
* Diffie Helmen Key Exchange - each share g^(x or y) and keep the x or y secret. the key is g^(xy) a sniffer can only calculate g^(x+y)
* Elliptic Curve Cryptography - values on an curve are shared and calculated such that  it is impossible to reverse calculate the original points from the shared points
* RSA - public/private key encryption similar to DH
* DES - Data Encryption Standard - Symmetric key algorithm - short key length of 56 bits. Developed primarily for hardware
* MD5 - Message Digest - 128 bit hash with block sizes of 512 bit. First collision found in 2010
* AES - Advanced Encryption Standard - Block cypher, 128/192/256 key sizes with 10/12/14 rounds with an output of 128 bits. Uses key expansion to generate of round key - 4x4 matrixes of 8 bit subblocks
* SHA - Secure Hash Algorithm - SHA1 160 bit hash based on MD5. SHA2 (sha256/512), SHA-3 different from the other two
* ECB - Electronic Code Book - Based on physical code books, each block is encrypted separately 
* CBC - Cipher Block Channing - Take a block and xor with init vector and then encrypt it with a key then use that block output to xor it with the next block as the init vector.
Random numbers. Secure in 2^128 bit plus
CSPRNG - Cryptographically secure pseudorandom number generator
Co Prime Numbers - Two numbers that shore not common devisor
NIST 800-90A -  Recommendation for Random Number Generation Using Deterministic Random Bit Generators
- Hash DRGB - Keyed hash data
- HMAC DRGB - Hash-based Message Authentication Code
DRGB - Deterministic Random Bit Generator
